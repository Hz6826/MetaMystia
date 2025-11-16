using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B4 RID: 692
	public class OrinExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x0600566D RID: 22125 RVA: 0x001C1AFC File Offset: 0x001BFCFC
		// Note: this type is marked as 'beforefieldinit'.
		static OrinExtraDialogData()
		{
			Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "OrinExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr);
			OrinExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "OPTION_REPEATCHALLENGE");
			OrinExtraDialogData.NativeFieldInfoPtr_challengeMissionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "challengeMissionId");
			OrinExtraDialogData.NativeFieldInfoPtr_repeatChallengeEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "repeatChallengeEventId");
			OrinExtraDialogData.NativeFieldInfoPtr_confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "confirm");
			OrinExtraDialogData.NativeFieldInfoPtr_enter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "enter");
			OrinExtraDialogData.NativeFieldInfoPtr_refuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "refuse");
			OrinExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, 100680880);
			OrinExtraDialogData.NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, 100680881);
			OrinExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, 100680882);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x001C1BE0 File Offset: 0x001BFDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214507, XrefRangeEnd = 214524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrinExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x001C1C60 File Offset: 0x001BFE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214524, XrefRangeEnd = 214545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRepeatChallengeItem(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x001C1CF0 File Offset: 0x001BFEF0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrinExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x0002E80B File Offset: 0x0002CA0B
		public OrinExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06005672 RID: 22130 RVA: 0x001C1D2C File Offset: 0x001BFF2C
		// (set) Token: 0x06005673 RID: 22131 RVA: 0x0002E814 File Offset: 0x0002CA14
		public unsafe static string OPTION_REPEATCHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrinExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrinExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06005674 RID: 22132 RVA: 0x001C1D4C File Offset: 0x001BFF4C
		// (set) Token: 0x06005675 RID: 22133 RVA: 0x0002E826 File Offset: 0x0002CA26
		public unsafe string challengeMissionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_challengeMissionId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_challengeMissionId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x001C1D74 File Offset: 0x001BFF74
		// (set) Token: 0x06005677 RID: 22135 RVA: 0x0002E845 File Offset: 0x0002CA45
		public unsafe string repeatChallengeEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_repeatChallengeEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_repeatChallengeEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x001C1D9C File Offset: 0x001BFF9C
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x0002E864 File Offset: 0x0002CA64
		public unsafe DialogPackage confirm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_confirm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_confirm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x001C1DCC File Offset: 0x001BFFCC
		// (set) Token: 0x0600567B RID: 22139 RVA: 0x0002E883 File Offset: 0x0002CA83
		public unsafe DialogPackage enter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_enter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_enter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x0600567C RID: 22140 RVA: 0x001C1DFC File Offset: 0x001BFFFC
		// (set) Token: 0x0600567D RID: 22141 RVA: 0x0002E8A2 File Offset: 0x0002CAA2
		public unsafe DialogPackage refuse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_refuse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.NativeFieldInfoPtr_refuse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039EA RID: 14826
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_REPEATCHALLENGE;

		// Token: 0x040039EB RID: 14827
		private static readonly IntPtr NativeFieldInfoPtr_challengeMissionId;

		// Token: 0x040039EC RID: 14828
		private static readonly IntPtr NativeFieldInfoPtr_repeatChallengeEventId;

		// Token: 0x040039ED RID: 14829
		private static readonly IntPtr NativeFieldInfoPtr_confirm;

		// Token: 0x040039EE RID: 14830
		private static readonly IntPtr NativeFieldInfoPtr_enter;

		// Token: 0x040039EF RID: 14831
		private static readonly IntPtr NativeFieldInfoPtr_refuse;

		// Token: 0x040039F0 RID: 14832
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x040039F1 RID: 14833
		private static readonly IntPtr NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x040039F2 RID: 14834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C6A RID: 3178
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.OrinExtraDialogData+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600E4E3 RID: 58595 RVA: 0x00370200 File Offset: 0x0036E400
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrinExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr);
				OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "specialNPCInteractData");
				OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>9__1");
				OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>9__3");
				OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680883);
				OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680884);
				OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680885);
				OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680886);
				OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680887);
			}

			// Token: 0x0600E4E4 RID: 58596 RVA: 0x003702E0 File Offset: 0x0036E4E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrinExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4E5 RID: 58597 RVA: 0x0037031C File Offset: 0x0036E51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214471, XrefRangeEnd = 214482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4E6 RID: 58598 RVA: 0x00370350 File Offset: 0x0036E550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214482, XrefRangeEnd = 214493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4E7 RID: 58599 RVA: 0x00370384 File Offset: 0x0036E584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214493, XrefRangeEnd = 214499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4E8 RID: 58600 RVA: 0x003703C4 File Offset: 0x0036E5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214499, XrefRangeEnd = 214507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrinExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4E9 RID: 58601 RVA: 0x0007A268 File Offset: 0x00078468
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A3E RID: 19006
			// (get) Token: 0x0600E4EA RID: 58602 RVA: 0x003703F8 File Offset: 0x0036E5F8
			// (set) Token: 0x0600E4EB RID: 58603 RVA: 0x0007A271 File Offset: 0x00078471
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A3F RID: 19007
			// (get) Token: 0x0600E4EC RID: 58604 RVA: 0x00370428 File Offset: 0x0036E628
			// (set) Token: 0x0600E4ED RID: 58605 RVA: 0x0007A290 File Offset: 0x00078490
			public unsafe OrinExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrinExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A40 RID: 19008
			// (get) Token: 0x0600E4EE RID: 58606 RVA: 0x00370458 File Offset: 0x0036E658
			// (set) Token: 0x0600E4EF RID: 58607 RVA: 0x0007A2AF File Offset: 0x000784AF
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A41 RID: 19009
			// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x00370488 File Offset: 0x0036E688
			// (set) Token: 0x0600E4F1 RID: 58609 RVA: 0x0007A2CE File Offset: 0x000784CE
			public unsafe Action __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrinExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009234 RID: 37428
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009235 RID: 37429
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009236 RID: 37430
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009237 RID: 37431
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04009238 RID: 37432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009239 RID: 37433
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0;

			// Token: 0x0400923A RID: 37434
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__1_Internal_Void_0;

			// Token: 0x0400923B RID: 37435
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

			// Token: 0x0400923C RID: 37436
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__3_Internal_Void_0;
		}
	}
}
