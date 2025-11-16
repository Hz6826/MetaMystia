using System;
using System.Runtime.InteropServices;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.MusicUtility
{
	// Token: 0x02000237 RID: 567
	public class IzakayaMusic : Il2CppSystem.Object
	{
		// Token: 0x060046A3 RID: 18083 RVA: 0x00024AEC File Offset: 0x00022CEC
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaMusic()
		{
			Il2CppClassPointerStore<IzakayaMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.MusicUtility", "IzakayaMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaMusic>.NativeClassPtr);
			IzakayaMusic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic>.NativeClassPtr, 100677301);
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x00192C7C File Offset: 0x00190E7C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaMusic() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaMusic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00024B25 File Offset: 0x00022D25
		public IzakayaMusic(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA6 RID: 2726
		[Serializable]
		public sealed class MusicChannelPackage : ValueType
		{
			// Token: 0x0600CC42 RID: 52290 RVA: 0x00326634 File Offset: 0x00324834
			// Note: this type is marked as 'beforefieldinit'.
			static MusicChannelPackage()
			{
				Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaMusic>.NativeClassPtr, "MusicChannelPackage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr);
				IzakayaMusic.MusicChannelPackage.NativeFieldInfoPtr_musicData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, "musicData");
				IzakayaMusic.MusicChannelPackage.NativeFieldInfoPtr_qtes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, "qtes");
				IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr__ctor_Public_Void_LoopedBGMPackage_Il2CppStructArray_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, 100677302);
				IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_get_ClipIntro_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, 100677303);
				IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_get_ClipLoop_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, 100677304);
				IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_get_Qtes_Public_get_Il2CppStructArray_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, 100677305);
				IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_set_Qtes_Public_set_Void_Il2CppStructArray_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr, 100677306);
			}

			// Token: 0x0600CC43 RID: 52291 RVA: 0x003266EC File Offset: 0x003248EC
			[CallerCount(272)]
			[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MusicChannelPackage(LoopedBGMPackage musicData, Il2CppStructArray<IzakayaMusic.SingleNote> qtes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(musicData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qtes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr__ctor_Public_Void_LoopedBGMPackage_Il2CppStructArray_1_SingleNote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004243 RID: 16963
			// (get) Token: 0x0600CC44 RID: 52292 RVA: 0x00326750 File Offset: 0x00324950
			public unsafe AudioClip ClipIntro
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 186213, RefRangeEnd = 186220, XrefRangeStart = 186213, XrefRangeEnd = 186213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_get_ClipIntro_Public_get_AudioClip_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
				}
			}

			// Token: 0x17004244 RID: 16964
			// (get) Token: 0x0600CC45 RID: 52293 RVA: 0x00326794 File Offset: 0x00324994
			public unsafe AudioClip ClipLoop
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 186220, RefRangeEnd = 186223, XrefRangeStart = 186220, XrefRangeEnd = 186220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_get_ClipLoop_Public_get_AudioClip_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
				}
			}

			// Token: 0x17004245 RID: 16965
			// (get) Token: 0x0600CC46 RID: 52294 RVA: 0x003267D8 File Offset: 0x003249D8
			// (set) Token: 0x0600CC47 RID: 52295 RVA: 0x0032681C File Offset: 0x00324A1C
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> Qtes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_get_Qtes_Public_get_Il2CppStructArray_1_SingleNote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 186224, RefRangeEnd = 186225, XrefRangeStart = 186223, XrefRangeEnd = 186224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.MusicChannelPackage.NativeMethodInfoPtr_set_Qtes_Public_set_Void_Il2CppStructArray_1_SingleNote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CC48 RID: 52296 RVA: 0x0006D9BC File Offset: 0x0006BBBC
			public MusicChannelPackage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CC49 RID: 52297 RVA: 0x0006D9C5 File Offset: 0x0006BBC5
			public MusicChannelPackage() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaMusic.MusicChannelPackage>.NativeClassPtr))
			{
			}

			// Token: 0x17004241 RID: 16961
			// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x00326864 File Offset: 0x00324A64
			// (set) Token: 0x0600CC4B RID: 52299 RVA: 0x0006D9D7 File Offset: 0x0006BBD7
			public unsafe LoopedBGMPackage musicData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusic.MusicChannelPackage.NativeFieldInfoPtr_musicData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusic.MusicChannelPackage.NativeFieldInfoPtr_musicData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004242 RID: 16962
			// (get) Token: 0x0600CC4C RID: 52300 RVA: 0x00326894 File Offset: 0x00324A94
			// (set) Token: 0x0600CC4D RID: 52301 RVA: 0x0006D9F6 File Offset: 0x0006BBF6
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> qtes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusic.MusicChannelPackage.NativeFieldInfoPtr_qtes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMusic.MusicChannelPackage.NativeFieldInfoPtr_qtes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008333 RID: 33587
			private static readonly IntPtr NativeFieldInfoPtr_musicData;

			// Token: 0x04008334 RID: 33588
			private static readonly IntPtr NativeFieldInfoPtr_qtes;

			// Token: 0x04008335 RID: 33589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoopedBGMPackage_Il2CppStructArray_1_SingleNote_0;

			// Token: 0x04008336 RID: 33590
			private static readonly IntPtr NativeMethodInfoPtr_get_ClipIntro_Public_get_AudioClip_0;

			// Token: 0x04008337 RID: 33591
			private static readonly IntPtr NativeMethodInfoPtr_get_ClipLoop_Public_get_AudioClip_0;

			// Token: 0x04008338 RID: 33592
			private static readonly IntPtr NativeMethodInfoPtr_get_Qtes_Public_get_Il2CppStructArray_1_SingleNote_0;

			// Token: 0x04008339 RID: 33593
			private static readonly IntPtr NativeMethodInfoPtr_set_Qtes_Public_set_Void_Il2CppStructArray_1_SingleNote_0;
		}

		// Token: 0x02000AA7 RID: 2727
		[Serializable]
		[StructLayout(2)]
		public struct SingleNote
		{
			// Token: 0x0600CC4E RID: 52302 RVA: 0x003268C4 File Offset: 0x00324AC4
			// Note: this type is marked as 'beforefieldinit'.
			static SingleNote()
			{
				Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaMusic>.NativeClassPtr, "SingleNote");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr);
				IzakayaMusic.SingleNote.NativeFieldInfoPtr_m_GetCalibrationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, "m_GetCalibrationCallback");
				IzakayaMusic.SingleNote.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, "startTime");
				IzakayaMusic.SingleNote.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, "endTime");
				IzakayaMusic.SingleNote.NativeFieldInfoPtr_noteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, "noteType");
				IzakayaMusic.SingleNote.NativeFieldInfoPtr_positionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, "positionType");
				IzakayaMusic.SingleNote.NativeMethodInfoPtr__ctor_Public_Void_SingleNote_Nullable_1_Int64_Nullable_1_Int64_Nullable_1_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677307);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_NoteType_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677308);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_m_CalibrationOffset_Private_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677309);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_CorrectedStartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677310);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_CorrectedEndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677311);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677312);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677313);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_Type_Public_get_NoteType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677314);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_Position_Public_get_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677315);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_CreateEnd_Public_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677316);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_PreloadCalibration_Public_Static_Void_Func_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677317);
				IzakayaMusic.SingleNote.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, 100677318);
			}

			// Token: 0x0600CC4F RID: 52303 RVA: 0x00326A44 File Offset: 0x00324C44
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 186238, RefRangeEnd = 186244, XrefRangeStart = 186225, XrefRangeEnd = 186238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleNote(IzakayaMusic.SingleNote source, Nullable<long> newStartTime = null, Nullable<long> newEndTime = null, Nullable<IzakayaMusic.SingleNote.NotePosition> newPosition = null)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref source;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newStartTime));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newEndTime));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newPosition));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr__ctor_Public_Void_SingleNote_Nullable_1_Int64_Nullable_1_Int64_Nullable_1_NotePosition_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC50 RID: 52304 RVA: 0x00326ABC File Offset: 0x00324CBC
			[CallerCount(0)]
			public unsafe SingleNote(long startTime, long endTime, IzakayaMusic.SingleNote.NoteType noteType, IzakayaMusic.SingleNote.NotePosition positionType)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref startTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noteType;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_NoteType_NotePosition_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004247 RID: 16967
			// (get) Token: 0x0600CC51 RID: 52305 RVA: 0x00326B18 File Offset: 0x00324D18
			public unsafe static long m_CalibrationOffset
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186244, XrefRangeEnd = 186246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_m_CalibrationOffset_Private_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004248 RID: 16968
			// (get) Token: 0x0600CC52 RID: 52306 RVA: 0x00326B48 File Offset: 0x00324D48
			public unsafe long CorrectedStartTime
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 186248, RefRangeEnd = 186262, XrefRangeStart = 186246, XrefRangeEnd = 186248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_CorrectedStartTime_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004249 RID: 16969
			// (get) Token: 0x0600CC53 RID: 52307 RVA: 0x00326B78 File Offset: 0x00324D78
			public unsafe long CorrectedEndTime
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 186264, RefRangeEnd = 186265, XrefRangeStart = 186262, XrefRangeEnd = 186264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_CorrectedEndTime_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700424A RID: 16970
			// (get) Token: 0x0600CC54 RID: 52308 RVA: 0x00326BA8 File Offset: 0x00324DA8
			public unsafe long StartTime
			{
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700424B RID: 16971
			// (get) Token: 0x0600CC55 RID: 52309 RVA: 0x00326BD8 File Offset: 0x00324DD8
			public unsafe long EndTime
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700424C RID: 16972
			// (get) Token: 0x0600CC56 RID: 52310 RVA: 0x00326C08 File Offset: 0x00324E08
			public unsafe IzakayaMusic.SingleNote.NoteType Type
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_Type_Public_get_NoteType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700424D RID: 16973
			// (get) Token: 0x0600CC57 RID: 52311 RVA: 0x00326C38 File Offset: 0x00324E38
			public unsafe IzakayaMusic.SingleNote.NotePosition Position
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_get_Position_Public_get_NotePosition_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CC58 RID: 52312 RVA: 0x00326C68 File Offset: 0x00324E68
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 186265, RefRangeEnd = 186267, XrefRangeStart = 186265, XrefRangeEnd = 186265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IzakayaMusic.SingleNote CreateEnd()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_CreateEnd_Public_SingleNote_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC59 RID: 52313 RVA: 0x00326C98 File Offset: 0x00324E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186267, XrefRangeEnd = 186271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void PreloadCalibration(Func<long> getCalibrationCallback)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getCalibrationCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_PreloadCalibration_Public_Static_Void_Func_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC5A RID: 52314 RVA: 0x00326CD0 File Offset: 0x00324ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186271, XrefRangeEnd = 186278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMusic.SingleNote.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CC5B RID: 52315 RVA: 0x0006DA15 File Offset: 0x0006BC15
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IzakayaMusic.SingleNote>.NativeClassPtr, ref this));
			}

			// Token: 0x17004246 RID: 16966
			// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x00326CFC File Offset: 0x00324EFC
			// (set) Token: 0x0600CC5D RID: 52317 RVA: 0x0006DA27 File Offset: 0x0006BC27
			public unsafe static Func<long> m_GetCalibrationCallback
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaMusic.SingleNote.NativeFieldInfoPtr_m_GetCalibrationCallback, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaMusic.SingleNote.NativeFieldInfoPtr_m_GetCalibrationCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400833A RID: 33594
			private static readonly IntPtr NativeFieldInfoPtr_m_GetCalibrationCallback;

			// Token: 0x0400833B RID: 33595
			private static readonly IntPtr NativeFieldInfoPtr_startTime;

			// Token: 0x0400833C RID: 33596
			private static readonly IntPtr NativeFieldInfoPtr_endTime;

			// Token: 0x0400833D RID: 33597
			private static readonly IntPtr NativeFieldInfoPtr_noteType;

			// Token: 0x0400833E RID: 33598
			private static readonly IntPtr NativeFieldInfoPtr_positionType;

			// Token: 0x0400833F RID: 33599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SingleNote_Nullable_1_Int64_Nullable_1_Int64_Nullable_1_NotePosition_0;

			// Token: 0x04008340 RID: 33600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_NoteType_NotePosition_0;

			// Token: 0x04008341 RID: 33601
			private static readonly IntPtr NativeMethodInfoPtr_get_m_CalibrationOffset_Private_Static_get_Int64_0;

			// Token: 0x04008342 RID: 33602
			private static readonly IntPtr NativeMethodInfoPtr_get_CorrectedStartTime_Public_get_Int64_0;

			// Token: 0x04008343 RID: 33603
			private static readonly IntPtr NativeMethodInfoPtr_get_CorrectedEndTime_Public_get_Int64_0;

			// Token: 0x04008344 RID: 33604
			private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

			// Token: 0x04008345 RID: 33605
			private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0;

			// Token: 0x04008346 RID: 33606
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_NoteType_0;

			// Token: 0x04008347 RID: 33607
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_NotePosition_0;

			// Token: 0x04008348 RID: 33608
			private static readonly IntPtr NativeMethodInfoPtr_CreateEnd_Public_SingleNote_0;

			// Token: 0x04008349 RID: 33609
			private static readonly IntPtr NativeMethodInfoPtr_PreloadCalibration_Public_Static_Void_Func_1_Int64_0;

			// Token: 0x0400834A RID: 33610
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0400834B RID: 33611
			[FieldOffset(0)]
			public long startTime;

			// Token: 0x0400834C RID: 33612
			[FieldOffset(8)]
			public long endTime;

			// Token: 0x0400834D RID: 33613
			[FieldOffset(16)]
			public IzakayaMusic.SingleNote.NoteType noteType;

			// Token: 0x0400834E RID: 33614
			[FieldOffset(20)]
			public IzakayaMusic.SingleNote.NotePosition positionType;

			// Token: 0x0200100F RID: 4111
			[Flags]
			public enum NotePosition : byte
			{
				// Token: 0x0400B1FC RID: 45564
				None = 0,
				// Token: 0x0400B1FD RID: 45565
				Left = 1,
				// Token: 0x0400B1FE RID: 45566
				Right = 2,
				// Token: 0x0400B1FF RID: 45567
				Any = 3
			}

			// Token: 0x02001010 RID: 4112
			public enum NoteType
			{
				// Token: 0x0400B201 RID: 45569
				Single,
				// Token: 0x0400B202 RID: 45570
				Hold,
				// Token: 0x0400B203 RID: 45571
				HoldSingle,
				// Token: 0x0400B204 RID: 45572
				HoldEnd
			}
		}
	}
}
