using System;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Music
{
	// Token: 0x0200019A RID: 410
	public class AudioManager : MonoSingleton<AudioManager>
	{
		// Token: 0x06002BDB RID: 11227 RVA: 0x00130014 File Offset: 0x0012E214
		// Note: this type is marked as 'beforefieldinit'.
		static AudioManager()
		{
			Il2CppClassPointerStore<AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Music", "AudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager>.NativeClassPtr);
			AudioManager.NativeFieldInfoPtr_MUSIC_START_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MUSIC_START_OFFSET");
			AudioManager.NativeFieldInfoPtr_MUSIC_FADE_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MUSIC_FADE_DURATION");
			AudioManager.NativeFieldInfoPtr_introPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "introPlayer");
			AudioManager.NativeFieldInfoPtr_loopPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "loopPlayer");
			AudioManager.NativeFieldInfoPtr_musicMainVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicMainVolume");
			AudioManager.NativeFieldInfoPtr_musicOverrideOverrideVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicOverrideOverrideVolumeMultiplier");
			AudioManager.NativeFieldInfoPtr_musicOverrideVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicOverrideVolumeMultiplier");
			AudioManager.NativeFieldInfoPtr_musicVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicVolumeMultiplier");
			AudioManager.NativeFieldInfoPtr__CurrentActiveBGMPackage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<CurrentActiveBGMPackage>k__BackingField");
			AudioManager.NativeFieldInfoPtr_OnLastLoopedBGMStoped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "OnLastLoopedBGMStoped");
			AudioManager.NativeMethodInfoPtr_get_CurrentActiveBGMPackage_Public_get_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670958);
			AudioManager.NativeMethodInfoPtr_set_CurrentActiveBGMPackage_Private_set_Void_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670959);
			AudioManager.NativeMethodInfoPtr_add_OnLastLoopedBGMStoped_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670960);
			AudioManager.NativeMethodInfoPtr_remove_OnLastLoopedBGMStoped_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670961);
			AudioManager.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670962);
			AudioManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670963);
			AudioManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670964);
			AudioManager.NativeMethodInfoPtr_FadeMainBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670965);
			AudioManager.NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670966);
			AudioManager.NativeMethodInfoPtr_PlayLoopedBGM_Public_Void_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670967);
			AudioManager.NativeMethodInfoPtr_FadeBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670968);
			AudioManager.NativeMethodInfoPtr_StopBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670969);
			AudioManager.NativeMethodInfoPtr_SetMusicVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670970);
			AudioManager.NativeMethodInfoPtr_UpdateMusicVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670971);
			AudioManager.NativeMethodInfoPtr_UpdateMusicVolumeMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670972);
			AudioManager.NativeMethodInfoPtr_UpdateMusicOverrideVolumeMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670973);
			AudioManager.NativeMethodInfoPtr_UpdateMusicOverrideOverrideVolumeMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670974);
			AudioManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670975);
			AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670976);
			AudioManager.NativeMethodInfoPtr__StopBGM_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100670977);
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x0013029C File Offset: 0x0012E49C
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x001302DC File Offset: 0x0012E4DC
		public unsafe LoopedBGMPackage CurrentActiveBGMPackage
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_CurrentActiveBGMPackage_Public_get_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98509, XrefRangeEnd = 98510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_CurrentActiveBGMPackage_Private_set_Void_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00130320 File Offset: 0x0012E520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98515, RefRangeEnd = 98516, XrefRangeStart = 98511, XrefRangeEnd = 98515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLastLoopedBGMStoped(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_add_OnLastLoopedBGMStoped_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00130364 File Offset: 0x0012E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98516, XrefRangeEnd = 98520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLastLoopedBGMStoped(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_remove_OnLastLoopedBGMStoped_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x001303A8 File Offset: 0x0012E5A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98544, RefRangeEnd = 98545, XrefRangeStart = 98520, XrefRangeEnd = 98544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x001303DC File Offset: 0x0012E5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98560, RefRangeEnd = 98561, XrefRangeStart = 98545, XrefRangeEnd = 98560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00130410 File Offset: 0x0012E610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98561, XrefRangeEnd = 98564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x0013044C File Offset: 0x0012E64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98564, XrefRangeEnd = 98571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeMainBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_FadeMainBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00130480 File Offset: 0x0012E680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98571, XrefRangeEnd = 98578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreMainBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x001304B4 File Offset: 0x0012E6B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 98599, RefRangeEnd = 98604, XrefRangeStart = 98578, XrefRangeEnd = 98599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayLoopedBGM(LoopedBGMPackage loopedBGMPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loopedBGMPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayLoopedBGM_Public_Void_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x001304F8 File Offset: 0x0012E6F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98611, RefRangeEnd = 98612, XrefRangeStart = 98604, XrefRangeEnd = 98611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_FadeBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0013052C File Offset: 0x0012E72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98625, RefRangeEnd = 98626, XrefRangeStart = 98612, XrefRangeEnd = 98625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_StopBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00130560 File Offset: 0x0012E760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98626, XrefRangeEnd = 98627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicVolume(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMusicVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x001305A0 File Offset: 0x0012E7A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 98638, RefRangeEnd = 98643, XrefRangeStart = 98627, XrefRangeEnd = 98638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateMusicVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x001305D4 File Offset: 0x0012E7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98643, XrefRangeEnd = 98644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicVolumeMultiplier(float targetMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateMusicVolumeMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00130614 File Offset: 0x0012E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98644, XrefRangeEnd = 98645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicOverrideVolumeMultiplier(float targetMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateMusicOverrideVolumeMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00130654 File Offset: 0x0012E854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98646, RefRangeEnd = 98647, XrefRangeStart = 98645, XrefRangeEnd = 98646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicOverrideOverrideVolumeMultiplier(float targetMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateMusicOverrideOverrideVolumeMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00130694 File Offset: 0x0012E894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98647, XrefRangeEnd = 98651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x001306D0 File Offset: 0x0012E8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98651, XrefRangeEnd = 98654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0013070C File Offset: 0x0012E90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98654, XrefRangeEnd = 98655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _StopBGM_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__StopBGM_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000198DB File Offset: 0x00017ADB
		public AudioManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x00130740 File Offset: 0x0012E940
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x000198E4 File Offset: 0x00017AE4
		public unsafe static double MUSIC_START_OFFSET
		{
			get
			{
				double result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_MUSIC_START_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_MUSIC_START_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x0013075C File Offset: 0x0012E95C
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x000198F2 File Offset: 0x00017AF2
		public unsafe static float MUSIC_FADE_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_MUSIC_FADE_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_MUSIC_FADE_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x00130778 File Offset: 0x0012E978
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00019900 File Offset: 0x00017B00
		public unsafe AudioSource introPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_introPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_introPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x001307A8 File Offset: 0x0012E9A8
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x0001991F File Offset: 0x00017B1F
		public unsafe AudioSource loopPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_loopPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_loopPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x001307D8 File Offset: 0x0012E9D8
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x0001993E File Offset: 0x00017B3E
		public unsafe float musicMainVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicMainVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicMainVolume)) = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x00130800 File Offset: 0x0012EA00
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x00019959 File Offset: 0x00017B59
		public unsafe float musicOverrideOverrideVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicOverrideOverrideVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicOverrideOverrideVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x00130828 File Offset: 0x0012EA28
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00019974 File Offset: 0x00017B74
		public unsafe float musicOverrideVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicOverrideVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicOverrideVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x00130850 File Offset: 0x0012EA50
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x0001998F File Offset: 0x00017B8F
		public unsafe float musicVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x00130878 File Offset: 0x0012EA78
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x000199AA File Offset: 0x00017BAA
		public unsafe LoopedBGMPackage _CurrentActiveBGMPackage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__CurrentActiveBGMPackage_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__CurrentActiveBGMPackage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x001308A8 File Offset: 0x0012EAA8
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x000199C9 File Offset: 0x00017BC9
		public unsafe Action OnLastLoopedBGMStoped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OnLastLoopedBGMStoped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OnLastLoopedBGMStoped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_START_OFFSET;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_DURATION;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeFieldInfoPtr_introPlayer;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeFieldInfoPtr_loopPlayer;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeFieldInfoPtr_musicMainVolume;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeFieldInfoPtr_musicOverrideOverrideVolumeMultiplier;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeFieldInfoPtr_musicOverrideVolumeMultiplier;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeFieldInfoPtr_musicVolumeMultiplier;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeFieldInfoPtr__CurrentActiveBGMPackage_k__BackingField;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeFieldInfoPtr_OnLastLoopedBGMStoped;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActiveBGMPackage_Public_get_LoopedBGMPackage_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActiveBGMPackage_Private_set_Void_LoopedBGMPackage_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLastLoopedBGMStoped_Public_add_Void_Action_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLastLoopedBGMStoped_Public_rem_Void_Action_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_FadeMainBGM_Public_Void_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_PlayLoopedBGM_Public_Void_LoopedBGMPackage_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_FadeBGM_Public_Void_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_StopBGM_Public_Void_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicVolume_Private_Void_Single_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicVolume_Private_Void_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicVolumeMultiplier_Private_Void_Single_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicOverrideVolumeMultiplier_Private_Void_Single_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicOverrideOverrideVolumeMultiplier_Public_Void_Single_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr__StopBGM_b__22_0_Private_Void_0;
	}
}
