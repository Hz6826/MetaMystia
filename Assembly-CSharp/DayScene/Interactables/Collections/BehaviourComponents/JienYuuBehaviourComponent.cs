using System;
using Common.CharacterUtility;
using DayScene.Input;
using DayScene.Interactables.Collections.ConditionComponents;
using DayScene.UI;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000177 RID: 375
	public class JienYuuBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002927 RID: 10535 RVA: 0x0012757C File Offset: 0x0012577C
		// Note: this type is marked as 'beforefieldinit'.
		static JienYuuBehaviourComponent()
		{
			Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "JienYuuBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr);
			JienYuuBehaviourComponent.NativeFieldInfoPtr_INTERACTABLE_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "INTERACTABLE_KEY");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_RELIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_RELIVE");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_MUSIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_MUSIC");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_COOKING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_COOKING");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTTARGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "OPTION_SELECTTARGET");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_CharacterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_CharacterVisual");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_TipIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_TipIcon");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_FaceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_FaceDirection");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_FirstDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_FirstDialog");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_ReliveTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_ReliveTimeline");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_ConfirmDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_ConfirmDialog");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_repeatChallengeEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "repeatChallengeEventId");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchCharacterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchCharacterVisual");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchFirstDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchFirstDialog");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchNormalDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchNormalDialog");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchAcceptDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchAcceptDialog");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchRefuseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchRefuseDialog");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchReliveTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchReliveTimeline");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_CharacterControllerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_CharacterControllerUnit");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchConditionComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "m_SwitchConditionComponent");
			JienYuuBehaviourComponent.NativeFieldInfoPtr_IsSwitchPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "IsSwitchPlatform");
			JienYuuBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670486);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_OnEnterMap_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670487);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670488);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_ReliveHakureiFestival_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670489);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_MusicRepeatChallenge_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670490);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_CookingRepeatChallenge_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670491);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_SetTargetCompetition_Private_Void_Action_BaseInteractData_ChallengeType_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670492);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_GetTitle_Private_String_BaseInteractData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670493);
			JienYuuBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670494);
			JienYuuBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670495);
			JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670496);
			JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_1_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670497);
			JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670498);
			JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, 100670499);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00127868 File Offset: 0x00125A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93132, XrefRangeEnd = 93148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JienYuuBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x001278A4 File Offset: 0x00125AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93148, XrefRangeEnd = 93156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnterMap(string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JienYuuBehaviourComponent.NativeMethodInfoPtr_OnEnterMap_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x001278F4 File Offset: 0x00125AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93156, XrefRangeEnd = 93184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JienYuuBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00127930 File Offset: 0x00125B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93184, XrefRangeEnd = 93201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReliveHakureiFestival(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr_ReliveHakureiFestival_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x001279C0 File Offset: 0x00125BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93201, XrefRangeEnd = 93218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MusicRepeatChallenge(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr_MusicRepeatChallenge_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00127A50 File Offset: 0x00125C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93218, XrefRangeEnd = 93235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CookingRepeatChallenge(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr_CookingRepeatChallenge_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x00127AE0 File Offset: 0x00125CE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 93269, RefRangeEnd = 93275, XrefRangeStart = 93235, XrefRangeEnd = 93269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetCompetition(Action closeFirstPanelCallback, DaySceneChatSelectionPannel.BaseInteractData baseInteractData, NightSceneDirector.ChallengeType challengeMode, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(closeFirstPanelCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref challengeMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr_SetTargetCompetition_Private_Void_Action_BaseInteractData_ChallengeType_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00127B90 File Offset: 0x00125D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93281, RefRangeEnd = 93282, XrefRangeStart = 93275, XrefRangeEnd = 93281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitle(DaySceneChatSelectionPannel.BaseInteractData data, string replaceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replaceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr_GetTitle_Private_String_BaseInteractData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00127BEC File Offset: 0x00125DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93282, XrefRangeEnd = 93297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JienYuuBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00127C28 File Offset: 0x00125E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JienYuuBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00127C64 File Offset: 0x00125E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93297, XrefRangeEnd = 93340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__23_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00127C98 File Offset: 0x00125E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93340, XrefRangeEnd = 93350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__23_1(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_1_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00127CDC File Offset: 0x00125EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93350, XrefRangeEnd = 93352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__23_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00127D10 File Offset: 0x00125F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__23_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__23_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00018134 File Offset: 0x00016334
		public JienYuuBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x00127D44 File Offset: 0x00125F44
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x0001813D File Offset: 0x0001633D
		public unsafe static string INTERACTABLE_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_INTERACTABLE_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_INTERACTABLE_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x00127D64 File Offset: 0x00125F64
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x0001814F File Offset: 0x0001634F
		public unsafe static string OPTION_SELECTDIFFICULTY_RELIVE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_RELIVE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_RELIVE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x00127D84 File Offset: 0x00125F84
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x00018161 File Offset: 0x00016361
		public unsafe static string OPTION_SELECTDIFFICULTY_MUSIC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_MUSIC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_MUSIC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x00127DA4 File Offset: 0x00125FA4
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x00018173 File Offset: 0x00016373
		public unsafe static string OPTION_SELECTDIFFICULTY_COOKING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_COOKING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_COOKING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x00127DC4 File Offset: 0x00125FC4
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x00018185 File Offset: 0x00016385
		public unsafe static string OPTION_SELECTTARGET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTTARGET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.NativeFieldInfoPtr_OPTION_SELECTTARGET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00127DE4 File Offset: 0x00125FE4
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x00018197 File Offset: 0x00016397
		public unsafe CharacterSpriteSetCompact m_CharacterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_CharacterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_CharacterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x00127E14 File Offset: 0x00126014
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x000181B6 File Offset: 0x000163B6
		public unsafe GameObject m_TipIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_TipIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_TipIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x00127E44 File Offset: 0x00126044
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x000181D5 File Offset: 0x000163D5
		public unsafe DayScenePlayerInputGenerator.CharacterRotation m_FaceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_FaceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_FaceDirection)) = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x00127E6C File Offset: 0x0012606C
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x000181F0 File Offset: 0x000163F0
		public unsafe DialogPackage m_FirstDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_FirstDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_FirstDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x00127E9C File Offset: 0x0012609C
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x0001820F File Offset: 0x0001640F
		public unsafe PlayableAsset m_ReliveTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_ReliveTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_ReliveTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x00127ECC File Offset: 0x001260CC
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x0001822E File Offset: 0x0001642E
		public unsafe DialogPackage m_ConfirmDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_ConfirmDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_ConfirmDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x00127EFC File Offset: 0x001260FC
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x0001824D File Offset: 0x0001644D
		public unsafe string repeatChallengeEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_repeatChallengeEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_repeatChallengeEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x00127F24 File Offset: 0x00126124
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x0001826C File Offset: 0x0001646C
		public unsafe CharacterSpriteSetCompact m_SwitchCharacterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchCharacterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchCharacterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x00127F54 File Offset: 0x00126154
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x0001828B File Offset: 0x0001648B
		public unsafe DialogPackage m_SwitchFirstDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchFirstDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchFirstDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x00127F84 File Offset: 0x00126184
		// (set) Token: 0x06002954 RID: 10580 RVA: 0x000182AA File Offset: 0x000164AA
		public unsafe DialogPackage m_SwitchNormalDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchNormalDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchNormalDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x00127FB4 File Offset: 0x001261B4
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x000182C9 File Offset: 0x000164C9
		public unsafe DialogPackage m_SwitchAcceptDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchAcceptDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchAcceptDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x00127FE4 File Offset: 0x001261E4
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x000182E8 File Offset: 0x000164E8
		public unsafe DialogPackage m_SwitchRefuseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchRefuseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchRefuseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x00128014 File Offset: 0x00126214
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x00018307 File Offset: 0x00016507
		public unsafe PlayableAsset m_SwitchReliveTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchReliveTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchReliveTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x00128044 File Offset: 0x00126244
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x00018326 File Offset: 0x00016526
		public unsafe CharacterControllerUnit m_CharacterControllerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_CharacterControllerUnit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_CharacterControllerUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x00128074 File Offset: 0x00126274
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x00018345 File Offset: 0x00016545
		public unsafe SwitchConditionComponent m_SwitchConditionComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchConditionComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SwitchConditionComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_m_SwitchConditionComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x001280A4 File Offset: 0x001262A4
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x00018364 File Offset: 0x00016564
		public unsafe bool IsSwitchPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_IsSwitchPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.NativeFieldInfoPtr_IsSwitchPlatform)) = value;
			}
		}

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_INTERACTABLE_KEY;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_RELIVE;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_MUSIC;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_COOKING;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTTARGET;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterVisual;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr_m_TipIcon;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceDirection;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstDialog;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeFieldInfoPtr_m_ReliveTimeline;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmDialog;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeFieldInfoPtr_repeatChallengeEventId;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchCharacterVisual;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchFirstDialog;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchNormalDialog;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchAcceptDialog;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchRefuseDialog;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchReliveTimeline;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterControllerUnit;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchConditionComponent;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr_IsSwitchPlatform;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterMap_Public_Virtual_Void_String_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_ReliveHakureiFestival_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_MusicRepeatChallenge_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_CookingRepeatChallenge_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetCompetition_Private_Void_Action_BaseInteractData_ChallengeType_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_GetTitle_Private_String_BaseInteractData_String_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__23_0_Private_Void_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__23_1_Private_Void_Action_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__23_3_Private_Void_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__23_2_Private_Void_0;

		// Token: 0x02000798 RID: 1944
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.JienYuuBehaviourComponent+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A3B7 RID: 41911 RVA: 0x002AE76C File Offset: 0x002AC96C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr);
				JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, "baseInteractData");
				JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, "<>9__1");
				JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, 100670500);
				JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ReliveHakureiFestival_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, 100670501);
				JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ReliveHakureiFestival_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, 100670502);
			}

			// Token: 0x0600A3B8 RID: 41912 RVA: 0x002AE810 File Offset: 0x002ACA10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3B9 RID: 41913 RVA: 0x002AE84C File Offset: 0x002ACA4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92957, XrefRangeEnd = 92969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReliveHakureiFestival_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ReliveHakureiFestival_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3BA RID: 41914 RVA: 0x002AE880 File Offset: 0x002ACA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92969, XrefRangeEnd = 92993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReliveHakureiFestival_b__1(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ReliveHakureiFestival_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3BB RID: 41915 RVA: 0x00058654 File Offset: 0x00056854
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035FC RID: 13820
			// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x002AE8C0 File Offset: 0x002ACAC0
			// (set) Token: 0x0600A3BD RID: 41917 RVA: 0x0005865D File Offset: 0x0005685D
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035FD RID: 13821
			// (get) Token: 0x0600A3BE RID: 41918 RVA: 0x002AE8F0 File Offset: 0x002ACAF0
			// (set) Token: 0x0600A3BF RID: 41919 RVA: 0x0005867C File Offset: 0x0005687C
			public unsafe JienYuuBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JienYuuBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035FE RID: 13822
			// (get) Token: 0x0600A3C0 RID: 41920 RVA: 0x002AE920 File Offset: 0x002ACB20
			// (set) Token: 0x0600A3C1 RID: 41921 RVA: 0x0005869B File Offset: 0x0005689B
			public unsafe Action<bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069FC RID: 27132
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x040069FD RID: 27133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040069FE RID: 27134
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040069FF RID: 27135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A00 RID: 27136
			private static readonly IntPtr NativeMethodInfoPtr__ReliveHakureiFestival_b__0_Internal_Void_0;

			// Token: 0x04006A01 RID: 27137
			private static readonly IntPtr NativeMethodInfoPtr__ReliveHakureiFestival_b__1_Internal_Void_Boolean_0;
		}

		// Token: 0x02000799 RID: 1945
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.JienYuuBehaviourComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A3C2 RID: 41922 RVA: 0x002AE950 File Offset: 0x002ACB50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr);
				JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, "<>9");
				JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, "<>9__24_2");
				JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__25_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, "<>9__25_4");
				JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__26_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, "<>9__26_4");
				JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, 100670504);
				JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__ReliveHakureiFestival_b__24_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, 100670505);
				JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__MusicRepeatChallenge_b__25_4_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, 100670506);
				JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__CookingRepeatChallenge_b__26_4_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr, 100670507);
			}

			// Token: 0x0600A3C3 RID: 41923 RVA: 0x002AEA1C File Offset: 0x002ACC1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3C4 RID: 41924 RVA: 0x002AEA58 File Offset: 0x002ACC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92993, XrefRangeEnd = 92998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReliveHakureiFestival_b__24_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__ReliveHakureiFestival_b__24_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3C5 RID: 41925 RVA: 0x002AEA8C File Offset: 0x002ACC8C
			[CallerCount(0)]
			public unsafe void _MusicRepeatChallenge_b__25_4(Action callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__MusicRepeatChallenge_b__25_4_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3C6 RID: 41926 RVA: 0x002AEAD0 File Offset: 0x002ACCD0
			[CallerCount(0)]
			public unsafe void _CookingRepeatChallenge_b__26_4(Action callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c.NativeMethodInfoPtr__CookingRepeatChallenge_b__26_4_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3C7 RID: 41927 RVA: 0x000586BA File Offset: 0x000568BA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035FF RID: 13823
			// (get) Token: 0x0600A3C8 RID: 41928 RVA: 0x002AEB14 File Offset: 0x002ACD14
			// (set) Token: 0x0600A3C9 RID: 41929 RVA: 0x000586C3 File Offset: 0x000568C3
			public unsafe static JienYuuBehaviourComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JienYuuBehaviourComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003600 RID: 13824
			// (get) Token: 0x0600A3CA RID: 41930 RVA: 0x002AEB3C File Offset: 0x002ACD3C
			// (set) Token: 0x0600A3CB RID: 41931 RVA: 0x000586D5 File Offset: 0x000568D5
			public unsafe static Action __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003601 RID: 13825
			// (get) Token: 0x0600A3CC RID: 41932 RVA: 0x002AEB64 File Offset: 0x002ACD64
			// (set) Token: 0x0600A3CD RID: 41933 RVA: 0x000586E7 File Offset: 0x000568E7
			public unsafe static DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback __9__25_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__25_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__25_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003602 RID: 13826
			// (get) Token: 0x0600A3CE RID: 41934 RVA: 0x002AEB8C File Offset: 0x002ACD8C
			// (set) Token: 0x0600A3CF RID: 41935 RVA: 0x000586F9 File Offset: 0x000568F9
			public unsafe static DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback __9__26_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__26_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JienYuuBehaviourComponent.__c.NativeFieldInfoPtr___9__26_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A02 RID: 27138
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006A03 RID: 27139
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x04006A04 RID: 27140
			private static readonly IntPtr NativeFieldInfoPtr___9__25_4;

			// Token: 0x04006A05 RID: 27141
			private static readonly IntPtr NativeFieldInfoPtr___9__26_4;

			// Token: 0x04006A06 RID: 27142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A07 RID: 27143
			private static readonly IntPtr NativeMethodInfoPtr__ReliveHakureiFestival_b__24_2_Internal_Void_0;

			// Token: 0x04006A08 RID: 27144
			private static readonly IntPtr NativeMethodInfoPtr__MusicRepeatChallenge_b__25_4_Internal_Void_Action_0;

			// Token: 0x04006A09 RID: 27145
			private static readonly IntPtr NativeMethodInfoPtr__CookingRepeatChallenge_b__26_4_Internal_Void_Action_0;
		}

		// Token: 0x0200079A RID: 1946
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.JienYuuBehaviourComponent+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A3D0 RID: 41936 RVA: 0x002AEBB4 File Offset: 0x002ACDB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr);
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, "baseInteractData");
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670508);
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__MusicRepeatChallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670509);
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670510);
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670511);
				JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670512);
			}

			// Token: 0x0600A3D1 RID: 41937 RVA: 0x002AEC6C File Offset: 0x002ACE6C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3D2 RID: 41938 RVA: 0x002AECA8 File Offset: 0x002ACEA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92998, XrefRangeEnd = 93044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MusicRepeatChallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__MusicRepeatChallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3D3 RID: 41939 RVA: 0x002AECDC File Offset: 0x002ACEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93044, XrefRangeEnd = 93045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A3D4 RID: 41940 RVA: 0x002AED6C File Offset: 0x002ACF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93045, XrefRangeEnd = 93046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A3D5 RID: 41941 RVA: 0x002AEDFC File Offset: 0x002ACFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93046, XrefRangeEnd = 93047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A3D6 RID: 41942 RVA: 0x0005870B File Offset: 0x0005690B
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003603 RID: 13827
			// (get) Token: 0x0600A3D7 RID: 41943 RVA: 0x002AEE8C File Offset: 0x002AD08C
			// (set) Token: 0x0600A3D8 RID: 41944 RVA: 0x00058714 File Offset: 0x00056914
			public unsafe JienYuuBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JienYuuBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003604 RID: 13828
			// (get) Token: 0x0600A3D9 RID: 41945 RVA: 0x002AEEBC File Offset: 0x002AD0BC
			// (set) Token: 0x0600A3DA RID: 41946 RVA: 0x00058733 File Offset: 0x00056933
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A0A RID: 27146
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A0B RID: 27147
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006A0C RID: 27148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A0D RID: 27149
			private static readonly IntPtr NativeMethodInfoPtr__MusicRepeatChallenge_b__0_Internal_Void_0;

			// Token: 0x04006A0E RID: 27150
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x04006A0F RID: 27151
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

			// Token: 0x04006A10 RID: 27152
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2;
		}

		// Token: 0x0200079B RID: 1947
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.JienYuuBehaviourComponent+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A3DB RID: 41947 RVA: 0x002AEEEC File Offset: 0x002AD0EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr);
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, "baseInteractData");
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670513);
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__CookingRepeatChallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670514);
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670515);
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670516);
				JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670517);
			}

			// Token: 0x0600A3DC RID: 41948 RVA: 0x002AEFA4 File Offset: 0x002AD1A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3DD RID: 41949 RVA: 0x002AEFE0 File Offset: 0x002AD1E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93047, XrefRangeEnd = 93093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CookingRepeatChallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__CookingRepeatChallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3DE RID: 41950 RVA: 0x002AF014 File Offset: 0x002AD214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93093, XrefRangeEnd = 93094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A3DF RID: 41951 RVA: 0x002AF0A4 File Offset: 0x002AD2A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93094, XrefRangeEnd = 93095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A3E0 RID: 41952 RVA: 0x002AF134 File Offset: 0x002AD334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93095, XrefRangeEnd = 93096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A3E1 RID: 41953 RVA: 0x00058752 File Offset: 0x00056952
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003605 RID: 13829
			// (get) Token: 0x0600A3E2 RID: 41954 RVA: 0x002AF1C4 File Offset: 0x002AD3C4
			// (set) Token: 0x0600A3E3 RID: 41955 RVA: 0x0005875B File Offset: 0x0005695B
			public unsafe JienYuuBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JienYuuBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003606 RID: 13830
			// (get) Token: 0x0600A3E4 RID: 41956 RVA: 0x002AF1F4 File Offset: 0x002AD3F4
			// (set) Token: 0x0600A3E5 RID: 41957 RVA: 0x0005877A File Offset: 0x0005697A
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A11 RID: 27153
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A12 RID: 27154
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006A13 RID: 27155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A14 RID: 27156
			private static readonly IntPtr NativeMethodInfoPtr__CookingRepeatChallenge_b__0_Internal_Void_0;

			// Token: 0x04006A15 RID: 27157
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x04006A16 RID: 27158
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

			// Token: 0x04006A17 RID: 27159
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2;
		}

		// Token: 0x0200079C RID: 1948
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.JienYuuBehaviourComponent+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A3E6 RID: 41958 RVA: 0x002AF224 File Offset: 0x002AD424
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JienYuuBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr);
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "baseInteractData");
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_closeFirstPanelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "closeFirstPanelCallback");
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_challengeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "challengeMode");
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "<>9__2");
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670518);
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670519);
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__SetTargetCompetition_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670520);
				JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__SetTargetCompetition_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670521);
			}

			// Token: 0x0600A3E7 RID: 41959 RVA: 0x002AF304 File Offset: 0x002AD504
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JienYuuBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3E8 RID: 41960 RVA: 0x002AF340 File Offset: 0x002AD540
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 93107, RefRangeEnd = 93112, XrefRangeStart = 93096, XrefRangeEnd = 93107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_0(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A3E9 RID: 41961 RVA: 0x002AF384 File Offset: 0x002AD584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93112, XrefRangeEnd = 93128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetTargetCompetition_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__SetTargetCompetition_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3EA RID: 41962 RVA: 0x002AF3B8 File Offset: 0x002AD5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93128, XrefRangeEnd = 93132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetTargetCompetition_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__SetTargetCompetition_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3EB RID: 41963 RVA: 0x00058799 File Offset: 0x00056999
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003607 RID: 13831
			// (get) Token: 0x0600A3EC RID: 41964 RVA: 0x002AF3EC File Offset: 0x002AD5EC
			// (set) Token: 0x0600A3ED RID: 41965 RVA: 0x000587A2 File Offset: 0x000569A2
			public unsafe JienYuuBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JienYuuBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003608 RID: 13832
			// (get) Token: 0x0600A3EE RID: 41966 RVA: 0x002AF41C File Offset: 0x002AD61C
			// (set) Token: 0x0600A3EF RID: 41967 RVA: 0x000587C1 File Offset: 0x000569C1
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003609 RID: 13833
			// (get) Token: 0x0600A3F0 RID: 41968 RVA: 0x002AF44C File Offset: 0x002AD64C
			// (set) Token: 0x0600A3F1 RID: 41969 RVA: 0x000587E0 File Offset: 0x000569E0
			public unsafe Action closeFirstPanelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_closeFirstPanelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_closeFirstPanelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700360A RID: 13834
			// (get) Token: 0x0600A3F2 RID: 41970 RVA: 0x002AF47C File Offset: 0x002AD67C
			// (set) Token: 0x0600A3F3 RID: 41971 RVA: 0x000587FF File Offset: 0x000569FF
			public unsafe NightSceneDirector.ChallengeType challengeMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_challengeMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_challengeMode)) = value;
				}
			}

			// Token: 0x1700360B RID: 13835
			// (get) Token: 0x0600A3F4 RID: 41972 RVA: 0x002AF4A4 File Offset: 0x002AD6A4
			// (set) Token: 0x0600A3F5 RID: 41973 RVA: 0x0005881A File Offset: 0x00056A1A
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JienYuuBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A18 RID: 27160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A19 RID: 27161
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006A1A RID: 27162
			private static readonly IntPtr NativeFieldInfoPtr_closeFirstPanelCallback;

			// Token: 0x04006A1B RID: 27163
			private static readonly IntPtr NativeFieldInfoPtr_challengeMode;

			// Token: 0x04006A1C RID: 27164
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006A1D RID: 27165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A1E RID: 27166
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_0;

			// Token: 0x04006A1F RID: 27167
			private static readonly IntPtr NativeMethodInfoPtr__SetTargetCompetition_b__1_Internal_Void_0;

			// Token: 0x04006A20 RID: 27168
			private static readonly IntPtr NativeMethodInfoPtr__SetTargetCompetition_b__2_Internal_Void_0;
		}
	}
}
