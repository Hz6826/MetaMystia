using System;
using DayScene.UI;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000193 RID: 403
	public class NitoriTelephoneComponent : EntityBehaviourComponent
	{
		// Token: 0x06002B51 RID: 11089 RVA: 0x0012E314 File Offset: 0x0012C514
		// Note: this type is marked as 'beforefieldinit'.
		static NitoriTelephoneComponent()
		{
			Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "NitoriTelephoneComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr);
			NitoriTelephoneComponent.NativeFieldInfoPtr_ACTION_CONSUMPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "ACTION_CONSUMPTION");
			NitoriTelephoneComponent.NativeFieldInfoPtr_EndDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "EndDialog");
			NitoriTelephoneComponent.NativeFieldInfoPtr_openDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "openDialog");
			NitoriTelephoneComponent.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "mapLabel");
			NitoriTelephoneComponent.NativeFieldInfoPtr_extraMerchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "extraMerchantData");
			NitoriTelephoneComponent.NativeFieldInfoPtr_extraMerchantConditionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "extraMerchantConditionData");
			NitoriTelephoneComponent.NativeFieldInfoPtr_targetKizunaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "targetKizunaLevel");
			NitoriTelephoneComponent.NativeFieldInfoPtr_conditionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "conditionData");
			NitoriTelephoneComponent.NativeFieldInfoPtr_currentMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "currentMapLabel");
			NitoriTelephoneComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670805);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenFirstMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670806);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetOpenSpecialNPCSubMenuBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670807);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetOpenMerchantNPCSubMenuBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670808);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetMultiInviteFriendBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670809);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetTitle_Private_Static_String_IEnumerable_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670810);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetSubmitButtonAvailability_Private_Static_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670811);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetMultiCommitFriendBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670812);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetMultiBuyMerchantBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670813);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenSpecialNPCMapSelectionMenu_Private_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670814);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenMerchantNPCMapSelectionMenu_Private_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670815);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenSpecialNPCSelectionMenu_Private_Void_BaseInteractData_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670816);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetMerchantName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670817);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenMerchantNPCSelectionMenu_Private_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670818);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetSpecialGuestText_Private_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670819);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetMerchantName_Private_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670820);
			NitoriTelephoneComponent.NativeMethodInfoPtr_RefExtraMerchantData_Private_ExtraMerchantData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670821);
			NitoriTelephoneComponent.NativeMethodInfoPtr_CheckConditionMerchantDoSell_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670822);
			NitoriTelephoneComponent.NativeMethodInfoPtr_CheckExtraMerchantDoSell_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670823);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenExtraMerchantShop_Private_Void_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670824);
			NitoriTelephoneComponent.NativeMethodInfoPtr_GetKizunaLevel_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670825);
			NitoriTelephoneComponent.NativeMethodInfoPtr_Call_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670826);
			NitoriTelephoneComponent.NativeMethodInfoPtr_TryGoBack_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670827);
			NitoriTelephoneComponent.NativeMethodInfoPtr_OpenAfterChatMenu_Private_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670828);
			NitoriTelephoneComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670829);
			NitoriTelephoneComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670830);
			NitoriTelephoneComponent.NativeMethodInfoPtr_Method_Internal_Static_Int32_Product_TrackedMerchant_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670831);
			NitoriTelephoneComponent.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_byref___c__DisplayClass17_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670832);
			NitoriTelephoneComponent.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__19_0_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670833);
			NitoriTelephoneComponent.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_2_Private_Boolean_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, 100670834);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x0012E650 File Offset: 0x0012C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97069, XrefRangeEnd = 97090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriTelephoneComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x0012E68C File Offset: 0x0012C88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97141, RefRangeEnd = 97142, XrefRangeStart = 97090, XrefRangeEnd = 97141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFirstMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenFirstMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0012E6C0 File Offset: 0x0012C8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97142, XrefRangeEnd = 97159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOpenSpecialNPCSubMenuBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetOpenSpecialNPCSubMenuBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0012E750 File Offset: 0x0012C950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97159, XrefRangeEnd = 97176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOpenMerchantNPCSubMenuBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetOpenMerchantNPCSubMenuBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x0012E7E0 File Offset: 0x0012C9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97176, XrefRangeEnd = 97283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMultiInviteFriendBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetMultiInviteFriendBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x0012E870 File Offset: 0x0012CA70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97295, RefRangeEnd = 97297, XrefRangeStart = 97283, XrefRangeEnd = 97295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTitle(IEnumerable<Object> data, string title)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetTitle_Private_Static_String_IEnumerable_1_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0012E8C0 File Offset: 0x0012CAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97297, XrefRangeEnd = 97302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetSubmitButtonAvailability(ValueTuple<IEnumerable<Object>, bool> data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetSubmitButtonAvailability_Private_Static_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x0012E908 File Offset: 0x0012CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97302, XrefRangeEnd = 97345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMultiCommitFriendBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetMultiCommitFriendBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x0012E998 File Offset: 0x0012CB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97345, XrefRangeEnd = 97442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMultiBuyMerchantBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetMultiBuyMerchantBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x0012EA28 File Offset: 0x0012CC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97534, RefRangeEnd = 97535, XrefRangeStart = 97442, XrefRangeEnd = 97534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSpecialNPCMapSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenSpecialNPCMapSelectionMenu_Private_Void_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x0012EA6C File Offset: 0x0012CC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97638, RefRangeEnd = 97639, XrefRangeStart = 97535, XrefRangeEnd = 97638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenMerchantNPCMapSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenMerchantNPCMapSelectionMenu_Private_Void_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0012EAB0 File Offset: 0x0012CCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97721, RefRangeEnd = 97722, XrefRangeStart = 97639, XrefRangeEnd = 97721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSpecialNPCSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData, Action closeChatSelectionPannelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closeChatSelectionPannelCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenSpecialNPCSelectionMenu_Private_Void_BaseInteractData_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x0012EB04 File Offset: 0x0012CD04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97740, RefRangeEnd = 97742, XrefRangeStart = 97722, XrefRangeEnd = 97740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMerchantName(string targetNpcStrId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNpcStrId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetMerchantName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x0012EB4C File Offset: 0x0012CD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97852, RefRangeEnd = 97853, XrefRangeStart = 97742, XrefRangeEnd = 97852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenMerchantNPCSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenMerchantNPCSelectionMenu_Private_Void_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x0012EB90 File Offset: 0x0012CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97853, XrefRangeEnd = 97860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSpecialGuestText(Object id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetSpecialGuestText_Private_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0012EBD8 File Offset: 0x0012CDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97860, XrefRangeEnd = 97881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMerchantName(Object id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetMerchantName_Private_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0012EC20 File Offset: 0x0012CE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97881, XrefRangeEnd = 97898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtraMerchantData RefExtraMerchantData(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_RefExtraMerchantData_Private_ExtraMerchantData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ExtraMerchantData(pointer);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x0012EC68 File Offset: 0x0012CE68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97911, RefRangeEnd = 97913, XrefRangeStart = 97898, XrefRangeEnd = 97911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckConditionMerchantDoSell(string characterLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_CheckConditionMerchantDoSell_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x0012ECB8 File Offset: 0x0012CEB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97950, RefRangeEnd = 97951, XrefRangeStart = 97913, XrefRangeEnd = 97950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckExtraMerchantDoSell(string characterLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_CheckExtraMerchantDoSell_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x0012ED08 File Offset: 0x0012CF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97951, XrefRangeEnd = 97973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenExtraMerchantShop(string characterLabel, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenExtraMerchantShop_Private_Void_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x0012ED5C File Offset: 0x0012CF5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97977, RefRangeEnd = 97980, XrefRangeStart = 97973, XrefRangeEnd = 97977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetKizunaLevel(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_GetKizunaLevel_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0012EDA8 File Offset: 0x0012CFA8
		[CallerCount(0)]
		public unsafe void Call(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_Call_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x0012EDEC File Offset: 0x0012CFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97980, XrefRangeEnd = 97982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryGoBack(Action handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_TryGoBack_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0012EE30 File Offset: 0x0012D030
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 97996, RefRangeEnd = 98000, XrefRangeStart = 97982, XrefRangeEnd = 97996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAfterChatMenu(Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> selectionLists, string endKey, DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionLists);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_OpenAfterChatMenu_Private_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0012EE98 File Offset: 0x0012D098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98000, XrefRangeEnd = 98007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriTelephoneComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0012EED4 File Offset: 0x0012D0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98007, XrefRangeEnd = 98016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NitoriTelephoneComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x0012EF10 File Offset: 0x0012D110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98016, XrefRangeEnd = 98020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Product_TrackedMerchant_PDM_0(Product productData, TrackedMerchant merchantData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_Method_Internal_Static_Int32_Product_TrackedMerchant_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0012EF68 File Offset: 0x0012D168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98026, RefRangeEnd = 98028, XrefRangeStart = 98020, XrefRangeEnd = 98026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Int32_byref___c__DisplayClass17_3_0(int trueValue, ref NitoriTelephoneComponent.__c__DisplayClass17_3 A_1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trueValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_byref___c__DisplayClass17_3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0012EFB8 File Offset: 0x0012D1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98028, XrefRangeEnd = 98031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OpenMerchantNPCMapSelectionMenu_b__19_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__19_0_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x0012F008 File Offset: 0x0012D208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98031, XrefRangeEnd = 98032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OpenMerchantNPCSelectionMenu_b__22_2(ExtraMerchantData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_2_Private_Boolean_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000193B6 File Offset: 0x000175B6
		public NitoriTelephoneComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0012F05C File Offset: 0x0012D25C
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x000193BF File Offset: 0x000175BF
		public unsafe static int ACTION_CONSUMPTION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&value));
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x0012F078 File Offset: 0x0012D278
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x000193CD File Offset: 0x000175CD
		public unsafe Il2CppReferenceArray<DialogPackage> EndDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_EndDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_EndDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x0012F0A8 File Offset: 0x0012D2A8
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x000193EC File Offset: 0x000175EC
		public unsafe Il2CppReferenceArray<DialogPackage> openDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_openDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_openDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x0012F0D8 File Offset: 0x0012D2D8
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x0001940B File Offset: 0x0001760B
		public unsafe Il2CppStringArray mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_mapLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_mapLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x0012F108 File Offset: 0x0012D308
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x0001942A File Offset: 0x0001762A
		public unsafe Il2CppReferenceArray<ExtraMerchantData> extraMerchantData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_extraMerchantData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExtraMerchantData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_extraMerchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x0012F138 File Offset: 0x0012D338
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x00019449 File Offset: 0x00017649
		public unsafe Il2CppReferenceArray<ExtraMerchantConditionData> extraMerchantConditionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_extraMerchantConditionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExtraMerchantConditionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_extraMerchantConditionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x0012F168 File Offset: 0x0012D368
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x00019468 File Offset: 0x00017668
		public unsafe int targetKizunaLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_targetKizunaLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_targetKizunaLevel)) = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x0012F190 File Offset: 0x0012D390
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x00019483 File Offset: 0x00017683
		public unsafe Dictionary<string, ExtraMerchantConditionData> conditionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_conditionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ExtraMerchantConditionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_conditionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x0012F1C0 File Offset: 0x0012D3C0
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x000194A2 File Offset: 0x000176A2
		public unsafe string currentMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_currentMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.NativeFieldInfoPtr_currentMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_CONSUMPTION;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeFieldInfoPtr_EndDialog;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeFieldInfoPtr_openDialog;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr_extraMerchantData;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeFieldInfoPtr_extraMerchantConditionData;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeFieldInfoPtr_targetKizunaLevel;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeFieldInfoPtr_conditionData;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeFieldInfoPtr_currentMapLabel;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_OpenFirstMenu_Private_Void_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_GetOpenSpecialNPCSubMenuBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_GetOpenMerchantNPCSubMenuBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiInviteFriendBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_GetTitle_Private_Static_String_IEnumerable_1_Object_String_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_GetSubmitButtonAvailability_Private_Static_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiCommitFriendBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiBuyMerchantBtnConfig_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_OpenSpecialNPCMapSelectionMenu_Private_Void_BaseInteractData_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_OpenMerchantNPCMapSelectionMenu_Private_Void_BaseInteractData_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_OpenSpecialNPCSelectionMenu_Private_Void_BaseInteractData_Action_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_GetMerchantName_Private_String_String_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_OpenMerchantNPCSelectionMenu_Private_Void_BaseInteractData_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestText_Private_String_Object_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_GetMerchantName_Private_String_Object_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_RefExtraMerchantData_Private_ExtraMerchantData_String_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditionMerchantDoSell_Private_Boolean_String_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraMerchantDoSell_Private_Boolean_String_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_OpenExtraMerchantShop_Private_Void_String_Action_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_GetKizunaLevel_Private_Int32_Int32_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_Call_Private_Void_Action_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_TryGoBack_Private_Void_Action_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenu_Private_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_BaseInteractData_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Product_TrackedMerchant_PDM_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_byref___c__DisplayClass17_3_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__19_0_Private_Boolean_String_0;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_2_Private_Boolean_ExtraMerchantData_0;

		// Token: 0x020007C6 RID: 1990
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A5C4 RID: 42436 RVA: 0x002B41B8 File Offset: 0x002B23B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr);
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__9_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__13_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__13_1");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__13_3");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__13_4");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__13_6");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__13_10");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__16_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__16_2");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__17_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__17_2");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__17_8");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__17_11");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__17_12");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__18_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__19_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__19_2");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__20_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__22_0");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__22_1");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__22_3");
				NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, "<>9__22_5");
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670836);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OnInteract_b__9_0_Internal_String_ExtraMerchantConditionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670837);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_0_Internal_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670838);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670839);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_3_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670840);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670841);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_6_Internal_String_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670842);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_10_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670843);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__16_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670844);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__16_2_Internal_String_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670845);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_0_Internal_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670846);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_2_Internal_String_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670847);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_8_Internal_IEnumerable_1_Int32_KeyValuePair_2_TrackedMerchant_Il2CppReferenceArray_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670848);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_11_Internal_IEnumerable_1_Product_KeyValuePair_2_String_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670849);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_12_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670850);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__18_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670851);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__19_2_Internal_String_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670852);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__20_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670853);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670854);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670855);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_3_Internal_String_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670856);
				NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_5_Internal_String_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr, 100670857);
			}

			// Token: 0x0600A5C5 RID: 42437 RVA: 0x002B4554 File Offset: 0x002B2754
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5C6 RID: 42438 RVA: 0x002B4590 File Offset: 0x002B2790
			[CallerCount(0)]
			public unsafe string _OnInteract_b__9_0(ExtraMerchantConditionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OnInteract_b__9_0_Internal_String_ExtraMerchantConditionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5C7 RID: 42439 RVA: 0x002B45E0 File Offset: 0x002B27E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96259, XrefRangeEnd = 96264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> _GetMultiInviteFriendBtnConfig_b__13_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_0_Internal_IEnumerable_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}

			// Token: 0x0600A5C8 RID: 42440 RVA: 0x002B4630 File Offset: 0x002B2830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96264, XrefRangeEnd = 96265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMultiInviteFriendBtnConfig_b__13_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5C9 RID: 42441 RVA: 0x002B4680 File Offset: 0x002B2880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96265, XrefRangeEnd = 96269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetMultiInviteFriendBtnConfig_b__13_3(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_3_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5CA RID: 42442 RVA: 0x002B46D0 File Offset: 0x002B28D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96269, XrefRangeEnd = 96273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMultiInviteFriendBtnConfig_b__13_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5CB RID: 42443 RVA: 0x002B471C File Offset: 0x002B291C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96273, XrefRangeEnd = 96276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetMultiInviteFriendBtnConfig_b__13_6(IEnumerable<Object> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_6_Internal_String_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5CC RID: 42444 RVA: 0x002B4764 File Offset: 0x002B2964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96276, XrefRangeEnd = 96281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiInviteFriendBtnConfig_b__13_10(int z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref z;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_10_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5CD RID: 42445 RVA: 0x002B47A4 File Offset: 0x002B29A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96281, XrefRangeEnd = 96303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMultiCommitFriendBtnConfig_b__16_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__16_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5CE RID: 42446 RVA: 0x002B47F0 File Offset: 0x002B29F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96303, XrefRangeEnd = 96306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetMultiCommitFriendBtnConfig_b__16_2(IEnumerable<Object> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__16_2_Internal_String_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5CF RID: 42447 RVA: 0x002B4838 File Offset: 0x002B2A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96306, XrefRangeEnd = 96311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> _GetMultiBuyMerchantBtnConfig_b__17_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_0_Internal_IEnumerable_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}

			// Token: 0x0600A5D0 RID: 42448 RVA: 0x002B4888 File Offset: 0x002B2A88
			[CallerCount(0)]
			public unsafe string _GetMultiBuyMerchantBtnConfig_b__17_2(ExtraMerchantData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_2_Internal_String_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5D1 RID: 42449 RVA: 0x002B48D8 File Offset: 0x002B2AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96311, XrefRangeEnd = 96327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GetMultiBuyMerchantBtnConfig_b__17_8(KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_8_Internal_IEnumerable_1_Int32_KeyValuePair_2_TrackedMerchant_Il2CppReferenceArray_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600A5D2 RID: 42450 RVA: 0x002B4930 File Offset: 0x002B2B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96327, XrefRangeEnd = 96328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Product> _GetMultiBuyMerchantBtnConfig_b__17_11(KeyValuePair<string, List<Product>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_11_Internal_IEnumerable_1_Product_KeyValuePair_2_String_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Product>>(intPtr3) : null;
			}

			// Token: 0x0600A5D3 RID: 42451 RVA: 0x002B4988 File Offset: 0x002B2B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiBuyMerchantBtnConfig_b__17_12(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_12_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5D4 RID: 42452 RVA: 0x002B49D0 File Offset: 0x002B2BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenSpecialNPCMapSelectionMenu_b__18_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__18_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5D5 RID: 42453 RVA: 0x002B4A20 File Offset: 0x002B2C20
			[CallerCount(0)]
			public unsafe string _OpenMerchantNPCMapSelectionMenu_b__19_2(ExtraMerchantData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__19_2_Internal_String_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5D6 RID: 42454 RVA: 0x002B4A70 File Offset: 0x002B2C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenSpecialNPCSelectionMenu_b__20_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__20_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5D7 RID: 42455 RVA: 0x002B4AC0 File Offset: 0x002B2CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96328, XrefRangeEnd = 96329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenMerchantNPCSelectionMenu_b__22_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5D8 RID: 42456 RVA: 0x002B4B10 File Offset: 0x002B2D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96329, XrefRangeEnd = 96330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenMerchantNPCSelectionMenu_b__22_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5D9 RID: 42457 RVA: 0x002B4B60 File Offset: 0x002B2D60
			[CallerCount(0)]
			public unsafe string _OpenMerchantNPCSelectionMenu_b__22_3(ExtraMerchantData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_3_Internal_String_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5DA RID: 42458 RVA: 0x002B4BB0 File Offset: 0x002B2DB0
			[CallerCount(0)]
			public unsafe string _OpenMerchantNPCSelectionMenu_b__22_5(ExtraMerchantData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_5_Internal_String_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A5DB RID: 42459 RVA: 0x000599CD File Offset: 0x00057BCD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003696 RID: 13974
			// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x002B4C00 File Offset: 0x002B2E00
			// (set) Token: 0x0600A5DD RID: 42461 RVA: 0x000599D6 File Offset: 0x00057BD6
			public unsafe static NitoriTelephoneComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003697 RID: 13975
			// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x002B4C28 File Offset: 0x002B2E28
			// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x000599E8 File Offset: 0x00057BE8
			public unsafe static Func<ExtraMerchantConditionData, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExtraMerchantConditionData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003698 RID: 13976
			// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x002B4C50 File Offset: 0x002B2E50
			// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x000599FA File Offset: 0x00057BFA
			public unsafe static Func<string, IEnumerable<string>> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, IEnumerable<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003699 RID: 13977
			// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002B4C78 File Offset: 0x002B2E78
			// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x00059A0C File Offset: 0x00057C0C
			public unsafe static Func<string, bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369A RID: 13978
			// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x002B4CA0 File Offset: 0x002B2EA0
			// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x00059A1E File Offset: 0x00057C1E
			public unsafe static Func<string, int> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369B RID: 13979
			// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x002B4CC8 File Offset: 0x002B2EC8
			// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x00059A30 File Offset: 0x00057C30
			public unsafe static Func<int, bool> __9__13_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369C RID: 13980
			// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x002B4CF0 File Offset: 0x002B2EF0
			// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x00059A42 File Offset: 0x00057C42
			public unsafe static Func<IEnumerable<Object>, string> __9__13_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369D RID: 13981
			// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x002B4D18 File Offset: 0x002B2F18
			// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x00059A54 File Offset: 0x00057C54
			public unsafe static Action<int> __9__13_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__13_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369E RID: 13982
			// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x002B4D40 File Offset: 0x002B2F40
			// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x00059A66 File Offset: 0x00057C66
			public unsafe static Func<int, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369F RID: 13983
			// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x002B4D68 File Offset: 0x002B2F68
			// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x00059A78 File Offset: 0x00057C78
			public unsafe static Func<IEnumerable<Object>, string> __9__16_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__16_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__16_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A0 RID: 13984
			// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x002B4D90 File Offset: 0x002B2F90
			// (set) Token: 0x0600A5F1 RID: 42481 RVA: 0x00059A8A File Offset: 0x00057C8A
			public unsafe static Func<string, IEnumerable<string>> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, IEnumerable<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A1 RID: 13985
			// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x002B4DB8 File Offset: 0x002B2FB8
			// (set) Token: 0x0600A5F3 RID: 42483 RVA: 0x00059A9C File Offset: 0x00057C9C
			public unsafe static Func<ExtraMerchantData, string> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExtraMerchantData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A2 RID: 13986
			// (get) Token: 0x0600A5F4 RID: 42484 RVA: 0x002B4DE0 File Offset: 0x002B2FE0
			// (set) Token: 0x0600A5F5 RID: 42485 RVA: 0x00059AAE File Offset: 0x00057CAE
			public unsafe static Func<KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>>, IEnumerable<int>> __9__17_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A3 RID: 13987
			// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x002B4E08 File Offset: 0x002B3008
			// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x00059AC0 File Offset: 0x00057CC0
			public unsafe static Func<KeyValuePair<string, List<Product>>, IEnumerable<Product>> __9__17_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<Product>>, IEnumerable<Product>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A4 RID: 13988
			// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x002B4E30 File Offset: 0x002B3030
			// (set) Token: 0x0600A5F9 RID: 42489 RVA: 0x00059AD2 File Offset: 0x00057CD2
			public unsafe static Action<Product> __9__17_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__17_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A5 RID: 13989
			// (get) Token: 0x0600A5FA RID: 42490 RVA: 0x002B4E58 File Offset: 0x002B3058
			// (set) Token: 0x0600A5FB RID: 42491 RVA: 0x00059AE4 File Offset: 0x00057CE4
			public unsafe static Func<string, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A6 RID: 13990
			// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x002B4E80 File Offset: 0x002B3080
			// (set) Token: 0x0600A5FD RID: 42493 RVA: 0x00059AF6 File Offset: 0x00057CF6
			public unsafe static Func<ExtraMerchantData, string> __9__19_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__19_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExtraMerchantData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__19_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A7 RID: 13991
			// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x002B4EA8 File Offset: 0x002B30A8
			// (set) Token: 0x0600A5FF RID: 42495 RVA: 0x00059B08 File Offset: 0x00057D08
			public unsafe static Func<string, bool> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A8 RID: 13992
			// (get) Token: 0x0600A600 RID: 42496 RVA: 0x002B4ED0 File Offset: 0x002B30D0
			// (set) Token: 0x0600A601 RID: 42497 RVA: 0x00059B1A File Offset: 0x00057D1A
			public unsafe static Func<string, bool> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A9 RID: 13993
			// (get) Token: 0x0600A602 RID: 42498 RVA: 0x002B4EF8 File Offset: 0x002B30F8
			// (set) Token: 0x0600A603 RID: 42499 RVA: 0x00059B2C File Offset: 0x00057D2C
			public unsafe static Func<string, bool> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AA RID: 13994
			// (get) Token: 0x0600A604 RID: 42500 RVA: 0x002B4F20 File Offset: 0x002B3120
			// (set) Token: 0x0600A605 RID: 42501 RVA: 0x00059B3E File Offset: 0x00057D3E
			public unsafe static Func<ExtraMerchantData, string> __9__22_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExtraMerchantData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AB RID: 13995
			// (get) Token: 0x0600A606 RID: 42502 RVA: 0x002B4F48 File Offset: 0x002B3148
			// (set) Token: 0x0600A607 RID: 42503 RVA: 0x00059B50 File Offset: 0x00057D50
			public unsafe static Func<ExtraMerchantData, string> __9__22_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExtraMerchantData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriTelephoneComponent.__c.NativeFieldInfoPtr___9__22_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B32 RID: 27442
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006B33 RID: 27443
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04006B34 RID: 27444
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04006B35 RID: 27445
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04006B36 RID: 27446
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x04006B37 RID: 27447
			private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

			// Token: 0x04006B38 RID: 27448
			private static readonly IntPtr NativeFieldInfoPtr___9__13_6;

			// Token: 0x04006B39 RID: 27449
			private static readonly IntPtr NativeFieldInfoPtr___9__13_10;

			// Token: 0x04006B3A RID: 27450
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04006B3B RID: 27451
			private static readonly IntPtr NativeFieldInfoPtr___9__16_2;

			// Token: 0x04006B3C RID: 27452
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04006B3D RID: 27453
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04006B3E RID: 27454
			private static readonly IntPtr NativeFieldInfoPtr___9__17_8;

			// Token: 0x04006B3F RID: 27455
			private static readonly IntPtr NativeFieldInfoPtr___9__17_11;

			// Token: 0x04006B40 RID: 27456
			private static readonly IntPtr NativeFieldInfoPtr___9__17_12;

			// Token: 0x04006B41 RID: 27457
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04006B42 RID: 27458
			private static readonly IntPtr NativeFieldInfoPtr___9__19_2;

			// Token: 0x04006B43 RID: 27459
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04006B44 RID: 27460
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04006B45 RID: 27461
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x04006B46 RID: 27462
			private static readonly IntPtr NativeFieldInfoPtr___9__22_3;

			// Token: 0x04006B47 RID: 27463
			private static readonly IntPtr NativeFieldInfoPtr___9__22_5;

			// Token: 0x04006B48 RID: 27464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B49 RID: 27465
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__9_0_Internal_String_ExtraMerchantConditionData_0;

			// Token: 0x04006B4A RID: 27466
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_0_Internal_IEnumerable_1_String_String_0;

			// Token: 0x04006B4B RID: 27467
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_1_Internal_Boolean_String_0;

			// Token: 0x04006B4C RID: 27468
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_3_Internal_Int32_String_0;

			// Token: 0x04006B4D RID: 27469
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_4_Internal_Boolean_Int32_0;

			// Token: 0x04006B4E RID: 27470
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_6_Internal_String_IEnumerable_1_Object_0;

			// Token: 0x04006B4F RID: 27471
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__13_10_Internal_Void_Int32_0;

			// Token: 0x04006B50 RID: 27472
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__16_0_Internal_Boolean_Int32_0;

			// Token: 0x04006B51 RID: 27473
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__16_2_Internal_String_IEnumerable_1_Object_0;

			// Token: 0x04006B52 RID: 27474
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_0_Internal_IEnumerable_1_String_String_0;

			// Token: 0x04006B53 RID: 27475
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_2_Internal_String_ExtraMerchantData_0;

			// Token: 0x04006B54 RID: 27476
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_8_Internal_IEnumerable_1_Int32_KeyValuePair_2_TrackedMerchant_Il2CppReferenceArray_1_Product_0;

			// Token: 0x04006B55 RID: 27477
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_11_Internal_IEnumerable_1_Product_KeyValuePair_2_String_List_1_Product_0;

			// Token: 0x04006B56 RID: 27478
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__17_12_Internal_Void_Product_0;

			// Token: 0x04006B57 RID: 27479
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__18_0_Internal_Boolean_String_0;

			// Token: 0x04006B58 RID: 27480
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__19_2_Internal_String_ExtraMerchantData_0;

			// Token: 0x04006B59 RID: 27481
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__20_0_Internal_Boolean_String_0;

			// Token: 0x04006B5A RID: 27482
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_0_Internal_Boolean_String_0;

			// Token: 0x04006B5B RID: 27483
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_1_Internal_Boolean_String_0;

			// Token: 0x04006B5C RID: 27484
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_3_Internal_String_ExtraMerchantData_0;

			// Token: 0x04006B5D RID: 27485
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__22_5_Internal_String_ExtraMerchantData_0;
		}

		// Token: 0x020007C7 RID: 1991
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600A608 RID: 42504 RVA: 0x002B4F70 File Offset: 0x002B3170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr, "baseInteractData");
				NitoriTelephoneComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr, 100670858);
				NitoriTelephoneComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__GetOpenSpecialNPCSubMenuBtnConfig_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr, 100670859);
			}

			// Token: 0x0600A609 RID: 42505 RVA: 0x002B4FEC File Offset: 0x002B31EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A60A RID: 42506 RVA: 0x002B5028 File Offset: 0x002B3228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96330, XrefRangeEnd = 96332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetOpenSpecialNPCSubMenuBtnConfig_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__GetOpenSpecialNPCSubMenuBtnConfig_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A60B RID: 42507 RVA: 0x00059B62 File Offset: 0x00057D62
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036AC RID: 13996
			// (get) Token: 0x0600A60C RID: 42508 RVA: 0x002B505C File Offset: 0x002B325C
			// (set) Token: 0x0600A60D RID: 42509 RVA: 0x00059B6B File Offset: 0x00057D6B
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AD RID: 13997
			// (get) Token: 0x0600A60E RID: 42510 RVA: 0x002B508C File Offset: 0x002B328C
			// (set) Token: 0x0600A60F RID: 42511 RVA: 0x00059B8A File Offset: 0x00057D8A
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B5E RID: 27486
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B5F RID: 27487
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006B60 RID: 27488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B61 RID: 27489
			private static readonly IntPtr NativeMethodInfoPtr__GetOpenSpecialNPCSubMenuBtnConfig_b__0_Internal_Void_0;
		}

		// Token: 0x020007C8 RID: 1992
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600A610 RID: 42512 RVA: 0x002B50BC File Offset: 0x002B32BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass12_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr, "baseInteractData");
				NitoriTelephoneComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr, 100670860);
				NitoriTelephoneComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__GetOpenMerchantNPCSubMenuBtnConfig_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr, 100670861);
			}

			// Token: 0x0600A611 RID: 42513 RVA: 0x002B5138 File Offset: 0x002B3338
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A612 RID: 42514 RVA: 0x002B5174 File Offset: 0x002B3374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96332, XrefRangeEnd = 96334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetOpenMerchantNPCSubMenuBtnConfig_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__GetOpenMerchantNPCSubMenuBtnConfig_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A613 RID: 42515 RVA: 0x00059BA9 File Offset: 0x00057DA9
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036AE RID: 13998
			// (get) Token: 0x0600A614 RID: 42516 RVA: 0x002B51A8 File Offset: 0x002B33A8
			// (set) Token: 0x0600A615 RID: 42517 RVA: 0x00059BB2 File Offset: 0x00057DB2
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AF RID: 13999
			// (get) Token: 0x0600A616 RID: 42518 RVA: 0x002B51D8 File Offset: 0x002B33D8
			// (set) Token: 0x0600A617 RID: 42519 RVA: 0x00059BD1 File Offset: 0x00057DD1
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass12_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass12_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B62 RID: 27490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B63 RID: 27491
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006B64 RID: 27492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B65 RID: 27493
			private static readonly IntPtr NativeMethodInfoPtr__GetOpenMerchantNPCSubMenuBtnConfig_b__0_Internal_Void_0;
		}

		// Token: 0x020007C9 RID: 1993
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600A618 RID: 42520 RVA: 0x002B5208 File Offset: 0x002B3408
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_allFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, "allFriends");
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, "baseInteractData");
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, 100670862);
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__2_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, 100670863);
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, 100670864);
				NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr, 100670865);
			}

			// Token: 0x0600A619 RID: 42521 RVA: 0x002B52C0 File Offset: 0x002B34C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A61A RID: 42522 RVA: 0x002B52FC File Offset: 0x002B34FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96334, XrefRangeEnd = 96351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMultiInviteFriendBtnConfig_b__2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__2_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A61B RID: 42523 RVA: 0x002B534C File Offset: 0x002B354C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96351, XrefRangeEnd = 96417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiInviteFriendBtnConfig_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A61C RID: 42524 RVA: 0x002B5380 File Offset: 0x002B3580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96417, XrefRangeEnd = 96456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0(Il2CppStructArray<int> inviteGuestId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inviteGuestId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A61D RID: 42525 RVA: 0x00059BF0 File Offset: 0x00057DF0
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036B0 RID: 14000
			// (get) Token: 0x0600A61E RID: 42526 RVA: 0x002B53C4 File Offset: 0x002B35C4
			// (set) Token: 0x0600A61F RID: 42527 RVA: 0x00059BF9 File Offset: 0x00057DF9
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B1 RID: 14001
			// (get) Token: 0x0600A620 RID: 42528 RVA: 0x002B53F4 File Offset: 0x002B35F4
			// (set) Token: 0x0600A621 RID: 42529 RVA: 0x00059C18 File Offset: 0x00057E18
			public unsafe Il2CppStructArray<int> allFriends
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_allFriends);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_allFriends), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B2 RID: 14002
			// (get) Token: 0x0600A622 RID: 42530 RVA: 0x002B5424 File Offset: 0x002B3624
			// (set) Token: 0x0600A623 RID: 42531 RVA: 0x00059C37 File Offset: 0x00057E37
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B66 RID: 27494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B67 RID: 27495
			private static readonly IntPtr NativeFieldInfoPtr_allFriends;

			// Token: 0x04006B68 RID: 27496
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006B69 RID: 27497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B6A RID: 27498
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__2_Internal_Boolean_String_0;

			// Token: 0x04006B6B RID: 27499
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__5_Internal_Void_0;

			// Token: 0x04006B6C RID: 27500
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0;
		}

		// Token: 0x020007CA RID: 1994
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : Object
		{
			// Token: 0x0600A624 RID: 42532 RVA: 0x002B5454 File Offset: 0x002B3654
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_endDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr, "endDialogs");
				NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_successInvitedId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr, "successInvitedId");
				NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr, 100670866);
				NitoriTelephoneComponent.__c__DisplayClass13_1.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__8_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr, 100670867);
			}

			// Token: 0x0600A625 RID: 42533 RVA: 0x002B54E4 File Offset: 0x002B36E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A626 RID: 42534 RVA: 0x002B5520 File Offset: 0x002B3720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96456, XrefRangeEnd = 96505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiInviteFriendBtnConfig_b__8(Action y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__8_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A627 RID: 42535 RVA: 0x00059C56 File Offset: 0x00057E56
			public __c__DisplayClass13_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036B3 RID: 14003
			// (get) Token: 0x0600A628 RID: 42536 RVA: 0x002B5564 File Offset: 0x002B3764
			// (set) Token: 0x0600A629 RID: 42537 RVA: 0x00059C5F File Offset: 0x00057E5F
			public unsafe Queue<DialogPackage> endDialogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_endDialogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_endDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B4 RID: 14004
			// (get) Token: 0x0600A62A RID: 42538 RVA: 0x002B5594 File Offset: 0x002B3794
			// (set) Token: 0x0600A62B RID: 42539 RVA: 0x00059C7E File Offset: 0x00057E7E
			public unsafe List<int> successInvitedId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_successInvitedId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_successInvitedId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B5 RID: 14005
			// (get) Token: 0x0600A62C RID: 42540 RVA: 0x002B55C4 File Offset: 0x002B37C4
			// (set) Token: 0x0600A62D RID: 42541 RVA: 0x00059C9D File Offset: 0x00057E9D
			public unsafe NitoriTelephoneComponent.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B6D RID: 27501
			private static readonly IntPtr NativeFieldInfoPtr_endDialogs;

			// Token: 0x04006B6E RID: 27502
			private static readonly IntPtr NativeFieldInfoPtr_successInvitedId;

			// Token: 0x04006B6F RID: 27503
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x04006B70 RID: 27504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B71 RID: 27505
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiInviteFriendBtnConfig_b__8_Internal_Void_Action_0;
		}

		// Token: 0x020007CB RID: 1995
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass13_2")]
		public sealed class __c__DisplayClass13_2 : Object
		{
			// Token: 0x0600A62E RID: 42542 RVA: 0x002B55F4 File Offset: 0x002B37F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_2()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass13_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass13_2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr, "y");
				NitoriTelephoneComponent.__c__DisplayClass13_2.NativeFieldInfoPtr_field_Public___c__DisplayClass13_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr, "CS$<>8__locals2");
				NitoriTelephoneComponent.__c__DisplayClass13_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr, 100670868);
				NitoriTelephoneComponent.__c__DisplayClass13_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr, 100670869);
			}

			// Token: 0x0600A62F RID: 42543 RVA: 0x002B5670 File Offset: 0x002B3870
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass13_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A630 RID: 42544 RVA: 0x002B56AC File Offset: 0x002B38AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96505, XrefRangeEnd = 96524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass13_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A631 RID: 42545 RVA: 0x00059CBC File Offset: 0x00057EBC
			public __c__DisplayClass13_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036B6 RID: 14006
			// (get) Token: 0x0600A632 RID: 42546 RVA: 0x002B56E0 File Offset: 0x002B38E0
			// (set) Token: 0x0600A633 RID: 42547 RVA: 0x00059CC5 File Offset: 0x00057EC5
			public unsafe Action y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_2.NativeFieldInfoPtr_y);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_2.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B7 RID: 14007
			// (get) Token: 0x0600A634 RID: 42548 RVA: 0x002B5710 File Offset: 0x002B3910
			// (set) Token: 0x0600A635 RID: 42549 RVA: 0x00059CE4 File Offset: 0x00057EE4
			public unsafe NitoriTelephoneComponent.__c__DisplayClass13_1 field_Public___c__DisplayClass13_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_2.NativeFieldInfoPtr_field_Public___c__DisplayClass13_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass13_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass13_2.NativeFieldInfoPtr_field_Public___c__DisplayClass13_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B72 RID: 27506
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04006B73 RID: 27507
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_1_0;

			// Token: 0x04006B74 RID: 27508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B75 RID: 27509
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020007CC RID: 1996
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600A636 RID: 42550 RVA: 0x002B5740 File Offset: 0x002B3940
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_allFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr, "allFriends");
				NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr, "baseInteractData");
				NitoriTelephoneComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr, 100670870);
				NitoriTelephoneComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr, 100670871);
				NitoriTelephoneComponent.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr, 100670872);
			}

			// Token: 0x0600A637 RID: 42551 RVA: 0x002B57E4 File Offset: 0x002B39E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A638 RID: 42552 RVA: 0x002B5820 File Offset: 0x002B3A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96524, XrefRangeEnd = 96590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiCommitFriendBtnConfig_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A639 RID: 42553 RVA: 0x002B5854 File Offset: 0x002B3A54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96590, XrefRangeEnd = 96622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0(Il2CppStructArray<int> inviteGuestId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inviteGuestId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A63A RID: 42554 RVA: 0x00059D03 File Offset: 0x00057F03
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036B8 RID: 14008
			// (get) Token: 0x0600A63B RID: 42555 RVA: 0x002B5898 File Offset: 0x002B3A98
			// (set) Token: 0x0600A63C RID: 42556 RVA: 0x00059D0C File Offset: 0x00057F0C
			public unsafe Il2CppStructArray<int> allFriends
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_allFriends);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_allFriends), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B9 RID: 14009
			// (get) Token: 0x0600A63D RID: 42557 RVA: 0x002B58C8 File Offset: 0x002B3AC8
			// (set) Token: 0x0600A63E RID: 42558 RVA: 0x00059D2B File Offset: 0x00057F2B
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036BA RID: 14010
			// (get) Token: 0x0600A63F RID: 42559 RVA: 0x002B58F8 File Offset: 0x002B3AF8
			// (set) Token: 0x0600A640 RID: 42560 RVA: 0x00059D4A File Offset: 0x00057F4A
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B76 RID: 27510
			private static readonly IntPtr NativeFieldInfoPtr_allFriends;

			// Token: 0x04006B77 RID: 27511
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B78 RID: 27512
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006B79 RID: 27513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B7A RID: 27514
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__1_Internal_Void_0;

			// Token: 0x04006B7B RID: 27515
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Il2CppStructArray_1_Int32_PDM_0;
		}

		// Token: 0x020007CD RID: 1997
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass16_1")]
		public sealed class __c__DisplayClass16_1 : Object
		{
			// Token: 0x0600A641 RID: 42561 RVA: 0x002B5928 File Offset: 0x002B3B28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass16_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass16_1.NativeFieldInfoPtr_endDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr, "endDialogs");
				NitoriTelephoneComponent.__c__DisplayClass16_1.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr, 100670873);
				NitoriTelephoneComponent.__c__DisplayClass16_1.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__4_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr, 100670874);
			}

			// Token: 0x0600A642 RID: 42562 RVA: 0x002B59A4 File Offset: 0x002B3BA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A643 RID: 42563 RVA: 0x002B59E0 File Offset: 0x002B3BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96622, XrefRangeEnd = 96651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiCommitFriendBtnConfig_b__4(Action y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_1.NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__4_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A644 RID: 42564 RVA: 0x00059D69 File Offset: 0x00057F69
			public __c__DisplayClass16_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036BB RID: 14011
			// (get) Token: 0x0600A645 RID: 42565 RVA: 0x002B5A24 File Offset: 0x002B3C24
			// (set) Token: 0x0600A646 RID: 42566 RVA: 0x00059D72 File Offset: 0x00057F72
			public unsafe Queue<DialogPackage> endDialogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_1.NativeFieldInfoPtr_endDialogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_1.NativeFieldInfoPtr_endDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036BC RID: 14012
			// (get) Token: 0x0600A647 RID: 42567 RVA: 0x002B5A54 File Offset: 0x002B3C54
			// (set) Token: 0x0600A648 RID: 42568 RVA: 0x00059D91 File Offset: 0x00057F91
			public unsafe NitoriTelephoneComponent.__c__DisplayClass16_0 field_Public___c__DisplayClass16_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_1.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_1.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B7C RID: 27516
			private static readonly IntPtr NativeFieldInfoPtr_endDialogs;

			// Token: 0x04006B7D RID: 27517
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0;

			// Token: 0x04006B7E RID: 27518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B7F RID: 27519
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiCommitFriendBtnConfig_b__4_Internal_Void_Action_0;
		}

		// Token: 0x020007CE RID: 1998
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass16_2")]
		public sealed class __c__DisplayClass16_2 : Object
		{
			// Token: 0x0600A649 RID: 42569 RVA: 0x002B5A84 File Offset: 0x002B3C84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_2()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass16_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass16_2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr, "y");
				NitoriTelephoneComponent.__c__DisplayClass16_2.NativeFieldInfoPtr_field_Public___c__DisplayClass16_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr, "CS$<>8__locals2");
				NitoriTelephoneComponent.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr, 100670875);
				NitoriTelephoneComponent.__c__DisplayClass16_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr, 100670876);
			}

			// Token: 0x0600A64A RID: 42570 RVA: 0x002B5B00 File Offset: 0x002B3D00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass16_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A64B RID: 42571 RVA: 0x002B5B3C File Offset: 0x002B3D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96651, XrefRangeEnd = 96670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass16_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A64C RID: 42572 RVA: 0x00059DB0 File Offset: 0x00057FB0
			public __c__DisplayClass16_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036BD RID: 14013
			// (get) Token: 0x0600A64D RID: 42573 RVA: 0x002B5B70 File Offset: 0x002B3D70
			// (set) Token: 0x0600A64E RID: 42574 RVA: 0x00059DB9 File Offset: 0x00057FB9
			public unsafe Action y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_2.NativeFieldInfoPtr_y);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_2.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036BE RID: 14014
			// (get) Token: 0x0600A64F RID: 42575 RVA: 0x002B5BA0 File Offset: 0x002B3DA0
			// (set) Token: 0x0600A650 RID: 42576 RVA: 0x00059DD8 File Offset: 0x00057FD8
			public unsafe NitoriTelephoneComponent.__c__DisplayClass16_1 field_Public___c__DisplayClass16_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_2.NativeFieldInfoPtr_field_Public___c__DisplayClass16_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass16_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass16_2.NativeFieldInfoPtr_field_Public___c__DisplayClass16_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B80 RID: 27520
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04006B81 RID: 27521
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_1_0;

			// Token: 0x04006B82 RID: 27522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B83 RID: 27523
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020007CF RID: 1999
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600A651 RID: 42577 RVA: 0x002B5BD0 File Offset: 0x002B3DD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_allMerchants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr, "allMerchants");
				NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr, "baseInteractData");
				NitoriTelephoneComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670877);
				NitoriTelephoneComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670878);
				NitoriTelephoneComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670879);
			}

			// Token: 0x0600A652 RID: 42578 RVA: 0x002B5C74 File Offset: 0x002B3E74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A653 RID: 42579 RVA: 0x002B5CB0 File Offset: 0x002B3EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96670, XrefRangeEnd = 96674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMultiBuyMerchantBtnConfig_b__1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A654 RID: 42580 RVA: 0x002B5D00 File Offset: 0x002B3F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96674, XrefRangeEnd = 96733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiBuyMerchantBtnConfig_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A655 RID: 42581 RVA: 0x00059DF7 File Offset: 0x00057FF7
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036BF RID: 14015
			// (get) Token: 0x0600A656 RID: 42582 RVA: 0x002B5D34 File Offset: 0x002B3F34
			// (set) Token: 0x0600A657 RID: 42583 RVA: 0x00059E00 File Offset: 0x00058000
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C0 RID: 14016
			// (get) Token: 0x0600A658 RID: 42584 RVA: 0x002B5D64 File Offset: 0x002B3F64
			// (set) Token: 0x0600A659 RID: 42585 RVA: 0x00059E1F File Offset: 0x0005801F
			public unsafe List<string> allMerchants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_allMerchants);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_allMerchants), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C1 RID: 14017
			// (get) Token: 0x0600A65A RID: 42586 RVA: 0x002B5D94 File Offset: 0x002B3F94
			// (set) Token: 0x0600A65B RID: 42587 RVA: 0x00059E3E File Offset: 0x0005803E
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B84 RID: 27524
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B85 RID: 27525
			private static readonly IntPtr NativeFieldInfoPtr_allMerchants;

			// Token: 0x04006B86 RID: 27526
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006B87 RID: 27527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B88 RID: 27528
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__1_Internal_Boolean_String_0;

			// Token: 0x04006B89 RID: 27529
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__3_Internal_Void_0;
		}

		// Token: 0x020007D0 RID: 2000
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Object
		{
			// Token: 0x0600A65C RID: 42588 RVA: 0x002B5DC4 File Offset: 0x002B3FC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, "cost");
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, "products");
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, 100670880);
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr_Method_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, 100670881);
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr_Method_Internal_String_IEnumerable_1_Object_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, 100670882);
				NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr_Method_Internal_Void_Il2CppStringArray_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr, 100670883);
			}

			// Token: 0x0600A65D RID: 42589 RVA: 0x002B5E7C File Offset: 0x002B407C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A65E RID: 42590 RVA: 0x002B5EB8 File Offset: 0x002B40B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96733, XrefRangeEnd = 96734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_PDM_0(ValueTuple<IEnumerable<Object>, bool> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr_Method_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A65F RID: 42591 RVA: 0x002B5F0C File Offset: 0x002B410C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96734, XrefRangeEnd = 96800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_IEnumerable_1_Object_PDM_0(IEnumerable<Object> currentSelection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentSelection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr_Method_Internal_String_IEnumerable_1_Object_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A660 RID: 42592 RVA: 0x002B5F54 File Offset: 0x002B4154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96800, XrefRangeEnd = 96899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Il2CppStringArray_PDM_0(Il2CppStringArray merchantID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(merchantID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeMethodInfoPtr_Method_Internal_Void_Il2CppStringArray_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A661 RID: 42593 RVA: 0x00059E5D File Offset: 0x0005805D
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036C2 RID: 14018
			// (get) Token: 0x0600A662 RID: 42594 RVA: 0x002B5F98 File Offset: 0x002B4198
			// (set) Token: 0x0600A663 RID: 42595 RVA: 0x00059E66 File Offset: 0x00058066
			public unsafe int cost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_cost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_cost)) = value;
				}
			}

			// Token: 0x170036C3 RID: 14019
			// (get) Token: 0x0600A664 RID: 42596 RVA: 0x002B5FC0 File Offset: 0x002B41C0
			// (set) Token: 0x0600A665 RID: 42597 RVA: 0x00059E81 File Offset: 0x00058081
			public unsafe Dictionary<TrackedMerchant, Il2CppReferenceArray<Product>> products
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_products);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TrackedMerchant, Il2CppReferenceArray<Product>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C4 RID: 14020
			// (get) Token: 0x0600A666 RID: 42598 RVA: 0x002B5FF0 File Offset: 0x002B41F0
			// (set) Token: 0x0600A667 RID: 42599 RVA: 0x00059EA0 File Offset: 0x000580A0
			public unsafe NitoriTelephoneComponent.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B8A RID: 27530
			private static readonly IntPtr NativeFieldInfoPtr_cost;

			// Token: 0x04006B8B RID: 27531
			private static readonly IntPtr NativeFieldInfoPtr_products;

			// Token: 0x04006B8C RID: 27532
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04006B8D RID: 27533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B8E RID: 27534
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_PDM_0;

			// Token: 0x04006B8F RID: 27535
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_IEnumerable_1_Object_PDM_0;

			// Token: 0x04006B90 RID: 27536
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Il2CppStringArray_PDM_0;
		}

		// Token: 0x020007D1 RID: 2001
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass17_2")]
		public sealed class __c__DisplayClass17_2 : Object
		{
			// Token: 0x0600A668 RID: 42600 RVA: 0x002B6020 File Offset: 0x002B4220
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_2()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass17_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_2>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass17_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_2>.NativeClassPtr, "x");
				NitoriTelephoneComponent.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_2>.NativeClassPtr, 100670884);
				NitoriTelephoneComponent.__c__DisplayClass17_2.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__9_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_2>.NativeClassPtr, 100670885);
			}

			// Token: 0x0600A669 RID: 42601 RVA: 0x002B6088 File Offset: 0x002B4288
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A66A RID: 42602 RVA: 0x002B60C4 File Offset: 0x002B42C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96899, XrefRangeEnd = 96904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetMultiBuyMerchantBtnConfig_b__9(Product y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass17_2.NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__9_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A66B RID: 42603 RVA: 0x00059EBF File Offset: 0x000580BF
			public __c__DisplayClass17_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036C5 RID: 14021
			// (get) Token: 0x0600A66C RID: 42604 RVA: 0x002B6118 File Offset: 0x002B4318
			// (set) Token: 0x0600A66D RID: 42605 RVA: 0x00059EC8 File Offset: 0x000580C8
			public KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>> x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_2.NativeFieldInfoPtr_x);
					return new KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_2.NativeFieldInfoPtr_x), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TrackedMerchant, Il2CppReferenceArray<Product>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006B91 RID: 27537
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04006B92 RID: 27538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B93 RID: 27539
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiBuyMerchantBtnConfig_b__9_Internal_Int32_Product_0;
		}

		// Token: 0x020007D2 RID: 2002
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass17_3")]
		public sealed class __c__DisplayClass17_3 : ValueType
		{
			// Token: 0x0600A66E RID: 42606 RVA: 0x00059EF6 File Offset: 0x000580F6
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_3()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass17_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_3>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass17_3.NativeFieldInfoPtr_merchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_3>.NativeClassPtr, "merchantData");
			}

			// Token: 0x0600A66F RID: 42607 RVA: 0x00059F2A File Offset: 0x0005812A
			public __c__DisplayClass17_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A670 RID: 42608 RVA: 0x00059F33 File Offset: 0x00058133
			public __c__DisplayClass17_3() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass17_3>.NativeClassPtr))
			{
			}

			// Token: 0x170036C6 RID: 14022
			// (get) Token: 0x0600A671 RID: 42609 RVA: 0x002B6148 File Offset: 0x002B4348
			// (set) Token: 0x0600A672 RID: 42610 RVA: 0x00059F45 File Offset: 0x00058145
			public unsafe TrackedMerchant merchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_3.NativeFieldInfoPtr_merchantData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass17_3.NativeFieldInfoPtr_merchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B94 RID: 27540
			private static readonly IntPtr NativeFieldInfoPtr_merchantData;
		}

		// Token: 0x020007D3 RID: 2003
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600A673 RID: 42611 RVA: 0x002B6178 File Offset: 0x002B4378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_parentInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr, "parentInteractData");
				NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr, "<>9__1");
				NitoriTelephoneComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr, 100670886);
				NitoriTelephoneComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr, 100670887);
			}

			// Token: 0x0600A674 RID: 42612 RVA: 0x002B6208 File Offset: 0x002B4408
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A675 RID: 42613 RVA: 0x002B6244 File Offset: 0x002B4444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96904, XrefRangeEnd = 96921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenSpecialNPCMapSelectionMenu_b__1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A676 RID: 42614 RVA: 0x00059F64 File Offset: 0x00058164
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036C7 RID: 14023
			// (get) Token: 0x0600A677 RID: 42615 RVA: 0x002B6294 File Offset: 0x002B4494
			// (set) Token: 0x0600A678 RID: 42616 RVA: 0x00059F6D File Offset: 0x0005816D
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C8 RID: 14024
			// (get) Token: 0x0600A679 RID: 42617 RVA: 0x002B62C4 File Offset: 0x002B44C4
			// (set) Token: 0x0600A67A RID: 42618 RVA: 0x00059F8C File Offset: 0x0005818C
			public unsafe DaySceneChatSelectionPannel.BaseInteractData parentInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_parentInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_parentInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C9 RID: 14025
			// (get) Token: 0x0600A67B RID: 42619 RVA: 0x002B62F4 File Offset: 0x002B44F4
			// (set) Token: 0x0600A67C RID: 42620 RVA: 0x00059FAB File Offset: 0x000581AB
			public unsafe Func<string, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B95 RID: 27541
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006B96 RID: 27542
			private static readonly IntPtr NativeFieldInfoPtr_parentInteractData;

			// Token: 0x04006B97 RID: 27543
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006B98 RID: 27544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B99 RID: 27545
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__1_Internal_Boolean_String_0;
		}

		// Token: 0x020007D4 RID: 2004
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass18_1")]
		public sealed class __c__DisplayClass18_1 : Object
		{
			// Token: 0x0600A67D RID: 42621 RVA: 0x002B6324 File Offset: 0x002B4524
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass18_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_mapSpecNpcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr, "mapSpecNpcs");
				NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_thisMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr, "thisMap");
				NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr, 100670888);
				NitoriTelephoneComponent.__c__DisplayClass18_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr, 100670889);
			}

			// Token: 0x0600A67E RID: 42622 RVA: 0x002B63B4 File Offset: 0x002B45B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A67F RID: 42623 RVA: 0x002B63F0 File Offset: 0x002B45F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96921, XrefRangeEnd = 96938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A680 RID: 42624 RVA: 0x00059FCA File Offset: 0x000581CA
			public __c__DisplayClass18_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036CA RID: 14026
			// (get) Token: 0x0600A681 RID: 42625 RVA: 0x002B6480 File Offset: 0x002B4680
			// (set) Token: 0x0600A682 RID: 42626 RVA: 0x00059FD3 File Offset: 0x000581D3
			public unsafe Il2CppStringArray mapSpecNpcs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_mapSpecNpcs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_mapSpecNpcs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036CB RID: 14027
			// (get) Token: 0x0600A683 RID: 42627 RVA: 0x002B64B0 File Offset: 0x002B46B0
			// (set) Token: 0x0600A684 RID: 42628 RVA: 0x00059FF2 File Offset: 0x000581F2
			public unsafe string thisMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_thisMap);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_thisMap), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170036CC RID: 14028
			// (get) Token: 0x0600A685 RID: 42629 RVA: 0x002B64D8 File Offset: 0x002B46D8
			// (set) Token: 0x0600A686 RID: 42630 RVA: 0x0005A011 File Offset: 0x00058211
			public unsafe NitoriTelephoneComponent.__c__DisplayClass18_0 field_Public___c__DisplayClass18_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B9A RID: 27546
			private static readonly IntPtr NativeFieldInfoPtr_mapSpecNpcs;

			// Token: 0x04006B9B RID: 27547
			private static readonly IntPtr NativeFieldInfoPtr_thisMap;

			// Token: 0x04006B9C RID: 27548
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0;

			// Token: 0x04006B9D RID: 27549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B9E RID: 27550
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;
		}

		// Token: 0x020007D5 RID: 2005
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass18_2")]
		public sealed class __c__DisplayClass18_2 : Object
		{
			// Token: 0x0600A687 RID: 42631 RVA: 0x002B6508 File Offset: 0x002B4708
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_2()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass18_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr_baseInteractData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr, "baseInteractData2");
				NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr_field_Public___c__DisplayClass18_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr, "CS$<>8__locals2");
				NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr, "<>9__4");
				NitoriTelephoneComponent.__c__DisplayClass18_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr, 100670890);
				NitoriTelephoneComponent.__c__DisplayClass18_2.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr, 100670891);
				NitoriTelephoneComponent.__c__DisplayClass18_2.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr, 100670892);
			}

			// Token: 0x0600A688 RID: 42632 RVA: 0x002B65AC File Offset: 0x002B47AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass18_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A689 RID: 42633 RVA: 0x002B65E8 File Offset: 0x002B47E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96938, XrefRangeEnd = 96948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenSpecialNPCMapSelectionMenu_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A68A RID: 42634 RVA: 0x002B661C File Offset: 0x002B481C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96948, XrefRangeEnd = 96949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenSpecialNPCMapSelectionMenu_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A68B RID: 42635 RVA: 0x0005A030 File Offset: 0x00058230
			public __c__DisplayClass18_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036CD RID: 14029
			// (get) Token: 0x0600A68C RID: 42636 RVA: 0x002B6650 File Offset: 0x002B4850
			// (set) Token: 0x0600A68D RID: 42637 RVA: 0x0005A039 File Offset: 0x00058239
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr_baseInteractData2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr_baseInteractData2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036CE RID: 14030
			// (get) Token: 0x0600A68E RID: 42638 RVA: 0x002B6680 File Offset: 0x002B4880
			// (set) Token: 0x0600A68F RID: 42639 RVA: 0x0005A058 File Offset: 0x00058258
			public unsafe NitoriTelephoneComponent.__c__DisplayClass18_1 field_Public___c__DisplayClass18_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr_field_Public___c__DisplayClass18_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass18_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr_field_Public___c__DisplayClass18_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036CF RID: 14031
			// (get) Token: 0x0600A690 RID: 42640 RVA: 0x002B66B0 File Offset: 0x002B48B0
			// (set) Token: 0x0600A691 RID: 42641 RVA: 0x0005A077 File Offset: 0x00058277
			public unsafe Action __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass18_2.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B9F RID: 27551
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData2;

			// Token: 0x04006BA0 RID: 27552
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass18_1_0;

			// Token: 0x04006BA1 RID: 27553
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006BA2 RID: 27554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BA3 RID: 27555
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__3_Internal_Void_0;

			// Token: 0x04006BA4 RID: 27556
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCMapSelectionMenu_b__4_Internal_Void_0;
		}

		// Token: 0x020007D6 RID: 2006
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600A692 RID: 42642 RVA: 0x002B66E0 File Offset: 0x002B48E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr, "map");
				NitoriTelephoneComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr, 100670893);
				NitoriTelephoneComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__1_Internal_Boolean_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr, 100670894);
			}

			// Token: 0x0600A693 RID: 42643 RVA: 0x002B675C File Offset: 0x002B495C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A694 RID: 42644 RVA: 0x002B6798 File Offset: 0x002B4998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96949, XrefRangeEnd = 96950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenMerchantNPCMapSelectionMenu_b__1(ExtraMerchantData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass19_0.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__1_Internal_Boolean_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A695 RID: 42645 RVA: 0x0005A096 File Offset: 0x00058296
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036D0 RID: 14032
			// (get) Token: 0x0600A696 RID: 42646 RVA: 0x002B67EC File Offset: 0x002B49EC
			// (set) Token: 0x0600A697 RID: 42647 RVA: 0x0005A09F File Offset: 0x0005829F
			public unsafe string map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_map);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_0.NativeFieldInfoPtr_map), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170036D1 RID: 14033
			// (get) Token: 0x0600A698 RID: 42648 RVA: 0x002B6814 File Offset: 0x002B4A14
			// (set) Token: 0x0600A699 RID: 42649 RVA: 0x0005A0BE File Offset: 0x000582BE
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BA5 RID: 27557
			private static readonly IntPtr NativeFieldInfoPtr_map;

			// Token: 0x04006BA6 RID: 27558
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006BA7 RID: 27559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BA8 RID: 27560
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__1_Internal_Boolean_ExtraMerchantData_0;
		}

		// Token: 0x020007D7 RID: 2007
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : Object
		{
			// Token: 0x0600A69A RID: 42650 RVA: 0x002B6844 File Offset: 0x002B4A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass19_1.NativeFieldInfoPtr_mapSpecNpcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr, "mapSpecNpcs");
				NitoriTelephoneComponent.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr, 100670895);
				NitoriTelephoneComponent.__c__DisplayClass19_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr, 100670896);
			}

			// Token: 0x0600A69B RID: 42651 RVA: 0x002B68C0 File Offset: 0x002B4AC0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A69C RID: 42652 RVA: 0x002B68FC File Offset: 0x002B4AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96950, XrefRangeEnd = 96968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData2, out string title2, out bool availability2, out Action onInteract2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData2);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass19_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title2 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract2 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A69D RID: 42653 RVA: 0x0005A0DD File Offset: 0x000582DD
			public __c__DisplayClass19_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036D2 RID: 14034
			// (get) Token: 0x0600A69E RID: 42654 RVA: 0x002B698C File Offset: 0x002B4B8C
			// (set) Token: 0x0600A69F RID: 42655 RVA: 0x0005A0E6 File Offset: 0x000582E6
			public unsafe Il2CppStringArray mapSpecNpcs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_1.NativeFieldInfoPtr_mapSpecNpcs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_1.NativeFieldInfoPtr_mapSpecNpcs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D3 RID: 14035
			// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x002B69BC File Offset: 0x002B4BBC
			// (set) Token: 0x0600A6A1 RID: 42657 RVA: 0x0005A105 File Offset: 0x00058305
			public unsafe NitoriTelephoneComponent.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BA9 RID: 27561
			private static readonly IntPtr NativeFieldInfoPtr_mapSpecNpcs;

			// Token: 0x04006BAA RID: 27562
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;

			// Token: 0x04006BAB RID: 27563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BAC RID: 27564
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;
		}

		// Token: 0x020007D8 RID: 2008
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass19_2")]
		public sealed class __c__DisplayClass19_2 : Object
		{
			// Token: 0x0600A6A2 RID: 42658 RVA: 0x002B69EC File Offset: 0x002B4BEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_2()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass19_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_thisMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr, "thisMap");
				NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_baseInteractData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr, "baseInteractData2");
				NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr, "CS$<>8__locals2");
				NitoriTelephoneComponent.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr, 100670897);
				NitoriTelephoneComponent.__c__DisplayClass19_2.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr, 100670898);
			}

			// Token: 0x0600A6A3 RID: 42659 RVA: 0x002B6A7C File Offset: 0x002B4C7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass19_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6A4 RID: 42660 RVA: 0x002B6AB8 File Offset: 0x002B4CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96968, XrefRangeEnd = 96971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenMerchantNPCMapSelectionMenu_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6A5 RID: 42661 RVA: 0x0005A124 File Offset: 0x00058324
			public __c__DisplayClass19_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036D4 RID: 14036
			// (get) Token: 0x0600A6A6 RID: 42662 RVA: 0x002B6AEC File Offset: 0x002B4CEC
			// (set) Token: 0x0600A6A7 RID: 42663 RVA: 0x0005A12D File Offset: 0x0005832D
			public unsafe string thisMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_thisMap);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_thisMap), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170036D5 RID: 14037
			// (get) Token: 0x0600A6A8 RID: 42664 RVA: 0x002B6B14 File Offset: 0x002B4D14
			// (set) Token: 0x0600A6A9 RID: 42665 RVA: 0x0005A14C File Offset: 0x0005834C
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_baseInteractData2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_baseInteractData2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D6 RID: 14038
			// (get) Token: 0x0600A6AA RID: 42666 RVA: 0x002B6B44 File Offset: 0x002B4D44
			// (set) Token: 0x0600A6AB RID: 42667 RVA: 0x0005A16B File Offset: 0x0005836B
			public unsafe NitoriTelephoneComponent.__c__DisplayClass19_1 field_Public___c__DisplayClass19_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass19_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BAD RID: 27565
			private static readonly IntPtr NativeFieldInfoPtr_thisMap;

			// Token: 0x04006BAE RID: 27566
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData2;

			// Token: 0x04006BAF RID: 27567
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0;

			// Token: 0x04006BB0 RID: 27568
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BB1 RID: 27569
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCMapSelectionMenu_b__4_Internal_Void_0;
		}

		// Token: 0x020007D9 RID: 2009
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x0600A6AC RID: 42668 RVA: 0x002B6B74 File Offset: 0x002B4D74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_parentInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr, "parentInteractData");
				NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_closeChatSelectionPannelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr, "closeChatSelectionPannelCallback");
				NitoriTelephoneComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr, 100670899);
				NitoriTelephoneComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr, 100670900);
			}

			// Token: 0x0600A6AD RID: 42669 RVA: 0x002B6C04 File Offset: 0x002B4E04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6AE RID: 42670 RVA: 0x002B6C40 File Offset: 0x002B4E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96971, XrefRangeEnd = 96988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenSpecialNPCSelectionMenu_b__1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6AF RID: 42671 RVA: 0x0005A18A File Offset: 0x0005838A
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036D7 RID: 14039
			// (get) Token: 0x0600A6B0 RID: 42672 RVA: 0x002B6C90 File Offset: 0x002B4E90
			// (set) Token: 0x0600A6B1 RID: 42673 RVA: 0x0005A193 File Offset: 0x00058393
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D8 RID: 14040
			// (get) Token: 0x0600A6B2 RID: 42674 RVA: 0x002B6CC0 File Offset: 0x002B4EC0
			// (set) Token: 0x0600A6B3 RID: 42675 RVA: 0x0005A1B2 File Offset: 0x000583B2
			public unsafe DaySceneChatSelectionPannel.BaseInteractData parentInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_parentInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_parentInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D9 RID: 14041
			// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x002B6CF0 File Offset: 0x002B4EF0
			// (set) Token: 0x0600A6B5 RID: 42677 RVA: 0x0005A1D1 File Offset: 0x000583D1
			public unsafe Action closeChatSelectionPannelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_closeChatSelectionPannelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_closeChatSelectionPannelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BB2 RID: 27570
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006BB3 RID: 27571
			private static readonly IntPtr NativeFieldInfoPtr_parentInteractData;

			// Token: 0x04006BB4 RID: 27572
			private static readonly IntPtr NativeFieldInfoPtr_closeChatSelectionPannelCallback;

			// Token: 0x04006BB5 RID: 27573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BB6 RID: 27574
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__1_Internal_Boolean_String_0;
		}

		// Token: 0x020007DA RID: 2010
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Object
		{
			// Token: 0x0600A6B6 RID: 42678 RVA: 0x002B6D20 File Offset: 0x002B4F20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_specialGuesStrId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr, "specialGuesStrId");
				NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_targetGuestStrId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr, "targetGuestStrId");
				NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr, 100670901);
				NitoriTelephoneComponent.__c__DisplayClass20_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr, 100670902);
			}

			// Token: 0x0600A6B7 RID: 42679 RVA: 0x002B6DB0 File Offset: 0x002B4FB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6B8 RID: 42680 RVA: 0x002B6DEC File Offset: 0x002B4FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96988, XrefRangeEnd = 97020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData3, out string title3, out bool availability3, out Action onInteract3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData3);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability3;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title3 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract3 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A6B9 RID: 42681 RVA: 0x0005A1F0 File Offset: 0x000583F0
			public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036DA RID: 14042
			// (get) Token: 0x0600A6BA RID: 42682 RVA: 0x002B6E7C File Offset: 0x002B507C
			// (set) Token: 0x0600A6BB RID: 42683 RVA: 0x0005A1F9 File Offset: 0x000583F9
			public unsafe string specialGuesStrId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_specialGuesStrId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_specialGuesStrId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170036DB RID: 14043
			// (get) Token: 0x0600A6BC RID: 42684 RVA: 0x002B6EA4 File Offset: 0x002B50A4
			// (set) Token: 0x0600A6BD RID: 42685 RVA: 0x0005A218 File Offset: 0x00058418
			public unsafe string targetGuestStrId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_targetGuestStrId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_targetGuestStrId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170036DC RID: 14044
			// (get) Token: 0x0600A6BE RID: 42686 RVA: 0x002B6ECC File Offset: 0x002B50CC
			// (set) Token: 0x0600A6BF RID: 42687 RVA: 0x0005A237 File Offset: 0x00058437
			public unsafe NitoriTelephoneComponent.__c__DisplayClass20_0 field_Public___c__DisplayClass20_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass20_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BB7 RID: 27575
			private static readonly IntPtr NativeFieldInfoPtr_specialGuesStrId;

			// Token: 0x04006BB8 RID: 27576
			private static readonly IntPtr NativeFieldInfoPtr_targetGuestStrId;

			// Token: 0x04006BB9 RID: 27577
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0;

			// Token: 0x04006BBA RID: 27578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BBB RID: 27579
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;
		}

		// Token: 0x020007DB RID: 2011
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass20_2")]
		public sealed class __c__DisplayClass20_2 : Object
		{
			// Token: 0x0600A6C0 RID: 42688 RVA: 0x002B6EFC File Offset: 0x002B50FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_2()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass20_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_baseInteractData3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr, "baseInteractData3");
				NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_onCustomEventExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr, "onCustomEventExecute");
				NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr, "CS$<>8__locals2");
				NitoriTelephoneComponent.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr, 100670903);
				NitoriTelephoneComponent.__c__DisplayClass20_2.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__3_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr, 100670904);
				NitoriTelephoneComponent.__c__DisplayClass20_2.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr, 100670905);
			}

			// Token: 0x0600A6C1 RID: 42689 RVA: 0x002B6FA0 File Offset: 0x002B51A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass20_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6C2 RID: 42690 RVA: 0x002B6FDC File Offset: 0x002B51DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97020, XrefRangeEnd = 97022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenSpecialNPCSelectionMenu_b__3(Action y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__3_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6C3 RID: 42691 RVA: 0x002B7020 File Offset: 0x002B5220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97022, XrefRangeEnd = 97026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenSpecialNPCSelectionMenu_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6C4 RID: 42692 RVA: 0x0005A256 File Offset: 0x00058456
			public __c__DisplayClass20_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036DD RID: 14045
			// (get) Token: 0x0600A6C5 RID: 42693 RVA: 0x002B7054 File Offset: 0x002B5254
			// (set) Token: 0x0600A6C6 RID: 42694 RVA: 0x0005A25F File Offset: 0x0005845F
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_baseInteractData3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_baseInteractData3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DE RID: 14046
			// (get) Token: 0x0600A6C7 RID: 42695 RVA: 0x002B7084 File Offset: 0x002B5284
			// (set) Token: 0x0600A6C8 RID: 42696 RVA: 0x0005A27E File Offset: 0x0005847E
			public unsafe Action<Action> onCustomEventExecute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_onCustomEventExecute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_onCustomEventExecute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DF RID: 14047
			// (get) Token: 0x0600A6C9 RID: 42697 RVA: 0x002B70B4 File Offset: 0x002B52B4
			// (set) Token: 0x0600A6CA RID: 42698 RVA: 0x0005A29D File Offset: 0x0005849D
			public unsafe NitoriTelephoneComponent.__c__DisplayClass20_1 field_Public___c__DisplayClass20_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass20_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BBC RID: 27580
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData3;

			// Token: 0x04006BBD RID: 27581
			private static readonly IntPtr NativeFieldInfoPtr_onCustomEventExecute;

			// Token: 0x04006BBE RID: 27582
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0;

			// Token: 0x04006BBF RID: 27583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BC0 RID: 27584
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__3_Internal_Void_Action_0;

			// Token: 0x04006BC1 RID: 27585
			private static readonly IntPtr NativeMethodInfoPtr__OpenSpecialNPCSelectionMenu_b__4_Internal_Void_0;
		}

		// Token: 0x020007DC RID: 2012
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x0600A6CB RID: 42699 RVA: 0x002B70E4 File Offset: 0x002B52E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass22_0.NativeFieldInfoPtr_targetNpcStrId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr, "targetNpcStrId");
				NitoriTelephoneComponent.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				NitoriTelephoneComponent.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr, 100670906);
				NitoriTelephoneComponent.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr, 100670907);
			}

			// Token: 0x0600A6CC RID: 42700 RVA: 0x002B7160 File Offset: 0x002B5360
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6CD RID: 42701 RVA: 0x002B719C File Offset: 0x002B539C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97026, XrefRangeEnd = 97065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData3, out string title3, out bool availability3, out Action onInteract3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData3);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability3;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title3 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract3 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A6CE RID: 42702 RVA: 0x0005A2BC File Offset: 0x000584BC
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036E0 RID: 14048
			// (get) Token: 0x0600A6CF RID: 42703 RVA: 0x002B722C File Offset: 0x002B542C
			// (set) Token: 0x0600A6D0 RID: 42704 RVA: 0x0005A2C5 File Offset: 0x000584C5
			public unsafe string targetNpcStrId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_0.NativeFieldInfoPtr_targetNpcStrId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_0.NativeFieldInfoPtr_targetNpcStrId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170036E1 RID: 14049
			// (get) Token: 0x0600A6D1 RID: 42705 RVA: 0x002B7254 File Offset: 0x002B5454
			// (set) Token: 0x0600A6D2 RID: 42706 RVA: 0x0005A2E4 File Offset: 0x000584E4
			public unsafe NitoriTelephoneComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BC2 RID: 27586
			private static readonly IntPtr NativeFieldInfoPtr_targetNpcStrId;

			// Token: 0x04006BC3 RID: 27587
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006BC4 RID: 27588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BC5 RID: 27589
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;
		}

		// Token: 0x020007DD RID: 2013
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : Object
		{
			// Token: 0x0600A6D3 RID: 42707 RVA: 0x002B7284 File Offset: 0x002B5484
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_isExtraMerchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr, "isExtraMerchantData");
				NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_baseInteractData3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr, "baseInteractData3");
				NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr, "CS$<>8__locals1");
				NitoriTelephoneComponent.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr, 100670908);
				NitoriTelephoneComponent.__c__DisplayClass22_1.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr, 100670909);
			}

			// Token: 0x0600A6D4 RID: 42708 RVA: 0x002B7314 File Offset: 0x002B5514
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6D5 RID: 42709 RVA: 0x002B7350 File Offset: 0x002B5550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97065, XrefRangeEnd = 97069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenMerchantNPCSelectionMenu_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6D6 RID: 42710 RVA: 0x0005A303 File Offset: 0x00058503
			public __c__DisplayClass22_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036E2 RID: 14050
			// (get) Token: 0x0600A6D7 RID: 42711 RVA: 0x002B7384 File Offset: 0x002B5584
			// (set) Token: 0x0600A6D8 RID: 42712 RVA: 0x0005A30C File Offset: 0x0005850C
			public unsafe bool isExtraMerchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_isExtraMerchantData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_isExtraMerchantData)) = value;
				}
			}

			// Token: 0x170036E3 RID: 14051
			// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x002B73AC File Offset: 0x002B55AC
			// (set) Token: 0x0600A6DA RID: 42714 RVA: 0x0005A327 File Offset: 0x00058527
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_baseInteractData3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_baseInteractData3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E4 RID: 14052
			// (get) Token: 0x0600A6DB RID: 42715 RVA: 0x002B73DC File Offset: 0x002B55DC
			// (set) Token: 0x0600A6DC RID: 42716 RVA: 0x0005A346 File Offset: 0x00058546
			public unsafe NitoriTelephoneComponent.__c__DisplayClass22_0 field_Public___c__DisplayClass22_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriTelephoneComponent.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BC6 RID: 27590
			private static readonly IntPtr NativeFieldInfoPtr_isExtraMerchantData;

			// Token: 0x04006BC7 RID: 27591
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData3;

			// Token: 0x04006BC8 RID: 27592
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0;

			// Token: 0x04006BC9 RID: 27593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BCA RID: 27594
			private static readonly IntPtr NativeMethodInfoPtr__OpenMerchantNPCSelectionMenu_b__6_Internal_Void_0;
		}

		// Token: 0x020007DE RID: 2014
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NitoriTelephoneComponent+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x0600A6DD RID: 42717 RVA: 0x002B740C File Offset: 0x002B560C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriTelephoneComponent>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass25_0>.NativeClassPtr);
				NitoriTelephoneComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass25_0>.NativeClassPtr, "label");
				NitoriTelephoneComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670910);
				NitoriTelephoneComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__RefExtraMerchantData_b__0_Internal_Boolean_ExtraMerchantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass25_0>.NativeClassPtr, 100670911);
			}

			// Token: 0x0600A6DE RID: 42718 RVA: 0x002B7474 File Offset: 0x002B5674
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriTelephoneComponent.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6DF RID: 42719 RVA: 0x002B74B0 File Offset: 0x002B56B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefExtraMerchantData_b__0(ExtraMerchantData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriTelephoneComponent.__c__DisplayClass25_0.NativeMethodInfoPtr__RefExtraMerchantData_b__0_Internal_Boolean_ExtraMerchantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6E0 RID: 42720 RVA: 0x0005A365 File Offset: 0x00058565
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036E5 RID: 14053
			// (get) Token: 0x0600A6E1 RID: 42721 RVA: 0x002B7504 File Offset: 0x002B5704
			// (set) Token: 0x0600A6E2 RID: 42722 RVA: 0x0005A36E File Offset: 0x0005856E
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriTelephoneComponent.__c__DisplayClass25_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04006BCB RID: 27595
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04006BCC RID: 27596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BCD RID: 27597
			private static readonly IntPtr NativeMethodInfoPtr__RefExtraMerchantData_b__0_Internal_Boolean_ExtraMerchantData_0;
		}
	}
}
