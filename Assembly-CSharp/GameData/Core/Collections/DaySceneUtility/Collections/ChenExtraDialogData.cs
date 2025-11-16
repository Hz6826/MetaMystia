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
	// Token: 0x0200029D RID: 669
	public class ChenExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06005530 RID: 21808 RVA: 0x001BDD9C File Offset: 0x001BBF9C
		// Note: this type is marked as 'beforefieldinit'.
		static ChenExtraDialogData()
		{
			Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "ChenExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr);
			ChenExtraDialogData.NativeFieldInfoPtr_TARGET_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "TARGET_EVENT");
			ChenExtraDialogData.NativeFieldInfoPtr_CONCERT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "CONCERT_KEY");
			ChenExtraDialogData.NativeFieldInfoPtr_PARTY_STAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "PARTY_STAGE");
			ChenExtraDialogData.NativeFieldInfoPtr_beginDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "beginDialog");
			ChenExtraDialogData.NativeFieldInfoPtr_closeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "closeDialog");
			ChenExtraDialogData.NativeFieldInfoPtr_hostConcertAgainEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "hostConcertAgainEvent");
			ChenExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, 100680701);
			ChenExtraDialogData.NativeMethodInfoPtr_Chen_Concert_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, 100680702);
			ChenExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, 100680703);
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x001BDE80 File Offset: 0x001BC080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212874, XrefRangeEnd = 212891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChenExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x001BDF00 File Offset: 0x001BC100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212891, XrefRangeEnd = 212914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Chen_Concert(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.NativeMethodInfoPtr_Chen_Concert_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x001BDF90 File Offset: 0x001BC190
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChenExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x0002DD30 File Offset: 0x0002BF30
		public ChenExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06005535 RID: 21813 RVA: 0x001BDFCC File Offset: 0x001BC1CC
		// (set) Token: 0x06005536 RID: 21814 RVA: 0x0002DD39 File Offset: 0x0002BF39
		public unsafe static string TARGET_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChenExtraDialogData.NativeFieldInfoPtr_TARGET_EVENT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChenExtraDialogData.NativeFieldInfoPtr_TARGET_EVENT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x001BDFEC File Offset: 0x001BC1EC
		// (set) Token: 0x06005538 RID: 21816 RVA: 0x0002DD4B File Offset: 0x0002BF4B
		public unsafe static string CONCERT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChenExtraDialogData.NativeFieldInfoPtr_CONCERT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChenExtraDialogData.NativeFieldInfoPtr_CONCERT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x001BE00C File Offset: 0x001BC20C
		// (set) Token: 0x0600553A RID: 21818 RVA: 0x0002DD5D File Offset: 0x0002BF5D
		public unsafe static string PARTY_STAGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChenExtraDialogData.NativeFieldInfoPtr_PARTY_STAGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChenExtraDialogData.NativeFieldInfoPtr_PARTY_STAGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x001BE02C File Offset: 0x001BC22C
		// (set) Token: 0x0600553C RID: 21820 RVA: 0x0002DD6F File Offset: 0x0002BF6F
		public unsafe DialogPackage beginDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.NativeFieldInfoPtr_beginDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.NativeFieldInfoPtr_beginDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x001BE05C File Offset: 0x001BC25C
		// (set) Token: 0x0600553E RID: 21822 RVA: 0x0002DD8E File Offset: 0x0002BF8E
		public unsafe DialogPackage closeDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.NativeFieldInfoPtr_closeDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.NativeFieldInfoPtr_closeDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x0600553F RID: 21823 RVA: 0x001BE08C File Offset: 0x001BC28C
		// (set) Token: 0x06005540 RID: 21824 RVA: 0x0002DDAD File Offset: 0x0002BFAD
		public unsafe string hostConcertAgainEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.NativeFieldInfoPtr_hostConcertAgainEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.NativeFieldInfoPtr_hostConcertAgainEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003937 RID: 14647
		private static readonly IntPtr NativeFieldInfoPtr_TARGET_EVENT;

		// Token: 0x04003938 RID: 14648
		private static readonly IntPtr NativeFieldInfoPtr_CONCERT_KEY;

		// Token: 0x04003939 RID: 14649
		private static readonly IntPtr NativeFieldInfoPtr_PARTY_STAGE;

		// Token: 0x0400393A RID: 14650
		private static readonly IntPtr NativeFieldInfoPtr_beginDialog;

		// Token: 0x0400393B RID: 14651
		private static readonly IntPtr NativeFieldInfoPtr_closeDialog;

		// Token: 0x0400393C RID: 14652
		private static readonly IntPtr NativeFieldInfoPtr_hostConcertAgainEvent;

		// Token: 0x0400393D RID: 14653
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x0400393E RID: 14654
		private static readonly IntPtr NativeMethodInfoPtr_Chen_Concert_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x0400393F RID: 14655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C4B RID: 3147
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.ChenExtraDialogData+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600E392 RID: 58258 RVA: 0x0036C810 File Offset: 0x0036AA10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr);
				ChenExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "specialNPCInteractData");
				ChenExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				ChenExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680704);
				ChenExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__Chen_Concert_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680705);
			}

			// Token: 0x0600E393 RID: 58259 RVA: 0x0036C88C File Offset: 0x0036AA8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E394 RID: 58260 RVA: 0x0036C8C8 File Offset: 0x0036AAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212834, XrefRangeEnd = 212853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Chen_Concert_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__Chen_Concert_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E395 RID: 58261 RVA: 0x00079600 File Offset: 0x00077800
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049E1 RID: 18913
			// (get) Token: 0x0600E396 RID: 58262 RVA: 0x0036C8FC File Offset: 0x0036AAFC
			// (set) Token: 0x0600E397 RID: 58263 RVA: 0x00079609 File Offset: 0x00077809
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E2 RID: 18914
			// (get) Token: 0x0600E398 RID: 58264 RVA: 0x0036C92C File Offset: 0x0036AB2C
			// (set) Token: 0x0600E399 RID: 58265 RVA: 0x00079628 File Offset: 0x00077828
			public unsafe ChenExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChenExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009181 RID: 37249
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009182 RID: 37250
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009183 RID: 37251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009184 RID: 37252
			private static readonly IntPtr NativeMethodInfoPtr__Chen_Concert_b__0_Internal_Void_0;
		}

		// Token: 0x02000C4C RID: 3148
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.ChenExtraDialogData+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : Object
		{
			// Token: 0x0600E39A RID: 58266 RVA: 0x0036C95C File Offset: 0x0036AB5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChenExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr);
				ChenExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_finishAutoCompleteEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "finishAutoCompleteEvents");
				ChenExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
				ChenExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680706);
				ChenExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__Chen_Concert_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680707);
				ChenExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680708);
			}

			// Token: 0x0600E39B RID: 58267 RVA: 0x0036C9EC File Offset: 0x0036ABEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChenExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E39C RID: 58268 RVA: 0x0036CA28 File Offset: 0x0036AC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212853, XrefRangeEnd = 212864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Chen_Concert_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__Chen_Concert_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E39D RID: 58269 RVA: 0x0036CA5C File Offset: 0x0036AC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212864, XrefRangeEnd = 212874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChenExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E39E RID: 58270 RVA: 0x00079647 File Offset: 0x00077847
			public __c__DisplayClass7_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049E3 RID: 18915
			// (get) Token: 0x0600E39F RID: 58271 RVA: 0x0036CA9C File Offset: 0x0036AC9C
			// (set) Token: 0x0600E3A0 RID: 58272 RVA: 0x00079650 File Offset: 0x00077850
			public unsafe Action finishAutoCompleteEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_finishAutoCompleteEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_finishAutoCompleteEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E4 RID: 18916
			// (get) Token: 0x0600E3A1 RID: 58273 RVA: 0x0036CACC File Offset: 0x0036ACCC
			// (set) Token: 0x0600E3A2 RID: 58274 RVA: 0x0007966F File Offset: 0x0007786F
			public unsafe ChenExtraDialogData.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChenExtraDialogData.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChenExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009185 RID: 37253
			private static readonly IntPtr NativeFieldInfoPtr_finishAutoCompleteEvents;

			// Token: 0x04009186 RID: 37254
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;

			// Token: 0x04009187 RID: 37255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009188 RID: 37256
			private static readonly IntPtr NativeMethodInfoPtr__Chen_Concert_b__1_Internal_Void_0;

			// Token: 0x04009189 RID: 37257
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;
		}
	}
}
