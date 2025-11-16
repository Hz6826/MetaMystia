using System;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Night.UI.HUD
{
	// Token: 0x02000050 RID: 80
	public class IncomeControllerRogueLike : IncomeController
	{
		// Token: 0x06000A20 RID: 2592 RVA: 0x000BE3CC File Offset: 0x000BC5CC
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerRogueLike()
		{
			Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.UI.HUD", "IncomeControllerRogueLike");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr);
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_TargetIncomeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_TargetIncomeValue");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_Progress");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_CompletionMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_CompletionMark");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerTitleMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_TriggerTitleMapping");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerFinishColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_TriggerFinishColor");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_RoundWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_RoundWave");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_PoolButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_PoolButton");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_PoolCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_PoolCanvasGroup");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_FinalFundCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_FinalFundCanvasGroup");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_WorkFundCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_WorkFundCanvasGroup");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_FinalFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_FinalFund");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_BossDesCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_BossDesCanvasGroup");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_TargetRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_TargetRequirement");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerTitlesDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_TriggerTitlesDic");
			IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerFinalTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "m_TriggerFinalTarget");
			IncomeControllerRogueLike.NativeFieldInfoPtr__SetPoolCanNotActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "<SetPoolCanNotActive>k__BackingField");
			IncomeControllerRogueLike.NativeMethodInfoPtr_get_SetPoolCanNotActive_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664955);
			IncomeControllerRogueLike.NativeMethodInfoPtr_set_SetPoolCanNotActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664956);
			IncomeControllerRogueLike.NativeMethodInfoPtr_set_TargetRequirement_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664957);
			IncomeControllerRogueLike.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664958);
			IncomeControllerRogueLike.NativeMethodInfoPtr_SetPoolActiveInst_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664959);
			IncomeControllerRogueLike.NativeMethodInfoPtr_SetInPoolActiveInst_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664960);
			IncomeControllerRogueLike.NativeMethodInfoPtr_SetPoolButton_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664961);
			IncomeControllerRogueLike.NativeMethodInfoPtr_SetFinalTarget_Public_Void_TriggerCardCondition_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664962);
			IncomeControllerRogueLike.NativeMethodInfoPtr_SetFinalTargetAndRefresh_Public_Void_TriggerCardCondition_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664963);
			IncomeControllerRogueLike.NativeMethodInfoPtr_UpdateTriggerStatus_Public_Void_TriggerCardCondition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664964);
			IncomeControllerRogueLike.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664965);
			IncomeControllerRogueLike.NativeMethodInfoPtr_UpdateRoundNum_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664966);
			IncomeControllerRogueLike.NativeMethodInfoPtr_Settle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664967);
			IncomeControllerRogueLike.NativeMethodInfoPtr_SetRogueFund_Public_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664968);
			IncomeControllerRogueLike.NativeMethodInfoPtr_ActiveRogueBossDescrption_Public_GameObject_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664969);
			IncomeControllerRogueLike.NativeMethodInfoPtr_HideBossDescription_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664970);
			IncomeControllerRogueLike.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664971);
			IncomeControllerRogueLike.NativeMethodInfoPtr__SetPoolButton_b__25_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664972);
			IncomeControllerRogueLike.NativeMethodInfoPtr__SetPoolButton_b__25_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, 100664973);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000BE6B8 File Offset: 0x000BC8B8
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x000BE6F4 File Offset: 0x000BC8F4
		public unsafe bool SetPoolCanNotActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_get_SetPoolCanNotActive_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_set_SetPoolCanNotActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000352 RID: 850
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000BE734 File Offset: 0x000BC934
		public unsafe int TargetRequirement
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39491, RefRangeEnd = 39492, XrefRangeStart = 39485, XrefRangeEnd = 39491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_set_TargetRequirement_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000BE774 File Offset: 0x000BC974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39492, XrefRangeEnd = 39561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerRogueLike.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000BE7B0 File Offset: 0x000BC9B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39562, RefRangeEnd = 39563, XrefRangeStart = 39561, XrefRangeEnd = 39562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoolActiveInst()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_SetPoolActiveInst_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000BE7E4 File Offset: 0x000BC9E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39564, RefRangeEnd = 39566, XrefRangeStart = 39563, XrefRangeEnd = 39564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInPoolActiveInst()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_SetInPoolActiveInst_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000BE818 File Offset: 0x000BCA18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39591, RefRangeEnd = 39592, XrefRangeStart = 39566, XrefRangeEnd = 39591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoolButton(Action onPoolButtonPressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPoolButtonPressed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_SetPoolButton_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000BE85C File Offset: 0x000BCA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39604, RefRangeEnd = 39606, XrefRangeStart = 39592, XrefRangeEnd = 39604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFinalTarget(TriggerCardCondition triggerCardCondition, int target, bool hasNextLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerCardCondition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasNextLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_SetFinalTarget_Public_Void_TriggerCardCondition_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000BE8B8 File Offset: 0x000BCAB8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 39621, RefRangeEnd = 39627, XrefRangeStart = 39606, XrefRangeEnd = 39621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFinalTargetAndRefresh(TriggerCardCondition triggerCardCondition, int target, bool hasNextLevel, int current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerCardCondition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasNextLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_SetFinalTargetAndRefresh_Public_Void_TriggerCardCondition_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000BE920 File Offset: 0x000BCB20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 39717, RefRangeEnd = 39724, XrefRangeStart = 39627, XrefRangeEnd = 39717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTriggerStatus(TriggerCardCondition triggerCardCondition, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerCardCondition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_UpdateTriggerStatus_Public_Void_TriggerCardCondition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000BE96C File Offset: 0x000BCB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39724, XrefRangeEnd = 39732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFundUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerRogueLike.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000BE9A8 File Offset: 0x000BCBA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39749, RefRangeEnd = 39750, XrefRangeStart = 39732, XrefRangeEnd = 39749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRoundNum(int currentNum, int maxNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentNum;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_UpdateRoundNum_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000BE9F4 File Offset: 0x000BCBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39752, RefRangeEnd = 39753, XrefRangeStart = 39750, XrefRangeEnd = 39752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Settle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_Settle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000BEA28 File Offset: 0x000BCC28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39754, RefRangeEnd = 39756, XrefRangeStart = 39753, XrefRangeEnd = 39754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRogueFund(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_SetRogueFund_Public_Void_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000BEA6C File Offset: 0x000BCC6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 39776, RefRangeEnd = 39783, XrefRangeStart = 39756, XrefRangeEnd = 39776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject ActiveRogueBossDescrption(RogueLikeRunTimeData.EliteChallengeBase challengeBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(challengeBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_ActiveRogueBossDescrption_Public_GameObject_EliteChallengeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000BEABC File Offset: 0x000BCCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39784, RefRangeEnd = 39785, XrefRangeStart = 39783, XrefRangeEnd = 39784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideBossDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr_HideBossDescription_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000BEAF0 File Offset: 0x000BCCF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerRogueLike() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000BEB2C File Offset: 0x000BCD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39785, XrefRangeEnd = 39787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetPoolButton_b__25_0(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr__SetPoolButton_b__25_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000BEB74 File Offset: 0x000BCD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39787, XrefRangeEnd = 39789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetPoolButton_b__25_1(bool isopen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isopen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.NativeMethodInfoPtr__SetPoolButton_b__25_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00007A8B File Offset: 0x00005C8B
		public IncomeControllerRogueLike(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000BEBB4 File Offset: 0x000BCDB4
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00007A94 File Offset: 0x00005C94
		public unsafe TextMeshProUGUI m_TargetIncomeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TargetIncomeValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TargetIncomeValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000BEBE4 File Offset: 0x000BCDE4
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00007AB3 File Offset: 0x00005CB3
		public unsafe Image m_Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_Progress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_Progress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000BEC14 File Offset: 0x000BCE14
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00007AD2 File Offset: 0x00005CD2
		public unsafe Image m_CompletionMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_CompletionMark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_CompletionMark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000BEC44 File Offset: 0x000BCE44
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public unsafe Il2CppReferenceArray<IncomeControllerRogueLike.TriggerTitle> m_TriggerTitleMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerTitleMapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IncomeControllerRogueLike.TriggerTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerTitleMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x000BEC74 File Offset: 0x000BCE74
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00007B10 File Offset: 0x00005D10
		public unsafe Color m_TriggerFinishColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerFinishColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerFinishColor)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x000BEC9C File Offset: 0x000BCE9C
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00007B2B File Offset: 0x00005D2B
		public unsafe TextMeshProUGUI m_RoundWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_RoundWave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_RoundWave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x000BECCC File Offset: 0x000BCECC
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00007B4A File Offset: 0x00005D4A
		public unsafe UIButtonSimple m_PoolButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_PoolButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_PoolButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000BECFC File Offset: 0x000BCEFC
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00007B69 File Offset: 0x00005D69
		public unsafe CanvasGroup m_PoolCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_PoolCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_PoolCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000BED2C File Offset: 0x000BCF2C
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00007B88 File Offset: 0x00005D88
		public unsafe CanvasGroup m_FinalFundCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_FinalFundCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_FinalFundCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000BED5C File Offset: 0x000BCF5C
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00007BA7 File Offset: 0x00005DA7
		public unsafe CanvasGroup m_WorkFundCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_WorkFundCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_WorkFundCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000BED8C File Offset: 0x000BCF8C
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00007BC6 File Offset: 0x00005DC6
		public unsafe TextMeshProUGUI m_FinalFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_FinalFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_FinalFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000BEDBC File Offset: 0x000BCFBC
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00007BE5 File Offset: 0x00005DE5
		public unsafe CanvasGroup m_BossDesCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_BossDesCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_BossDesCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x000BEDEC File Offset: 0x000BCFEC
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00007C04 File Offset: 0x00005E04
		public unsafe int m_TargetRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TargetRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TargetRequirement)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x000BEE14 File Offset: 0x000BD014
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00007C1F File Offset: 0x00005E1F
		public unsafe Dictionary<TriggerCardCondition, IncomeControllerRogueLike.TriggerTitle> m_TriggerTitlesDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerTitlesDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TriggerCardCondition, IncomeControllerRogueLike.TriggerTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerTitlesDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000BEE44 File Offset: 0x000BD044
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00007C3E File Offset: 0x00005E3E
		public unsafe Dictionary<TriggerCardCondition, ValueTuple<int, int, bool>> m_TriggerFinalTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerFinalTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TriggerCardCondition, ValueTuple<int, int, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr_m_TriggerFinalTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000BEE74 File Offset: 0x000BD074
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00007C5D File Offset: 0x00005E5D
		public unsafe bool _SetPoolCanNotActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr__SetPoolCanNotActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.NativeFieldInfoPtr__SetPoolCanNotActive_k__BackingField)) = value;
			}
		}

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetIncomeValue;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_m_Progress;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_m_CompletionMark;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerTitleMapping;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerFinishColor;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_m_RoundWave;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_m_PoolButton;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_m_PoolCanvasGroup;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalFundCanvasGroup;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkFundCanvasGroup;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalFund;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeFieldInfoPtr_m_BossDesCanvasGroup;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetRequirement;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerTitlesDic;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerFinalTarget;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr__SetPoolCanNotActive_k__BackingField;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_get_SetPoolCanNotActive_Private_get_Boolean_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_set_SetPoolCanNotActive_Public_set_Void_Boolean_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetRequirement_Public_set_Void_Int32_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_SetPoolActiveInst_Public_Void_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_SetInPoolActiveInst_Public_Void_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_SetPoolButton_Public_Void_Action_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalTarget_Public_Void_TriggerCardCondition_Int32_Boolean_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalTargetAndRefresh_Public_Void_TriggerCardCondition_Int32_Boolean_Int32_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTriggerStatus_Public_Void_TriggerCardCondition_Int32_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoundNum_Public_Void_Int32_Int32_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_Settle_Public_Void_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_SetRogueFund_Public_Void_RogueLikeRunTimeData_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_ActiveRogueBossDescrption_Public_GameObject_EliteChallengeBase_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_HideBossDescription_Public_Void_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr__SetPoolButton_b__25_0_Private_Void_CallbackContext_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr__SetPoolButton_b__25_1_Private_Void_Boolean_0;

		// Token: 0x02000515 RID: 1301
		[Serializable]
		public sealed class TriggerTitle : ValueType
		{
			// Token: 0x0600849C RID: 33948 RVA: 0x00252C34 File Offset: 0x00250E34
			// Note: this type is marked as 'beforefieldinit'.
			static TriggerTitle()
			{
				Il2CppClassPointerStore<IncomeControllerRogueLike.TriggerTitle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "TriggerTitle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerRogueLike.TriggerTitle>.NativeClassPtr);
				IncomeControllerRogueLike.TriggerTitle.NativeFieldInfoPtr_TriggerCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.TriggerTitle>.NativeClassPtr, "TriggerCondition");
				IncomeControllerRogueLike.TriggerTitle.NativeFieldInfoPtr_UIElementCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.TriggerTitle>.NativeClassPtr, "UIElementCluster");
			}

			// Token: 0x0600849D RID: 33949 RVA: 0x0004760E File Offset: 0x0004580E
			public TriggerTitle(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600849E RID: 33950 RVA: 0x00047617 File Offset: 0x00045817
			public TriggerTitle() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerRogueLike.TriggerTitle>.NativeClassPtr))
			{
			}

			// Token: 0x17002C8E RID: 11406
			// (get) Token: 0x0600849F RID: 33951 RVA: 0x00252C88 File Offset: 0x00250E88
			// (set) Token: 0x060084A0 RID: 33952 RVA: 0x00047629 File Offset: 0x00045829
			public unsafe TriggerCardCondition TriggerCondition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.TriggerTitle.NativeFieldInfoPtr_TriggerCondition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.TriggerTitle.NativeFieldInfoPtr_TriggerCondition)) = value;
				}
			}

			// Token: 0x17002C8F RID: 11407
			// (get) Token: 0x060084A1 RID: 33953 RVA: 0x00252CB0 File Offset: 0x00250EB0
			// (set) Token: 0x060084A2 RID: 33954 RVA: 0x00047644 File Offset: 0x00045844
			public unsafe UIElementCluster UIElementCluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.TriggerTitle.NativeFieldInfoPtr_UIElementCluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.TriggerTitle.NativeFieldInfoPtr_UIElementCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005737 RID: 22327
			private static readonly IntPtr NativeFieldInfoPtr_TriggerCondition;

			// Token: 0x04005738 RID: 22328
			private static readonly IntPtr NativeFieldInfoPtr_UIElementCluster;
		}

		// Token: 0x02000516 RID: 1302
		[ObfuscatedName("Night.UI.HUD.IncomeControllerRogueLike+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060084A3 RID: 33955 RVA: 0x00252CE0 File Offset: 0x00250EE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr);
				IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, "<>9");
				IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, "<>9__22_0");
				IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, "<>9__22_1");
				IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, "<>9__22_2");
				IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, "<>9__22_3");
				IncomeControllerRogueLike.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, 100664975);
				IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_0_Internal_TriggerCardCondition_TriggerTitle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, 100664976);
				IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_1_Internal_TriggerTitle_TriggerTitle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, 100664977);
				IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_2_Internal_TriggerCardCondition_TriggerTitle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, 100664978);
				IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_3_Internal_ValueTuple_3_Int32_Int32_Boolean_TriggerTitle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr, 100664979);
			}

			// Token: 0x060084A4 RID: 33956 RVA: 0x00252DD4 File Offset: 0x00250FD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerRogueLike.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084A5 RID: 33957 RVA: 0x00252E10 File Offset: 0x00251010
			[CallerCount(0)]
			public unsafe TriggerCardCondition _Initialize_b__22_0(IncomeControllerRogueLike.TriggerTitle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_0_Internal_TriggerCardCondition_TriggerTitle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060084A6 RID: 33958 RVA: 0x00252E64 File Offset: 0x00251064
			[CallerCount(0)]
			public unsafe IncomeControllerRogueLike.TriggerTitle _Initialize_b__22_1(IncomeControllerRogueLike.TriggerTitle y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_1_Internal_TriggerTitle_TriggerTitle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new IncomeControllerRogueLike.TriggerTitle(pointer);
			}

			// Token: 0x060084A7 RID: 33959 RVA: 0x00252EB4 File Offset: 0x002510B4
			[CallerCount(0)]
			public unsafe TriggerCardCondition _Initialize_b__22_2(IncomeControllerRogueLike.TriggerTitle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_2_Internal_TriggerCardCondition_TriggerTitle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060084A8 RID: 33960 RVA: 0x00252F08 File Offset: 0x00251108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39467, XrefRangeEnd = 39470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, int, bool> _Initialize_b__22_3(IncomeControllerRogueLike.TriggerTitle y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c.NativeMethodInfoPtr__Initialize_b__22_3_Internal_ValueTuple_3_Int32_Int32_Boolean_TriggerTitle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, int, bool>(pointer);
			}

			// Token: 0x060084A9 RID: 33961 RVA: 0x00047663 File Offset: 0x00045863
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C90 RID: 11408
			// (get) Token: 0x060084AA RID: 33962 RVA: 0x00252F58 File Offset: 0x00251158
			// (set) Token: 0x060084AB RID: 33963 RVA: 0x0004766C File Offset: 0x0004586C
			public unsafe static IncomeControllerRogueLike.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerRogueLike.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C91 RID: 11409
			// (get) Token: 0x060084AC RID: 33964 RVA: 0x00252F80 File Offset: 0x00251180
			// (set) Token: 0x060084AD RID: 33965 RVA: 0x0004767E File Offset: 0x0004587E
			public unsafe static Func<IncomeControllerRogueLike.TriggerTitle, TriggerCardCondition> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IncomeControllerRogueLike.TriggerTitle, TriggerCardCondition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C92 RID: 11410
			// (get) Token: 0x060084AE RID: 33966 RVA: 0x00252FA8 File Offset: 0x002511A8
			// (set) Token: 0x060084AF RID: 33967 RVA: 0x00047690 File Offset: 0x00045890
			public unsafe static Func<IncomeControllerRogueLike.TriggerTitle, IncomeControllerRogueLike.TriggerTitle> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IncomeControllerRogueLike.TriggerTitle, IncomeControllerRogueLike.TriggerTitle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C93 RID: 11411
			// (get) Token: 0x060084B0 RID: 33968 RVA: 0x00252FD0 File Offset: 0x002511D0
			// (set) Token: 0x060084B1 RID: 33969 RVA: 0x000476A2 File Offset: 0x000458A2
			public unsafe static Func<IncomeControllerRogueLike.TriggerTitle, TriggerCardCondition> __9__22_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IncomeControllerRogueLike.TriggerTitle, TriggerCardCondition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C94 RID: 11412
			// (get) Token: 0x060084B2 RID: 33970 RVA: 0x00252FF8 File Offset: 0x002511F8
			// (set) Token: 0x060084B3 RID: 33971 RVA: 0x000476B4 File Offset: 0x000458B4
			public unsafe static Func<IncomeControllerRogueLike.TriggerTitle, ValueTuple<int, int, bool>> __9__22_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IncomeControllerRogueLike.TriggerTitle, ValueTuple<int, int, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerRogueLike.__c.NativeFieldInfoPtr___9__22_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005739 RID: 22329
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400573A RID: 22330
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400573B RID: 22331
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x0400573C RID: 22332
			private static readonly IntPtr NativeFieldInfoPtr___9__22_2;

			// Token: 0x0400573D RID: 22333
			private static readonly IntPtr NativeFieldInfoPtr___9__22_3;

			// Token: 0x0400573E RID: 22334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400573F RID: 22335
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__22_0_Internal_TriggerCardCondition_TriggerTitle_0;

			// Token: 0x04005740 RID: 22336
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__22_1_Internal_TriggerTitle_TriggerTitle_0;

			// Token: 0x04005741 RID: 22337
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__22_2_Internal_TriggerCardCondition_TriggerTitle_0;

			// Token: 0x04005742 RID: 22338
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__22_3_Internal_ValueTuple_3_Int32_Int32_Boolean_TriggerTitle_0;
		}

		// Token: 0x02000517 RID: 1303
		[ObfuscatedName("Night.UI.HUD.IncomeControllerRogueLike+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x060084B4 RID: 33972 RVA: 0x00253020 File Offset: 0x00251220
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerRogueLike>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_finish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, "finish");
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, "progress");
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, "value");
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, "target");
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664980);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664981);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664982);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664983);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664984);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664985);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664986);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664987);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664988);
				IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr, 100664989);
			}

			// Token: 0x060084B5 RID: 33973 RVA: 0x00253178 File Offset: 0x00251378
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerRogueLike.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084B6 RID: 33974 RVA: 0x002531B4 File Offset: 0x002513B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39470, XrefRangeEnd = 39472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084B7 RID: 33975 RVA: 0x002531F8 File Offset: 0x002513F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39472, XrefRangeEnd = 39474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084B8 RID: 33976 RVA: 0x0025323C File Offset: 0x0025143C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39474, XrefRangeEnd = 39476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084B9 RID: 33977 RVA: 0x00253280 File Offset: 0x00251480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39476, XrefRangeEnd = 39477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084BA RID: 33978 RVA: 0x002532C4 File Offset: 0x002514C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39477, XrefRangeEnd = 39481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084BB RID: 33979 RVA: 0x00253308 File Offset: 0x00251508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084BC RID: 33980 RVA: 0x0025334C File Offset: 0x0025154C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39481, XrefRangeEnd = 39485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084BD RID: 33981 RVA: 0x00253390 File Offset: 0x00251590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084BE RID: 33982 RVA: 0x002533D4 File Offset: 0x002515D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTriggerStatus_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeMethodInfoPtr__UpdateTriggerStatus_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084BF RID: 33983 RVA: 0x000476C6 File Offset: 0x000458C6
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C95 RID: 11413
			// (get) Token: 0x060084C0 RID: 33984 RVA: 0x00253418 File Offset: 0x00251618
			// (set) Token: 0x060084C1 RID: 33985 RVA: 0x000476CF File Offset: 0x000458CF
			public unsafe bool finish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_finish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_finish)) = value;
				}
			}

			// Token: 0x17002C96 RID: 11414
			// (get) Token: 0x060084C2 RID: 33986 RVA: 0x00253440 File Offset: 0x00251640
			// (set) Token: 0x060084C3 RID: 33987 RVA: 0x000476EA File Offset: 0x000458EA
			public unsafe float progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_progress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_progress)) = value;
				}
			}

			// Token: 0x17002C97 RID: 11415
			// (get) Token: 0x060084C4 RID: 33988 RVA: 0x00253468 File Offset: 0x00251668
			// (set) Token: 0x060084C5 RID: 33989 RVA: 0x00047705 File Offset: 0x00045905
			public unsafe IncomeControllerRogueLike __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerRogueLike>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C98 RID: 11416
			// (get) Token: 0x060084C6 RID: 33990 RVA: 0x00253498 File Offset: 0x00251698
			// (set) Token: 0x060084C7 RID: 33991 RVA: 0x00047724 File Offset: 0x00045924
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x17002C99 RID: 11417
			// (get) Token: 0x060084C8 RID: 33992 RVA: 0x002534C0 File Offset: 0x002516C0
			// (set) Token: 0x060084C9 RID: 33993 RVA: 0x0004773F File Offset: 0x0004593F
			public unsafe int target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerRogueLike.__c__DisplayClass28_0.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x04005743 RID: 22339
			private static readonly IntPtr NativeFieldInfoPtr_finish;

			// Token: 0x04005744 RID: 22340
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x04005745 RID: 22341
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005746 RID: 22342
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04005747 RID: 22343
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04005748 RID: 22344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005749 RID: 22345
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__0_Internal_Void_Image_0;

			// Token: 0x0400574A RID: 22346
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__1_Internal_Void_Image_0;

			// Token: 0x0400574B RID: 22347
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__2_Internal_Void_Image_0;

			// Token: 0x0400574C RID: 22348
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400574D RID: 22349
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400574E RID: 22350
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400574F RID: 22351
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005750 RID: 22352
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__7_Internal_Void_Image_0;

			// Token: 0x04005751 RID: 22353
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTriggerStatus_b__8_Internal_Void_Image_0;
		}
	}
}
