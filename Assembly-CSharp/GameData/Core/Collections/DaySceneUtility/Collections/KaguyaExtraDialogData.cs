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
	// Token: 0x020002A0 RID: 672
	public class KaguyaExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06005573 RID: 21875 RVA: 0x001BEAC0 File Offset: 0x001BCCC0
		// Note: this type is marked as 'beforefieldinit'.
		static KaguyaExtraDialogData()
		{
			Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KaguyaExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr);
			KaguyaExtraDialogData.NativeFieldInfoPtr_KIZUNA_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "KIZUNA_TITLE");
			KaguyaExtraDialogData.NativeFieldInfoPtr_agreeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "agreeDialog");
			KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "kaguyaWinStartDialog");
			KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinRefuseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "kaguyaWinRefuseDialog");
			KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "mokouWinStartDialog");
			KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinRefuseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "mokouWinRefuseDialog");
			KaguyaExtraDialogData.NativeFieldInfoPtr_preliminaryTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "preliminaryTask");
			KaguyaExtraDialogData.NativeFieldInfoPtr_scheduledTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "scheduledTask");
			KaguyaExtraDialogData.NativeFieldInfoPtr_battleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "battleEvent");
			KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "mokouWinEvent");
			KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "kaguyaWinEvent");
			KaguyaExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, 100680740);
			KaguyaExtraDialogData.NativeMethodInfoPtr_KaguyaVSMokou_FoodBattle_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, 100680741);
			KaguyaExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, 100680742);
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x001BEC08 File Offset: 0x001BCE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213372, XrefRangeEnd = 213389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KaguyaExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x001BEC88 File Offset: 0x001BCE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213389, XrefRangeEnd = 213414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KaguyaVSMokou_FoodBattle(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.NativeMethodInfoPtr_KaguyaVSMokou_FoodBattle_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x001BED18 File Offset: 0x001BCF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213414, XrefRangeEnd = 213427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KaguyaExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x0002DFB6 File Offset: 0x0002C1B6
		public KaguyaExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x001BED54 File Offset: 0x001BCF54
		// (set) Token: 0x06005579 RID: 21881 RVA: 0x0002DFBF File Offset: 0x0002C1BF
		public unsafe static string KIZUNA_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KaguyaExtraDialogData.NativeFieldInfoPtr_KIZUNA_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KaguyaExtraDialogData.NativeFieldInfoPtr_KIZUNA_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0600557A RID: 21882 RVA: 0x001BED74 File Offset: 0x001BCF74
		// (set) Token: 0x0600557B RID: 21883 RVA: 0x0002DFD1 File Offset: 0x0002C1D1
		public unsafe DialogPackage agreeDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_agreeDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_agreeDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x001BEDA4 File Offset: 0x001BCFA4
		// (set) Token: 0x0600557D RID: 21885 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		public unsafe DialogPackage kaguyaWinStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600557E RID: 21886 RVA: 0x001BEDD4 File Offset: 0x001BCFD4
		// (set) Token: 0x0600557F RID: 21887 RVA: 0x0002E00F File Offset: 0x0002C20F
		public unsafe DialogPackage kaguyaWinRefuseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinRefuseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinRefuseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06005580 RID: 21888 RVA: 0x001BEE04 File Offset: 0x001BD004
		// (set) Token: 0x06005581 RID: 21889 RVA: 0x0002E02E File Offset: 0x0002C22E
		public unsafe DialogPackage mokouWinStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06005582 RID: 21890 RVA: 0x001BEE34 File Offset: 0x001BD034
		// (set) Token: 0x06005583 RID: 21891 RVA: 0x0002E04D File Offset: 0x0002C24D
		public unsafe DialogPackage mokouWinRefuseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinRefuseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinRefuseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06005584 RID: 21892 RVA: 0x001BEE64 File Offset: 0x001BD064
		// (set) Token: 0x06005585 RID: 21893 RVA: 0x0002E06C File Offset: 0x0002C26C
		public unsafe string preliminaryTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_preliminaryTask);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_preliminaryTask), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06005586 RID: 21894 RVA: 0x001BEE8C File Offset: 0x001BD08C
		// (set) Token: 0x06005587 RID: 21895 RVA: 0x0002E08B File Offset: 0x0002C28B
		public unsafe string scheduledTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_scheduledTask);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_scheduledTask), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06005588 RID: 21896 RVA: 0x001BEEB4 File Offset: 0x001BD0B4
		// (set) Token: 0x06005589 RID: 21897 RVA: 0x0002E0AA File Offset: 0x0002C2AA
		public unsafe string battleEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_battleEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_battleEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600558A RID: 21898 RVA: 0x001BEEDC File Offset: 0x001BD0DC
		// (set) Token: 0x0600558B RID: 21899 RVA: 0x0002E0C9 File Offset: 0x0002C2C9
		public unsafe string mokouWinEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_mokouWinEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600558C RID: 21900 RVA: 0x001BEF04 File Offset: 0x001BD104
		// (set) Token: 0x0600558D RID: 21901 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
		public unsafe string kaguyaWinEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.NativeFieldInfoPtr_kaguyaWinEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400395C RID: 14684
		private static readonly IntPtr NativeFieldInfoPtr_KIZUNA_TITLE;

		// Token: 0x0400395D RID: 14685
		private static readonly IntPtr NativeFieldInfoPtr_agreeDialog;

		// Token: 0x0400395E RID: 14686
		private static readonly IntPtr NativeFieldInfoPtr_kaguyaWinStartDialog;

		// Token: 0x0400395F RID: 14687
		private static readonly IntPtr NativeFieldInfoPtr_kaguyaWinRefuseDialog;

		// Token: 0x04003960 RID: 14688
		private static readonly IntPtr NativeFieldInfoPtr_mokouWinStartDialog;

		// Token: 0x04003961 RID: 14689
		private static readonly IntPtr NativeFieldInfoPtr_mokouWinRefuseDialog;

		// Token: 0x04003962 RID: 14690
		private static readonly IntPtr NativeFieldInfoPtr_preliminaryTask;

		// Token: 0x04003963 RID: 14691
		private static readonly IntPtr NativeFieldInfoPtr_scheduledTask;

		// Token: 0x04003964 RID: 14692
		private static readonly IntPtr NativeFieldInfoPtr_battleEvent;

		// Token: 0x04003965 RID: 14693
		private static readonly IntPtr NativeFieldInfoPtr_mokouWinEvent;

		// Token: 0x04003966 RID: 14694
		private static readonly IntPtr NativeFieldInfoPtr_kaguyaWinEvent;

		// Token: 0x04003967 RID: 14695
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003968 RID: 14696
		private static readonly IntPtr NativeMethodInfoPtr_KaguyaVSMokou_FoodBattle_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003969 RID: 14697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C52 RID: 3154
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KaguyaExtraDialogData+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600E3DE RID: 58334 RVA: 0x0036D6C0 File Offset: 0x0036B8C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr);
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "specialNPCInteractData");
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "<>9__1");
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, "<>9__4");
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680743);
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680744);
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680745);
				KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr, 100680746);
			}

			// Token: 0x0600E3DF RID: 58335 RVA: 0x0036D78C File Offset: 0x0036B98C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3E0 RID: 58336 RVA: 0x0036D7C8 File Offset: 0x0036B9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213314, XrefRangeEnd = 213348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _KaguyaVSMokou_FoodBattle_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3E1 RID: 58337 RVA: 0x0036D7FC File Offset: 0x0036B9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213348, XrefRangeEnd = 213349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _KaguyaVSMokou_FoodBattle_b__1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3E2 RID: 58338 RVA: 0x0036D84C File Offset: 0x0036BA4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213349, XrefRangeEnd = 213354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _KaguyaVSMokou_FoodBattle_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3E3 RID: 58339 RVA: 0x00079888 File Offset: 0x00077A88
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049F4 RID: 18932
			// (get) Token: 0x0600E3E4 RID: 58340 RVA: 0x0036D880 File Offset: 0x0036BA80
			// (set) Token: 0x0600E3E5 RID: 58341 RVA: 0x00079891 File Offset: 0x00077A91
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F5 RID: 18933
			// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x0036D8B0 File Offset: 0x0036BAB0
			// (set) Token: 0x0600E3E7 RID: 58343 RVA: 0x000798B0 File Offset: 0x00077AB0
			public unsafe KaguyaExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KaguyaExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F6 RID: 18934
			// (get) Token: 0x0600E3E8 RID: 58344 RVA: 0x0036D8E0 File Offset: 0x0036BAE0
			// (set) Token: 0x0600E3E9 RID: 58345 RVA: 0x000798CF File Offset: 0x00077ACF
			public unsafe Func<string, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F7 RID: 18935
			// (get) Token: 0x0600E3EA RID: 58346 RVA: 0x0036D910 File Offset: 0x0036BB10
			// (set) Token: 0x0600E3EB RID: 58347 RVA: 0x000798EE File Offset: 0x00077AEE
			public unsafe Action __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091AC RID: 37292
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091AD RID: 37293
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091AE RID: 37294
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040091AF RID: 37295
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040091B0 RID: 37296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091B1 RID: 37297
			private static readonly IntPtr NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__0_Internal_Void_0;

			// Token: 0x040091B2 RID: 37298
			private static readonly IntPtr NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__1_Internal_Boolean_String_0;

			// Token: 0x040091B3 RID: 37299
			private static readonly IntPtr NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__4_Internal_Void_0;
		}

		// Token: 0x02000C53 RID: 3155
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KaguyaExtraDialogData+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : Object
		{
			// Token: 0x0600E3EC RID: 58348 RVA: 0x0036D940 File Offset: 0x0036BB40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KaguyaExtraDialogData>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr);
				KaguyaExtraDialogData.__c__DisplayClass12_1.NativeFieldInfoPtr_lastTimeKaguyaWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr, "lastTimeKaguyaWin");
				KaguyaExtraDialogData.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr, "CS$<>8__locals1");
				KaguyaExtraDialogData.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr, 100680747);
				KaguyaExtraDialogData.__c__DisplayClass12_1.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr, 100680748);
				KaguyaExtraDialogData.__c__DisplayClass12_1.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr, 100680749);
			}

			// Token: 0x0600E3ED RID: 58349 RVA: 0x0036D9D0 File Offset: 0x0036BBD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KaguyaExtraDialogData.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3EE RID: 58350 RVA: 0x0036DA0C File Offset: 0x0036BC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213354, XrefRangeEnd = 213365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _KaguyaVSMokou_FoodBattle_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3EF RID: 58351 RVA: 0x0036DA40 File Offset: 0x0036BC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213365, XrefRangeEnd = 213372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3F0 RID: 58352 RVA: 0x0007990D File Offset: 0x00077B0D
			public __c__DisplayClass12_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049F8 RID: 18936
			// (get) Token: 0x0600E3F1 RID: 58353 RVA: 0x0036DA80 File Offset: 0x0036BC80
			// (set) Token: 0x0600E3F2 RID: 58354 RVA: 0x00079916 File Offset: 0x00077B16
			public unsafe bool lastTimeKaguyaWin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeFieldInfoPtr_lastTimeKaguyaWin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeFieldInfoPtr_lastTimeKaguyaWin)) = value;
				}
			}

			// Token: 0x170049F9 RID: 18937
			// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x0036DAA8 File Offset: 0x0036BCA8
			// (set) Token: 0x0600E3F4 RID: 58356 RVA: 0x00079931 File Offset: 0x00077B31
			public unsafe KaguyaExtraDialogData.__c__DisplayClass12_0 field_Public___c__DisplayClass12_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KaguyaExtraDialogData.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KaguyaExtraDialogData.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091B4 RID: 37300
			private static readonly IntPtr NativeFieldInfoPtr_lastTimeKaguyaWin;

			// Token: 0x040091B5 RID: 37301
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0;

			// Token: 0x040091B6 RID: 37302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091B7 RID: 37303
			private static readonly IntPtr NativeMethodInfoPtr__KaguyaVSMokou_FoodBattle_b__2_Internal_Void_0;

			// Token: 0x040091B8 RID: 37304
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;
		}
	}
}
