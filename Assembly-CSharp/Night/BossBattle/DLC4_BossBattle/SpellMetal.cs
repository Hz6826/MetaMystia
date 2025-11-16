using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class SpellMetal : PatchouliSpellBase
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x000CB6AC File Offset: 0x000C98AC
		// Note: this type is marked as 'beforefieldinit'.
		static SpellMetal()
		{
			Il2CppClassPointerStore<SpellMetal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellMetal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr);
			SpellMetal.NativeFieldInfoPtr_pGetPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr, "pGetPerSec");
			SpellMetal.NativeFieldInfoPtr_basePLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr, "basePLine");
			SpellMetal.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr, 100665562);
			SpellMetal.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr, 100665563);
			SpellMetal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr, 100665564);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000CB740 File Offset: 0x000C9940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44171, XrefRangeEnd = 44183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodB(string oldText, int currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellMetal.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000CB7A4 File Offset: 0x000C99A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44183, XrefRangeEnd = 44196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodD(string oldText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellMetal.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000CB7F8 File Offset: 0x000C99F8
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellMetal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellMetal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellMetal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x000090C4 File Offset: 0x000072C4
		public SpellMetal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000CB834 File Offset: 0x000C9A34
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x000090CD File Offset: 0x000072CD
		public unsafe int pGetPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellMetal.NativeFieldInfoPtr_pGetPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellMetal.NativeFieldInfoPtr_pGetPerSec)) = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000CB85C File Offset: 0x000C9A5C
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x000090E8 File Offset: 0x000072E8
		public unsafe int basePLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellMetal.NativeFieldInfoPtr_basePLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellMetal.NativeFieldInfoPtr_basePLine)) = value;
			}
		}

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_pGetPerSec;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_basePLine;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
