using System;
using Common.CharacterUtility;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001AA RID: 426
	public class NormalGuestsController : GuestGroupController
	{
		// Token: 0x060030CE RID: 12494 RVA: 0x00142140 File Offset: 0x00140340
		// Note: this type is marked as 'beforefieldinit'.
		static NormalGuestsController()
		{
			Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "NormalGuestsController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr);
			NormalGuestsController.NativeFieldInfoPtr__NormalGuestsGroups_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<NormalGuestsGroups>k__BackingField");
			NormalGuestsController.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_NormalGuest_Nullable_1_Vector3_Action_1_AStarInputGeneratorComponent_LeaveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672072);
			NormalGuestsController.NativeMethodInfoPtr_get_NormalGuestsGroups_Public_get_Il2CppReferenceArray_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672073);
			NormalGuestsController.NativeMethodInfoPtr_get_EvaluateLikeFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672074);
			NormalGuestsController.NativeMethodInfoPtr_get_EvaluateHateFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672075);
			NormalGuestsController.NativeMethodInfoPtr_GetAllGuests_Public_Virtual_IEnumerable_1_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672076);
			NormalGuestsController.NativeMethodInfoPtr_OnGetGuestName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672077);
			NormalGuestsController.NativeMethodInfoPtr_OnRequestIdleDialog_Public_Virtual_String_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672078);
			NormalGuestsController.NativeMethodInfoPtr_GetNoMoneyDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672079);
			NormalGuestsController.NativeMethodInfoPtr_GetNoMoneyAngryDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672080);
			NormalGuestsController.NativeMethodInfoPtr_GetRepellDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672081);
			NormalGuestsController.NativeMethodInfoPtr_GetSeenRepellDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672082);
			NormalGuestsController.NativeMethodInfoPtr_GetEvaluationDialog_Protected_Virtual_String_Int32_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672083);
			NormalGuestsController.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672084);
			NormalGuestsController.NativeMethodInfoPtr_PostGenerateOrder_Public_Virtual_OrderBase_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672085);
			NormalGuestsController.NativeMethodInfoPtr_PostEvaluation_Public_Virtual_Void_EvaluationResult_Action_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672086);
			NormalGuestsController.NativeMethodInfoPtr_Method_Internal_Static_List_1_Recipe_IEnumerable_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672087);
			NormalGuestsController.NativeMethodInfoPtr_Method_Internal_Static_List_1_Sellable_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, 100672088);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x001422D8 File Offset: 0x001404D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 110593, RefRangeEnd = 110598, XrefRangeStart = 110498, XrefRangeEnd = 110593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalGuestsController(IEnumerable<NormalGuest> normalGuests, Nullable<Vector3> overrideSpawnPosition, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, GuestGroupController.LeaveType walkToLeave) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalGuests);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideSpawnPosition));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postprocessCharacterCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref walkToLeave;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_NormalGuest_Nullable_1_Vector3_Action_1_AStarInputGeneratorComponent_LeaveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x0014235C File Offset: 0x0014055C
		public unsafe Il2CppReferenceArray<NormalGuest> NormalGuestsGroups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.NativeMethodInfoPtr_get_NormalGuestsGroups_Public_get_Il2CppReferenceArray_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NormalGuest>>(intPtr3) : null;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x0014239C File Offset: 0x0014059C
		public unsafe override Il2CppStructArray<int> EvaluateLikeFoodTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110598, XrefRangeEnd = 110601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_get_EvaluateLikeFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x001423E8 File Offset: 0x001405E8
		public unsafe override Il2CppStructArray<int> EvaluateHateFoodTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110601, XrefRangeEnd = 110607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_get_EvaluateHateFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00142434 File Offset: 0x00140634
		[CallerCount(0)]
		public unsafe override IEnumerable<GuestBase> GetAllGuests()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_GetAllGuests_Public_Virtual_IEnumerable_1_GuestBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestBase>>(intPtr3) : null;
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00142480 File Offset: 0x00140680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110607, XrefRangeEnd = 110643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGetGuestName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_OnGetGuestName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x001424C4 File Offset: 0x001406C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110643, XrefRangeEnd = 110649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnRequestIdleDialog(out Transform speaker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_OnRequestIdleDialog_Public_Virtual_String_byref_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			speaker = ((intPtr4 == 0) ? null : new Transform(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00142528 File Offset: 0x00140728
		[CallerCount(0)]
		public unsafe override int GetNoMoneyDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_GetNoMoneyDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00142570 File Offset: 0x00140770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110649, XrefRangeEnd = 110656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNoMoneyAngryDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_GetNoMoneyAngryDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x001425B8 File Offset: 0x001407B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48392, RefRangeEnd = 48393, XrefRangeStart = 48392, XrefRangeEnd = 48393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetRepellDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_GetRepellDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x00142600 File Offset: 0x00140800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48412, RefRangeEnd = 48414, XrefRangeStart = 48412, XrefRangeEnd = 48414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetSeenRepellDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_GetSeenRepellDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x00142648 File Offset: 0x00140848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110656, XrefRangeEnd = 110662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEvaluationDialog(int evalulationIndex, out Transform speaker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evalulationIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_GetEvaluationDialog_Protected_Virtual_String_Int32_byref_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			speaker = ((intPtr4 == 0) ? null : new Transform(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x001426BC File Offset: 0x001408BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110662, XrefRangeEnd = 110798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00142700 File Offset: 0x00140900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110798, XrefRangeEnd = 110945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GuestsManager.OrderBase PostGenerateOrder(bool isFreeOrder, out string orderGenerationMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isFreeOrder;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_PostGenerateOrder_Public_Virtual_OrderBase_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x00142774 File Offset: 0x00140974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110945, XrefRangeEnd = 110958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostEvaluation(GuestGroupController.EvaluationResult evaluationType, Action onFinish, bool finishedByPartner, bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluationType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishedByPartner;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestsController.NativeMethodInfoPtr_PostEvaluation_Public_Virtual_Void_EvaluationResult_Action_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x001427EC File Offset: 0x001409EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110998, RefRangeEnd = 111000, XrefRangeStart = 110958, XrefRangeEnd = 110998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Recipe> Method_Internal_Static_List_1_Recipe_IEnumerable_1_Recipe_0(IEnumerable<Recipe> originList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.NativeMethodInfoPtr_Method_Internal_Static_List_1_Recipe_IEnumerable_1_Recipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr3) : null;
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x00142830 File Offset: 0x00140A30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111022, RefRangeEnd = 111025, XrefRangeStart = 111000, XrefRangeEnd = 111022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Sellable> Method_Internal_Static_List_1_Sellable_List_1_Sellable_0(List<Sellable> originList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.NativeMethodInfoPtr_Method_Internal_Static_List_1_Sellable_List_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr3) : null;
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0001BC50 File Offset: 0x00019E50
		public NormalGuestsController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x00142874 File Offset: 0x00140A74
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x0001BC59 File Offset: 0x00019E59
		public unsafe Il2CppReferenceArray<NormalGuest> _NormalGuestsGroups_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.NativeFieldInfoPtr__NormalGuestsGroups_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NormalGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.NativeFieldInfoPtr__NormalGuestsGroups_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestsGroups_k__BackingField;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_NormalGuest_Nullable_1_Vector3_Action_1_AStarInputGeneratorComponent_LeaveType_0;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestsGroups_Public_get_Il2CppReferenceArray_1_NormalGuest_0;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeMethodInfoPtr_get_EvaluateLikeFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeMethodInfoPtr_get_EvaluateHateFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeMethodInfoPtr_GetAllGuests_Public_Virtual_IEnumerable_1_GuestBase_0;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeMethodInfoPtr_OnGetGuestName_Public_Virtual_String_0;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeMethodInfoPtr_OnRequestIdleDialog_Public_Virtual_String_byref_Transform_0;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeMethodInfoPtr_GetNoMoneyDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeMethodInfoPtr_GetNoMoneyAngryDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeMethodInfoPtr_GetRepellDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeMethodInfoPtr_GetSeenRepellDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeMethodInfoPtr_GetEvaluationDialog_Protected_Virtual_String_Int32_byref_Transform_0;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_PostGenerateOrder_Public_Virtual_OrderBase_Boolean_byref_String_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr_PostEvaluation_Public_Virtual_Void_EvaluationResult_Action_Boolean_Boolean_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_List_1_Recipe_IEnumerable_1_Recipe_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_List_1_Sellable_List_1_Sellable_0;

		// Token: 0x02000850 RID: 2128
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600AD19 RID: 44313 RVA: 0x002C9C30 File Offset: 0x002C7E30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr);
				NormalGuestsController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__0_0");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__0_1");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__0_2");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__0_3");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__9_0");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__9_1");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__16_0");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__16_1");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__16_2");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__16_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__16_3");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_4");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_5");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_9");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_11");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_12");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_15");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_17");
				NormalGuestsController.__c.NativeFieldInfoPtr___9__17_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, "<>9__17_19");
				NormalGuestsController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672090);
				NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_CharacterSpriteSetCompact_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672091);
				NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_String_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672092);
				NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_2_Internal_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672093);
				NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_3_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672094);
				NormalGuestsController.__c.NativeMethodInfoPtr__OnGetGuestName_b__9_0_Internal_String_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672095);
				NormalGuestsController.__c.NativeMethodInfoPtr__OnGetGuestName_b__9_1_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672096);
				NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_0_Internal_String_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672097);
				NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_1_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672098);
				NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_2_Internal_String_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672099);
				NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_3_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672100);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_4_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672101);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_5_Internal_String_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672102);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_9_Internal_String_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672103);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_11_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672104);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_12_Internal_String_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672105);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_15_Internal_String_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672106);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_17_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672107);
				NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_19_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr, 100672108);
			}

			// Token: 0x0600AD1A RID: 44314 RVA: 0x002C9F54 File Offset: 0x002C8154
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD1B RID: 44315 RVA: 0x002C9F90 File Offset: 0x002C8190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110149, XrefRangeEnd = 110150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterSpriteSetCompact __ctor_b__0_0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_CharacterSpriteSetCompact_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
			}

			// Token: 0x0600AD1C RID: 44316 RVA: 0x002C9FE0 File Offset: 0x002C81E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__0_1(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_String_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD1D RID: 44317 RVA: 0x002CA028 File Offset: 0x002C8228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110150, XrefRangeEnd = 110152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __ctor_b__0_2(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_2_Internal_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD1E RID: 44318 RVA: 0x002CA078 File Offset: 0x002C8278
			[CallerCount(0)]
			public unsafe int __ctor_b__0_3(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr___ctor_b__0_3_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD1F RID: 44319 RVA: 0x002CA0D0 File Offset: 0x002C82D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnGetGuestName_b__9_0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__OnGetGuestName_b__9_0_Internal_String_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD20 RID: 44320 RVA: 0x002CA118 File Offset: 0x002C8318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110152, XrefRangeEnd = 110155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnGetGuestName_b__9_1(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__OnGetGuestName_b__9_1_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD21 RID: 44321 RVA: 0x002CA174 File Offset: 0x002C8374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110155, XrefRangeEnd = 110156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__16_0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_0_Internal_String_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD22 RID: 44322 RVA: 0x002CA1BC File Offset: 0x002C83BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110156, XrefRangeEnd = 110159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__16_1(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_1_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD23 RID: 44323 RVA: 0x002CA218 File Offset: 0x002C8418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__16_2(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_2_Internal_String_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD24 RID: 44324 RVA: 0x002CA260 File Offset: 0x002C8460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110159, XrefRangeEnd = 110162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__16_3(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__ToString_b__16_3_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD25 RID: 44325 RVA: 0x002CA2BC File Offset: 0x002C84BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110162, XrefRangeEnd = 110169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PostGenerateOrder_b__17_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_4_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD26 RID: 44326 RVA: 0x002CA300 File Offset: 0x002C8500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110169, XrefRangeEnd = 110180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PostGenerateOrder_b__17_5(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_5_Internal_String_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD27 RID: 44327 RVA: 0x002CA348 File Offset: 0x002C8548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110180, XrefRangeEnd = 110184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PostGenerateOrder_b__17_9(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_9_Internal_String_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD28 RID: 44328 RVA: 0x002CA390 File Offset: 0x002C8590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110184, XrefRangeEnd = 110191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PostGenerateOrder_b__17_11(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_11_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD29 RID: 44329 RVA: 0x002CA3D4 File Offset: 0x002C85D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110191, XrefRangeEnd = 110200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PostGenerateOrder_b__17_12(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_12_Internal_String_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD2A RID: 44330 RVA: 0x002CA41C File Offset: 0x002C861C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PostGenerateOrder_b__17_15(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_15_Internal_String_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AD2B RID: 44331 RVA: 0x002CA464 File Offset: 0x002C8664
			[CallerCount(0)]
			public unsafe int _PostGenerateOrder_b__17_17(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_17_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD2C RID: 44332 RVA: 0x002CA4B4 File Offset: 0x002C86B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110200, XrefRangeEnd = 110201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__17_19(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c.NativeMethodInfoPtr__PostGenerateOrder_b__17_19_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD2D RID: 44333 RVA: 0x0005D4E2 File Offset: 0x0005B6E2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038DB RID: 14555
			// (get) Token: 0x0600AD2E RID: 44334 RVA: 0x002CA504 File Offset: 0x002C8704
			// (set) Token: 0x0600AD2F RID: 44335 RVA: 0x0005D4EB File Offset: 0x0005B6EB
			public unsafe static NormalGuestsController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestsController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DC RID: 14556
			// (get) Token: 0x0600AD30 RID: 44336 RVA: 0x002CA52C File Offset: 0x002C872C
			// (set) Token: 0x0600AD31 RID: 44337 RVA: 0x0005D4FD File Offset: 0x0005B6FD
			public unsafe static Func<NormalGuest, CharacterSpriteSetCompact> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, CharacterSpriteSetCompact>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DD RID: 14557
			// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x002CA554 File Offset: 0x002C8754
			// (set) Token: 0x0600AD33 RID: 44339 RVA: 0x0005D50F File Offset: 0x0005B70F
			public unsafe static Func<NormalGuest, string> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DE RID: 14558
			// (get) Token: 0x0600AD34 RID: 44340 RVA: 0x002CA57C File Offset: 0x002C877C
			// (set) Token: 0x0600AD35 RID: 44341 RVA: 0x0005D521 File Offset: 0x0005B721
			public unsafe static Func<NormalGuest, int> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DF RID: 14559
			// (get) Token: 0x0600AD36 RID: 44342 RVA: 0x002CA5A4 File Offset: 0x002C87A4
			// (set) Token: 0x0600AD37 RID: 44343 RVA: 0x0005D533 File Offset: 0x0005B733
			public unsafe static Func<int, int, int> __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E0 RID: 14560
			// (get) Token: 0x0600AD38 RID: 44344 RVA: 0x002CA5CC File Offset: 0x002C87CC
			// (set) Token: 0x0600AD39 RID: 44345 RVA: 0x0005D545 File Offset: 0x0005B745
			public unsafe static Func<NormalGuest, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E1 RID: 14561
			// (get) Token: 0x0600AD3A RID: 44346 RVA: 0x002CA5F4 File Offset: 0x002C87F4
			// (set) Token: 0x0600AD3B RID: 44347 RVA: 0x0005D557 File Offset: 0x0005B757
			public unsafe static Func<string, string, string> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E2 RID: 14562
			// (get) Token: 0x0600AD3C RID: 44348 RVA: 0x002CA61C File Offset: 0x002C881C
			// (set) Token: 0x0600AD3D RID: 44349 RVA: 0x0005D569 File Offset: 0x0005B769
			public unsafe static Func<NormalGuest, string> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E3 RID: 14563
			// (get) Token: 0x0600AD3E RID: 44350 RVA: 0x002CA644 File Offset: 0x002C8844
			// (set) Token: 0x0600AD3F RID: 44351 RVA: 0x0005D57B File Offset: 0x0005B77B
			public unsafe static Func<string, string, string> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E4 RID: 14564
			// (get) Token: 0x0600AD40 RID: 44352 RVA: 0x002CA66C File Offset: 0x002C886C
			// (set) Token: 0x0600AD41 RID: 44353 RVA: 0x0005D58D File Offset: 0x0005B78D
			public unsafe static Func<GuestsManager.OrderBase, string> __9__16_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E5 RID: 14565
			// (get) Token: 0x0600AD42 RID: 44354 RVA: 0x002CA694 File Offset: 0x002C8894
			// (set) Token: 0x0600AD43 RID: 44355 RVA: 0x0005D59F File Offset: 0x0005B79F
			public unsafe static Func<string, string, string> __9__16_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__16_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E6 RID: 14566
			// (get) Token: 0x0600AD44 RID: 44356 RVA: 0x002CA6BC File Offset: 0x002C88BC
			// (set) Token: 0x0600AD45 RID: 44357 RVA: 0x0005D5B1 File Offset: 0x0005B7B1
			public unsafe static Func<int, string> __9__17_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E7 RID: 14567
			// (get) Token: 0x0600AD46 RID: 44358 RVA: 0x002CA6E4 File Offset: 0x002C88E4
			// (set) Token: 0x0600AD47 RID: 44359 RVA: 0x0005D5C3 File Offset: 0x0005B7C3
			public unsafe static Func<Recipe, string> __9__17_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E8 RID: 14568
			// (get) Token: 0x0600AD48 RID: 44360 RVA: 0x002CA70C File Offset: 0x002C890C
			// (set) Token: 0x0600AD49 RID: 44361 RVA: 0x0005D5D5 File Offset: 0x0005B7D5
			public unsafe static Func<Recipe, string> __9__17_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038E9 RID: 14569
			// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x002CA734 File Offset: 0x002C8934
			// (set) Token: 0x0600AD4B RID: 44363 RVA: 0x0005D5E7 File Offset: 0x0005B7E7
			public unsafe static Func<int, string> __9__17_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038EA RID: 14570
			// (get) Token: 0x0600AD4C RID: 44364 RVA: 0x002CA75C File Offset: 0x002C895C
			// (set) Token: 0x0600AD4D RID: 44365 RVA: 0x0005D5F9 File Offset: 0x0005B7F9
			public unsafe static Func<Sellable, string> __9__17_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038EB RID: 14571
			// (get) Token: 0x0600AD4E RID: 44366 RVA: 0x002CA784 File Offset: 0x002C8984
			// (set) Token: 0x0600AD4F RID: 44367 RVA: 0x0005D60B File Offset: 0x0005B80B
			public unsafe static Func<Sellable, string> __9__17_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038EC RID: 14572
			// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x002CA7AC File Offset: 0x002C89AC
			// (set) Token: 0x0600AD51 RID: 44369 RVA: 0x0005D61D File Offset: 0x0005B81D
			public unsafe static Func<Sellable, int> __9__17_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038ED RID: 14573
			// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x002CA7D4 File Offset: 0x002C89D4
			// (set) Token: 0x0600AD53 RID: 44371 RVA: 0x0005D62F File Offset: 0x0005B82F
			public unsafe static Func<Sellable, bool> __9__17_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestsController.__c.NativeFieldInfoPtr___9__17_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FB7 RID: 28599
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006FB8 RID: 28600
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04006FB9 RID: 28601
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04006FBA RID: 28602
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x04006FBB RID: 28603
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x04006FBC RID: 28604
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04006FBD RID: 28605
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04006FBE RID: 28606
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04006FBF RID: 28607
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x04006FC0 RID: 28608
			private static readonly IntPtr NativeFieldInfoPtr___9__16_2;

			// Token: 0x04006FC1 RID: 28609
			private static readonly IntPtr NativeFieldInfoPtr___9__16_3;

			// Token: 0x04006FC2 RID: 28610
			private static readonly IntPtr NativeFieldInfoPtr___9__17_4;

			// Token: 0x04006FC3 RID: 28611
			private static readonly IntPtr NativeFieldInfoPtr___9__17_5;

			// Token: 0x04006FC4 RID: 28612
			private static readonly IntPtr NativeFieldInfoPtr___9__17_9;

			// Token: 0x04006FC5 RID: 28613
			private static readonly IntPtr NativeFieldInfoPtr___9__17_11;

			// Token: 0x04006FC6 RID: 28614
			private static readonly IntPtr NativeFieldInfoPtr___9__17_12;

			// Token: 0x04006FC7 RID: 28615
			private static readonly IntPtr NativeFieldInfoPtr___9__17_15;

			// Token: 0x04006FC8 RID: 28616
			private static readonly IntPtr NativeFieldInfoPtr___9__17_17;

			// Token: 0x04006FC9 RID: 28617
			private static readonly IntPtr NativeFieldInfoPtr___9__17_19;

			// Token: 0x04006FCA RID: 28618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FCB RID: 28619
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_CharacterSpriteSetCompact_NormalGuest_0;

			// Token: 0x04006FCC RID: 28620
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_1_Internal_String_NormalGuest_0;

			// Token: 0x04006FCD RID: 28621
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_2_Internal_Int32_NormalGuest_0;

			// Token: 0x04006FCE RID: 28622
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_3_Internal_Int32_Int32_Int32_0;

			// Token: 0x04006FCF RID: 28623
			private static readonly IntPtr NativeMethodInfoPtr__OnGetGuestName_b__9_0_Internal_String_NormalGuest_0;

			// Token: 0x04006FD0 RID: 28624
			private static readonly IntPtr NativeMethodInfoPtr__OnGetGuestName_b__9_1_Internal_String_String_String_0;

			// Token: 0x04006FD1 RID: 28625
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__16_0_Internal_String_NormalGuest_0;

			// Token: 0x04006FD2 RID: 28626
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__16_1_Internal_String_String_String_0;

			// Token: 0x04006FD3 RID: 28627
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__16_2_Internal_String_OrderBase_0;

			// Token: 0x04006FD4 RID: 28628
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__16_3_Internal_String_String_String_0;

			// Token: 0x04006FD5 RID: 28629
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_4_Internal_String_Int32_0;

			// Token: 0x04006FD6 RID: 28630
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_5_Internal_String_Recipe_0;

			// Token: 0x04006FD7 RID: 28631
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_9_Internal_String_Recipe_0;

			// Token: 0x04006FD8 RID: 28632
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_11_Internal_String_Int32_0;

			// Token: 0x04006FD9 RID: 28633
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_12_Internal_String_Sellable_0;

			// Token: 0x04006FDA RID: 28634
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_15_Internal_String_Sellable_0;

			// Token: 0x04006FDB RID: 28635
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_17_Internal_Int32_Sellable_0;

			// Token: 0x04006FDC RID: 28636
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__17_19_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000851 RID: 2129
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AD54 RID: 44372 RVA: 0x002CA7FC File Offset: 0x002C89FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass17_0.NativeFieldInfoPtr_orderGenerationMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr, "orderGenerationMsg");
				NormalGuestsController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr, 100672109);
				NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Recipe_List_1_Recipe_NormalGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr, 100672110);
				NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr__PostGenerateOrder_b__8_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr, 100672111);
				NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Sellable_List_1_Sellable_NormalGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr, 100672112);
			}

			// Token: 0x0600AD55 RID: 44373 RVA: 0x002CA8A0 File Offset: 0x002C8AA0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD56 RID: 44374 RVA: 0x002CA8DC File Offset: 0x002C8ADC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110324, RefRangeEnd = 110325, XrefRangeStart = 110201, XrefRangeEnd = 110324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe Method_Internal_Recipe_List_1_Recipe_NormalGuest_Int32_0(List<Recipe> toFilter, NormalGuest source, int fund)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFilter);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fund;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Recipe_List_1_Recipe_NormalGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600AD57 RID: 44375 RVA: 0x002CA94C File Offset: 0x002C8B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110325, XrefRangeEnd = 110340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__8(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr__PostGenerateOrder_b__8_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD58 RID: 44376 RVA: 0x002CA99C File Offset: 0x002C8B9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110465, RefRangeEnd = 110466, XrefRangeStart = 110340, XrefRangeEnd = 110465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable Method_Internal_Sellable_List_1_Sellable_NormalGuest_Int32_0(List<Sellable> toFilter, NormalGuest source, int fund)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFilter);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fund;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Sellable_List_1_Sellable_NormalGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600AD59 RID: 44377 RVA: 0x0005D641 File Offset: 0x0005B841
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038EE RID: 14574
			// (get) Token: 0x0600AD5A RID: 44378 RVA: 0x002CAA0C File Offset: 0x002C8C0C
			// (set) Token: 0x0600AD5B RID: 44379 RVA: 0x0005D64A File Offset: 0x0005B84A
			public unsafe string orderGenerationMsg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_0.NativeFieldInfoPtr_orderGenerationMsg);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_0.NativeFieldInfoPtr_orderGenerationMsg), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038EF RID: 14575
			// (get) Token: 0x0600AD5C RID: 44380 RVA: 0x002CAA34 File Offset: 0x002C8C34
			// (set) Token: 0x0600AD5D RID: 44381 RVA: 0x0005D669 File Offset: 0x0005B869
			public unsafe NormalGuestsController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FDD RID: 28637
			private static readonly IntPtr NativeFieldInfoPtr_orderGenerationMsg;

			// Token: 0x04006FDE RID: 28638
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006FDF RID: 28639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FE0 RID: 28640
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Recipe_List_1_Recipe_NormalGuest_Int32_0;

			// Token: 0x04006FE1 RID: 28641
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__8_Internal_Boolean_Recipe_0;

			// Token: 0x04006FE2 RID: 28642
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Sellable_List_1_Sellable_NormalGuest_Int32_0;
		}

		// Token: 0x02000852 RID: 2130
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Il2CppSystem.Object
		{
			// Token: 0x0600AD5E RID: 44382 RVA: 0x002CAA64 File Offset: 0x002C8C64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass17_1.NativeFieldInfoPtr_fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr, "fund");
				NormalGuestsController.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr, 100672113);
				NormalGuestsController.__c__DisplayClass17_1.NativeMethodInfoPtr__PostGenerateOrder_b__6_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr, 100672114);
				NormalGuestsController.__c__DisplayClass17_1.NativeMethodInfoPtr__PostGenerateOrder_b__7_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr, 100672115);
			}

			// Token: 0x0600AD5F RID: 44383 RVA: 0x002CAAE0 File Offset: 0x002C8CE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD60 RID: 44384 RVA: 0x002CAB1C File Offset: 0x002C8D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110466, XrefRangeEnd = 110468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__6(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_1.NativeMethodInfoPtr__PostGenerateOrder_b__6_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD61 RID: 44385 RVA: 0x002CAB6C File Offset: 0x002C8D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__7(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_1.NativeMethodInfoPtr__PostGenerateOrder_b__7_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD62 RID: 44386 RVA: 0x0005D688 File Offset: 0x0005B888
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F0 RID: 14576
			// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x002CABBC File Offset: 0x002C8DBC
			// (set) Token: 0x0600AD64 RID: 44388 RVA: 0x0005D691 File Offset: 0x0005B891
			public unsafe int fund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_1.NativeFieldInfoPtr_fund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_1.NativeFieldInfoPtr_fund)) = value;
				}
			}

			// Token: 0x04006FE3 RID: 28643
			private static readonly IntPtr NativeFieldInfoPtr_fund;

			// Token: 0x04006FE4 RID: 28644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FE5 RID: 28645
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__6_Internal_Boolean_Recipe_0;

			// Token: 0x04006FE6 RID: 28646
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__7_Internal_Boolean_Recipe_0;
		}

		// Token: 0x02000853 RID: 2131
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass17_2")]
		public sealed class __c__DisplayClass17_2 : Il2CppSystem.Object
		{
			// Token: 0x0600AD65 RID: 44389 RVA: 0x002CABE4 File Offset: 0x002C8DE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_2()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass17_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_2>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass17_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_2>.NativeClassPtr, "x");
				NormalGuestsController.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_2>.NativeClassPtr, 100672116);
				NormalGuestsController.__c__DisplayClass17_2.NativeMethodInfoPtr__PostGenerateOrder_b__10_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_2>.NativeClassPtr, 100672117);
			}

			// Token: 0x0600AD66 RID: 44390 RVA: 0x002CAC4C File Offset: 0x002C8E4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD67 RID: 44391 RVA: 0x002CAC88 File Offset: 0x002C8E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110468, XrefRangeEnd = 110473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__10(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_2.NativeMethodInfoPtr__PostGenerateOrder_b__10_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD68 RID: 44392 RVA: 0x0005D6AC File Offset: 0x0005B8AC
			public __c__DisplayClass17_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F1 RID: 14577
			// (get) Token: 0x0600AD69 RID: 44393 RVA: 0x002CACD4 File Offset: 0x002C8ED4
			// (set) Token: 0x0600AD6A RID: 44394 RVA: 0x0005D6B5 File Offset: 0x0005B8B5
			public unsafe Recipe x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_2.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_2.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FE7 RID: 28647
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04006FE8 RID: 28648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FE9 RID: 28649
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__10_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000854 RID: 2132
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass17_3")]
		public sealed class __c__DisplayClass17_3 : Il2CppSystem.Object
		{
			// Token: 0x0600AD6B RID: 44395 RVA: 0x002CAD04 File Offset: 0x002C8F04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_3()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass17_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass17_3.NativeFieldInfoPtr_fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr, "fund");
				NormalGuestsController.__c__DisplayClass17_3.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr, "source");
				NormalGuestsController.__c__DisplayClass17_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr, 100672118);
				NormalGuestsController.__c__DisplayClass17_3.NativeMethodInfoPtr__PostGenerateOrder_b__13_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr, 100672119);
				NormalGuestsController.__c__DisplayClass17_3.NativeMethodInfoPtr__PostGenerateOrder_b__14_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr, 100672120);
			}

			// Token: 0x0600AD6C RID: 44396 RVA: 0x002CAD94 File Offset: 0x002C8F94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD6D RID: 44397 RVA: 0x002CADD0 File Offset: 0x002C8FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110473, XrefRangeEnd = 110474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__13(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_3.NativeMethodInfoPtr__PostGenerateOrder_b__13_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD6E RID: 44398 RVA: 0x002CAE20 File Offset: 0x002C9020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110474, XrefRangeEnd = 110490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__14(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_3.NativeMethodInfoPtr__PostGenerateOrder_b__14_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD6F RID: 44399 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
			public __c__DisplayClass17_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F2 RID: 14578
			// (get) Token: 0x0600AD70 RID: 44400 RVA: 0x002CAE70 File Offset: 0x002C9070
			// (set) Token: 0x0600AD71 RID: 44401 RVA: 0x0005D6DD File Offset: 0x0005B8DD
			public unsafe int fund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_3.NativeFieldInfoPtr_fund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_3.NativeFieldInfoPtr_fund)) = value;
				}
			}

			// Token: 0x170038F3 RID: 14579
			// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x002CAE98 File Offset: 0x002C9098
			// (set) Token: 0x0600AD73 RID: 44403 RVA: 0x0005D6F8 File Offset: 0x0005B8F8
			public unsafe NormalGuest source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_3.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_3.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FEA RID: 28650
			private static readonly IntPtr NativeFieldInfoPtr_fund;

			// Token: 0x04006FEB RID: 28651
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04006FEC RID: 28652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FED RID: 28653
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__13_Internal_Boolean_Sellable_0;

			// Token: 0x04006FEE RID: 28654
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__14_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000855 RID: 2133
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass17_4")]
		public sealed class __c__DisplayClass17_4 : Il2CppSystem.Object
		{
			// Token: 0x0600AD74 RID: 44404 RVA: 0x002CAEC8 File Offset: 0x002C90C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_4()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass17_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_4>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass17_4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_4>.NativeClassPtr, "x");
				NormalGuestsController.__c__DisplayClass17_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_4>.NativeClassPtr, 100672121);
				NormalGuestsController.__c__DisplayClass17_4.NativeMethodInfoPtr__PostGenerateOrder_b__16_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_4>.NativeClassPtr, 100672122);
			}

			// Token: 0x0600AD75 RID: 44405 RVA: 0x002CAF30 File Offset: 0x002C9130
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD76 RID: 44406 RVA: 0x002CAF6C File Offset: 0x002C916C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110490, XrefRangeEnd = 110494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__16(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_4.NativeMethodInfoPtr__PostGenerateOrder_b__16_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD77 RID: 44407 RVA: 0x0005D717 File Offset: 0x0005B917
			public __c__DisplayClass17_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F4 RID: 14580
			// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x002CAFB8 File Offset: 0x002C91B8
			// (set) Token: 0x0600AD79 RID: 44409 RVA: 0x0005D720 File Offset: 0x0005B920
			public unsafe Sellable x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_4.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_4.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FEF RID: 28655
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04006FF0 RID: 28656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FF1 RID: 28657
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__16_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000856 RID: 2134
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass17_5")]
		public sealed class __c__DisplayClass17_5 : Il2CppSystem.Object
		{
			// Token: 0x0600AD7A RID: 44410 RVA: 0x002CAFE8 File Offset: 0x002C91E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_5()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass17_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_5>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass17_5.NativeFieldInfoPtr_storedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_5>.NativeClassPtr, "storedFood");
				NormalGuestsController.__c__DisplayClass17_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_5>.NativeClassPtr, 100672123);
				NormalGuestsController.__c__DisplayClass17_5.NativeMethodInfoPtr__PostGenerateOrder_b__18_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_5>.NativeClassPtr, 100672124);
			}

			// Token: 0x0600AD7B RID: 44411 RVA: 0x002CB050 File Offset: 0x002C9250
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass17_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD7C RID: 44412 RVA: 0x002CB08C File Offset: 0x002C928C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110494, XrefRangeEnd = 110498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__18(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass17_5.NativeMethodInfoPtr__PostGenerateOrder_b__18_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD7D RID: 44413 RVA: 0x0005D73F File Offset: 0x0005B93F
			public __c__DisplayClass17_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F5 RID: 14581
			// (get) Token: 0x0600AD7E RID: 44414 RVA: 0x002CB0DC File Offset: 0x002C92DC
			// (set) Token: 0x0600AD7F RID: 44415 RVA: 0x0005D748 File Offset: 0x0005B948
			public unsafe IEnumerable<int> storedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_5.NativeFieldInfoPtr_storedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass17_5.NativeFieldInfoPtr_storedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FF2 RID: 28658
			private static readonly IntPtr NativeFieldInfoPtr_storedFood;

			// Token: 0x04006FF3 RID: 28659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FF4 RID: 28660
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__18_Internal_Boolean_Recipe_0;
		}

		// Token: 0x02000857 RID: 2135
		[ObfuscatedName("NightScene.GuestManagementUtility.NormalGuestsController+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AD80 RID: 44416 RVA: 0x002CB10C File Offset: 0x002C930C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestsController>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr);
				NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr_evaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr, "evaluationType");
				NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr_finishedByPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr, "finishedByPartner");
				NormalGuestsController.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr, 100672125);
				NormalGuestsController.__c__DisplayClass18_0.NativeMethodInfoPtr__PostEvaluation_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr, 100672126);
			}

			// Token: 0x0600AD81 RID: 44417 RVA: 0x002CB19C File Offset: 0x002C939C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestsController.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD82 RID: 44418 RVA: 0x002CB1D8 File Offset: 0x002C93D8
			[CallerCount(0)]
			public unsafe void _PostEvaluation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestsController.__c__DisplayClass18_0.NativeMethodInfoPtr__PostEvaluation_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD83 RID: 44419 RVA: 0x0005D767 File Offset: 0x0005B967
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F6 RID: 14582
			// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x002CB20C File Offset: 0x002C940C
			// (set) Token: 0x0600AD85 RID: 44421 RVA: 0x0005D770 File Offset: 0x0005B970
			public unsafe NormalGuestsController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038F7 RID: 14583
			// (get) Token: 0x0600AD86 RID: 44422 RVA: 0x002CB23C File Offset: 0x002C943C
			// (set) Token: 0x0600AD87 RID: 44423 RVA: 0x0005D78F File Offset: 0x0005B98F
			public unsafe GuestGroupController.EvaluationResult evaluationType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr_evaluationType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr_evaluationType)) = value;
				}
			}

			// Token: 0x170038F8 RID: 14584
			// (get) Token: 0x0600AD88 RID: 44424 RVA: 0x002CB264 File Offset: 0x002C9464
			// (set) Token: 0x0600AD89 RID: 44425 RVA: 0x0005D7AA File Offset: 0x0005B9AA
			public unsafe bool finishedByPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr_finishedByPartner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestsController.__c__DisplayClass18_0.NativeFieldInfoPtr_finishedByPartner)) = value;
				}
			}

			// Token: 0x04006FF5 RID: 28661
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006FF6 RID: 28662
			private static readonly IntPtr NativeFieldInfoPtr_evaluationType;

			// Token: 0x04006FF7 RID: 28663
			private static readonly IntPtr NativeFieldInfoPtr_finishedByPartner;

			// Token: 0x04006FF8 RID: 28664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FF9 RID: 28665
			private static readonly IntPtr NativeMethodInfoPtr__PostEvaluation_b__0_Internal_Void_0;
		}
	}
}
