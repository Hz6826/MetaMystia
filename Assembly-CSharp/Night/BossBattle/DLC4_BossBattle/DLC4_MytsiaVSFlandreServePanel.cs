using System;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000AD RID: 173
	public class DLC4_MytsiaVSFlandreServePanel : UIPanelExtern
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x000DD078 File Offset: 0x000DB278
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_MytsiaVSFlandreServePanel()
		{
			Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_MytsiaVSFlandreServePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr);
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_ManualText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_ManualText");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_HPText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_HPText");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_NameText");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_CardElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_CardElement");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_CardParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_CardParent");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_ParentCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_ParentCanvasGroup");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_DescribeCharacterCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_DescribeCharacterCluster");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "isHide");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_AllInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_AllInstances");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_LetterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "m_LetterGroup");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr__CurrentSelectedLetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "<CurrentSelectedLetter>k__BackingField");
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_get_OpenContext_Private_get_SpecialOrderOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666523);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_SpecialOrderOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666524);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_get_CurrentSelectedLetter_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666525);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_set_CurrentSelectedLetter_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666526);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666527);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666528);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666529);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666530);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_UIElementCluster_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666531);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666532);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666533);
			DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, 100666534);
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x000DD288 File Offset: 0x000DB488
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x000DD2C0 File Offset: 0x000DB4C0
		public unsafe DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_get_OpenContext_Private_get_SpecialOrderOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51872, XrefRangeEnd = 51873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_SpecialOrderOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000DD308 File Offset: 0x000DB508
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x000DD344 File Offset: 0x000DB544
		public unsafe int CurrentSelectedLetter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_get_CurrentSelectedLetter_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_set_CurrentSelectedLetter_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000DD384 File Offset: 0x000DB584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51873, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000DD3C0 File Offset: 0x000DB5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51886, XrefRangeEnd = 51888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000DD408 File Offset: 0x000DB608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51888, XrefRangeEnd = 51912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000DD444 File Offset: 0x000DB644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51912, XrefRangeEnd = 51934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000DD478 File Offset: 0x000DB678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51934, XrefRangeEnd = 51980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(UIElementCluster cluster, GuestGuardMapping guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guard));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_UIElementCluster_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000DD4D4 File Offset: 0x000DB6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51980, XrefRangeEnd = 51989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000DD510 File Offset: 0x000DB710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51989, XrefRangeEnd = 51999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000DD54C File Offset: 0x000DB74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51999, XrefRangeEnd = 52015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_MytsiaVSFlandreServePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0000BD7E File Offset: 0x00009F7E
		public DLC4_MytsiaVSFlandreServePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000DD588 File Offset: 0x000DB788
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0000BD87 File Offset: 0x00009F87
		public unsafe TextMeshProUGUI m_ManualText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_ManualText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_ManualText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000DD5B8 File Offset: 0x000DB7B8
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0000BDA6 File Offset: 0x00009FA6
		public unsafe TextMeshProUGUI m_HPText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_HPText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_HPText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x000DD5E8 File Offset: 0x000DB7E8
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x0000BDC5 File Offset: 0x00009FC5
		public unsafe TextMeshProUGUI m_NameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_NameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_NameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000DD618 File Offset: 0x000DB818
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public unsafe GameObject m_CardElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_CardElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_CardElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000DD648 File Offset: 0x000DB848
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0000BE03 File Offset: 0x0000A003
		public unsafe RectTransform m_CardParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_CardParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_CardParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000DD678 File Offset: 0x000DB878
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0000BE22 File Offset: 0x0000A022
		public unsafe CanvasGroup m_ParentCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_ParentCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_ParentCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000DD6A8 File Offset: 0x000DB8A8
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0000BE41 File Offset: 0x0000A041
		public unsafe UIElementCluster m_DescribeCharacterCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_DescribeCharacterCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_DescribeCharacterCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000DD6D8 File Offset: 0x000DB8D8
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0000BE60 File Offset: 0x0000A060
		public unsafe bool isHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_isHide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_isHide)) = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000DD700 File Offset: 0x000DB900
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0000BE7B File Offset: 0x0000A07B
		public unsafe List<GameObject> m_AllInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_AllInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_AllInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000DD730 File Offset: 0x000DB930
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x0000BE9A File Offset: 0x0000A09A
		public unsafe UILogicalGroupT<GuestGuardMapping> m_LetterGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_LetterGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<GuestGuardMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr_m_LetterGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000DD760 File Offset: 0x000DB960
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0000BEB9 File Offset: 0x0000A0B9
		public DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000DD790 File Offset: 0x000DB990
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x0000BEE7 File Offset: 0x0000A0E7
		public unsafe int _CurrentSelectedLetter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr__CurrentSelectedLetter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.NativeFieldInfoPtr__CurrentSelectedLetter_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeFieldInfoPtr_m_ManualText;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeFieldInfoPtr_m_HPText;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeFieldInfoPtr_m_NameText;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeFieldInfoPtr_m_CardElement;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeFieldInfoPtr_m_CardParent;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentCanvasGroup;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr_m_DescribeCharacterCluster;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_isHide;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_m_AllInstances;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_m_LetterGroup;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSelectedLetter_k__BackingField;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_SpecialOrderOpenContext_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_SpecialOrderOpenContext_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedLetter_Private_get_Int32_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSelectedLetter_Private_set_Void_Int32_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_UIElementCluster_GuestGuardMapping_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005BD RID: 1469
		public sealed class SpecialOrderOpenContext : ValueType
		{
			// Token: 0x06008C9C RID: 35996 RVA: 0x00269F2C File Offset: 0x0026812C
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialOrderOpenContext()
			{
				Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "SpecialOrderOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr);
				DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeFieldInfoPtr_ActiveGuestIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr, "ActiveGuestIds");
				DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeFieldInfoPtr_OnFinishPuttingCardCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr, "OnFinishPuttingCardCallback");
				DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeMethodInfoPtr__ctor_Public_Void_List_1_GuestGuardMapping_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr, 100666535);
			}

			// Token: 0x06008C9D RID: 35997 RVA: 0x00269F94 File Offset: 0x00268194
			[CallerCount(272)]
			[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialOrderOpenContext(List<GuestGuardMapping> activeGuestIds, Action<int> onFinishPuttingCardCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeGuestIds);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishPuttingCardCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeMethodInfoPtr__ctor_Public_Void_List_1_GuestGuardMapping_Action_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C9E RID: 35998 RVA: 0x0004B9B6 File Offset: 0x00049BB6
			public SpecialOrderOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008C9F RID: 35999 RVA: 0x0004B9BF File Offset: 0x00049BBF
			public SpecialOrderOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17002F0F RID: 12047
			// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x00269FF8 File Offset: 0x002681F8
			// (set) Token: 0x06008CA1 RID: 36001 RVA: 0x0004B9D1 File Offset: 0x00049BD1
			public unsafe List<GuestGuardMapping> ActiveGuestIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeFieldInfoPtr_ActiveGuestIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuestGuardMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeFieldInfoPtr_ActiveGuestIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F10 RID: 12048
			// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x0026A028 File Offset: 0x00268228
			// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x0004B9F0 File Offset: 0x00049BF0
			public unsafe Action<int> OnFinishPuttingCardCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeFieldInfoPtr_OnFinishPuttingCardCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext.NativeFieldInfoPtr_OnFinishPuttingCardCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BF9 RID: 23545
			private static readonly IntPtr NativeFieldInfoPtr_ActiveGuestIds;

			// Token: 0x04005BFA RID: 23546
			private static readonly IntPtr NativeFieldInfoPtr_OnFinishPuttingCardCallback;

			// Token: 0x04005BFB RID: 23547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GuestGuardMapping_Action_1_Int32_0;
		}

		// Token: 0x020005BE RID: 1470
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_MytsiaVSFlandreServePanel+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x06008CA4 RID: 36004 RVA: 0x0026A058 File Offset: 0x00268258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr);
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_thisGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, "thisGuard");
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_introduceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, "introduceText");
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, "guard");
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, 100666536);
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, 100666537);
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, 100666538);
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, 100666539);
				DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr, 100666540);
			}

			// Token: 0x06008CA5 RID: 36005 RVA: 0x0026A138 File Offset: 0x00268338
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CA6 RID: 36006 RVA: 0x0026A174 File Offset: 0x00268374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51841, XrefRangeEnd = 51843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CA7 RID: 36007 RVA: 0x0026A1B8 File Offset: 0x002683B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51843, XrefRangeEnd = 51846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CA8 RID: 36008 RVA: 0x0026A1FC File Offset: 0x002683FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51846, XrefRangeEnd = 51850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CA9 RID: 36009 RVA: 0x0026A230 File Offset: 0x00268430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51850, XrefRangeEnd = 51872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CAA RID: 36010 RVA: 0x0004BA0F File Offset: 0x00049C0F
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F11 RID: 12049
			// (get) Token: 0x06008CAB RID: 36011 RVA: 0x0026A264 File Offset: 0x00268464
			// (set) Token: 0x06008CAC RID: 36012 RVA: 0x0004BA18 File Offset: 0x00049C18
			public unsafe DLC4_MytsiaVSFlandreServePanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MytsiaVSFlandreServePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F12 RID: 12050
			// (get) Token: 0x06008CAD RID: 36013 RVA: 0x0026A294 File Offset: 0x00268494
			// (set) Token: 0x06008CAE RID: 36014 RVA: 0x0004BA37 File Offset: 0x00049C37
			public GuestGuardMapping thisGuard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_thisGuard);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_thisGuard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F13 RID: 12051
			// (get) Token: 0x06008CAF RID: 36015 RVA: 0x0026A2C4 File Offset: 0x002684C4
			// (set) Token: 0x06008CB0 RID: 36016 RVA: 0x0004BA65 File Offset: 0x00049C65
			public unsafe string introduceText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_introduceText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_introduceText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F14 RID: 12052
			// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x0026A2EC File Offset: 0x002684EC
			// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x0004BA84 File Offset: 0x00049C84
			public GuestGuardMapping guard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_guard);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MytsiaVSFlandreServePanel.__c__DisplayClass22_0.NativeFieldInfoPtr_guard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005BFC RID: 23548
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BFD RID: 23549
			private static readonly IntPtr NativeFieldInfoPtr_thisGuard;

			// Token: 0x04005BFE RID: 23550
			private static readonly IntPtr NativeFieldInfoPtr_introduceText;

			// Token: 0x04005BFF RID: 23551
			private static readonly IntPtr NativeFieldInfoPtr_guard;

			// Token: 0x04005C00 RID: 23552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C01 RID: 23553
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;

			// Token: 0x04005C02 RID: 23554
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0;

			// Token: 0x04005C03 RID: 23555
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_0;

			// Token: 0x04005C04 RID: 23556
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_0;
		}
	}
}
