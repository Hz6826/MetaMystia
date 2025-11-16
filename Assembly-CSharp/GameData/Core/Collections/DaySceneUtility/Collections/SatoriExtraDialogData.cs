using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B7 RID: 695
	public class SatoriExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06005697 RID: 22167 RVA: 0x001C23F8 File Offset: 0x001C05F8
		// Note: this type is marked as 'beforefieldinit'.
		static SatoriExtraDialogData()
		{
			Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "SatoriExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr);
			SatoriExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "OPTION_REPEATCHALLENGE");
			SatoriExtraDialogData.NativeFieldInfoPtr_firstChallengeSuccessEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "firstChallengeSuccessEventId");
			SatoriExtraDialogData.NativeFieldInfoPtr_repeatChallengeEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "repeatChallengeEventId");
			SatoriExtraDialogData.NativeFieldInfoPtr_confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "confirm");
			SatoriExtraDialogData.NativeFieldInfoPtr_enter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "enter");
			SatoriExtraDialogData.NativeFieldInfoPtr_refuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "refuse");
			SatoriExtraDialogData.NativeFieldInfoPtr_introTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "introTimeline");
			SatoriExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, 100680906);
			SatoriExtraDialogData.NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, 100680907);
			SatoriExtraDialogData.NativeMethodInfoPtr_DifficultButtonConfig_Private_Void_BaseInteractData_Difficulty_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, 100680908);
			SatoriExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, 100680909);
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x001C2504 File Offset: 0x001C0704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214842, XrefRangeEnd = 214859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SatoriExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x001C2584 File Offset: 0x001C0784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214859, XrefRangeEnd = 214880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x001C2614 File Offset: 0x001C0814
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214906, RefRangeEnd = 214909, XrefRangeStart = 214880, XrefRangeEnd = 214906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.NativeMethodInfoPtr_DifficultButtonConfig_Private_Void_BaseInteractData_Difficulty_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x001C26B0 File Offset: 0x001C08B0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SatoriExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x0002E985 File Offset: 0x0002CB85
		public SatoriExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x001C26EC File Offset: 0x001C08EC
		// (set) Token: 0x0600569E RID: 22174 RVA: 0x0002E98E File Offset: 0x0002CB8E
		public unsafe static string OPTION_REPEATCHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SatoriExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SatoriExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600569F RID: 22175 RVA: 0x001C270C File Offset: 0x001C090C
		// (set) Token: 0x060056A0 RID: 22176 RVA: 0x0002E9A0 File Offset: 0x0002CBA0
		public unsafe string firstChallengeSuccessEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_firstChallengeSuccessEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_firstChallengeSuccessEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x060056A1 RID: 22177 RVA: 0x001C2734 File Offset: 0x001C0934
		// (set) Token: 0x060056A2 RID: 22178 RVA: 0x0002E9BF File Offset: 0x0002CBBF
		public unsafe string repeatChallengeEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_repeatChallengeEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_repeatChallengeEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x060056A3 RID: 22179 RVA: 0x001C275C File Offset: 0x001C095C
		// (set) Token: 0x060056A4 RID: 22180 RVA: 0x0002E9DE File Offset: 0x0002CBDE
		public unsafe DialogPackage confirm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_confirm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_confirm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x060056A5 RID: 22181 RVA: 0x001C278C File Offset: 0x001C098C
		// (set) Token: 0x060056A6 RID: 22182 RVA: 0x0002E9FD File Offset: 0x0002CBFD
		public unsafe DialogPackage enter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_enter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_enter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x060056A7 RID: 22183 RVA: 0x001C27BC File Offset: 0x001C09BC
		// (set) Token: 0x060056A8 RID: 22184 RVA: 0x0002EA1C File Offset: 0x0002CC1C
		public unsafe DialogPackage refuse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_refuse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_refuse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x060056A9 RID: 22185 RVA: 0x001C27EC File Offset: 0x001C09EC
		// (set) Token: 0x060056AA RID: 22186 RVA: 0x0002EA3B File Offset: 0x0002CC3B
		public unsafe PlayableAsset introTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_introTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.NativeFieldInfoPtr_introTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_REPEATCHALLENGE;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeFieldInfoPtr_firstChallengeSuccessEventId;

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeFieldInfoPtr_repeatChallengeEventId;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeFieldInfoPtr_confirm;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeFieldInfoPtr_enter;

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeFieldInfoPtr_refuse;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeFieldInfoPtr_introTimeline;

		// Token: 0x04003A09 RID: 14857
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003A0A RID: 14858
		private static readonly IntPtr NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003A0B RID: 14859
		private static readonly IntPtr NativeMethodInfoPtr_DifficultButtonConfig_Private_Void_BaseInteractData_Difficulty_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003A0C RID: 14860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C6F RID: 3183
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.SatoriExtraDialogData+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600E526 RID: 58662 RVA: 0x00370BFC File Offset: 0x0036EDFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "specialNPCInteractData");
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>9__1");
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680910);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680911);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680912);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680913);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680914);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680915);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680916);
				SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680917);
			}

			// Token: 0x0600E527 RID: 58663 RVA: 0x00370D04 File Offset: 0x0036EF04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E528 RID: 58664 RVA: 0x00370D40 File Offset: 0x0036EF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214695, XrefRangeEnd = 214706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E529 RID: 58665 RVA: 0x00370D74 File Offset: 0x0036EF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214706, XrefRangeEnd = 214766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E52A RID: 58666 RVA: 0x00370DA8 File Offset: 0x0036EFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214766, XrefRangeEnd = 214783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E52B RID: 58667 RVA: 0x00370E38 File Offset: 0x0036F038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214783, XrefRangeEnd = 214784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E52C RID: 58668 RVA: 0x00370EC8 File Offset: 0x0036F0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214784, XrefRangeEnd = 214785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E52D RID: 58669 RVA: 0x00370F58 File Offset: 0x0036F158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214785, XrefRangeEnd = 214786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E52E RID: 58670 RVA: 0x00370FE8 File Offset: 0x0036F1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214786, XrefRangeEnd = 214806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_4(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title2, out bool availability2, out Action onInteract2)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E52F RID: 58671 RVA: 0x0007A557 File Offset: 0x00078757
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A54 RID: 19028
			// (get) Token: 0x0600E530 RID: 58672 RVA: 0x00371078 File Offset: 0x0036F278
			// (set) Token: 0x0600E531 RID: 58673 RVA: 0x0007A560 File Offset: 0x00078760
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A55 RID: 19029
			// (get) Token: 0x0600E532 RID: 58674 RVA: 0x003710A8 File Offset: 0x0036F2A8
			// (set) Token: 0x0600E533 RID: 58675 RVA: 0x0007A57F File Offset: 0x0007877F
			public unsafe SatoriExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SatoriExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A56 RID: 19030
			// (get) Token: 0x0600E534 RID: 58676 RVA: 0x003710D8 File Offset: 0x0036F2D8
			// (set) Token: 0x0600E535 RID: 58677 RVA: 0x0007A59E File Offset: 0x0007879E
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009256 RID: 37462
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009257 RID: 37463
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009258 RID: 37464
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009259 RID: 37465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400925A RID: 37466
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0;

			// Token: 0x0400925B RID: 37467
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__1_Internal_Void_0;

			// Token: 0x0400925C RID: 37468
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x0400925D RID: 37469
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

			// Token: 0x0400925E RID: 37470
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_2;

			// Token: 0x0400925F RID: 37471
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_3;

			// Token: 0x04009260 RID: 37472
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_4;
		}

		// Token: 0x02000C70 RID: 3184
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.SatoriExtraDialogData+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Object
		{
			// Token: 0x0600E536 RID: 58678 RVA: 0x00371108 File Offset: 0x0036F308
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr);
				SatoriExtraDialogData.__c__DisplayClass8_1.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr, "baseInteractData");
				SatoriExtraDialogData.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
				SatoriExtraDialogData.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr, 100680918);
				SatoriExtraDialogData.__c__DisplayClass8_1.NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr, 100680919);
			}

			// Token: 0x0600E537 RID: 58679 RVA: 0x00371184 File Offset: 0x0036F384
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E538 RID: 58680 RVA: 0x003711C0 File Offset: 0x0036F3C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214806, XrefRangeEnd = 214829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass8_1.NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E539 RID: 58681 RVA: 0x0007A5BD File Offset: 0x000787BD
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A57 RID: 19031
			// (get) Token: 0x0600E53A RID: 58682 RVA: 0x003711F4 File Offset: 0x0036F3F4
			// (set) Token: 0x0600E53B RID: 58683 RVA: 0x0007A5C6 File Offset: 0x000787C6
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_1.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_1.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A58 RID: 19032
			// (get) Token: 0x0600E53C RID: 58684 RVA: 0x00371224 File Offset: 0x0036F424
			// (set) Token: 0x0600E53D RID: 58685 RVA: 0x0007A5E5 File Offset: 0x000787E5
			public unsafe SatoriExtraDialogData.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SatoriExtraDialogData.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009261 RID: 37473
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04009262 RID: 37474
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x04009263 RID: 37475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009264 RID: 37476
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_Internal_Void_0;
		}

		// Token: 0x02000C71 RID: 3185
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.SatoriExtraDialogData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E53E RID: 58686 RVA: 0x00371254 File Offset: 0x0036F454
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr);
				SatoriExtraDialogData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr, "<>9");
				SatoriExtraDialogData.__c.NativeFieldInfoPtr___9__8_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr, "<>9__8_7");
				SatoriExtraDialogData.__c.NativeFieldInfoPtr___9__8_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr, "<>9__8_9");
				SatoriExtraDialogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr, 100680921);
				SatoriExtraDialogData.__c.NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_7_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr, 100680922);
				SatoriExtraDialogData.__c.NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr, 100680923);
			}

			// Token: 0x0600E53F RID: 58687 RVA: 0x003712F8 File Offset: 0x0036F4F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatoriExtraDialogData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E540 RID: 58688 RVA: 0x00371334 File Offset: 0x0036F534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__8_7(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c.NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_7_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E541 RID: 58689 RVA: 0x00371378 File Offset: 0x0036F578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214829, XrefRangeEnd = 214834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__8_9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c.NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E542 RID: 58690 RVA: 0x0007A604 File Offset: 0x00078804
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A59 RID: 19033
			// (get) Token: 0x0600E543 RID: 58691 RVA: 0x003713AC File Offset: 0x0036F5AC
			// (set) Token: 0x0600E544 RID: 58692 RVA: 0x0007A60D File Offset: 0x0007880D
			public unsafe static SatoriExtraDialogData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SatoriExtraDialogData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SatoriExtraDialogData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SatoriExtraDialogData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A5A RID: 19034
			// (get) Token: 0x0600E545 RID: 58693 RVA: 0x003713D4 File Offset: 0x0036F5D4
			// (set) Token: 0x0600E546 RID: 58694 RVA: 0x0007A61F File Offset: 0x0007881F
			public unsafe static DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback __9__8_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SatoriExtraDialogData.__c.NativeFieldInfoPtr___9__8_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SatoriExtraDialogData.__c.NativeFieldInfoPtr___9__8_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A5B RID: 19035
			// (get) Token: 0x0600E547 RID: 58695 RVA: 0x003713FC File Offset: 0x0036F5FC
			// (set) Token: 0x0600E548 RID: 58696 RVA: 0x0007A631 File Offset: 0x00078831
			public unsafe static Action __9__8_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SatoriExtraDialogData.__c.NativeFieldInfoPtr___9__8_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SatoriExtraDialogData.__c.NativeFieldInfoPtr___9__8_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009265 RID: 37477
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009266 RID: 37478
			private static readonly IntPtr NativeFieldInfoPtr___9__8_7;

			// Token: 0x04009267 RID: 37479
			private static readonly IntPtr NativeFieldInfoPtr___9__8_9;

			// Token: 0x04009268 RID: 37480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009269 RID: 37481
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_7_Internal_Void_Action_0;

			// Token: 0x0400926A RID: 37482
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__8_9_Internal_Void_0;
		}

		// Token: 0x02000C72 RID: 3186
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.SatoriExtraDialogData+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600E549 RID: 58697 RVA: 0x00371424 File Offset: 0x0036F624
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SatoriExtraDialogData>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr);
				SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr, "baseInteractData");
				SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr, "difficulty");
				SatoriExtraDialogData.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr, 100680924);
				SatoriExtraDialogData.__c__DisplayClass9_0.NativeMethodInfoPtr__DifficultButtonConfig_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr, 100680925);
			}

			// Token: 0x0600E54A RID: 58698 RVA: 0x003714B4 File Offset: 0x0036F6B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatoriExtraDialogData.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E54B RID: 58699 RVA: 0x003714F0 File Offset: 0x0036F6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214834, XrefRangeEnd = 214842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DifficultButtonConfig_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatoriExtraDialogData.__c__DisplayClass9_0.NativeMethodInfoPtr__DifficultButtonConfig_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E54C RID: 58700 RVA: 0x0007A643 File Offset: 0x00078843
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A5C RID: 19036
			// (get) Token: 0x0600E54D RID: 58701 RVA: 0x00371524 File Offset: 0x0036F724
			// (set) Token: 0x0600E54E RID: 58702 RVA: 0x0007A64C File Offset: 0x0007884C
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A5D RID: 19037
			// (get) Token: 0x0600E54F RID: 58703 RVA: 0x00371554 File Offset: 0x0036F754
			// (set) Token: 0x0600E550 RID: 58704 RVA: 0x0007A66B File Offset: 0x0007886B
			public unsafe SatoriExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SatoriExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A5E RID: 19038
			// (get) Token: 0x0600E551 RID: 58705 RVA: 0x00371584 File Offset: 0x0036F784
			// (set) Token: 0x0600E552 RID: 58706 RVA: 0x0007A68A File Offset: 0x0007888A
			public unsafe NightSceneDirector.Difficulty difficulty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr_difficulty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatoriExtraDialogData.__c__DisplayClass9_0.NativeFieldInfoPtr_difficulty)) = value;
				}
			}

			// Token: 0x0400926B RID: 37483
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x0400926C RID: 37484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400926D RID: 37485
			private static readonly IntPtr NativeFieldInfoPtr_difficulty;

			// Token: 0x0400926E RID: 37486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400926F RID: 37487
			private static readonly IntPtr NativeMethodInfoPtr__DifficultButtonConfig_b__0_Internal_Void_0;
		}
	}
}
