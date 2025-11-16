using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData;
using GameData.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003BD RID: 957
	public class EscConfigPannel : UISubPanel<EscMainPannel>
	{
		// Token: 0x060071E4 RID: 29156 RVA: 0x0021A258 File Offset: 0x00218458
		// Note: this type is marked as 'beforefieldinit'.
		static EscConfigPannel()
		{
			Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscConfigPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr);
			EscConfigPannel.NativeFieldInfoPtr_m_CurrentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "m_CurrentSettings");
			EscConfigPannel.NativeFieldInfoPtr_CalibrationAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "CalibrationAmountText");
			EscConfigPannel.NativeFieldInfoPtr_MusicVolumeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "MusicVolumeText");
			EscConfigPannel.NativeFieldInfoPtr_SFXVolumeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "SFXVolumeText");
			EscConfigPannel.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "MusicVolume");
			EscConfigPannel.NativeFieldInfoPtr_SfxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "SfxVolume");
			EscConfigPannel.NativeFieldInfoPtr_EnableSpellDeclareCutin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "EnableSpellDeclareCutin");
			EscConfigPannel.NativeFieldInfoPtr_FullScreenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "FullScreenMode");
			EscConfigPannel.NativeFieldInfoPtr_RenderResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "RenderResolution");
			EscConfigPannel.NativeFieldInfoPtr_Vsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "Vsync");
			EscConfigPannel.NativeFieldInfoPtr_TargetRefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "TargetRefreshRate");
			EscConfigPannel.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "Language");
			EscConfigPannel.NativeFieldInfoPtr_QTECalibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "QTECalibration");
			EscConfigPannel.NativeFieldInfoPtr_RunInBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "RunInBackground");
			EscConfigPannel.NativeFieldInfoPtr_UseLegacyQTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "UseLegacyQTEPannel");
			EscConfigPannel.NativeFieldInfoPtr_UseLegacyThrowDeliver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "UseLegacyThrowDeliver");
			EscConfigPannel.NativeFieldInfoPtr_EnableLargerFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "EnableLargerFontSize");
			EscConfigPannel.NativeFieldInfoPtr_TargetRefreshRateGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "TargetRefreshRateGroup");
			EscConfigPannel.NativeFieldInfoPtr_LanguageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "LanguageGroup");
			EscConfigPannel.NativeFieldInfoPtr_OnMusicVolumeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "OnMusicVolumeUpdate");
			EscConfigPannel.NativeFieldInfoPtr_OnOverrideMusicVolumeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "OnOverrideMusicVolumeUpdate");
			EscConfigPannel.NativeFieldInfoPtr_OnSFXVolumeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "OnSFXVolumeUpdate");
			EscConfigPannel.NativeMethodInfoPtr_get_CurrentSettings_Private_Static_get_PlayerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686775);
			EscConfigPannel.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_LoadLanguageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686776);
			EscConfigPannel.NativeMethodInfoPtr_get_EnableSpellDecalareCutin_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686777);
			EscConfigPannel.NativeMethodInfoPtr_get_EnableLegacyQTEPannel_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686778);
			EscConfigPannel.NativeMethodInfoPtr_get_EnableLegacyThrowDeliver_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686779);
			EscConfigPannel.NativeMethodInfoPtr_get_CleanMusicGameMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686780);
			EscConfigPannel.NativeMethodInfoPtr_get_SfxVol_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686781);
			EscConfigPannel.NativeMethodInfoPtr_get_MusicVol_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686782);
			EscConfigPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686783);
			EscConfigPannel.NativeMethodInfoPtr_add_OnMusicVolumeUpdate_Public_Static_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686784);
			EscConfigPannel.NativeMethodInfoPtr_remove_OnMusicVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686785);
			EscConfigPannel.NativeMethodInfoPtr_add_OnOverrideMusicVolumeUpdate_Public_Static_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686786);
			EscConfigPannel.NativeMethodInfoPtr_remove_OnOverrideMusicVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686787);
			EscConfigPannel.NativeMethodInfoPtr_add_OnSFXVolumeUpdate_Public_Static_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686788);
			EscConfigPannel.NativeMethodInfoPtr_remove_OnSFXVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686789);
			EscConfigPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686790);
			EscConfigPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686791);
			EscConfigPannel.NativeMethodInfoPtr_InitButton_Private_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686792);
			EscConfigPannel.NativeMethodInfoPtr_RunVolumeUpdateCallback_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686793);
			EscConfigPannel.NativeMethodInfoPtr_SetSFXVolume_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686794);
			EscConfigPannel.NativeMethodInfoPtr_SetMusicVolume_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686795);
			EscConfigPannel.NativeMethodInfoPtr_SetMusicGameCleanMode_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686796);
			EscConfigPannel.NativeMethodInfoPtr_ChangeMusicVolume_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686797);
			EscConfigPannel.NativeMethodInfoPtr_ChangeSFXVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686798);
			EscConfigPannel.NativeMethodInfoPtr_ChangeMusicVolumeVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686799);
			EscConfigPannel.NativeMethodInfoPtr_ChangeSFXVolumeVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686800);
			EscConfigPannel.NativeMethodInfoPtr_Lerp_Private_Static_Int64_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686801);
			EscConfigPannel.NativeMethodInfoPtr_ChangeCalibration_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686802);
			EscConfigPannel.NativeMethodInfoPtr_ChangeCalibrationVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686803);
			EscConfigPannel.NativeMethodInfoPtr_GetCalibrationVisual_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686804);
			EscConfigPannel.NativeMethodInfoPtr_GetCalibrationProgress_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686805);
			EscConfigPannel.NativeMethodInfoPtr_ChangeFullScreenMode_Private_Static_Void_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686806);
			EscConfigPannel.NativeMethodInfoPtr_ChangeDisplayResolution_Private_Void_SupportedResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686807);
			EscConfigPannel.NativeMethodInfoPtr_UpdateDisplaySettings_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686808);
			EscConfigPannel.NativeMethodInfoPtr_GetResolution_Private_Static_Vector2Int_SupportedResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686809);
			EscConfigPannel.NativeMethodInfoPtr_ToggleSpellDecalareCutin_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686810);
			EscConfigPannel.NativeMethodInfoPtr_ToggleRunInBackground_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686811);
			EscConfigPannel.NativeMethodInfoPtr_ToggleUseLegacyQTEPannel_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686812);
			EscConfigPannel.NativeMethodInfoPtr_ToggleUseLegacyThrowDeliver_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686813);
			EscConfigPannel.NativeMethodInfoPtr_ToggleUseLargerFontSize_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686814);
			EscConfigPannel.NativeMethodInfoPtr_ToggleVsync_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686815);
			EscConfigPannel.NativeMethodInfoPtr_ChangeTargetRefreshRate_Private_Void_SupportedRefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686816);
			EscConfigPannel.NativeMethodInfoPtr_GetRefreshRate_Private_Static_Int32_SupportedRefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686817);
			EscConfigPannel.NativeMethodInfoPtr_ChangeLangaugeButton_Private_Void_LoadLanguageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686818);
			EscConfigPannel.NativeMethodInfoPtr_ChangeLangauge_Public_Static_Void_LoadLanguageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686819);
			EscConfigPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686820);
			EscConfigPannel.NativeMethodInfoPtr_InitializeBtn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686821);
			EscConfigPannel.NativeMethodInfoPtr_MountCurrentSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686822);
			EscConfigPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686823);
			EscConfigPannel.NativeMethodInfoPtr_SaveSettingData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686824);
			EscConfigPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686825);
			EscConfigPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686826);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686827);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686828);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686829);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686830);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686831);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686832);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686833);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686834);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686835);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_12_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686836);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_13_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686837);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_14_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686838);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_15_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686839);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_16_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686840);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_17_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686841);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_18_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686842);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_19_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686843);
			EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_20_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, 100686844);
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x0021A9B8 File Offset: 0x00218BB8
		public unsafe static PlayerSettings CurrentSettings
		{
			[CallerCount(89)]
			[CachedScanResults(RefRangeStart = 284722, RefRangeEnd = 284811, XrefRangeStart = 284712, XrefRangeEnd = 284722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_CurrentSettings_Private_Static_get_PlayerSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x060071E6 RID: 29158 RVA: 0x0021A9EC File Offset: 0x00218BEC
		public unsafe static MultiLanguageTextMesh.LoadLanguageType CurrentLanguage
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 284812, RefRangeEnd = 284815, XrefRangeStart = 284811, XrefRangeEnd = 284812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_LoadLanguageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x0021AA1C File Offset: 0x00218C1C
		public unsafe static bool EnableSpellDecalareCutin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 284816, RefRangeEnd = 284817, XrefRangeStart = 284815, XrefRangeEnd = 284816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_EnableSpellDecalareCutin_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x060071E8 RID: 29160 RVA: 0x0021AA4C File Offset: 0x00218C4C
		public unsafe static bool EnableLegacyQTEPannel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284817, XrefRangeEnd = 284818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_EnableLegacyQTEPannel_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x060071E9 RID: 29161 RVA: 0x0021AA7C File Offset: 0x00218C7C
		public unsafe static bool EnableLegacyThrowDeliver
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 284819, RefRangeEnd = 284822, XrefRangeStart = 284818, XrefRangeEnd = 284819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_EnableLegacyThrowDeliver_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x060071EA RID: 29162 RVA: 0x0021AAAC File Offset: 0x00218CAC
		public unsafe static bool CleanMusicGameMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 284823, RefRangeEnd = 284826, XrefRangeStart = 284822, XrefRangeEnd = 284823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_CleanMusicGameMode_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x0021AADC File Offset: 0x00218CDC
		public unsafe static float SfxVol
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 284827, RefRangeEnd = 284831, XrefRangeStart = 284826, XrefRangeEnd = 284827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_SfxVol_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x060071EC RID: 29164 RVA: 0x0021AB0C File Offset: 0x00218D0C
		public unsafe static float MusicVol
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 284832, RefRangeEnd = 284836, XrefRangeStart = 284831, XrefRangeEnd = 284832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_get_MusicVol_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x0021AB3C File Offset: 0x00218D3C
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscConfigPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x0021AB84 File Offset: 0x00218D84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284845, RefRangeEnd = 284847, XrefRangeStart = 284836, XrefRangeEnd = 284845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnMusicVolumeUpdate(Action<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_add_OnMusicVolumeUpdate_Public_Static_add_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x0021ABBC File Offset: 0x00218DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284856, RefRangeEnd = 284858, XrefRangeStart = 284847, XrefRangeEnd = 284856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnMusicVolumeUpdate(Action<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_remove_OnMusicVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x0021ABF4 File Offset: 0x00218DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284867, RefRangeEnd = 284868, XrefRangeStart = 284858, XrefRangeEnd = 284867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnOverrideMusicVolumeUpdate(Action<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_add_OnOverrideMusicVolumeUpdate_Public_Static_add_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x0021AC2C File Offset: 0x00218E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284868, XrefRangeEnd = 284877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnOverrideMusicVolumeUpdate(Action<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_remove_OnOverrideMusicVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x0021AC64 File Offset: 0x00218E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284886, RefRangeEnd = 284887, XrefRangeStart = 284877, XrefRangeEnd = 284886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSFXVolumeUpdate(Action<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_add_OnSFXVolumeUpdate_Public_Static_add_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x0021AC9C File Offset: 0x00218E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284887, XrefRangeEnd = 284896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSFXVolumeUpdate(Action<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_remove_OnSFXVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x0021ACD4 File Offset: 0x00218ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284896, XrefRangeEnd = 285184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscConfigPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x0021AD10 File Offset: 0x00218F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285184, XrefRangeEnd = 285186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscConfigPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x0021AD58 File Offset: 0x00218F58
		[CallerCount(0)]
		public unsafe void InitButton(UIButtonToggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_InitButton_Private_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x0021AD9C File Offset: 0x00218F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285202, RefRangeEnd = 285204, XrefRangeStart = 285186, XrefRangeEnd = 285202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunVolumeUpdateCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_RunVolumeUpdateCallback_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x0021ADC4 File Offset: 0x00218FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285207, RefRangeEnd = 285208, XrefRangeStart = 285204, XrefRangeEnd = 285207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSFXVolume(float volume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_SetSFXVolume_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x0021ADF8 File Offset: 0x00218FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285211, RefRangeEnd = 285212, XrefRangeStart = 285208, XrefRangeEnd = 285211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMusicVolume(float volume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_SetMusicVolume_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x0021AE2C File Offset: 0x0021902C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285213, RefRangeEnd = 285214, XrefRangeStart = 285212, XrefRangeEnd = 285213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMusicGameCleanMode(bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_SetMusicGameCleanMode_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x0021AE60 File Offset: 0x00219060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285218, RefRangeEnd = 285220, XrefRangeStart = 285214, XrefRangeEnd = 285218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeMusicVolume(float volume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeMusicVolume_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x0021AE94 File Offset: 0x00219094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285220, XrefRangeEnd = 285223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSFXVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeSFXVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x0021AED4 File Offset: 0x002190D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285223, XrefRangeEnd = 285230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeMusicVolumeVisual(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeMusicVolumeVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x0021AF14 File Offset: 0x00219114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285230, XrefRangeEnd = 285237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSFXVolumeVisual(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeSFXVolumeVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x0021AF54 File Offset: 0x00219154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285237, XrefRangeEnd = 285239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Lerp(int a, int b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_Lerp_Private_Static_Int64_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x0021AFB0 File Offset: 0x002191B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285239, XrefRangeEnd = 285242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeCalibration(float targetCalibration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetCalibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeCalibration_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x0021AFE4 File Offset: 0x002191E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285242, XrefRangeEnd = 285253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCalibrationVisual(float targetCalibration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetCalibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeCalibrationVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x0021B024 File Offset: 0x00219224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285264, RefRangeEnd = 285265, XrefRangeStart = 285253, XrefRangeEnd = 285264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCalibrationVisual(float targetCalibration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetCalibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_GetCalibrationVisual_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x0021B05C File Offset: 0x0021925C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285266, RefRangeEnd = 285267, XrefRangeStart = 285265, XrefRangeEnd = 285266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetCalibrationProgress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_GetCalibrationProgress_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x0021B08C File Offset: 0x0021928C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285267, XrefRangeEnd = 285273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeFullScreenMode(FullScreenMode targetFullScreenMode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetFullScreenMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeFullScreenMode_Private_Static_Void_FullScreenMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x0021B0C0 File Offset: 0x002192C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285273, XrefRangeEnd = 285279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeDisplayResolution(PlayerSettings.SupportedResolution targetResolution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetResolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeDisplayResolution_Private_Void_SupportedResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x0021B100 File Offset: 0x00219300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285279, XrefRangeEnd = 285284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateDisplaySettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_UpdateDisplaySettings_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x0021B128 File Offset: 0x00219328
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 285285, RefRangeEnd = 285299, XrefRangeStart = 285284, XrefRangeEnd = 285285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int GetResolution(PlayerSettings.SupportedResolution resolution)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_GetResolution_Private_Static_Vector2Int_SupportedResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007208 RID: 29192 RVA: 0x0021B168 File Offset: 0x00219368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285299, XrefRangeEnd = 285300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleSpellDecalareCutin(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ToggleSpellDecalareCutin_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x0021B1A8 File Offset: 0x002193A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285300, XrefRangeEnd = 285303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleRunInBackground(bool enable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ToggleRunInBackground_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x0021B1DC File Offset: 0x002193DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285303, XrefRangeEnd = 285304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleUseLegacyQTEPannel(bool enable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ToggleUseLegacyQTEPannel_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x0021B210 File Offset: 0x00219410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285304, XrefRangeEnd = 285305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleUseLegacyThrowDeliver(bool enable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ToggleUseLegacyThrowDeliver_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x0021B244 File Offset: 0x00219444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285305, XrefRangeEnd = 285311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleUseLargerFontSize(bool enable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ToggleUseLargerFontSize_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x0021B278 File Offset: 0x00219478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285311, XrefRangeEnd = 285323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleVsync(bool doVsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doVsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ToggleVsync_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x0021B2B8 File Offset: 0x002194B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285323, XrefRangeEnd = 285327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTargetRefreshRate(PlayerSettings.SupportedRefreshRate refreshRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref refreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeTargetRefreshRate_Private_Void_SupportedRefreshRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x0021B2F8 File Offset: 0x002194F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285331, RefRangeEnd = 285333, XrefRangeStart = 285327, XrefRangeEnd = 285331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRefreshRate(PlayerSettings.SupportedRefreshRate refreshRate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref refreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_GetRefreshRate_Private_Static_Int32_SupportedRefreshRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x0021B338 File Offset: 0x00219538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285357, RefRangeEnd = 285362, XrefRangeStart = 285333, XrefRangeEnd = 285357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLangaugeButton(MultiLanguageTextMesh.LoadLanguageType langauge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref langauge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeLangaugeButton_Private_Void_LoadLanguageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x0021B378 File Offset: 0x00219578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285383, RefRangeEnd = 285385, XrefRangeStart = 285362, XrefRangeEnd = 285383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeLangauge(MultiLanguageTextMesh.LoadLanguageType langauge)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref langauge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_ChangeLangauge_Public_Static_Void_LoadLanguageType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x0021B3AC File Offset: 0x002195AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285385, XrefRangeEnd = 285395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscConfigPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x0021B3E8 File Offset: 0x002195E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285436, RefRangeEnd = 285438, XrefRangeStart = 285395, XrefRangeEnd = 285436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBtn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_InitializeBtn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x0021B41C File Offset: 0x0021961C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285446, RefRangeEnd = 285447, XrefRangeStart = 285438, XrefRangeEnd = 285446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MountCurrentSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_MountCurrentSettings_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x0021B444 File Offset: 0x00219644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285447, XrefRangeEnd = 285453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscConfigPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x0021B480 File Offset: 0x00219680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285458, RefRangeEnd = 285459, XrefRangeStart = 285453, XrefRangeEnd = 285458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveSettingData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr_SaveSettingData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x0021B4A8 File Offset: 0x002196A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285459, XrefRangeEnd = 285478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscConfigPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x0021B4E4 File Offset: 0x002196E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285478, XrefRangeEnd = 285481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscConfigPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x0021B520 File Offset: 0x00219720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285481, XrefRangeEnd = 285487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x0021B554 File Offset: 0x00219754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285487, XrefRangeEnd = 285493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x0021B588 File Offset: 0x00219788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285493, XrefRangeEnd = 285499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x0021B5BC File Offset: 0x002197BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285499, XrefRangeEnd = 285505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x0021B5F0 File Offset: 0x002197F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285505, XrefRangeEnd = 285511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x0021B624 File Offset: 0x00219824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285511, XrefRangeEnd = 285517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x0021B658 File Offset: 0x00219858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285517, XrefRangeEnd = 285523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x0021B68C File Offset: 0x0021988C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285523, XrefRangeEnd = 285530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x0021B6C0 File Offset: 0x002198C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285530, XrefRangeEnd = 285537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x0021B6F4 File Offset: 0x002198F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285537, XrefRangeEnd = 285544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_12()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_12_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x0021B728 File Offset: 0x00219928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285544, XrefRangeEnd = 285551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_13()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_13_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x0021B75C File Offset: 0x0021995C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285551, XrefRangeEnd = 285558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_14()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_14_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x0021B790 File Offset: 0x00219990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285558, XrefRangeEnd = 285581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_15()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_15_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x0021B7C4 File Offset: 0x002199C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285581, XrefRangeEnd = 285582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_16_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x0021B7F8 File Offset: 0x002199F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285582, XrefRangeEnd = 285583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_17()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_17_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x0021B82C File Offset: 0x00219A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285583, XrefRangeEnd = 285584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_18()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_18_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x0021B860 File Offset: 0x00219A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285584, XrefRangeEnd = 285585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_19()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_19_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x0021B894 File Offset: 0x00219A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285585, XrefRangeEnd = 285586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_20()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.NativeMethodInfoPtr__OnPanelInitialize_b__46_20_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x0003DB68 File Offset: 0x0003BD68
		public EscConfigPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x0600722C RID: 29228 RVA: 0x0021B8C8 File Offset: 0x00219AC8
		// (set) Token: 0x0600722D RID: 29229 RVA: 0x0003DB71 File Offset: 0x0003BD71
		public unsafe static PlayerSettings m_CurrentSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.NativeFieldInfoPtr_m_CurrentSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.NativeFieldInfoPtr_m_CurrentSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600722E RID: 29230 RVA: 0x0021B8F0 File Offset: 0x00219AF0
		// (set) Token: 0x0600722F RID: 29231 RVA: 0x0003DB83 File Offset: 0x0003BD83
		public unsafe TextMeshProUGUI CalibrationAmountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_CalibrationAmountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_CalibrationAmountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x06007230 RID: 29232 RVA: 0x0021B920 File Offset: 0x00219B20
		// (set) Token: 0x06007231 RID: 29233 RVA: 0x0003DBA2 File Offset: 0x0003BDA2
		public unsafe TextMeshProUGUI MusicVolumeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_MusicVolumeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_MusicVolumeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06007232 RID: 29234 RVA: 0x0021B950 File Offset: 0x00219B50
		// (set) Token: 0x06007233 RID: 29235 RVA: 0x0003DBC1 File Offset: 0x0003BDC1
		public unsafe TextMeshProUGUI SFXVolumeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_SFXVolumeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_SFXVolumeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06007234 RID: 29236 RVA: 0x0021B980 File Offset: 0x00219B80
		// (set) Token: 0x06007235 RID: 29237 RVA: 0x0003DBE0 File Offset: 0x0003BDE0
		public unsafe UIScrollBar MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_MusicVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_MusicVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x0021B9B0 File Offset: 0x00219BB0
		// (set) Token: 0x06007237 RID: 29239 RVA: 0x0003DBFF File Offset: 0x0003BDFF
		public unsafe UIScrollBar SfxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_SfxVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_SfxVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06007238 RID: 29240 RVA: 0x0021B9E0 File Offset: 0x00219BE0
		// (set) Token: 0x06007239 RID: 29241 RVA: 0x0003DC1E File Offset: 0x0003BE1E
		public unsafe UIButtonToggle EnableSpellDeclareCutin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_EnableSpellDeclareCutin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_EnableSpellDeclareCutin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600723A RID: 29242 RVA: 0x0021BA10 File Offset: 0x00219C10
		// (set) Token: 0x0600723B RID: 29243 RVA: 0x0003DC3D File Offset: 0x0003BE3D
		public unsafe Il2CppReferenceArray<UIButtonToggle> FullScreenMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_FullScreenMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_FullScreenMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600723C RID: 29244 RVA: 0x0021BA40 File Offset: 0x00219C40
		// (set) Token: 0x0600723D RID: 29245 RVA: 0x0003DC5C File Offset: 0x0003BE5C
		public unsafe Il2CppReferenceArray<UIButtonToggle> RenderResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_RenderResolution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_RenderResolution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600723E RID: 29246 RVA: 0x0021BA70 File Offset: 0x00219C70
		// (set) Token: 0x0600723F RID: 29247 RVA: 0x0003DC7B File Offset: 0x0003BE7B
		public unsafe UIButtonToggle Vsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_Vsync);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_Vsync), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x0021BAA0 File Offset: 0x00219CA0
		// (set) Token: 0x06007241 RID: 29249 RVA: 0x0003DC9A File Offset: 0x0003BE9A
		public unsafe Il2CppReferenceArray<UIButtonToggle> TargetRefreshRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_TargetRefreshRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_TargetRefreshRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x0021BAD0 File Offset: 0x00219CD0
		// (set) Token: 0x06007243 RID: 29251 RVA: 0x0003DCB9 File Offset: 0x0003BEB9
		public unsafe Il2CppReferenceArray<UIButtonToggle> Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_Language);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_Language), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06007244 RID: 29252 RVA: 0x0021BB00 File Offset: 0x00219D00
		// (set) Token: 0x06007245 RID: 29253 RVA: 0x0003DCD8 File Offset: 0x0003BED8
		public unsafe UIScrollBar QTECalibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_QTECalibration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_QTECalibration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06007246 RID: 29254 RVA: 0x0021BB30 File Offset: 0x00219D30
		// (set) Token: 0x06007247 RID: 29255 RVA: 0x0003DCF7 File Offset: 0x0003BEF7
		public unsafe UIButtonToggle RunInBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_RunInBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_RunInBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x06007248 RID: 29256 RVA: 0x0021BB60 File Offset: 0x00219D60
		// (set) Token: 0x06007249 RID: 29257 RVA: 0x0003DD16 File Offset: 0x0003BF16
		public unsafe UIButtonToggle UseLegacyQTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_UseLegacyQTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_UseLegacyQTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600724A RID: 29258 RVA: 0x0021BB90 File Offset: 0x00219D90
		// (set) Token: 0x0600724B RID: 29259 RVA: 0x0003DD35 File Offset: 0x0003BF35
		public unsafe UIButtonToggle UseLegacyThrowDeliver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_UseLegacyThrowDeliver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_UseLegacyThrowDeliver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600724C RID: 29260 RVA: 0x0021BBC0 File Offset: 0x00219DC0
		// (set) Token: 0x0600724D RID: 29261 RVA: 0x0003DD54 File Offset: 0x0003BF54
		public unsafe UIButtonToggle EnableLargerFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_EnableLargerFontSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_EnableLargerFontSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x0021BBF0 File Offset: 0x00219DF0
		// (set) Token: 0x0600724F RID: 29263 RVA: 0x0003DD73 File Offset: 0x0003BF73
		public unsafe CanvasGroup TargetRefreshRateGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_TargetRefreshRateGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_TargetRefreshRateGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x0021BC20 File Offset: 0x00219E20
		// (set) Token: 0x06007251 RID: 29265 RVA: 0x0003DD92 File Offset: 0x0003BF92
		public unsafe CanvasGroup LanguageGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_LanguageGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.NativeFieldInfoPtr_LanguageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06007252 RID: 29266 RVA: 0x0021BC50 File Offset: 0x00219E50
		// (set) Token: 0x06007253 RID: 29267 RVA: 0x0003DDB1 File Offset: 0x0003BFB1
		public unsafe static Action<float> OnMusicVolumeUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.NativeFieldInfoPtr_OnMusicVolumeUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.NativeFieldInfoPtr_OnMusicVolumeUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06007254 RID: 29268 RVA: 0x0021BC78 File Offset: 0x00219E78
		// (set) Token: 0x06007255 RID: 29269 RVA: 0x0003DDC3 File Offset: 0x0003BFC3
		public unsafe static Action<float> OnOverrideMusicVolumeUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.NativeFieldInfoPtr_OnOverrideMusicVolumeUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.NativeFieldInfoPtr_OnOverrideMusicVolumeUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x0021BCA0 File Offset: 0x00219EA0
		// (set) Token: 0x06007257 RID: 29271 RVA: 0x0003DDD5 File Offset: 0x0003BFD5
		public unsafe static Action<float> OnSFXVolumeUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.NativeFieldInfoPtr_OnSFXVolumeUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.NativeFieldInfoPtr_OnSFXVolumeUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B6E RID: 19310
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSettings;

		// Token: 0x04004B6F RID: 19311
		private static readonly IntPtr NativeFieldInfoPtr_CalibrationAmountText;

		// Token: 0x04004B70 RID: 19312
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolumeText;

		// Token: 0x04004B71 RID: 19313
		private static readonly IntPtr NativeFieldInfoPtr_SFXVolumeText;

		// Token: 0x04004B72 RID: 19314
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x04004B73 RID: 19315
		private static readonly IntPtr NativeFieldInfoPtr_SfxVolume;

		// Token: 0x04004B74 RID: 19316
		private static readonly IntPtr NativeFieldInfoPtr_EnableSpellDeclareCutin;

		// Token: 0x04004B75 RID: 19317
		private static readonly IntPtr NativeFieldInfoPtr_FullScreenMode;

		// Token: 0x04004B76 RID: 19318
		private static readonly IntPtr NativeFieldInfoPtr_RenderResolution;

		// Token: 0x04004B77 RID: 19319
		private static readonly IntPtr NativeFieldInfoPtr_Vsync;

		// Token: 0x04004B78 RID: 19320
		private static readonly IntPtr NativeFieldInfoPtr_TargetRefreshRate;

		// Token: 0x04004B79 RID: 19321
		private static readonly IntPtr NativeFieldInfoPtr_Language;

		// Token: 0x04004B7A RID: 19322
		private static readonly IntPtr NativeFieldInfoPtr_QTECalibration;

		// Token: 0x04004B7B RID: 19323
		private static readonly IntPtr NativeFieldInfoPtr_RunInBackground;

		// Token: 0x04004B7C RID: 19324
		private static readonly IntPtr NativeFieldInfoPtr_UseLegacyQTEPannel;

		// Token: 0x04004B7D RID: 19325
		private static readonly IntPtr NativeFieldInfoPtr_UseLegacyThrowDeliver;

		// Token: 0x04004B7E RID: 19326
		private static readonly IntPtr NativeFieldInfoPtr_EnableLargerFontSize;

		// Token: 0x04004B7F RID: 19327
		private static readonly IntPtr NativeFieldInfoPtr_TargetRefreshRateGroup;

		// Token: 0x04004B80 RID: 19328
		private static readonly IntPtr NativeFieldInfoPtr_LanguageGroup;

		// Token: 0x04004B81 RID: 19329
		private static readonly IntPtr NativeFieldInfoPtr_OnMusicVolumeUpdate;

		// Token: 0x04004B82 RID: 19330
		private static readonly IntPtr NativeFieldInfoPtr_OnOverrideMusicVolumeUpdate;

		// Token: 0x04004B83 RID: 19331
		private static readonly IntPtr NativeFieldInfoPtr_OnSFXVolumeUpdate;

		// Token: 0x04004B84 RID: 19332
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Private_Static_get_PlayerSettings_0;

		// Token: 0x04004B85 RID: 19333
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_LoadLanguageType_0;

		// Token: 0x04004B86 RID: 19334
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSpellDecalareCutin_Public_Static_get_Boolean_0;

		// Token: 0x04004B87 RID: 19335
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableLegacyQTEPannel_Public_Static_get_Boolean_0;

		// Token: 0x04004B88 RID: 19336
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableLegacyThrowDeliver_Public_Static_get_Boolean_0;

		// Token: 0x04004B89 RID: 19337
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanMusicGameMode_Public_Static_get_Boolean_0;

		// Token: 0x04004B8A RID: 19338
		private static readonly IntPtr NativeMethodInfoPtr_get_SfxVol_Public_Static_get_Single_0;

		// Token: 0x04004B8B RID: 19339
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVol_Public_Static_get_Single_0;

		// Token: 0x04004B8C RID: 19340
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004B8D RID: 19341
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMusicVolumeUpdate_Public_Static_add_Void_Action_1_Single_0;

		// Token: 0x04004B8E RID: 19342
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMusicVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0;

		// Token: 0x04004B8F RID: 19343
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOverrideMusicVolumeUpdate_Public_Static_add_Void_Action_1_Single_0;

		// Token: 0x04004B90 RID: 19344
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOverrideMusicVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0;

		// Token: 0x04004B91 RID: 19345
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSFXVolumeUpdate_Public_Static_add_Void_Action_1_Single_0;

		// Token: 0x04004B92 RID: 19346
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSFXVolumeUpdate_Public_Static_rem_Void_Action_1_Single_0;

		// Token: 0x04004B93 RID: 19347
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004B94 RID: 19348
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004B95 RID: 19349
		private static readonly IntPtr NativeMethodInfoPtr_InitButton_Private_Void_UIButtonToggle_0;

		// Token: 0x04004B96 RID: 19350
		private static readonly IntPtr NativeMethodInfoPtr_RunVolumeUpdateCallback_Public_Static_Void_0;

		// Token: 0x04004B97 RID: 19351
		private static readonly IntPtr NativeMethodInfoPtr_SetSFXVolume_Public_Static_Void_Single_0;

		// Token: 0x04004B98 RID: 19352
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicVolume_Public_Static_Void_Single_0;

		// Token: 0x04004B99 RID: 19353
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicGameCleanMode_Public_Static_Void_Boolean_0;

		// Token: 0x04004B9A RID: 19354
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMusicVolume_Public_Static_Void_Single_0;

		// Token: 0x04004B9B RID: 19355
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSFXVolume_Private_Void_Single_0;

		// Token: 0x04004B9C RID: 19356
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMusicVolumeVisual_Private_Void_Single_0;

		// Token: 0x04004B9D RID: 19357
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSFXVolumeVisual_Private_Void_Single_0;

		// Token: 0x04004B9E RID: 19358
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Int64_Int32_Int32_Single_0;

		// Token: 0x04004B9F RID: 19359
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCalibration_Public_Static_Void_Single_0;

		// Token: 0x04004BA0 RID: 19360
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCalibrationVisual_Private_Void_Single_0;

		// Token: 0x04004BA1 RID: 19361
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrationVisual_Public_Static_String_Single_0;

		// Token: 0x04004BA2 RID: 19362
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrationProgress_Public_Static_Single_0;

		// Token: 0x04004BA3 RID: 19363
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFullScreenMode_Private_Static_Void_FullScreenMode_0;

		// Token: 0x04004BA4 RID: 19364
		private static readonly IntPtr NativeMethodInfoPtr_ChangeDisplayResolution_Private_Void_SupportedResolution_0;

		// Token: 0x04004BA5 RID: 19365
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplaySettings_Private_Static_Void_0;

		// Token: 0x04004BA6 RID: 19366
		private static readonly IntPtr NativeMethodInfoPtr_GetResolution_Private_Static_Vector2Int_SupportedResolution_0;

		// Token: 0x04004BA7 RID: 19367
		private static readonly IntPtr NativeMethodInfoPtr_ToggleSpellDecalareCutin_Private_Void_Boolean_0;

		// Token: 0x04004BA8 RID: 19368
		private static readonly IntPtr NativeMethodInfoPtr_ToggleRunInBackground_Private_Static_Void_Boolean_0;

		// Token: 0x04004BA9 RID: 19369
		private static readonly IntPtr NativeMethodInfoPtr_ToggleUseLegacyQTEPannel_Private_Static_Void_Boolean_0;

		// Token: 0x04004BAA RID: 19370
		private static readonly IntPtr NativeMethodInfoPtr_ToggleUseLegacyThrowDeliver_Private_Static_Void_Boolean_0;

		// Token: 0x04004BAB RID: 19371
		private static readonly IntPtr NativeMethodInfoPtr_ToggleUseLargerFontSize_Private_Static_Void_Boolean_0;

		// Token: 0x04004BAC RID: 19372
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVsync_Private_Void_Boolean_0;

		// Token: 0x04004BAD RID: 19373
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTargetRefreshRate_Private_Void_SupportedRefreshRate_0;

		// Token: 0x04004BAE RID: 19374
		private static readonly IntPtr NativeMethodInfoPtr_GetRefreshRate_Private_Static_Int32_SupportedRefreshRate_0;

		// Token: 0x04004BAF RID: 19375
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLangaugeButton_Private_Void_LoadLanguageType_0;

		// Token: 0x04004BB0 RID: 19376
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLangauge_Public_Static_Void_LoadLanguageType_0;

		// Token: 0x04004BB1 RID: 19377
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004BB2 RID: 19378
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBtn_Private_Void_0;

		// Token: 0x04004BB3 RID: 19379
		private static readonly IntPtr NativeMethodInfoPtr_MountCurrentSettings_Public_Static_Void_0;

		// Token: 0x04004BB4 RID: 19380
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004BB5 RID: 19381
		private static readonly IntPtr NativeMethodInfoPtr_SaveSettingData_Public_Static_Void_0;

		// Token: 0x04004BB6 RID: 19382
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004BB7 RID: 19383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BB8 RID: 19384
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_0;

		// Token: 0x04004BB9 RID: 19385
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0;

		// Token: 0x04004BBA RID: 19386
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_5_Private_Void_0;

		// Token: 0x04004BBB RID: 19387
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_6_Private_Void_0;

		// Token: 0x04004BBC RID: 19388
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_7_Private_Void_0;

		// Token: 0x04004BBD RID: 19389
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_8_Private_Void_0;

		// Token: 0x04004BBE RID: 19390
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_9_Private_Void_0;

		// Token: 0x04004BBF RID: 19391
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_10_Private_Void_0;

		// Token: 0x04004BC0 RID: 19392
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_11_Private_Void_0;

		// Token: 0x04004BC1 RID: 19393
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_12_Private_Void_0;

		// Token: 0x04004BC2 RID: 19394
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_13_Private_Void_0;

		// Token: 0x04004BC3 RID: 19395
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_14_Private_Void_0;

		// Token: 0x04004BC4 RID: 19396
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_15_Private_Void_0;

		// Token: 0x04004BC5 RID: 19397
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_16_Private_Void_0;

		// Token: 0x04004BC6 RID: 19398
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_17_Private_Void_0;

		// Token: 0x04004BC7 RID: 19399
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_18_Private_Void_0;

		// Token: 0x04004BC8 RID: 19400
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_19_Private_Void_0;

		// Token: 0x04004BC9 RID: 19401
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_20_Private_Void_0;

		// Token: 0x02000F35 RID: 3893
		[ObfuscatedName("Common.UI.EscapeUtility.EscConfigPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010FE1 RID: 69601 RVA: 0x003ED430 File Offset: 0x003EB630
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr);
				EscConfigPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, "<>9");
				EscConfigPannel.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, "<>9__46_0");
				EscConfigPannel.__c.NativeFieldInfoPtr___9__46_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, "<>9__46_1");
				EscConfigPannel.__c.NativeFieldInfoPtr___9__46_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, "<>9__46_2");
				EscConfigPannel.__c.NativeFieldInfoPtr___9__46_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, "<>9__46_21");
				EscConfigPannel.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, "<>9__73_0");
				EscConfigPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, 100686846);
				EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, 100686847);
				EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, 100686848);
				EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, 100686849);
				EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_21_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, 100686850);
				EscConfigPannel.__c.NativeMethodInfoPtr__GetRefreshRate_b__73_0_Internal_Int32_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr, 100686851);
			}

			// Token: 0x06010FE2 RID: 69602 RVA: 0x003ED54C File Offset: 0x003EB74C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscConfigPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FE3 RID: 69603 RVA: 0x003ED588 File Offset: 0x003EB788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284681, XrefRangeEnd = 284687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__46_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FE4 RID: 69604 RVA: 0x003ED5BC File Offset: 0x003EB7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284687, XrefRangeEnd = 284693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__46_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FE5 RID: 69605 RVA: 0x003ED5F0 File Offset: 0x003EB7F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284693, XrefRangeEnd = 284699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__46_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FE6 RID: 69606 RVA: 0x003ED624 File Offset: 0x003EB824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284699, XrefRangeEnd = 284700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _OnPanelInitialize_b__46_21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_21_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010FE7 RID: 69607 RVA: 0x003ED660 File Offset: 0x003EB860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetRefreshRate_b__73_0(Resolution x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c.NativeMethodInfoPtr__GetRefreshRate_b__73_0_Internal_Int32_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010FE8 RID: 69608 RVA: 0x00093B08 File Offset: 0x00091D08
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005867 RID: 22631
			// (get) Token: 0x06010FE9 RID: 69609 RVA: 0x003ED6AC File Offset: 0x003EB8AC
			// (set) Token: 0x06010FEA RID: 69610 RVA: 0x00093B11 File Offset: 0x00091D11
			public unsafe static EscConfigPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscConfigPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005868 RID: 22632
			// (get) Token: 0x06010FEB RID: 69611 RVA: 0x003ED6D4 File Offset: 0x003EB8D4
			// (set) Token: 0x06010FEC RID: 69612 RVA: 0x00093B23 File Offset: 0x00091D23
			public unsafe static UnityAction __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005869 RID: 22633
			// (get) Token: 0x06010FED RID: 69613 RVA: 0x003ED6FC File Offset: 0x003EB8FC
			// (set) Token: 0x06010FEE RID: 69614 RVA: 0x00093B35 File Offset: 0x00091D35
			public unsafe static UnityAction __9__46_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700586A RID: 22634
			// (get) Token: 0x06010FEF RID: 69615 RVA: 0x003ED724 File Offset: 0x003EB924
			// (set) Token: 0x06010FF0 RID: 69616 RVA: 0x00093B47 File Offset: 0x00091D47
			public unsafe static UnityAction __9__46_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700586B RID: 22635
			// (get) Token: 0x06010FF1 RID: 69617 RVA: 0x003ED74C File Offset: 0x003EB94C
			// (set) Token: 0x06010FF2 RID: 69618 RVA: 0x00093B59 File Offset: 0x00091D59
			public unsafe static Func<long> __9__46_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__46_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700586C RID: 22636
			// (get) Token: 0x06010FF3 RID: 69619 RVA: 0x003ED774 File Offset: 0x003EB974
			// (set) Token: 0x06010FF4 RID: 69620 RVA: 0x00093B6B File Offset: 0x00091D6B
			public unsafe static Func<Resolution, int> __9__73_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Resolution, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscConfigPannel.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ABE7 RID: 44007
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400ABE8 RID: 44008
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x0400ABE9 RID: 44009
			private static readonly IntPtr NativeFieldInfoPtr___9__46_1;

			// Token: 0x0400ABEA RID: 44010
			private static readonly IntPtr NativeFieldInfoPtr___9__46_2;

			// Token: 0x0400ABEB RID: 44011
			private static readonly IntPtr NativeFieldInfoPtr___9__46_21;

			// Token: 0x0400ABEC RID: 44012
			private static readonly IntPtr NativeFieldInfoPtr___9__73_0;

			// Token: 0x0400ABED RID: 44013
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABEE RID: 44014
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Internal_Void_0;

			// Token: 0x0400ABEF RID: 44015
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Internal_Void_0;

			// Token: 0x0400ABF0 RID: 44016
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_Void_0;

			// Token: 0x0400ABF1 RID: 44017
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_21_Internal_Int64_0;

			// Token: 0x0400ABF2 RID: 44018
			private static readonly IntPtr NativeMethodInfoPtr__GetRefreshRate_b__73_0_Internal_Int32_Resolution_0;
		}

		// Token: 0x02000F36 RID: 3894
		[ObfuscatedName("Common.UI.EscapeUtility.EscConfigPannel+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x06010FF5 RID: 69621 RVA: 0x003ED79C File Offset: 0x003EB99C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<EscConfigPannel.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscConfigPannel>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscConfigPannel.__c__DisplayClass75_0>.NativeClassPtr);
				EscConfigPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_langauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscConfigPannel.__c__DisplayClass75_0>.NativeClassPtr, "langauge");
				EscConfigPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c__DisplayClass75_0>.NativeClassPtr, 100686852);
				EscConfigPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__ChangeLangauge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscConfigPannel.__c__DisplayClass75_0>.NativeClassPtr, 100686853);
			}

			// Token: 0x06010FF6 RID: 69622 RVA: 0x003ED804 File Offset: 0x003EBA04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscConfigPannel.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FF7 RID: 69623 RVA: 0x003ED840 File Offset: 0x003EBA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284700, XrefRangeEnd = 284712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ChangeLangauge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscConfigPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__ChangeLangauge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FF8 RID: 69624 RVA: 0x00093B7D File Offset: 0x00091D7D
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700586D RID: 22637
			// (get) Token: 0x06010FF9 RID: 69625 RVA: 0x003ED874 File Offset: 0x003EBA74
			// (set) Token: 0x06010FFA RID: 69626 RVA: 0x00093B86 File Offset: 0x00091D86
			public unsafe MultiLanguageTextMesh.LoadLanguageType langauge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_langauge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscConfigPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_langauge)) = value;
				}
			}

			// Token: 0x0400ABF3 RID: 44019
			private static readonly IntPtr NativeFieldInfoPtr_langauge;

			// Token: 0x0400ABF4 RID: 44020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABF5 RID: 44021
			private static readonly IntPtr NativeMethodInfoPtr__ChangeLangauge_b__0_Internal_Void_0;
		}
	}
}
