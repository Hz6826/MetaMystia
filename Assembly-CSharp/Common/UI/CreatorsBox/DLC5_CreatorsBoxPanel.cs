using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Core.UILogicalGroup;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x020003D0 RID: 976
	public class DLC5_CreatorsBoxPanel : UIPanelParam<DLC5_CreatorsBoxPanel.OpenContext, DLC5_CreatorsBoxPanel.OpenContext>
	{
		// Token: 0x0600743A RID: 29754 RVA: 0x00221BE0 File Offset: 0x0021FDE0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_CreatorsBoxPanel()
		{
			Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.CreatorsBox", "DLC5_CreatorsBoxPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr);
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_RoundTotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_RoundTotalTime");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SkipMax");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SkipDefault");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SkipMin");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SkipStep");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_FastForwardAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_FastForwardAmount");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_Element");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SecondaryElement");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_InBetweenElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_InBetweenElement");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_Grid");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SecondaryGrid");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_ProgressIndicatorComponent");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryProgressIndicatorComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SecondaryProgressIndicatorComponent");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_AddExtraTimeBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_AddExtraTimeBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_RemoveExtraTimeBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_RemoveExtraTimeBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_TrimExtraTimeBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_TrimExtraTimeBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleMoreBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_ScaleMoreBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleLessBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_ScaleLessBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleResetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_ScaleResetBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ResetAllBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_ResetAllBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_LoadPresetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_LoadPresetBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SavePresetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SavePresetBtn");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_ExitButton");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SpecialGuestSelectionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SpecialGuestSelectionPanel");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_PresetPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_PresetPanel");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_CurrentList");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_CurrentView");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_AvailableSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_AvailableSpecialGuests");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_Pool");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_LogicalGroupT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_LogicalGroupT");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryLogicalGroupT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SecondaryLogicalGroupT");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_SkipAmount");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentSelectedCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_CurrentSelectedCell");
			DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_FocusingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "m_FocusingType");
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687189);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_AddExtraTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687190);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_TrimExtraTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687191);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687192);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_MountDataAndRefreshView_Private_Void_CreatorBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687193);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_SortSpecialGuestList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687194);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateView_Private_ValueTuple_2_Int32_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687195);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_CreateReturnValue_Private_CreatorBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687196);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687197);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateAddTimeButton_Private_Void_UIButtonBase_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687198);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateScaleButton_Private_ValueTuple_3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687199);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateLoadButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687200);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_ProcessScaleButtonReselection_Private_Void_UIButtonBase_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687201);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687202);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687203);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_32_Private_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687204);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_0_Private_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687205);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687206);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687207);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687208);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687209);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687210);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_6_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687211);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_7_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687212);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687213);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687214);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687215);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_11_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687216);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_12_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687217);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_13_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687218);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_14_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687219);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_15_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687220);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_16_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687221);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_17_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687222);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_18_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687223);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_19_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687224);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_20_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687225);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_21_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687226);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_22_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687227);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_23_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687228);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687229);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_Cell_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687230);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687231);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687232);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687233);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687234);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687235);
			DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_FocusingType_Int32_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, 100687236);
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00222278 File Offset: 0x00220478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289518, XrefRangeEnd = 289730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x002222B4 File Offset: 0x002204B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289740, RefRangeEnd = 289742, XrefRangeStart = 289730, XrefRangeEnd = 289740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExtraTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_AddExtraTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x002222E8 File Offset: 0x002204E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289761, RefRangeEnd = 289764, XrefRangeStart = 289742, XrefRangeEnd = 289761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimExtraTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_TrimExtraTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x0022231C File Offset: 0x0022051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289764, XrefRangeEnd = 289777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_CreatorsBoxPanel.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00222370 File Offset: 0x00220570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289907, RefRangeEnd = 289909, XrefRangeStart = 289777, XrefRangeEnd = 289907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MountDataAndRefreshView(CreatorBoxData creatorBoxData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(creatorBoxData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_MountDataAndRefreshView_Private_Void_CreatorBoxData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x002223B8 File Offset: 0x002205B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 289928, RefRangeEnd = 289933, XrefRangeStart = 289909, XrefRangeEnd = 289928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortSpecialGuestList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_SortSpecialGuestList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x002223EC File Offset: 0x002205EC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 289972, RefRangeEnd = 289982, XrefRangeStart = 289933, XrefRangeEnd = 289972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, DLC5_CreatorsBoxPanel.Cell> UpdateView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateView_Private_ValueTuple_2_Int32_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<int, DLC5_CreatorsBoxPanel.Cell>(pointer);
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x00222424 File Offset: 0x00220624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290035, RefRangeEnd = 290037, XrefRangeStart = 289982, XrefRangeEnd = 290035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorBoxData CreateReturnValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_CreateReturnValue_Private_CreatorBoxData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CreatorBoxData(pointer);
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x0022245C File Offset: 0x0022065C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290037, XrefRangeEnd = 290052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose(DLC5_CreatorsBoxPanel.OpenContext closeParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(closeParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x002224B0 File Offset: 0x002206B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290071, RefRangeEnd = 290076, XrefRangeStart = 290052, XrefRangeEnd = 290071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAddTimeButton(UIButtonBase currentButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentButton);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateAddTimeButton_Private_Void_UIButtonBase_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x002224F4 File Offset: 0x002206F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290076, XrefRangeEnd = 290082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, bool, bool> UpdateScaleButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateScaleButton_Private_ValueTuple_3_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<bool, bool, bool>(pointer);
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x0022252C File Offset: 0x0022072C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290103, RefRangeEnd = 290105, XrefRangeStart = 290082, XrefRangeEnd = 290103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLoadButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_UpdateLoadButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x00222560 File Offset: 0x00220760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290115, RefRangeEnd = 290118, XrefRangeStart = 290105, XrefRangeEnd = 290115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessScaleButtonReselection(UIButtonBase currentButton, bool canScaleMore, bool canScaleLess, bool canScaleReset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentButton);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canScaleMore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canScaleLess;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canScaleReset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_ProcessScaleButtonReselection_Private_Void_UIButtonBase_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x002225CC File Offset: 0x002207CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290118, XrefRangeEnd = 290149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00222608 File Offset: 0x00220808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290149, XrefRangeEnd = 290212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_CreatorsBoxPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x00222644 File Offset: 0x00220844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290212, XrefRangeEnd = 290229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_32(DLC5_CreatorsBoxPanel.Cell cell, CreatorsBoxTimelineElement _, UIButtonSimple btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_32_Private_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x002226AC File Offset: 0x002208AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290229, XrefRangeEnd = 290241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_0(DLC5_CreatorsBoxPanel.Cell cell, CreatorsBoxTimelineElement _, UIButtonSimple btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_0_Private_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x00222714 File Offset: 0x00220914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290241, XrefRangeEnd = 290248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x00222748 File Offset: 0x00220948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290248, XrefRangeEnd = 290251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x0022277C File Offset: 0x0022097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290251, XrefRangeEnd = 290271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x002227B0 File Offset: 0x002209B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290271, XrefRangeEnd = 290274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x002227E4 File Offset: 0x002209E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290274, XrefRangeEnd = 290289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x00222818 File Offset: 0x00220A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290289, XrefRangeEnd = 290294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid _OnPanelInitialize_b__36_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_6_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00222854 File Offset: 0x00220A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290294, XrefRangeEnd = 290299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid _OnPanelInitialize_b__36_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_7_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00222890 File Offset: 0x00220A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290299, XrefRangeEnd = 290300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x002228C4 File Offset: 0x00220AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290300, XrefRangeEnd = 290301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x002228F8 File Offset: 0x00220AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290301, XrefRangeEnd = 290302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x0022292C File Offset: 0x00220B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290302, XrefRangeEnd = 290317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_11(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_11_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x00222974 File Offset: 0x00220B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290317, XrefRangeEnd = 290326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_12(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_12_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x002229BC File Offset: 0x00220BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290326, XrefRangeEnd = 290335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_13(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_13_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x00222A04 File Offset: 0x00220C04
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_14()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_14_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x00222A38 File Offset: 0x00220C38
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_15()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_15_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x00222A6C File Offset: 0x00220C6C
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_16_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x00222AA0 File Offset: 0x00220CA0
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_17()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_17_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x00222AD4 File Offset: 0x00220CD4
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_18()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_18_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x00222B08 File Offset: 0x00220D08
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_19()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_19_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x00222B3C File Offset: 0x00220D3C
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_20()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_20_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00222B70 File Offset: 0x00220D70
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_21()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_21_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x00222BA4 File Offset: 0x00220DA4
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_22()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_22_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x00222BD8 File Offset: 0x00220DD8
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__36_23()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_23_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x00222C0C File Offset: 0x00220E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290335, XrefRangeEnd = 290336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0(DLC5_CreatorsBoxPanel.Cell cell, CreatorsBoxTimelineElement element, UIButtonSimple _)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x00222C68 File Offset: 0x00220E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290355, RefRangeEnd = 290357, XrefRangeStart = 290336, XrefRangeEnd = 290355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Cell_UIButtonSimple_0(DLC5_CreatorsBoxPanel.Cell cell, UIButtonSimple btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_Cell_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x00222CBC File Offset: 0x00220EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290357, XrefRangeEnd = 290368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0(AdpUISystemUtils.BorderElementType type, int column, int row, Nullable<ValueTuple<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00222D30 File Offset: 0x00220F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290377, RefRangeEnd = 290378, XrefRangeStart = 290368, XrefRangeEnd = 290377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_UIButtonBase_0(UIButtonBase button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x00222D74 File Offset: 0x00220F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290387, RefRangeEnd = 290389, XrefRangeStart = 290378, XrefRangeEnd = 290387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_UIButtonBase_1(UIButtonBase button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00222DB8 File Offset: 0x00220FB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290398, RefRangeEnd = 290401, XrefRangeStart = 290389, XrefRangeEnd = 290398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_UIButtonBase_2(UIButtonBase button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x00222DFC File Offset: 0x00220FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290401, XrefRangeEnd = 290403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x00222E30 File Offset: 0x00221030
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290430, RefRangeEnd = 290435, XrefRangeStart = 290403, XrefRangeEnd = 290430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_FocusingType_Int32_Cell_0(DLC5_CreatorsBoxPanel.FocusingType focusingType, int bestViewIndex, DLC5_CreatorsBoxPanel.Cell bestListCell)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref focusingType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bestViewIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bestListCell);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.NativeMethodInfoPtr_Method_Private_Void_FocusingType_Int32_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x0003EEE6 File Offset: 0x0003D0E6
		public DLC5_CreatorsBoxPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x00222E90 File Offset: 0x00221090
		// (set) Token: 0x0600746D RID: 29805 RVA: 0x0003EEEF File Offset: 0x0003D0EF
		public unsafe static int m_RoundTotalTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_RoundTotalTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_RoundTotalTime, (void*)(&value));
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600746E RID: 29806 RVA: 0x00222EAC File Offset: 0x002210AC
		// (set) Token: 0x0600746F RID: 29807 RVA: 0x0003EEFD File Offset: 0x0003D0FD
		public unsafe static int m_SkipMax
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipMax, (void*)(&value));
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x06007470 RID: 29808 RVA: 0x00222EC8 File Offset: 0x002210C8
		// (set) Token: 0x06007471 RID: 29809 RVA: 0x0003EF0B File Offset: 0x0003D10B
		public unsafe static int m_SkipDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipDefault, (void*)(&value));
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x06007472 RID: 29810 RVA: 0x00222EE4 File Offset: 0x002210E4
		// (set) Token: 0x06007473 RID: 29811 RVA: 0x0003EF19 File Offset: 0x0003D119
		public unsafe static int m_SkipMin
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipMin, (void*)(&value));
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x06007474 RID: 29812 RVA: 0x00222F00 File Offset: 0x00221100
		// (set) Token: 0x06007475 RID: 29813 RVA: 0x0003EF27 File Offset: 0x0003D127
		public unsafe static int m_SkipStep
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipStep, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipStep, (void*)(&value));
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x00222F1C File Offset: 0x0022111C
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x0003EF35 File Offset: 0x0003D135
		public unsafe static int m_FastForwardAmount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_FastForwardAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_FastForwardAmount, (void*)(&value));
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x06007478 RID: 29816 RVA: 0x00222F38 File Offset: 0x00221138
		// (set) Token: 0x06007479 RID: 29817 RVA: 0x0003EF43 File Offset: 0x0003D143
		public unsafe CreatorsBoxTimelineElement m_Element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorsBoxTimelineElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x00222F68 File Offset: 0x00221168
		// (set) Token: 0x0600747B RID: 29819 RVA: 0x0003EF62 File Offset: 0x0003D162
		public unsafe CreatorsBoxTimelineElement m_SecondaryElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorsBoxTimelineElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600747C RID: 29820 RVA: 0x00222F98 File Offset: 0x00221198
		// (set) Token: 0x0600747D RID: 29821 RVA: 0x0003EF81 File Offset: 0x0003D181
		public unsafe Il2CppReferenceArray<CreatorsBoxTimelineInBetweenElement> m_InBetweenElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_InBetweenElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CreatorsBoxTimelineInBetweenElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_InBetweenElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600747E RID: 29822 RVA: 0x00222FC8 File Offset: 0x002211C8
		// (set) Token: 0x0600747F RID: 29823 RVA: 0x0003EFA0 File Offset: 0x0003D1A0
		public unsafe GridLayoutGroup m_Grid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Grid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Grid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x06007480 RID: 29824 RVA: 0x00222FF8 File Offset: 0x002211F8
		// (set) Token: 0x06007481 RID: 29825 RVA: 0x0003EFBF File Offset: 0x0003D1BF
		public unsafe GridLayoutGroup m_SecondaryGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x00223028 File Offset: 0x00221228
		// (set) Token: 0x06007483 RID: 29827 RVA: 0x0003EFDE File Offset: 0x0003D1DE
		public unsafe AdpProgressIndicatorComponent m_ProgressIndicatorComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x00223058 File Offset: 0x00221258
		// (set) Token: 0x06007485 RID: 29829 RVA: 0x0003EFFD File Offset: 0x0003D1FD
		public unsafe AdpProgressIndicatorComponent m_SecondaryProgressIndicatorComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryProgressIndicatorComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryProgressIndicatorComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x06007486 RID: 29830 RVA: 0x00223088 File Offset: 0x00221288
		// (set) Token: 0x06007487 RID: 29831 RVA: 0x0003F01C File Offset: 0x0003D21C
		public unsafe UIButtonSimple m_AddExtraTimeBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_AddExtraTimeBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_AddExtraTimeBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x002230B8 File Offset: 0x002212B8
		// (set) Token: 0x06007489 RID: 29833 RVA: 0x0003F03B File Offset: 0x0003D23B
		public unsafe UIButtonSimple m_RemoveExtraTimeBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_RemoveExtraTimeBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_RemoveExtraTimeBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x002230E8 File Offset: 0x002212E8
		// (set) Token: 0x0600748B RID: 29835 RVA: 0x0003F05A File Offset: 0x0003D25A
		public unsafe UIButtonSimple m_TrimExtraTimeBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_TrimExtraTimeBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_TrimExtraTimeBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x0600748C RID: 29836 RVA: 0x00223118 File Offset: 0x00221318
		// (set) Token: 0x0600748D RID: 29837 RVA: 0x0003F079 File Offset: 0x0003D279
		public unsafe UIButtonSimple m_ScaleMoreBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleMoreBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleMoreBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x00223148 File Offset: 0x00221348
		// (set) Token: 0x0600748F RID: 29839 RVA: 0x0003F098 File Offset: 0x0003D298
		public unsafe UIButtonSimple m_ScaleLessBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleLessBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleLessBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x06007490 RID: 29840 RVA: 0x00223178 File Offset: 0x00221378
		// (set) Token: 0x06007491 RID: 29841 RVA: 0x0003F0B7 File Offset: 0x0003D2B7
		public unsafe UIButtonSimple m_ScaleResetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleResetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ScaleResetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x002231A8 File Offset: 0x002213A8
		// (set) Token: 0x06007493 RID: 29843 RVA: 0x0003F0D6 File Offset: 0x0003D2D6
		public unsafe UIButtonHold m_ResetAllBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ResetAllBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ResetAllBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x002231D8 File Offset: 0x002213D8
		// (set) Token: 0x06007495 RID: 29845 RVA: 0x0003F0F5 File Offset: 0x0003D2F5
		public unsafe UIButtonSimple m_LoadPresetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_LoadPresetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_LoadPresetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x00223208 File Offset: 0x00221408
		// (set) Token: 0x06007497 RID: 29847 RVA: 0x0003F114 File Offset: 0x0003D314
		public unsafe UIButtonSimple m_SavePresetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SavePresetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SavePresetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x00223238 File Offset: 0x00221438
		// (set) Token: 0x06007499 RID: 29849 RVA: 0x0003F133 File Offset: 0x0003D333
		public unsafe UIButtonHold m_ExitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ExitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_ExitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600749A RID: 29850 RVA: 0x00223268 File Offset: 0x00221468
		// (set) Token: 0x0600749B RID: 29851 RVA: 0x0003F152 File Offset: 0x0003D352
		public unsafe DLC5_SpecialGuestSelectionPanel m_SpecialGuestSelectionPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SpecialGuestSelectionPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_SpecialGuestSelectionPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SpecialGuestSelectionPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x00223298 File Offset: 0x00221498
		// (set) Token: 0x0600749D RID: 29853 RVA: 0x0003F171 File Offset: 0x0003D371
		public unsafe DLC5_PresetSelectionPanel m_PresetPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_PresetPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_PresetSelectionPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_PresetPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600749E RID: 29854 RVA: 0x002232C8 File Offset: 0x002214C8
		// (set) Token: 0x0600749F RID: 29855 RVA: 0x0003F190 File Offset: 0x0003D390
		public unsafe List<DLC5_CreatorsBoxPanel.Cell> m_CurrentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_CreatorsBoxPanel.Cell>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x002232F8 File Offset: 0x002214F8
		// (set) Token: 0x060074A1 RID: 29857 RVA: 0x0003F1AF File Offset: 0x0003D3AF
		public unsafe List<DLC5_CreatorsBoxPanel.Cell> m_CurrentView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_CreatorsBoxPanel.Cell>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x060074A2 RID: 29858 RVA: 0x00223328 File Offset: 0x00221528
		// (set) Token: 0x060074A3 RID: 29859 RVA: 0x0003F1CE File Offset: 0x0003D3CE
		public unsafe List<SpecialGuest> m_AvailableSpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_AvailableSpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_AvailableSpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x060074A4 RID: 29860 RVA: 0x00223358 File Offset: 0x00221558
		// (set) Token: 0x060074A5 RID: 29861 RVA: 0x0003F1ED File Offset: 0x0003D3ED
		public unsafe ObjectPool<DLC5_CreatorsBoxPanel.Cell> m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<DLC5_CreatorsBoxPanel.Cell>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x060074A6 RID: 29862 RVA: 0x00223388 File Offset: 0x00221588
		// (set) Token: 0x060074A7 RID: 29863 RVA: 0x0003F20C File Offset: 0x0003D40C
		public unsafe StaticHorizontalGridScrollListUILogicalGroupT<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple> m_LogicalGroupT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_LogicalGroupT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_LogicalGroupT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x060074A8 RID: 29864 RVA: 0x002233B8 File Offset: 0x002215B8
		// (set) Token: 0x060074A9 RID: 29865 RVA: 0x0003F22B File Offset: 0x0003D42B
		public unsafe StaticHorizontalGridScrollListUILogicalGroupT<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple> m_SecondaryLogicalGroupT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryLogicalGroupT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SecondaryLogicalGroupT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x002233E8 File Offset: 0x002215E8
		// (set) Token: 0x060074AB RID: 29867 RVA: 0x0003F24A File Offset: 0x0003D44A
		public unsafe int m_SkipAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_SkipAmount)) = value;
			}
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x060074AC RID: 29868 RVA: 0x00223410 File Offset: 0x00221610
		// (set) Token: 0x060074AD RID: 29869 RVA: 0x0003F265 File Offset: 0x0003D465
		public unsafe DLC5_CreatorsBoxPanel.Cell m_CurrentSelectedCell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentSelectedCell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel.Cell>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_CurrentSelectedCell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x060074AE RID: 29870 RVA: 0x00223440 File Offset: 0x00221640
		// (set) Token: 0x060074AF RID: 29871 RVA: 0x0003F284 File Offset: 0x0003D484
		public unsafe DLC5_CreatorsBoxPanel.FocusingType m_FocusingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_FocusingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.NativeFieldInfoPtr_m_FocusingType)) = value;
			}
		}

		// Token: 0x04004CFD RID: 19709
		private static readonly IntPtr NativeFieldInfoPtr_m_RoundTotalTime;

		// Token: 0x04004CFE RID: 19710
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipMax;

		// Token: 0x04004CFF RID: 19711
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipDefault;

		// Token: 0x04004D00 RID: 19712
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipMin;

		// Token: 0x04004D01 RID: 19713
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipStep;

		// Token: 0x04004D02 RID: 19714
		private static readonly IntPtr NativeFieldInfoPtr_m_FastForwardAmount;

		// Token: 0x04004D03 RID: 19715
		private static readonly IntPtr NativeFieldInfoPtr_m_Element;

		// Token: 0x04004D04 RID: 19716
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondaryElement;

		// Token: 0x04004D05 RID: 19717
		private static readonly IntPtr NativeFieldInfoPtr_m_InBetweenElement;

		// Token: 0x04004D06 RID: 19718
		private static readonly IntPtr NativeFieldInfoPtr_m_Grid;

		// Token: 0x04004D07 RID: 19719
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondaryGrid;

		// Token: 0x04004D08 RID: 19720
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressIndicatorComponent;

		// Token: 0x04004D09 RID: 19721
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondaryProgressIndicatorComponent;

		// Token: 0x04004D0A RID: 19722
		private static readonly IntPtr NativeFieldInfoPtr_m_AddExtraTimeBtn;

		// Token: 0x04004D0B RID: 19723
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveExtraTimeBtn;

		// Token: 0x04004D0C RID: 19724
		private static readonly IntPtr NativeFieldInfoPtr_m_TrimExtraTimeBtn;

		// Token: 0x04004D0D RID: 19725
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleMoreBtn;

		// Token: 0x04004D0E RID: 19726
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleLessBtn;

		// Token: 0x04004D0F RID: 19727
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleResetBtn;

		// Token: 0x04004D10 RID: 19728
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetAllBtn;

		// Token: 0x04004D11 RID: 19729
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadPresetBtn;

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeFieldInfoPtr_m_SavePresetBtn;

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeFieldInfoPtr_m_ExitButton;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestSelectionPanel;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeFieldInfoPtr_m_PresetPanel;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentList;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentView;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableSpecialGuests;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x04004D1A RID: 19738
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroupT;

		// Token: 0x04004D1B RID: 19739
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondaryLogicalGroupT;

		// Token: 0x04004D1C RID: 19740
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipAmount;

		// Token: 0x04004D1D RID: 19741
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedCell;

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusingType;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeMethodInfoPtr_AddExtraTime_Private_Void_0;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeMethodInfoPtr_TrimExtraTime_Private_Void_0;

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeMethodInfoPtr_MountDataAndRefreshView_Private_Void_CreatorBoxData_0;

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeMethodInfoPtr_SortSpecialGuestList_Private_Void_0;

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeMethodInfoPtr_UpdateView_Private_ValueTuple_2_Int32_Cell_0;

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeMethodInfoPtr_CreateReturnValue_Private_CreatorBoxData_0;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAddTimeButton_Private_Void_UIButtonBase_3;

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScaleButton_Private_ValueTuple_3_Boolean_Boolean_Boolean_0;

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLoadButton_Private_Void_0;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeMethodInfoPtr_ProcessScaleButtonReselection_Private_Void_UIButtonBase_Boolean_Boolean_Boolean_0;

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_32_Private_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_0;

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_0_Private_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_0;

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_1_Private_Void_0;

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_2_Private_Void_0;

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_3_Private_Void_0;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_4_Private_Void_0;

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_5_Private_Void_0;

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_6_Private_UniTaskVoid_0;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_7_Private_UniTaskVoid_0;

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_8_Private_Void_0;

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_9_Private_Void_0;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_10_Private_Void_0;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_11_Private_Void_CallbackContext_0;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_12_Private_Void_CallbackContext_0;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_13_Private_Void_CallbackContext_0;

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_14_Private_Void_0;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_15_Private_Void_0;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_16_Private_Void_0;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_17_Private_Void_0;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_18_Private_Void_0;

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_19_Private_Void_0;

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_20_Private_Void_0;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_21_Private_Void_0;

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_22_Private_Void_0;

		// Token: 0x04004D46 RID: 19782
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_23_Private_Void_0;

		// Token: 0x04004D47 RID: 19783
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0;

		// Token: 0x04004D48 RID: 19784
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Cell_UIButtonSimple_0;

		// Token: 0x04004D49 RID: 19785
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_Cell_CreatorsBoxTimelineElement_UIButtonSimple_PDM_0;

		// Token: 0x04004D4A RID: 19786
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_0;

		// Token: 0x04004D4B RID: 19787
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_1;

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_UIButtonBase_2;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_FocusingType_Int32_Cell_0;

		// Token: 0x02000F63 RID: 3939
		public sealed class OpenContext : ValueType
		{
			// Token: 0x0601120C RID: 70156 RVA: 0x003F3A70 File Offset: 0x003F1C70
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.OpenContext.NativeFieldInfoPtr_CreatorBoxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr, "CreatorBoxData");
				DLC5_CreatorsBoxPanel.OpenContext.NativeFieldInfoPtr_CreatorBoxDataPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr, "CreatorBoxDataPresets");
				DLC5_CreatorsBoxPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_CreatorBoxData_Il2CppReferenceArray_1_Nullable_1_CreatorBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr, 100687237);
			}

			// Token: 0x0601120D RID: 70157 RVA: 0x003F3AD8 File Offset: 0x003F1CD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289353, RefRangeEnd = 289354, XrefRangeStart = 289351, XrefRangeEnd = 289353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(CreatorBoxData creatorBoxData, Il2CppReferenceArray<Nullable<CreatorBoxData>> creatorBoxDataPresets) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(creatorBoxData));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(creatorBoxDataPresets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_CreatorBoxData_Il2CppReferenceArray_1_Nullable_1_CreatorBoxData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601120E RID: 70158 RVA: 0x00094ED7 File Offset: 0x000930D7
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601120F RID: 70159 RVA: 0x00094EE0 File Offset: 0x000930E0
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700590A RID: 22794
			// (get) Token: 0x06011210 RID: 70160 RVA: 0x003F3B40 File Offset: 0x003F1D40
			// (set) Token: 0x06011211 RID: 70161 RVA: 0x00094EF2 File Offset: 0x000930F2
			public CreatorBoxData CreatorBoxData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.OpenContext.NativeFieldInfoPtr_CreatorBoxData);
					return new CreatorBoxData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.OpenContext.NativeFieldInfoPtr_CreatorBoxData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700590B RID: 22795
			// (get) Token: 0x06011212 RID: 70162 RVA: 0x003F3B70 File Offset: 0x003F1D70
			// (set) Token: 0x06011213 RID: 70163 RVA: 0x00094F20 File Offset: 0x00093120
			public unsafe Il2CppReferenceArray<Nullable<CreatorBoxData>> CreatorBoxDataPresets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.OpenContext.NativeFieldInfoPtr_CreatorBoxDataPresets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Nullable<CreatorBoxData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.OpenContext.NativeFieldInfoPtr_CreatorBoxDataPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD44 RID: 44356
			private static readonly IntPtr NativeFieldInfoPtr_CreatorBoxData;

			// Token: 0x0400AD45 RID: 44357
			private static readonly IntPtr NativeFieldInfoPtr_CreatorBoxDataPresets;

			// Token: 0x0400AD46 RID: 44358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CreatorBoxData_Il2CppReferenceArray_1_Nullable_1_CreatorBoxData_0;
		}

		// Token: 0x02000F64 RID: 3940
		public enum FocusingType
		{
			// Token: 0x0400AD48 RID: 44360
			None,
			// Token: 0x0400AD49 RID: 44361
			View,
			// Token: 0x0400AD4A RID: 44362
			List
		}

		// Token: 0x02000F65 RID: 3941
		public class Cell : Object
		{
			// Token: 0x06011214 RID: 70164 RVA: 0x003F3BA0 File Offset: 0x003F1DA0
			// Note: this type is marked as 'beforefieldinit'.
			static Cell()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "Cell");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__TimeStamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, "<TimeStamp>k__BackingField");
				DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__IsLast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, "<IsLast>k__BackingField");
				DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__IsExtra_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, "<IsExtra>k__BackingField");
				DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__NextIsExtra_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, "<NextIsExtra>k__BackingField");
				DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__SelectedSpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, "<SelectedSpecialGuest>k__BackingField");
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_TimeStamp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687238);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_TimeStamp_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687239);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_IsLast_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687240);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_IsLast_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687241);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_IsExtra_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687242);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_IsExtra_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687243);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_NextIsExtra_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687244);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_NextIsExtra_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687245);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_SelectedSpecialGuest_Public_get_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687246);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_SelectedSpecialGuest_Public_set_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687247);
				DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr, 100687248);
			}

			// Token: 0x17005911 RID: 22801
			// (get) Token: 0x06011215 RID: 70165 RVA: 0x003F3D0C File Offset: 0x003F1F0C
			// (set) Token: 0x06011216 RID: 70166 RVA: 0x003F3D48 File Offset: 0x003F1F48
			public unsafe int TimeStamp
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_TimeStamp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 138385, RefRangeEnd = 138389, XrefRangeStart = 138385, XrefRangeEnd = 138389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_TimeStamp_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17005912 RID: 22802
			// (get) Token: 0x06011217 RID: 70167 RVA: 0x003F3D88 File Offset: 0x003F1F88
			// (set) Token: 0x06011218 RID: 70168 RVA: 0x003F3DC4 File Offset: 0x003F1FC4
			public unsafe bool IsLast
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_IsLast_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_IsLast_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17005913 RID: 22803
			// (get) Token: 0x06011219 RID: 70169 RVA: 0x003F3E04 File Offset: 0x003F2004
			// (set) Token: 0x0601121A RID: 70170 RVA: 0x003F3E40 File Offset: 0x003F2040
			public unsafe bool IsExtra
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_IsExtra_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_IsExtra_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17005914 RID: 22804
			// (get) Token: 0x0601121B RID: 70171 RVA: 0x003F3E80 File Offset: 0x003F2080
			// (set) Token: 0x0601121C RID: 70172 RVA: 0x003F3EBC File Offset: 0x003F20BC
			public unsafe bool NextIsExtra
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_NextIsExtra_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_NextIsExtra_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17005915 RID: 22805
			// (get) Token: 0x0601121D RID: 70173 RVA: 0x003F3EFC File Offset: 0x003F20FC
			// (set) Token: 0x0601121E RID: 70174 RVA: 0x003F3F3C File Offset: 0x003F213C
			public unsafe SpecialGuest SelectedSpecialGuest
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_get_SelectedSpecialGuest_Public_get_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr_set_SelectedSpecialGuest_Public_set_Void_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0601121F RID: 70175 RVA: 0x003F3F80 File Offset: 0x003F2180
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cell() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.Cell>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.Cell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011220 RID: 70176 RVA: 0x00094F3F File Offset: 0x0009313F
			public Cell(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700590C RID: 22796
			// (get) Token: 0x06011221 RID: 70177 RVA: 0x003F3FBC File Offset: 0x003F21BC
			// (set) Token: 0x06011222 RID: 70178 RVA: 0x00094F48 File Offset: 0x00093148
			public unsafe int _TimeStamp_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__TimeStamp_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__TimeStamp_k__BackingField)) = value;
				}
			}

			// Token: 0x1700590D RID: 22797
			// (get) Token: 0x06011223 RID: 70179 RVA: 0x003F3FE4 File Offset: 0x003F21E4
			// (set) Token: 0x06011224 RID: 70180 RVA: 0x00094F63 File Offset: 0x00093163
			public unsafe bool _IsLast_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__IsLast_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__IsLast_k__BackingField)) = value;
				}
			}

			// Token: 0x1700590E RID: 22798
			// (get) Token: 0x06011225 RID: 70181 RVA: 0x003F400C File Offset: 0x003F220C
			// (set) Token: 0x06011226 RID: 70182 RVA: 0x00094F7E File Offset: 0x0009317E
			public unsafe bool _IsExtra_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__IsExtra_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__IsExtra_k__BackingField)) = value;
				}
			}

			// Token: 0x1700590F RID: 22799
			// (get) Token: 0x06011227 RID: 70183 RVA: 0x003F4034 File Offset: 0x003F2234
			// (set) Token: 0x06011228 RID: 70184 RVA: 0x00094F99 File Offset: 0x00093199
			public unsafe bool _NextIsExtra_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__NextIsExtra_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__NextIsExtra_k__BackingField)) = value;
				}
			}

			// Token: 0x17005910 RID: 22800
			// (get) Token: 0x06011229 RID: 70185 RVA: 0x003F405C File Offset: 0x003F225C
			// (set) Token: 0x0601122A RID: 70186 RVA: 0x00094FB4 File Offset: 0x000931B4
			public unsafe SpecialGuest _SelectedSpecialGuest_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__SelectedSpecialGuest_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.Cell.NativeFieldInfoPtr__SelectedSpecialGuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD4B RID: 44363
			private static readonly IntPtr NativeFieldInfoPtr__TimeStamp_k__BackingField;

			// Token: 0x0400AD4C RID: 44364
			private static readonly IntPtr NativeFieldInfoPtr__IsLast_k__BackingField;

			// Token: 0x0400AD4D RID: 44365
			private static readonly IntPtr NativeFieldInfoPtr__IsExtra_k__BackingField;

			// Token: 0x0400AD4E RID: 44366
			private static readonly IntPtr NativeFieldInfoPtr__NextIsExtra_k__BackingField;

			// Token: 0x0400AD4F RID: 44367
			private static readonly IntPtr NativeFieldInfoPtr__SelectedSpecialGuest_k__BackingField;

			// Token: 0x0400AD50 RID: 44368
			private static readonly IntPtr NativeMethodInfoPtr_get_TimeStamp_Public_get_Int32_0;

			// Token: 0x0400AD51 RID: 44369
			private static readonly IntPtr NativeMethodInfoPtr_set_TimeStamp_Public_set_Void_Int32_0;

			// Token: 0x0400AD52 RID: 44370
			private static readonly IntPtr NativeMethodInfoPtr_get_IsLast_Public_get_Boolean_0;

			// Token: 0x0400AD53 RID: 44371
			private static readonly IntPtr NativeMethodInfoPtr_set_IsLast_Public_set_Void_Boolean_0;

			// Token: 0x0400AD54 RID: 44372
			private static readonly IntPtr NativeMethodInfoPtr_get_IsExtra_Public_get_Boolean_0;

			// Token: 0x0400AD55 RID: 44373
			private static readonly IntPtr NativeMethodInfoPtr_set_IsExtra_Public_set_Void_Boolean_0;

			// Token: 0x0400AD56 RID: 44374
			private static readonly IntPtr NativeMethodInfoPtr_get_NextIsExtra_Public_get_Boolean_0;

			// Token: 0x0400AD57 RID: 44375
			private static readonly IntPtr NativeMethodInfoPtr_set_NextIsExtra_Public_set_Void_Boolean_0;

			// Token: 0x0400AD58 RID: 44376
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectedSpecialGuest_Public_get_SpecialGuest_0;

			// Token: 0x0400AD59 RID: 44377
			private static readonly IntPtr NativeMethodInfoPtr_set_SelectedSpecialGuest_Public_set_Void_SpecialGuest_0;

			// Token: 0x0400AD5A RID: 44378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000F66 RID: 3942
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Object
		{
			// Token: 0x0601122B RID: 70187 RVA: 0x003F408C File Offset: 0x003F228C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_0>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeFieldInfoPtr_secondaryFocusIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_0>.NativeClassPtr, "secondaryFocusIndex");
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_0>.NativeClassPtr, 100687249);
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeMethodInfoPtr__OnPanelInitialize_b__33_Internal_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_0>.NativeClassPtr, 100687250);
			}

			// Token: 0x0601122C RID: 70188 RVA: 0x003F40F4 File Offset: 0x003F22F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601122D RID: 70189 RVA: 0x003F4130 File Offset: 0x003F2330
			[CallerCount(0)]
			public unsafe bool _OnPanelInitialize_b__33(DLC5_CreatorsBoxPanel.Cell matchCell)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchCell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeMethodInfoPtr__OnPanelInitialize_b__33_Internal_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601122E RID: 70190 RVA: 0x00094FD3 File Offset: 0x000931D3
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005916 RID: 22806
			// (get) Token: 0x0601122F RID: 70191 RVA: 0x003F4180 File Offset: 0x003F2380
			// (set) Token: 0x06011230 RID: 70192 RVA: 0x00094FDC File Offset: 0x000931DC
			public unsafe int secondaryFocusIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeFieldInfoPtr_secondaryFocusIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_0.NativeFieldInfoPtr_secondaryFocusIndex)) = value;
				}
			}

			// Token: 0x0400AD5B RID: 44379
			private static readonly IntPtr NativeFieldInfoPtr_secondaryFocusIndex;

			// Token: 0x0400AD5C RID: 44380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD5D RID: 44381
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__33_Internal_Boolean_Cell_0;
		}

		// Token: 0x02000F67 RID: 3943
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<>c__DisplayClass36_1")]
		public sealed class __c__DisplayClass36_1 : Object
		{
			// Token: 0x06011231 RID: 70193 RVA: 0x003F41A8 File Offset: 0x003F23A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_1()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "<>c__DisplayClass36_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeFieldInfoPtr_cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr, "cell");
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr, "<>4__this");
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr, 100687251);
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeMethodInfoPtr__OnPanelInitialize_b__34_Internal_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr, 100687252);
			}

			// Token: 0x06011232 RID: 70194 RVA: 0x003F4224 File Offset: 0x003F2424
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011233 RID: 70195 RVA: 0x003F4260 File Offset: 0x003F2460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289408, XrefRangeEnd = 289413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTaskVoid _OnPanelInitialize_b__34()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeMethodInfoPtr__OnPanelInitialize_b__34_Internal_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011234 RID: 70196 RVA: 0x00094FF7 File Offset: 0x000931F7
			public __c__DisplayClass36_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005917 RID: 22807
			// (get) Token: 0x06011235 RID: 70197 RVA: 0x003F429C File Offset: 0x003F249C
			// (set) Token: 0x06011236 RID: 70198 RVA: 0x00095000 File Offset: 0x00093200
			public unsafe DLC5_CreatorsBoxPanel.Cell cell
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeFieldInfoPtr_cell);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel.Cell>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeFieldInfoPtr_cell), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005918 RID: 22808
			// (get) Token: 0x06011237 RID: 70199 RVA: 0x003F42CC File Offset: 0x003F24CC
			// (set) Token: 0x06011238 RID: 70200 RVA: 0x0009501F File Offset: 0x0009321F
			public unsafe DLC5_CreatorsBoxPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD5E RID: 44382
			private static readonly IntPtr NativeFieldInfoPtr_cell;

			// Token: 0x0400AD5F RID: 44383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD60 RID: 44384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD61 RID: 44385
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_Internal_UniTaskVoid_0;

			// Token: 0x020010DB RID: 4315
			[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<>c__DisplayClass36_1+<<OnPanelInitialize>b__34>d")]
			public sealed class __OnPanelInitialize_b__34_d : ValueType
			{
				// Token: 0x0601240C RID: 74764 RVA: 0x00429050 File Offset: 0x00427250
				// Note: this type is marked as 'beforefieldinit'.
				static __OnPanelInitialize_b__34_d()
				{
					Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>.NativeClassPtr, "<<OnPanelInitialize>b__34>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr);
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, "<>1__state");
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, "<>t__builder");
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, "<>4__this");
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr__previousSelection_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, "<previousSelection>5__2");
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, "<>u__1");
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, 100687253);
					DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr, 100687254);
				}

				// Token: 0x0601240D RID: 74765 RVA: 0x00429108 File Offset: 0x00427308
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 289406, RefRangeEnd = 289408, XrefRangeStart = 289354, XrefRangeEnd = 289406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601240E RID: 74766 RVA: 0x00429140 File Offset: 0x00427340
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601240F RID: 74767 RVA: 0x0009E421 File Offset: 0x0009C621
				public __OnPanelInitialize_b__34_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06012410 RID: 74768 RVA: 0x0009E42A File Offset: 0x0009C62A
				public __OnPanelInitialize_b__34_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005F75 RID: 24437
				// (get) Token: 0x06012411 RID: 74769 RVA: 0x00429188 File Offset: 0x00427388
				// (set) Token: 0x06012412 RID: 74770 RVA: 0x0009E43C File Offset: 0x0009C63C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F76 RID: 24438
				// (get) Token: 0x06012413 RID: 74771 RVA: 0x004291B0 File Offset: 0x004273B0
				// (set) Token: 0x06012414 RID: 74772 RVA: 0x0009E457 File Offset: 0x0009C657
				public AsyncUniTaskVoidMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005F77 RID: 24439
				// (get) Token: 0x06012415 RID: 74773 RVA: 0x004291E0 File Offset: 0x004273E0
				// (set) Token: 0x06012416 RID: 74774 RVA: 0x0009E485 File Offset: 0x0009C685
				public unsafe DLC5_CreatorsBoxPanel.__c__DisplayClass36_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel.__c__DisplayClass36_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F78 RID: 24440
				// (get) Token: 0x06012417 RID: 74775 RVA: 0x00429210 File Offset: 0x00427410
				// (set) Token: 0x06012418 RID: 74776 RVA: 0x0009E4A4 File Offset: 0x0009C6A4
				public unsafe SpecialGuest _previousSelection_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr__previousSelection_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr__previousSelection_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F79 RID: 24441
				// (get) Token: 0x06012419 RID: 74777 RVA: 0x00429240 File Offset: 0x00427440
				// (set) Token: 0x0601241A RID: 74778 RVA: 0x0009E4C3 File Offset: 0x0009C6C3
				public UniTask<SpecialGuest>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___u__1);
						return new UniTask<SpecialGuest>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<SpecialGuest>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_1.__OnPanelInitialize_b__34_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<SpecialGuest>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B90B RID: 47371
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B90C RID: 47372
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B90D RID: 47373
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B90E RID: 47374
				private static readonly IntPtr NativeFieldInfoPtr__previousSelection_5__2;

				// Token: 0x0400B90F RID: 47375
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B910 RID: 47376
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B911 RID: 47377
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000F68 RID: 3944
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<>c__DisplayClass36_2")]
		public sealed class __c__DisplayClass36_2 : Object
		{
			// Token: 0x06011239 RID: 70201 RVA: 0x003F42FC File Offset: 0x003F24FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_2()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "<>c__DisplayClass36_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_2>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeFieldInfoPtr_listFocusIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_2>.NativeClassPtr, "listFocusIndex");
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_2>.NativeClassPtr, 100687255);
				DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeMethodInfoPtr__OnPanelInitialize_b__35_Internal_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_2>.NativeClassPtr, 100687256);
			}

			// Token: 0x0601123A RID: 70202 RVA: 0x003F4364 File Offset: 0x003F2564
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c__DisplayClass36_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601123B RID: 70203 RVA: 0x003F43A0 File Offset: 0x003F25A0
			[CallerCount(0)]
			public unsafe bool _OnPanelInitialize_b__35(DLC5_CreatorsBoxPanel.Cell matchCell)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchCell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeMethodInfoPtr__OnPanelInitialize_b__35_Internal_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601123C RID: 70204 RVA: 0x0009503E File Offset: 0x0009323E
			public __c__DisplayClass36_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005919 RID: 22809
			// (get) Token: 0x0601123D RID: 70205 RVA: 0x003F43F0 File Offset: 0x003F25F0
			// (set) Token: 0x0601123E RID: 70206 RVA: 0x00095047 File Offset: 0x00093247
			public unsafe int listFocusIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeFieldInfoPtr_listFocusIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__c__DisplayClass36_2.NativeFieldInfoPtr_listFocusIndex)) = value;
				}
			}

			// Token: 0x0400AD62 RID: 44386
			private static readonly IntPtr NativeFieldInfoPtr_listFocusIndex;

			// Token: 0x0400AD63 RID: 44387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD64 RID: 44388
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__35_Internal_Boolean_Cell_0;
		}

		// Token: 0x02000F69 RID: 3945
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0601123F RID: 70207 RVA: 0x003F4418 File Offset: 0x003F2618
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__40_0");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__40_1");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__41_0");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__43_0");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__43_1");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__43_2");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__47_0");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__51_0");
				DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__51_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, "<>9__51_1");
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687258);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__MountDataAndRefreshView_b__40_0_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687259);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__MountDataAndRefreshView_b__40_1_Internal_Int32_SpecGuestRefreshNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687260);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__SortSpecialGuestList_b__41_0_Internal_Int32_SpecialGuest_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687261);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__CreateReturnValue_b__43_0_Internal_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687262);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__CreateReturnValue_b__43_1_Internal_ValueTuple_2_Int32_Int32_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687263);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__CreateReturnValue_b__43_2_Internal_Int32_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687264);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__UpdateLoadButton_b__47_0_Internal_Boolean_Nullable_1_CreatorBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687265);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr___ctor_b__51_0_Internal_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687266);
				DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr___ctor_b__51_1_Internal_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr, 100687267);
			}

			// Token: 0x06011240 RID: 70208 RVA: 0x003F45D4 File Offset: 0x003F27D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011241 RID: 70209 RVA: 0x003F4610 File Offset: 0x003F2810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289413, XrefRangeEnd = 289414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MountDataAndRefreshView_b__40_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__MountDataAndRefreshView_b__40_0_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011242 RID: 70210 RVA: 0x003F4660 File Offset: 0x003F2860
			[CallerCount(0)]
			public unsafe int _MountDataAndRefreshView_b__40_1(CreatorBoxData.SpecGuestRefreshNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__MountDataAndRefreshView_b__40_1_Internal_Int32_SpecGuestRefreshNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011243 RID: 70211 RVA: 0x003F46AC File Offset: 0x003F28AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289414, XrefRangeEnd = 289418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortSpecialGuestList_b__41_0(SpecialGuest a, SpecialGuest b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__SortSpecialGuestList_b__41_0_Internal_Int32_SpecialGuest_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011244 RID: 70212 RVA: 0x003F470C File Offset: 0x003F290C
			[CallerCount(0)]
			public unsafe bool _CreateReturnValue_b__43_0(DLC5_CreatorsBoxPanel.Cell x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__CreateReturnValue_b__43_0_Internal_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011245 RID: 70213 RVA: 0x003F475C File Offset: 0x003F295C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289418, XrefRangeEnd = 289421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, int> _CreateReturnValue_b__43_1(DLC5_CreatorsBoxPanel.Cell x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__CreateReturnValue_b__43_1_Internal_ValueTuple_2_Int32_Int32_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, int>(pointer);
			}

			// Token: 0x06011246 RID: 70214 RVA: 0x003F47A4 File Offset: 0x003F29A4
			[CallerCount(0)]
			public unsafe int _CreateReturnValue_b__43_2(ValueTuple<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__CreateReturnValue_b__43_2_Internal_Int32_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011247 RID: 70215 RVA: 0x003F47F8 File Offset: 0x003F29F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289421, XrefRangeEnd = 289422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateLoadButton_b__47_0(Nullable<CreatorBoxData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr__UpdateLoadButton_b__47_0_Internal_Boolean_Nullable_1_CreatorBoxData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011248 RID: 70216 RVA: 0x003F484C File Offset: 0x003F2A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289422, XrefRangeEnd = 289426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC5_CreatorsBoxPanel.Cell __ctor_b__51_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr___ctor_b__51_0_Internal_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel.Cell>(intPtr3) : null;
			}

			// Token: 0x06011249 RID: 70217 RVA: 0x003F488C File Offset: 0x003F2A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289426, XrefRangeEnd = 289428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__51_1(DLC5_CreatorsBoxPanel.Cell cell)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__c.NativeMethodInfoPtr___ctor_b__51_1_Internal_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601124A RID: 70218 RVA: 0x00095062 File Offset: 0x00093262
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700591A RID: 22810
			// (get) Token: 0x0601124B RID: 70219 RVA: 0x003F48D0 File Offset: 0x003F2AD0
			// (set) Token: 0x0601124C RID: 70220 RVA: 0x0009506B File Offset: 0x0009326B
			public unsafe static DLC5_CreatorsBoxPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700591B RID: 22811
			// (get) Token: 0x0601124D RID: 70221 RVA: 0x003F48F8 File Offset: 0x003F2AF8
			// (set) Token: 0x0601124E RID: 70222 RVA: 0x0009507D File Offset: 0x0009327D
			public unsafe static Func<SpecialGuest, bool> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700591C RID: 22812
			// (get) Token: 0x0601124F RID: 70223 RVA: 0x003F4920 File Offset: 0x003F2B20
			// (set) Token: 0x06011250 RID: 70224 RVA: 0x0009508F File Offset: 0x0009328F
			public unsafe static Func<CreatorBoxData.SpecGuestRefreshNode, int> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CreatorBoxData.SpecGuestRefreshNode, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700591D RID: 22813
			// (get) Token: 0x06011251 RID: 70225 RVA: 0x003F4948 File Offset: 0x003F2B48
			// (set) Token: 0x06011252 RID: 70226 RVA: 0x000950A1 File Offset: 0x000932A1
			public unsafe static Comparison<SpecialGuest> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700591E RID: 22814
			// (get) Token: 0x06011253 RID: 70227 RVA: 0x003F4970 File Offset: 0x003F2B70
			// (set) Token: 0x06011254 RID: 70228 RVA: 0x000950B3 File Offset: 0x000932B3
			public unsafe static Func<DLC5_CreatorsBoxPanel.Cell, bool> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_CreatorsBoxPanel.Cell, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700591F RID: 22815
			// (get) Token: 0x06011255 RID: 70229 RVA: 0x003F4998 File Offset: 0x003F2B98
			// (set) Token: 0x06011256 RID: 70230 RVA: 0x000950C5 File Offset: 0x000932C5
			public unsafe static Func<DLC5_CreatorsBoxPanel.Cell, ValueTuple<int, int>> __9__43_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_CreatorsBoxPanel.Cell, ValueTuple<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005920 RID: 22816
			// (get) Token: 0x06011257 RID: 70231 RVA: 0x003F49C0 File Offset: 0x003F2BC0
			// (set) Token: 0x06011258 RID: 70232 RVA: 0x000950D7 File Offset: 0x000932D7
			public unsafe static Func<ValueTuple<int, int>, int> __9__43_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__43_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005921 RID: 22817
			// (get) Token: 0x06011259 RID: 70233 RVA: 0x003F49E8 File Offset: 0x003F2BE8
			// (set) Token: 0x0601125A RID: 70234 RVA: 0x000950E9 File Offset: 0x000932E9
			public unsafe static Func<Nullable<CreatorBoxData>, bool> __9__47_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<CreatorBoxData>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005922 RID: 22818
			// (get) Token: 0x0601125B RID: 70235 RVA: 0x003F4A10 File Offset: 0x003F2C10
			// (set) Token: 0x0601125C RID: 70236 RVA: 0x000950FB File Offset: 0x000932FB
			public unsafe static Func<DLC5_CreatorsBoxPanel.Cell> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_CreatorsBoxPanel.Cell>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005923 RID: 22819
			// (get) Token: 0x0601125D RID: 70237 RVA: 0x003F4A38 File Offset: 0x003F2C38
			// (set) Token: 0x0601125E RID: 70238 RVA: 0x0009510D File Offset: 0x0009330D
			public unsafe static Action<DLC5_CreatorsBoxPanel.Cell> __9__51_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__51_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC5_CreatorsBoxPanel.Cell>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_CreatorsBoxPanel.__c.NativeFieldInfoPtr___9__51_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD65 RID: 44389
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AD66 RID: 44390
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x0400AD67 RID: 44391
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x0400AD68 RID: 44392
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400AD69 RID: 44393
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x0400AD6A RID: 44394
			private static readonly IntPtr NativeFieldInfoPtr___9__43_1;

			// Token: 0x0400AD6B RID: 44395
			private static readonly IntPtr NativeFieldInfoPtr___9__43_2;

			// Token: 0x0400AD6C RID: 44396
			private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x0400AD6D RID: 44397
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x0400AD6E RID: 44398
			private static readonly IntPtr NativeFieldInfoPtr___9__51_1;

			// Token: 0x0400AD6F RID: 44399
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD70 RID: 44400
			private static readonly IntPtr NativeMethodInfoPtr__MountDataAndRefreshView_b__40_0_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400AD71 RID: 44401
			private static readonly IntPtr NativeMethodInfoPtr__MountDataAndRefreshView_b__40_1_Internal_Int32_SpecGuestRefreshNode_0;

			// Token: 0x0400AD72 RID: 44402
			private static readonly IntPtr NativeMethodInfoPtr__SortSpecialGuestList_b__41_0_Internal_Int32_SpecialGuest_SpecialGuest_0;

			// Token: 0x0400AD73 RID: 44403
			private static readonly IntPtr NativeMethodInfoPtr__CreateReturnValue_b__43_0_Internal_Boolean_Cell_0;

			// Token: 0x0400AD74 RID: 44404
			private static readonly IntPtr NativeMethodInfoPtr__CreateReturnValue_b__43_1_Internal_ValueTuple_2_Int32_Int32_Cell_0;

			// Token: 0x0400AD75 RID: 44405
			private static readonly IntPtr NativeMethodInfoPtr__CreateReturnValue_b__43_2_Internal_Int32_ValueTuple_2_Int32_Int32_0;

			// Token: 0x0400AD76 RID: 44406
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLoadButton_b__47_0_Internal_Boolean_Nullable_1_CreatorBoxData_0;

			// Token: 0x0400AD77 RID: 44407
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__51_0_Internal_Cell_0;

			// Token: 0x0400AD78 RID: 44408
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__51_1_Internal_Void_Cell_0;
		}

		// Token: 0x02000F6A RID: 3946
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<<OnPanelInitialize>b__36_6>d")]
		public sealed class __OnPanelInitialize_b__36_6_d : ValueType
		{
			// Token: 0x0601125F RID: 70239 RVA: 0x003F4A60 File Offset: 0x003F2C60
			// Note: this type is marked as 'beforefieldinit'.
			static __OnPanelInitialize_b__36_6_d()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "<<OnPanelInitialize>b__36_6>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr, "<>1__state");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr, "<>t__builder");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr, "<>4__this");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr, "<>u__1");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr, 100687268);
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr, 100687269);
			}

			// Token: 0x06011260 RID: 70240 RVA: 0x003F4B04 File Offset: 0x003F2D04
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 289470, RefRangeEnd = 289472, XrefRangeStart = 289428, XrefRangeEnd = 289470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011261 RID: 70241 RVA: 0x003F4B3C File Offset: 0x003F2D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011262 RID: 70242 RVA: 0x0009511F File Offset: 0x0009331F
			public __OnPanelInitialize_b__36_6_d(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011263 RID: 70243 RVA: 0x00095128 File Offset: 0x00093328
			public __OnPanelInitialize_b__36_6_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d>.NativeClassPtr))
			{
			}

			// Token: 0x17005924 RID: 22820
			// (get) Token: 0x06011264 RID: 70244 RVA: 0x003F4B84 File Offset: 0x003F2D84
			// (set) Token: 0x06011265 RID: 70245 RVA: 0x0009513A File Offset: 0x0009333A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005925 RID: 22821
			// (get) Token: 0x06011266 RID: 70246 RVA: 0x003F4BAC File Offset: 0x003F2DAC
			// (set) Token: 0x06011267 RID: 70247 RVA: 0x00095155 File Offset: 0x00093355
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005926 RID: 22822
			// (get) Token: 0x06011268 RID: 70248 RVA: 0x003F4BDC File Offset: 0x003F2DDC
			// (set) Token: 0x06011269 RID: 70249 RVA: 0x00095183 File Offset: 0x00093383
			public unsafe DLC5_CreatorsBoxPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005927 RID: 22823
			// (get) Token: 0x0601126A RID: 70250 RVA: 0x003F4C0C File Offset: 0x003F2E0C
			// (set) Token: 0x0601126B RID: 70251 RVA: 0x000951A2 File Offset: 0x000933A2
			public UniTask<Nullable<int>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___u__1);
					return new UniTask<Nullable<int>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_6_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AD79 RID: 44409
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AD7A RID: 44410
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AD7B RID: 44411
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD7C RID: 44412
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AD7D RID: 44413
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AD7E RID: 44414
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000F6B RID: 3947
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_CreatorsBoxPanel+<<OnPanelInitialize>b__36_7>d")]
		public sealed class __OnPanelInitialize_b__36_7_d : ValueType
		{
			// Token: 0x0601126C RID: 70252 RVA: 0x003F4C3C File Offset: 0x003F2E3C
			// Note: this type is marked as 'beforefieldinit'.
			static __OnPanelInitialize_b__36_7_d()
			{
				Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel>.NativeClassPtr, "<<OnPanelInitialize>b__36_7>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr);
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr, "<>1__state");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr, "<>t__builder");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr, "<>4__this");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr, "<>u__1");
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr, 100687270);
				DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr, 100687271);
			}

			// Token: 0x0601126D RID: 70253 RVA: 0x003F4CE0 File Offset: 0x003F2EE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 289516, RefRangeEnd = 289518, XrefRangeStart = 289472, XrefRangeEnd = 289516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601126E RID: 70254 RVA: 0x003F4D18 File Offset: 0x003F2F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601126F RID: 70255 RVA: 0x000951D0 File Offset: 0x000933D0
			public __OnPanelInitialize_b__36_7_d(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011270 RID: 70256 RVA: 0x000951D9 File Offset: 0x000933D9
			public __OnPanelInitialize_b__36_7_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d>.NativeClassPtr))
			{
			}

			// Token: 0x17005928 RID: 22824
			// (get) Token: 0x06011271 RID: 70257 RVA: 0x003F4D60 File Offset: 0x003F2F60
			// (set) Token: 0x06011272 RID: 70258 RVA: 0x000951EB File Offset: 0x000933EB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005929 RID: 22825
			// (get) Token: 0x06011273 RID: 70259 RVA: 0x003F4D88 File Offset: 0x003F2F88
			// (set) Token: 0x06011274 RID: 70260 RVA: 0x00095206 File Offset: 0x00093406
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700592A RID: 22826
			// (get) Token: 0x06011275 RID: 70261 RVA: 0x003F4DB8 File Offset: 0x003F2FB8
			// (set) Token: 0x06011276 RID: 70262 RVA: 0x00095234 File Offset: 0x00093434
			public unsafe DLC5_CreatorsBoxPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_CreatorsBoxPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700592B RID: 22827
			// (get) Token: 0x06011277 RID: 70263 RVA: 0x003F4DE8 File Offset: 0x003F2FE8
			// (set) Token: 0x06011278 RID: 70264 RVA: 0x00095253 File Offset: 0x00093453
			public UniTask<Nullable<int>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___u__1);
					return new UniTask<Nullable<int>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_CreatorsBoxPanel.__OnPanelInitialize_b__36_7_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AD7F RID: 44415
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AD80 RID: 44416
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AD81 RID: 44417
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD82 RID: 44418
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AD83 RID: 44419
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AD84 RID: 44420
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
