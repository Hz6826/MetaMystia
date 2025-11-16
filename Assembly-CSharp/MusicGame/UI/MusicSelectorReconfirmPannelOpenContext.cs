using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MusicGame.UI
{
	// Token: 0x0200002D RID: 45
	public sealed class MusicSelectorReconfirmPannelOpenContext : ValueType
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x000AC77C File Offset: 0x000AA97C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSelectorReconfirmPannelOpenContext()
		{
			Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicSelectorReconfirmPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr);
			MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_MusicID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr, "MusicID");
			MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_IsBossMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr, "IsBossMode");
			MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr, "Difficulty");
			MusicSelectorReconfirmPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_DifficultyMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr, 100663914);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000AC7FC File Offset: 0x000AA9FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22861, RefRangeEnd = 22864, XrefRangeStart = 22860, XrefRangeEnd = 22861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSelectorReconfirmPannelOpenContext(string musicID, bool isBossMode, DifficultyMode difficulty) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBossMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorReconfirmPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_DifficultyMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000046F3 File Offset: 0x000028F3
		public MusicSelectorReconfirmPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000046FC File Offset: 0x000028FC
		public MusicSelectorReconfirmPannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorReconfirmPannelOpenContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000AC868 File Offset: 0x000AAA68
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000470E File Offset: 0x0000290E
		public unsafe string MusicID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_MusicID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_MusicID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000AC890 File Offset: 0x000AAA90
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0000472D File Offset: 0x0000292D
		public unsafe bool IsBossMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_IsBossMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_IsBossMode)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00004748 File Offset: 0x00002948
		public unsafe DifficultyMode Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_Difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorReconfirmPannelOpenContext.NativeFieldInfoPtr_Difficulty)) = value;
			}
		}

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_MusicID;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_IsBossMode;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_Difficulty;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_DifficultyMode_0;
	}
}
