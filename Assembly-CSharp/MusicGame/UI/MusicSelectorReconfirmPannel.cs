using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x0200002E RID: 46
	public class MusicSelectorReconfirmPannel : UIPanel
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x000AC8E0 File Offset: 0x000AAAE0
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSelectorReconfirmPannel()
		{
			Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicSelectorReconfirmPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr);
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicalNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_MusicalNoteSpeed");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_MusicalNoteSpeedPercentageText");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_MusicVolume");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicVolumePercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_MusicVolumePercentageText");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_ButtonVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_ButtonVolume");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_ButtonVolumePercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_ButtonVolumePercentageText");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_AutoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_AutoMode");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_CleanMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_CleanMode");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_YesButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_YesButton");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_NoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_NoButton");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_SettingButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_SettingButton");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicGameConfigPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_MusicGameConfigPannel");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_HideInBossMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "HideInBossMode");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_IsAutoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "m_IsAutoMode");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr__ExitContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "<ExitContext>k__BackingField");
			MusicSelectorReconfirmPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, "<MusicalNoteSpeed>k__BackingField");
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_OpenContext_Public_get_MusicSelectorReconfirmPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663915);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicSelectorReconfirmPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663916);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_ExitContext_Public_get_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663917);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_set_ExitContext_Private_set_Void_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663918);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663919);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663920);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_IsEasy_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663921);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663922);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663923);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnSettingButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663924);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_UpdateValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663925);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663926);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_GetMusicSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663927);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663928);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_GetNoteSpeedProgress_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663929);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_GetNoteSpeedDisplay_Public_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663930);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicVolumeChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663931);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnButtonVolumeChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663932);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicalNoteSpeedChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663933);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicalCleanModeChanged_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663934);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicalNoteSpeedChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663935);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicVolumeChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663936);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnButtonVolumeChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663937);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663938);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663939);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663940);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663941);
			MusicSelectorReconfirmPannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr, 100663942);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000ACC94 File Offset: 0x000AAE94
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000ACCCC File Offset: 0x000AAECC
		public unsafe MusicSelectorReconfirmPannelOpenContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_OpenContext_Public_get_MusicSelectorReconfirmPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MusicSelectorReconfirmPannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22864, XrefRangeEnd = 22865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicSelectorReconfirmPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x000ACD14 File Offset: 0x000AAF14
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000ACD50 File Offset: 0x000AAF50
		public unsafe PlayMode ExitContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_ExitContext_Public_get_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_set_ExitContext_Private_set_Void_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x000ACD90 File Offset: 0x000AAF90
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x000ACDCC File Offset: 0x000AAFCC
		public unsafe float MusicalNoteSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000ACE0C File Offset: 0x000AB00C
		public unsafe bool IsEasy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_IsEasy_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000ACE48 File Offset: 0x000AB048
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorReconfirmPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000ACE90 File Offset: 0x000AB090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22865, XrefRangeEnd = 22939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000ACECC File Offset: 0x000AB0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22939, XrefRangeEnd = 22954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSettingButtonClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnSettingButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000ACF00 File Offset: 0x000AB100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22954, XrefRangeEnd = 22961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_UpdateValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000ACF34 File Offset: 0x000AB134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22961, XrefRangeEnd = 22976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000ACF70 File Offset: 0x000AB170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22976, XrefRangeEnd = 22977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMusicSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_GetMusicSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000ACFAC File Offset: 0x000AB1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22977, XrefRangeEnd = 22980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000ACFE8 File Offset: 0x000AB1E8
		[CallerCount(0)]
		public unsafe float GetNoteSpeedProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_GetNoteSpeedProgress_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000AD034 File Offset: 0x000AB234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22989, RefRangeEnd = 22991, XrefRangeStart = 22980, XrefRangeEnd = 22989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNoteSpeedDisplay(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_GetNoteSpeedDisplay_Public_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000AD078 File Offset: 0x000AB278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22991, XrefRangeEnd = 22992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicVolumeChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicVolumeChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000AD0B8 File Offset: 0x000AB2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22992, XrefRangeEnd = 22993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonVolumeChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnButtonVolumeChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000AD0F8 File Offset: 0x000AB2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22993, XrefRangeEnd = 22994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicalNoteSpeedChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicalNoteSpeedChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000AD138 File Offset: 0x000AB338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22994, XrefRangeEnd = 22995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicalCleanModeChanged(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicalCleanModeChanged_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000AD178 File Offset: 0x000AB378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22995, XrefRangeEnd = 22997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicalNoteSpeedChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicalNoteSpeedChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000AD1B8 File Offset: 0x000AB3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22997, XrefRangeEnd = 23004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicVolumeChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnMusicVolumeChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000AD1F8 File Offset: 0x000AB3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23004, XrefRangeEnd = 23011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonVolumeChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_OnButtonVolumeChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000AD238 File Offset: 0x000AB438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23011, XrefRangeEnd = 23025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorReconfirmPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000AD274 File Offset: 0x000AB474
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSelectorReconfirmPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorReconfirmPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000AD2B0 File Offset: 0x000AB4B0
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__30_0(bool onToggleUpdate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onToggleUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000AD2F0 File Offset: 0x000AB4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23025, XrefRangeEnd = 23028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000AD324 File Offset: 0x000AB524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23028, XrefRangeEnd = 23029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__30_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00004763 File Offset: 0x00002963
		public MusicSelectorReconfirmPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000AD358 File Offset: 0x000AB558
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0000476C File Offset: 0x0000296C
		public unsafe UIScrollBar m_MusicalNoteSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicalNoteSpeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicalNoteSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000AD388 File Offset: 0x000AB588
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0000478B File Offset: 0x0000298B
		public unsafe TMP_Text m_MusicalNoteSpeedPercentageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000AD3B8 File Offset: 0x000AB5B8
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x000047AA File Offset: 0x000029AA
		public unsafe UIScrollBar m_MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000AD3E8 File Offset: 0x000AB5E8
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x000047C9 File Offset: 0x000029C9
		public unsafe TMP_Text m_MusicVolumePercentageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicVolumePercentageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicVolumePercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000AD418 File Offset: 0x000AB618
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x000047E8 File Offset: 0x000029E8
		public unsafe UIScrollBar m_ButtonVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_ButtonVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_ButtonVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000AD448 File Offset: 0x000AB648
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00004807 File Offset: 0x00002A07
		public unsafe TMP_Text m_ButtonVolumePercentageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_ButtonVolumePercentageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_ButtonVolumePercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x000AD478 File Offset: 0x000AB678
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00004826 File Offset: 0x00002A26
		public unsafe UIButtonToggle m_AutoMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_AutoMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_AutoMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00004845 File Offset: 0x00002A45
		public unsafe UIButtonToggle m_CleanMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_CleanMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_CleanMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x000AD4D8 File Offset: 0x000AB6D8
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00004864 File Offset: 0x00002A64
		public unsafe UIButtonSimple m_YesButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_YesButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_YesButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000AD508 File Offset: 0x000AB708
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00004883 File Offset: 0x00002A83
		public unsafe UIButtonSimple m_NoButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_NoButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_NoButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x000AD538 File Offset: 0x000AB738
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x000048A2 File Offset: 0x00002AA2
		public unsafe UIButtonSimple m_SettingButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_SettingButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_SettingButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000AD568 File Offset: 0x000AB768
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000048C1 File Offset: 0x00002AC1
		public unsafe MusicGameConfigPannel m_MusicGameConfigPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicGameConfigPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameConfigPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_MusicGameConfigPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x000AD598 File Offset: 0x000AB798
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x000048E0 File Offset: 0x00002AE0
		public unsafe Il2CppReferenceArray<GameObject> HideInBossMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_HideInBossMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_HideInBossMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000AD5C8 File Offset: 0x000AB7C8
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x000048FF File Offset: 0x00002AFF
		public unsafe bool m_IsAutoMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_IsAutoMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr_m_IsAutoMode)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000AD5F0 File Offset: 0x000AB7F0
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x0000491A File Offset: 0x00002B1A
		public MusicSelectorReconfirmPannelOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new MusicSelectorReconfirmPannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000AD620 File Offset: 0x000AB820
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00004948 File Offset: 0x00002B48
		public unsafe PlayMode _ExitContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr__ExitContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr__ExitContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000AD648 File Offset: 0x000AB848
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00004963 File Offset: 0x00002B63
		public unsafe float _MusicalNoteSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicalNoteSpeed;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicVolume;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicVolumePercentageText;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_m_ButtonVolume;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_m_ButtonVolumePercentageText;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoMode;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_m_CleanMode;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_m_YesButton;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_m_NoButton;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_m_SettingButton;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicGameConfigPannel;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_HideInBossMode;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAutoMode;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr__ExitContext_k__BackingField;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Public_get_MusicSelectorReconfirmPannelOpenContext_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicSelectorReconfirmPannelOpenContext_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_ExitContext_Public_get_PlayMode_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_set_ExitContext_Private_set_Void_PlayMode_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEasy_Private_get_Boolean_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_OnSettingButtonClick_Private_Void_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Private_Void_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_GetMusicSpeed_Public_Single_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteSpeedProgress_Public_Single_Single_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteSpeedDisplay_Public_String_Single_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicVolumeChanged_Public_Void_Single_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonVolumeChanged_Public_Void_Single_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicalNoteSpeedChanged_Public_Void_Single_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicalCleanModeChanged_Public_Void_Boolean_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicalNoteSpeedChangedVisual_Private_Void_Single_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicVolumeChangedVisual_Private_Void_Single_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonVolumeChangedVisual_Private_Void_Single_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__30_0_Private_Void_Boolean_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__30_2_Private_Void_0;
	}
}
