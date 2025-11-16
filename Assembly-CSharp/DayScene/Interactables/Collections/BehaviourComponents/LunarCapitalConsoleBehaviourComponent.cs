using System;
using Common.UI;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000184 RID: 388
	public class LunarCapitalConsoleBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002A50 RID: 10832 RVA: 0x0012B0C0 File Offset: 0x001292C0
		// Note: this type is marked as 'beforefieldinit'.
		static LunarCapitalConsoleBehaviourComponent()
		{
			Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "LunarCapitalConsoleBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr);
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TopMenuOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_TopMenuOptions");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TreasureToolsOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_TreasureToolsOptions");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_RepeatChallengeMenuOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_RepeatChallengeMenuOptions");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_MizuchiBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_MizuchiBuffs");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_MizuchiBuffsTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_MizuchiBuffsTitle");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_IsEnterChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_IsEnterChallenge");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_PracticeAChallengeFinishedEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_PracticeBChallengeFinishedEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_PracticeCChallengeFinishedEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_ArrestMizuchiChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_ArrestMizuchiChallengeFinishedEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeARepeatChallengeStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_PracticeARepeatChallengeStartEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeBRepeatChallengeStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_PracticeBRepeatChallengeStartEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeCRepeatChallengeStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_PracticeCRepeatChallengeStartEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_ArrestMizuchiRepeatChallengeStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_ArrestMizuchiRepeatChallengeStartEvent");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_WelcomeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_WelcomeDialog");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TreasureToolsNoneDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_TreasureToolsNoneDialog");
			LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_RepeatChallengeArrestMizuchiDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "m_RepeatChallengeArrestMizuchiDialog");
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670656);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670657);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OnCloseButtonSubmit_Private_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670658);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenTreasureToolsPanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670659);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenRepeatChallengePanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670660);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenRogueLikePanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670661);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenEternalBox_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670662);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterPracticeA_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670663);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterPracticeB_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670664);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterPracticeC_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670665);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterArrestMizuchi_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670666);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_SwitchMizuchiBuffs_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670667);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670668);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr__OpenTreasureToolsPanel_b__20_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670670);
			LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr__OpenEternalBox_b__23_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, 100670671);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x0012B370 File Offset: 0x00129570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94975, XrefRangeEnd = 95081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x0012B3AC File Offset: 0x001295AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95081, XrefRangeEnd = 95100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0012B3E8 File Offset: 0x001295E8
		[CallerCount(0)]
		public unsafe static void OnCloseButtonSubmit(Action action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OnCloseButtonSubmit_Private_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x0012B420 File Offset: 0x00129620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95100, XrefRangeEnd = 95111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTreasureToolsPanel(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenTreasureToolsPanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x0012B4B0 File Offset: 0x001296B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95111, XrefRangeEnd = 95142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenRepeatChallengePanel(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenRepeatChallengePanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x0012B540 File Offset: 0x00129740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95142, XrefRangeEnd = 95158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenRogueLikePanel(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenRogueLikePanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x0012B5D0 File Offset: 0x001297D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95158, XrefRangeEnd = 95169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEternalBox(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_OpenEternalBox_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x0012B660 File Offset: 0x00129860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95169, XrefRangeEnd = 95190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterPracticeA(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterPracticeA_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x0012B6F0 File Offset: 0x001298F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95190, XrefRangeEnd = 95211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterPracticeB(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterPracticeB_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x0012B780 File Offset: 0x00129980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95211, XrefRangeEnd = 95232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterPracticeC(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterPracticeC_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x0012B810 File Offset: 0x00129A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95232, XrefRangeEnd = 95295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterArrestMizuchi(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_EnterArrestMizuchi_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x0012B8A0 File Offset: 0x00129AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95321, RefRangeEnd = 95322, XrefRangeStart = 95295, XrefRangeEnd = 95321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwitchMizuchiBuffs(Il2CppStringArray options)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr_SwitchMizuchiBuffs_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x0012B8D8 File Offset: 0x00129AD8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LunarCapitalConsoleBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x0012B914 File Offset: 0x00129B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95322, XrefRangeEnd = 95341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenTreasureToolsPanel_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr__OpenTreasureToolsPanel_b__20_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x0012B948 File Offset: 0x00129B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95341, XrefRangeEnd = 95361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenEternalBox_b__23_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.NativeMethodInfoPtr__OpenEternalBox_b__23_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00018B78 File Offset: 0x00016D78
		public LunarCapitalConsoleBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x0012B97C File Offset: 0x00129B7C
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x00018B81 File Offset: 0x00016D81
		public unsafe static Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> m_TopMenuOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TopMenuOptions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TopMenuOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x0012B9A4 File Offset: 0x00129BA4
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x00018B93 File Offset: 0x00016D93
		public unsafe static Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> m_TreasureToolsOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TreasureToolsOptions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TreasureToolsOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x0012B9CC File Offset: 0x00129BCC
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x00018BA5 File Offset: 0x00016DA5
		public unsafe static Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> m_RepeatChallengeMenuOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_RepeatChallengeMenuOptions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_RepeatChallengeMenuOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x0012B9F4 File Offset: 0x00129BF4
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x00018BB7 File Offset: 0x00016DB7
		public unsafe static Il2CppReferenceArray<Object> m_MizuchiBuffs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_MizuchiBuffs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_MizuchiBuffs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x0012BA1C File Offset: 0x00129C1C
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x00018BC9 File Offset: 0x00016DC9
		public unsafe static Dictionary<Object, string> m_MizuchiBuffsTitle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_MizuchiBuffsTitle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_MizuchiBuffsTitle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x0012BA44 File Offset: 0x00129C44
		// (set) Token: 0x06002A6C RID: 10860 RVA: 0x00018BDB File Offset: 0x00016DDB
		public unsafe bool m_IsEnterChallenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_IsEnterChallenge);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_IsEnterChallenge)) = value;
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x0012BA6C File Offset: 0x00129C6C
		// (set) Token: 0x06002A6E RID: 10862 RVA: 0x00018BF6 File Offset: 0x00016DF6
		public unsafe string m_PracticeAChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x0012BA94 File Offset: 0x00129C94
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x00018C15 File Offset: 0x00016E15
		public unsafe string m_PracticeBChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x0012BABC File Offset: 0x00129CBC
		// (set) Token: 0x06002A72 RID: 10866 RVA: 0x00018C34 File Offset: 0x00016E34
		public unsafe string m_PracticeCChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x0012BAE4 File Offset: 0x00129CE4
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x00018C53 File Offset: 0x00016E53
		public unsafe string m_ArrestMizuchiChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_ArrestMizuchiChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_ArrestMizuchiChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x0012BB0C File Offset: 0x00129D0C
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x00018C72 File Offset: 0x00016E72
		public unsafe string m_PracticeARepeatChallengeStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeARepeatChallengeStartEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeARepeatChallengeStartEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x0012BB34 File Offset: 0x00129D34
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x00018C91 File Offset: 0x00016E91
		public unsafe string m_PracticeBRepeatChallengeStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeBRepeatChallengeStartEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeBRepeatChallengeStartEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x0012BB5C File Offset: 0x00129D5C
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x00018CB0 File Offset: 0x00016EB0
		public unsafe string m_PracticeCRepeatChallengeStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeCRepeatChallengeStartEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_PracticeCRepeatChallengeStartEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x0012BB84 File Offset: 0x00129D84
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x00018CCF File Offset: 0x00016ECF
		public unsafe string m_ArrestMizuchiRepeatChallengeStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_ArrestMizuchiRepeatChallengeStartEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_ArrestMizuchiRepeatChallengeStartEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x0012BBAC File Offset: 0x00129DAC
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x00018CEE File Offset: 0x00016EEE
		public unsafe DialogPackage m_WelcomeDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_WelcomeDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_WelcomeDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x0012BBDC File Offset: 0x00129DDC
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x00018D0D File Offset: 0x00016F0D
		public unsafe DialogPackage m_TreasureToolsNoneDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TreasureToolsNoneDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_TreasureToolsNoneDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x0012BC0C File Offset: 0x00129E0C
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x00018D2C File Offset: 0x00016F2C
		public unsafe DialogPackage m_RepeatChallengeArrestMizuchiDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_RepeatChallengeArrestMizuchiDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.NativeFieldInfoPtr_m_RepeatChallengeArrestMizuchiDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_m_TopMenuOptions;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureToolsOptions;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatChallengeMenuOptions;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_m_MizuchiBuffs;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_m_MizuchiBuffsTitle;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr_m_IsEnterChallenge;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrestMizuchiChallengeFinishedEvent;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeARepeatChallengeStartEvent;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeBRepeatChallengeStartEvent;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeCRepeatChallengeStartEvent;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrestMizuchiRepeatChallengeStartEvent;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeFieldInfoPtr_m_WelcomeDialog;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeFieldInfoPtr_m_TreasureToolsNoneDialog;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatChallengeArrestMizuchiDialog;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_OnCloseButtonSubmit_Private_Static_Void_Action_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_OpenTreasureToolsPanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_OpenRepeatChallengePanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikePanel_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_OpenEternalBox_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_EnterPracticeA_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_EnterPracticeB_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_EnterPracticeC_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_EnterArrestMizuchi_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_SwitchMizuchiBuffs_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr__OpenTreasureToolsPanel_b__20_0_Private_Void_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr__OpenEternalBox_b__23_0_Private_Void_0;

		// Token: 0x020007B4 RID: 1972
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A501 RID: 42241 RVA: 0x002B1E68 File Offset: 0x002B0068
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr, "<>9");
				LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr, "<>9__18_0");
				LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr, "<>9__27_2");
				LunarCapitalConsoleBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr, 100670673);
				LunarCapitalConsoleBehaviourComponent.__c.NativeMethodInfoPtr__OnInteract_b__18_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr, 100670674);
				LunarCapitalConsoleBehaviourComponent.__c.NativeMethodInfoPtr__EnterArrestMizuchi_b__27_2_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr, 100670675);
			}

			// Token: 0x0600A502 RID: 42242 RVA: 0x002B1F0C File Offset: 0x002B010C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A503 RID: 42243 RVA: 0x002B1F48 File Offset: 0x002B0148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94839, XrefRangeEnd = 94855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__18_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c.NativeMethodInfoPtr__OnInteract_b__18_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A504 RID: 42244 RVA: 0x002B1F7C File Offset: 0x002B017C
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnterArrestMizuchi_b__27_2(ValueTuple<IEnumerable<Object>, bool> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c.NativeMethodInfoPtr__EnterArrestMizuchi_b__27_2_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A505 RID: 42245 RVA: 0x000593FD File Offset: 0x000575FD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003661 RID: 13921
			// (get) Token: 0x0600A506 RID: 42246 RVA: 0x002B1FD0 File Offset: 0x002B01D0
			// (set) Token: 0x0600A507 RID: 42247 RVA: 0x00059406 File Offset: 0x00057606
			public unsafe static LunarCapitalConsoleBehaviourComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LunarCapitalConsoleBehaviourComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003662 RID: 13922
			// (get) Token: 0x0600A508 RID: 42248 RVA: 0x002B1FF8 File Offset: 0x002B01F8
			// (set) Token: 0x0600A509 RID: 42249 RVA: 0x00059418 File Offset: 0x00057618
			public unsafe static Action __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003663 RID: 13923
			// (get) Token: 0x0600A50A RID: 42250 RVA: 0x002B2020 File Offset: 0x002B0220
			// (set) Token: 0x0600A50B RID: 42251 RVA: 0x0005942A File Offset: 0x0005762A
			public unsafe static Func<ValueTuple<IEnumerable<Object>, bool>, bool> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Object>, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LunarCapitalConsoleBehaviourComponent.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006ABB RID: 27323
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006ABC RID: 27324
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04006ABD RID: 27325
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x04006ABE RID: 27326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006ABF RID: 27327
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__18_0_Internal_Void_0;

			// Token: 0x04006AC0 RID: 27328
			private static readonly IntPtr NativeMethodInfoPtr__EnterArrestMizuchi_b__27_2_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;
		}

		// Token: 0x020007B5 RID: 1973
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x0600A50C RID: 42252 RVA: 0x002B2048 File Offset: 0x002B0248
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr, "baseInteractData");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr, "<>9__1");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr, 100670676);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeMethodInfoPtr__OpenRepeatChallengePanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr, 100670677);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeMethodInfoPtr__OpenRepeatChallengePanel_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr, 100670678);
			}

			// Token: 0x0600A50D RID: 42253 RVA: 0x002B20EC File Offset: 0x002B02EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A50E RID: 42254 RVA: 0x002B2128 File Offset: 0x002B0328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94855, XrefRangeEnd = 94878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenRepeatChallengePanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeMethodInfoPtr__OpenRepeatChallengePanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A50F RID: 42255 RVA: 0x002B215C File Offset: 0x002B035C
			[CallerCount(0)]
			public unsafe void _OpenRepeatChallengePanel_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeMethodInfoPtr__OpenRepeatChallengePanel_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A510 RID: 42256 RVA: 0x0005943C File Offset: 0x0005763C
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003664 RID: 13924
			// (get) Token: 0x0600A511 RID: 42257 RVA: 0x002B2190 File Offset: 0x002B0390
			// (set) Token: 0x0600A512 RID: 42258 RVA: 0x00059445 File Offset: 0x00057645
			public unsafe LunarCapitalConsoleBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LunarCapitalConsoleBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003665 RID: 13925
			// (get) Token: 0x0600A513 RID: 42259 RVA: 0x002B21C0 File Offset: 0x002B03C0
			// (set) Token: 0x0600A514 RID: 42260 RVA: 0x00059464 File Offset: 0x00057664
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003666 RID: 13926
			// (get) Token: 0x0600A515 RID: 42261 RVA: 0x002B21F0 File Offset: 0x002B03F0
			// (set) Token: 0x0600A516 RID: 42262 RVA: 0x00059483 File Offset: 0x00057683
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AC1 RID: 27329
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006AC2 RID: 27330
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006AC3 RID: 27331
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006AC4 RID: 27332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AC5 RID: 27333
			private static readonly IntPtr NativeMethodInfoPtr__OpenRepeatChallengePanel_b__0_Internal_Void_0;

			// Token: 0x04006AC6 RID: 27334
			private static readonly IntPtr NativeMethodInfoPtr__OpenRepeatChallengePanel_b__1_Internal_Void_0;
		}

		// Token: 0x020007B6 RID: 1974
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x0600A517 RID: 42263 RVA: 0x002B2220 File Offset: 0x002B0420
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0>.NativeClassPtr, "baseInteractData");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0>.NativeClassPtr, 100670679);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeMethodInfoPtr__OpenRogueLikePanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0>.NativeClassPtr, 100670680);
			}

			// Token: 0x0600A518 RID: 42264 RVA: 0x002B2288 File Offset: 0x002B0488
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A519 RID: 42265 RVA: 0x002B22C4 File Offset: 0x002B04C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94878, XrefRangeEnd = 94880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenRogueLikePanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeMethodInfoPtr__OpenRogueLikePanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A51A RID: 42266 RVA: 0x000594A2 File Offset: 0x000576A2
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003667 RID: 13927
			// (get) Token: 0x0600A51B RID: 42267 RVA: 0x002B22F8 File Offset: 0x002B04F8
			// (set) Token: 0x0600A51C RID: 42268 RVA: 0x000594AB File Offset: 0x000576AB
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass22_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AC7 RID: 27335
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006AC8 RID: 27336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AC9 RID: 27337
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikePanel_b__0_Internal_Void_0;
		}

		// Token: 0x020007B7 RID: 1975
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x0600A51D RID: 42269 RVA: 0x002B2328 File Offset: 0x002B0528
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, "baseInteractData");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, "<>9__1");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, 100670681);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__EnterPracticeA_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, 100670682);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__EnterPracticeA_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr, 100670683);
			}

			// Token: 0x0600A51E RID: 42270 RVA: 0x002B23CC File Offset: 0x002B05CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A51F RID: 42271 RVA: 0x002B2408 File Offset: 0x002B0608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94880, XrefRangeEnd = 94892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterPracticeA_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__EnterPracticeA_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A520 RID: 42272 RVA: 0x002B243C File Offset: 0x002B063C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94892, XrefRangeEnd = 94896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterPracticeA_b__1(bool isConfirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isConfirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeMethodInfoPtr__EnterPracticeA_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A521 RID: 42273 RVA: 0x000594CA File Offset: 0x000576CA
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003668 RID: 13928
			// (get) Token: 0x0600A522 RID: 42274 RVA: 0x002B247C File Offset: 0x002B067C
			// (set) Token: 0x0600A523 RID: 42275 RVA: 0x000594D3 File Offset: 0x000576D3
			public unsafe LunarCapitalConsoleBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LunarCapitalConsoleBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003669 RID: 13929
			// (get) Token: 0x0600A524 RID: 42276 RVA: 0x002B24AC File Offset: 0x002B06AC
			// (set) Token: 0x0600A525 RID: 42277 RVA: 0x000594F2 File Offset: 0x000576F2
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700366A RID: 13930
			// (get) Token: 0x0600A526 RID: 42278 RVA: 0x002B24DC File Offset: 0x002B06DC
			// (set) Token: 0x0600A527 RID: 42279 RVA: 0x00059511 File Offset: 0x00057711
			public unsafe Action<bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass24_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006ACA RID: 27338
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006ACB RID: 27339
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006ACC RID: 27340
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006ACD RID: 27341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006ACE RID: 27342
			private static readonly IntPtr NativeMethodInfoPtr__EnterPracticeA_b__0_Internal_Void_0;

			// Token: 0x04006ACF RID: 27343
			private static readonly IntPtr NativeMethodInfoPtr__EnterPracticeA_b__1_Internal_Void_Boolean_0;
		}

		// Token: 0x020007B8 RID: 1976
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x0600A528 RID: 42280 RVA: 0x002B250C File Offset: 0x002B070C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, "baseInteractData");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, "<>9__1");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670684);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__EnterPracticeB_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670685);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__EnterPracticeB_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670686);
			}

			// Token: 0x0600A529 RID: 42281 RVA: 0x002B25B0 File Offset: 0x002B07B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A52A RID: 42282 RVA: 0x002B25EC File Offset: 0x002B07EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94896, XrefRangeEnd = 94908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterPracticeB_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__EnterPracticeB_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A52B RID: 42283 RVA: 0x002B2620 File Offset: 0x002B0820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94908, XrefRangeEnd = 94912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterPracticeB_b__1(bool isConfirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isConfirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__EnterPracticeB_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A52C RID: 42284 RVA: 0x00059530 File Offset: 0x00057730
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700366B RID: 13931
			// (get) Token: 0x0600A52D RID: 42285 RVA: 0x002B2660 File Offset: 0x002B0860
			// (set) Token: 0x0600A52E RID: 42286 RVA: 0x00059539 File Offset: 0x00057739
			public unsafe LunarCapitalConsoleBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LunarCapitalConsoleBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700366C RID: 13932
			// (get) Token: 0x0600A52F RID: 42287 RVA: 0x002B2690 File Offset: 0x002B0890
			// (set) Token: 0x0600A530 RID: 42288 RVA: 0x00059558 File Offset: 0x00057758
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700366D RID: 13933
			// (get) Token: 0x0600A531 RID: 42289 RVA: 0x002B26C0 File Offset: 0x002B08C0
			// (set) Token: 0x0600A532 RID: 42290 RVA: 0x00059577 File Offset: 0x00057777
			public unsafe Action<bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass25_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AD0 RID: 27344
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006AD1 RID: 27345
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006AD2 RID: 27346
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006AD3 RID: 27347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AD4 RID: 27348
			private static readonly IntPtr NativeMethodInfoPtr__EnterPracticeB_b__0_Internal_Void_0;

			// Token: 0x04006AD5 RID: 27349
			private static readonly IntPtr NativeMethodInfoPtr__EnterPracticeB_b__1_Internal_Void_Boolean_0;
		}

		// Token: 0x020007B9 RID: 1977
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Object
		{
			// Token: 0x0600A533 RID: 42291 RVA: 0x002B26F0 File Offset: 0x002B08F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, "baseInteractData");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, "<>9__1");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670687);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__EnterPracticeC_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670688);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__EnterPracticeC_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr, 100670689);
			}

			// Token: 0x0600A534 RID: 42292 RVA: 0x002B2794 File Offset: 0x002B0994
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A535 RID: 42293 RVA: 0x002B27D0 File Offset: 0x002B09D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94912, XrefRangeEnd = 94924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterPracticeC_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__EnterPracticeC_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A536 RID: 42294 RVA: 0x002B2804 File Offset: 0x002B0A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94924, XrefRangeEnd = 94928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterPracticeC_b__1(bool isConfirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isConfirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeMethodInfoPtr__EnterPracticeC_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A537 RID: 42295 RVA: 0x00059596 File Offset: 0x00057796
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700366E RID: 13934
			// (get) Token: 0x0600A538 RID: 42296 RVA: 0x002B2844 File Offset: 0x002B0A44
			// (set) Token: 0x0600A539 RID: 42297 RVA: 0x0005959F File Offset: 0x0005779F
			public unsafe LunarCapitalConsoleBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LunarCapitalConsoleBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700366F RID: 13935
			// (get) Token: 0x0600A53A RID: 42298 RVA: 0x002B2874 File Offset: 0x002B0A74
			// (set) Token: 0x0600A53B RID: 42299 RVA: 0x000595BE File Offset: 0x000577BE
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003670 RID: 13936
			// (get) Token: 0x0600A53C RID: 42300 RVA: 0x002B28A4 File Offset: 0x002B0AA4
			// (set) Token: 0x0600A53D RID: 42301 RVA: 0x000595DD File Offset: 0x000577DD
			public unsafe Action<bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass26_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AD6 RID: 27350
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006AD7 RID: 27351
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006AD8 RID: 27352
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006AD9 RID: 27353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006ADA RID: 27354
			private static readonly IntPtr NativeMethodInfoPtr__EnterPracticeC_b__0_Internal_Void_0;

			// Token: 0x04006ADB RID: 27355
			private static readonly IntPtr NativeMethodInfoPtr__EnterPracticeC_b__1_Internal_Void_Boolean_0;
		}

		// Token: 0x020007BA RID: 1978
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.LunarCapitalConsoleBehaviourComponent+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Object
		{
			// Token: 0x0600A53E RID: 42302 RVA: 0x002B28D4 File Offset: 0x002B0AD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "baseInteractData");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_multipleChoiceMenuOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "multipleChoiceMenuOpenContext");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "<>9__5");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, "<>9__4");
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670690);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670691);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__1_Internal_String_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670692);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670693);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670694);
				LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__5_Internal_Void_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr, 100670695);
			}

			// Token: 0x0600A53F RID: 42303 RVA: 0x002B29DC File Offset: 0x002B0BDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A540 RID: 42304 RVA: 0x002B2A18 File Offset: 0x002B0C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94928, XrefRangeEnd = 94939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EnterArrestMizuchi_b__0(Object option)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A541 RID: 42305 RVA: 0x002B2A60 File Offset: 0x002B0C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94939, XrefRangeEnd = 94942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EnterArrestMizuchi_b__1(IEnumerable<Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__1_Internal_String_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A542 RID: 42306 RVA: 0x002B2AA8 File Offset: 0x002B0CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94942, XrefRangeEnd = 94953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterArrestMizuchi_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A543 RID: 42307 RVA: 0x002B2ADC File Offset: 0x002B0CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94953, XrefRangeEnd = 94967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterArrestMizuchi_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A544 RID: 42308 RVA: 0x002B2B10 File Offset: 0x002B0D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94967, XrefRangeEnd = 94975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EnterArrestMizuchi_b__5(bool isConfirm, Il2CppStringArray options)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isConfirm;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeMethodInfoPtr__EnterArrestMizuchi_b__5_Internal_Void_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A545 RID: 42309 RVA: 0x000595FC File Offset: 0x000577FC
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003671 RID: 13937
			// (get) Token: 0x0600A546 RID: 42310 RVA: 0x002B2B60 File Offset: 0x002B0D60
			// (set) Token: 0x0600A547 RID: 42311 RVA: 0x00059605 File Offset: 0x00057805
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003672 RID: 13938
			// (get) Token: 0x0600A548 RID: 42312 RVA: 0x002B2B90 File Offset: 0x002B0D90
			// (set) Token: 0x0600A549 RID: 42313 RVA: 0x00059624 File Offset: 0x00057824
			public unsafe LunarCapitalConsoleBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LunarCapitalConsoleBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003673 RID: 13939
			// (get) Token: 0x0600A54A RID: 42314 RVA: 0x002B2BC0 File Offset: 0x002B0DC0
			// (set) Token: 0x0600A54B RID: 42315 RVA: 0x00059643 File Offset: 0x00057843
			public MultipleChoicePannel.MultipleChoicePannelOpenContext multipleChoiceMenuOpenContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_multipleChoiceMenuOpenContext);
					return new MultipleChoicePannel.MultipleChoicePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr_multipleChoiceMenuOpenContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003674 RID: 13940
			// (get) Token: 0x0600A54C RID: 42316 RVA: 0x002B2BF0 File Offset: 0x002B0DF0
			// (set) Token: 0x0600A54D RID: 42317 RVA: 0x00059671 File Offset: 0x00057871
			public unsafe Action<bool, Il2CppStringArray> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, Il2CppStringArray>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003675 RID: 13941
			// (get) Token: 0x0600A54E RID: 42318 RVA: 0x002B2C20 File Offset: 0x002B0E20
			// (set) Token: 0x0600A54F RID: 42319 RVA: 0x00059690 File Offset: 0x00057890
			public unsafe Action __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LunarCapitalConsoleBehaviourComponent.__c__DisplayClass27_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006ADC RID: 27356
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006ADD RID: 27357
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006ADE RID: 27358
			private static readonly IntPtr NativeFieldInfoPtr_multipleChoiceMenuOpenContext;

			// Token: 0x04006ADF RID: 27359
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04006AE0 RID: 27360
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006AE1 RID: 27361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AE2 RID: 27362
			private static readonly IntPtr NativeMethodInfoPtr__EnterArrestMizuchi_b__0_Internal_String_Object_0;

			// Token: 0x04006AE3 RID: 27363
			private static readonly IntPtr NativeMethodInfoPtr__EnterArrestMizuchi_b__1_Internal_String_IEnumerable_1_Object_0;

			// Token: 0x04006AE4 RID: 27364
			private static readonly IntPtr NativeMethodInfoPtr__EnterArrestMizuchi_b__3_Internal_Void_0;

			// Token: 0x04006AE5 RID: 27365
			private static readonly IntPtr NativeMethodInfoPtr__EnterArrestMizuchi_b__4_Internal_Void_0;

			// Token: 0x04006AE6 RID: 27366
			private static readonly IntPtr NativeMethodInfoPtr__EnterArrestMizuchi_b__5_Internal_Void_Boolean_Il2CppStringArray_0;
		}
	}
}
