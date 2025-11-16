using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData.RunTime.NightSceneUtility
{
	// Token: 0x02000221 RID: 545
	public static class MusicSystem : Object
	{
		// Token: 0x060040AF RID: 16559 RVA: 0x0017BA44 File Offset: 0x00179C44
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSystem()
		{
			Il2CppClassPointerStore<MusicSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.NightSceneUtility", "MusicSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr);
			MusicSystem.NativeFieldInfoPtr_midiSegmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "midiSegmentLength");
			MusicSystem.NativeFieldInfoPtr_midiSegmentMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "midiSegmentMultiplier");
			MusicSystem.NativeFieldInfoPtr__MidiNoteOpenPreparationTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MidiNoteOpenPreparationTime>k__BackingField");
			MusicSystem.NativeFieldInfoPtr__MidiNoteOpenLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MidiNoteOpenLength>k__BackingField");
			MusicSystem.NativeFieldInfoPtr__MusicSwitchTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MusicSwitchTime>k__BackingField");
			MusicSystem.NativeFieldInfoPtr__MidiNoteVolume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MidiNoteVolume>k__BackingField");
			MusicSystem.NativeFieldInfoPtr__MusicVolumeWhenMidi_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MusicVolumeWhenMidi>k__BackingField");
			MusicSystem.NativeFieldInfoPtr__MidiNoteAwaitingProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MidiNoteAwaitingProgress>k__BackingField");
			MusicSystem.NativeFieldInfoPtr__MusicVolume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<MusicVolume>k__BackingField");
			MusicSystem.NativeMethodInfoPtr_get_MidiNoteOpenPreparationTime_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675486);
			MusicSystem.NativeMethodInfoPtr_set_MidiNoteOpenPreparationTime_Private_Static_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675487);
			MusicSystem.NativeMethodInfoPtr_get_MidiNoteOpenLength_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675488);
			MusicSystem.NativeMethodInfoPtr_set_MidiNoteOpenLength_Private_Static_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675489);
			MusicSystem.NativeMethodInfoPtr_get_MidiSegmentLength_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675490);
			MusicSystem.NativeMethodInfoPtr_get_MusicSwitchTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675491);
			MusicSystem.NativeMethodInfoPtr_set_MusicSwitchTime_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675492);
			MusicSystem.NativeMethodInfoPtr_get_MidiNoteVolume_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675493);
			MusicSystem.NativeMethodInfoPtr_set_MidiNoteVolume_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675494);
			MusicSystem.NativeMethodInfoPtr_get_MusicVolumeWhenMidi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675495);
			MusicSystem.NativeMethodInfoPtr_set_MusicVolumeWhenMidi_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675496);
			MusicSystem.NativeMethodInfoPtr_get_MidiNoteAwaitingProgress_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675497);
			MusicSystem.NativeMethodInfoPtr_set_MidiNoteAwaitingProgress_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675498);
			MusicSystem.NativeMethodInfoPtr_get_MusicVolume_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675499);
			MusicSystem.NativeMethodInfoPtr_set_MusicVolume_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675500);
			MusicSystem.NativeMethodInfoPtr_Initialize_Public_Static_Void_Single_Single_Single_Int64_Single_Int64_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675501);
			MusicSystem.NativeMethodInfoPtr_GetMidiSegmentMultiplier_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675502);
			MusicSystem.NativeMethodInfoPtr_SetMidiSegmentMultiplier_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100675503);
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x0017BC90 File Offset: 0x00179E90
		// (set) Token: 0x060040B1 RID: 16561 RVA: 0x0017BCC0 File Offset: 0x00179EC0
		public unsafe static long MidiNoteOpenPreparationTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158720, XrefRangeEnd = 158722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MidiNoteOpenPreparationTime_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158722, XrefRangeEnd = 158724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MidiNoteOpenPreparationTime_Private_Static_set_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x0017BCF4 File Offset: 0x00179EF4
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x0017BD24 File Offset: 0x00179F24
		public unsafe static long MidiNoteOpenLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158724, XrefRangeEnd = 158726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MidiNoteOpenLength_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158726, XrefRangeEnd = 158728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MidiNoteOpenLength_Private_Static_set_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0017BD58 File Offset: 0x00179F58
		public unsafe static long MidiSegmentLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158728, XrefRangeEnd = 158730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MidiSegmentLength_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x0017BD88 File Offset: 0x00179F88
		// (set) Token: 0x060040B6 RID: 16566 RVA: 0x0017BDB8 File Offset: 0x00179FB8
		public unsafe static float MusicSwitchTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158730, XrefRangeEnd = 158732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MusicSwitchTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158732, XrefRangeEnd = 158734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MusicSwitchTime_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x0017BDEC File Offset: 0x00179FEC
		// (set) Token: 0x060040B8 RID: 16568 RVA: 0x0017BE1C File Offset: 0x0017A01C
		public unsafe static float MidiNoteVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158734, XrefRangeEnd = 158736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MidiNoteVolume_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158736, XrefRangeEnd = 158738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MidiNoteVolume_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x0017BE50 File Offset: 0x0017A050
		// (set) Token: 0x060040BA RID: 16570 RVA: 0x0017BE80 File Offset: 0x0017A080
		public unsafe static float MusicVolumeWhenMidi
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158738, XrefRangeEnd = 158740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MusicVolumeWhenMidi_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158740, XrefRangeEnd = 158742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MusicVolumeWhenMidi_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x0017BEB4 File Offset: 0x0017A0B4
		// (set) Token: 0x060040BC RID: 16572 RVA: 0x0017BEE4 File Offset: 0x0017A0E4
		public unsafe static float MidiNoteAwaitingProgress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158742, XrefRangeEnd = 158744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MidiNoteAwaitingProgress_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158744, XrefRangeEnd = 158746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MidiNoteAwaitingProgress_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x0017BF18 File Offset: 0x0017A118
		// (set) Token: 0x060040BE RID: 16574 RVA: 0x0017BF48 File Offset: 0x0017A148
		public unsafe static float MusicVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158746, XrefRangeEnd = 158748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_get_MusicVolume_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158748, XrefRangeEnd = 158750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_set_MusicVolume_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0017BF7C File Offset: 0x0017A17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158750, XrefRangeEnd = 158766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(float musicVolume, float musicVolumeWhenMidi, float musicSwitchTime, long midiSegmentLength, float midiNoteVolume, long midiNoteOpenPreparationTime, float midiNoteAwaitingProgress, long midiNoteOpenLength)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref musicVolume;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicVolumeWhenMidi;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicSwitchTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiSegmentLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiNoteVolume;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiNoteOpenPreparationTime;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiNoteAwaitingProgress;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiNoteOpenLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_Initialize_Public_Static_Void_Single_Single_Single_Int64_Single_Int64_Single_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0017C010 File Offset: 0x0017A210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158766, XrefRangeEnd = 158768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMidiSegmentMultiplier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_GetMidiSegmentMultiplier_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0017C040 File Offset: 0x0017A240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158768, XrefRangeEnd = 158770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMidiSegmentMultiplier(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_SetMidiSegmentMultiplier_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x0002347A File Offset: 0x0002167A
		public MusicSystem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x060040C3 RID: 16579 RVA: 0x0017C074 File Offset: 0x0017A274
		// (set) Token: 0x060040C4 RID: 16580 RVA: 0x00023483 File Offset: 0x00021683
		public unsafe static long midiSegmentLength
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_midiSegmentLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_midiSegmentLength, (void*)(&value));
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x0017C090 File Offset: 0x0017A290
		// (set) Token: 0x060040C6 RID: 16582 RVA: 0x00023491 File Offset: 0x00021691
		public unsafe static float midiSegmentMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_midiSegmentMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_midiSegmentMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x0017C0AC File Offset: 0x0017A2AC
		// (set) Token: 0x060040C8 RID: 16584 RVA: 0x0002349F File Offset: 0x0002169F
		public unsafe static long _MidiNoteOpenPreparationTime_k__BackingField
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MidiNoteOpenPreparationTime_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MidiNoteOpenPreparationTime_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x0017C0C8 File Offset: 0x0017A2C8
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x000234AD File Offset: 0x000216AD
		public unsafe static long _MidiNoteOpenLength_k__BackingField
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MidiNoteOpenLength_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MidiNoteOpenLength_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x0017C0E4 File Offset: 0x0017A2E4
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x000234BB File Offset: 0x000216BB
		public unsafe static float _MusicSwitchTime_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MusicSwitchTime_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MusicSwitchTime_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x0017C100 File Offset: 0x0017A300
		// (set) Token: 0x060040CE RID: 16590 RVA: 0x000234C9 File Offset: 0x000216C9
		public unsafe static float _MidiNoteVolume_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MidiNoteVolume_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MidiNoteVolume_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x0017C11C File Offset: 0x0017A31C
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x000234D7 File Offset: 0x000216D7
		public unsafe static float _MusicVolumeWhenMidi_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MusicVolumeWhenMidi_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MusicVolumeWhenMidi_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x0017C138 File Offset: 0x0017A338
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x000234E5 File Offset: 0x000216E5
		public unsafe static float _MidiNoteAwaitingProgress_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MidiNoteAwaitingProgress_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MidiNoteAwaitingProgress_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x0017C154 File Offset: 0x0017A354
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x000234F3 File Offset: 0x000216F3
		public unsafe static float _MusicVolume_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr__MusicVolume_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr__MusicVolume_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeFieldInfoPtr_midiSegmentLength;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeFieldInfoPtr_midiSegmentMultiplier;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeFieldInfoPtr__MidiNoteOpenPreparationTime_k__BackingField;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeFieldInfoPtr__MidiNoteOpenLength_k__BackingField;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeFieldInfoPtr__MusicSwitchTime_k__BackingField;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeFieldInfoPtr__MidiNoteVolume_k__BackingField;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeFieldInfoPtr__MusicVolumeWhenMidi_k__BackingField;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeFieldInfoPtr__MidiNoteAwaitingProgress_k__BackingField;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeFieldInfoPtr__MusicVolume_k__BackingField;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiNoteOpenPreparationTime_Public_Static_get_Int64_0;

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeMethodInfoPtr_set_MidiNoteOpenPreparationTime_Private_Static_set_Void_Int64_0;

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiNoteOpenLength_Public_Static_get_Int64_0;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeMethodInfoPtr_set_MidiNoteOpenLength_Private_Static_set_Void_Int64_0;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiSegmentLength_Public_Static_get_Int64_0;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicSwitchTime_Public_Static_get_Single_0;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicSwitchTime_Private_Static_set_Void_Single_0;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiNoteVolume_Public_Static_get_Single_0;

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeMethodInfoPtr_set_MidiNoteVolume_Private_Static_set_Void_Single_0;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVolumeWhenMidi_Public_Static_get_Single_0;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicVolumeWhenMidi_Private_Static_set_Void_Single_0;

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiNoteAwaitingProgress_Public_Static_get_Single_0;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeMethodInfoPtr_set_MidiNoteAwaitingProgress_Private_Static_set_Void_Single_0;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVolume_Public_Static_get_Single_0;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicVolume_Private_Static_set_Void_Single_0;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Single_Single_Single_Int64_Single_Int64_Single_Int64_0;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeMethodInfoPtr_GetMidiSegmentMultiplier_Public_Static_Single_0;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeMethodInfoPtr_SetMidiSegmentMultiplier_Public_Static_Void_Single_0;
	}
}
