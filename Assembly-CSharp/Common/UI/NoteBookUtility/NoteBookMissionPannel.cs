using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.Profile.SchedulerNodeCollection;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Reflection;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x0200039D RID: 925
	public class NoteBookMissionPannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x06006F4F RID: 28495 RVA: 0x0021122C File Offset: 0x0020F42C
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookMissionPannel()
		{
			Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookMissionPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr);
			NoteBookMissionPannel.NativeFieldInfoPtr_START_LOOP_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "START_LOOP_COUNT");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_ActionExecutionScheduler");
			NoteBookMissionPannel.NativeFieldInfoPtr_missionObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "missionObject");
			NoteBookMissionPannel.NativeFieldInfoPtr_conditionObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "conditionObject");
			NoteBookMissionPannel.NativeFieldInfoPtr_MissionObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "MissionObjectField");
			NoteBookMissionPannel.NativeFieldInfoPtr_subPannelReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "subPannelReference");
			NoteBookMissionPannel.NativeFieldInfoPtr_detailPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "detailPannel");
			NoteBookMissionPannel.NativeFieldInfoPtr_nullPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "nullPannel");
			NoteBookMissionPannel.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "selected");
			NoteBookMissionPannel.NativeFieldInfoPtr_subSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "subSelected");
			NoteBookMissionPannel.NativeFieldInfoPtr_fillters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "fillters");
			NoteBookMissionPannel.NativeFieldInfoPtr_CacheTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "CacheTransform");
			NoteBookMissionPannel.NativeFieldInfoPtr_progressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "progressIndicator");
			NoteBookMissionPannel.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "title");
			NoteBookMissionPannel.NativeFieldInfoPtr_missionSenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "missionSenderData");
			NoteBookMissionPannel.NativeFieldInfoPtr_missionReceiverAndTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "missionReceiverAndTimeData");
			NoteBookMissionPannel.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "description");
			NoteBookMissionPannel.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "condition");
			NoteBookMissionPannel.NativeFieldInfoPtr_conditionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "conditionField");
			NoteBookMissionPannel.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "reward");
			NoteBookMissionPannel.NativeFieldInfoPtr_rewardTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "rewardTitle");
			NoteBookMissionPannel.NativeFieldInfoPtr_rewardField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "rewardField");
			NoteBookMissionPannel.NativeFieldInfoPtr_fontName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "fontName");
			NoteBookMissionPannel.NativeFieldInfoPtr_trackingMissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "trackingMissionColor");
			NoteBookMissionPannel.NativeFieldInfoPtr_fulFilledMissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "fulFilledMissionColor");
			NoteBookMissionPannel.NativeFieldInfoPtr_finishedMissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "finishedMissionColor");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_CurrentAllMissionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_CurrentAllMissionData");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_LastAllMissionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_LastAllMissionData");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_AllConditionButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_AllConditionButton");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_AllConditionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_AllConditionInstances");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_AllMissionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_AllMissionInstances");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_AllRewardInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_AllRewardInstances");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_FirstToFocusMissionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_FirstToFocusMissionData");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_LastTrackingMissionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_LastTrackingMissionData");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_MissionDataFilterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_MissionDataFilterType");
			NoteBookMissionPannel.NativeFieldInfoPtr_m_MissionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "m_MissionGroup");
			NoteBookMissionPannel.NativeFieldInfoPtr__CharacterFillter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<CharacterFillter>k__BackingField");
			NoteBookMissionPannel.NativeMethodInfoPtr_get_CharacterFillter_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686008);
			NoteBookMissionPannel.NativeMethodInfoPtr_set_CharacterFillter_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686009);
			NoteBookMissionPannel.NativeMethodInfoPtr_set_FirstToFocusMissionData_Public_set_Void_TrackedMissionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686010);
			NoteBookMissionPannel.NativeMethodInfoPtr_get_FontName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686011);
			NoteBookMissionPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686012);
			NoteBookMissionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686013);
			NoteBookMissionPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686014);
			NoteBookMissionPannel.NativeMethodInfoPtr_SwitchMode_Private_Void_MissionDataFillterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686015);
			NoteBookMissionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686016);
			NoteBookMissionPannel.NativeMethodInfoPtr_RefreshMissionElements_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686017);
			NoteBookMissionPannel.NativeMethodInfoPtr_UpdateRightPanel_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686018);
			NoteBookMissionPannel.NativeMethodInfoPtr_UpdateMissionItemVisual_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686019);
			NoteBookMissionPannel.NativeMethodInfoPtr_RegNullInput_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686020);
			NoteBookMissionPannel.NativeMethodInfoPtr_OnCancelInvoked_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686021);
			NoteBookMissionPannel.NativeMethodInfoPtr_FormatKeyData_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686022);
			NoteBookMissionPannel.NativeMethodInfoPtr_DescribeMission_Private_Void_TrackedMissionData_UIButtonSimple_MissionStatus_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686023);
			NoteBookMissionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686024);
			NoteBookMissionPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686025);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686026);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686027);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686028);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_10_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686029);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686030);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686031);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686032);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686033);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686034);
			NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_8_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686035);
			NoteBookMissionPannel.NativeMethodInfoPtr__RefreshMissionElements_b__50_1_Private_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686036);
			NoteBookMissionPannel.NativeMethodInfoPtr__RefreshMissionElements_b__50_2_Private_Boolean_FinishCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686037);
			NoteBookMissionPannel.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, 100686038);
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06006F50 RID: 28496 RVA: 0x002117AC File Offset: 0x0020F9AC
		// (set) Token: 0x06006F51 RID: 28497 RVA: 0x002117E4 File Offset: 0x0020F9E4
		public unsafe string CharacterFillter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 87732, RefRangeEnd = 87742, XrefRangeStart = 87732, XrefRangeEnd = 87742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_get_CharacterFillter_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_set_CharacterFillter_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002652 RID: 9810
		// (set) Token: 0x06006F52 RID: 28498 RVA: 0x00211828 File Offset: 0x0020FA28
		public unsafe RunTimeScheduler.TrackedMissionData FirstToFocusMissionData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_set_FirstToFocusMissionData_Public_set_Void_TrackedMissionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x06006F53 RID: 28499 RVA: 0x0021186C File Offset: 0x0020FA6C
		public unsafe string FontName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278894, XrefRangeEnd = 278896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_get_FontName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x06006F54 RID: 28500 RVA: 0x002118A4 File Offset: 0x0020FAA4
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMissionPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x002118EC File Offset: 0x0020FAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278896, XrefRangeEnd = 278975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMissionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00211928 File Offset: 0x0020FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278975, XrefRangeEnd = 278986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMissionPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x00211964 File Offset: 0x0020FB64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 279002, RefRangeEnd = 279007, XrefRangeStart = 278986, XrefRangeEnd = 279002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchMode(RunTimeScheduler.MissionDataFillterType mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_SwitchMode_Private_Void_MissionDataFillterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x002119A4 File Offset: 0x0020FBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279007, XrefRangeEnd = 279019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMissionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x002119E0 File Offset: 0x0020FBE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279100, RefRangeEnd = 279103, XrefRangeStart = 279019, XrefRangeEnd = 279100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshMissionElements(bool preserveOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_RefreshMissionElements_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x00211A20 File Offset: 0x0020FC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279103, XrefRangeEnd = 279106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRightPanel(bool hasAnyMissionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hasAnyMissionData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_UpdateRightPanel_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x00211A60 File Offset: 0x0020FC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279174, RefRangeEnd = 279175, XrefRangeStart = 279106, XrefRangeEnd = 279174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMissionItemVisual(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> missionData, UIElementCluster cluster)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(missionData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_UpdateMissionItemVisual_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x00211ABC File Offset: 0x0020FCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279183, RefRangeEnd = 279184, XrefRangeStart = 279175, XrefRangeEnd = 279183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegNullInput(bool doReg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doReg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_RegNullInput_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00211AFC File Offset: 0x0020FCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279184, XrefRangeEnd = 279187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCancelInvoked(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_OnCancelInvoked_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x00211B44 File Offset: 0x0020FD44
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279223, RefRangeEnd = 279230, XrefRangeStart = 279187, XrefRangeEnd = 279223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatKeyData(string original)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(original);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_FormatKeyData_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x00211B8C File Offset: 0x0020FD8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279539, RefRangeEnd = 279540, XrefRangeStart = 279230, XrefRangeEnd = 279539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeMission(RunTimeScheduler.TrackedMissionData trackedMission, UIButtonSimple left, RunTimeScheduler.MissionStatus missionStatus, Action refreshMissionVisualHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trackedMission);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missionStatus;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refreshMissionVisualHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr_DescribeMission_Private_Void_TrackedMissionData_UIButtonSimple_MissionStatus_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x00211C04 File Offset: 0x0020FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279540, XrefRangeEnd = 279577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMissionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x00211C40 File Offset: 0x0020FE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279577, XrefRangeEnd = 279622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookMissionPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x00211C7C File Offset: 0x0020FE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279622, XrefRangeEnd = 279646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_0(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> missionData, UIElementCluster cluster, UIButtonSimple interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(missionData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(interactable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x00211CE8 File Offset: 0x0020FEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279646, XrefRangeEnd = 279698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_1(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> missionData, UIElementCluster _, UIButtonSimple interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(missionData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(interactable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x00211D54 File Offset: 0x0020FF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279698, XrefRangeEnd = 279701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x00211D88 File Offset: 0x0020FF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279701, XrefRangeEnd = 279705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_10(MoveDirection dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_10_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x00211DC8 File Offset: 0x0020FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279705, XrefRangeEnd = 279706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00211DFC File Offset: 0x0020FFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279706, XrefRangeEnd = 279707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00211E30 File Offset: 0x00210030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279707, XrefRangeEnd = 279708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x00211E64 File Offset: 0x00210064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279708, XrefRangeEnd = 279709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x00211E98 File Offset: 0x00210098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279709, XrefRangeEnd = 279710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00211ECC File Offset: 0x002100CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279710, XrefRangeEnd = 279723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_8(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_8_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x00211F14 File Offset: 0x00210114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279723, XrefRangeEnd = 279728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RefreshMissionElements_b__50_1(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__RefreshMissionElements_b__50_1_Private_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x00211F68 File Offset: 0x00210168
		[CallerCount(0)]
		public unsafe bool _RefreshMissionElements_b__50_2(MissionNode.FinishCondition y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.NativeMethodInfoPtr__RefreshMissionElements_b__50_2_Private_Boolean_FinishCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x00211FBC File Offset: 0x002101BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279728, XrefRangeEnd = 279736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Int32_Int32_PDM_0<T>(int current, int total) where T : NonTradableObjectBase
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.MethodInfoStoreGeneric_Method_Internal_Static_String_Int32_Int32_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x0003C62B File Offset: 0x0003A82B
		public NoteBookMissionPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06006F70 RID: 28528 RVA: 0x00212004 File Offset: 0x00210204
		// (set) Token: 0x06006F71 RID: 28529 RVA: 0x0003C634 File Offset: 0x0003A834
		public unsafe static int START_LOOP_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.NativeFieldInfoPtr_START_LOOP_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.NativeFieldInfoPtr_START_LOOP_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x00212020 File Offset: 0x00210220
		// (set) Token: 0x06006F73 RID: 28531 RVA: 0x0003C642 File Offset: 0x0003A842
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x06006F74 RID: 28532 RVA: 0x00212050 File Offset: 0x00210250
		// (set) Token: 0x06006F75 RID: 28533 RVA: 0x0003C661 File Offset: 0x0003A861
		public unsafe GameObject missionObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_missionObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_missionObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x00212080 File Offset: 0x00210280
		// (set) Token: 0x06006F77 RID: 28535 RVA: 0x0003C680 File Offset: 0x0003A880
		public unsafe GameObject conditionObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_conditionObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_conditionObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x002120B0 File Offset: 0x002102B0
		// (set) Token: 0x06006F79 RID: 28537 RVA: 0x0003C69F File Offset: 0x0003A89F
		public unsafe VerticalLayoutGroup MissionObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_MissionObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_MissionObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x002120E0 File Offset: 0x002102E0
		// (set) Token: 0x06006F7B RID: 28539 RVA: 0x0003C6BE File Offset: 0x0003A8BE
		public unsafe SubmissionPanel subPannelReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_subPannelReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_subPannelReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06006F7C RID: 28540 RVA: 0x00212110 File Offset: 0x00210310
		// (set) Token: 0x06006F7D RID: 28541 RVA: 0x0003C6DD File Offset: 0x0003A8DD
		public unsafe CanvasGroup detailPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_detailPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_detailPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06006F7E RID: 28542 RVA: 0x00212140 File Offset: 0x00210340
		// (set) Token: 0x06006F7F RID: 28543 RVA: 0x0003C6FC File Offset: 0x0003A8FC
		public unsafe CanvasGroup nullPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_nullPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_nullPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x00212170 File Offset: 0x00210370
		// (set) Token: 0x06006F81 RID: 28545 RVA: 0x0003C71B File Offset: 0x0003A91B
		public unsafe CanvasGroup selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06006F82 RID: 28546 RVA: 0x002121A0 File Offset: 0x002103A0
		// (set) Token: 0x06006F83 RID: 28547 RVA: 0x0003C73A File Offset: 0x0003A93A
		public unsafe CanvasGroup subSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_subSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_subSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x002121D0 File Offset: 0x002103D0
		// (set) Token: 0x06006F85 RID: 28549 RVA: 0x0003C759 File Offset: 0x0003A959
		public unsafe Il2CppReferenceArray<UIButtonToggle> fillters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_fillters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_fillters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x00212200 File Offset: 0x00210400
		// (set) Token: 0x06006F87 RID: 28551 RVA: 0x0003C778 File Offset: 0x0003A978
		public unsafe RectTransform CacheTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_CacheTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_CacheTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x00212230 File Offset: 0x00210430
		// (set) Token: 0x06006F89 RID: 28553 RVA: 0x0003C797 File Offset: 0x0003A997
		public unsafe AdpProgressIndicatorComponent progressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_progressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_progressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x00212260 File Offset: 0x00210460
		// (set) Token: 0x06006F8B RID: 28555 RVA: 0x0003C7B6 File Offset: 0x0003A9B6
		public unsafe TextMeshProUGUI title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06006F8C RID: 28556 RVA: 0x00212290 File Offset: 0x00210490
		// (set) Token: 0x06006F8D RID: 28557 RVA: 0x0003C7D5 File Offset: 0x0003A9D5
		public unsafe TextMeshProUGUI missionSenderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_missionSenderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_missionSenderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x002122C0 File Offset: 0x002104C0
		// (set) Token: 0x06006F8F RID: 28559 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		public unsafe TextMeshProUGUI missionReceiverAndTimeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_missionReceiverAndTimeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_missionReceiverAndTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x002122F0 File Offset: 0x002104F0
		// (set) Token: 0x06006F91 RID: 28561 RVA: 0x0003C813 File Offset: 0x0003AA13
		public unsafe TextMeshProUGUI description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x06006F92 RID: 28562 RVA: 0x00212320 File Offset: 0x00210520
		// (set) Token: 0x06006F93 RID: 28563 RVA: 0x0003C832 File Offset: 0x0003AA32
		public unsafe GameObject condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_condition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06006F94 RID: 28564 RVA: 0x00212350 File Offset: 0x00210550
		// (set) Token: 0x06006F95 RID: 28565 RVA: 0x0003C851 File Offset: 0x0003AA51
		public unsafe RectTransform conditionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_conditionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_conditionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06006F96 RID: 28566 RVA: 0x00212380 File Offset: 0x00210580
		// (set) Token: 0x06006F97 RID: 28567 RVA: 0x0003C870 File Offset: 0x0003AA70
		public unsafe GameObject reward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_reward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x002123B0 File Offset: 0x002105B0
		// (set) Token: 0x06006F99 RID: 28569 RVA: 0x0003C88F File Offset: 0x0003AA8F
		public unsafe GameObject rewardTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_rewardTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_rewardTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x002123E0 File Offset: 0x002105E0
		// (set) Token: 0x06006F9B RID: 28571 RVA: 0x0003C8AE File Offset: 0x0003AAAE
		public unsafe RectTransform rewardField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_rewardField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_rewardField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x06006F9C RID: 28572 RVA: 0x00212410 File Offset: 0x00210610
		// (set) Token: 0x06006F9D RID: 28573 RVA: 0x0003C8CD File Offset: 0x0003AACD
		public unsafe MultiLanguageTextMesh.MultiLanguageString fontName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_fontName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_fontName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06006F9E RID: 28574 RVA: 0x00212440 File Offset: 0x00210640
		// (set) Token: 0x06006F9F RID: 28575 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		public unsafe Color32 trackingMissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_trackingMissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_trackingMissionColor)) = value;
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06006FA0 RID: 28576 RVA: 0x00212468 File Offset: 0x00210668
		// (set) Token: 0x06006FA1 RID: 28577 RVA: 0x0003C907 File Offset: 0x0003AB07
		public unsafe Color32 fulFilledMissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_fulFilledMissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_fulFilledMissionColor)) = value;
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x00212490 File Offset: 0x00210690
		// (set) Token: 0x06006FA3 RID: 28579 RVA: 0x0003C922 File Offset: 0x0003AB22
		public unsafe Color32 finishedMissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_finishedMissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_finishedMissionColor)) = value;
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x002124B8 File Offset: 0x002106B8
		// (set) Token: 0x06006FA5 RID: 28581 RVA: 0x0003C93D File Offset: 0x0003AB3D
		public unsafe List<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> m_CurrentAllMissionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_CurrentAllMissionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_CurrentAllMissionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x002124E8 File Offset: 0x002106E8
		// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x0003C95C File Offset: 0x0003AB5C
		public unsafe List<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> m_LastAllMissionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_LastAllMissionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_LastAllMissionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x00212518 File Offset: 0x00210718
		// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x0003C97B File Offset: 0x0003AB7B
		public unsafe List<UIButtonSimple> m_AllConditionButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllConditionButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllConditionButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x00212548 File Offset: 0x00210748
		// (set) Token: 0x06006FAB RID: 28587 RVA: 0x0003C99A File Offset: 0x0003AB9A
		public unsafe List<GameObject> m_AllConditionInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllConditionInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllConditionInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00212578 File Offset: 0x00210778
		// (set) Token: 0x06006FAD RID: 28589 RVA: 0x0003C9B9 File Offset: 0x0003ABB9
		public unsafe List<GameObject> m_AllMissionInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllMissionInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllMissionInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x002125A8 File Offset: 0x002107A8
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		public unsafe List<GameObject> m_AllRewardInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllRewardInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_AllRewardInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x002125D8 File Offset: 0x002107D8
		// (set) Token: 0x06006FB1 RID: 28593 RVA: 0x0003C9F7 File Offset: 0x0003ABF7
		public unsafe RunTimeScheduler.TrackedMissionData m_FirstToFocusMissionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_FirstToFocusMissionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeScheduler.TrackedMissionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_FirstToFocusMissionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x00212608 File Offset: 0x00210808
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x0003CA16 File Offset: 0x0003AC16
		public unsafe RunTimeScheduler.TrackedMissionData m_LastTrackingMissionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_LastTrackingMissionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeScheduler.TrackedMissionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_LastTrackingMissionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x00212638 File Offset: 0x00210838
		// (set) Token: 0x06006FB5 RID: 28597 RVA: 0x0003CA35 File Offset: 0x0003AC35
		public Nullable<RunTimeScheduler.MissionDataFillterType> m_MissionDataFilterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_MissionDataFilterType);
				return new Nullable<RunTimeScheduler.MissionDataFillterType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RunTimeScheduler.MissionDataFillterType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_MissionDataFilterType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RunTimeScheduler.MissionDataFillterType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x06006FB6 RID: 28598 RVA: 0x00212668 File Offset: 0x00210868
		// (set) Token: 0x06006FB7 RID: 28599 RVA: 0x0003CA63 File Offset: 0x0003AC63
		public unsafe StaticVirtualScrollListUILogicalGroupT<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>, UIElementCluster, UIButtonSimple> m_MissionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_MissionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr_m_MissionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x06006FB8 RID: 28600 RVA: 0x00212698 File Offset: 0x00210898
		// (set) Token: 0x06006FB9 RID: 28601 RVA: 0x0003CA82 File Offset: 0x0003AC82
		public unsafe string _CharacterFillter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr__CharacterFillter_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.NativeFieldInfoPtr__CharacterFillter_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040049BC RID: 18876
		private static readonly IntPtr NativeFieldInfoPtr_START_LOOP_COUNT;

		// Token: 0x040049BD RID: 18877
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x040049BE RID: 18878
		private static readonly IntPtr NativeFieldInfoPtr_missionObject;

		// Token: 0x040049BF RID: 18879
		private static readonly IntPtr NativeFieldInfoPtr_conditionObject;

		// Token: 0x040049C0 RID: 18880
		private static readonly IntPtr NativeFieldInfoPtr_MissionObjectField;

		// Token: 0x040049C1 RID: 18881
		private static readonly IntPtr NativeFieldInfoPtr_subPannelReference;

		// Token: 0x040049C2 RID: 18882
		private static readonly IntPtr NativeFieldInfoPtr_detailPannel;

		// Token: 0x040049C3 RID: 18883
		private static readonly IntPtr NativeFieldInfoPtr_nullPannel;

		// Token: 0x040049C4 RID: 18884
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x040049C5 RID: 18885
		private static readonly IntPtr NativeFieldInfoPtr_subSelected;

		// Token: 0x040049C6 RID: 18886
		private static readonly IntPtr NativeFieldInfoPtr_fillters;

		// Token: 0x040049C7 RID: 18887
		private static readonly IntPtr NativeFieldInfoPtr_CacheTransform;

		// Token: 0x040049C8 RID: 18888
		private static readonly IntPtr NativeFieldInfoPtr_progressIndicator;

		// Token: 0x040049C9 RID: 18889
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040049CA RID: 18890
		private static readonly IntPtr NativeFieldInfoPtr_missionSenderData;

		// Token: 0x040049CB RID: 18891
		private static readonly IntPtr NativeFieldInfoPtr_missionReceiverAndTimeData;

		// Token: 0x040049CC RID: 18892
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x040049CD RID: 18893
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x040049CE RID: 18894
		private static readonly IntPtr NativeFieldInfoPtr_conditionField;

		// Token: 0x040049CF RID: 18895
		private static readonly IntPtr NativeFieldInfoPtr_reward;

		// Token: 0x040049D0 RID: 18896
		private static readonly IntPtr NativeFieldInfoPtr_rewardTitle;

		// Token: 0x040049D1 RID: 18897
		private static readonly IntPtr NativeFieldInfoPtr_rewardField;

		// Token: 0x040049D2 RID: 18898
		private static readonly IntPtr NativeFieldInfoPtr_fontName;

		// Token: 0x040049D3 RID: 18899
		private static readonly IntPtr NativeFieldInfoPtr_trackingMissionColor;

		// Token: 0x040049D4 RID: 18900
		private static readonly IntPtr NativeFieldInfoPtr_fulFilledMissionColor;

		// Token: 0x040049D5 RID: 18901
		private static readonly IntPtr NativeFieldInfoPtr_finishedMissionColor;

		// Token: 0x040049D6 RID: 18902
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAllMissionData;

		// Token: 0x040049D7 RID: 18903
		private static readonly IntPtr NativeFieldInfoPtr_m_LastAllMissionData;

		// Token: 0x040049D8 RID: 18904
		private static readonly IntPtr NativeFieldInfoPtr_m_AllConditionButton;

		// Token: 0x040049D9 RID: 18905
		private static readonly IntPtr NativeFieldInfoPtr_m_AllConditionInstances;

		// Token: 0x040049DA RID: 18906
		private static readonly IntPtr NativeFieldInfoPtr_m_AllMissionInstances;

		// Token: 0x040049DB RID: 18907
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRewardInstances;

		// Token: 0x040049DC RID: 18908
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstToFocusMissionData;

		// Token: 0x040049DD RID: 18909
		private static readonly IntPtr NativeFieldInfoPtr_m_LastTrackingMissionData;

		// Token: 0x040049DE RID: 18910
		private static readonly IntPtr NativeFieldInfoPtr_m_MissionDataFilterType;

		// Token: 0x040049DF RID: 18911
		private static readonly IntPtr NativeFieldInfoPtr_m_MissionGroup;

		// Token: 0x040049E0 RID: 18912
		private static readonly IntPtr NativeFieldInfoPtr__CharacterFillter_k__BackingField;

		// Token: 0x040049E1 RID: 18913
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterFillter_Private_get_String_0;

		// Token: 0x040049E2 RID: 18914
		private static readonly IntPtr NativeMethodInfoPtr_set_CharacterFillter_Public_set_Void_String_0;

		// Token: 0x040049E3 RID: 18915
		private static readonly IntPtr NativeMethodInfoPtr_set_FirstToFocusMissionData_Public_set_Void_TrackedMissionData_0;

		// Token: 0x040049E4 RID: 18916
		private static readonly IntPtr NativeMethodInfoPtr_get_FontName_Private_get_String_0;

		// Token: 0x040049E5 RID: 18917
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040049E6 RID: 18918
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040049E7 RID: 18919
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040049E8 RID: 18920
		private static readonly IntPtr NativeMethodInfoPtr_SwitchMode_Private_Void_MissionDataFillterType_0;

		// Token: 0x040049E9 RID: 18921
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040049EA RID: 18922
		private static readonly IntPtr NativeMethodInfoPtr_RefreshMissionElements_Private_Void_Boolean_0;

		// Token: 0x040049EB RID: 18923
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRightPanel_Private_Void_Boolean_0;

		// Token: 0x040049EC RID: 18924
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMissionItemVisual_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_0;

		// Token: 0x040049ED RID: 18925
		private static readonly IntPtr NativeMethodInfoPtr_RegNullInput_Private_Void_Boolean_0;

		// Token: 0x040049EE RID: 18926
		private static readonly IntPtr NativeMethodInfoPtr_OnCancelInvoked_Private_Void_CallbackContext_0;

		// Token: 0x040049EF RID: 18927
		private static readonly IntPtr NativeMethodInfoPtr_FormatKeyData_Private_String_String_0;

		// Token: 0x040049F0 RID: 18928
		private static readonly IntPtr NativeMethodInfoPtr_DescribeMission_Private_Void_TrackedMissionData_UIButtonSimple_MissionStatus_Action_0;

		// Token: 0x040049F1 RID: 18929
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040049F2 RID: 18930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040049F3 RID: 18931
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040049F4 RID: 18932
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Private_Void_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040049F5 RID: 18933
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_9_Private_Void_0;

		// Token: 0x040049F6 RID: 18934
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_10_Private_Void_MoveDirection_0;

		// Token: 0x040049F7 RID: 18935
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_0;

		// Token: 0x040049F8 RID: 18936
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0;

		// Token: 0x040049F9 RID: 18937
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_5_Private_Void_0;

		// Token: 0x040049FA RID: 18938
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_6_Private_Void_0;

		// Token: 0x040049FB RID: 18939
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_7_Private_Void_0;

		// Token: 0x040049FC RID: 18940
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_8_Private_Void_CallbackContext_0;

		// Token: 0x040049FD RID: 18941
		private static readonly IntPtr NativeMethodInfoPtr__RefreshMissionElements_b__50_1_Private_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0;

		// Token: 0x040049FE RID: 18942
		private static readonly IntPtr NativeMethodInfoPtr__RefreshMissionElements_b__50_2_Private_Boolean_FinishCondition_0;

		// Token: 0x040049FF RID: 18943
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Int32_Int32_PDM_0;

		// Token: 0x02000EE2 RID: 3810
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
		{
			// Token: 0x06010BAB RID: 68523 RVA: 0x003DEE00 File Offset: 0x003DD000
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, "interactable");
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr_missionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, "missionData");
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___9__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, "<>9__14");
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___9__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, "<>9__13");
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, 100686039);
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, 100686040);
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, 100686041);
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, 100686042);
				NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr, 100686043);
			}

			// Token: 0x06010BAC RID: 68524 RVA: 0x003DEEF4 File Offset: 0x003DD0F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BAD RID: 68525 RVA: 0x003DEF30 File Offset: 0x003DD130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277939, XrefRangeEnd = 277948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BAE RID: 68526 RVA: 0x003DEF64 File Offset: 0x003DD164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277948, XrefRangeEnd = 277958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BAF RID: 68527 RVA: 0x003DEF98 File Offset: 0x003DD198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277958, XrefRangeEnd = 277970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BB0 RID: 68528 RVA: 0x003DEFCC File Offset: 0x003DD1CC
			[CallerCount(0)]
			public unsafe bool _OnPanelInitialize_b__14(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010BB1 RID: 68529 RVA: 0x00091D87 File Offset: 0x0008FF87
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700572D RID: 22317
			// (get) Token: 0x06010BB2 RID: 68530 RVA: 0x003DF020 File Offset: 0x003DD220
			// (set) Token: 0x06010BB3 RID: 68531 RVA: 0x00091D90 File Offset: 0x0008FF90
			public unsafe UIButtonSimple interactable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr_interactable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700572E RID: 22318
			// (get) Token: 0x06010BB4 RID: 68532 RVA: 0x003DF050 File Offset: 0x003DD250
			// (set) Token: 0x06010BB5 RID: 68533 RVA: 0x00091DAF File Offset: 0x0008FFAF
			public ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> missionData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr_missionData);
					return new ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr_missionData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700572F RID: 22319
			// (get) Token: 0x06010BB6 RID: 68534 RVA: 0x003DF080 File Offset: 0x003DD280
			// (set) Token: 0x06010BB7 RID: 68535 RVA: 0x00091DDD File Offset: 0x0008FFDD
			public unsafe NoteBookMissionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005730 RID: 22320
			// (get) Token: 0x06010BB8 RID: 68536 RVA: 0x003DF0B0 File Offset: 0x003DD2B0
			// (set) Token: 0x06010BB9 RID: 68537 RVA: 0x00091DFC File Offset: 0x0008FFFC
			public unsafe Predicate<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> __9__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___9__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___9__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005731 RID: 22321
			// (get) Token: 0x06010BBA RID: 68538 RVA: 0x003DF0E0 File Offset: 0x003DD2E0
			// (set) Token: 0x06010BBB RID: 68539 RVA: 0x00091E1B File Offset: 0x0009001B
			public unsafe Action __9__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___9__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass46_0.NativeFieldInfoPtr___9__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A94A RID: 43338
			private static readonly IntPtr NativeFieldInfoPtr_interactable;

			// Token: 0x0400A94B RID: 43339
			private static readonly IntPtr NativeFieldInfoPtr_missionData;

			// Token: 0x0400A94C RID: 43340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A94D RID: 43341
			private static readonly IntPtr NativeFieldInfoPtr___9__14;

			// Token: 0x0400A94E RID: 43342
			private static readonly IntPtr NativeFieldInfoPtr___9__13;

			// Token: 0x0400A94F RID: 43343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A950 RID: 43344
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_0;

			// Token: 0x0400A951 RID: 43345
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_0;

			// Token: 0x0400A952 RID: 43346
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_0;

			// Token: 0x0400A953 RID: 43347
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0;
		}

		// Token: 0x02000EE3 RID: 3811
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010BBC RID: 68540 RVA: 0x003DF110 File Offset: 0x003DD310
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr);
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__46_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__46_2");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__50_0");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__52_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__52_3");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_0");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_1");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_2");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_3");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_26");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_27");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_29");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_30");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_33");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_34");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_36");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_37");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_40 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_40");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_41 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_41");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_43 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_43");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_44 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_44");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_53 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_53");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_54");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_56");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_57");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_59 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_59");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_60");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_62");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_63");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_48");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_49");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_69 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_69");
				NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_71 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, "<>9__56_71");
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686045);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686046);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__RefreshMissionElements_b__50_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686047);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__UpdateMissionItemVisual_b__52_3_Internal_Boolean_FinishCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686048);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_0_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686049);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_1_Internal_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686050);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_2_Internal_Product_IGrouping_2_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686051);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_3_Internal_Int32_IGrouping_2_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686052);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_19_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686053);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_21_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686054);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_26_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686055);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_27_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686056);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_29_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686057);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_30_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686058);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_33_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686059);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_34_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686060);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_36_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686061);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_37_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686062);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_40_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686063);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_41_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686064);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_43_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686065);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_44_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686066);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_53_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686067);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_54_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686068);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_56_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686069);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_57_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686070);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_59_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686071);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_60_Internal_Void_SellableDescriber_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686072);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_62_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686073);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_63_Internal_Void_SellableDescriber_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686074);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_48_Internal_Void_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686075);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_49_Internal_Void_SellableDescriber_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686076);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_69_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686077);
				NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_71_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr, 100686078);
			}

			// Token: 0x06010BBD RID: 68541 RVA: 0x003DF664 File Offset: 0x003DD864
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BBE RID: 68542 RVA: 0x003DF6A0 File Offset: 0x003DD8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277970, XrefRangeEnd = 277971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__46_2(UIButtonToggle toggle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BBF RID: 68543 RVA: 0x003DF6E4 File Offset: 0x003DD8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshMissionElements_b__50_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__RefreshMissionElements_b__50_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BC0 RID: 68544 RVA: 0x003DF728 File Offset: 0x003DD928
			[CallerCount(0)]
			public unsafe bool _UpdateMissionItemVisual_b__52_3(MissionNode.FinishCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__UpdateMissionItemVisual_b__52_3_Internal_Boolean_FinishCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010BC1 RID: 68545 RVA: 0x003DF77C File Offset: 0x003DD97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277971, XrefRangeEnd = 277974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<MissionNode.FinishCondition, bool> _DescribeMission_b__56_0(MissionNode.FinishCondition a, bool b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_0_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<MissionNode.FinishCondition, bool>(pointer);
			}

			// Token: 0x06010BC2 RID: 68546 RVA: 0x003DF7D8 File Offset: 0x003DD9D8
			[CallerCount(0)]
			public unsafe Product _DescribeMission_b__56_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_1_Internal_Product_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x06010BC3 RID: 68547 RVA: 0x003DF828 File Offset: 0x003DDA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277974, XrefRangeEnd = 277977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _DescribeMission_b__56_2(IGrouping<Product, Product> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_2_Internal_Product_IGrouping_2_Product_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x06010BC4 RID: 68548 RVA: 0x003DF870 File Offset: 0x003DDA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277977, XrefRangeEnd = 277980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DescribeMission_b__56_3(IGrouping<Product, Product> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_3_Internal_Int32_IGrouping_2_Product_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010BC5 RID: 68549 RVA: 0x003DF8C0 File Offset: 0x003DDAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277980, XrefRangeEnd = 277983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<NonTradableObjectBase, int> _DescribeMission_b__56_19<T>(KeyValuePair<T, int> x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.MethodInfoStoreGeneric__DescribeMission_b__56_19_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<NonTradableObjectBase, int>(pointer);
			}

			// Token: 0x06010BC6 RID: 68550 RVA: 0x003DF910 File Offset: 0x003DDB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277983, XrefRangeEnd = 277986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<MissionNode.FinishCondition, bool> _DescribeMission_b__56_21<T>(MissionNode.FinishCondition a, bool b) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.MethodInfoStoreGeneric__DescribeMission_b__56_21_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<MissionNode.FinishCondition, bool>(pointer);
			}

			// Token: 0x06010BC7 RID: 68551 RVA: 0x003DF96C File Offset: 0x003DDB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277986, XrefRangeEnd = 277988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_26(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_26_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BC8 RID: 68552 RVA: 0x003DF9B0 File Offset: 0x003DDBB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277988, XrefRangeEnd = 277990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_27(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_27_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BC9 RID: 68553 RVA: 0x003DFA04 File Offset: 0x003DDC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_29(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_29_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BCA RID: 68554 RVA: 0x003DFA48 File Offset: 0x003DDC48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_30(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_30_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BCB RID: 68555 RVA: 0x003DFA9C File Offset: 0x003DDC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_33(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_33_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BCC RID: 68556 RVA: 0x003DFAE0 File Offset: 0x003DDCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_34(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_34_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BCD RID: 68557 RVA: 0x003DFB34 File Offset: 0x003DDD34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_36(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_36_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BCE RID: 68558 RVA: 0x003DFB78 File Offset: 0x003DDD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_37(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_37_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BCF RID: 68559 RVA: 0x003DFBCC File Offset: 0x003DDDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_40(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_40_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD0 RID: 68560 RVA: 0x003DFC10 File Offset: 0x003DDE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_41(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_41_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD1 RID: 68561 RVA: 0x003DFC64 File Offset: 0x003DDE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_43(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_43_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD2 RID: 68562 RVA: 0x003DFCA8 File Offset: 0x003DDEA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_44(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_44_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD3 RID: 68563 RVA: 0x003DFCFC File Offset: 0x003DDEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_53(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_53_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD4 RID: 68564 RVA: 0x003DFD40 File Offset: 0x003DDF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_54(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_54_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD5 RID: 68565 RVA: 0x003DFD94 File Offset: 0x003DDF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_56(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_56_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD6 RID: 68566 RVA: 0x003DFDD8 File Offset: 0x003DDFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_57(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_57_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD7 RID: 68567 RVA: 0x003DFE2C File Offset: 0x003DE02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277990, XrefRangeEnd = 277992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_59(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_59_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD8 RID: 68568 RVA: 0x003DFE70 File Offset: 0x003DE070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277992, XrefRangeEnd = 277994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_60(SellableDescriber describer, Ingredient item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_60_Internal_Void_SellableDescriber_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BD9 RID: 68569 RVA: 0x003DFEC4 File Offset: 0x003DE0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277994, XrefRangeEnd = 277996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_62(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_62_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BDA RID: 68570 RVA: 0x003DFF08 File Offset: 0x003DE108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277996, XrefRangeEnd = 277999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_63(SellableDescriber describer, Item item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_63_Internal_Void_SellableDescriber_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BDB RID: 68571 RVA: 0x003DFF5C File Offset: 0x003DE15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_48(SellableDescriber describer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_48_Internal_Void_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BDC RID: 68572 RVA: 0x003DFFA0 File Offset: 0x003DE1A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_49(SellableDescriber describer, Sellable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_49_Internal_Void_SellableDescriber_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BDD RID: 68573 RVA: 0x003DFFF4 File Offset: 0x003DE1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_69(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_69_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BDE RID: 68574 RVA: 0x003E0038 File Offset: 0x003DE238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__56_71(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_71_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BDF RID: 68575 RVA: 0x00091E3A File Offset: 0x0009003A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005732 RID: 22322
			// (get) Token: 0x06010BE0 RID: 68576 RVA: 0x003E007C File Offset: 0x003DE27C
			// (set) Token: 0x06010BE1 RID: 68577 RVA: 0x00091E43 File Offset: 0x00090043
			public unsafe static NoteBookMissionPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005733 RID: 22323
			// (get) Token: 0x06010BE2 RID: 68578 RVA: 0x003E00A4 File Offset: 0x003DE2A4
			// (set) Token: 0x06010BE3 RID: 68579 RVA: 0x00091E55 File Offset: 0x00090055
			public unsafe static Action<UIButtonToggle> __9__46_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__46_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__46_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005734 RID: 22324
			// (get) Token: 0x06010BE4 RID: 68580 RVA: 0x003E00CC File Offset: 0x003DE2CC
			// (set) Token: 0x06010BE5 RID: 68581 RVA: 0x00091E67 File Offset: 0x00090067
			public unsafe static Action<GameObject> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005735 RID: 22325
			// (get) Token: 0x06010BE6 RID: 68582 RVA: 0x003E00F4 File Offset: 0x003DE2F4
			// (set) Token: 0x06010BE7 RID: 68583 RVA: 0x00091E79 File Offset: 0x00090079
			public unsafe static Func<MissionNode.FinishCondition, bool> __9__52_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__52_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MissionNode.FinishCondition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__52_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005736 RID: 22326
			// (get) Token: 0x06010BE8 RID: 68584 RVA: 0x003E011C File Offset: 0x003DE31C
			// (set) Token: 0x06010BE9 RID: 68585 RVA: 0x00091E8B File Offset: 0x0009008B
			public unsafe static Func<MissionNode.FinishCondition, bool, ValueTuple<MissionNode.FinishCondition, bool>> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MissionNode.FinishCondition, bool, ValueTuple<MissionNode.FinishCondition, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005737 RID: 22327
			// (get) Token: 0x06010BEA RID: 68586 RVA: 0x003E0144 File Offset: 0x003DE344
			// (set) Token: 0x06010BEB RID: 68587 RVA: 0x00091E9D File Offset: 0x0009009D
			public unsafe static Func<Product, Product> __9__56_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005738 RID: 22328
			// (get) Token: 0x06010BEC RID: 68588 RVA: 0x003E016C File Offset: 0x003DE36C
			// (set) Token: 0x06010BED RID: 68589 RVA: 0x00091EAF File Offset: 0x000900AF
			public unsafe static Func<IGrouping<Product, Product>, Product> __9__56_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Product, Product>, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005739 RID: 22329
			// (get) Token: 0x06010BEE RID: 68590 RVA: 0x003E0194 File Offset: 0x003DE394
			// (set) Token: 0x06010BEF RID: 68591 RVA: 0x00091EC1 File Offset: 0x000900C1
			public unsafe static Func<IGrouping<Product, Product>, int> __9__56_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Product, Product>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700573A RID: 22330
			// (get) Token: 0x06010BF0 RID: 68592 RVA: 0x003E01BC File Offset: 0x003DE3BC
			// (set) Token: 0x06010BF1 RID: 68593 RVA: 0x00091ED3 File Offset: 0x000900D3
			public unsafe static Action<SellableDescriber> __9__56_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700573B RID: 22331
			// (get) Token: 0x06010BF2 RID: 68594 RVA: 0x003E01E4 File Offset: 0x003DE3E4
			// (set) Token: 0x06010BF3 RID: 68595 RVA: 0x00091EE5 File Offset: 0x000900E5
			public unsafe static Action<SellableDescriber, Sellable> __9__56_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700573C RID: 22332
			// (get) Token: 0x06010BF4 RID: 68596 RVA: 0x003E020C File Offset: 0x003DE40C
			// (set) Token: 0x06010BF5 RID: 68597 RVA: 0x00091EF7 File Offset: 0x000900F7
			public unsafe static Action<SellableDescriber> __9__56_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700573D RID: 22333
			// (get) Token: 0x06010BF6 RID: 68598 RVA: 0x003E0234 File Offset: 0x003DE434
			// (set) Token: 0x06010BF7 RID: 68599 RVA: 0x00091F09 File Offset: 0x00090109
			public unsafe static Action<SellableDescriber, Sellable> __9__56_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700573E RID: 22334
			// (get) Token: 0x06010BF8 RID: 68600 RVA: 0x003E025C File Offset: 0x003DE45C
			// (set) Token: 0x06010BF9 RID: 68601 RVA: 0x00091F1B File Offset: 0x0009011B
			public unsafe static Action<SellableDescriber> __9__56_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700573F RID: 22335
			// (get) Token: 0x06010BFA RID: 68602 RVA: 0x003E0284 File Offset: 0x003DE484
			// (set) Token: 0x06010BFB RID: 68603 RVA: 0x00091F2D File Offset: 0x0009012D
			public unsafe static Action<SellableDescriber, Sellable> __9__56_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005740 RID: 22336
			// (get) Token: 0x06010BFC RID: 68604 RVA: 0x003E02AC File Offset: 0x003DE4AC
			// (set) Token: 0x06010BFD RID: 68605 RVA: 0x00091F3F File Offset: 0x0009013F
			public unsafe static Action<SellableDescriber> __9__56_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005741 RID: 22337
			// (get) Token: 0x06010BFE RID: 68606 RVA: 0x003E02D4 File Offset: 0x003DE4D4
			// (set) Token: 0x06010BFF RID: 68607 RVA: 0x00091F51 File Offset: 0x00090151
			public unsafe static Action<SellableDescriber, Sellable> __9__56_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005742 RID: 22338
			// (get) Token: 0x06010C00 RID: 68608 RVA: 0x003E02FC File Offset: 0x003DE4FC
			// (set) Token: 0x06010C01 RID: 68609 RVA: 0x00091F63 File Offset: 0x00090163
			public unsafe static Action<SellableDescriber> __9__56_40
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_40, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_40, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005743 RID: 22339
			// (get) Token: 0x06010C02 RID: 68610 RVA: 0x003E0324 File Offset: 0x003DE524
			// (set) Token: 0x06010C03 RID: 68611 RVA: 0x00091F75 File Offset: 0x00090175
			public unsafe static Action<SellableDescriber, Sellable> __9__56_41
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_41, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_41, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005744 RID: 22340
			// (get) Token: 0x06010C04 RID: 68612 RVA: 0x003E034C File Offset: 0x003DE54C
			// (set) Token: 0x06010C05 RID: 68613 RVA: 0x00091F87 File Offset: 0x00090187
			public unsafe static Action<SellableDescriber> __9__56_43
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_43, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_43, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005745 RID: 22341
			// (get) Token: 0x06010C06 RID: 68614 RVA: 0x003E0374 File Offset: 0x003DE574
			// (set) Token: 0x06010C07 RID: 68615 RVA: 0x00091F99 File Offset: 0x00090199
			public unsafe static Action<SellableDescriber, Sellable> __9__56_44
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_44, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_44, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005746 RID: 22342
			// (get) Token: 0x06010C08 RID: 68616 RVA: 0x003E039C File Offset: 0x003DE59C
			// (set) Token: 0x06010C09 RID: 68617 RVA: 0x00091FAB File Offset: 0x000901AB
			public unsafe static Action<SellableDescriber> __9__56_53
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_53, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_53, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005747 RID: 22343
			// (get) Token: 0x06010C0A RID: 68618 RVA: 0x003E03C4 File Offset: 0x003DE5C4
			// (set) Token: 0x06010C0B RID: 68619 RVA: 0x00091FBD File Offset: 0x000901BD
			public unsafe static Action<SellableDescriber, Sellable> __9__56_54
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_54, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_54, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005748 RID: 22344
			// (get) Token: 0x06010C0C RID: 68620 RVA: 0x003E03EC File Offset: 0x003DE5EC
			// (set) Token: 0x06010C0D RID: 68621 RVA: 0x00091FCF File Offset: 0x000901CF
			public unsafe static Action<SellableDescriber> __9__56_56
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_56, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_56, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005749 RID: 22345
			// (get) Token: 0x06010C0E RID: 68622 RVA: 0x003E0414 File Offset: 0x003DE614
			// (set) Token: 0x06010C0F RID: 68623 RVA: 0x00091FE1 File Offset: 0x000901E1
			public unsafe static Action<SellableDescriber, Sellable> __9__56_57
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_57, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_57, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700574A RID: 22346
			// (get) Token: 0x06010C10 RID: 68624 RVA: 0x003E043C File Offset: 0x003DE63C
			// (set) Token: 0x06010C11 RID: 68625 RVA: 0x00091FF3 File Offset: 0x000901F3
			public unsafe static Action<SellableDescriber> __9__56_59
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_59, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_59, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700574B RID: 22347
			// (get) Token: 0x06010C12 RID: 68626 RVA: 0x003E0464 File Offset: 0x003DE664
			// (set) Token: 0x06010C13 RID: 68627 RVA: 0x00092005 File Offset: 0x00090205
			public unsafe static Action<SellableDescriber, Ingredient> __9__56_60
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_60, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_60, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700574C RID: 22348
			// (get) Token: 0x06010C14 RID: 68628 RVA: 0x003E048C File Offset: 0x003DE68C
			// (set) Token: 0x06010C15 RID: 68629 RVA: 0x00092017 File Offset: 0x00090217
			public unsafe static Action<SellableDescriber> __9__56_62
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_62, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_62, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700574D RID: 22349
			// (get) Token: 0x06010C16 RID: 68630 RVA: 0x003E04B4 File Offset: 0x003DE6B4
			// (set) Token: 0x06010C17 RID: 68631 RVA: 0x00092029 File Offset: 0x00090229
			public unsafe static Action<SellableDescriber, Item> __9__56_63
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_63, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_63, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700574E RID: 22350
			// (get) Token: 0x06010C18 RID: 68632 RVA: 0x003E04DC File Offset: 0x003DE6DC
			// (set) Token: 0x06010C19 RID: 68633 RVA: 0x0009203B File Offset: 0x0009023B
			public unsafe static Action<SellableDescriber> __9__56_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700574F RID: 22351
			// (get) Token: 0x06010C1A RID: 68634 RVA: 0x003E0504 File Offset: 0x003DE704
			// (set) Token: 0x06010C1B RID: 68635 RVA: 0x0009204D File Offset: 0x0009024D
			public unsafe static Action<SellableDescriber, Sellable> __9__56_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005750 RID: 22352
			// (get) Token: 0x06010C1C RID: 68636 RVA: 0x003E052C File Offset: 0x003DE72C
			// (set) Token: 0x06010C1D RID: 68637 RVA: 0x0009205F File Offset: 0x0009025F
			public unsafe static Action<Image> __9__56_69
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_69, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_69, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005751 RID: 22353
			// (get) Token: 0x06010C1E RID: 68638 RVA: 0x003E0554 File Offset: 0x003DE754
			// (set) Token: 0x06010C1F RID: 68639 RVA: 0x00092071 File Offset: 0x00090271
			public unsafe static Action<Image> __9__56_71
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_71, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookMissionPannel.__c.NativeFieldInfoPtr___9__56_71, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A954 RID: 43348
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A955 RID: 43349
			private static readonly IntPtr NativeFieldInfoPtr___9__46_2;

			// Token: 0x0400A956 RID: 43350
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x0400A957 RID: 43351
			private static readonly IntPtr NativeFieldInfoPtr___9__52_3;

			// Token: 0x0400A958 RID: 43352
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x0400A959 RID: 43353
			private static readonly IntPtr NativeFieldInfoPtr___9__56_1;

			// Token: 0x0400A95A RID: 43354
			private static readonly IntPtr NativeFieldInfoPtr___9__56_2;

			// Token: 0x0400A95B RID: 43355
			private static readonly IntPtr NativeFieldInfoPtr___9__56_3;

			// Token: 0x0400A95C RID: 43356
			private static readonly IntPtr NativeFieldInfoPtr___9__56_26;

			// Token: 0x0400A95D RID: 43357
			private static readonly IntPtr NativeFieldInfoPtr___9__56_27;

			// Token: 0x0400A95E RID: 43358
			private static readonly IntPtr NativeFieldInfoPtr___9__56_29;

			// Token: 0x0400A95F RID: 43359
			private static readonly IntPtr NativeFieldInfoPtr___9__56_30;

			// Token: 0x0400A960 RID: 43360
			private static readonly IntPtr NativeFieldInfoPtr___9__56_33;

			// Token: 0x0400A961 RID: 43361
			private static readonly IntPtr NativeFieldInfoPtr___9__56_34;

			// Token: 0x0400A962 RID: 43362
			private static readonly IntPtr NativeFieldInfoPtr___9__56_36;

			// Token: 0x0400A963 RID: 43363
			private static readonly IntPtr NativeFieldInfoPtr___9__56_37;

			// Token: 0x0400A964 RID: 43364
			private static readonly IntPtr NativeFieldInfoPtr___9__56_40;

			// Token: 0x0400A965 RID: 43365
			private static readonly IntPtr NativeFieldInfoPtr___9__56_41;

			// Token: 0x0400A966 RID: 43366
			private static readonly IntPtr NativeFieldInfoPtr___9__56_43;

			// Token: 0x0400A967 RID: 43367
			private static readonly IntPtr NativeFieldInfoPtr___9__56_44;

			// Token: 0x0400A968 RID: 43368
			private static readonly IntPtr NativeFieldInfoPtr___9__56_53;

			// Token: 0x0400A969 RID: 43369
			private static readonly IntPtr NativeFieldInfoPtr___9__56_54;

			// Token: 0x0400A96A RID: 43370
			private static readonly IntPtr NativeFieldInfoPtr___9__56_56;

			// Token: 0x0400A96B RID: 43371
			private static readonly IntPtr NativeFieldInfoPtr___9__56_57;

			// Token: 0x0400A96C RID: 43372
			private static readonly IntPtr NativeFieldInfoPtr___9__56_59;

			// Token: 0x0400A96D RID: 43373
			private static readonly IntPtr NativeFieldInfoPtr___9__56_60;

			// Token: 0x0400A96E RID: 43374
			private static readonly IntPtr NativeFieldInfoPtr___9__56_62;

			// Token: 0x0400A96F RID: 43375
			private static readonly IntPtr NativeFieldInfoPtr___9__56_63;

			// Token: 0x0400A970 RID: 43376
			private static readonly IntPtr NativeFieldInfoPtr___9__56_48;

			// Token: 0x0400A971 RID: 43377
			private static readonly IntPtr NativeFieldInfoPtr___9__56_49;

			// Token: 0x0400A972 RID: 43378
			private static readonly IntPtr NativeFieldInfoPtr___9__56_69;

			// Token: 0x0400A973 RID: 43379
			private static readonly IntPtr NativeFieldInfoPtr___9__56_71;

			// Token: 0x0400A974 RID: 43380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A975 RID: 43381
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_Void_UIButtonToggle_0;

			// Token: 0x0400A976 RID: 43382
			private static readonly IntPtr NativeMethodInfoPtr__RefreshMissionElements_b__50_0_Internal_Void_GameObject_0;

			// Token: 0x0400A977 RID: 43383
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMissionItemVisual_b__52_3_Internal_Boolean_FinishCondition_0;

			// Token: 0x0400A978 RID: 43384
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_0_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0;

			// Token: 0x0400A979 RID: 43385
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_1_Internal_Product_Product_0;

			// Token: 0x0400A97A RID: 43386
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_2_Internal_Product_IGrouping_2_Product_Product_0;

			// Token: 0x0400A97B RID: 43387
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_3_Internal_Int32_IGrouping_2_Product_Product_0;

			// Token: 0x0400A97C RID: 43388
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_19_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0;

			// Token: 0x0400A97D RID: 43389
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_21_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0;

			// Token: 0x0400A97E RID: 43390
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_26_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A97F RID: 43391
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_27_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A980 RID: 43392
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_29_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A981 RID: 43393
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_30_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A982 RID: 43394
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_33_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A983 RID: 43395
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_34_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A984 RID: 43396
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_36_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A985 RID: 43397
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_37_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A986 RID: 43398
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_40_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A987 RID: 43399
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_41_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A988 RID: 43400
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_43_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A989 RID: 43401
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_44_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A98A RID: 43402
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_53_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A98B RID: 43403
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_54_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A98C RID: 43404
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_56_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A98D RID: 43405
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_57_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A98E RID: 43406
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_59_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A98F RID: 43407
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_60_Internal_Void_SellableDescriber_Ingredient_0;

			// Token: 0x0400A990 RID: 43408
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_62_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A991 RID: 43409
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_63_Internal_Void_SellableDescriber_Item_0;

			// Token: 0x0400A992 RID: 43410
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_48_Internal_Void_SellableDescriber_0;

			// Token: 0x0400A993 RID: 43411
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_49_Internal_Void_SellableDescriber_Sellable_0;

			// Token: 0x0400A994 RID: 43412
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_69_Internal_Void_Image_0;

			// Token: 0x0400A995 RID: 43413
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__56_71_Internal_Void_Image_0;

			// Token: 0x020010B9 RID: 4281
			private sealed class MethodInfoStoreGeneric__DescribeMission_b__56_19_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400B872 RID: 47218
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_19_Internal_KeyValuePair_2_NonTradableObjectBase_Int32_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010BA RID: 4282
			private sealed class MethodInfoStoreGeneric__DescribeMission_b__56_21_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0<T>
			{
				// Token: 0x0400B873 RID: 47219
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c.NativeMethodInfoPtr__DescribeMission_b__56_21_Internal_ValueTuple_2_FinishCondition_Boolean_FinishCondition_Boolean_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x02000EE4 RID: 3812
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x06010C20 RID: 68640 RVA: 0x003E057C File Offset: 0x003DE77C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr, "comparer");
				NoteBookMissionPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				NoteBookMissionPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr, 100686079);
				NoteBookMissionPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__RefreshMissionElements_b__3_Internal_Int32_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr, 100686080);
			}

			// Token: 0x06010C21 RID: 68641 RVA: 0x003E05F8 File Offset: 0x003DE7F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C22 RID: 68642 RVA: 0x003E0634 File Offset: 0x003DE834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277999, XrefRangeEnd = 278022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RefreshMissionElements_b__3(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> a, ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__RefreshMissionElements_b__3_Internal_Int32_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C23 RID: 68643 RVA: 0x00092083 File Offset: 0x00090283
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005752 RID: 22354
			// (get) Token: 0x06010C24 RID: 68644 RVA: 0x003E06A0 File Offset: 0x003DE8A0
			// (set) Token: 0x06010C25 RID: 68645 RVA: 0x0009208C File Offset: 0x0009028C
			public unsafe Comparer<int> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005753 RID: 22355
			// (get) Token: 0x06010C26 RID: 68646 RVA: 0x003E06D0 File Offset: 0x003DE8D0
			// (set) Token: 0x06010C27 RID: 68647 RVA: 0x000920AB File Offset: 0x000902AB
			public unsafe NoteBookMissionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A996 RID: 43414
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x0400A997 RID: 43415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A998 RID: 43416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A999 RID: 43417
			private static readonly IntPtr NativeMethodInfoPtr__RefreshMissionElements_b__3_Internal_Int32_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0;
		}

		// Token: 0x02000EE5 RID: 3813
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass50_1")]
		public sealed class __c__DisplayClass50_1 : Il2CppSystem.Object
		{
			// Token: 0x06010C28 RID: 68648 RVA: 0x003E0700 File Offset: 0x003DE900
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_1()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass50_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass50_1.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr, "a");
				NoteBookMissionPannel.__c__DisplayClass50_1.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr, "b");
				NoteBookMissionPannel.__c__DisplayClass50_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr, 100686081);
				NoteBookMissionPannel.__c__DisplayClass50_1.NativeMethodInfoPtr__RefreshMissionElements_b__4_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr, 100686082);
				NoteBookMissionPannel.__c__DisplayClass50_1.NativeMethodInfoPtr__RefreshMissionElements_b__5_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr, 100686083);
			}

			// Token: 0x06010C29 RID: 68649 RVA: 0x003E0790 File Offset: 0x003DE990
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass50_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass50_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C2A RID: 68650 RVA: 0x003E07CC File Offset: 0x003DE9CC
			[CallerCount(0)]
			public unsafe bool _RefreshMissionElements_b__4(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass50_1.NativeMethodInfoPtr__RefreshMissionElements_b__4_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C2B RID: 68651 RVA: 0x003E0820 File Offset: 0x003DEA20
			[CallerCount(0)]
			public unsafe bool _RefreshMissionElements_b__5(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass50_1.NativeMethodInfoPtr__RefreshMissionElements_b__5_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C2C RID: 68652 RVA: 0x000920CA File Offset: 0x000902CA
			public __c__DisplayClass50_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005754 RID: 22356
			// (get) Token: 0x06010C2D RID: 68653 RVA: 0x003E0874 File Offset: 0x003DEA74
			// (set) Token: 0x06010C2E RID: 68654 RVA: 0x000920D3 File Offset: 0x000902D3
			public ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_1.NativeFieldInfoPtr_a);
					return new ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_1.NativeFieldInfoPtr_a), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005755 RID: 22357
			// (get) Token: 0x06010C2F RID: 68655 RVA: 0x003E08A4 File Offset: 0x003DEAA4
			// (set) Token: 0x06010C30 RID: 68656 RVA: 0x00092101 File Offset: 0x00090301
			public ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_1.NativeFieldInfoPtr_b);
					return new ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass50_1.NativeFieldInfoPtr_b), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A99A RID: 43418
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x0400A99B RID: 43419
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x0400A99C RID: 43420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A99D RID: 43421
			private static readonly IntPtr NativeMethodInfoPtr__RefreshMissionElements_b__4_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0;

			// Token: 0x0400A99E RID: 43422
			private static readonly IntPtr NativeMethodInfoPtr__RefreshMissionElements_b__5_Internal_Boolean_ValueTuple_3_TrackedMissionData_MissionStatus_Int32_0;
		}

		// Token: 0x02000EE6 RID: 3814
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
		{
			// Token: 0x06010C31 RID: 68657 RVA: 0x003E08D4 File Offset: 0x003DEAD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_missionLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, "missionLanguage");
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_missionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, "missionData");
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, "textColor");
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_isMissionFulfilledOrFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, "isMissionFulfilledOrFinished");
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, "textKey");
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, 100686084);
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateMissionItemVisual_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, 100686085);
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateMissionItemVisual_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, 100686086);
				NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateMissionItemVisual_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr, 100686087);
			}

			// Token: 0x06010C32 RID: 68658 RVA: 0x003E09B4 File Offset: 0x003DEBB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C33 RID: 68659 RVA: 0x003E09F0 File Offset: 0x003DEBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278022, XrefRangeEnd = 278044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMissionItemVisual_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateMissionItemVisual_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C34 RID: 68660 RVA: 0x003E0A34 File Offset: 0x003DEC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278044, XrefRangeEnd = 278050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMissionItemVisual_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateMissionItemVisual_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C35 RID: 68661 RVA: 0x003E0A78 File Offset: 0x003DEC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278050, XrefRangeEnd = 278052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMissionItemVisual_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateMissionItemVisual_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C36 RID: 68662 RVA: 0x0009212F File Offset: 0x0009032F
			public __c__DisplayClass52_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005756 RID: 22358
			// (get) Token: 0x06010C37 RID: 68663 RVA: 0x003E0ABC File Offset: 0x003DECBC
			// (set) Token: 0x06010C38 RID: 68664 RVA: 0x00092138 File Offset: 0x00090338
			public unsafe LanguageBase missionLanguage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_missionLanguage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_missionLanguage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005757 RID: 22359
			// (get) Token: 0x06010C39 RID: 68665 RVA: 0x003E0AEC File Offset: 0x003DECEC
			// (set) Token: 0x06010C3A RID: 68666 RVA: 0x00092157 File Offset: 0x00090357
			public ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> missionData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_missionData);
					return new ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_missionData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005758 RID: 22360
			// (get) Token: 0x06010C3B RID: 68667 RVA: 0x003E0B1C File Offset: 0x003DED1C
			// (set) Token: 0x06010C3C RID: 68668 RVA: 0x00092185 File Offset: 0x00090385
			public unsafe Color textColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_textColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_textColor)) = value;
				}
			}

			// Token: 0x17005759 RID: 22361
			// (get) Token: 0x06010C3D RID: 68669 RVA: 0x003E0B44 File Offset: 0x003DED44
			// (set) Token: 0x06010C3E RID: 68670 RVA: 0x000921A0 File Offset: 0x000903A0
			public unsafe bool isMissionFulfilledOrFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_isMissionFulfilledOrFinished);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_isMissionFulfilledOrFinished)) = value;
				}
			}

			// Token: 0x1700575A RID: 22362
			// (get) Token: 0x06010C3F RID: 68671 RVA: 0x003E0B6C File Offset: 0x003DED6C
			// (set) Token: 0x06010C40 RID: 68672 RVA: 0x000921BB File Offset: 0x000903BB
			public unsafe string textKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_textKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_textKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A99F RID: 43423
			private static readonly IntPtr NativeFieldInfoPtr_missionLanguage;

			// Token: 0x0400A9A0 RID: 43424
			private static readonly IntPtr NativeFieldInfoPtr_missionData;

			// Token: 0x0400A9A1 RID: 43425
			private static readonly IntPtr NativeFieldInfoPtr_textColor;

			// Token: 0x0400A9A2 RID: 43426
			private static readonly IntPtr NativeFieldInfoPtr_isMissionFulfilledOrFinished;

			// Token: 0x0400A9A3 RID: 43427
			private static readonly IntPtr NativeFieldInfoPtr_textKey;

			// Token: 0x0400A9A4 RID: 43428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9A5 RID: 43429
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMissionItemVisual_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A9A6 RID: 43430
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMissionItemVisual_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A9A7 RID: 43431
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMissionItemVisual_b__2_Internal_Void_Image_0;
		}

		// Token: 0x02000EE7 RID: 3815
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x06010C41 RID: 68673 RVA: 0x003E0B94 File Offset: 0x003DED94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_allProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "allProduct");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_rewardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "rewardNum");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_missionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "missionStatus");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_trackedMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "trackedMission");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_refreshMissionVisualHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "refreshMissionVisualHandle");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_currentLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "currentLeft");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_missionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "missionData");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___9__67 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, "<>9__67");
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686088);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686089);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_FinishCondition_Boolean_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686090);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__DescribeMission_b__18_Internal_Void_SubmissionPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686091);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__DescribeMission_b__14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686092);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__DescribeMission_b__67_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686093);
				NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_KeyValuePair_2_Product_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr, 100686094);
			}

			// Token: 0x06010C42 RID: 68674 RVA: 0x003E0D00 File Offset: 0x003DEF00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C43 RID: 68675 RVA: 0x003E0D3C File Offset: 0x003DEF3C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 278054, RefRangeEnd = 278057, XrefRangeStart = 278052, XrefRangeEnd = 278054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_byref___c__DisplayClass56_1_0(ref NoteBookMissionPannel.__c__DisplayClass56_1 A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass56_1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C44 RID: 68676 RVA: 0x003E0D80 File Offset: 0x003DEF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278057, XrefRangeEnd = 278492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_ValueTuple_2_FinishCondition_Boolean_Int32_PDM_0(UIElementCluster cluster, ValueTuple<MissionNode.FinishCondition, bool> staticData, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(staticData));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_FinishCondition_Boolean_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C45 RID: 68677 RVA: 0x003E0DE8 File Offset: 0x003DEFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278492, XrefRangeEnd = 278499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__18<T>(SubmissionPanel _) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.MethodInfoStoreGeneric__DescribeMission_b__18_Internal_Void_SubmissionPanel_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C46 RID: 68678 RVA: 0x003E0E2C File Offset: 0x003DF02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278499, XrefRangeEnd = 278501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__14<T>() where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.MethodInfoStoreGeneric__DescribeMission_b__14_Internal_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C47 RID: 68679 RVA: 0x003E0E60 File Offset: 0x003DF060
			[CallerCount(0)]
			public unsafe void _DescribeMission_b__67(MoveDirection dir)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__DescribeMission_b__67_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C48 RID: 68680 RVA: 0x003E0EA0 File Offset: 0x003DF0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278501, XrefRangeEnd = 278556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_KeyValuePair_2_Product_Int32_PDM_0(UIElementCluster cluster, KeyValuePair<Product, int> rewardData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rewardData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_KeyValuePair_2_Product_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C49 RID: 68681 RVA: 0x000921DA File Offset: 0x000903DA
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700575B RID: 22363
			// (get) Token: 0x06010C4A RID: 68682 RVA: 0x003E0EFC File Offset: 0x003DF0FC
			// (set) Token: 0x06010C4B RID: 68683 RVA: 0x000921E3 File Offset: 0x000903E3
			public unsafe List<Product> allProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_allProduct);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_allProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700575C RID: 22364
			// (get) Token: 0x06010C4C RID: 68684 RVA: 0x003E0F2C File Offset: 0x003DF12C
			// (set) Token: 0x06010C4D RID: 68685 RVA: 0x00092202 File Offset: 0x00090402
			public unsafe int rewardNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_rewardNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_rewardNum)) = value;
				}
			}

			// Token: 0x1700575D RID: 22365
			// (get) Token: 0x06010C4E RID: 68686 RVA: 0x003E0F54 File Offset: 0x003DF154
			// (set) Token: 0x06010C4F RID: 68687 RVA: 0x0009221D File Offset: 0x0009041D
			public unsafe RunTimeScheduler.MissionStatus missionStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_missionStatus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_missionStatus)) = value;
				}
			}

			// Token: 0x1700575E RID: 22366
			// (get) Token: 0x06010C50 RID: 68688 RVA: 0x003E0F7C File Offset: 0x003DF17C
			// (set) Token: 0x06010C51 RID: 68689 RVA: 0x00092238 File Offset: 0x00090438
			public unsafe NoteBookMissionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700575F RID: 22367
			// (get) Token: 0x06010C52 RID: 68690 RVA: 0x003E0FAC File Offset: 0x003DF1AC
			// (set) Token: 0x06010C53 RID: 68691 RVA: 0x00092257 File Offset: 0x00090457
			public unsafe RunTimeScheduler.TrackedMissionData trackedMission
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_trackedMission);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeScheduler.TrackedMissionData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_trackedMission), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005760 RID: 22368
			// (get) Token: 0x06010C54 RID: 68692 RVA: 0x003E0FDC File Offset: 0x003DF1DC
			// (set) Token: 0x06010C55 RID: 68693 RVA: 0x00092276 File Offset: 0x00090476
			public unsafe Action refreshMissionVisualHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_refreshMissionVisualHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_refreshMissionVisualHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005761 RID: 22369
			// (get) Token: 0x06010C56 RID: 68694 RVA: 0x003E100C File Offset: 0x003DF20C
			// (set) Token: 0x06010C57 RID: 68695 RVA: 0x00092295 File Offset: 0x00090495
			public unsafe UIButtonSimple currentLeft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_currentLeft);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_currentLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005762 RID: 22370
			// (get) Token: 0x06010C58 RID: 68696 RVA: 0x003E103C File Offset: 0x003DF23C
			// (set) Token: 0x06010C59 RID: 68697 RVA: 0x000922B4 File Offset: 0x000904B4
			public unsafe MissionNode missionData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_missionData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MissionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_missionData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005763 RID: 22371
			// (get) Token: 0x06010C5A RID: 68698 RVA: 0x003E106C File Offset: 0x003DF26C
			// (set) Token: 0x06010C5B RID: 68699 RVA: 0x000922D3 File Offset: 0x000904D3
			public unsafe Action<MoveDirection> __9__67
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___9__67);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoveDirection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___9__67), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9A8 RID: 43432
			private static readonly IntPtr NativeFieldInfoPtr_allProduct;

			// Token: 0x0400A9A9 RID: 43433
			private static readonly IntPtr NativeFieldInfoPtr_rewardNum;

			// Token: 0x0400A9AA RID: 43434
			private static readonly IntPtr NativeFieldInfoPtr_missionStatus;

			// Token: 0x0400A9AB RID: 43435
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9AC RID: 43436
			private static readonly IntPtr NativeFieldInfoPtr_trackedMission;

			// Token: 0x0400A9AD RID: 43437
			private static readonly IntPtr NativeFieldInfoPtr_refreshMissionVisualHandle;

			// Token: 0x0400A9AE RID: 43438
			private static readonly IntPtr NativeFieldInfoPtr_currentLeft;

			// Token: 0x0400A9AF RID: 43439
			private static readonly IntPtr NativeFieldInfoPtr_missionData;

			// Token: 0x0400A9B0 RID: 43440
			private static readonly IntPtr NativeFieldInfoPtr___9__67;

			// Token: 0x0400A9B1 RID: 43441
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9B2 RID: 43442
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass56_1_0;

			// Token: 0x0400A9B3 RID: 43443
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_FinishCondition_Boolean_Int32_PDM_0;

			// Token: 0x0400A9B4 RID: 43444
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__18_Internal_Void_SubmissionPanel_0;

			// Token: 0x0400A9B5 RID: 43445
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__14_Internal_Void_0;

			// Token: 0x0400A9B6 RID: 43446
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__67_Internal_Void_MoveDirection_0;

			// Token: 0x0400A9B7 RID: 43447
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_KeyValuePair_2_Product_Int32_PDM_0;

			// Token: 0x020010BB RID: 4283
			private sealed class MethodInfoStoreGeneric__DescribeMission_b__18_Internal_Void_SubmissionPanel_0<T>
			{
				// Token: 0x0400B874 RID: 47220
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__DescribeMission_b__18_Internal_Void_SubmissionPanel_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010BC RID: 4284
			private sealed class MethodInfoStoreGeneric__DescribeMission_b__14_Internal_Void_0<T>
			{
				// Token: 0x0400B875 RID: 47221
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__DescribeMission_b__14_Internal_Void_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x02000EE8 RID: 3816
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_1")]
		public sealed class __c__DisplayClass56_1 : ValueType
		{
			// Token: 0x06010C5C RID: 68700 RVA: 0x000922F2 File Offset: 0x000904F2
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_1()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_1>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_1.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_1>.NativeClassPtr, "product");
			}

			// Token: 0x06010C5D RID: 68701 RVA: 0x00092326 File Offset: 0x00090526
			public __c__DisplayClass56_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010C5E RID: 68702 RVA: 0x0009232F File Offset: 0x0009052F
			public __c__DisplayClass56_1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_1>.NativeClassPtr))
			{
			}

			// Token: 0x17005764 RID: 22372
			// (get) Token: 0x06010C5F RID: 68703 RVA: 0x003E109C File Offset: 0x003DF29C
			// (set) Token: 0x06010C60 RID: 68704 RVA: 0x00092341 File Offset: 0x00090541
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_1.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_1.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A9B8 RID: 43448
			private static readonly IntPtr NativeFieldInfoPtr_product;
		}

		// Token: 0x02000EE9 RID: 3817
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_2")]
		public sealed class __c__DisplayClass56_2 : Il2CppSystem.Object
		{
			// Token: 0x06010C61 RID: 68705 RVA: 0x003E10CC File Offset: 0x003DF2CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_2()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_interactableBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "interactableBase");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "text");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_runtimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "runtimeData");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_thisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "thisIndex");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "textColor");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "index");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_thisCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "thisCluster");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_staticData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "staticData");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "CS$<>8__locals1");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "<>9__51");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__52 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "<>9__52");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "<>9__65");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, "<>9__66");
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686095);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Void_Int64_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686096);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Void_Int32_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686097);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__23_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686098);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__24_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686099);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__28_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686100);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__51_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686101);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__31_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686102);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__52_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686103);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686104);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__35_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686105);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__38_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686106);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686107);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__42_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686108);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__45_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686109);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686110);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__55_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686111);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__58_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686112);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__61_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686113);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__65_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686114);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__64_Internal_IEnumerable_1_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686115);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__66_Internal_Boolean_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686116);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686117);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__50_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686118);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__9_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686119);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686120);
				NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr, 100686121);
			}

			// Token: 0x06010C62 RID: 68706 RVA: 0x003E1418 File Offset: 0x003DF618
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C63 RID: 68707 RVA: 0x003E1454 File Offset: 0x003DF654
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 278571, RefRangeEnd = 278573, XrefRangeStart = 278556, XrefRangeEnd = 278571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int64_Int32_PDM_0(long current, int total)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref current;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Void_Int64_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C64 RID: 68708 RVA: 0x003E14A0 File Offset: 0x003DF6A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278573, XrefRangeEnd = 278605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_PDM_0<T>(int max, Action<SellableDescriber> describerModeChangeCallback, Action<SellableDescriber, T> describeObjectCallback, Func<IEnumerable<KeyValuePair<T, int>>> getElementCallback, Action<IEnumerable<int>, bool> storageInCallback, Action<int, bool> storageOutCallback, Func<int, T> idToObjectCallback, Func<int, int> getObjectAmountCallback) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref max;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describerModeChangeCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getElementCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageInCallback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageOutCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToObjectCallback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getObjectAmountCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.MethodInfoStoreGeneric_Method_Internal_Void_Int32_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_PDM_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C65 RID: 68709 RVA: 0x003E1564 File Offset: 0x003DF764
			[CallerCount(0)]
			public unsafe void _DescribeMission_b__23<T>(TextMeshProUGUI x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.MethodInfoStoreGeneric__DescribeMission_b__23_Internal_Void_TextMeshProUGUI_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C66 RID: 68710 RVA: 0x003E15A8 File Offset: 0x003DF7A8
			[CallerCount(0)]
			public unsafe void _DescribeMission_b__24<T>(Image x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.MethodInfoStoreGeneric__DescribeMission_b__24_Internal_Void_Image_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C67 RID: 68711 RVA: 0x003E15EC File Offset: 0x003DF7EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278605, XrefRangeEnd = 278617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__28()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__28_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C68 RID: 68712 RVA: 0x003E162C File Offset: 0x003DF82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278617, XrefRangeEnd = 278622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DescribeMission_b__51(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__51_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C69 RID: 68713 RVA: 0x003E1680 File Offset: 0x003DF880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278622, XrefRangeEnd = 278634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__31()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__31_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C6A RID: 68714 RVA: 0x003E16C0 File Offset: 0x003DF8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278634, XrefRangeEnd = 278639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DescribeMission_b__52(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__52_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C6B RID: 68715 RVA: 0x003E1714 File Offset: 0x003DF914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278639, XrefRangeEnd = 278646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C6C RID: 68716 RVA: 0x003E1768 File Offset: 0x003DF968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278646, XrefRangeEnd = 278657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__35()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__35_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C6D RID: 68717 RVA: 0x003E17A8 File Offset: 0x003DF9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278657, XrefRangeEnd = 278668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__38()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__38_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C6E RID: 68718 RVA: 0x003E17E8 File Offset: 0x003DF9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278668, XrefRangeEnd = 278673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_1(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C6F RID: 68719 RVA: 0x003E183C File Offset: 0x003DFA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278673, XrefRangeEnd = 278684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__42()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__42_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C70 RID: 68720 RVA: 0x003E187C File Offset: 0x003DFA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278684, XrefRangeEnd = 278695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__45()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__45_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C71 RID: 68721 RVA: 0x003E18BC File Offset: 0x003DFABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278695, XrefRangeEnd = 278696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_2(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C72 RID: 68722 RVA: 0x003E1910 File Offset: 0x003DFB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278696, XrefRangeEnd = 278707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__55()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__55_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C73 RID: 68723 RVA: 0x003E1950 File Offset: 0x003DFB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278707, XrefRangeEnd = 278718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__58()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__58_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C74 RID: 68724 RVA: 0x003E1990 File Offset: 0x003DFB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278718, XrefRangeEnd = 278730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Ingredient, int>> _DescribeMission_b__61()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__61_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C75 RID: 68725 RVA: 0x003E19D0 File Offset: 0x003DFBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278730, XrefRangeEnd = 278731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DescribeMission_b__65(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__65_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C76 RID: 68726 RVA: 0x003E1A24 File Offset: 0x003DFC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278731, XrefRangeEnd = 278743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Item, int>> _DescribeMission_b__64()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__64_Internal_IEnumerable_1_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Item, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C77 RID: 68727 RVA: 0x003E1A64 File Offset: 0x003DFC64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278743, XrefRangeEnd = 278744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DescribeMission_b__66(KeyValuePair<Item, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__66_Internal_Boolean_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C78 RID: 68728 RVA: 0x003E1AB8 File Offset: 0x003DFCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278744, XrefRangeEnd = 278758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_3(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010C79 RID: 68729 RVA: 0x003E1B0C File Offset: 0x003DFD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278758, XrefRangeEnd = 278769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Sellable, int>> _DescribeMission_b__50()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__50_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C7A RID: 68730 RVA: 0x003E1B4C File Offset: 0x003DFD4C
			[CallerCount(0)]
			public unsafe void _DescribeMission_b__9(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__9_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C7B RID: 68731 RVA: 0x003E1B90 File Offset: 0x003DFD90
			[CallerCount(0)]
			public unsafe void _DescribeMission_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C7C RID: 68732 RVA: 0x003E1BD4 File Offset: 0x003DFDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278769, XrefRangeEnd = 278770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C7D RID: 68733 RVA: 0x0009236F File Offset: 0x0009056F
			public __c__DisplayClass56_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005765 RID: 22373
			// (get) Token: 0x06010C7E RID: 68734 RVA: 0x003E1C18 File Offset: 0x003DFE18
			// (set) Token: 0x06010C7F RID: 68735 RVA: 0x00092378 File Offset: 0x00090578
			public unsafe UIButtonSimple interactableBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_interactableBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_interactableBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005766 RID: 22374
			// (get) Token: 0x06010C80 RID: 68736 RVA: 0x003E1C48 File Offset: 0x003DFE48
			// (set) Token: 0x06010C81 RID: 68737 RVA: 0x00092397 File Offset: 0x00090597
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005767 RID: 22375
			// (get) Token: 0x06010C82 RID: 68738 RVA: 0x003E1C70 File Offset: 0x003DFE70
			// (set) Token: 0x06010C83 RID: 68739 RVA: 0x000923B6 File Offset: 0x000905B6
			public unsafe List<int> runtimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_runtimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_runtimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005768 RID: 22376
			// (get) Token: 0x06010C84 RID: 68740 RVA: 0x003E1CA0 File Offset: 0x003DFEA0
			// (set) Token: 0x06010C85 RID: 68741 RVA: 0x000923D5 File Offset: 0x000905D5
			public unsafe int thisIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_thisIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_thisIndex)) = value;
				}
			}

			// Token: 0x17005769 RID: 22377
			// (get) Token: 0x06010C86 RID: 68742 RVA: 0x003E1CC8 File Offset: 0x003DFEC8
			// (set) Token: 0x06010C87 RID: 68743 RVA: 0x000923F0 File Offset: 0x000905F0
			public unsafe Color textColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_textColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_textColor)) = value;
				}
			}

			// Token: 0x1700576A RID: 22378
			// (get) Token: 0x06010C88 RID: 68744 RVA: 0x003E1CF0 File Offset: 0x003DFEF0
			// (set) Token: 0x06010C89 RID: 68745 RVA: 0x0009240B File Offset: 0x0009060B
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700576B RID: 22379
			// (get) Token: 0x06010C8A RID: 68746 RVA: 0x003E1D18 File Offset: 0x003DFF18
			// (set) Token: 0x06010C8B RID: 68747 RVA: 0x00092426 File Offset: 0x00090626
			public unsafe UIElementCluster thisCluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_thisCluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_thisCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700576C RID: 22380
			// (get) Token: 0x06010C8C RID: 68748 RVA: 0x003E1D48 File Offset: 0x003DFF48
			// (set) Token: 0x06010C8D RID: 68749 RVA: 0x00092445 File Offset: 0x00090645
			public ValueTuple<MissionNode.FinishCondition, bool> staticData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_staticData);
					return new ValueTuple<MissionNode.FinishCondition, bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<MissionNode.FinishCondition, bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_staticData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<MissionNode.FinishCondition, bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700576D RID: 22381
			// (get) Token: 0x06010C8E RID: 68750 RVA: 0x003E1D78 File Offset: 0x003DFF78
			// (set) Token: 0x06010C8F RID: 68751 RVA: 0x00092473 File Offset: 0x00090673
			public unsafe NoteBookMissionPannel.__c__DisplayClass56_0 field_Public___c__DisplayClass56_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel.__c__DisplayClass56_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700576E RID: 22382
			// (get) Token: 0x06010C90 RID: 68752 RVA: 0x003E1DA8 File Offset: 0x003DFFA8
			// (set) Token: 0x06010C91 RID: 68753 RVA: 0x00092492 File Offset: 0x00090692
			public unsafe Func<KeyValuePair<Sellable, int>, bool> __9__51
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__51);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__51), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700576F RID: 22383
			// (get) Token: 0x06010C92 RID: 68754 RVA: 0x003E1DD8 File Offset: 0x003DFFD8
			// (set) Token: 0x06010C93 RID: 68755 RVA: 0x000924B1 File Offset: 0x000906B1
			public unsafe Func<KeyValuePair<Sellable, int>, bool> __9__52
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__52);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__52), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005770 RID: 22384
			// (get) Token: 0x06010C94 RID: 68756 RVA: 0x003E1E08 File Offset: 0x003E0008
			// (set) Token: 0x06010C95 RID: 68757 RVA: 0x000924D0 File Offset: 0x000906D0
			public unsafe Func<KeyValuePair<Ingredient, int>, bool> __9__65
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__65);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__65), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005771 RID: 22385
			// (get) Token: 0x06010C96 RID: 68758 RVA: 0x003E1E38 File Offset: 0x003E0038
			// (set) Token: 0x06010C97 RID: 68759 RVA: 0x000924EF File Offset: 0x000906EF
			public unsafe Func<KeyValuePair<Item, int>, bool> __9__66
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__66);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_2.NativeFieldInfoPtr___9__66), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9B9 RID: 43449
			private static readonly IntPtr NativeFieldInfoPtr_interactableBase;

			// Token: 0x0400A9BA RID: 43450
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x0400A9BB RID: 43451
			private static readonly IntPtr NativeFieldInfoPtr_runtimeData;

			// Token: 0x0400A9BC RID: 43452
			private static readonly IntPtr NativeFieldInfoPtr_thisIndex;

			// Token: 0x0400A9BD RID: 43453
			private static readonly IntPtr NativeFieldInfoPtr_textColor;

			// Token: 0x0400A9BE RID: 43454
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A9BF RID: 43455
			private static readonly IntPtr NativeFieldInfoPtr_thisCluster;

			// Token: 0x0400A9C0 RID: 43456
			private static readonly IntPtr NativeFieldInfoPtr_staticData;

			// Token: 0x0400A9C1 RID: 43457
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0;

			// Token: 0x0400A9C2 RID: 43458
			private static readonly IntPtr NativeFieldInfoPtr___9__51;

			// Token: 0x0400A9C3 RID: 43459
			private static readonly IntPtr NativeFieldInfoPtr___9__52;

			// Token: 0x0400A9C4 RID: 43460
			private static readonly IntPtr NativeFieldInfoPtr___9__65;

			// Token: 0x0400A9C5 RID: 43461
			private static readonly IntPtr NativeFieldInfoPtr___9__66;

			// Token: 0x0400A9C6 RID: 43462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9C7 RID: 43463
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int64_Int32_PDM_0;

			// Token: 0x0400A9C8 RID: 43464
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_PDM_0;

			// Token: 0x0400A9C9 RID: 43465
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__23_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A9CA RID: 43466
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__24_Internal_Void_Image_0;

			// Token: 0x0400A9CB RID: 43467
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__28_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9CC RID: 43468
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__51_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9CD RID: 43469
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__31_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9CE RID: 43470
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__52_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9CF RID: 43471
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_0;

			// Token: 0x0400A9D0 RID: 43472
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__35_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9D1 RID: 43473
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__38_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9D2 RID: 43474
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_1;

			// Token: 0x0400A9D3 RID: 43475
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__42_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9D4 RID: 43476
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__45_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9D5 RID: 43477
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_2;

			// Token: 0x0400A9D6 RID: 43478
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__55_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9D7 RID: 43479
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__58_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9D8 RID: 43480
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__61_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x0400A9D9 RID: 43481
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__65_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x0400A9DA RID: 43482
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__64_Internal_IEnumerable_1_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400A9DB RID: 43483
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__66_Internal_Boolean_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400A9DC RID: 43484
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_Sellable_Int32_PDM_3;

			// Token: 0x0400A9DD RID: 43485
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__50_Internal_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A9DE RID: 43486
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__9_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A9DF RID: 43487
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__10_Internal_Void_Image_0;

			// Token: 0x0400A9E0 RID: 43488
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__11_Internal_Void_Image_0;

			// Token: 0x020010BD RID: 4285
			private sealed class MethodInfoStoreGeneric_Method_Internal_Void_Int32_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_PDM_0<T>
			{
				// Token: 0x0400B876 RID: 47222
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr_Method_Internal_Void_Int32_Action_1_SellableDescriber_Action_2_SellableDescriber_T_Func_1_IEnumerable_1_KeyValuePair_2_T_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_T_Func_2_Int32_Int32_PDM_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010BE RID: 4286
			private sealed class MethodInfoStoreGeneric__DescribeMission_b__23_Internal_Void_TextMeshProUGUI_0<T>
			{
				// Token: 0x0400B877 RID: 47223
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__23_Internal_Void_TextMeshProUGUI_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x020010BF RID: 4287
			private sealed class MethodInfoStoreGeneric__DescribeMission_b__24_Internal_Void_Image_0<T>
			{
				// Token: 0x0400B878 RID: 47224
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.__c__DisplayClass56_2.NativeMethodInfoPtr__DescribeMission_b__24_Internal_Void_Image_0, Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_2>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x02000EEA RID: 3818
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_3`1")]
		public sealed class __c__DisplayClass56_3<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010C98 RID: 68760 RVA: 0x003E1E68 File Offset: 0x003E0068
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_3()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_describerModeChangeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "describerModeChangeCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_SetTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "SetTextCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_describeObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "describeObjectCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_getElementCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "getElementCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_storageInCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "storageInCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_storageOutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "storageOutCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_idToObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "idToObjectCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_getObjectAmountCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "getObjectAmountCallback");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "max");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass56_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, "CS$<>8__locals2");
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, 100686122);
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, 100686123);
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr__DescribeMission_b__16_Internal_Void_SellableDescriber_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, 100686124);
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr__DescribeMission_b__17_Internal_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, 100686125);
				NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr, 100686126);
			}

			// Token: 0x06010C99 RID: 68761 RVA: 0x003E1FFC File Offset: 0x003E01FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C9A RID: 68762 RVA: 0x003E2038 File Offset: 0x003E0238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278770, XrefRangeEnd = 278804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C9B RID: 68763 RVA: 0x003E206C File Offset: 0x003E026C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278804, XrefRangeEnd = 278809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__16(SellableDescriber sellableDescriber, NonTradableObjectBase obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellableDescriber);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr__DescribeMission_b__16_Internal_Void_SellableDescriber_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C9C RID: 68764 RVA: 0x003E20C0 File Offset: 0x003E02C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278809, XrefRangeEnd = 278816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<NonTradableObjectBase, int>> _DescribeMission_b__17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr__DescribeMission_b__17_Internal_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>>(intPtr3) : null;
			}

			// Token: 0x06010C9D RID: 68765 RVA: 0x003E2100 File Offset: 0x003E0300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278816, XrefRangeEnd = 278885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010C9E RID: 68766 RVA: 0x0009250E File Offset: 0x0009070E
			public __c__DisplayClass56_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005772 RID: 22386
			// (get) Token: 0x06010C9F RID: 68767 RVA: 0x003E2134 File Offset: 0x003E0334
			// (set) Token: 0x06010CA0 RID: 68768 RVA: 0x00092517 File Offset: 0x00090717
			public unsafe Action<SellableDescriber> describerModeChangeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_describerModeChangeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_describerModeChangeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005773 RID: 22387
			// (get) Token: 0x06010CA1 RID: 68769 RVA: 0x003E2164 File Offset: 0x003E0364
			// (set) Token: 0x06010CA2 RID: 68770 RVA: 0x00092536 File Offset: 0x00090736
			public unsafe Action<string> SetTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_SetTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_SetTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005774 RID: 22388
			// (get) Token: 0x06010CA3 RID: 68771 RVA: 0x003E2194 File Offset: 0x003E0394
			// (set) Token: 0x06010CA4 RID: 68772 RVA: 0x00092555 File Offset: 0x00090755
			public unsafe Action<SellableDescriber, T> describeObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_describeObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_describeObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005775 RID: 22389
			// (get) Token: 0x06010CA5 RID: 68773 RVA: 0x003E21C4 File Offset: 0x003E03C4
			// (set) Token: 0x06010CA6 RID: 68774 RVA: 0x00092574 File Offset: 0x00090774
			public unsafe Func<IEnumerable<KeyValuePair<T, int>>> getElementCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_getElementCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<KeyValuePair<T, int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_getElementCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005776 RID: 22390
			// (get) Token: 0x06010CA7 RID: 68775 RVA: 0x003E21F4 File Offset: 0x003E03F4
			// (set) Token: 0x06010CA8 RID: 68776 RVA: 0x00092593 File Offset: 0x00090793
			public unsafe Action<IEnumerable<int>, bool> storageInCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_storageInCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_storageInCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005777 RID: 22391
			// (get) Token: 0x06010CA9 RID: 68777 RVA: 0x003E2224 File Offset: 0x003E0424
			// (set) Token: 0x06010CAA RID: 68778 RVA: 0x000925B2 File Offset: 0x000907B2
			public unsafe Action<int, bool> storageOutCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_storageOutCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_storageOutCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005778 RID: 22392
			// (get) Token: 0x06010CAB RID: 68779 RVA: 0x003E2254 File Offset: 0x003E0454
			// (set) Token: 0x06010CAC RID: 68780 RVA: 0x000925D1 File Offset: 0x000907D1
			public unsafe Func<int, T> idToObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_idToObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_idToObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005779 RID: 22393
			// (get) Token: 0x06010CAD RID: 68781 RVA: 0x003E2284 File Offset: 0x003E0484
			// (set) Token: 0x06010CAE RID: 68782 RVA: 0x000925F0 File Offset: 0x000907F0
			public unsafe Func<int, int> getObjectAmountCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_getObjectAmountCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_getObjectAmountCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700577A RID: 22394
			// (get) Token: 0x06010CAF RID: 68783 RVA: 0x003E22B4 File Offset: 0x003E04B4
			// (set) Token: 0x06010CB0 RID: 68784 RVA: 0x0009260F File Offset: 0x0009080F
			public unsafe int max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_max)) = value;
				}
			}

			// Token: 0x1700577B RID: 22395
			// (get) Token: 0x06010CB1 RID: 68785 RVA: 0x003E22DC File Offset: 0x003E04DC
			// (set) Token: 0x06010CB2 RID: 68786 RVA: 0x0009262A File Offset: 0x0009082A
			public unsafe NoteBookMissionPannel.__c__DisplayClass56_2 field_Public___c__DisplayClass56_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass56_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel.__c__DisplayClass56_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_3<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass56_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9E1 RID: 43489
			private static readonly IntPtr NativeFieldInfoPtr_describerModeChangeCallback;

			// Token: 0x0400A9E2 RID: 43490
			private static readonly IntPtr NativeFieldInfoPtr_SetTextCallback;

			// Token: 0x0400A9E3 RID: 43491
			private static readonly IntPtr NativeFieldInfoPtr_describeObjectCallback;

			// Token: 0x0400A9E4 RID: 43492
			private static readonly IntPtr NativeFieldInfoPtr_getElementCallback;

			// Token: 0x0400A9E5 RID: 43493
			private static readonly IntPtr NativeFieldInfoPtr_storageInCallback;

			// Token: 0x0400A9E6 RID: 43494
			private static readonly IntPtr NativeFieldInfoPtr_storageOutCallback;

			// Token: 0x0400A9E7 RID: 43495
			private static readonly IntPtr NativeFieldInfoPtr_idToObjectCallback;

			// Token: 0x0400A9E8 RID: 43496
			private static readonly IntPtr NativeFieldInfoPtr_getObjectAmountCallback;

			// Token: 0x0400A9E9 RID: 43497
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x0400A9EA RID: 43498
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_2_0;

			// Token: 0x0400A9EB RID: 43499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9EC RID: 43500
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A9ED RID: 43501
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__16_Internal_Void_SellableDescriber_NonTradableObjectBase_0;

			// Token: 0x0400A9EE RID: 43502
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__17_Internal_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_0;

			// Token: 0x0400A9EF RID: 43503
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}

		// Token: 0x02000EEB RID: 3819
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_4`1")]
		public sealed class __c__DisplayClass56_4<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010CB3 RID: 68787 RVA: 0x003E230C File Offset: 0x003E050C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_4()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_4<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_4`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_4<T>>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_4<T>>.NativeClassPtr, "instance");
				NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_4<T>>.NativeClassPtr, 100686127);
				NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeMethodInfoPtr__DescribeMission_b__15_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_4<T>>.NativeClassPtr, 100686128);
			}

			// Token: 0x06010CB4 RID: 68788 RVA: 0x003E23B0 File Offset: 0x003E05B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_4<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CB5 RID: 68789 RVA: 0x003E23EC File Offset: 0x003E05EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278885, XrefRangeEnd = 278887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__15(string t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeMethodInfoPtr__DescribeMission_b__15_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CB6 RID: 68790 RVA: 0x00092649 File Offset: 0x00090849
			public __c__DisplayClass56_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700577C RID: 22396
			// (get) Token: 0x06010CB7 RID: 68791 RVA: 0x003E2430 File Offset: 0x003E0630
			// (set) Token: 0x06010CB8 RID: 68792 RVA: 0x00092652 File Offset: 0x00090852
			public unsafe SubmissionPanel instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_4<T>.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9F0 RID: 43504
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x0400A9F1 RID: 43505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9F2 RID: 43506
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__15_Internal_Void_String_0;
		}

		// Token: 0x02000EEC RID: 3820
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_5`1")]
		public sealed class __c__DisplayClass56_5<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010CB9 RID: 68793 RVA: 0x003E2460 File Offset: 0x003E0660
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_5()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_5`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeFieldInfoPtr_dynamicData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr, "dynamicData");
				NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_1_T_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr, "CS$<>8__locals3");
				NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr, 100686129);
				NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeMethodInfoPtr_Method_Internal_Boolean_ValueTuple_2_FinishCondition_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr, 100686130);
				NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeMethodInfoPtr__DescribeMission_b__25_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr, 100686131);
			}

			// Token: 0x06010CBA RID: 68794 RVA: 0x003E252C File Offset: 0x003E072C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_5<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CBB RID: 68795 RVA: 0x003E2568 File Offset: 0x003E0768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278887, XrefRangeEnd = 278888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_ValueTuple_2_FinishCondition_Boolean_PDM_0(ValueTuple<MissionNode.FinishCondition, bool> d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(d));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeMethodInfoPtr_Method_Internal_Boolean_ValueTuple_2_FinishCondition_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010CBC RID: 68796 RVA: 0x003E25BC File Offset: 0x003E07BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278888, XrefRangeEnd = 278889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__25(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeMethodInfoPtr__DescribeMission_b__25_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CBD RID: 68797 RVA: 0x00092671 File Offset: 0x00090871
			public __c__DisplayClass56_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700577D RID: 22397
			// (get) Token: 0x06010CBE RID: 68798 RVA: 0x003E2600 File Offset: 0x003E0800
			// (set) Token: 0x06010CBF RID: 68799 RVA: 0x0009267A File Offset: 0x0009087A
			public ValueTuple<MissionNode.FinishCondition, bool> dynamicData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeFieldInfoPtr_dynamicData);
					return new ValueTuple<MissionNode.FinishCondition, bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<MissionNode.FinishCondition, bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeFieldInfoPtr_dynamicData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<MissionNode.FinishCondition, bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700577E RID: 22398
			// (get) Token: 0x06010CC0 RID: 68800 RVA: 0x003E2630 File Offset: 0x003E0830
			// (set) Token: 0x06010CC1 RID: 68801 RVA: 0x000926A8 File Offset: 0x000908A8
			public unsafe NoteBookMissionPannel.__c__DisplayClass56_3<T> field_Public___c__DisplayClass56_3_1_T_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_1_T_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel.__c__DisplayClass56_3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_5<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_1_T_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9F3 RID: 43507
			private static readonly IntPtr NativeFieldInfoPtr_dynamicData;

			// Token: 0x0400A9F4 RID: 43508
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_1_T_0;

			// Token: 0x0400A9F5 RID: 43509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9F6 RID: 43510
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_ValueTuple_2_FinishCondition_Boolean_PDM_0;

			// Token: 0x0400A9F7 RID: 43511
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__25_Internal_Void_Image_0;
		}

		// Token: 0x02000EED RID: 3821
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMissionPannel+<>c__DisplayClass56_6")]
		public sealed class __c__DisplayClass56_6 : Il2CppSystem.Object
		{
			// Token: 0x06010CC2 RID: 68802 RVA: 0x003E2660 File Offset: 0x003E0860
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_6()
			{
				Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr, "<>c__DisplayClass56_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr);
				NoteBookMissionPannel.__c__DisplayClass56_6.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr, "text");
				NoteBookMissionPannel.__c__DisplayClass56_6.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr, "num");
				NoteBookMissionPannel.__c__DisplayClass56_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr, 100686132);
				NoteBookMissionPannel.__c__DisplayClass56_6.NativeMethodInfoPtr__DescribeMission_b__68_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr, 100686133);
				NoteBookMissionPannel.__c__DisplayClass56_6.NativeMethodInfoPtr__DescribeMission_b__70_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr, 100686134);
			}

			// Token: 0x06010CC3 RID: 68803 RVA: 0x003E26F0 File Offset: 0x003E08F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMissionPannel.__c__DisplayClass56_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CC4 RID: 68804 RVA: 0x003E272C File Offset: 0x003E092C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__68(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_6.NativeMethodInfoPtr__DescribeMission_b__68_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CC5 RID: 68805 RVA: 0x003E2770 File Offset: 0x003E0970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278889, XrefRangeEnd = 278894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeMission_b__70(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMissionPannel.__c__DisplayClass56_6.NativeMethodInfoPtr__DescribeMission_b__70_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CC6 RID: 68806 RVA: 0x000926C7 File Offset: 0x000908C7
			public __c__DisplayClass56_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700577F RID: 22399
			// (get) Token: 0x06010CC7 RID: 68807 RVA: 0x003E27B4 File Offset: 0x003E09B4
			// (set) Token: 0x06010CC8 RID: 68808 RVA: 0x000926D0 File Offset: 0x000908D0
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_6.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_6.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005780 RID: 22400
			// (get) Token: 0x06010CC9 RID: 68809 RVA: 0x003E27DC File Offset: 0x003E09DC
			// (set) Token: 0x06010CCA RID: 68810 RVA: 0x000926EF File Offset: 0x000908EF
			public unsafe int num
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_6.NativeFieldInfoPtr_num);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMissionPannel.__c__DisplayClass56_6.NativeFieldInfoPtr_num)) = value;
				}
			}

			// Token: 0x0400A9F8 RID: 43512
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x0400A9F9 RID: 43513
			private static readonly IntPtr NativeFieldInfoPtr_num;

			// Token: 0x0400A9FA RID: 43514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9FB RID: 43515
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__68_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A9FC RID: 43516
			private static readonly IntPtr NativeMethodInfoPtr__DescribeMission_b__70_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EEE RID: 3822
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_String_Int32_Int32_PDM_0<T>
		{
			// Token: 0x0400A9FD RID: 43517
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookMissionPannel.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_Int32_PDM_0, Il2CppClassPointerStore<NoteBookMissionPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
