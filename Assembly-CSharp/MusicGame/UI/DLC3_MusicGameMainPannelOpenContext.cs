using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x0200002F RID: 47
	public sealed class DLC3_MusicGameMainPannelOpenContext : ValueType
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x000AD670 File Offset: 0x000AB870
		// Note: this type is marked as 'beforefieldinit'.
		static DLC3_MusicGameMainPannelOpenContext()
		{
			Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "DLC3_MusicGameMainPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr);
			DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicChapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, "MusicChapter");
			DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, "MusicalNoteSpeed");
			DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MissedNoteNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, "MissedNoteNum");
			DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_rockSpritePair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, "rockSpritePair");
			DLC3_MusicGameMainPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_MusicChapter_Single_Vector2Int_ValueTuple_2_RockSprites_RockSprites_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, 100663943);
			DLC3_MusicGameMainPannelOpenContext.NativeMethodInfoPtr_get_RockSpritesPair_Public_get_ValueTuple_2_RockSprites_RockSprites_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, 100663944);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000AD718 File Offset: 0x000AB918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23031, RefRangeEnd = 23032, XrefRangeStart = 23029, XrefRangeEnd = 23031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC3_MusicGameMainPannelOpenContext(MusicGameChapterProfile.MusicChapter musicChapter, float musicalNoteSpeed, Vector2Int missedNoteNum, ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites> rockSpritePair) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(musicChapter));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicalNoteSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missedNoteNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rockSpritePair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_MusicChapter_Single_Vector2Int_ValueTuple_2_RockSprites_RockSprites_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000AD7A4 File Offset: 0x000AB9A4
		public unsafe ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites> RockSpritesPair
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannelOpenContext.NativeMethodInfoPtr_get_RockSpritesPair_Public_get_ValueTuple_2_RockSprites_RockSprites_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites>(pointer);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000497E File Offset: 0x00002B7E
		public DLC3_MusicGameMainPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00004987 File Offset: 0x00002B87
		public DLC3_MusicGameMainPannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000AD7E0 File Offset: 0x000AB9E0
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00004999 File Offset: 0x00002B99
		public MusicGameChapterProfile.MusicChapter MusicChapter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicChapter);
				return new MusicGameChapterProfile.MusicChapter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicChapter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000AD810 File Offset: 0x000ABA10
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000049C7 File Offset: 0x00002BC7
		public unsafe float MusicalNoteSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed)) = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000AD838 File Offset: 0x000ABA38
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x000049E2 File Offset: 0x00002BE2
		public unsafe Vector2Int MissedNoteNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MissedNoteNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MissedNoteNum)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000AD860 File Offset: 0x000ABA60
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x000049FD File Offset: 0x00002BFD
		public ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites> rockSpritePair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_rockSpritePair);
				return new ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannelOpenContext.NativeFieldInfoPtr_rockSpritePair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_MusicChapter;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_MusicalNoteSpeed;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_MissedNoteNum;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_rockSpritePair;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MusicChapter_Single_Vector2Int_ValueTuple_2_RockSprites_RockSprites_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_get_RockSpritesPair_Public_get_ValueTuple_2_RockSprites_RockSprites_0;
	}
}
