using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x0200039F RID: 927
	public class NoteBookProfileBadgeSubPannel : UIPanelExtern
	{
		// Token: 0x06006FE6 RID: 28646 RVA: 0x00212EA8 File Offset: 0x002110A8
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookProfileBadgeSubPannel()
		{
			Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookProfileBadgeSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr);
			NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_badgeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, "badgeElement");
			NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_badgesContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, "badgesContent");
			NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, "selected");
			NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_progressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, "progressIndicator");
			NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_m_LogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, "m_LogicalGroup");
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686147);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686148);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686149);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686150);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnBadgeElementEnabled_Private_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686151);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnSelect_Private_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686152);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_UpdateBadgeElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686153);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686154);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686155);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686156);
			NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr, 100686157);
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x06006FE7 RID: 28647 RVA: 0x00213018 File Offset: 0x00211218
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x00213060 File Offset: 0x00211260
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x0021309C File Offset: 0x0021129C
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x002130E4 File Offset: 0x002112E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279848, XrefRangeEnd = 279868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x00213120 File Offset: 0x00211320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279868, XrefRangeEnd = 279903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBadgeElementEnabled(int id, UIElementCluster component, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnBadgeElementEnabled_Private_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x00213184 File Offset: 0x00211384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279903, XrefRangeEnd = 279904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelect(int id, UIElementCluster component, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnSelect_Private_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x002131E8 File Offset: 0x002113E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279904, XrefRangeEnd = 279912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBadgeElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_UpdateBadgeElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x0021321C File Offset: 0x0021141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279912, XrefRangeEnd = 279928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00213258 File Offset: 0x00211458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279928, XrefRangeEnd = 279933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00213294 File Offset: 0x00211494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x002132D0 File Offset: 0x002114D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookProfileBadgeSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileBadgeSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileBadgeSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x0003CC6A File Offset: 0x0003AE6A
		public NoteBookProfileBadgeSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x0021330C File Offset: 0x0021150C
		// (set) Token: 0x06006FF4 RID: 28660 RVA: 0x0003CC73 File Offset: 0x0003AE73
		public unsafe GameObject badgeElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_badgeElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_badgeElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x0021333C File Offset: 0x0021153C
		// (set) Token: 0x06006FF6 RID: 28662 RVA: 0x0003CC92 File Offset: 0x0003AE92
		public unsafe VerticalLayoutGroup badgesContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_badgesContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_badgesContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x0021336C File Offset: 0x0021156C
		// (set) Token: 0x06006FF8 RID: 28664 RVA: 0x0003CCB1 File Offset: 0x0003AEB1
		public unsafe CanvasGroup selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x0021339C File Offset: 0x0021159C
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		public unsafe AdpProgressIndicatorComponent progressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_progressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_progressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x06006FFB RID: 28667 RVA: 0x002133CC File Offset: 0x002115CC
		// (set) Token: 0x06006FFC RID: 28668 RVA: 0x0003CCEF File Offset: 0x0003AEEF
		public unsafe StaticVirtualScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_LogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_m_LogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileBadgeSubPannel.NativeFieldInfoPtr_m_LogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A1B RID: 18971
		private static readonly IntPtr NativeFieldInfoPtr_badgeElement;

		// Token: 0x04004A1C RID: 18972
		private static readonly IntPtr NativeFieldInfoPtr_badgesContent;

		// Token: 0x04004A1D RID: 18973
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04004A1E RID: 18974
		private static readonly IntPtr NativeFieldInfoPtr_progressIndicator;

		// Token: 0x04004A1F RID: 18975
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroup;

		// Token: 0x04004A20 RID: 18976
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004A21 RID: 18977
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04004A22 RID: 18978
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004A23 RID: 18979
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004A24 RID: 18980
		private static readonly IntPtr NativeMethodInfoPtr_OnBadgeElementEnabled_Private_Void_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004A25 RID: 18981
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Private_Void_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004A26 RID: 18982
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBadgeElements_Private_Void_0;

		// Token: 0x04004A27 RID: 18983
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004A28 RID: 18984
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004A29 RID: 18985
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004A2A RID: 18986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
