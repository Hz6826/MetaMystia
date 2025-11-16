using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020000BB RID: 187
	public class DaySceneChatSelectionPannel : UIPanel
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x000E44D0 File Offset: 0x000E26D0
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneChatSelectionPannel()
		{
			Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneChatSelectionPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr);
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_ACTION_CONSUMPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "ACTION_CONSUMPTION");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_SOFT_DRINK_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "SOFT_DRINK_TAG_ID");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_CHAT_KIZUNA_GENERATION_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "CHAT_KIZUNA_GENERATION_AMOUNT");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_chatSelectionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "chatSelectionParent");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_selectionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "selectionField");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "scroller");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_allChatSelectionElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "allChatSelectionElements");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr_m_SelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "m_SelectionGroup");
			DaySceneChatSelectionPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_BaseOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666923);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_BaseOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666924);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666925);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666926);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_GetConfigurationSet_Private_IEnumerable_1_GetSpecialNPCSelectionConfigurationCallback_String_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_Boolean_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666927);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Chat_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666928);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Invite_Private_Void_String_Int32_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666929);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_FillterCollection_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_IEnumerable_1_WeightedTag_IEnumerable_1_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666930);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_SelectFromData_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666931);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_RequestIngredient_Private_Void_String_Int32_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666932);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_RequestBeverages_Private_Void_String_Int32_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666933);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Commision_Private_Void_String_String_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666934);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_InviteSpecGuest_Public_Static_Boolean_SpecialGuest_Int32_byref_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666935);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_CommitSpecGuest_Public_Static_Void_SpecialGuest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666936);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666937);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_RefreshPannel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666938);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_OpenInternal_Private_Void_Il2CppArrayBase_1_TGetSelectionConfigurationCallback_TInteractData_Func_3_TInteractData_TGetSelectionConfigurationCallback_ValueTuple_3_Boolean_String_Action_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666939);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666940);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666941);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_BaseInteractData_GetSelectionConfigurationCallback_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666942);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Private_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666943);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_NormalNPCInteractData_GetNormalNPCSelectionConfigurationCallback_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666944);
			DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_SpecialNPCInteractData_GetSpecialNPCSelectionConfigurationCallback_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, 100666945);
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x000E4780 File Offset: 0x000E2980
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x000E47C0 File Offset: 0x000E29C0
		public unsafe DaySceneChatSelectionPannel.BaseOpenContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_BaseOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseOpenContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_BaseOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000E4804 File Offset: 0x000E2A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58810, XrefRangeEnd = 58813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000E4840 File Offset: 0x000E2A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58813, XrefRangeEnd = 58944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000E487C File Offset: 0x000E2A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59065, RefRangeEnd = 59066, XrefRangeStart = 58944, XrefRangeEnd = 59065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> GetConfigurationSet(string currentCharacterLabel, Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelections, Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections, bool shouldTriggerEvent, Action<Action> onWillExecuteDayEndEventCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(currentCharacterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prependSelections);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appendSelections);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_GetConfigurationSet_Private_IEnumerable_1_GetSpecialNPCSelectionConfigurationCallback_String_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_Boolean_Action_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>>(intPtr3) : null;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000E4914 File Offset: 0x000E2B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59100, RefRangeEnd = 59101, XrefRangeStart = 59066, XrefRangeEnd = 59100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Chat(string characterLabel, bool shouldTriggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Chat_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000E4964 File Offset: 0x000E2B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59144, RefRangeEnd = 59145, XrefRangeStart = 59101, XrefRangeEnd = 59144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invite(string characterLabel, int currentKizunaLevel, Action<Action> onWillExecuteDayEndEventCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentKizunaLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Invite_Private_Void_String_Int32_Action_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000E49C8 File Offset: 0x000E2BC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59179, RefRangeEnd = 59181, XrefRangeStart = 59145, XrefRangeEnd = 59179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> FillterCollection(IEnumerable<int> hateTagCollection, IEnumerable<SpecialGuest.WeightedTag> likeTagCollection, IEnumerable<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>> allProductTags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hateTagCollection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(likeTagCollection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allProductTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_FillterCollection_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_IEnumerable_1_WeightedTag_IEnumerable_1_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000E4A3C File Offset: 0x000E2C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59202, RefRangeEnd = 59204, XrefRangeStart = 59181, XrefRangeEnd = 59202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> SelectFromData(IEnumerable<int> data, Func<int, int> getLevelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getLevelCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_SelectFromData_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_Func_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000E4AA0 File Offset: 0x000E2CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59322, RefRangeEnd = 59323, XrefRangeStart = 59204, XrefRangeEnd = 59322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestIngredient(string characterLabel, int currentKizunaLevel, Action<Action> onWillExecuteDayEndEventCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentKizunaLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_RequestIngredient_Private_Void_String_Int32_Action_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000E4B04 File Offset: 0x000E2D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59420, RefRangeEnd = 59421, XrefRangeStart = 59323, XrefRangeEnd = 59420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestBeverages(string characterLabel, int currentKizunaLevel, Action<Action> onWillExecuteDayEndEventCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentKizunaLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_RequestBeverages_Private_Void_String_Int32_Action_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000E4B68 File Offset: 0x000E2D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59421, XrefRangeEnd = 59450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commision(string characterLabel, string commisionLabel, Action<Action> onWillExecuteDayEndEventCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(commisionLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Commision_Private_Void_String_String_Action_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000E4BD0 File Offset: 0x000E2DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59465, RefRangeEnd = 59466, XrefRangeStart = 59450, XrefRangeEnd = 59465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InviteSpecGuest(SpecialGuest specialGuest, int kizunaLevel, out DialogPackage selectedDialogue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuest);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kizunaLevel;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_InviteSpecGuest_Public_Static_Boolean_SpecialGuest_Int32_byref_DialogPackage_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selectedDialogue = ((intPtr4 == 0) ? null : new DialogPackage(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000E4C44 File Offset: 0x000E2E44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59506, RefRangeEnd = 59509, XrefRangeStart = 59466, XrefRangeEnd = 59506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CommitSpecGuest(SpecialGuest specialGuest, string commisionLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuest);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(commisionLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_CommitSpecGuest_Public_Static_Void_SpecialGuest_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000E4C8C File Offset: 0x000E2E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59509, XrefRangeEnd = 59514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000E4CC8 File Offset: 0x000E2EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59514, XrefRangeEnd = 59518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_RefreshPannel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000E4CFC File Offset: 0x000E2EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59569, RefRangeEnd = 59570, XrefRangeStart = 59518, XrefRangeEnd = 59569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenInternal<TInteractData, TGetSelectionConfigurationCallback>(Il2CppArrayBase<TGetSelectionConfigurationCallback> selections, TInteractData interactData, Func<TInteractData, TGetSelectionConfigurationCallback, ValueTuple<bool, string, Action>> getConfigCallback, Action endButtonAction, int indexToSelect = -1) where TInteractData : DaySceneChatSelectionPannel.BaseInteractData where TGetSelectionConfigurationCallback : Delegate
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selections);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TInteractData).IsValueType)
			{
				TInteractData tinteractData = interactData;
				intPtr = ((tinteractData is string) ? IL2CPP.ManagedStringToIl2Cpp(tinteractData as string) : IL2CPP.Il2CppObjectBaseToPtr(tinteractData as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref interactData;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getConfigCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endButtonAction);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexToSelect;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.MethodInfoStoreGeneric_OpenInternal_Private_Void_Il2CppArrayBase_1_TGetSelectionConfigurationCallback_TInteractData_Func_3_TInteractData_TGetSelectionConfigurationCallback_ValueTuple_3_Boolean_String_Action_Action_Int32_0<TInteractData, TGetSelectionConfigurationCallback>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000E4DBC File Offset: 0x000E2FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59570, XrefRangeEnd = 59577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000E4DF8 File Offset: 0x000E2FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59577, XrefRangeEnd = 59591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneChatSelectionPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000E4E34 File Offset: 0x000E3034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59591, XrefRangeEnd = 59594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<bool, string, Action> Method_Internal_Static_ValueTuple_3_Boolean_String_Action_BaseInteractData_GetSelectionConfigurationCallback_PDM_0(DaySceneChatSelectionPannel.BaseInteractData interactData, DaySceneChatSelectionPannel.GetSelectionConfigurationCallback getSelectionConfigCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSelectionConfigCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_BaseInteractData_GetSelectionConfigurationCallback_PDM_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<bool, string, Action>(pointer);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000E4E84 File Offset: 0x000E3084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59594, XrefRangeEnd = 59605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.NormalNPCInteractData normalInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Private_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000E4F14 File Offset: 0x000E3114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59605, XrefRangeEnd = 59608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<bool, string, Action> Method_Internal_Static_ValueTuple_3_Boolean_String_Action_NormalNPCInteractData_GetNormalNPCSelectionConfigurationCallback_PDM_0(DaySceneChatSelectionPannel.NormalNPCInteractData normalInteractData, DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback getSelectionConfigCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSelectionConfigCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_NormalNPCInteractData_GetNormalNPCSelectionConfigurationCallback_PDM_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<bool, string, Action>(pointer);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000E4F64 File Offset: 0x000E3164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59608, XrefRangeEnd = 59611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<bool, string, Action> Method_Internal_Static_ValueTuple_3_Boolean_String_Action_SpecialNPCInteractData_GetSpecialNPCSelectionConfigurationCallback_PDM_0(DaySceneChatSelectionPannel.SpecialNPCInteractData specialInteractData, DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback getSelectionConfigCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSelectionConfigCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_SpecialNPCInteractData_GetSpecialNPCSelectionConfigurationCallback_PDM_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<bool, string, Action>(pointer);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0000CFCE File Offset: 0x0000B1CE
		public DaySceneChatSelectionPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x000E4FB4 File Offset: 0x000E31B4
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0000CFD7 File Offset: 0x0000B1D7
		public unsafe static int ACTION_CONSUMPTION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&value));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000E4FD0 File Offset: 0x000E31D0
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
		public unsafe static int SOFT_DRINK_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.NativeFieldInfoPtr_SOFT_DRINK_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.NativeFieldInfoPtr_SOFT_DRINK_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000E4FEC File Offset: 0x000E31EC
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0000CFF3 File Offset: 0x0000B1F3
		public unsafe static int CHAT_KIZUNA_GENERATION_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.NativeFieldInfoPtr_CHAT_KIZUNA_GENERATION_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.NativeFieldInfoPtr_CHAT_KIZUNA_GENERATION_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000E5008 File Offset: 0x000E3208
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x0000D001 File Offset: 0x0000B201
		public unsafe GameObject chatSelectionParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_chatSelectionParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_chatSelectionParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x000E5038 File Offset: 0x000E3238
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0000D020 File Offset: 0x0000B220
		public unsafe RectTransform selectionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_selectionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_selectionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x000E5068 File Offset: 0x000E3268
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x0000D03F File Offset: 0x0000B23F
		public unsafe AdpScrollListFixedComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListFixedComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x000E5098 File Offset: 0x000E3298
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x0000D05E File Offset: 0x0000B25E
		public unsafe List<GameObject> allChatSelectionElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_allChatSelectionElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_allChatSelectionElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000E50C8 File Offset: 0x000E32C8
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0000D07D File Offset: 0x0000B27D
		public unsafe UILogicalGroup m_SelectionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_m_SelectionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr_m_SelectionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x000E50F8 File Offset: 0x000E32F8
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000D09C File Offset: 0x0000B29C
		public unsafe DaySceneChatSelectionPannel.BaseOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseOpenContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_CONSUMPTION;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeFieldInfoPtr_SOFT_DRINK_TAG_ID;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeFieldInfoPtr_CHAT_KIZUNA_GENERATION_AMOUNT;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeFieldInfoPtr_chatSelectionParent;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeFieldInfoPtr_selectionField;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeFieldInfoPtr_allChatSelectionElements;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionGroup;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_BaseOpenContext_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_BaseOpenContext_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigurationSet_Private_IEnumerable_1_GetSpecialNPCSelectionConfigurationCallback_String_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_Boolean_Action_1_Action_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_Chat_Private_Void_String_Boolean_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_Invite_Private_Void_String_Int32_Action_1_Action_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_FillterCollection_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_IEnumerable_1_WeightedTag_IEnumerable_1_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_SelectFromData_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_Func_2_Int32_Int32_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_RequestIngredient_Private_Void_String_Int32_Action_1_Action_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_RequestBeverages_Private_Void_String_Int32_Action_1_Action_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_Commision_Private_Void_String_String_Action_1_Action_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_InviteSpecGuest_Public_Static_Boolean_SpecialGuest_Int32_byref_DialogPackage_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_CommitSpecGuest_Public_Static_Void_SpecialGuest_String_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPannel_Public_Void_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_OpenInternal_Private_Void_Il2CppArrayBase_1_TGetSelectionConfigurationCallback_TInteractData_Func_3_TInteractData_TGetSelectionConfigurationCallback_ValueTuple_3_Boolean_String_Action_Action_Int32_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_BaseInteractData_GetSelectionConfigurationCallback_PDM_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_NormalNPCInteractData_GetNormalNPCSelectionConfigurationCallback_PDM_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_ValueTuple_3_Boolean_String_Action_SpecialNPCInteractData_GetSpecialNPCSelectionConfigurationCallback_PDM_0;

		// Token: 0x020005FD RID: 1533
		public sealed class GetNormalNPCSelectionConfigurationCallback : MulticastDelegate
		{
			// Token: 0x0600901C RID: 36892 RVA: 0x00272A84 File Offset: 0x00270C84
			// Note: this type is marked as 'beforefieldinit'.
			static GetNormalNPCSelectionConfigurationCallback()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "GetNormalNPCSelectionConfigurationCallback");
				DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>.NativeClassPtr, 100666946);
				DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>.NativeClassPtr, 100666947);
				DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>.NativeClassPtr, 100666948);
				DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>.NativeClassPtr, 100666949);
			}

			// Token: 0x0600901D RID: 36893 RVA: 0x00272AF8 File Offset: 0x00270CF8
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 58093, RefRangeEnd = 58167, XrefRangeStart = 58081, XrefRangeEnd = 58093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetNormalNPCSelectionConfigurationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600901E RID: 36894 RVA: 0x00272B54 File Offset: 0x00270D54
			[CallerCount(0)]
			public unsafe void Invoke(DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData, out string title, out bool availability, out Action onInteract)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalNPCInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600901F RID: 36895 RVA: 0x00272BE4 File Offset: 0x00270DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58167, XrefRangeEnd = 58171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData, out string title, out bool availability, out Action onInteract, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalNPCInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
				IntPtr intPtr6 = intPtr3;
				return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
			}

			// Token: 0x06009020 RID: 36896 RVA: 0x00272CA8 File Offset: 0x00270EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58171, XrefRangeEnd = 58172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(out string title, out bool availability, out Action onInteract, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x06009021 RID: 36897 RVA: 0x0004E274 File Offset: 0x0004C474
			public GetNormalNPCSelectionConfigurationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04005DC8 RID: 24008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04005DC9 RID: 24009
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

			// Token: 0x04005DCA RID: 24010
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0;

			// Token: 0x04005DCB RID: 24011
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0;
		}

		// Token: 0x020005FE RID: 1534
		public sealed class GetSelectionConfigurationCallback : MulticastDelegate
		{
			// Token: 0x06009022 RID: 36898 RVA: 0x00272D38 File Offset: 0x00270F38
			// Note: this type is marked as 'beforefieldinit'.
			static GetSelectionConfigurationCallback()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "GetSelectionConfigurationCallback");
				DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>.NativeClassPtr, 100666950);
				DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>.NativeClassPtr, 100666951);
				DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>.NativeClassPtr, 100666952);
				DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>.NativeClassPtr, 100666953);
			}

			// Token: 0x06009023 RID: 36899 RVA: 0x00272DAC File Offset: 0x00270FAC
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 58093, RefRangeEnd = 58167, XrefRangeStart = 58093, XrefRangeEnd = 58167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetSelectionConfigurationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009024 RID: 36900 RVA: 0x00272E08 File Offset: 0x00271008
			[CallerCount(0)]
			public unsafe void Invoke(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x06009025 RID: 36901 RVA: 0x00272E98 File Offset: 0x00271098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58172, XrefRangeEnd = 58176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
				IntPtr intPtr6 = intPtr3;
				return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
			}

			// Token: 0x06009026 RID: 36902 RVA: 0x00272F5C File Offset: 0x0027115C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(out string title, out bool availability, out Action onInteract, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x06009027 RID: 36903 RVA: 0x0004E27D File Offset: 0x0004C47D
			public GetSelectionConfigurationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04005DCC RID: 24012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04005DCD RID: 24013
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

			// Token: 0x04005DCE RID: 24014
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0;

			// Token: 0x04005DCF RID: 24015
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0;
		}

		// Token: 0x020005FF RID: 1535
		public sealed class GetSpecialNPCSelectionConfigurationCallback : MulticastDelegate
		{
			// Token: 0x06009028 RID: 36904 RVA: 0x00272FEC File Offset: 0x002711EC
			// Note: this type is marked as 'beforefieldinit'.
			static GetSpecialNPCSelectionConfigurationCallback()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "GetSpecialNPCSelectionConfigurationCallback");
				DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>.NativeClassPtr, 100666954);
				DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>.NativeClassPtr, 100666955);
				DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>.NativeClassPtr, 100666956);
				DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>.NativeClassPtr, 100666957);
			}

			// Token: 0x06009029 RID: 36905 RVA: 0x00273060 File Offset: 0x00271260
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 58093, RefRangeEnd = 58167, XrefRangeStart = 58093, XrefRangeEnd = 58167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetSpecialNPCSelectionConfigurationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600902A RID: 36906 RVA: 0x002730BC File Offset: 0x002712BC
			[CallerCount(0)]
			public unsafe void Invoke(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600902B RID: 36907 RVA: 0x0027314C File Offset: 0x0027134C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58176, XrefRangeEnd = 58180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
				IntPtr intPtr6 = intPtr3;
				return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
			}

			// Token: 0x0600902C RID: 36908 RVA: 0x00273210 File Offset: 0x00271410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(out string title, out bool availability, out Action onInteract, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600902D RID: 36909 RVA: 0x0004E286 File Offset: 0x0004C486
			public GetSpecialNPCSelectionConfigurationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04005DD0 RID: 24016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04005DD1 RID: 24017
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

			// Token: 0x04005DD2 RID: 24018
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_AsyncCallback_Object_0;

			// Token: 0x04005DD3 RID: 24019
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_String_byref_Boolean_byref_Action_IAsyncResult_0;
		}

		// Token: 0x02000600 RID: 1536
		public class SpecialNPCInteractData : DaySceneChatSelectionPannel.NormalNPCInteractData
		{
			// Token: 0x0600902E RID: 36910 RVA: 0x002732A0 File Offset: 0x002714A0
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialNPCInteractData()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialNPCInteractData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "SpecialNPCInteractData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialNPCInteractData>.NativeClassPtr);
				DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeFieldInfoPtr_npcKizunaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialNPCInteractData>.NativeClassPtr, "npcKizunaLevel");
				DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeFieldInfoPtr_statusTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialNPCInteractData>.NativeClassPtr, "statusTracker");
				DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrackedMerchant_StatusTracker_Func_2_String_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialNPCInteractData>.NativeClassPtr, 100666958);
			}

			// Token: 0x0600902F RID: 36911 RVA: 0x00273308 File Offset: 0x00271508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58180, XrefRangeEnd = 58182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialNPCInteractData(string characterLabel, int npcKizunaLevel, TrackedMerchant merchantData, StatusTracker statusTracker, Func<string, string> getPhraseCallback, Action closePannelCallback, Action refreshSelectionCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialNPCInteractData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref npcKizunaLevel;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusTracker);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getPhraseCallback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refreshSelectionCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrackedMerchant_StatusTracker_Func_2_String_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009030 RID: 36912 RVA: 0x0004E28F File Offset: 0x0004C48F
			public SpecialNPCInteractData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003030 RID: 12336
			// (get) Token: 0x06009031 RID: 36913 RVA: 0x002733C0 File Offset: 0x002715C0
			// (set) Token: 0x06009032 RID: 36914 RVA: 0x0004E298 File Offset: 0x0004C498
			public unsafe int npcKizunaLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeFieldInfoPtr_npcKizunaLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeFieldInfoPtr_npcKizunaLevel)) = value;
				}
			}

			// Token: 0x17003031 RID: 12337
			// (get) Token: 0x06009033 RID: 36915 RVA: 0x002733E8 File Offset: 0x002715E8
			// (set) Token: 0x06009034 RID: 36916 RVA: 0x0004E2B3 File Offset: 0x0004C4B3
			public unsafe StatusTracker statusTracker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeFieldInfoPtr_statusTracker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusTracker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialNPCInteractData.NativeFieldInfoPtr_statusTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DD4 RID: 24020
			private static readonly IntPtr NativeFieldInfoPtr_npcKizunaLevel;

			// Token: 0x04005DD5 RID: 24021
			private static readonly IntPtr NativeFieldInfoPtr_statusTracker;

			// Token: 0x04005DD6 RID: 24022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrackedMerchant_StatusTracker_Func_2_String_String_Action_Action_0;
		}

		// Token: 0x02000601 RID: 1537
		public class NormalNPCInteractData : DaySceneChatSelectionPannel.BaseInteractData
		{
			// Token: 0x06009035 RID: 36917 RVA: 0x00273418 File Offset: 0x00271618
			// Note: this type is marked as 'beforefieldinit'.
			static NormalNPCInteractData()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalNPCInteractData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "NormalNPCInteractData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalNPCInteractData>.NativeClassPtr);
				DaySceneChatSelectionPannel.NormalNPCInteractData.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalNPCInteractData>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.NormalNPCInteractData.NativeFieldInfoPtr_merchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalNPCInteractData>.NativeClassPtr, "merchantData");
				DaySceneChatSelectionPannel.NormalNPCInteractData.NativeMethodInfoPtr__ctor_Public_Void_String_TrackedMerchant_Func_2_String_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalNPCInteractData>.NativeClassPtr, 100666959);
			}

			// Token: 0x06009036 RID: 36918 RVA: 0x00273480 File Offset: 0x00271680
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58188, RefRangeEnd = 58190, XrefRangeStart = 58182, XrefRangeEnd = 58188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NormalNPCInteractData(string characterLabel, TrackedMerchant merchantData, Func<string, string> getPhraseCallback, Action closePannelCallback, Action refreshSelectionCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalNPCInteractData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getPhraseCallback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refreshSelectionCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NormalNPCInteractData.NativeMethodInfoPtr__ctor_Public_Void_String_TrackedMerchant_Func_2_String_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009037 RID: 36919 RVA: 0x0004E2D2 File Offset: 0x0004C4D2
			public NormalNPCInteractData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003032 RID: 12338
			// (get) Token: 0x06009038 RID: 36920 RVA: 0x00273518 File Offset: 0x00271718
			// (set) Token: 0x06009039 RID: 36921 RVA: 0x0004E2DB File Offset: 0x0004C4DB
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalNPCInteractData.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalNPCInteractData.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003033 RID: 12339
			// (get) Token: 0x0600903A RID: 36922 RVA: 0x00273540 File Offset: 0x00271740
			// (set) Token: 0x0600903B RID: 36923 RVA: 0x0004E2FA File Offset: 0x0004C4FA
			public unsafe TrackedMerchant merchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalNPCInteractData.NativeFieldInfoPtr_merchantData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalNPCInteractData.NativeFieldInfoPtr_merchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DD7 RID: 24023
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005DD8 RID: 24024
			private static readonly IntPtr NativeFieldInfoPtr_merchantData;

			// Token: 0x04005DD9 RID: 24025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TrackedMerchant_Func_2_String_String_Action_Action_0;
		}

		// Token: 0x02000602 RID: 1538
		public class BaseInteractData : Il2CppSystem.Object
		{
			// Token: 0x0600903C RID: 36924 RVA: 0x00273570 File Offset: 0x00271770
			// Note: this type is marked as 'beforefieldinit'.
			static BaseInteractData()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "BaseInteractData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr);
				DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_closeChatSelectionPannelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr, "closeChatSelectionPannelCallback");
				DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_getPhraseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr, "getPhraseCallback");
				DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_refreshSelectionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr, "refreshSelectionCallback");
				DaySceneChatSelectionPannel.BaseInteractData.NativeMethodInfoPtr__ctor_Public_Void_Func_2_String_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr, 100666960);
			}

			// Token: 0x0600903D RID: 36925 RVA: 0x002735EC File Offset: 0x002717EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58190, XrefRangeEnd = 58194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseInteractData(Func<string, string> getPhraseCallback, Action closePannelCallback, Action refreshSelectionCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseInteractData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getPhraseCallback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refreshSelectionCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.BaseInteractData.NativeMethodInfoPtr__ctor_Public_Void_Func_2_String_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600903E RID: 36926 RVA: 0x0004E319 File Offset: 0x0004C519
			public BaseInteractData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003034 RID: 12340
			// (get) Token: 0x0600903F RID: 36927 RVA: 0x0027365C File Offset: 0x0027185C
			// (set) Token: 0x06009040 RID: 36928 RVA: 0x0004E322 File Offset: 0x0004C522
			public unsafe Action closeChatSelectionPannelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_closeChatSelectionPannelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_closeChatSelectionPannelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003035 RID: 12341
			// (get) Token: 0x06009041 RID: 36929 RVA: 0x0027368C File Offset: 0x0027188C
			// (set) Token: 0x06009042 RID: 36930 RVA: 0x0004E341 File Offset: 0x0004C541
			public unsafe Func<string, string> getPhraseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_getPhraseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_getPhraseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003036 RID: 12342
			// (get) Token: 0x06009043 RID: 36931 RVA: 0x002736BC File Offset: 0x002718BC
			// (set) Token: 0x06009044 RID: 36932 RVA: 0x0004E360 File Offset: 0x0004C560
			public unsafe Action refreshSelectionCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_refreshSelectionCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.BaseInteractData.NativeFieldInfoPtr_refreshSelectionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DDA RID: 24026
			private static readonly IntPtr NativeFieldInfoPtr_closeChatSelectionPannelCallback;

			// Token: 0x04005DDB RID: 24027
			private static readonly IntPtr NativeFieldInfoPtr_getPhraseCallback;

			// Token: 0x04005DDC RID: 24028
			private static readonly IntPtr NativeFieldInfoPtr_refreshSelectionCallback;

			// Token: 0x04005DDD RID: 24029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_String_String_Action_Action_0;
		}

		// Token: 0x02000603 RID: 1539
		public class BaseOpenContext : Il2CppSystem.Object
		{
			// Token: 0x06009045 RID: 36933 RVA: 0x002736EC File Offset: 0x002718EC
			// Note: this type is marked as 'beforefieldinit'.
			static BaseOpenContext()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "BaseOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseOpenContext>.NativeClassPtr);
				DaySceneChatSelectionPannel.BaseOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Abstract_Virtual_New_get_OpenContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseOpenContext>.NativeClassPtr, 100666961);
				DaySceneChatSelectionPannel.BaseOpenContext.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseOpenContext>.NativeClassPtr, 100666962);
			}

			// Token: 0x17003037 RID: 12343
			// (get) Token: 0x06009046 RID: 36934 RVA: 0x00273740 File Offset: 0x00271940
			public unsafe virtual DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.BaseOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Abstract_Virtual_New_get_OpenContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009047 RID: 36935 RVA: 0x00273788 File Offset: 0x00271988
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseOpenContext() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.BaseOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.BaseOpenContext.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009048 RID: 36936 RVA: 0x0004E37F File Offset: 0x0004C57F
			public BaseOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04005DDE RID: 24030
			private static readonly IntPtr NativeMethodInfoPtr_get_ContextType_Public_Abstract_Virtual_New_get_OpenContextType_0;

			// Token: 0x04005DDF RID: 24031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x02000FBD RID: 4029
			public enum OpenContextType
			{
				// Token: 0x0400AF76 RID: 44918
				General,
				// Token: 0x0400AF77 RID: 44919
				Normal,
				// Token: 0x0400AF78 RID: 44920
				Special
			}
		}

		// Token: 0x02000604 RID: 1540
		public class SpecialGuestOpenContext : DaySceneChatSelectionPannel.BaseOpenContext
		{
			// Token: 0x06009049 RID: 36937 RVA: 0x002737C4 File Offset: 0x002719C4
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialGuestOpenContext()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "SpecialGuestOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr);
				DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_CharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr, "CharacterLabel");
				DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_OnWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr, "OnWillExecuteDayEndEventCallback");
				DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_ShouldTriggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr, "ShouldTriggerEvent");
				DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr, 100666963);
				DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr, 100666964);
			}

			// Token: 0x0600904A RID: 36938 RVA: 0x00273854 File Offset: 0x00271A54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58194, XrefRangeEnd = 58197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuestOpenContext(string characterLabel, bool shouldTriggerEvent, Action<Action> onWillExecuteDayEndEventCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.SpecialGuestOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Action_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700303B RID: 12347
			// (get) Token: 0x0600904B RID: 36939 RVA: 0x002738C0 File Offset: 0x00271AC0
			public unsafe override DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600904C RID: 36940 RVA: 0x0004E388 File Offset: 0x0004C588
			public SpecialGuestOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003038 RID: 12344
			// (get) Token: 0x0600904D RID: 36941 RVA: 0x00273908 File Offset: 0x00271B08
			// (set) Token: 0x0600904E RID: 36942 RVA: 0x0004E391 File Offset: 0x0004C591
			public unsafe string CharacterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_CharacterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_CharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003039 RID: 12345
			// (get) Token: 0x0600904F RID: 36943 RVA: 0x00273930 File Offset: 0x00271B30
			// (set) Token: 0x06009050 RID: 36944 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
			public unsafe Action<Action> OnWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_OnWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_OnWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700303A RID: 12346
			// (get) Token: 0x06009051 RID: 36945 RVA: 0x00273960 File Offset: 0x00271B60
			// (set) Token: 0x06009052 RID: 36946 RVA: 0x0004E3CF File Offset: 0x0004C5CF
			public unsafe bool ShouldTriggerEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_ShouldTriggerEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.SpecialGuestOpenContext.NativeFieldInfoPtr_ShouldTriggerEvent)) = value;
				}
			}

			// Token: 0x04005DE0 RID: 24032
			private static readonly IntPtr NativeFieldInfoPtr_CharacterLabel;

			// Token: 0x04005DE1 RID: 24033
			private static readonly IntPtr NativeFieldInfoPtr_OnWillExecuteDayEndEventCallback;

			// Token: 0x04005DE2 RID: 24034
			private static readonly IntPtr NativeFieldInfoPtr_ShouldTriggerEvent;

			// Token: 0x04005DE3 RID: 24035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Action_1_Action_0;

			// Token: 0x04005DE4 RID: 24036
			private static readonly IntPtr NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0;
		}

		// Token: 0x02000605 RID: 1541
		public class NormalGuestOpenContext : DaySceneChatSelectionPannel.BaseOpenContext
		{
			// Token: 0x06009053 RID: 36947 RVA: 0x00273988 File Offset: 0x00271B88
			// Note: this type is marked as 'beforefieldinit'.
			static NormalGuestOpenContext()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "NormalGuestOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr);
				DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_CharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr, "CharacterLabel");
				DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_MerchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr, "MerchantData");
				DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_Selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr, "Selections");
				DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_String_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr, 100666965);
				DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr, 100666966);
			}

			// Token: 0x06009054 RID: 36948 RVA: 0x00273A18 File Offset: 0x00271C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58197, XrefRangeEnd = 58201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NormalGuestOpenContext(Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback> selections, string characterLabel, TrackedMerchant merchantData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.NormalGuestOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_String_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700303F RID: 12351
			// (get) Token: 0x06009055 RID: 36949 RVA: 0x00273A88 File Offset: 0x00271C88
			public unsafe override DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009056 RID: 36950 RVA: 0x0004E3EA File Offset: 0x0004C5EA
			public NormalGuestOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700303C RID: 12348
			// (get) Token: 0x06009057 RID: 36951 RVA: 0x00273AD0 File Offset: 0x00271CD0
			// (set) Token: 0x06009058 RID: 36952 RVA: 0x0004E3F3 File Offset: 0x0004C5F3
			public unsafe string CharacterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_CharacterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_CharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700303D RID: 12349
			// (get) Token: 0x06009059 RID: 36953 RVA: 0x00273AF8 File Offset: 0x00271CF8
			// (set) Token: 0x0600905A RID: 36954 RVA: 0x0004E412 File Offset: 0x0004C612
			public unsafe TrackedMerchant MerchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_MerchantData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_MerchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700303E RID: 12350
			// (get) Token: 0x0600905B RID: 36955 RVA: 0x00273B28 File Offset: 0x00271D28
			// (set) Token: 0x0600905C RID: 36956 RVA: 0x0004E431 File Offset: 0x0004C631
			public unsafe Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback> Selections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_Selections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.NormalGuestOpenContext.NativeFieldInfoPtr_Selections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DE5 RID: 24037
			private static readonly IntPtr NativeFieldInfoPtr_CharacterLabel;

			// Token: 0x04005DE6 RID: 24038
			private static readonly IntPtr NativeFieldInfoPtr_MerchantData;

			// Token: 0x04005DE7 RID: 24039
			private static readonly IntPtr NativeFieldInfoPtr_Selections;

			// Token: 0x04005DE8 RID: 24040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_String_TrackedMerchant_0;

			// Token: 0x04005DE9 RID: 24041
			private static readonly IntPtr NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0;
		}

		// Token: 0x02000606 RID: 1542
		public class GeneralOpenContext : DaySceneChatSelectionPannel.BaseOpenContext
		{
			// Token: 0x0600905D RID: 36957 RVA: 0x00273B58 File Offset: 0x00271D58
			// Note: this type is marked as 'beforefieldinit'.
			static GeneralOpenContext()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "GeneralOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr);
				DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_EndButtonTitleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, "EndButtonTitleKey");
				DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_IndexToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, "IndexToSelect");
				DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_OnEndButtonSubmitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, "OnEndButtonSubmitCallback");
				DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_Selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, "Selections");
				DaySceneChatSelectionPannel.GeneralOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_Int32_EndButtonCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, 100666967);
				DaySceneChatSelectionPannel.GeneralOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, 100666968);
			}

			// Token: 0x0600905E RID: 36958 RVA: 0x00273BFC File Offset: 0x00271DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58245, XrefRangeEnd = 58249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GeneralOpenContext(Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> selections, string endButtonTitleKey, int indexToSelect, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback onEndButtonSubmitCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endButtonTitleKey);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexToSelect;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEndButtonSubmitCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GeneralOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_Int32_EndButtonCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003044 RID: 12356
			// (get) Token: 0x0600905F RID: 36959 RVA: 0x00273C7C File Offset: 0x00271E7C
			public unsafe override DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[CallerCount(84)]
				[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatSelectionPannel.GeneralOpenContext.NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009060 RID: 36960 RVA: 0x0004E450 File Offset: 0x0004C650
			public GeneralOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003040 RID: 12352
			// (get) Token: 0x06009061 RID: 36961 RVA: 0x00273CC4 File Offset: 0x00271EC4
			// (set) Token: 0x06009062 RID: 36962 RVA: 0x0004E459 File Offset: 0x0004C659
			public unsafe string EndButtonTitleKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_EndButtonTitleKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_EndButtonTitleKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003041 RID: 12353
			// (get) Token: 0x06009063 RID: 36963 RVA: 0x00273CEC File Offset: 0x00271EEC
			// (set) Token: 0x06009064 RID: 36964 RVA: 0x0004E478 File Offset: 0x0004C678
			public unsafe int IndexToSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_IndexToSelect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_IndexToSelect)) = value;
				}
			}

			// Token: 0x17003042 RID: 12354
			// (get) Token: 0x06009065 RID: 36965 RVA: 0x00273D14 File Offset: 0x00271F14
			// (set) Token: 0x06009066 RID: 36966 RVA: 0x0004E493 File Offset: 0x0004C693
			public unsafe DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback OnEndButtonSubmitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_OnEndButtonSubmitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_OnEndButtonSubmitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003043 RID: 12355
			// (get) Token: 0x06009067 RID: 36967 RVA: 0x00273D44 File Offset: 0x00271F44
			// (set) Token: 0x06009068 RID: 36968 RVA: 0x0004E4B2 File Offset: 0x0004C6B2
			public unsafe Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> Selections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_Selections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.GeneralOpenContext.NativeFieldInfoPtr_Selections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DEA RID: 24042
			private static readonly IntPtr NativeFieldInfoPtr_EndButtonTitleKey;

			// Token: 0x04005DEB RID: 24043
			private static readonly IntPtr NativeFieldInfoPtr_IndexToSelect;

			// Token: 0x04005DEC RID: 24044
			private static readonly IntPtr NativeFieldInfoPtr_OnEndButtonSubmitCallback;

			// Token: 0x04005DED RID: 24045
			private static readonly IntPtr NativeFieldInfoPtr_Selections;

			// Token: 0x04005DEE RID: 24046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_Int32_EndButtonCallback_0;

			// Token: 0x04005DEF RID: 24047
			private static readonly IntPtr NativeMethodInfoPtr_get_ContextType_Public_Virtual_get_OpenContextType_0;

			// Token: 0x02000FBE RID: 4030
			public sealed class EndButtonCallback : MulticastDelegate
			{
				// Token: 0x060115D7 RID: 71127 RVA: 0x003FE3BC File Offset: 0x003FC5BC
				// Note: this type is marked as 'beforefieldinit'.
				static EndButtonCallback()
				{
					Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext>.NativeClassPtr, "EndButtonCallback");
					DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>.NativeClassPtr, 100666969);
					DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>.NativeClassPtr, 100666970);
					DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>.NativeClassPtr, 100666971);
					DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>.NativeClassPtr, 100666972);
				}

				// Token: 0x060115D8 RID: 71128 RVA: 0x003FE430 File Offset: 0x003FC630
				[CallerCount(31)]
				[CachedScanResults(RefRangeStart = 58208, RefRangeEnd = 58239, XrefRangeStart = 58201, XrefRangeEnd = 58208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EndButtonCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115D9 RID: 71129 RVA: 0x003FE48C File Offset: 0x003FC68C
				[CallerCount(0)]
				public unsafe void Invoke(Action closePannelCallback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115DA RID: 71130 RVA: 0x003FE4D0 File Offset: 0x003FC6D0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 58240, RefRangeEnd = 58242, XrefRangeStart = 58239, XrefRangeEnd = 58240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(Action closePannelCallback, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060115DB RID: 71131 RVA: 0x003FE544 File Offset: 0x003FC744
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 58243, RefRangeEnd = 58245, XrefRangeStart = 58242, XrefRangeEnd = 58243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115DC RID: 71132 RVA: 0x00097279 File Offset: 0x00095479
				public EndButtonCallback(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060115DD RID: 71133 RVA: 0x00097282 File Offset: 0x00095482
				public static implicit operator DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback(Action<Action> A_0)
				{
					return DelegateSupport.ConvertDelegate<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(A_0);
				}

				// Token: 0x060115DE RID: 71134 RVA: 0x0009728A File Offset: 0x0009548A
				public static DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback operator +(DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback A_0, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>();
				}

				// Token: 0x060115DF RID: 71135 RVA: 0x00097298 File Offset: 0x00095498
				public static DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback operator -(DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback A_0, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback A_1)
				{
					Delegate result;
					Delegate @delegate = result = Delegate.Remove(A_0, A_1);
					if (@delegate != null)
					{
						result = @delegate.Cast<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>();
					}
					return result;
				}

				// Token: 0x0400AF79 RID: 44921
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400AF7A RID: 44922
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Action_0;

				// Token: 0x0400AF7B RID: 44923
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0;

				// Token: 0x0400AF7C RID: 44924
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x02000607 RID: 1543
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x06009069 RID: 36969 RVA: 0x00273D74 File Offset: 0x00271F74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_endButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, "endButtonAction");
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_generalOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, "generalOpenContext");
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_endButtonSubmitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, "endButtonSubmitCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_prependSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, "prependSelections");
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_appendSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, "appendSelections");
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, 100666973);
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, 100666974);
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, 100666975);
				DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_SpecialGuestPublicExtraDialogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr, 100666976);
			}

			// Token: 0x0600906A RID: 36970 RVA: 0x00273E68 File Offset: 0x00272068
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600906B RID: 36971 RVA: 0x00273EA4 File Offset: 0x002720A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58249, XrefRangeEnd = 58256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600906C RID: 36972 RVA: 0x00273ED8 File Offset: 0x002720D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58256, XrefRangeEnd = 58259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData interactData, out string title, out bool availability, out Action onInteract)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600906D RID: 36973 RVA: 0x00273F68 File Offset: 0x00272168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58259, XrefRangeEnd = 58269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__9(SpecialGuestPublicExtraDialogData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_SpecialGuestPublicExtraDialogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600906E RID: 36974 RVA: 0x0004E4D1 File Offset: 0x0004C6D1
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003045 RID: 12357
			// (get) Token: 0x0600906F RID: 36975 RVA: 0x00273FAC File Offset: 0x002721AC
			// (set) Token: 0x06009070 RID: 36976 RVA: 0x0004E4DA File Offset: 0x0004C6DA
			public unsafe DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback endButtonAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_endButtonAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_endButtonAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003046 RID: 12358
			// (get) Token: 0x06009071 RID: 36977 RVA: 0x00273FDC File Offset: 0x002721DC
			// (set) Token: 0x06009072 RID: 36978 RVA: 0x0004E4F9 File Offset: 0x0004C6F9
			public unsafe DaySceneChatSelectionPannel.GeneralOpenContext generalOpenContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_generalOpenContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_generalOpenContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003047 RID: 12359
			// (get) Token: 0x06009073 RID: 36979 RVA: 0x0027400C File Offset: 0x0027220C
			// (set) Token: 0x06009074 RID: 36980 RVA: 0x0004E518 File Offset: 0x0004C718
			public unsafe Action endButtonSubmitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_endButtonSubmitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_endButtonSubmitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003048 RID: 12360
			// (get) Token: 0x06009075 RID: 36981 RVA: 0x0027403C File Offset: 0x0027223C
			// (set) Token: 0x06009076 RID: 36982 RVA: 0x0004E537 File Offset: 0x0004C737
			public unsafe List<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_prependSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_prependSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003049 RID: 12361
			// (get) Token: 0x06009077 RID: 36983 RVA: 0x0027406C File Offset: 0x0027226C
			// (set) Token: 0x06009078 RID: 36984 RVA: 0x0004E556 File Offset: 0x0004C756
			public unsafe List<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_appendSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr_appendSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304A RID: 12362
			// (get) Token: 0x06009079 RID: 36985 RVA: 0x0027409C File Offset: 0x0027229C
			// (set) Token: 0x0600907A RID: 36986 RVA: 0x0004E575 File Offset: 0x0004C775
			public unsafe DaySceneChatSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DF0 RID: 24048
			private static readonly IntPtr NativeFieldInfoPtr_endButtonAction;

			// Token: 0x04005DF1 RID: 24049
			private static readonly IntPtr NativeFieldInfoPtr_generalOpenContext;

			// Token: 0x04005DF2 RID: 24050
			private static readonly IntPtr NativeFieldInfoPtr_endButtonSubmitCallback;

			// Token: 0x04005DF3 RID: 24051
			private static readonly IntPtr NativeFieldInfoPtr_prependSelections;

			// Token: 0x04005DF4 RID: 24052
			private static readonly IntPtr NativeFieldInfoPtr_appendSelections;

			// Token: 0x04005DF5 RID: 24053
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005DF6 RID: 24054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005DF7 RID: 24055
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_0;

			// Token: 0x04005DF8 RID: 24056
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x04005DF9 RID: 24057
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_SpecialGuestPublicExtraDialogData_0;
		}

		// Token: 0x02000608 RID: 1544
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600907B RID: 36987 RVA: 0x002740CC File Offset: 0x002722CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__16_2");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__16_4");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__16_7");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__20_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__20_3");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__20_1");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__22_6");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__22_0");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__22_1");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__22_2");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__22_4");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__23_0");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__23_1");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__23_2");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__26_0");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__26_2");
				DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, "<>9__26_3");
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666978);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__16_2_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666979);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__16_4_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666980);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__16_7_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666981);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__FillterCollection_b__20_3_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666982);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__FillterCollection_b__20_1_Internal_IEnumerable_1_Int32_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666983);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_0_Internal_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666984);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_6_Internal_IEnumerable_1_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666985);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_1_Internal_Boolean_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666986);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666987);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_4_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666988);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestBeverages_b__23_0_Internal_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666989);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestBeverages_b__23_1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666990);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestBeverages_b__23_2_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666991);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__CommitSpecGuest_b__26_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666992);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__CommitSpecGuest_b__26_2_Internal_Boolean_ProbabilityDrivenProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666993);
				DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__CommitSpecGuest_b__26_3_Internal_Product_ProbabilityDrivenProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr, 100666994);
			}

			// Token: 0x0600907C RID: 36988 RVA: 0x002743A0 File Offset: 0x002725A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600907D RID: 36989 RVA: 0x002743DC File Offset: 0x002725DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58269, XrefRangeEnd = 58273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPanelOpen_b__16_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__16_2_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600907E RID: 36990 RVA: 0x00274424 File Offset: 0x00272624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58273, XrefRangeEnd = 58277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPanelOpen_b__16_4(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__16_4_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600907F RID: 36991 RVA: 0x0027446C File Offset: 0x0027266C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58277, XrefRangeEnd = 58281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPanelOpen_b__16_7(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__16_7_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009080 RID: 36992 RVA: 0x002744B4 File Offset: 0x002726B4
			[CallerCount(0)]
			public unsafe int _FillterCollection_b__20_3(SpecialGuest.WeightedTag xy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__FillterCollection_b__20_3_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009081 RID: 36993 RVA: 0x00274504 File Offset: 0x00272704
			[CallerCount(0)]
			public unsafe IEnumerable<int> _FillterCollection_b__20_1(ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__FillterCollection_b__20_1_Internal_IEnumerable_1_Int32_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06009082 RID: 36994 RVA: 0x0027455C File Offset: 0x0027275C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58281, XrefRangeEnd = 58304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>> _RequestIngredient_b__22_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_0_Internal_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>(pointer);
			}

			// Token: 0x06009083 RID: 36995 RVA: 0x002745A0 File Offset: 0x002727A0
			[CallerCount(0)]
			public unsafe IEnumerable<int> _RequestIngredient_b__22_6(Recipe xy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_6_Internal_IEnumerable_1_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06009084 RID: 36996 RVA: 0x002745F0 File Offset: 0x002727F0
			[CallerCount(0)]
			public unsafe bool _RequestIngredient_b__22_1(ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_1_Internal_Boolean_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009085 RID: 36997 RVA: 0x00274644 File Offset: 0x00272844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58304, XrefRangeEnd = 58305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RequestIngredient_b__22_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009086 RID: 36998 RVA: 0x00274690 File Offset: 0x00272890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RequestIngredient_b__22_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestIngredient_b__22_4_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009087 RID: 36999 RVA: 0x002746DC File Offset: 0x002728DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58305, XrefRangeEnd = 58312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>> _RequestBeverages_b__23_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestBeverages_b__23_0_Internal_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>(pointer);
			}

			// Token: 0x06009088 RID: 37000 RVA: 0x00274720 File Offset: 0x00272920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58312, XrefRangeEnd = 58316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RequestBeverages_b__23_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestBeverages_b__23_1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009089 RID: 37001 RVA: 0x0027476C File Offset: 0x0027296C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RequestBeverages_b__23_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__RequestBeverages_b__23_2_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600908A RID: 37002 RVA: 0x002747B8 File Offset: 0x002729B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58316, XrefRangeEnd = 58318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CommitSpecGuest_b__26_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__CommitSpecGuest_b__26_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600908B RID: 37003 RVA: 0x00274808 File Offset: 0x00272A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58318, XrefRangeEnd = 58319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CommitSpecGuest_b__26_2(Collectable.ProbabilityDrivenProduct x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__CommitSpecGuest_b__26_2_Internal_Boolean_ProbabilityDrivenProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600908C RID: 37004 RVA: 0x0027485C File Offset: 0x00272A5C
			[CallerCount(0)]
			public unsafe Product _CommitSpecGuest_b__26_3(Collectable.ProbabilityDrivenProduct x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c.NativeMethodInfoPtr__CommitSpecGuest_b__26_3_Internal_Product_ProbabilityDrivenProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x0600908D RID: 37005 RVA: 0x0004E594 File Offset: 0x0004C794
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700304B RID: 12363
			// (get) Token: 0x0600908E RID: 37006 RVA: 0x002748AC File Offset: 0x00272AAC
			// (set) Token: 0x0600908F RID: 37007 RVA: 0x0004E59D File Offset: 0x0004C79D
			public unsafe static DaySceneChatSelectionPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304C RID: 12364
			// (get) Token: 0x06009090 RID: 37008 RVA: 0x002748D4 File Offset: 0x00272AD4
			// (set) Token: 0x06009091 RID: 37009 RVA: 0x0004E5AF File Offset: 0x0004C7AF
			public unsafe static Func<string, string> __9__16_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304D RID: 12365
			// (get) Token: 0x06009092 RID: 37010 RVA: 0x002748FC File Offset: 0x00272AFC
			// (set) Token: 0x06009093 RID: 37011 RVA: 0x0004E5C1 File Offset: 0x0004C7C1
			public unsafe static Func<string, string> __9__16_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304E RID: 12366
			// (get) Token: 0x06009094 RID: 37012 RVA: 0x00274924 File Offset: 0x00272B24
			// (set) Token: 0x06009095 RID: 37013 RVA: 0x0004E5D3 File Offset: 0x0004C7D3
			public unsafe static Func<string, string> __9__16_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__16_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304F RID: 12367
			// (get) Token: 0x06009096 RID: 37014 RVA: 0x0027494C File Offset: 0x00272B4C
			// (set) Token: 0x06009097 RID: 37015 RVA: 0x0004E5E5 File Offset: 0x0004C7E5
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__20_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__20_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__20_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003050 RID: 12368
			// (get) Token: 0x06009098 RID: 37016 RVA: 0x00274974 File Offset: 0x00272B74
			// (set) Token: 0x06009099 RID: 37017 RVA: 0x0004E5F7 File Offset: 0x0004C7F7
			public unsafe static Func<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>, IEnumerable<int>> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003051 RID: 12369
			// (get) Token: 0x0600909A RID: 37018 RVA: 0x0027499C File Offset: 0x00272B9C
			// (set) Token: 0x0600909B RID: 37019 RVA: 0x0004E609 File Offset: 0x0004C809
			public unsafe static Func<Recipe, IEnumerable<int>> __9__22_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003052 RID: 12370
			// (get) Token: 0x0600909C RID: 37020 RVA: 0x002749C4 File Offset: 0x00272BC4
			// (set) Token: 0x0600909D RID: 37021 RVA: 0x0004E61B File Offset: 0x0004C81B
			public unsafe static Func<int, ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003053 RID: 12371
			// (get) Token: 0x0600909E RID: 37022 RVA: 0x002749EC File Offset: 0x00272BEC
			// (set) Token: 0x0600909F RID: 37023 RVA: 0x0004E62D File Offset: 0x0004C82D
			public unsafe static Func<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>, bool> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003054 RID: 12372
			// (get) Token: 0x060090A0 RID: 37024 RVA: 0x00274A14 File Offset: 0x00272C14
			// (set) Token: 0x060090A1 RID: 37025 RVA: 0x0004E63F File Offset: 0x0004C83F
			public unsafe static Func<int, bool> __9__22_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003055 RID: 12373
			// (get) Token: 0x060090A2 RID: 37026 RVA: 0x00274A3C File Offset: 0x00272C3C
			// (set) Token: 0x060090A3 RID: 37027 RVA: 0x0004E651 File Offset: 0x0004C851
			public unsafe static Func<int, int> __9__22_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__22_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003056 RID: 12374
			// (get) Token: 0x060090A4 RID: 37028 RVA: 0x00274A64 File Offset: 0x00272C64
			// (set) Token: 0x060090A5 RID: 37029 RVA: 0x0004E663 File Offset: 0x0004C863
			public unsafe static Func<int, ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003057 RID: 12375
			// (get) Token: 0x060090A6 RID: 37030 RVA: 0x00274A8C File Offset: 0x00272C8C
			// (set) Token: 0x060090A7 RID: 37031 RVA: 0x0004E675 File Offset: 0x0004C875
			public unsafe static Func<int, bool> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003058 RID: 12376
			// (get) Token: 0x060090A8 RID: 37032 RVA: 0x00274AB4 File Offset: 0x00272CB4
			// (set) Token: 0x060090A9 RID: 37033 RVA: 0x0004E687 File Offset: 0x0004C887
			public unsafe static Func<int, int> __9__23_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__23_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003059 RID: 12377
			// (get) Token: 0x060090AA RID: 37034 RVA: 0x00274ADC File Offset: 0x00272CDC
			// (set) Token: 0x060090AB RID: 37035 RVA: 0x0004E699 File Offset: 0x0004C899
			public unsafe static Func<string, bool> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305A RID: 12378
			// (get) Token: 0x060090AC RID: 37036 RVA: 0x00274B04 File Offset: 0x00272D04
			// (set) Token: 0x060090AD RID: 37037 RVA: 0x0004E6AB File Offset: 0x0004C8AB
			public unsafe static Func<Collectable.ProbabilityDrivenProduct, bool> __9__26_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collectable.ProbabilityDrivenProduct, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305B RID: 12379
			// (get) Token: 0x060090AE RID: 37038 RVA: 0x00274B2C File Offset: 0x00272D2C
			// (set) Token: 0x060090AF RID: 37039 RVA: 0x0004E6BD File Offset: 0x0004C8BD
			public unsafe static Func<Collectable.ProbabilityDrivenProduct, Product> __9__26_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collectable.ProbabilityDrivenProduct, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneChatSelectionPannel.__c.NativeFieldInfoPtr___9__26_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DFA RID: 24058
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005DFB RID: 24059
			private static readonly IntPtr NativeFieldInfoPtr___9__16_2;

			// Token: 0x04005DFC RID: 24060
			private static readonly IntPtr NativeFieldInfoPtr___9__16_4;

			// Token: 0x04005DFD RID: 24061
			private static readonly IntPtr NativeFieldInfoPtr___9__16_7;

			// Token: 0x04005DFE RID: 24062
			private static readonly IntPtr NativeFieldInfoPtr___9__20_3;

			// Token: 0x04005DFF RID: 24063
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x04005E00 RID: 24064
			private static readonly IntPtr NativeFieldInfoPtr___9__22_6;

			// Token: 0x04005E01 RID: 24065
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04005E02 RID: 24066
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x04005E03 RID: 24067
			private static readonly IntPtr NativeFieldInfoPtr___9__22_2;

			// Token: 0x04005E04 RID: 24068
			private static readonly IntPtr NativeFieldInfoPtr___9__22_4;

			// Token: 0x04005E05 RID: 24069
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04005E06 RID: 24070
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04005E07 RID: 24071
			private static readonly IntPtr NativeFieldInfoPtr___9__23_2;

			// Token: 0x04005E08 RID: 24072
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04005E09 RID: 24073
			private static readonly IntPtr NativeFieldInfoPtr___9__26_2;

			// Token: 0x04005E0A RID: 24074
			private static readonly IntPtr NativeFieldInfoPtr___9__26_3;

			// Token: 0x04005E0B RID: 24075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E0C RID: 24076
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__16_2_Internal_String_String_0;

			// Token: 0x04005E0D RID: 24077
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__16_4_Internal_String_String_0;

			// Token: 0x04005E0E RID: 24078
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__16_7_Internal_String_String_0;

			// Token: 0x04005E0F RID: 24079
			private static readonly IntPtr NativeMethodInfoPtr__FillterCollection_b__20_3_Internal_Int32_WeightedTag_0;

			// Token: 0x04005E10 RID: 24080
			private static readonly IntPtr NativeMethodInfoPtr__FillterCollection_b__20_1_Internal_IEnumerable_1_Int32_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04005E11 RID: 24081
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__22_0_Internal_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04005E12 RID: 24082
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__22_6_Internal_IEnumerable_1_Int32_Recipe_0;

			// Token: 0x04005E13 RID: 24083
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__22_1_Internal_Boolean_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04005E14 RID: 24084
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__22_2_Internal_Boolean_Int32_0;

			// Token: 0x04005E15 RID: 24085
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__22_4_Internal_Int32_Int32_0;

			// Token: 0x04005E16 RID: 24086
			private static readonly IntPtr NativeMethodInfoPtr__RequestBeverages_b__23_0_Internal_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04005E17 RID: 24087
			private static readonly IntPtr NativeMethodInfoPtr__RequestBeverages_b__23_1_Internal_Boolean_Int32_0;

			// Token: 0x04005E18 RID: 24088
			private static readonly IntPtr NativeMethodInfoPtr__RequestBeverages_b__23_2_Internal_Int32_Int32_0;

			// Token: 0x04005E19 RID: 24089
			private static readonly IntPtr NativeMethodInfoPtr__CommitSpecGuest_b__26_0_Internal_Boolean_String_0;

			// Token: 0x04005E1A RID: 24090
			private static readonly IntPtr NativeMethodInfoPtr__CommitSpecGuest_b__26_2_Internal_Boolean_ProbabilityDrivenProduct_0;

			// Token: 0x04005E1B RID: 24091
			private static readonly IntPtr NativeMethodInfoPtr__CommitSpecGuest_b__26_3_Internal_Product_ProbabilityDrivenProduct_0;
		}

		// Token: 0x02000609 RID: 1545
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x060090B0 RID: 37040 RVA: 0x00274B54 File Offset: 0x00272D54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_shouldTriggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, "shouldTriggerEvent");
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_currentCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, "currentCharacterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___9__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, "<>9__17");
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100666995);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100666996);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100666997);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100666998);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100666999);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100667000);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100667001);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100667002);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__GetConfigurationSet_b__17_Internal_Boolean_FinishCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100667003);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_String_String_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100667004);
				DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__GetConfigurationSet_b__8_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr, 100667005);
			}

			// Token: 0x060090B1 RID: 37041 RVA: 0x00274CC0 File Offset: 0x00272EC0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090B2 RID: 37042 RVA: 0x00274CFC File Offset: 0x00272EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58319, XrefRangeEnd = 58343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B3 RID: 37043 RVA: 0x00274D8C File Offset: 0x00272F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58343, XrefRangeEnd = 58371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B4 RID: 37044 RVA: 0x00274E1C File Offset: 0x0027301C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58371, XrefRangeEnd = 58391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_2(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B5 RID: 37045 RVA: 0x00274EAC File Offset: 0x002730AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58391, XrefRangeEnd = 58427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_3(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B6 RID: 37046 RVA: 0x00274F3C File Offset: 0x0027313C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58427, XrefRangeEnd = 58455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_4(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B7 RID: 37047 RVA: 0x00274FCC File Offset: 0x002731CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58455, XrefRangeEnd = 58483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_5(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_5, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B8 RID: 37048 RVA: 0x0027505C File Offset: 0x0027325C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58483, XrefRangeEnd = 58523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_6(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_6, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090B9 RID: 37049 RVA: 0x002750EC File Offset: 0x002732EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58523, XrefRangeEnd = 58524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConfigurationSet_b__17(MissionNode.FinishCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__GetConfigurationSet_b__17_Internal_Boolean_FinishCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060090BA RID: 37050 RVA: 0x00275140 File Offset: 0x00273340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58524, XrefRangeEnd = 58545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialNPCInteractData_String_String_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, string missionLabel, string overrideTitle, out string title, out bool availability, out Action onInteract)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(missionLabel);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideTitle);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_String_String_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090BB RID: 37051 RVA: 0x002751F4 File Offset: 0x002733F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58545, XrefRangeEnd = 58556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__8(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__GetConfigurationSet_b__8_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x060090BC RID: 37052 RVA: 0x0004E6CF File Offset: 0x0004C8CF
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700305C RID: 12380
			// (get) Token: 0x060090BD RID: 37053 RVA: 0x00275284 File Offset: 0x00273484
			// (set) Token: 0x060090BE RID: 37054 RVA: 0x0004E6D8 File Offset: 0x0004C8D8
			public unsafe DaySceneChatSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305D RID: 12381
			// (get) Token: 0x060090BF RID: 37055 RVA: 0x002752B4 File Offset: 0x002734B4
			// (set) Token: 0x060090C0 RID: 37056 RVA: 0x0004E6F7 File Offset: 0x0004C8F7
			public unsafe bool shouldTriggerEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_shouldTriggerEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_shouldTriggerEvent)) = value;
				}
			}

			// Token: 0x1700305E RID: 12382
			// (get) Token: 0x060090C1 RID: 37057 RVA: 0x002752DC File Offset: 0x002734DC
			// (set) Token: 0x060090C2 RID: 37058 RVA: 0x0004E712 File Offset: 0x0004C912
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305F RID: 12383
			// (get) Token: 0x060090C3 RID: 37059 RVA: 0x0027530C File Offset: 0x0027350C
			// (set) Token: 0x060090C4 RID: 37060 RVA: 0x0004E731 File Offset: 0x0004C931
			public unsafe string currentCharacterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_currentCharacterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_currentCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003060 RID: 12384
			// (get) Token: 0x060090C5 RID: 37061 RVA: 0x00275334 File Offset: 0x00273534
			// (set) Token: 0x060090C6 RID: 37062 RVA: 0x0004E750 File Offset: 0x0004C950
			public unsafe Func<MissionNode.FinishCondition, bool> __9__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___9__17);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MissionNode.FinishCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___9__17), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E1C RID: 24092
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E1D RID: 24093
			private static readonly IntPtr NativeFieldInfoPtr_shouldTriggerEvent;

			// Token: 0x04005E1E RID: 24094
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005E1F RID: 24095
			private static readonly IntPtr NativeFieldInfoPtr_currentCharacterLabel;

			// Token: 0x04005E20 RID: 24096
			private static readonly IntPtr NativeFieldInfoPtr___9__17;

			// Token: 0x04005E21 RID: 24097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E22 RID: 24098
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x04005E23 RID: 24099
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

			// Token: 0x04005E24 RID: 24100
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_2;

			// Token: 0x04005E25 RID: 24101
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_3;

			// Token: 0x04005E26 RID: 24102
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_4;

			// Token: 0x04005E27 RID: 24103
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_5;

			// Token: 0x04005E28 RID: 24104
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_6;

			// Token: 0x04005E29 RID: 24105
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__17_Internal_Boolean_FinishCondition_0;

			// Token: 0x04005E2A RID: 24106
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialNPCInteractData_String_String_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x04005E2B RID: 24107
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__8_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;
		}

		// Token: 0x0200060A RID: 1546
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Il2CppSystem.Object
		{
			// Token: 0x060090C7 RID: 37063 RVA: 0x00275364 File Offset: 0x00273564
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr, "CS$<>8__locals1");
				DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr, 100667006);
				DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__GetConfigurationSet_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr, 100667007);
			}

			// Token: 0x060090C8 RID: 37064 RVA: 0x002753E0 File Offset: 0x002735E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090C9 RID: 37065 RVA: 0x0027541C File Offset: 0x0027361C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58556, XrefRangeEnd = 58558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__GetConfigurationSet_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090CA RID: 37066 RVA: 0x0004E76F File Offset: 0x0004C96F
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003061 RID: 12385
			// (get) Token: 0x060090CB RID: 37067 RVA: 0x00275450 File Offset: 0x00273650
			// (set) Token: 0x060090CC RID: 37068 RVA: 0x0004E778 File Offset: 0x0004C978
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003062 RID: 12386
			// (get) Token: 0x060090CD RID: 37069 RVA: 0x00275478 File Offset: 0x00273678
			// (set) Token: 0x060090CE RID: 37070 RVA: 0x0004E797 File Offset: 0x0004C997
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E2C RID: 24108
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E2D RID: 24109
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E2E RID: 24110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E2F RID: 24111
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__9_Internal_Void_0;
		}

		// Token: 0x0200060B RID: 1547
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_2")]
		public sealed class __c__DisplayClass17_2 : Il2CppSystem.Object
		{
			// Token: 0x060090CF RID: 37071 RVA: 0x002754A8 File Offset: 0x002736A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_2()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeFieldInfoPtr_merchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr, "merchantData");
				DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr, "CS$<>8__locals2");
				DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr, 100667008);
				DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeMethodInfoPtr__GetConfigurationSet_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr, 100667009);
				DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeMethodInfoPtr__GetConfigurationSet_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr, 100667010);
			}

			// Token: 0x060090D0 RID: 37072 RVA: 0x00275538 File Offset: 0x00273738
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090D1 RID: 37073 RVA: 0x00275574 File Offset: 0x00273774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58558, XrefRangeEnd = 58564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeMethodInfoPtr__GetConfigurationSet_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090D2 RID: 37074 RVA: 0x002755A8 File Offset: 0x002737A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58564, XrefRangeEnd = 58570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeMethodInfoPtr__GetConfigurationSet_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090D3 RID: 37075 RVA: 0x0004E7B6 File Offset: 0x0004C9B6
			public __c__DisplayClass17_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003063 RID: 12387
			// (get) Token: 0x060090D4 RID: 37076 RVA: 0x002755DC File Offset: 0x002737DC
			// (set) Token: 0x060090D5 RID: 37077 RVA: 0x0004E7BF File Offset: 0x0004C9BF
			public unsafe TrackedMerchant merchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeFieldInfoPtr_merchantData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeFieldInfoPtr_merchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003064 RID: 12388
			// (get) Token: 0x060090D6 RID: 37078 RVA: 0x0027560C File Offset: 0x0027380C
			// (set) Token: 0x060090D7 RID: 37079 RVA: 0x0004E7DE File Offset: 0x0004C9DE
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_2.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E30 RID: 24112
			private static readonly IntPtr NativeFieldInfoPtr_merchantData;

			// Token: 0x04005E31 RID: 24113
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E32 RID: 24114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E33 RID: 24115
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__10_Internal_Void_0;

			// Token: 0x04005E34 RID: 24116
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__11_Internal_Void_0;
		}

		// Token: 0x0200060C RID: 1548
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_3")]
		public sealed class __c__DisplayClass17_3 : Il2CppSystem.Object
		{
			// Token: 0x060090D8 RID: 37080 RVA: 0x0027563C File Offset: 0x0027383C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_3()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr, "CS$<>8__locals3");
				DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr, 100667011);
				DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeMethodInfoPtr__GetConfigurationSet_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr, 100667012);
			}

			// Token: 0x060090D9 RID: 37081 RVA: 0x002756B8 File Offset: 0x002738B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090DA RID: 37082 RVA: 0x002756F4 File Offset: 0x002738F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58570, XrefRangeEnd = 58576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeMethodInfoPtr__GetConfigurationSet_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090DB RID: 37083 RVA: 0x0004E7FD File Offset: 0x0004C9FD
			public __c__DisplayClass17_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003065 RID: 12389
			// (get) Token: 0x060090DC RID: 37084 RVA: 0x00275728 File Offset: 0x00273928
			// (set) Token: 0x060090DD RID: 37085 RVA: 0x0004E806 File Offset: 0x0004CA06
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003066 RID: 12390
			// (get) Token: 0x060090DE RID: 37086 RVA: 0x00275750 File Offset: 0x00273950
			// (set) Token: 0x060090DF RID: 37087 RVA: 0x0004E825 File Offset: 0x0004CA25
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_3.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E35 RID: 24117
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E36 RID: 24118
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E37 RID: 24119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E38 RID: 24120
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__12_Internal_Void_0;
		}

		// Token: 0x0200060D RID: 1549
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_4")]
		public sealed class __c__DisplayClass17_4 : Il2CppSystem.Object
		{
			// Token: 0x060090E0 RID: 37088 RVA: 0x00275780 File Offset: 0x00273980
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_4()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_npcKizunaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr, "npcKizunaLevel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr, "CS$<>8__locals4");
				DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr, 100667013);
				DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeMethodInfoPtr__GetConfigurationSet_b__13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr, 100667014);
			}

			// Token: 0x060090E1 RID: 37089 RVA: 0x00275810 File Offset: 0x00273A10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090E2 RID: 37090 RVA: 0x0027584C File Offset: 0x00273A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58576, XrefRangeEnd = 58577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeMethodInfoPtr__GetConfigurationSet_b__13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090E3 RID: 37091 RVA: 0x0004E844 File Offset: 0x0004CA44
			public __c__DisplayClass17_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003067 RID: 12391
			// (get) Token: 0x060090E4 RID: 37092 RVA: 0x00275880 File Offset: 0x00273A80
			// (set) Token: 0x060090E5 RID: 37093 RVA: 0x0004E84D File Offset: 0x0004CA4D
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003068 RID: 12392
			// (get) Token: 0x060090E6 RID: 37094 RVA: 0x002758A8 File Offset: 0x00273AA8
			// (set) Token: 0x060090E7 RID: 37095 RVA: 0x0004E86C File Offset: 0x0004CA6C
			public unsafe int npcKizunaLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_npcKizunaLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_npcKizunaLevel)) = value;
				}
			}

			// Token: 0x17003069 RID: 12393
			// (get) Token: 0x060090E8 RID: 37096 RVA: 0x002758D0 File Offset: 0x00273AD0
			// (set) Token: 0x060090E9 RID: 37097 RVA: 0x0004E887 File Offset: 0x0004CA87
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_4.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E39 RID: 24121
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E3A RID: 24122
			private static readonly IntPtr NativeFieldInfoPtr_npcKizunaLevel;

			// Token: 0x04005E3B RID: 24123
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E3C RID: 24124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E3D RID: 24125
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__13_Internal_Void_0;
		}

		// Token: 0x0200060E RID: 1550
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_5")]
		public sealed class __c__DisplayClass17_5 : Il2CppSystem.Object
		{
			// Token: 0x060090EA RID: 37098 RVA: 0x00275900 File Offset: 0x00273B00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_5()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_npcKizunaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr, "npcKizunaLevel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr, "CS$<>8__locals5");
				DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr, 100667015);
				DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeMethodInfoPtr__GetConfigurationSet_b__14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr, 100667016);
			}

			// Token: 0x060090EB RID: 37099 RVA: 0x00275990 File Offset: 0x00273B90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090EC RID: 37100 RVA: 0x002759CC File Offset: 0x00273BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58577, XrefRangeEnd = 58578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeMethodInfoPtr__GetConfigurationSet_b__14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090ED RID: 37101 RVA: 0x0004E8A6 File Offset: 0x0004CAA6
			public __c__DisplayClass17_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700306A RID: 12394
			// (get) Token: 0x060090EE RID: 37102 RVA: 0x00275A00 File Offset: 0x00273C00
			// (set) Token: 0x060090EF RID: 37103 RVA: 0x0004E8AF File Offset: 0x0004CAAF
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700306B RID: 12395
			// (get) Token: 0x060090F0 RID: 37104 RVA: 0x00275A28 File Offset: 0x00273C28
			// (set) Token: 0x060090F1 RID: 37105 RVA: 0x0004E8CE File Offset: 0x0004CACE
			public unsafe int npcKizunaLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_npcKizunaLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_npcKizunaLevel)) = value;
				}
			}

			// Token: 0x1700306C RID: 12396
			// (get) Token: 0x060090F2 RID: 37106 RVA: 0x00275A50 File Offset: 0x00273C50
			// (set) Token: 0x060090F3 RID: 37107 RVA: 0x0004E8E9 File Offset: 0x0004CAE9
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_5.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E3E RID: 24126
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E3F RID: 24127
			private static readonly IntPtr NativeFieldInfoPtr_npcKizunaLevel;

			// Token: 0x04005E40 RID: 24128
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E41 RID: 24129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E42 RID: 24130
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__14_Internal_Void_0;
		}

		// Token: 0x0200060F RID: 1551
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_6")]
		public sealed class __c__DisplayClass17_6 : Il2CppSystem.Object
		{
			// Token: 0x060090F4 RID: 37108 RVA: 0x00275A80 File Offset: 0x00273C80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_6()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_npcKizunaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr, "npcKizunaLevel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr, "CS$<>8__locals6");
				DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr, 100667017);
				DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeMethodInfoPtr__GetConfigurationSet_b__15_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr, 100667018);
			}

			// Token: 0x060090F5 RID: 37109 RVA: 0x00275B10 File Offset: 0x00273D10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090F6 RID: 37110 RVA: 0x00275B4C File Offset: 0x00273D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58578, XrefRangeEnd = 58579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeMethodInfoPtr__GetConfigurationSet_b__15_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060090F7 RID: 37111 RVA: 0x0004E908 File Offset: 0x0004CB08
			public __c__DisplayClass17_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700306D RID: 12397
			// (get) Token: 0x060090F8 RID: 37112 RVA: 0x00275B80 File Offset: 0x00273D80
			// (set) Token: 0x060090F9 RID: 37113 RVA: 0x0004E911 File Offset: 0x0004CB11
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700306E RID: 12398
			// (get) Token: 0x060090FA RID: 37114 RVA: 0x00275BA8 File Offset: 0x00273DA8
			// (set) Token: 0x060090FB RID: 37115 RVA: 0x0004E930 File Offset: 0x0004CB30
			public unsafe int npcKizunaLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_npcKizunaLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_npcKizunaLevel)) = value;
				}
			}

			// Token: 0x1700306F RID: 12399
			// (get) Token: 0x060090FC RID: 37116 RVA: 0x00275BD0 File Offset: 0x00273DD0
			// (set) Token: 0x060090FD RID: 37117 RVA: 0x0004E94B File Offset: 0x0004CB4B
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_6.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E43 RID: 24131
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E44 RID: 24132
			private static readonly IntPtr NativeFieldInfoPtr_npcKizunaLevel;

			// Token: 0x04005E45 RID: 24133
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E46 RID: 24134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E47 RID: 24135
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__15_Internal_Void_0;
		}

		// Token: 0x02000610 RID: 1552
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_7")]
		public sealed class __c__DisplayClass17_7 : Il2CppSystem.Object
		{
			// Token: 0x060090FE RID: 37118 RVA: 0x00275C00 File Offset: 0x00273E00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_7()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_commisionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr, "commisionLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr, "CS$<>8__locals7");
				DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr, 100667019);
				DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeMethodInfoPtr__GetConfigurationSet_b__16_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr, 100667020);
			}

			// Token: 0x060090FF RID: 37119 RVA: 0x00275C90 File Offset: 0x00273E90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_7() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_7>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009100 RID: 37120 RVA: 0x00275CCC File Offset: 0x00273ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58579, XrefRangeEnd = 58608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeMethodInfoPtr__GetConfigurationSet_b__16_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009101 RID: 37121 RVA: 0x0004E96A File Offset: 0x0004CB6A
			public __c__DisplayClass17_7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003070 RID: 12400
			// (get) Token: 0x06009102 RID: 37122 RVA: 0x00275D00 File Offset: 0x00273F00
			// (set) Token: 0x06009103 RID: 37123 RVA: 0x0004E973 File Offset: 0x0004CB73
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003071 RID: 12401
			// (get) Token: 0x06009104 RID: 37124 RVA: 0x00275D28 File Offset: 0x00273F28
			// (set) Token: 0x06009105 RID: 37125 RVA: 0x0004E992 File Offset: 0x0004CB92
			public unsafe string commisionLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_commisionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_commisionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003072 RID: 12402
			// (get) Token: 0x06009106 RID: 37126 RVA: 0x00275D50 File Offset: 0x00273F50
			// (set) Token: 0x06009107 RID: 37127 RVA: 0x0004E9B1 File Offset: 0x0004CBB1
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_7.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E48 RID: 24136
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E49 RID: 24137
			private static readonly IntPtr NativeFieldInfoPtr_commisionLabel;

			// Token: 0x04005E4A RID: 24138
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E4B RID: 24139
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E4C RID: 24140
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__16_Internal_Void_0;
		}

		// Token: 0x02000611 RID: 1553
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_8")]
		public sealed class __c__DisplayClass17_8 : Il2CppSystem.Object
		{
			// Token: 0x06009108 RID: 37128 RVA: 0x00275D80 File Offset: 0x00273F80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_8()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_currentMissionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr, "currentMissionLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_targetCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr, "targetCondition");
				DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr, "CS$<>8__locals8");
				DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr, 100667021);
				DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeMethodInfoPtr__GetConfigurationSet_b__18_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr, 100667022);
			}

			// Token: 0x06009109 RID: 37129 RVA: 0x00275E10 File Offset: 0x00274010
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_8() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_8>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600910A RID: 37130 RVA: 0x00275E4C File Offset: 0x0027404C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58608, XrefRangeEnd = 58629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__18(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeMethodInfoPtr__GetConfigurationSet_b__18_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600910B RID: 37131 RVA: 0x0004E9D0 File Offset: 0x0004CBD0
			public __c__DisplayClass17_8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003073 RID: 12403
			// (get) Token: 0x0600910C RID: 37132 RVA: 0x00275EDC File Offset: 0x002740DC
			// (set) Token: 0x0600910D RID: 37133 RVA: 0x0004E9D9 File Offset: 0x0004CBD9
			public unsafe string currentMissionLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_currentMissionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_currentMissionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003074 RID: 12404
			// (get) Token: 0x0600910E RID: 37134 RVA: 0x00275F04 File Offset: 0x00274104
			// (set) Token: 0x0600910F RID: 37135 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
			public MissionNode.FinishCondition targetCondition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_targetCondition);
					return new MissionNode.FinishCondition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_targetCondition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003075 RID: 12405
			// (get) Token: 0x06009110 RID: 37136 RVA: 0x00275F34 File Offset: 0x00274134
			// (set) Token: 0x06009111 RID: 37137 RVA: 0x0004EA26 File Offset: 0x0004CC26
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_8.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E4D RID: 24141
			private static readonly IntPtr NativeFieldInfoPtr_currentMissionLabel;

			// Token: 0x04005E4E RID: 24142
			private static readonly IntPtr NativeFieldInfoPtr_targetCondition;

			// Token: 0x04005E4F RID: 24143
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E50 RID: 24144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E51 RID: 24145
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__18_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;
		}

		// Token: 0x02000612 RID: 1554
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass17_9")]
		public sealed class __c__DisplayClass17_9 : Il2CppSystem.Object
		{
			// Token: 0x06009112 RID: 37138 RVA: 0x00275F64 File Offset: 0x00274164
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_9()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass17_9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr, "specialNPCInteractData");
				DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_missionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr, "missionLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr, "CS$<>8__locals9");
				DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr, 100667023);
				DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeMethodInfoPtr__GetConfigurationSet_b__19_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr, 100667024);
			}

			// Token: 0x06009113 RID: 37139 RVA: 0x00275FF4 File Offset: 0x002741F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_9() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass17_9>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009114 RID: 37140 RVA: 0x00276030 File Offset: 0x00274230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58629, XrefRangeEnd = 58635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetConfigurationSet_b__19()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeMethodInfoPtr__GetConfigurationSet_b__19_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009115 RID: 37141 RVA: 0x0004EA45 File Offset: 0x0004CC45
			public __c__DisplayClass17_9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003076 RID: 12406
			// (get) Token: 0x06009116 RID: 37142 RVA: 0x00276064 File Offset: 0x00274264
			// (set) Token: 0x06009117 RID: 37143 RVA: 0x0004EA4E File Offset: 0x0004CC4E
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003077 RID: 12407
			// (get) Token: 0x06009118 RID: 37144 RVA: 0x00276094 File Offset: 0x00274294
			// (set) Token: 0x06009119 RID: 37145 RVA: 0x0004EA6D File Offset: 0x0004CC6D
			public unsafe string missionLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_missionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_missionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003078 RID: 12408
			// (get) Token: 0x0600911A RID: 37146 RVA: 0x002760BC File Offset: 0x002742BC
			// (set) Token: 0x0600911B RID: 37147 RVA: 0x0004EA8C File Offset: 0x0004CC8C
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass17_9.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E52 RID: 24146
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04005E53 RID: 24147
			private static readonly IntPtr NativeFieldInfoPtr_missionLabel;

			// Token: 0x04005E54 RID: 24148
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04005E55 RID: 24149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E56 RID: 24150
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigurationSet_b__19_Internal_Void_0;
		}

		// Token: 0x02000613 RID: 1555
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600911C RID: 37148 RVA: 0x002760EC File Offset: 0x002742EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_shouldTriggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr, "shouldTriggerEvent");
				DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr, "stage");
				DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr, 100667025);
				DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeMethodInfoPtr__Chat_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr, 100667026);
			}

			// Token: 0x0600911D RID: 37149 RVA: 0x0027617C File Offset: 0x0027437C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600911E RID: 37150 RVA: 0x002761B8 File Offset: 0x002743B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58635, XrefRangeEnd = 58655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Chat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeMethodInfoPtr__Chat_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600911F RID: 37151 RVA: 0x0004EAAB File Offset: 0x0004CCAB
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003079 RID: 12409
			// (get) Token: 0x06009120 RID: 37152 RVA: 0x002761EC File Offset: 0x002743EC
			// (set) Token: 0x06009121 RID: 37153 RVA: 0x0004EAB4 File Offset: 0x0004CCB4
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700307A RID: 12410
			// (get) Token: 0x06009122 RID: 37154 RVA: 0x00276214 File Offset: 0x00274414
			// (set) Token: 0x06009123 RID: 37155 RVA: 0x0004EAD3 File Offset: 0x0004CCD3
			public unsafe bool shouldTriggerEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_shouldTriggerEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_shouldTriggerEvent)) = value;
				}
			}

			// Token: 0x1700307B RID: 12411
			// (get) Token: 0x06009124 RID: 37156 RVA: 0x0027623C File Offset: 0x0027443C
			// (set) Token: 0x06009125 RID: 37157 RVA: 0x0004EAEE File Offset: 0x0004CCEE
			public unsafe DaySceneChatSelectionPannel.BaseOpenContext stage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_stage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseOpenContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass18_0.NativeFieldInfoPtr_stage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E57 RID: 24151
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E58 RID: 24152
			private static readonly IntPtr NativeFieldInfoPtr_shouldTriggerEvent;

			// Token: 0x04005E59 RID: 24153
			private static readonly IntPtr NativeFieldInfoPtr_stage;

			// Token: 0x04005E5A RID: 24154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E5B RID: 24155
			private static readonly IntPtr NativeMethodInfoPtr__Chat_b__0_Internal_Void_0;
		}

		// Token: 0x02000614 RID: 1556
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x06009126 RID: 37158 RVA: 0x0027626C File Offset: 0x0027446C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr, "characterLabel");
				DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr, 100667027);
				DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__Invite_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr, 100667028);
				DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__Invite_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr, 100667029);
			}

			// Token: 0x06009127 RID: 37159 RVA: 0x002762FC File Offset: 0x002744FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009128 RID: 37160 RVA: 0x00276338 File Offset: 0x00274538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58655, XrefRangeEnd = 58665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Invite_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__Invite_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009129 RID: 37161 RVA: 0x0027636C File Offset: 0x0027456C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58665, XrefRangeEnd = 58666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Invite_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__Invite_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600912A RID: 37162 RVA: 0x0004EB0D File Offset: 0x0004CD0D
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700307C RID: 12412
			// (get) Token: 0x0600912B RID: 37163 RVA: 0x002763A0 File Offset: 0x002745A0
			// (set) Token: 0x0600912C RID: 37164 RVA: 0x0004EB16 File Offset: 0x0004CD16
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700307D RID: 12413
			// (get) Token: 0x0600912D RID: 37165 RVA: 0x002763C8 File Offset: 0x002745C8
			// (set) Token: 0x0600912E RID: 37166 RVA: 0x0004EB35 File Offset: 0x0004CD35
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E5C RID: 24156
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005E5D RID: 24157
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005E5E RID: 24158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E5F RID: 24159
			private static readonly IntPtr NativeMethodInfoPtr__Invite_b__0_Internal_Void_0;

			// Token: 0x04005E60 RID: 24160
			private static readonly IntPtr NativeMethodInfoPtr__Invite_b__1_Internal_Void_0;
		}

		// Token: 0x02000615 RID: 1557
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600912F RID: 37167 RVA: 0x002763F8 File Offset: 0x002745F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_hateTagCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr, "hateTagCollection");
				DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_likeTagCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr, "likeTagCollection");
				DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr, 100667030);
				DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__FillterCollection_b__0_Internal_Boolean_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr, 100667031);
			}

			// Token: 0x06009130 RID: 37168 RVA: 0x00276474 File Offset: 0x00274674
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009131 RID: 37169 RVA: 0x002764B0 File Offset: 0x002746B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58666, XrefRangeEnd = 58686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FillterCollection_b__0(ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__FillterCollection_b__0_Internal_Boolean_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009132 RID: 37170 RVA: 0x0004EB54 File Offset: 0x0004CD54
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700307E RID: 12414
			// (get) Token: 0x06009133 RID: 37171 RVA: 0x00276504 File Offset: 0x00274704
			// (set) Token: 0x06009134 RID: 37172 RVA: 0x0004EB5D File Offset: 0x0004CD5D
			public unsafe IEnumerable<int> hateTagCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_hateTagCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_hateTagCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700307F RID: 12415
			// (get) Token: 0x06009135 RID: 37173 RVA: 0x00276534 File Offset: 0x00274734
			// (set) Token: 0x06009136 RID: 37174 RVA: 0x0004EB7C File Offset: 0x0004CD7C
			public unsafe IEnumerable<SpecialGuest.WeightedTag> likeTagCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_likeTagCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpecialGuest.WeightedTag>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_likeTagCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E61 RID: 24161
			private static readonly IntPtr NativeFieldInfoPtr_hateTagCollection;

			// Token: 0x04005E62 RID: 24162
			private static readonly IntPtr NativeFieldInfoPtr_likeTagCollection;

			// Token: 0x04005E63 RID: 24163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E64 RID: 24164
			private static readonly IntPtr NativeMethodInfoPtr__FillterCollection_b__0_Internal_Boolean_ValueTuple_3_Int32_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_0;
		}

		// Token: 0x02000616 RID: 1558
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
		{
			// Token: 0x06009137 RID: 37175 RVA: 0x00276564 File Offset: 0x00274764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr, "x");
				DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr, 100667032);
				DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__FillterCollection_b__2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr, 100667033);
				DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__FillterCollection_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr, 100667034);
			}

			// Token: 0x06009138 RID: 37176 RVA: 0x002765E0 File Offset: 0x002747E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass20_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009139 RID: 37177 RVA: 0x0027661C File Offset: 0x0027481C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58686, XrefRangeEnd = 58689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FillterCollection_b__2(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__FillterCollection_b__2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600913A RID: 37178 RVA: 0x00276668 File Offset: 0x00274868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58689, XrefRangeEnd = 58692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FillterCollection_b__4(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__FillterCollection_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600913B RID: 37179 RVA: 0x0004EB9B File Offset: 0x0004CD9B
			public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003080 RID: 12416
			// (get) Token: 0x0600913C RID: 37180 RVA: 0x002766B4 File Offset: 0x002748B4
			// (set) Token: 0x0600913D RID: 37181 RVA: 0x0004EBA4 File Offset: 0x0004CDA4
			public ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>> x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeFieldInfoPtr_x);
					return new ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass20_1.NativeFieldInfoPtr_x), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, Il2CppStructArray<int>, IEnumerable<int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005E65 RID: 24165
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005E66 RID: 24166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E67 RID: 24167
			private static readonly IntPtr NativeMethodInfoPtr__FillterCollection_b__2_Internal_Boolean_Int32_0;

			// Token: 0x04005E68 RID: 24168
			private static readonly IntPtr NativeMethodInfoPtr__FillterCollection_b__4_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000617 RID: 1559
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600913E RID: 37182 RVA: 0x002766E4 File Offset: 0x002748E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_getLevelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr, "getLevelCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr, 100667035);
				DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr, 100667036);
				DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__SelectFromData_b__1_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr, 100667037);
			}

			// Token: 0x0600913F RID: 37183 RVA: 0x00276760 File Offset: 0x00274960
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009140 RID: 37184 RVA: 0x0027679C File Offset: 0x0027499C
			[CallerCount(0)]
			public unsafe int Method_Internal_Int32_Int32_PDM_0(int dat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref dat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009141 RID: 37185 RVA: 0x002767E8 File Offset: 0x002749E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58692, XrefRangeEnd = 58696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _SelectFromData_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__SelectFromData_b__1_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06009142 RID: 37186 RVA: 0x0004EBD2 File Offset: 0x0004CDD2
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003081 RID: 12417
			// (get) Token: 0x06009143 RID: 37187 RVA: 0x00276834 File Offset: 0x00274A34
			// (set) Token: 0x06009144 RID: 37188 RVA: 0x0004EBDB File Offset: 0x0004CDDB
			public unsafe Func<int, int> getLevelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_getLevelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_getLevelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E69 RID: 24169
			private static readonly IntPtr NativeFieldInfoPtr_getLevelCallback;

			// Token: 0x04005E6A RID: 24170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E6B RID: 24171
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_Int32_PDM_0;

			// Token: 0x04005E6C RID: 24172
			private static readonly IntPtr NativeMethodInfoPtr__SelectFromData_b__1_Internal_IEnumerable_1_Int32_Int32_0;
		}

		// Token: 0x02000618 RID: 1560
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x06009145 RID: 37189 RVA: 0x00276864 File Offset: 0x00274A64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_specialGuestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr, "specialGuestData");
				DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_selectedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr, "selectedIngredients");
				DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr, 100667038);
				DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__RequestIngredient_b__3_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr, 100667039);
				DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__RequestIngredient_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr, 100667040);
			}

			// Token: 0x06009146 RID: 37190 RVA: 0x00276908 File Offset: 0x00274B08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009147 RID: 37191 RVA: 0x00276944 File Offset: 0x00274B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58696, XrefRangeEnd = 58707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RequestIngredient_b__3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__RequestIngredient_b__3_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009148 RID: 37192 RVA: 0x00276990 File Offset: 0x00274B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58707, XrefRangeEnd = 58709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RequestIngredient_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__RequestIngredient_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009149 RID: 37193 RVA: 0x0004EBFA File Offset: 0x0004CDFA
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003082 RID: 12418
			// (get) Token: 0x0600914A RID: 37194 RVA: 0x002769C4 File Offset: 0x00274BC4
			// (set) Token: 0x0600914B RID: 37195 RVA: 0x0004EC03 File Offset: 0x0004CE03
			public unsafe SpecialGuest specialGuestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_specialGuestData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_specialGuestData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003083 RID: 12419
			// (get) Token: 0x0600914C RID: 37196 RVA: 0x002769F4 File Offset: 0x00274BF4
			// (set) Token: 0x0600914D RID: 37197 RVA: 0x0004EC22 File Offset: 0x0004CE22
			public unsafe IEnumerable<int> selectedIngredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_selectedIngredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_selectedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003084 RID: 12420
			// (get) Token: 0x0600914E RID: 37198 RVA: 0x00276A24 File Offset: 0x00274C24
			// (set) Token: 0x0600914F RID: 37199 RVA: 0x0004EC41 File Offset: 0x0004CE41
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E6D RID: 24173
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestData;

			// Token: 0x04005E6E RID: 24174
			private static readonly IntPtr NativeFieldInfoPtr_selectedIngredients;

			// Token: 0x04005E6F RID: 24175
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005E70 RID: 24176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E71 RID: 24177
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__3_Internal_Boolean_Int32_0;

			// Token: 0x04005E72 RID: 24178
			private static readonly IntPtr NativeMethodInfoPtr__RequestIngredient_b__5_Internal_Void_0;
		}

		// Token: 0x02000619 RID: 1561
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x06009150 RID: 37200 RVA: 0x00276A54 File Offset: 0x00274C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeFieldInfoPtr_selectedBeverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr, "selectedBeverages");
				DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr, 100667041);
				DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeMethodInfoPtr__RequestBeverages_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr, 100667042);
			}

			// Token: 0x06009151 RID: 37201 RVA: 0x00276AD0 File Offset: 0x00274CD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009152 RID: 37202 RVA: 0x00276B0C File Offset: 0x00274D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58709, XrefRangeEnd = 58711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RequestBeverages_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeMethodInfoPtr__RequestBeverages_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009153 RID: 37203 RVA: 0x0004EC60 File Offset: 0x0004CE60
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003085 RID: 12421
			// (get) Token: 0x06009154 RID: 37204 RVA: 0x00276B40 File Offset: 0x00274D40
			// (set) Token: 0x06009155 RID: 37205 RVA: 0x0004EC69 File Offset: 0x0004CE69
			public unsafe IEnumerable<int> selectedBeverages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeFieldInfoPtr_selectedBeverages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeFieldInfoPtr_selectedBeverages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003086 RID: 12422
			// (get) Token: 0x06009156 RID: 37206 RVA: 0x00276B70 File Offset: 0x00274D70
			// (set) Token: 0x06009157 RID: 37207 RVA: 0x0004EC88 File Offset: 0x0004CE88
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass23_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E73 RID: 24179
			private static readonly IntPtr NativeFieldInfoPtr_selectedBeverages;

			// Token: 0x04005E74 RID: 24180
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005E75 RID: 24181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E76 RID: 24182
			private static readonly IntPtr NativeMethodInfoPtr__RequestBeverages_b__3_Internal_Void_0;
		}

		// Token: 0x0200061A RID: 1562
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x06009158 RID: 37208 RVA: 0x00276BA0 File Offset: 0x00274DA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass24_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass24_0>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass24_0>.NativeClassPtr, 100667043);
				DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__Commision_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass24_0>.NativeClassPtr, 100667044);
			}

			// Token: 0x06009159 RID: 37209 RVA: 0x00276C08 File Offset: 0x00274E08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600915A RID: 37210 RVA: 0x00276C44 File Offset: 0x00274E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58711, XrefRangeEnd = 58712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Commision_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__Commision_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600915B RID: 37211 RVA: 0x0004ECA7 File Offset: 0x0004CEA7
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003087 RID: 12423
			// (get) Token: 0x0600915C RID: 37212 RVA: 0x00276C78 File Offset: 0x00274E78
			// (set) Token: 0x0600915D RID: 37213 RVA: 0x0004ECB0 File Offset: 0x0004CEB0
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E77 RID: 24183
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005E78 RID: 24184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E79 RID: 24185
			private static readonly IntPtr NativeMethodInfoPtr__Commision_b__0_Internal_Void_0;
		}

		// Token: 0x0200061B RID: 1563
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600915E RID: 37214 RVA: 0x00276CA8 File Offset: 0x00274EA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_luckyLeafBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr, "luckyLeafBuff");
				DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr, "<>9__4");
				DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr, 100667045);
				DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__CommitSpecGuest_b__1_Internal_IEnumerable_1_Product_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr, 100667046);
				DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__CommitSpecGuest_b__4_Internal_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr, 100667047);
			}

			// Token: 0x0600915F RID: 37215 RVA: 0x00276D38 File Offset: 0x00274F38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009160 RID: 37216 RVA: 0x00276D74 File Offset: 0x00274F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58712, XrefRangeEnd = 58762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Product> _CommitSpecGuest_b__1(string a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__CommitSpecGuest_b__1_Internal_IEnumerable_1_Product_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Product>>(intPtr3) : null;
			}

			// Token: 0x06009161 RID: 37217 RVA: 0x00276DC4 File Offset: 0x00274FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58762, XrefRangeEnd = 58765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _CommitSpecGuest_b__4(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__CommitSpecGuest_b__4_Internal_Product_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x06009162 RID: 37218 RVA: 0x0004ECCF File Offset: 0x0004CECF
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003088 RID: 12424
			// (get) Token: 0x06009163 RID: 37219 RVA: 0x00276E14 File Offset: 0x00275014
			// (set) Token: 0x06009164 RID: 37220 RVA: 0x0004ECD8 File Offset: 0x0004CED8
			public unsafe bool luckyLeafBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_luckyLeafBuff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_luckyLeafBuff)) = value;
				}
			}

			// Token: 0x17003089 RID: 12425
			// (get) Token: 0x06009165 RID: 37221 RVA: 0x00276E3C File Offset: 0x0027503C
			// (set) Token: 0x06009166 RID: 37222 RVA: 0x0004ECF3 File Offset: 0x0004CEF3
			public unsafe Func<Product, Product> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E7A RID: 24186
			private static readonly IntPtr NativeFieldInfoPtr_luckyLeafBuff;

			// Token: 0x04005E7B RID: 24187
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04005E7C RID: 24188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E7D RID: 24189
			private static readonly IntPtr NativeMethodInfoPtr__CommitSpecGuest_b__1_Internal_IEnumerable_1_Product_String_0;

			// Token: 0x04005E7E RID: 24190
			private static readonly IntPtr NativeMethodInfoPtr__CommitSpecGuest_b__4_Internal_Product_Product_0;
		}

		// Token: 0x0200061C RID: 1564
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass29_0`2")]
		public sealed class __c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback> : Il2CppSystem.Object where TInteractData : DaySceneChatSelectionPannel.BaseInteractData where TGetSelectionConfigurationCallback : Delegate
		{
			// Token: 0x06009167 RID: 37223 RVA: 0x00276E6C File Offset: 0x0027506C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass29_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInteractData>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetSelectionConfigurationCallback>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_getConfigCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "getConfigCallback");
				DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_interactData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "interactData");
				DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "<>4__this");
				DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667048);
				DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_ValueTuple_2_Func_1_String_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667049);
				DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__OpenInternal_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667050);
			}

			// Token: 0x06009168 RID: 37224 RVA: 0x00276F5C File Offset: 0x0027515C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009169 RID: 37225 RVA: 0x00276F98 File Offset: 0x00275198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58765, XrefRangeEnd = 58803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIButtonSimple_ValueTuple_2_Func_1_String_Action_PDM_0(UIButtonSimple interactableBase, ValueTuple<Func<string>, Action> collectionData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactableBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(collectionData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_ValueTuple_2_Func_1_String_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600916A RID: 37226 RVA: 0x00276FF4 File Offset: 0x002751F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58803, XrefRangeEnd = 58807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenInternal_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__OpenInternal_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600916B RID: 37227 RVA: 0x0004ED12 File Offset: 0x0004CF12
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700308A RID: 12426
			// (get) Token: 0x0600916C RID: 37228 RVA: 0x00277028 File Offset: 0x00275228
			// (set) Token: 0x0600916D RID: 37229 RVA: 0x0004ED1B File Offset: 0x0004CF1B
			public unsafe Func<TInteractData, TGetSelectionConfigurationCallback, ValueTuple<bool, string, Action>> getConfigCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_getConfigCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TInteractData, TGetSelectionConfigurationCallback, ValueTuple<bool, string, Action>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_getConfigCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700308B RID: 12427
			// (get) Token: 0x0600916E RID: 37230 RVA: 0x00277058 File Offset: 0x00275258
			// (set) Token: 0x0600916F RID: 37231 RVA: 0x00277080 File Offset: 0x00275280
			public unsafe TInteractData interactData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_interactData);
					return IL2CPP.PointerToValueGeneric<TInteractData>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_interactData);
					Type typeFromHandle = typeof(TInteractData);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700308C RID: 12428
			// (get) Token: 0x06009170 RID: 37232 RVA: 0x00277128 File Offset: 0x00275328
			// (set) Token: 0x06009171 RID: 37233 RVA: 0x0004ED3A File Offset: 0x0004CF3A
			public unsafe DaySceneChatSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E7F RID: 24191
			private static readonly IntPtr NativeFieldInfoPtr_getConfigCallback;

			// Token: 0x04005E80 RID: 24192
			private static readonly IntPtr NativeFieldInfoPtr_interactData;

			// Token: 0x04005E81 RID: 24193
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E82 RID: 24194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E83 RID: 24195
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_ValueTuple_2_Func_1_String_Action_PDM_0;

			// Token: 0x04005E84 RID: 24196
			private static readonly IntPtr NativeMethodInfoPtr__OpenInternal_b__1_Internal_Void_0;
		}

		// Token: 0x0200061D RID: 1565
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass29_1`2")]
		public sealed class __c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback> : Il2CppSystem.Object where TInteractData : DaySceneChatSelectionPannel.BaseInteractData where TGetSelectionConfigurationCallback : Delegate
		{
			// Token: 0x06009172 RID: 37234 RVA: 0x00277158 File Offset: 0x00275358
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass29_1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInteractData>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetSelectionConfigurationCallback>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_thisSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "thisSelection");
				DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "CS$<>8__locals1");
				DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667051);
				DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr_Method_Internal_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667052);
			}

			// Token: 0x06009173 RID: 37235 RVA: 0x00277220 File Offset: 0x00275420
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009174 RID: 37236 RVA: 0x0027725C File Offset: 0x0027545C
			[CallerCount(0)]
			public unsafe string Method_Internal_String_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr_Method_Internal_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009175 RID: 37237 RVA: 0x0004ED59 File Offset: 0x0004CF59
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700308D RID: 12429
			// (get) Token: 0x06009176 RID: 37238 RVA: 0x00277294 File Offset: 0x00275494
			// (set) Token: 0x06009177 RID: 37239 RVA: 0x002772BC File Offset: 0x002754BC
			public unsafe TGetSelectionConfigurationCallback thisSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_thisSelection);
					return IL2CPP.PointerToValueGeneric<TGetSelectionConfigurationCallback>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_thisSelection);
					Type typeFromHandle = typeof(TGetSelectionConfigurationCallback);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700308E RID: 12430
			// (get) Token: 0x06009178 RID: 37240 RVA: 0x00277364 File Offset: 0x00275564
			// (set) Token: 0x06009179 RID: 37241 RVA: 0x0004ED62 File Offset: 0x0004CF62
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback> field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_1<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E85 RID: 24197
			private static readonly IntPtr NativeFieldInfoPtr_thisSelection;

			// Token: 0x04005E86 RID: 24198
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0;

			// Token: 0x04005E87 RID: 24199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E88 RID: 24200
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_PDM_0;
		}

		// Token: 0x0200061E RID: 1566
		[ObfuscatedName("DayScene.UI.DaySceneChatSelectionPannel+<>c__DisplayClass29_2`2")]
		public sealed class __c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback> : Il2CppSystem.Object where TInteractData : DaySceneChatSelectionPannel.BaseInteractData where TGetSelectionConfigurationCallback : Delegate
		{
			// Token: 0x0600917A RID: 37242 RVA: 0x00277394 File Offset: 0x00275594
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_2()
			{
				Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr, "<>c__DisplayClass29_2`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInteractData>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetSelectionConfigurationCallback>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr);
				DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_interactableBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "interactableBase");
				DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, "CS$<>8__locals2");
				DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667053);
				DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__OpenInternal_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr, 100667054);
			}

			// Token: 0x0600917B RID: 37243 RVA: 0x0027745C File Offset: 0x0027565C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600917C RID: 37244 RVA: 0x00277498 File Offset: 0x00275698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58807, XrefRangeEnd = 58810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenInternal_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeMethodInfoPtr__OpenInternal_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600917D RID: 37245 RVA: 0x0004ED81 File Offset: 0x0004CF81
			public __c__DisplayClass29_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700308F RID: 12431
			// (get) Token: 0x0600917E RID: 37246 RVA: 0x002774CC File Offset: 0x002756CC
			// (set) Token: 0x0600917F RID: 37247 RVA: 0x0004ED8A File Offset: 0x0004CF8A
			public unsafe UIButtonSimple interactableBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_interactableBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_interactableBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003090 RID: 12432
			// (get) Token: 0x06009180 RID: 37248 RVA: 0x002774FC File Offset: 0x002756FC
			// (set) Token: 0x06009181 RID: 37249 RVA: 0x0004EDA9 File Offset: 0x0004CFA9
			public unsafe DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback> field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.__c__DisplayClass29_0<TInteractData, TGetSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatSelectionPannel.__c__DisplayClass29_2<TInteractData, TGetSelectionConfigurationCallback>.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E89 RID: 24201
			private static readonly IntPtr NativeFieldInfoPtr_interactableBase;

			// Token: 0x04005E8A RID: 24202
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_2_TInteractData_TGetSelectionConfigurationCallback_0;

			// Token: 0x04005E8B RID: 24203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E8C RID: 24204
			private static readonly IntPtr NativeMethodInfoPtr__OpenInternal_b__3_Internal_Void_0;
		}

		// Token: 0x0200061F RID: 1567
		private sealed class MethodInfoStoreGeneric_OpenInternal_Private_Void_Il2CppArrayBase_1_TGetSelectionConfigurationCallback_TInteractData_Func_3_TInteractData_TGetSelectionConfigurationCallback_ValueTuple_3_Boolean_String_Action_Action_Int32_0<TInteractData, TGetSelectionConfigurationCallback>
		{
			// Token: 0x04005E8D RID: 24205
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DaySceneChatSelectionPannel.NativeMethodInfoPtr_OpenInternal_Private_Void_Il2CppArrayBase_1_TGetSelectionConfigurationCallback_TInteractData_Func_3_TInteractData_TGetSelectionConfigurationCallback_ValueTuple_3_Boolean_String_Action_Action_Int32_0, Il2CppClassPointerStore<DaySceneChatSelectionPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInteractData>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetSelectionConfigurationCallback>.NativeClassPtr))
			}))));
		}
	}
}
