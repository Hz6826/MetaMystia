using System;
using DEYU.Singletons;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.MusicUtility
{
	// Token: 0x020001A2 RID: 418
	public class MusicManager : MonoSingleton<MusicManager>
	{
		// Token: 0x06002DE4 RID: 11748 RVA: 0x00137350 File Offset: 0x00135550
		// Note: this type is marked as 'beforefieldinit'.
		static MusicManager()
		{
			Il2CppClassPointerStore<MusicManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.MusicUtility", "MusicManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager>.NativeClassPtr);
			MusicManager.NativeFieldInfoPtr_MUSIC_START_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "MUSIC_START_OFFSET");
			MusicManager.NativeFieldInfoPtr_midiNoteOpenPreparationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "midiNoteOpenPreparationTime");
			MusicManager.NativeFieldInfoPtr_midiNotePreValidTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "midiNotePreValidTime");
			MusicManager.NativeFieldInfoPtr_midiNotePostValidTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "midiNotePostValidTime");
			MusicManager.NativeFieldInfoPtr_midiNoteHoldEarlyEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "midiNoteHoldEarlyEndTime");
			MusicManager.NativeFieldInfoPtr_maxQTEDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "maxQTEDuration");
			MusicManager.NativeFieldInfoPtr_musicSwitchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "musicSwitchTime");
			MusicManager.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "musicVolume");
			MusicManager.NativeFieldInfoPtr_musicVolumeWhenMidi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "musicVolumeWhenMidi");
			MusicManager.NativeFieldInfoPtr_midiNoteVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "midiNoteVolume");
			MusicManager.NativeFieldInfoPtr_onMusicChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "onMusicChange");
			MusicManager.NativeFieldInfoPtr_onMusicVolumeChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "onMusicVolumeChange");
			MusicManager.NativeFieldInfoPtr_channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "channels");
			MusicManager.NativeFieldInfoPtr_clipLoopTotalMiliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "clipLoopTotalMiliseconds");
			MusicManager.NativeFieldInfoPtr_currentChannelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "currentChannelIndex");
			MusicManager.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "entry");
			MusicManager.NativeFieldInfoPtr_isChannelSwitching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "isChannelSwitching");
			MusicManager.NativeFieldInfoPtr_onMusicTransitionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "onMusicTransitionSource");
			MusicManager.NativeFieldInfoPtr_requestedChannelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "requestedChannelIndex");
			MusicManager.NativeFieldInfoPtr_streamingSwitchPointList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "streamingSwitchPointList");
			MusicManager.NativeFieldInfoPtr__MidiSegmentMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<MidiSegmentMultiplier>k__BackingField");
			MusicManager.NativeFieldInfoPtr__IsMidiOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<IsMidiOn>k__BackingField");
			MusicManager.NativeFieldInfoPtr__PlaybackTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<PlaybackTime>k__BackingField");
			MusicManager.NativeFieldInfoPtr__MusicSystemBeginPlayMiliseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<MusicSystemBeginPlayMiliseconds>k__BackingField");
			MusicManager.NativeMethodInfoPtr_get_MidiSegmentMultiplier_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671366);
			MusicManager.NativeMethodInfoPtr_set_MidiSegmentMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671367);
			MusicManager.NativeMethodInfoPtr_get_MidiSegmentLength_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671368);
			MusicManager.NativeMethodInfoPtr_get_IsMidiOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671369);
			MusicManager.NativeMethodInfoPtr_set_IsMidiOn_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671370);
			MusicManager.NativeMethodInfoPtr_get_PlaybackTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671371);
			MusicManager.NativeMethodInfoPtr_set_PlaybackTime_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671372);
			MusicManager.NativeMethodInfoPtr_get_MusicSystemBeginPlayMiliseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671373);
			MusicManager.NativeMethodInfoPtr_set_MusicSystemBeginPlayMiliseconds_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671374);
			MusicManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671375);
			MusicManager.NativeMethodInfoPtr_Initialize_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671376);
			MusicManager.NativeMethodInfoPtr_FadeMainBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671377);
			MusicManager.NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671378);
			MusicManager.NativeMethodInfoPtr_UpdateMusicVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671379);
			MusicManager.NativeMethodInfoPtr_RequestChannelSwitch_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671380);
			MusicManager.NativeMethodInfoPtr_SwitchChannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671381);
			MusicManager.NativeMethodInfoPtr_OnSwitching_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671382);
			MusicManager.NativeMethodInfoPtr_StopMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671383);
			MusicManager.NativeMethodInfoPtr_GetMidiNotes_Public_Il2CppStructArray_1_SingleNote_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671384);
			MusicManager.NativeMethodInfoPtr_SwitchBackToMain_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671385);
			MusicManager.NativeMethodInfoPtr_FetchNotes_Public_Il2CppStructArray_1_SingleNote_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671386);
			MusicManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671387);
			MusicManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671388);
			MusicManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671389);
			MusicManager.NativeMethodInfoPtr__Initialize_b__39_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100671390);
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x00137754 File Offset: 0x00135954
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x00137790 File Offset: 0x00135990
		public unsafe float MidiSegmentMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_get_MidiSegmentMultiplier_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_set_MidiSegmentMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x001377D0 File Offset: 0x001359D0
		public unsafe long MidiSegmentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_get_MidiSegmentLength_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x0013780C File Offset: 0x00135A0C
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x00137848 File Offset: 0x00135A48
		public unsafe bool IsMidiOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_get_IsMidiOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_set_IsMidiOn_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x00137888 File Offset: 0x00135A88
		// (set) Token: 0x06002DEB RID: 11755 RVA: 0x001378C4 File Offset: 0x00135AC4
		public unsafe long PlaybackTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_get_PlaybackTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_set_PlaybackTime_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x00137904 File Offset: 0x00135B04
		// (set) Token: 0x06002DED RID: 11757 RVA: 0x00137940 File Offset: 0x00135B40
		public unsafe long MusicSystemBeginPlayMiliseconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_get_MusicSystemBeginPlayMiliseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_set_MusicSystemBeginPlayMiliseconds_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x00137980 File Offset: 0x00135B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103211, XrefRangeEnd = 103234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x001379B4 File Offset: 0x00135BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103313, RefRangeEnd = 103314, XrefRangeStart = 103234, XrefRangeEnd = 103313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_Initialize_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x001379F4 File Offset: 0x00135BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103333, RefRangeEnd = 103334, XrefRangeStart = 103314, XrefRangeEnd = 103333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeMainBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_FadeMainBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00137A28 File Offset: 0x00135C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103334, XrefRangeEnd = 103353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreMainBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00137A5C File Offset: 0x00135C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103353, XrefRangeEnd = 103355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicVolume(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_UpdateMusicVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00137A9C File Offset: 0x00135C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103355, RefRangeEnd = 103356, XrefRangeStart = 103355, XrefRangeEnd = 103355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestChannelSwitch(int requestedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_RequestChannelSwitch_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00137ADC File Offset: 0x00135CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103356, XrefRangeEnd = 103365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchChannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_SwitchChannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00137B10 File Offset: 0x00135D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103365, XrefRangeEnd = 103370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnSwitching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_OnSwitching_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00137B50 File Offset: 0x00135D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103370, XrefRangeEnd = 103379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_StopMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00137B84 File Offset: 0x00135D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103379, XrefRangeEnd = 103391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> GetMidiNotes(float QTEMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref QTEMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_GetMidiNotes_Public_Il2CppStructArray_1_SingleNote_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr3) : null;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00137BD0 File Offset: 0x00135DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103400, RefRangeEnd = 103401, XrefRangeStart = 103391, XrefRangeEnd = 103400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchBackToMain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_SwitchBackToMain_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00137C04 File Offset: 0x00135E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103401, XrefRangeEnd = 103407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> FetchNotes(long startTime, long endTime, long preparationOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preparationOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_FetchNotes_Public_Il2CppStructArray_1_SingleNote_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr3) : null;
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00137C6C File Offset: 0x00135E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103407, XrefRangeEnd = 103413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00137CA8 File Offset: 0x00135EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103413, XrefRangeEnd = 103419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00137CE4 File Offset: 0x00135EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103419, XrefRangeEnd = 103430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00137D20 File Offset: 0x00135F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103430, XrefRangeEnd = 103456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__39_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr__Initialize_b__39_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x0001A85C File Offset: 0x00018A5C
		public MusicManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x00137D54 File Offset: 0x00135F54
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x0001A865 File Offset: 0x00018A65
		public unsafe static double MUSIC_START_OFFSET
		{
			get
			{
				double result;
				IL2CPP.il2cpp_field_static_get_value(MusicManager.NativeFieldInfoPtr_MUSIC_START_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicManager.NativeFieldInfoPtr_MUSIC_START_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00137D70 File Offset: 0x00135F70
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x0001A873 File Offset: 0x00018A73
		public unsafe long midiNoteOpenPreparationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNoteOpenPreparationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNoteOpenPreparationTime)) = value;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x00137D98 File Offset: 0x00135F98
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x0001A88E File Offset: 0x00018A8E
		public unsafe long midiNotePreValidTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNotePreValidTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNotePreValidTime)) = value;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x00137DC0 File Offset: 0x00135FC0
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x0001A8A9 File Offset: 0x00018AA9
		public unsafe long midiNotePostValidTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNotePostValidTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNotePostValidTime)) = value;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00137DE8 File Offset: 0x00135FE8
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x0001A8C4 File Offset: 0x00018AC4
		public unsafe long midiNoteHoldEarlyEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNoteHoldEarlyEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNoteHoldEarlyEndTime)) = value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x00137E10 File Offset: 0x00136010
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x0001A8DF File Offset: 0x00018ADF
		public unsafe long maxQTEDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_maxQTEDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_maxQTEDuration)) = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x00137E38 File Offset: 0x00136038
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x0001A8FA File Offset: 0x00018AFA
		public unsafe float musicSwitchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_musicSwitchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_musicSwitchTime)) = value;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00137E60 File Offset: 0x00136060
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x0001A915 File Offset: 0x00018B15
		public unsafe float musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_musicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_musicVolume)) = value;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x00137E88 File Offset: 0x00136088
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x0001A930 File Offset: 0x00018B30
		public unsafe float musicVolumeWhenMidi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_musicVolumeWhenMidi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_musicVolumeWhenMidi)) = value;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00137EB0 File Offset: 0x001360B0
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x0001A94B File Offset: 0x00018B4B
		public unsafe float midiNoteVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNoteVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_midiNoteVolume)) = value;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x00137ED8 File Offset: 0x001360D8
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x0001A966 File Offset: 0x00018B66
		public unsafe AudioClip onMusicChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_onMusicChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_onMusicChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x00137F08 File Offset: 0x00136108
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x0001A985 File Offset: 0x00018B85
		public unsafe Action<float> onMusicVolumeChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_onMusicVolumeChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_onMusicVolumeChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x00137F38 File Offset: 0x00136138
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		public unsafe Il2CppReferenceArray<LoopedBGMChannel> channels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_channels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoopedBGMChannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_channels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x00137F68 File Offset: 0x00136168
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x0001A9C3 File Offset: 0x00018BC3
		public unsafe long clipLoopTotalMiliseconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_clipLoopTotalMiliseconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_clipLoopTotalMiliseconds)) = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00137F90 File Offset: 0x00136190
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x0001A9DE File Offset: 0x00018BDE
		public unsafe int currentChannelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_currentChannelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_currentChannelIndex)) = value;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00137FB8 File Offset: 0x001361B8
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x0001A9F9 File Offset: 0x00018BF9
		public unsafe Il2CppStructArray<long> entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x00137FE8 File Offset: 0x001361E8
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0001AA18 File Offset: 0x00018C18
		public unsafe bool isChannelSwitching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_isChannelSwitching);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_isChannelSwitching)) = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x00138010 File Offset: 0x00136210
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0001AA33 File Offset: 0x00018C33
		public unsafe AudioSource onMusicTransitionSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_onMusicTransitionSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_onMusicTransitionSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00138040 File Offset: 0x00136240
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x0001AA52 File Offset: 0x00018C52
		public unsafe int requestedChannelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_requestedChannelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_requestedChannelIndex)) = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x00138068 File Offset: 0x00136268
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0001AA6D File Offset: 0x00018C6D
		public unsafe Queue<long> streamingSwitchPointList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_streamingSwitchPointList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr_streamingSwitchPointList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00138098 File Offset: 0x00136298
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x0001AA8C File Offset: 0x00018C8C
		public unsafe float _MidiSegmentMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__MidiSegmentMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__MidiSegmentMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x001380C0 File Offset: 0x001362C0
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0001AAA7 File Offset: 0x00018CA7
		public unsafe bool _IsMidiOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__IsMidiOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__IsMidiOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x001380E8 File Offset: 0x001362E8
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x0001AAC2 File Offset: 0x00018CC2
		public unsafe long _PlaybackTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__PlaybackTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__PlaybackTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00138110 File Offset: 0x00136310
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x0001AADD File Offset: 0x00018CDD
		public unsafe long _MusicSystemBeginPlayMiliseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__MusicSystemBeginPlayMiliseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__MusicSystemBeginPlayMiliseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_START_OFFSET;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeFieldInfoPtr_midiNoteOpenPreparationTime;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeFieldInfoPtr_midiNotePreValidTime;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeFieldInfoPtr_midiNotePostValidTime;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeFieldInfoPtr_midiNoteHoldEarlyEndTime;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeFieldInfoPtr_maxQTEDuration;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeFieldInfoPtr_musicSwitchTime;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeFieldInfoPtr_musicVolumeWhenMidi;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeFieldInfoPtr_midiNoteVolume;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeFieldInfoPtr_onMusicChange;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeFieldInfoPtr_onMusicVolumeChange;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeFieldInfoPtr_channels;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeFieldInfoPtr_clipLoopTotalMiliseconds;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeFieldInfoPtr_currentChannelIndex;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeFieldInfoPtr_isChannelSwitching;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeFieldInfoPtr_onMusicTransitionSource;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeFieldInfoPtr_requestedChannelIndex;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeFieldInfoPtr_streamingSwitchPointList;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeFieldInfoPtr__MidiSegmentMultiplier_k__BackingField;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeFieldInfoPtr__IsMidiOn_k__BackingField;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeFieldInfoPtr__PlaybackTime_k__BackingField;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeFieldInfoPtr__MusicSystemBeginPlayMiliseconds_k__BackingField;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiSegmentMultiplier_Private_get_Single_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_set_MidiSegmentMultiplier_Public_set_Void_Single_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiSegmentLength_Public_get_Int64_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMidiOn_Public_get_Boolean_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMidiOn_Private_set_Void_Boolean_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaybackTime_Public_get_Int64_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaybackTime_Private_set_Void_Int64_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicSystemBeginPlayMiliseconds_Public_get_Int64_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicSystemBeginPlayMiliseconds_Private_set_Void_Int64_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Action_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_FadeMainBGM_Public_Void_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicVolume_Private_Void_Single_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_RequestChannelSwitch_Public_Void_Int32_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_SwitchChannel_Private_Void_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitching_Private_IEnumerator_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_StopMusic_Public_Void_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_GetMidiNotes_Public_Il2CppStructArray_1_SingleNote_Single_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_SwitchBackToMain_Public_Void_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_FetchNotes_Public_Il2CppStructArray_1_SingleNote_Int64_Int64_Int64_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__39_0_Private_Void_0;

		// Token: 0x0200080F RID: 2063
		[ObfuscatedName("NightScene.MusicUtility.MusicManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A94D RID: 43341 RVA: 0x002BE738 File Offset: 0x002BC938
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr);
				MusicManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, "<>9");
				MusicManager.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, "<>9__39_1");
				MusicManager.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, "<>9__40_0");
				MusicManager.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, "<>9__41_0");
				MusicManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, 100671392);
				MusicManager.__c.NativeMethodInfoPtr__Initialize_b__39_1_Internal_Void_LoopedBGMChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, 100671393);
				MusicManager.__c.NativeMethodInfoPtr__FadeMainBGM_b__40_0_Internal_Void_LoopedBGMChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, 100671394);
				MusicManager.__c.NativeMethodInfoPtr__RestoreMainBGM_b__41_0_Internal_Void_LoopedBGMChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr, 100671395);
			}

			// Token: 0x0600A94E RID: 43342 RVA: 0x002BE804 File Offset: 0x002BCA04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A94F RID: 43343 RVA: 0x002BE840 File Offset: 0x002BCA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103180, XrefRangeEnd = 103185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__39_1(LoopedBGMChannel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c.NativeMethodInfoPtr__Initialize_b__39_1_Internal_Void_LoopedBGMChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A950 RID: 43344 RVA: 0x002BE884 File Offset: 0x002BCA84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103185, XrefRangeEnd = 103192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FadeMainBGM_b__40_0(LoopedBGMChannel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c.NativeMethodInfoPtr__FadeMainBGM_b__40_0_Internal_Void_LoopedBGMChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A951 RID: 43345 RVA: 0x002BE8C8 File Offset: 0x002BCAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103192, XrefRangeEnd = 103199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RestoreMainBGM_b__41_0(LoopedBGMChannel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c.NativeMethodInfoPtr__RestoreMainBGM_b__41_0_Internal_Void_LoopedBGMChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A952 RID: 43346 RVA: 0x0005B614 File Offset: 0x00059814
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170037A3 RID: 14243
			// (get) Token: 0x0600A953 RID: 43347 RVA: 0x002BE90C File Offset: 0x002BCB0C
			// (set) Token: 0x0600A954 RID: 43348 RVA: 0x0005B61D File Offset: 0x0005981D
			public unsafe static MusicManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037A4 RID: 14244
			// (get) Token: 0x0600A955 RID: 43349 RVA: 0x002BE934 File Offset: 0x002BCB34
			// (set) Token: 0x0600A956 RID: 43350 RVA: 0x0005B62F File Offset: 0x0005982F
			public unsafe static Action<LoopedBGMChannel> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicManager.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LoopedBGMChannel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicManager.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037A5 RID: 14245
			// (get) Token: 0x0600A957 RID: 43351 RVA: 0x002BE95C File Offset: 0x002BCB5C
			// (set) Token: 0x0600A958 RID: 43352 RVA: 0x0005B641 File Offset: 0x00059841
			public unsafe static Action<LoopedBGMChannel> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicManager.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LoopedBGMChannel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicManager.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037A6 RID: 14246
			// (get) Token: 0x0600A959 RID: 43353 RVA: 0x002BE984 File Offset: 0x002BCB84
			// (set) Token: 0x0600A95A RID: 43354 RVA: 0x0005B653 File Offset: 0x00059853
			public unsafe static Action<LoopedBGMChannel> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicManager.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LoopedBGMChannel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicManager.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D65 RID: 28005
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006D66 RID: 28006
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x04006D67 RID: 28007
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04006D68 RID: 28008
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x04006D69 RID: 28009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D6A RID: 28010
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__39_1_Internal_Void_LoopedBGMChannel_0;

			// Token: 0x04006D6B RID: 28011
			private static readonly IntPtr NativeMethodInfoPtr__FadeMainBGM_b__40_0_Internal_Void_LoopedBGMChannel_0;

			// Token: 0x04006D6C RID: 28012
			private static readonly IntPtr NativeMethodInfoPtr__RestoreMainBGM_b__41_0_Internal_Void_LoopedBGMChannel_0;
		}

		// Token: 0x02000810 RID: 2064
		[ObfuscatedName("NightScene.MusicUtility.MusicManager+<OnSwitching>d__45")]
		public sealed class _OnSwitching_d__45 : Il2CppSystem.Object
		{
			// Token: 0x0600A95B RID: 43355 RVA: 0x002BE9AC File Offset: 0x002BCBAC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnSwitching_d__45()
			{
				Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<OnSwitching>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr);
				MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, "<>1__state");
				MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, "<>2__current");
				MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, "<>4__this");
				MusicManager._OnSwitching_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, 100671396);
				MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, 100671397);
				MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, 100671398);
				MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, 100671399);
				MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, 100671400);
				MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr, 100671401);
			}

			// Token: 0x0600A95C RID: 43356 RVA: 0x002BEA8C File Offset: 0x002BCC8C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnSwitching_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager._OnSwitching_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager._OnSwitching_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A95D RID: 43357 RVA: 0x002BEAD4 File Offset: 0x002BCCD4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A95E RID: 43358 RVA: 0x002BEB08 File Offset: 0x002BCD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103199, XrefRangeEnd = 103205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170037AA RID: 14250
			// (get) Token: 0x0600A95F RID: 43359 RVA: 0x002BEB44 File Offset: 0x002BCD44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A960 RID: 43360 RVA: 0x002BEB84 File Offset: 0x002BCD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103205, XrefRangeEnd = 103211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170037AB RID: 14251
			// (get) Token: 0x0600A961 RID: 43361 RVA: 0x002BEBB8 File Offset: 0x002BCDB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager._OnSwitching_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A962 RID: 43362 RVA: 0x0005B665 File Offset: 0x00059865
			public _OnSwitching_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170037A7 RID: 14247
			// (get) Token: 0x0600A963 RID: 43363 RVA: 0x002BEBF8 File Offset: 0x002BCDF8
			// (set) Token: 0x0600A964 RID: 43364 RVA: 0x0005B66E File Offset: 0x0005986E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170037A8 RID: 14248
			// (get) Token: 0x0600A965 RID: 43365 RVA: 0x002BEC20 File Offset: 0x002BCE20
			// (set) Token: 0x0600A966 RID: 43366 RVA: 0x0005B689 File Offset: 0x00059889
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037A9 RID: 14249
			// (get) Token: 0x0600A967 RID: 43367 RVA: 0x002BEC50 File Offset: 0x002BCE50
			// (set) Token: 0x0600A968 RID: 43368 RVA: 0x0005B6A8 File Offset: 0x000598A8
			public unsafe MusicManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager._OnSwitching_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D6D RID: 28013
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D6E RID: 28014
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D6F RID: 28015
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D70 RID: 28016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D71 RID: 28017
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D72 RID: 28018
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D73 RID: 28019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D74 RID: 28020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D75 RID: 28021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
