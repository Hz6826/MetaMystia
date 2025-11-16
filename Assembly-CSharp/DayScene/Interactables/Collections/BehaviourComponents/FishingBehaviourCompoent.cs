using System;
using System.Runtime.InteropServices;
using Common.UI;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Input;
using DayScene.UI;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene.UI.GuestManagementUtility;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000181 RID: 385
	public class FishingBehaviourCompoent : EntityBehaviourComponent
	{
		// Token: 0x060029C8 RID: 10696 RVA: 0x001296AC File Offset: 0x001278AC
		// Note: this type is marked as 'beforefieldinit'.
		static FishingBehaviourCompoent()
		{
			Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "FishingBehaviourCompoent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr);
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_PlayerTargetPosition");
			FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Throw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "AnimatorKey_Throw");
			FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Bite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "AnimatorKey_Bite");
			FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_UnBite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "AnimatorKey_UnBite");
			FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "AnimatorKey_Lift");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_daySceneFishingPrePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_daySceneFishingPrePannel");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_daySceneFishingResultPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_daySceneFishingResultPannel");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_FishingRodAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_FishingRodAnimator");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerFishingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_PlayerFishingPosition");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerThrowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_PlayerThrowPosition");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerThrowAnimationEndDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_PlayerThrowAnimationEndDelay");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_UnBiteDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_UnBiteDelay");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_TreasureDelay");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureBonusVFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_TreasureBonusVFXOffset");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_DialogBoxUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_DialogBoxUI");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_DialogBoxUIDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_DialogBoxUIDuration");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_ResultSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_ResultSpriteRenderer");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_TreasureSpriteRenderer");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_TreasureSprite");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_RubbishSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_RubbishSprite");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_BonusEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_BonusEffect");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_VisualPointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_VisualPointPosition");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_VisualPointHelperOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_VisualPointHelperOffset");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_LiftFromWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_LiftFromWater");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_AfterLifting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_AfterLifting");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_BiteSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_BiteSfx");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_fishRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_fishRewards");
			FishingBehaviourCompoent.NativeFieldInfoPtr_m_fishRewardsTreasureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "m_fishRewardsTreasureMode");
			FishingBehaviourCompoent.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "currentState");
			FishingBehaviourCompoent.NativeMethodInfoPtr_get_DoNotAutoFacingWhenInteract_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670591);
			FishingBehaviourCompoent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670592);
			FishingBehaviourCompoent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670593);
			FishingBehaviourCompoent.NativeMethodInfoPtr_OnInteractAsync_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670594);
			FishingBehaviourCompoent.NativeMethodInfoPtr_ShowDialogBoxes_Private_UniTask_Transform_Il2CppStructArray_1_FishingResultState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670595);
			FishingBehaviourCompoent.NativeMethodInfoPtr_CreateDialogBoxAsync_Private_UniTask_FishingResultState_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670596);
			FishingBehaviourCompoent.NativeMethodInfoPtr_SpawnBonusVFX_Private_UniTask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670597);
			FishingBehaviourCompoent.NativeMethodInfoPtr_CharacterStep_Private_UniTask_Transform_DayScenePlayerInputGenerator_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670598);
			FishingBehaviourCompoent.NativeMethodInfoPtr_SetRodAnimator_Private_Void_FishingRotState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670599);
			FishingBehaviourCompoent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670600);
			FishingBehaviourCompoent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670601);
			FishingBehaviourCompoent.NativeMethodInfoPtr__OnInteractAsync_b__33_0_Private_Void_DLC4_DaySceneFishingPrePannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670603);
			FishingBehaviourCompoent.NativeMethodInfoPtr__OnInteractAsync_b__33_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670604);
			FishingBehaviourCompoent.NativeMethodInfoPtr__OnInteractAsync_b__33_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, 100670605);
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x00129A38 File Offset: 0x00127C38
		public unsafe override bool DoNotAutoFacingWhenInteract
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingBehaviourCompoent.NativeMethodInfoPtr_get_DoNotAutoFacingWhenInteract_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00129A80 File Offset: 0x00127C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94252, XrefRangeEnd = 94260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingBehaviourCompoent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00129ABC File Offset: 0x00127CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94260, XrefRangeEnd = 94267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingBehaviourCompoent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00129AF8 File Offset: 0x00127CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94267, XrefRangeEnd = 94273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OnInteractAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr_OnInteractAsync_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00129B34 File Offset: 0x00127D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94281, RefRangeEnd = 94282, XrefRangeStart = 94273, XrefRangeEnd = 94281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask ShowDialogBoxes(Transform characterTransform, [Optional] Il2CppStructArray<FishingBehaviourCompoent.FishingResultState> fishingResultStates)
		{
			if (fishingResultStates == null)
			{
				fishingResultStates = new Il2CppStructArray<FishingBehaviourCompoent.FishingResultState>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterTransform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fishingResultStates);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr_ShowDialogBoxes_Private_UniTask_Transform_Il2CppStructArray_1_FishingResultState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00129B9C File Offset: 0x00127D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94289, RefRangeEnd = 94290, XrefRangeStart = 94282, XrefRangeEnd = 94289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask CreateDialogBoxAsync(FishingBehaviourCompoent.FishingResultState fishingResultState, Transform characterTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fishingResultState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterTransform);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr_CreateDialogBoxAsync_Private_UniTask_FishingResultState_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00129BF4 File Offset: 0x00127DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94290, XrefRangeEnd = 94296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SpawnBonusVFX(bool shouldSpawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldSpawn;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr_SpawnBonusVFX_Private_UniTask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00129C38 File Offset: 0x00127E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94304, RefRangeEnd = 94306, XrefRangeStart = 94296, XrefRangeEnd = 94304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask CharacterStep(Transform characterTransform, DayScenePlayerInputGenerator character, Vector3 characterStartPosition, Vector3 characterTargetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterTransform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterStartPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterTargetPosition;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr_CharacterStep_Private_UniTask_Transform_DayScenePlayerInputGenerator_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00129CB0 File Offset: 0x00127EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94333, RefRangeEnd = 94334, XrefRangeStart = 94306, XrefRangeEnd = 94333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRodAnimator(FishingBehaviourCompoent.FishingRotState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr_SetRodAnimator_Private_Void_FishingRotState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00129CF0 File Offset: 0x00127EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94334, XrefRangeEnd = 94352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingBehaviourCompoent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00129D2C File Offset: 0x00127F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishingBehaviourCompoent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00129D68 File Offset: 0x00127F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94352, XrefRangeEnd = 94368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteractAsync_b__33_0(DLC4_DaySceneFishingPrePannel x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr__OnInteractAsync_b__33_0_Private_Void_DLC4_DaySceneFishingPrePannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00129DAC File Offset: 0x00127FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94368, XrefRangeEnd = 94387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteractAsync_b__33_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr__OnInteractAsync_b__33_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00129DE0 File Offset: 0x00127FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94387, XrefRangeEnd = 94397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteractAsync_b__33_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.NativeMethodInfoPtr__OnInteractAsync_b__33_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00018634 File Offset: 0x00016834
		public UniTask ShowDialogBoxes(Transform characterTransform, params FishingBehaviourCompoent.FishingResultState[] fishingResultStates)
		{
			return this.ShowDialogBoxes(characterTransform, new Il2CppStructArray<FishingBehaviourCompoent.FishingResultState>(fishingResultStates));
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00018643 File Offset: 0x00016843
		public FishingBehaviourCompoent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x00129E14 File Offset: 0x00128014
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0001864C File Offset: 0x0001684C
		public unsafe static Il2CppStructArray<Vector2> m_PlayerTargetPosition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerTargetPosition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerTargetPosition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x00129E3C File Offset: 0x0012803C
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x0001865E File Offset: 0x0001685E
		public unsafe static int AnimatorKey_Throw
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Throw, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Throw, (void*)(&value));
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x00129E58 File Offset: 0x00128058
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x0001866C File Offset: 0x0001686C
		public unsafe static int AnimatorKey_Bite
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Bite, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Bite, (void*)(&value));
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x00129E74 File Offset: 0x00128074
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0001867A File Offset: 0x0001687A
		public unsafe static int AnimatorKey_UnBite
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_UnBite, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_UnBite, (void*)(&value));
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x00129E90 File Offset: 0x00128090
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x00018688 File Offset: 0x00016888
		public unsafe static int AnimatorKey_Lift
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Lift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishingBehaviourCompoent.NativeFieldInfoPtr_AnimatorKey_Lift, (void*)(&value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x00129EAC File Offset: 0x001280AC
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x00018696 File Offset: 0x00016896
		public unsafe DLC4_DaySceneFishingPrePannel m_daySceneFishingPrePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_daySceneFishingPrePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingPrePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_daySceneFishingPrePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x00129EDC File Offset: 0x001280DC
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x000186B5 File Offset: 0x000168B5
		public unsafe DLC4_DaySceneFishingResultPanel m_daySceneFishingResultPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_daySceneFishingResultPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingResultPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_daySceneFishingResultPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x00129F0C File Offset: 0x0012810C
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x000186D4 File Offset: 0x000168D4
		public unsafe Animator m_FishingRodAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_FishingRodAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_FishingRodAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x00129F3C File Offset: 0x0012813C
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x000186F3 File Offset: 0x000168F3
		public unsafe Transform m_PlayerFishingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerFishingPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerFishingPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x00129F6C File Offset: 0x0012816C
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x00018712 File Offset: 0x00016912
		public unsafe Transform m_PlayerThrowPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerThrowPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerThrowPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x00129F9C File Offset: 0x0012819C
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x00018731 File Offset: 0x00016931
		public unsafe float m_PlayerThrowAnimationEndDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerThrowAnimationEndDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_PlayerThrowAnimationEndDelay)) = value;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x00129FC4 File Offset: 0x001281C4
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0001874C File Offset: 0x0001694C
		public unsafe float m_UnBiteDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_UnBiteDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_UnBiteDelay)) = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x00129FEC File Offset: 0x001281EC
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x00018767 File Offset: 0x00016967
		public unsafe float m_TreasureDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureDelay)) = value;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x0012A014 File Offset: 0x00128214
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x00018782 File Offset: 0x00016982
		public unsafe Vector2 m_TreasureBonusVFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureBonusVFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureBonusVFXOffset)) = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x0012A03C File Offset: 0x0012823C
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x0001879D File Offset: 0x0001699D
		public unsafe DialogBoxUI m_DialogBoxUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_DialogBoxUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_DialogBoxUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0012A06C File Offset: 0x0012826C
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x000187BC File Offset: 0x000169BC
		public unsafe float m_DialogBoxUIDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_DialogBoxUIDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_DialogBoxUIDuration)) = value;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x0012A094 File Offset: 0x00128294
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x000187D7 File Offset: 0x000169D7
		public unsafe SpriteRenderer m_ResultSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_ResultSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_ResultSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x0012A0C4 File Offset: 0x001282C4
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x000187F6 File Offset: 0x000169F6
		public unsafe SpriteRenderer m_TreasureSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0012A0F4 File Offset: 0x001282F4
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x00018815 File Offset: 0x00016A15
		public unsafe Sprite m_TreasureSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_TreasureSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x0012A124 File Offset: 0x00128324
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x00018834 File Offset: 0x00016A34
		public unsafe Sprite m_RubbishSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_RubbishSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_RubbishSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x0012A154 File Offset: 0x00128354
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x00018853 File Offset: 0x00016A53
		public unsafe GameObject m_BonusEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_BonusEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_BonusEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0012A184 File Offset: 0x00128384
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x00018872 File Offset: 0x00016A72
		public unsafe Transform m_VisualPointPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_VisualPointPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_VisualPointPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x0012A1B4 File Offset: 0x001283B4
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x00018891 File Offset: 0x00016A91
		public unsafe Vector2 m_VisualPointHelperOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_VisualPointHelperOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_VisualPointHelperOffset)) = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0012A1DC File Offset: 0x001283DC
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x000188AC File Offset: 0x00016AAC
		public unsafe AudioClip m_LiftFromWater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_LiftFromWater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_LiftFromWater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x0012A20C File Offset: 0x0012840C
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x000188CB File Offset: 0x00016ACB
		public unsafe AudioClip m_AfterLifting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_AfterLifting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_AfterLifting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x0012A23C File Offset: 0x0012843C
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x000188EA File Offset: 0x00016AEA
		public unsafe AudioClip m_BiteSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_BiteSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_BiteSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x0012A26C File Offset: 0x0012846C
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00018909 File Offset: 0x00016B09
		public unsafe Il2CppReferenceArray<FishingBehaviourCompoent.FishReward> m_fishRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_fishRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FishingBehaviourCompoent.FishReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_fishRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0012A29C File Offset: 0x0012849C
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x00018928 File Offset: 0x00016B28
		public unsafe Il2CppReferenceArray<FishingBehaviourCompoent.FishReward> m_fishRewardsTreasureMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_fishRewardsTreasureMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FishingBehaviourCompoent.FishReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_m_fishRewardsTreasureMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0012A2CC File Offset: 0x001284CC
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x00018947 File Offset: 0x00016B47
		public unsafe FishingBehaviourCompoent.FishingRotState currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerTargetPosition;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorKey_Throw;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorKey_Bite;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorKey_UnBite;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorKey_Lift;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr_m_daySceneFishingPrePannel;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_m_daySceneFishingResultPannel;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingRodAnimator;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerFishingPosition;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerThrowPosition;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerThrowAnimationEndDelay;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeFieldInfoPtr_m_UnBiteDelay;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureDelay;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureBonusVFXOffset;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_m_DialogBoxUI;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeFieldInfoPtr_m_DialogBoxUIDuration;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeFieldInfoPtr_m_ResultSpriteRenderer;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureSpriteRenderer;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureSprite;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeFieldInfoPtr_m_RubbishSprite;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeFieldInfoPtr_m_BonusEffect;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualPointPosition;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualPointHelperOffset;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr_m_LiftFromWater;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr_m_AfterLifting;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr_m_BiteSfx;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr_m_fishRewards;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_m_fishRewardsTreasureMode;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotAutoFacingWhenInteract_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_OnInteractAsync_Private_UniTaskVoid_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_ShowDialogBoxes_Private_UniTask_Transform_Il2CppStructArray_1_FishingResultState_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_CreateDialogBoxAsync_Private_UniTask_FishingResultState_Transform_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_SpawnBonusVFX_Private_UniTask_Boolean_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_CharacterStep_Private_UniTask_Transform_DayScenePlayerInputGenerator_Vector3_Vector3_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_SetRodAnimator_Private_Void_FishingRotState_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr__OnInteractAsync_b__33_0_Private_Void_DLC4_DaySceneFishingPrePannel_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr__OnInteractAsync_b__33_1_Private_Void_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr__OnInteractAsync_b__33_2_Private_Void_0;

		// Token: 0x020007A4 RID: 1956
		[Serializable]
		public sealed class FishReward : ValueType
		{
			// Token: 0x0600A443 RID: 42051 RVA: 0x002B0280 File Offset: 0x002AE480
			// Note: this type is marked as 'beforefieldinit'.
			static FishReward()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "FishReward");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr);
				FishingBehaviourCompoent.FishReward.NativeFieldInfoPtr_RewardProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr, "RewardProduct");
				FishingBehaviourCompoent.FishReward.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr, "Probability");
				FishingBehaviourCompoent.FishReward.NativeMethodInfoPtr__ctor_Public_Void_Product_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr, 100670606);
			}

			// Token: 0x0600A444 RID: 42052 RVA: 0x002B02E8 File Offset: 0x002AE4E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93833, XrefRangeEnd = 93834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FishReward(Product rewardProduct, float probability) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rewardProduct));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.FishReward.NativeMethodInfoPtr__ctor_Public_Void_Product_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A445 RID: 42053 RVA: 0x00058AB9 File Offset: 0x00056CB9
			public FishReward(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A446 RID: 42054 RVA: 0x00058AC2 File Offset: 0x00056CC2
			public FishReward() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent.FishReward>.NativeClassPtr))
			{
			}

			// Token: 0x17003620 RID: 13856
			// (get) Token: 0x0600A447 RID: 42055 RVA: 0x002B034C File Offset: 0x002AE54C
			// (set) Token: 0x0600A448 RID: 42056 RVA: 0x00058AD4 File Offset: 0x00056CD4
			public Product RewardProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.FishReward.NativeFieldInfoPtr_RewardProduct);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.FishReward.NativeFieldInfoPtr_RewardProduct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003621 RID: 13857
			// (get) Token: 0x0600A449 RID: 42057 RVA: 0x002B037C File Offset: 0x002AE57C
			// (set) Token: 0x0600A44A RID: 42058 RVA: 0x00058B02 File Offset: 0x00056D02
			public unsafe float Probability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.FishReward.NativeFieldInfoPtr_Probability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.FishReward.NativeFieldInfoPtr_Probability)) = value;
				}
			}

			// Token: 0x04006A4C RID: 27212
			private static readonly IntPtr NativeFieldInfoPtr_RewardProduct;

			// Token: 0x04006A4D RID: 27213
			private static readonly IntPtr NativeFieldInfoPtr_Probability;

			// Token: 0x04006A4E RID: 27214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Product_Single_0;
		}

		// Token: 0x020007A5 RID: 1957
		public enum FishingRotState
		{
			// Token: 0x04006A50 RID: 27216
			ThrowAndWait,
			// Token: 0x04006A51 RID: 27217
			Bite,
			// Token: 0x04006A52 RID: 27218
			UnBite,
			// Token: 0x04006A53 RID: 27219
			LiftToIdle,
			// Token: 0x04006A54 RID: 27220
			None
		}

		// Token: 0x020007A6 RID: 1958
		public enum FishingResultState
		{
			// Token: 0x04006A56 RID: 27222
			Fish,
			// Token: 0x04006A57 RID: 27223
			Trash,
			// Token: 0x04006A58 RID: 27224
			Treasure,
			// Token: 0x04006A59 RID: 27225
			None
		}

		// Token: 0x020007A7 RID: 1959
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A44B RID: 42059 RVA: 0x002B03A4 File Offset: 0x002AE5A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass33_0>.NativeClassPtr);
				FishingBehaviourCompoent.__c__DisplayClass33_0.NativeFieldInfoPtr_trophy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass33_0>.NativeClassPtr, "trophy");
				FishingBehaviourCompoent.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass33_0>.NativeClassPtr, 100670607);
				FishingBehaviourCompoent.__c__DisplayClass33_0.NativeMethodInfoPtr__OnInteractAsync_b__3_Internal_Void_DLC4_DaySceneFishingResultPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass33_0>.NativeClassPtr, 100670608);
			}

			// Token: 0x0600A44C RID: 42060 RVA: 0x002B040C File Offset: 0x002AE60C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A44D RID: 42061 RVA: 0x002B0448 File Offset: 0x002AE648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93834, XrefRangeEnd = 93837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteractAsync_b__3(DLC4_DaySceneFishingResultPanel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.__c__DisplayClass33_0.NativeMethodInfoPtr__OnInteractAsync_b__3_Internal_Void_DLC4_DaySceneFishingResultPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A44E RID: 42062 RVA: 0x00058B1D File Offset: 0x00056D1D
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003622 RID: 13858
			// (get) Token: 0x0600A44F RID: 42063 RVA: 0x002B048C File Offset: 0x002AE68C
			// (set) Token: 0x0600A450 RID: 42064 RVA: 0x00058B26 File Offset: 0x00056D26
			public unsafe Item trophy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass33_0.NativeFieldInfoPtr_trophy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Item>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass33_0.NativeFieldInfoPtr_trophy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A5A RID: 27226
			private static readonly IntPtr NativeFieldInfoPtr_trophy;

			// Token: 0x04006A5B RID: 27227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A5C RID: 27228
			private static readonly IntPtr NativeMethodInfoPtr__OnInteractAsync_b__3_Internal_Void_DLC4_DaySceneFishingResultPanel_0;
		}

		// Token: 0x020007A8 RID: 1960
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<OnInteractAsync>d__33")]
		public sealed class _OnInteractAsync_d__33 : ValueType
		{
			// Token: 0x0600A451 RID: 42065 RVA: 0x002B04BC File Offset: 0x002AE6BC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnInteractAsync_d__33()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<OnInteractAsync>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr);
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<>1__state");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<>t__builder");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<>4__this");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__character_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<character>5__2");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterTransform_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<characterTransform>5__3");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterStartPosition_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<characterStartPosition>5__4");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterTargetPosition_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<characterTargetPosition>5__5");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__resultContext_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<resultContext>5__6");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__fishingResultStateNorm_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<fishingResultStateNorm>5__7");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__getTreasure_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<getTreasure>5__8");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<>u__1");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<>u__2");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, "<>u__3");
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, 100670609);
				FishingBehaviourCompoent._OnInteractAsync_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr, 100670610);
			}

			// Token: 0x0600A452 RID: 42066 RVA: 0x002B0614 File Offset: 0x002AE814
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94113, RefRangeEnd = 94115, XrefRangeStart = 93837, XrefRangeEnd = 94113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A453 RID: 42067 RVA: 0x002B064C File Offset: 0x002AE84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A454 RID: 42068 RVA: 0x00058B45 File Offset: 0x00056D45
			public _OnInteractAsync_d__33(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A455 RID: 42069 RVA: 0x00058B4E File Offset: 0x00056D4E
			public _OnInteractAsync_d__33() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent._OnInteractAsync_d__33>.NativeClassPtr))
			{
			}

			// Token: 0x17003623 RID: 13859
			// (get) Token: 0x0600A456 RID: 42070 RVA: 0x002B0694 File Offset: 0x002AE894
			// (set) Token: 0x0600A457 RID: 42071 RVA: 0x00058B60 File Offset: 0x00056D60
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003624 RID: 13860
			// (get) Token: 0x0600A458 RID: 42072 RVA: 0x002B06BC File Offset: 0x002AE8BC
			// (set) Token: 0x0600A459 RID: 42073 RVA: 0x00058B7B File Offset: 0x00056D7B
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003625 RID: 13861
			// (get) Token: 0x0600A45A RID: 42074 RVA: 0x002B06EC File Offset: 0x002AE8EC
			// (set) Token: 0x0600A45B RID: 42075 RVA: 0x00058BA9 File Offset: 0x00056DA9
			public unsafe FishingBehaviourCompoent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishingBehaviourCompoent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003626 RID: 13862
			// (get) Token: 0x0600A45C RID: 42076 RVA: 0x002B071C File Offset: 0x002AE91C
			// (set) Token: 0x0600A45D RID: 42077 RVA: 0x00058BC8 File Offset: 0x00056DC8
			public unsafe DayScenePlayerInputGenerator _character_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__character_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__character_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003627 RID: 13863
			// (get) Token: 0x0600A45E RID: 42078 RVA: 0x002B074C File Offset: 0x002AE94C
			// (set) Token: 0x0600A45F RID: 42079 RVA: 0x00058BE7 File Offset: 0x00056DE7
			public unsafe Transform _characterTransform_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterTransform_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterTransform_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003628 RID: 13864
			// (get) Token: 0x0600A460 RID: 42080 RVA: 0x002B077C File Offset: 0x002AE97C
			// (set) Token: 0x0600A461 RID: 42081 RVA: 0x00058C06 File Offset: 0x00056E06
			public unsafe Vector3 _characterStartPosition_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterStartPosition_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterStartPosition_5__4)) = value;
				}
			}

			// Token: 0x17003629 RID: 13865
			// (get) Token: 0x0600A462 RID: 42082 RVA: 0x002B07A4 File Offset: 0x002AE9A4
			// (set) Token: 0x0600A463 RID: 42083 RVA: 0x00058C21 File Offset: 0x00056E21
			public unsafe Vector3 _characterTargetPosition_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterTargetPosition_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__characterTargetPosition_5__5)) = value;
				}
			}

			// Token: 0x1700362A RID: 13866
			// (get) Token: 0x0600A464 RID: 42084 RVA: 0x002B07CC File Offset: 0x002AE9CC
			// (set) Token: 0x0600A465 RID: 42085 RVA: 0x00058C3C File Offset: 0x00056E3C
			public DLC4_DaySceneFishingPrePannel.ResultContext _resultContext_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__resultContext_5__6);
					return new DLC4_DaySceneFishingPrePannel.ResultContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__resultContext_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_DaySceneFishingPrePannel.ResultContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700362B RID: 13867
			// (get) Token: 0x0600A466 RID: 42086 RVA: 0x002B07FC File Offset: 0x002AE9FC
			// (set) Token: 0x0600A467 RID: 42087 RVA: 0x00058C6A File Offset: 0x00056E6A
			public unsafe FishingBehaviourCompoent.FishingResultState _fishingResultStateNorm_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__fishingResultStateNorm_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__fishingResultStateNorm_5__7)) = value;
				}
			}

			// Token: 0x1700362C RID: 13868
			// (get) Token: 0x0600A468 RID: 42088 RVA: 0x002B0824 File Offset: 0x002AEA24
			// (set) Token: 0x0600A469 RID: 42089 RVA: 0x00058C85 File Offset: 0x00056E85
			public unsafe bool _getTreasure_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__getTreasure_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr__getTreasure_5__8)) = value;
				}
			}

			// Token: 0x1700362D RID: 13869
			// (get) Token: 0x0600A46A RID: 42090 RVA: 0x002B084C File Offset: 0x002AEA4C
			// (set) Token: 0x0600A46B RID: 42091 RVA: 0x00058CA0 File Offset: 0x00056EA0
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700362E RID: 13870
			// (get) Token: 0x0600A46C RID: 42092 RVA: 0x002B087C File Offset: 0x002AEA7C
			// (set) Token: 0x0600A46D RID: 42093 RVA: 0x00058CCE File Offset: 0x00056ECE
			public UniTask<DLC4_DaySceneFishingPrePannel.ResultContext>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__2);
					return new UniTask<DLC4_DaySceneFishingPrePannel.ResultContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC4_DaySceneFishingPrePannel.ResultContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC4_DaySceneFishingPrePannel.ResultContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700362F RID: 13871
			// (get) Token: 0x0600A46E RID: 42094 RVA: 0x002B08AC File Offset: 0x002AEAAC
			// (set) Token: 0x0600A46F RID: 42095 RVA: 0x00058CFC File Offset: 0x00056EFC
			public UniTask<DLC4_DaySceneFishingResultPanel>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__3);
					return new UniTask<DLC4_DaySceneFishingResultPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC4_DaySceneFishingResultPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._OnInteractAsync_d__33.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC4_DaySceneFishingResultPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006A5D RID: 27229
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A5E RID: 27230
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006A5F RID: 27231
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A60 RID: 27232
			private static readonly IntPtr NativeFieldInfoPtr__character_5__2;

			// Token: 0x04006A61 RID: 27233
			private static readonly IntPtr NativeFieldInfoPtr__characterTransform_5__3;

			// Token: 0x04006A62 RID: 27234
			private static readonly IntPtr NativeFieldInfoPtr__characterStartPosition_5__4;

			// Token: 0x04006A63 RID: 27235
			private static readonly IntPtr NativeFieldInfoPtr__characterTargetPosition_5__5;

			// Token: 0x04006A64 RID: 27236
			private static readonly IntPtr NativeFieldInfoPtr__resultContext_5__6;

			// Token: 0x04006A65 RID: 27237
			private static readonly IntPtr NativeFieldInfoPtr__fishingResultStateNorm_5__7;

			// Token: 0x04006A66 RID: 27238
			private static readonly IntPtr NativeFieldInfoPtr__getTreasure_5__8;

			// Token: 0x04006A67 RID: 27239
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006A68 RID: 27240
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04006A69 RID: 27241
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04006A6A RID: 27242
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A6B RID: 27243
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020007A9 RID: 1961
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<ShowDialogBoxes>d__34")]
		public sealed class _ShowDialogBoxes_d__34 : ValueType
		{
			// Token: 0x0600A470 RID: 42096 RVA: 0x002B08DC File Offset: 0x002AEADC
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowDialogBoxes_d__34()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<ShowDialogBoxes>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr);
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "<>1__state");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "<>t__builder");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr_fishingResultStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "fishingResultStates");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "<>4__this");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr_characterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "characterTransform");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "<>7__wrap1");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "<>7__wrap2");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, "<>u__1");
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, 100670611);
				FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr, 100670612);
			}

			// Token: 0x0600A471 RID: 42097 RVA: 0x002B09D0 File Offset: 0x002AEBD0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 94133, RefRangeEnd = 94136, XrefRangeStart = 94115, XrefRangeEnd = 94133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A472 RID: 42098 RVA: 0x002B0A08 File Offset: 0x002AEC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A473 RID: 42099 RVA: 0x00058D2A File Offset: 0x00056F2A
			public _ShowDialogBoxes_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A474 RID: 42100 RVA: 0x00058D33 File Offset: 0x00056F33
			public _ShowDialogBoxes_d__34() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent._ShowDialogBoxes_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17003630 RID: 13872
			// (get) Token: 0x0600A475 RID: 42101 RVA: 0x002B0A50 File Offset: 0x002AEC50
			// (set) Token: 0x0600A476 RID: 42102 RVA: 0x00058D45 File Offset: 0x00056F45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003631 RID: 13873
			// (get) Token: 0x0600A477 RID: 42103 RVA: 0x002B0A78 File Offset: 0x002AEC78
			// (set) Token: 0x0600A478 RID: 42104 RVA: 0x00058D60 File Offset: 0x00056F60
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003632 RID: 13874
			// (get) Token: 0x0600A479 RID: 42105 RVA: 0x002B0AA8 File Offset: 0x002AECA8
			// (set) Token: 0x0600A47A RID: 42106 RVA: 0x00058D8E File Offset: 0x00056F8E
			public unsafe Il2CppStructArray<FishingBehaviourCompoent.FishingResultState> fishingResultStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr_fishingResultStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FishingBehaviourCompoent.FishingResultState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr_fishingResultStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003633 RID: 13875
			// (get) Token: 0x0600A47B RID: 42107 RVA: 0x002B0AD8 File Offset: 0x002AECD8
			// (set) Token: 0x0600A47C RID: 42108 RVA: 0x00058DAD File Offset: 0x00056FAD
			public unsafe FishingBehaviourCompoent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishingBehaviourCompoent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003634 RID: 13876
			// (get) Token: 0x0600A47D RID: 42109 RVA: 0x002B0B08 File Offset: 0x002AED08
			// (set) Token: 0x0600A47E RID: 42110 RVA: 0x00058DCC File Offset: 0x00056FCC
			public unsafe Transform characterTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr_characterTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr_characterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003635 RID: 13877
			// (get) Token: 0x0600A47F RID: 42111 RVA: 0x002B0B38 File Offset: 0x002AED38
			// (set) Token: 0x0600A480 RID: 42112 RVA: 0x00058DEB File Offset: 0x00056FEB
			public unsafe Il2CppStructArray<FishingBehaviourCompoent.FishingResultState> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FishingBehaviourCompoent.FishingResultState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003636 RID: 13878
			// (get) Token: 0x0600A481 RID: 42113 RVA: 0x002B0B68 File Offset: 0x002AED68
			// (set) Token: 0x0600A482 RID: 42114 RVA: 0x00058E0A File Offset: 0x0005700A
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17003637 RID: 13879
			// (get) Token: 0x0600A483 RID: 42115 RVA: 0x002B0B90 File Offset: 0x002AED90
			// (set) Token: 0x0600A484 RID: 42116 RVA: 0x00058E25 File Offset: 0x00057025
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._ShowDialogBoxes_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006A6C RID: 27244
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A6D RID: 27245
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006A6E RID: 27246
			private static readonly IntPtr NativeFieldInfoPtr_fishingResultStates;

			// Token: 0x04006A6F RID: 27247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A70 RID: 27248
			private static readonly IntPtr NativeFieldInfoPtr_characterTransform;

			// Token: 0x04006A71 RID: 27249
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04006A72 RID: 27250
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006A73 RID: 27251
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006A74 RID: 27252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A75 RID: 27253
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020007AA RID: 1962
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<CreateDialogBoxAsync>d__35")]
		public sealed class _CreateDialogBoxAsync_d__35 : ValueType
		{
			// Token: 0x0600A485 RID: 42117 RVA: 0x002B0BC0 File Offset: 0x002AEDC0
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateDialogBoxAsync_d__35()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<CreateDialogBoxAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr);
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "<>1__state");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "<>t__builder");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr_fishingResultState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "fishingResultState");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "<>4__this");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr_characterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "characterTransform");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr__dialogUIInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "<dialogUIInstance>5__2");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, "<>u__1");
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, 100670613);
				FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr, 100670614);
			}

			// Token: 0x0600A486 RID: 42118 RVA: 0x002B0CA0 File Offset: 0x002AEEA0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 94152, RefRangeEnd = 94155, XrefRangeStart = 94136, XrefRangeEnd = 94152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A487 RID: 42119 RVA: 0x002B0CD8 File Offset: 0x002AEED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A488 RID: 42120 RVA: 0x00058E53 File Offset: 0x00057053
			public _CreateDialogBoxAsync_d__35(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A489 RID: 42121 RVA: 0x00058E5C File Offset: 0x0005705C
			public _CreateDialogBoxAsync_d__35() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent._CreateDialogBoxAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x17003638 RID: 13880
			// (get) Token: 0x0600A48A RID: 42122 RVA: 0x002B0D20 File Offset: 0x002AEF20
			// (set) Token: 0x0600A48B RID: 42123 RVA: 0x00058E6E File Offset: 0x0005706E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003639 RID: 13881
			// (get) Token: 0x0600A48C RID: 42124 RVA: 0x002B0D48 File Offset: 0x002AEF48
			// (set) Token: 0x0600A48D RID: 42125 RVA: 0x00058E89 File Offset: 0x00057089
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700363A RID: 13882
			// (get) Token: 0x0600A48E RID: 42126 RVA: 0x002B0D78 File Offset: 0x002AEF78
			// (set) Token: 0x0600A48F RID: 42127 RVA: 0x00058EB7 File Offset: 0x000570B7
			public unsafe FishingBehaviourCompoent.FishingResultState fishingResultState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr_fishingResultState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr_fishingResultState)) = value;
				}
			}

			// Token: 0x1700363B RID: 13883
			// (get) Token: 0x0600A490 RID: 42128 RVA: 0x002B0DA0 File Offset: 0x002AEFA0
			// (set) Token: 0x0600A491 RID: 42129 RVA: 0x00058ED2 File Offset: 0x000570D2
			public unsafe FishingBehaviourCompoent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishingBehaviourCompoent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700363C RID: 13884
			// (get) Token: 0x0600A492 RID: 42130 RVA: 0x002B0DD0 File Offset: 0x002AEFD0
			// (set) Token: 0x0600A493 RID: 42131 RVA: 0x00058EF1 File Offset: 0x000570F1
			public unsafe Transform characterTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr_characterTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr_characterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700363D RID: 13885
			// (get) Token: 0x0600A494 RID: 42132 RVA: 0x002B0E00 File Offset: 0x002AF000
			// (set) Token: 0x0600A495 RID: 42133 RVA: 0x00058F10 File Offset: 0x00057110
			public unsafe DialogBoxUI _dialogUIInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr__dialogUIInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr__dialogUIInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700363E RID: 13886
			// (get) Token: 0x0600A496 RID: 42134 RVA: 0x002B0E30 File Offset: 0x002AF030
			// (set) Token: 0x0600A497 RID: 42135 RVA: 0x00058F2F File Offset: 0x0005712F
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CreateDialogBoxAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006A76 RID: 27254
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A77 RID: 27255
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006A78 RID: 27256
			private static readonly IntPtr NativeFieldInfoPtr_fishingResultState;

			// Token: 0x04006A79 RID: 27257
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A7A RID: 27258
			private static readonly IntPtr NativeFieldInfoPtr_characterTransform;

			// Token: 0x04006A7B RID: 27259
			private static readonly IntPtr NativeFieldInfoPtr__dialogUIInstance_5__2;

			// Token: 0x04006A7C RID: 27260
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006A7D RID: 27261
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A7E RID: 27262
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020007AB RID: 1963
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<SpawnBonusVFX>d__36")]
		public sealed class _SpawnBonusVFX_d__36 : ValueType
		{
			// Token: 0x0600A498 RID: 42136 RVA: 0x002B0E60 File Offset: 0x002AF060
			// Note: this type is marked as 'beforefieldinit'.
			static _SpawnBonusVFX_d__36()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<SpawnBonusVFX>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr);
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, "<>1__state");
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, "<>t__builder");
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr_shouldSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, "shouldSpawn");
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, "<>4__this");
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, "<>u__1");
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, 100670615);
				FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr, 100670616);
			}

			// Token: 0x0600A499 RID: 42137 RVA: 0x002B0F18 File Offset: 0x002AF118
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94174, RefRangeEnd = 94178, XrefRangeStart = 94155, XrefRangeEnd = 94174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A49A RID: 42138 RVA: 0x002B0F50 File Offset: 0x002AF150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A49B RID: 42139 RVA: 0x00058F5D File Offset: 0x0005715D
			public _SpawnBonusVFX_d__36(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A49C RID: 42140 RVA: 0x00058F66 File Offset: 0x00057166
			public _SpawnBonusVFX_d__36() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent._SpawnBonusVFX_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x1700363F RID: 13887
			// (get) Token: 0x0600A49D RID: 42141 RVA: 0x002B0F98 File Offset: 0x002AF198
			// (set) Token: 0x0600A49E RID: 42142 RVA: 0x00058F78 File Offset: 0x00057178
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003640 RID: 13888
			// (get) Token: 0x0600A49F RID: 42143 RVA: 0x002B0FC0 File Offset: 0x002AF1C0
			// (set) Token: 0x0600A4A0 RID: 42144 RVA: 0x00058F93 File Offset: 0x00057193
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003641 RID: 13889
			// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x002B0FF0 File Offset: 0x002AF1F0
			// (set) Token: 0x0600A4A2 RID: 42146 RVA: 0x00058FC1 File Offset: 0x000571C1
			public unsafe bool shouldSpawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr_shouldSpawn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr_shouldSpawn)) = value;
				}
			}

			// Token: 0x17003642 RID: 13890
			// (get) Token: 0x0600A4A3 RID: 42147 RVA: 0x002B1018 File Offset: 0x002AF218
			// (set) Token: 0x0600A4A4 RID: 42148 RVA: 0x00058FDC File Offset: 0x000571DC
			public unsafe FishingBehaviourCompoent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishingBehaviourCompoent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003643 RID: 13891
			// (get) Token: 0x0600A4A5 RID: 42149 RVA: 0x002B1048 File Offset: 0x002AF248
			// (set) Token: 0x0600A4A6 RID: 42150 RVA: 0x00058FFB File Offset: 0x000571FB
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._SpawnBonusVFX_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006A7F RID: 27263
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A80 RID: 27264
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006A81 RID: 27265
			private static readonly IntPtr NativeFieldInfoPtr_shouldSpawn;

			// Token: 0x04006A82 RID: 27266
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A83 RID: 27267
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006A84 RID: 27268
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A85 RID: 27269
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020007AC RID: 1964
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A4A7 RID: 42151 RVA: 0x002B1078 File Offset: 0x002AF278
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr);
				FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr, "characterTransform");
				FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr, "characterStartPosition");
				FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr, "characterTargetPosition");
				FishingBehaviourCompoent.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr, 100670617);
				FishingBehaviourCompoent.__c__DisplayClass37_0.NativeMethodInfoPtr__CharacterStep_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr, 100670618);
				FishingBehaviourCompoent.__c__DisplayClass37_0.NativeMethodInfoPtr__CharacterStep_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr, 100670619);
			}

			// Token: 0x0600A4A8 RID: 42152 RVA: 0x002B111C File Offset: 0x002AF31C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4A9 RID: 42153 RVA: 0x002B1158 File Offset: 0x002AF358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94178, XrefRangeEnd = 94180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CharacterStep_b__0(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeMethodInfoPtr__CharacterStep_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4AA RID: 42154 RVA: 0x002B1198 File Offset: 0x002AF398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94180, XrefRangeEnd = 94182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CharacterStep_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeMethodInfoPtr__CharacterStep_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4AB RID: 42155 RVA: 0x00059029 File Offset: 0x00057229
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003644 RID: 13892
			// (get) Token: 0x0600A4AC RID: 42156 RVA: 0x002B11D8 File Offset: 0x002AF3D8
			// (set) Token: 0x0600A4AD RID: 42157 RVA: 0x00059032 File Offset: 0x00057232
			public unsafe Transform characterTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003645 RID: 13893
			// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x002B1208 File Offset: 0x002AF408
			// (set) Token: 0x0600A4AF RID: 42159 RVA: 0x00059051 File Offset: 0x00057251
			public unsafe Vector3 characterStartPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterStartPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterStartPosition)) = value;
				}
			}

			// Token: 0x17003646 RID: 13894
			// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x002B1230 File Offset: 0x002AF430
			// (set) Token: 0x0600A4B1 RID: 42161 RVA: 0x0005906C File Offset: 0x0005726C
			public unsafe Vector3 characterTargetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterTargetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent.__c__DisplayClass37_0.NativeFieldInfoPtr_characterTargetPosition)) = value;
				}
			}

			// Token: 0x04006A86 RID: 27270
			private static readonly IntPtr NativeFieldInfoPtr_characterTransform;

			// Token: 0x04006A87 RID: 27271
			private static readonly IntPtr NativeFieldInfoPtr_characterStartPosition;

			// Token: 0x04006A88 RID: 27272
			private static readonly IntPtr NativeFieldInfoPtr_characterTargetPosition;

			// Token: 0x04006A89 RID: 27273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A8A RID: 27274
			private static readonly IntPtr NativeMethodInfoPtr__CharacterStep_b__0_Internal_Void_Single_0;

			// Token: 0x04006A8B RID: 27275
			private static readonly IntPtr NativeMethodInfoPtr__CharacterStep_b__1_Internal_Void_Single_0;
		}

		// Token: 0x020007AD RID: 1965
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.FishingBehaviourCompoent+<CharacterStep>d__37")]
		public sealed class _CharacterStep_d__37 : ValueType
		{
			// Token: 0x0600A4B2 RID: 42162 RVA: 0x002B1258 File Offset: 0x002AF458
			// Note: this type is marked as 'beforefieldinit'.
			static _CharacterStep_d__37()
			{
				Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishingBehaviourCompoent>.NativeClassPtr, "<CharacterStep>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr);
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "<>1__state");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "<>t__builder");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "characterTransform");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "characterStartPosition");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "characterTargetPosition");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "<>4__this");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "character");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "<>8__1");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, "<>u__1");
				FishingBehaviourCompoent._CharacterStep_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, 100670620);
				FishingBehaviourCompoent._CharacterStep_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr, 100670621);
			}

			// Token: 0x0600A4B3 RID: 42163 RVA: 0x002B1360 File Offset: 0x002AF560
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 94249, RefRangeEnd = 94252, XrefRangeStart = 94182, XrefRangeEnd = 94249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._CharacterStep_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4B4 RID: 42164 RVA: 0x002B1398 File Offset: 0x002AF598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingBehaviourCompoent._CharacterStep_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4B5 RID: 42165 RVA: 0x00059087 File Offset: 0x00057287
			public _CharacterStep_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A4B6 RID: 42166 RVA: 0x00059090 File Offset: 0x00057290
			public _CharacterStep_d__37() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingBehaviourCompoent._CharacterStep_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x17003647 RID: 13895
			// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x002B13E0 File Offset: 0x002AF5E0
			// (set) Token: 0x0600A4B8 RID: 42168 RVA: 0x000590A2 File Offset: 0x000572A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003648 RID: 13896
			// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x002B1408 File Offset: 0x002AF608
			// (set) Token: 0x0600A4BA RID: 42170 RVA: 0x000590BD File Offset: 0x000572BD
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003649 RID: 13897
			// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x002B1438 File Offset: 0x002AF638
			// (set) Token: 0x0600A4BC RID: 42172 RVA: 0x000590EB File Offset: 0x000572EB
			public unsafe Transform characterTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700364A RID: 13898
			// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x002B1468 File Offset: 0x002AF668
			// (set) Token: 0x0600A4BE RID: 42174 RVA: 0x0005910A File Offset: 0x0005730A
			public unsafe Vector3 characterStartPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterStartPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterStartPosition)) = value;
				}
			}

			// Token: 0x1700364B RID: 13899
			// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x002B1490 File Offset: 0x002AF690
			// (set) Token: 0x0600A4C0 RID: 42176 RVA: 0x00059125 File Offset: 0x00057325
			public unsafe Vector3 characterTargetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterTargetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_characterTargetPosition)) = value;
				}
			}

			// Token: 0x1700364C RID: 13900
			// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x002B14B8 File Offset: 0x002AF6B8
			// (set) Token: 0x0600A4C2 RID: 42178 RVA: 0x00059140 File Offset: 0x00057340
			public unsafe FishingBehaviourCompoent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishingBehaviourCompoent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700364D RID: 13901
			// (get) Token: 0x0600A4C3 RID: 42179 RVA: 0x002B14E8 File Offset: 0x002AF6E8
			// (set) Token: 0x0600A4C4 RID: 42180 RVA: 0x0005915F File Offset: 0x0005735F
			public unsafe DayScenePlayerInputGenerator character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700364E RID: 13902
			// (get) Token: 0x0600A4C5 RID: 42181 RVA: 0x002B1518 File Offset: 0x002AF718
			// (set) Token: 0x0600A4C6 RID: 42182 RVA: 0x0005917E File Offset: 0x0005737E
			public unsafe FishingBehaviourCompoent.__c__DisplayClass37_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishingBehaviourCompoent.__c__DisplayClass37_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700364F RID: 13903
			// (get) Token: 0x0600A4C7 RID: 42183 RVA: 0x002B1548 File Offset: 0x002AF748
			// (set) Token: 0x0600A4C8 RID: 42184 RVA: 0x0005919D File Offset: 0x0005739D
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingBehaviourCompoent._CharacterStep_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006A8C RID: 27276
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A8D RID: 27277
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006A8E RID: 27278
			private static readonly IntPtr NativeFieldInfoPtr_characterTransform;

			// Token: 0x04006A8F RID: 27279
			private static readonly IntPtr NativeFieldInfoPtr_characterStartPosition;

			// Token: 0x04006A90 RID: 27280
			private static readonly IntPtr NativeFieldInfoPtr_characterTargetPosition;

			// Token: 0x04006A91 RID: 27281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A92 RID: 27282
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04006A93 RID: 27283
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006A94 RID: 27284
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006A95 RID: 27285
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A96 RID: 27286
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
