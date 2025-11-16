using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MusicGame.UI
{
	// Token: 0x0200001F RID: 31
	public sealed class MusicGameMainPannelOpenContext : ValueType
	{
		// Token: 0x06000281 RID: 641 RVA: 0x000A70BC File Offset: 0x000A52BC
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMainPannelOpenContext()
		{
			Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameMainPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr);
			MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, "MusicID");
			MusicGameMainPannelOpenContext.NativeFieldInfoPtr_isEasyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, "isEasyMode");
			MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, "MusicalNoteSpeed");
			MusicGameMainPannelOpenContext.NativeFieldInfoPtr_isAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, "isAutoPlay");
			MusicGameMainPannelOpenContext.NativeFieldInfoPtr_skipMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, "skipMode");
			MusicGameMainPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, 100663681);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000A7164 File Offset: 0x000A5364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20494, RefRangeEnd = 20495, XrefRangeStart = 20493, XrefRangeEnd = 20494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMainPannelOpenContext(string musicID, bool isEasyMode, float musicalNoteSpeed, bool isAutoPlay, bool skipMode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEasyMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicalNoteSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAutoPlay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Single_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000034CD File Offset: 0x000016CD
		public MusicGameMainPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000034D6 File Offset: 0x000016D6
		public MusicGameMainPannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr))
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000A71EC File Offset: 0x000A53EC
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000034E8 File Offset: 0x000016E8
		public unsafe string MusicID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000A7214 File Offset: 0x000A5414
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003507 File Offset: 0x00001707
		public unsafe bool isEasyMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_isEasyMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_isEasyMode)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000289 RID: 649 RVA: 0x000A723C File Offset: 0x000A543C
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003522 File Offset: 0x00001722
		public unsafe float MusicalNoteSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000A7264 File Offset: 0x000A5464
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0000353D File Offset: 0x0000173D
		public unsafe bool isAutoPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_isAutoPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_isAutoPlay)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000A728C File Offset: 0x000A548C
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003558 File Offset: 0x00001758
		public unsafe bool skipMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_skipMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannelOpenContext.NativeFieldInfoPtr_skipMode)) = value;
			}
		}

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_MusicID;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_isEasyMode;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_MusicalNoteSpeed;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_isAutoPlay;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_skipMode;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Single_Boolean_Boolean_0;
	}
}
