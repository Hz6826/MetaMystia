using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x020000CB RID: 203
	public class DLC4_DaySceneFishingQTEPannel : UISubPanel<DLC4_DaySceneFishingPrePannel>
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x000EF068 File Offset: 0x000ED268
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_DaySceneFishingQTEPannel()
		{
			Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_DaySceneFishingQTEPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr);
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "G");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_M = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "M");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingStartProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_FishingStartProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureSpawnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureSpawnArea");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_DeterminationPointStartProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_DeterminationPointStartProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_SliderBoxLength");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxProgressChangeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_SliderBoxProgressChangeAmount");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressAddPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_FishingProgressAddPerSec");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressLosePerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_FishingProgressLosePerSec");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ForceWhenPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_ForceWhenPressed");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SpeedToProgressPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_SpeedToProgressPercentage");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressGetPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureProgressGetPerSec");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressLosePerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureProgressLosePerSec");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishMoveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_FishMoveMode");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ShakeFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_ShakeFlow");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ShakeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_ShakeOffset");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_WholeUIParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_WholeUIParent");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_Offset");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_FishingArea");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureImage");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureArea");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureProgressIndicator");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_FishingProgressIndicator");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxProgressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_SliderBoxProgressIndicator");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_TreasureAnimator");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_DeterminedPointIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_DeterminedPointIndicator");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_AnimatorKey_Disappear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "AnimatorKey_Disappear");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_AnimatorKey_Idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "AnimatorKey_Idle");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentDeterminationPointProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "currentDeterminationPointProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentFishingProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "currentFishingProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentSliderBoxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "currentSliderBoxProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "currentSpeed");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentTreasureGetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "currentTreasureGetProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_fishingAreaHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "fishingAreaHeight");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_getTreasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "getTreasure");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_hasEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "hasEnd");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_inArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "inArea");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_initialDeterminationPointProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "initialDeterminationPointProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_initialMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "initialMoveSpeed");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_isPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "isPressed");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_CurrentModeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "m_CurrentModeIndex");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_moveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "moveDuration");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_moveStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "moveStatus");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_needWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "needWaitTime");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_onUpdatingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "onUpdatingData");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_shouldShowTreasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "shouldShowTreasure");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_targetFishYPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "targetFishYPosition");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_targetSliderBoxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "targetSliderBoxProgress");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "timer");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_treasurePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "treasurePosition");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr__CurrentFishMoveMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "<CurrentFishMoveMode>k__BackingField");
			DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "<Result>k__BackingField");
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_CurrentFishMoveMode_Public_get_FishMoveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667641);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_set_CurrentFishMoveMode_Public_set_Void_FishMoveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667642);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_Result_Public_get_FishingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667643);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_set_Result_Private_set_Void_FishingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667644);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_CurrentMoveMode_Private_get_MoveModeProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667645);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667646);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_RandomFlowOffset_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667647);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667648);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667649);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnSubmit_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667650);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnCancel_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667651);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667652);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnUpdateProgress_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667653);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_GetLevel_Private_FishMoveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667654);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667655);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_FreeFall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667656);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_TryMoveFish_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667657);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_UpdateFishingAndTreasureProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667658);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667659);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667660);
			DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, 100667661);
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000EF64C File Offset: 0x000ED84C
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x000EF688 File Offset: 0x000ED888
		public unsafe DLC4_DaySceneFishingQTEPannel.FishMoveMode CurrentFishMoveMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_CurrentFishMoveMode_Public_get_FishMoveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_set_CurrentFishMoveMode_Public_set_Void_FishMoveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000EF6C8 File Offset: 0x000ED8C8
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x000EF704 File Offset: 0x000ED904
		public unsafe DLC4_DaySceneFishingQTEPannel.FishingResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_Result_Public_get_FishingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_set_Result_Private_set_Void_FishingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x000EF744 File Offset: 0x000ED944
		public unsafe DLC4_DaySceneFishingQTEPannel.MoveModeProperty CurrentMoveMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_CurrentMoveMode_Private_get_MoveModeProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000EF780 File Offset: 0x000ED980
		public unsafe override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x000EF7C8 File Offset: 0x000ED9C8
		public unsafe float RandomFlowOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66904, XrefRangeEnd = 66907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_get_RandomFlowOffset_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000EF804 File Offset: 0x000EDA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66907, XrefRangeEnd = 66917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000EF838 File Offset: 0x000EDA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66917, XrefRangeEnd = 66967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000EF874 File Offset: 0x000EDA74
		[CallerCount(0)]
		public unsafe void OnSubmit(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnSubmit_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000EF8BC File Offset: 0x000EDABC
		[CallerCount(0)]
		public unsafe void OnCancel(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnCancel_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000EF904 File Offset: 0x000EDB04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66980, RefRangeEnd = 66983, XrefRangeStart = 66967, XrefRangeEnd = 66980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000EF938 File Offset: 0x000EDB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66983, XrefRangeEnd = 66988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnUpdateProgress_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000EF978 File Offset: 0x000EDB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66988, XrefRangeEnd = 66989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_DaySceneFishingQTEPannel.FishMoveMode GetLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_GetLevel_Private_FishMoveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000EF9B4 File Offset: 0x000EDBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66989, XrefRangeEnd = 67022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000EF9F0 File Offset: 0x000EDBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67022, XrefRangeEnd = 67024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeFall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_FreeFall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000EFA24 File Offset: 0x000EDC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67024, RefRangeEnd = 67025, XrefRangeStart = 67024, XrefRangeEnd = 67024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryMoveFish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_TryMoveFish_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000EFA58 File Offset: 0x000EDC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67040, RefRangeEnd = 67041, XrefRangeStart = 67025, XrefRangeEnd = 67040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFishingAndTreasureProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_UpdateFishingAndTreasureProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000EFA8C File Offset: 0x000EDC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67041, XrefRangeEnd = 67044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000EFAC8 File Offset: 0x000EDCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67044, XrefRangeEnd = 67056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000EFB04 File Offset: 0x000EDD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67056, XrefRangeEnd = 67065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_DaySceneFishingQTEPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0000EFAB File Offset: 0x0000D1AB
		public DLC4_DaySceneFishingQTEPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x000EFB40 File Offset: 0x000EDD40
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		public unsafe static float G
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_G, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_G, (void*)(&value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x000EFB5C File Offset: 0x000EDD5C
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x0000EFC2 File Offset: 0x0000D1C2
		public unsafe static int M
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_M, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_M, (void*)(&value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x000EFB78 File Offset: 0x000EDD78
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public unsafe float m_FishingStartProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingStartProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingStartProgress)) = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x000EFBA0 File Offset: 0x000EDDA0
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0000EFEB File Offset: 0x0000D1EB
		public unsafe Vector2 m_TreasureSpawnArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureSpawnArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureSpawnArea)) = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x000EFBC8 File Offset: 0x000EDDC8
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x0000F006 File Offset: 0x0000D206
		public unsafe Vector2 m_DeterminationPointStartProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_DeterminationPointStartProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_DeterminationPointStartProgress)) = value;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x000EFBF0 File Offset: 0x000EDDF0
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x0000F021 File Offset: 0x0000D221
		public unsafe float m_SliderBoxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxLength)) = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000EFC18 File Offset: 0x000EDE18
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000F03C File Offset: 0x0000D23C
		public unsafe float m_SliderBoxProgressChangeAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxProgressChangeAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxProgressChangeAmount)) = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000EFC40 File Offset: 0x000EDE40
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000F057 File Offset: 0x0000D257
		public unsafe float m_FishingProgressAddPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressAddPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressAddPerSec)) = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x000EFC68 File Offset: 0x000EDE68
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x0000F072 File Offset: 0x0000D272
		public unsafe float m_FishingProgressLosePerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressLosePerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressLosePerSec)) = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x000EFC90 File Offset: 0x000EDE90
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000F08D File Offset: 0x0000D28D
		public unsafe float m_ForceWhenPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ForceWhenPressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ForceWhenPressed)) = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x000EFCB8 File Offset: 0x000EDEB8
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		public unsafe float m_SpeedToProgressPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SpeedToProgressPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SpeedToProgressPercentage)) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x000EFCE0 File Offset: 0x000EDEE0
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0000F0C3 File Offset: 0x0000D2C3
		public unsafe float m_TreasureProgressGetPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressGetPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressGetPerSec)) = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x000EFD08 File Offset: 0x000EDF08
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000F0DE File Offset: 0x0000D2DE
		public unsafe float m_TreasureProgressLosePerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressLosePerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressLosePerSec)) = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x000EFD30 File Offset: 0x000EDF30
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x0000F0F9 File Offset: 0x0000D2F9
		public unsafe Il2CppStructArray<DLC4_DaySceneFishingQTEPannel.MoveModeProperty> m_FishMoveMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishMoveMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishMoveMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x000EFD60 File Offset: 0x000EDF60
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0000F118 File Offset: 0x0000D318
		public unsafe Vector3 m_ShakeFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ShakeFlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ShakeFlow)) = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x000EFD88 File Offset: 0x000EDF88
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0000F133 File Offset: 0x0000D333
		public unsafe float m_ShakeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ShakeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_ShakeOffset)) = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x000EFDB0 File Offset: 0x000EDFB0
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x0000F14E File Offset: 0x0000D34E
		public unsafe RectTransform m_WholeUIParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_WholeUIParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_WholeUIParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x000EFDE0 File Offset: 0x000EDFE0
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000F16D File Offset: 0x0000D36D
		public unsafe Vector3 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x000EFE08 File Offset: 0x000EE008
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000F188 File Offset: 0x0000D388
		public unsafe RectTransform m_FishingArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x000EFE38 File Offset: 0x000EE038
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000F1A7 File Offset: 0x0000D3A7
		public unsafe RectTransform m_TreasureImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x000EFE68 File Offset: 0x000EE068
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0000F1C6 File Offset: 0x0000D3C6
		public unsafe CanvasGroup m_TreasureArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x000EFE98 File Offset: 0x000EE098
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0000F1E5 File Offset: 0x0000D3E5
		public unsafe AdpProgressIndicatorComponent m_TreasureProgressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureProgressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x000EFEC8 File Offset: 0x000EE0C8
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x0000F204 File Offset: 0x0000D404
		public unsafe AdpProgressIndicatorComponent m_FishingProgressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_FishingProgressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x000EFEF8 File Offset: 0x000EE0F8
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x0000F223 File Offset: 0x0000D423
		public unsafe AdpProgressIndicatorComponent m_SliderBoxProgressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxProgressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_SliderBoxProgressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x000EFF28 File Offset: 0x000EE128
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x0000F242 File Offset: 0x0000D442
		public unsafe Animator m_TreasureAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_TreasureAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x000EFF58 File Offset: 0x000EE158
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x0000F261 File Offset: 0x0000D461
		public unsafe AdpProgressIndicatorComponent m_DeterminedPointIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_DeterminedPointIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_DeterminedPointIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000EFF88 File Offset: 0x000EE188
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x0000F280 File Offset: 0x0000D480
		public unsafe int AnimatorKey_Disappear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_AnimatorKey_Disappear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_AnimatorKey_Disappear)) = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x000EFFB0 File Offset: 0x000EE1B0
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x0000F29B File Offset: 0x0000D49B
		public unsafe int AnimatorKey_Idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_AnimatorKey_Idle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_AnimatorKey_Idle)) = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x000EFFD8 File Offset: 0x000EE1D8
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x0000F2B6 File Offset: 0x0000D4B6
		public unsafe float currentDeterminationPointProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentDeterminationPointProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentDeterminationPointProgress)) = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x000F0000 File Offset: 0x000EE200
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x0000F2D1 File Offset: 0x0000D4D1
		public unsafe float currentFishingProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentFishingProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentFishingProgress)) = value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x000F0028 File Offset: 0x000EE228
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		public unsafe float currentSliderBoxProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentSliderBoxProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentSliderBoxProgress)) = value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000F0050 File Offset: 0x000EE250
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000F307 File Offset: 0x0000D507
		public unsafe float currentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentSpeed)) = value;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000F0078 File Offset: 0x000EE278
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000F322 File Offset: 0x0000D522
		public unsafe float currentTreasureGetProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentTreasureGetProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_currentTreasureGetProgress)) = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x000F00A0 File Offset: 0x000EE2A0
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0000F33D File Offset: 0x0000D53D
		public unsafe float fishingAreaHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_fishingAreaHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_fishingAreaHeight)) = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x000F00C8 File Offset: 0x000EE2C8
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0000F358 File Offset: 0x0000D558
		public unsafe bool getTreasure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_getTreasure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_getTreasure)) = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000F00F0 File Offset: 0x000EE2F0
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000F373 File Offset: 0x0000D573
		public unsafe bool hasEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_hasEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_hasEnd)) = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x000F0118 File Offset: 0x000EE318
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000F38E File Offset: 0x0000D58E
		public unsafe bool inArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_inArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_inArea)) = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x000F0140 File Offset: 0x000EE340
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0000F3A9 File Offset: 0x0000D5A9
		public unsafe float initialDeterminationPointProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_initialDeterminationPointProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_initialDeterminationPointProgress)) = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x000F0168 File Offset: 0x000EE368
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		public unsafe float initialMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_initialMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_initialMoveSpeed)) = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000F0190 File Offset: 0x000EE390
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000F3DF File Offset: 0x0000D5DF
		public unsafe bool isPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_isPressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_isPressed)) = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000F01B8 File Offset: 0x000EE3B8
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0000F3FA File Offset: 0x0000D5FA
		public unsafe int m_CurrentModeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_CurrentModeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_m_CurrentModeIndex)) = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x000F01E0 File Offset: 0x000EE3E0
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0000F415 File Offset: 0x0000D615
		public unsafe float moveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_moveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_moveDuration)) = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000F0208 File Offset: 0x000EE408
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0000F430 File Offset: 0x0000D630
		public unsafe DLC4_DaySceneFishingQTEPannel.MoveStatus moveStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_moveStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_moveStatus)) = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000F0230 File Offset: 0x000EE430
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x0000F44B File Offset: 0x0000D64B
		public unsafe float needWaitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_needWaitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_needWaitTime)) = value;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000F0258 File Offset: 0x000EE458
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000F466 File Offset: 0x0000D666
		public unsafe Coroutine onUpdatingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_onUpdatingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_onUpdatingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000F0288 File Offset: 0x000EE488
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000F485 File Offset: 0x0000D685
		public unsafe bool shouldShowTreasure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_shouldShowTreasure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_shouldShowTreasure)) = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x000F02B0 File Offset: 0x000EE4B0
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		public unsafe float targetFishYPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_targetFishYPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_targetFishYPosition)) = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000F02D8 File Offset: 0x000EE4D8
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000F4BB File Offset: 0x0000D6BB
		public unsafe float targetSliderBoxProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_targetSliderBoxProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_targetSliderBoxProgress)) = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x000F0300 File Offset: 0x000EE500
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x0000F4D6 File Offset: 0x0000D6D6
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x000F0328 File Offset: 0x000EE528
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
		public unsafe float treasurePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_treasurePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr_treasurePosition)) = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x000F0350 File Offset: 0x000EE550
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000F50C File Offset: 0x0000D70C
		public unsafe DLC4_DaySceneFishingQTEPannel.FishMoveMode _CurrentFishMoveMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr__CurrentFishMoveMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr__CurrentFishMoveMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x000F0378 File Offset: 0x000EE578
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x0000F527 File Offset: 0x0000D727
		public unsafe DLC4_DaySceneFishingQTEPannel.FishingResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr_G;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr_M;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingStartProgress;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureSpawnArea;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_m_DeterminationPointStartProgress;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_m_SliderBoxLength;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_m_SliderBoxProgressChangeAmount;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingProgressAddPerSec;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingProgressLosePerSec;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceWhenPressed;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_m_SpeedToProgressPercentage;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureProgressGetPerSec;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureProgressLosePerSec;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_m_FishMoveMode;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_m_ShakeFlow;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr_m_ShakeOffset;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeUIParent;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingArea;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureImage;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureArea;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureProgressIndicator;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingProgressIndicator;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_m_SliderBoxProgressIndicator;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureAnimator;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_m_DeterminedPointIndicator;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorKey_Disappear;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorKey_Idle;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr_currentDeterminationPointProgress;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeFieldInfoPtr_currentFishingProgress;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeFieldInfoPtr_currentSliderBoxProgress;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeed;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr_currentTreasureGetProgress;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_fishingAreaHeight;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_getTreasure;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr_hasEnd;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_inArea;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_initialDeterminationPointProgress;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_initialMoveSpeed;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr_isPressed;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentModeIndex;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr_moveDuration;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_moveStatus;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_needWaitTime;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingData;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr_shouldShowTreasure;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr_targetFishYPosition;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeFieldInfoPtr_targetSliderBoxProgress;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeFieldInfoPtr_treasurePosition;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFishMoveMode_k__BackingField;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFishMoveMode_Public_get_FishMoveMode_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentFishMoveMode_Public_set_Void_FishMoveMode_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_FishingResult_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_FishingResult_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMoveMode_Private_get_MoveModeProperty_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_get_RandomFlowOffset_Private_get_Single_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_CallbackContext_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Private_Void_CallbackContext_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateProgress_Private_IEnumerator_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_GetLevel_Private_FishMoveMode_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_FreeFall_Private_Void_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_TryMoveFish_Private_Void_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFishingAndTreasureProgress_Private_Void_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000670 RID: 1648
		public enum FishingResult
		{
			// Token: 0x040060C7 RID: 24775
			Fail,
			// Token: 0x040060C8 RID: 24776
			Success,
			// Token: 0x040060C9 RID: 24777
			SuccessAndGetTreasure
		}

		// Token: 0x02000671 RID: 1649
		public enum FishMoveMode
		{
			// Token: 0x040060CB RID: 24779
			Smooth,
			// Token: 0x040060CC RID: 24780
			Mixed,
			// Token: 0x040060CD RID: 24781
			Dart
		}

		// Token: 0x02000672 RID: 1650
		[Serializable]
		[StructLayout(2)]
		public struct MoveModeProperty
		{
			// Token: 0x06009548 RID: 38216 RVA: 0x00282A88 File Offset: 0x00280C88
			// Note: this type is marked as 'beforefieldinit'.
			static MoveModeProperty()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "MoveModeProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr);
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeFieldInfoPtr_fishMoveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, "fishMoveMode");
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeFieldInfoPtr_displacementDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, "displacementDistance");
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeFieldInfoPtr_displacementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, "displacementSpeed");
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, "waitTime");
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeFieldInfoPtr_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, "rate");
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_FishMoveMode_Public_get_FishMoveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, 100667662);
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_DisplacementDistance_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, 100667663);
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_DisplacementSpeed_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, 100667664);
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_WaitTime_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, 100667665);
				DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_Rate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, 100667666);
			}

			// Token: 0x17003196 RID: 12694
			// (get) Token: 0x06009549 RID: 38217 RVA: 0x00282B7C File Offset: 0x00280D7C
			public unsafe DLC4_DaySceneFishingQTEPannel.FishMoveMode FishMoveMode
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_FishMoveMode_Public_get_FishMoveMode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003197 RID: 12695
			// (get) Token: 0x0600954A RID: 38218 RVA: 0x00282BAC File Offset: 0x00280DAC
			public unsafe Vector2 DisplacementDistance
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_DisplacementDistance_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003198 RID: 12696
			// (get) Token: 0x0600954B RID: 38219 RVA: 0x00282BDC File Offset: 0x00280DDC
			public unsafe Vector2 DisplacementSpeed
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_DisplacementSpeed_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003199 RID: 12697
			// (get) Token: 0x0600954C RID: 38220 RVA: 0x00282C0C File Offset: 0x00280E0C
			public unsafe Vector2 WaitTime
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_WaitTime_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700319A RID: 12698
			// (get) Token: 0x0600954D RID: 38221 RVA: 0x00282C3C File Offset: 0x00280E3C
			public unsafe float Rate
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel.MoveModeProperty.NativeMethodInfoPtr_get_Rate_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600954E RID: 38222 RVA: 0x00050BEF File Offset: 0x0004EDEF
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel.MoveModeProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x040060CE RID: 24782
			private static readonly IntPtr NativeFieldInfoPtr_fishMoveMode;

			// Token: 0x040060CF RID: 24783
			private static readonly IntPtr NativeFieldInfoPtr_displacementDistance;

			// Token: 0x040060D0 RID: 24784
			private static readonly IntPtr NativeFieldInfoPtr_displacementSpeed;

			// Token: 0x040060D1 RID: 24785
			private static readonly IntPtr NativeFieldInfoPtr_waitTime;

			// Token: 0x040060D2 RID: 24786
			private static readonly IntPtr NativeFieldInfoPtr_rate;

			// Token: 0x040060D3 RID: 24787
			private static readonly IntPtr NativeMethodInfoPtr_get_FishMoveMode_Public_get_FishMoveMode_0;

			// Token: 0x040060D4 RID: 24788
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplacementDistance_Public_get_Vector2_0;

			// Token: 0x040060D5 RID: 24789
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplacementSpeed_Public_get_Vector2_0;

			// Token: 0x040060D6 RID: 24790
			private static readonly IntPtr NativeMethodInfoPtr_get_WaitTime_Public_get_Vector2_0;

			// Token: 0x040060D7 RID: 24791
			private static readonly IntPtr NativeMethodInfoPtr_get_Rate_Public_get_Single_0;

			// Token: 0x040060D8 RID: 24792
			[FieldOffset(0)]
			public DLC4_DaySceneFishingQTEPannel.FishMoveMode fishMoveMode;

			// Token: 0x040060D9 RID: 24793
			[FieldOffset(4)]
			public Vector2 displacementDistance;

			// Token: 0x040060DA RID: 24794
			[FieldOffset(12)]
			public Vector2 displacementSpeed;

			// Token: 0x040060DB RID: 24795
			[FieldOffset(20)]
			public Vector2 waitTime;

			// Token: 0x040060DC RID: 24796
			[FieldOffset(28)]
			public float rate;
		}

		// Token: 0x02000673 RID: 1651
		public enum MoveStatus
		{
			// Token: 0x040060DE RID: 24798
			Moving,
			// Token: 0x040060DF RID: 24799
			Waiting
		}

		// Token: 0x02000674 RID: 1652
		[ObfuscatedName("DayScene.UI.DLC4_DaySceneFishingQTEPannel+<OnUpdateProgress>d__71")]
		public sealed class _OnUpdateProgress_d__71 : Il2CppSystem.Object
		{
			// Token: 0x0600954F RID: 38223 RVA: 0x00282C6C File Offset: 0x00280E6C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateProgress_d__71()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel>.NativeClassPtr, "<OnUpdateProgress>d__71");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr);
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, "<>1__state");
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, "<>2__current");
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, "<>4__this");
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, 100667667);
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, 100667668);
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, 100667669);
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, 100667670);
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, 100667671);
				DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr, 100667672);
			}

			// Token: 0x06009550 RID: 38224 RVA: 0x00282D4C File Offset: 0x00280F4C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateProgress_d__71(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009551 RID: 38225 RVA: 0x00282D94 File Offset: 0x00280F94
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009552 RID: 38226 RVA: 0x00282DC8 File Offset: 0x00280FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66894, XrefRangeEnd = 66898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700319E RID: 12702
			// (get) Token: 0x06009553 RID: 38227 RVA: 0x00282E04 File Offset: 0x00281004
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009554 RID: 38228 RVA: 0x00282E44 File Offset: 0x00281044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66898, XrefRangeEnd = 66904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700319F RID: 12703
			// (get) Token: 0x06009555 RID: 38229 RVA: 0x00282E78 File Offset: 0x00281078
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009556 RID: 38230 RVA: 0x00050C01 File Offset: 0x0004EE01
			public _OnUpdateProgress_d__71(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700319B RID: 12699
			// (get) Token: 0x06009557 RID: 38231 RVA: 0x00282EB8 File Offset: 0x002810B8
			// (set) Token: 0x06009558 RID: 38232 RVA: 0x00050C0A File Offset: 0x0004EE0A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700319C RID: 12700
			// (get) Token: 0x06009559 RID: 38233 RVA: 0x00282EE0 File Offset: 0x002810E0
			// (set) Token: 0x0600955A RID: 38234 RVA: 0x00050C25 File Offset: 0x0004EE25
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700319D RID: 12701
			// (get) Token: 0x0600955B RID: 38235 RVA: 0x00282F10 File Offset: 0x00281110
			// (set) Token: 0x0600955C RID: 38236 RVA: 0x00050C44 File Offset: 0x0004EE44
			public unsafe DLC4_DaySceneFishingQTEPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingQTEPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingQTEPannel._OnUpdateProgress_d__71.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060E0 RID: 24800
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040060E1 RID: 24801
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040060E2 RID: 24802
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040060E3 RID: 24803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040060E4 RID: 24804
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040060E5 RID: 24805
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040060E6 RID: 24806
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040060E7 RID: 24807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040060E8 RID: 24808
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
