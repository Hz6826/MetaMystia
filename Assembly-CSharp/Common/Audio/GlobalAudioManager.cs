using System;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Common.Audio
{
	// Token: 0x020003D8 RID: 984
	public class GlobalAudioManager : MonoSingletonPersistant<GlobalAudioManager>
	{
		// Token: 0x0600758E RID: 30094 RVA: 0x002265C0 File Offset: 0x002247C0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalAudioManager()
		{
			Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.Audio", "GlobalAudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr);
			GlobalAudioManager.NativeFieldInfoPtr_MaxAudioSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "MaxAudioSources");
			GlobalAudioManager.NativeFieldInfoPtr_MUSIC_FADE_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "MUSIC_FADE_DURATION");
			GlobalAudioManager.NativeFieldInfoPtr_REPEAT_AUDIO_PROTECTION_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "REPEAT_AUDIO_PROTECTION_OFFSET");
			GlobalAudioManager.NativeFieldInfoPtr_looping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "looping");
			GlobalAudioManager.NativeFieldInfoPtr_m_WorkingGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "m_WorkingGC");
			GlobalAudioManager.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "pool");
			GlobalAudioManager.NativeFieldInfoPtr_working = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "working");
			GlobalAudioManager.NativeFieldInfoPtr_workingAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "workingAudio");
			GlobalAudioManager.NativeFieldInfoPtr_bgmStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "bgmStart");
			GlobalAudioManager.NativeFieldInfoPtr_bgmLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "bgmLoop");
			GlobalAudioManager.NativeFieldInfoPtr_bufferedSFXVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "bufferedSFXVolume");
			GlobalAudioManager.NativeFieldInfoPtr_currentAudioSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "currentAudioSources");
			GlobalAudioManager.NativeFieldInfoPtr_internalBGMVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "internalBGMVolumeMultiplier");
			GlobalAudioManager.NativeFieldInfoPtr_isOverrideBGMPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "isOverrideBGMPlaying");
			GlobalAudioManager.NativeFieldInfoPtr_m_IsOverrideBGMStopping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "m_IsOverrideBGMStopping");
			GlobalAudioManager.NativeFieldInfoPtr_m_PausedStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "m_PausedStartTime");
			GlobalAudioManager.NativeFieldInfoPtr_onFadeMainBGMCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "onFadeMainBGMCallback");
			GlobalAudioManager.NativeFieldInfoPtr_onRestoreMainBGMCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "onRestoreMainBGMCallback");
			GlobalAudioManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687403);
			GlobalAudioManager.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687404);
			GlobalAudioManager.NativeMethodInfoPtr_UpdateSFXVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687405);
			GlobalAudioManager.NativeMethodInfoPtr_UpdateBGMVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687406);
			GlobalAudioManager.NativeMethodInfoPtr_GetSystemString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687407);
			GlobalAudioManager.NativeMethodInfoPtr_GetIdle_Private_AudioSource_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687408);
			GlobalAudioManager.NativeMethodInfoPtr_PlayLoopedSFX_Public_Void_Object_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687409);
			GlobalAudioManager.NativeMethodInfoPtr_Release_Private_Void_WorkingLoopedSFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687410);
			GlobalAudioManager.NativeMethodInfoPtr_SetSourceVolume_Private_Void_Single_AudioSource_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687411);
			GlobalAudioManager.NativeMethodInfoPtr_MuteAllLoopedSFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687412);
			GlobalAudioManager.NativeMethodInfoPtr_RestoreAllLoopedSFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687413);
			GlobalAudioManager.NativeMethodInfoPtr_SetAllLoopedSFXVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687414);
			GlobalAudioManager.NativeMethodInfoPtr_StopAllLoopedSFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687415);
			GlobalAudioManager.NativeMethodInfoPtr_UpdateEntry_Public_Void_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687416);
			GlobalAudioManager.NativeMethodInfoPtr_Play_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687417);
			GlobalAudioManager.NativeMethodInfoPtr_PlayOverrideBGM_Public_ValueTuple_2_AudioSource_AudioSource_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687418);
			GlobalAudioManager.NativeMethodInfoPtr_PlayOverrideBGM_Public_ValueTuple_2_AudioSource_AudioSource_LoopedBGMPackage_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687419);
			GlobalAudioManager.NativeMethodInfoPtr_PauseOverrideBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687420);
			GlobalAudioManager.NativeMethodInfoPtr_ResumeOverrideBGM_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687421);
			GlobalAudioManager.NativeMethodInfoPtr_StopOverrideBGM_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687422);
			GlobalAudioManager.NativeMethodInfoPtr_StopOverrideBGMInternal_Private_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687423);
			GlobalAudioManager.NativeMethodInfoPtr_FadeOverrideBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687424);
			GlobalAudioManager.NativeMethodInfoPtr_RestoreOverrideBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687425);
			GlobalAudioManager.NativeMethodInfoPtr_SetOverrideBGMMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687426);
			GlobalAudioManager.NativeMethodInfoPtr_FadeOverrideBGMInternal_Private_Void_FadeType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687427);
			GlobalAudioManager.NativeMethodInfoPtr_FadeAudioSource_Private_Void_Object_FadeType_Single_Action_1_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687428);
			GlobalAudioManager.NativeMethodInfoPtr_GetHash_Private_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687429);
			GlobalAudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, 100687430);
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00226988 File Offset: 0x00224B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291838, XrefRangeEnd = 291873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x002269BC File Offset: 0x00224BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291873, XrefRangeEnd = 291927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GlobalAudioManager.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x002269F8 File Offset: 0x00224BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291927, XrefRangeEnd = 291941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSFXVolume(float targetVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_UpdateSFXVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00226A38 File Offset: 0x00224C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291941, XrefRangeEnd = 291944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBGMVolume(float targetVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_UpdateBGMVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00226A78 File Offset: 0x00224C78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292038, RefRangeEnd = 292040, XrefRangeStart = 291944, XrefRangeEnd = 292038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSystemString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_GetSystemString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00226AB0 File Offset: 0x00224CB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292071, RefRangeEnd = 292074, XrefRangeStart = 292040, XrefRangeEnd = 292071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSource GetIdle(out bool temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_GetIdle_Private_AudioSource_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00226AFC File Offset: 0x00224CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292095, RefRangeEnd = 292097, XrefRangeStart = 292074, XrefRangeEnd = 292095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayLoopedSFX(UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(identifier);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loopedBGMPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_PlayLoopedSFX_Public_Void_Object_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00226B50 File Offset: 0x00224D50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292123, RefRangeEnd = 292126, XrefRangeStart = 292097, XrefRangeEnd = 292123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(GlobalAudioManager.WorkingLoopedSFX workingLoopedSFX)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(workingLoopedSFX);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_Release_Private_Void_WorkingLoopedSFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00226B94 File Offset: 0x00224D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292126, XrefRangeEnd = 292129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourceVolume(float progress, AudioSource componentA, AudioSource componentB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(componentA);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(componentB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_SetSourceVolume_Private_Void_Single_AudioSource_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00226BF8 File Offset: 0x00224DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292129, XrefRangeEnd = 292136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MuteAllLoopedSFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_MuteAllLoopedSFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00226C2C File Offset: 0x00224E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292143, RefRangeEnd = 292144, XrefRangeStart = 292136, XrefRangeEnd = 292143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreAllLoopedSFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_RestoreAllLoopedSFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00226C60 File Offset: 0x00224E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292144, XrefRangeEnd = 292163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllLoopedSFXVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_SetAllLoopedSFXVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00226CA0 File Offset: 0x00224EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292184, RefRangeEnd = 292185, XrefRangeStart = 292163, XrefRangeEnd = 292184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllLoopedSFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_StopAllLoopedSFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00226CD4 File Offset: 0x00224ED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292187, RefRangeEnd = 292190, XrefRangeStart = 292185, XrefRangeEnd = 292187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntry(Action onFadeMainBGMCallback, Action onRestoreMainBGMCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFadeMainBGMCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRestoreMainBGMCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_UpdateEntry_Public_Void_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x00226D28 File Offset: 0x00224F28
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 292212, RefRangeEnd = 292276, XrefRangeStart = 292190, XrefRangeEnd = 292212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(AudioClip audioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_Play_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00226D6C File Offset: 0x00224F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292277, RefRangeEnd = 292279, XrefRangeStart = 292276, XrefRangeEnd = 292277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<AudioSource, AudioSource> PlayOverrideBGM(LoopedBGMPackage bgmPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bgmPackage);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_PlayOverrideBGM_Public_ValueTuple_2_AudioSource_AudioSource_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<AudioSource, AudioSource>(pointer);
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00226DB4 File Offset: 0x00224FB4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292307, RefRangeEnd = 292313, XrefRangeStart = 292279, XrefRangeEnd = 292307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<AudioSource, AudioSource> PlayOverrideBGM(LoopedBGMPackage bgmPackage, double delay, bool instantSwitch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bgmPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantSwitch;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_PlayOverrideBGM_Public_ValueTuple_2_AudioSource_AudioSource_LoopedBGMPackage_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<AudioSource, AudioSource>(pointer);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00226E18 File Offset: 0x00225018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292320, RefRangeEnd = 292322, XrefRangeStart = 292313, XrefRangeEnd = 292320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseOverrideBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_PauseOverrideBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00226E4C File Offset: 0x0022504C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292325, RefRangeEnd = 292327, XrefRangeStart = 292322, XrefRangeEnd = 292325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeOverrideBGM(double delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_ResumeOverrideBGM_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00226E8C File Offset: 0x0022508C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 292328, RefRangeEnd = 292347, XrefRangeStart = 292327, XrefRangeEnd = 292328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopOverrideBGM(Action onFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_StopOverrideBGM_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00226ED0 File Offset: 0x002250D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292360, RefRangeEnd = 292362, XrefRangeStart = 292347, XrefRangeEnd = 292360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopOverrideBGMInternal(Action onFinish, bool instantSwitch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantSwitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_StopOverrideBGMInternal_Private_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00226F20 File Offset: 0x00225120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292363, RefRangeEnd = 292364, XrefRangeStart = 292362, XrefRangeEnd = 292363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOverrideBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_FadeOverrideBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00226F54 File Offset: 0x00225154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292365, RefRangeEnd = 292366, XrefRangeStart = 292364, XrefRangeEnd = 292365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreOverrideBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_RestoreOverrideBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00226F88 File Offset: 0x00225188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292370, RefRangeEnd = 292371, XrefRangeStart = 292366, XrefRangeEnd = 292370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideBGMMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_SetOverrideBGMMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00226FC8 File Offset: 0x002251C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292381, RefRangeEnd = 292384, XrefRangeStart = 292371, XrefRangeEnd = 292381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOverrideBGMInternal(GlobalAudioManager.FadeType fadeType, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_FadeOverrideBGMInternal_Private_Void_FadeType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00227018 File Offset: 0x00225218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292390, RefRangeEnd = 292391, XrefRangeStart = 292384, XrefRangeEnd = 292390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeAudioSource(Il2CppSystem.Object extraIndentifier, GlobalAudioManager.FadeType fadeType, float startVolume, Action<float> updateAudioSourceCallback, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraIndentifier);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startVolume;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateAudioSourceCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_FadeAudioSource_Private_Void_Object_FadeType_Single_Action_1_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x0022709C File Offset: 0x0022529C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292398, RefRangeEnd = 292401, XrefRangeStart = 292391, XrefRangeEnd = 292398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHash(Il2CppSystem.Object extraIndentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraIndentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr_GetHash_Private_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x002270EC File Offset: 0x002252EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292401, XrefRangeEnd = 292440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalAudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x0003F9EB File Offset: 0x0003DBEB
		public GlobalAudioManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x060075AC RID: 30124 RVA: 0x00227128 File Offset: 0x00225328
		// (set) Token: 0x060075AD RID: 30125 RVA: 0x0003F9F4 File Offset: 0x0003DBF4
		public unsafe static int MaxAudioSources
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GlobalAudioManager.NativeFieldInfoPtr_MaxAudioSources, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalAudioManager.NativeFieldInfoPtr_MaxAudioSources, (void*)(&value));
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x060075AE RID: 30126 RVA: 0x00227144 File Offset: 0x00225344
		// (set) Token: 0x060075AF RID: 30127 RVA: 0x0003FA02 File Offset: 0x0003DC02
		public unsafe static float MUSIC_FADE_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GlobalAudioManager.NativeFieldInfoPtr_MUSIC_FADE_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalAudioManager.NativeFieldInfoPtr_MUSIC_FADE_DURATION, (void*)(&value));
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x060075B0 RID: 30128 RVA: 0x00227160 File Offset: 0x00225360
		// (set) Token: 0x060075B1 RID: 30129 RVA: 0x0003FA10 File Offset: 0x0003DC10
		public unsafe static float REPEAT_AUDIO_PROTECTION_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GlobalAudioManager.NativeFieldInfoPtr_REPEAT_AUDIO_PROTECTION_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalAudioManager.NativeFieldInfoPtr_REPEAT_AUDIO_PROTECTION_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x060075B2 RID: 30130 RVA: 0x0022717C File Offset: 0x0022537C
		// (set) Token: 0x060075B3 RID: 30131 RVA: 0x0003FA1E File Offset: 0x0003DC1E
		public unsafe Dictionary<LoopedBGMPackage, GlobalAudioManager.WorkingLoopedSFX> looping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_looping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LoopedBGMPackage, GlobalAudioManager.WorkingLoopedSFX>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_looping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x060075B4 RID: 30132 RVA: 0x002271AC File Offset: 0x002253AC
		// (set) Token: 0x060075B5 RID: 30133 RVA: 0x0003FA3D File Offset: 0x0003DC3D
		public unsafe Stack<LoopedBGMPackage> m_WorkingGC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_m_WorkingGC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<LoopedBGMPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_m_WorkingGC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x060075B6 RID: 30134 RVA: 0x002271DC File Offset: 0x002253DC
		// (set) Token: 0x060075B7 RID: 30135 RVA: 0x0003FA5C File Offset: 0x0003DC5C
		public unsafe Stack<AudioSource> pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x060075B8 RID: 30136 RVA: 0x0022720C File Offset: 0x0022540C
		// (set) Token: 0x060075B9 RID: 30137 RVA: 0x0003FA7B File Offset: 0x0003DC7B
		public unsafe Dictionary<AudioSource, Coroutine> working
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_working);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioSource, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_working), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x0022723C File Offset: 0x0022543C
		// (set) Token: 0x060075BB RID: 30139 RVA: 0x0003FA9A File Offset: 0x0003DC9A
		public unsafe List<int> workingAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_workingAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_workingAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x060075BC RID: 30140 RVA: 0x0022726C File Offset: 0x0022546C
		// (set) Token: 0x060075BD RID: 30141 RVA: 0x0003FAB9 File Offset: 0x0003DCB9
		public unsafe AudioSource bgmStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_bgmStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_bgmStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x060075BE RID: 30142 RVA: 0x0022729C File Offset: 0x0022549C
		// (set) Token: 0x060075BF RID: 30143 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
		public unsafe AudioSource bgmLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_bgmLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_bgmLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x002272CC File Offset: 0x002254CC
		// (set) Token: 0x060075C1 RID: 30145 RVA: 0x0003FAF7 File Offset: 0x0003DCF7
		public unsafe float bufferedSFXVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_bufferedSFXVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_bufferedSFXVolume)) = value;
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x060075C2 RID: 30146 RVA: 0x002272F4 File Offset: 0x002254F4
		// (set) Token: 0x060075C3 RID: 30147 RVA: 0x0003FB12 File Offset: 0x0003DD12
		public unsafe int currentAudioSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_currentAudioSources);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_currentAudioSources)) = value;
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x060075C4 RID: 30148 RVA: 0x0022731C File Offset: 0x0022551C
		// (set) Token: 0x060075C5 RID: 30149 RVA: 0x0003FB2D File Offset: 0x0003DD2D
		public unsafe float internalBGMVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_internalBGMVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_internalBGMVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x060075C6 RID: 30150 RVA: 0x00227344 File Offset: 0x00225544
		// (set) Token: 0x060075C7 RID: 30151 RVA: 0x0003FB48 File Offset: 0x0003DD48
		public unsafe bool isOverrideBGMPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_isOverrideBGMPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_isOverrideBGMPlaying)) = value;
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x060075C8 RID: 30152 RVA: 0x0022736C File Offset: 0x0022556C
		// (set) Token: 0x060075C9 RID: 30153 RVA: 0x0003FB63 File Offset: 0x0003DD63
		public unsafe bool m_IsOverrideBGMStopping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_m_IsOverrideBGMStopping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_m_IsOverrideBGMStopping)) = value;
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x060075CA RID: 30154 RVA: 0x00227394 File Offset: 0x00225594
		// (set) Token: 0x060075CB RID: 30155 RVA: 0x0003FB7E File Offset: 0x0003DD7E
		public Nullable<float> m_PausedStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_m_PausedStartTime);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_m_PausedStartTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x060075CC RID: 30156 RVA: 0x002273C4 File Offset: 0x002255C4
		// (set) Token: 0x060075CD RID: 30157 RVA: 0x0003FBAC File Offset: 0x0003DDAC
		public unsafe Action onFadeMainBGMCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_onFadeMainBGMCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_onFadeMainBGMCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x002273F4 File Offset: 0x002255F4
		// (set) Token: 0x060075CF RID: 30159 RVA: 0x0003FBCB File Offset: 0x0003DDCB
		public unsafe Action onRestoreMainBGMCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_onRestoreMainBGMCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.NativeFieldInfoPtr_onRestoreMainBGMCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DE4 RID: 19940
		private static readonly IntPtr NativeFieldInfoPtr_MaxAudioSources;

		// Token: 0x04004DE5 RID: 19941
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_DURATION;

		// Token: 0x04004DE6 RID: 19942
		private static readonly IntPtr NativeFieldInfoPtr_REPEAT_AUDIO_PROTECTION_OFFSET;

		// Token: 0x04004DE7 RID: 19943
		private static readonly IntPtr NativeFieldInfoPtr_looping;

		// Token: 0x04004DE8 RID: 19944
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkingGC;

		// Token: 0x04004DE9 RID: 19945
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04004DEA RID: 19946
		private static readonly IntPtr NativeFieldInfoPtr_working;

		// Token: 0x04004DEB RID: 19947
		private static readonly IntPtr NativeFieldInfoPtr_workingAudio;

		// Token: 0x04004DEC RID: 19948
		private static readonly IntPtr NativeFieldInfoPtr_bgmStart;

		// Token: 0x04004DED RID: 19949
		private static readonly IntPtr NativeFieldInfoPtr_bgmLoop;

		// Token: 0x04004DEE RID: 19950
		private static readonly IntPtr NativeFieldInfoPtr_bufferedSFXVolume;

		// Token: 0x04004DEF RID: 19951
		private static readonly IntPtr NativeFieldInfoPtr_currentAudioSources;

		// Token: 0x04004DF0 RID: 19952
		private static readonly IntPtr NativeFieldInfoPtr_internalBGMVolumeMultiplier;

		// Token: 0x04004DF1 RID: 19953
		private static readonly IntPtr NativeFieldInfoPtr_isOverrideBGMPlaying;

		// Token: 0x04004DF2 RID: 19954
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOverrideBGMStopping;

		// Token: 0x04004DF3 RID: 19955
		private static readonly IntPtr NativeFieldInfoPtr_m_PausedStartTime;

		// Token: 0x04004DF4 RID: 19956
		private static readonly IntPtr NativeFieldInfoPtr_onFadeMainBGMCallback;

		// Token: 0x04004DF5 RID: 19957
		private static readonly IntPtr NativeFieldInfoPtr_onRestoreMainBGMCallback;

		// Token: 0x04004DF6 RID: 19958
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004DF7 RID: 19959
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x04004DF8 RID: 19960
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSFXVolume_Private_Void_Single_0;

		// Token: 0x04004DF9 RID: 19961
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBGMVolume_Private_Void_Single_0;

		// Token: 0x04004DFA RID: 19962
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemString_Public_String_0;

		// Token: 0x04004DFB RID: 19963
		private static readonly IntPtr NativeMethodInfoPtr_GetIdle_Private_AudioSource_byref_Boolean_0;

		// Token: 0x04004DFC RID: 19964
		private static readonly IntPtr NativeMethodInfoPtr_PlayLoopedSFX_Public_Void_Object_LoopedBGMPackage_0;

		// Token: 0x04004DFD RID: 19965
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_WorkingLoopedSFX_0;

		// Token: 0x04004DFE RID: 19966
		private static readonly IntPtr NativeMethodInfoPtr_SetSourceVolume_Private_Void_Single_AudioSource_AudioSource_0;

		// Token: 0x04004DFF RID: 19967
		private static readonly IntPtr NativeMethodInfoPtr_MuteAllLoopedSFX_Public_Void_0;

		// Token: 0x04004E00 RID: 19968
		private static readonly IntPtr NativeMethodInfoPtr_RestoreAllLoopedSFX_Public_Void_0;

		// Token: 0x04004E01 RID: 19969
		private static readonly IntPtr NativeMethodInfoPtr_SetAllLoopedSFXVolume_Private_Void_Single_0;

		// Token: 0x04004E02 RID: 19970
		private static readonly IntPtr NativeMethodInfoPtr_StopAllLoopedSFX_Public_Void_0;

		// Token: 0x04004E03 RID: 19971
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntry_Public_Void_Action_Action_0;

		// Token: 0x04004E04 RID: 19972
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_AudioClip_0;

		// Token: 0x04004E05 RID: 19973
		private static readonly IntPtr NativeMethodInfoPtr_PlayOverrideBGM_Public_ValueTuple_2_AudioSource_AudioSource_LoopedBGMPackage_0;

		// Token: 0x04004E06 RID: 19974
		private static readonly IntPtr NativeMethodInfoPtr_PlayOverrideBGM_Public_ValueTuple_2_AudioSource_AudioSource_LoopedBGMPackage_Double_Boolean_0;

		// Token: 0x04004E07 RID: 19975
		private static readonly IntPtr NativeMethodInfoPtr_PauseOverrideBGM_Public_Void_0;

		// Token: 0x04004E08 RID: 19976
		private static readonly IntPtr NativeMethodInfoPtr_ResumeOverrideBGM_Public_Void_Double_0;

		// Token: 0x04004E09 RID: 19977
		private static readonly IntPtr NativeMethodInfoPtr_StopOverrideBGM_Public_Void_Action_0;

		// Token: 0x04004E0A RID: 19978
		private static readonly IntPtr NativeMethodInfoPtr_StopOverrideBGMInternal_Private_Void_Action_Boolean_0;

		// Token: 0x04004E0B RID: 19979
		private static readonly IntPtr NativeMethodInfoPtr_FadeOverrideBGM_Public_Void_0;

		// Token: 0x04004E0C RID: 19980
		private static readonly IntPtr NativeMethodInfoPtr_RestoreOverrideBGM_Public_Void_0;

		// Token: 0x04004E0D RID: 19981
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideBGMMultiplier_Private_Void_Single_0;

		// Token: 0x04004E0E RID: 19982
		private static readonly IntPtr NativeMethodInfoPtr_FadeOverrideBGMInternal_Private_Void_FadeType_Action_0;

		// Token: 0x04004E0F RID: 19983
		private static readonly IntPtr NativeMethodInfoPtr_FadeAudioSource_Private_Void_Object_FadeType_Single_Action_1_Single_Action_0;

		// Token: 0x04004E10 RID: 19984
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Private_Int32_Object_0;

		// Token: 0x04004E11 RID: 19985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F78 RID: 3960
		[Serializable]
		public sealed class DelayAudioClip : ValueType
		{
			// Token: 0x060112FD RID: 70397 RVA: 0x003F6620 File Offset: 0x003F4820
			// Note: this type is marked as 'beforefieldinit'.
			static DelayAudioClip()
			{
				Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "DelayAudioClip");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr);
				GlobalAudioManager.DelayAudioClip.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, "audioClip");
				GlobalAudioManager.DelayAudioClip.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, "delay");
			}

			// Token: 0x060112FE RID: 70398 RVA: 0x000956A4 File Offset: 0x000938A4
			public DelayAudioClip(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060112FF RID: 70399 RVA: 0x000956AD File Offset: 0x000938AD
			public DelayAudioClip() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr))
			{
			}

			// Token: 0x17005952 RID: 22866
			// (get) Token: 0x06011300 RID: 70400 RVA: 0x003F6674 File Offset: 0x003F4874
			// (set) Token: 0x06011301 RID: 70401 RVA: 0x000956BF File Offset: 0x000938BF
			public unsafe AudioClip audioClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.DelayAudioClip.NativeFieldInfoPtr_audioClip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.DelayAudioClip.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005953 RID: 22867
			// (get) Token: 0x06011302 RID: 70402 RVA: 0x003F66A4 File Offset: 0x003F48A4
			// (set) Token: 0x06011303 RID: 70403 RVA: 0x000956DE File Offset: 0x000938DE
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.DelayAudioClip.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.DelayAudioClip.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x0400ADD1 RID: 44497
			private static readonly IntPtr NativeFieldInfoPtr_audioClip;

			// Token: 0x0400ADD2 RID: 44498
			private static readonly IntPtr NativeFieldInfoPtr_delay;
		}

		// Token: 0x02000F79 RID: 3961
		public enum FadeType
		{
			// Token: 0x0400ADD4 RID: 44500
			FadeIn,
			// Token: 0x0400ADD5 RID: 44501
			FadeOut
		}

		// Token: 0x02000F7A RID: 3962
		public class WorkingLoopedSFX : Il2CppSystem.Object
		{
			// Token: 0x06011304 RID: 70404 RVA: 0x003F66CC File Offset: 0x003F48CC
			// Note: this type is marked as 'beforefieldinit'.
			static WorkingLoopedSFX()
			{
				Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "WorkingLoopedSFX");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr);
				GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__Identifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, "<Identifier>k__BackingField");
				GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__ComponentA_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, "<ComponentA>k__BackingField");
				GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__ComponentB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, "<ComponentB>k__BackingField");
				GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__AIsTemp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, "<AIsTemp>k__BackingField");
				GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__BIsTemp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, "<BIsTemp>k__BackingField");
				GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__BgmPkg_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, "<BgmPkg>k__BackingField");
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr__ctor_Private_Void_AudioSource_AudioSource_Boolean_Boolean_Object_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687431);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_Identifier_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687432);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_ComponentA_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687433);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_ComponentB_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687434);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_AIsTemp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687435);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_BIsTemp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687436);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_BgmPkg_Public_get_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687437);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687438);
				GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_Generate_Public_Static_WorkingLoopedSFX_GlobalAudioManager_Object_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr, 100687439);
			}

			// Token: 0x06011305 RID: 70405 RVA: 0x003F6824 File Offset: 0x003F4A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291698, XrefRangeEnd = 291703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkingLoopedSFX(AudioSource componentA, AudioSource componentB, bool aIsTemp, bool bIsTemp, UnityEngine.Object identifier, LoopedBGMPackage bgmPkg) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.WorkingLoopedSFX>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentA);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(componentB);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aIsTemp;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsTemp;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identifier);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgmPkg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr__ctor_Private_Void_AudioSource_AudioSource_Boolean_Boolean_Object_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700595A RID: 22874
			// (get) Token: 0x06011306 RID: 70406 RVA: 0x003F68C4 File Offset: 0x003F4AC4
			public unsafe UnityEngine.Object Identifier
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_Identifier_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700595B RID: 22875
			// (get) Token: 0x06011307 RID: 70407 RVA: 0x003F6904 File Offset: 0x003F4B04
			public unsafe AudioSource ComponentA
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_ComponentA_Public_get_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
				}
			}

			// Token: 0x1700595C RID: 22876
			// (get) Token: 0x06011308 RID: 70408 RVA: 0x003F6944 File Offset: 0x003F4B44
			public unsafe AudioSource ComponentB
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_ComponentB_Public_get_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
				}
			}

			// Token: 0x1700595D RID: 22877
			// (get) Token: 0x06011309 RID: 70409 RVA: 0x003F6984 File Offset: 0x003F4B84
			public unsafe bool AIsTemp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_AIsTemp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700595E RID: 22878
			// (get) Token: 0x0601130A RID: 70410 RVA: 0x003F69C0 File Offset: 0x003F4BC0
			public unsafe bool BIsTemp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_BIsTemp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700595F RID: 22879
			// (get) Token: 0x0601130B RID: 70411 RVA: 0x003F69FC File Offset: 0x003F4BFC
			public unsafe LoopedBGMPackage BgmPkg
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_get_BgmPkg_Public_get_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr3) : null;
				}
			}

			// Token: 0x0601130C RID: 70412 RVA: 0x003F6A3C File Offset: 0x003F4C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291703, XrefRangeEnd = 291726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601130D RID: 70413 RVA: 0x003F6A80 File Offset: 0x003F4C80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 291744, RefRangeEnd = 291745, XrefRangeStart = 291726, XrefRangeEnd = 291744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static GlobalAudioManager.WorkingLoopedSFX Generate(GlobalAudioManager manager, UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identifier);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loopedBGMPackage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.WorkingLoopedSFX.NativeMethodInfoPtr_Generate_Public_Static_WorkingLoopedSFX_GlobalAudioManager_Object_LoopedBGMPackage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager.WorkingLoopedSFX>(intPtr3) : null;
			}

			// Token: 0x0601130E RID: 70414 RVA: 0x000956F9 File Offset: 0x000938F9
			public WorkingLoopedSFX(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005954 RID: 22868
			// (get) Token: 0x0601130F RID: 70415 RVA: 0x003F6AE8 File Offset: 0x003F4CE8
			// (set) Token: 0x06011310 RID: 70416 RVA: 0x00095702 File Offset: 0x00093902
			public unsafe UnityEngine.Object _Identifier_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__Identifier_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__Identifier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005955 RID: 22869
			// (get) Token: 0x06011311 RID: 70417 RVA: 0x003F6B18 File Offset: 0x003F4D18
			// (set) Token: 0x06011312 RID: 70418 RVA: 0x00095721 File Offset: 0x00093921
			public unsafe AudioSource _ComponentA_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__ComponentA_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__ComponentA_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005956 RID: 22870
			// (get) Token: 0x06011313 RID: 70419 RVA: 0x003F6B48 File Offset: 0x003F4D48
			// (set) Token: 0x06011314 RID: 70420 RVA: 0x00095740 File Offset: 0x00093940
			public unsafe AudioSource _ComponentB_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__ComponentB_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__ComponentB_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005957 RID: 22871
			// (get) Token: 0x06011315 RID: 70421 RVA: 0x003F6B78 File Offset: 0x003F4D78
			// (set) Token: 0x06011316 RID: 70422 RVA: 0x0009575F File Offset: 0x0009395F
			public unsafe bool _AIsTemp_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__AIsTemp_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__AIsTemp_k__BackingField)) = value;
				}
			}

			// Token: 0x17005958 RID: 22872
			// (get) Token: 0x06011317 RID: 70423 RVA: 0x003F6BA0 File Offset: 0x003F4DA0
			// (set) Token: 0x06011318 RID: 70424 RVA: 0x0009577A File Offset: 0x0009397A
			public unsafe bool _BIsTemp_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__BIsTemp_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__BIsTemp_k__BackingField)) = value;
				}
			}

			// Token: 0x17005959 RID: 22873
			// (get) Token: 0x06011319 RID: 70425 RVA: 0x003F6BC8 File Offset: 0x003F4DC8
			// (set) Token: 0x0601131A RID: 70426 RVA: 0x00095795 File Offset: 0x00093995
			public unsafe LoopedBGMPackage _BgmPkg_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__BgmPkg_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.WorkingLoopedSFX.NativeFieldInfoPtr__BgmPkg_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADD6 RID: 44502
			private static readonly IntPtr NativeFieldInfoPtr__Identifier_k__BackingField;

			// Token: 0x0400ADD7 RID: 44503
			private static readonly IntPtr NativeFieldInfoPtr__ComponentA_k__BackingField;

			// Token: 0x0400ADD8 RID: 44504
			private static readonly IntPtr NativeFieldInfoPtr__ComponentB_k__BackingField;

			// Token: 0x0400ADD9 RID: 44505
			private static readonly IntPtr NativeFieldInfoPtr__AIsTemp_k__BackingField;

			// Token: 0x0400ADDA RID: 44506
			private static readonly IntPtr NativeFieldInfoPtr__BIsTemp_k__BackingField;

			// Token: 0x0400ADDB RID: 44507
			private static readonly IntPtr NativeFieldInfoPtr__BgmPkg_k__BackingField;

			// Token: 0x0400ADDC RID: 44508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_AudioSource_AudioSource_Boolean_Boolean_Object_LoopedBGMPackage_0;

			// Token: 0x0400ADDD RID: 44509
			private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_Object_0;

			// Token: 0x0400ADDE RID: 44510
			private static readonly IntPtr NativeMethodInfoPtr_get_ComponentA_Public_get_AudioSource_0;

			// Token: 0x0400ADDF RID: 44511
			private static readonly IntPtr NativeMethodInfoPtr_get_ComponentB_Public_get_AudioSource_0;

			// Token: 0x0400ADE0 RID: 44512
			private static readonly IntPtr NativeMethodInfoPtr_get_AIsTemp_Public_get_Boolean_0;

			// Token: 0x0400ADE1 RID: 44513
			private static readonly IntPtr NativeMethodInfoPtr_get_BIsTemp_Public_get_Boolean_0;

			// Token: 0x0400ADE2 RID: 44514
			private static readonly IntPtr NativeMethodInfoPtr_get_BgmPkg_Public_get_LoopedBGMPackage_0;

			// Token: 0x0400ADE3 RID: 44515
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0400ADE4 RID: 44516
			private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Static_WorkingLoopedSFX_GlobalAudioManager_Object_LoopedBGMPackage_0;
		}

		// Token: 0x02000F7B RID: 3963
		[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0601131B RID: 70427 RVA: 0x003F6BF8 File Offset: 0x003F4DF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass20_0>.NativeClassPtr);
				GlobalAudioManager.__c__DisplayClass20_0.NativeFieldInfoPtr_targetVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass20_0>.NativeClassPtr, "targetVolume");
				GlobalAudioManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass20_0>.NativeClassPtr, 100687440);
				GlobalAudioManager.__c__DisplayClass20_0.NativeMethodInfoPtr__UpdateSFXVolume_b__0_Internal_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass20_0>.NativeClassPtr, 100687441);
			}

			// Token: 0x0601131C RID: 70428 RVA: 0x003F6C60 File Offset: 0x003F4E60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601131D RID: 70429 RVA: 0x003F6C9C File Offset: 0x003F4E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291745, XrefRangeEnd = 291747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateSFXVolume_b__0(AudioSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass20_0.NativeMethodInfoPtr__UpdateSFXVolume_b__0_Internal_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601131E RID: 70430 RVA: 0x000957B4 File Offset: 0x000939B4
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005960 RID: 22880
			// (get) Token: 0x0601131F RID: 70431 RVA: 0x003F6CE0 File Offset: 0x003F4EE0
			// (set) Token: 0x06011320 RID: 70432 RVA: 0x000957BD File Offset: 0x000939BD
			public unsafe float targetVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass20_0.NativeFieldInfoPtr_targetVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass20_0.NativeFieldInfoPtr_targetVolume)) = value;
				}
			}

			// Token: 0x0400ADE5 RID: 44517
			private static readonly IntPtr NativeFieldInfoPtr_targetVolume;

			// Token: 0x0400ADE6 RID: 44518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADE7 RID: 44519
			private static readonly IntPtr NativeMethodInfoPtr__UpdateSFXVolume_b__0_Internal_Void_AudioSource_0;
		}

		// Token: 0x02000F7C RID: 3964
		[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06011321 RID: 70433 RVA: 0x003F6D08 File Offset: 0x003F4F08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr);
				GlobalAudioManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr, "<>9");
				GlobalAudioManager.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr, "<>9__22_0");
				GlobalAudioManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr, 100687443);
				GlobalAudioManager.__c.NativeMethodInfoPtr__GetSystemString_b__22_0_Internal_String_KeyValuePair_2_LoopedBGMPackage_WorkingLoopedSFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr, 100687444);
			}

			// Token: 0x06011322 RID: 70434 RVA: 0x003F6D84 File Offset: 0x003F4F84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011323 RID: 70435 RVA: 0x003F6DC0 File Offset: 0x003F4FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291747, XrefRangeEnd = 291750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetSystemString_b__22_0(KeyValuePair<LoopedBGMPackage, GlobalAudioManager.WorkingLoopedSFX> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c.NativeMethodInfoPtr__GetSystemString_b__22_0_Internal_String_KeyValuePair_2_LoopedBGMPackage_WorkingLoopedSFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06011324 RID: 70436 RVA: 0x000957D8 File Offset: 0x000939D8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005961 RID: 22881
			// (get) Token: 0x06011325 RID: 70437 RVA: 0x003F6E10 File Offset: 0x003F5010
			// (set) Token: 0x06011326 RID: 70438 RVA: 0x000957E1 File Offset: 0x000939E1
			public unsafe static GlobalAudioManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalAudioManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalAudioManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005962 RID: 22882
			// (get) Token: 0x06011327 RID: 70439 RVA: 0x003F6E38 File Offset: 0x003F5038
			// (set) Token: 0x06011328 RID: 70440 RVA: 0x000957F3 File Offset: 0x000939F3
			public unsafe static Func<KeyValuePair<LoopedBGMPackage, GlobalAudioManager.WorkingLoopedSFX>, string> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalAudioManager.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LoopedBGMPackage, GlobalAudioManager.WorkingLoopedSFX>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalAudioManager.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADE8 RID: 44520
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400ADE9 RID: 44521
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400ADEA RID: 44522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADEB RID: 44523
			private static readonly IntPtr NativeMethodInfoPtr__GetSystemString_b__22_0_Internal_String_KeyValuePair_2_LoopedBGMPackage_WorkingLoopedSFX_0;
		}

		// Token: 0x02000F7D RID: 3965
		[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x06011329 RID: 70441 RVA: 0x003F6E60 File Offset: 0x003F5060
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr);
				GlobalAudioManager.__c__DisplayClass25_0.NativeFieldInfoPtr_workingLoopedSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr, "workingLoopedSFX");
				GlobalAudioManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				GlobalAudioManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr, 100687445);
				GlobalAudioManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr, 100687446);
				GlobalAudioManager.__c__DisplayClass25_0.NativeMethodInfoPtr__Release_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr, 100687447);
			}

			// Token: 0x0601132A RID: 70442 RVA: 0x003F6EF0 File Offset: 0x003F50F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601132B RID: 70443 RVA: 0x003F6F2C File Offset: 0x003F512C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291750, XrefRangeEnd = 291770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601132C RID: 70444 RVA: 0x003F6F60 File Offset: 0x003F5160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291770, XrefRangeEnd = 291773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Release_b__1(float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass25_0.NativeMethodInfoPtr__Release_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601132D RID: 70445 RVA: 0x00095805 File Offset: 0x00093A05
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005963 RID: 22883
			// (get) Token: 0x0601132E RID: 70446 RVA: 0x003F6FA0 File Offset: 0x003F51A0
			// (set) Token: 0x0601132F RID: 70447 RVA: 0x0009580E File Offset: 0x00093A0E
			public unsafe GlobalAudioManager.WorkingLoopedSFX workingLoopedSFX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass25_0.NativeFieldInfoPtr_workingLoopedSFX);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager.WorkingLoopedSFX>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass25_0.NativeFieldInfoPtr_workingLoopedSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005964 RID: 22884
			// (get) Token: 0x06011330 RID: 70448 RVA: 0x003F6FD0 File Offset: 0x003F51D0
			// (set) Token: 0x06011331 RID: 70449 RVA: 0x0009582D File Offset: 0x00093A2D
			public unsafe GlobalAudioManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADEC RID: 44524
			private static readonly IntPtr NativeFieldInfoPtr_workingLoopedSFX;

			// Token: 0x0400ADED RID: 44525
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ADEE RID: 44526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADEF RID: 44527
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400ADF0 RID: 44528
			private static readonly IntPtr NativeMethodInfoPtr__Release_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000F7E RID: 3966
		[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x06011332 RID: 70450 RVA: 0x003F7000 File Offset: 0x003F5200
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr);
				GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "component");
				GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "audioClip");
				GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_isTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "isTemp");
				GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "hash");
				GlobalAudioManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, 100687448);
				GlobalAudioManager.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, 100687449);
				GlobalAudioManager.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, 100687450);
			}

			// Token: 0x06011333 RID: 70451 RVA: 0x003F70CC File Offset: 0x003F52CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011334 RID: 70452 RVA: 0x003F7108 File Offset: 0x003F5308
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 291812, RefRangeEnd = 291813, XrefRangeStart = 291807, XrefRangeEnd = 291812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06011335 RID: 70453 RVA: 0x003F7148 File Offset: 0x003F5348
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 291818, RefRangeEnd = 291819, XrefRangeStart = 291813, XrefRangeEnd = 291818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06011336 RID: 70454 RVA: 0x0009584C File Offset: 0x00093A4C
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005965 RID: 22885
			// (get) Token: 0x06011337 RID: 70455 RVA: 0x003F7188 File Offset: 0x003F5388
			// (set) Token: 0x06011338 RID: 70456 RVA: 0x00095855 File Offset: 0x00093A55
			public unsafe AudioSource component
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_component);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_component), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005966 RID: 22886
			// (get) Token: 0x06011339 RID: 70457 RVA: 0x003F71B8 File Offset: 0x003F53B8
			// (set) Token: 0x0601133A RID: 70458 RVA: 0x00095874 File Offset: 0x00093A74
			public unsafe AudioClip audioClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_audioClip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005967 RID: 22887
			// (get) Token: 0x0601133B RID: 70459 RVA: 0x003F71E8 File Offset: 0x003F53E8
			// (set) Token: 0x0601133C RID: 70460 RVA: 0x00095893 File Offset: 0x00093A93
			public unsafe GlobalAudioManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005968 RID: 22888
			// (get) Token: 0x0601133D RID: 70461 RVA: 0x003F7218 File Offset: 0x003F5418
			// (set) Token: 0x0601133E RID: 70462 RVA: 0x000958B2 File Offset: 0x00093AB2
			public unsafe bool isTemp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_isTemp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_isTemp)) = value;
				}
			}

			// Token: 0x17005969 RID: 22889
			// (get) Token: 0x0601133F RID: 70463 RVA: 0x003F7240 File Offset: 0x003F5440
			// (set) Token: 0x06011340 RID: 70464 RVA: 0x000958CD File Offset: 0x00093ACD
			public unsafe int hash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_hash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.NativeFieldInfoPtr_hash)) = value;
				}
			}

			// Token: 0x0400ADF1 RID: 44529
			private static readonly IntPtr NativeFieldInfoPtr_component;

			// Token: 0x0400ADF2 RID: 44530
			private static readonly IntPtr NativeFieldInfoPtr_audioClip;

			// Token: 0x0400ADF3 RID: 44531
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ADF4 RID: 44532
			private static readonly IntPtr NativeFieldInfoPtr_isTemp;

			// Token: 0x0400ADF5 RID: 44533
			private static readonly IntPtr NativeFieldInfoPtr_hash;

			// Token: 0x0400ADF6 RID: 44534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADF7 RID: 44535
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x0400ADF8 RID: 44536
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_1;

			// Token: 0x020010DD RID: 4317
			[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass32_0+<<Play>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x0601241B RID: 74779 RVA: 0x00429270 File Offset: 0x00427470
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "<<Play>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100687451);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100687452);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100687453);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100687454);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100687455);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100687456);
				}

				// Token: 0x0601241C RID: 74780 RVA: 0x00429350 File Offset: 0x00427550
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601241D RID: 74781 RVA: 0x00429398 File Offset: 0x00427598
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601241E RID: 74782 RVA: 0x004293CC File Offset: 0x004275CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291773, XrefRangeEnd = 291786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F7D RID: 24445
				// (get) Token: 0x0601241F RID: 74783 RVA: 0x00429408 File Offset: 0x00427608
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012420 RID: 74784 RVA: 0x00429448 File Offset: 0x00427648
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291786, XrefRangeEnd = 291792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F7E RID: 24446
				// (get) Token: 0x06012421 RID: 74785 RVA: 0x0042947C File Offset: 0x0042767C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012422 RID: 74786 RVA: 0x0009E4F1 File Offset: 0x0009C6F1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F7A RID: 24442
				// (get) Token: 0x06012423 RID: 74787 RVA: 0x004294BC File Offset: 0x004276BC
				// (set) Token: 0x06012424 RID: 74788 RVA: 0x0009E4FA File Offset: 0x0009C6FA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F7B RID: 24443
				// (get) Token: 0x06012425 RID: 74789 RVA: 0x004294E4 File Offset: 0x004276E4
				// (set) Token: 0x06012426 RID: 74790 RVA: 0x0009E515 File Offset: 0x0009C715
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F7C RID: 24444
				// (get) Token: 0x06012427 RID: 74791 RVA: 0x00429514 File Offset: 0x00427714
				// (set) Token: 0x06012428 RID: 74792 RVA: 0x0009E534 File Offset: 0x0009C734
				public unsafe GlobalAudioManager.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B915 RID: 47381
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B916 RID: 47382
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B917 RID: 47383
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B918 RID: 47384
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B919 RID: 47385
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B91A RID: 47386
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B91B RID: 47387
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B91C RID: 47388
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B91D RID: 47389
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x020010DE RID: 4318
			[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass32_0+<<Play>g__Lock|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06012429 RID: 74793 RVA: 0x00429544 File Offset: 0x00427744
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0>.NativeClassPtr, "<<Play>g__Lock|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100687457);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100687458);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100687459);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100687460);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100687461);
					GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100687462);
				}

				// Token: 0x0601242A RID: 74794 RVA: 0x00429624 File Offset: 0x00427824
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601242B RID: 74795 RVA: 0x0042966C File Offset: 0x0042786C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601242C RID: 74796 RVA: 0x004296A0 File Offset: 0x004278A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291792, XrefRangeEnd = 291801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F82 RID: 24450
				// (get) Token: 0x0601242D RID: 74797 RVA: 0x004296DC File Offset: 0x004278DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601242E RID: 74798 RVA: 0x0042971C File Offset: 0x0042791C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291801, XrefRangeEnd = 291807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F83 RID: 24451
				// (get) Token: 0x0601242F RID: 74799 RVA: 0x00429750 File Offset: 0x00427950
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012430 RID: 74800 RVA: 0x0009E553 File Offset: 0x0009C753
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F7F RID: 24447
				// (get) Token: 0x06012431 RID: 74801 RVA: 0x00429790 File Offset: 0x00427990
				// (set) Token: 0x06012432 RID: 74802 RVA: 0x0009E55C File Offset: 0x0009C75C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F80 RID: 24448
				// (get) Token: 0x06012433 RID: 74803 RVA: 0x004297B8 File Offset: 0x004279B8
				// (set) Token: 0x06012434 RID: 74804 RVA: 0x0009E577 File Offset: 0x0009C777
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F81 RID: 24449
				// (get) Token: 0x06012435 RID: 74805 RVA: 0x004297E8 File Offset: 0x004279E8
				// (set) Token: 0x06012436 RID: 74806 RVA: 0x0009E596 File Offset: 0x0009C796
				public unsafe GlobalAudioManager.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B91E RID: 47390
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B91F RID: 47391
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B920 RID: 47392
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B921 RID: 47393
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B922 RID: 47394
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B923 RID: 47395
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B924 RID: 47396
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B925 RID: 47397
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B926 RID: 47398
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000F7F RID: 3967
		[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x06011341 RID: 70465 RVA: 0x003F7268 File Offset: 0x003F5468
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr);
				GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr_bgmPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr, "bgmPackage");
				GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr, "delay");
				GlobalAudioManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr, 100687463);
				GlobalAudioManager.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr, 100687464);
			}

			// Token: 0x06011342 RID: 70466 RVA: 0x003F72F8 File Offset: 0x003F54F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011343 RID: 70467 RVA: 0x003F7334 File Offset: 0x003F5534
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 291833, RefRangeEnd = 291834, XrefRangeStart = 291819, XrefRangeEnd = 291833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011344 RID: 70468 RVA: 0x000958E8 File Offset: 0x00093AE8
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700596A RID: 22890
			// (get) Token: 0x06011345 RID: 70469 RVA: 0x003F7368 File Offset: 0x003F5568
			// (set) Token: 0x06011346 RID: 70470 RVA: 0x000958F1 File Offset: 0x00093AF1
			public unsafe GlobalAudioManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700596B RID: 22891
			// (get) Token: 0x06011347 RID: 70471 RVA: 0x003F7398 File Offset: 0x003F5598
			// (set) Token: 0x06011348 RID: 70472 RVA: 0x00095910 File Offset: 0x00093B10
			public unsafe LoopedBGMPackage bgmPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr_bgmPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr_bgmPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700596C RID: 22892
			// (get) Token: 0x06011349 RID: 70473 RVA: 0x003F73C8 File Offset: 0x003F55C8
			// (set) Token: 0x0601134A RID: 70474 RVA: 0x0009592F File Offset: 0x00093B2F
			public unsafe double delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass34_0.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x0400ADF9 RID: 44537
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ADFA RID: 44538
			private static readonly IntPtr NativeFieldInfoPtr_bgmPackage;

			// Token: 0x0400ADFB RID: 44539
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400ADFC RID: 44540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADFD RID: 44541
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000F80 RID: 3968
		[ObfuscatedName("Common.Audio.GlobalAudioManager+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0601134B RID: 70475 RVA: 0x003F73F0 File Offset: 0x003F55F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalAudioManager>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr);
				GlobalAudioManager.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				GlobalAudioManager.__c__DisplayClass38_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr, "onFinish");
				GlobalAudioManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr, 100687465);
				GlobalAudioManager.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr, 100687466);
			}

			// Token: 0x0601134C RID: 70476 RVA: 0x003F746C File Offset: 0x003F566C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioManager.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601134D RID: 70477 RVA: 0x003F74A8 File Offset: 0x003F56A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291834, XrefRangeEnd = 291838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAudioManager.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601134E RID: 70478 RVA: 0x0009594A File Offset: 0x00093B4A
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700596D RID: 22893
			// (get) Token: 0x0601134F RID: 70479 RVA: 0x003F74DC File Offset: 0x003F56DC
			// (set) Token: 0x06011350 RID: 70480 RVA: 0x00095953 File Offset: 0x00093B53
			public unsafe GlobalAudioManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalAudioManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700596E RID: 22894
			// (get) Token: 0x06011351 RID: 70481 RVA: 0x003F750C File Offset: 0x003F570C
			// (set) Token: 0x06011352 RID: 70482 RVA: 0x00095972 File Offset: 0x00093B72
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass38_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalAudioManager.__c__DisplayClass38_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADFE RID: 44542
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ADFF RID: 44543
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400AE00 RID: 44544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE01 RID: 44545
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
