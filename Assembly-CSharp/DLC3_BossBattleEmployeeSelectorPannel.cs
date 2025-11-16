using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Token: 0x02000013 RID: 19
public class DLC3_BossBattleEmployeeSelectorPannel : UIPanel
{
	// Token: 0x06000152 RID: 338 RVA: 0x000A3458 File Offset: 0x000A1658
	// Note: this type is marked as 'beforefieldinit'.
	static DLC3_BossBattleEmployeeSelectorPannel()
	{
		Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC3_BossBattleEmployeeSelectorPannel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr);
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "cluster");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "container");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_buttonHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "buttonHold");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_charaterObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "charaterObject");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_partnerProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "partnerProperty");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_AllInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "m_AllInstances");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_PartnerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "m_PartnerGroup");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_PanelTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "m_PanelTokenSource");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_partnerPropertyDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "partnerPropertyDic");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<PannelOpenContext>k__BackingField");
		DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr__FinalSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<FinalSelected>k__BackingField");
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_EmployeeSelectorOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663461);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_EmployeeSelectorOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663462);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_get_FinalSelected_Public_get_PartnerProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663463);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_set_FinalSelected_Private_set_Void_PartnerProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663464);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663465);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663466);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ProcessElements_Private_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663467);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ChangeImage_Private_Void_Image_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663468);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_Describe_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663469);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663470);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663471);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663472);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663473);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663474);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__OnPanelInitialize_b__17_1_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663475);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__OnPanelInitialize_b__17_2_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663476);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__OnPanelOpen_b__18_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663477);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_0_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663478);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_2_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663479);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_3_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663480);
		DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_9_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, 100663481);
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000153 RID: 339 RVA: 0x000A3708 File Offset: 0x000A1908
	// (set) Token: 0x06000154 RID: 340 RVA: 0x000A3740 File Offset: 0x000A1940
	public unsafe DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext PannelOpenContext
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_EmployeeSelectorOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18127, XrefRangeEnd = 18128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_EmployeeSelectorOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000155 RID: 341 RVA: 0x000A3788 File Offset: 0x000A1988
	// (set) Token: 0x06000156 RID: 342 RVA: 0x000A37C0 File Offset: 0x000A19C0
	public unsafe DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty FinalSelected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_get_FinalSelected_Public_get_PartnerProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18128, XrefRangeEnd = 18129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_set_FinalSelected_Private_set_Void_PartnerProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000A3808 File Offset: 0x000A1A08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18129, XrefRangeEnd = 18183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000158 RID: 344 RVA: 0x000A3844 File Offset: 0x000A1A44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18183, XrefRangeEnd = 18249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000A3880 File Offset: 0x000A1A80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18249, XrefRangeEnd = 18390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessElements(UIElementCluster uiElement, int partnerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ProcessElements_Private_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000A38D0 File Offset: 0x000A1AD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18390, XrefRangeEnd = 18392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeImage(Image image, bool shouldOpen, Sprite sprite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldOpen;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ChangeImage_Private_Void_Image_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x000A3934 File Offset: 0x000A1B34
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18505, RefRangeEnd = 18507, XrefRangeStart = 18392, XrefRangeEnd = 18505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Describe(int partnerId, string titleLang)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref partnerId;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(titleLang);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_Describe_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x000A3984 File Offset: 0x000A1B84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18507, XrefRangeEnd = 18511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000A39CC File Offset: 0x000A1BCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18511, XrefRangeEnd = 18513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000A3A14 File Offset: 0x000A1C14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18513, XrefRangeEnd = 18516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelClose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000A3A50 File Offset: 0x000A1C50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18516, XrefRangeEnd = 18527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000A3A8C File Offset: 0x000A1C8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18527, XrefRangeEnd = 18543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC3_BossBattleEmployeeSelectorPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x000A3AC8 File Offset: 0x000A1CC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18543, XrefRangeEnd = 18553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnPanelInitialize_b__17_1(MoveDirection direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref direction;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__OnPanelInitialize_b__17_1_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x000A3B08 File Offset: 0x000A1D08
	[CallerCount(0)]
	public unsafe bool _OnPanelInitialize_b__17_2(int x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref x;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__OnPanelInitialize_b__17_2_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x000A3B54 File Offset: 0x000A1D54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18553, XrefRangeEnd = 18559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _OnPanelOpen_b__18_0(int x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref x;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__OnPanelOpen_b__18_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18559, XrefRangeEnd = 18560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Describe_b__21_0(Image x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_0_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000A3BE4 File Offset: 0x000A1DE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Describe_b__21_2(Image x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_2_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x000A3C28 File Offset: 0x000A1E28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Describe_b__21_3(Image x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_3_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x000A3C6C File Offset: 0x000A1E6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18560, XrefRangeEnd = 18566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Describe_b__21_9(Image x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.NativeMethodInfoPtr__Describe_b__21_9_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002A99 File Offset: 0x00000C99
	public DLC3_BossBattleEmployeeSelectorPannel(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000169 RID: 361 RVA: 0x000A3CB0 File Offset: 0x000A1EB0
	// (set) Token: 0x0600016A RID: 362 RVA: 0x00002AA2 File Offset: 0x00000CA2
	public unsafe UIElementCluster cluster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_cluster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x0600016B RID: 363 RVA: 0x000A3CE0 File Offset: 0x000A1EE0
	// (set) Token: 0x0600016C RID: 364 RVA: 0x00002AC1 File Offset: 0x00000CC1
	public unsafe RectTransform container
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_container);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600016D RID: 365 RVA: 0x000A3D10 File Offset: 0x000A1F10
	// (set) Token: 0x0600016E RID: 366 RVA: 0x00002AE0 File Offset: 0x00000CE0
	public unsafe UIButtonHold buttonHold
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_buttonHold);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_buttonHold), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600016F RID: 367 RVA: 0x000A3D40 File Offset: 0x000A1F40
	// (set) Token: 0x06000170 RID: 368 RVA: 0x00002AFF File Offset: 0x00000CFF
	public unsafe GameObject charaterObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_charaterObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_charaterObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000171 RID: 369 RVA: 0x000A3D70 File Offset: 0x000A1F70
	// (set) Token: 0x06000172 RID: 370 RVA: 0x00002B1E File Offset: 0x00000D1E
	public unsafe Il2CppReferenceArray<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty> partnerProperty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_partnerProperty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_partnerProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000173 RID: 371 RVA: 0x000A3DA0 File Offset: 0x000A1FA0
	// (set) Token: 0x06000174 RID: 372 RVA: 0x00002B3D File Offset: 0x00000D3D
	public unsafe List<GameObject> m_AllInstances
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_AllInstances);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_AllInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000175 RID: 373 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
	// (set) Token: 0x06000176 RID: 374 RVA: 0x00002B5C File Offset: 0x00000D5C
	public unsafe UILogicalGroupT<int> m_PartnerGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_PartnerGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_PartnerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000177 RID: 375 RVA: 0x000A3E00 File Offset: 0x000A2000
	// (set) Token: 0x06000178 RID: 376 RVA: 0x00002B7B File Offset: 0x00000D7B
	public unsafe CancellationTokenSource m_PanelTokenSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_PanelTokenSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_m_PanelTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000179 RID: 377 RVA: 0x000A3E30 File Offset: 0x000A2030
	// (set) Token: 0x0600017A RID: 378 RVA: 0x00002B9A File Offset: 0x00000D9A
	public unsafe Dictionary<int, DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty> partnerPropertyDic
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_partnerPropertyDic);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr_partnerPropertyDic), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600017B RID: 379 RVA: 0x000A3E60 File Offset: 0x000A2060
	// (set) Token: 0x0600017C RID: 380 RVA: 0x00002BB9 File Offset: 0x00000DB9
	public DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext _PannelOpenContext_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField);
			return new DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x0600017D RID: 381 RVA: 0x000A3E90 File Offset: 0x000A2090
	// (set) Token: 0x0600017E RID: 382 RVA: 0x00002BE7 File Offset: 0x00000DE7
	public DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty _FinalSelected_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr__FinalSelected_k__BackingField);
			return new DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.NativeFieldInfoPtr__FinalSelected_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x040000D8 RID: 216
	private static readonly IntPtr NativeFieldInfoPtr_cluster;

	// Token: 0x040000D9 RID: 217
	private static readonly IntPtr NativeFieldInfoPtr_container;

	// Token: 0x040000DA RID: 218
	private static readonly IntPtr NativeFieldInfoPtr_buttonHold;

	// Token: 0x040000DB RID: 219
	private static readonly IntPtr NativeFieldInfoPtr_charaterObject;

	// Token: 0x040000DC RID: 220
	private static readonly IntPtr NativeFieldInfoPtr_partnerProperty;

	// Token: 0x040000DD RID: 221
	private static readonly IntPtr NativeFieldInfoPtr_m_AllInstances;

	// Token: 0x040000DE RID: 222
	private static readonly IntPtr NativeFieldInfoPtr_m_PartnerGroup;

	// Token: 0x040000DF RID: 223
	private static readonly IntPtr NativeFieldInfoPtr_m_PanelTokenSource;

	// Token: 0x040000E0 RID: 224
	private static readonly IntPtr NativeFieldInfoPtr_partnerPropertyDic;

	// Token: 0x040000E1 RID: 225
	private static readonly IntPtr NativeFieldInfoPtr__PannelOpenContext_k__BackingField;

	// Token: 0x040000E2 RID: 226
	private static readonly IntPtr NativeFieldInfoPtr__FinalSelected_k__BackingField;

	// Token: 0x040000E3 RID: 227
	private static readonly IntPtr NativeMethodInfoPtr_get_PannelOpenContext_Private_get_EmployeeSelectorOpenContext_0;

	// Token: 0x040000E4 RID: 228
	private static readonly IntPtr NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_EmployeeSelectorOpenContext_0;

	// Token: 0x040000E5 RID: 229
	private static readonly IntPtr NativeMethodInfoPtr_get_FinalSelected_Public_get_PartnerProperty_0;

	// Token: 0x040000E6 RID: 230
	private static readonly IntPtr NativeMethodInfoPtr_set_FinalSelected_Private_set_Void_PartnerProperty_0;

	// Token: 0x040000E7 RID: 231
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

	// Token: 0x040000E8 RID: 232
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

	// Token: 0x040000E9 RID: 233
	private static readonly IntPtr NativeMethodInfoPtr_ProcessElements_Private_Void_UIElementCluster_Int32_0;

	// Token: 0x040000EA RID: 234
	private static readonly IntPtr NativeMethodInfoPtr_ChangeImage_Private_Void_Image_Boolean_Sprite_0;

	// Token: 0x040000EB RID: 235
	private static readonly IntPtr NativeMethodInfoPtr_Describe_Private_Void_Int32_String_0;

	// Token: 0x040000EC RID: 236
	private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0;

	// Token: 0x040000ED RID: 237
	private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0;

	// Token: 0x040000EE RID: 238
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

	// Token: 0x040000EF RID: 239
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x040000F0 RID: 240
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000F1 RID: 241
	private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_1_Private_Void_MoveDirection_0;

	// Token: 0x040000F2 RID: 242
	private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_2_Private_Boolean_Int32_0;

	// Token: 0x040000F3 RID: 243
	private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__18_0_Private_Boolean_Int32_0;

	// Token: 0x040000F4 RID: 244
	private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_0_Private_Void_Image_0;

	// Token: 0x040000F5 RID: 245
	private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_2_Private_Void_Image_0;

	// Token: 0x040000F6 RID: 246
	private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_3_Private_Void_Image_0;

	// Token: 0x040000F7 RID: 247
	private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_9_Private_Void_Image_0;

	// Token: 0x0200046F RID: 1135
	public sealed class EmployeeSelectorOpenContext : ValueType
	{
		// Token: 0x06007C4F RID: 31823 RVA: 0x0023A62C File Offset: 0x0023882C
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeSelectorOpenContext()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "EmployeeSelectorOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeFieldInfoPtr_bossStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr, "bossStatus");
			DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeFieldInfoPtr_unlockedPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr, "unlockedPartner");
			DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeMethodInfoPtr__ctor_Public_Void_PartnerBossInfo_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr, 100663482);
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x0023A694 File Offset: 0x00238894
		[CallerCount(272)]
		[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17827, XrefRangeEnd = 17829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeSelectorOpenContext(PartnerBossInfo bossStatus, List<int> unlockedPartner) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bossStatus);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedPartner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeMethodInfoPtr__ctor_Public_Void_PartnerBossInfo_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x00042E81 File Offset: 0x00041081
		public EmployeeSelectorOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x00042E8A File Offset: 0x0004108A
		public EmployeeSelectorOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext>.NativeClassPtr))
		{
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x06007C53 RID: 31827 RVA: 0x0023A6F8 File Offset: 0x002388F8
		// (set) Token: 0x06007C54 RID: 31828 RVA: 0x00042E9C File Offset: 0x0004109C
		public unsafe PartnerBossInfo bossStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeFieldInfoPtr_bossStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeFieldInfoPtr_bossStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x06007C55 RID: 31829 RVA: 0x0023A728 File Offset: 0x00238928
		// (set) Token: 0x06007C56 RID: 31830 RVA: 0x00042EBB File Offset: 0x000410BB
		public unsafe List<int> unlockedPartner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeFieldInfoPtr_unlockedPartner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext.NativeFieldInfoPtr_unlockedPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051C7 RID: 20935
		private static readonly IntPtr NativeFieldInfoPtr_bossStatus;

		// Token: 0x040051C8 RID: 20936
		private static readonly IntPtr NativeFieldInfoPtr_unlockedPartner;

		// Token: 0x040051C9 RID: 20937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PartnerBossInfo_List_1_Int32_0;
	}

	// Token: 0x02000470 RID: 1136
	[Serializable]
	public sealed class PartnerProperty : ValueType
	{
		// Token: 0x06007C57 RID: 31831 RVA: 0x0023A758 File Offset: 0x00238958
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerProperty()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "PartnerProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, "id");
			DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, "key");
			DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_interactableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, "interactableKey");
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x00042EDA File Offset: 0x000410DA
		public PartnerProperty(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x00042EE3 File Offset: 0x000410E3
		public PartnerProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr))
		{
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x0023A7C0 File Offset: 0x002389C0
		// (set) Token: 0x06007C5B RID: 31835 RVA: 0x00042EF5 File Offset: 0x000410F5
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06007C5C RID: 31836 RVA: 0x0023A7E8 File Offset: 0x002389E8
		// (set) Token: 0x06007C5D RID: 31837 RVA: 0x00042F10 File Offset: 0x00041110
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06007C5E RID: 31838 RVA: 0x0023A810 File Offset: 0x00238A10
		// (set) Token: 0x06007C5F RID: 31839 RVA: 0x00042F2F File Offset: 0x0004112F
		public unsafe string interactableKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_interactableKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty.NativeFieldInfoPtr_interactableKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040051CA RID: 20938
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040051CB RID: 20939
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040051CC RID: 20940
		private static readonly IntPtr NativeFieldInfoPtr_interactableKey;
	}

	// Token: 0x02000471 RID: 1137
	[ObfuscatedName("DLC3_BossBattleEmployeeSelectorPannel+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06007C60 RID: 31840 RVA: 0x0023A838 File Offset: 0x00238A38
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr, "<>9");
			DLC3_BossBattleEmployeeSelectorPannel.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr, "<>9__17_0");
			DLC3_BossBattleEmployeeSelectorPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr, 100663484);
			DLC3_BossBattleEmployeeSelectorPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__17_0_Internal_Int32_PartnerProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr, 100663485);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x0023A8B4 File Offset: 0x00238AB4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x0023A8F0 File Offset: 0x00238AF0
		[CallerCount(0)]
		public unsafe int _OnPanelInitialize_b__17_0(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__17_0_Internal_Int32_PartnerProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x00042F4E File Offset: 0x0004114E
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06007C64 RID: 31844 RVA: 0x0023A944 File Offset: 0x00238B44
		// (set) Token: 0x06007C65 RID: 31845 RVA: 0x00042F57 File Offset: 0x00041157
		public unsafe static DLC3_BossBattleEmployeeSelectorPannel.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_BossBattleEmployeeSelectorPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_BossBattleEmployeeSelectorPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06007C66 RID: 31846 RVA: 0x0023A96C File Offset: 0x00238B6C
		// (set) Token: 0x06007C67 RID: 31847 RVA: 0x00042F69 File Offset: 0x00041169
		public unsafe static Func<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty, int> __9__17_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_BossBattleEmployeeSelectorPannel.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_BossBattleEmployeeSelectorPannel.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051CD RID: 20941
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040051CE RID: 20942
		private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

		// Token: 0x040051CF RID: 20943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051D0 RID: 20944
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_0_Internal_Int32_PartnerProperty_0;
	}

	// Token: 0x02000472 RID: 1138
	[ObfuscatedName("DLC3_BossBattleEmployeeSelectorPannel+<>c__DisplayClass19_0")]
	public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
	{
		// Token: 0x06007C68 RID: 31848 RVA: 0x0023A994 File Offset: 0x00238B94
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass19_0()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<>c__DisplayClass19_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, "property");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_currentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, "currentId");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663486);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663487);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663488);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663489);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663490);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663491);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr, 100663492);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x0023AA88 File Offset: 0x00238C88
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x0023AAC4 File Offset: 0x00238CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18101, XrefRangeEnd = 18102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__0(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x0023AB08 File Offset: 0x00238D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__2(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x0023AB4C File Offset: 0x00238D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__3(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x0023AB90 File Offset: 0x00238D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18102, XrefRangeEnd = 18105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x0023ABC4 File Offset: 0x00238DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18105, XrefRangeEnd = 18111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__10(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x0023AC08 File Offset: 0x00238E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ProcessElements_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x00042F7B File Offset: 0x0004117B
		public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06007C71 RID: 31857 RVA: 0x0023AC3C File Offset: 0x00238E3C
		// (set) Token: 0x06007C72 RID: 31858 RVA: 0x00042F84 File Offset: 0x00041184
		public unsafe DLC3_BossBattleEmployeeSelectorPannel __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x0023AC6C File Offset: 0x00238E6C
		// (set) Token: 0x06007C74 RID: 31860 RVA: 0x00042FA3 File Offset: 0x000411A3
		public DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_property);
				return new DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_property), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x06007C75 RID: 31861 RVA: 0x0023AC9C File Offset: 0x00238E9C
		// (set) Token: 0x06007C76 RID: 31862 RVA: 0x00042FD1 File Offset: 0x000411D1
		public unsafe int currentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_currentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_currentId)) = value;
			}
		}

		// Token: 0x040051D1 RID: 20945
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040051D2 RID: 20946
		private static readonly IntPtr NativeFieldInfoPtr_property;

		// Token: 0x040051D3 RID: 20947
		private static readonly IntPtr NativeFieldInfoPtr_currentId;

		// Token: 0x040051D4 RID: 20948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051D5 RID: 20949
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__0_Internal_Void_Image_0;

		// Token: 0x040051D6 RID: 20950
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__2_Internal_Void_Image_0;

		// Token: 0x040051D7 RID: 20951
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__3_Internal_Void_Image_0;

		// Token: 0x040051D8 RID: 20952
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__5_Internal_Void_0;

		// Token: 0x040051D9 RID: 20953
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__10_Internal_Void_Image_0;

		// Token: 0x040051DA RID: 20954
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__11_Internal_Void_0;
	}

	// Token: 0x02000473 RID: 1139
	[ObfuscatedName("DLC3_BossBattleEmployeeSelectorPannel+<>c__DisplayClass19_1")]
	public sealed class __c__DisplayClass19_1 : Il2CppSystem.Object
	{
		// Token: 0x06007C77 RID: 31863 RVA: 0x0023ACC4 File Offset: 0x00238EC4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass19_1()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<>c__DisplayClass19_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr, "characterVisual");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr, 100663493);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ProcessElements_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr, 100663494);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ProcessElements_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr, 100663495);
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x0023AD54 File Offset: 0x00238F54
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x0023AD90 File Offset: 0x00238F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18111, XrefRangeEnd = 18113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__1(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ProcessElements_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x0023ADD4 File Offset: 0x00238FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18113, XrefRangeEnd = 18115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__4(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ProcessElements_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C7B RID: 31867 RVA: 0x00042FEC File Offset: 0x000411EC
		public __c__DisplayClass19_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x06007C7C RID: 31868 RVA: 0x0023AE18 File Offset: 0x00239018
		// (set) Token: 0x06007C7D RID: 31869 RVA: 0x00042FF5 File Offset: 0x000411F5
		public unsafe CharacterSpriteSetCompact characterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_characterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x06007C7E RID: 31870 RVA: 0x0023AE48 File Offset: 0x00239048
		// (set) Token: 0x06007C7F RID: 31871 RVA: 0x00043014 File Offset: 0x00041214
		public unsafe DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051DB RID: 20955
		private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

		// Token: 0x040051DC RID: 20956
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;

		// Token: 0x040051DD RID: 20957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051DE RID: 20958
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__1_Internal_Void_Image_0;

		// Token: 0x040051DF RID: 20959
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__4_Internal_Void_Image_0;
	}

	// Token: 0x02000474 RID: 1140
	[ObfuscatedName("DLC3_BossBattleEmployeeSelectorPannel+<>c__DisplayClass19_2")]
	public sealed class __c__DisplayClass19_2 : Il2CppSystem.Object
	{
		// Token: 0x06007C80 RID: 31872 RVA: 0x0023AE78 File Offset: 0x00239078
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass19_2()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<>c__DisplayClass19_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, "characterVisual");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, "CS$<>8__locals2");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, 100663496);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, 100663497);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, 100663498);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, 100663499);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr, 100663500);
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x0023AF30 File Offset: 0x00239130
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x0023AF6C File Offset: 0x0023916C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18115, XrefRangeEnd = 18117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__6(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x0023AFB0 File Offset: 0x002391B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__7(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x0023AFF4 File Offset: 0x002391F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18117, XrefRangeEnd = 18119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__8(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x0023B038 File Offset: 0x00239238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessElements_b__9(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeMethodInfoPtr__ProcessElements_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x00043033 File Offset: 0x00041233
		public __c__DisplayClass19_2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06007C87 RID: 31879 RVA: 0x0023B07C File Offset: 0x0023927C
		// (set) Token: 0x06007C88 RID: 31880 RVA: 0x0004303C File Offset: 0x0004123C
		public unsafe CharacterSpriteSetFull characterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeFieldInfoPtr_characterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x0023B0AC File Offset: 0x002392AC
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x0004305B File Offset: 0x0004125B
		public unsafe DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051E0 RID: 20960
		private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

		// Token: 0x040051E1 RID: 20961
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;

		// Token: 0x040051E2 RID: 20962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051E3 RID: 20963
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__6_Internal_Void_Image_0;

		// Token: 0x040051E4 RID: 20964
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__7_Internal_Void_Image_0;

		// Token: 0x040051E5 RID: 20965
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__8_Internal_Void_Image_0;

		// Token: 0x040051E6 RID: 20966
		private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__9_Internal_Void_Image_0;
	}

	// Token: 0x02000475 RID: 1141
	[ObfuscatedName("DLC3_BossBattleEmployeeSelectorPannel+<>c__DisplayClass21_0")]
	public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
	{
		// Token: 0x06007C8B RID: 31883 RVA: 0x0023B0DC File Offset: 0x002392DC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass21_0()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<>c__DisplayClass21_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr, "characterVisual");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr, 100663501);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr, 100663502);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr, 100663503);
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x0023B16C File Offset: 0x0023936C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x0023B1A8 File Offset: 0x002393A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18119, XrefRangeEnd = 18121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__1(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x0023B1EC File Offset: 0x002393EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18121, XrefRangeEnd = 18123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__4(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x0004307A File Offset: 0x0004127A
		public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06007C90 RID: 31888 RVA: 0x0023B230 File Offset: 0x00239430
		// (set) Token: 0x06007C91 RID: 31889 RVA: 0x00043083 File Offset: 0x00041283
		public unsafe CharacterSpriteSetCompact characterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_characterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06007C92 RID: 31890 RVA: 0x0023B260 File Offset: 0x00239460
		// (set) Token: 0x06007C93 RID: 31891 RVA: 0x000430A2 File Offset: 0x000412A2
		public unsafe DLC3_BossBattleEmployeeSelectorPannel __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051E7 RID: 20967
		private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

		// Token: 0x040051E8 RID: 20968
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040051E9 RID: 20969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051EA RID: 20970
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__1_Internal_Void_Image_0;

		// Token: 0x040051EB RID: 20971
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__4_Internal_Void_Image_0;
	}

	// Token: 0x02000476 RID: 1142
	[ObfuscatedName("DLC3_BossBattleEmployeeSelectorPannel+<>c__DisplayClass21_1")]
	public sealed class __c__DisplayClass21_1 : Il2CppSystem.Object
	{
		// Token: 0x06007C94 RID: 31892 RVA: 0x0023B290 File Offset: 0x00239490
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass21_1()
		{
			Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel>.NativeClassPtr, "<>c__DisplayClass21_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, "characterVisual");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, "<>4__this");
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, 100663504);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, 100663505);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, 100663506);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, 100663507);
			DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr, 100663508);
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x0023B348 File Offset: 0x00239548
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass21_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x0023B384 File Offset: 0x00239584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18123, XrefRangeEnd = 18125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__5(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C97 RID: 31895 RVA: 0x0023B3C8 File Offset: 0x002395C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__6(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x0023B40C File Offset: 0x0023960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18125, XrefRangeEnd = 18127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__7(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x0023B450 File Offset: 0x00239650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__8(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x000430C1 File Offset: 0x000412C1
		public __c__DisplayClass21_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x0023B494 File Offset: 0x00239694
		// (set) Token: 0x06007C9C RID: 31900 RVA: 0x000430CA File Offset: 0x000412CA
		public unsafe CharacterSpriteSetFull characterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeFieldInfoPtr_characterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x0023B4C4 File Offset: 0x002396C4
		// (set) Token: 0x06007C9E RID: 31902 RVA: 0x000430E9 File Offset: 0x000412E9
		public unsafe DLC3_BossBattleEmployeeSelectorPannel __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleEmployeeSelectorPannel.__c__DisplayClass21_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051EC RID: 20972
		private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

		// Token: 0x040051ED RID: 20973
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040051EE RID: 20974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051EF RID: 20975
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__5_Internal_Void_Image_0;

		// Token: 0x040051F0 RID: 20976
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0;

		// Token: 0x040051F1 RID: 20977
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__7_Internal_Void_Image_0;

		// Token: 0x040051F2 RID: 20978
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0;
	}
}
