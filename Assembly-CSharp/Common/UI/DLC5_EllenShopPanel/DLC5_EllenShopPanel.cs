using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI.DLC5_EllenShopPanel
{
	// Token: 0x020003CD RID: 973
	public class DLC5_EllenShopPanel : UIPanel
	{
		// Token: 0x060073D5 RID: 29653 RVA: 0x00220B20 File Offset: 0x0021ED20
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_EllenShopPanel()
		{
			Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.DLC5_EllenShopPanel", "DLC5_EllenShopPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr);
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_OnePieceProducts");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_DailyProducts");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_NormalProducts");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProductRefreshNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_DailyProductRefreshNum");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_DescriberPanel");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_Describer");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceShelfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_OnePieceShelfField");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyShelfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_DailyShelfField");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalShelfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_NormalShelfField");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_ObjectStackParent");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RemainingCandy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_RemainingCandy");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RemainingFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_RemainingFund");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_EllenShopIntroductionSubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_EllenShopIntroductionSubPanel");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_DAILY_PRODUCTS_HAS_REFRESHED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "DAILY_PRODUCTS_HAS_REFRESHED");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_OnePieceProductsList");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_DailyProductsList");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_NormalProductsList");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RefreshedDailyProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_RefreshedDailyProductsList");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_OnePieceGroup");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_DailyGroup");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "m_NormalGroup");
			DLC5_EllenShopPanel.NativeFieldInfoPtr__HasBought_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "<HasBought>k__BackingField");
			DLC5_EllenShopPanel.NativeFieldInfoPtr_CANDY_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "CANDY_ID");
			DLC5_EllenShopPanel.NativeMethodInfoPtr_CreateGroup_Private_StaticVerticalGridScrollListUILogicalGroupT_3_ProductCondition_UIElementCluster_UIButtonSimple_GridLayoutGroup_Int32_Func_2_ProductCondition_Boolean_Action_1_ProductCondition_IReadOnlyList_1_ProductCondition_Action_2_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687128);
			DLC5_EllenShopPanel.NativeMethodInfoPtr_get_HasBought_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687129);
			DLC5_EllenShopPanel.NativeMethodInfoPtr_set_HasBought_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687130);
			DLC5_EllenShopPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687131);
			DLC5_EllenShopPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687132);
			DLC5_EllenShopPanel.NativeMethodInfoPtr_RefreshFund_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687133);
			DLC5_EllenShopPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687134);
			DLC5_EllenShopPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687135);
			DLC5_EllenShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__29_2_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687136);
			DLC5_EllenShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__29_5_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687137);
			DLC5_EllenShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__29_7_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, 100687138);
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x00220E0C File Offset: 0x0021F00C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288916, RefRangeEnd = 288919, XrefRangeStart = 288877, XrefRangeEnd = 288916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> CreateGroup(GridLayoutGroup shelfField, int row, Func<DLC5_EllenShopPanel.ProductCondition, bool> checkEnabledFunc, Action<DLC5_EllenShopPanel.ProductCondition> afterBuyExtraCallback, IReadOnlyList<DLC5_EllenShopPanel.ProductCondition> targetList, Action<int, MoveDirection> onCustomLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shelfField);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkEnabledFunc);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterBuyExtraCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCustomLoop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr_CreateGroup_Private_StaticVerticalGridScrollListUILogicalGroupT_3_ProductCondition_UIElementCluster_UIButtonSimple_GridLayoutGroup_Int32_Func_2_ProductCondition_Boolean_Action_1_ProductCondition_IReadOnlyList_1_ProductCondition_Action_2_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple>>(intPtr3) : null;
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x00220EB8 File Offset: 0x0021F0B8
		// (set) Token: 0x060073D8 RID: 29656 RVA: 0x00220EF4 File Offset: 0x0021F0F4
		public unsafe bool HasBought
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr_get_HasBought_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr_set_HasBought_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00220F34 File Offset: 0x0021F134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288919, XrefRangeEnd = 289013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_EllenShopPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00220F70 File Offset: 0x0021F170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289013, XrefRangeEnd = 289129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_EllenShopPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00220FAC File Offset: 0x0021F1AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289136, RefRangeEnd = 289138, XrefRangeStart = 289129, XrefRangeEnd = 289136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr_RefreshFund_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00220FE0 File Offset: 0x0021F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289138, XrefRangeEnd = 289159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_EllenShopPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x0022101C File Offset: 0x0021F21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289159, XrefRangeEnd = 289183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_EllenShopPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x00221058 File Offset: 0x0021F258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289183, XrefRangeEnd = 289190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__29_2(int column, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__29_2_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x002210A4 File Offset: 0x0021F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289190, XrefRangeEnd = 289197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__29_5(int column, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__29_5_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x002210F0 File Offset: 0x0021F2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289197, XrefRangeEnd = 289204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__29_7(int column, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__29_7_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x0003EA48 File Offset: 0x0003CC48
		public DLC5_EllenShopPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x0022113C File Offset: 0x0021F33C
		// (set) Token: 0x060073E3 RID: 29667 RVA: 0x0003EA51 File Offset: 0x0003CC51
		public unsafe Il2CppReferenceArray<DLC5_EllenShopPanel.ProductCondition> m_OnePieceProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x0022116C File Offset: 0x0021F36C
		// (set) Token: 0x060073E5 RID: 29669 RVA: 0x0003EA70 File Offset: 0x0003CC70
		public unsafe Il2CppReferenceArray<DLC5_EllenShopPanel.ProductCondition> m_DailyProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x0022119C File Offset: 0x0021F39C
		// (set) Token: 0x060073E7 RID: 29671 RVA: 0x0003EA8F File Offset: 0x0003CC8F
		public unsafe Il2CppReferenceArray<DLC5_EllenShopPanel.ProductCondition> m_NormalProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x002211CC File Offset: 0x0021F3CC
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x0003EAAE File Offset: 0x0003CCAE
		public unsafe Vector2Int m_DailyProductRefreshNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProductRefreshNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProductRefreshNum)) = value;
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x002211F4 File Offset: 0x0021F3F4
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x0003EAC9 File Offset: 0x0003CCC9
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x00221224 File Offset: 0x0021F424
		// (set) Token: 0x060073ED RID: 29677 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
		public unsafe CanvasGroup m_DescriberPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DescriberPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x060073EE RID: 29678 RVA: 0x00221254 File Offset: 0x0021F454
		// (set) Token: 0x060073EF RID: 29679 RVA: 0x0003EB07 File Offset: 0x0003CD07
		public unsafe EllenShopDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EllenShopDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x060073F0 RID: 29680 RVA: 0x00221284 File Offset: 0x0021F484
		// (set) Token: 0x060073F1 RID: 29681 RVA: 0x0003EB26 File Offset: 0x0003CD26
		public unsafe GridLayoutGroup m_OnePieceShelfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceShelfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceShelfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x060073F2 RID: 29682 RVA: 0x002212B4 File Offset: 0x0021F4B4
		// (set) Token: 0x060073F3 RID: 29683 RVA: 0x0003EB45 File Offset: 0x0003CD45
		public unsafe GridLayoutGroup m_DailyShelfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyShelfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyShelfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x060073F4 RID: 29684 RVA: 0x002212E4 File Offset: 0x0021F4E4
		// (set) Token: 0x060073F5 RID: 29685 RVA: 0x0003EB64 File Offset: 0x0003CD64
		public unsafe GridLayoutGroup m_NormalShelfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalShelfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalShelfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x00221314 File Offset: 0x0021F514
		// (set) Token: 0x060073F7 RID: 29687 RVA: 0x0003EB83 File Offset: 0x0003CD83
		public unsafe GameObject m_ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x00221344 File Offset: 0x0021F544
		// (set) Token: 0x060073F9 RID: 29689 RVA: 0x0003EBA2 File Offset: 0x0003CDA2
		public unsafe TextMeshProUGUI m_RemainingCandy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RemainingCandy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RemainingCandy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x00221374 File Offset: 0x0021F574
		// (set) Token: 0x060073FB RID: 29691 RVA: 0x0003EBC1 File Offset: 0x0003CDC1
		public unsafe TextMeshProUGUI m_RemainingFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RemainingFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RemainingFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x002213A4 File Offset: 0x0021F5A4
		// (set) Token: 0x060073FD RID: 29693 RVA: 0x0003EBE0 File Offset: 0x0003CDE0
		public unsafe DLC5_EllenShopIntroductionSubPanel m_EllenShopIntroductionSubPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_EllenShopIntroductionSubPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopIntroductionSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_EllenShopIntroductionSubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x002213D4 File Offset: 0x0021F5D4
		// (set) Token: 0x060073FF RID: 29695 RVA: 0x0003EBFF File Offset: 0x0003CDFF
		public unsafe static string DAILY_PRODUCTS_HAS_REFRESHED
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.NativeFieldInfoPtr_DAILY_PRODUCTS_HAS_REFRESHED, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.NativeFieldInfoPtr_DAILY_PRODUCTS_HAS_REFRESHED, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x06007400 RID: 29696 RVA: 0x002213F4 File Offset: 0x0021F5F4
		// (set) Token: 0x06007401 RID: 29697 RVA: 0x0003EC11 File Offset: 0x0003CE11
		public unsafe List<DLC5_EllenShopPanel.ProductCondition> m_OnePieceProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x00221424 File Offset: 0x0021F624
		// (set) Token: 0x06007403 RID: 29699 RVA: 0x0003EC30 File Offset: 0x0003CE30
		public unsafe List<DLC5_EllenShopPanel.ProductCondition> m_DailyProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x00221454 File Offset: 0x0021F654
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x0003EC4F File Offset: 0x0003CE4F
		public unsafe List<DLC5_EllenShopPanel.ProductCondition> m_NormalProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x00221484 File Offset: 0x0021F684
		// (set) Token: 0x06007407 RID: 29703 RVA: 0x0003EC6E File Offset: 0x0003CE6E
		public unsafe List<DLC5_EllenShopPanel.ProductCondition> m_RefreshedDailyProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RefreshedDailyProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_RefreshedDailyProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x06007408 RID: 29704 RVA: 0x002214B4 File Offset: 0x0021F6B4
		// (set) Token: 0x06007409 RID: 29705 RVA: 0x0003EC8D File Offset: 0x0003CE8D
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> m_OnePieceGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_OnePieceGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x002214E4 File Offset: 0x0021F6E4
		// (set) Token: 0x0600740B RID: 29707 RVA: 0x0003ECAC File Offset: 0x0003CEAC
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> m_DailyGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_DailyGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x00221514 File Offset: 0x0021F714
		// (set) Token: 0x0600740D RID: 29709 RVA: 0x0003ECCB File Offset: 0x0003CECB
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> m_NormalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr_m_NormalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600740E RID: 29710 RVA: 0x00221544 File Offset: 0x0021F744
		// (set) Token: 0x0600740F RID: 29711 RVA: 0x0003ECEA File Offset: 0x0003CEEA
		public unsafe bool _HasBought_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr__HasBought_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.NativeFieldInfoPtr__HasBought_k__BackingField)) = value;
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x0022156C File Offset: 0x0021F76C
		// (set) Token: 0x06007411 RID: 29713 RVA: 0x0003ED05 File Offset: 0x0003CF05
		public unsafe static int CANDY_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.NativeFieldInfoPtr_CANDY_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.NativeFieldInfoPtr_CANDY_ID, (void*)(&value));
			}
		}

		// Token: 0x04004CC5 RID: 19653
		private static readonly IntPtr NativeFieldInfoPtr_m_OnePieceProducts;

		// Token: 0x04004CC6 RID: 19654
		private static readonly IntPtr NativeFieldInfoPtr_m_DailyProducts;

		// Token: 0x04004CC7 RID: 19655
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalProducts;

		// Token: 0x04004CC8 RID: 19656
		private static readonly IntPtr NativeFieldInfoPtr_m_DailyProductRefreshNum;

		// Token: 0x04004CC9 RID: 19657
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x04004CCA RID: 19658
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberPanel;

		// Token: 0x04004CCB RID: 19659
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x04004CCC RID: 19660
		private static readonly IntPtr NativeFieldInfoPtr_m_OnePieceShelfField;

		// Token: 0x04004CCD RID: 19661
		private static readonly IntPtr NativeFieldInfoPtr_m_DailyShelfField;

		// Token: 0x04004CCE RID: 19662
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalShelfField;

		// Token: 0x04004CCF RID: 19663
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectStackParent;

		// Token: 0x04004CD0 RID: 19664
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingCandy;

		// Token: 0x04004CD1 RID: 19665
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingFund;

		// Token: 0x04004CD2 RID: 19666
		private static readonly IntPtr NativeFieldInfoPtr_m_EllenShopIntroductionSubPanel;

		// Token: 0x04004CD3 RID: 19667
		private static readonly IntPtr NativeFieldInfoPtr_DAILY_PRODUCTS_HAS_REFRESHED;

		// Token: 0x04004CD4 RID: 19668
		private static readonly IntPtr NativeFieldInfoPtr_m_OnePieceProductsList;

		// Token: 0x04004CD5 RID: 19669
		private static readonly IntPtr NativeFieldInfoPtr_m_DailyProductsList;

		// Token: 0x04004CD6 RID: 19670
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalProductsList;

		// Token: 0x04004CD7 RID: 19671
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshedDailyProductsList;

		// Token: 0x04004CD8 RID: 19672
		private static readonly IntPtr NativeFieldInfoPtr_m_OnePieceGroup;

		// Token: 0x04004CD9 RID: 19673
		private static readonly IntPtr NativeFieldInfoPtr_m_DailyGroup;

		// Token: 0x04004CDA RID: 19674
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGroup;

		// Token: 0x04004CDB RID: 19675
		private static readonly IntPtr NativeFieldInfoPtr__HasBought_k__BackingField;

		// Token: 0x04004CDC RID: 19676
		private static readonly IntPtr NativeFieldInfoPtr_CANDY_ID;

		// Token: 0x04004CDD RID: 19677
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroup_Private_StaticVerticalGridScrollListUILogicalGroupT_3_ProductCondition_UIElementCluster_UIButtonSimple_GridLayoutGroup_Int32_Func_2_ProductCondition_Boolean_Action_1_ProductCondition_IReadOnlyList_1_ProductCondition_Action_2_Int32_MoveDirection_0;

		// Token: 0x04004CDE RID: 19678
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBought_Public_get_Boolean_0;

		// Token: 0x04004CDF RID: 19679
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBought_Private_set_Void_Boolean_0;

		// Token: 0x04004CE0 RID: 19680
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004CE1 RID: 19681
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004CE2 RID: 19682
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFund_Private_Void_0;

		// Token: 0x04004CE3 RID: 19683
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004CE4 RID: 19684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004CE5 RID: 19685
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_2_Private_Void_Int32_MoveDirection_0;

		// Token: 0x04004CE6 RID: 19686
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_5_Private_Void_Int32_MoveDirection_0;

		// Token: 0x04004CE7 RID: 19687
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_7_Private_Void_Int32_MoveDirection_0;

		// Token: 0x02000F5A RID: 3930
		[Serializable]
		public sealed class ProductCondition : ValueType
		{
			// Token: 0x06011191 RID: 70033 RVA: 0x003F23AC File Offset: 0x003F05AC
			// Note: this type is marked as 'beforefieldinit'.
			static ProductCondition()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "ProductCondition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr);
				DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_Currencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr, "m_Currencies");
				DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_Reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr, "m_Reward");
				DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_ForceRefreshForDaily = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr, "m_ForceRefreshForDaily");
			}

			// Token: 0x06011192 RID: 70034 RVA: 0x00094AEA File Offset: 0x00092CEA
			public ProductCondition(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011193 RID: 70035 RVA: 0x00094AF3 File Offset: 0x00092CF3
			public ProductCondition() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr))
			{
			}

			// Token: 0x170058E9 RID: 22761
			// (get) Token: 0x06011194 RID: 70036 RVA: 0x003F2414 File Offset: 0x003F0614
			// (set) Token: 0x06011195 RID: 70037 RVA: 0x00094B05 File Offset: 0x00092D05
			public unsafe Il2CppReferenceArray<DLC5_EllenShopPanel.Currency> m_Currencies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_Currencies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_EllenShopPanel.Currency>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_Currencies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058EA RID: 22762
			// (get) Token: 0x06011196 RID: 70038 RVA: 0x003F2444 File Offset: 0x003F0644
			// (set) Token: 0x06011197 RID: 70039 RVA: 0x00094B24 File Offset: 0x00092D24
			public Product m_Reward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_Reward);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_Reward), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058EB RID: 22763
			// (get) Token: 0x06011198 RID: 70040 RVA: 0x003F2474 File Offset: 0x003F0674
			// (set) Token: 0x06011199 RID: 70041 RVA: 0x00094B52 File Offset: 0x00092D52
			public unsafe bool m_ForceRefreshForDaily
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_ForceRefreshForDaily);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.ProductCondition.NativeFieldInfoPtr_m_ForceRefreshForDaily)) = value;
				}
			}

			// Token: 0x0400ACFE RID: 44286
			private static readonly IntPtr NativeFieldInfoPtr_m_Currencies;

			// Token: 0x0400ACFF RID: 44287
			private static readonly IntPtr NativeFieldInfoPtr_m_Reward;

			// Token: 0x0400AD00 RID: 44288
			private static readonly IntPtr NativeFieldInfoPtr_m_ForceRefreshForDaily;
		}

		// Token: 0x02000F5B RID: 3931
		[Serializable]
		public sealed class Currency : ValueType
		{
			// Token: 0x0601119A RID: 70042 RVA: 0x003F249C File Offset: 0x003F069C
			// Note: this type is marked as 'beforefieldinit'.
			static Currency()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "Currency");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr);
				DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ProductConditionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, "m_ProductConditionType");
				DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, "m_Product");
				DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ConditionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, "m_ConditionValue");
				DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ConditionValueArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, "m_ConditionValueArray");
				DLC5_EllenShopPanel.Currency.NativeMethodInfoPtr_GetText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, 100687139);
				DLC5_EllenShopPanel.Currency.NativeMethodInfoPtr_Method_Internal_Static_String_Product_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, 100687140);
				DLC5_EllenShopPanel.Currency.NativeMethodInfoPtr_Method_Internal_Static_String_Product_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, 100687141);
			}

			// Token: 0x0601119B RID: 70043 RVA: 0x003F2554 File Offset: 0x003F0754
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 288700, RefRangeEnd = 288702, XrefRangeStart = 288583, XrefRangeEnd = 288700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetText()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.NativeMethodInfoPtr_GetText_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601119C RID: 70044 RVA: 0x003F2590 File Offset: 0x003F0790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288702, XrefRangeEnd = 288710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Method_Internal_Static_String_Product_Int32_PDM_0(Product product, int tagId)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.NativeMethodInfoPtr_Method_Internal_Static_String_Product_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601119D RID: 70045 RVA: 0x003F25E0 File Offset: 0x003F07E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288752, RefRangeEnd = 288753, XrefRangeStart = 288710, XrefRangeEnd = 288752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Method_Internal_Static_String_Product_Il2CppStructArray_1_Int32_0(Product product, Il2CppStructArray<int> tags)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.NativeMethodInfoPtr_Method_Internal_Static_String_Product_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601119E RID: 70046 RVA: 0x00094B6D File Offset: 0x00092D6D
			public Currency(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601119F RID: 70047 RVA: 0x00094B76 File Offset: 0x00092D76
			public Currency() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr))
			{
			}

			// Token: 0x170058EC RID: 22764
			// (get) Token: 0x060111A0 RID: 70048 RVA: 0x003F2634 File Offset: 0x003F0834
			// (set) Token: 0x060111A1 RID: 70049 RVA: 0x00094B88 File Offset: 0x00092D88
			public unsafe MissionNode.FinishCondition.ConditionType m_ProductConditionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ProductConditionType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ProductConditionType)) = value;
				}
			}

			// Token: 0x170058ED RID: 22765
			// (get) Token: 0x060111A2 RID: 70050 RVA: 0x003F265C File Offset: 0x003F085C
			// (set) Token: 0x060111A3 RID: 70051 RVA: 0x00094BA3 File Offset: 0x00092DA3
			public Product m_Product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_Product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_Product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058EE RID: 22766
			// (get) Token: 0x060111A4 RID: 70052 RVA: 0x003F268C File Offset: 0x003F088C
			// (set) Token: 0x060111A5 RID: 70053 RVA: 0x00094BD1 File Offset: 0x00092DD1
			public unsafe int m_ConditionValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ConditionValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ConditionValue)) = value;
				}
			}

			// Token: 0x170058EF RID: 22767
			// (get) Token: 0x060111A6 RID: 70054 RVA: 0x003F26B4 File Offset: 0x003F08B4
			// (set) Token: 0x060111A7 RID: 70055 RVA: 0x00094BEC File Offset: 0x00092DEC
			public unsafe Il2CppStructArray<int> m_ConditionValueArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ConditionValueArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.Currency.NativeFieldInfoPtr_m_ConditionValueArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD01 RID: 44289
			private static readonly IntPtr NativeFieldInfoPtr_m_ProductConditionType;

			// Token: 0x0400AD02 RID: 44290
			private static readonly IntPtr NativeFieldInfoPtr_m_Product;

			// Token: 0x0400AD03 RID: 44291
			private static readonly IntPtr NativeFieldInfoPtr_m_ConditionValue;

			// Token: 0x0400AD04 RID: 44292
			private static readonly IntPtr NativeFieldInfoPtr_m_ConditionValueArray;

			// Token: 0x0400AD05 RID: 44293
			private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_String_0;

			// Token: 0x0400AD06 RID: 44294
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Product_Int32_PDM_0;

			// Token: 0x0400AD07 RID: 44295
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Product_Il2CppStructArray_1_Int32_0;

			// Token: 0x020010DA RID: 4314
			[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopPanel+Currency+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060123FE RID: 74750 RVA: 0x00428DDC File Offset: 0x00426FDC
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr);
					DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, "<>9");
					DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, "<>9__4_2");
					DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, "<>9__4_3");
					DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, "<>9__4_4");
					DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, 100687143);
					DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__GetText_b__4_2_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, 100687144);
					DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__GetText_b__4_3_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, 100687145);
					DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__GetText_b__4_4_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr, 100687146);
				}

				// Token: 0x060123FF RID: 74751 RVA: 0x00428EA8 File Offset: 0x004270A8
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.Currency.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012400 RID: 74752 RVA: 0x00428EE4 File Offset: 0x004270E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__4_2(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__GetText_b__4_2_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012401 RID: 74753 RVA: 0x00428F28 File Offset: 0x00427128
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__4_3(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__GetText_b__4_3_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012402 RID: 74754 RVA: 0x00428F6C File Offset: 0x0042716C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__4_4(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.Currency.__c.NativeMethodInfoPtr__GetText_b__4_4_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012403 RID: 74755 RVA: 0x0009E3D0 File Offset: 0x0009C5D0
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F71 RID: 24433
				// (get) Token: 0x06012404 RID: 74756 RVA: 0x00428FB0 File Offset: 0x004271B0
				// (set) Token: 0x06012405 RID: 74757 RVA: 0x0009E3D9 File Offset: 0x0009C5D9
				public unsafe static DLC5_EllenShopPanel.Currency.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopPanel.Currency.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F72 RID: 24434
				// (get) Token: 0x06012406 RID: 74758 RVA: 0x00428FD8 File Offset: 0x004271D8
				// (set) Token: 0x06012407 RID: 74759 RVA: 0x0009E3EB File Offset: 0x0009C5EB
				public unsafe static Func<int, string> __9__4_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F73 RID: 24435
				// (get) Token: 0x06012408 RID: 74760 RVA: 0x00429000 File Offset: 0x00427200
				// (set) Token: 0x06012409 RID: 74761 RVA: 0x0009E3FD File Offset: 0x0009C5FD
				public unsafe static Func<int, string> __9__4_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F74 RID: 24436
				// (get) Token: 0x0601240A RID: 74762 RVA: 0x00429028 File Offset: 0x00427228
				// (set) Token: 0x0601240B RID: 74763 RVA: 0x0009E40F File Offset: 0x0009C60F
				public unsafe static Func<int, string> __9__4_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.Currency.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B903 RID: 47363
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B904 RID: 47364
				private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

				// Token: 0x0400B905 RID: 47365
				private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

				// Token: 0x0400B906 RID: 47366
				private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

				// Token: 0x0400B907 RID: 47367
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B908 RID: 47368
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__4_2_Internal_String_Int32_0;

				// Token: 0x0400B909 RID: 47369
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__4_3_Internal_String_Int32_0;

				// Token: 0x0400B90A RID: 47370
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__4_4_Internal_String_Int32_0;
			}
		}

		// Token: 0x02000F5C RID: 3932
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopPanel+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
		{
			// Token: 0x060111A8 RID: 70056 RVA: 0x003F26E4 File Offset: 0x003F08E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr);
				DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_checkEnabledFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr, "checkEnabledFunc");
				DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
				DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_afterBuyExtraCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr, "afterBuyExtraCallback");
				DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr, 100687147);
				DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr, 100687148);
				DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr, 100687149);
			}

			// Token: 0x060111A9 RID: 70057 RVA: 0x003F2788 File Offset: 0x003F0988
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111AA RID: 70058 RVA: 0x003F27C4 File Offset: 0x003F09C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288753, XrefRangeEnd = 288799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_0(DLC5_EllenShopPanel.ProductCondition productCondition, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productCondition));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111AB RID: 70059 RVA: 0x003F2830 File Offset: 0x003F0A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288799, XrefRangeEnd = 288820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_1(DLC5_EllenShopPanel.ProductCondition productCondition, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productCondition));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111AC RID: 70060 RVA: 0x00094C0B File Offset: 0x00092E0B
			public __c__DisplayClass0_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058F0 RID: 22768
			// (get) Token: 0x060111AD RID: 70061 RVA: 0x003F289C File Offset: 0x003F0A9C
			// (set) Token: 0x060111AE RID: 70062 RVA: 0x00094C14 File Offset: 0x00092E14
			public unsafe Func<DLC5_EllenShopPanel.ProductCondition, bool> checkEnabledFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_checkEnabledFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.ProductCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_checkEnabledFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058F1 RID: 22769
			// (get) Token: 0x060111AF RID: 70063 RVA: 0x003F28CC File Offset: 0x003F0ACC
			// (set) Token: 0x060111B0 RID: 70064 RVA: 0x00094C33 File Offset: 0x00092E33
			public unsafe DLC5_EllenShopPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058F2 RID: 22770
			// (get) Token: 0x060111B1 RID: 70065 RVA: 0x003F28FC File Offset: 0x003F0AFC
			// (set) Token: 0x060111B2 RID: 70066 RVA: 0x00094C52 File Offset: 0x00092E52
			public unsafe Action<DLC5_EllenShopPanel.ProductCondition> afterBuyExtraCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_afterBuyExtraCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_afterBuyExtraCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD08 RID: 44296
			private static readonly IntPtr NativeFieldInfoPtr_checkEnabledFunc;

			// Token: 0x0400AD09 RID: 44297
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD0A RID: 44298
			private static readonly IntPtr NativeFieldInfoPtr_afterBuyExtraCallback;

			// Token: 0x0400AD0B RID: 44299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD0C RID: 44300
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_0;

			// Token: 0x0400AD0D RID: 44301
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ProductCondition_UIElementCluster_UIButtonSimple_PDM_1;
		}

		// Token: 0x02000F5D RID: 3933
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopPanel+<>c__DisplayClass0_1")]
		public sealed class __c__DisplayClass0_1 : Il2CppSystem.Object
		{
			// Token: 0x060111B3 RID: 70067 RVA: 0x003F292C File Offset: 0x003F0B2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_1()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "<>c__DisplayClass0_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr);
				DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr, "amount");
				DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeFieldInfoPtr_canBought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr, "canBought");
				DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr, 100687150);
				DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__CreateGroup_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr, 100687151);
				DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__CreateGroup_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr, 100687152);
				DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__CreateGroup_b__4_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr, 100687153);
			}

			// Token: 0x060111B4 RID: 70068 RVA: 0x003F29D0 File Offset: 0x003F0BD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111B5 RID: 70069 RVA: 0x003F2A0C File Offset: 0x003F0C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288820, XrefRangeEnd = 288825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGroup_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__CreateGroup_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111B6 RID: 70070 RVA: 0x003F2A50 File Offset: 0x003F0C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288825, XrefRangeEnd = 288830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGroup_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__CreateGroup_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111B7 RID: 70071 RVA: 0x003F2A94 File Offset: 0x003F0C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288830, XrefRangeEnd = 288831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGroup_b__4(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeMethodInfoPtr__CreateGroup_b__4_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111B8 RID: 70072 RVA: 0x00094C71 File Offset: 0x00092E71
			public __c__DisplayClass0_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058F3 RID: 22771
			// (get) Token: 0x060111B9 RID: 70073 RVA: 0x003F2AD8 File Offset: 0x003F0CD8
			// (set) Token: 0x060111BA RID: 70074 RVA: 0x00094C7A File Offset: 0x00092E7A
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x170058F4 RID: 22772
			// (get) Token: 0x060111BB RID: 70075 RVA: 0x003F2B00 File Offset: 0x003F0D00
			// (set) Token: 0x060111BC RID: 70076 RVA: 0x00094C95 File Offset: 0x00092E95
			public unsafe bool canBought
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeFieldInfoPtr_canBought);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_1.NativeFieldInfoPtr_canBought)) = value;
				}
			}

			// Token: 0x0400AD0E RID: 44302
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400AD0F RID: 44303
			private static readonly IntPtr NativeFieldInfoPtr_canBought;

			// Token: 0x0400AD10 RID: 44304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD11 RID: 44305
			private static readonly IntPtr NativeMethodInfoPtr__CreateGroup_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD12 RID: 44306
			private static readonly IntPtr NativeMethodInfoPtr__CreateGroup_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD13 RID: 44307
			private static readonly IntPtr NativeMethodInfoPtr__CreateGroup_b__4_Internal_Void_CanvasGroup_0;
		}

		// Token: 0x02000F5E RID: 3934
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopPanel+<>c__DisplayClass0_2")]
		public sealed class __c__DisplayClass0_2 : Il2CppSystem.Object
		{
			// Token: 0x060111BD RID: 70077 RVA: 0x003F2B28 File Offset: 0x003F0D28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_2()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "<>c__DisplayClass0_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr);
				DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeFieldInfoPtr_thisProductCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr, "thisProductCondition");
				DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr, 100687154);
				DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeMethodInfoPtr__CreateGroup_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr, 100687155);
				DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeMethodInfoPtr__CreateGroup_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr, 100687156);
			}

			// Token: 0x060111BE RID: 70078 RVA: 0x003F2BB8 File Offset: 0x003F0DB8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111BF RID: 70079 RVA: 0x003F2BF4 File Offset: 0x003F0DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288831, XrefRangeEnd = 288832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGroup_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeMethodInfoPtr__CreateGroup_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111C0 RID: 70080 RVA: 0x003F2C28 File Offset: 0x003F0E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288832, XrefRangeEnd = 288853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGroup_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeMethodInfoPtr__CreateGroup_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111C1 RID: 70081 RVA: 0x00094CB0 File Offset: 0x00092EB0
			public __c__DisplayClass0_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058F5 RID: 22773
			// (get) Token: 0x060111C2 RID: 70082 RVA: 0x003F2C5C File Offset: 0x003F0E5C
			// (set) Token: 0x060111C3 RID: 70083 RVA: 0x00094CB9 File Offset: 0x00092EB9
			public DLC5_EllenShopPanel.ProductCondition thisProductCondition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeFieldInfoPtr_thisProductCondition);
					return new DLC5_EllenShopPanel.ProductCondition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeFieldInfoPtr_thisProductCondition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_EllenShopPanel.ProductCondition>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058F6 RID: 22774
			// (get) Token: 0x060111C4 RID: 70084 RVA: 0x003F2C8C File Offset: 0x003F0E8C
			// (set) Token: 0x060111C5 RID: 70085 RVA: 0x00094CE7 File Offset: 0x00092EE7
			public unsafe DLC5_EllenShopPanel.__c__DisplayClass0_0 field_Public___c__DisplayClass0_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopPanel.__c__DisplayClass0_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_2.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD14 RID: 44308
			private static readonly IntPtr NativeFieldInfoPtr_thisProductCondition;

			// Token: 0x0400AD15 RID: 44309
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0;

			// Token: 0x0400AD16 RID: 44310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD17 RID: 44311
			private static readonly IntPtr NativeMethodInfoPtr__CreateGroup_b__5_Internal_Void_0;

			// Token: 0x0400AD18 RID: 44312
			private static readonly IntPtr NativeMethodInfoPtr__CreateGroup_b__6_Internal_Void_0;
		}

		// Token: 0x02000F5F RID: 3935
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopPanel+<>c__DisplayClass0_3")]
		public sealed class __c__DisplayClass0_3 : Il2CppSystem.Object
		{
			// Token: 0x060111C6 RID: 70086 RVA: 0x003F2CBC File Offset: 0x003F0EBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_3()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "<>c__DisplayClass0_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr);
				DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr, "panel");
				DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr, "CS$<>8__locals2");
				DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr, 100687157);
				DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeMethodInfoPtr__CreateGroup_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr, 100687158);
			}

			// Token: 0x060111C7 RID: 70087 RVA: 0x003F2D38 File Offset: 0x003F0F38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c__DisplayClass0_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111C8 RID: 70088 RVA: 0x003F2D74 File Offset: 0x003F0F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288853, XrefRangeEnd = 288862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGroup_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeMethodInfoPtr__CreateGroup_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111C9 RID: 70089 RVA: 0x00094D06 File Offset: 0x00092F06
			public __c__DisplayClass0_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058F7 RID: 22775
			// (get) Token: 0x060111CA RID: 70090 RVA: 0x003F2DA8 File Offset: 0x003F0FA8
			// (set) Token: 0x060111CB RID: 70091 RVA: 0x00094D0F File Offset: 0x00092F0F
			public unsafe DLC5_EllenShopIntroductionSubPanel panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeFieldInfoPtr_panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopIntroductionSubPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058F8 RID: 22776
			// (get) Token: 0x060111CC RID: 70092 RVA: 0x003F2DD8 File Offset: 0x003F0FD8
			// (set) Token: 0x060111CD RID: 70093 RVA: 0x00094D2E File Offset: 0x00092F2E
			public unsafe DLC5_EllenShopPanel.__c__DisplayClass0_2 field_Public___c__DisplayClass0_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopPanel.__c__DisplayClass0_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopPanel.__c__DisplayClass0_3.NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD19 RID: 44313
			private static readonly IntPtr NativeFieldInfoPtr_panel;

			// Token: 0x0400AD1A RID: 44314
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_0;

			// Token: 0x0400AD1B RID: 44315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD1C RID: 44316
			private static readonly IntPtr NativeMethodInfoPtr__CreateGroup_b__7_Internal_Void_0;
		}

		// Token: 0x02000F60 RID: 3936
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060111CE RID: 70094 RVA: 0x003F2E08 File Offset: 0x003F1008
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr);
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__29_0");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__29_1");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__29_3");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__29_4");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__29_6");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__30_1");
				DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, "<>9__30_0");
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687160);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_0_Internal_Boolean_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687161);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_1_Internal_Void_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687162);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_3_Internal_Boolean_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687163);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_4_Internal_Void_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687164);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_6_Internal_Boolean_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687165);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687166);
				DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_0_Internal_Boolean_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr, 100687167);
			}

			// Token: 0x060111CF RID: 70095 RVA: 0x003F2F74 File Offset: 0x003F1174
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111D0 RID: 70096 RVA: 0x003F2FB0 File Offset: 0x003F11B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288862, XrefRangeEnd = 288863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__29_0(DLC5_EllenShopPanel.ProductCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_0_Internal_Boolean_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060111D1 RID: 70097 RVA: 0x003F3004 File Offset: 0x003F1204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288863, XrefRangeEnd = 288864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__29_1(DLC5_EllenShopPanel.ProductCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_1_Internal_Void_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111D2 RID: 70098 RVA: 0x003F304C File Offset: 0x003F124C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288864, XrefRangeEnd = 288868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__29_3(DLC5_EllenShopPanel.ProductCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_3_Internal_Boolean_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060111D3 RID: 70099 RVA: 0x003F30A0 File Offset: 0x003F12A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288868, XrefRangeEnd = 288873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__29_4(DLC5_EllenShopPanel.ProductCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_4_Internal_Void_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111D4 RID: 70100 RVA: 0x003F30E8 File Offset: 0x003F12E8
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__29_6(DLC5_EllenShopPanel.ProductCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_6_Internal_Boolean_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060111D5 RID: 70101 RVA: 0x003F313C File Offset: 0x003F133C
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__30_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060111D6 RID: 70102 RVA: 0x003F3188 File Offset: 0x003F1388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288873, XrefRangeEnd = 288877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__30_0(DLC5_EllenShopPanel.ProductCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_0_Internal_Boolean_ProductCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060111D7 RID: 70103 RVA: 0x00094D4D File Offset: 0x00092F4D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058F9 RID: 22777
			// (get) Token: 0x060111D8 RID: 70104 RVA: 0x003F31DC File Offset: 0x003F13DC
			// (set) Token: 0x060111D9 RID: 70105 RVA: 0x00094D56 File Offset: 0x00092F56
			public unsafe static DLC5_EllenShopPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058FA RID: 22778
			// (get) Token: 0x060111DA RID: 70106 RVA: 0x003F3204 File Offset: 0x003F1404
			// (set) Token: 0x060111DB RID: 70107 RVA: 0x00094D68 File Offset: 0x00092F68
			public unsafe static Func<DLC5_EllenShopPanel.ProductCondition, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.ProductCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058FB RID: 22779
			// (get) Token: 0x060111DC RID: 70108 RVA: 0x003F322C File Offset: 0x003F142C
			// (set) Token: 0x060111DD RID: 70109 RVA: 0x00094D7A File Offset: 0x00092F7A
			public unsafe static Action<DLC5_EllenShopPanel.ProductCondition> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058FC RID: 22780
			// (get) Token: 0x060111DE RID: 70110 RVA: 0x003F3254 File Offset: 0x003F1454
			// (set) Token: 0x060111DF RID: 70111 RVA: 0x00094D8C File Offset: 0x00092F8C
			public unsafe static Func<DLC5_EllenShopPanel.ProductCondition, bool> __9__29_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.ProductCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058FD RID: 22781
			// (get) Token: 0x060111E0 RID: 70112 RVA: 0x003F327C File Offset: 0x003F147C
			// (set) Token: 0x060111E1 RID: 70113 RVA: 0x00094D9E File Offset: 0x00092F9E
			public unsafe static Action<DLC5_EllenShopPanel.ProductCondition> __9__29_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC5_EllenShopPanel.ProductCondition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058FE RID: 22782
			// (get) Token: 0x060111E2 RID: 70114 RVA: 0x003F32A4 File Offset: 0x003F14A4
			// (set) Token: 0x060111E3 RID: 70115 RVA: 0x00094DB0 File Offset: 0x00092FB0
			public unsafe static Func<DLC5_EllenShopPanel.ProductCondition, bool> __9__29_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.ProductCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__29_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058FF RID: 22783
			// (get) Token: 0x060111E4 RID: 70116 RVA: 0x003F32CC File Offset: 0x003F14CC
			// (set) Token: 0x060111E5 RID: 70117 RVA: 0x00094DC2 File Offset: 0x00092FC2
			public unsafe static Func<int, int> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005900 RID: 22784
			// (get) Token: 0x060111E6 RID: 70118 RVA: 0x003F32F4 File Offset: 0x003F14F4
			// (set) Token: 0x060111E7 RID: 70119 RVA: 0x00094DD4 File Offset: 0x00092FD4
			public unsafe static Func<DLC5_EllenShopPanel.ProductCondition, bool> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.ProductCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopPanel.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD1D RID: 44317
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AD1E RID: 44318
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400AD1F RID: 44319
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x0400AD20 RID: 44320
			private static readonly IntPtr NativeFieldInfoPtr___9__29_3;

			// Token: 0x0400AD21 RID: 44321
			private static readonly IntPtr NativeFieldInfoPtr___9__29_4;

			// Token: 0x0400AD22 RID: 44322
			private static readonly IntPtr NativeFieldInfoPtr___9__29_6;

			// Token: 0x0400AD23 RID: 44323
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x0400AD24 RID: 44324
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x0400AD25 RID: 44325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD26 RID: 44326
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_0_Internal_Boolean_ProductCondition_0;

			// Token: 0x0400AD27 RID: 44327
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_1_Internal_Void_ProductCondition_0;

			// Token: 0x0400AD28 RID: 44328
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_3_Internal_Boolean_ProductCondition_0;

			// Token: 0x0400AD29 RID: 44329
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_4_Internal_Void_ProductCondition_0;

			// Token: 0x0400AD2A RID: 44330
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_6_Internal_Boolean_ProductCondition_0;

			// Token: 0x0400AD2B RID: 44331
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_1_Internal_Int32_Int32_0;

			// Token: 0x0400AD2C RID: 44332
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_0_Internal_Boolean_ProductCondition_0;
		}
	}
}
