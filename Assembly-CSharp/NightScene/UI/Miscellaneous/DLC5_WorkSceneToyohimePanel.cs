using System;
using Common.UI.GlobalMap;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NightScene.UI.Miscellaneous
{
	// Token: 0x020001BA RID: 442
	public class DLC5_WorkSceneToyohimePanel : GuideMapPanel<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext, string>
	{
		// Token: 0x060036A9 RID: 13993 RVA: 0x0015A80C File Offset: 0x00158A0C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_WorkSceneToyohimePanel()
		{
			Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.Miscellaneous", "DLC5_WorkSceneToyohimePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr);
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_Animator");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_SubmitInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_SubmitInput");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_HasLinkedInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_HasLinkedInput");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_InputOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_InputOffset");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_Delay");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_CurrentSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_CurrentSpot");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_ActivedSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_ActivedSpots");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_ShowButDisableSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_ShowButDisableSpots");
			DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_CurrentSelectedSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "m_CurrentSelectedSpot");
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673677);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_CloseExternPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673678);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_ToyohimeMapOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673679);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OpenBlockPanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673680);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_ToyohimeMapOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673681);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673682);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673683);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673684);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673685);
			DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr__OnGuideMapInitialize_b__6_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, 100673686);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0015A9B8 File Offset: 0x00158BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128226, XrefRangeEnd = 128237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0015A9F4 File Offset: 0x00158BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128237, XrefRangeEnd = 128242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_CloseExternPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0015AA28 File Offset: 0x00158C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128242, XrefRangeEnd = 128255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelEndOpen(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_ToyohimeMapOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0015AA7C File Offset: 0x00158C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128255, XrefRangeEnd = 128260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OpenBlockPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OpenBlockPanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0015AABC File Offset: 0x00158CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128260, XrefRangeEnd = 128300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelPreOpen(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_ToyohimeMapOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x0015AB10 File Offset: 0x00158D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128300, XrefRangeEnd = 128306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0015AB68 File Offset: 0x00158D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128306, XrefRangeEnd = 128335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0015ABB8 File Offset: 0x00158DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128335, XrefRangeEnd = 128344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0015AC08 File Offset: 0x00158E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128344, XrefRangeEnd = 128360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_WorkSceneToyohimePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0015AC44 File Offset: 0x00158E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128360, XrefRangeEnd = 128365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__6_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel.NativeMethodInfoPtr__OnGuideMapInitialize_b__6_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x0001E52E File Offset: 0x0001C72E
		public DLC5_WorkSceneToyohimePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x0015AC8C File Offset: 0x00158E8C
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x0001E537 File Offset: 0x0001C737
		public unsafe Animator m_Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x0015ACBC File Offset: 0x00158EBC
		// (set) Token: 0x060036B8 RID: 14008 RVA: 0x0001E556 File Offset: 0x0001C756
		public unsafe CanvasGroup m_SubmitInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_SubmitInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_SubmitInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x0015ACEC File Offset: 0x00158EEC
		// (set) Token: 0x060036BA RID: 14010 RVA: 0x0001E575 File Offset: 0x0001C775
		public unsafe CanvasGroup m_HasLinkedInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_HasLinkedInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_HasLinkedInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x0015AD1C File Offset: 0x00158F1C
		// (set) Token: 0x060036BC RID: 14012 RVA: 0x0001E594 File Offset: 0x0001C794
		public unsafe Vector3 m_InputOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_InputOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_InputOffset)) = value;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x0015AD44 File Offset: 0x00158F44
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x0001E5AF File Offset: 0x0001C7AF
		public unsafe float m_Delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_Delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_Delay)) = value;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x0015AD6C File Offset: 0x00158F6C
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x0001E5CA File Offset: 0x0001C7CA
		public unsafe string m_CurrentSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_CurrentSpot);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_CurrentSpot), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x0015AD94 File Offset: 0x00158F94
		// (set) Token: 0x060036C2 RID: 14018 RVA: 0x0001E5E9 File Offset: 0x0001C7E9
		public unsafe HashSet<string> m_ActivedSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_ActivedSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_ActivedSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x0015ADC4 File Offset: 0x00158FC4
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x0001E608 File Offset: 0x0001C808
		public unsafe HashSet<string> m_ShowButDisableSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_ShowButDisableSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_ShowButDisableSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x0015ADF4 File Offset: 0x00158FF4
		// (set) Token: 0x060036C6 RID: 14022 RVA: 0x0001E627 File Offset: 0x0001C827
		public unsafe string m_CurrentSelectedSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_CurrentSelectedSpot);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.NativeFieldInfoPtr_m_CurrentSelectedSpot), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeFieldInfoPtr_m_SubmitInput;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeFieldInfoPtr_m_HasLinkedInput;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeFieldInfoPtr_m_InputOffset;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeFieldInfoPtr_m_Delay;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSpot;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeFieldInfoPtr_m_ActivedSpots;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowButDisableSpots;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedSpot;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr_CloseExternPanel_Public_Void_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_ToyohimeMapOpenContext_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_OpenBlockPanel_Private_IEnumerator_0;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_ToyohimeMapOpenContext_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__6_0_Private_Void_CallbackContext_0;

		// Token: 0x02000928 RID: 2344
		public sealed class ToyohimeMapOpenContext : ValueType
		{
			// Token: 0x0600B83C RID: 47164 RVA: 0x002E9AD4 File Offset: 0x002E7CD4
			// Note: this type is marked as 'beforefieldinit'.
			static ToyohimeMapOpenContext()
			{
				Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "ToyohimeMapOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr);
				DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CheckSpotOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr, "CheckSpotOpened");
				DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CheckSpotLinked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr, "CheckSpotLinked");
				DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CurrentMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr, "CurrentMapLabel");
				DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Predicate_1_String_Predicate_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr, 100673687);
			}

			// Token: 0x0600B83D RID: 47165 RVA: 0x002E9B50 File Offset: 0x002E7D50
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 73879, RefRangeEnd = 73914, XrefRangeStart = 73879, XrefRangeEnd = 73914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToyohimeMapOpenContext(Predicate<string> checkSpotOpened, Predicate<string> checkSpotLinked, string currentMapLabel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(checkSpotOpened);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkSpotLinked);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentMapLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Predicate_1_String_Predicate_1_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B83E RID: 47166 RVA: 0x000636B0 File Offset: 0x000618B0
			public ToyohimeMapOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B83F RID: 47167 RVA: 0x000636B9 File Offset: 0x000618B9
			public ToyohimeMapOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003C5E RID: 15454
			// (get) Token: 0x0600B840 RID: 47168 RVA: 0x002E9BC4 File Offset: 0x002E7DC4
			// (set) Token: 0x0600B841 RID: 47169 RVA: 0x000636CB File Offset: 0x000618CB
			public unsafe Predicate<string> CheckSpotOpened
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CheckSpotOpened);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CheckSpotOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C5F RID: 15455
			// (get) Token: 0x0600B842 RID: 47170 RVA: 0x002E9BF4 File Offset: 0x002E7DF4
			// (set) Token: 0x0600B843 RID: 47171 RVA: 0x000636EA File Offset: 0x000618EA
			public unsafe Predicate<string> CheckSpotLinked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CheckSpotLinked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CheckSpotLinked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C60 RID: 15456
			// (get) Token: 0x0600B844 RID: 47172 RVA: 0x002E9C24 File Offset: 0x002E7E24
			// (set) Token: 0x0600B845 RID: 47173 RVA: 0x00063709 File Offset: 0x00061909
			public unsafe string CurrentMapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CurrentMapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext.NativeFieldInfoPtr_CurrentMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04007724 RID: 30500
			private static readonly IntPtr NativeFieldInfoPtr_CheckSpotOpened;

			// Token: 0x04007725 RID: 30501
			private static readonly IntPtr NativeFieldInfoPtr_CheckSpotLinked;

			// Token: 0x04007726 RID: 30502
			private static readonly IntPtr NativeFieldInfoPtr_CurrentMapLabel;

			// Token: 0x04007727 RID: 30503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Predicate_1_String_Predicate_1_String_String_0;
		}

		// Token: 0x02000929 RID: 2345
		[ObfuscatedName("NightScene.UI.Miscellaneous.DLC5_WorkSceneToyohimePanel+<OpenBlockPanel>d__13")]
		public sealed class _OpenBlockPanel_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600B846 RID: 47174 RVA: 0x002E9C4C File Offset: 0x002E7E4C
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenBlockPanel_d__13()
			{
				Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel>.NativeClassPtr, "<OpenBlockPanel>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr);
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, "<>1__state");
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, "<>2__current");
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, "<>4__this");
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, 100673688);
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, 100673689);
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, 100673690);
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, 100673691);
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, 100673692);
				DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr, 100673693);
			}

			// Token: 0x0600B847 RID: 47175 RVA: 0x002E9D2C File Offset: 0x002E7F2C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OpenBlockPanel_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B848 RID: 47176 RVA: 0x002E9D74 File Offset: 0x002E7F74
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B849 RID: 47177 RVA: 0x002E9DA8 File Offset: 0x002E7FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128211, XrefRangeEnd = 128220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C64 RID: 15460
			// (get) Token: 0x0600B84A RID: 47178 RVA: 0x002E9DE4 File Offset: 0x002E7FE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B84B RID: 47179 RVA: 0x002E9E24 File Offset: 0x002E8024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128220, XrefRangeEnd = 128226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C65 RID: 15461
			// (get) Token: 0x0600B84C RID: 47180 RVA: 0x002E9E58 File Offset: 0x002E8058
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B84D RID: 47181 RVA: 0x00063728 File Offset: 0x00061928
			public _OpenBlockPanel_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C61 RID: 15457
			// (get) Token: 0x0600B84E RID: 47182 RVA: 0x002E9E98 File Offset: 0x002E8098
			// (set) Token: 0x0600B84F RID: 47183 RVA: 0x00063731 File Offset: 0x00061931
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C62 RID: 15458
			// (get) Token: 0x0600B850 RID: 47184 RVA: 0x002E9EC0 File Offset: 0x002E80C0
			// (set) Token: 0x0600B851 RID: 47185 RVA: 0x0006374C File Offset: 0x0006194C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C63 RID: 15459
			// (get) Token: 0x0600B852 RID: 47186 RVA: 0x002E9EF0 File Offset: 0x002E80F0
			// (set) Token: 0x0600B853 RID: 47187 RVA: 0x0006376B File Offset: 0x0006196B
			public unsafe DLC5_WorkSceneToyohimePanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_WorkSceneToyohimePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_WorkSceneToyohimePanel._OpenBlockPanel_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007728 RID: 30504
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007729 RID: 30505
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400772A RID: 30506
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400772B RID: 30507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400772C RID: 30508
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400772D RID: 30509
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400772E RID: 30510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400772F RID: 30511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007730 RID: 30512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
