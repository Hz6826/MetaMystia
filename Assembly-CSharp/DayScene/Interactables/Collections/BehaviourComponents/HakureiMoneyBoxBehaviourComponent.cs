using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000183 RID: 387
	public class HakureiMoneyBoxBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002A22 RID: 10786 RVA: 0x0012A5CC File Offset: 0x001287CC
		// Note: this type is marked as 'beforefieldinit'.
		static HakureiMoneyBoxBehaviourComponent()
		{
			Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "HakureiMoneyBoxBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr);
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_maxDonateNumPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "maxDonateNumPerDay");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_REIMU_STRINGID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "REIMU_STRINGID");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_openDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "openDialog");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_specialDialogWhenReimuDisappear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "specialDialogWhenReimuDisappear");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_reimuDisappearDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "reimuDisappearDistance");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oneHundredDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "oneHundredDialog");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_fiveHundredDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "fiveHundredDialog");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oneThousandDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "oneThousandDialog");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_EndDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "EndDialog");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_conditionFulfilledTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "conditionFulfilledTimeline");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_yukariFinalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "yukariFinalEvent");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oldSavementEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "oldSavementEvent");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_finalDonateNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "finalDonateNum");
			HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_m_ModuleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "m_ModuleID");
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_get_IfReimuStay_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670629);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_GetDialog_Public_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670630);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670631);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670632);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_InitButtonInternal_Private_Void_BaseInteractData_String_Int32_Il2CppReferenceArray_1_DialogPackage_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670633);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_InitButtonFinal_Private_Void_BaseInteractData_String_Int32_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670634);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OneHundredButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670635);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_FiveHundredButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670636);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OneHousandButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670637);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_FinalButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670638);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_EndButtonAction_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670639);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_DonateBecomeBuff_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670640);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_AddKizuna_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670641);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670642);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670643);
			HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, 100670644);
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0012A854 File Offset: 0x00128A54
		public unsafe bool IfReimuStay
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94516, RefRangeEnd = 94520, XrefRangeStart = 94511, XrefRangeEnd = 94516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_get_IfReimuStay_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x0012A890 File Offset: 0x00128A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94520, XrefRangeEnd = 94525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPackage GetDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_GetDialog_Public_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr3) : null;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x0012A8D0 File Offset: 0x00128AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94525, XrefRangeEnd = 94540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0012A90C File Offset: 0x00128B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94540, XrefRangeEnd = 94545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x0012A948 File Offset: 0x00128B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 94575, RefRangeEnd = 94578, XrefRangeStart = 94545, XrefRangeEnd = 94575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitButtonInternal(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, string titleKey, int targetAmount, Il2CppReferenceArray<DialogPackage> dialogPackageCollection, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(titleKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dialogPackageCollection);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_InitButtonInternal_Private_Void_BaseInteractData_String_Int32_Il2CppReferenceArray_1_DialogPackage_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0012AA0C File Offset: 0x00128C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94612, RefRangeEnd = 94613, XrefRangeStart = 94578, XrefRangeEnd = 94612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitButtonFinal(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, string titleKey, int targetAmount, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(titleKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetAmount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_InitButtonFinal_Private_Void_BaseInteractData_String_Int32_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0012AABC File Offset: 0x00128CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94613, XrefRangeEnd = 94616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OneHundredButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OneHundredButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x0012AB4C File Offset: 0x00128D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94616, XrefRangeEnd = 94619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FiveHundredButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_FiveHundredButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0012ABDC File Offset: 0x00128DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94619, XrefRangeEnd = 94622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OneHousandButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_OneHousandButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0012AC6C File Offset: 0x00128E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94622, XrefRangeEnd = 94625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_FinalButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x0012ACFC File Offset: 0x00128EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94625, XrefRangeEnd = 94648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndButtonAction(Action closePannelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_EndButtonAction_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x0012AD40 File Offset: 0x00128F40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 94765, RefRangeEnd = 94768, XrefRangeStart = 94648, XrefRangeEnd = 94765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DonateBecomeBuff(int donateMoney)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref donateMoney;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_DonateBecomeBuff_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x0012AD80 File Offset: 0x00128F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94768, XrefRangeEnd = 94780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKizuna(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_AddKizuna_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0012ADC0 File Offset: 0x00128FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94780, XrefRangeEnd = 94790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x0012ADFC File Offset: 0x00128FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94790, XrefRangeEnd = 94795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HakureiMoneyBoxBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0012AE38 File Offset: 0x00129038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94795, XrefRangeEnd = 94839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000189E3 File Offset: 0x00016BE3
		public HakureiMoneyBoxBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x0012AE6C File Offset: 0x0012906C
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x000189EC File Offset: 0x00016BEC
		public unsafe static int maxDonateNumPerDay
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_maxDonateNumPerDay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_maxDonateNumPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x0012AE88 File Offset: 0x00129088
		// (set) Token: 0x06002A37 RID: 10807 RVA: 0x000189FA File Offset: 0x00016BFA
		public unsafe static string REIMU_STRINGID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_REIMU_STRINGID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_REIMU_STRINGID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0012AEA8 File Offset: 0x001290A8
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x00018A0C File Offset: 0x00016C0C
		public unsafe Il2CppReferenceArray<DialogPackage> openDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_openDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_openDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x0012AED8 File Offset: 0x001290D8
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x00018A2B File Offset: 0x00016C2B
		public unsafe Il2CppReferenceArray<DialogPackage> specialDialogWhenReimuDisappear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_specialDialogWhenReimuDisappear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_specialDialogWhenReimuDisappear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x0012AF08 File Offset: 0x00129108
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x00018A4A File Offset: 0x00016C4A
		public unsafe float reimuDisappearDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_reimuDisappearDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_reimuDisappearDistance)) = value;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x0012AF30 File Offset: 0x00129130
		// (set) Token: 0x06002A3F RID: 10815 RVA: 0x00018A65 File Offset: 0x00016C65
		public unsafe Il2CppReferenceArray<DialogPackage> oneHundredDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oneHundredDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oneHundredDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x0012AF60 File Offset: 0x00129160
		// (set) Token: 0x06002A41 RID: 10817 RVA: 0x00018A84 File Offset: 0x00016C84
		public unsafe Il2CppReferenceArray<DialogPackage> fiveHundredDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_fiveHundredDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_fiveHundredDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x0012AF90 File Offset: 0x00129190
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x00018AA3 File Offset: 0x00016CA3
		public unsafe Il2CppReferenceArray<DialogPackage> oneThousandDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oneThousandDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oneThousandDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x0012AFC0 File Offset: 0x001291C0
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00018AC2 File Offset: 0x00016CC2
		public unsafe Il2CppReferenceArray<DialogPackage> EndDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_EndDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_EndDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x0012AFF0 File Offset: 0x001291F0
		// (set) Token: 0x06002A47 RID: 10823 RVA: 0x00018AE1 File Offset: 0x00016CE1
		public unsafe PlayableAsset conditionFulfilledTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_conditionFulfilledTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_conditionFulfilledTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x0012B020 File Offset: 0x00129220
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00018B00 File Offset: 0x00016D00
		public unsafe string yukariFinalEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_yukariFinalEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_yukariFinalEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x0012B048 File Offset: 0x00129248
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00018B1F File Offset: 0x00016D1F
		public unsafe string oldSavementEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oldSavementEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_oldSavementEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x0012B070 File Offset: 0x00129270
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x00018B3E File Offset: 0x00016D3E
		public unsafe int finalDonateNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_finalDonateNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_finalDonateNum)) = value;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x0012B098 File Offset: 0x00129298
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00018B59 File Offset: 0x00016D59
		public unsafe string m_ModuleID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_m_ModuleID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.NativeFieldInfoPtr_m_ModuleID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr_maxDonateNumPerDay;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeFieldInfoPtr_REIMU_STRINGID;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeFieldInfoPtr_openDialog;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeFieldInfoPtr_specialDialogWhenReimuDisappear;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeFieldInfoPtr_reimuDisappearDistance;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeFieldInfoPtr_oneHundredDialog;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeFieldInfoPtr_fiveHundredDialog;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeFieldInfoPtr_oneThousandDialog;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeFieldInfoPtr_EndDialog;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeFieldInfoPtr_conditionFulfilledTimeline;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeFieldInfoPtr_yukariFinalEvent;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeFieldInfoPtr_oldSavementEvent;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeFieldInfoPtr_finalDonateNum;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr_m_ModuleID;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_get_IfReimuStay_Private_get_Boolean_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_GetDialog_Public_DialogPackage_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_InitButtonInternal_Private_Void_BaseInteractData_String_Int32_Il2CppReferenceArray_1_DialogPackage_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_InitButtonFinal_Private_Void_BaseInteractData_String_Int32_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_OneHundredButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_FiveHundredButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_OneHousandButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_FinalButtonConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_EndButtonAction_Private_Void_Action_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_DonateBecomeBuff_Private_Void_Int32_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr_AddKizuna_Private_Void_Int32_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__17_0_Private_Void_0;

		// Token: 0x020007B1 RID: 1969
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.HakureiMoneyBoxBehaviourComponent+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600A4D9 RID: 42201 RVA: 0x002B17EC File Offset: 0x002AF9EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr);
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, "baseInteractData");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_dialogPackageCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, "dialogPackageCollection");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_targetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, "targetAmount");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, "<>9__2");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, 100670645);
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__InitButtonInternal_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, 100670646);
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__InitButtonInternal_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, 100670647);
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__InitButtonInternal_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr, 100670648);
			}

			// Token: 0x0600A4DA RID: 42202 RVA: 0x002B18CC File Offset: 0x002AFACC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4DB RID: 42203 RVA: 0x002B1908 File Offset: 0x002AFB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94476, XrefRangeEnd = 94490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitButtonInternal_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__InitButtonInternal_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4DC RID: 42204 RVA: 0x002B193C File Offset: 0x002AFB3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94490, XrefRangeEnd = 94492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitButtonInternal_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__InitButtonInternal_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4DD RID: 42205 RVA: 0x002B1970 File Offset: 0x002AFB70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94492, XrefRangeEnd = 94494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitButtonInternal_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__InitButtonInternal_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4DE RID: 42206 RVA: 0x000592AA File Offset: 0x000574AA
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003655 RID: 13909
			// (get) Token: 0x0600A4DF RID: 42207 RVA: 0x002B19A4 File Offset: 0x002AFBA4
			// (set) Token: 0x0600A4E0 RID: 42208 RVA: 0x000592B3 File Offset: 0x000574B3
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003656 RID: 13910
			// (get) Token: 0x0600A4E1 RID: 42209 RVA: 0x002B19D4 File Offset: 0x002AFBD4
			// (set) Token: 0x0600A4E2 RID: 42210 RVA: 0x000592D2 File Offset: 0x000574D2
			public unsafe Il2CppReferenceArray<DialogPackage> dialogPackageCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_dialogPackageCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_dialogPackageCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003657 RID: 13911
			// (get) Token: 0x0600A4E3 RID: 42211 RVA: 0x002B1A04 File Offset: 0x002AFC04
			// (set) Token: 0x0600A4E4 RID: 42212 RVA: 0x000592F1 File Offset: 0x000574F1
			public unsafe HakureiMoneyBoxBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HakureiMoneyBoxBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003658 RID: 13912
			// (get) Token: 0x0600A4E5 RID: 42213 RVA: 0x002B1A34 File Offset: 0x002AFC34
			// (set) Token: 0x0600A4E6 RID: 42214 RVA: 0x00059310 File Offset: 0x00057510
			public unsafe int targetAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_targetAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_targetAmount)) = value;
				}
			}

			// Token: 0x17003659 RID: 13913
			// (get) Token: 0x0600A4E7 RID: 42215 RVA: 0x002B1A5C File Offset: 0x002AFC5C
			// (set) Token: 0x0600A4E8 RID: 42216 RVA: 0x0005932B File Offset: 0x0005752B
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AA5 RID: 27301
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006AA6 RID: 27302
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackageCollection;

			// Token: 0x04006AA7 RID: 27303
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006AA8 RID: 27304
			private static readonly IntPtr NativeFieldInfoPtr_targetAmount;

			// Token: 0x04006AA9 RID: 27305
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006AAA RID: 27306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AAB RID: 27307
			private static readonly IntPtr NativeMethodInfoPtr__InitButtonInternal_b__0_Internal_Void_0;

			// Token: 0x04006AAC RID: 27308
			private static readonly IntPtr NativeMethodInfoPtr__InitButtonInternal_b__2_Internal_Void_0;

			// Token: 0x04006AAD RID: 27309
			private static readonly IntPtr NativeMethodInfoPtr__InitButtonInternal_b__1_Internal_Void_0;
		}

		// Token: 0x020007B2 RID: 1970
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.HakureiMoneyBoxBehaviourComponent+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x0600A4E9 RID: 42217 RVA: 0x002B1A8C File Offset: 0x002AFC8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr);
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, "baseInteractData");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_targetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, "targetAmount");
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, 100670649);
				HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__InitButtonFinal_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, 100670650);
			}

			// Token: 0x0600A4EA RID: 42218 RVA: 0x002B1B1C File Offset: 0x002AFD1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4EB RID: 42219 RVA: 0x002B1B58 File Offset: 0x002AFD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94494, XrefRangeEnd = 94496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitButtonFinal_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__InitButtonFinal_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4EC RID: 42220 RVA: 0x0005934A File Offset: 0x0005754A
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700365A RID: 13914
			// (get) Token: 0x0600A4ED RID: 42221 RVA: 0x002B1B8C File Offset: 0x002AFD8C
			// (set) Token: 0x0600A4EE RID: 42222 RVA: 0x00059353 File Offset: 0x00057553
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700365B RID: 13915
			// (get) Token: 0x0600A4EF RID: 42223 RVA: 0x002B1BBC File Offset: 0x002AFDBC
			// (set) Token: 0x0600A4F0 RID: 42224 RVA: 0x00059372 File Offset: 0x00057572
			public unsafe HakureiMoneyBoxBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HakureiMoneyBoxBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700365C RID: 13916
			// (get) Token: 0x0600A4F1 RID: 42225 RVA: 0x002B1BEC File Offset: 0x002AFDEC
			// (set) Token: 0x0600A4F2 RID: 42226 RVA: 0x00059391 File Offset: 0x00057591
			public unsafe int targetAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_targetAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiMoneyBoxBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_targetAmount)) = value;
				}
			}

			// Token: 0x04006AAE RID: 27310
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006AAF RID: 27311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006AB0 RID: 27312
			private static readonly IntPtr NativeFieldInfoPtr_targetAmount;

			// Token: 0x04006AB1 RID: 27313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AB2 RID: 27314
			private static readonly IntPtr NativeMethodInfoPtr__InitButtonFinal_b__0_Internal_Void_0;
		}

		// Token: 0x020007B3 RID: 1971
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.HakureiMoneyBoxBehaviourComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A4F3 RID: 42227 RVA: 0x002B1C14 File Offset: 0x002AFE14
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr);
				HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, "<>9");
				HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, "<>9__25_0");
				HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, "<>9__26_0");
				HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, "<>9__26_1");
				HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, 100670652);
				HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__EndButtonAction_b__25_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, 100670653);
				HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__DonateBecomeBuff_b__26_0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, 100670654);
				HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__DonateBecomeBuff_b__26_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr, 100670655);
			}

			// Token: 0x0600A4F4 RID: 42228 RVA: 0x002B1CE0 File Offset: 0x002AFEE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HakureiMoneyBoxBehaviourComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4F5 RID: 42229 RVA: 0x002B1D1C File Offset: 0x002AFF1C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EndButtonAction_b__25_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__EndButtonAction_b__25_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4F6 RID: 42230 RVA: 0x002B1D50 File Offset: 0x002AFF50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94496, XrefRangeEnd = 94500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DonateBecomeBuff_b__26_0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__DonateBecomeBuff_b__26_0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4F7 RID: 42231 RVA: 0x002B1D94 File Offset: 0x002AFF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94500, XrefRangeEnd = 94511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DonateBecomeBuff_b__26_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiMoneyBoxBehaviourComponent.__c.NativeMethodInfoPtr__DonateBecomeBuff_b__26_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4F8 RID: 42232 RVA: 0x000593AC File Offset: 0x000575AC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700365D RID: 13917
			// (get) Token: 0x0600A4F9 RID: 42233 RVA: 0x002B1DC8 File Offset: 0x002AFFC8
			// (set) Token: 0x0600A4FA RID: 42234 RVA: 0x000593B5 File Offset: 0x000575B5
			public unsafe static HakureiMoneyBoxBehaviourComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HakureiMoneyBoxBehaviourComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700365E RID: 13918
			// (get) Token: 0x0600A4FB RID: 42235 RVA: 0x002B1DF0 File Offset: 0x002AFFF0
			// (set) Token: 0x0600A4FC RID: 42236 RVA: 0x000593C7 File Offset: 0x000575C7
			public unsafe static Action __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700365F RID: 13919
			// (get) Token: 0x0600A4FD RID: 42237 RVA: 0x002B1E18 File Offset: 0x002B0018
			// (set) Token: 0x0600A4FE RID: 42238 RVA: 0x000593D9 File Offset: 0x000575D9
			public unsafe static Action<Action> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003660 RID: 13920
			// (get) Token: 0x0600A4FF RID: 42239 RVA: 0x002B1E40 File Offset: 0x002B0040
			// (set) Token: 0x0600A500 RID: 42240 RVA: 0x000593EB File Offset: 0x000575EB
			public unsafe static Action __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HakureiMoneyBoxBehaviourComponent.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AB3 RID: 27315
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006AB4 RID: 27316
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04006AB5 RID: 27317
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04006AB6 RID: 27318
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x04006AB7 RID: 27319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AB8 RID: 27320
			private static readonly IntPtr NativeMethodInfoPtr__EndButtonAction_b__25_0_Internal_Void_0;

			// Token: 0x04006AB9 RID: 27321
			private static readonly IntPtr NativeMethodInfoPtr__DonateBecomeBuff_b__26_0_Internal_Void_Action_0;

			// Token: 0x04006ABA RID: 27322
			private static readonly IntPtr NativeMethodInfoPtr__DonateBecomeBuff_b__26_1_Internal_Void_0;
		}
	}
}
