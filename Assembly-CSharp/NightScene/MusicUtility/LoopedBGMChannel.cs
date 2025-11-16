using System;
using DEYU.Utils;
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
	// Token: 0x020001A1 RID: 417
	public class LoopedBGMChannel : MonoBehaviour
	{
		// Token: 0x06002DBC RID: 11708 RVA: 0x00136B08 File Offset: 0x00134D08
		// Note: this type is marked as 'beforefieldinit'.
		static LoopedBGMChannel()
		{
			Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.MusicUtility", "LoopedBGMChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr);
			LoopedBGMChannel.NativeFieldInfoPtr_allMidis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "allMidis");
			LoopedBGMChannel.NativeFieldInfoPtr_channelVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "channelVolumeMultiplier");
			LoopedBGMChannel.NativeFieldInfoPtr_introPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "introPlayer");
			LoopedBGMChannel.NativeFieldInfoPtr_isDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "isDisposed");
			LoopedBGMChannel.NativeFieldInfoPtr_loopPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "loopPlayer");
			LoopedBGMChannel.NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "masterVolume");
			LoopedBGMChannel.NativeFieldInfoPtr_midiVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "midiVolumeMultiplier");
			LoopedBGMChannel.NativeFieldInfoPtr_musicOverrideVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "musicOverrideVolumeMultiplier");
			LoopedBGMChannel.NativeFieldInfoPtr_onMidiSwitching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "onMidiSwitching");
			LoopedBGMChannel.NativeFieldInfoPtr_onChannelSwitching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "onChannelSwitching");
			LoopedBGMChannel.NativeFieldInfoPtr_streamingMidiList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "streamingMidiList");
			LoopedBGMChannel.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671336);
			LoopedBGMChannel.NativeMethodInfoPtr_Initialize_Public_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671337);
			LoopedBGMChannel.NativeMethodInfoPtr_ChangeMusicVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671338);
			LoopedBGMChannel.NativeMethodInfoPtr_Play_Public_Void_MusicChannelPackage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671339);
			LoopedBGMChannel.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671340);
			LoopedBGMChannel.NativeMethodInfoPtr_FadeMainBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671341);
			LoopedBGMChannel.NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671342);
			LoopedBGMChannel.NativeMethodInfoPtr_UpdateMusicOverrideVolumeMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671343);
			LoopedBGMChannel.NativeMethodInfoPtr_UpdateVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671344);
			LoopedBGMChannel.NativeMethodInfoPtr_ToggleChannelVolume_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671345);
			LoopedBGMChannel.NativeMethodInfoPtr_ChannelOn_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671346);
			LoopedBGMChannel.NativeMethodInfoPtr_ToggleMidiVolume_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671347);
			LoopedBGMChannel.NativeMethodInfoPtr_MidiOn_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671348);
			LoopedBGMChannel.NativeMethodInfoPtr_FetchNotes_Public_IEnumerable_1_SingleNote_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671349);
			LoopedBGMChannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671350);
			LoopedBGMChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, 100671351);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00136D54 File Offset: 0x00134F54
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00136D88 File Offset: 0x00134F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103030, RefRangeEnd = 103031, XrefRangeStart = 103004, XrefRangeEnd = 103030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action<float> Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_Initialize_Public_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr3) : null;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00136DC8 File Offset: 0x00134FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103031, XrefRangeEnd = 103034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeMusicVolume(float targetVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_ChangeMusicVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00136E08 File Offset: 0x00135008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103073, RefRangeEnd = 103074, XrefRangeStart = 103034, XrefRangeEnd = 103073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(IzakayaMusic.MusicChannelPackage channelPackage, bool defaultChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(channelPackage));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_Play_Public_Void_MusicChannelPackage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00136E60 File Offset: 0x00135060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103074, XrefRangeEnd = 103079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00136E94 File Offset: 0x00135094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103079, XrefRangeEnd = 103086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeMainBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_FadeMainBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00136EC8 File Offset: 0x001350C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103086, XrefRangeEnd = 103093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreMainBGM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00136EFC File Offset: 0x001350FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103093, XrefRangeEnd = 103096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicOverrideVolumeMultiplier(float targetMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_UpdateMusicOverrideVolumeMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00136F3C File Offset: 0x0013513C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103099, RefRangeEnd = 103101, XrefRangeStart = 103096, XrefRangeEnd = 103099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_UpdateVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00136F70 File Offset: 0x00135170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103110, RefRangeEnd = 103113, XrefRangeStart = 103101, XrefRangeEnd = 103110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleChannelVolume(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_ToggleChannelVolume_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00136FB0 File Offset: 0x001351B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103113, XrefRangeEnd = 103118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ChannelOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_ChannelOn_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00136FFC File Offset: 0x001351FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103127, RefRangeEnd = 103128, XrefRangeStart = 103118, XrefRangeEnd = 103127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMidiVolume(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_ToggleMidiVolume_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0013703C File Offset: 0x0013523C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103128, XrefRangeEnd = 103133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MidiOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_MidiOn_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00137088 File Offset: 0x00135288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103171, RefRangeEnd = 103173, XrefRangeStart = 103133, XrefRangeEnd = 103171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IzakayaMusic.SingleNote> FetchNotes(long startTime, long endTime, long clipLoopTotalMilliseconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipLoopTotalMilliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr_FetchNotes_Public_IEnumerable_1_SingleNote_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IzakayaMusic.SingleNote>>(intPtr3) : null;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x001370F0 File Offset: 0x001352F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103173, XrefRangeEnd = 103179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoopedBGMChannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x0013712C File Offset: 0x0013532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103179, XrefRangeEnd = 103180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopedBGMChannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0001A712 File Offset: 0x00018912
		public LoopedBGMChannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x00137168 File Offset: 0x00135368
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x0001A71B File Offset: 0x0001891B
		public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> allMidis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_allMidis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_allMidis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x00137198 File Offset: 0x00135398
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x0001A73A File Offset: 0x0001893A
		public unsafe float channelVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_channelVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_channelVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x001371C0 File Offset: 0x001353C0
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x0001A755 File Offset: 0x00018955
		public unsafe AudioSource introPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_introPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_introPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x001371F0 File Offset: 0x001353F0
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x0001A774 File Offset: 0x00018974
		public unsafe bool isDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_isDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_isDisposed)) = value;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x00137218 File Offset: 0x00135418
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x0001A78F File Offset: 0x0001898F
		public unsafe AudioSource loopPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_loopPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_loopPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x00137248 File Offset: 0x00135448
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x0001A7AE File Offset: 0x000189AE
		public unsafe float masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_masterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_masterVolume)) = value;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x00137270 File Offset: 0x00135470
		// (set) Token: 0x06002DDB RID: 11739 RVA: 0x0001A7C9 File Offset: 0x000189C9
		public unsafe float midiVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_midiVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_midiVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x00137298 File Offset: 0x00135498
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x0001A7E4 File Offset: 0x000189E4
		public unsafe float musicOverrideVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_musicOverrideVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_musicOverrideVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x001372C0 File Offset: 0x001354C0
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x0001A7FF File Offset: 0x000189FF
		public unsafe Coroutine onMidiSwitching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_onMidiSwitching);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_onMidiSwitching), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x001372F0 File Offset: 0x001354F0
		// (set) Token: 0x06002DE1 RID: 11745 RVA: 0x0001A81E File Offset: 0x00018A1E
		public unsafe Coroutine onChannelSwitching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_onChannelSwitching);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_onChannelSwitching), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x00137320 File Offset: 0x00135520
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x0001A83D File Offset: 0x00018A3D
		public unsafe LQueue<IzakayaMusic.SingleNote> streamingMidiList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_streamingMidiList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LQueue<IzakayaMusic.SingleNote>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.NativeFieldInfoPtr_streamingMidiList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeFieldInfoPtr_allMidis;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeFieldInfoPtr_channelVolumeMultiplier;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeFieldInfoPtr_introPlayer;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeFieldInfoPtr_isDisposed;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeFieldInfoPtr_loopPlayer;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeFieldInfoPtr_masterVolume;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeFieldInfoPtr_midiVolumeMultiplier;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeFieldInfoPtr_musicOverrideVolumeMultiplier;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeFieldInfoPtr_onMidiSwitching;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeFieldInfoPtr_onChannelSwitching;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeFieldInfoPtr_streamingMidiList;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Action_1_Single_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMusicVolume_Private_Void_Single_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_MusicChannelPackage_Boolean_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_FadeMainBGM_Public_Void_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_RestoreMainBGM_Public_Void_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicOverrideVolumeMultiplier_Private_Void_Single_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolume_Private_Void_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_ToggleChannelVolume_Public_Void_Boolean_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_ChannelOn_Private_IEnumerator_Boolean_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMidiVolume_Public_Void_Boolean_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_MidiOn_Private_IEnumerator_Boolean_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_FetchNotes_Public_IEnumerable_1_SingleNote_Int64_Int64_Int64_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200080C RID: 2060
		[ObfuscatedName("NightScene.MusicUtility.LoopedBGMChannel+<ChannelOn>d__21")]
		public sealed class _ChannelOn_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600A923 RID: 43299 RVA: 0x002BDF88 File Offset: 0x002BC188
			// Note: this type is marked as 'beforefieldinit'.
			static _ChannelOn_d__21()
			{
				Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "<ChannelOn>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr);
				LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, "<>1__state");
				LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, "<>2__current");
				LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, "on");
				LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, "<>4__this");
				LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr__progress_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, "<progress>5__2");
				LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, 100671352);
				LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, 100671353);
				LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, 100671354);
				LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, 100671355);
				LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, 100671356);
				LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr, 100671357);
			}

			// Token: 0x0600A924 RID: 43300 RVA: 0x002BE090 File Offset: 0x002BC290
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChannelOn_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopedBGMChannel._ChannelOn_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A925 RID: 43301 RVA: 0x002BE0D8 File Offset: 0x002BC2D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A926 RID: 43302 RVA: 0x002BE10C File Offset: 0x002BC30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102955, XrefRangeEnd = 102971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003799 RID: 14233
			// (get) Token: 0x0600A927 RID: 43303 RVA: 0x002BE148 File Offset: 0x002BC348
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A928 RID: 43304 RVA: 0x002BE188 File Offset: 0x002BC388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102971, XrefRangeEnd = 102977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700379A RID: 14234
			// (get) Token: 0x0600A929 RID: 43305 RVA: 0x002BE1BC File Offset: 0x002BC3BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._ChannelOn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A92A RID: 43306 RVA: 0x0005B4C0 File Offset: 0x000596C0
			public _ChannelOn_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003794 RID: 14228
			// (get) Token: 0x0600A92B RID: 43307 RVA: 0x002BE1FC File Offset: 0x002BC3FC
			// (set) Token: 0x0600A92C RID: 43308 RVA: 0x0005B4C9 File Offset: 0x000596C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003795 RID: 14229
			// (get) Token: 0x0600A92D RID: 43309 RVA: 0x002BE224 File Offset: 0x002BC424
			// (set) Token: 0x0600A92E RID: 43310 RVA: 0x0005B4E4 File Offset: 0x000596E4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003796 RID: 14230
			// (get) Token: 0x0600A92F RID: 43311 RVA: 0x002BE254 File Offset: 0x002BC454
			// (set) Token: 0x0600A930 RID: 43312 RVA: 0x0005B503 File Offset: 0x00059703
			public unsafe bool on
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr_on);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr_on)) = value;
				}
			}

			// Token: 0x17003797 RID: 14231
			// (get) Token: 0x0600A931 RID: 43313 RVA: 0x002BE27C File Offset: 0x002BC47C
			// (set) Token: 0x0600A932 RID: 43314 RVA: 0x0005B51E File Offset: 0x0005971E
			public unsafe LoopedBGMChannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMChannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003798 RID: 14232
			// (get) Token: 0x0600A933 RID: 43315 RVA: 0x002BE2AC File Offset: 0x002BC4AC
			// (set) Token: 0x0600A934 RID: 43316 RVA: 0x0005B53D File Offset: 0x0005973D
			public unsafe float _progress_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr__progress_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._ChannelOn_d__21.NativeFieldInfoPtr__progress_5__2)) = value;
				}
			}

			// Token: 0x04006D4C RID: 27980
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D4D RID: 27981
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D4E RID: 27982
			private static readonly IntPtr NativeFieldInfoPtr_on;

			// Token: 0x04006D4F RID: 27983
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D50 RID: 27984
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__2;

			// Token: 0x04006D51 RID: 27985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D52 RID: 27986
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D53 RID: 27987
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D54 RID: 27988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D55 RID: 27989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D56 RID: 27990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200080D RID: 2061
		[ObfuscatedName("NightScene.MusicUtility.LoopedBGMChannel+<MidiOn>d__23")]
		public sealed class _MidiOn_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600A935 RID: 43317 RVA: 0x002BE2D4 File Offset: 0x002BC4D4
			// Note: this type is marked as 'beforefieldinit'.
			static _MidiOn_d__23()
			{
				Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "<MidiOn>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr);
				LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, "<>1__state");
				LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, "<>2__current");
				LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, "on");
				LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, "<>4__this");
				LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr__progress_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, "<progress>5__2");
				LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, 100671358);
				LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, 100671359);
				LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, 100671360);
				LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, 100671361);
				LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, 100671362);
				LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr, 100671363);
			}

			// Token: 0x0600A936 RID: 43318 RVA: 0x002BE3DC File Offset: 0x002BC5DC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MidiOn_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopedBGMChannel._MidiOn_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A937 RID: 43319 RVA: 0x002BE424 File Offset: 0x002BC624
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A938 RID: 43320 RVA: 0x002BE458 File Offset: 0x002BC658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102977, XrefRangeEnd = 102997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170037A0 RID: 14240
			// (get) Token: 0x0600A939 RID: 43321 RVA: 0x002BE494 File Offset: 0x002BC694
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A93A RID: 43322 RVA: 0x002BE4D4 File Offset: 0x002BC6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102997, XrefRangeEnd = 103003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170037A1 RID: 14241
			// (get) Token: 0x0600A93B RID: 43323 RVA: 0x002BE508 File Offset: 0x002BC708
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel._MidiOn_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A93C RID: 43324 RVA: 0x0005B558 File Offset: 0x00059758
			public _MidiOn_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700379B RID: 14235
			// (get) Token: 0x0600A93D RID: 43325 RVA: 0x002BE548 File Offset: 0x002BC748
			// (set) Token: 0x0600A93E RID: 43326 RVA: 0x0005B561 File Offset: 0x00059761
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700379C RID: 14236
			// (get) Token: 0x0600A93F RID: 43327 RVA: 0x002BE570 File Offset: 0x002BC770
			// (set) Token: 0x0600A940 RID: 43328 RVA: 0x0005B57C File Offset: 0x0005977C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700379D RID: 14237
			// (get) Token: 0x0600A941 RID: 43329 RVA: 0x002BE5A0 File Offset: 0x002BC7A0
			// (set) Token: 0x0600A942 RID: 43330 RVA: 0x0005B59B File Offset: 0x0005979B
			public unsafe bool on
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr_on);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr_on)) = value;
				}
			}

			// Token: 0x1700379E RID: 14238
			// (get) Token: 0x0600A943 RID: 43331 RVA: 0x002BE5C8 File Offset: 0x002BC7C8
			// (set) Token: 0x0600A944 RID: 43332 RVA: 0x0005B5B6 File Offset: 0x000597B6
			public unsafe LoopedBGMChannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMChannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700379F RID: 14239
			// (get) Token: 0x0600A945 RID: 43333 RVA: 0x002BE5F8 File Offset: 0x002BC7F8
			// (set) Token: 0x0600A946 RID: 43334 RVA: 0x0005B5D5 File Offset: 0x000597D5
			public unsafe float _progress_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr__progress_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel._MidiOn_d__23.NativeFieldInfoPtr__progress_5__2)) = value;
				}
			}

			// Token: 0x04006D57 RID: 27991
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D58 RID: 27992
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D59 RID: 27993
			private static readonly IntPtr NativeFieldInfoPtr_on;

			// Token: 0x04006D5A RID: 27994
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D5B RID: 27995
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__2;

			// Token: 0x04006D5C RID: 27996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D5D RID: 27997
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D5E RID: 27998
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D5F RID: 27999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D60 RID: 28000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D61 RID: 28001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200080E RID: 2062
		[ObfuscatedName("NightScene.MusicUtility.LoopedBGMChannel+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A947 RID: 43335 RVA: 0x002BE620 File Offset: 0x002BC820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<LoopedBGMChannel.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoopedBGMChannel>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopedBGMChannel.__c__DisplayClass24_0>.NativeClassPtr);
				LoopedBGMChannel.__c__DisplayClass24_0.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedBGMChannel.__c__DisplayClass24_0>.NativeClassPtr, "endTime");
				LoopedBGMChannel.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel.__c__DisplayClass24_0>.NativeClassPtr, 100671364);
				LoopedBGMChannel.__c__DisplayClass24_0.NativeMethodInfoPtr__FetchNotes_b__0_Internal_Boolean_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedBGMChannel.__c__DisplayClass24_0>.NativeClassPtr, 100671365);
			}

			// Token: 0x0600A948 RID: 43336 RVA: 0x002BE688 File Offset: 0x002BC888
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopedBGMChannel.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A949 RID: 43337 RVA: 0x002BE6C4 File Offset: 0x002BC8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103003, XrefRangeEnd = 103004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FetchNotes_b__0(IzakayaMusic.SingleNote x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopedBGMChannel.__c__DisplayClass24_0.NativeMethodInfoPtr__FetchNotes_b__0_Internal_Boolean_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A94A RID: 43338 RVA: 0x0005B5F0 File Offset: 0x000597F0
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170037A2 RID: 14242
			// (get) Token: 0x0600A94B RID: 43339 RVA: 0x002BE710 File Offset: 0x002BC910
			// (set) Token: 0x0600A94C RID: 43340 RVA: 0x0005B5F9 File Offset: 0x000597F9
			public unsafe long endTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.__c__DisplayClass24_0.NativeFieldInfoPtr_endTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopedBGMChannel.__c__DisplayClass24_0.NativeFieldInfoPtr_endTime)) = value;
				}
			}

			// Token: 0x04006D62 RID: 28002
			private static readonly IntPtr NativeFieldInfoPtr_endTime;

			// Token: 0x04006D63 RID: 28003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D64 RID: 28004
			private static readonly IntPtr NativeMethodInfoPtr__FetchNotes_b__0_Internal_Boolean_SingleNote_0;
		}
	}
}
