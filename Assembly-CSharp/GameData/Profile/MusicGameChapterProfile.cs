using System;
using DEYU.UniversalUISystem;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x020002DE RID: 734
	public class MusicGameChapterProfile : ScriptableObject
	{
		// Token: 0x060059C1 RID: 22977 RVA: 0x001CB990 File Offset: 0x001C9B90
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameChapterProfile()
		{
			Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "MusicGameChapterProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr);
			MusicGameChapterProfile.NativeFieldInfoPtr_Chapters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr, "Chapters");
			MusicGameChapterProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr, 100681362);
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x001CB9E8 File Offset: 0x001C9BE8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameChapterProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x00030775 File Offset: 0x0002E975
		public MusicGameChapterProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x060059C4 RID: 22980 RVA: 0x001CBA24 File Offset: 0x001C9C24
		// (set) Token: 0x060059C5 RID: 22981 RVA: 0x0003077E File Offset: 0x0002E97E
		public unsafe Il2CppReferenceArray<MusicGameChapterProfile.MusicChapter> Chapters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.NativeFieldInfoPtr_Chapters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MusicGameChapterProfile.MusicChapter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.NativeFieldInfoPtr_Chapters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BDD RID: 15325
		private static readonly IntPtr NativeFieldInfoPtr_Chapters;

		// Token: 0x04003BDE RID: 15326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CAA RID: 3242
		[Serializable]
		public sealed class NPCMusicRank : ValueType
		{
			// Token: 0x0600E865 RID: 59493 RVA: 0x0037A288 File Offset: 0x00378488
			// Note: this type is marked as 'beforefieldinit'.
			static NPCMusicRank()
			{
				Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr, "NPCMusicRank");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr);
				MusicGameChapterProfile.NPCMusicRank.NativeFieldInfoPtr_npcLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr, "npcLabel");
				MusicGameChapterProfile.NPCMusicRank.NativeFieldInfoPtr_npcScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr, "npcScore");
				MusicGameChapterProfile.NPCMusicRank.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr, 100681363);
				MusicGameChapterProfile.NPCMusicRank.NativeMethodInfoPtr_get_NpcLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr, 100681364);
				MusicGameChapterProfile.NPCMusicRank.NativeMethodInfoPtr_get_NpcScore_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr, 100681365);
			}

			// Token: 0x0600E866 RID: 59494 RVA: 0x0037A318 File Offset: 0x00378518
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219582, RefRangeEnd = 219584, XrefRangeStart = 219581, XrefRangeEnd = 219582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NPCMusicRank(string npcLabel, Vector2Int npcScore) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref npcScore;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.NPCMusicRank.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B82 RID: 19330
			// (get) Token: 0x0600E867 RID: 59495 RVA: 0x0037A378 File Offset: 0x00378578
			public unsafe string NpcLabel
			{
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.NPCMusicRank.NativeMethodInfoPtr_get_NpcLabel_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004B83 RID: 19331
			// (get) Token: 0x0600E868 RID: 59496 RVA: 0x0037A3B4 File Offset: 0x003785B4
			public unsafe Vector2Int NpcScore
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.NPCMusicRank.NativeMethodInfoPtr_get_NpcScore_Public_get_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E869 RID: 59497 RVA: 0x0007C37C File Offset: 0x0007A57C
			public NPCMusicRank(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E86A RID: 59498 RVA: 0x0007C385 File Offset: 0x0007A585
			public NPCMusicRank() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameChapterProfile.NPCMusicRank>.NativeClassPtr))
			{
			}

			// Token: 0x17004B80 RID: 19328
			// (get) Token: 0x0600E86B RID: 59499 RVA: 0x0037A3F8 File Offset: 0x003785F8
			// (set) Token: 0x0600E86C RID: 59500 RVA: 0x0007C397 File Offset: 0x0007A597
			public unsafe string npcLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.NPCMusicRank.NativeFieldInfoPtr_npcLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.NPCMusicRank.NativeFieldInfoPtr_npcLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B81 RID: 19329
			// (get) Token: 0x0600E86D RID: 59501 RVA: 0x0037A420 File Offset: 0x00378620
			// (set) Token: 0x0600E86E RID: 59502 RVA: 0x0007C3B6 File Offset: 0x0007A5B6
			public unsafe Vector2Int npcScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.NPCMusicRank.NativeFieldInfoPtr_npcScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.NPCMusicRank.NativeFieldInfoPtr_npcScore)) = value;
				}
			}

			// Token: 0x04009441 RID: 37953
			private static readonly IntPtr NativeFieldInfoPtr_npcLabel;

			// Token: 0x04009442 RID: 37954
			private static readonly IntPtr NativeFieldInfoPtr_npcScore;

			// Token: 0x04009443 RID: 37955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector2Int_0;

			// Token: 0x04009444 RID: 37956
			private static readonly IntPtr NativeMethodInfoPtr_get_NpcLabel_Public_get_String_0;

			// Token: 0x04009445 RID: 37957
			private static readonly IntPtr NativeMethodInfoPtr_get_NpcScore_Public_get_Vector2Int_0;
		}

		// Token: 0x02000CAB RID: 3243
		[Serializable]
		public sealed class MusicChapter : ValueType
		{
			// Token: 0x0600E86F RID: 59503 RVA: 0x0037A448 File Offset: 0x00378648
			// Note: this type is marked as 'beforefieldinit'.
			static MusicChapter()
			{
				Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameChapterProfile>.NativeClassPtr, "MusicChapter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr);
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_musicLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "musicLabel");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_easyModeLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "easyModeLevel");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_hardModeLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "hardModeLevel");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_easySingleNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "easySingleNote");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_hardSingleNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "hardSingleNote");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_noteClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "noteClick");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "coverPic");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPicOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "coverPicOffset");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPicBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "coverPicBorderColor");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_musicAudioPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "musicAudioPackage");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_npcMusicRanks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "npcMusicRanks");
				MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_previewMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, "previewMusic");
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_MusicLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681366);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_EasyModeLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681367);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_HardModeLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681368);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_EasySingleNote_Public_get_Il2CppStructArray_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681369);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_HardSingleNote_Public_get_Il2CppStructArray_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681370);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_CoverPic_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681371);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_MusicAudioPackage_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681372);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_NoteClick_Public_get_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681373);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_NpcMusicRanks_Public_get_Il2CppReferenceArray_1_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681374);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_PreviewMusic_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681375);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_UpdateMap_Public_Void_Il2CppStructArray_1_SingleNote_Il2CppStructArray_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681376);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_ApplyCDImage_Public_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681377);
				MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_SetNpcMusicRanks_Public_Void_Il2CppReferenceArray_1_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, 100681378);
			}

			// Token: 0x17004B90 RID: 19344
			// (get) Token: 0x0600E870 RID: 59504 RVA: 0x0037A668 File Offset: 0x00378868
			public unsafe string MusicLabel
			{
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_MusicLabel_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004B91 RID: 19345
			// (get) Token: 0x0600E871 RID: 59505 RVA: 0x0037A6A4 File Offset: 0x003788A4
			public unsafe int EasyModeLevel
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 88495, RefRangeEnd = 88519, XrefRangeStart = 88495, XrefRangeEnd = 88519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_EasyModeLevel_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B92 RID: 19346
			// (get) Token: 0x0600E872 RID: 59506 RVA: 0x0037A6E8 File Offset: 0x003788E8
			public unsafe int HardModeLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_HardModeLevel_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B93 RID: 19347
			// (get) Token: 0x0600E873 RID: 59507 RVA: 0x0037A72C File Offset: 0x0037892C
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> EasySingleNote
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_EasySingleNote_Public_get_Il2CppStructArray_1_SingleNote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B94 RID: 19348
			// (get) Token: 0x0600E874 RID: 59508 RVA: 0x0037A770 File Offset: 0x00378970
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> HardSingleNote
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_HardSingleNote_Public_get_Il2CppStructArray_1_SingleNote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B95 RID: 19349
			// (get) Token: 0x0600E875 RID: 59509 RVA: 0x0037A7B4 File Offset: 0x003789B4
			public unsafe Sprite CoverPic
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_CoverPic_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
			}

			// Token: 0x17004B96 RID: 19350
			// (get) Token: 0x0600E876 RID: 59510 RVA: 0x0037A7F8 File Offset: 0x003789F8
			public unsafe AssetReference MusicAudioPackage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_MusicAudioPackage_Public_get_AssetReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
				}
			}

			// Token: 0x17004B97 RID: 19351
			// (get) Token: 0x0600E877 RID: 59511 RVA: 0x0037A83C File Offset: 0x00378A3C
			public unsafe Il2CppStructArray<long> NoteClick
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_NoteClick_Public_get_Il2CppStructArray_1_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B98 RID: 19352
			// (get) Token: 0x0600E878 RID: 59512 RVA: 0x0037A880 File Offset: 0x00378A80
			public unsafe Il2CppReferenceArray<MusicGameChapterProfile.NPCMusicRank> NpcMusicRanks
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 219589, RefRangeEnd = 219592, XrefRangeStart = 219584, XrefRangeEnd = 219589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_NpcMusicRanks_Public_get_Il2CppReferenceArray_1_NPCMusicRank_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MusicGameChapterProfile.NPCMusicRank>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B99 RID: 19353
			// (get) Token: 0x0600E879 RID: 59513 RVA: 0x0037A8C4 File Offset: 0x00378AC4
			public unsafe AssetReference PreviewMusic
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_get_PreviewMusic_Public_get_AssetReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
				}
			}

			// Token: 0x0600E87A RID: 59514 RVA: 0x0037A908 File Offset: 0x00378B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219592, XrefRangeEnd = 219594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateMap(Il2CppStructArray<IzakayaMusic.SingleNote> newEasy, Il2CppStructArray<IzakayaMusic.SingleNote> newHard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEasy);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newHard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_UpdateMap_Public_Void_Il2CppStructArray_1_SingleNote_Il2CppStructArray_1_SingleNote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E87B RID: 59515 RVA: 0x0037A964 File Offset: 0x00378B64
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 219606, RefRangeEnd = 219610, XrefRangeStart = 219594, XrefRangeEnd = 219606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyCDImage(UIElementCluster imageComponent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_ApplyCDImage_Public_Void_UIElementCluster_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E87C RID: 59516 RVA: 0x0037A9AC File Offset: 0x00378BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNpcMusicRanks(Il2CppReferenceArray<MusicGameChapterProfile.NPCMusicRank> ranks)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ranks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameChapterProfile.MusicChapter.NativeMethodInfoPtr_SetNpcMusicRanks_Public_Void_Il2CppReferenceArray_1_NPCMusicRank_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E87D RID: 59517 RVA: 0x0007C3D1 File Offset: 0x0007A5D1
			public MusicChapter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E87E RID: 59518 RVA: 0x0007C3DA File Offset: 0x0007A5DA
			public MusicChapter() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr))
			{
			}

			// Token: 0x17004B84 RID: 19332
			// (get) Token: 0x0600E87F RID: 59519 RVA: 0x0037A9F4 File Offset: 0x00378BF4
			// (set) Token: 0x0600E880 RID: 59520 RVA: 0x0007C3EC File Offset: 0x0007A5EC
			public unsafe string musicLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_musicLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_musicLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B85 RID: 19333
			// (get) Token: 0x0600E881 RID: 59521 RVA: 0x0037AA1C File Offset: 0x00378C1C
			// (set) Token: 0x0600E882 RID: 59522 RVA: 0x0007C40B File Offset: 0x0007A60B
			public unsafe int easyModeLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_easyModeLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_easyModeLevel)) = value;
				}
			}

			// Token: 0x17004B86 RID: 19334
			// (get) Token: 0x0600E883 RID: 59523 RVA: 0x0037AA44 File Offset: 0x00378C44
			// (set) Token: 0x0600E884 RID: 59524 RVA: 0x0007C426 File Offset: 0x0007A626
			public unsafe int hardModeLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_hardModeLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_hardModeLevel)) = value;
				}
			}

			// Token: 0x17004B87 RID: 19335
			// (get) Token: 0x0600E885 RID: 59525 RVA: 0x0037AA6C File Offset: 0x00378C6C
			// (set) Token: 0x0600E886 RID: 59526 RVA: 0x0007C441 File Offset: 0x0007A641
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> easySingleNote
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_easySingleNote);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_easySingleNote), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B88 RID: 19336
			// (get) Token: 0x0600E887 RID: 59527 RVA: 0x0037AA9C File Offset: 0x00378C9C
			// (set) Token: 0x0600E888 RID: 59528 RVA: 0x0007C460 File Offset: 0x0007A660
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> hardSingleNote
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_hardSingleNote);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_hardSingleNote), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B89 RID: 19337
			// (get) Token: 0x0600E889 RID: 59529 RVA: 0x0037AACC File Offset: 0x00378CCC
			// (set) Token: 0x0600E88A RID: 59530 RVA: 0x0007C47F File Offset: 0x0007A67F
			public unsafe Il2CppStructArray<long> noteClick
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_noteClick);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_noteClick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B8A RID: 19338
			// (get) Token: 0x0600E88B RID: 59531 RVA: 0x0037AAFC File Offset: 0x00378CFC
			// (set) Token: 0x0600E88C RID: 59532 RVA: 0x0007C49E File Offset: 0x0007A69E
			public unsafe Sprite coverPic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B8B RID: 19339
			// (get) Token: 0x0600E88D RID: 59533 RVA: 0x0037AB2C File Offset: 0x00378D2C
			// (set) Token: 0x0600E88E RID: 59534 RVA: 0x0007C4BD File Offset: 0x0007A6BD
			public unsafe Vector2 coverPicOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPicOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPicOffset)) = value;
				}
			}

			// Token: 0x17004B8C RID: 19340
			// (get) Token: 0x0600E88F RID: 59535 RVA: 0x0037AB54 File Offset: 0x00378D54
			// (set) Token: 0x0600E890 RID: 59536 RVA: 0x0007C4D8 File Offset: 0x0007A6D8
			public unsafe Color coverPicBorderColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPicBorderColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_coverPicBorderColor)) = value;
				}
			}

			// Token: 0x17004B8D RID: 19341
			// (get) Token: 0x0600E891 RID: 59537 RVA: 0x0037AB7C File Offset: 0x00378D7C
			// (set) Token: 0x0600E892 RID: 59538 RVA: 0x0007C4F3 File Offset: 0x0007A6F3
			public unsafe AssetReference musicAudioPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_musicAudioPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_musicAudioPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B8E RID: 19342
			// (get) Token: 0x0600E893 RID: 59539 RVA: 0x0037ABAC File Offset: 0x00378DAC
			// (set) Token: 0x0600E894 RID: 59540 RVA: 0x0007C512 File Offset: 0x0007A712
			public unsafe Il2CppReferenceArray<MusicGameChapterProfile.NPCMusicRank> npcMusicRanks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_npcMusicRanks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MusicGameChapterProfile.NPCMusicRank>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_npcMusicRanks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B8F RID: 19343
			// (get) Token: 0x0600E895 RID: 59541 RVA: 0x0037ABDC File Offset: 0x00378DDC
			// (set) Token: 0x0600E896 RID: 59542 RVA: 0x0007C531 File Offset: 0x0007A731
			public unsafe AssetReference previewMusic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_previewMusic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameChapterProfile.MusicChapter.NativeFieldInfoPtr_previewMusic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009446 RID: 37958
			private static readonly IntPtr NativeFieldInfoPtr_musicLabel;

			// Token: 0x04009447 RID: 37959
			private static readonly IntPtr NativeFieldInfoPtr_easyModeLevel;

			// Token: 0x04009448 RID: 37960
			private static readonly IntPtr NativeFieldInfoPtr_hardModeLevel;

			// Token: 0x04009449 RID: 37961
			private static readonly IntPtr NativeFieldInfoPtr_easySingleNote;

			// Token: 0x0400944A RID: 37962
			private static readonly IntPtr NativeFieldInfoPtr_hardSingleNote;

			// Token: 0x0400944B RID: 37963
			private static readonly IntPtr NativeFieldInfoPtr_noteClick;

			// Token: 0x0400944C RID: 37964
			private static readonly IntPtr NativeFieldInfoPtr_coverPic;

			// Token: 0x0400944D RID: 37965
			private static readonly IntPtr NativeFieldInfoPtr_coverPicOffset;

			// Token: 0x0400944E RID: 37966
			private static readonly IntPtr NativeFieldInfoPtr_coverPicBorderColor;

			// Token: 0x0400944F RID: 37967
			private static readonly IntPtr NativeFieldInfoPtr_musicAudioPackage;

			// Token: 0x04009450 RID: 37968
			private static readonly IntPtr NativeFieldInfoPtr_npcMusicRanks;

			// Token: 0x04009451 RID: 37969
			private static readonly IntPtr NativeFieldInfoPtr_previewMusic;

			// Token: 0x04009452 RID: 37970
			private static readonly IntPtr NativeMethodInfoPtr_get_MusicLabel_Public_get_String_0;

			// Token: 0x04009453 RID: 37971
			private static readonly IntPtr NativeMethodInfoPtr_get_EasyModeLevel_Public_get_Int32_0;

			// Token: 0x04009454 RID: 37972
			private static readonly IntPtr NativeMethodInfoPtr_get_HardModeLevel_Public_get_Int32_0;

			// Token: 0x04009455 RID: 37973
			private static readonly IntPtr NativeMethodInfoPtr_get_EasySingleNote_Public_get_Il2CppStructArray_1_SingleNote_0;

			// Token: 0x04009456 RID: 37974
			private static readonly IntPtr NativeMethodInfoPtr_get_HardSingleNote_Public_get_Il2CppStructArray_1_SingleNote_0;

			// Token: 0x04009457 RID: 37975
			private static readonly IntPtr NativeMethodInfoPtr_get_CoverPic_Public_get_Sprite_0;

			// Token: 0x04009458 RID: 37976
			private static readonly IntPtr NativeMethodInfoPtr_get_MusicAudioPackage_Public_get_AssetReference_0;

			// Token: 0x04009459 RID: 37977
			private static readonly IntPtr NativeMethodInfoPtr_get_NoteClick_Public_get_Il2CppStructArray_1_Int64_0;

			// Token: 0x0400945A RID: 37978
			private static readonly IntPtr NativeMethodInfoPtr_get_NpcMusicRanks_Public_get_Il2CppReferenceArray_1_NPCMusicRank_0;

			// Token: 0x0400945B RID: 37979
			private static readonly IntPtr NativeMethodInfoPtr_get_PreviewMusic_Public_get_AssetReference_0;

			// Token: 0x0400945C RID: 37980
			private static readonly IntPtr NativeMethodInfoPtr_UpdateMap_Public_Void_Il2CppStructArray_1_SingleNote_Il2CppStructArray_1_SingleNote_0;

			// Token: 0x0400945D RID: 37981
			private static readonly IntPtr NativeMethodInfoPtr_ApplyCDImage_Public_Void_UIElementCluster_0;

			// Token: 0x0400945E RID: 37982
			private static readonly IntPtr NativeMethodInfoPtr_SetNpcMusicRanks_Public_Void_Il2CppReferenceArray_1_NPCMusicRank_0;
		}
	}
}
