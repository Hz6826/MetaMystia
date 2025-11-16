using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.ShapedLayoutGroup;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace MusicGame.UI
{
	// Token: 0x0200002B RID: 43
	public class MusicSelectorPannel : UISubPanel<MusicGameMapSelectPannel>
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x000ABA7C File Offset: 0x000A9C7C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSelectorPannel()
		{
			Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicSelectorPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr);
			MusicSelectorPannel.NativeFieldInfoPtr_LEVEL_TOTAL_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "LEVEL_TOTAL_NUM");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicItemPrefab");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorInfoPannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicSelectorInfoPannelPrefab");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorConfirmPannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicSelectorConfirmPannelPrefab");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicGameMainPannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicGameMainPannelPrefab");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicResultPannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicResultPannelPrefab");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicRankPannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicRankPannelPrefab");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicItemContainer");
			MusicSelectorPannel.NativeFieldInfoPtr_m_RecordCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_RecordCluster");
			MusicSelectorPannel.NativeFieldInfoPtr_m_DefaultPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_DefaultPic");
			MusicSelectorPannel.NativeFieldInfoPtr_m_AllpassEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_AllpassEventId");
			MusicSelectorPannel.NativeFieldInfoPtr_getBadgeLevelLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "getBadgeLevelLine");
			MusicSelectorPannel.NativeFieldInfoPtr_m_LoadedHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_LoadedHandle");
			MusicSelectorPannel.NativeFieldInfoPtr_m_PreviewMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_PreviewMusic");
			MusicSelectorPannel.NativeFieldInfoPtr_m_CurrentMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_CurrentMapLabel");
			MusicSelectorPannel.NativeFieldInfoPtr_m_CurrentMusicID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_CurrentMusicID");
			MusicSelectorPannel.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_List");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicLabel");
			MusicSelectorPannel.NativeFieldInfoPtr_m_ShouldInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_ShouldInterrupt");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicGameMainPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicGameMainPanel");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicResultPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicResultPannel");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorConfirmPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicSelectorConfirmPannel");
			MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorInfoPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "m_MusicSelectorInfoPannel");
			MusicSelectorPannel.NativeMethodInfoPtr_get_DefaultPic_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663873);
			MusicSelectorPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663874);
			MusicSelectorPannel.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663875);
			MusicSelectorPannel.NativeMethodInfoPtr_SetMusicItemsInfo_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663876);
			MusicSelectorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663877);
			MusicSelectorPannel.NativeMethodInfoPtr_OnWillClose_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663878);
			MusicSelectorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663879);
			MusicSelectorPannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663880);
			MusicSelectorPannel.NativeMethodInfoPtr_GetScoreLevel_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663881);
			MusicSelectorPannel.NativeMethodInfoPtr_CheckBadgeCondition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663882);
			MusicSelectorPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663883);
			MusicSelectorPannel.NativeMethodInfoPtr_OnMusicItemEnable_Private_Void_String_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663884);
			MusicSelectorPannel.NativeMethodInfoPtr_OnMusicItemSelected_Private_Void_String_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663885);
			MusicSelectorPannel.NativeMethodInfoPtr_OnConfirmPannelClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663886);
			MusicSelectorPannel.NativeMethodInfoPtr_OnMusicGameMainPannelClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663887);
			MusicSelectorPannel.NativeMethodInfoPtr_OnMusicResultPannelClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663888);
			MusicSelectorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663889);
			MusicSelectorPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663890);
			MusicSelectorPannel.NativeMethodInfoPtr__OnWillClose_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663891);
			MusicSelectorPannel.NativeMethodInfoPtr__OnConfirmPannelClose_b__39_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663892);
			MusicSelectorPannel.NativeMethodInfoPtr__OnConfirmPannelClose_b__39_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, 100663893);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000ABE1C File Offset: 0x000AA01C
		public unsafe Sprite DefaultPic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_get_DefaultPic_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x000ABE5C File Offset: 0x000AA05C
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000ABEA4 File Offset: 0x000AA0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22522, XrefRangeEnd = 22525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000ABED8 File Offset: 0x000AA0D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22527, RefRangeEnd = 22528, XrefRangeStart = 22525, XrefRangeEnd = 22527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicItemsInfo(string mapLabel, List<string> musicLabels)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicLabels);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_SetMusicItemsInfo_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000ABF2C File Offset: 0x000AA12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22528, XrefRangeEnd = 22556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000ABF68 File Offset: 0x000AA168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22556, XrefRangeEnd = 22568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillClose(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnWillClose_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000ABFB0 File Offset: 0x000AA1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22568, XrefRangeEnd = 22593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000ABFEC File Offset: 0x000AA1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22593, XrefRangeEnd = 22612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000AC020 File Offset: 0x000AA220
		[CallerCount(0)]
		public unsafe int GetScoreLevel(int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_GetScoreLevel_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000AC06C File Offset: 0x000AA26C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22666, RefRangeEnd = 22668, XrefRangeStart = 22612, XrefRangeEnd = 22666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckBadgeCondition(bool isEasyMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isEasyMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_CheckBadgeCondition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000AC0AC File Offset: 0x000AA2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22668, XrefRangeEnd = 22693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000AC0E8 File Offset: 0x000AA2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22693, XrefRangeEnd = 22711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicItemEnable(string data, UIElementCluster ui, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnMusicItemEnable_Private_Void_String_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000AC150 File Offset: 0x000AA350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22711, XrefRangeEnd = 22715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicItemSelected(string data, UIElementCluster ui, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnMusicItemSelected_Private_Void_String_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000AC1B8 File Offset: 0x000AA3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22726, RefRangeEnd = 22728, XrefRangeStart = 22715, XrefRangeEnd = 22726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConfirmPannelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnConfirmPannelClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000AC1EC File Offset: 0x000AA3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22728, XrefRangeEnd = 22742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicGameMainPannelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnMusicGameMainPannelClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000AC220 File Offset: 0x000AA420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22742, XrefRangeEnd = 22772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicResultPannelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr_OnMusicResultPannelClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000AC254 File Offset: 0x000AA454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22772, XrefRangeEnd = 22797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000AC290 File Offset: 0x000AA490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22797, XrefRangeEnd = 22815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSelectorPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000AC2CC File Offset: 0x000AA4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22815, XrefRangeEnd = 22823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnWillClose_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr__OnWillClose_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000AC300 File Offset: 0x000AA500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22823, XrefRangeEnd = 22834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnConfirmPannelClose_b__39_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr__OnConfirmPannelClose_b__39_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000AC334 File Offset: 0x000AA534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22834, XrefRangeEnd = 22860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnConfirmPannelClose_b__39_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.NativeMethodInfoPtr__OnConfirmPannelClose_b__39_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000443A File Offset: 0x0000263A
		public MusicSelectorPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000AC368 File Offset: 0x000AA568
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00004443 File Offset: 0x00002643
		public unsafe static int LEVEL_TOTAL_NUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MusicSelectorPannel.NativeFieldInfoPtr_LEVEL_TOTAL_NUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSelectorPannel.NativeFieldInfoPtr_LEVEL_TOTAL_NUM, (void*)(&value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000AC384 File Offset: 0x000AA584
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00004451 File Offset: 0x00002651
		public unsafe GameObject m_MusicItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00004470 File Offset: 0x00002670
		public unsafe MusicSelectorInfoPannel m_MusicSelectorInfoPannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorInfoPannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorInfoPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorInfoPannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000AC3E4 File Offset: 0x000AA5E4
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000448F File Offset: 0x0000268F
		public unsafe MusicSelectorConfirmPannel m_MusicSelectorConfirmPannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorConfirmPannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorConfirmPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorConfirmPannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x000AC414 File Offset: 0x000AA614
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x000044AE File Offset: 0x000026AE
		public unsafe MusicGameMainPannel m_MusicGameMainPannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicGameMainPannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicGameMainPannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000AC444 File Offset: 0x000AA644
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x000044CD File Offset: 0x000026CD
		public unsafe MusicResultPannel m_MusicResultPannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicResultPannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicResultPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicResultPannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x000AC474 File Offset: 0x000AA674
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x000044EC File Offset: 0x000026EC
		public unsafe MusicRankPannel m_MusicRankPannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicRankPannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicRankPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicRankPannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x000AC4A4 File Offset: 0x000AA6A4
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000450B File Offset: 0x0000270B
		public unsafe ShapedLayoutGroup m_MusicItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShapedLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x000AC4D4 File Offset: 0x000AA6D4
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0000452A File Offset: 0x0000272A
		public unsafe UIElementCluster m_RecordCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_RecordCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_RecordCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x000AC504 File Offset: 0x000AA704
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00004549 File Offset: 0x00002749
		public unsafe Sprite m_DefaultPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_DefaultPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_DefaultPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000AC534 File Offset: 0x000AA734
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00004568 File Offset: 0x00002768
		public unsafe string m_AllpassEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_AllpassEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_AllpassEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000AC55C File Offset: 0x000AA75C
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00004587 File Offset: 0x00002787
		public unsafe int getBadgeLevelLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_getBadgeLevelLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_getBadgeLevelLine)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000AC584 File Offset: 0x000AA784
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000045A2 File Offset: 0x000027A2
		public unsafe HashSet<AsyncOperationHandle<LoopedBGMPackage>> m_LoadedHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_LoadedHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AsyncOperationHandle<LoopedBGMPackage>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_LoadedHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000AC5B4 File Offset: 0x000AA7B4
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x000045C1 File Offset: 0x000027C1
		public unsafe Dictionary<string, LoopedBGMPackage> m_PreviewMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_PreviewMusic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LoopedBGMPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_PreviewMusic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000AC5E4 File Offset: 0x000AA7E4
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000045E0 File Offset: 0x000027E0
		public unsafe string m_CurrentMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_CurrentMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_CurrentMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000AC60C File Offset: 0x000AA80C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000045FF File Offset: 0x000027FF
		public unsafe string m_CurrentMusicID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_CurrentMusicID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_CurrentMusicID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000AC634 File Offset: 0x000AA834
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000461E File Offset: 0x0000281E
		public unsafe StaticVirtualScrollListUILogicalGroupT<string, UIElementCluster, UIButtonSimple> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<string, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000AC664 File Offset: 0x000AA864
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0000463D File Offset: 0x0000283D
		public unsafe List<string> m_MusicLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x000AC694 File Offset: 0x000AA894
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0000465C File Offset: 0x0000285C
		public unsafe bool m_ShouldInterrupt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_ShouldInterrupt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_ShouldInterrupt)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x000AC6BC File Offset: 0x000AA8BC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00004677 File Offset: 0x00002877
		public unsafe MusicGameMainPannel m_MusicGameMainPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicGameMainPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicGameMainPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x000AC6EC File Offset: 0x000AA8EC
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00004696 File Offset: 0x00002896
		public unsafe MusicResultPannel m_MusicResultPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicResultPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicResultPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicResultPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x000AC71C File Offset: 0x000AA91C
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x000046B5 File Offset: 0x000028B5
		public unsafe MusicSelectorConfirmPannel m_MusicSelectorConfirmPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorConfirmPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorConfirmPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorConfirmPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x000AC74C File Offset: 0x000AA94C
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x000046D4 File Offset: 0x000028D4
		public unsafe MusicSelectorInfoPannel m_MusicSelectorInfoPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorInfoPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorInfoPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.NativeFieldInfoPtr_m_MusicSelectorInfoPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL_TOTAL_NUM;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicItemPrefab;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicSelectorInfoPannelPrefab;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicSelectorConfirmPannelPrefab;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicGameMainPannelPrefab;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicResultPannelPrefab;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicRankPannelPrefab;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicItemContainer;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_m_RecordCluster;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultPic;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_m_AllpassEventId;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_getBadgeLevelLine;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedHandle;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewMusic;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMapLabel;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMusicID;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicLabel;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldInterrupt;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicGameMainPanel;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicResultPannel;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicSelectorConfirmPannel;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicSelectorInfoPannel;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPic_Public_get_Sprite_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicItemsInfo_Public_Void_String_List_1_String_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_OnWillClose_Private_Void_CallbackContext_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPannel_Private_Void_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_GetScoreLevel_Private_Int32_Int32_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_CheckBadgeCondition_Public_Void_Boolean_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicItemEnable_Private_Void_String_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicItemSelected_Private_Void_String_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_OnConfirmPannelClose_Private_Void_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicGameMainPannelClose_Private_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicResultPannelClose_Private_Void_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__OnWillClose_b__31_0_Private_Void_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr__OnConfirmPannelClose_b__39_0_Private_Void_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr__OnConfirmPannelClose_b__39_1_Private_Void_0;

		// Token: 0x0200049E RID: 1182
		public enum PannelCloseMode
		{
			// Token: 0x04005313 RID: 21267
			Default,
			// Token: 0x04005314 RID: 21268
			Restart
		}

		// Token: 0x0200049F RID: 1183
		[ObfuscatedName("MusicGame.UI.MusicSelectorPannel+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x06007E55 RID: 32341 RVA: 0x00240544 File Offset: 0x0023E744
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr);
				MusicSelectorPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_loadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr, "loadCount");
				MusicSelectorPannel.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				MusicSelectorPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr, 100663894);
				MusicSelectorPannel.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr, 100663895);
				MusicSelectorPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr, 100663896);
			}

			// Token: 0x06007E56 RID: 32342 RVA: 0x002405D4 File Offset: 0x0023E7D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E57 RID: 32343 RVA: 0x00240610 File Offset: 0x0023E810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22430, XrefRangeEnd = 22435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007E58 RID: 32344 RVA: 0x00240650 File Offset: 0x0023E850
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E59 RID: 32345 RVA: 0x00043FC9 File Offset: 0x000421C9
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AAF RID: 10927
			// (get) Token: 0x06007E5A RID: 32346 RVA: 0x0024068C File Offset: 0x0023E88C
			// (set) Token: 0x06007E5B RID: 32347 RVA: 0x00043FD2 File Offset: 0x000421D2
			public unsafe int loadCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_loadCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_loadCount)) = value;
				}
			}

			// Token: 0x17002AB0 RID: 10928
			// (get) Token: 0x06007E5C RID: 32348 RVA: 0x002406B4 File Offset: 0x0023E8B4
			// (set) Token: 0x06007E5D RID: 32349 RVA: 0x00043FED File Offset: 0x000421ED
			public unsafe MusicSelectorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005315 RID: 21269
			private static readonly IntPtr NativeFieldInfoPtr_loadCount;

			// Token: 0x04005316 RID: 21270
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005317 RID: 21271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005318 RID: 21272
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04005319 RID: 21273
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_0;

			// Token: 0x02000FA8 RID: 4008
			[ObfuscatedName("MusicGame.UI.MusicSelectorPannel+<>c__DisplayClass32_0+<<OnPanelOpen>g__AfterPreviewMusicLoad|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060114A9 RID: 70825 RVA: 0x003FAB90 File Offset: 0x003F8D90
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0>.NativeClassPtr, "<<OnPanelOpen>g__AfterPreviewMusicLoad|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663897);
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663898);
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663899);
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663900);
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663901);
					MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663902);
				}

				// Token: 0x060114AA RID: 70826 RVA: 0x003FAC70 File Offset: 0x003F8E70
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114AB RID: 70827 RVA: 0x003FACB8 File Offset: 0x003F8EB8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114AC RID: 70828 RVA: 0x003FACEC File Offset: 0x003F8EEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22406, XrefRangeEnd = 22424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170059E4 RID: 23012
				// (get) Token: 0x060114AD RID: 70829 RVA: 0x003FAD28 File Offset: 0x003F8F28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060114AE RID: 70830 RVA: 0x003FAD68 File Offset: 0x003F8F68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22424, XrefRangeEnd = 22430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059E5 RID: 23013
				// (get) Token: 0x060114AF RID: 70831 RVA: 0x003FAD9C File Offset: 0x003F8F9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060114B0 RID: 70832 RVA: 0x00096702 File Offset: 0x00094902
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059E1 RID: 23009
				// (get) Token: 0x060114B1 RID: 70833 RVA: 0x003FADDC File Offset: 0x003F8FDC
				// (set) Token: 0x060114B2 RID: 70834 RVA: 0x0009670B File Offset: 0x0009490B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170059E2 RID: 23010
				// (get) Token: 0x060114B3 RID: 70835 RVA: 0x003FAE04 File Offset: 0x003F9004
				// (set) Token: 0x060114B4 RID: 70836 RVA: 0x00096726 File Offset: 0x00094926
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059E3 RID: 23011
				// (get) Token: 0x060114B5 RID: 70837 RVA: 0x003FAE34 File Offset: 0x003F9034
				// (set) Token: 0x060114B6 RID: 70838 RVA: 0x00096745 File Offset: 0x00094945
				public unsafe MusicSelectorPannel.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AEC8 RID: 44744
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEC9 RID: 44745
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AECA RID: 44746
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AECB RID: 44747
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AECC RID: 44748
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AECD RID: 44749
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AECE RID: 44750
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AECF RID: 44751
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AED0 RID: 44752
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020004A0 RID: 1184
		[ObfuscatedName("MusicGame.UI.MusicSelectorPannel+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x06007E5E RID: 32350 RVA: 0x002406E4 File Offset: 0x0023E8E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr);
				MusicSelectorPannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				MusicSelectorPannel.__c__DisplayClass35_0.NativeFieldInfoPtr_isEasyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr, "isEasyMode");
				MusicSelectorPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr, 100663903);
				MusicSelectorPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__CheckBadgeCondition_b__0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr, 100663904);
				MusicSelectorPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__CheckBadgeCondition_b__2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr, 100663905);
			}

			// Token: 0x06007E5F RID: 32351 RVA: 0x00240774 File Offset: 0x0023E974
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E60 RID: 32352 RVA: 0x002407B0 File Offset: 0x0023E9B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22435, XrefRangeEnd = 22439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckBadgeCondition_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__CheckBadgeCondition_b__0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E61 RID: 32353 RVA: 0x00240800 File Offset: 0x0023EA00
			[CallerCount(0)]
			public unsafe bool _CheckBadgeCondition_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__CheckBadgeCondition_b__2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E62 RID: 32354 RVA: 0x0004400C File Offset: 0x0004220C
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AB1 RID: 10929
			// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0024084C File Offset: 0x0023EA4C
			// (set) Token: 0x06007E64 RID: 32356 RVA: 0x00044015 File Offset: 0x00042215
			public unsafe MusicSelectorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB2 RID: 10930
			// (get) Token: 0x06007E65 RID: 32357 RVA: 0x0024087C File Offset: 0x0023EA7C
			// (set) Token: 0x06007E66 RID: 32358 RVA: 0x00044034 File Offset: 0x00042234
			public unsafe bool isEasyMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass35_0.NativeFieldInfoPtr_isEasyMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass35_0.NativeFieldInfoPtr_isEasyMode)) = value;
				}
			}

			// Token: 0x0400531A RID: 21274
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400531B RID: 21275
			private static readonly IntPtr NativeFieldInfoPtr_isEasyMode;

			// Token: 0x0400531C RID: 21276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400531D RID: 21277
			private static readonly IntPtr NativeMethodInfoPtr__CheckBadgeCondition_b__0_Internal_Int32_String_0;

			// Token: 0x0400531E RID: 21278
			private static readonly IntPtr NativeMethodInfoPtr__CheckBadgeCondition_b__2_Internal_Boolean_Int32_0;
		}

		// Token: 0x020004A1 RID: 1185
		[ObfuscatedName("MusicGame.UI.MusicSelectorPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007E67 RID: 32359 RVA: 0x002408A4 File Offset: 0x0023EAA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr);
				MusicSelectorPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr, "<>9");
				MusicSelectorPannel.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr, "<>9__35_1");
				MusicSelectorPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr, 100663907);
				MusicSelectorPannel.__c.NativeMethodInfoPtr__CheckBadgeCondition_b__35_1_Internal_Int32_KeyValuePair_2_Badge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr, 100663908);
			}

			// Token: 0x06007E68 RID: 32360 RVA: 0x00240920 File Offset: 0x0023EB20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E69 RID: 32361 RVA: 0x0024095C File Offset: 0x0023EB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckBadgeCondition_b__35_1(KeyValuePair<Badge, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c.NativeMethodInfoPtr__CheckBadgeCondition_b__35_1_Internal_Int32_KeyValuePair_2_Badge_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E6A RID: 32362 RVA: 0x0004404F File Offset: 0x0004224F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AB3 RID: 10931
			// (get) Token: 0x06007E6B RID: 32363 RVA: 0x002409B0 File Offset: 0x0023EBB0
			// (set) Token: 0x06007E6C RID: 32364 RVA: 0x00044058 File Offset: 0x00042258
			public unsafe static MusicSelectorPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicSelectorPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicSelectorPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB4 RID: 10932
			// (get) Token: 0x06007E6D RID: 32365 RVA: 0x002409D8 File Offset: 0x0023EBD8
			// (set) Token: 0x06007E6E RID: 32366 RVA: 0x0004406A File Offset: 0x0004226A
			public unsafe static Func<KeyValuePair<Badge, int>, int> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicSelectorPannel.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Badge, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicSelectorPannel.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400531F RID: 21279
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005320 RID: 21280
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x04005321 RID: 21281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005322 RID: 21282
			private static readonly IntPtr NativeMethodInfoPtr__CheckBadgeCondition_b__35_1_Internal_Int32_KeyValuePair_2_Badge_Int32_0;
		}

		// Token: 0x020004A2 RID: 1186
		[ObfuscatedName("MusicGame.UI.MusicSelectorPannel+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x06007E6F RID: 32367 RVA: 0x00240A00 File Offset: 0x0023EC00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr);
				MusicSelectorPannel.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				MusicSelectorPannel.__c__DisplayClass37_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr, "data");
				MusicSelectorPannel.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr, 100663909);
				MusicSelectorPannel.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_Void_String_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr, 100663910);
				MusicSelectorPannel.__c__DisplayClass37_0.NativeMethodInfoPtr__OnMusicItemEnable_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr, 100663911);
			}

			// Token: 0x06007E70 RID: 32368 RVA: 0x00240A90 File Offset: 0x0023EC90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E71 RID: 32369 RVA: 0x00240ACC File Offset: 0x0023ECCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22440, XrefRangeEnd = 22458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_String_Boolean_PDM_0(string musicLabel, bool isEasyMode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(musicLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEasyMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_Void_String_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E72 RID: 32370 RVA: 0x00240B1C File Offset: 0x0023ED1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22458, XrefRangeEnd = 22502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMusicItemEnable_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass37_0.NativeMethodInfoPtr__OnMusicItemEnable_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E73 RID: 32371 RVA: 0x0004407C File Offset: 0x0004227C
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AB5 RID: 10933
			// (get) Token: 0x06007E74 RID: 32372 RVA: 0x00240B50 File Offset: 0x0023ED50
			// (set) Token: 0x06007E75 RID: 32373 RVA: 0x00044085 File Offset: 0x00042285
			public unsafe MusicSelectorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB6 RID: 10934
			// (get) Token: 0x06007E76 RID: 32374 RVA: 0x00240B80 File Offset: 0x0023ED80
			// (set) Token: 0x06007E77 RID: 32375 RVA: 0x000440A4 File Offset: 0x000422A4
			public unsafe string data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_0.NativeFieldInfoPtr_data);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_0.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04005323 RID: 21283
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005324 RID: 21284
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005325 RID: 21285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005326 RID: 21286
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_String_Boolean_PDM_0;

			// Token: 0x04005327 RID: 21287
			private static readonly IntPtr NativeMethodInfoPtr__OnMusicItemEnable_b__1_Internal_Void_0;
		}

		// Token: 0x020004A3 RID: 1187
		[ObfuscatedName("MusicGame.UI.MusicSelectorPannel+<>c__DisplayClass37_1")]
		public sealed class __c__DisplayClass37_1 : Il2CppSystem.Object
		{
			// Token: 0x06007E78 RID: 32376 RVA: 0x00240BA8 File Offset: 0x0023EDA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_1()
			{
				Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorPannel>.NativeClassPtr, "<>c__DisplayClass37_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr);
				MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_musicLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr, "musicLabel");
				MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_isEasyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr, "isEasyMode");
				MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr, "CS$<>8__locals1");
				MusicSelectorPannel.__c__DisplayClass37_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr, 100663912);
				MusicSelectorPannel.__c__DisplayClass37_1.NativeMethodInfoPtr__OnMusicItemEnable_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr, 100663913);
			}

			// Token: 0x06007E79 RID: 32377 RVA: 0x00240C38 File Offset: 0x0023EE38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorPannel.__c__DisplayClass37_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass37_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E7A RID: 32378 RVA: 0x00240C74 File Offset: 0x0023EE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22502, XrefRangeEnd = 22522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMusicItemEnable_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorPannel.__c__DisplayClass37_1.NativeMethodInfoPtr__OnMusicItemEnable_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E7B RID: 32379 RVA: 0x000440C3 File Offset: 0x000422C3
			public __c__DisplayClass37_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AB7 RID: 10935
			// (get) Token: 0x06007E7C RID: 32380 RVA: 0x00240CA8 File Offset: 0x0023EEA8
			// (set) Token: 0x06007E7D RID: 32381 RVA: 0x000440CC File Offset: 0x000422CC
			public unsafe string musicLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_musicLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_musicLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002AB8 RID: 10936
			// (get) Token: 0x06007E7E RID: 32382 RVA: 0x00240CD0 File Offset: 0x0023EED0
			// (set) Token: 0x06007E7F RID: 32383 RVA: 0x000440EB File Offset: 0x000422EB
			public unsafe bool isEasyMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_isEasyMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_isEasyMode)) = value;
				}
			}

			// Token: 0x17002AB9 RID: 10937
			// (get) Token: 0x06007E80 RID: 32384 RVA: 0x00240CF8 File Offset: 0x0023EEF8
			// (set) Token: 0x06007E81 RID: 32385 RVA: 0x00044106 File Offset: 0x00042306
			public unsafe MusicSelectorPannel.__c__DisplayClass37_0 field_Public___c__DisplayClass37_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel.__c__DisplayClass37_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorPannel.__c__DisplayClass37_1.NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005328 RID: 21288
			private static readonly IntPtr NativeFieldInfoPtr_musicLabel;

			// Token: 0x04005329 RID: 21289
			private static readonly IntPtr NativeFieldInfoPtr_isEasyMode;

			// Token: 0x0400532A RID: 21290
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0;

			// Token: 0x0400532B RID: 21291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400532C RID: 21292
			private static readonly IntPtr NativeMethodInfoPtr__OnMusicItemEnable_b__2_Internal_Void_0;
		}
	}
}
