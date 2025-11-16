using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x0200029F RID: 671
	public class FlandreExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06005554 RID: 21844 RVA: 0x001BE41C File Offset: 0x001BC61C
		// Note: this type is marked as 'beforefieldinit'.
		static FlandreExtraDialogData()
		{
			Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "FlandreExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr);
			FlandreExtraDialogData.NativeFieldInfoPtr_DECORATION_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "DECORATION_TITLE");
			FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "RECHALLENGE_TITLE");
			FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_CONFIRM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "RECHALLENGE_CONFIRM");
			FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_REFUSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "RECHALLENGE_REFUSE");
			FlandreExtraDialogData.NativeFieldInfoPtr_decorationDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "decorationDialog");
			FlandreExtraDialogData.NativeFieldInfoPtr_m_DecorationEditorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "m_DecorationEditorPanel");
			FlandreExtraDialogData.NativeFieldInfoPtr_m_BeginEventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "m_BeginEventLabel");
			FlandreExtraDialogData.NativeFieldInfoPtr_m_RepeatChallengeEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "m_RepeatChallengeEventId");
			FlandreExtraDialogData.NativeFieldInfoPtr_m_ConfirmDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "m_ConfirmDialog");
			FlandreExtraDialogData.NativeFieldInfoPtr_m_RefuseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "m_RefuseDialog");
			FlandreExtraDialogData.NativeFieldInfoPtr_m_ReChallengeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "m_ReChallengeDialog");
			FlandreExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680718);
			FlandreExtraDialogData.NativeMethodInfoPtr_Decoration_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680719);
			FlandreExtraDialogData.NativeMethodInfoPtr_Rechallenge_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680720);
			FlandreExtraDialogData.NativeMethodInfoPtr_DifficultButtonConfig_Private_Void_BaseInteractData_Difficulty_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680721);
			FlandreExtraDialogData.NativeMethodInfoPtr_Confirm_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680722);
			FlandreExtraDialogData.NativeMethodInfoPtr_Refuse_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680723);
			FlandreExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, 100680724);
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x001BE5B4 File Offset: 0x001BC7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213191, XrefRangeEnd = 213217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpecialGuestExtraDialogData(out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelection, out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlandreExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x001BE634 File Offset: 0x001BC834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213217, XrefRangeEnd = 213234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decoration(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.NativeMethodInfoPtr_Decoration_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x001BE6C4 File Offset: 0x001BC8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213234, XrefRangeEnd = 213255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rechallenge(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.NativeMethodInfoPtr_Rechallenge_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x001BE754 File Offset: 0x001BC954
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213281, RefRangeEnd = 213284, XrefRangeStart = 213255, XrefRangeEnd = 213281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DifficultButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, NightSceneDirector.Difficulty difficulty, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.NativeMethodInfoPtr_DifficultButtonConfig_Private_Void_BaseInteractData_Difficulty_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x001BE7F0 File Offset: 0x001BC9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213284, XrefRangeEnd = 213301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.NativeMethodInfoPtr_Confirm_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x001BE880 File Offset: 0x001BCA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213301, XrefRangeEnd = 213305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refuse(Action closePannelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.NativeMethodInfoPtr_Refuse_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x001BE8C4 File Offset: 0x001BCAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213305, XrefRangeEnd = 213314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlandreExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x0002DE8C File Offset: 0x0002C08C
		public FlandreExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x001BE900 File Offset: 0x001BCB00
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x0002DE95 File Offset: 0x0002C095
		public unsafe static string DECORATION_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreExtraDialogData.NativeFieldInfoPtr_DECORATION_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreExtraDialogData.NativeFieldInfoPtr_DECORATION_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x001BE920 File Offset: 0x001BCB20
		// (set) Token: 0x06005560 RID: 21856 RVA: 0x0002DEA7 File Offset: 0x0002C0A7
		public unsafe static string RECHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06005561 RID: 21857 RVA: 0x001BE940 File Offset: 0x001BCB40
		// (set) Token: 0x06005562 RID: 21858 RVA: 0x0002DEB9 File Offset: 0x0002C0B9
		public unsafe static string RECHALLENGE_CONFIRM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_CONFIRM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_CONFIRM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06005563 RID: 21859 RVA: 0x001BE960 File Offset: 0x001BCB60
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x0002DECB File Offset: 0x0002C0CB
		public unsafe static string RECHALLENGE_REFUSE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_REFUSE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreExtraDialogData.NativeFieldInfoPtr_RECHALLENGE_REFUSE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x001BE980 File Offset: 0x001BCB80
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x0002DEDD File Offset: 0x0002C0DD
		public unsafe DialogPackage decorationDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_decorationDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_decorationDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x001BE9B0 File Offset: 0x001BCBB0
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x0002DEFC File Offset: 0x0002C0FC
		public unsafe DLC4_FlandreHomeDecorationEditorPanel m_DecorationEditorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_DecorationEditorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_DecorationEditorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x001BE9E0 File Offset: 0x001BCBE0
		// (set) Token: 0x0600556A RID: 21866 RVA: 0x0002DF1B File Offset: 0x0002C11B
		public unsafe string m_BeginEventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_BeginEventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_BeginEventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x001BEA08 File Offset: 0x001BCC08
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x0002DF3A File Offset: 0x0002C13A
		public unsafe string m_RepeatChallengeEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_RepeatChallengeEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_RepeatChallengeEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x001BEA30 File Offset: 0x001BCC30
		// (set) Token: 0x0600556E RID: 21870 RVA: 0x0002DF59 File Offset: 0x0002C159
		public unsafe DialogPackage m_ConfirmDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_ConfirmDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_ConfirmDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x001BEA60 File Offset: 0x001BCC60
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x0002DF78 File Offset: 0x0002C178
		public unsafe DialogPackage m_RefuseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_RefuseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_RefuseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x001BEA90 File Offset: 0x001BCC90
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x0002DF97 File Offset: 0x0002C197
		public unsafe DialogPackage m_ReChallengeDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_ReChallengeDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.NativeFieldInfoPtr_m_ReChallengeDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400394A RID: 14666
		private static readonly IntPtr NativeFieldInfoPtr_DECORATION_TITLE;

		// Token: 0x0400394B RID: 14667
		private static readonly IntPtr NativeFieldInfoPtr_RECHALLENGE_TITLE;

		// Token: 0x0400394C RID: 14668
		private static readonly IntPtr NativeFieldInfoPtr_RECHALLENGE_CONFIRM;

		// Token: 0x0400394D RID: 14669
		private static readonly IntPtr NativeFieldInfoPtr_RECHALLENGE_REFUSE;

		// Token: 0x0400394E RID: 14670
		private static readonly IntPtr NativeFieldInfoPtr_decorationDialog;

		// Token: 0x0400394F RID: 14671
		private static readonly IntPtr NativeFieldInfoPtr_m_DecorationEditorPanel;

		// Token: 0x04003950 RID: 14672
		private static readonly IntPtr NativeFieldInfoPtr_m_BeginEventLabel;

		// Token: 0x04003951 RID: 14673
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatChallengeEventId;

		// Token: 0x04003952 RID: 14674
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmDialog;

		// Token: 0x04003953 RID: 14675
		private static readonly IntPtr NativeFieldInfoPtr_m_RefuseDialog;

		// Token: 0x04003954 RID: 14676
		private static readonly IntPtr NativeFieldInfoPtr_m_ReChallengeDialog;

		// Token: 0x04003955 RID: 14677
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003956 RID: 14678
		private static readonly IntPtr NativeMethodInfoPtr_Decoration_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeMethodInfoPtr_Rechallenge_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeMethodInfoPtr_DifficultButtonConfig_Private_Void_BaseInteractData_Difficulty_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeMethodInfoPtr_Refuse_Private_Void_Action_0;

		// Token: 0x0400395B RID: 14683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C4E RID: 3150
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.FlandreExtraDialogData+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600E3AF RID: 58287 RVA: 0x0036CD20 File Offset: 0x0036AF20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr);
				FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "specialNPCInteractData");
				FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "<>9__1");
				FlandreExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680725);
				FlandreExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__Decoration_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680726);
				FlandreExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__Decoration_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680727);
			}

			// Token: 0x0600E3B0 RID: 58288 RVA: 0x0036CDC4 File Offset: 0x0036AFC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3B1 RID: 58289 RVA: 0x0036CE00 File Offset: 0x0036B000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213051, XrefRangeEnd = 213062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Decoration_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__Decoration_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3B2 RID: 58290 RVA: 0x0036CE34 File Offset: 0x0036B034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213062, XrefRangeEnd = 213071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Decoration_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__Decoration_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3B3 RID: 58291 RVA: 0x000796F4 File Offset: 0x000778F4
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049E8 RID: 18920
			// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x0036CE68 File Offset: 0x0036B068
			// (set) Token: 0x0600E3B5 RID: 58293 RVA: 0x000796FD File Offset: 0x000778FD
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E9 RID: 18921
			// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x0036CE98 File Offset: 0x0036B098
			// (set) Token: 0x0600E3B7 RID: 58295 RVA: 0x0007971C File Offset: 0x0007791C
			public unsafe FlandreExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049EA RID: 18922
			// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x0036CEC8 File Offset: 0x0036B0C8
			// (set) Token: 0x0600E3B9 RID: 58297 RVA: 0x0007973B File Offset: 0x0007793B
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009191 RID: 37265
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009192 RID: 37266
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009193 RID: 37267
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009194 RID: 37268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009195 RID: 37269
			private static readonly IntPtr NativeMethodInfoPtr__Decoration_b__0_Internal_Void_0;

			// Token: 0x04009196 RID: 37270
			private static readonly IntPtr NativeMethodInfoPtr__Decoration_b__1_Internal_Void_0;
		}

		// Token: 0x02000C4F RID: 3151
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.FlandreExtraDialogData+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600E3BA RID: 58298 RVA: 0x0036CEF8 File Offset: 0x0036B0F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr);
				FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr, "specialNPCInteractData");
				FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr, "<>9__1");
				FlandreExtraDialogData.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr, 100680728);
				FlandreExtraDialogData.__c__DisplayClass13_0.NativeMethodInfoPtr__Rechallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr, 100680729);
				FlandreExtraDialogData.__c__DisplayClass13_0.NativeMethodInfoPtr__Rechallenge_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr, 100680730);
			}

			// Token: 0x0600E3BB RID: 58299 RVA: 0x0036CF9C File Offset: 0x0036B19C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3BC RID: 58300 RVA: 0x0036CFD8 File Offset: 0x0036B1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213071, XrefRangeEnd = 213082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rechallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass13_0.NativeMethodInfoPtr__Rechallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3BD RID: 58301 RVA: 0x0036D00C File Offset: 0x0036B20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213082, XrefRangeEnd = 213105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rechallenge_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass13_0.NativeMethodInfoPtr__Rechallenge_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3BE RID: 58302 RVA: 0x0007975A File Offset: 0x0007795A
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049EB RID: 18923
			// (get) Token: 0x0600E3BF RID: 58303 RVA: 0x0036D040 File Offset: 0x0036B240
			// (set) Token: 0x0600E3C0 RID: 58304 RVA: 0x00079763 File Offset: 0x00077963
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049EC RID: 18924
			// (get) Token: 0x0600E3C1 RID: 58305 RVA: 0x0036D070 File Offset: 0x0036B270
			// (set) Token: 0x0600E3C2 RID: 58306 RVA: 0x00079782 File Offset: 0x00077982
			public unsafe FlandreExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049ED RID: 18925
			// (get) Token: 0x0600E3C3 RID: 58307 RVA: 0x0036D0A0 File Offset: 0x0036B2A0
			// (set) Token: 0x0600E3C4 RID: 58308 RVA: 0x000797A1 File Offset: 0x000779A1
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009197 RID: 37271
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009198 RID: 37272
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009199 RID: 37273
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400919A RID: 37274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400919B RID: 37275
			private static readonly IntPtr NativeMethodInfoPtr__Rechallenge_b__0_Internal_Void_0;

			// Token: 0x0400919C RID: 37276
			private static readonly IntPtr NativeMethodInfoPtr__Rechallenge_b__1_Internal_Void_0;
		}

		// Token: 0x02000C50 RID: 3152
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.FlandreExtraDialogData+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600E3C5 RID: 58309 RVA: 0x0036D0D0 File Offset: 0x0036B2D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr);
				FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr, "baseInteractData");
				FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr, "difficulty");
				FlandreExtraDialogData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr, 100680731);
				FlandreExtraDialogData.__c__DisplayClass14_0.NativeMethodInfoPtr__DifficultButtonConfig_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr, 100680732);
			}

			// Token: 0x0600E3C6 RID: 58310 RVA: 0x0036D160 File Offset: 0x0036B360
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3C7 RID: 58311 RVA: 0x0036D19C File Offset: 0x0036B39C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213105, XrefRangeEnd = 213113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DifficultButtonConfig_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass14_0.NativeMethodInfoPtr__DifficultButtonConfig_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3C8 RID: 58312 RVA: 0x000797C0 File Offset: 0x000779C0
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049EE RID: 18926
			// (get) Token: 0x0600E3C9 RID: 58313 RVA: 0x0036D1D0 File Offset: 0x0036B3D0
			// (set) Token: 0x0600E3CA RID: 58314 RVA: 0x000797C9 File Offset: 0x000779C9
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049EF RID: 18927
			// (get) Token: 0x0600E3CB RID: 58315 RVA: 0x0036D200 File Offset: 0x0036B400
			// (set) Token: 0x0600E3CC RID: 58316 RVA: 0x000797E8 File Offset: 0x000779E8
			public unsafe FlandreExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F0 RID: 18928
			// (get) Token: 0x0600E3CD RID: 58317 RVA: 0x0036D230 File Offset: 0x0036B430
			// (set) Token: 0x0600E3CE RID: 58318 RVA: 0x00079807 File Offset: 0x00077A07
			public unsafe NightSceneDirector.Difficulty difficulty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr_difficulty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass14_0.NativeFieldInfoPtr_difficulty)) = value;
				}
			}

			// Token: 0x0400919D RID: 37277
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x0400919E RID: 37278
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400919F RID: 37279
			private static readonly IntPtr NativeFieldInfoPtr_difficulty;

			// Token: 0x040091A0 RID: 37280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091A1 RID: 37281
			private static readonly IntPtr NativeMethodInfoPtr__DifficultButtonConfig_b__0_Internal_Void_0;
		}

		// Token: 0x02000C51 RID: 3153
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.FlandreExtraDialogData+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600E3CF RID: 58319 RVA: 0x0036D258 File Offset: 0x0036B458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreExtraDialogData>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, "baseInteractData");
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, "<>9__5");
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680733);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr__Confirm_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680734);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr__Confirm_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680735);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680736);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680737);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680738);
				FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr, 100680739);
			}

			// Token: 0x0600E3D0 RID: 58320 RVA: 0x0036D34C File Offset: 0x0036B54C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreExtraDialogData.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3D1 RID: 58321 RVA: 0x0036D388 File Offset: 0x0036B588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213113, XrefRangeEnd = 213124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Confirm_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr__Confirm_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3D2 RID: 58322 RVA: 0x0036D3BC File Offset: 0x0036B5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213124, XrefRangeEnd = 213168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Confirm_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr__Confirm_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3D3 RID: 58323 RVA: 0x0036D3F0 File Offset: 0x0036B5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213168, XrefRangeEnd = 213169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E3D4 RID: 58324 RVA: 0x0036D480 File Offset: 0x0036B680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213169, XrefRangeEnd = 213170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E3D5 RID: 58325 RVA: 0x0036D510 File Offset: 0x0036B710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213170, XrefRangeEnd = 213171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E3D6 RID: 58326 RVA: 0x0036D5A0 File Offset: 0x0036B7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213171, XrefRangeEnd = 213191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FlandreExtraDialogData.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E3D7 RID: 58327 RVA: 0x00079822 File Offset: 0x00077A22
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049F1 RID: 18929
			// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x0036D630 File Offset: 0x0036B830
			// (set) Token: 0x0600E3D9 RID: 58329 RVA: 0x0007982B File Offset: 0x00077A2B
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F2 RID: 18930
			// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x0036D660 File Offset: 0x0036B860
			// (set) Token: 0x0600E3DB RID: 58331 RVA: 0x0007984A File Offset: 0x00077A4A
			public unsafe FlandreExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F3 RID: 18931
			// (get) Token: 0x0600E3DC RID: 58332 RVA: 0x0036D690 File Offset: 0x0036B890
			// (set) Token: 0x0600E3DD RID: 58333 RVA: 0x00079869 File Offset: 0x00077A69
			public unsafe Action __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreExtraDialogData.__c__DisplayClass15_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091A2 RID: 37282
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x040091A3 RID: 37283
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091A4 RID: 37284
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040091A5 RID: 37285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091A6 RID: 37286
			private static readonly IntPtr NativeMethodInfoPtr__Confirm_b__0_Internal_Void_0;

			// Token: 0x040091A7 RID: 37287
			private static readonly IntPtr NativeMethodInfoPtr__Confirm_b__5_Internal_Void_0;

			// Token: 0x040091A8 RID: 37288
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x040091A9 RID: 37289
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

			// Token: 0x040091AA RID: 37290
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2;

			// Token: 0x040091AB RID: 37291
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3;
		}
	}
}
