using System;
using DEYU.AdpUISystem.LogicalCollection;
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

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200010E RID: 270
	public class DLC5_RogueLikeEliteRewardSelectionPanel : UIPanelParam<RogueLikeRunTimeData, RogueLikeRunTimeData.EliteChallengeBase.EliteReward>
	{
		// Token: 0x06001D80 RID: 7552 RVA: 0x0010151C File Offset: 0x000FF71C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteRewardSelectionPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeEliteRewardSelectionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteTitleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_EliteTitleName");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_EliteReward");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteRewardRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_EliteRewardRectTransform");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_PoolButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_PoolButton");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_ExtraMenuSubPanelForRewardSelector");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelectorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_ExtraMenuSubPanelForRewardSelectorOffset");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_RewardInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_RewardInstance");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_UILogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "m_UILogicalGroup");
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668580);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668581);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668582);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668583);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__8_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668584);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__8_2_Private_Void_DLC5_RogueLikeExtraMenuSubPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668585);
			DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__8_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, 100668586);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00101678 File Offset: 0x000FF878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74111, XrefRangeEnd = 74137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x001016B4 File Offset: 0x000FF8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74137, XrefRangeEnd = 74196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(RogueLikeRunTimeData openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00101704 File Offset: 0x000FF904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74196, XrefRangeEnd = 74206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00101740 File Offset: 0x000FF940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74206, XrefRangeEnd = 74217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteRewardSelectionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0010177C File Offset: 0x000FF97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74217, XrefRangeEnd = 74225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__8_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__8_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x001017B0 File Offset: 0x000FF9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74225, XrefRangeEnd = 74235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__8_2(DLC5_RogueLikeExtraMenuSubPanel x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__8_2_Private_Void_DLC5_RogueLikeExtraMenuSubPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x001017F4 File Offset: 0x000FF9F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74237, RefRangeEnd = 74239, XrefRangeStart = 74235, XrefRangeEnd = 74237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__8_1(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__8_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00011D4E File Offset: 0x0000FF4E
		public DLC5_RogueLikeEliteRewardSelectionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0010183C File Offset: 0x000FFA3C
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00011D57 File Offset: 0x0000FF57
		public unsafe TextMeshProUGUI m_EliteTitleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteTitleName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteTitleName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0010186C File Offset: 0x000FFA6C
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00011D76 File Offset: 0x0000FF76
		public unsafe GameObject m_EliteReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0010189C File Offset: 0x000FFA9C
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00011D95 File Offset: 0x0000FF95
		public unsafe RectTransform m_EliteRewardRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteRewardRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_EliteRewardRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x001018CC File Offset: 0x000FFACC
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		public unsafe UIButtonSimple m_PoolButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_PoolButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_PoolButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x001018FC File Offset: 0x000FFAFC
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00011DD3 File Offset: 0x0000FFD3
		public unsafe DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForRewardSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeExtraMenuSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0010192C File Offset: 0x000FFB2C
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00011DF2 File Offset: 0x0000FFF2
		public unsafe int m_ExtraMenuSubPanelForRewardSelectorOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelectorOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelectorOffset)) = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00101954 File Offset: 0x000FFB54
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00011E0D File Offset: 0x0001000D
		public unsafe List<GameObject> m_RewardInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_RewardInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_RewardInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00101984 File Offset: 0x000FFB84
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x00011E2C File Offset: 0x0001002C
		public unsafe UILogicalGroupT<RogueLikeRunTimeData.EliteChallengeBase.EliteRewardType> m_UILogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_UILogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<RogueLikeRunTimeData.EliteChallengeBase.EliteRewardType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.NativeFieldInfoPtr_m_UILogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteTitleName;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteReward;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteRewardRectTransform;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeFieldInfoPtr_m_PoolButton;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelector;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraMenuSubPanelForRewardSelectorOffset;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeFieldInfoPtr_m_RewardInstance;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeFieldInfoPtr_m_UILogicalGroup;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_0_Private_Void_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_2_Private_Void_DLC5_RogueLikeExtraMenuSubPanel_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_1_Private_Void_CallbackContext_0;

		// Token: 0x020006E1 RID: 1761
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteRewardSelectionPanel+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x06009A82 RID: 39554 RVA: 0x00291DFC File Offset: 0x0028FFFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_openParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "openParam");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100668587);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100668588);
			}

			// Token: 0x06009A83 RID: 39555 RVA: 0x00291E78 File Offset: 0x00290078
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A84 RID: 39556 RVA: 0x00291EB4 File Offset: 0x002900B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74062, XrefRangeEnd = 74096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0(UIElementCluster cluster, ValueTuple<RogueLikeRunTimeData.EliteChallengeBase.EliteReward, bool> eliteRewardPair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eliteRewardPair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A85 RID: 39557 RVA: 0x000539AA File Offset: 0x00051BAA
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003351 RID: 13137
			// (get) Token: 0x06009A86 RID: 39558 RVA: 0x00291F10 File Offset: 0x00290110
			// (set) Token: 0x06009A87 RID: 39559 RVA: 0x000539B3 File Offset: 0x00051BB3
			public unsafe RogueLikeRunTimeData openParam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_openParam);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_openParam), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003352 RID: 13138
			// (get) Token: 0x06009A88 RID: 39560 RVA: 0x00291F40 File Offset: 0x00290140
			// (set) Token: 0x06009A89 RID: 39561 RVA: 0x000539D2 File Offset: 0x00051BD2
			public unsafe DLC5_RogueLikeEliteRewardSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteRewardSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006478 RID: 25720
			private static readonly IntPtr NativeFieldInfoPtr_openParam;

			// Token: 0x04006479 RID: 25721
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400647A RID: 25722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400647B RID: 25723
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0;
		}

		// Token: 0x020006E2 RID: 1762
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteRewardSelectionPanel+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x06009A8A RID: 39562 RVA: 0x00291F70 File Offset: 0x00290170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_eliteReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "eliteReward");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_isNotLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "isNotLast");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_buttonHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "buttonHold");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "<>9__4");
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100668589);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100668590);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100668591);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_UIButtonHold_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100668592);
				DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100668593);
			}

			// Token: 0x06009A8B RID: 39563 RVA: 0x00292064 File Offset: 0x00290264
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A8C RID: 39564 RVA: 0x002920A0 File Offset: 0x002902A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74096, XrefRangeEnd = 74098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A8D RID: 39565 RVA: 0x002920E4 File Offset: 0x002902E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A8E RID: 39566 RVA: 0x00292128 File Offset: 0x00290328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74098, XrefRangeEnd = 74108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3(UIButtonHold x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_UIButtonHold_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A8F RID: 39567 RVA: 0x0029216C File Offset: 0x0029036C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74108, XrefRangeEnd = 74111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A90 RID: 39568 RVA: 0x000539F1 File Offset: 0x00051BF1
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003353 RID: 13139
			// (get) Token: 0x06009A91 RID: 39569 RVA: 0x002921A0 File Offset: 0x002903A0
			// (set) Token: 0x06009A92 RID: 39570 RVA: 0x000539FA File Offset: 0x00051BFA
			public RogueLikeRunTimeData.EliteChallengeBase.EliteReward eliteReward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_eliteReward);
					return new RogueLikeRunTimeData.EliteChallengeBase.EliteReward(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeRunTimeData.EliteChallengeBase.EliteReward>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_eliteReward), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeRunTimeData.EliteChallengeBase.EliteReward>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003354 RID: 13140
			// (get) Token: 0x06009A93 RID: 39571 RVA: 0x002921D0 File Offset: 0x002903D0
			// (set) Token: 0x06009A94 RID: 39572 RVA: 0x00053A28 File Offset: 0x00051C28
			public unsafe bool isNotLast
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_isNotLast);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_isNotLast)) = value;
				}
			}

			// Token: 0x17003355 RID: 13141
			// (get) Token: 0x06009A95 RID: 39573 RVA: 0x002921F8 File Offset: 0x002903F8
			// (set) Token: 0x06009A96 RID: 39574 RVA: 0x00053A43 File Offset: 0x00051C43
			public unsafe UIButtonHold buttonHold
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_buttonHold);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_buttonHold), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003356 RID: 13142
			// (get) Token: 0x06009A97 RID: 39575 RVA: 0x00292228 File Offset: 0x00290428
			// (set) Token: 0x06009A98 RID: 39576 RVA: 0x00053A62 File Offset: 0x00051C62
			public unsafe DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0 field_Public___c__DisplayClass9_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003357 RID: 13143
			// (get) Token: 0x06009A99 RID: 39577 RVA: 0x00292258 File Offset: 0x00290458
			// (set) Token: 0x06009A9A RID: 39578 RVA: 0x00053A81 File Offset: 0x00051C81
			public unsafe Action __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteRewardSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400647C RID: 25724
			private static readonly IntPtr NativeFieldInfoPtr_eliteReward;

			// Token: 0x0400647D RID: 25725
			private static readonly IntPtr NativeFieldInfoPtr_isNotLast;

			// Token: 0x0400647E RID: 25726
			private static readonly IntPtr NativeFieldInfoPtr_buttonHold;

			// Token: 0x0400647F RID: 25727
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0;

			// Token: 0x04006480 RID: 25728
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006481 RID: 25729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006482 RID: 25730
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006483 RID: 25731
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_Image_0;

			// Token: 0x04006484 RID: 25732
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_UIButtonHold_0;

			// Token: 0x04006485 RID: 25733
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0;
		}
	}
}
