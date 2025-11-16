using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x020003D2 RID: 978
	public class DLC5_SpecialGuestSelectionPanel : UIPanelParam<DLC5_SpecialGuestSelectionPanel.OpenContext, SpecialGuest>
	{
		// Token: 0x060074CC RID: 29900 RVA: 0x00223A38 File Offset: 0x00221C38
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_SpecialGuestSelectionPanel()
		{
			Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.CreatorsBox", "DLC5_SpecialGuestSelectionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr);
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_Grid");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_Prefab");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_ProgressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_ProgressIndicator");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_NullPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_NullPanel");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_DescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_DescriberPanel");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_Fallback");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_SpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_SpecialGuests");
			DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_SpecialGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "m_SpecialGuestGroup");
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687283);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687284);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687285);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687286);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687287);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_SpecialGuest_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687288);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_SpecialGuest_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687289);
			DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, 100687290);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x00223BA8 File Offset: 0x00221DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290645, XrefRangeEnd = 290686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x00223BE4 File Offset: 0x00221DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290686, XrefRangeEnd = 290702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_SpecialGuestSelectionPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x00223C38 File Offset: 0x00221E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290702, XrefRangeEnd = 290707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose(SpecialGuest closeParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(closeParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_SpecialGuest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x00223C88 File Offset: 0x00221E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290707, XrefRangeEnd = 290718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x00223CC4 File Offset: 0x00221EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290718, XrefRangeEnd = 290729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_SpecialGuestSelectionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x00223D00 File Offset: 0x00221F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290729, XrefRangeEnd = 290851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_0(SpecialGuest guestData, UIElementCluster cluster, UIButtonSimple _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_SpecialGuest_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00223D68 File Offset: 0x00221F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290851, XrefRangeEnd = 290865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_1(SpecialGuest guest, UIElementCluster _, UIButtonSimple btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_SpecialGuest_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x00223DD0 File Offset: 0x00221FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290865, XrefRangeEnd = 290869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_2(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		public DLC5_SpecialGuestSelectionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x00223E18 File Offset: 0x00222018
		// (set) Token: 0x060074D7 RID: 29911 RVA: 0x0003F3A9 File Offset: 0x0003D5A9
		public unsafe GridLayoutGroup m_Grid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Grid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Grid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x060074D8 RID: 29912 RVA: 0x00223E48 File Offset: 0x00222048
		// (set) Token: 0x060074D9 RID: 29913 RVA: 0x0003F3C8 File Offset: 0x0003D5C8
		public unsafe UIElementCluster m_Prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x060074DA RID: 29914 RVA: 0x00223E78 File Offset: 0x00222078
		// (set) Token: 0x060074DB RID: 29915 RVA: 0x0003F3E7 File Offset: 0x0003D5E7
		public unsafe AdpProgressIndicatorComponent m_ProgressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_ProgressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_ProgressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x00223EA8 File Offset: 0x002220A8
		// (set) Token: 0x060074DD RID: 29917 RVA: 0x0003F406 File Offset: 0x0003D606
		public unsafe CanvasGroup m_NullPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_NullPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_NullPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x060074DE RID: 29918 RVA: 0x00223ED8 File Offset: 0x002220D8
		// (set) Token: 0x060074DF RID: 29919 RVA: 0x0003F425 File Offset: 0x0003D625
		public unsafe CanvasGroup m_DescriberPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_DescriberPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_DescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x060074E0 RID: 29920 RVA: 0x00223F08 File Offset: 0x00222108
		// (set) Token: 0x060074E1 RID: 29921 RVA: 0x0003F444 File Offset: 0x0003D644
		public unsafe Sprite m_Fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_Fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x060074E2 RID: 29922 RVA: 0x00223F38 File Offset: 0x00222138
		// (set) Token: 0x060074E3 RID: 29923 RVA: 0x0003F463 File Offset: 0x0003D663
		public unsafe List<SpecialGuest> m_SpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_SpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_SpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x060074E4 RID: 29924 RVA: 0x00223F68 File Offset: 0x00222168
		// (set) Token: 0x060074E5 RID: 29925 RVA: 0x0003F482 File Offset: 0x0003D682
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_SpecialGuestGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_SpecialGuestGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.NativeFieldInfoPtr_m_SpecialGuestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeFieldInfoPtr_m_Grid;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeFieldInfoPtr_m_Prefab;

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressIndicator;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPanel;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberPanel;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeFieldInfoPtr_m_Fallback;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuests;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestGroup;

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004D6B RID: 19819
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_SpecialGuest_0;

		// Token: 0x04004D6C RID: 19820
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004D6D RID: 19821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D6E RID: 19822
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_SpecialGuest_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004D6F RID: 19823
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_SpecialGuest_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004D70 RID: 19824
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_CallbackContext_0;

		// Token: 0x02000F6E RID: 3950
		public sealed class OpenContext : ValueType
		{
			// Token: 0x0601128A RID: 70282 RVA: 0x003F5028 File Offset: 0x003F3228
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr);
				DLC5_SpecialGuestSelectionPanel.OpenContext.NativeFieldInfoPtr_Selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr, "Selections");
				DLC5_SpecialGuestSelectionPanel.OpenContext.NativeFieldInfoPtr_DefaultSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr, "DefaultSelection");
				DLC5_SpecialGuestSelectionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_SpecialGuest_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr, 100687291);
			}

			// Token: 0x0601128B RID: 70283 RVA: 0x003F5090 File Offset: 0x003F3290
			[CallerCount(272)]
			[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(IReadOnlyList<SpecialGuest> selections, SpecialGuest defaultSelection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultSelection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_SpecialGuest_SpecialGuest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601128C RID: 70284 RVA: 0x00095359 File Offset: 0x00093559
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601128D RID: 70285 RVA: 0x00095362 File Offset: 0x00093562
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17005931 RID: 22833
			// (get) Token: 0x0601128E RID: 70286 RVA: 0x003F50F4 File Offset: 0x003F32F4
			// (set) Token: 0x0601128F RID: 70287 RVA: 0x00095374 File Offset: 0x00093574
			public unsafe IReadOnlyList<SpecialGuest> Selections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.OpenContext.NativeFieldInfoPtr_Selections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.OpenContext.NativeFieldInfoPtr_Selections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005932 RID: 22834
			// (get) Token: 0x06011290 RID: 70288 RVA: 0x003F5124 File Offset: 0x003F3324
			// (set) Token: 0x06011291 RID: 70289 RVA: 0x00095393 File Offset: 0x00093593
			public unsafe SpecialGuest DefaultSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.OpenContext.NativeFieldInfoPtr_DefaultSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.OpenContext.NativeFieldInfoPtr_DefaultSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD8B RID: 44427
			private static readonly IntPtr NativeFieldInfoPtr_Selections;

			// Token: 0x0400AD8C RID: 44428
			private static readonly IntPtr NativeFieldInfoPtr_DefaultSelection;

			// Token: 0x0400AD8D RID: 44429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_SpecialGuest_SpecialGuest_0;
		}

		// Token: 0x02000F6F RID: 3951
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_SpecialGuestSelectionPanel+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x06011292 RID: 70290 RVA: 0x003F5154 File Offset: 0x003F3354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_isCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "isCurrent");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_guestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "guestData");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "colorScheme");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "pixel");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687292);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687293);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687294);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687295);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687296);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687297);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100687298);
			}

			// Token: 0x06011293 RID: 70291 RVA: 0x003F5270 File Offset: 0x003F3470
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011294 RID: 70292 RVA: 0x003F52AC File Offset: 0x003F34AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290519, XrefRangeEnd = 290525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011295 RID: 70293 RVA: 0x003F52F0 File Offset: 0x003F34F0
			[CallerCount(0)]
			public unsafe void _OnPanelInitialize_b__8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011296 RID: 70294 RVA: 0x003F5334 File Offset: 0x003F3534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290525, XrefRangeEnd = 290530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011297 RID: 70295 RVA: 0x003F5378 File Offset: 0x003F3578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290530, XrefRangeEnd = 290536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011298 RID: 70296 RVA: 0x003F53BC File Offset: 0x003F35BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290536, XrefRangeEnd = 290539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011299 RID: 70297 RVA: 0x003F5400 File Offset: 0x003F3600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290539, XrefRangeEnd = 290542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__12(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601129A RID: 70298 RVA: 0x000953B2 File Offset: 0x000935B2
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005933 RID: 22835
			// (get) Token: 0x0601129B RID: 70299 RVA: 0x003F5444 File Offset: 0x003F3644
			// (set) Token: 0x0601129C RID: 70300 RVA: 0x000953BB File Offset: 0x000935BB
			public unsafe bool isCurrent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_isCurrent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_isCurrent)) = value;
				}
			}

			// Token: 0x17005934 RID: 22836
			// (get) Token: 0x0601129D RID: 70301 RVA: 0x003F546C File Offset: 0x003F366C
			// (set) Token: 0x0601129E RID: 70302 RVA: 0x000953D6 File Offset: 0x000935D6
			public unsafe SpecialGuest guestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_guestData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_guestData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005935 RID: 22837
			// (get) Token: 0x0601129F RID: 70303 RVA: 0x003F549C File Offset: 0x003F369C
			// (set) Token: 0x060112A0 RID: 70304 RVA: 0x000953F5 File Offset: 0x000935F5
			public unsafe Il2CppStructArray<Color> colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_colorScheme);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_colorScheme), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005936 RID: 22838
			// (get) Token: 0x060112A1 RID: 70305 RVA: 0x003F54CC File Offset: 0x003F36CC
			// (set) Token: 0x060112A2 RID: 70306 RVA: 0x00095414 File Offset: 0x00093614
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005937 RID: 22839
			// (get) Token: 0x060112A3 RID: 70307 RVA: 0x003F54FC File Offset: 0x003F36FC
			// (set) Token: 0x060112A4 RID: 70308 RVA: 0x00095433 File Offset: 0x00093633
			public unsafe DLC5_SpecialGuestSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_SpecialGuestSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD8E RID: 44430
			private static readonly IntPtr NativeFieldInfoPtr_isCurrent;

			// Token: 0x0400AD8F RID: 44431
			private static readonly IntPtr NativeFieldInfoPtr_guestData;

			// Token: 0x0400AD90 RID: 44432
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x0400AD91 RID: 44433
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400AD92 RID: 44434
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD93 RID: 44435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD94 RID: 44436
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD95 RID: 44437
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD96 RID: 44438
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_Image_0;

			// Token: 0x0400AD97 RID: 44439
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_Image_0;

			// Token: 0x0400AD98 RID: 44440
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_Image_0;

			// Token: 0x0400AD99 RID: 44441
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_Image_0;
		}

		// Token: 0x02000F70 RID: 3952
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_SpecialGuestSelectionPanel+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x060112A5 RID: 70309 RVA: 0x003F552C File Offset: 0x003F372C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_guest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "guest");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "<>4__this");
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100687299);
				DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100687300);
			}

			// Token: 0x060112A6 RID: 70310 RVA: 0x003F55A8 File Offset: 0x003F37A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112A7 RID: 70311 RVA: 0x003F55E4 File Offset: 0x003F37E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290542, XrefRangeEnd = 290645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112A8 RID: 70312 RVA: 0x00095452 File Offset: 0x00093652
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005938 RID: 22840
			// (get) Token: 0x060112A9 RID: 70313 RVA: 0x003F5618 File Offset: 0x003F3818
			// (set) Token: 0x060112AA RID: 70314 RVA: 0x0009545B File Offset: 0x0009365B
			public unsafe SpecialGuest guest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_guest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_guest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005939 RID: 22841
			// (get) Token: 0x060112AB RID: 70315 RVA: 0x003F5648 File Offset: 0x003F3848
			// (set) Token: 0x060112AC RID: 70316 RVA: 0x0009547A File Offset: 0x0009367A
			public unsafe DLC5_SpecialGuestSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_SpecialGuestSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_SpecialGuestSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD9A RID: 44442
			private static readonly IntPtr NativeFieldInfoPtr_guest;

			// Token: 0x0400AD9B RID: 44443
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD9C RID: 44444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD9D RID: 44445
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_0;
		}

		// Token: 0x02000F71 RID: 3953
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_SpecialGuestSelectionPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060112AD RID: 70317 RVA: 0x003F5678 File Offset: 0x003F3878
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr);
				DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, "<>9");
				DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, "<>9__9_3");
				DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, "<>9__9_4");
				DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, "<>9__9_5");
				DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, "<>9__9_6");
				DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, 100687302);
				DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, 100687303);
				DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, 100687304);
				DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, 100687305);
				DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr, 100687306);
			}

			// Token: 0x060112AE RID: 70318 RVA: 0x003F576C File Offset: 0x003F396C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_SpecialGuestSelectionPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112AF RID: 70319 RVA: 0x003F57A8 File Offset: 0x003F39A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9_3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112B0 RID: 70320 RVA: 0x003F57EC File Offset: 0x003F39EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9_4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112B1 RID: 70321 RVA: 0x003F5830 File Offset: 0x003F3A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9_5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112B2 RID: 70322 RVA: 0x003F5874 File Offset: 0x003F3A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9_6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_SpecialGuestSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112B3 RID: 70323 RVA: 0x00095499 File Offset: 0x00093699
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700593A RID: 22842
			// (get) Token: 0x060112B4 RID: 70324 RVA: 0x003F58B8 File Offset: 0x003F3AB8
			// (set) Token: 0x060112B5 RID: 70325 RVA: 0x000954A2 File Offset: 0x000936A2
			public unsafe static DLC5_SpecialGuestSelectionPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_SpecialGuestSelectionPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700593B RID: 22843
			// (get) Token: 0x060112B6 RID: 70326 RVA: 0x003F58E0 File Offset: 0x003F3AE0
			// (set) Token: 0x060112B7 RID: 70327 RVA: 0x000954B4 File Offset: 0x000936B4
			public unsafe static Action<Image> __9__9_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700593C RID: 22844
			// (get) Token: 0x060112B8 RID: 70328 RVA: 0x003F5908 File Offset: 0x003F3B08
			// (set) Token: 0x060112B9 RID: 70329 RVA: 0x000954C6 File Offset: 0x000936C6
			public unsafe static Action<Image> __9__9_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700593D RID: 22845
			// (get) Token: 0x060112BA RID: 70330 RVA: 0x003F5930 File Offset: 0x003F3B30
			// (set) Token: 0x060112BB RID: 70331 RVA: 0x000954D8 File Offset: 0x000936D8
			public unsafe static Action<Image> __9__9_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700593E RID: 22846
			// (get) Token: 0x060112BC RID: 70332 RVA: 0x003F5958 File Offset: 0x003F3B58
			// (set) Token: 0x060112BD RID: 70333 RVA: 0x000954EA File Offset: 0x000936EA
			public unsafe static Action<Image> __9__9_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_SpecialGuestSelectionPanel.__c.NativeFieldInfoPtr___9__9_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD9E RID: 44446
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AD9F RID: 44447
			private static readonly IntPtr NativeFieldInfoPtr___9__9_3;

			// Token: 0x0400ADA0 RID: 44448
			private static readonly IntPtr NativeFieldInfoPtr___9__9_4;

			// Token: 0x0400ADA1 RID: 44449
			private static readonly IntPtr NativeFieldInfoPtr___9__9_5;

			// Token: 0x0400ADA2 RID: 44450
			private static readonly IntPtr NativeFieldInfoPtr___9__9_6;

			// Token: 0x0400ADA3 RID: 44451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADA4 RID: 44452
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Internal_Void_Image_0;

			// Token: 0x0400ADA5 RID: 44453
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_4_Internal_Void_Image_0;

			// Token: 0x0400ADA6 RID: 44454
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_5_Internal_Void_Image_0;

			// Token: 0x0400ADA7 RID: 44455
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_6_Internal_Void_Image_0;
		}
	}
}
