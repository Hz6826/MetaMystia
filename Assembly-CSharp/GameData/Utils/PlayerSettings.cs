using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Utils
{
	// Token: 0x02000219 RID: 537
	public class PlayerSettings : Il2CppSystem.Object
	{
		// Token: 0x06003DEA RID: 15850 RVA: 0x00170994 File Offset: 0x0016EB94
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSettings()
		{
			Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Utils", "PlayerSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr);
			PlayerSettings.NativeFieldInfoPtr_CURRENT_SETTING_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "CURRENT_SETTING_VERSION");
			PlayerSettings.NativeFieldInfoPtr__SaveFileVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<SaveFileVersion>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__MusicVol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<MusicVol>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__SfxVol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<SfxVol>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__EnableSpellDecalareCutin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<EnableSpellDecalareCutin>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__RunInBackground_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<RunInBackground>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__UseLegacyQTEPannel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<UseLegacyQTEPannel>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__UseLegacyThrowDeliver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<UseLegacyThrowDeliver>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__EnableLargerFontSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<EnableLargerFontSize>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__CurrentResolution_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<CurrentResolution>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__FullScreenMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<FullScreenMode>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__Vsync_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<Vsync>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__TargetRefreshRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<TargetRefreshRate>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__CurrentLanguage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<CurrentLanguage>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__MusicCalibrationOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<MusicCalibrationOffset>k__BackingField");
			PlayerSettings.NativeFieldInfoPtr__CleanMusicGameMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, "<CleanMusicGameMode>k__BackingField");
			PlayerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674632);
			PlayerSettings.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674633);
			PlayerSettings.NativeMethodInfoPtr_MapLanguage_Private_Static_LoadLanguageType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674634);
			PlayerSettings.NativeMethodInfoPtr_get_SaveFileVersion_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674635);
			PlayerSettings.NativeMethodInfoPtr_set_SaveFileVersion_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674636);
			PlayerSettings.NativeMethodInfoPtr_get_MusicVol_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674637);
			PlayerSettings.NativeMethodInfoPtr_set_MusicVol_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674638);
			PlayerSettings.NativeMethodInfoPtr_get_SfxVol_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674639);
			PlayerSettings.NativeMethodInfoPtr_set_SfxVol_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674640);
			PlayerSettings.NativeMethodInfoPtr_get_EnableSpellDecalareCutin_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674641);
			PlayerSettings.NativeMethodInfoPtr_set_EnableSpellDecalareCutin_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674642);
			PlayerSettings.NativeMethodInfoPtr_get_RunInBackground_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674643);
			PlayerSettings.NativeMethodInfoPtr_set_RunInBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674644);
			PlayerSettings.NativeMethodInfoPtr_get_UseLegacyQTEPannel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674645);
			PlayerSettings.NativeMethodInfoPtr_set_UseLegacyQTEPannel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674646);
			PlayerSettings.NativeMethodInfoPtr_get_UseLegacyThrowDeliver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674647);
			PlayerSettings.NativeMethodInfoPtr_set_UseLegacyThrowDeliver_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674648);
			PlayerSettings.NativeMethodInfoPtr_get_EnableLargerFontSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674649);
			PlayerSettings.NativeMethodInfoPtr_set_EnableLargerFontSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674650);
			PlayerSettings.NativeMethodInfoPtr_get_CurrentResolution_Public_get_SupportedResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674651);
			PlayerSettings.NativeMethodInfoPtr_set_CurrentResolution_Public_set_Void_SupportedResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674652);
			PlayerSettings.NativeMethodInfoPtr_get_FullScreenMode_Public_get_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674653);
			PlayerSettings.NativeMethodInfoPtr_set_FullScreenMode_Public_set_Void_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674654);
			PlayerSettings.NativeMethodInfoPtr_get_Vsync_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674655);
			PlayerSettings.NativeMethodInfoPtr_set_Vsync_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674656);
			PlayerSettings.NativeMethodInfoPtr_get_TargetRefreshRate_Public_get_SupportedRefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674657);
			PlayerSettings.NativeMethodInfoPtr_set_TargetRefreshRate_Public_set_Void_SupportedRefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674658);
			PlayerSettings.NativeMethodInfoPtr_get_CurrentLanguage_Public_get_LoadLanguageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674659);
			PlayerSettings.NativeMethodInfoPtr_set_CurrentLanguage_Public_set_Void_LoadLanguageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674660);
			PlayerSettings.NativeMethodInfoPtr_get_MusicCalibrationOffset_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674661);
			PlayerSettings.NativeMethodInfoPtr_set_MusicCalibrationOffset_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674662);
			PlayerSettings.NativeMethodInfoPtr_get_CleanMusicGameMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674663);
			PlayerSettings.NativeMethodInfoPtr_set_CleanMusicGameMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674664);
			PlayerSettings.NativeMethodInfoPtr_get_IsRecentVersion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674665);
			PlayerSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr, 100674666);
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00170DC0 File Offset: 0x0016EFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138323, XrefRangeEnd = 138324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00170DFC File Offset: 0x0016EFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138330, RefRangeEnd = 138331, XrefRangeStart = 138324, XrefRangeEnd = 138330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSettings(int version) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00170E44 File Offset: 0x0016F044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138384, RefRangeEnd = 138385, XrefRangeStart = 138331, XrefRangeEnd = 138384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MultiLanguageTextMesh.LoadLanguageType MapLanguage(string cultureName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_MapLanguage_Private_Static_LoadLanguageType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x00170E88 File Offset: 0x0016F088
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x00170EC4 File Offset: 0x0016F0C4
		public unsafe int SaveFileVersion
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_SaveFileVersion_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 138385, RefRangeEnd = 138389, XrefRangeStart = 138385, XrefRangeEnd = 138385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_SaveFileVersion_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x00170F04 File Offset: 0x0016F104
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x00170F40 File Offset: 0x0016F140
		public unsafe float MusicVol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_MusicVol_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_MusicVol_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x00170F80 File Offset: 0x0016F180
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x00170FBC File Offset: 0x0016F1BC
		public unsafe float SfxVol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_SfxVol_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_SfxVol_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x00170FFC File Offset: 0x0016F1FC
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x00171038 File Offset: 0x0016F238
		public unsafe bool EnableSpellDecalareCutin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_EnableSpellDecalareCutin_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_EnableSpellDecalareCutin_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00171078 File Offset: 0x0016F278
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x001710B4 File Offset: 0x0016F2B4
		public unsafe bool RunInBackground
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_RunInBackground_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_RunInBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x001710F4 File Offset: 0x0016F2F4
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x00171130 File Offset: 0x0016F330
		public unsafe bool UseLegacyQTEPannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_UseLegacyQTEPannel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_UseLegacyQTEPannel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x00171170 File Offset: 0x0016F370
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x001711AC File Offset: 0x0016F3AC
		public unsafe bool UseLegacyThrowDeliver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_UseLegacyThrowDeliver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_UseLegacyThrowDeliver_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x001711EC File Offset: 0x0016F3EC
		// (set) Token: 0x06003DFD RID: 15869 RVA: 0x00171228 File Offset: 0x0016F428
		public unsafe bool EnableLargerFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_EnableLargerFontSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 105991, RefRangeEnd = 105993, XrefRangeStart = 105991, XrefRangeEnd = 105993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_EnableLargerFontSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x00171268 File Offset: 0x0016F468
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x001712A4 File Offset: 0x0016F4A4
		public unsafe PlayerSettings.SupportedResolution CurrentResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_CurrentResolution_Public_get_SupportedResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_CurrentResolution_Public_set_Void_SupportedResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x001712E4 File Offset: 0x0016F4E4
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x00171320 File Offset: 0x0016F520
		public unsafe FullScreenMode FullScreenMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_FullScreenMode_Public_get_FullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_FullScreenMode_Public_set_Void_FullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x00171360 File Offset: 0x0016F560
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x0017139C File Offset: 0x0016F59C
		public unsafe bool Vsync
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_Vsync_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_Vsync_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x001713DC File Offset: 0x0016F5DC
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x00171418 File Offset: 0x0016F618
		public unsafe PlayerSettings.SupportedRefreshRate TargetRefreshRate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53318, RefRangeEnd = 53319, XrefRangeStart = 53318, XrefRangeEnd = 53319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_TargetRefreshRate_Public_get_SupportedRefreshRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95701, RefRangeEnd = 95702, XrefRangeStart = 95701, XrefRangeEnd = 95702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_TargetRefreshRate_Public_set_Void_SupportedRefreshRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x00171458 File Offset: 0x0016F658
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x00171494 File Offset: 0x0016F694
		public unsafe MultiLanguageTextMesh.LoadLanguageType CurrentLanguage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73634, RefRangeEnd = 73635, XrefRangeStart = 73634, XrefRangeEnd = 73635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_CurrentLanguage_Public_get_LoadLanguageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_CurrentLanguage_Public_set_Void_LoadLanguageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x001714D4 File Offset: 0x0016F6D4
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x00171510 File Offset: 0x0016F710
		public unsafe long MusicCalibrationOffset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_MusicCalibrationOffset_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_MusicCalibrationOffset_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x00171550 File Offset: 0x0016F750
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x0017158C File Offset: 0x0016F78C
		public unsafe bool CleanMusicGameMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_CleanMusicGameMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_set_CleanMusicGameMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x001715CC File Offset: 0x0016F7CC
		public unsafe bool IsRecentVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 138389, RefRangeEnd = 138390, XrefRangeStart = 138389, XrefRangeEnd = 138389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSettings.NativeMethodInfoPtr_get_IsRecentVersion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00171608 File Offset: 0x0016F808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138390, XrefRangeEnd = 138441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x000228CC File Offset: 0x00020ACC
		public PlayerSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x0017164C File Offset: 0x0016F84C
		// (set) Token: 0x06003E10 RID: 15888 RVA: 0x000228D5 File Offset: 0x00020AD5
		public unsafe static int CURRENT_SETTING_VERSION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PlayerSettings.NativeFieldInfoPtr_CURRENT_SETTING_VERSION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSettings.NativeFieldInfoPtr_CURRENT_SETTING_VERSION, (void*)(&value));
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x00171668 File Offset: 0x0016F868
		// (set) Token: 0x06003E12 RID: 15890 RVA: 0x000228E3 File Offset: 0x00020AE3
		public unsafe int _SaveFileVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__SaveFileVersion_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__SaveFileVersion_k__BackingField)) = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x00171690 File Offset: 0x0016F890
		// (set) Token: 0x06003E14 RID: 15892 RVA: 0x000228FE File Offset: 0x00020AFE
		public unsafe float _MusicVol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__MusicVol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__MusicVol_k__BackingField)) = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x001716B8 File Offset: 0x0016F8B8
		// (set) Token: 0x06003E16 RID: 15894 RVA: 0x00022919 File Offset: 0x00020B19
		public unsafe float _SfxVol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__SfxVol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__SfxVol_k__BackingField)) = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x001716E0 File Offset: 0x0016F8E0
		// (set) Token: 0x06003E18 RID: 15896 RVA: 0x00022934 File Offset: 0x00020B34
		public unsafe bool _EnableSpellDecalareCutin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__EnableSpellDecalareCutin_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__EnableSpellDecalareCutin_k__BackingField)) = value;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06003E19 RID: 15897 RVA: 0x00171708 File Offset: 0x0016F908
		// (set) Token: 0x06003E1A RID: 15898 RVA: 0x0002294F File Offset: 0x00020B4F
		public unsafe bool _RunInBackground_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__RunInBackground_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__RunInBackground_k__BackingField)) = value;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x00171730 File Offset: 0x0016F930
		// (set) Token: 0x06003E1C RID: 15900 RVA: 0x0002296A File Offset: 0x00020B6A
		public unsafe bool _UseLegacyQTEPannel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__UseLegacyQTEPannel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__UseLegacyQTEPannel_k__BackingField)) = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06003E1D RID: 15901 RVA: 0x00171758 File Offset: 0x0016F958
		// (set) Token: 0x06003E1E RID: 15902 RVA: 0x00022985 File Offset: 0x00020B85
		public unsafe bool _UseLegacyThrowDeliver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__UseLegacyThrowDeliver_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__UseLegacyThrowDeliver_k__BackingField)) = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x00171780 File Offset: 0x0016F980
		// (set) Token: 0x06003E20 RID: 15904 RVA: 0x000229A0 File Offset: 0x00020BA0
		public unsafe bool _EnableLargerFontSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__EnableLargerFontSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__EnableLargerFontSize_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x001717A8 File Offset: 0x0016F9A8
		// (set) Token: 0x06003E22 RID: 15906 RVA: 0x000229BB File Offset: 0x00020BBB
		public unsafe PlayerSettings.SupportedResolution _CurrentResolution_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__CurrentResolution_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__CurrentResolution_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x001717D0 File Offset: 0x0016F9D0
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x000229D6 File Offset: 0x00020BD6
		public unsafe FullScreenMode _FullScreenMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__FullScreenMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__FullScreenMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x001717F8 File Offset: 0x0016F9F8
		// (set) Token: 0x06003E26 RID: 15910 RVA: 0x000229F1 File Offset: 0x00020BF1
		public unsafe bool _Vsync_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__Vsync_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__Vsync_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06003E27 RID: 15911 RVA: 0x00171820 File Offset: 0x0016FA20
		// (set) Token: 0x06003E28 RID: 15912 RVA: 0x00022A0C File Offset: 0x00020C0C
		public unsafe PlayerSettings.SupportedRefreshRate _TargetRefreshRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__TargetRefreshRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__TargetRefreshRate_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x00171848 File Offset: 0x0016FA48
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x00022A27 File Offset: 0x00020C27
		public unsafe MultiLanguageTextMesh.LoadLanguageType _CurrentLanguage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__CurrentLanguage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__CurrentLanguage_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x00171870 File Offset: 0x0016FA70
		// (set) Token: 0x06003E2C RID: 15916 RVA: 0x00022A42 File Offset: 0x00020C42
		public unsafe long _MusicCalibrationOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__MusicCalibrationOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__MusicCalibrationOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x00171898 File Offset: 0x0016FA98
		// (set) Token: 0x06003E2E RID: 15918 RVA: 0x00022A5D File Offset: 0x00020C5D
		public unsafe bool _CleanMusicGameMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__CleanMusicGameMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSettings.NativeFieldInfoPtr__CleanMusicGameMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeFieldInfoPtr_CURRENT_SETTING_VERSION;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeFieldInfoPtr__SaveFileVersion_k__BackingField;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeFieldInfoPtr__MusicVol_k__BackingField;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeFieldInfoPtr__SfxVol_k__BackingField;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeFieldInfoPtr__EnableSpellDecalareCutin_k__BackingField;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeFieldInfoPtr__RunInBackground_k__BackingField;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeFieldInfoPtr__UseLegacyQTEPannel_k__BackingField;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeFieldInfoPtr__UseLegacyThrowDeliver_k__BackingField;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeFieldInfoPtr__EnableLargerFontSize_k__BackingField;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeFieldInfoPtr__CurrentResolution_k__BackingField;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeFieldInfoPtr__FullScreenMode_k__BackingField;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeFieldInfoPtr__Vsync_k__BackingField;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeFieldInfoPtr__TargetRefreshRate_k__BackingField;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLanguage_k__BackingField;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeFieldInfoPtr__MusicCalibrationOffset_k__BackingField;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeFieldInfoPtr__CleanMusicGameMode_k__BackingField;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_MapLanguage_Private_Static_LoadLanguageType_String_0;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileVersion_Private_get_Int32_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_set_SaveFileVersion_Private_set_Void_Int32_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVol_Public_get_Single_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicVol_Public_set_Void_Single_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_get_SfxVol_Public_get_Single_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_set_SfxVol_Public_set_Void_Single_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSpellDecalareCutin_Public_get_Boolean_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableSpellDecalareCutin_Public_set_Void_Boolean_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_get_RunInBackground_Public_get_Boolean_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_set_RunInBackground_Public_set_Void_Boolean_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_get_UseLegacyQTEPannel_Public_get_Boolean_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_set_UseLegacyQTEPannel_Public_set_Void_Boolean_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_get_UseLegacyThrowDeliver_Public_get_Boolean_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_set_UseLegacyThrowDeliver_Public_set_Void_Boolean_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableLargerFontSize_Public_get_Boolean_0;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableLargerFontSize_Public_set_Void_Boolean_0;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentResolution_Public_get_SupportedResolution_0;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentResolution_Public_set_Void_SupportedResolution_0;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeMethodInfoPtr_get_FullScreenMode_Public_get_FullScreenMode_0;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeMethodInfoPtr_set_FullScreenMode_Public_set_Void_FullScreenMode_0;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeMethodInfoPtr_get_Vsync_Public_get_Boolean_0;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_set_Vsync_Public_set_Void_Boolean_0;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetRefreshRate_Public_get_SupportedRefreshRate_0;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetRefreshRate_Public_set_Void_SupportedRefreshRate_0;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_get_LoadLanguageType_0;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLanguage_Public_set_Void_LoadLanguageType_0;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicCalibrationOffset_Public_get_Int64_0;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicCalibrationOffset_Public_set_Void_Int64_0;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanMusicGameMode_Public_get_Boolean_0;

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeMethodInfoPtr_set_CleanMusicGameMode_Public_set_Void_Boolean_0;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRecentVersion_Public_get_Boolean_0;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000982 RID: 2434
		public enum SupportedRefreshRate
		{
			// Token: 0x040079BE RID: 31166
			R60,
			// Token: 0x040079BF RID: 31167
			R120,
			// Token: 0x040079C0 RID: 31168
			R144,
			// Token: 0x040079C1 RID: 31169
			R240,
			// Token: 0x040079C2 RID: 31170
			UNLIMITED,
			// Token: 0x040079C3 RID: 31171
			SCREEEN
		}

		// Token: 0x02000983 RID: 2435
		public enum SupportedResolution
		{
			// Token: 0x040079C5 RID: 31173
			NATIVE,
			// Token: 0x040079C6 RID: 31174
			X720,
			// Token: 0x040079C7 RID: 31175
			X768,
			// Token: 0x040079C8 RID: 31176
			X900,
			// Token: 0x040079C9 RID: 31177
			X1080,
			// Token: 0x040079CA RID: 31178
			X2K,
			// Token: 0x040079CB RID: 31179
			X4K
		}
	}
}
