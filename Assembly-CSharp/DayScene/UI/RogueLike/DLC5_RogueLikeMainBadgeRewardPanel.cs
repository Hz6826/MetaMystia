using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000112 RID: 274
	public class DLC5_RogueLikeMainBadgeRewardPanel : UIPanelParamOpen<RogueLikeAchievementRunTimeData>
	{
		// Token: 0x06001DDC RID: 7644 RVA: 0x001027AC File Offset: 0x001009AC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeMainBadgeRewardPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeMainBadgeRewardPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeViewerGridContent");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeElement");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeImage");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeDescriberCanvasGroup");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeNameText");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeDescriptionText");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeCollectRateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeCollectRateText");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_BadgeScroller");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_ClaimButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_ClaimButton");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_GetBadgeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_GetBadgeList");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_RemainingBadges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_RemainingBadges");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_RemainingBadgesType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_RemainingBadgesType");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_AchievementGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "m_AchievementGroup");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_shadowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "shadowColor");
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668627);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeAchievementRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668628);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_SortBadgeList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668629);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_UpdateRemainingBadge_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668630);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668631);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668632);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668633);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668634);
			DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, 100668635);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x001029BC File Offset: 0x00100BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74560, XrefRangeEnd = 74613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x001029F8 File Offset: 0x00100BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74613, XrefRangeEnd = 74630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(RogueLikeAchievementRunTimeData openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeAchievementRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00102A48 File Offset: 0x00100C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74652, RefRangeEnd = 74654, XrefRangeStart = 74630, XrefRangeEnd = 74652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortBadgeList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_SortBadgeList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00102A7C File Offset: 0x00100C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74689, RefRangeEnd = 74691, XrefRangeStart = 74654, XrefRangeEnd = 74689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRemainingBadge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_UpdateRemainingBadge_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00102AB0 File Offset: 0x00100CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74691, XrefRangeEnd = 74710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00102AEC File Offset: 0x00100CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74710, XrefRangeEnd = 74735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeMainBadgeRewardPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00102B28 File Offset: 0x00100D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74735, XrefRangeEnd = 74766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_0(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00102B8C File Offset: 0x00100D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74766, XrefRangeEnd = 74780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_1(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00102BF0 File Offset: 0x00100DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74780, XrefRangeEnd = 74804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0001201E File Offset: 0x0001021E
		public DLC5_RogueLikeMainBadgeRewardPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00102C24 File Offset: 0x00100E24
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00012027 File Offset: 0x00010227
		public unsafe GridLayoutGroup m_BadgeViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00102C54 File Offset: 0x00100E54
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00012046 File Offset: 0x00010246
		public unsafe GameObject m_BadgeElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00102C84 File Offset: 0x00100E84
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00012065 File Offset: 0x00010265
		public unsafe Image m_BadgeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00102CB4 File Offset: 0x00100EB4
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00012084 File Offset: 0x00010284
		public unsafe CanvasGroup m_BadgeDescriberCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00102CE4 File Offset: 0x00100EE4
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x000120A3 File Offset: 0x000102A3
		public unsafe TextMeshProUGUI m_BadgeNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00102D14 File Offset: 0x00100F14
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x000120C2 File Offset: 0x000102C2
		public unsafe TextMeshProUGUI m_BadgeDescriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeDescriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeDescriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00102D44 File Offset: 0x00100F44
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x000120E1 File Offset: 0x000102E1
		public unsafe TextMeshProUGUI m_BadgeCollectRateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeCollectRateText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeCollectRateText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00102D74 File Offset: 0x00100F74
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x00012100 File Offset: 0x00010300
		public unsafe AdpProgressIndicatorComponent m_BadgeScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_BadgeScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00102DA4 File Offset: 0x00100FA4
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0001211F File Offset: 0x0001031F
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00102DD4 File Offset: 0x00100FD4
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0001213E File Offset: 0x0001033E
		public unsafe UIButtonSimple m_ClaimButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_ClaimButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_ClaimButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00102E04 File Offset: 0x00101004
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0001215D File Offset: 0x0001035D
		public unsafe List<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_GetBadgeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_GetBadgeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_GetBadgeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00102E34 File Offset: 0x00101034
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0001217C File Offset: 0x0001037C
		public unsafe List<DLC5_RogueLikeDataProfile.RogueLikeAchievement> m_RemainingBadges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_RemainingBadges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_RemainingBadges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00102E64 File Offset: 0x00101064
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0001219B File Offset: 0x0001039B
		public unsafe HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_RemainingBadgesType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_RemainingBadgesType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_RemainingBadgesType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00102E94 File Offset: 0x00101094
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x000121BA File Offset: 0x000103BA
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, UIElementCluster, UIButtonSimple> m_AchievementGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_AchievementGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_m_AchievementGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00102EC4 File Offset: 0x001010C4
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x000121D9 File Offset: 0x000103D9
		public unsafe Color shadowColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_shadowColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.NativeFieldInfoPtr_shadowColor)) = value;
			}
		}

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeViewerGridContent;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeElement;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeImage;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeNameText;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeDescriptionText;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeCollectRateText;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeScroller;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeFieldInfoPtr_m_ClaimButton;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeFieldInfoPtr_m_GetBadgeList;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingBadges;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingBadgesType;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeFieldInfoPtr_m_AchievementGroup;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeFieldInfoPtr_shadowColor;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeAchievementRunTimeData_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_SortBadgeList_Private_Void_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRemainingBadge_Private_Void_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_2_Private_Void_0;

		// Token: 0x020006E5 RID: 1765
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMainBadgeRewardPanel+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x06009AA3 RID: 39587 RVA: 0x002923B4 File Offset: 0x002905B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr);
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, "sprite");
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_getBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, "getBadge");
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_achievementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, "achievementType");
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, 100668636);
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, 100668637);
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, 100668638);
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr, 100668639);
			}

			// Token: 0x06009AA4 RID: 39588 RVA: 0x00292480 File Offset: 0x00290680
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AA5 RID: 39589 RVA: 0x002924BC File Offset: 0x002906BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74540, XrefRangeEnd = 74542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AA6 RID: 39590 RVA: 0x00292500 File Offset: 0x00290700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74542, XrefRangeEnd = 74544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AA7 RID: 39591 RVA: 0x00292544 File Offset: 0x00290744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74544, XrefRangeEnd = 74550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AA8 RID: 39592 RVA: 0x00053AF9 File Offset: 0x00051CF9
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700335A RID: 13146
			// (get) Token: 0x06009AA9 RID: 39593 RVA: 0x00292588 File Offset: 0x00290788
			// (set) Token: 0x06009AAA RID: 39594 RVA: 0x00053B02 File Offset: 0x00051D02
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700335B RID: 13147
			// (get) Token: 0x06009AAB RID: 39595 RVA: 0x002925B8 File Offset: 0x002907B8
			// (set) Token: 0x06009AAC RID: 39596 RVA: 0x00053B21 File Offset: 0x00051D21
			public unsafe bool getBadge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_getBadge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_getBadge)) = value;
				}
			}

			// Token: 0x1700335C RID: 13148
			// (get) Token: 0x06009AAD RID: 39597 RVA: 0x002925E0 File Offset: 0x002907E0
			// (set) Token: 0x06009AAE RID: 39598 RVA: 0x00053B3C File Offset: 0x00051D3C
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_achievementType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr_achievementType)) = value;
				}
			}

			// Token: 0x1700335D RID: 13149
			// (get) Token: 0x06009AAF RID: 39599 RVA: 0x00292608 File Offset: 0x00290808
			// (set) Token: 0x06009AB0 RID: 39600 RVA: 0x00053B57 File Offset: 0x00051D57
			public unsafe DLC5_RogueLikeMainBadgeRewardPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainBadgeRewardPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400648D RID: 25741
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400648E RID: 25742
			private static readonly IntPtr NativeFieldInfoPtr_getBadge;

			// Token: 0x0400648F RID: 25743
			private static readonly IntPtr NativeFieldInfoPtr_achievementType;

			// Token: 0x04006490 RID: 25744
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006491 RID: 25745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006492 RID: 25746
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_Image_0;

			// Token: 0x04006493 RID: 25747
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0;

			// Token: 0x04006494 RID: 25748
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_Image_0;
		}

		// Token: 0x020006E6 RID: 1766
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMainBadgeRewardPanel+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : Il2CppSystem.Object
		{
			// Token: 0x06009AB1 RID: 39601 RVA: 0x00292638 File Offset: 0x00290838
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr);
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeFieldInfoPtr_achievementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr, "achievementType");
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr, 100668640);
				DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr, 100668641);
			}

			// Token: 0x06009AB2 RID: 39602 RVA: 0x002926B4 File Offset: 0x002908B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AB3 RID: 39603 RVA: 0x002926F0 File Offset: 0x002908F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74550, XrefRangeEnd = 74559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AB4 RID: 39604 RVA: 0x00053B76 File Offset: 0x00051D76
			public __c__DisplayClass15_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700335E RID: 13150
			// (get) Token: 0x06009AB5 RID: 39605 RVA: 0x00292724 File Offset: 0x00290924
			// (set) Token: 0x06009AB6 RID: 39606 RVA: 0x00053B7F File Offset: 0x00051D7F
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeFieldInfoPtr_achievementType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeFieldInfoPtr_achievementType)) = value;
				}
			}

			// Token: 0x1700335F RID: 13151
			// (get) Token: 0x06009AB7 RID: 39607 RVA: 0x0029274C File Offset: 0x0029094C
			// (set) Token: 0x06009AB8 RID: 39608 RVA: 0x00053B9A File Offset: 0x00051D9A
			public unsafe DLC5_RogueLikeMainBadgeRewardPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainBadgeRewardPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainBadgeRewardPanel.__c__DisplayClass15_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006495 RID: 25749
			private static readonly IntPtr NativeFieldInfoPtr_achievementType;

			// Token: 0x04006496 RID: 25750
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006497 RID: 25751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006498 RID: 25752
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_0;
		}

		// Token: 0x020006E7 RID: 1767
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMainBadgeRewardPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009AB9 RID: 39609 RVA: 0x0029277C File Offset: 0x0029097C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr);
				DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9__15_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr, "<>9__15_7");
				DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr, "<>9__18_0");
				DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr, 100668643);
				DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Internal_Void_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr, 100668644);
				DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeMethodInfoPtr__UpdateRemainingBadge_b__18_0_Internal_RogueLikeAchievementType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr, 100668645);
			}

			// Token: 0x06009ABA RID: 39610 RVA: 0x00292820 File Offset: 0x00290A20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainBadgeRewardPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ABB RID: 39611 RVA: 0x0029285C File Offset: 0x00290A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74559, XrefRangeEnd = 74560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_7(DLC5_RogueLikeDataProfile.RogueLikeAchievement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Internal_Void_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ABC RID: 39612 RVA: 0x002928A4 File Offset: 0x00290AA4
			[CallerCount(0)]
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementType _UpdateRemainingBadge_b__18_0(DLC5_RogueLikeDataProfile.RogueLikeAchievement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeMethodInfoPtr__UpdateRemainingBadge_b__18_0_Internal_RogueLikeAchievementType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009ABD RID: 39613 RVA: 0x00053BB9 File Offset: 0x00051DB9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003360 RID: 13152
			// (get) Token: 0x06009ABE RID: 39614 RVA: 0x002928F8 File Offset: 0x00290AF8
			// (set) Token: 0x06009ABF RID: 39615 RVA: 0x00053BC2 File Offset: 0x00051DC2
			public unsafe static DLC5_RogueLikeMainBadgeRewardPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainBadgeRewardPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003361 RID: 13153
			// (get) Token: 0x06009AC0 RID: 39616 RVA: 0x00292920 File Offset: 0x00290B20
			// (set) Token: 0x06009AC1 RID: 39617 RVA: 0x00053BD4 File Offset: 0x00051DD4
			public unsafe static Action<DLC5_RogueLikeDataProfile.RogueLikeAchievement> __9__15_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9__15_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9__15_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003362 RID: 13154
			// (get) Token: 0x06009AC2 RID: 39618 RVA: 0x00292948 File Offset: 0x00290B48
			// (set) Token: 0x06009AC3 RID: 39619 RVA: 0x00053BE6 File Offset: 0x00051DE6
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievementType> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMainBadgeRewardPanel.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006499 RID: 25753
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400649A RID: 25754
			private static readonly IntPtr NativeFieldInfoPtr___9__15_7;

			// Token: 0x0400649B RID: 25755
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400649C RID: 25756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400649D RID: 25757
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Internal_Void_RogueLikeAchievement_0;

			// Token: 0x0400649E RID: 25758
			private static readonly IntPtr NativeMethodInfoPtr__UpdateRemainingBadge_b__18_0_Internal_RogueLikeAchievementType_RogueLikeAchievement_0;
		}
	}
}
