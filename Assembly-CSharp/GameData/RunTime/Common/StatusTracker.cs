using System;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.Singletons;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x0200022C RID: 556
	public class StatusTracker : Singleton<StatusTracker>
	{
		// Token: 0x060041F9 RID: 16889 RVA: 0x00180494 File Offset: 0x0017E694
		// Note: this type is marked as 'beforefieldinit'.
		static StatusTracker()
		{
			Il2CppClassPointerStore<StatusTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "StatusTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr);
			StatusTracker.NativeFieldInfoPtr_buffedSpringPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "buffedSpringPartners");
			StatusTracker.NativeFieldInfoPtr_bussinessBeverageConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "bussinessBeverageConsumes");
			StatusTracker.NativeFieldInfoPtr_bussinessFoodConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "bussinessFoodConsumes");
			StatusTracker.NativeFieldInfoPtr_bussinessIngredientConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "bussinessIngredientConsumes");
			StatusTracker.NativeFieldInfoPtr_hasChatNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "hasChatNPC");
			StatusTracker.NativeFieldInfoPtr_hasInitializedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "hasInitializedComponent");
			StatusTracker.NativeFieldInfoPtr_hasRequestedBeveragesNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "hasRequestedBeveragesNPC");
			StatusTracker.NativeFieldInfoPtr_hasRequestedIngredientsNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "hasRequestedIngredientsNPC");
			StatusTracker.NativeFieldInfoPtr_hasTemptInviteNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "hasTemptInviteNPC");
			StatusTracker.NativeFieldInfoPtr_invalidFoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "invalidFoods");
			StatusTracker.NativeFieldInfoPtr_missionBeverageConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "missionBeverageConsumes");
			StatusTracker.NativeFieldInfoPtr_missionFoodConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "missionFoodConsumes");
			StatusTracker.NativeFieldInfoPtr_missionIngredientConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "missionIngredientConsumes");
			StatusTracker.NativeFieldInfoPtr_partners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "partners");
			StatusTracker.NativeFieldInfoPtr_processingCommissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "processingCommissions");
			StatusTracker.NativeFieldInfoPtr__MissionIncome_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<MissionIncome>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__BussinessIncome_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<BussinessIncome>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__Fee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<Fee>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__MissionExpense_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<MissionExpense>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__ShoppingExpense_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<ShoppingExpense>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__DebtExpense_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<DebtExpense>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__PartnerExpense_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<PartnerExpense>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__PerformanceCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<PerformanceCount>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__PerformanceSucceededCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<PerformanceSucceededCount>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__PerformanceFullComboCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<PerformanceFullComboCount>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__SuccessRiceBallCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<SuccessRiceBallCount>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__GainExperience_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<GainExperience>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__MaxCombo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<MaxCombo>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__MaxPassion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<MaxPassion>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__Visitors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<Visitors>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__NormalGuestReception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<NormalGuestReception>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__SpecialGuestReception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<SpecialGuestReception>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__PositiveSkillTriggered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<PositiveSkillTriggered>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__NegativeSkillTriggered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<NegativeSkillTriggered>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__InvitedGuests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<InvitedGuests>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__IgnoredGuests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<IgnoredGuests>k__BackingField");
			StatusTracker.NativeFieldInfoPtr__CleanWorkSessionTracking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<CleanWorkSessionTracking>k__BackingField");
			StatusTracker.NativeMethodInfoPtr_get_MissionIncome_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675874);
			StatusTracker.NativeMethodInfoPtr_set_MissionIncome_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675875);
			StatusTracker.NativeMethodInfoPtr_get_BussinessIncome_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675876);
			StatusTracker.NativeMethodInfoPtr_set_BussinessIncome_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675877);
			StatusTracker.NativeMethodInfoPtr_get_Fee_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675878);
			StatusTracker.NativeMethodInfoPtr_set_Fee_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675879);
			StatusTracker.NativeMethodInfoPtr_get_NetProfit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675880);
			StatusTracker.NativeMethodInfoPtr_get_MissionExpense_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675881);
			StatusTracker.NativeMethodInfoPtr_set_MissionExpense_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675882);
			StatusTracker.NativeMethodInfoPtr_get_ShoppingExpense_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675883);
			StatusTracker.NativeMethodInfoPtr_set_ShoppingExpense_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675884);
			StatusTracker.NativeMethodInfoPtr_get_DebtExpense_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675885);
			StatusTracker.NativeMethodInfoPtr_set_DebtExpense_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675886);
			StatusTracker.NativeMethodInfoPtr_get_PartnerExpense_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675887);
			StatusTracker.NativeMethodInfoPtr_set_PartnerExpense_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675888);
			StatusTracker.NativeMethodInfoPtr_get_PerformanceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675889);
			StatusTracker.NativeMethodInfoPtr_set_PerformanceCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675890);
			StatusTracker.NativeMethodInfoPtr_get_PerformanceSucceededCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675891);
			StatusTracker.NativeMethodInfoPtr_set_PerformanceSucceededCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675892);
			StatusTracker.NativeMethodInfoPtr_get_PerformanceFullComboCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675893);
			StatusTracker.NativeMethodInfoPtr_set_PerformanceFullComboCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675894);
			StatusTracker.NativeMethodInfoPtr_get_SuccessRiceBallCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675895);
			StatusTracker.NativeMethodInfoPtr_set_SuccessRiceBallCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675896);
			StatusTracker.NativeMethodInfoPtr_get_BussinessFoodConsumesValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675897);
			StatusTracker.NativeMethodInfoPtr_get_BussinessBeverageConsumesValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675898);
			StatusTracker.NativeMethodInfoPtr_get_BussinessIngredientsConsumesValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675899);
			StatusTracker.NativeMethodInfoPtr_get_BussinessFoodConsumes_Public_get_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675900);
			StatusTracker.NativeMethodInfoPtr_get_BussinessBeverageConsumes_Public_get_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675901);
			StatusTracker.NativeMethodInfoPtr_get_MissionIngredientsConsumesValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675902);
			StatusTracker.NativeMethodInfoPtr_get_MissionFoodConsumesValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675903);
			StatusTracker.NativeMethodInfoPtr_get_MissionBeverageConsumesValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675904);
			StatusTracker.NativeMethodInfoPtr_get_MissionIngredientConsumes_Public_get_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675905);
			StatusTracker.NativeMethodInfoPtr_get_MissionFoodConsumes_Public_get_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675906);
			StatusTracker.NativeMethodInfoPtr_get_MissionBeverageConsumes_Public_get_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675907);
			StatusTracker.NativeMethodInfoPtr_get_InvalidFoodsValue_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675908);
			StatusTracker.NativeMethodInfoPtr_get_InvalidFoods_Public_get_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675909);
			StatusTracker.NativeMethodInfoPtr_get_GainExperience_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675910);
			StatusTracker.NativeMethodInfoPtr_set_GainExperience_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675911);
			StatusTracker.NativeMethodInfoPtr_get_MaxCombo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675912);
			StatusTracker.NativeMethodInfoPtr_set_MaxCombo_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675913);
			StatusTracker.NativeMethodInfoPtr_get_MaxPassion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675914);
			StatusTracker.NativeMethodInfoPtr_set_MaxPassion_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675915);
			StatusTracker.NativeMethodInfoPtr_get_Visitors_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675916);
			StatusTracker.NativeMethodInfoPtr_set_Visitors_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675917);
			StatusTracker.NativeMethodInfoPtr_get_NormalGuestReception_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675918);
			StatusTracker.NativeMethodInfoPtr_set_NormalGuestReception_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675919);
			StatusTracker.NativeMethodInfoPtr_get_SpecialGuestReception_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675920);
			StatusTracker.NativeMethodInfoPtr_set_SpecialGuestReception_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675921);
			StatusTracker.NativeMethodInfoPtr_get_PositiveSkillTriggered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675922);
			StatusTracker.NativeMethodInfoPtr_set_PositiveSkillTriggered_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675923);
			StatusTracker.NativeMethodInfoPtr_get_NegativeSkillTriggered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675924);
			StatusTracker.NativeMethodInfoPtr_set_NegativeSkillTriggered_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675925);
			StatusTracker.NativeMethodInfoPtr_get_InvitedGuests_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675926);
			StatusTracker.NativeMethodInfoPtr_get_IgnoredGuests_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675927);
			StatusTracker.NativeMethodInfoPtr_get_CleanWorkSessionTracking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675928);
			StatusTracker.NativeMethodInfoPtr_set_CleanWorkSessionTracking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675929);
			StatusTracker.NativeMethodInfoPtr_UpdateMissionIncome_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675930);
			StatusTracker.NativeMethodInfoPtr_SetBussinessIncome_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675931);
			StatusTracker.NativeMethodInfoPtr_SetPartnerExpense_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675932);
			StatusTracker.NativeMethodInfoPtr_AddFee_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675933);
			StatusTracker.NativeMethodInfoPtr_UpdateMissionExpense_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675934);
			StatusTracker.NativeMethodInfoPtr_UpdateShoppingExpense_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675935);
			StatusTracker.NativeMethodInfoPtr_UpdateDebtExpense_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675936);
			StatusTracker.NativeMethodInfoPtr_AddPerformanceCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675937);
			StatusTracker.NativeMethodInfoPtr_AddPerformanceSucceedCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675938);
			StatusTracker.NativeMethodInfoPtr_AddPerformanceFullComboCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675939);
			StatusTracker.NativeMethodInfoPtr_AddBussinessFoodConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675940);
			StatusTracker.NativeMethodInfoPtr_AddBussinessBeverageConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675941);
			StatusTracker.NativeMethodInfoPtr_DeductBussinessBeverageConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675942);
			StatusTracker.NativeMethodInfoPtr_AddBussinessIngredientConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675943);
			StatusTracker.NativeMethodInfoPtr_AddMissionIngredientConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675944);
			StatusTracker.NativeMethodInfoPtr_AddMissionFoodConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675945);
			StatusTracker.NativeMethodInfoPtr_AddMissionBeverageConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675946);
			StatusTracker.NativeMethodInfoPtr_AddInvalidConsumes_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675947);
			StatusTracker.NativeMethodInfoPtr_AddInvalidConsumes_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675948);
			StatusTracker.NativeMethodInfoPtr_CleanInValidConsumes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675949);
			StatusTracker.NativeMethodInfoPtr_UpdateExperience_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675950);
			StatusTracker.NativeMethodInfoPtr_UpdateMaxCombo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675951);
			StatusTracker.NativeMethodInfoPtr_UpdateMaxPassion_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675952);
			StatusTracker.NativeMethodInfoPtr_UpdateVisitors_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675953);
			StatusTracker.NativeMethodInfoPtr_RecordNormalGuestReception_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675954);
			StatusTracker.NativeMethodInfoPtr_RecordSpecialGuestReception_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675955);
			StatusTracker.NativeMethodInfoPtr_UpdatePositiveSkillTriggerAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675956);
			StatusTracker.NativeMethodInfoPtr_UpdateNegativeSkillTriggerAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675957);
			StatusTracker.NativeMethodInfoPtr_UpdateSucceededRiceBallAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675958);
			StatusTracker.NativeMethodInfoPtr_RecordInvitedGuest_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675959);
			StatusTracker.NativeMethodInfoPtr_RepeatRecordInvitedGuest_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675960);
			StatusTracker.NativeMethodInfoPtr_RecordIgnoredGuest_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675961);
			StatusTracker.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675962);
			StatusTracker.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675963);
			StatusTracker.NativeMethodInfoPtr_HasNPCInvited_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675964);
			StatusTracker.NativeMethodInfoPtr_RecordCommission_Public_Void_String_DialogPackage_IEnumerable_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675965);
			StatusTracker.NativeMethodInfoPtr_HasCommission_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675966);
			StatusTracker.NativeMethodInfoPtr_ReceiveCommissionsAsync_Public_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675967);
			StatusTracker.NativeMethodInfoPtr_RecordChatNPCLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675968);
			StatusTracker.NativeMethodInfoPtr_HasNPCChat_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675969);
			StatusTracker.NativeMethodInfoPtr_RecordTemptInviteNPCLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675970);
			StatusTracker.NativeMethodInfoPtr_HasTemptInvited_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675971);
			StatusTracker.NativeMethodInfoPtr_RecordRequestIngredientNPCLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675972);
			StatusTracker.NativeMethodInfoPtr_HasIngredientRequested_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675973);
			StatusTracker.NativeMethodInfoPtr_RecordRequestBeverageNPCLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675974);
			StatusTracker.NativeMethodInfoPtr_HasBeverageRequested_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675975);
			StatusTracker.NativeMethodInfoPtr_AddToPartner_Public_Void_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675976);
			StatusTracker.NativeMethodInfoPtr_AddToPartner_Public_Void_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675977);
			StatusTracker.NativeMethodInfoPtr_CleanPartner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675978);
			StatusTracker.NativeMethodInfoPtr_GetPartners_Public_IEnumerable_1_ValueTuple_2_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675979);
			StatusTracker.NativeMethodInfoPtr_AddPartnerEnjoySpring_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675980);
			StatusTracker.NativeMethodInfoPtr_HasPartnerEnjoySpring_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675981);
			StatusTracker.NativeMethodInfoPtr_GetComponentNum_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675982);
			StatusTracker.NativeMethodInfoPtr_IncreaseComponentNum_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675983);
			StatusTracker.NativeMethodInfoPtr_ClearComponentNum_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675984);
			StatusTracker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675985);
			StatusTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, 100675986);
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x0018107C File Offset: 0x0017F27C
		// (set) Token: 0x060041FB RID: 16891 RVA: 0x001810B8 File Offset: 0x0017F2B8
		public unsafe int MissionIncome
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionIncome_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_MissionIncome_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x001810F8 File Offset: 0x0017F2F8
		// (set) Token: 0x060041FD RID: 16893 RVA: 0x00181134 File Offset: 0x0017F334
		public unsafe int BussinessIncome
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_BussinessIncome_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166417, RefRangeEnd = 166418, XrefRangeStart = 166417, XrefRangeEnd = 166417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_BussinessIncome_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x00181174 File Offset: 0x0017F374
		// (set) Token: 0x060041FF RID: 16895 RVA: 0x001811B0 File Offset: 0x0017F3B0
		public unsafe int Fee
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 49194, RefRangeEnd = 49208, XrefRangeStart = 49194, XrefRangeEnd = 49208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_Fee_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_Fee_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x001811F0 File Offset: 0x0017F3F0
		public unsafe int NetProfit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166418, RefRangeEnd = 166419, XrefRangeStart = 166418, XrefRangeEnd = 166418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_NetProfit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x0018122C File Offset: 0x0017F42C
		// (set) Token: 0x06004202 RID: 16898 RVA: 0x00181268 File Offset: 0x0017F468
		public unsafe int MissionExpense
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionExpense_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_MissionExpense_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x001812A8 File Offset: 0x0017F4A8
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x001812E4 File Offset: 0x0017F4E4
		public unsafe int ShoppingExpense
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_ShoppingExpense_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_ShoppingExpense_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x00181324 File Offset: 0x0017F524
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x00181360 File Offset: 0x0017F560
		public unsafe int DebtExpense
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_DebtExpense_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 103831, RefRangeEnd = 103833, XrefRangeStart = 103831, XrefRangeEnd = 103833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_DebtExpense_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x001813A0 File Offset: 0x0017F5A0
		// (set) Token: 0x06004208 RID: 16904 RVA: 0x001813DC File Offset: 0x0017F5DC
		public unsafe int PartnerExpense
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30554, RefRangeEnd = 30555, XrefRangeStart = 30554, XrefRangeEnd = 30555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_PartnerExpense_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_PartnerExpense_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x0018141C File Offset: 0x0017F61C
		// (set) Token: 0x0600420A RID: 16906 RVA: 0x00181458 File Offset: 0x0017F658
		public unsafe int PerformanceCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49210, RefRangeEnd = 49211, XrefRangeStart = 49210, XrefRangeEnd = 49211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_PerformanceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_PerformanceCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x00181498 File Offset: 0x0017F698
		// (set) Token: 0x0600420C RID: 16908 RVA: 0x001814D4 File Offset: 0x0017F6D4
		public unsafe int PerformanceSucceededCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_PerformanceSucceededCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_PerformanceSucceededCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x00181514 File Offset: 0x0017F714
		// (set) Token: 0x0600420E RID: 16910 RVA: 0x00181550 File Offset: 0x0017F750
		public unsafe int PerformanceFullComboCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_PerformanceFullComboCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_PerformanceFullComboCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x00181590 File Offset: 0x0017F790
		// (set) Token: 0x06004210 RID: 16912 RVA: 0x001815CC File Offset: 0x0017F7CC
		public unsafe int SuccessRiceBallCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_SuccessRiceBallCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_SuccessRiceBallCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x0018160C File Offset: 0x0017F80C
		public unsafe IEnumerable<int> BussinessFoodConsumesValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_BussinessFoodConsumesValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x0018164C File Offset: 0x0017F84C
		public unsafe IEnumerable<int> BussinessBeverageConsumesValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_BussinessBeverageConsumesValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x0018168C File Offset: 0x0017F88C
		public unsafe IEnumerable<int> BussinessIngredientsConsumesValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_BussinessIngredientsConsumesValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x001816CC File Offset: 0x0017F8CC
		public unsafe IEnumerable<Sprite> BussinessFoodConsumes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166419, XrefRangeEnd = 166438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_BussinessFoodConsumes_Public_get_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x0018170C File Offset: 0x0017F90C
		public unsafe IEnumerable<Sprite> BussinessBeverageConsumes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166438, XrefRangeEnd = 166457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_BussinessBeverageConsumes_Public_get_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x0018174C File Offset: 0x0017F94C
		public unsafe IEnumerable<int> MissionIngredientsConsumesValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionIngredientsConsumesValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x0018178C File Offset: 0x0017F98C
		public unsafe IEnumerable<int> MissionFoodConsumesValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionFoodConsumesValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x001817CC File Offset: 0x0017F9CC
		public unsafe IEnumerable<int> MissionBeverageConsumesValue
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionBeverageConsumesValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x0018180C File Offset: 0x0017FA0C
		public unsafe IEnumerable<Sprite> MissionIngredientConsumes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166457, XrefRangeEnd = 166476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionIngredientConsumes_Public_get_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x0018184C File Offset: 0x0017FA4C
		public unsafe IEnumerable<Sprite> MissionFoodConsumes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166476, XrefRangeEnd = 166495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionFoodConsumes_Public_get_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x0018188C File Offset: 0x0017FA8C
		public unsafe IEnumerable<Sprite> MissionBeverageConsumes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166495, XrefRangeEnd = 166514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MissionBeverageConsumes_Public_get_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x001818CC File Offset: 0x0017FACC
		public unsafe IEnumerable<int> InvalidFoodsValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_InvalidFoodsValue_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x0018190C File Offset: 0x0017FB0C
		public unsafe IEnumerable<Sprite> InvalidFoods
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166533, RefRangeEnd = 166534, XrefRangeStart = 166514, XrefRangeEnd = 166533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_InvalidFoods_Public_get_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x0018194C File Offset: 0x0017FB4C
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x00181988 File Offset: 0x0017FB88
		public unsafe int GainExperience
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_GainExperience_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_GainExperience_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x001819C8 File Offset: 0x0017FBC8
		// (set) Token: 0x06004221 RID: 16929 RVA: 0x00181A04 File Offset: 0x0017FC04
		public unsafe int MaxCombo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MaxCombo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_MaxCombo_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x00181A44 File Offset: 0x0017FC44
		// (set) Token: 0x06004223 RID: 16931 RVA: 0x00181A80 File Offset: 0x0017FC80
		public unsafe int MaxPassion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_MaxPassion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_MaxPassion_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x00181AC0 File Offset: 0x0017FCC0
		// (set) Token: 0x06004225 RID: 16933 RVA: 0x00181AFC File Offset: 0x0017FCFC
		public unsafe int Visitors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_Visitors_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_Visitors_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x00181B3C File Offset: 0x0017FD3C
		// (set) Token: 0x06004227 RID: 16935 RVA: 0x00181B78 File Offset: 0x0017FD78
		public unsafe int NormalGuestReception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_NormalGuestReception_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_NormalGuestReception_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x00181BB8 File Offset: 0x0017FDB8
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x00181BF4 File Offset: 0x0017FDF4
		public unsafe int SpecialGuestReception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_SpecialGuestReception_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_SpecialGuestReception_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x00181C34 File Offset: 0x0017FE34
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x00181C70 File Offset: 0x0017FE70
		public unsafe int PositiveSkillTriggered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_PositiveSkillTriggered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_PositiveSkillTriggered_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x00181CB0 File Offset: 0x0017FEB0
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x00181CEC File Offset: 0x0017FEEC
		public unsafe int NegativeSkillTriggered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_NegativeSkillTriggered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_NegativeSkillTriggered_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x00181D2C File Offset: 0x0017FF2C
		public unsafe List<int> InvitedGuests
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40645, RefRangeEnd = 40646, XrefRangeStart = 40645, XrefRangeEnd = 40646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_InvitedGuests_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x00181D6C File Offset: 0x0017FF6C
		public unsafe List<int> IgnoredGuests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_IgnoredGuests_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x00181DAC File Offset: 0x0017FFAC
		// (set) Token: 0x06004231 RID: 16945 RVA: 0x00181DE8 File Offset: 0x0017FFE8
		public unsafe bool CleanWorkSessionTracking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_get_CleanWorkSessionTracking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_set_CleanWorkSessionTracking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x00181E28 File Offset: 0x00180028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166534, RefRangeEnd = 166535, XrefRangeStart = 166534, XrefRangeEnd = 166534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMissionIncome(int addAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref addAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateMissionIncome_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x00181E68 File Offset: 0x00180068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166417, RefRangeEnd = 166418, XrefRangeStart = 166417, XrefRangeEnd = 166418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBussinessIncome(int currentAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_SetBussinessIncome_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x00181EA8 File Offset: 0x001800A8
		[CallerCount(0)]
		public unsafe void SetPartnerExpense(int currentAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_SetPartnerExpense_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x00181EE8 File Offset: 0x001800E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166535, RefRangeEnd = 166537, XrefRangeStart = 166535, XrefRangeEnd = 166535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFee(int currentAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddFee_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x00181F28 File Offset: 0x00180128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166537, RefRangeEnd = 166541, XrefRangeStart = 166537, XrefRangeEnd = 166537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMissionExpense(int addAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref addAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateMissionExpense_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00181F68 File Offset: 0x00180168
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 166541, RefRangeEnd = 166548, XrefRangeStart = 166541, XrefRangeEnd = 166541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShoppingExpense(int addAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref addAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateShoppingExpense_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00181FA8 File Offset: 0x001801A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103831, RefRangeEnd = 103833, XrefRangeStart = 103831, XrefRangeEnd = 103833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDebtExpense(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateDebtExpense_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x00181FE8 File Offset: 0x001801E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166548, RefRangeEnd = 166550, XrefRangeStart = 166548, XrefRangeEnd = 166548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPerformanceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddPerformanceCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x0018201C File Offset: 0x0018021C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166550, RefRangeEnd = 166552, XrefRangeStart = 166550, XrefRangeEnd = 166550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPerformanceSucceedCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddPerformanceSucceedCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x00182050 File Offset: 0x00180250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166552, RefRangeEnd = 166554, XrefRangeStart = 166552, XrefRangeEnd = 166552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPerformanceFullComboCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddPerformanceFullComboCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x00182084 File Offset: 0x00180284
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166558, RefRangeEnd = 166563, XrefRangeStart = 166554, XrefRangeEnd = 166558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBussinessFoodConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddBussinessFoodConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x001820C8 File Offset: 0x001802C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166567, RefRangeEnd = 166572, XrefRangeStart = 166563, XrefRangeEnd = 166567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBussinessBeverageConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddBussinessBeverageConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x0018210C File Offset: 0x0018030C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166592, RefRangeEnd = 166593, XrefRangeStart = 166572, XrefRangeEnd = 166592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeductBussinessBeverageConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_DeductBussinessBeverageConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x00182150 File Offset: 0x00180350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166597, RefRangeEnd = 166600, XrefRangeStart = 166593, XrefRangeEnd = 166597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBussinessIngredientConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddBussinessIngredientConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00182194 File Offset: 0x00180394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166604, RefRangeEnd = 166606, XrefRangeStart = 166600, XrefRangeEnd = 166604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMissionIngredientConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddMissionIngredientConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x001821D8 File Offset: 0x001803D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166610, RefRangeEnd = 166612, XrefRangeStart = 166606, XrefRangeEnd = 166610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMissionFoodConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddMissionFoodConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x0018221C File Offset: 0x0018041C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166616, RefRangeEnd = 166618, XrefRangeStart = 166612, XrefRangeEnd = 166616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMissionBeverageConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddMissionBeverageConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00182260 File Offset: 0x00180460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166622, RefRangeEnd = 166623, XrefRangeStart = 166618, XrefRangeEnd = 166622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInvalidConsumes(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddInvalidConsumes_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x001822A4 File Offset: 0x001804A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 166627, RefRangeEnd = 166633, XrefRangeStart = 166623, XrefRangeEnd = 166627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInvalidConsumes([Optional] Il2CppStructArray<int> ids)
		{
			if (ids == null)
			{
				ids = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddInvalidConsumes_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x001822F4 File Offset: 0x001804F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166634, RefRangeEnd = 166635, XrefRangeStart = 166633, XrefRangeEnd = 166634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanInValidConsumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_CleanInValidConsumes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00182328 File Offset: 0x00180528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166635, RefRangeEnd = 166636, XrefRangeStart = 166635, XrefRangeEnd = 166635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExperience(int addAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref addAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateExperience_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00182368 File Offset: 0x00180568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166636, RefRangeEnd = 166637, XrefRangeStart = 166636, XrefRangeEnd = 166636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaxCombo(int currentCombo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentCombo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateMaxCombo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x001823A8 File Offset: 0x001805A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166637, RefRangeEnd = 166638, XrefRangeStart = 166637, XrefRangeEnd = 166637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaxPassion(int currentPassion, int _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentPassion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateMaxPassion_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x001823F4 File Offset: 0x001805F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166638, RefRangeEnd = 166640, XrefRangeStart = 166638, XrefRangeEnd = 166638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisitors(int vistorAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vistorAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateVisitors_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00182434 File Offset: 0x00180634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166640, RefRangeEnd = 166642, XrefRangeStart = 166640, XrefRangeEnd = 166640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordNormalGuestReception(int guestAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordNormalGuestReception_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x00182474 File Offset: 0x00180674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166642, RefRangeEnd = 166643, XrefRangeStart = 166642, XrefRangeEnd = 166642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordSpecialGuestReception(int guestAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordSpecialGuestReception_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x001824B4 File Offset: 0x001806B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166643, RefRangeEnd = 166645, XrefRangeStart = 166643, XrefRangeEnd = 166643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePositiveSkillTriggerAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdatePositiveSkillTriggerAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x001824E8 File Offset: 0x001806E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166645, RefRangeEnd = 166647, XrefRangeStart = 166645, XrefRangeEnd = 166645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNegativeSkillTriggerAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateNegativeSkillTriggerAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x0018251C File Offset: 0x0018071C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166647, RefRangeEnd = 166649, XrefRangeStart = 166647, XrefRangeEnd = 166647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSucceededRiceBallAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_UpdateSucceededRiceBallAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00182550 File Offset: 0x00180750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166671, RefRangeEnd = 166674, XrefRangeStart = 166649, XrefRangeEnd = 166671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInvitedGuest(int guestId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordInvitedGuest_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00182590 File Offset: 0x00180790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166674, XrefRangeEnd = 166676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepeatRecordInvitedGuest(int guestId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RepeatRecordInvitedGuest_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x001825D0 File Offset: 0x001807D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166676, XrefRangeEnd = 166684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordIgnoredGuest(int guestId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordIgnoredGuest_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x00182610 File Offset: 0x00180810
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 166687, RefRangeEnd = 166696, XrefRangeStart = 166684, XrefRangeEnd = 166687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00182644 File Offset: 0x00180844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166696, XrefRangeEnd = 166699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusTracker.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x00182680 File Offset: 0x00180880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166703, RefRangeEnd = 166704, XrefRangeStart = 166699, XrefRangeEnd = 166703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNPCInvited(int guestId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasNPCInvited_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x001826CC File Offset: 0x001808CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166710, RefRangeEnd = 166711, XrefRangeStart = 166704, XrefRangeEnd = 166710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordCommission(string characterLabel, DialogPackage commissionFinishDialog, IEnumerable<Product> commisionProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commissionFinishDialog);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commisionProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordCommission_Public_Void_String_DialogPackage_IEnumerable_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00182734 File Offset: 0x00180934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166726, RefRangeEnd = 166728, XrefRangeStart = 166711, XrefRangeEnd = 166726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCommission(string characterLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasCommission_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x00182784 File Offset: 0x00180984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166734, RefRangeEnd = 166735, XrefRangeStart = 166728, XrefRangeEnd = 166734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask ReceiveCommissionsAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_ReceiveCommissionsAsync_Public_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x001827BC File Offset: 0x001809BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166739, RefRangeEnd = 166740, XrefRangeStart = 166735, XrefRangeEnd = 166739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordChatNPCLabel(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordChatNPCLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00182800 File Offset: 0x00180A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166744, RefRangeEnd = 166745, XrefRangeStart = 166740, XrefRangeEnd = 166744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNPCChat(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasNPCChat_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00182850 File Offset: 0x00180A50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166749, RefRangeEnd = 166751, XrefRangeStart = 166745, XrefRangeEnd = 166749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordTemptInviteNPCLabel(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordTemptInviteNPCLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00182894 File Offset: 0x00180A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166755, RefRangeEnd = 166757, XrefRangeStart = 166751, XrefRangeEnd = 166755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTemptInvited(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasTemptInvited_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x001828E4 File Offset: 0x00180AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166761, RefRangeEnd = 166762, XrefRangeStart = 166757, XrefRangeEnd = 166761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordRequestIngredientNPCLabel(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordRequestIngredientNPCLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x00182928 File Offset: 0x00180B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166766, RefRangeEnd = 166767, XrefRangeStart = 166762, XrefRangeEnd = 166766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasIngredientRequested(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasIngredientRequested_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x00182978 File Offset: 0x00180B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166771, RefRangeEnd = 166772, XrefRangeStart = 166767, XrefRangeEnd = 166771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordRequestBeverageNPCLabel(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_RecordRequestBeverageNPCLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x001829BC File Offset: 0x00180BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166776, RefRangeEnd = 166777, XrefRangeStart = 166772, XrefRangeEnd = 166776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBeverageRequested(string npcLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasBeverageRequested_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x00182A0C File Offset: 0x00180C0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 166791, RefRangeEnd = 166798, XrefRangeStart = 166777, XrefRangeEnd = 166791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToPartner(int specialNPCId, PartnerBase.PartnerType partnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialNPCId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddToPartner_Public_Void_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x00182A58 File Offset: 0x00180C58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166803, RefRangeEnd = 166807, XrefRangeStart = 166798, XrefRangeEnd = 166803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToPartner(int specialNPCId, PartnerBase partner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialNPCId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddToPartner_Public_Void_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x00182AA8 File Offset: 0x00180CA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166809, RefRangeEnd = 166813, XrefRangeStart = 166807, XrefRangeEnd = 166809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanPartner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_CleanPartner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x00182ADC File Offset: 0x00180CDC
		[CallerCount(0)]
		public unsafe IEnumerable<ValueTuple<int, PartnerBase>> GetPartners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_GetPartners_Public_IEnumerable_1_ValueTuple_2_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<int, PartnerBase>>>(intPtr3) : null;
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x00182B1C File Offset: 0x00180D1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166827, RefRangeEnd = 166830, XrefRangeStart = 166813, XrefRangeEnd = 166827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPartnerEnjoySpring(int partnerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_AddPartnerEnjoySpring_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x00182B5C File Offset: 0x00180D5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 166834, RefRangeEnd = 166841, XrefRangeStart = 166830, XrefRangeEnd = 166834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPartnerEnjoySpring(int partnerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_HasPartnerEnjoySpring_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x00182BA8 File Offset: 0x00180DA8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 166848, RefRangeEnd = 166862, XrefRangeStart = 166841, XrefRangeEnd = 166848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetComponentNum(string componentLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(componentLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_GetComponentNum_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00182BF8 File Offset: 0x00180DF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 166885, RefRangeEnd = 166893, XrefRangeStart = 166862, XrefRangeEnd = 166885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseComponentNum(string componentLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(componentLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_IncreaseComponentNum_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x00182C3C File Offset: 0x00180E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166893, XrefRangeEnd = 166897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearComponentNum(string componentLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(componentLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr_ClearComponentNum_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x00182C80 File Offset: 0x00180E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166897, XrefRangeEnd = 166936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusTracker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00182CBC File Offset: 0x00180EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166936, XrefRangeEnd = 167035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00023B70 File Offset: 0x00021D70
		public void AddInvalidConsumes(params int[] ids)
		{
			this.AddInvalidConsumes(new Il2CppStructArray<int>(ids));
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x00023B7E File Offset: 0x00021D7E
		public StatusTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x00182CF8 File Offset: 0x00180EF8
		// (set) Token: 0x0600426E RID: 17006 RVA: 0x00023B87 File Offset: 0x00021D87
		public unsafe List<int> buffedSpringPartners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_buffedSpringPartners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_buffedSpringPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x00182D28 File Offset: 0x00180F28
		// (set) Token: 0x06004270 RID: 17008 RVA: 0x00023BA6 File Offset: 0x00021DA6
		public unsafe List<int> bussinessBeverageConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_bussinessBeverageConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_bussinessBeverageConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x00182D58 File Offset: 0x00180F58
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x00023BC5 File Offset: 0x00021DC5
		public unsafe List<int> bussinessFoodConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_bussinessFoodConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_bussinessFoodConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x00182D88 File Offset: 0x00180F88
		// (set) Token: 0x06004274 RID: 17012 RVA: 0x00023BE4 File Offset: 0x00021DE4
		public unsafe List<int> bussinessIngredientConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_bussinessIngredientConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_bussinessIngredientConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x00182DB8 File Offset: 0x00180FB8
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x00023C03 File Offset: 0x00021E03
		public unsafe List<string> hasChatNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasChatNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasChatNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x00182DE8 File Offset: 0x00180FE8
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x00023C22 File Offset: 0x00021E22
		public unsafe Dictionary<string, int> hasInitializedComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasInitializedComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasInitializedComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x00182E18 File Offset: 0x00181018
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x00023C41 File Offset: 0x00021E41
		public unsafe List<string> hasRequestedBeveragesNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasRequestedBeveragesNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasRequestedBeveragesNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00182E48 File Offset: 0x00181048
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x00023C60 File Offset: 0x00021E60
		public unsafe List<string> hasRequestedIngredientsNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasRequestedIngredientsNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasRequestedIngredientsNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x00182E78 File Offset: 0x00181078
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x00023C7F File Offset: 0x00021E7F
		public unsafe List<string> hasTemptInviteNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasTemptInviteNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_hasTemptInviteNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x00182EA8 File Offset: 0x001810A8
		// (set) Token: 0x06004280 RID: 17024 RVA: 0x00023C9E File Offset: 0x00021E9E
		public unsafe List<int> invalidFoods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_invalidFoods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_invalidFoods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x00182ED8 File Offset: 0x001810D8
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x00023CBD File Offset: 0x00021EBD
		public unsafe List<int> missionBeverageConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_missionBeverageConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_missionBeverageConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x00182F08 File Offset: 0x00181108
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x00023CDC File Offset: 0x00021EDC
		public unsafe List<int> missionFoodConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_missionFoodConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_missionFoodConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x00182F38 File Offset: 0x00181138
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x00023CFB File Offset: 0x00021EFB
		public unsafe List<int> missionIngredientConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_missionIngredientConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_missionIngredientConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x00182F68 File Offset: 0x00181168
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x00023D1A File Offset: 0x00021F1A
		public unsafe List<ValueTuple<int, PartnerBase>> partners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_partners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, PartnerBase>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_partners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x00182F98 File Offset: 0x00181198
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x00023D39 File Offset: 0x00021F39
		public unsafe Queue<ValueTuple<string, DialogPackage, IEnumerable<Product>>> processingCommissions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_processingCommissions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ValueTuple<string, DialogPackage, IEnumerable<Product>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr_processingCommissions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x00182FC8 File Offset: 0x001811C8
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x00023D58 File Offset: 0x00021F58
		public unsafe int _MissionIncome_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MissionIncome_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MissionIncome_k__BackingField)) = value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x00182FF0 File Offset: 0x001811F0
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x00023D73 File Offset: 0x00021F73
		public unsafe int _BussinessIncome_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__BussinessIncome_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__BussinessIncome_k__BackingField)) = value;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x00183018 File Offset: 0x00181218
		// (set) Token: 0x06004290 RID: 17040 RVA: 0x00023D8E File Offset: 0x00021F8E
		public unsafe int _Fee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__Fee_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__Fee_k__BackingField)) = value;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x00183040 File Offset: 0x00181240
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x00023DA9 File Offset: 0x00021FA9
		public unsafe int _MissionExpense_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MissionExpense_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MissionExpense_k__BackingField)) = value;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x00183068 File Offset: 0x00181268
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x00023DC4 File Offset: 0x00021FC4
		public unsafe int _ShoppingExpense_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__ShoppingExpense_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__ShoppingExpense_k__BackingField)) = value;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x00183090 File Offset: 0x00181290
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x00023DDF File Offset: 0x00021FDF
		public unsafe int _DebtExpense_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__DebtExpense_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__DebtExpense_k__BackingField)) = value;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x001830B8 File Offset: 0x001812B8
		// (set) Token: 0x06004298 RID: 17048 RVA: 0x00023DFA File Offset: 0x00021FFA
		public unsafe int _PartnerExpense_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PartnerExpense_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PartnerExpense_k__BackingField)) = value;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06004299 RID: 17049 RVA: 0x001830E0 File Offset: 0x001812E0
		// (set) Token: 0x0600429A RID: 17050 RVA: 0x00023E15 File Offset: 0x00022015
		public unsafe int _PerformanceCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PerformanceCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PerformanceCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x00183108 File Offset: 0x00181308
		// (set) Token: 0x0600429C RID: 17052 RVA: 0x00023E30 File Offset: 0x00022030
		public unsafe int _PerformanceSucceededCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PerformanceSucceededCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PerformanceSucceededCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x00183130 File Offset: 0x00181330
		// (set) Token: 0x0600429E RID: 17054 RVA: 0x00023E4B File Offset: 0x0002204B
		public unsafe int _PerformanceFullComboCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PerformanceFullComboCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PerformanceFullComboCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x00183158 File Offset: 0x00181358
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x00023E66 File Offset: 0x00022066
		public unsafe int _SuccessRiceBallCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__SuccessRiceBallCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__SuccessRiceBallCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x00183180 File Offset: 0x00181380
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x00023E81 File Offset: 0x00022081
		public unsafe int _GainExperience_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__GainExperience_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__GainExperience_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x001831A8 File Offset: 0x001813A8
		// (set) Token: 0x060042A4 RID: 17060 RVA: 0x00023E9C File Offset: 0x0002209C
		public unsafe int _MaxCombo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MaxCombo_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MaxCombo_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x001831D0 File Offset: 0x001813D0
		// (set) Token: 0x060042A6 RID: 17062 RVA: 0x00023EB7 File Offset: 0x000220B7
		public unsafe int _MaxPassion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MaxPassion_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__MaxPassion_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x001831F8 File Offset: 0x001813F8
		// (set) Token: 0x060042A8 RID: 17064 RVA: 0x00023ED2 File Offset: 0x000220D2
		public unsafe int _Visitors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__Visitors_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__Visitors_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x00183220 File Offset: 0x00181420
		// (set) Token: 0x060042AA RID: 17066 RVA: 0x00023EED File Offset: 0x000220ED
		public unsafe int _NormalGuestReception_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__NormalGuestReception_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__NormalGuestReception_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x00183248 File Offset: 0x00181448
		// (set) Token: 0x060042AC RID: 17068 RVA: 0x00023F08 File Offset: 0x00022108
		public unsafe int _SpecialGuestReception_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__SpecialGuestReception_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__SpecialGuestReception_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x00183270 File Offset: 0x00181470
		// (set) Token: 0x060042AE RID: 17070 RVA: 0x00023F23 File Offset: 0x00022123
		public unsafe int _PositiveSkillTriggered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PositiveSkillTriggered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__PositiveSkillTriggered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x00183298 File Offset: 0x00181498
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x00023F3E File Offset: 0x0002213E
		public unsafe int _NegativeSkillTriggered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__NegativeSkillTriggered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__NegativeSkillTriggered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x001832C0 File Offset: 0x001814C0
		// (set) Token: 0x060042B2 RID: 17074 RVA: 0x00023F59 File Offset: 0x00022159
		public unsafe List<int> _InvitedGuests_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__InvitedGuests_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__InvitedGuests_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x001832F0 File Offset: 0x001814F0
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x00023F78 File Offset: 0x00022178
		public unsafe List<int> _IgnoredGuests_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__IgnoredGuests_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__IgnoredGuests_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00183320 File Offset: 0x00181520
		// (set) Token: 0x060042B6 RID: 17078 RVA: 0x00023F97 File Offset: 0x00022197
		public unsafe bool _CleanWorkSessionTracking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__CleanWorkSessionTracking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.NativeFieldInfoPtr__CleanWorkSessionTracking_k__BackingField)) = value;
			}
		}

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeFieldInfoPtr_buffedSpringPartners;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeFieldInfoPtr_bussinessBeverageConsumes;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeFieldInfoPtr_bussinessFoodConsumes;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeFieldInfoPtr_bussinessIngredientConsumes;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeFieldInfoPtr_hasChatNPC;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeFieldInfoPtr_hasInitializedComponent;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeFieldInfoPtr_hasRequestedBeveragesNPC;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeFieldInfoPtr_hasRequestedIngredientsNPC;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeFieldInfoPtr_hasTemptInviteNPC;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeFieldInfoPtr_invalidFoods;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeFieldInfoPtr_missionBeverageConsumes;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeFieldInfoPtr_missionFoodConsumes;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeFieldInfoPtr_missionIngredientConsumes;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeFieldInfoPtr_partners;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeFieldInfoPtr_processingCommissions;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeFieldInfoPtr__MissionIncome_k__BackingField;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeFieldInfoPtr__BussinessIncome_k__BackingField;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeFieldInfoPtr__Fee_k__BackingField;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeFieldInfoPtr__MissionExpense_k__BackingField;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeFieldInfoPtr__ShoppingExpense_k__BackingField;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeFieldInfoPtr__DebtExpense_k__BackingField;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeFieldInfoPtr__PartnerExpense_k__BackingField;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeFieldInfoPtr__PerformanceCount_k__BackingField;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeFieldInfoPtr__PerformanceSucceededCount_k__BackingField;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeFieldInfoPtr__PerformanceFullComboCount_k__BackingField;

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeFieldInfoPtr__SuccessRiceBallCount_k__BackingField;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeFieldInfoPtr__GainExperience_k__BackingField;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeFieldInfoPtr__MaxCombo_k__BackingField;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeFieldInfoPtr__MaxPassion_k__BackingField;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeFieldInfoPtr__Visitors_k__BackingField;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestReception_k__BackingField;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestReception_k__BackingField;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeFieldInfoPtr__PositiveSkillTriggered_k__BackingField;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeFieldInfoPtr__NegativeSkillTriggered_k__BackingField;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeFieldInfoPtr__InvitedGuests_k__BackingField;

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeFieldInfoPtr__IgnoredGuests_k__BackingField;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeFieldInfoPtr__CleanWorkSessionTracking_k__BackingField;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionIncome_Public_get_Int32_0;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeMethodInfoPtr_set_MissionIncome_Private_set_Void_Int32_0;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeMethodInfoPtr_get_BussinessIncome_Public_get_Int32_0;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeMethodInfoPtr_set_BussinessIncome_Private_set_Void_Int32_0;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeMethodInfoPtr_get_Fee_Public_get_Int32_0;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeMethodInfoPtr_set_Fee_Private_set_Void_Int32_0;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeMethodInfoPtr_get_NetProfit_Public_get_Int32_0;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionExpense_Public_get_Int32_0;

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeMethodInfoPtr_set_MissionExpense_Private_set_Void_Int32_0;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeMethodInfoPtr_get_ShoppingExpense_Public_get_Int32_0;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeMethodInfoPtr_set_ShoppingExpense_Private_set_Void_Int32_0;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeMethodInfoPtr_get_DebtExpense_Public_get_Int32_0;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeMethodInfoPtr_set_DebtExpense_Private_set_Void_Int32_0;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerExpense_Public_get_Int32_0;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeMethodInfoPtr_set_PartnerExpense_Private_set_Void_Int32_0;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeMethodInfoPtr_get_PerformanceCount_Public_get_Int32_0;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeMethodInfoPtr_set_PerformanceCount_Private_set_Void_Int32_0;

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeMethodInfoPtr_get_PerformanceSucceededCount_Public_get_Int32_0;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeMethodInfoPtr_set_PerformanceSucceededCount_Private_set_Void_Int32_0;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeMethodInfoPtr_get_PerformanceFullComboCount_Public_get_Int32_0;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeMethodInfoPtr_set_PerformanceFullComboCount_Private_set_Void_Int32_0;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeMethodInfoPtr_get_SuccessRiceBallCount_Public_get_Int32_0;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeMethodInfoPtr_set_SuccessRiceBallCount_Private_set_Void_Int32_0;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeMethodInfoPtr_get_BussinessFoodConsumesValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_get_BussinessBeverageConsumesValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeMethodInfoPtr_get_BussinessIngredientsConsumesValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeMethodInfoPtr_get_BussinessFoodConsumes_Public_get_IEnumerable_1_Sprite_0;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_get_BussinessBeverageConsumes_Public_get_IEnumerable_1_Sprite_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionIngredientsConsumesValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionFoodConsumesValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionBeverageConsumesValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionIngredientConsumes_Public_get_IEnumerable_1_Sprite_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionFoodConsumes_Public_get_IEnumerable_1_Sprite_0;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionBeverageConsumes_Public_get_IEnumerable_1_Sprite_0;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidFoodsValue_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidFoods_Public_get_IEnumerable_1_Sprite_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_get_GainExperience_Public_get_Int32_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_set_GainExperience_Private_set_Void_Int32_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCombo_Public_get_Int32_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCombo_Private_set_Void_Int32_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxPassion_Public_get_Int32_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxPassion_Private_set_Void_Int32_0;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeMethodInfoPtr_get_Visitors_Public_get_Int32_0;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeMethodInfoPtr_set_Visitors_Private_set_Void_Int32_0;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestReception_Public_get_Int32_0;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestReception_Private_set_Void_Int32_0;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestReception_Public_get_Int32_0;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestReception_Public_set_Void_Int32_0;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveSkillTriggered_Public_get_Int32_0;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeMethodInfoPtr_set_PositiveSkillTriggered_Public_set_Void_Int32_0;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeSkillTriggered_Public_get_Int32_0;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeMethodInfoPtr_set_NegativeSkillTriggered_Public_set_Void_Int32_0;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeMethodInfoPtr_get_InvitedGuests_Public_get_List_1_Int32_0;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoredGuests_Public_get_List_1_Int32_0;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanWorkSessionTracking_Public_get_Boolean_0;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeMethodInfoPtr_set_CleanWorkSessionTracking_Public_set_Void_Boolean_0;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMissionIncome_Public_Void_Int32_0;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeMethodInfoPtr_SetBussinessIncome_Public_Void_Int32_0;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeMethodInfoPtr_SetPartnerExpense_Public_Void_Int32_0;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr_AddFee_Public_Void_Int32_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMissionExpense_Public_Void_Int32_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShoppingExpense_Public_Void_Int32_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDebtExpense_Public_Void_Int32_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_AddPerformanceCount_Public_Void_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_AddPerformanceSucceedCount_Public_Void_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_AddPerformanceFullComboCount_Public_Void_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_AddBussinessFoodConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeMethodInfoPtr_AddBussinessBeverageConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr_DeductBussinessBeverageConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_AddBussinessIngredientConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_AddMissionIngredientConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr_AddMissionFoodConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr_AddMissionBeverageConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeMethodInfoPtr_AddInvalidConsumes_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeMethodInfoPtr_AddInvalidConsumes_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeMethodInfoPtr_CleanInValidConsumes_Public_Void_0;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExperience_Public_Void_Int32_0;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaxCombo_Public_Void_Int32_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaxPassion_Public_Void_Int32_Int32_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisitors_Public_Void_Int32_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr_RecordNormalGuestReception_Public_Void_Int32_0;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_RecordSpecialGuestReception_Public_Void_Int32_0;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePositiveSkillTriggerAmount_Public_Void_0;

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNegativeSkillTriggerAmount_Public_Void_0;

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSucceededRiceBallAmount_Public_Void_0;

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeMethodInfoPtr_RecordInvitedGuest_Public_Void_Int32_0;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeMethodInfoPtr_RepeatRecordInvitedGuest_Public_Void_Int32_0;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeMethodInfoPtr_RecordIgnoredGuest_Public_Void_Int32_0;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeMethodInfoPtr_HasNPCInvited_Public_Boolean_Int32_0;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeMethodInfoPtr_RecordCommission_Public_Void_String_DialogPackage_IEnumerable_1_Product_0;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeMethodInfoPtr_HasCommission_Public_Boolean_String_0;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCommissionsAsync_Public_UniTask_0;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeMethodInfoPtr_RecordChatNPCLabel_Public_Void_String_0;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeMethodInfoPtr_HasNPCChat_Public_Boolean_String_0;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeMethodInfoPtr_RecordTemptInviteNPCLabel_Public_Void_String_0;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeMethodInfoPtr_HasTemptInvited_Public_Boolean_String_0;

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeMethodInfoPtr_RecordRequestIngredientNPCLabel_Public_Void_String_0;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeMethodInfoPtr_HasIngredientRequested_Public_Boolean_String_0;

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeMethodInfoPtr_RecordRequestBeverageNPCLabel_Public_Void_String_0;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeMethodInfoPtr_HasBeverageRequested_Public_Boolean_String_0;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeMethodInfoPtr_AddToPartner_Public_Void_Int32_PartnerType_0;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr_AddToPartner_Public_Void_Int32_PartnerBase_0;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeMethodInfoPtr_CleanPartner_Public_Void_0;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeMethodInfoPtr_GetPartners_Public_IEnumerable_1_ValueTuple_2_Int32_PartnerBase_0;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr_AddPartnerEnjoySpring_Public_Void_Int32_0;

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeMethodInfoPtr_HasPartnerEnjoySpring_Public_Boolean_Int32_0;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentNum_Public_Int32_String_0;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseComponentNum_Public_Void_String_0;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeMethodInfoPtr_ClearComponentNum_Public_Void_String_0;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A25 RID: 2597
		[ObfuscatedName("GameData.RunTime.Common.StatusTracker+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C516 RID: 50454 RVA: 0x0030FAC4 File Offset: 0x0030DCC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr);
				StatusTracker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9");
				StatusTracker.__c.NativeFieldInfoPtr___9__68_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9__68_0");
				StatusTracker.__c.NativeFieldInfoPtr___9__70_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9__70_0");
				StatusTracker.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9__78_0");
				StatusTracker.__c.NativeFieldInfoPtr___9__80_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9__80_0");
				StatusTracker.__c.NativeFieldInfoPtr___9__82_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9__82_0");
				StatusTracker.__c.NativeFieldInfoPtr___9__86_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, "<>9__86_0");
				StatusTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675988);
				StatusTracker.__c.NativeMethodInfoPtr__get_BussinessFoodConsumes_b__68_0_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675989);
				StatusTracker.__c.NativeMethodInfoPtr__get_BussinessBeverageConsumes_b__70_0_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675990);
				StatusTracker.__c.NativeMethodInfoPtr__get_MissionIngredientConsumes_b__78_0_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675991);
				StatusTracker.__c.NativeMethodInfoPtr__get_MissionFoodConsumes_b__80_0_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675992);
				StatusTracker.__c.NativeMethodInfoPtr__get_MissionBeverageConsumes_b__82_0_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675993);
				StatusTracker.__c.NativeMethodInfoPtr__get_InvalidFoods_b__86_0_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr, 100675994);
			}

			// Token: 0x0600C517 RID: 50455 RVA: 0x0030FC08 File Offset: 0x0030DE08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusTracker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C518 RID: 50456 RVA: 0x0030FC44 File Offset: 0x0030DE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _get_BussinessFoodConsumes_b__68_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__get_BussinessFoodConsumes_b__68_0_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600C519 RID: 50457 RVA: 0x0030FC90 File Offset: 0x0030DE90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _get_BussinessBeverageConsumes_b__70_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__get_BussinessBeverageConsumes_b__70_0_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600C51A RID: 50458 RVA: 0x0030FCDC File Offset: 0x0030DEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _get_MissionIngredientConsumes_b__78_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__get_MissionIngredientConsumes_b__78_0_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600C51B RID: 50459 RVA: 0x0030FD28 File Offset: 0x0030DF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _get_MissionFoodConsumes_b__80_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__get_MissionFoodConsumes_b__80_0_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600C51C RID: 50460 RVA: 0x0030FD74 File Offset: 0x0030DF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _get_MissionBeverageConsumes_b__82_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__get_MissionBeverageConsumes_b__82_0_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600C51D RID: 50461 RVA: 0x0030FDC0 File Offset: 0x0030DFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _get_InvalidFoods_b__86_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c.NativeMethodInfoPtr__get_InvalidFoods_b__86_0_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600C51E RID: 50462 RVA: 0x0006A5D8 File Offset: 0x000687D8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004025 RID: 16421
			// (get) Token: 0x0600C51F RID: 50463 RVA: 0x0030FE0C File Offset: 0x0030E00C
			// (set) Token: 0x0600C520 RID: 50464 RVA: 0x0006A5E1 File Offset: 0x000687E1
			public unsafe static StatusTracker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusTracker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004026 RID: 16422
			// (get) Token: 0x0600C521 RID: 50465 RVA: 0x0030FE34 File Offset: 0x0030E034
			// (set) Token: 0x0600C522 RID: 50466 RVA: 0x0006A5F3 File Offset: 0x000687F3
			public unsafe static Func<int, Sprite> __9__68_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9__68_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9__68_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004027 RID: 16423
			// (get) Token: 0x0600C523 RID: 50467 RVA: 0x0030FE5C File Offset: 0x0030E05C
			// (set) Token: 0x0600C524 RID: 50468 RVA: 0x0006A605 File Offset: 0x00068805
			public unsafe static Func<int, Sprite> __9__70_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9__70_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9__70_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004028 RID: 16424
			// (get) Token: 0x0600C525 RID: 50469 RVA: 0x0030FE84 File Offset: 0x0030E084
			// (set) Token: 0x0600C526 RID: 50470 RVA: 0x0006A617 File Offset: 0x00068817
			public unsafe static Func<int, Sprite> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004029 RID: 16425
			// (get) Token: 0x0600C527 RID: 50471 RVA: 0x0030FEAC File Offset: 0x0030E0AC
			// (set) Token: 0x0600C528 RID: 50472 RVA: 0x0006A629 File Offset: 0x00068829
			public unsafe static Func<int, Sprite> __9__80_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9__80_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9__80_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402A RID: 16426
			// (get) Token: 0x0600C529 RID: 50473 RVA: 0x0030FED4 File Offset: 0x0030E0D4
			// (set) Token: 0x0600C52A RID: 50474 RVA: 0x0006A63B File Offset: 0x0006883B
			public unsafe static Func<int, Sprite> __9__82_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9__82_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9__82_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402B RID: 16427
			// (get) Token: 0x0600C52B RID: 50475 RVA: 0x0030FEFC File Offset: 0x0030E0FC
			// (set) Token: 0x0600C52C RID: 50476 RVA: 0x0006A64D File Offset: 0x0006884D
			public unsafe static Func<int, Sprite> __9__86_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StatusTracker.__c.NativeFieldInfoPtr___9__86_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StatusTracker.__c.NativeFieldInfoPtr___9__86_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007EAF RID: 32431
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007EB0 RID: 32432
			private static readonly IntPtr NativeFieldInfoPtr___9__68_0;

			// Token: 0x04007EB1 RID: 32433
			private static readonly IntPtr NativeFieldInfoPtr___9__70_0;

			// Token: 0x04007EB2 RID: 32434
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x04007EB3 RID: 32435
			private static readonly IntPtr NativeFieldInfoPtr___9__80_0;

			// Token: 0x04007EB4 RID: 32436
			private static readonly IntPtr NativeFieldInfoPtr___9__82_0;

			// Token: 0x04007EB5 RID: 32437
			private static readonly IntPtr NativeFieldInfoPtr___9__86_0;

			// Token: 0x04007EB6 RID: 32438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007EB7 RID: 32439
			private static readonly IntPtr NativeMethodInfoPtr__get_BussinessFoodConsumes_b__68_0_Internal_Sprite_Int32_0;

			// Token: 0x04007EB8 RID: 32440
			private static readonly IntPtr NativeMethodInfoPtr__get_BussinessBeverageConsumes_b__70_0_Internal_Sprite_Int32_0;

			// Token: 0x04007EB9 RID: 32441
			private static readonly IntPtr NativeMethodInfoPtr__get_MissionIngredientConsumes_b__78_0_Internal_Sprite_Int32_0;

			// Token: 0x04007EBA RID: 32442
			private static readonly IntPtr NativeMethodInfoPtr__get_MissionFoodConsumes_b__80_0_Internal_Sprite_Int32_0;

			// Token: 0x04007EBB RID: 32443
			private static readonly IntPtr NativeMethodInfoPtr__get_MissionBeverageConsumes_b__82_0_Internal_Sprite_Int32_0;

			// Token: 0x04007EBC RID: 32444
			private static readonly IntPtr NativeMethodInfoPtr__get_InvalidFoods_b__86_0_Internal_Sprite_Int32_0;
		}

		// Token: 0x02000A26 RID: 2598
		[ObfuscatedName("GameData.RunTime.Common.StatusTracker+<>c__DisplayClass165_0")]
		public sealed class __c__DisplayClass165_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C52D RID: 50477 RVA: 0x0030FF24 File Offset: 0x0030E124
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass165_0()
			{
				Il2CppClassPointerStore<StatusTracker.__c__DisplayClass165_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<>c__DisplayClass165_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusTracker.__c__DisplayClass165_0>.NativeClassPtr);
				StatusTracker.__c__DisplayClass165_0.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker.__c__DisplayClass165_0>.NativeClassPtr, "characterLabel");
				StatusTracker.__c__DisplayClass165_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c__DisplayClass165_0>.NativeClassPtr, 100675995);
				StatusTracker.__c__DisplayClass165_0.NativeMethodInfoPtr__HasCommission_b__0_Internal_Boolean_ValueTuple_3_String_DialogPackage_IEnumerable_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker.__c__DisplayClass165_0>.NativeClassPtr, 100675996);
			}

			// Token: 0x0600C52E RID: 50478 RVA: 0x0030FF8C File Offset: 0x0030E18C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass165_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusTracker.__c__DisplayClass165_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c__DisplayClass165_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C52F RID: 50479 RVA: 0x0030FFC8 File Offset: 0x0030E1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasCommission_b__0(ValueTuple<string, DialogPackage, IEnumerable<Product>> specialData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(specialData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker.__c__DisplayClass165_0.NativeMethodInfoPtr__HasCommission_b__0_Internal_Boolean_ValueTuple_3_String_DialogPackage_IEnumerable_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C530 RID: 50480 RVA: 0x0006A65F File Offset: 0x0006885F
			public __c__DisplayClass165_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402C RID: 16428
			// (get) Token: 0x0600C531 RID: 50481 RVA: 0x0031001C File Offset: 0x0030E21C
			// (set) Token: 0x0600C532 RID: 50482 RVA: 0x0006A668 File Offset: 0x00068868
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.__c__DisplayClass165_0.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker.__c__DisplayClass165_0.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04007EBD RID: 32445
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04007EBE RID: 32446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007EBF RID: 32447
			private static readonly IntPtr NativeMethodInfoPtr__HasCommission_b__0_Internal_Boolean_ValueTuple_3_String_DialogPackage_IEnumerable_1_Product_0;
		}

		// Token: 0x02000A27 RID: 2599
		[ObfuscatedName("GameData.RunTime.Common.StatusTracker+<ReceiveCommissionsAsync>d__166")]
		public sealed class _ReceiveCommissionsAsync_d__166 : ValueType
		{
			// Token: 0x0600C533 RID: 50483 RVA: 0x00310044 File Offset: 0x0030E244
			// Note: this type is marked as 'beforefieldinit'.
			static _ReceiveCommissionsAsync_d__166()
			{
				Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusTracker>.NativeClassPtr, "<ReceiveCommissionsAsync>d__166");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr);
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, "<>1__state");
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, "<>t__builder");
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, "<>4__this");
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr__allProducts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, "<allProducts>5__2");
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, "<>u__1");
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, 100675997);
				StatusTracker._ReceiveCommissionsAsync_d__166.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr, 100675998);
			}

			// Token: 0x0600C534 RID: 50484 RVA: 0x003100FC File Offset: 0x0030E2FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 166415, RefRangeEnd = 166417, XrefRangeStart = 166364, XrefRangeEnd = 166415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker._ReceiveCommissionsAsync_d__166.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C535 RID: 50485 RVA: 0x00310134 File Offset: 0x0030E334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTracker._ReceiveCommissionsAsync_d__166.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C536 RID: 50486 RVA: 0x0006A687 File Offset: 0x00068887
			public _ReceiveCommissionsAsync_d__166(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C537 RID: 50487 RVA: 0x0006A690 File Offset: 0x00068890
			public _ReceiveCommissionsAsync_d__166() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusTracker._ReceiveCommissionsAsync_d__166>.NativeClassPtr))
			{
			}

			// Token: 0x1700402D RID: 16429
			// (get) Token: 0x0600C538 RID: 50488 RVA: 0x0031017C File Offset: 0x0030E37C
			// (set) Token: 0x0600C539 RID: 50489 RVA: 0x0006A6A2 File Offset: 0x000688A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700402E RID: 16430
			// (get) Token: 0x0600C53A RID: 50490 RVA: 0x003101A4 File Offset: 0x0030E3A4
			// (set) Token: 0x0600C53B RID: 50491 RVA: 0x0006A6BD File Offset: 0x000688BD
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700402F RID: 16431
			// (get) Token: 0x0600C53C RID: 50492 RVA: 0x003101D4 File Offset: 0x0030E3D4
			// (set) Token: 0x0600C53D RID: 50493 RVA: 0x0006A6EB File Offset: 0x000688EB
			public unsafe StatusTracker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusTracker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004030 RID: 16432
			// (get) Token: 0x0600C53E RID: 50494 RVA: 0x00310204 File Offset: 0x0030E404
			// (set) Token: 0x0600C53F RID: 50495 RVA: 0x0006A70A File Offset: 0x0006890A
			public unsafe Dictionary<string, List<Product>> _allProducts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr__allProducts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Product>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr__allProducts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004031 RID: 16433
			// (get) Token: 0x0600C540 RID: 50496 RVA: 0x00310234 File Offset: 0x0030E434
			// (set) Token: 0x0600C541 RID: 50497 RVA: 0x0006A729 File Offset: 0x00068929
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTracker._ReceiveCommissionsAsync_d__166.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007EC0 RID: 32448
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007EC1 RID: 32449
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04007EC2 RID: 32450
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007EC3 RID: 32451
			private static readonly IntPtr NativeFieldInfoPtr__allProducts_5__2;

			// Token: 0x04007EC4 RID: 32452
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04007EC5 RID: 32453
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007EC6 RID: 32454
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
