using System;
using GameData.Core.Collections;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.UI.CookingUtility;
using UnityEngine;

namespace NightScene.CookingUtility
{
	// Token: 0x020001B2 RID: 434
	public class CookController : MonoBehaviour
	{
		// Token: 0x060034A5 RID: 13477 RVA: 0x001535B0 File Offset: 0x001517B0
		// Note: this type is marked as 'beforefieldinit'.
		static CookController()
		{
			Il2CppClassPointerStore<CookController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.CookingUtility", "CookController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookController>.NativeClassPtr);
			CookController.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "visual");
			CookController.NativeFieldInfoPtr_onStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "onStatus");
			CookController.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "start");
			CookController.NativeFieldInfoPtr_sellableShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "sellableShadow");
			CookController.NativeFieldInfoPtr_steam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "steam");
			CookController.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "result");
			CookController.NativeFieldInfoPtr_resultVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "resultVisual");
			CookController.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "normalColor");
			CookController.NativeFieldInfoPtr_failedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "failedColor");
			CookController.NativeFieldInfoPtr_cookingProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "cookingProgress");
			CookController.NativeFieldInfoPtr_cookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "cookTime");
			CookController.NativeFieldInfoPtr_couldReturnIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "couldReturnIngredients");
			CookController.NativeFieldInfoPtr_onCookingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "onCookingCoroutine");
			CookController.NativeFieldInfoPtr_qteScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "qteScore");
			CookController.NativeFieldInfoPtr_shownRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "shownRecipes");
			CookController.NativeFieldInfoPtr__IsEmptyDesk_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<IsEmptyDesk>k__BackingField");
			CookController.NativeFieldInfoPtr__Phase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<Phase>k__BackingField");
			CookController.NativeFieldInfoPtr__Cooker_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<Cooker>k__BackingField");
			CookController.NativeFieldInfoPtr__ObtainedRecipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<ObtainedRecipes>k__BackingField");
			CookController.NativeFieldInfoPtr__UnObtainedRecipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<UnObtainedRecipes>k__BackingField");
			CookController.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<Result>k__BackingField");
			CookController.NativeFieldInfoPtr__LastResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<LastResult>k__BackingField");
			CookController.NativeFieldInfoPtr__ChosenRecipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<ChosenRecipe>k__BackingField");
			CookController.NativeFieldInfoPtr__GridPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<GridPosition>k__BackingField");
			CookController.NativeFieldInfoPtr__GridIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<GridIndex>k__BackingField");
			CookController.NativeFieldInfoPtr_cookControllerWorkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "cookControllerWorkTime");
			CookController.NativeFieldInfoPtr_startCookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "startCookTime");
			CookController.NativeFieldInfoPtr_thisCookAllowInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController>.NativeClassPtr, "thisCookAllowInterrupt");
			CookController.NativeMethodInfoPtr_get_IsEmptyDesk_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673353);
			CookController.NativeMethodInfoPtr_set_IsEmptyDesk_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673354);
			CookController.NativeMethodInfoPtr_get_Phase_Public_get_CookPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673355);
			CookController.NativeMethodInfoPtr_set_Phase_Private_set_Void_CookPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673356);
			CookController.NativeMethodInfoPtr_get_Cooker_Public_get_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673357);
			CookController.NativeMethodInfoPtr_set_Cooker_Private_set_Void_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673358);
			CookController.NativeMethodInfoPtr_get_CookingProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673359);
			CookController.NativeMethodInfoPtr_set_CookingProgress_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673360);
			CookController.NativeMethodInfoPtr_get_ObtainedRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673361);
			CookController.NativeMethodInfoPtr_set_ObtainedRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673362);
			CookController.NativeMethodInfoPtr_get_UnObtainedRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673363);
			CookController.NativeMethodInfoPtr_set_UnObtainedRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673364);
			CookController.NativeMethodInfoPtr_get_ShownRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673365);
			CookController.NativeMethodInfoPtr_set_ShownRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673366);
			CookController.NativeMethodInfoPtr_get_Result_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673367);
			CookController.NativeMethodInfoPtr_set_Result_Private_set_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673368);
			CookController.NativeMethodInfoPtr_get_LastResult_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673369);
			CookController.NativeMethodInfoPtr_set_LastResult_Private_set_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673370);
			CookController.NativeMethodInfoPtr_get_ChosenRecipe_Public_get_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673371);
			CookController.NativeMethodInfoPtr_set_ChosenRecipe_Private_set_Void_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673372);
			CookController.NativeMethodInfoPtr_get_CookControllerWorkTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673373);
			CookController.NativeMethodInfoPtr_set_CookControllerWorkTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673374);
			CookController.NativeMethodInfoPtr_get_CookingAllowInterrupt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673375);
			CookController.NativeMethodInfoPtr_get_GridPosition_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673376);
			CookController.NativeMethodInfoPtr_set_GridPosition_Private_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673377);
			CookController.NativeMethodInfoPtr_get_GridIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673378);
			CookController.NativeMethodInfoPtr_set_GridIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673379);
			CookController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673380);
			CookController.NativeMethodInfoPtr_Initialize_Public_Void_Cooker_CookAnimator_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673381);
			CookController.NativeMethodInfoPtr_Initialize_Public_Void_CookAnimator_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673382);
			CookController.NativeMethodInfoPtr_SetCook_Public_Void_Sellable_Recipe_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673383);
			CookController.NativeMethodInfoPtr_GetTrueCookingTime_Public_Single_Sellable_Recipe_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673384);
			CookController.NativeMethodInfoPtr_UpdateCookControllerWorkTime_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673385);
			CookController.NativeMethodInfoPtr_GetFinalFood_Public_Sellable_Sellable_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673386);
			CookController.NativeMethodInfoPtr_get_CouldCookerOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673387);
			CookController.NativeMethodInfoPtr_get_CanCookerOpenByPartner_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673388);
			CookController.NativeMethodInfoPtr_StartCookCountDown_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673389);
			CookController.NativeMethodInfoPtr_ShowCookingVisual_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673390);
			CookController.NativeMethodInfoPtr_SetCookerProgressExtern_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673391);
			CookController.NativeMethodInfoPtr_InterruptCook_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673392);
			CookController.NativeMethodInfoPtr_FinishCooking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673393);
			CookController.NativeMethodInfoPtr_Store_Public_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673394);
			CookController.NativeMethodInfoPtr_Extract_Public_Void_Action_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673395);
			CookController.NativeMethodInfoPtr_AfterPlayerExtract_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673396);
			CookController.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673397);
			CookController.NativeMethodInfoPtr_CloseCookingVisual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673398);
			CookController.NativeMethodInfoPtr_OnCooking_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673399);
			CookController.NativeMethodInfoPtr_SolveQteMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673400);
			CookController.NativeMethodInfoPtr_CheckFailCook_Private_Boolean_Sellable_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673401);
			CookController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673402);
			CookController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController>.NativeClassPtr, 100673403);
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x00153C0C File Offset: 0x00151E0C
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00153C48 File Offset: 0x00151E48
		public unsafe bool IsEmptyDesk
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_IsEmptyDesk_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_IsEmptyDesk_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x00153C88 File Offset: 0x00151E88
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x00153CC4 File Offset: 0x00151EC4
		public unsafe CookController.CookPhase Phase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_Phase_Public_get_CookPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_Phase_Private_set_Void_CookPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x00153D04 File Offset: 0x00151F04
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x00153D44 File Offset: 0x00151F44
		public unsafe Cooker Cooker
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_Cooker_Public_get_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_Cooker_Private_set_Void_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x00153D88 File Offset: 0x00151F88
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x00153DC4 File Offset: 0x00151FC4
		public unsafe float CookingProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_CookingProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125168, XrefRangeEnd = 125170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_CookingProgress_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x00153E04 File Offset: 0x00152004
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x00153E44 File Offset: 0x00152044
		public unsafe Il2CppReferenceArray<Recipe> ObtainedRecipes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_ObtainedRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_ObtainedRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00153E88 File Offset: 0x00152088
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x00153EC8 File Offset: 0x001520C8
		public unsafe Il2CppReferenceArray<Recipe> UnObtainedRecipes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_UnObtainedRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_UnObtainedRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00153F0C File Offset: 0x0015210C
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x00153F4C File Offset: 0x0015214C
		public unsafe Il2CppReferenceArray<Recipe> ShownRecipes
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_ShownRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_ShownRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x00153F90 File Offset: 0x00152190
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x00153FD0 File Offset: 0x001521D0
		public unsafe Sellable Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_Result_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_Result_Private_set_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x00154014 File Offset: 0x00152214
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x00154054 File Offset: 0x00152254
		public unsafe Sellable LastResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_LastResult_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_LastResult_Private_set_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x00154098 File Offset: 0x00152298
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x001540D8 File Offset: 0x001522D8
		public unsafe Recipe ChosenRecipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_ChosenRecipe_Public_get_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_ChosenRecipe_Private_set_Void_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x0015411C File Offset: 0x0015231C
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x00154158 File Offset: 0x00152358
		public unsafe float CookControllerWorkTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_CookControllerWorkTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_CookControllerWorkTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x00154198 File Offset: 0x00152398
		public unsafe bool CookingAllowInterrupt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_CookingAllowInterrupt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x001541D4 File Offset: 0x001523D4
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x00154210 File Offset: 0x00152410
		public unsafe Vector3Int GridPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_GridPosition_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_GridPosition_Private_set_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x00154250 File Offset: 0x00152450
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x0015428C File Offset: 0x0015248C
		public unsafe int GridIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_GridIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_set_GridIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x001542CC File Offset: 0x001524CC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00154300 File Offset: 0x00152500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125225, RefRangeEnd = 125226, XrefRangeStart = 125170, XrefRangeEnd = 125225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cooker cooker, CookAnimator visual, Vector3Int gridPosition, int gridIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_Initialize_Public_Void_Cooker_CookAnimator_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00154370 File Offset: 0x00152570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125234, RefRangeEnd = 125235, XrefRangeStart = 125226, XrefRangeEnd = 125234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CookAnimator visual, Vector3Int gridPosition, int gridIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_Initialize_Public_Void_CookAnimator_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x001543D0 File Offset: 0x001525D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125270, RefRangeEnd = 125272, XrefRangeStart = 125235, XrefRangeEnd = 125270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCook(Sellable thisResult, Recipe recipe, bool thisCouldReturnIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisResult);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisCouldReturnIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_SetCook_Public_Void_Sellable_Recipe_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00154434 File Offset: 0x00152634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125282, RefRangeEnd = 125284, XrefRangeStart = 125272, XrefRangeEnd = 125282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTrueCookingTime(Sellable output, Recipe recipe, bool userType = true, bool usePlayerLevelProperty = true, bool useExtraCookTimeModifier = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePlayerLevelProperty;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useExtraCookTimeModifier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_GetTrueCookingTime_Public_Single_Sellable_Recipe_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x001544C0 File Offset: 0x001526C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125284, XrefRangeEnd = 125286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCookControllerWorkTime(float workTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref workTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_UpdateCookControllerWorkTime_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00154500 File Offset: 0x00152700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125291, RefRangeEnd = 125293, XrefRangeStart = 125286, XrefRangeEnd = 125291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable GetFinalFood(Sellable result, out bool isRequestedFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isRequestedFood;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_GetFinalFood_Public_Sellable_Sellable_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x00154560 File Offset: 0x00152760
		public unsafe bool CouldCookerOpen
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 125297, RefRangeEnd = 125299, XrefRangeStart = 125293, XrefRangeEnd = 125297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_CouldCookerOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x0015459C File Offset: 0x0015279C
		public unsafe bool CanCookerOpenByPartner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125299, XrefRangeEnd = 125301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_get_CanCookerOpenByPartner_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x001545D8 File Offset: 0x001527D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125335, RefRangeEnd = 125338, XrefRangeStart = 125301, XrefRangeEnd = 125335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCookCountDown(float qteScore, bool allowInterrupt = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qteScore;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInterrupt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_StartCookCountDown_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00154624 File Offset: 0x00152824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125346, RefRangeEnd = 125348, XrefRangeStart = 125338, XrefRangeEnd = 125346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCookingVisual(Sprite outputIcon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputIcon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_ShowCookingVisual_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00154668 File Offset: 0x00152868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCookerProgressExtern(float overrideProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_SetCookerProgressExtern_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x001546A8 File Offset: 0x001528A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 125351, RefRangeEnd = 125357, XrefRangeStart = 125348, XrefRangeEnd = 125351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InterruptCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_InterruptCook_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x001546DC File Offset: 0x001528DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125509, RefRangeEnd = 125510, XrefRangeStart = 125357, XrefRangeEnd = 125509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCooking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_FinishCooking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00154710 File Offset: 0x00152910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125517, RefRangeEnd = 125519, XrefRangeStart = 125510, XrefRangeEnd = 125517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Store(Sellable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_Store_Public_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00154754 File Offset: 0x00152954
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125544, RefRangeEnd = 125548, XrefRangeStart = 125519, XrefRangeEnd = 125544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Extract(Action<Sellable> targetAssignmentCallBack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetAssignmentCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_Extract_Public_Void_Action_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00154798 File Offset: 0x00152998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125548, XrefRangeEnd = 125550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterPlayerExtract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_AfterPlayerExtract_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x001547CC File Offset: 0x001529CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125550, XrefRangeEnd = 125552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WhenPlayerTryExtractWithFullTray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00154800 File Offset: 0x00152A00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125562, RefRangeEnd = 125566, XrefRangeStart = 125552, XrefRangeEnd = 125562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseCookingVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_CloseCookingVisual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00154834 File Offset: 0x00152A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125566, XrefRangeEnd = 125571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnCooking(float cookingDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookingDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_OnCooking_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00154880 File Offset: 0x00152A80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125571, RefRangeEnd = 125572, XrefRangeStart = 125571, XrefRangeEnd = 125571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float SolveQteMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_SolveQteMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x001548BC File Offset: 0x00152ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125572, XrefRangeEnd = 125586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckFailCook(Sellable food, float qteScore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qteScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr_CheckFailCook_Private_Boolean_Sellable_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00154918 File Offset: 0x00152B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125586, XrefRangeEnd = 125602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00154954 File Offset: 0x00152B54
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x0001D479 File Offset: 0x0001B679
		public CookController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x00154990 File Offset: 0x00152B90
		// (set) Token: 0x060034DB RID: 13531 RVA: 0x0001D482 File Offset: 0x0001B682
		public unsafe CookAnimator visual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_visual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x001549C0 File Offset: 0x00152BC0
		// (set) Token: 0x060034DD RID: 13533 RVA: 0x0001D4A1 File Offset: 0x0001B6A1
		public unsafe CookingStatusModule onStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_onStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookingStatusModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_onStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x001549F0 File Offset: 0x00152BF0
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		public unsafe AudioClip start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x00154A20 File Offset: 0x00152C20
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x0001D4DF File Offset: 0x0001B6DF
		public unsafe SpriteRenderer sellableShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_sellableShadow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_sellableShadow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x00154A50 File Offset: 0x00152C50
		// (set) Token: 0x060034E3 RID: 13539 RVA: 0x0001D4FE File Offset: 0x0001B6FE
		public unsafe SpriteRenderer steam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_steam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_steam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x00154A80 File Offset: 0x00152C80
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x0001D51D File Offset: 0x0001B71D
		public unsafe SpriteRenderer result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x00154AB0 File Offset: 0x00152CB0
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x0001D53C File Offset: 0x0001B73C
		public unsafe SpriteRenderer resultVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_resultVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_resultVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x00154AE0 File Offset: 0x00152CE0
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x0001D55B File Offset: 0x0001B75B
		public unsafe Color normalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_normalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_normalColor)) = value;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x00154B08 File Offset: 0x00152D08
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x0001D576 File Offset: 0x0001B776
		public unsafe Color failedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_failedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_failedColor)) = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x00154B30 File Offset: 0x00152D30
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x0001D591 File Offset: 0x0001B791
		public unsafe float cookingProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_cookingProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_cookingProgress)) = value;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x00154B58 File Offset: 0x00152D58
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x0001D5AC File Offset: 0x0001B7AC
		public unsafe float cookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_cookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_cookTime)) = value;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x00154B80 File Offset: 0x00152D80
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x0001D5C7 File Offset: 0x0001B7C7
		public unsafe bool couldReturnIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_couldReturnIngredients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_couldReturnIngredients)) = value;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x00154BA8 File Offset: 0x00152DA8
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x0001D5E2 File Offset: 0x0001B7E2
		public unsafe Coroutine onCookingCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_onCookingCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_onCookingCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x00154BD8 File Offset: 0x00152DD8
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x0001D601 File Offset: 0x0001B801
		public unsafe float qteScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_qteScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_qteScore)) = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x00154C00 File Offset: 0x00152E00
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x0001D61C File Offset: 0x0001B81C
		public unsafe Il2CppReferenceArray<Recipe> shownRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_shownRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_shownRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x00154C30 File Offset: 0x00152E30
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x0001D63B File Offset: 0x0001B83B
		public unsafe bool _IsEmptyDesk_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__IsEmptyDesk_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__IsEmptyDesk_k__BackingField)) = value;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x00154C58 File Offset: 0x00152E58
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x0001D656 File Offset: 0x0001B856
		public unsafe CookController.CookPhase _Phase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__Phase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__Phase_k__BackingField)) = value;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x00154C80 File Offset: 0x00152E80
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x0001D671 File Offset: 0x0001B871
		public unsafe Cooker _Cooker_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__Cooker_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__Cooker_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x00154CB0 File Offset: 0x00152EB0
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x0001D690 File Offset: 0x0001B890
		public unsafe Il2CppReferenceArray<Recipe> _ObtainedRecipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__ObtainedRecipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__ObtainedRecipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x00154CE0 File Offset: 0x00152EE0
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x0001D6AF File Offset: 0x0001B8AF
		public unsafe Il2CppReferenceArray<Recipe> _UnObtainedRecipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__UnObtainedRecipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__UnObtainedRecipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x00154D10 File Offset: 0x00152F10
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x0001D6CE File Offset: 0x0001B8CE
		public unsafe Sellable _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x00154D40 File Offset: 0x00152F40
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x0001D6ED File Offset: 0x0001B8ED
		public unsafe Sellable _LastResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__LastResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__LastResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x00154D70 File Offset: 0x00152F70
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x0001D70C File Offset: 0x0001B90C
		public unsafe Recipe _ChosenRecipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__ChosenRecipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__ChosenRecipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x00154DA0 File Offset: 0x00152FA0
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x0001D72B File Offset: 0x0001B92B
		public unsafe Vector3Int _GridPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__GridPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__GridPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x00154DC8 File Offset: 0x00152FC8
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x0001D746 File Offset: 0x0001B946
		public unsafe int _GridIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__GridIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr__GridIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x00154DF0 File Offset: 0x00152FF0
		// (set) Token: 0x0600350D RID: 13581 RVA: 0x0001D761 File Offset: 0x0001B961
		public unsafe float cookControllerWorkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_cookControllerWorkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_cookControllerWorkTime)) = value;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x00154E18 File Offset: 0x00153018
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x0001D77C File Offset: 0x0001B97C
		public unsafe float startCookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_startCookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_startCookTime)) = value;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x00154E40 File Offset: 0x00153040
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x0001D797 File Offset: 0x0001B997
		public unsafe bool thisCookAllowInterrupt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_thisCookAllowInterrupt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.NativeFieldInfoPtr_thisCookAllowInterrupt)) = value;
			}
		}

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeFieldInfoPtr_visual;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeFieldInfoPtr_onStatus;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeFieldInfoPtr_sellableShadow;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeFieldInfoPtr_steam;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeFieldInfoPtr_resultVisual;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeFieldInfoPtr_normalColor;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeFieldInfoPtr_failedColor;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeFieldInfoPtr_cookingProgress;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeFieldInfoPtr_cookTime;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeFieldInfoPtr_couldReturnIngredients;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeFieldInfoPtr_onCookingCoroutine;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeFieldInfoPtr_qteScore;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeFieldInfoPtr_shownRecipes;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeFieldInfoPtr__IsEmptyDesk_k__BackingField;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeFieldInfoPtr__Phase_k__BackingField;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeFieldInfoPtr__Cooker_k__BackingField;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeFieldInfoPtr__ObtainedRecipes_k__BackingField;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeFieldInfoPtr__UnObtainedRecipes_k__BackingField;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeFieldInfoPtr__LastResult_k__BackingField;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeFieldInfoPtr__ChosenRecipe_k__BackingField;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeFieldInfoPtr__GridPosition_k__BackingField;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeFieldInfoPtr__GridIndex_k__BackingField;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeFieldInfoPtr_cookControllerWorkTime;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeFieldInfoPtr_startCookTime;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeFieldInfoPtr_thisCookAllowInterrupt;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyDesk_Public_get_Boolean_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEmptyDesk_Private_set_Void_Boolean_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_get_Phase_Public_get_CookPhase_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_set_Phase_Private_set_Void_CookPhase_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_get_Cooker_Public_get_Cooker_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_set_Cooker_Private_set_Void_Cooker_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr_get_CookingProgress_Public_get_Single_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_set_CookingProgress_Private_set_Void_Single_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_get_ObtainedRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_set_ObtainedRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_get_UnObtainedRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_set_UnObtainedRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_get_ShownRecipes_Public_get_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_set_ShownRecipes_Public_set_Void_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Sellable_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_Sellable_0;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeMethodInfoPtr_get_LastResult_Public_get_Sellable_0;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeMethodInfoPtr_set_LastResult_Private_set_Void_Sellable_0;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenRecipe_Public_get_Recipe_0;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeMethodInfoPtr_set_ChosenRecipe_Private_set_Void_Recipe_0;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeMethodInfoPtr_get_CookControllerWorkTime_Public_get_Single_0;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr_set_CookControllerWorkTime_Public_set_Void_Single_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_get_CookingAllowInterrupt_Public_get_Boolean_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_get_GridPosition_Public_get_Vector3Int_0;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_set_GridPosition_Private_set_Void_Vector3Int_0;

		// Token: 0x040023C0 RID: 9152
		private static readonly IntPtr NativeMethodInfoPtr_get_GridIndex_Public_get_Int32_0;

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeMethodInfoPtr_set_GridIndex_Private_set_Void_Int32_0;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cooker_CookAnimator_Vector3Int_Int32_0;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CookAnimator_Vector3Int_Int32_0;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeMethodInfoPtr_SetCook_Public_Void_Sellable_Recipe_Boolean_0;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeMethodInfoPtr_GetTrueCookingTime_Public_Single_Sellable_Recipe_Boolean_Boolean_Boolean_0;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCookControllerWorkTime_Private_Void_Single_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFood_Public_Sellable_Sellable_byref_Boolean_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr_get_CouldCookerOpen_Public_get_Boolean_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr_get_CanCookerOpenByPartner_Public_get_Boolean_0;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr_StartCookCountDown_Public_Void_Single_Boolean_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_ShowCookingVisual_Public_Void_Sprite_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_SetCookerProgressExtern_Public_Void_Single_0;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeMethodInfoPtr_InterruptCook_Public_Void_0;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeMethodInfoPtr_FinishCooking_Public_Void_0;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Void_Sellable_0;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Void_Action_1_Sellable_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr_AfterPlayerExtract_Public_Void_0;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Void_0;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_CloseCookingVisual_Public_Void_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr_OnCooking_Private_IEnumerator_Single_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_SolveQteMultiplier_Public_Single_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr_CheckFailCook_Private_Boolean_Sellable_Single_0;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000905 RID: 2309
		public enum CookPhase
		{
			// Token: 0x0400764E RID: 30286
			Idle,
			// Token: 0x0400764F RID: 30287
			Loaded,
			// Token: 0x04007650 RID: 30288
			Cooking,
			// Token: 0x04007651 RID: 30289
			Finished
		}

		// Token: 0x02000906 RID: 2310
		[ObfuscatedName("NightScene.CookingUtility.CookController+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B6AD RID: 46765 RVA: 0x002E58B4 File Offset: 0x002E3AB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<CookController.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookController.__c__DisplayClass71_0>.NativeClassPtr);
				CookController.__c__DisplayClass71_0.NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c__DisplayClass71_0>.NativeClassPtr, "cooker");
				CookController.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c__DisplayClass71_0>.NativeClassPtr, 100673404);
				CookController.__c__DisplayClass71_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c__DisplayClass71_0>.NativeClassPtr, 100673405);
			}

			// Token: 0x0600B6AE RID: 46766 RVA: 0x002E591C File Offset: 0x002E3B1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookController.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6AF RID: 46767 RVA: 0x002E5958 File Offset: 0x002E3B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125095, XrefRangeEnd = 125100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__1(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c__DisplayClass71_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6B0 RID: 46768 RVA: 0x000627AB File Offset: 0x000609AB
			public __c__DisplayClass71_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE5 RID: 15333
			// (get) Token: 0x0600B6B1 RID: 46769 RVA: 0x002E59A8 File Offset: 0x002E3BA8
			// (set) Token: 0x0600B6B2 RID: 46770 RVA: 0x000627B4 File Offset: 0x000609B4
			public unsafe Cooker cooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.__c__DisplayClass71_0.NativeFieldInfoPtr_cooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.__c__DisplayClass71_0.NativeFieldInfoPtr_cooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007652 RID: 30290
			private static readonly IntPtr NativeFieldInfoPtr_cooker;

			// Token: 0x04007653 RID: 30291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007654 RID: 30292
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__1_Internal_Boolean_Recipe_0;
		}

		// Token: 0x02000907 RID: 2311
		[ObfuscatedName("NightScene.CookingUtility.CookController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B6B3 RID: 46771 RVA: 0x002E59D8 File Offset: 0x002E3BD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CookController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr);
				CookController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, "<>9");
				CookController.__c.NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, "<>9__71_0");
				CookController.__c.NativeFieldInfoPtr___9__85_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, "<>9__85_0");
				CookController.__c.NativeFieldInfoPtr___9__85_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, "<>9__85_1");
				CookController.__c.NativeFieldInfoPtr___9__85_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, "<>9__85_2");
				CookController.__c.NativeFieldInfoPtr___9__85_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, "<>9__85_3");
				CookController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, 100673407);
				CookController.__c.NativeMethodInfoPtr__Initialize_b__71_0_Internal_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, 100673408);
				CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, 100673409);
				CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_1_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, 100673410);
				CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_2_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, 100673411);
				CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_3_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr, 100673412);
			}

			// Token: 0x0600B6B4 RID: 46772 RVA: 0x002E5AF4 File Offset: 0x002E3CF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6B5 RID: 46773 RVA: 0x002E5B30 File Offset: 0x002E3D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe _Initialize_b__71_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c.NativeMethodInfoPtr__Initialize_b__71_0_Internal_Recipe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600B6B6 RID: 46774 RVA: 0x002E5B7C File Offset: 0x002E3D7C
			[CallerCount(0)]
			public unsafe int _FinishCooking_b__85_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6B7 RID: 46775 RVA: 0x002E5BC8 File Offset: 0x002E3DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125100, XrefRangeEnd = 125113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FinishCooking_b__85_1(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_1_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6B8 RID: 46776 RVA: 0x002E5C0C File Offset: 0x002E3E0C
			[CallerCount(0)]
			public unsafe float _FinishCooking_b__85_2(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_2_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6B9 RID: 46777 RVA: 0x002E5C58 File Offset: 0x002E3E58
			[CallerCount(0)]
			public unsafe float _FinishCooking_b__85_3(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c.NativeMethodInfoPtr__FinishCooking_b__85_3_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6BA RID: 46778 RVA: 0x000627D3 File Offset: 0x000609D3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE6 RID: 15334
			// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x002E5CA4 File Offset: 0x002E3EA4
			// (set) Token: 0x0600B6BC RID: 46780 RVA: 0x000627DC File Offset: 0x000609DC
			public unsafe static CookController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE7 RID: 15335
			// (get) Token: 0x0600B6BD RID: 46781 RVA: 0x002E5CCC File Offset: 0x002E3ECC
			// (set) Token: 0x0600B6BE RID: 46782 RVA: 0x000627EE File Offset: 0x000609EE
			public unsafe static Func<int, Recipe> __9__71_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookController.__c.NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookController.__c.NativeFieldInfoPtr___9__71_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE8 RID: 15336
			// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x002E5CF4 File Offset: 0x002E3EF4
			// (set) Token: 0x0600B6C0 RID: 46784 RVA: 0x00062800 File Offset: 0x00060A00
			public unsafe static Func<int, int> __9__85_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookController.__c.NativeFieldInfoPtr___9__85_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookController.__c.NativeFieldInfoPtr___9__85_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE9 RID: 15337
			// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x002E5D1C File Offset: 0x002E3F1C
			// (set) Token: 0x0600B6C2 RID: 46786 RVA: 0x00062812 File Offset: 0x00060A12
			public unsafe static Action<AchievementNotifyResult> __9__85_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookController.__c.NativeFieldInfoPtr___9__85_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookController.__c.NativeFieldInfoPtr___9__85_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEA RID: 15338
			// (get) Token: 0x0600B6C3 RID: 46787 RVA: 0x002E5D44 File Offset: 0x002E3F44
			// (set) Token: 0x0600B6C4 RID: 46788 RVA: 0x00062824 File Offset: 0x00060A24
			public unsafe static Func<float, float> __9__85_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookController.__c.NativeFieldInfoPtr___9__85_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookController.__c.NativeFieldInfoPtr___9__85_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEB RID: 15339
			// (get) Token: 0x0600B6C5 RID: 46789 RVA: 0x002E5D6C File Offset: 0x002E3F6C
			// (set) Token: 0x0600B6C6 RID: 46790 RVA: 0x00062836 File Offset: 0x00060A36
			public unsafe static Func<float, float> __9__85_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookController.__c.NativeFieldInfoPtr___9__85_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookController.__c.NativeFieldInfoPtr___9__85_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007655 RID: 30293
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007656 RID: 30294
			private static readonly IntPtr NativeFieldInfoPtr___9__71_0;

			// Token: 0x04007657 RID: 30295
			private static readonly IntPtr NativeFieldInfoPtr___9__85_0;

			// Token: 0x04007658 RID: 30296
			private static readonly IntPtr NativeFieldInfoPtr___9__85_1;

			// Token: 0x04007659 RID: 30297
			private static readonly IntPtr NativeFieldInfoPtr___9__85_2;

			// Token: 0x0400765A RID: 30298
			private static readonly IntPtr NativeFieldInfoPtr___9__85_3;

			// Token: 0x0400765B RID: 30299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400765C RID: 30300
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__71_0_Internal_Recipe_Int32_0;

			// Token: 0x0400765D RID: 30301
			private static readonly IntPtr NativeMethodInfoPtr__FinishCooking_b__85_0_Internal_Int32_Int32_0;

			// Token: 0x0400765E RID: 30302
			private static readonly IntPtr NativeMethodInfoPtr__FinishCooking_b__85_1_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x0400765F RID: 30303
			private static readonly IntPtr NativeMethodInfoPtr__FinishCooking_b__85_2_Internal_Single_Single_0;

			// Token: 0x04007660 RID: 30304
			private static readonly IntPtr NativeMethodInfoPtr__FinishCooking_b__85_3_Internal_Single_Single_0;
		}

		// Token: 0x02000908 RID: 2312
		[ObfuscatedName("NightScene.CookingUtility.CookController+<OnCooking>d__91")]
		public sealed class _OnCooking_d__91 : Il2CppSystem.Object
		{
			// Token: 0x0600B6C7 RID: 46791 RVA: 0x002E5D94 File Offset: 0x002E3F94
			// Note: this type is marked as 'beforefieldinit'.
			static _OnCooking_d__91()
			{
				Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<OnCooking>d__91");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr);
				CookController._OnCooking_d__91.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, "<>1__state");
				CookController._OnCooking_d__91.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, "<>2__current");
				CookController._OnCooking_d__91.NativeFieldInfoPtr_cookingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, "cookingDuration");
				CookController._OnCooking_d__91.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, "<>4__this");
				CookController._OnCooking_d__91.NativeFieldInfoPtr__startCookingTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, "<startCookingTime>5__2");
				CookController._OnCooking_d__91.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, 100673413);
				CookController._OnCooking_d__91.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, 100673414);
				CookController._OnCooking_d__91.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, 100673415);
				CookController._OnCooking_d__91.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, 100673416);
				CookController._OnCooking_d__91.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, 100673417);
				CookController._OnCooking_d__91.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr, 100673418);
			}

			// Token: 0x0600B6C8 RID: 46792 RVA: 0x002E5E9C File Offset: 0x002E409C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnCooking_d__91(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookController._OnCooking_d__91>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController._OnCooking_d__91.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6C9 RID: 46793 RVA: 0x002E5EE4 File Offset: 0x002E40E4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController._OnCooking_d__91.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6CA RID: 46794 RVA: 0x002E5F18 File Offset: 0x002E4118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125113, XrefRangeEnd = 125114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController._OnCooking_d__91.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003BF1 RID: 15345
			// (get) Token: 0x0600B6CB RID: 46795 RVA: 0x002E5F54 File Offset: 0x002E4154
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController._OnCooking_d__91.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B6CC RID: 46796 RVA: 0x002E5F94 File Offset: 0x002E4194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125114, XrefRangeEnd = 125120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController._OnCooking_d__91.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BF2 RID: 15346
			// (get) Token: 0x0600B6CD RID: 46797 RVA: 0x002E5FC8 File Offset: 0x002E41C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController._OnCooking_d__91.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B6CE RID: 46798 RVA: 0x00062848 File Offset: 0x00060A48
			public _OnCooking_d__91(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BEC RID: 15340
			// (get) Token: 0x0600B6CF RID: 46799 RVA: 0x002E6008 File Offset: 0x002E4208
			// (set) Token: 0x0600B6D0 RID: 46800 RVA: 0x00062851 File Offset: 0x00060A51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003BED RID: 15341
			// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x002E6030 File Offset: 0x002E4230
			// (set) Token: 0x0600B6D2 RID: 46802 RVA: 0x0006286C File Offset: 0x00060A6C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEE RID: 15342
			// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x002E6060 File Offset: 0x002E4260
			// (set) Token: 0x0600B6D4 RID: 46804 RVA: 0x0006288B File Offset: 0x00060A8B
			public unsafe float cookingDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr_cookingDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr_cookingDuration)) = value;
				}
			}

			// Token: 0x17003BEF RID: 15343
			// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x002E6088 File Offset: 0x002E4288
			// (set) Token: 0x0600B6D6 RID: 46806 RVA: 0x000628A6 File Offset: 0x00060AA6
			public unsafe CookController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF0 RID: 15344
			// (get) Token: 0x0600B6D7 RID: 46807 RVA: 0x002E60B8 File Offset: 0x002E42B8
			// (set) Token: 0x0600B6D8 RID: 46808 RVA: 0x000628C5 File Offset: 0x00060AC5
			public unsafe float _startCookingTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr__startCookingTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController._OnCooking_d__91.NativeFieldInfoPtr__startCookingTime_5__2)) = value;
				}
			}

			// Token: 0x04007661 RID: 30305
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007662 RID: 30306
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007663 RID: 30307
			private static readonly IntPtr NativeFieldInfoPtr_cookingDuration;

			// Token: 0x04007664 RID: 30308
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007665 RID: 30309
			private static readonly IntPtr NativeFieldInfoPtr__startCookingTime_5__2;

			// Token: 0x04007666 RID: 30310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007667 RID: 30311
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007668 RID: 30312
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007669 RID: 30313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400766A RID: 30314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400766B RID: 30315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000909 RID: 2313
		[ObfuscatedName("NightScene.CookingUtility.CookController+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B6D9 RID: 46809 RVA: 0x002E60E0 File Offset: 0x002E42E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookController>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr);
				CookController.__c__DisplayClass93_0.NativeFieldInfoPtr_food = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr, "food");
				CookController.__c__DisplayClass93_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr, "<>9__1");
				CookController.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr, 100673419);
				CookController.__c__DisplayClass93_0.NativeMethodInfoPtr__CheckFailCook_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr, 100673420);
				CookController.__c__DisplayClass93_0.NativeMethodInfoPtr__CheckFailCook_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr, 100673421);
			}

			// Token: 0x0600B6DA RID: 46810 RVA: 0x002E6170 File Offset: 0x002E4370
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookController.__c__DisplayClass93_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6DB RID: 46811 RVA: 0x002E61AC File Offset: 0x002E43AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125120, XrefRangeEnd = 125132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckFailCook_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c__DisplayClass93_0.NativeMethodInfoPtr__CheckFailCook_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6DC RID: 46812 RVA: 0x002E61F8 File Offset: 0x002E43F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125132, XrefRangeEnd = 125168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckFailCook_b__1(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookController.__c__DisplayClass93_0.NativeMethodInfoPtr__CheckFailCook_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6DD RID: 46813 RVA: 0x000628E0 File Offset: 0x00060AE0
			public __c__DisplayClass93_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF3 RID: 15347
			// (get) Token: 0x0600B6DE RID: 46814 RVA: 0x002E6244 File Offset: 0x002E4444
			// (set) Token: 0x0600B6DF RID: 46815 RVA: 0x000628E9 File Offset: 0x00060AE9
			public unsafe Sellable food
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.__c__DisplayClass93_0.NativeFieldInfoPtr_food);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.__c__DisplayClass93_0.NativeFieldInfoPtr_food), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF4 RID: 15348
			// (get) Token: 0x0600B6E0 RID: 46816 RVA: 0x002E6274 File Offset: 0x002E4474
			// (set) Token: 0x0600B6E1 RID: 46817 RVA: 0x00062908 File Offset: 0x00060B08
			public unsafe Func<int, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.__c__DisplayClass93_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookController.__c__DisplayClass93_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400766C RID: 30316
			private static readonly IntPtr NativeFieldInfoPtr_food;

			// Token: 0x0400766D RID: 30317
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400766E RID: 30318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400766F RID: 30319
			private static readonly IntPtr NativeMethodInfoPtr__CheckFailCook_b__0_Internal_Boolean_Int32_0;

			// Token: 0x04007670 RID: 30320
			private static readonly IntPtr NativeMethodInfoPtr__CheckFailCook_b__1_Internal_Boolean_Int32_0;
		}
	}
}
