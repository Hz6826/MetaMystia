using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MusicGame.UI
{
	// Token: 0x02000028 RID: 40
	public sealed class MusicSelectorConfirmPannelOpenContext : ValueType
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x000AAE9C File Offset: 0x000A909C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSelectorConfirmPannelOpenContext()
		{
			Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicSelectorConfirmPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr);
			MusicSelectorConfirmPannelOpenContext.NativeFieldInfoPtr_MusicID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr, "MusicID");
			MusicSelectorConfirmPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr, 100663844);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000AAEF4 File Offset: 0x000A90F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 2767, RefRangeEnd = 2776, XrefRangeStart = 2767, XrefRangeEnd = 2776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSelectorConfirmPannelOpenContext(string musicID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000042B5 File Offset: 0x000024B5
		public MusicSelectorConfirmPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000042BE File Offset: 0x000024BE
		public MusicSelectorConfirmPannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000AAF44 File Offset: 0x000A9144
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000042D0 File Offset: 0x000024D0
		public unsafe string MusicID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannelOpenContext.NativeFieldInfoPtr_MusicID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannelOpenContext.NativeFieldInfoPtr_MusicID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_MusicID;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
