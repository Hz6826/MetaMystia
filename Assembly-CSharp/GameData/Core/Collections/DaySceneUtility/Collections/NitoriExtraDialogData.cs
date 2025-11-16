using System;
using DayScene.UI;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B3 RID: 691
	public class NitoriExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x0600565E RID: 22110 RVA: 0x001C1840 File Offset: 0x001BFA40
		// Note: this type is marked as 'beforefieldinit'.
		static NitoriExtraDialogData()
		{
			Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "NitoriExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr);
			NitoriExtraDialogData.NativeFieldInfoPtr_OPTION_FIRST_REPEATCHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, "OPTION_FIRST_REPEATCHALLENGE");
			NitoriExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, "OPTION_REPEATCHALLENGE");
			NitoriExtraDialogData.NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, "CHALLENGESUCCESS_EVENT_ID");
			NitoriExtraDialogData.NativeFieldInfoPtr_FIRST_REPEATCHALLENGE_EVENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, "FIRST_REPEATCHALLENGE_EVENT_ID");
			NitoriExtraDialogData.NativeFieldInfoPtr_REPEATCHALLENGE_EVENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, "REPEATCHALLENGE_EVENT_ID");
			NitoriExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, 100680874);
			NitoriExtraDialogData.NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, 100680875);
			NitoriExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, 100680876);
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x001C1910 File Offset: 0x001BFB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214425, XrefRangeEnd = 214442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x001C1990 File Offset: 0x001BFB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214442, XrefRangeEnd = 214471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriExtraDialogData.NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x001C1A20 File Offset: 0x001BFC20
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NitoriExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x0002E7A8 File Offset: 0x0002C9A8
		public NitoriExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x001C1A5C File Offset: 0x001BFC5C
		// (set) Token: 0x06005664 RID: 22116 RVA: 0x0002E7B1 File Offset: 0x0002C9B1
		public unsafe static string OPTION_FIRST_REPEATCHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NitoriExtraDialogData.NativeFieldInfoPtr_OPTION_FIRST_REPEATCHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NitoriExtraDialogData.NativeFieldInfoPtr_OPTION_FIRST_REPEATCHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06005665 RID: 22117 RVA: 0x001C1A7C File Offset: 0x001BFC7C
		// (set) Token: 0x06005666 RID: 22118 RVA: 0x0002E7C3 File Offset: 0x0002C9C3
		public unsafe static string OPTION_REPEATCHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NitoriExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NitoriExtraDialogData.NativeFieldInfoPtr_OPTION_REPEATCHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06005667 RID: 22119 RVA: 0x001C1A9C File Offset: 0x001BFC9C
		// (set) Token: 0x06005668 RID: 22120 RVA: 0x0002E7D5 File Offset: 0x0002C9D5
		public unsafe static string CHALLENGESUCCESS_EVENT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NitoriExtraDialogData.NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NitoriExtraDialogData.NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x001C1ABC File Offset: 0x001BFCBC
		// (set) Token: 0x0600566A RID: 22122 RVA: 0x0002E7E7 File Offset: 0x0002C9E7
		public unsafe static string FIRST_REPEATCHALLENGE_EVENT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NitoriExtraDialogData.NativeFieldInfoPtr_FIRST_REPEATCHALLENGE_EVENT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NitoriExtraDialogData.NativeFieldInfoPtr_FIRST_REPEATCHALLENGE_EVENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x001C1ADC File Offset: 0x001BFCDC
		// (set) Token: 0x0600566C RID: 22124 RVA: 0x0002E7F9 File Offset: 0x0002C9F9
		public unsafe static string REPEATCHALLENGE_EVENT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NitoriExtraDialogData.NativeFieldInfoPtr_REPEATCHALLENGE_EVENT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NitoriExtraDialogData.NativeFieldInfoPtr_REPEATCHALLENGE_EVENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039E2 RID: 14818
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_FIRST_REPEATCHALLENGE;

		// Token: 0x040039E3 RID: 14819
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_REPEATCHALLENGE;

		// Token: 0x040039E4 RID: 14820
		private static readonly IntPtr NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID;

		// Token: 0x040039E5 RID: 14821
		private static readonly IntPtr NativeFieldInfoPtr_FIRST_REPEATCHALLENGE_EVENT_ID;

		// Token: 0x040039E6 RID: 14822
		private static readonly IntPtr NativeFieldInfoPtr_REPEATCHALLENGE_EVENT_ID;

		// Token: 0x040039E7 RID: 14823
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x040039E8 RID: 14824
		private static readonly IntPtr NativeMethodInfoPtr_AddRepeatChallengeItem_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x040039E9 RID: 14825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C69 RID: 3177
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.NitoriExtraDialogData+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600E4DA RID: 58586 RVA: 0x00370068 File Offset: 0x0036E268
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriExtraDialogData>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr);
				NitoriExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, "specialNPCInteractData");
				NitoriExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_firstRepeatChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, "firstRepeatChallenge");
				NitoriExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, 100680877);
				NitoriExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, 100680878);
				NitoriExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, 100680879);
			}

			// Token: 0x0600E4DB RID: 58587 RVA: 0x003700F8 File Offset: 0x0036E2F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4DC RID: 58588 RVA: 0x00370134 File Offset: 0x0036E334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214402, XrefRangeEnd = 214413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddRepeatChallengeItem_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4DD RID: 58589 RVA: 0x00370168 File Offset: 0x0036E368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214413, XrefRangeEnd = 214425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4DE RID: 58590 RVA: 0x0007A225 File Offset: 0x00078425
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A3C RID: 19004
			// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x003701A8 File Offset: 0x0036E3A8
			// (set) Token: 0x0600E4E0 RID: 58592 RVA: 0x0007A22E File Offset: 0x0007842E
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A3D RID: 19005
			// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x003701D8 File Offset: 0x0036E3D8
			// (set) Token: 0x0600E4E2 RID: 58594 RVA: 0x0007A24D File Offset: 0x0007844D
			public unsafe bool firstRepeatChallenge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_firstRepeatChallenge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_firstRepeatChallenge)) = value;
				}
			}

			// Token: 0x0400922F RID: 37423
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009230 RID: 37424
			private static readonly IntPtr NativeFieldInfoPtr_firstRepeatChallenge;

			// Token: 0x04009231 RID: 37425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009232 RID: 37426
			private static readonly IntPtr NativeMethodInfoPtr__AddRepeatChallengeItem_b__0_Internal_Void_0;

			// Token: 0x04009233 RID: 37427
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;
		}
	}
}
