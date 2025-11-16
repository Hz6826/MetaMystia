using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace NightScene.UI
{
	// Token: 0x020001B9 RID: 441
	public class WorkSceneTrayPannel : UIPanelExtern
	{
		// Token: 0x0600367E RID: 13950 RVA: 0x00159EF4 File Offset: 0x001580F4
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneTrayPannel()
		{
			Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI", "WorkSceneTrayPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr);
			WorkSceneTrayPannel.NativeFieldInfoPtr_NORMAL_TRAY_LAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "NORMAL_TRAY_LAYER");
			WorkSceneTrayPannel.NativeFieldInfoPtr_INTERACTABLE_TRAY_LAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "INTERACTABLE_TRAY_LAYER");
			WorkSceneTrayPannel.NativeFieldInfoPtr_TrayParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "TrayParent");
			WorkSceneTrayPannel.NativeFieldInfoPtr_TrayField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "TrayField");
			WorkSceneTrayPannel.NativeFieldInfoPtr_m_EffectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "m_EffectField");
			WorkSceneTrayPannel.NativeFieldInfoPtr_OnTrayUpdateSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "OnTrayUpdateSFX");
			WorkSceneTrayPannel.NativeFieldInfoPtr_TrayCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "TrayCanvas");
			WorkSceneTrayPannel.NativeFieldInfoPtr_m_AllTrayInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "m_AllTrayInstances");
			WorkSceneTrayPannel.NativeFieldInfoPtr_m_TrayInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "m_TrayInstancePool");
			WorkSceneTrayPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			WorkSceneTrayPannel.NativeFieldInfoPtr__AllTrayElementGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "<AllTrayElementGroup>k__BackingField");
			WorkSceneTrayPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673642);
			WorkSceneTrayPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673643);
			WorkSceneTrayPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673644);
			WorkSceneTrayPannel.NativeMethodInfoPtr_get_AllTrayElementGroup_Public_get_UILogicalGroupT_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673645);
			WorkSceneTrayPannel.NativeMethodInfoPtr_set_AllTrayElementGroup_Private_set_Void_UILogicalGroupT_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673646);
			WorkSceneTrayPannel.NativeMethodInfoPtr_get_EffectField_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673647);
			WorkSceneTrayPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673648);
			WorkSceneTrayPannel.NativeMethodInfoPtr_PlayClip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673649);
			WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673650);
			WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673651);
			WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673652);
			WorkSceneTrayPannel.NativeMethodInfoPtr_InitializeTray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673653);
			WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673654);
			WorkSceneTrayPannel.NativeMethodInfoPtr_UpdateTrayVisual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673655);
			WorkSceneTrayPannel.NativeMethodInfoPtr_ClearTargetTray_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673656);
			WorkSceneTrayPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673657);
			WorkSceneTrayPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673658);
			WorkSceneTrayPannel.NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673659);
			WorkSceneTrayPannel.NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Private_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, 100673660);
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x0015A17C File Offset: 0x0015837C
		public unsafe override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127833, XrefRangeEnd = 127836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x0015A1C4 File Offset: 0x001583C4
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x0015A1FC File Offset: 0x001583FC
		public unsafe Nullable<WorkSceneTrayPannel.PannelOpenContext> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<WorkSceneTrayPannel.PannelOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127836, XrefRangeEnd = 127844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x0015A244 File Offset: 0x00158444
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x0015A284 File Offset: 0x00158484
		public unsafe UILogicalGroupT<int> AllTrayElementGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_get_AllTrayElementGroup_Public_get_UILogicalGroupT_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_set_AllTrayElementGroup_Private_set_Void_UILogicalGroupT_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x0015A2C8 File Offset: 0x001584C8
		public unsafe Transform EffectField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_get_EffectField_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x0015A308 File Offset: 0x00158508
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x0015A350 File Offset: 0x00158550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127844, XrefRangeEnd = 127849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_PlayClip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x0015A384 File Offset: 0x00158584
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x0015A3C0 File Offset: 0x001585C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127849, XrefRangeEnd = 127918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x0015A3FC File Offset: 0x001585FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127918, XrefRangeEnd = 127919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x0015A438 File Offset: 0x00158638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127981, RefRangeEnd = 127982, XrefRangeStart = 127919, XrefRangeEnd = 127981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeTray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_InitializeTray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x0015A46C File Offset: 0x0015866C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127982, XrefRangeEnd = 128030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x0015A4A8 File Offset: 0x001586A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 128165, RefRangeEnd = 128172, XrefRangeStart = 128030, XrefRangeEnd = 128165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTrayVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_UpdateTrayVisual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x0015A4DC File Offset: 0x001586DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128177, RefRangeEnd = 128178, XrefRangeStart = 128172, XrefRangeEnd = 128177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTargetTray(IEnumerable<int> targetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr_ClearTargetTray_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0015A520 File Offset: 0x00158720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128178, XrefRangeEnd = 128189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTrayPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x0015A55C File Offset: 0x0015875C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128189, XrefRangeEnd = 128198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneTrayPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x0015A598 File Offset: 0x00158798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128198, XrefRangeEnd = 128201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelInitialize_b__24_0(int _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x0015A5E4 File Offset: 0x001587E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128201, XrefRangeEnd = 128211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIElementCluster _OnPanelInitialize_b__24_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Private_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x0001E3E3 File Offset: 0x0001C5E3
		public WorkSceneTrayPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x0015A624 File Offset: 0x00158824
		// (set) Token: 0x06003694 RID: 13972 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		public unsafe static int NORMAL_TRAY_LAYER
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.NativeFieldInfoPtr_NORMAL_TRAY_LAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.NativeFieldInfoPtr_NORMAL_TRAY_LAYER, (void*)(&value));
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x0015A640 File Offset: 0x00158840
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x0001E3FA File Offset: 0x0001C5FA
		public unsafe static int INTERACTABLE_TRAY_LAYER
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.NativeFieldInfoPtr_INTERACTABLE_TRAY_LAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.NativeFieldInfoPtr_INTERACTABLE_TRAY_LAYER, (void*)(&value));
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x0015A65C File Offset: 0x0015885C
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x0001E408 File Offset: 0x0001C608
		public unsafe GameObject TrayParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_TrayParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_TrayParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x0015A68C File Offset: 0x0015888C
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x0001E427 File Offset: 0x0001C627
		public unsafe Transform TrayField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_TrayField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_TrayField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x0015A6BC File Offset: 0x001588BC
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x0001E446 File Offset: 0x0001C646
		public unsafe Transform m_EffectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_m_EffectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_m_EffectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x0015A6EC File Offset: 0x001588EC
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x0001E465 File Offset: 0x0001C665
		public unsafe AudioClip OnTrayUpdateSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_OnTrayUpdateSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_OnTrayUpdateSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x0015A71C File Offset: 0x0015891C
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x0001E484 File Offset: 0x0001C684
		public unsafe Canvas TrayCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_TrayCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_TrayCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x0015A74C File Offset: 0x0015894C
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x0001E4A3 File Offset: 0x0001C6A3
		public unsafe List<ValueTuple<UIElementCluster, UIButtonSimple>> m_AllTrayInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_m_AllTrayInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<UIElementCluster, UIButtonSimple>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_m_AllTrayInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x0015A77C File Offset: 0x0015897C
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x0001E4C2 File Offset: 0x0001C6C2
		public unsafe ObjectPool<UIElementCluster> m_TrayInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_m_TrayInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr_m_TrayInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x0015A7AC File Offset: 0x001589AC
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x0001E4E1 File Offset: 0x0001C6E1
		public Nullable<WorkSceneTrayPannel.PannelOpenContext> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new Nullable<WorkSceneTrayPannel.PannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WorkSceneTrayPannel.PannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WorkSceneTrayPannel.PannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x0015A7DC File Offset: 0x001589DC
		// (set) Token: 0x060036A8 RID: 13992 RVA: 0x0001E50F File Offset: 0x0001C70F
		public unsafe UILogicalGroupT<int> _AllTrayElementGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr__AllTrayElementGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.NativeFieldInfoPtr__AllTrayElementGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr_NORMAL_TRAY_LAYER;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr_INTERACTABLE_TRAY_LAYER;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr_TrayParent;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr_TrayField;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectField;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeFieldInfoPtr_OnTrayUpdateSFX;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeFieldInfoPtr_TrayCanvas;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeFieldInfoPtr_m_AllTrayInstances;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeFieldInfoPtr_m_TrayInstancePool;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeFieldInfoPtr__AllTrayElementGroup_k__BackingField;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeMethodInfoPtr_get_AllTrayElementGroup_Public_get_UILogicalGroupT_1_Int32_0;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeMethodInfoPtr_set_AllTrayElementGroup_Private_set_Void_UILogicalGroupT_1_Int32_0;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectField_Public_get_Transform_0;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_PlayClip_Private_Void_0;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_InitializeTray_Private_Void_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrayVisual_Public_Void_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_ClearTargetTray_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Boolean_Int32_0;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Private_UIElementCluster_0;

		// Token: 0x02000923 RID: 2339
		public sealed class PannelOpenContext : ValueType
		{
			// Token: 0x0600B7FA RID: 47098 RVA: 0x002E8F90 File Offset: 0x002E7190
			// Note: this type is marked as 'beforefieldinit'.
			static PannelOpenContext()
			{
				Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "PannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr);
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_EnableControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "EnableControl");
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_InputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "InputMode");
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "OnTrayElementSelect");
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "OnTrayElementSubmit");
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnNullTrayElementSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "OnNullTrayElementSelect");
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementOverrideUpDownMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "OnTrayElementOverrideUpDownMove");
				WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_TraySpecialEffectCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, "TraySpecialEffectCanvas");
				WorkSceneTrayPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Action_1_Sellable_Action_1_Sellable_Action_Action_2_MoveDirection_Int32_Transform_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, 100673661);
				WorkSceneTrayPannel.PannelOpenContext.NativeMethodInfoPtr_GetDefaultContext_Public_Static_PannelOpenContext_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr, 100673662);
			}

			// Token: 0x0600B7FB RID: 47099 RVA: 0x002E9070 File Offset: 0x002E7270
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 127793, RefRangeEnd = 127796, XrefRangeStart = 127784, XrefRangeEnd = 127793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PannelOpenContext(bool enableControl, Action<Sellable> onTrayElementSelect, Action<Sellable> onTrayElementSubmit, Action onNullTrayElementSelect, Action<MoveDirection, int> onTrayElementOverrideUpDownMove, Transform traySpecialEffectTransform, AdpUIPanelManager.RequestedInputMode inputMode = AdpUIPanelManager.RequestedInputMode.UI) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref enableControl;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTrayElementSelect);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTrayElementSubmit);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onNullTrayElementSelect);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTrayElementOverrideUpDownMove);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(traySpecialEffectTransform);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Action_1_Sellable_Action_1_Sellable_Action_Action_2_MoveDirection_Int32_Transform_RequestedInputMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7FC RID: 47100 RVA: 0x002E9128 File Offset: 0x002E7328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127796, XrefRangeEnd = 127807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static WorkSceneTrayPannel.PannelOpenContext GetDefaultContext(AdpUIPanelManager.RequestedInputMode inputMode)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref inputMode;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.PannelOpenContext.NativeMethodInfoPtr_GetDefaultContext_Public_Static_PannelOpenContext_RequestedInputMode_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new WorkSceneTrayPannel.PannelOpenContext(pointer);
			}

			// Token: 0x0600B7FD RID: 47101 RVA: 0x00063456 File Offset: 0x00061656
			public PannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B7FE RID: 47102 RVA: 0x0006345F File Offset: 0x0006165F
			public PannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel.PannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003C4A RID: 15434
			// (get) Token: 0x0600B7FF RID: 47103 RVA: 0x002E9160 File Offset: 0x002E7360
			// (set) Token: 0x0600B800 RID: 47104 RVA: 0x00063471 File Offset: 0x00061671
			public unsafe bool EnableControl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_EnableControl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_EnableControl)) = value;
				}
			}

			// Token: 0x17003C4B RID: 15435
			// (get) Token: 0x0600B801 RID: 47105 RVA: 0x002E9188 File Offset: 0x002E7388
			// (set) Token: 0x0600B802 RID: 47106 RVA: 0x0006348C File Offset: 0x0006168C
			public unsafe AdpUIPanelManager.RequestedInputMode InputMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_InputMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_InputMode)) = value;
				}
			}

			// Token: 0x17003C4C RID: 15436
			// (get) Token: 0x0600B803 RID: 47107 RVA: 0x002E91B0 File Offset: 0x002E73B0
			// (set) Token: 0x0600B804 RID: 47108 RVA: 0x000634A7 File Offset: 0x000616A7
			public unsafe Action<Sellable> OnTrayElementSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementSelect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C4D RID: 15437
			// (get) Token: 0x0600B805 RID: 47109 RVA: 0x002E91E0 File Offset: 0x002E73E0
			// (set) Token: 0x0600B806 RID: 47110 RVA: 0x000634C6 File Offset: 0x000616C6
			public unsafe Action<Sellable> OnTrayElementSubmit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementSubmit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C4E RID: 15438
			// (get) Token: 0x0600B807 RID: 47111 RVA: 0x002E9210 File Offset: 0x002E7410
			// (set) Token: 0x0600B808 RID: 47112 RVA: 0x000634E5 File Offset: 0x000616E5
			public unsafe Action OnNullTrayElementSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnNullTrayElementSelect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnNullTrayElementSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C4F RID: 15439
			// (get) Token: 0x0600B809 RID: 47113 RVA: 0x002E9240 File Offset: 0x002E7440
			// (set) Token: 0x0600B80A RID: 47114 RVA: 0x00063504 File Offset: 0x00061704
			public unsafe Action<MoveDirection, int> OnTrayElementOverrideUpDownMove
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementOverrideUpDownMove);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoveDirection, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_OnTrayElementOverrideUpDownMove), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C50 RID: 15440
			// (get) Token: 0x0600B80B RID: 47115 RVA: 0x002E9270 File Offset: 0x002E7470
			// (set) Token: 0x0600B80C RID: 47116 RVA: 0x00063523 File Offset: 0x00061723
			public unsafe Canvas TraySpecialEffectCanvas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_TraySpecialEffectCanvas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.PannelOpenContext.NativeFieldInfoPtr_TraySpecialEffectCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007701 RID: 30465
			private static readonly IntPtr NativeFieldInfoPtr_EnableControl;

			// Token: 0x04007702 RID: 30466
			private static readonly IntPtr NativeFieldInfoPtr_InputMode;

			// Token: 0x04007703 RID: 30467
			private static readonly IntPtr NativeFieldInfoPtr_OnTrayElementSelect;

			// Token: 0x04007704 RID: 30468
			private static readonly IntPtr NativeFieldInfoPtr_OnTrayElementSubmit;

			// Token: 0x04007705 RID: 30469
			private static readonly IntPtr NativeFieldInfoPtr_OnNullTrayElementSelect;

			// Token: 0x04007706 RID: 30470
			private static readonly IntPtr NativeFieldInfoPtr_OnTrayElementOverrideUpDownMove;

			// Token: 0x04007707 RID: 30471
			private static readonly IntPtr NativeFieldInfoPtr_TraySpecialEffectCanvas;

			// Token: 0x04007708 RID: 30472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Action_1_Sellable_Action_1_Sellable_Action_Action_2_MoveDirection_Int32_Transform_RequestedInputMode_0;

			// Token: 0x04007709 RID: 30473
			private static readonly IntPtr NativeMethodInfoPtr_GetDefaultContext_Public_Static_PannelOpenContext_RequestedInputMode_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("NightScene.UI.WorkSceneTrayPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B80D RID: 47117 RVA: 0x002E92A0 File Offset: 0x002E74A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr);
				WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, "<>9");
				WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, "<>9__24_2");
				WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, "<>9__24_3");
				WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, "<>9__24_4");
				WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, "<>9__28_0");
				WorkSceneTrayPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, 100673664);
				WorkSceneTrayPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_2_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, 100673665);
				WorkSceneTrayPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_3_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, 100673666);
				WorkSceneTrayPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_4_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, 100673667);
				WorkSceneTrayPannel.__c.NativeMethodInfoPtr__UpdateTrayVisual_b__28_0_Internal_UIButtonSimple_ValueTuple_2_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr, 100673668);
			}

			// Token: 0x0600B80E RID: 47118 RVA: 0x002E9394 File Offset: 0x002E7594
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B80F RID: 47119 RVA: 0x002E93D0 File Offset: 0x002E75D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127807, XrefRangeEnd = 127814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__24_2(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_2_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B810 RID: 47120 RVA: 0x002E9414 File Offset: 0x002E7614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127814, XrefRangeEnd = 127818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__24_3(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_3_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B811 RID: 47121 RVA: 0x002E9458 File Offset: 0x002E7658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127818, XrefRangeEnd = 127824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__24_4(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_4_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B812 RID: 47122 RVA: 0x002E949C File Offset: 0x002E769C
			[CallerCount(0)]
			public unsafe UIButtonSimple _UpdateTrayVisual_b__28_0(ValueTuple<UIElementCluster, UIButtonSimple> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c.NativeMethodInfoPtr__UpdateTrayVisual_b__28_0_Internal_UIButtonSimple_ValueTuple_2_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr3) : null;
			}

			// Token: 0x0600B813 RID: 47123 RVA: 0x00063542 File Offset: 0x00061742
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C51 RID: 15441
			// (get) Token: 0x0600B814 RID: 47124 RVA: 0x002E94F4 File Offset: 0x002E76F4
			// (set) Token: 0x0600B815 RID: 47125 RVA: 0x0006354B File Offset: 0x0006174B
			public unsafe static WorkSceneTrayPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C52 RID: 15442
			// (get) Token: 0x0600B816 RID: 47126 RVA: 0x002E951C File Offset: 0x002E771C
			// (set) Token: 0x0600B817 RID: 47127 RVA: 0x0006355D File Offset: 0x0006175D
			public unsafe static Action<UIElementCluster> __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C53 RID: 15443
			// (get) Token: 0x0600B818 RID: 47128 RVA: 0x002E9544 File Offset: 0x002E7744
			// (set) Token: 0x0600B819 RID: 47129 RVA: 0x0006356F File Offset: 0x0006176F
			public unsafe static Action<UIElementCluster> __9__24_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C54 RID: 15444
			// (get) Token: 0x0600B81A RID: 47130 RVA: 0x002E956C File Offset: 0x002E776C
			// (set) Token: 0x0600B81B RID: 47131 RVA: 0x00063581 File Offset: 0x00061781
			public unsafe static Action<UIElementCluster> __9__24_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__24_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C55 RID: 15445
			// (get) Token: 0x0600B81C RID: 47132 RVA: 0x002E9594 File Offset: 0x002E7794
			// (set) Token: 0x0600B81D RID: 47133 RVA: 0x00063593 File Offset: 0x00061793
			public unsafe static Func<ValueTuple<UIElementCluster, UIButtonSimple>, UIButtonSimple> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<UIElementCluster, UIButtonSimple>, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTrayPannel.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400770A RID: 30474
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400770B RID: 30475
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x0400770C RID: 30476
			private static readonly IntPtr NativeFieldInfoPtr___9__24_3;

			// Token: 0x0400770D RID: 30477
			private static readonly IntPtr NativeFieldInfoPtr___9__24_4;

			// Token: 0x0400770E RID: 30478
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400770F RID: 30479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007710 RID: 30480
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_2_Internal_Void_UIElementCluster_0;

			// Token: 0x04007711 RID: 30481
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_3_Internal_Void_UIElementCluster_0;

			// Token: 0x04007712 RID: 30482
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_4_Internal_Void_UIElementCluster_0;

			// Token: 0x04007713 RID: 30483
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrayVisual_b__28_0_Internal_UIButtonSimple_ValueTuple_2_UIElementCluster_UIButtonSimple_0;
		}

		// Token: 0x02000925 RID: 2341
		[ObfuscatedName("NightScene.UI.WorkSceneTrayPannel+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B81E RID: 47134 RVA: 0x002E95BC File Offset: 0x002E77BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr);
				WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_onTrayElementSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr, "onTrayElementSelect");
				WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_onTrayElementSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr, "onTrayElementSubmit");
				WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_overrideUpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr, "overrideUpDown");
				WorkSceneTrayPannel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr, 100673669);
			}

			// Token: 0x0600B81F RID: 47135 RVA: 0x002E9638 File Offset: 0x002E7838
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B820 RID: 47136 RVA: 0x000635A5 File Offset: 0x000617A5
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C56 RID: 15446
			// (get) Token: 0x0600B821 RID: 47137 RVA: 0x002E9674 File Offset: 0x002E7874
			// (set) Token: 0x0600B822 RID: 47138 RVA: 0x000635AE File Offset: 0x000617AE
			public unsafe Action<Sellable> onTrayElementSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_onTrayElementSelect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_onTrayElementSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C57 RID: 15447
			// (get) Token: 0x0600B823 RID: 47139 RVA: 0x002E96A4 File Offset: 0x002E78A4
			// (set) Token: 0x0600B824 RID: 47140 RVA: 0x000635CD File Offset: 0x000617CD
			public unsafe Action<Sellable> onTrayElementSubmit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_onTrayElementSubmit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_onTrayElementSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C58 RID: 15448
			// (get) Token: 0x0600B825 RID: 47141 RVA: 0x002E96D4 File Offset: 0x002E78D4
			// (set) Token: 0x0600B826 RID: 47142 RVA: 0x000635EC File Offset: 0x000617EC
			public unsafe Action<MoveDirection, int> overrideUpDown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_overrideUpDown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoveDirection, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_0.NativeFieldInfoPtr_overrideUpDown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007714 RID: 30484
			private static readonly IntPtr NativeFieldInfoPtr_onTrayElementSelect;

			// Token: 0x04007715 RID: 30485
			private static readonly IntPtr NativeFieldInfoPtr_onTrayElementSubmit;

			// Token: 0x04007716 RID: 30486
			private static readonly IntPtr NativeFieldInfoPtr_overrideUpDown;

			// Token: 0x04007717 RID: 30487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000926 RID: 2342
		[ObfuscatedName("NightScene.UI.WorkSceneTrayPannel+<>c__DisplayClass28_1")]
		public sealed class __c__DisplayClass28_1 : Il2CppSystem.Object
		{
			// Token: 0x0600B827 RID: 47143 RVA: 0x002E9704 File Offset: 0x002E7904
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_1()
			{
				Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "<>c__DisplayClass28_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr);
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_currentSellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, "currentSellable");
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_checkHasSellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, "checkHasSellable");
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, "CS$<>8__locals1");
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, 100673670);
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, 100673671);
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, 100673672);
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, 100673673);
				WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr, 100673674);
			}

			// Token: 0x0600B828 RID: 47144 RVA: 0x002E97D0 File Offset: 0x002E79D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B829 RID: 47145 RVA: 0x002E980C File Offset: 0x002E7A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127824, XrefRangeEnd = 127825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTrayVisual_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B82A RID: 47146 RVA: 0x002E9840 File Offset: 0x002E7A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127825, XrefRangeEnd = 127826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTrayVisual_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B82B RID: 47147 RVA: 0x002E9874 File Offset: 0x002E7A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127826, XrefRangeEnd = 127829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTrayVisual_b__3(Image imageComponent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B82C RID: 47148 RVA: 0x002E98B8 File Offset: 0x002E7AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127829, XrefRangeEnd = 127833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTrayVisual_b__4(Image modifier)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeMethodInfoPtr__UpdateTrayVisual_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B82D RID: 47149 RVA: 0x0006360B File Offset: 0x0006180B
			public __c__DisplayClass28_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C59 RID: 15449
			// (get) Token: 0x0600B82E RID: 47150 RVA: 0x002E98FC File Offset: 0x002E7AFC
			// (set) Token: 0x0600B82F RID: 47151 RVA: 0x00063614 File Offset: 0x00061814
			public unsafe Sellable currentSellable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_currentSellable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_currentSellable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C5A RID: 15450
			// (get) Token: 0x0600B830 RID: 47152 RVA: 0x002E992C File Offset: 0x002E7B2C
			// (set) Token: 0x0600B831 RID: 47153 RVA: 0x00063633 File Offset: 0x00061833
			public unsafe bool checkHasSellable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_checkHasSellable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_checkHasSellable)) = value;
				}
			}

			// Token: 0x17003C5B RID: 15451
			// (get) Token: 0x0600B832 RID: 47154 RVA: 0x002E9954 File Offset: 0x002E7B54
			// (set) Token: 0x0600B833 RID: 47155 RVA: 0x0006364E File Offset: 0x0006184E
			public unsafe WorkSceneTrayPannel.__c__DisplayClass28_0 field_Public___c__DisplayClass28_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel.__c__DisplayClass28_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_1.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007718 RID: 30488
			private static readonly IntPtr NativeFieldInfoPtr_currentSellable;

			// Token: 0x04007719 RID: 30489
			private static readonly IntPtr NativeFieldInfoPtr_checkHasSellable;

			// Token: 0x0400771A RID: 30490
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0;

			// Token: 0x0400771B RID: 30491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400771C RID: 30492
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrayVisual_b__1_Internal_Void_0;

			// Token: 0x0400771D RID: 30493
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrayVisual_b__2_Internal_Void_0;

			// Token: 0x0400771E RID: 30494
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrayVisual_b__3_Internal_Void_Image_0;

			// Token: 0x0400771F RID: 30495
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrayVisual_b__4_Internal_Void_Image_0;
		}

		// Token: 0x02000927 RID: 2343
		[ObfuscatedName("NightScene.UI.WorkSceneTrayPannel+<>c__DisplayClass28_2")]
		public sealed class __c__DisplayClass28_2 : Il2CppSystem.Object
		{
			// Token: 0x0600B834 RID: 47156 RVA: 0x002E9984 File Offset: 0x002E7B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_2()
			{
				Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTrayPannel>.NativeClassPtr, "<>c__DisplayClass28_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr);
				WorkSceneTrayPannel.__c__DisplayClass28_2.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr, "index");
				WorkSceneTrayPannel.__c__DisplayClass28_2.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr, "CS$<>8__locals2");
				WorkSceneTrayPannel.__c__DisplayClass28_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr, 100673675);
				WorkSceneTrayPannel.__c__DisplayClass28_2.NativeMethodInfoPtr__UpdateTrayVisual_b__5_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr, 100673676);
			}

			// Token: 0x0600B835 RID: 47157 RVA: 0x002E9A00 File Offset: 0x002E7C00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTrayPannel.__c__DisplayClass28_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B836 RID: 47158 RVA: 0x002E9A3C File Offset: 0x002E7C3C
			[CallerCount(0)]
			public unsafe void _UpdateTrayVisual_b__5(MoveDirection dir)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTrayPannel.__c__DisplayClass28_2.NativeMethodInfoPtr__UpdateTrayVisual_b__5_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B837 RID: 47159 RVA: 0x0006366D File Offset: 0x0006186D
			public __c__DisplayClass28_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C5C RID: 15452
			// (get) Token: 0x0600B838 RID: 47160 RVA: 0x002E9A7C File Offset: 0x002E7C7C
			// (set) Token: 0x0600B839 RID: 47161 RVA: 0x00063676 File Offset: 0x00061876
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_2.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_2.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17003C5D RID: 15453
			// (get) Token: 0x0600B83A RID: 47162 RVA: 0x002E9AA4 File Offset: 0x002E7CA4
			// (set) Token: 0x0600B83B RID: 47163 RVA: 0x00063691 File Offset: 0x00061891
			public unsafe WorkSceneTrayPannel.__c__DisplayClass28_0 field_Public___c__DisplayClass28_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_2.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel.__c__DisplayClass28_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTrayPannel.__c__DisplayClass28_2.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007720 RID: 30496
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04007721 RID: 30497
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0;

			// Token: 0x04007722 RID: 30498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007723 RID: 30499
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrayVisual_b__5_Internal_Void_MoveDirection_0;
		}
	}
}
