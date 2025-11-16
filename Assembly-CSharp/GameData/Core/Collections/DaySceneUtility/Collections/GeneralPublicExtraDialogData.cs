using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B5 RID: 693
	public class GeneralPublicExtraDialogData : SpecialGuestPublicExtraDialogData
	{
		// Token: 0x0600567E RID: 22142 RVA: 0x001C1E2C File Offset: 0x001C002C
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralPublicExtraDialogData()
		{
			Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "GeneralPublicExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr);
			GeneralPublicExtraDialogData.NativeFieldInfoPtr_appendOrPrepend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "appendOrPrepend");
			GeneralPublicExtraDialogData.NativeFieldInfoPtr_optionTitleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "optionTitleKey");
			GeneralPublicExtraDialogData.NativeFieldInfoPtr_beginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "beginEvent");
			GeneralPublicExtraDialogData.NativeFieldInfoPtr_alwaysOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "alwaysOpen");
			GeneralPublicExtraDialogData.NativeFieldInfoPtr_dialogPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "dialogPackages");
			GeneralPublicExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, 100680888);
			GeneralPublicExtraDialogData.NativeMethodInfoPtr_OnInteract_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, 100680889);
			GeneralPublicExtraDialogData.NativeMethodInfoPtr_Play_Private_Void_SGuestDialogPackage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, 100680890);
			GeneralPublicExtraDialogData.NativeMethodInfoPtr_TryFindSGuestDialogPackage_Private_Boolean_String_byref_SGuestDialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, 100680891);
			GeneralPublicExtraDialogData.NativeMethodInfoPtr_ScheduledEvent_Private_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, 100680892);
			GeneralPublicExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, 100680893);
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x001C1F38 File Offset: 0x001C0138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214597, XrefRangeEnd = 214625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralPublicExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x001C1FB8 File Offset: 0x001C01B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214625, XrefRangeEnd = 214664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteract(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.NativeMethodInfoPtr_OnInteract_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x001C2048 File Offset: 0x001C0248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214683, RefRangeEnd = 214684, XrefRangeStart = 214664, XrefRangeEnd = 214683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(GeneralPublicExtraDialogData.SGuestDialogPackage package, bool finishEventIsEmpty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(package));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishEventIsEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.NativeMethodInfoPtr_Play_Private_Void_SGuestDialogPackage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x001C20A0 File Offset: 0x001C02A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214684, XrefRangeEnd = 214687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFindSGuestDialogPackage(string guestLabel, out GeneralPublicExtraDialogData.SGuestDialogPackage sGuestDialogPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guestLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.NativeMethodInfoPtr_TryFindSGuestDialogPackage_Private_Boolean_String_byref_SGuestDialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sGuestDialogPackage = ((intPtr4 == 0) ? null : new GeneralPublicExtraDialogData.SGuestDialogPackage(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x001C2110 File Offset: 0x001C0310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214687, XrefRangeEnd = 214691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduledEvent(string eventId, bool isEmpty, bool isManualComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(eventId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmpty;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isManualComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.NativeMethodInfoPtr_ScheduledEvent_Private_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x001C2170 File Offset: 0x001C0370
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralPublicExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x0002E8C1 File Offset: 0x0002CAC1
		public GeneralPublicExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x001C21AC File Offset: 0x001C03AC
		// (set) Token: 0x06005687 RID: 22151 RVA: 0x0002E8CA File Offset: 0x0002CACA
		public unsafe bool appendOrPrepend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_appendOrPrepend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_appendOrPrepend)) = value;
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x001C21D4 File Offset: 0x001C03D4
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x0002E8E5 File Offset: 0x0002CAE5
		public unsafe string optionTitleKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_optionTitleKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_optionTitleKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x001C21FC File Offset: 0x001C03FC
		// (set) Token: 0x0600568B RID: 22155 RVA: 0x0002E904 File Offset: 0x0002CB04
		public unsafe string beginEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_beginEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_beginEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x001C2224 File Offset: 0x001C0424
		// (set) Token: 0x0600568D RID: 22157 RVA: 0x0002E923 File Offset: 0x0002CB23
		public unsafe bool alwaysOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_alwaysOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_alwaysOpen)) = value;
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x001C224C File Offset: 0x001C044C
		// (set) Token: 0x0600568F RID: 22159 RVA: 0x0002E93E File Offset: 0x0002CB3E
		public unsafe Il2CppReferenceArray<GeneralPublicExtraDialogData.SGuestDialogPackage> dialogPackages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_dialogPackages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GeneralPublicExtraDialogData.SGuestDialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.NativeFieldInfoPtr_dialogPackages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039F3 RID: 14835
		private static readonly IntPtr NativeFieldInfoPtr_appendOrPrepend;

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeFieldInfoPtr_optionTitleKey;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeFieldInfoPtr_beginEvent;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeFieldInfoPtr_alwaysOpen;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackages;

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_SGuestDialogPackage_Boolean_0;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeMethodInfoPtr_TryFindSGuestDialogPackage_Private_Boolean_String_byref_SGuestDialogPackage_0;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeMethodInfoPtr_ScheduledEvent_Private_Void_String_Boolean_Boolean_0;

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C6B RID: 3179
		[Serializable]
		public sealed class SGuestDialogPackage : ValueType
		{
			// Token: 0x0600E4F2 RID: 58610 RVA: 0x003704B8 File Offset: 0x0036E6B8
			// Note: this type is marked as 'beforefieldinit'.
			static SGuestDialogPackage()
			{
				Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "SGuestDialogPackage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr);
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_guestLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "guestLabel");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_extraBeginLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "extraBeginLabel");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "eventType");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "dialogPackage");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_timelineAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "timelineAssetReference");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_needChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "needChat");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_extraSelectionsFinishEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "extraSelectionsFinishEvent");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_executeOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "executeOnce");
				GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_manualCompleteFinishEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, "manualCompleteFinishEvent");
			}

			// Token: 0x0600E4F3 RID: 58611 RVA: 0x0007A2ED File Offset: 0x000784ED
			public SGuestDialogPackage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E4F4 RID: 58612 RVA: 0x0007A2F6 File Offset: 0x000784F6
			public SGuestDialogPackage() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr))
			{
			}

			// Token: 0x17004A42 RID: 19010
			// (get) Token: 0x0600E4F5 RID: 58613 RVA: 0x00370598 File Offset: 0x0036E798
			// (set) Token: 0x0600E4F6 RID: 58614 RVA: 0x0007A308 File Offset: 0x00078508
			public unsafe string guestLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_guestLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_guestLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004A43 RID: 19011
			// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x003705C0 File Offset: 0x0036E7C0
			// (set) Token: 0x0600E4F8 RID: 58616 RVA: 0x0007A327 File Offset: 0x00078527
			public unsafe string extraBeginLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_extraBeginLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_extraBeginLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004A44 RID: 19012
			// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x003705E8 File Offset: 0x0036E7E8
			// (set) Token: 0x0600E4FA RID: 58618 RVA: 0x0007A346 File Offset: 0x00078546
			public unsafe SchedulerNode.Event.EventType eventType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_eventType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_eventType)) = value;
				}
			}

			// Token: 0x17004A45 RID: 19013
			// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x00370610 File Offset: 0x0036E810
			// (set) Token: 0x0600E4FC RID: 58620 RVA: 0x0007A361 File Offset: 0x00078561
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A46 RID: 19014
			// (get) Token: 0x0600E4FD RID: 58621 RVA: 0x00370640 File Offset: 0x0036E840
			// (set) Token: 0x0600E4FE RID: 58622 RVA: 0x0007A380 File Offset: 0x00078580
			public unsafe AssetReferenceT<PlayableAsset> timelineAssetReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_timelineAssetReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<PlayableAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_timelineAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A47 RID: 19015
			// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x00370670 File Offset: 0x0036E870
			// (set) Token: 0x0600E500 RID: 58624 RVA: 0x0007A39F File Offset: 0x0007859F
			public unsafe bool needChat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_needChat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_needChat)) = value;
				}
			}

			// Token: 0x17004A48 RID: 19016
			// (get) Token: 0x0600E501 RID: 58625 RVA: 0x00370698 File Offset: 0x0036E898
			// (set) Token: 0x0600E502 RID: 58626 RVA: 0x0007A3BA File Offset: 0x000785BA
			public unsafe string extraSelectionsFinishEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_extraSelectionsFinishEvent);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_extraSelectionsFinishEvent), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004A49 RID: 19017
			// (get) Token: 0x0600E503 RID: 58627 RVA: 0x003706C0 File Offset: 0x0036E8C0
			// (set) Token: 0x0600E504 RID: 58628 RVA: 0x0007A3D9 File Offset: 0x000785D9
			public unsafe bool executeOnce
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_executeOnce);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_executeOnce)) = value;
				}
			}

			// Token: 0x17004A4A RID: 19018
			// (get) Token: 0x0600E505 RID: 58629 RVA: 0x003706E8 File Offset: 0x0036E8E8
			// (set) Token: 0x0600E506 RID: 58630 RVA: 0x0007A3F4 File Offset: 0x000785F4
			public unsafe bool manualCompleteFinishEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_manualCompleteFinishEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.SGuestDialogPackage.NativeFieldInfoPtr_manualCompleteFinishEvent)) = value;
				}
			}

			// Token: 0x0400923D RID: 37437
			private static readonly IntPtr NativeFieldInfoPtr_guestLabel;

			// Token: 0x0400923E RID: 37438
			private static readonly IntPtr NativeFieldInfoPtr_extraBeginLabel;

			// Token: 0x0400923F RID: 37439
			private static readonly IntPtr NativeFieldInfoPtr_eventType;

			// Token: 0x04009240 RID: 37440
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

			// Token: 0x04009241 RID: 37441
			private static readonly IntPtr NativeFieldInfoPtr_timelineAssetReference;

			// Token: 0x04009242 RID: 37442
			private static readonly IntPtr NativeFieldInfoPtr_needChat;

			// Token: 0x04009243 RID: 37443
			private static readonly IntPtr NativeFieldInfoPtr_extraSelectionsFinishEvent;

			// Token: 0x04009244 RID: 37444
			private static readonly IntPtr NativeFieldInfoPtr_executeOnce;

			// Token: 0x04009245 RID: 37445
			private static readonly IntPtr NativeFieldInfoPtr_manualCompleteFinishEvent;
		}

		// Token: 0x02000C6C RID: 3180
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.GeneralPublicExtraDialogData+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600E507 RID: 58631 RVA: 0x00370710 File Offset: 0x0036E910
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr);
				GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, "specialNPCInteractData");
				GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_sGuestDialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, "sGuestDialogPackage");
				GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_finishEventIsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, "finishEventIsEmpty");
				GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, 100680894);
				GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr, 100680895);
			}

			// Token: 0x0600E508 RID: 58632 RVA: 0x003707B4 File Offset: 0x0036E9B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E509 RID: 58633 RVA: 0x003707F0 File Offset: 0x0036E9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214545, XrefRangeEnd = 214546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E50A RID: 58634 RVA: 0x0007A40F File Offset: 0x0007860F
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A4B RID: 19019
			// (get) Token: 0x0600E50B RID: 58635 RVA: 0x00370824 File Offset: 0x0036EA24
			// (set) Token: 0x0600E50C RID: 58636 RVA: 0x0007A418 File Offset: 0x00078618
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A4C RID: 19020
			// (get) Token: 0x0600E50D RID: 58637 RVA: 0x00370854 File Offset: 0x0036EA54
			// (set) Token: 0x0600E50E RID: 58638 RVA: 0x0007A437 File Offset: 0x00078637
			public unsafe GeneralPublicExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralPublicExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A4D RID: 19021
			// (get) Token: 0x0600E50F RID: 58639 RVA: 0x00370884 File Offset: 0x0036EA84
			// (set) Token: 0x0600E510 RID: 58640 RVA: 0x0007A456 File Offset: 0x00078656
			public GeneralPublicExtraDialogData.SGuestDialogPackage sGuestDialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_sGuestDialogPackage);
					return new GeneralPublicExtraDialogData.SGuestDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_sGuestDialogPackage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A4E RID: 19022
			// (get) Token: 0x0600E511 RID: 58641 RVA: 0x003708B4 File Offset: 0x0036EAB4
			// (set) Token: 0x0600E512 RID: 58642 RVA: 0x0007A484 File Offset: 0x00078684
			public unsafe bool finishEventIsEmpty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_finishEventIsEmpty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass6_0.NativeFieldInfoPtr_finishEventIsEmpty)) = value;
				}
			}

			// Token: 0x04009246 RID: 37446
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009247 RID: 37447
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009248 RID: 37448
			private static readonly IntPtr NativeFieldInfoPtr_sGuestDialogPackage;

			// Token: 0x04009249 RID: 37449
			private static readonly IntPtr NativeFieldInfoPtr_finishEventIsEmpty;

			// Token: 0x0400924A RID: 37450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400924B RID: 37451
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0;
		}

		// Token: 0x02000C6D RID: 3181
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.GeneralPublicExtraDialogData+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600E513 RID: 58643 RVA: 0x003708DC File Offset: 0x0036EADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr);
				GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_package = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "package");
				GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_finishEventIsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "finishEventIsEmpty");
				GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680896);
				GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__Play_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680897);
				GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__Play_b__1_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680898);
			}

			// Token: 0x0600E514 RID: 58644 RVA: 0x00370980 File Offset: 0x0036EB80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E515 RID: 58645 RVA: 0x003709BC File Offset: 0x0036EBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214575, XrefRangeEnd = 214579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Play_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__Play_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E516 RID: 58646 RVA: 0x003709F0 File Offset: 0x0036EBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214579, XrefRangeEnd = 214585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _Play_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__Play_b__1_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x0600E517 RID: 58647 RVA: 0x0007A49F File Offset: 0x0007869F
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A4F RID: 19023
			// (get) Token: 0x0600E518 RID: 58648 RVA: 0x00370A28 File Offset: 0x0036EC28
			// (set) Token: 0x0600E519 RID: 58649 RVA: 0x0007A4A8 File Offset: 0x000786A8
			public unsafe GeneralPublicExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralPublicExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A50 RID: 19024
			// (get) Token: 0x0600E51A RID: 58650 RVA: 0x00370A58 File Offset: 0x0036EC58
			// (set) Token: 0x0600E51B RID: 58651 RVA: 0x0007A4C7 File Offset: 0x000786C7
			public GeneralPublicExtraDialogData.SGuestDialogPackage package
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_package);
					return new GeneralPublicExtraDialogData.SGuestDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_package), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GeneralPublicExtraDialogData.SGuestDialogPackage>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A51 RID: 19025
			// (get) Token: 0x0600E51C RID: 58652 RVA: 0x00370A88 File Offset: 0x0036EC88
			// (set) Token: 0x0600E51D RID: 58653 RVA: 0x0007A4F5 File Offset: 0x000786F5
			public unsafe bool finishEventIsEmpty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_finishEventIsEmpty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_finishEventIsEmpty)) = value;
				}
			}

			// Token: 0x0400924C RID: 37452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400924D RID: 37453
			private static readonly IntPtr NativeFieldInfoPtr_package;

			// Token: 0x0400924E RID: 37454
			private static readonly IntPtr NativeFieldInfoPtr_finishEventIsEmpty;

			// Token: 0x0400924F RID: 37455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009250 RID: 37456
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Void_0;

			// Token: 0x04009251 RID: 37457
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__1_Internal_UniTask_0;

			// Token: 0x02001059 RID: 4185
			[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.GeneralPublicExtraDialogData+<>c__DisplayClass7_0+<<Play>b__1>d")]
			public sealed class __Play_b__1_d : ValueType
			{
				// Token: 0x06011E3D RID: 73277 RVA: 0x00417820 File Offset: 0x00415A20
				// Note: this type is marked as 'beforefieldinit'.
				static __Play_b__1_d()
				{
					Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<<Play>b__1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr);
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, "<>1__state");
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, "<>t__builder");
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, "<>4__this");
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, "<>8__1");
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, "<>u__1");
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, 100680899);
					GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr, 100680900);
				}

				// Token: 0x06011E3E RID: 73278 RVA: 0x004178D8 File Offset: 0x00415AD8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 214573, RefRangeEnd = 214575, XrefRangeStart = 214546, XrefRangeEnd = 214573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E3F RID: 73279 RVA: 0x00417910 File Offset: 0x00415B10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E40 RID: 73280 RVA: 0x0009B691 File Offset: 0x00099891
				public __Play_b__1_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06011E41 RID: 73281 RVA: 0x0009B69A File Offset: 0x0009989A
				public __Play_b__1_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005D40 RID: 23872
				// (get) Token: 0x06011E42 RID: 73282 RVA: 0x00417958 File Offset: 0x00415B58
				// (set) Token: 0x06011E43 RID: 73283 RVA: 0x0009B6AC File Offset: 0x000998AC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D41 RID: 23873
				// (get) Token: 0x06011E44 RID: 73284 RVA: 0x00417980 File Offset: 0x00415B80
				// (set) Token: 0x06011E45 RID: 73285 RVA: 0x0009B6C7 File Offset: 0x000998C7
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005D42 RID: 23874
				// (get) Token: 0x06011E46 RID: 73286 RVA: 0x004179B0 File Offset: 0x00415BB0
				// (set) Token: 0x06011E47 RID: 73287 RVA: 0x0009B6F5 File Offset: 0x000998F5
				public unsafe GeneralPublicExtraDialogData.__c__DisplayClass7_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralPublicExtraDialogData.__c__DisplayClass7_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D43 RID: 23875
				// (get) Token: 0x06011E48 RID: 73288 RVA: 0x004179E0 File Offset: 0x00415BE0
				// (set) Token: 0x06011E49 RID: 73289 RVA: 0x0009B714 File Offset: 0x00099914
				public unsafe GeneralPublicExtraDialogData.__c__DisplayClass7_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralPublicExtraDialogData.__c__DisplayClass7_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D44 RID: 23876
				// (get) Token: 0x06011E4A RID: 73290 RVA: 0x00417A10 File Offset: 0x00415C10
				// (set) Token: 0x06011E4B RID: 73291 RVA: 0x0009B733 File Offset: 0x00099933
				public UniTask<IAssetHandle<PlayableAsset>>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___u__1);
						return new UniTask<IAssetHandle<PlayableAsset>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<PlayableAsset>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_0.__Play_b__1_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<PlayableAsset>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B4CF RID: 46287
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4D0 RID: 46288
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B4D1 RID: 46289
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4D2 RID: 46290
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B4D3 RID: 46291
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B4D4 RID: 46292
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4D5 RID: 46293
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000C6E RID: 3182
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.GeneralPublicExtraDialogData+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : Object
		{
			// Token: 0x0600E51E RID: 58654 RVA: 0x00370AB0 File Offset: 0x0036ECB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralPublicExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr);
				GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "timeline");
				GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
				GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680901);
				GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__Play_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680902);
			}

			// Token: 0x0600E51F RID: 58655 RVA: 0x00370B2C File Offset: 0x0036ED2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralPublicExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E520 RID: 58656 RVA: 0x00370B68 File Offset: 0x0036ED68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214585, XrefRangeEnd = 214597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Play_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__Play_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E521 RID: 58657 RVA: 0x0007A510 File Offset: 0x00078710
			public __c__DisplayClass7_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A52 RID: 19026
			// (get) Token: 0x0600E522 RID: 58658 RVA: 0x00370B9C File Offset: 0x0036ED9C
			// (set) Token: 0x0600E523 RID: 58659 RVA: 0x0007A519 File Offset: 0x00078719
			public unsafe IAssetHandle<PlayableAsset> timeline
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_timeline);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<PlayableAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_timeline), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A53 RID: 19027
			// (get) Token: 0x0600E524 RID: 58660 RVA: 0x00370BCC File Offset: 0x0036EDCC
			// (set) Token: 0x0600E525 RID: 58661 RVA: 0x0007A538 File Offset: 0x00078738
			public unsafe GeneralPublicExtraDialogData.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralPublicExtraDialogData.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralPublicExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009252 RID: 37458
			private static readonly IntPtr NativeFieldInfoPtr_timeline;

			// Token: 0x04009253 RID: 37459
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;

			// Token: 0x04009254 RID: 37460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009255 RID: 37461
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__2_Internal_Void_0;
		}
	}
}
