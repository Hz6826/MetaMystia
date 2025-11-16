using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000371 RID: 881
	public class DLC4_DayScene_TrophyPannel : UIPanel
	{
		// Token: 0x06006896 RID: 26774 RVA: 0x001FB950 File Offset: 0x001F9B50
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_DayScene_TrophyPannel()
		{
			Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DLC4_DayScene_TrophyPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr);
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_HIDE_TROPHY_TIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "HIDE_TROPHY_TIP");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "itemElement");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemDescrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "itemDescrier");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "itemPannel");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "scroller");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_VisualObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "m_VisualObject");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_DescriptionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "m_DescriptionTitle");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_DescriptionDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "m_DescriptionDetail");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_TrophyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "m_TrophyList");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_TrophyGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "m_TrophyGroup");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_myTrophies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "myTrophies");
			DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_shadowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "shadowColor");
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685069);
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685070);
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_Trophy_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685071);
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_Trophy_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685072);
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685073);
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685074);
			DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, 100685075);
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x001FBAFC File Offset: 0x001F9CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x001FBB38 File Offset: 0x001F9D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267859, XrefRangeEnd = 267949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x001FBB74 File Offset: 0x001F9D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267949, XrefRangeEnd = 267963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(TrophiesProfile.Trophy trophyInfo, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trophyInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_Trophy_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x001FBBDC File Offset: 0x001F9DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267963, XrefRangeEnd = 267982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected(TrophiesProfile.Trophy trophyInfo, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trophyInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_Trophy_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x001FBC44 File Offset: 0x001F9E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267982, XrefRangeEnd = 267987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x001FBC80 File Offset: 0x001F9E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267987, XrefRangeEnd = 268000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x001FBCBC File Offset: 0x001F9EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268000, XrefRangeEnd = 268009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_DayScene_TrophyPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x0003885E File Offset: 0x00036A5E
		public DLC4_DayScene_TrophyPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x001FBCF8 File Offset: 0x001F9EF8
		// (set) Token: 0x060068A0 RID: 26784 RVA: 0x00038867 File Offset: 0x00036A67
		public unsafe static string HIDE_TROPHY_TIP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_HIDE_TROPHY_TIP, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_HIDE_TROPHY_TIP, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x001FBD18 File Offset: 0x001F9F18
		// (set) Token: 0x060068A2 RID: 26786 RVA: 0x00038879 File Offset: 0x00036A79
		public unsafe GameObject itemElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x001FBD48 File Offset: 0x001F9F48
		// (set) Token: 0x060068A4 RID: 26788 RVA: 0x00038898 File Offset: 0x00036A98
		public unsafe ObjectLanguageBaseDescriber itemDescrier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemDescrier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBaseDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemDescrier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x001FBD78 File Offset: 0x001F9F78
		// (set) Token: 0x060068A6 RID: 26790 RVA: 0x000388B7 File Offset: 0x00036AB7
		public unsafe GridLayoutGroup itemPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_itemPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x060068A7 RID: 26791 RVA: 0x001FBDA8 File Offset: 0x001F9FA8
		// (set) Token: 0x060068A8 RID: 26792 RVA: 0x000388D6 File Offset: 0x00036AD6
		public unsafe AdpProgressIndicatorComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x001FBDD8 File Offset: 0x001F9FD8
		// (set) Token: 0x060068AA RID: 26794 RVA: 0x000388F5 File Offset: 0x00036AF5
		public unsafe GameObject m_VisualObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_VisualObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_VisualObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x001FBE08 File Offset: 0x001FA008
		// (set) Token: 0x060068AC RID: 26796 RVA: 0x00038914 File Offset: 0x00036B14
		public unsafe TextMeshProUGUI m_DescriptionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_DescriptionTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_DescriptionTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x001FBE38 File Offset: 0x001FA038
		// (set) Token: 0x060068AE RID: 26798 RVA: 0x00038933 File Offset: 0x00036B33
		public unsafe TextMeshProUGUI m_DescriptionDetail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_DescriptionDetail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_DescriptionDetail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x060068AF RID: 26799 RVA: 0x001FBE68 File Offset: 0x001FA068
		// (set) Token: 0x060068B0 RID: 26800 RVA: 0x00038952 File Offset: 0x00036B52
		public unsafe List<TrophiesProfile.Trophy> m_TrophyList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_TrophyList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrophiesProfile.Trophy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_TrophyList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x060068B1 RID: 26801 RVA: 0x001FBE98 File Offset: 0x001FA098
		// (set) Token: 0x060068B2 RID: 26802 RVA: 0x00038971 File Offset: 0x00036B71
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<TrophiesProfile.Trophy, UIElementCluster, UIButtonSimple> m_TrophyGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_TrophyGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<TrophiesProfile.Trophy, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_m_TrophyGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x060068B3 RID: 26803 RVA: 0x001FBEC8 File Offset: 0x001FA0C8
		// (set) Token: 0x060068B4 RID: 26804 RVA: 0x00038990 File Offset: 0x00036B90
		public unsafe HashSet<int> myTrophies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_myTrophies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_myTrophies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x060068B5 RID: 26805 RVA: 0x001FBEF8 File Offset: 0x001FA0F8
		// (set) Token: 0x060068B6 RID: 26806 RVA: 0x000389AF File Offset: 0x00036BAF
		public unsafe Color shadowColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_shadowColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.NativeFieldInfoPtr_shadowColor)) = value;
			}
		}

		// Token: 0x0400455A RID: 17754
		private static readonly IntPtr NativeFieldInfoPtr_HIDE_TROPHY_TIP;

		// Token: 0x0400455B RID: 17755
		private static readonly IntPtr NativeFieldInfoPtr_itemElement;

		// Token: 0x0400455C RID: 17756
		private static readonly IntPtr NativeFieldInfoPtr_itemDescrier;

		// Token: 0x0400455D RID: 17757
		private static readonly IntPtr NativeFieldInfoPtr_itemPannel;

		// Token: 0x0400455E RID: 17758
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x0400455F RID: 17759
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualObject;

		// Token: 0x04004560 RID: 17760
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriptionTitle;

		// Token: 0x04004561 RID: 17761
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriptionDetail;

		// Token: 0x04004562 RID: 17762
		private static readonly IntPtr NativeFieldInfoPtr_m_TrophyList;

		// Token: 0x04004563 RID: 17763
		private static readonly IntPtr NativeFieldInfoPtr_m_TrophyGroup;

		// Token: 0x04004564 RID: 17764
		private static readonly IntPtr NativeFieldInfoPtr_myTrophies;

		// Token: 0x04004565 RID: 17765
		private static readonly IntPtr NativeFieldInfoPtr_shadowColor;

		// Token: 0x04004566 RID: 17766
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004567 RID: 17767
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004568 RID: 17768
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_Trophy_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004569 RID: 17769
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_Trophy_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400456A RID: 17770
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400456B RID: 17771
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400456C RID: 17772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E7D RID: 3709
		[ObfuscatedName("Common.UI.DLC4_DayScene_TrophyPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010787 RID: 67463 RVA: 0x003D25C4 File Offset: 0x003D07C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr);
				DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr, "<>9");
				DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr, "<>9__13_0");
				DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr, "<>9__13_1");
				DLC4_DayScene_TrophyPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr, 100685077);
				DLC4_DayScene_TrophyPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_0_Internal_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr, 100685078);
				DLC4_DayScene_TrophyPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_1_Internal_Trophy_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr, 100685079);
			}

			// Token: 0x06010788 RID: 67464 RVA: 0x003D2668 File Offset: 0x003D0868
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010789 RID: 67465 RVA: 0x003D26A4 File Offset: 0x003D08A4
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__13_0(TrophiesProfile.Trophy x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_0_Internal_Int32_Trophy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601078A RID: 67466 RVA: 0x003D26F4 File Offset: 0x003D08F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrophiesProfile.Trophy _OnPanelOpen_b__13_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_1_Internal_Trophy_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrophiesProfile.Trophy>(intPtr3) : null;
			}

			// Token: 0x0601078B RID: 67467 RVA: 0x0008FB81 File Offset: 0x0008DD81
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005601 RID: 22017
			// (get) Token: 0x0601078C RID: 67468 RVA: 0x003D2740 File Offset: 0x003D0940
			// (set) Token: 0x0601078D RID: 67469 RVA: 0x0008FB8A File Offset: 0x0008DD8A
			public unsafe static DLC4_DayScene_TrophyPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DayScene_TrophyPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005602 RID: 22018
			// (get) Token: 0x0601078E RID: 67470 RVA: 0x003D2768 File Offset: 0x003D0968
			// (set) Token: 0x0601078F RID: 67471 RVA: 0x0008FB9C File Offset: 0x0008DD9C
			public unsafe static Func<TrophiesProfile.Trophy, int> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrophiesProfile.Trophy, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005603 RID: 22019
			// (get) Token: 0x06010790 RID: 67472 RVA: 0x003D2790 File Offset: 0x003D0990
			// (set) Token: 0x06010791 RID: 67473 RVA: 0x0008FBAE File Offset: 0x0008DDAE
			public unsafe static Func<int, TrophiesProfile.Trophy> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, TrophiesProfile.Trophy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_DayScene_TrophyPannel.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6C7 RID: 42695
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6C8 RID: 42696
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400A6C9 RID: 42697
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x0400A6CA RID: 42698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6CB RID: 42699
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_0_Internal_Int32_Trophy_0;

			// Token: 0x0400A6CC RID: 42700
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_1_Internal_Trophy_Int32_0;
		}

		// Token: 0x02000E7E RID: 3710
		[ObfuscatedName("Common.UI.DLC4_DayScene_TrophyPannel+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x06010792 RID: 67474 RVA: 0x003D27B8 File Offset: 0x003D09B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr);
				DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_trophyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr, "trophyInfo");
				DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr, 100685080);
				DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr, 100685081);
			}

			// Token: 0x06010793 RID: 67475 RVA: 0x003D2834 File Offset: 0x003D0A34
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010794 RID: 67476 RVA: 0x003D2870 File Offset: 0x003D0A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267853, XrefRangeEnd = 267859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010795 RID: 67477 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005604 RID: 22020
			// (get) Token: 0x06010796 RID: 67478 RVA: 0x003D28B4 File Offset: 0x003D0AB4
			// (set) Token: 0x06010797 RID: 67479 RVA: 0x0008FBC9 File Offset: 0x0008DDC9
			public unsafe TrophiesProfile.Trophy trophyInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_trophyInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrophiesProfile.Trophy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_trophyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005605 RID: 22021
			// (get) Token: 0x06010798 RID: 67480 RVA: 0x003D28E4 File Offset: 0x003D0AE4
			// (set) Token: 0x06010799 RID: 67481 RVA: 0x0008FBE8 File Offset: 0x0008DDE8
			public unsafe DLC4_DayScene_TrophyPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DayScene_TrophyPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DayScene_TrophyPannel.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6CD RID: 42701
			private static readonly IntPtr NativeFieldInfoPtr_trophyInfo;

			// Token: 0x0400A6CE RID: 42702
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6CF RID: 42703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6D0 RID: 42704
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;
		}
	}
}
