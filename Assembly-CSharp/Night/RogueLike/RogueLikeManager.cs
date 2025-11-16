using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using PrepNightScene.UI;

namespace Night.RogueLike
{
	// Token: 0x02000055 RID: 85
	public class RogueLikeManager : Object
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x000C0DD0 File Offset: 0x000BEFD0
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeManager()
		{
			Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "RogueLikeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr);
			RogueLikeManager.NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<RogueLikeRunTimeData>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__BossDataContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<BossDataContext>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__TargetRequirement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<TargetRequirement>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__GainedCards_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<GainedCards>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr_OnCurrentRequireNumChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "OnCurrentRequireNumChanged");
			RogueLikeManager.NativeFieldInfoPtr_OnSettleCardTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "OnSettleCardTrigger");
			RogueLikeManager.NativeFieldInfoPtr__GachaLoop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<GachaLoop>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__GachaCardConditionQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<GachaCardConditionQueue>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "CancellationTokenSource");
			RogueLikeManager.NativeFieldInfoPtr__DLC5_RogueLikeCardSelectorPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<DLC5_RogueLikeCardSelectorPanel>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__IsCardSelectorPanelOpened_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<IsCardSelectorPanelOpened>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__SelectedCard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<SelectedCard>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__RemainingTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<RemainingTime>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__HasWorkEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<HasWorkEnd>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__HasDisposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<HasDisposed>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__OnWorkEndCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<OnWorkEndCallback>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__SubPannel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<SubPannel>k__BackingField");
			RogueLikeManager.NativeFieldInfoPtr__RemindPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<RemindPanel>k__BackingField");
			RogueLikeManager.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665084);
			RogueLikeManager.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665085);
			RogueLikeManager.NativeMethodInfoPtr_get_BossDataContext_Public_get_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665086);
			RogueLikeManager.NativeMethodInfoPtr_get_EventManager_Public_get_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665087);
			RogueLikeManager.NativeMethodInfoPtr_get_GuestsManager_Public_get_GuestsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665088);
			RogueLikeManager.NativeMethodInfoPtr_get_TargetRequirement_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665089);
			RogueLikeManager.NativeMethodInfoPtr_set_TargetRequirement_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665090);
			RogueLikeManager.NativeMethodInfoPtr_get_GainedCards_Public_get_List_1_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665091);
			RogueLikeManager.NativeMethodInfoPtr_get_Funds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665092);
			RogueLikeManager.NativeMethodInfoPtr_add_OnCurrentRequireNumChanged_Public_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665093);
			RogueLikeManager.NativeMethodInfoPtr_remove_OnCurrentRequireNumChanged_Public_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665094);
			RogueLikeManager.NativeMethodInfoPtr_get_GachaLoop_Public_get_Nullable_1_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665095);
			RogueLikeManager.NativeMethodInfoPtr_set_GachaLoop_Public_set_Void_Nullable_1_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665096);
			RogueLikeManager.NativeMethodInfoPtr_get_GachaCardConditionQueue_Public_get_Queue_1_TriggerCardCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665097);
			RogueLikeManager.NativeMethodInfoPtr_get_DLC5_RogueLikeCardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665098);
			RogueLikeManager.NativeMethodInfoPtr_set_DLC5_RogueLikeCardSelectorPanel_Public_set_Void_DLC5_RogueLikeCardSelectorPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665099);
			RogueLikeManager.NativeMethodInfoPtr_get_IsCardSelectorPanelOpened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665100);
			RogueLikeManager.NativeMethodInfoPtr_set_IsCardSelectorPanelOpened_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665101);
			RogueLikeManager.NativeMethodInfoPtr_get_SelectedCard_Public_get_Queue_1_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665102);
			RogueLikeManager.NativeMethodInfoPtr_set_SelectedCard_Private_set_Void_Queue_1_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665103);
			RogueLikeManager.NativeMethodInfoPtr_get_RemainingTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665104);
			RogueLikeManager.NativeMethodInfoPtr_set_RemainingTime_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665105);
			RogueLikeManager.NativeMethodInfoPtr_get_HasWorkEnd_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665106);
			RogueLikeManager.NativeMethodInfoPtr_set_HasWorkEnd_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665107);
			RogueLikeManager.NativeMethodInfoPtr_get_HasDisposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665108);
			RogueLikeManager.NativeMethodInfoPtr_set_HasDisposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665109);
			RogueLikeManager.NativeMethodInfoPtr_get_OnWorkEndCallback_Public_get_Action_1_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665110);
			RogueLikeManager.NativeMethodInfoPtr_set_OnWorkEndCallback_Public_set_Void_Action_1_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665111);
			RogueLikeManager.NativeMethodInfoPtr_ChangeTargetRequirement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665112);
			RogueLikeManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665113);
			RogueLikeManager.NativeMethodInfoPtr_PostCheck_Public_Virtual_Final_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665114);
			RogueLikeManager.NativeMethodInfoPtr_OpenReminderAsync_Public_Virtual_Final_New_UniTask_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665115);
			RogueLikeManager.NativeMethodInfoPtr_get_SubPannel_Public_Virtual_Final_New_get_UISubPanel_1_IzakayaConfigPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665116);
			RogueLikeManager.NativeMethodInfoPtr_set_SubPannel_Public_set_Void_UISubPanel_1_IzakayaConfigPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665117);
			RogueLikeManager.NativeMethodInfoPtr_get_RemindPanel_Public_get_RemindSubPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665118);
			RogueLikeManager.NativeMethodInfoPtr_set_RemindPanel_Public_set_Void_RemindSubPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665119);
			RogueLikeManager.NativeMethodInfoPtr_EnqueueWorkCard_Public_Void_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665120);
			RogueLikeManager.NativeMethodInfoPtr_WaitForScorePanelLoad_Public_UniTask_List_1_CardScorePair_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, 100665121);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000C1260 File Offset: 0x000BF460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40518, RefRangeEnd = 40519, XrefRangeStart = 40473, XrefRangeEnd = 40518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeManager(RogueLikeRunTimeData rogueLikeRunTimeData, BossData.BossDataContext bossDataContext) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_BossDataContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000C12C4 File Offset: 0x000BF4C4
		public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_get_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000C1304 File Offset: 0x000BF504
		public unsafe BossData.BossDataContext BossDataContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_BossDataContext_Public_get_BossDataContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new BossData.BossDataContext(pointer);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000C133C File Offset: 0x000BF53C
		public unsafe EventManager EventManager
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 40519, RefRangeEnd = 40547, XrefRangeStart = 40519, XrefRangeEnd = 40519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_EventManager_Public_get_EventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000C137C File Offset: 0x000BF57C
		public unsafe GuestsManager GuestsManager
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 40547, RefRangeEnd = 40555, XrefRangeStart = 40547, XrefRangeEnd = 40547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_GuestsManager_Public_get_GuestsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000C13BC File Offset: 0x000BF5BC
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x000C13F8 File Offset: 0x000BF5F8
		public unsafe int TargetRequirement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_TargetRequirement_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 40555, RefRangeEnd = 40571, XrefRangeStart = 40555, XrefRangeEnd = 40555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_TargetRequirement_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x000C1438 File Offset: 0x000BF638
		public unsafe List<RogueLikeCardInstance> GainedCards
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_GainedCards_Public_get_List_1_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardInstance>>(intPtr3) : null;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000C1478 File Offset: 0x000BF678
		public unsafe int Funds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_Funds_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000C14B4 File Offset: 0x000BF6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40591, RefRangeEnd = 40592, XrefRangeStart = 40586, XrefRangeEnd = 40591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnCurrentRequireNumChanged(Action<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_add_OnCurrentRequireNumChanged_Public_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000C14F8 File Offset: 0x000BF6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40592, XrefRangeEnd = 40597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnCurrentRequireNumChanged(Action<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_remove_OnCurrentRequireNumChanged_Public_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x000C153C File Offset: 0x000BF73C
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x000C1574 File Offset: 0x000BF774
		public unsafe Nullable<UniTask> GachaLoop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_GachaLoop_Public_get_Nullable_1_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<UniTask>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40597, XrefRangeEnd = 40598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_GachaLoop_Public_set_Void_Nullable_1_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x000C15BC File Offset: 0x000BF7BC
		public unsafe Queue<TriggerCardCondition> GachaCardConditionQueue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_GachaCardConditionQueue_Public_get_Queue_1_TriggerCardCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<TriggerCardCondition>>(intPtr3) : null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x000C15FC File Offset: 0x000BF7FC
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x000C163C File Offset: 0x000BF83C
		public unsafe DLC5_RogueLikeCardSelectorPanel DLC5_RogueLikeCardSelectorPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_DLC5_RogueLikeCardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40598, XrefRangeEnd = 40599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_DLC5_RogueLikeCardSelectorPanel_Public_set_Void_DLC5_RogueLikeCardSelectorPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x000C1680 File Offset: 0x000BF880
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x000C16BC File Offset: 0x000BF8BC
		public unsafe bool IsCardSelectorPanelOpened
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_IsCardSelectorPanelOpened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_IsCardSelectorPanelOpened_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x000C16FC File Offset: 0x000BF8FC
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x000C173C File Offset: 0x000BF93C
		public unsafe Queue<RogueLikeCardInstance> SelectedCard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_SelectedCard_Public_get_Queue_1_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<RogueLikeCardInstance>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40599, XrefRangeEnd = 40600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_SelectedCard_Private_set_Void_Queue_1_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000C1780 File Offset: 0x000BF980
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x000C17BC File Offset: 0x000BF9BC
		public unsafe int RemainingTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_RemainingTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_RemainingTime_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000C17FC File Offset: 0x000BF9FC
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000C1838 File Offset: 0x000BFA38
		public unsafe bool HasWorkEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_HasWorkEnd_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_HasWorkEnd_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000C1878 File Offset: 0x000BFA78
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000C18B4 File Offset: 0x000BFAB4
		public unsafe bool HasDisposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_HasDisposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_HasDisposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x000C18F4 File Offset: 0x000BFAF4
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x000C1934 File Offset: 0x000BFB34
		public unsafe Action<RogueLikeManager> OnWorkEndCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_OnWorkEndCallback_Public_get_Action_1_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<RogueLikeManager>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40600, XrefRangeEnd = 40601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_OnWorkEndCallback_Public_set_Void_Action_1_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000C1978 File Offset: 0x000BFB78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40601, RefRangeEnd = 40604, XrefRangeStart = 40601, XrefRangeEnd = 40601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTargetRequirement(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_ChangeTargetRequirement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000C19B8 File Offset: 0x000BFBB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40629, RefRangeEnd = 40630, XrefRangeStart = 40604, XrefRangeEnd = 40629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000C19EC File Offset: 0x000BFBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40630, XrefRangeEnd = 40634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool PostCheck(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_PostCheck_Public_Virtual_Final_New_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000C1A44 File Offset: 0x000BFC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40634, XrefRangeEnd = 40644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UniTask<bool> OpenReminderAsync(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_OpenReminderAsync_Public_Virtual_Final_New_UniTask_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<bool>(pointer);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000C1A8C File Offset: 0x000BFC8C
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x000C1ACC File Offset: 0x000BFCCC
		public unsafe virtual UISubPanel<IzakayaConfigPannel> SubPannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_SubPannel_Public_Virtual_Final_New_get_UISubPanel_1_IzakayaConfigPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISubPanel<IzakayaConfigPannel>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40644, XrefRangeEnd = 40645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_SubPannel_Public_set_Void_UISubPanel_1_IzakayaConfigPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000C1B10 File Offset: 0x000BFD10
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x000C1B50 File Offset: 0x000BFD50
		public unsafe RemindSubPanel RemindPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40645, RefRangeEnd = 40646, XrefRangeStart = 40645, XrefRangeEnd = 40645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_get_RemindPanel_Public_get_RemindSubPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40646, XrefRangeEnd = 40647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_set_RemindPanel_Public_set_Void_RemindSubPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000C1B94 File Offset: 0x000BFD94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40662, RefRangeEnd = 40664, XrefRangeStart = 40647, XrefRangeEnd = 40662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnqueueWorkCard(RogueLikeCardInstance card, List<RogueLikeCardInstance> associatedCards)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(associatedCards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_EnqueueWorkCard_Public_Void_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000C1BE8 File Offset: 0x000BFDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40683, RefRangeEnd = 40684, XrefRangeStart = 40664, XrefRangeEnd = 40683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask WaitForScorePanelLoad(List<DLC5_RogueLikeCardScorePanel.CardScorePair> cardScorePairs, Action onPanelCloseCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardScorePairs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager.NativeMethodInfoPtr_WaitForScorePanelLoad_Public_UniTask_List_1_CardScorePair_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00007FC3 File Offset: 0x000061C3
		public RogueLikeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000C1C44 File Offset: 0x000BFE44
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00007FCC File Offset: 0x000061CC
		public unsafe RogueLikeRunTimeData _RogueLikeRunTimeData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000C1C74 File Offset: 0x000BFE74
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00007FEB File Offset: 0x000061EB
		public BossData.BossDataContext _BossDataContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__BossDataContext_k__BackingField);
				return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__BossDataContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000C1CA4 File Offset: 0x000BFEA4
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00008019 File Offset: 0x00006219
		public unsafe int _TargetRequirement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__TargetRequirement_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__TargetRequirement_k__BackingField)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x000C1CCC File Offset: 0x000BFECC
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00008034 File Offset: 0x00006234
		public unsafe List<RogueLikeCardInstance> _GainedCards_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__GainedCards_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__GainedCards_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000C1CFC File Offset: 0x000BFEFC
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00008053 File Offset: 0x00006253
		public unsafe Action<int> OnCurrentRequireNumChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr_OnCurrentRequireNumChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr_OnCurrentRequireNumChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000C1D2C File Offset: 0x000BFF2C
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00008072 File Offset: 0x00006272
		public unsafe Action<Dictionary<RogueLikeCardBase.CardType, List<Product>>> OnSettleCardTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr_OnSettleCardTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<RogueLikeCardBase.CardType, List<Product>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr_OnSettleCardTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000C1D5C File Offset: 0x000BFF5C
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00008091 File Offset: 0x00006291
		public Nullable<UniTask> _GachaLoop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__GachaLoop_k__BackingField);
				return new Nullable<UniTask>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<UniTask>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__GachaLoop_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<UniTask>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000C1D8C File Offset: 0x000BFF8C
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000080BF File Offset: 0x000062BF
		public unsafe Queue<TriggerCardCondition> _GachaCardConditionQueue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__GachaCardConditionQueue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<TriggerCardCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__GachaCardConditionQueue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000C1DBC File Offset: 0x000BFFBC
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000080DE File Offset: 0x000062DE
		public unsafe CancellationTokenSource CancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr_CancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000C1DEC File Offset: 0x000BFFEC
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000080FD File Offset: 0x000062FD
		public unsafe DLC5_RogueLikeCardSelectorPanel _DLC5_RogueLikeCardSelectorPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__DLC5_RogueLikeCardSelectorPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__DLC5_RogueLikeCardSelectorPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000C1E1C File Offset: 0x000C001C
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0000811C File Offset: 0x0000631C
		public unsafe bool _IsCardSelectorPanelOpened_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__IsCardSelectorPanelOpened_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__IsCardSelectorPanelOpened_k__BackingField)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000C1E44 File Offset: 0x000C0044
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00008137 File Offset: 0x00006337
		public unsafe Queue<RogueLikeCardInstance> _SelectedCard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__SelectedCard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<RogueLikeCardInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__SelectedCard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000C1E74 File Offset: 0x000C0074
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00008156 File Offset: 0x00006356
		public unsafe int _RemainingTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__RemainingTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__RemainingTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000C1E9C File Offset: 0x000C009C
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00008171 File Offset: 0x00006371
		public unsafe bool _HasWorkEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__HasWorkEnd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__HasWorkEnd_k__BackingField)) = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000C1EC4 File Offset: 0x000C00C4
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0000818C File Offset: 0x0000638C
		public unsafe bool _HasDisposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__HasDisposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__HasDisposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000C1EEC File Offset: 0x000C00EC
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000081A7 File Offset: 0x000063A7
		public unsafe Action<RogueLikeManager> _OnWorkEndCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__OnWorkEndCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RogueLikeManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__OnWorkEndCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000C1F1C File Offset: 0x000C011C
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x000081C6 File Offset: 0x000063C6
		public unsafe UISubPanel<IzakayaConfigPannel> _SubPannel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__SubPannel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISubPanel<IzakayaConfigPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__SubPannel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000C1F4C File Offset: 0x000C014C
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x000081E5 File Offset: 0x000063E5
		public unsafe RemindSubPanel _RemindPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__RemindPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager.NativeFieldInfoPtr__RemindPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr__BossDataContext_k__BackingField;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr__TargetRequirement_k__BackingField;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr__GainedCards_k__BackingField;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_OnCurrentRequireNumChanged;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_OnSettleCardTrigger;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr__GachaLoop_k__BackingField;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr__GachaCardConditionQueue_k__BackingField;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_CancellationTokenSource;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr__DLC5_RogueLikeCardSelectorPanel_k__BackingField;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr__IsCardSelectorPanelOpened_k__BackingField;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr__SelectedCard_k__BackingField;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr__RemainingTime_k__BackingField;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr__HasWorkEnd_k__BackingField;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr__HasDisposed_k__BackingField;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr__OnWorkEndCallback_k__BackingField;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr__SubPannel_k__BackingField;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr__RemindPanel_k__BackingField;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_BossDataContext_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_get_RogueLikeRunTimeData_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_get_BossDataContext_Public_get_BossDataContext_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_get_EventManager_Public_get_EventManager_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestsManager_Public_get_GuestsManager_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetRequirement_Public_get_Int32_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetRequirement_Private_set_Void_Int32_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_get_GainedCards_Public_get_List_1_RogueLikeCardInstance_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_get_Funds_Public_get_Int32_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCurrentRequireNumChanged_Public_add_Void_Action_1_Int32_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCurrentRequireNumChanged_Public_rem_Void_Action_1_Int32_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaLoop_Public_get_Nullable_1_UniTask_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_set_GachaLoop_Public_set_Void_Nullable_1_UniTask_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaCardConditionQueue_Public_get_Queue_1_TriggerCardCondition_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_get_DLC5_RogueLikeCardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_set_DLC5_RogueLikeCardSelectorPanel_Public_set_Void_DLC5_RogueLikeCardSelectorPanel_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCardSelectorPanelOpened_Public_get_Boolean_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCardSelectorPanelOpened_Public_set_Void_Boolean_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedCard_Public_get_Queue_1_RogueLikeCardInstance_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedCard_Private_set_Void_Queue_1_RogueLikeCardInstance_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingTime_Public_get_Int32_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingTime_Public_set_Void_Int32_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWorkEnd_Public_get_Boolean_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_set_HasWorkEnd_Public_set_Void_Boolean_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDisposed_Public_get_Boolean_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_set_HasDisposed_Private_set_Void_Boolean_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_get_OnWorkEndCallback_Public_get_Action_1_RogueLikeManager_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_set_OnWorkEndCallback_Public_set_Void_Action_1_RogueLikeManager_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTargetRequirement_Public_Void_Int32_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_PostCheck_Public_Virtual_Final_New_Boolean_byref_String_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_OpenReminderAsync_Public_Virtual_Final_New_UniTask_1_Boolean_String_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_get_SubPannel_Public_Virtual_Final_New_get_UISubPanel_1_IzakayaConfigPannel_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_set_SubPannel_Public_set_Void_UISubPanel_1_IzakayaConfigPannel_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_get_RemindPanel_Public_get_RemindSubPanel_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_set_RemindPanel_Public_set_Void_RemindSubPanel_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueWorkCard_Public_Void_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_WaitForScorePanelLoad_Public_UniTask_List_1_CardScorePair_Action_0;

		// Token: 0x02000520 RID: 1312
		[ObfuscatedName("Night.RogueLike.RogueLikeManager+<OpenReminderAsync>d__63")]
		public sealed class _OpenReminderAsync_d__63 : ValueType
		{
			// Token: 0x0600850E RID: 34062 RVA: 0x00254204 File Offset: 0x00252404
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenReminderAsync_d__63()
			{
				Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<OpenReminderAsync>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr);
				RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, "<>1__state");
				RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, "<>t__builder");
				RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, "<>4__this");
				RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, "message");
				RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr__remindPanel_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, "<remindPanel>5__2");
				RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, "<>u__1");
				RogueLikeManager._OpenReminderAsync_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, 100665122);
				RogueLikeManager._OpenReminderAsync_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr, 100665123);
			}

			// Token: 0x0600850F RID: 34063 RVA: 0x002542D0 File Offset: 0x002524D0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40435, RefRangeEnd = 40437, XrefRangeStart = 40410, XrefRangeEnd = 40435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager._OpenReminderAsync_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008510 RID: 34064 RVA: 0x00254308 File Offset: 0x00252508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40437, XrefRangeEnd = 40440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager._OpenReminderAsync_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008511 RID: 34065 RVA: 0x0004795F File Offset: 0x00045B5F
			public _OpenReminderAsync_d__63(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008512 RID: 34066 RVA: 0x00047968 File Offset: 0x00045B68
			public _OpenReminderAsync_d__63() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeManager._OpenReminderAsync_d__63>.NativeClassPtr))
			{
			}

			// Token: 0x17002CAE RID: 11438
			// (get) Token: 0x06008513 RID: 34067 RVA: 0x00254350 File Offset: 0x00252550
			// (set) Token: 0x06008514 RID: 34068 RVA: 0x0004797A File Offset: 0x00045B7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002CAF RID: 11439
			// (get) Token: 0x06008515 RID: 34069 RVA: 0x00254378 File Offset: 0x00252578
			// (set) Token: 0x06008516 RID: 34070 RVA: 0x00047995 File Offset: 0x00045B95
			public AsyncUniTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002CB0 RID: 11440
			// (get) Token: 0x06008517 RID: 34071 RVA: 0x002543A8 File Offset: 0x002525A8
			// (set) Token: 0x06008518 RID: 34072 RVA: 0x000479C3 File Offset: 0x00045BC3
			public unsafe RogueLikeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CB1 RID: 11441
			// (get) Token: 0x06008519 RID: 34073 RVA: 0x002543D8 File Offset: 0x002525D8
			// (set) Token: 0x0600851A RID: 34074 RVA: 0x000479E2 File Offset: 0x00045BE2
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002CB2 RID: 11442
			// (get) Token: 0x0600851B RID: 34075 RVA: 0x00254400 File Offset: 0x00252600
			// (set) Token: 0x0600851C RID: 34076 RVA: 0x00047A01 File Offset: 0x00045C01
			public unsafe RemindSubPanel _remindPanel_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr__remindPanel_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr__remindPanel_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CB3 RID: 11443
			// (get) Token: 0x0600851D RID: 34077 RVA: 0x00254430 File Offset: 0x00252630
			// (set) Token: 0x0600851E RID: 34078 RVA: 0x00047A20 File Offset: 0x00045C20
			public UniTask<RemindSubPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___u__1);
					return new UniTask<RemindSubPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<RemindSubPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._OpenReminderAsync_d__63.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<RemindSubPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400577D RID: 22397
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400577E RID: 22398
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400577F RID: 22399
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005780 RID: 22400
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04005781 RID: 22401
			private static readonly IntPtr NativeFieldInfoPtr__remindPanel_5__2;

			// Token: 0x04005782 RID: 22402
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005783 RID: 22403
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005784 RID: 22404
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000521 RID: 1313
		[ObfuscatedName("Night.RogueLike.RogueLikeManager+<WaitForScorePanelLoad>d__73")]
		public sealed class _WaitForScorePanelLoad_d__73 : ValueType
		{
			// Token: 0x0600851F RID: 34079 RVA: 0x00254460 File Offset: 0x00252660
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForScorePanelLoad_d__73()
			{
				Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeManager>.NativeClassPtr, "<WaitForScorePanelLoad>d__73");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr);
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, "<>1__state");
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, "<>t__builder");
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, "<>4__this");
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr_cardScorePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, "cardScorePairs");
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr_onPanelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, "onPanelCloseCallback");
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, "<>u__1");
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, 100665124);
				RogueLikeManager._WaitForScorePanelLoad_d__73.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr, 100665125);
			}

			// Token: 0x06008520 RID: 34080 RVA: 0x0025452C File Offset: 0x0025272C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40471, RefRangeEnd = 40473, XrefRangeStart = 40440, XrefRangeEnd = 40471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008521 RID: 34081 RVA: 0x00254564 File Offset: 0x00252764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008522 RID: 34082 RVA: 0x00047A4E File Offset: 0x00045C4E
			public _WaitForScorePanelLoad_d__73(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008523 RID: 34083 RVA: 0x00047A57 File Offset: 0x00045C57
			public _WaitForScorePanelLoad_d__73() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeManager._WaitForScorePanelLoad_d__73>.NativeClassPtr))
			{
			}

			// Token: 0x17002CB4 RID: 11444
			// (get) Token: 0x06008524 RID: 34084 RVA: 0x002545AC File Offset: 0x002527AC
			// (set) Token: 0x06008525 RID: 34085 RVA: 0x00047A69 File Offset: 0x00045C69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002CB5 RID: 11445
			// (get) Token: 0x06008526 RID: 34086 RVA: 0x002545D4 File Offset: 0x002527D4
			// (set) Token: 0x06008527 RID: 34087 RVA: 0x00047A84 File Offset: 0x00045C84
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002CB6 RID: 11446
			// (get) Token: 0x06008528 RID: 34088 RVA: 0x00254604 File Offset: 0x00252804
			// (set) Token: 0x06008529 RID: 34089 RVA: 0x00047AB2 File Offset: 0x00045CB2
			public unsafe RogueLikeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CB7 RID: 11447
			// (get) Token: 0x0600852A RID: 34090 RVA: 0x00254634 File Offset: 0x00252834
			// (set) Token: 0x0600852B RID: 34091 RVA: 0x00047AD1 File Offset: 0x00045CD1
			public unsafe List<DLC5_RogueLikeCardScorePanel.CardScorePair> cardScorePairs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr_cardScorePairs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_RogueLikeCardScorePanel.CardScorePair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr_cardScorePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CB8 RID: 11448
			// (get) Token: 0x0600852C RID: 34092 RVA: 0x00254664 File Offset: 0x00252864
			// (set) Token: 0x0600852D RID: 34093 RVA: 0x00047AF0 File Offset: 0x00045CF0
			public unsafe Action onPanelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr_onPanelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr_onPanelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CB9 RID: 11449
			// (get) Token: 0x0600852E RID: 34094 RVA: 0x00254694 File Offset: 0x00252894
			// (set) Token: 0x0600852F RID: 34095 RVA: 0x00047B0F File Offset: 0x00045D0F
			public UniTask<DLC5_RogueLikeCardScorePanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeCardScorePanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeCardScorePanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeManager._WaitForScorePanelLoad_d__73.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeCardScorePanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005785 RID: 22405
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005786 RID: 22406
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005787 RID: 22407
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005788 RID: 22408
			private static readonly IntPtr NativeFieldInfoPtr_cardScorePairs;

			// Token: 0x04005789 RID: 22409
			private static readonly IntPtr NativeFieldInfoPtr_onPanelCloseCallback;

			// Token: 0x0400578A RID: 22410
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400578B RID: 22411
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400578C RID: 22412
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
