using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Input;
using DayScene.Interactables.Collections.BehaviourComponents;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection.Async;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x020000CA RID: 202
	public class DLC4_DaySceneFishingPrePannel : AsyncUIPanelParamClose<DLC4_DaySceneFishingPrePannel.ResultContext>
	{
		// Token: 0x060017D9 RID: 6105 RVA: 0x000EE330 File Offset: 0x000EC530
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_DaySceneFishingPrePannel()
		{
			Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_DaySceneFishingPrePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr);
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_GET_TREASURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "PRD_FISHING_GET_TREASURE");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_GET_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "PRD_FISHING_GET_RATE");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_FIRST_GET_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "PRD_FISHING_FIRST_GET_CHANCE");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_m_hardModeFishingRodIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "m_hardModeFishingRodIds");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "waitTime");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_missingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "missingTime");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_m_HardModeQTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "m_HardModeQTEPannel");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_isFishBiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "isFishBiting");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_isTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "isTrash");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_successStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "successStatus");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__TreasureContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<TreasureContext>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__AnimatorSetToBite_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<AnimatorSetToBite>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__AnimatorSetToUnBite_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<AnimatorSetToUnBite>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ResetFocusIndicatorCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<ResetFocusIndicatorCallback>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<Player>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ForceSpawnTreasureInUnityEditor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<ForceSpawnTreasureInUnityEditor>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ThisRewardProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<ThisRewardProduct>k__BackingField");
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Il2CppReferenceArray_1_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667599);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Il2CppReferenceArray_1_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667600);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_TreasureContext_Private_get_Il2CppReferenceArray_1_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667601);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_TreasureContext_Public_set_Void_Il2CppReferenceArray_1_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667602);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_AnimatorSetToBite_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667603);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_AnimatorSetToBite_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667604);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_AnimatorSetToUnBite_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667605);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_AnimatorSetToUnBite_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667606);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_ResetFocusIndicatorCallback_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667607);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_ResetFocusIndicatorCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667608);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_Player_Public_get_DayScenePlayerInputGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667609);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_Player_Private_set_Void_DayScenePlayerInputGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667610);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_CheckNeedSetFishUnBite_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667611);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_ForceSpawnTreasureInUnityEditor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667612);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_ForceSpawnTreasureInUnityEditor_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667613);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667614);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_ThisRewardProduct_Public_get_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667615);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_ThisRewardProduct_Private_set_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667616);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_HardFishingMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667617);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667618);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_OnSubmit_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667619);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667620);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_TryClosePanel_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667621);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667622);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667623);
			DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr__OnPanelInitialize_b__48_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, 100667624);
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000EE6D0 File Offset: 0x000EC8D0
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x000EE710 File Offset: 0x000EC910
		public unsafe Il2CppReferenceArray<FishingBehaviourCompoent.FishReward> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Il2CppReferenceArray_1_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FishingBehaviourCompoent.FishReward>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66721, XrefRangeEnd = 66722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Il2CppReferenceArray_1_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x000EE754 File Offset: 0x000EC954
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x000EE794 File Offset: 0x000EC994
		public unsafe Il2CppReferenceArray<FishingBehaviourCompoent.FishReward> TreasureContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_TreasureContext_Private_get_Il2CppReferenceArray_1_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FishingBehaviourCompoent.FishReward>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66722, XrefRangeEnd = 66723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_TreasureContext_Public_set_Void_Il2CppReferenceArray_1_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x000EE7D8 File Offset: 0x000EC9D8
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x000EE818 File Offset: 0x000ECA18
		public unsafe Action AnimatorSetToBite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_AnimatorSetToBite_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66723, XrefRangeEnd = 66724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_AnimatorSetToBite_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x000EE85C File Offset: 0x000ECA5C
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x000EE89C File Offset: 0x000ECA9C
		public unsafe Action AnimatorSetToUnBite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_AnimatorSetToUnBite_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66724, XrefRangeEnd = 66725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_AnimatorSetToUnBite_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x000EE8E0 File Offset: 0x000ECAE0
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x000EE920 File Offset: 0x000ECB20
		public unsafe Action ResetFocusIndicatorCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_ResetFocusIndicatorCallback_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66725, XrefRangeEnd = 66726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_ResetFocusIndicatorCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000EE964 File Offset: 0x000ECB64
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x000EE9A4 File Offset: 0x000ECBA4
		public unsafe DayScenePlayerInputGenerator Player
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_Player_Public_get_DayScenePlayerInputGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_Player_Private_set_Void_DayScenePlayerInputGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x000EE9E8 File Offset: 0x000ECBE8
		public unsafe bool CheckNeedSetFishUnBite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_CheckNeedSetFishUnBite_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x000EEA24 File Offset: 0x000ECC24
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x000EEA60 File Offset: 0x000ECC60
		public unsafe bool ForceSpawnTreasureInUnityEditor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_ForceSpawnTreasureInUnityEditor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_ForceSpawnTreasureInUnityEditor_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x000EEAA0 File Offset: 0x000ECCA0
		public unsafe override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x000EEAE8 File Offset: 0x000ECCE8
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x000EEB20 File Offset: 0x000ECD20
		public unsafe Product ThisRewardProduct
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_ThisRewardProduct_Public_get_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66726, XrefRangeEnd = 66727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_set_ThisRewardProduct_Private_set_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x000EEB68 File Offset: 0x000ECD68
		public unsafe bool HardFishingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66727, XrefRangeEnd = 66737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_get_HardFishingMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000EEBA4 File Offset: 0x000ECDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66737, XrefRangeEnd = 66762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000EEBE0 File Offset: 0x000ECDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66762, XrefRangeEnd = 66763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_OnSubmit_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000EEC28 File Offset: 0x000ECE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66763, XrefRangeEnd = 66768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000EEC70 File Offset: 0x000ECE70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 66874, RefRangeEnd = 66880, XrefRangeStart = 66768, XrefRangeEnd = 66874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryClosePanel(bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_TryClosePanel_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000EECB0 File Offset: 0x000ECEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66880, XrefRangeEnd = 66889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000EECEC File Offset: 0x000ECEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66889, XrefRangeEnd = 66892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_DaySceneFishingPrePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000EED28 File Offset: 0x000ECF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66892, XrefRangeEnd = 66894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__48_0(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.NativeMethodInfoPtr__OnPanelInitialize_b__48_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		public DLC4_DaySceneFishingPrePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x000EED70 File Offset: 0x000ECF70
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0000EDB5 File Offset: 0x0000CFB5
		public unsafe static string PRD_FISHING_GET_TREASURE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_GET_TREASURE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_GET_TREASURE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000EED90 File Offset: 0x000ECF90
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000EDC7 File Offset: 0x0000CFC7
		public unsafe static float PRD_FISHING_GET_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_GET_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_GET_RATE, (void*)(&value));
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000EEDAC File Offset: 0x000ECFAC
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000EDD5 File Offset: 0x0000CFD5
		public unsafe static int PRD_FISHING_FIRST_GET_CHANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_FIRST_GET_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_PRD_FISHING_FIRST_GET_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x000EEDC8 File Offset: 0x000ECFC8
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
		public unsafe Il2CppStructArray<int> m_hardModeFishingRodIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_m_hardModeFishingRodIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_m_hardModeFishingRodIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x000EEDF8 File Offset: 0x000ECFF8
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000EE02 File Offset: 0x0000D002
		public unsafe Vector2 waitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_waitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_waitTime)) = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x000EEE20 File Offset: 0x000ED020
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000EE1D File Offset: 0x0000D01D
		public unsafe float missingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_missingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_missingTime)) = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x000EEE48 File Offset: 0x000ED048
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000EE38 File Offset: 0x0000D038
		public unsafe DLC4_DaySceneFishingQTEPannel m_HardModeQTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_m_HardModeQTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingQTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_m_HardModeQTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x000EEE78 File Offset: 0x000ED078
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0000EE57 File Offset: 0x0000D057
		public unsafe bool isFishBiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_isFishBiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_isFishBiting)) = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x000EEEA0 File Offset: 0x000ED0A0
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x0000EE72 File Offset: 0x0000D072
		public unsafe bool isTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_isTrash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_isTrash)) = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x000EEEC8 File Offset: 0x000ED0C8
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x0000EE8D File Offset: 0x0000D08D
		public unsafe DLC4_DaySceneFishingQTEPannel.FishingResult successStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_successStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr_successStatus)) = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x000EEEF0 File Offset: 0x000ED0F0
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		public unsafe Il2CppReferenceArray<FishingBehaviourCompoent.FishReward> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FishingBehaviourCompoent.FishReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000EEF20 File Offset: 0x000ED120
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x0000EEC7 File Offset: 0x0000D0C7
		public unsafe Il2CppReferenceArray<FishingBehaviourCompoent.FishReward> _TreasureContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__TreasureContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FishingBehaviourCompoent.FishReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__TreasureContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x000EEF50 File Offset: 0x000ED150
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x0000EEE6 File Offset: 0x0000D0E6
		public unsafe Action _AnimatorSetToBite_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__AnimatorSetToBite_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__AnimatorSetToBite_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000EEF80 File Offset: 0x000ED180
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0000EF05 File Offset: 0x0000D105
		public unsafe Action _AnimatorSetToUnBite_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__AnimatorSetToUnBite_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__AnimatorSetToUnBite_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000EEFB0 File Offset: 0x000ED1B0
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0000EF24 File Offset: 0x0000D124
		public unsafe Action _ResetFocusIndicatorCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ResetFocusIndicatorCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ResetFocusIndicatorCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000EEFE0 File Offset: 0x000ED1E0
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0000EF43 File Offset: 0x0000D143
		public unsafe DayScenePlayerInputGenerator _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000EF010 File Offset: 0x000ED210
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000EF62 File Offset: 0x0000D162
		public unsafe bool _ForceSpawnTreasureInUnityEditor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ForceSpawnTreasureInUnityEditor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ForceSpawnTreasureInUnityEditor_k__BackingField)) = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000EF038 File Offset: 0x000ED238
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x0000EF7D File Offset: 0x0000D17D
		public Product _ThisRewardProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ThisRewardProduct_k__BackingField);
				return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.NativeFieldInfoPtr__ThisRewardProduct_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr_PRD_FISHING_GET_TREASURE;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_PRD_FISHING_GET_RATE;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr_PRD_FISHING_FIRST_GET_CHANCE;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr_m_hardModeFishingRodIds;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeFieldInfoPtr_waitTime;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeFieldInfoPtr_missingTime;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeFieldInfoPtr_m_HardModeQTEPannel;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr_isFishBiting;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeFieldInfoPtr_isTrash;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeFieldInfoPtr_successStatus;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr__TreasureContext_k__BackingField;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeFieldInfoPtr__AnimatorSetToBite_k__BackingField;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr__AnimatorSetToUnBite_k__BackingField;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr__ResetFocusIndicatorCallback_k__BackingField;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeFieldInfoPtr__ForceSpawnTreasureInUnityEditor_k__BackingField;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeFieldInfoPtr__ThisRewardProduct_k__BackingField;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_Il2CppReferenceArray_1_FishReward_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Il2CppReferenceArray_1_FishReward_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_get_TreasureContext_Private_get_Il2CppReferenceArray_1_FishReward_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_set_TreasureContext_Public_set_Void_Il2CppReferenceArray_1_FishReward_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_get_AnimatorSetToBite_Private_get_Action_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_set_AnimatorSetToBite_Public_set_Void_Action_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_get_AnimatorSetToUnBite_Private_get_Action_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_set_AnimatorSetToUnBite_Public_set_Void_Action_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_get_ResetFocusIndicatorCallback_Private_get_Action_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_set_ResetFocusIndicatorCallback_Public_set_Void_Action_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_DayScenePlayerInputGenerator_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_DayScenePlayerInputGenerator_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckNeedSetFishUnBite_Private_get_Boolean_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceSpawnTreasureInUnityEditor_Public_get_Boolean_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_set_ForceSpawnTreasureInUnityEditor_Private_set_Void_Boolean_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_get_ThisRewardProduct_Public_get_Product_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_set_ThisRewardProduct_Private_set_Void_Product_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_get_HardFishingMode_Public_get_Boolean_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_CallbackContext_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_TryClosePanel_Private_Void_Boolean_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__48_0_Private_Void_CallbackContext_0;

		// Token: 0x0200066B RID: 1643
		public sealed class ResultContext : ValueType
		{
			// Token: 0x060094FF RID: 38143 RVA: 0x00281E2C File Offset: 0x0028002C
			// Note: this type is marked as 'beforefieldinit'.
			static ResultContext()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "ResultContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr);
				DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_RewardProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, "RewardProduct");
				DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_TreasureProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, "TreasureProduct");
				DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_CheckNeedSetFishUnBite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, "CheckNeedSetFishUnBite");
				DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_CheckIfOpenResultPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, "CheckIfOpenResultPanel");
				DLC4_DaySceneFishingPrePannel.ResultContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Product_Nullable_1_Product_Boolean_Func_2_Product_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, 100667625);
			}

			// Token: 0x06009500 RID: 38144 RVA: 0x00281EBC File Offset: 0x002800BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66509, XrefRangeEnd = 66512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResultContext(Nullable<Product> rewardProduct, Nullable<Product> treasureProduct, bool checkNeedSetFishUnBite, Func<Product, Item> checkIfOpenResultPanel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rewardProduct));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(treasureProduct));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkNeedSetFishUnBite;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkIfOpenResultPanel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.ResultContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Product_Nullable_1_Product_Boolean_Func_2_Product_Item_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009501 RID: 38145 RVA: 0x000508DE File Offset: 0x0004EADE
			public ResultContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009502 RID: 38146 RVA: 0x000508E7 File Offset: 0x0004EAE7
			public ResultContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700317F RID: 12671
			// (get) Token: 0x06009503 RID: 38147 RVA: 0x00281F4C File Offset: 0x0028014C
			// (set) Token: 0x06009504 RID: 38148 RVA: 0x000508F9 File Offset: 0x0004EAF9
			public Nullable<Product> RewardProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_RewardProduct);
					return new Nullable<Product>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Product>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_RewardProduct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Product>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003180 RID: 12672
			// (get) Token: 0x06009505 RID: 38149 RVA: 0x00281F7C File Offset: 0x0028017C
			// (set) Token: 0x06009506 RID: 38150 RVA: 0x00050927 File Offset: 0x0004EB27
			public Nullable<Product> TreasureProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_TreasureProduct);
					return new Nullable<Product>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Product>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_TreasureProduct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Product>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003181 RID: 12673
			// (get) Token: 0x06009507 RID: 38151 RVA: 0x00281FAC File Offset: 0x002801AC
			// (set) Token: 0x06009508 RID: 38152 RVA: 0x00050955 File Offset: 0x0004EB55
			public unsafe bool CheckNeedSetFishUnBite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_CheckNeedSetFishUnBite);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_CheckNeedSetFishUnBite)) = value;
				}
			}

			// Token: 0x17003182 RID: 12674
			// (get) Token: 0x06009509 RID: 38153 RVA: 0x00281FD4 File Offset: 0x002801D4
			// (set) Token: 0x0600950A RID: 38154 RVA: 0x00050970 File Offset: 0x0004EB70
			public unsafe Func<Product, Item> CheckIfOpenResultPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_CheckIfOpenResultPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, Item>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.ResultContext.NativeFieldInfoPtr_CheckIfOpenResultPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060A0 RID: 24736
			private static readonly IntPtr NativeFieldInfoPtr_RewardProduct;

			// Token: 0x040060A1 RID: 24737
			private static readonly IntPtr NativeFieldInfoPtr_TreasureProduct;

			// Token: 0x040060A2 RID: 24738
			private static readonly IntPtr NativeFieldInfoPtr_CheckNeedSetFishUnBite;

			// Token: 0x040060A3 RID: 24739
			private static readonly IntPtr NativeFieldInfoPtr_CheckIfOpenResultPanel;

			// Token: 0x040060A4 RID: 24740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Product_Nullable_1_Product_Boolean_Func_2_Product_Item_0;
		}

		// Token: 0x0200066C RID: 1644
		[ObfuscatedName("DayScene.UI.DLC4_DaySceneFishingPrePannel+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600950B RID: 38155 RVA: 0x00282004 File Offset: 0x00280204
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr);
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr_myTrophies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr, "myTrophies");
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr, "<>9__3");
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr, 100667626);
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__1_Internal_Boolean_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr, 100667627);
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr, 100667628);
			}

			// Token: 0x0600950C RID: 38156 RVA: 0x002820A8 File Offset: 0x002802A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600950D RID: 38157 RVA: 0x002820E4 File Offset: 0x002802E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66512, XrefRangeEnd = 66513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpenAsync_b__1(FishingBehaviourCompoent.FishReward x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__1_Internal_Boolean_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600950E RID: 38158 RVA: 0x00282138 File Offset: 0x00280338
			[CallerCount(0)]
			public unsafe bool _OnPanelOpenAsync_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600950F RID: 38159 RVA: 0x0005098F File Offset: 0x0004EB8F
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003183 RID: 12675
			// (get) Token: 0x06009510 RID: 38160 RVA: 0x00282174 File Offset: 0x00280374
			// (set) Token: 0x06009511 RID: 38161 RVA: 0x00050998 File Offset: 0x0004EB98
			public unsafe DLC4_DaySceneFishingPrePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingPrePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003184 RID: 12676
			// (get) Token: 0x06009512 RID: 38162 RVA: 0x002821A4 File Offset: 0x002803A4
			// (set) Token: 0x06009513 RID: 38163 RVA: 0x000509B7 File Offset: 0x0004EBB7
			public unsafe HashSet<int> myTrophies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr_myTrophies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr_myTrophies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003185 RID: 12677
			// (get) Token: 0x06009514 RID: 38164 RVA: 0x002821D4 File Offset: 0x002803D4
			// (set) Token: 0x06009515 RID: 38165 RVA: 0x000509D6 File Offset: 0x0004EBD6
			public unsafe Func<bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060A5 RID: 24741
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040060A6 RID: 24742
			private static readonly IntPtr NativeFieldInfoPtr_myTrophies;

			// Token: 0x040060A7 RID: 24743
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040060A8 RID: 24744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040060A9 RID: 24745
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__1_Internal_Boolean_FishReward_0;

			// Token: 0x040060AA RID: 24746
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__3_Internal_Boolean_0;
		}

		// Token: 0x0200066D RID: 1645
		[ObfuscatedName("DayScene.UI.DLC4_DaySceneFishingPrePannel+<>c__DisplayClass50_1")]
		public sealed class __c__DisplayClass50_1 : Il2CppSystem.Object
		{
			// Token: 0x06009516 RID: 38166 RVA: 0x00282204 File Offset: 0x00280404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_1()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<>c__DisplayClass50_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr);
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeFieldInfoPtr_hardModeQTEPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr, "hardModeQTEPanel");
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeFieldInfoPtr_field_Public___c__DisplayClass50_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr, 100667629);
				DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeMethodInfoPtr__OnPanelOpenAsync_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr, 100667630);
			}

			// Token: 0x06009517 RID: 38167 RVA: 0x00282280 File Offset: 0x00280480
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009518 RID: 38168 RVA: 0x002822BC File Offset: 0x002804BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66513, XrefRangeEnd = 66516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpenAsync_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeMethodInfoPtr__OnPanelOpenAsync_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009519 RID: 38169 RVA: 0x000509F5 File Offset: 0x0004EBF5
			public __c__DisplayClass50_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003186 RID: 12678
			// (get) Token: 0x0600951A RID: 38170 RVA: 0x002822F0 File Offset: 0x002804F0
			// (set) Token: 0x0600951B RID: 38171 RVA: 0x000509FE File Offset: 0x0004EBFE
			public unsafe DLC4_DaySceneFishingQTEPannel hardModeQTEPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeFieldInfoPtr_hardModeQTEPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingQTEPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeFieldInfoPtr_hardModeQTEPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003187 RID: 12679
			// (get) Token: 0x0600951C RID: 38172 RVA: 0x00282320 File Offset: 0x00280520
			// (set) Token: 0x0600951D RID: 38173 RVA: 0x00050A1D File Offset: 0x0004EC1D
			public unsafe DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0 field_Public___c__DisplayClass50_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeFieldInfoPtr_field_Public___c__DisplayClass50_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_1.NativeFieldInfoPtr_field_Public___c__DisplayClass50_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060AB RID: 24747
			private static readonly IntPtr NativeFieldInfoPtr_hardModeQTEPanel;

			// Token: 0x040060AC RID: 24748
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass50_0_0;

			// Token: 0x040060AD RID: 24749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040060AE RID: 24750
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__4_Internal_Void_0;
		}

		// Token: 0x0200066E RID: 1646
		[ObfuscatedName("DayScene.UI.DLC4_DaySceneFishingPrePannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600951E RID: 38174 RVA: 0x00282350 File Offset: 0x00280550
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr);
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9");
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9__50_0");
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__50_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9__50_2");
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9__51_1");
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9__51_2");
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9__51_3");
				DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, "<>9__51_0");
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667632);
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__50_0_Internal_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667633);
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__50_2_Internal_Single_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667634);
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_1_Internal_Boolean_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667635);
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_2_Internal_Boolean_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667636);
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_3_Internal_Single_FishReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667637);
				DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_0_Internal_Item_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr, 100667638);
			}

			// Token: 0x0600951F RID: 38175 RVA: 0x00282494 File Offset: 0x00280694
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009520 RID: 38176 RVA: 0x002824D0 File Offset: 0x002806D0
			[CallerCount(0)]
			public unsafe int _OnPanelOpenAsync_b__50_0(TrophiesProfile.Trophy x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__50_0_Internal_Int32_Trophy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009521 RID: 38177 RVA: 0x00282520 File Offset: 0x00280720
			[CallerCount(0)]
			public unsafe float _OnPanelOpenAsync_b__50_2(FishingBehaviourCompoent.FishReward x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__50_2_Internal_Single_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009522 RID: 38178 RVA: 0x00282574 File Offset: 0x00280774
			[CallerCount(0)]
			public unsafe bool _TryClosePanel_b__51_1(FishingBehaviourCompoent.FishReward x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_1_Internal_Boolean_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009523 RID: 38179 RVA: 0x002825C8 File Offset: 0x002807C8
			[CallerCount(0)]
			public unsafe bool _TryClosePanel_b__51_2(FishingBehaviourCompoent.FishReward x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_2_Internal_Boolean_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009524 RID: 38180 RVA: 0x0028261C File Offset: 0x0028081C
			[CallerCount(0)]
			public unsafe float _TryClosePanel_b__51_3(FishingBehaviourCompoent.FishReward x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_3_Internal_Single_FishReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009525 RID: 38181 RVA: 0x00282670 File Offset: 0x00280870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66516, XrefRangeEnd = 66518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Item _TryClosePanel_b__51_0(Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel.__c.NativeMethodInfoPtr__TryClosePanel_b__51_0_Internal_Item_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Item>(intPtr3) : null;
			}

			// Token: 0x06009526 RID: 38182 RVA: 0x00050A3C File Offset: 0x0004EC3C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003188 RID: 12680
			// (get) Token: 0x06009527 RID: 38183 RVA: 0x002826C8 File Offset: 0x002808C8
			// (set) Token: 0x06009528 RID: 38184 RVA: 0x00050A45 File Offset: 0x0004EC45
			public unsafe static DLC4_DaySceneFishingPrePannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingPrePannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003189 RID: 12681
			// (get) Token: 0x06009529 RID: 38185 RVA: 0x002826F0 File Offset: 0x002808F0
			// (set) Token: 0x0600952A RID: 38186 RVA: 0x00050A57 File Offset: 0x0004EC57
			public unsafe static Func<TrophiesProfile.Trophy, int> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrophiesProfile.Trophy, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700318A RID: 12682
			// (get) Token: 0x0600952B RID: 38187 RVA: 0x00282718 File Offset: 0x00280918
			// (set) Token: 0x0600952C RID: 38188 RVA: 0x00050A69 File Offset: 0x0004EC69
			public unsafe static Func<FishingBehaviourCompoent.FishReward, float> __9__50_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__50_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FishingBehaviourCompoent.FishReward, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__50_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700318B RID: 12683
			// (get) Token: 0x0600952D RID: 38189 RVA: 0x00282740 File Offset: 0x00280940
			// (set) Token: 0x0600952E RID: 38190 RVA: 0x00050A7B File Offset: 0x0004EC7B
			public unsafe static Func<FishingBehaviourCompoent.FishReward, bool> __9__51_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FishingBehaviourCompoent.FishReward, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700318C RID: 12684
			// (get) Token: 0x0600952F RID: 38191 RVA: 0x00282768 File Offset: 0x00280968
			// (set) Token: 0x06009530 RID: 38192 RVA: 0x00050A8D File Offset: 0x0004EC8D
			public unsafe static Func<FishingBehaviourCompoent.FishReward, bool> __9__51_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FishingBehaviourCompoent.FishReward, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700318D RID: 12685
			// (get) Token: 0x06009531 RID: 38193 RVA: 0x00282790 File Offset: 0x00280990
			// (set) Token: 0x06009532 RID: 38194 RVA: 0x00050A9F File Offset: 0x0004EC9F
			public unsafe static Func<FishingBehaviourCompoent.FishReward, float> __9__51_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FishingBehaviourCompoent.FishReward, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700318E RID: 12686
			// (get) Token: 0x06009533 RID: 38195 RVA: 0x002827B8 File Offset: 0x002809B8
			// (set) Token: 0x06009534 RID: 38196 RVA: 0x00050AB1 File Offset: 0x0004ECB1
			public unsafe static Func<Product, Item> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingPrePannel.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060AF RID: 24751
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040060B0 RID: 24752
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x040060B1 RID: 24753
			private static readonly IntPtr NativeFieldInfoPtr___9__50_2;

			// Token: 0x040060B2 RID: 24754
			private static readonly IntPtr NativeFieldInfoPtr___9__51_1;

			// Token: 0x040060B3 RID: 24755
			private static readonly IntPtr NativeFieldInfoPtr___9__51_2;

			// Token: 0x040060B4 RID: 24756
			private static readonly IntPtr NativeFieldInfoPtr___9__51_3;

			// Token: 0x040060B5 RID: 24757
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x040060B6 RID: 24758
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040060B7 RID: 24759
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__50_0_Internal_Int32_Trophy_0;

			// Token: 0x040060B8 RID: 24760
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__50_2_Internal_Single_FishReward_0;

			// Token: 0x040060B9 RID: 24761
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__51_1_Internal_Boolean_FishReward_0;

			// Token: 0x040060BA RID: 24762
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__51_2_Internal_Boolean_FishReward_0;

			// Token: 0x040060BB RID: 24763
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__51_3_Internal_Single_FishReward_0;

			// Token: 0x040060BC RID: 24764
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__51_0_Internal_Item_Product_0;
		}

		// Token: 0x0200066F RID: 1647
		[ObfuscatedName("DayScene.UI.DLC4_DaySceneFishingPrePannel+<OnPanelOpenAsync>d__50")]
		public sealed class _OnPanelOpenAsync_d__50 : ValueType
		{
			// Token: 0x06009535 RID: 38197 RVA: 0x002827E0 File Offset: 0x002809E0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__50()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel>.NativeClassPtr, "<OnPanelOpenAsync>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr);
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<>1__state");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<>t__builder");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<>4__this");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<>8__1");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<token>5__2");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<>u__1");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, "<>u__2");
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, 100667639);
				DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr, 100667640);
			}

			// Token: 0x06009536 RID: 38198 RVA: 0x002828C0 File Offset: 0x00280AC0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 66719, RefRangeEnd = 66721, XrefRangeStart = 66518, XrefRangeEnd = 66719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009537 RID: 38199 RVA: 0x002828F8 File Offset: 0x00280AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009538 RID: 38200 RVA: 0x00050AC3 File Offset: 0x0004ECC3
			public _OnPanelOpenAsync_d__50(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009539 RID: 38201 RVA: 0x00050ACC File Offset: 0x0004ECCC
			public _OnPanelOpenAsync_d__50() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50>.NativeClassPtr))
			{
			}

			// Token: 0x1700318F RID: 12687
			// (get) Token: 0x0600953A RID: 38202 RVA: 0x00282940 File Offset: 0x00280B40
			// (set) Token: 0x0600953B RID: 38203 RVA: 0x00050ADE File Offset: 0x0004ECDE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003190 RID: 12688
			// (get) Token: 0x0600953C RID: 38204 RVA: 0x00282968 File Offset: 0x00280B68
			// (set) Token: 0x0600953D RID: 38205 RVA: 0x00050AF9 File Offset: 0x0004ECF9
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003191 RID: 12689
			// (get) Token: 0x0600953E RID: 38206 RVA: 0x00282998 File Offset: 0x00280B98
			// (set) Token: 0x0600953F RID: 38207 RVA: 0x00050B27 File Offset: 0x0004ED27
			public unsafe DLC4_DaySceneFishingPrePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingPrePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003192 RID: 12690
			// (get) Token: 0x06009540 RID: 38208 RVA: 0x002829C8 File Offset: 0x00280BC8
			// (set) Token: 0x06009541 RID: 38209 RVA: 0x00050B46 File Offset: 0x0004ED46
			public unsafe DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingPrePannel.__c__DisplayClass50_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003193 RID: 12691
			// (get) Token: 0x06009542 RID: 38210 RVA: 0x002829F8 File Offset: 0x00280BF8
			// (set) Token: 0x06009543 RID: 38211 RVA: 0x00050B65 File Offset: 0x0004ED65
			public CancellationToken _token_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr__token_5__2);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr__token_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003194 RID: 12692
			// (get) Token: 0x06009544 RID: 38212 RVA: 0x00282A28 File Offset: 0x00280C28
			// (set) Token: 0x06009545 RID: 38213 RVA: 0x00050B93 File Offset: 0x0004ED93
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003195 RID: 12693
			// (get) Token: 0x06009546 RID: 38214 RVA: 0x00282A58 File Offset: 0x00280C58
			// (set) Token: 0x06009547 RID: 38215 RVA: 0x00050BC1 File Offset: 0x0004EDC1
			public UniTask<int>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___u__2);
					return new UniTask<int>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingPrePannel._OnPanelOpenAsync_d__50.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040060BD RID: 24765
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040060BE RID: 24766
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040060BF RID: 24767
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040060C0 RID: 24768
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040060C1 RID: 24769
			private static readonly IntPtr NativeFieldInfoPtr__token_5__2;

			// Token: 0x040060C2 RID: 24770
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040060C3 RID: 24771
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040060C4 RID: 24772
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040060C5 RID: 24773
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
