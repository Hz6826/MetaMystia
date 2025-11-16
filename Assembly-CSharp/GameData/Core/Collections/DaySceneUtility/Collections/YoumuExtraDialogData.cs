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
	// Token: 0x020002B9 RID: 697
	public class YoumuExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060056B0 RID: 22192 RVA: 0x001C298C File Offset: 0x001C0B8C
		// Note: this type is marked as 'beforefieldinit'.
		static YoumuExtraDialogData()
		{
			Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "YoumuExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr);
			YoumuExtraDialogData.NativeFieldInfoPtr_CHAT_KEY_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "CHAT_KEY_A");
			YoumuExtraDialogData.NativeFieldInfoPtr_CHAT_KEY_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "CHAT_KEY_B");
			YoumuExtraDialogData.NativeFieldInfoPtr_challengeAStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "challengeAStartDialog");
			YoumuExtraDialogData.NativeFieldInfoPtr_challengeAEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "challengeAEvent");
			YoumuExtraDialogData.NativeFieldInfoPtr_challengeBStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "challengeBStartDialog");
			YoumuExtraDialogData.NativeFieldInfoPtr_challengeBEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "challengeBEvent");
			YoumuExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, 100680929);
			YoumuExtraDialogData.NativeMethodInfoPtr_YoumuChallenge_Advanced_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, 100680930);
			YoumuExtraDialogData.NativeMethodInfoPtr_YoumuChallenge_Basic_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, 100680931);
			YoumuExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, 100680932);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x001C2A84 File Offset: 0x001C0C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214971, XrefRangeEnd = 214997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YoumuExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x001C2B04 File Offset: 0x001C0D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214997, XrefRangeEnd = 215014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YoumuChallenge_Advanced(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.NativeMethodInfoPtr_YoumuChallenge_Advanced_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x001C2B94 File Offset: 0x001C0D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215014, XrefRangeEnd = 215031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YoumuChallenge_Basic(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.NativeMethodInfoPtr_YoumuChallenge_Basic_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x001C2C24 File Offset: 0x001C0E24
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YoumuExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x0002EA63 File Offset: 0x0002CC63
		public YoumuExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x060056B6 RID: 22198 RVA: 0x001C2C60 File Offset: 0x001C0E60
		// (set) Token: 0x060056B7 RID: 22199 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		public unsafe static string CHAT_KEY_A
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(YoumuExtraDialogData.NativeFieldInfoPtr_CHAT_KEY_A, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YoumuExtraDialogData.NativeFieldInfoPtr_CHAT_KEY_A, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x001C2C80 File Offset: 0x001C0E80
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x0002EA7E File Offset: 0x0002CC7E
		public unsafe static string CHAT_KEY_B
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(YoumuExtraDialogData.NativeFieldInfoPtr_CHAT_KEY_B, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YoumuExtraDialogData.NativeFieldInfoPtr_CHAT_KEY_B, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x060056BA RID: 22202 RVA: 0x001C2CA0 File Offset: 0x001C0EA0
		// (set) Token: 0x060056BB RID: 22203 RVA: 0x0002EA90 File Offset: 0x0002CC90
		public unsafe DialogPackage challengeAStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeAStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeAStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x001C2CD0 File Offset: 0x001C0ED0
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x0002EAAF File Offset: 0x0002CCAF
		public unsafe string challengeAEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeAEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeAEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x001C2CF8 File Offset: 0x001C0EF8
		// (set) Token: 0x060056BF RID: 22207 RVA: 0x0002EACE File Offset: 0x0002CCCE
		public unsafe DialogPackage challengeBStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeBStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeBStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x001C2D28 File Offset: 0x001C0F28
		// (set) Token: 0x060056C1 RID: 22209 RVA: 0x0002EAED File Offset: 0x0002CCED
		public unsafe string challengeBEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeBEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.NativeFieldInfoPtr_challengeBEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003A10 RID: 14864
		private static readonly IntPtr NativeFieldInfoPtr_CHAT_KEY_A;

		// Token: 0x04003A11 RID: 14865
		private static readonly IntPtr NativeFieldInfoPtr_CHAT_KEY_B;

		// Token: 0x04003A12 RID: 14866
		private static readonly IntPtr NativeFieldInfoPtr_challengeAStartDialog;

		// Token: 0x04003A13 RID: 14867
		private static readonly IntPtr NativeFieldInfoPtr_challengeAEvent;

		// Token: 0x04003A14 RID: 14868
		private static readonly IntPtr NativeFieldInfoPtr_challengeBStartDialog;

		// Token: 0x04003A15 RID: 14869
		private static readonly IntPtr NativeFieldInfoPtr_challengeBEvent;

		// Token: 0x04003A16 RID: 14870
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003A17 RID: 14871
		private static readonly IntPtr NativeMethodInfoPtr_YoumuChallenge_Advanced_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003A18 RID: 14872
		private static readonly IntPtr NativeMethodInfoPtr_YoumuChallenge_Basic_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003A19 RID: 14873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C73 RID: 3187
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YoumuExtraDialogData+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600E553 RID: 58707 RVA: 0x003715AC File Offset: 0x0036F7AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr);
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "specialNPCInteractData");
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>9__2");
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>9__1");
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680933);
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__YoumuChallenge_Advanced_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680934);
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__YoumuChallenge_Advanced_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680935);
				YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__YoumuChallenge_Advanced_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680936);
			}

			// Token: 0x0600E554 RID: 58708 RVA: 0x00371678 File Offset: 0x0036F878
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E555 RID: 58709 RVA: 0x003716B4 File Offset: 0x0036F8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214909, XrefRangeEnd = 214920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _YoumuChallenge_Advanced_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__YoumuChallenge_Advanced_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E556 RID: 58710 RVA: 0x003716E8 File Offset: 0x0036F8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214920, XrefRangeEnd = 214932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _YoumuChallenge_Advanced_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__YoumuChallenge_Advanced_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E557 RID: 58711 RVA: 0x0037171C File Offset: 0x0036F91C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214932, XrefRangeEnd = 214940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _YoumuChallenge_Advanced_b__2(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__YoumuChallenge_Advanced_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E558 RID: 58712 RVA: 0x0007A6A5 File Offset: 0x000788A5
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A5F RID: 19039
			// (get) Token: 0x0600E559 RID: 58713 RVA: 0x0037175C File Offset: 0x0036F95C
			// (set) Token: 0x0600E55A RID: 58714 RVA: 0x0007A6AE File Offset: 0x000788AE
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A60 RID: 19040
			// (get) Token: 0x0600E55B RID: 58715 RVA: 0x0037178C File Offset: 0x0036F98C
			// (set) Token: 0x0600E55C RID: 58716 RVA: 0x0007A6CD File Offset: 0x000788CD
			public unsafe YoumuExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YoumuExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A61 RID: 19041
			// (get) Token: 0x0600E55D RID: 58717 RVA: 0x003717BC File Offset: 0x0036F9BC
			// (set) Token: 0x0600E55E RID: 58718 RVA: 0x0007A6EC File Offset: 0x000788EC
			public unsafe Action<bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A62 RID: 19042
			// (get) Token: 0x0600E55F RID: 58719 RVA: 0x003717EC File Offset: 0x0036F9EC
			// (set) Token: 0x0600E560 RID: 58720 RVA: 0x0007A70B File Offset: 0x0007890B
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009270 RID: 37488
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009271 RID: 37489
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009272 RID: 37490
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04009273 RID: 37491
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009274 RID: 37492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009275 RID: 37493
			private static readonly IntPtr NativeMethodInfoPtr__YoumuChallenge_Advanced_b__0_Internal_Void_0;

			// Token: 0x04009276 RID: 37494
			private static readonly IntPtr NativeMethodInfoPtr__YoumuChallenge_Advanced_b__1_Internal_Void_0;

			// Token: 0x04009277 RID: 37495
			private static readonly IntPtr NativeMethodInfoPtr__YoumuChallenge_Advanced_b__2_Internal_Void_Boolean_0;
		}

		// Token: 0x02000C74 RID: 3188
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YoumuExtraDialogData+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600E561 RID: 58721 RVA: 0x0037181C File Offset: 0x0036FA1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YoumuExtraDialogData>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr);
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "specialNPCInteractData");
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>9__2");
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>9__1");
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680937);
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__YoumuChallenge_Basic_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680938);
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__YoumuChallenge_Basic_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680939);
				YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__YoumuChallenge_Basic_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680940);
			}

			// Token: 0x0600E562 RID: 58722 RVA: 0x003718E8 File Offset: 0x0036FAE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YoumuExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E563 RID: 58723 RVA: 0x00371924 File Offset: 0x0036FB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214940, XrefRangeEnd = 214951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _YoumuChallenge_Basic_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__YoumuChallenge_Basic_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E564 RID: 58724 RVA: 0x00371958 File Offset: 0x0036FB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214951, XrefRangeEnd = 214963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _YoumuChallenge_Basic_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__YoumuChallenge_Basic_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E565 RID: 58725 RVA: 0x0037198C File Offset: 0x0036FB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214963, XrefRangeEnd = 214971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _YoumuChallenge_Basic_b__2(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YoumuExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__YoumuChallenge_Basic_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E566 RID: 58726 RVA: 0x0007A72A File Offset: 0x0007892A
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A63 RID: 19043
			// (get) Token: 0x0600E567 RID: 58727 RVA: 0x003719CC File Offset: 0x0036FBCC
			// (set) Token: 0x0600E568 RID: 58728 RVA: 0x0007A733 File Offset: 0x00078933
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A64 RID: 19044
			// (get) Token: 0x0600E569 RID: 58729 RVA: 0x003719FC File Offset: 0x0036FBFC
			// (set) Token: 0x0600E56A RID: 58730 RVA: 0x0007A752 File Offset: 0x00078952
			public unsafe YoumuExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YoumuExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A65 RID: 19045
			// (get) Token: 0x0600E56B RID: 58731 RVA: 0x00371A2C File Offset: 0x0036FC2C
			// (set) Token: 0x0600E56C RID: 58732 RVA: 0x0007A771 File Offset: 0x00078971
			public unsafe Action<bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A66 RID: 19046
			// (get) Token: 0x0600E56D RID: 58733 RVA: 0x00371A5C File Offset: 0x0036FC5C
			// (set) Token: 0x0600E56E RID: 58734 RVA: 0x0007A790 File Offset: 0x00078990
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YoumuExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009278 RID: 37496
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009279 RID: 37497
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400927A RID: 37498
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400927B RID: 37499
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400927C RID: 37500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400927D RID: 37501
			private static readonly IntPtr NativeMethodInfoPtr__YoumuChallenge_Basic_b__0_Internal_Void_0;

			// Token: 0x0400927E RID: 37502
			private static readonly IntPtr NativeMethodInfoPtr__YoumuChallenge_Basic_b__1_Internal_Void_0;

			// Token: 0x0400927F RID: 37503
			private static readonly IntPtr NativeMethodInfoPtr__YoumuChallenge_Basic_b__2_Internal_Void_Boolean_0;
		}
	}
}
