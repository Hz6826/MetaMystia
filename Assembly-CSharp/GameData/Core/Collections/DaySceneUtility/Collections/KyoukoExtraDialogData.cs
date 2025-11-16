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
	// Token: 0x020002A2 RID: 674
	public class KyoukoExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x0600559F RID: 21919 RVA: 0x001BF254 File Offset: 0x001BD454
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoExtraDialogData()
		{
			Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr);
			KyoukoExtraDialogData.NativeFieldInfoPtr_BEASTFOREST_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "BEASTFOREST_LABEL");
			KyoukoExtraDialogData.NativeFieldInfoPtr_tutorialConfirmDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "tutorialConfirmDialog");
			KyoukoExtraDialogData.NativeFieldInfoPtr_partyStageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "partyStageLabel");
			KyoukoExtraDialogData.NativeFieldInfoPtr_WhatShouldIDo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "WhatShouldIDo");
			KyoukoExtraDialogData.NativeFieldInfoPtr_Memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "Memory");
			KyoukoExtraDialogData.NativeFieldInfoPtr_HowToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "HowToSave");
			KyoukoExtraDialogData.NativeFieldInfoPtr_AttenionTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "AttenionTip");
			KyoukoExtraDialogData.NativeFieldInfoPtr_GameTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "GameTip");
			KyoukoExtraDialogData.NativeMethodInfoPtr_get_DoNotSkipGreeting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680765);
			KyoukoExtraDialogData.NativeMethodInfoPtr_get_ShowTutorial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680766);
			KyoukoExtraDialogData.NativeMethodInfoPtr_get_AllKyoukoTutorialData_Private_get_Il2CppReferenceArray_1_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680767);
			KyoukoExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680768);
			KyoukoExtraDialogData.NativeMethodInfoPtr_AllCurrentTutorialHaveFinished_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680769);
			KyoukoExtraDialogData.NativeMethodInfoPtr_ShowButton_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680770);
			KyoukoExtraDialogData.NativeMethodInfoPtr_GetButtonCallback_Private_GetSpecialNPCSelectionConfigurationCallback_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680771);
			KyoukoExtraDialogData.NativeMethodInfoPtr_ConfirmCallback_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680772);
			KyoukoExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, 100680773);
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x060055A0 RID: 21920 RVA: 0x001BF3D8 File Offset: 0x001BD5D8
		public unsafe override bool DoNotSkipGreeting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213643, XrefRangeEnd = 213648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoExtraDialogData.NativeMethodInfoPtr_get_DoNotSkipGreeting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x001BF420 File Offset: 0x001BD620
		public unsafe bool ShowTutorial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 213655, RefRangeEnd = 213657, XrefRangeStart = 213648, XrefRangeEnd = 213655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr_get_ShowTutorial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x060055A2 RID: 21922 RVA: 0x001BF45C File Offset: 0x001BD65C
		public unsafe Il2CppReferenceArray<KyoukoTutorialData> AllKyoukoTutorialData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 213670, RefRangeEnd = 213672, XrefRangeStart = 213657, XrefRangeEnd = 213670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr_get_AllKyoukoTutorialData_Private_get_Il2CppReferenceArray_1_KyoukoTutorialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KyoukoTutorialData>>(intPtr3) : null;
			}
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x001BF49C File Offset: 0x001BD69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213672, XrefRangeEnd = 213698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x001BF51C File Offset: 0x001BD71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213700, RefRangeEnd = 213702, XrefRangeStart = 213698, XrefRangeEnd = 213700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AllCurrentTutorialHaveFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr_AllCurrentTutorialHaveFinished_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x001BF558 File Offset: 0x001BD758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213702, XrefRangeEnd = 213708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowButton(bool oldAvailability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldAvailability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr_ShowButton_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x001BF5A4 File Offset: 0x001BD7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213708, XrefRangeEnd = 213720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback GetButtonCallback(KyoukoTutorialData tutorialData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tutorialData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr_GetButtonCallback_Private_GetSpecialNPCSelectionConfigurationCallback_KyoukoTutorialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr3) : null;
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x001BF5F4 File Offset: 0x001BD7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213720, XrefRangeEnd = 213735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmCallback(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr_ConfirmCallback_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x001BF638 File Offset: 0x001BD838
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x0002E1BD File Offset: 0x0002C3BD
		public KyoukoExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x001BF674 File Offset: 0x001BD874
		// (set) Token: 0x060055AB RID: 21931 RVA: 0x0002E1C6 File Offset: 0x0002C3C6
		public unsafe static string BEASTFOREST_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KyoukoExtraDialogData.NativeFieldInfoPtr_BEASTFOREST_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KyoukoExtraDialogData.NativeFieldInfoPtr_BEASTFOREST_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x001BF694 File Offset: 0x001BD894
		// (set) Token: 0x060055AD RID: 21933 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
		public unsafe DialogPackage tutorialConfirmDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_tutorialConfirmDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_tutorialConfirmDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x001BF6C4 File Offset: 0x001BD8C4
		// (set) Token: 0x060055AF RID: 21935 RVA: 0x0002E1F7 File Offset: 0x0002C3F7
		public unsafe string partyStageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_partyStageLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_partyStageLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x001BF6EC File Offset: 0x001BD8EC
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x0002E216 File Offset: 0x0002C416
		public unsafe KyoukoTutorialData WhatShouldIDo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_WhatShouldIDo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_WhatShouldIDo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x001BF71C File Offset: 0x001BD91C
		// (set) Token: 0x060055B3 RID: 21939 RVA: 0x0002E235 File Offset: 0x0002C435
		public unsafe KyoukoTutorialData_Memory Memory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_Memory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_Memory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_Memory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x001BF74C File Offset: 0x001BD94C
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x0002E254 File Offset: 0x0002C454
		public unsafe KyoukoTutorialData HowToSave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_HowToSave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_HowToSave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x001BF77C File Offset: 0x001BD97C
		// (set) Token: 0x060055B7 RID: 21943 RVA: 0x0002E273 File Offset: 0x0002C473
		public unsafe KyoukoTutorialData AttenionTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_AttenionTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_AttenionTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x001BF7AC File Offset: 0x001BD9AC
		// (set) Token: 0x060055B9 RID: 21945 RVA: 0x0002E292 File Offset: 0x0002C492
		public unsafe KyoukoTutorialData_GameTip GameTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_GameTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_GameTip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.NativeFieldInfoPtr_GameTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003973 RID: 14707
		private static readonly IntPtr NativeFieldInfoPtr_BEASTFOREST_LABEL;

		// Token: 0x04003974 RID: 14708
		private static readonly IntPtr NativeFieldInfoPtr_tutorialConfirmDialog;

		// Token: 0x04003975 RID: 14709
		private static readonly IntPtr NativeFieldInfoPtr_partyStageLabel;

		// Token: 0x04003976 RID: 14710
		private static readonly IntPtr NativeFieldInfoPtr_WhatShouldIDo;

		// Token: 0x04003977 RID: 14711
		private static readonly IntPtr NativeFieldInfoPtr_Memory;

		// Token: 0x04003978 RID: 14712
		private static readonly IntPtr NativeFieldInfoPtr_HowToSave;

		// Token: 0x04003979 RID: 14713
		private static readonly IntPtr NativeFieldInfoPtr_AttenionTip;

		// Token: 0x0400397A RID: 14714
		private static readonly IntPtr NativeFieldInfoPtr_GameTip;

		// Token: 0x0400397B RID: 14715
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotSkipGreeting_Public_Virtual_get_Boolean_0;

		// Token: 0x0400397C RID: 14716
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowTutorial_Public_get_Boolean_0;

		// Token: 0x0400397D RID: 14717
		private static readonly IntPtr NativeMethodInfoPtr_get_AllKyoukoTutorialData_Private_get_Il2CppReferenceArray_1_KyoukoTutorialData_0;

		// Token: 0x0400397E RID: 14718
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeMethodInfoPtr_AllCurrentTutorialHaveFinished_Public_Boolean_0;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeMethodInfoPtr_ShowButton_Private_Boolean_Boolean_0;

		// Token: 0x04003981 RID: 14721
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonCallback_Private_GetSpecialNPCSelectionConfigurationCallback_KyoukoTutorialData_0;

		// Token: 0x04003982 RID: 14722
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmCallback_Private_Void_Action_0;

		// Token: 0x04003983 RID: 14723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C57 RID: 3159
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoExtraDialogData+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600E41E RID: 58398 RVA: 0x0036E1DC File Offset: 0x0036C3DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr);
				KyoukoExtraDialogData.__c__DisplayClass17_0.NativeFieldInfoPtr_tutorialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr, "tutorialData");
				KyoukoExtraDialogData.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				KyoukoExtraDialogData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr, 100680774);
				KyoukoExtraDialogData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetButtonCallback_b__0_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr, 100680775);
			}

			// Token: 0x0600E41F RID: 58399 RVA: 0x0036E258 File Offset: 0x0036C458
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E420 RID: 58400 RVA: 0x0036E294 File Offset: 0x0036C494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213625, XrefRangeEnd = 213632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetButtonCallback_b__0(DaySceneChatSelectionPannel.SpecialNPCInteractData data, out string title, out bool availability, out Action onInteract)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetButtonCallback_b__0_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E421 RID: 58401 RVA: 0x00079AC5 File Offset: 0x00077CC5
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A06 RID: 18950
			// (get) Token: 0x0600E422 RID: 58402 RVA: 0x0036E324 File Offset: 0x0036C524
			// (set) Token: 0x0600E423 RID: 58403 RVA: 0x00079ACE File Offset: 0x00077CCE
			public unsafe KyoukoTutorialData tutorialData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.__c__DisplayClass17_0.NativeFieldInfoPtr_tutorialData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.__c__DisplayClass17_0.NativeFieldInfoPtr_tutorialData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A07 RID: 18951
			// (get) Token: 0x0600E424 RID: 58404 RVA: 0x0036E354 File Offset: 0x0036C554
			// (set) Token: 0x0600E425 RID: 58405 RVA: 0x00079AED File Offset: 0x00077CED
			public unsafe KyoukoExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091D0 RID: 37328
			private static readonly IntPtr NativeFieldInfoPtr_tutorialData;

			// Token: 0x040091D1 RID: 37329
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091D2 RID: 37330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091D3 RID: 37331
			private static readonly IntPtr NativeMethodInfoPtr__GetButtonCallback_b__0_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;
		}

		// Token: 0x02000C58 RID: 3160
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoExtraDialogData+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600E426 RID: 58406 RVA: 0x0036E384 File Offset: 0x0036C584
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoExtraDialogData>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr);
				KyoukoExtraDialogData.__c__DisplayClass18_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr, "onFinish");
				KyoukoExtraDialogData.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr, 100680776);
				KyoukoExtraDialogData.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr, 100680777);
				KyoukoExtraDialogData.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr, 100680778);
			}

			// Token: 0x0600E427 RID: 58407 RVA: 0x0036E400 File Offset: 0x0036C600
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoExtraDialogData.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E428 RID: 58408 RVA: 0x0036E43C File Offset: 0x0036C63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213632, XrefRangeEnd = 213643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E429 RID: 58409 RVA: 0x0036E470 File Offset: 0x0036C670
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoExtraDialogData.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E42A RID: 58410 RVA: 0x00079B0C File Offset: 0x00077D0C
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A08 RID: 18952
			// (get) Token: 0x0600E42B RID: 58411 RVA: 0x0036E4B0 File Offset: 0x0036C6B0
			// (set) Token: 0x0600E42C RID: 58412 RVA: 0x00079B15 File Offset: 0x00077D15
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.__c__DisplayClass18_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoExtraDialogData.__c__DisplayClass18_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091D4 RID: 37332
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x040091D5 RID: 37333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091D6 RID: 37334
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040091D7 RID: 37335
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;
		}
	}
}
