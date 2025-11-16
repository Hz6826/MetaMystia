using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.RunTime.Common
{
	// Token: 0x0200022A RID: 554
	[Serializable]
	public sealed class PlayerMusicScoreSave : ValueType
	{
		// Token: 0x060041BE RID: 16830 RVA: 0x0017FBD8 File Offset: 0x0017DDD8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMusicScoreSave()
		{
			Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "PlayerMusicScoreSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr);
			PlayerMusicScoreSave.NativeFieldInfoPtr_realSaveTimeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr, "realSaveTimeCode");
			PlayerMusicScoreSave.NativeFieldInfoPtr_scoreData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr, "scoreData");
			PlayerMusicScoreSave.NativeMethodInfoPtr__ctor_Public_Void_DateTime_Dictionary_2_String_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr, 100675769);
			PlayerMusicScoreSave.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_PlayerMusicScoreSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr, 100675770);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0017FC58 File Offset: 0x0017DE58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163279, RefRangeEnd = 163283, XrefRangeStart = 163272, XrefRangeEnd = 163279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMusicScoreSave(DateTime realSaveTimeCode, Dictionary<string, ValueTuple<int, int>> scoreData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref realSaveTimeCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scoreData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMusicScoreSave.NativeMethodInfoPtr__ctor_Public_Void_DateTime_Dictionary_2_String_ValueTuple_2_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x0017FCB8 File Offset: 0x0017DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163283, XrefRangeEnd = 163290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMusicScoreSave Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerMusicScoreSave.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_PlayerMusicScoreSave_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerMusicScoreSave(pointer);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x00023891 File Offset: 0x00021A91
		public PlayerMusicScoreSave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x0002389A File Offset: 0x00021A9A
		public PlayerMusicScoreSave() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMusicScoreSave>.NativeClassPtr))
		{
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x0017FCF4 File Offset: 0x0017DEF4
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x000238AC File Offset: 0x00021AAC
		public unsafe DateTime realSaveTimeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMusicScoreSave.NativeFieldInfoPtr_realSaveTimeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMusicScoreSave.NativeFieldInfoPtr_realSaveTimeCode)) = value;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x0017FD1C File Offset: 0x0017DF1C
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x000238C7 File Offset: 0x00021AC7
		public unsafe Dictionary<string, ValueTuple<int, int>> scoreData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMusicScoreSave.NativeFieldInfoPtr_scoreData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<int, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMusicScoreSave.NativeFieldInfoPtr_scoreData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeFieldInfoPtr_realSaveTimeCode;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeFieldInfoPtr_scoreData;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_Dictionary_2_String_ValueTuple_2_Int32_Int32_0;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_PlayerMusicScoreSave_0;
	}
}
