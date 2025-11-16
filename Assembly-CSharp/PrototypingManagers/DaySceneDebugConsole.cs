using System;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace PrototypingManagers
{
	// Token: 0x02000045 RID: 69
	public class DaySceneDebugConsole : DebugConsoleBase
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x000B73C8 File Offset: 0x000B55C8
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneDebugConsole()
		{
			Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "DaySceneDebugConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr);
			DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "dialogPackages");
			DaySceneDebugConsole.NativeFieldInfoPtr_addCharacterKizunaLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "addCharacterKizunaLabel");
			DaySceneDebugConsole.NativeFieldInfoPtr_addDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "addDay");
			DaySceneDebugConsole.NativeFieldInfoPtr_addExpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "addExpAmount");
			DaySceneDebugConsole.NativeFieldInfoPtr_addKizunaAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "addKizunaAmount");
			DaySceneDebugConsole.NativeFieldInfoPtr_allNPCSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "allNPCSelections");
			DaySceneDebugConsole.NativeFieldInfoPtr_changeDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "changeDay");
			DaySceneDebugConsole.NativeFieldInfoPtr_currentActionWarpCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "currentActionWarpCount");
			DaySceneDebugConsole.NativeFieldInfoPtr_currentHourWarpCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "currentHourWarpCount");
			DaySceneDebugConsole.NativeFieldInfoPtr_diagramView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "diagramView");
			DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "dialogPackageNames");
			DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackagePlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "dialogPackagePlaying");
			DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackageSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "dialogPackageSearch");
			DaySceneDebugConsole.NativeFieldInfoPtr_fillter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "fillter");
			DaySceneDebugConsole.NativeFieldInfoPtr_fillterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "fillterText");
			DaySceneDebugConsole.NativeFieldInfoPtr_isColliderOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isColliderOff");
			DaySceneDebugConsole.NativeFieldInfoPtr_isKizunaCharacterSelectionExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isKizunaCharacterSelectionExpaneded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isKizunaCharacterUpgSelectionExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isKizunaCharacterUpgSelectionExpaneded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isMoveCharacterSelectionExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isMoveCharacterSelectionExpaneded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isMoveMapSelectionExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isMoveMapSelectionExpaneded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isPartnerExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isPartnerExpanded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isReturnCharacterSelectionExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isReturnCharacterSelectionExpaneded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isRotationSelectionExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isRotationSelectionExpaneded");
			DaySceneDebugConsole.NativeFieldInfoPtr_isTeleportExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "isTeleportExpanded");
			DaySceneDebugConsole.NativeFieldInfoPtr_labelsToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "labelsToSpawn");
			DaySceneDebugConsole.NativeFieldInfoPtr_lineTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "lineTex");
			DaySceneDebugConsole.NativeFieldInfoPtr_m_NPCConsoleScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "m_NPCConsoleScroll");
			DaySceneDebugConsole.NativeFieldInfoPtr_mapSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "mapSelections");
			DaySceneDebugConsole.NativeFieldInfoPtr_moveCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "moveCharacterLabel");
			DaySceneDebugConsole.NativeFieldInfoPtr_moveCharPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "moveCharPos");
			DaySceneDebugConsole.NativeFieldInfoPtr_moveCharRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "moveCharRotation");
			DaySceneDebugConsole.NativeFieldInfoPtr_moveMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "moveMapLabel");
			DaySceneDebugConsole.NativeFieldInfoPtr_pannelScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "pannelScroll");
			DaySceneDebugConsole.NativeFieldInfoPtr_returnCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "returnCharacterLabel");
			DaySceneDebugConsole.NativeFieldInfoPtr_selectedLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "selectedLabels");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldDialogListShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldDialogListShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldEventListShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldEventListShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldNPCConsoleShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldNPCConsoleShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldNPCDataShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldNPCDataShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldOnGUIBuffConsoleShown");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldScheduledDataShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldScheduledDataShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldTrackedCollectablesDataShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldTrackedCollectablesDataShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_shouldTrackedDataShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "shouldTrackedDataShow");
			DaySceneDebugConsole.NativeFieldInfoPtr_specialGuestSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "specialGuestSelections");
			DaySceneDebugConsole.NativeFieldInfoPtr_switchEntityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "switchEntityEnabled");
			DaySceneDebugConsole.NativeFieldInfoPtr_switchEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "switchEntityName");
			DaySceneDebugConsole.NativeFieldInfoPtr_teleportMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "teleportMapLabel");
			DaySceneDebugConsole.NativeFieldInfoPtr_unfoldedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "unfoldedNodes");
			DaySceneDebugConsole.NativeFieldInfoPtr_upgCharacterKizunaLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "upgCharacterKizunaLabel");
			DaySceneDebugConsole.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664539);
			DaySceneDebugConsole.NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664540);
			DaySceneDebugConsole.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664541);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowNPCsConsole_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664542);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowTrackedNPCs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664543);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowTrackedCollectables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664544);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowTrackedMission_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664545);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowScheduledEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664546);
			DaySceneDebugConsole.NativeMethodInfoPtr_InitializeEventLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664547);
			DaySceneDebugConsole.NativeMethodInfoPtr_DrawLine_Private_Void_Vector2_Vector2_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664548);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowEventListSet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664549);
			DaySceneDebugConsole.NativeMethodInfoPtr_ConnectNode_Private_Void_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664550);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowButtonSet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664551);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowTeleport_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664552);
			DaySceneDebugConsole.NativeMethodInfoPtr_InitializeDialogPackageNames_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664553);
			DaySceneDebugConsole.NativeMethodInfoPtr_ShowDialogListSet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664554);
			DaySceneDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664555);
			DaySceneDebugConsole.NativeMethodInfoPtr_Method_Private_Void_LabelStatus_String_byref___c__DisplayClass59_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664556);
			DaySceneDebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664557);
			DaySceneDebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664558);
			DaySceneDebugConsole.NativeMethodInfoPtr__ShowDialogListSet_b__64_0_Private_Void_AsyncOperationHandle_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, 100664559);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000B7970 File Offset: 0x000B5B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32486, XrefRangeEnd = 32487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000B79A4 File Offset: 0x000B5BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32487, XrefRangeEnd = 32600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDebugConsole.NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000B79E0 File Offset: 0x000B5BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32600, XrefRangeEnd = 32741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrawDebugConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDebugConsole.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000B7A1C File Offset: 0x000B5C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32939, RefRangeEnd = 32940, XrefRangeStart = 32741, XrefRangeEnd = 32939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowNPCsConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowNPCsConsole_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000B7A50 File Offset: 0x000B5C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32940, XrefRangeEnd = 32951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTrackedNPCs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowTrackedNPCs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000B7A84 File Offset: 0x000B5C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32951, XrefRangeEnd = 32962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTrackedCollectables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowTrackedCollectables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000B7AB8 File Offset: 0x000B5CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32962, XrefRangeEnd = 32976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTrackedMission()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowTrackedMission_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000B7AEC File Offset: 0x000B5CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32976, XrefRangeEnd = 32990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowScheduledEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowScheduledEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000B7B20 File Offset: 0x000B5D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32990, XrefRangeEnd = 33220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeEventLists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_InitializeEventLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000B7B54 File Offset: 0x000B5D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33253, RefRangeEnd = 33255, XrefRangeStart = 33220, XrefRangeEnd = 33253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pointA;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_DrawLine_Private_Void_Vector2_Vector2_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000B7BBC File Offset: 0x000B5DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33784, RefRangeEnd = 33785, XrefRangeStart = 33255, XrefRangeEnd = 33784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowEventListSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowEventListSet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000B7BF0 File Offset: 0x000B5DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33794, RefRangeEnd = 33795, XrefRangeStart = 33785, XrefRangeEnd = 33794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectNode(Rect start, Rect end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ConnectNode_Private_Void_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000B7C3C File Offset: 0x000B5E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34651, RefRangeEnd = 34652, XrefRangeStart = 33795, XrefRangeEnd = 34651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowButtonSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowButtonSet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000B7C70 File Offset: 0x000B5E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34652, XrefRangeEnd = 34675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTeleport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowTeleport_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000B7CA4 File Offset: 0x000B5EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34701, RefRangeEnd = 34702, XrefRangeStart = 34675, XrefRangeEnd = 34701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogPackageNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_InitializeDialogPackageNames_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000B7CD8 File Offset: 0x000B5ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34753, RefRangeEnd = 34754, XrefRangeStart = 34702, XrefRangeEnd = 34753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowDialogListSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_ShowDialogListSet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000B7D0C File Offset: 0x000B5F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34754, XrefRangeEnd = 34821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneDebugConsole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000B7D48 File Offset: 0x000B5F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34821, XrefRangeEnd = 34845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_LabelStatus_String_byref___c__DisplayClass59_0_PDM_0(DaySceneDebugConsole.LabelStatus labelStatus, string label, ref DaySceneDebugConsole.__c__DisplayClass59_0 A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref labelStatus;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_Method_Private_Void_LabelStatus_String_byref___c__DisplayClass59_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000B7DAC File Offset: 0x000B5FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34845, XrefRangeEnd = 34855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0(Il2CppStructArray<int> selectedId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000B7DE4 File Offset: 0x000B5FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34855, XrefRangeEnd = 34871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1(Il2CppStructArray<int> selectedId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000B7E1C File Offset: 0x000B601C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34871, XrefRangeEnd = 34890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowDialogListSet_b__64_0(AsyncOperationHandle<DialogPackage> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.NativeMethodInfoPtr__ShowDialogListSet_b__64_0_Private_Void_AsyncOperationHandle_1_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public DaySceneDebugConsole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000B7E64 File Offset: 0x000B6064
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00006BDD File Offset: 0x00004DDD
		public unsafe Il2CppReferenceArray<AssetReference> dialogPackages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000B7E94 File Offset: 0x000B6094
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00006BFC File Offset: 0x00004DFC
		public unsafe string addCharacterKizunaLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addCharacterKizunaLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addCharacterKizunaLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000B7EBC File Offset: 0x000B60BC
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00006C1B File Offset: 0x00004E1B
		public unsafe int addDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addDay)) = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000B7EE4 File Offset: 0x000B60E4
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00006C36 File Offset: 0x00004E36
		public unsafe int addExpAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addExpAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addExpAmount)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000B7F0C File Offset: 0x000B610C
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00006C51 File Offset: 0x00004E51
		public unsafe int addKizunaAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addKizunaAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_addKizunaAmount)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000B7F34 File Offset: 0x000B6134
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00006C6C File Offset: 0x00004E6C
		public unsafe Dictionary<string, string> allNPCSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_allNPCSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_allNPCSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000B7F64 File Offset: 0x000B6164
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00006C8B File Offset: 0x00004E8B
		public unsafe int changeDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_changeDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_changeDay)) = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000B7F8C File Offset: 0x000B618C
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00006CA6 File Offset: 0x00004EA6
		public unsafe int currentActionWarpCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_currentActionWarpCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_currentActionWarpCount)) = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000B7FB4 File Offset: 0x000B61B4
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00006CC1 File Offset: 0x00004EC1
		public unsafe int currentHourWarpCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_currentHourWarpCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_currentHourWarpCount)) = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000B7FDC File Offset: 0x000B61DC
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00006CDC File Offset: 0x00004EDC
		public unsafe bool diagramView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_diagramView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_diagramView)) = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000B8004 File Offset: 0x000B6204
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00006CF7 File Offset: 0x00004EF7
		public unsafe Dictionary<AssetReference, string> dialogPackageNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackageNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AssetReference, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackageNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000B8034 File Offset: 0x000B6234
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00006D16 File Offset: 0x00004F16
		public unsafe bool dialogPackagePlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackagePlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackagePlaying)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000B805C File Offset: 0x000B625C
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00006D31 File Offset: 0x00004F31
		public unsafe string dialogPackageSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackageSearch);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_dialogPackageSearch), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000B8084 File Offset: 0x000B6284
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00006D50 File Offset: 0x00004F50
		public Nullable<SchedulerNode.SchedulerType> fillter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_fillter);
				return new Nullable<SchedulerNode.SchedulerType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SchedulerNode.SchedulerType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_fillter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SchedulerNode.SchedulerType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000B80B4 File Offset: 0x000B62B4
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00006D7E File Offset: 0x00004F7E
		public unsafe string fillterText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_fillterText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_fillterText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000B80DC File Offset: 0x000B62DC
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00006D9D File Offset: 0x00004F9D
		public unsafe bool isColliderOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isColliderOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isColliderOff)) = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000B8104 File Offset: 0x000B6304
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public unsafe bool isKizunaCharacterSelectionExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isKizunaCharacterSelectionExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isKizunaCharacterSelectionExpaneded)) = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000B812C File Offset: 0x000B632C
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00006DD3 File Offset: 0x00004FD3
		public unsafe bool isKizunaCharacterUpgSelectionExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isKizunaCharacterUpgSelectionExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isKizunaCharacterUpgSelectionExpaneded)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000B8154 File Offset: 0x000B6354
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00006DEE File Offset: 0x00004FEE
		public unsafe bool isMoveCharacterSelectionExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isMoveCharacterSelectionExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isMoveCharacterSelectionExpaneded)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000B817C File Offset: 0x000B637C
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00006E09 File Offset: 0x00005009
		public unsafe bool isMoveMapSelectionExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isMoveMapSelectionExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isMoveMapSelectionExpaneded)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000B81A4 File Offset: 0x000B63A4
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00006E24 File Offset: 0x00005024
		public unsafe bool isPartnerExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isPartnerExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isPartnerExpanded)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000B81CC File Offset: 0x000B63CC
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00006E3F File Offset: 0x0000503F
		public unsafe bool isReturnCharacterSelectionExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isReturnCharacterSelectionExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isReturnCharacterSelectionExpaneded)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000B81F4 File Offset: 0x000B63F4
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00006E5A File Offset: 0x0000505A
		public unsafe bool isRotationSelectionExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isRotationSelectionExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isRotationSelectionExpaneded)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000B821C File Offset: 0x000B641C
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00006E75 File Offset: 0x00005075
		public unsafe bool isTeleportExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isTeleportExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_isTeleportExpanded)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000B8244 File Offset: 0x000B6444
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00006E90 File Offset: 0x00005090
		public unsafe Dictionary<DaySceneDebugConsole.LabelStatus, string> labelsToSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_labelsToSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DaySceneDebugConsole.LabelStatus, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_labelsToSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000B8274 File Offset: 0x000B6474
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00006EAF File Offset: 0x000050AF
		public unsafe Texture2D lineTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_lineTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_lineTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000B82A4 File Offset: 0x000B64A4
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00006ECE File Offset: 0x000050CE
		public unsafe Vector2 m_NPCConsoleScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_m_NPCConsoleScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_m_NPCConsoleScroll)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x000B82CC File Offset: 0x000B64CC
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00006EE9 File Offset: 0x000050E9
		public unsafe Dictionary<string, string> mapSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_mapSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_mapSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000B82FC File Offset: 0x000B64FC
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00006F08 File Offset: 0x00005108
		public unsafe string moveCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x000B8324 File Offset: 0x000B6524
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00006F27 File Offset: 0x00005127
		public unsafe Vector2 moveCharPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveCharPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveCharPos)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000B834C File Offset: 0x000B654C
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00006F42 File Offset: 0x00005142
		public unsafe int moveCharRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveCharRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveCharRotation)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x000B8374 File Offset: 0x000B6574
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00006F5D File Offset: 0x0000515D
		public unsafe string moveMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_moveMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x000B839C File Offset: 0x000B659C
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00006F7C File Offset: 0x0000517C
		public unsafe Vector2 pannelScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_pannelScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_pannelScroll)) = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000B83C4 File Offset: 0x000B65C4
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00006F97 File Offset: 0x00005197
		public unsafe string returnCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_returnCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_returnCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000B83EC File Offset: 0x000B65EC
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00006FB6 File Offset: 0x000051B6
		public unsafe List<DaySceneDebugConsole.LabelStatus> selectedLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_selectedLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneDebugConsole.LabelStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_selectedLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x000B841C File Offset: 0x000B661C
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00006FD5 File Offset: 0x000051D5
		public unsafe bool shouldDialogListShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldDialogListShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldDialogListShow)) = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x000B8444 File Offset: 0x000B6644
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00006FF0 File Offset: 0x000051F0
		public unsafe bool shouldEventListShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldEventListShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldEventListShow)) = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000B846C File Offset: 0x000B666C
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x0000700B File Offset: 0x0000520B
		public unsafe bool shouldNPCConsoleShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldNPCConsoleShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldNPCConsoleShow)) = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000B8494 File Offset: 0x000B6694
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00007026 File Offset: 0x00005226
		public unsafe bool shouldNPCDataShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldNPCDataShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldNPCDataShow)) = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000B84BC File Offset: 0x000B66BC
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00007041 File Offset: 0x00005241
		public unsafe bool shouldOnGUIBuffConsoleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown)) = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000B84E4 File Offset: 0x000B66E4
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0000705C File Offset: 0x0000525C
		public unsafe bool shouldScheduledDataShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldScheduledDataShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldScheduledDataShow)) = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000B850C File Offset: 0x000B670C
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00007077 File Offset: 0x00005277
		public unsafe bool shouldTrackedCollectablesDataShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldTrackedCollectablesDataShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldTrackedCollectablesDataShow)) = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000B8534 File Offset: 0x000B6734
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00007092 File Offset: 0x00005292
		public unsafe bool shouldTrackedDataShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldTrackedDataShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_shouldTrackedDataShow)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x000B855C File Offset: 0x000B675C
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000070AD File Offset: 0x000052AD
		public unsafe Dictionary<string, string> specialGuestSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_specialGuestSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_specialGuestSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x000B858C File Offset: 0x000B678C
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x000070CC File Offset: 0x000052CC
		public unsafe bool switchEntityEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_switchEntityEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_switchEntityEnabled)) = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000B85B4 File Offset: 0x000B67B4
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x000070E7 File Offset: 0x000052E7
		public unsafe string switchEntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_switchEntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_switchEntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x000B85DC File Offset: 0x000B67DC
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00007106 File Offset: 0x00005306
		public unsafe string teleportMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_teleportMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_teleportMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x000B8604 File Offset: 0x000B6804
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00007125 File Offset: 0x00005325
		public unsafe List<Queue<DaySceneDebugConsole.Node>> unfoldedNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_unfoldedNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Queue<DaySceneDebugConsole.Node>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_unfoldedNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000B8634 File Offset: 0x000B6834
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00007144 File Offset: 0x00005344
		public unsafe string upgCharacterKizunaLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_upgCharacterKizunaLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.NativeFieldInfoPtr_upgCharacterKizunaLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackages;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr_addCharacterKizunaLabel;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeFieldInfoPtr_addDay;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_addExpAmount;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeFieldInfoPtr_addKizunaAmount;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_allNPCSelections;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeFieldInfoPtr_changeDay;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr_currentActionWarpCount;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr_currentHourWarpCount;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr_diagramView;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackageNames;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackagePlaying;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackageSearch;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_fillter;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_fillterText;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_isColliderOff;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_isKizunaCharacterSelectionExpaneded;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_isKizunaCharacterUpgSelectionExpaneded;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_isMoveCharacterSelectionExpaneded;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr_isMoveMapSelectionExpaneded;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr_isPartnerExpanded;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr_isReturnCharacterSelectionExpaneded;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr_isRotationSelectionExpaneded;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr_isTeleportExpanded;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_labelsToSpawn;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr_lineTex;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr_m_NPCConsoleScroll;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_mapSelections;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr_moveCharacterLabel;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_moveCharPos;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_moveCharRotation;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_moveMapLabel;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_pannelScroll;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_returnCharacterLabel;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_selectedLabels;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_shouldDialogListShow;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_shouldEventListShow;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_shouldNPCConsoleShow;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_shouldNPCDataShow;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_shouldScheduledDataShow;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_shouldTrackedCollectablesDataShow;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_shouldTrackedDataShow;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestSelections;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_switchEntityEnabled;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_switchEntityName;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_teleportMapLabel;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_unfoldedNodes;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_upgCharacterKizunaLabel;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_ShowNPCsConsole_Private_Void_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_ShowTrackedNPCs_Private_Void_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_ShowTrackedCollectables_Private_Void_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_ShowTrackedMission_Private_Void_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_ShowScheduledEvent_Private_Void_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_InitializeEventLists_Private_Void_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Private_Void_Vector2_Vector2_Color_Single_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_ShowEventListSet_Private_Void_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_ConnectNode_Private_Void_Rect_Rect_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_ShowButtonSet_Private_Void_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_ShowTeleport_Private_Void_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogPackageNames_Private_Void_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_ShowDialogListSet_Private_Void_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_LabelStatus_String_byref___c__DisplayClass59_0_PDM_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr__ShowDialogListSet_b__64_0_Private_Void_AsyncOperationHandle_1_DialogPackage_0;

		// Token: 0x020004F7 RID: 1271
		public class Node : Il2CppSystem.Object
		{
			// Token: 0x060082DF RID: 33503 RVA: 0x0024D6C8 File Offset: 0x0024B8C8
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr);
				DaySceneDebugConsole.Node.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, "children");
				DaySceneDebugConsole.Node.NativeFieldInfoPtr_nullString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, "nullString");
				DaySceneDebugConsole.Node.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, "parent");
				DaySceneDebugConsole.Node.NativeFieldInfoPtr_rectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, "rectPosition");
				DaySceneDebugConsole.Node.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, "value");
				DaySceneDebugConsole.Node.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, 100664560);
				DaySceneDebugConsole.Node.NativeMethodInfoPtr_GetDate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, 100664561);
				DaySceneDebugConsole.Node.NativeMethodInfoPtr_GetAbsoluteTime_Private_Static_Int32_Node_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, 100664562);
				DaySceneDebugConsole.Node.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr, 100664563);
			}

			// Token: 0x060082E0 RID: 33504 RVA: 0x0024D7A8 File Offset: 0x0024B9A8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 32155, RefRangeEnd = 32159, XrefRangeStart = 32155, XrefRangeEnd = 32155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDebugConsole.Node.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082E1 RID: 33505 RVA: 0x0024D7EC File Offset: 0x0024B9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32159, XrefRangeEnd = 32160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetDate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.Node.NativeMethodInfoPtr_GetDate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082E2 RID: 33506 RVA: 0x0024D828 File Offset: 0x0024BA28
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 32176, RefRangeEnd = 32182, XrefRangeStart = 32160, XrefRangeEnd = 32176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetAbsoluteTime(DaySceneDebugConsole.Node nodeData, int additiveTime, ref int iteration)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additiveTime;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iteration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.Node.NativeMethodInfoPtr_GetAbsoluteTime_Private_Static_Int32_Node_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082E3 RID: 33507 RVA: 0x0024D888 File Offset: 0x0024BA88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.Node>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.Node.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082E4 RID: 33508 RVA: 0x00046A09 File Offset: 0x00044C09
			public Node(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C09 RID: 11273
			// (get) Token: 0x060082E5 RID: 33509 RVA: 0x0024D8C4 File Offset: 0x0024BAC4
			// (set) Token: 0x060082E6 RID: 33510 RVA: 0x00046A12 File Offset: 0x00044C12
			public unsafe Il2CppReferenceArray<DaySceneDebugConsole.Node> children
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_children);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneDebugConsole.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C0A RID: 11274
			// (get) Token: 0x060082E7 RID: 33511 RVA: 0x0024D8F4 File Offset: 0x0024BAF4
			// (set) Token: 0x060082E8 RID: 33512 RVA: 0x00046A31 File Offset: 0x00044C31
			public unsafe string nullString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_nullString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_nullString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002C0B RID: 11275
			// (get) Token: 0x060082E9 RID: 33513 RVA: 0x0024D91C File Offset: 0x0024BB1C
			// (set) Token: 0x060082EA RID: 33514 RVA: 0x00046A50 File Offset: 0x00044C50
			public unsafe DaySceneDebugConsole.Node parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C0C RID: 11276
			// (get) Token: 0x060082EB RID: 33515 RVA: 0x0024D94C File Offset: 0x0024BB4C
			// (set) Token: 0x060082EC RID: 33516 RVA: 0x00046A6F File Offset: 0x00044C6F
			public Nullable<Rect> rectPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_rectPosition);
					return new Nullable<Rect>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Rect>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_rectPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Rect>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002C0D RID: 11277
			// (get) Token: 0x060082ED RID: 33517 RVA: 0x0024D97C File Offset: 0x0024BB7C
			// (set) Token: 0x060082EE RID: 33518 RVA: 0x00046A9D File Offset: 0x00044C9D
			public unsafe SchedulerNode value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchedulerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.Node.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040055B9 RID: 21945
			private static readonly IntPtr NativeFieldInfoPtr_children;

			// Token: 0x040055BA RID: 21946
			private static readonly IntPtr NativeFieldInfoPtr_nullString;

			// Token: 0x040055BB RID: 21947
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040055BC RID: 21948
			private static readonly IntPtr NativeFieldInfoPtr_rectPosition;

			// Token: 0x040055BD RID: 21949
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040055BE RID: 21950
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040055BF RID: 21951
			private static readonly IntPtr NativeMethodInfoPtr_GetDate_Public_Int32_0;

			// Token: 0x040055C0 RID: 21952
			private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteTime_Private_Static_Int32_Node_Int32_byref_Int32_0;

			// Token: 0x040055C1 RID: 21953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004F8 RID: 1272
		public enum LabelStatus
		{
			// Token: 0x040055C3 RID: 21955
			Whole,
			// Token: 0x040055C4 RID: 21956
			Core,
			// Token: 0x040055C5 RID: 21957
			DLC1,
			// Token: 0x040055C6 RID: 21958
			DLC2,
			// Token: 0x040055C7 RID: 21959
			DLC3,
			// Token: 0x040055C8 RID: 21960
			DLC4,
			// Token: 0x040055C9 RID: 21961
			DLC5,
			// Token: 0x040055CA RID: 21962
			DLCMusic
		}

		// Token: 0x020004F9 RID: 1273
		public enum PartnerCount
		{
			// Token: 0x040055CC RID: 21964
			I = 1,
			// Token: 0x040055CD RID: 21965
			II,
			// Token: 0x040055CE RID: 21966
			III
		}

		// Token: 0x020004FA RID: 1274
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060082EF RID: 33519 RVA: 0x0024D9AC File Offset: 0x0024BBAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr);
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_0");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_1");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_2");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_3");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_4");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_5");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__50_6");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__57_2");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__57_9");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__57_3");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__57_15");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_1");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_2");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_3");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_0");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_4");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_5");
				DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, "<>9__61_7");
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664565);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664566);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664567);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_2_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664568);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664569);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_4_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664570);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_5_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664571);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_6_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664572);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_2_Internal_Int32_KeyValuePair_2_Int32_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664573);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_9_Internal_IEnumerable_1_Node_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664574);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_3_Internal_IEnumerable_1_Queue_1_Node_List_1_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664575);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_15_Internal_Int32_KeyValuePair_2_Int32_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664576);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_1_Internal_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664577);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_2_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664578);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_3_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664579);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_0_Internal_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664580);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_4_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664581);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_5_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664582);
				DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_7_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr, 100664583);
			}

			// Token: 0x060082F0 RID: 33520 RVA: 0x0024DCD0 File Offset: 0x0024BED0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082F1 RID: 33521 RVA: 0x0024DD0C File Offset: 0x0024BF0C
			[CallerCount(0)]
			public unsafe string _OnStart_b__50_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082F2 RID: 33522 RVA: 0x0024DD54 File Offset: 0x0024BF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32182, XrefRangeEnd = 32188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnStart_b__50_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082F3 RID: 33523 RVA: 0x0024DD9C File Offset: 0x0024BF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32188, XrefRangeEnd = 32189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnStart_b__50_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_2_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082F4 RID: 33524 RVA: 0x0024DDEC File Offset: 0x0024BFEC
			[CallerCount(0)]
			public unsafe string _OnStart_b__50_3(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082F5 RID: 33525 RVA: 0x0024DE34 File Offset: 0x0024C034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32189, XrefRangeEnd = 32195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnStart_b__50_4(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_4_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082F6 RID: 33526 RVA: 0x0024DE7C File Offset: 0x0024C07C
			[CallerCount(0)]
			public unsafe string _OnStart_b__50_5(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_5_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082F7 RID: 33527 RVA: 0x0024DEC4 File Offset: 0x0024C0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32195, XrefRangeEnd = 32202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnStart_b__50_6(string y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__50_6_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082F8 RID: 33528 RVA: 0x0024DF0C File Offset: 0x0024C10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32202, XrefRangeEnd = 32203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitializeEventLists_b__57_2(KeyValuePair<int, Queue<DaySceneDebugConsole.Node>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_2_Internal_Int32_KeyValuePair_2_Int32_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082F9 RID: 33529 RVA: 0x0024DF60 File Offset: 0x0024C160
			[CallerCount(0)]
			public unsafe IEnumerable<DaySceneDebugConsole.Node> _InitializeEventLists_b__57_9(Queue<DaySceneDebugConsole.Node> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_9_Internal_IEnumerable_1_Node_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneDebugConsole.Node>>(intPtr3) : null;
			}

			// Token: 0x060082FA RID: 33530 RVA: 0x0024DFB0 File Offset: 0x0024C1B0
			[CallerCount(0)]
			public unsafe IEnumerable<Queue<DaySceneDebugConsole.Node>> _InitializeEventLists_b__57_3(List<Queue<DaySceneDebugConsole.Node>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_3_Internal_IEnumerable_1_Queue_1_Node_List_1_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Queue<DaySceneDebugConsole.Node>>>(intPtr3) : null;
			}

			// Token: 0x060082FB RID: 33531 RVA: 0x0024E000 File Offset: 0x0024C200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32203, XrefRangeEnd = 32204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitializeEventLists_b__57_15(KeyValuePair<int, Queue<DaySceneDebugConsole.Node>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__InitializeEventLists_b__57_15_Internal_Int32_KeyValuePair_2_Int32_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082FC RID: 33532 RVA: 0x0024E054 File Offset: 0x0024C254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32204, XrefRangeEnd = 32205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe _ShowButtonSet_b__61_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_1_Internal_Recipe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x060082FD RID: 33533 RVA: 0x0024E0A0 File Offset: 0x0024C2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32205, XrefRangeEnd = 32206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ShowButtonSet_b__61_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_2_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082FE RID: 33534 RVA: 0x0024E0E4 File Offset: 0x0024C2E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32206, XrefRangeEnd = 32210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ShowButtonSet_b__61_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_3_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082FF RID: 33535 RVA: 0x0024E128 File Offset: 0x0024C328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32210, XrefRangeEnd = 32220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowButtonSet_b__61_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_0_Internal_Void_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008300 RID: 33536 RVA: 0x0024E16C File Offset: 0x0024C36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32220, XrefRangeEnd = 32230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ShowButtonSet_b__61_4(Il2CppSystem.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_4_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008301 RID: 33537 RVA: 0x0024E1B4 File Offset: 0x0024C3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32230, XrefRangeEnd = 32236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowButtonSet_b__61_5(ValueTuple<IEnumerable<Il2CppSystem.Object>, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_5_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008302 RID: 33538 RVA: 0x0024E208 File Offset: 0x0024C408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32236, XrefRangeEnd = 32243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ShowButtonSet_b__61_7(Il2CppSystem.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c.NativeMethodInfoPtr__ShowButtonSet_b__61_7_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008303 RID: 33539 RVA: 0x00046ABC File Offset: 0x00044CBC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C0E RID: 11278
			// (get) Token: 0x06008304 RID: 33540 RVA: 0x0024E250 File Offset: 0x0024C450
			// (set) Token: 0x06008305 RID: 33541 RVA: 0x00046AC5 File Offset: 0x00044CC5
			public unsafe static DaySceneDebugConsole.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C0F RID: 11279
			// (get) Token: 0x06008306 RID: 33542 RVA: 0x0024E278 File Offset: 0x0024C478
			// (set) Token: 0x06008307 RID: 33543 RVA: 0x00046AD7 File Offset: 0x00044CD7
			public unsafe static Func<string, string> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C10 RID: 11280
			// (get) Token: 0x06008308 RID: 33544 RVA: 0x0024E2A0 File Offset: 0x0024C4A0
			// (set) Token: 0x06008309 RID: 33545 RVA: 0x00046AE9 File Offset: 0x00044CE9
			public unsafe static Func<string, string> __9__50_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C11 RID: 11281
			// (get) Token: 0x0600830A RID: 33546 RVA: 0x0024E2C8 File Offset: 0x0024C4C8
			// (set) Token: 0x0600830B RID: 33547 RVA: 0x00046AFB File Offset: 0x00044CFB
			public unsafe static Func<string, bool> __9__50_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C12 RID: 11282
			// (get) Token: 0x0600830C RID: 33548 RVA: 0x0024E2F0 File Offset: 0x0024C4F0
			// (set) Token: 0x0600830D RID: 33549 RVA: 0x00046B0D File Offset: 0x00044D0D
			public unsafe static Func<string, string> __9__50_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C13 RID: 11283
			// (get) Token: 0x0600830E RID: 33550 RVA: 0x0024E318 File Offset: 0x0024C518
			// (set) Token: 0x0600830F RID: 33551 RVA: 0x00046B1F File Offset: 0x00044D1F
			public unsafe static Func<string, string> __9__50_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C14 RID: 11284
			// (get) Token: 0x06008310 RID: 33552 RVA: 0x0024E340 File Offset: 0x0024C540
			// (set) Token: 0x06008311 RID: 33553 RVA: 0x00046B31 File Offset: 0x00044D31
			public unsafe static Func<string, string> __9__50_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C15 RID: 11285
			// (get) Token: 0x06008312 RID: 33554 RVA: 0x0024E368 File Offset: 0x0024C568
			// (set) Token: 0x06008313 RID: 33555 RVA: 0x00046B43 File Offset: 0x00044D43
			public unsafe static Func<string, string> __9__50_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__50_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C16 RID: 11286
			// (get) Token: 0x06008314 RID: 33556 RVA: 0x0024E390 File Offset: 0x0024C590
			// (set) Token: 0x06008315 RID: 33557 RVA: 0x00046B55 File Offset: 0x00044D55
			public unsafe static Func<KeyValuePair<int, Queue<DaySceneDebugConsole.Node>>, int> __9__57_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Queue<DaySceneDebugConsole.Node>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C17 RID: 11287
			// (get) Token: 0x06008316 RID: 33558 RVA: 0x0024E3B8 File Offset: 0x0024C5B8
			// (set) Token: 0x06008317 RID: 33559 RVA: 0x00046B67 File Offset: 0x00044D67
			public unsafe static Func<Queue<DaySceneDebugConsole.Node>, IEnumerable<DaySceneDebugConsole.Node>> __9__57_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Queue<DaySceneDebugConsole.Node>, IEnumerable<DaySceneDebugConsole.Node>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C18 RID: 11288
			// (get) Token: 0x06008318 RID: 33560 RVA: 0x0024E3E0 File Offset: 0x0024C5E0
			// (set) Token: 0x06008319 RID: 33561 RVA: 0x00046B79 File Offset: 0x00044D79
			public unsafe static Func<List<Queue<DaySceneDebugConsole.Node>>, IEnumerable<Queue<DaySceneDebugConsole.Node>>> __9__57_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<Queue<DaySceneDebugConsole.Node>>, IEnumerable<Queue<DaySceneDebugConsole.Node>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C19 RID: 11289
			// (get) Token: 0x0600831A RID: 33562 RVA: 0x0024E408 File Offset: 0x0024C608
			// (set) Token: 0x0600831B RID: 33563 RVA: 0x00046B8B File Offset: 0x00044D8B
			public unsafe static Func<KeyValuePair<int, Queue<DaySceneDebugConsole.Node>>, int> __9__57_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Queue<DaySceneDebugConsole.Node>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__57_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C1A RID: 11290
			// (get) Token: 0x0600831C RID: 33564 RVA: 0x0024E430 File Offset: 0x0024C630
			// (set) Token: 0x0600831D RID: 33565 RVA: 0x00046B9D File Offset: 0x00044D9D
			public unsafe static Func<int, Recipe> __9__61_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C1B RID: 11291
			// (get) Token: 0x0600831E RID: 33566 RVA: 0x0024E458 File Offset: 0x0024C658
			// (set) Token: 0x0600831F RID: 33567 RVA: 0x00046BAF File Offset: 0x00044DAF
			public unsafe static Func<int, string> __9__61_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C1C RID: 11292
			// (get) Token: 0x06008320 RID: 33568 RVA: 0x0024E480 File Offset: 0x0024C680
			// (set) Token: 0x06008321 RID: 33569 RVA: 0x00046BC1 File Offset: 0x00044DC1
			public unsafe static Func<int, string> __9__61_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C1D RID: 11293
			// (get) Token: 0x06008322 RID: 33570 RVA: 0x0024E4A8 File Offset: 0x0024C6A8
			// (set) Token: 0x06008323 RID: 33571 RVA: 0x00046BD3 File Offset: 0x00044DD3
			public unsafe static Action<SpecialGuest> __9__61_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C1E RID: 11294
			// (get) Token: 0x06008324 RID: 33572 RVA: 0x0024E4D0 File Offset: 0x0024C6D0
			// (set) Token: 0x06008325 RID: 33573 RVA: 0x00046BE5 File Offset: 0x00044DE5
			public unsafe static Func<Il2CppSystem.Object, string> __9__61_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppSystem.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C1F RID: 11295
			// (get) Token: 0x06008326 RID: 33574 RVA: 0x0024E4F8 File Offset: 0x0024C6F8
			// (set) Token: 0x06008327 RID: 33575 RVA: 0x00046BF7 File Offset: 0x00044DF7
			public unsafe static Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> __9__61_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C20 RID: 11296
			// (get) Token: 0x06008328 RID: 33576 RVA: 0x0024E520 File Offset: 0x0024C720
			// (set) Token: 0x06008329 RID: 33577 RVA: 0x00046C09 File Offset: 0x00044E09
			public unsafe static Func<Il2CppSystem.Object, string> __9__61_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppSystem.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugConsole.__c.NativeFieldInfoPtr___9__61_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040055CF RID: 21967
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040055D0 RID: 21968
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x040055D1 RID: 21969
			private static readonly IntPtr NativeFieldInfoPtr___9__50_1;

			// Token: 0x040055D2 RID: 21970
			private static readonly IntPtr NativeFieldInfoPtr___9__50_2;

			// Token: 0x040055D3 RID: 21971
			private static readonly IntPtr NativeFieldInfoPtr___9__50_3;

			// Token: 0x040055D4 RID: 21972
			private static readonly IntPtr NativeFieldInfoPtr___9__50_4;

			// Token: 0x040055D5 RID: 21973
			private static readonly IntPtr NativeFieldInfoPtr___9__50_5;

			// Token: 0x040055D6 RID: 21974
			private static readonly IntPtr NativeFieldInfoPtr___9__50_6;

			// Token: 0x040055D7 RID: 21975
			private static readonly IntPtr NativeFieldInfoPtr___9__57_2;

			// Token: 0x040055D8 RID: 21976
			private static readonly IntPtr NativeFieldInfoPtr___9__57_9;

			// Token: 0x040055D9 RID: 21977
			private static readonly IntPtr NativeFieldInfoPtr___9__57_3;

			// Token: 0x040055DA RID: 21978
			private static readonly IntPtr NativeFieldInfoPtr___9__57_15;

			// Token: 0x040055DB RID: 21979
			private static readonly IntPtr NativeFieldInfoPtr___9__61_1;

			// Token: 0x040055DC RID: 21980
			private static readonly IntPtr NativeFieldInfoPtr___9__61_2;

			// Token: 0x040055DD RID: 21981
			private static readonly IntPtr NativeFieldInfoPtr___9__61_3;

			// Token: 0x040055DE RID: 21982
			private static readonly IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x040055DF RID: 21983
			private static readonly IntPtr NativeFieldInfoPtr___9__61_4;

			// Token: 0x040055E0 RID: 21984
			private static readonly IntPtr NativeFieldInfoPtr___9__61_5;

			// Token: 0x040055E1 RID: 21985
			private static readonly IntPtr NativeFieldInfoPtr___9__61_7;

			// Token: 0x040055E2 RID: 21986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040055E3 RID: 21987
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_0_Internal_String_String_0;

			// Token: 0x040055E4 RID: 21988
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_1_Internal_String_String_0;

			// Token: 0x040055E5 RID: 21989
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_2_Internal_Boolean_String_0;

			// Token: 0x040055E6 RID: 21990
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_3_Internal_String_String_0;

			// Token: 0x040055E7 RID: 21991
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_4_Internal_String_String_0;

			// Token: 0x040055E8 RID: 21992
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_5_Internal_String_String_0;

			// Token: 0x040055E9 RID: 21993
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__50_6_Internal_String_String_0;

			// Token: 0x040055EA RID: 21994
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__57_2_Internal_Int32_KeyValuePair_2_Int32_Queue_1_Node_0;

			// Token: 0x040055EB RID: 21995
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__57_9_Internal_IEnumerable_1_Node_Queue_1_Node_0;

			// Token: 0x040055EC RID: 21996
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__57_3_Internal_IEnumerable_1_Queue_1_Node_List_1_Queue_1_Node_0;

			// Token: 0x040055ED RID: 21997
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__57_15_Internal_Int32_KeyValuePair_2_Int32_Queue_1_Node_0;

			// Token: 0x040055EE RID: 21998
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_1_Internal_Recipe_Int32_0;

			// Token: 0x040055EF RID: 21999
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_2_Internal_String_Int32_0;

			// Token: 0x040055F0 RID: 22000
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_3_Internal_String_Int32_0;

			// Token: 0x040055F1 RID: 22001
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_0_Internal_Void_SpecialGuest_0;

			// Token: 0x040055F2 RID: 22002
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_4_Internal_String_Object_0;

			// Token: 0x040055F3 RID: 22003
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_5_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;

			// Token: 0x040055F4 RID: 22004
			private static readonly IntPtr NativeMethodInfoPtr__ShowButtonSet_b__61_7_Internal_String_Object_0;
		}

		// Token: 0x020004FB RID: 1275
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600832A RID: 33578 RVA: 0x0024E548 File Offset: 0x0024C748
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr_nodesDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, "nodesDictionary");
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr_processedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, "processedNode");
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, "<>4__this");
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664584);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Node_Node_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664585);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Void_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664586);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Void_Node_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664587);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Int32_Node_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664588);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_IEnumerable_1_Int32_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664589);
				DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Void_Node_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr, 100664590);
			}

			// Token: 0x0600832B RID: 33579 RVA: 0x0024E63C File Offset: 0x0024C83C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600832C RID: 33580 RVA: 0x0024E678 File Offset: 0x0024C878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32243, XrefRangeEnd = 32253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DaySceneDebugConsole.Node Method_Internal_Node_Node_String_PDM_0(DaySceneDebugConsole.Node root, string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Node_Node_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.Node>(intPtr3) : null;
			}

			// Token: 0x0600832D RID: 33581 RVA: 0x0024E6DC File Offset: 0x0024C8DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32269, RefRangeEnd = 32270, XrefRangeStart = 32253, XrefRangeEnd = 32269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Node_0(DaySceneDebugConsole.Node nodeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Void_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600832E RID: 33582 RVA: 0x0024E720 File Offset: 0x0024C920
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 32288, RefRangeEnd = 32290, XrefRangeStart = 32270, XrefRangeEnd = 32288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Node_1(DaySceneDebugConsole.Node root)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Void_Node_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600832F RID: 33583 RVA: 0x0024E764 File Offset: 0x0024C964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32290, XrefRangeEnd = 32317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_Node_PDM_0(DaySceneDebugConsole.Node nodeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Int32_Node_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008330 RID: 33584 RVA: 0x0024E7B4 File Offset: 0x0024C9B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32364, RefRangeEnd = 32365, XrefRangeStart = 32317, XrefRangeEnd = 32364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> Method_Internal_IEnumerable_1_Int32_Node_0(DaySceneDebugConsole.Node child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_IEnumerable_1_Int32_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008331 RID: 33585 RVA: 0x0024E804 File Offset: 0x0024CA04
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 32421, RefRangeEnd = 32423, XrefRangeStart = 32365, XrefRangeEnd = 32421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Node_2(DaySceneDebugConsole.Node root)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_0.NativeMethodInfoPtr_Method_Internal_Void_Node_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008332 RID: 33586 RVA: 0x00046C1B File Offset: 0x00044E1B
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C21 RID: 11297
			// (get) Token: 0x06008333 RID: 33587 RVA: 0x0024E848 File Offset: 0x0024CA48
			// (set) Token: 0x06008334 RID: 33588 RVA: 0x00046C24 File Offset: 0x00044E24
			public unsafe Dictionary<string, DaySceneDebugConsole.Node> nodesDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr_nodesDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DaySceneDebugConsole.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr_nodesDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C22 RID: 11298
			// (get) Token: 0x06008335 RID: 33589 RVA: 0x0024E878 File Offset: 0x0024CA78
			// (set) Token: 0x06008336 RID: 33590 RVA: 0x00046C43 File Offset: 0x00044E43
			public unsafe Dictionary<int, Queue<DaySceneDebugConsole.Node>> processedNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr_processedNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Queue<DaySceneDebugConsole.Node>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr_processedNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C23 RID: 11299
			// (get) Token: 0x06008337 RID: 33591 RVA: 0x0024E8A8 File Offset: 0x0024CAA8
			// (set) Token: 0x06008338 RID: 33592 RVA: 0x00046C62 File Offset: 0x00044E62
			public unsafe DaySceneDebugConsole __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040055F5 RID: 22005
			private static readonly IntPtr NativeFieldInfoPtr_nodesDictionary;

			// Token: 0x040055F6 RID: 22006
			private static readonly IntPtr NativeFieldInfoPtr_processedNode;

			// Token: 0x040055F7 RID: 22007
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040055F8 RID: 22008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040055F9 RID: 22009
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Node_Node_String_PDM_0;

			// Token: 0x040055FA RID: 22010
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Node_0;

			// Token: 0x040055FB RID: 22011
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Node_1;

			// Token: 0x040055FC RID: 22012
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_Node_PDM_0;

			// Token: 0x040055FD RID: 22013
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerable_1_Int32_Node_0;

			// Token: 0x040055FE RID: 22014
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Node_2;
		}

		// Token: 0x020004FC RID: 1276
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass57_1")]
		public sealed class __c__DisplayClass57_1 : Il2CppSystem.Object
		{
			// Token: 0x06008339 RID: 33593 RVA: 0x0024E8D8 File Offset: 0x0024CAD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_1()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass57_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass57_1.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr, "item");
				DaySceneDebugConsole.__c__DisplayClass57_1.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr, "CS$<>8__locals1");
				DaySceneDebugConsole.__c__DisplayClass57_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr, 100664591);
				DaySceneDebugConsole.__c__DisplayClass57_1.NativeMethodInfoPtr__InitializeEventLists_b__8_Internal_Node_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr, 100664592);
			}

			// Token: 0x0600833A RID: 33594 RVA: 0x0024E954 File Offset: 0x0024CB54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600833B RID: 33595 RVA: 0x0024E990 File Offset: 0x0024CB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32423, XrefRangeEnd = 32433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DaySceneDebugConsole.Node _InitializeEventLists_b__8(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_1.NativeMethodInfoPtr__InitializeEventLists_b__8_Internal_Node_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.Node>(intPtr3) : null;
			}

			// Token: 0x0600833C RID: 33596 RVA: 0x00046C81 File Offset: 0x00044E81
			public __c__DisplayClass57_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C24 RID: 11300
			// (get) Token: 0x0600833D RID: 33597 RVA: 0x0024E9E0 File Offset: 0x0024CBE0
			// (set) Token: 0x0600833E RID: 33598 RVA: 0x00046C8A File Offset: 0x00044E8A
			public unsafe DaySceneDebugConsole.Node item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_1.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_1.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C25 RID: 11301
			// (get) Token: 0x0600833F RID: 33599 RVA: 0x0024EA10 File Offset: 0x0024CC10
			// (set) Token: 0x06008340 RID: 33600 RVA: 0x00046CA9 File Offset: 0x00044EA9
			public unsafe DaySceneDebugConsole.__c__DisplayClass57_0 field_Public___c__DisplayClass57_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_1.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.__c__DisplayClass57_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_1.NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040055FF RID: 22015
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04005600 RID: 22016
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass57_0_0;

			// Token: 0x04005601 RID: 22017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005602 RID: 22018
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__8_Internal_Node_String_0;
		}

		// Token: 0x020004FD RID: 1277
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass57_2")]
		public sealed class __c__DisplayClass57_2 : Il2CppSystem.Object
		{
			// Token: 0x06008341 RID: 33601 RVA: 0x0024EA40 File Offset: 0x0024CC40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_2()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass57_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass57_2.NativeFieldInfoPtr_nodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr, "nodeData");
				DaySceneDebugConsole.__c__DisplayClass57_2.NativeFieldInfoPtr___9__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr, "<>9__12");
				DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr, 100664593);
				DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__InitializeEventLists_b__10_Internal_Boolean_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr, 100664594);
				DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__InitializeEventLists_b__12_Internal_Boolean_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr, 100664595);
				DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__InitializeEventLists_b__11_Internal_Boolean_KeyValuePair_2_Int32_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr, 100664596);
			}

			// Token: 0x06008342 RID: 33602 RVA: 0x0024EAE4 File Offset: 0x0024CCE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008343 RID: 33603 RVA: 0x0024EB20 File Offset: 0x0024CD20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32433, XrefRangeEnd = 32444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeEventLists_b__10(Queue<DaySceneDebugConsole.Node> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__InitializeEventLists_b__10_Internal_Boolean_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008344 RID: 33604 RVA: 0x0024EB70 File Offset: 0x0024CD70
			[CallerCount(0)]
			public unsafe bool _InitializeEventLists_b__12(DaySceneDebugConsole.Node y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__InitializeEventLists_b__12_Internal_Boolean_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008345 RID: 33605 RVA: 0x0024EBC0 File Offset: 0x0024CDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32444, XrefRangeEnd = 32445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeEventLists_b__11(KeyValuePair<int, DaySceneDebugConsole.Node> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_2.NativeMethodInfoPtr__InitializeEventLists_b__11_Internal_Boolean_KeyValuePair_2_Int32_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008346 RID: 33606 RVA: 0x00046CC8 File Offset: 0x00044EC8
			public __c__DisplayClass57_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C26 RID: 11302
			// (get) Token: 0x06008347 RID: 33607 RVA: 0x0024EC14 File Offset: 0x0024CE14
			// (set) Token: 0x06008348 RID: 33608 RVA: 0x00046CD1 File Offset: 0x00044ED1
			public unsafe DaySceneDebugConsole.Node nodeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_2.NativeFieldInfoPtr_nodeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_2.NativeFieldInfoPtr_nodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C27 RID: 11303
			// (get) Token: 0x06008349 RID: 33609 RVA: 0x0024EC44 File Offset: 0x0024CE44
			// (set) Token: 0x0600834A RID: 33610 RVA: 0x00046CF0 File Offset: 0x00044EF0
			public unsafe Func<DaySceneDebugConsole.Node, bool> __9__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_2.NativeFieldInfoPtr___9__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneDebugConsole.Node, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_2.NativeFieldInfoPtr___9__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005603 RID: 22019
			private static readonly IntPtr NativeFieldInfoPtr_nodeData;

			// Token: 0x04005604 RID: 22020
			private static readonly IntPtr NativeFieldInfoPtr___9__12;

			// Token: 0x04005605 RID: 22021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005606 RID: 22022
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__10_Internal_Boolean_Queue_1_Node_0;

			// Token: 0x04005607 RID: 22023
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__12_Internal_Boolean_Node_0;

			// Token: 0x04005608 RID: 22024
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__11_Internal_Boolean_KeyValuePair_2_Int32_Node_0;
		}

		// Token: 0x020004FE RID: 1278
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass57_3")]
		public sealed class __c__DisplayClass57_3 : Il2CppSystem.Object
		{
			// Token: 0x0600834B RID: 33611 RVA: 0x0024EC74 File Offset: 0x0024CE74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_3()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass57_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, "child");
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr___9__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, "<>9__16");
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr___9__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, "<>9__17");
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, 100664597);
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__13_Internal_Boolean_KeyValuePair_2_Int32_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, 100664598);
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__16_Internal_Boolean_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, 100664599);
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__14_Internal_Boolean_KeyValuePair_2_Int32_Queue_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, 100664600);
				DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__17_Internal_Boolean_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr, 100664601);
			}

			// Token: 0x0600834C RID: 33612 RVA: 0x0024ED40 File Offset: 0x0024CF40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass57_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600834D RID: 33613 RVA: 0x0024ED7C File Offset: 0x0024CF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32445, XrefRangeEnd = 32456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeEventLists_b__13(KeyValuePair<int, Queue<DaySceneDebugConsole.Node>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__13_Internal_Boolean_KeyValuePair_2_Int32_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600834E RID: 33614 RVA: 0x0024EDD0 File Offset: 0x0024CFD0
			[CallerCount(0)]
			public unsafe bool _InitializeEventLists_b__16(DaySceneDebugConsole.Node y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__16_Internal_Boolean_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600834F RID: 33615 RVA: 0x0024EE20 File Offset: 0x0024D020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32456, XrefRangeEnd = 32467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeEventLists_b__14(KeyValuePair<int, Queue<DaySceneDebugConsole.Node>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__14_Internal_Boolean_KeyValuePair_2_Int32_Queue_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008350 RID: 33616 RVA: 0x0024EE74 File Offset: 0x0024D074
			[CallerCount(0)]
			public unsafe bool _InitializeEventLists_b__17(DaySceneDebugConsole.Node y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass57_3.NativeMethodInfoPtr__InitializeEventLists_b__17_Internal_Boolean_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008351 RID: 33617 RVA: 0x00046D0F File Offset: 0x00044F0F
			public __c__DisplayClass57_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C28 RID: 11304
			// (get) Token: 0x06008352 RID: 33618 RVA: 0x0024EEC4 File Offset: 0x0024D0C4
			// (set) Token: 0x06008353 RID: 33619 RVA: 0x00046D18 File Offset: 0x00044F18
			public unsafe DaySceneDebugConsole.Node child
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr_child);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr_child), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C29 RID: 11305
			// (get) Token: 0x06008354 RID: 33620 RVA: 0x0024EEF4 File Offset: 0x0024D0F4
			// (set) Token: 0x06008355 RID: 33621 RVA: 0x00046D37 File Offset: 0x00044F37
			public unsafe Func<DaySceneDebugConsole.Node, bool> __9__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr___9__16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneDebugConsole.Node, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr___9__16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C2A RID: 11306
			// (get) Token: 0x06008356 RID: 33622 RVA: 0x0024EF24 File Offset: 0x0024D124
			// (set) Token: 0x06008357 RID: 33623 RVA: 0x00046D56 File Offset: 0x00044F56
			public unsafe Func<DaySceneDebugConsole.Node, bool> __9__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr___9__17);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneDebugConsole.Node, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass57_3.NativeFieldInfoPtr___9__17), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005609 RID: 22025
			private static readonly IntPtr NativeFieldInfoPtr_child;

			// Token: 0x0400560A RID: 22026
			private static readonly IntPtr NativeFieldInfoPtr___9__16;

			// Token: 0x0400560B RID: 22027
			private static readonly IntPtr NativeFieldInfoPtr___9__17;

			// Token: 0x0400560C RID: 22028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400560D RID: 22029
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__13_Internal_Boolean_KeyValuePair_2_Int32_Queue_1_Node_0;

			// Token: 0x0400560E RID: 22030
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__16_Internal_Boolean_Node_0;

			// Token: 0x0400560F RID: 22031
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__14_Internal_Boolean_KeyValuePair_2_Int32_Queue_1_Node_0;

			// Token: 0x04005610 RID: 22032
			private static readonly IntPtr NativeMethodInfoPtr__InitializeEventLists_b__17_Internal_Boolean_Node_0;
		}

		// Token: 0x020004FF RID: 1279
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : ValueType
		{
			// Token: 0x06008358 RID: 33624 RVA: 0x00046D75 File Offset: 0x00044F75
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass59_0>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass59_0.NativeFieldInfoPtr_newStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass59_0>.NativeClassPtr, "newStyle");
			}

			// Token: 0x06008359 RID: 33625 RVA: 0x00046DA9 File Offset: 0x00044FA9
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600835A RID: 33626 RVA: 0x00046DB2 File Offset: 0x00044FB2
			public __c__DisplayClass59_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass59_0>.NativeClassPtr))
			{
			}

			// Token: 0x17002C2B RID: 11307
			// (get) Token: 0x0600835B RID: 33627 RVA: 0x0024EF54 File Offset: 0x0024D154
			// (set) Token: 0x0600835C RID: 33628 RVA: 0x00046DC4 File Offset: 0x00044FC4
			public unsafe GUIStyle newStyle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass59_0.NativeFieldInfoPtr_newStyle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass59_0.NativeFieldInfoPtr_newStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005611 RID: 22033
			private static readonly IntPtr NativeFieldInfoPtr_newStyle;
		}

		// Token: 0x02000500 RID: 1280
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600835D RID: 33629 RVA: 0x0024EF84 File Offset: 0x0024D184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass63_0.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr, "assetReference");
				DaySceneDebugConsole.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				DaySceneDebugConsole.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr, 100664602);
				DaySceneDebugConsole.__c__DisplayClass63_0.NativeMethodInfoPtr__InitializeDialogPackageNames_b__0_Internal_Void_AsyncOperationHandle_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr, 100664603);
			}

			// Token: 0x0600835E RID: 33630 RVA: 0x0024F000 File Offset: 0x0024D200
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600835F RID: 33631 RVA: 0x0024F03C File Offset: 0x0024D23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32467, XrefRangeEnd = 32480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeDialogPackageNames_b__0(AsyncOperationHandle<DialogPackage> handle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass63_0.NativeMethodInfoPtr__InitializeDialogPackageNames_b__0_Internal_Void_AsyncOperationHandle_1_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008360 RID: 33632 RVA: 0x00046DE3 File Offset: 0x00044FE3
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C2C RID: 11308
			// (get) Token: 0x06008361 RID: 33633 RVA: 0x0024F084 File Offset: 0x0024D284
			// (set) Token: 0x06008362 RID: 33634 RVA: 0x00046DEC File Offset: 0x00044FEC
			public unsafe AssetReference assetReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass63_0.NativeFieldInfoPtr_assetReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass63_0.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C2D RID: 11309
			// (get) Token: 0x06008363 RID: 33635 RVA: 0x0024F0B4 File Offset: 0x0024D2B4
			// (set) Token: 0x06008364 RID: 33636 RVA: 0x00046E0B File Offset: 0x0004500B
			public unsafe DaySceneDebugConsole __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005612 RID: 22034
			private static readonly IntPtr NativeFieldInfoPtr_assetReference;

			// Token: 0x04005613 RID: 22035
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005614 RID: 22036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005615 RID: 22037
			private static readonly IntPtr NativeMethodInfoPtr__InitializeDialogPackageNames_b__0_Internal_Void_AsyncOperationHandle_1_DialogPackage_0;
		}

		// Token: 0x02000501 RID: 1281
		[ObfuscatedName("PrototypingManagers.DaySceneDebugConsole+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x06008365 RID: 33637 RVA: 0x0024F0E4 File Offset: 0x0024D2E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugConsole>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr);
				DaySceneDebugConsole.__c__DisplayClass64_0.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr, "handle");
				DaySceneDebugConsole.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				DaySceneDebugConsole.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr, 100664604);
				DaySceneDebugConsole.__c__DisplayClass64_0.NativeMethodInfoPtr__ShowDialogListSet_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr, 100664605);
			}

			// Token: 0x06008366 RID: 33638 RVA: 0x0024F160 File Offset: 0x0024D360
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugConsole.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008367 RID: 33639 RVA: 0x0024F19C File Offset: 0x0024D39C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32480, XrefRangeEnd = 32486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowDialogListSet_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugConsole.__c__DisplayClass64_0.NativeMethodInfoPtr__ShowDialogListSet_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008368 RID: 33640 RVA: 0x00046E2A File Offset: 0x0004502A
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C2E RID: 11310
			// (get) Token: 0x06008369 RID: 33641 RVA: 0x0024F1D0 File Offset: 0x0024D3D0
			// (set) Token: 0x0600836A RID: 33642 RVA: 0x00046E33 File Offset: 0x00045033
			public AsyncOperationHandle<DialogPackage> handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass64_0.NativeFieldInfoPtr_handle);
					return new AsyncOperationHandle<DialogPackage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<DialogPackage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass64_0.NativeFieldInfoPtr_handle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<DialogPackage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002C2F RID: 11311
			// (get) Token: 0x0600836B RID: 33643 RVA: 0x0024F200 File Offset: 0x0024D400
			// (set) Token: 0x0600836C RID: 33644 RVA: 0x00046E61 File Offset: 0x00045061
			public unsafe DaySceneDebugConsole __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugConsole>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugConsole.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005616 RID: 22038
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04005617 RID: 22039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005618 RID: 22040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005619 RID: 22041
			private static readonly IntPtr NativeMethodInfoPtr__ShowDialogListSet_b__1_Internal_Void_0;
		}
	}
}
