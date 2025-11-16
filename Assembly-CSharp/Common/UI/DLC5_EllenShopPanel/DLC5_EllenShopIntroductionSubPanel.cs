using System;
using Common.UI.NoteBookUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.DLC5_EllenShopPanel
{
	// Token: 0x020003CC RID: 972
	public class DLC5_EllenShopIntroductionSubPanel : UIPanelParamOpen<DLC5_EllenShopPanel.ProductCondition>
	{
		// Token: 0x060073A2 RID: 29602 RVA: 0x00220254 File Offset: 0x0021E454
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_EllenShopIntroductionSubPanel()
		{
			Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.DLC5_EllenShopPanel", "DLC5_EllenShopIntroductionSubPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr);
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_Fund");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_Cost");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Remaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_Remaining");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ButtonHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_ButtonHold");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ConditionObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_ConditionObject");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ConditionTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_ConditionTransform");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_SubPanelReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_SubPanelReference");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_MoveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_MoveTarget");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_MoveTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_MoveTransform");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_trackingMissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "trackingMissionColor");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_fulFilledMissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "fulFilledMissionColor");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_currentProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "currentProduct");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "cost");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_affordable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "affordable");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "startPosition");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr__CloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "<CloseContext>k__BackingField");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_AllConditionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_AllConditionInstances");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_AllButtonInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "m_AllButtonInstances");
			DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_returnSubmitItemWhenCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "returnSubmitItemWhenCloseCallback");
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_get_CloseContext_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687069);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687070);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687071);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ProductCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687072);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_CheckStatus_Private_Boolean_KeyValuePair_2_Currency_ValueTuple_2_Int64_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687073);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_ProcessConditionObject_Private_Void_UIElementCluster_KeyValuePair_2_Currency_ValueTuple_2_Int64_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687074);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_RefreshFund_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687075);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687076);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687077);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__23_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687078);
			DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_Method_Internal_Static_String_Int64_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, 100687079);
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x060073A3 RID: 29603 RVA: 0x002204DC File Offset: 0x0021E6DC
		// (set) Token: 0x060073A4 RID: 29604 RVA: 0x00220518 File Offset: 0x0021E718
		public unsafe bool CloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_get_CloseContext_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x00220558 File Offset: 0x0021E758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288300, XrefRangeEnd = 288304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x00220594 File Offset: 0x0021E794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288304, XrefRangeEnd = 288363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_EllenShopPanel.ProductCondition openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ProductCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x002205E8 File Offset: 0x0021E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288363, XrefRangeEnd = 288367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckStatus(KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> staticData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(staticData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_CheckStatus_Private_Boolean_KeyValuePair_2_Currency_ValueTuple_2_Int64_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x0022063C File Offset: 0x0021E83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288367, XrefRangeEnd = 288468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessConditionObject(UIElementCluster cluster, KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_ProcessConditionObject_Private_Void_UIElementCluster_KeyValuePair_2_Currency_ValueTuple_2_Int64_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x00220698 File Offset: 0x0021E898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288541, RefRangeEnd = 288543, XrefRangeStart = 288468, XrefRangeEnd = 288541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_RefreshFund_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x002206CC File Offset: 0x0021E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288543, XrefRangeEnd = 288544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x00220708 File Offset: 0x0021E908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288544, XrefRangeEnd = 288562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_EllenShopIntroductionSubPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x00220744 File Offset: 0x0021E944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288562, XrefRangeEnd = 288574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__23_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__23_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00220778 File Offset: 0x0021E978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288574, XrefRangeEnd = 288583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Int64_Int32_PDM_0(long current, int total)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.NativeMethodInfoPtr_Method_Internal_Static_String_Int64_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x0003E80A File Offset: 0x0003CA0A
		public DLC5_EllenShopIntroductionSubPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x060073AF RID: 29615 RVA: 0x002207C0 File Offset: 0x0021E9C0
		// (set) Token: 0x060073B0 RID: 29616 RVA: 0x0003E813 File Offset: 0x0003CA13
		public unsafe TextMeshProUGUI m_Fund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Fund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Fund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x060073B1 RID: 29617 RVA: 0x002207F0 File Offset: 0x0021E9F0
		// (set) Token: 0x060073B2 RID: 29618 RVA: 0x0003E832 File Offset: 0x0003CA32
		public unsafe TextMeshProUGUI m_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x060073B3 RID: 29619 RVA: 0x00220820 File Offset: 0x0021EA20
		// (set) Token: 0x060073B4 RID: 29620 RVA: 0x0003E851 File Offset: 0x0003CA51
		public unsafe TextMeshProUGUI m_Remaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Remaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_Remaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x060073B5 RID: 29621 RVA: 0x00220850 File Offset: 0x0021EA50
		// (set) Token: 0x060073B6 RID: 29622 RVA: 0x0003E870 File Offset: 0x0003CA70
		public unsafe UIButtonHold m_ButtonHold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ButtonHold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ButtonHold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x060073B7 RID: 29623 RVA: 0x00220880 File Offset: 0x0021EA80
		// (set) Token: 0x060073B8 RID: 29624 RVA: 0x0003E88F File Offset: 0x0003CA8F
		public unsafe GameObject m_ConditionObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ConditionObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ConditionObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x060073B9 RID: 29625 RVA: 0x002208B0 File Offset: 0x0021EAB0
		// (set) Token: 0x060073BA RID: 29626 RVA: 0x0003E8AE File Offset: 0x0003CAAE
		public unsafe Transform m_ConditionTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ConditionTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_ConditionTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x060073BB RID: 29627 RVA: 0x002208E0 File Offset: 0x0021EAE0
		// (set) Token: 0x060073BC RID: 29628 RVA: 0x0003E8CD File Offset: 0x0003CACD
		public unsafe SubmissionPanel m_SubPanelReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_SubPanelReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_SubPanelReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x060073BD RID: 29629 RVA: 0x00220910 File Offset: 0x0021EB10
		// (set) Token: 0x060073BE RID: 29630 RVA: 0x0003E8EC File Offset: 0x0003CAEC
		public unsafe RectTransform m_MoveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_MoveTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_MoveTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x060073BF RID: 29631 RVA: 0x00220940 File Offset: 0x0021EB40
		// (set) Token: 0x060073C0 RID: 29632 RVA: 0x0003E90B File Offset: 0x0003CB0B
		public unsafe RectTransform m_MoveTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_MoveTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_MoveTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x00220970 File Offset: 0x0021EB70
		// (set) Token: 0x060073C2 RID: 29634 RVA: 0x0003E92A File Offset: 0x0003CB2A
		public unsafe Color32 trackingMissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_trackingMissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_trackingMissionColor)) = value;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x060073C3 RID: 29635 RVA: 0x00220998 File Offset: 0x0021EB98
		// (set) Token: 0x060073C4 RID: 29636 RVA: 0x0003E945 File Offset: 0x0003CB45
		public unsafe Color32 fulFilledMissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_fulFilledMissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_fulFilledMissionColor)) = value;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x060073C5 RID: 29637 RVA: 0x002209C0 File Offset: 0x0021EBC0
		// (set) Token: 0x060073C6 RID: 29638 RVA: 0x0003E960 File Offset: 0x0003CB60
		public unsafe Dictionary<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> currentProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_currentProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_currentProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x060073C7 RID: 29639 RVA: 0x002209F0 File Offset: 0x0021EBF0
		// (set) Token: 0x060073C8 RID: 29640 RVA: 0x0003E97F File Offset: 0x0003CB7F
		public unsafe int cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_cost)) = value;
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x060073C9 RID: 29641 RVA: 0x00220A18 File Offset: 0x0021EC18
		// (set) Token: 0x060073CA RID: 29642 RVA: 0x0003E99A File Offset: 0x0003CB9A
		public unsafe bool affordable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_affordable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_affordable)) = value;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x060073CB RID: 29643 RVA: 0x00220A40 File Offset: 0x0021EC40
		// (set) Token: 0x060073CC RID: 29644 RVA: 0x0003E9B5 File Offset: 0x0003CBB5
		public unsafe Vector2 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x060073CD RID: 29645 RVA: 0x00220A68 File Offset: 0x0021EC68
		// (set) Token: 0x060073CE RID: 29646 RVA: 0x0003E9D0 File Offset: 0x0003CBD0
		public unsafe bool _CloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr__CloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr__CloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x060073CF RID: 29647 RVA: 0x00220A90 File Offset: 0x0021EC90
		// (set) Token: 0x060073D0 RID: 29648 RVA: 0x0003E9EB File Offset: 0x0003CBEB
		public unsafe List<GameObject> m_AllConditionInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_AllConditionInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_AllConditionInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x060073D1 RID: 29649 RVA: 0x00220AC0 File Offset: 0x0021ECC0
		// (set) Token: 0x060073D2 RID: 29650 RVA: 0x0003EA0A File Offset: 0x0003CC0A
		public unsafe List<UIButtonSimple> m_AllButtonInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_AllButtonInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_m_AllButtonInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x060073D3 RID: 29651 RVA: 0x00220AF0 File Offset: 0x0021ECF0
		// (set) Token: 0x060073D4 RID: 29652 RVA: 0x0003EA29 File Offset: 0x0003CC29
		public unsafe Action returnSubmitItemWhenCloseCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_returnSubmitItemWhenCloseCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.NativeFieldInfoPtr_returnSubmitItemWhenCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CA7 RID: 19623
		private static readonly IntPtr NativeFieldInfoPtr_m_Fund;

		// Token: 0x04004CA8 RID: 19624
		private static readonly IntPtr NativeFieldInfoPtr_m_Cost;

		// Token: 0x04004CA9 RID: 19625
		private static readonly IntPtr NativeFieldInfoPtr_m_Remaining;

		// Token: 0x04004CAA RID: 19626
		private static readonly IntPtr NativeFieldInfoPtr_m_ButtonHold;

		// Token: 0x04004CAB RID: 19627
		private static readonly IntPtr NativeFieldInfoPtr_m_ConditionObject;

		// Token: 0x04004CAC RID: 19628
		private static readonly IntPtr NativeFieldInfoPtr_m_ConditionTransform;

		// Token: 0x04004CAD RID: 19629
		private static readonly IntPtr NativeFieldInfoPtr_m_SubPanelReference;

		// Token: 0x04004CAE RID: 19630
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveTarget;

		// Token: 0x04004CAF RID: 19631
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveTransform;

		// Token: 0x04004CB0 RID: 19632
		private static readonly IntPtr NativeFieldInfoPtr_trackingMissionColor;

		// Token: 0x04004CB1 RID: 19633
		private static readonly IntPtr NativeFieldInfoPtr_fulFilledMissionColor;

		// Token: 0x04004CB2 RID: 19634
		private static readonly IntPtr NativeFieldInfoPtr_currentProduct;

		// Token: 0x04004CB3 RID: 19635
		private static readonly IntPtr NativeFieldInfoPtr_cost;

		// Token: 0x04004CB4 RID: 19636
		private static readonly IntPtr NativeFieldInfoPtr_affordable;

		// Token: 0x04004CB5 RID: 19637
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x04004CB6 RID: 19638
		private static readonly IntPtr NativeFieldInfoPtr__CloseContext_k__BackingField;

		// Token: 0x04004CB7 RID: 19639
		private static readonly IntPtr NativeFieldInfoPtr_m_AllConditionInstances;

		// Token: 0x04004CB8 RID: 19640
		private static readonly IntPtr NativeFieldInfoPtr_m_AllButtonInstances;

		// Token: 0x04004CB9 RID: 19641
		private static readonly IntPtr NativeFieldInfoPtr_returnSubmitItemWhenCloseCallback;

		// Token: 0x04004CBA RID: 19642
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseContext_Public_get_Boolean_0;

		// Token: 0x04004CBB RID: 19643
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseContext_Private_set_Void_Boolean_0;

		// Token: 0x04004CBC RID: 19644
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004CBD RID: 19645
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ProductCondition_0;

		// Token: 0x04004CBE RID: 19646
		private static readonly IntPtr NativeMethodInfoPtr_CheckStatus_Private_Boolean_KeyValuePair_2_Currency_ValueTuple_2_Int64_List_1_Int32_0;

		// Token: 0x04004CBF RID: 19647
		private static readonly IntPtr NativeMethodInfoPtr_ProcessConditionObject_Private_Void_UIElementCluster_KeyValuePair_2_Currency_ValueTuple_2_Int64_List_1_Int32_0;

		// Token: 0x04004CC0 RID: 19648
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFund_Private_Void_0;

		// Token: 0x04004CC1 RID: 19649
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004CC2 RID: 19650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004CC3 RID: 19651
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__23_2_Private_Void_0;

		// Token: 0x04004CC4 RID: 19652
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Int64_Int32_PDM_0;

		// Token: 0x02000F55 RID: 3925
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopIntroductionSubPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0601110C RID: 69900 RVA: 0x003F0778 File Offset: 0x003EE978
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__23_0");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__23_1");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_25");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_26");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_7");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_8");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_29");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_30");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_32");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_33");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_35");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__25_36");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__26_0");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__26_1");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, "<>9__26_2");
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687081);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__23_0_Internal_Currency_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687082);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__23_1_Internal_ValueTuple_2_Int64_List_1_Int32_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687083);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_24_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687084);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_25_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687085);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_26_Internal_Void_SellableDescriber_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687086);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_7_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687087);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_8_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687088);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_29_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687089);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_30_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687090);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_32_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687091);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_33_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687092);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_35_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687093);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_36_Internal_Void_SellableDescriber_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687094);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__RefreshFund_b__26_0_Internal_Product_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687095);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__RefreshFund_b__26_1_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687096);
				DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__RefreshFund_b__26_2_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr, 100687097);
			}

			// Token: 0x0601110D RID: 69901 RVA: 0x003F0A38 File Offset: 0x003EEC38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601110E RID: 69902 RVA: 0x003F0A74 File Offset: 0x003EEC74
			[CallerCount(0)]
			public unsafe DLC5_EllenShopPanel.Currency _OnPanelOpen_b__23_0(DLC5_EllenShopPanel.Currency x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__23_0_Internal_Currency_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC5_EllenShopPanel.Currency(pointer);
			}

			// Token: 0x0601110F RID: 69903 RVA: 0x003F0AC4 File Offset: 0x003EECC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287878, XrefRangeEnd = 287888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<long, List<int>> _OnPanelOpen_b__23_1(DLC5_EllenShopPanel.Currency y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__23_1_Internal_ValueTuple_2_Int64_List_1_Int32_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<long, List<int>>(pointer);
			}

			// Token: 0x06011110 RID: 69904 RVA: 0x003F0B14 File Offset: 0x003EED14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287888, XrefRangeEnd = 287891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<NonTradableObjectBase, int> _ProcessConditionObject_b__25_24<T>(KeyValuePair<T, int> x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.MethodInfoStoreGeneric__ProcessConditionObject_b__25_24_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<NonTradableObjectBase, int>(pointer);
			}

			// Token: 0x06011111 RID: 69905 RVA: 0x003F0B64 File Offset: 0x003EED64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_25(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_25_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011112 RID: 69906 RVA: 0x003F0BA8 File Offset: 0x003EEDA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_26(SellableDescriber describer, Item item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_26_Internal_Void_SellableDescriber_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011113 RID: 69907 RVA: 0x003F0BFC File Offset: 0x003EEDFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_7(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_7_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011114 RID: 69908 RVA: 0x003F0C40 File Offset: 0x003EEE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_8(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_8_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011115 RID: 69909 RVA: 0x003F0C94 File Offset: 0x003EEE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_29(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_29_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011116 RID: 69910 RVA: 0x003F0CD8 File Offset: 0x003EEED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_30(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_30_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011117 RID: 69911 RVA: 0x003F0D2C File Offset: 0x003EEF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_32(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_32_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011118 RID: 69912 RVA: 0x003F0D70 File Offset: 0x003EEF70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_33(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_33_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011119 RID: 69913 RVA: 0x003F0DC4 File Offset: 0x003EEFC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_35(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_35_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601111A RID: 69914 RVA: 0x003F0E08 File Offset: 0x003EF008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__25_36(SellableDescriber describer, Ingredient item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_36_Internal_Void_SellableDescriber_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601111B RID: 69915 RVA: 0x003F0E5C File Offset: 0x003EF05C
			[CallerCount(0)]
			public unsafe Product _RefreshFund_b__26_0(DLC5_EllenShopPanel.Currency x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__RefreshFund_b__26_0_Internal_Product_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x0601111C RID: 69916 RVA: 0x003F0EAC File Offset: 0x003EF0AC
			[CallerCount(0)]
			public unsafe bool _RefreshFund_b__26_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__RefreshFund_b__26_1_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601111D RID: 69917 RVA: 0x003F0F00 File Offset: 0x003EF100
			[CallerCount(0)]
			public unsafe int _RefreshFund_b__26_2(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__RefreshFund_b__26_2_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601111E RID: 69918 RVA: 0x000946E1 File Offset: 0x000928E1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058C3 RID: 22723
			// (get) Token: 0x0601111F RID: 69919 RVA: 0x003F0F54 File Offset: 0x003EF154
			// (set) Token: 0x06011120 RID: 69920 RVA: 0x000946EA File Offset: 0x000928EA
			public unsafe static DLC5_EllenShopIntroductionSubPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopIntroductionSubPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C4 RID: 22724
			// (get) Token: 0x06011121 RID: 69921 RVA: 0x003F0F7C File Offset: 0x003EF17C
			// (set) Token: 0x06011122 RID: 69922 RVA: 0x000946FC File Offset: 0x000928FC
			public unsafe static Func<DLC5_EllenShopPanel.Currency, DLC5_EllenShopPanel.Currency> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.Currency, DLC5_EllenShopPanel.Currency>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C5 RID: 22725
			// (get) Token: 0x06011123 RID: 69923 RVA: 0x003F0FA4 File Offset: 0x003EF1A4
			// (set) Token: 0x06011124 RID: 69924 RVA: 0x0009470E File Offset: 0x0009290E
			public unsafe static Func<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C6 RID: 22726
			// (get) Token: 0x06011125 RID: 69925 RVA: 0x003F0FCC File Offset: 0x003EF1CC
			// (set) Token: 0x06011126 RID: 69926 RVA: 0x00094720 File Offset: 0x00092920
			public unsafe static Action<SellableDescriber> __9__25_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C7 RID: 22727
			// (get) Token: 0x06011127 RID: 69927 RVA: 0x003F0FF4 File Offset: 0x003EF1F4
			// (set) Token: 0x06011128 RID: 69928 RVA: 0x00094732 File Offset: 0x00092932
			public unsafe static Action<SellableDescriber, Item> __9__25_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C8 RID: 22728
			// (get) Token: 0x06011129 RID: 69929 RVA: 0x003F101C File Offset: 0x003EF21C
			// (set) Token: 0x0601112A RID: 69930 RVA: 0x00094744 File Offset: 0x00092944
			public unsafe static Action<SellableDescriber> __9__25_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C9 RID: 22729
			// (get) Token: 0x0601112B RID: 69931 RVA: 0x003F1044 File Offset: 0x003EF244
			// (set) Token: 0x0601112C RID: 69932 RVA: 0x00094756 File Offset: 0x00092956
			public unsafe static Action<SellableDescriber, Sellable> __9__25_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058CA RID: 22730
			// (get) Token: 0x0601112D RID: 69933 RVA: 0x003F106C File Offset: 0x003EF26C
			// (set) Token: 0x0601112E RID: 69934 RVA: 0x00094768 File Offset: 0x00092968
			public unsafe static Action<SellableDescriber> __9__25_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058CB RID: 22731
			// (get) Token: 0x0601112F RID: 69935 RVA: 0x003F1094 File Offset: 0x003EF294
			// (set) Token: 0x06011130 RID: 69936 RVA: 0x0009477A File Offset: 0x0009297A
			public unsafe static Action<SellableDescriber, Sellable> __9__25_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058CC RID: 22732
			// (get) Token: 0x06011131 RID: 69937 RVA: 0x003F10BC File Offset: 0x003EF2BC
			// (set) Token: 0x06011132 RID: 69938 RVA: 0x0009478C File Offset: 0x0009298C
			public unsafe static Action<SellableDescriber> __9__25_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058CD RID: 22733
			// (get) Token: 0x06011133 RID: 69939 RVA: 0x003F10E4 File Offset: 0x003EF2E4
			// (set) Token: 0x06011134 RID: 69940 RVA: 0x0009479E File Offset: 0x0009299E
			public unsafe static Action<SellableDescriber, Sellable> __9__25_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058CE RID: 22734
			// (get) Token: 0x06011135 RID: 69941 RVA: 0x003F110C File Offset: 0x003EF30C
			// (set) Token: 0x06011136 RID: 69942 RVA: 0x000947B0 File Offset: 0x000929B0
			public unsafe static Action<SellableDescriber> __9__25_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058CF RID: 22735
			// (get) Token: 0x06011137 RID: 69943 RVA: 0x003F1134 File Offset: 0x003EF334
			// (set) Token: 0x06011138 RID: 69944 RVA: 0x000947C2 File Offset: 0x000929C2
			public unsafe static Action<SellableDescriber, Ingredient> __9__25_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__25_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D0 RID: 22736
			// (get) Token: 0x06011139 RID: 69945 RVA: 0x003F115C File Offset: 0x003EF35C
			// (set) Token: 0x0601113A RID: 69946 RVA: 0x000947D4 File Offset: 0x000929D4
			public unsafe static Func<DLC5_EllenShopPanel.Currency, Product> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_EllenShopPanel.Currency, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D1 RID: 22737
			// (get) Token: 0x0601113B RID: 69947 RVA: 0x003F1184 File Offset: 0x003EF384
			// (set) Token: 0x0601113C RID: 69948 RVA: 0x000947E6 File Offset: 0x000929E6
			public unsafe static Func<Product, bool> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D2 RID: 22738
			// (get) Token: 0x0601113D RID: 69949 RVA: 0x003F11AC File Offset: 0x003EF3AC
			// (set) Token: 0x0601113E RID: 69950 RVA: 0x000947F8 File Offset: 0x000929F8
			public unsafe static Func<Product, int> __9__26_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_EllenShopIntroductionSubPanel.__c.NativeFieldInfoPtr___9__26_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ACA9 RID: 44201
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400ACAA RID: 44202
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x0400ACAB RID: 44203
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x0400ACAC RID: 44204
			private static readonly IntPtr NativeFieldInfoPtr___9__25_25;

			// Token: 0x0400ACAD RID: 44205
			private static readonly IntPtr NativeFieldInfoPtr___9__25_26;

			// Token: 0x0400ACAE RID: 44206
			private static readonly IntPtr NativeFieldInfoPtr___9__25_7;

			// Token: 0x0400ACAF RID: 44207
			private static readonly IntPtr NativeFieldInfoPtr___9__25_8;

			// Token: 0x0400ACB0 RID: 44208
			private static readonly IntPtr NativeFieldInfoPtr___9__25_29;

			// Token: 0x0400ACB1 RID: 44209
			private static readonly IntPtr NativeFieldInfoPtr___9__25_30;

			// Token: 0x0400ACB2 RID: 44210
			private static readonly IntPtr NativeFieldInfoPtr___9__25_32;

			// Token: 0x0400ACB3 RID: 44211
			private static readonly IntPtr NativeFieldInfoPtr___9__25_33;

			// Token: 0x0400ACB4 RID: 44212
			private static readonly IntPtr NativeFieldInfoPtr___9__25_35;

			// Token: 0x0400ACB5 RID: 44213
			private static readonly IntPtr NativeFieldInfoPtr___9__25_36;

			// Token: 0x0400ACB6 RID: 44214
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x0400ACB7 RID: 44215
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x0400ACB8 RID: 44216
			private static readonly IntPtr NativeFieldInfoPtr___9__26_2;

			// Token: 0x0400ACB9 RID: 44217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ACBA RID: 44218
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__23_0_Internal_Currency_Currency_0;

			// Token: 0x0400ACBB RID: 44219
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__23_1_Internal_ValueTuple_2_Int64_List_1_Int32_Currency_0;

			// Token: 0x0400ACBC RID: 44220
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_24_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0;

			// Token: 0x0400ACBD RID: 44221
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_25_Internal_Void_SellableDescriber_0;

			// Token: 0x0400ACBE RID: 44222
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_26_Internal_Void_SellableDescriber_Item_0;

			// Token: 0x0400ACBF RID: 44223
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_7_Internal_Void_SellableDescriber_0;

			// Token: 0x0400ACC0 RID: 44224
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_8_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400ACC1 RID: 44225
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_29_Internal_Void_SellableDescriber_0;

			// Token: 0x0400ACC2 RID: 44226
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_30_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400ACC3 RID: 44227
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_32_Internal_Void_SellableDescriber_0;

			// Token: 0x0400ACC4 RID: 44228
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_33_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400ACC5 RID: 44229
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_35_Internal_Void_SellableDescriber_0;

			// Token: 0x0400ACC6 RID: 44230
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__25_36_Internal_Void_SellableDescriber_Ingredient_0;

			// Token: 0x0400ACC7 RID: 44231
			private static readonly IntPtr NativeMethodInfoPtr__RefreshFund_b__26_0_Internal_Product_Currency_0;

			// Token: 0x0400ACC8 RID: 44232
			private static readonly IntPtr NativeMethodInfoPtr__RefreshFund_b__26_1_Internal_Boolean_Product_0;

			// Token: 0x0400ACC9 RID: 44233
			private static readonly IntPtr NativeMethodInfoPtr__RefreshFund_b__26_2_Internal_Int32_Product_0;

			// Token: 0x020010D6 RID: 4310
			private sealed class MethodInfoStoreGeneric__ProcessConditionObject_b__25_24_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400B8FF RID: 47359
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC5_EllenShopIntroductionSubPanel.__c.NativeMethodInfoPtr__ProcessConditionObject_b__25_24_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x02000F56 RID: 3926
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopIntroductionSubPanel+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0601113F RID: 69951 RVA: 0x003F11D4 File Offset: 0x003EF3D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "product");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_staticData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "staticData");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_SetTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "SetTextCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_thisCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "thisCluster");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_interactableBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "interactableBase");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_checkConditionFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "checkConditionFunc");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "tags");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_targetTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "targetTag");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___9__28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, "<>9__28");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687098);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687099);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687100);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687101);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__23_Internal_Void_SubmissionPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687102);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_T_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687103);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__5_Internal_Boolean_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687104);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__27_Internal_IEnumerable_1_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687105);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__28_Internal_Boolean_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687106);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__6_Internal_Boolean_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687107);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__9_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687108);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__10_Internal_Boolean_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687109);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__11_Internal_Boolean_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687110);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__12_Internal_Boolean_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687111);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__13_Internal_Boolean_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687112);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687113);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__31_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687114);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__34_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687115);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__37_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr, 100687116);
			}

			// Token: 0x06011140 RID: 69952 RVA: 0x003F1444 File Offset: 0x003EF644
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011141 RID: 69953 RVA: 0x003F1480 File Offset: 0x003EF680
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287945, RefRangeEnd = 287947, XrefRangeStart = 287891, XrefRangeEnd = 287945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011142 RID: 69954 RVA: 0x003F14B4 File Offset: 0x003EF6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287947, XrefRangeEnd = 287952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011143 RID: 69955 RVA: 0x003F14E8 File Offset: 0x003EF6E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287986, RefRangeEnd = 287988, XrefRangeStart = 287952, XrefRangeEnd = 287986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_0<T>(Action<SellableDescriber> describerModeChangeCallback, Action<SellableDescriber, T> describeObjectCallback, Func<IEnumerable<KeyValuePair<T, int>>> getElementCallback, Action<IEnumerable<int>, bool> storageInCallback, Action<int, bool> storageOutCallback, Func<int, T> idToObjectCallback, Func<int, int> getObjectAmountCallback) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describerModeChangeCallback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getElementCallback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageInCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageOutCallback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToObjectCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getObjectAmountCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.MethodInfoStoreGeneric_Method_Internal_Void_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011144 RID: 69956 RVA: 0x003F159C File Offset: 0x003EF79C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287988, XrefRangeEnd = 287990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__23<T>(SubmissionPanel _) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.MethodInfoStoreGeneric__ProcessConditionObject_b__23_Internal_Void_SubmissionPanel_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011145 RID: 69957 RVA: 0x003F15E0 File Offset: 0x003EF7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287990, XrefRangeEnd = 287991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_KeyValuePair_2_T_Int32_PDM_0<T>(KeyValuePair<T, int> x) where T : TradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.MethodInfoStoreGeneric_Method_Internal_Boolean_KeyValuePair_2_T_Int32_PDM_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011146 RID: 69958 RVA: 0x003F1634 File Offset: 0x003EF834
			[CallerCount(0)]
			public unsafe bool _ProcessConditionObject_b__5(TradableObjectBase x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__5_Internal_Boolean_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011147 RID: 69959 RVA: 0x003F1690 File Offset: 0x003EF890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287991, XrefRangeEnd = 288003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Item, int>> _ProcessConditionObject_b__27()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__27_Internal_IEnumerable_1_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Item, int>>>(intPtr3) : null;
			}

			// Token: 0x06011148 RID: 69960 RVA: 0x003F16D0 File Offset: 0x003EF8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288003, XrefRangeEnd = 288004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ProcessConditionObject_b__28(KeyValuePair<Item, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__28_Internal_Boolean_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011149 RID: 69961 RVA: 0x003F1724 File Offset: 0x003EF924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288004, XrefRangeEnd = 288017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ProcessConditionObject_b__6(TradableObjectBase x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__6_Internal_Boolean_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601114A RID: 69962 RVA: 0x003F1780 File Offset: 0x003EF980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288017, XrefRangeEnd = 288028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _ProcessConditionObject_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__9_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x0601114B RID: 69963 RVA: 0x003F17C0 File Offset: 0x003EF9C0
			[CallerCount(0)]
			public unsafe bool _ProcessConditionObject_b__10(TradableObjectBase x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__10_Internal_Boolean_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601114C RID: 69964 RVA: 0x003F181C File Offset: 0x003EFA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288028, XrefRangeEnd = 288032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ProcessConditionObject_b__11(TradableObjectBase x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__11_Internal_Boolean_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601114D RID: 69965 RVA: 0x003F1878 File Offset: 0x003EFA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288032, XrefRangeEnd = 288038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ProcessConditionObject_b__12(TradableObjectBase x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__12_Internal_Boolean_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601114E RID: 69966 RVA: 0x003F18D4 File Offset: 0x003EFAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288038, XrefRangeEnd = 288042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ProcessConditionObject_b__13(TradableObjectBase x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__13_Internal_Boolean_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601114F RID: 69967 RVA: 0x003F1930 File Offset: 0x003EFB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288042, XrefRangeEnd = 288212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011150 RID: 69968 RVA: 0x003F1964 File Offset: 0x003EFB64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288212, XrefRangeEnd = 288223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _ProcessConditionObject_b__31()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__31_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06011151 RID: 69969 RVA: 0x003F19A4 File Offset: 0x003EFBA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288223, XrefRangeEnd = 288234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _ProcessConditionObject_b__34()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__34_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06011152 RID: 69970 RVA: 0x003F19E4 File Offset: 0x003EFBE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288234, XrefRangeEnd = 288245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Ingredient, int>> _ProcessConditionObject_b__37()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__37_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
			}

			// Token: 0x06011153 RID: 69971 RVA: 0x0009480A File Offset: 0x00092A0A
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058D3 RID: 22739
			// (get) Token: 0x06011154 RID: 69972 RVA: 0x003F1A24 File Offset: 0x003EFC24
			// (set) Token: 0x06011155 RID: 69973 RVA: 0x00094813 File Offset: 0x00092A13
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058D4 RID: 22740
			// (get) Token: 0x06011156 RID: 69974 RVA: 0x003F1A54 File Offset: 0x003EFC54
			// (set) Token: 0x06011157 RID: 69975 RVA: 0x00094841 File Offset: 0x00092A41
			public KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> staticData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_staticData);
					return new KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_staticData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058D5 RID: 22741
			// (get) Token: 0x06011158 RID: 69976 RVA: 0x003F1A84 File Offset: 0x003EFC84
			// (set) Token: 0x06011159 RID: 69977 RVA: 0x0009486F File Offset: 0x00092A6F
			public unsafe DLC5_EllenShopIntroductionSubPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopIntroductionSubPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D6 RID: 22742
			// (get) Token: 0x0601115A RID: 69978 RVA: 0x003F1AB4 File Offset: 0x003EFCB4
			// (set) Token: 0x0601115B RID: 69979 RVA: 0x0009488E File Offset: 0x00092A8E
			public unsafe Action<string> SetTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_SetTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_SetTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D7 RID: 22743
			// (get) Token: 0x0601115C RID: 69980 RVA: 0x003F1AE4 File Offset: 0x003EFCE4
			// (set) Token: 0x0601115D RID: 69981 RVA: 0x000948AD File Offset: 0x00092AAD
			public unsafe UIElementCluster thisCluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_thisCluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_thisCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D8 RID: 22744
			// (get) Token: 0x0601115E RID: 69982 RVA: 0x003F1B14 File Offset: 0x003EFD14
			// (set) Token: 0x0601115F RID: 69983 RVA: 0x000948CC File Offset: 0x00092ACC
			public unsafe UIButtonSimple interactableBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_interactableBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_interactableBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058D9 RID: 22745
			// (get) Token: 0x06011160 RID: 69984 RVA: 0x003F1B44 File Offset: 0x003EFD44
			// (set) Token: 0x06011161 RID: 69985 RVA: 0x000948EB File Offset: 0x00092AEB
			public unsafe Func<TradableObjectBase, int, bool> checkConditionFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_checkConditionFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TradableObjectBase, int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_checkConditionFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058DA RID: 22746
			// (get) Token: 0x06011162 RID: 69986 RVA: 0x003F1B74 File Offset: 0x003EFD74
			// (set) Token: 0x06011163 RID: 69987 RVA: 0x0009490A File Offset: 0x00092B0A
			public unsafe Il2CppStructArray<int> tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_tags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058DB RID: 22747
			// (get) Token: 0x06011164 RID: 69988 RVA: 0x003F1BA4 File Offset: 0x003EFDA4
			// (set) Token: 0x06011165 RID: 69989 RVA: 0x00094929 File Offset: 0x00092B29
			public unsafe int targetTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_targetTag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_targetTag)) = value;
				}
			}

			// Token: 0x170058DC RID: 22748
			// (get) Token: 0x06011166 RID: 69990 RVA: 0x003F1BCC File Offset: 0x003EFDCC
			// (set) Token: 0x06011167 RID: 69991 RVA: 0x00094944 File Offset: 0x00092B44
			public unsafe Func<KeyValuePair<Item, int>, bool> __9__28
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___9__28);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___9__28), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ACCA RID: 44234
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400ACCB RID: 44235
			private static readonly IntPtr NativeFieldInfoPtr_staticData;

			// Token: 0x0400ACCC RID: 44236
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ACCD RID: 44237
			private static readonly IntPtr NativeFieldInfoPtr_SetTextCallback;

			// Token: 0x0400ACCE RID: 44238
			private static readonly IntPtr NativeFieldInfoPtr_thisCluster;

			// Token: 0x0400ACCF RID: 44239
			private static readonly IntPtr NativeFieldInfoPtr_interactableBase;

			// Token: 0x0400ACD0 RID: 44240
			private static readonly IntPtr NativeFieldInfoPtr_checkConditionFunc;

			// Token: 0x0400ACD1 RID: 44241
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x0400ACD2 RID: 44242
			private static readonly IntPtr NativeFieldInfoPtr_targetTag;

			// Token: 0x0400ACD3 RID: 44243
			private static readonly IntPtr NativeFieldInfoPtr___9__28;

			// Token: 0x0400ACD4 RID: 44244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ACD5 RID: 44245
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x0400ACD6 RID: 44246
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400ACD7 RID: 44247
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_0;

			// Token: 0x0400ACD8 RID: 44248
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__23_Internal_Void_SubmissionPanel_0;

			// Token: 0x0400ACD9 RID: 44249
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_T_Int32_PDM_0;

			// Token: 0x0400ACDA RID: 44250
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__5_Internal_Boolean_TradableObjectBase_Int32_0;

			// Token: 0x0400ACDB RID: 44251
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__27_Internal_IEnumerable_1_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400ACDC RID: 44252
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__28_Internal_Boolean_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400ACDD RID: 44253
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__6_Internal_Boolean_TradableObjectBase_Int32_0;

			// Token: 0x0400ACDE RID: 44254
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__9_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400ACDF RID: 44255
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__10_Internal_Boolean_TradableObjectBase_Int32_0;

			// Token: 0x0400ACE0 RID: 44256
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__11_Internal_Boolean_TradableObjectBase_Int32_0;

			// Token: 0x0400ACE1 RID: 44257
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__12_Internal_Boolean_TradableObjectBase_Int32_0;

			// Token: 0x0400ACE2 RID: 44258
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__13_Internal_Boolean_TradableObjectBase_Int32_0;

			// Token: 0x0400ACE3 RID: 44259
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x0400ACE4 RID: 44260
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__31_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400ACE5 RID: 44261
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__34_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400ACE6 RID: 44262
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__37_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x020010D7 RID: 4311
			private sealed class MethodInfoStoreGeneric_Method_Internal_Void_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_0<T>
			{
				// Token: 0x0400B900 RID: 47360
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_0, Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010D8 RID: 4312
			private sealed class MethodInfoStoreGeneric__ProcessConditionObject_b__23_Internal_Void_SubmissionPanel_0<T>
			{
				// Token: 0x0400B901 RID: 47361
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessConditionObject_b__23_Internal_Void_SubmissionPanel_0, Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010D9 RID: 4313
			private sealed class MethodInfoStoreGeneric_Method_Internal_Boolean_KeyValuePair_2_T_Int32_PDM_0<T>
			{
				// Token: 0x0400B902 RID: 47362
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_T_Int32_PDM_0, Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x02000F57 RID: 3927
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopIntroductionSubPanel+<>c__DisplayClass25_1")]
		public sealed class __c__DisplayClass25_1 : Il2CppSystem.Object
		{
			// Token: 0x06011168 RID: 69992 RVA: 0x003F1BFC File Offset: 0x003EFDFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_1()
			{
				Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "<>c__DisplayClass25_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, "textColor");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_checkStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, "checkStatus");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, "description");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, 100687117);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ProcessConditionObject_b__15_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, 100687118);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ProcessConditionObject_b__16_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, 100687119);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ProcessConditionObject_b__17_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr, 100687120);
			}

			// Token: 0x06011169 RID: 69993 RVA: 0x003F1CB4 File Offset: 0x003EFEB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601116A RID: 69994 RVA: 0x003F1CF0 File Offset: 0x003EFEF0
			[CallerCount(0)]
			public unsafe void _ProcessConditionObject_b__15(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ProcessConditionObject_b__15_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601116B RID: 69995 RVA: 0x003F1D34 File Offset: 0x003EFF34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288245, XrefRangeEnd = 288246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__16(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ProcessConditionObject_b__16_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601116C RID: 69996 RVA: 0x003F1D78 File Offset: 0x003EFF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288246, XrefRangeEnd = 288247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__17(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ProcessConditionObject_b__17_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601116D RID: 69997 RVA: 0x00094963 File Offset: 0x00092B63
			public __c__DisplayClass25_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058DD RID: 22749
			// (get) Token: 0x0601116E RID: 69998 RVA: 0x003F1DBC File Offset: 0x003EFFBC
			// (set) Token: 0x0601116F RID: 69999 RVA: 0x0009496C File Offset: 0x00092B6C
			public unsafe Color32 textColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_textColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_textColor)) = value;
				}
			}

			// Token: 0x170058DE RID: 22750
			// (get) Token: 0x06011170 RID: 70000 RVA: 0x003F1DE4 File Offset: 0x003EFFE4
			// (set) Token: 0x06011171 RID: 70001 RVA: 0x00094987 File Offset: 0x00092B87
			public unsafe bool checkStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_checkStatus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_checkStatus)) = value;
				}
			}

			// Token: 0x170058DF RID: 22751
			// (get) Token: 0x06011172 RID: 70002 RVA: 0x003F1E0C File Offset: 0x003F000C
			// (set) Token: 0x06011173 RID: 70003 RVA: 0x000949A2 File Offset: 0x00092BA2
			public unsafe string description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400ACE7 RID: 44263
			private static readonly IntPtr NativeFieldInfoPtr_textColor;

			// Token: 0x0400ACE8 RID: 44264
			private static readonly IntPtr NativeFieldInfoPtr_checkStatus;

			// Token: 0x0400ACE9 RID: 44265
			private static readonly IntPtr NativeFieldInfoPtr_description;

			// Token: 0x0400ACEA RID: 44266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ACEB RID: 44267
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__15_Internal_Void_Image_0;

			// Token: 0x0400ACEC RID: 44268
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__16_Internal_Void_Image_0;

			// Token: 0x0400ACED RID: 44269
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__17_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000F58 RID: 3928
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopIntroductionSubPanel+<>c__DisplayClass25_2`1")]
		public sealed class __c__DisplayClass25_2<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06011174 RID: 70004 RVA: 0x003F1E34 File Offset: 0x003F0034
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_2()
			{
				Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "<>c__DisplayClass25_2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_storageInCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "storageInCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_describerModeChangeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "describerModeChangeCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_describeObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "describeObjectCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_getElementCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "getElementCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_storageOutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "storageOutCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_idToObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "idToObjectCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_getObjectAmountCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "getObjectAmountCallback");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, 100687121);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ProcessConditionObject_b__18_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, 100687122);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, 100687123);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ProcessConditionObject_b__21_Internal_Void_SellableDescriber_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, 100687124);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ProcessConditionObject_b__22_Internal_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr, 100687125);
			}

			// Token: 0x06011175 RID: 70005 RVA: 0x003F1FA0 File Offset: 0x003F01A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011176 RID: 70006 RVA: 0x003F1FDC File Offset: 0x003F01DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288247, XrefRangeEnd = 288249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ProcessConditionObject_b__18_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011177 RID: 70007 RVA: 0x003F2010 File Offset: 0x003F0210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288249, XrefRangeEnd = 288288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011178 RID: 70008 RVA: 0x003F2044 File Offset: 0x003F0244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288288, XrefRangeEnd = 288293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__21(SellableDescriber sellableDescriber, NonTradableObjectBase obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellableDescriber);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ProcessConditionObject_b__21_Internal_Void_SellableDescriber_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011179 RID: 70009 RVA: 0x003F2098 File Offset: 0x003F0298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288293, XrefRangeEnd = 288300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<NonTradableObjectBase, int>> _ProcessConditionObject_b__22()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeMethodInfoPtr__ProcessConditionObject_b__22_Internal_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>>(intPtr3) : null;
			}

			// Token: 0x0601117A RID: 70010 RVA: 0x000949C1 File Offset: 0x00092BC1
			public __c__DisplayClass25_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058E0 RID: 22752
			// (get) Token: 0x0601117B RID: 70011 RVA: 0x003F20D8 File Offset: 0x003F02D8
			// (set) Token: 0x0601117C RID: 70012 RVA: 0x000949CA File Offset: 0x00092BCA
			public unsafe Action<IEnumerable<int>, bool> storageInCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_storageInCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_storageInCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E1 RID: 22753
			// (get) Token: 0x0601117D RID: 70013 RVA: 0x003F2108 File Offset: 0x003F0308
			// (set) Token: 0x0601117E RID: 70014 RVA: 0x000949E9 File Offset: 0x00092BE9
			public unsafe Action<SellableDescriber> describerModeChangeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_describerModeChangeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_describerModeChangeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E2 RID: 22754
			// (get) Token: 0x0601117F RID: 70015 RVA: 0x003F2138 File Offset: 0x003F0338
			// (set) Token: 0x06011180 RID: 70016 RVA: 0x00094A08 File Offset: 0x00092C08
			public unsafe Action<SellableDescriber, T> describeObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_describeObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_describeObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E3 RID: 22755
			// (get) Token: 0x06011181 RID: 70017 RVA: 0x003F2168 File Offset: 0x003F0368
			// (set) Token: 0x06011182 RID: 70018 RVA: 0x00094A27 File Offset: 0x00092C27
			public unsafe Func<IEnumerable<KeyValuePair<T, int>>> getElementCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_getElementCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<KeyValuePair<T, int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_getElementCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E4 RID: 22756
			// (get) Token: 0x06011183 RID: 70019 RVA: 0x003F2198 File Offset: 0x003F0398
			// (set) Token: 0x06011184 RID: 70020 RVA: 0x00094A46 File Offset: 0x00092C46
			public unsafe Action<int, bool> storageOutCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_storageOutCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_storageOutCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E5 RID: 22757
			// (get) Token: 0x06011185 RID: 70021 RVA: 0x003F21C8 File Offset: 0x003F03C8
			// (set) Token: 0x06011186 RID: 70022 RVA: 0x00094A65 File Offset: 0x00092C65
			public unsafe Func<int, T> idToObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_idToObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_idToObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E6 RID: 22758
			// (get) Token: 0x06011187 RID: 70023 RVA: 0x003F21F8 File Offset: 0x003F03F8
			// (set) Token: 0x06011188 RID: 70024 RVA: 0x00094A84 File Offset: 0x00092C84
			public unsafe Func<int, int> getObjectAmountCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_getObjectAmountCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_getObjectAmountCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058E7 RID: 22759
			// (get) Token: 0x06011189 RID: 70025 RVA: 0x003F2228 File Offset: 0x003F0428
			// (set) Token: 0x0601118A RID: 70026 RVA: 0x00094AA3 File Offset: 0x00092CA3
			public unsafe DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0 field_Public___c__DisplayClass25_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_2<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ACEE RID: 44270
			private static readonly IntPtr NativeFieldInfoPtr_storageInCallback;

			// Token: 0x0400ACEF RID: 44271
			private static readonly IntPtr NativeFieldInfoPtr_describerModeChangeCallback;

			// Token: 0x0400ACF0 RID: 44272
			private static readonly IntPtr NativeFieldInfoPtr_describeObjectCallback;

			// Token: 0x0400ACF1 RID: 44273
			private static readonly IntPtr NativeFieldInfoPtr_getElementCallback;

			// Token: 0x0400ACF2 RID: 44274
			private static readonly IntPtr NativeFieldInfoPtr_storageOutCallback;

			// Token: 0x0400ACF3 RID: 44275
			private static readonly IntPtr NativeFieldInfoPtr_idToObjectCallback;

			// Token: 0x0400ACF4 RID: 44276
			private static readonly IntPtr NativeFieldInfoPtr_getObjectAmountCallback;

			// Token: 0x0400ACF5 RID: 44277
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0;

			// Token: 0x0400ACF6 RID: 44278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ACF7 RID: 44279
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__18_Internal_Void_0;

			// Token: 0x0400ACF8 RID: 44280
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400ACF9 RID: 44281
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__21_Internal_Void_SellableDescriber_NonTradableObjectBase_0;

			// Token: 0x0400ACFA RID: 44282
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__22_Internal_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_0;
		}

		// Token: 0x02000F59 RID: 3929
		[ObfuscatedName("Common.UI.DLC5_EllenShopPanel.DLC5_EllenShopIntroductionSubPanel+<>c__DisplayClass25_3`1")]
		public sealed class __c__DisplayClass25_3<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x0601118B RID: 70027 RVA: 0x003F2258 File Offset: 0x003F0458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_3()
			{
				Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel>.NativeClassPtr, "<>c__DisplayClass25_3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>>.NativeClassPtr);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>>.NativeClassPtr, "instance");
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>>.NativeClassPtr, 100687126);
				DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeMethodInfoPtr__ProcessConditionObject_b__20_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>>.NativeClassPtr, 100687127);
			}

			// Token: 0x0601118C RID: 70028 RVA: 0x003F22FC File Offset: 0x003F04FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601118D RID: 70029 RVA: 0x003F2338 File Offset: 0x003F0538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessConditionObject_b__20(string t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeMethodInfoPtr__ProcessConditionObject_b__20_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601118E RID: 70030 RVA: 0x00094AC2 File Offset: 0x00092CC2
			public __c__DisplayClass25_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058E8 RID: 22760
			// (get) Token: 0x0601118F RID: 70031 RVA: 0x003F237C File Offset: 0x003F057C
			// (set) Token: 0x06011190 RID: 70032 RVA: 0x00094ACB File Offset: 0x00092CCB
			public unsafe SubmissionPanel instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_EllenShopIntroductionSubPanel.__c__DisplayClass25_3<T>.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ACFB RID: 44283
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x0400ACFC RID: 44284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ACFD RID: 44285
			private static readonly IntPtr NativeMethodInfoPtr__ProcessConditionObject_b__20_Internal_Void_String_0;
		}
	}
}
