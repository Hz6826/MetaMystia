using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200008A RID: 138
	[Serializable]
	public class SpellWood : PatchouliSpellBase
	{
		// Token: 0x06000D8B RID: 3467 RVA: 0x000CB884 File Offset: 0x000C9A84
		// Note: this type is marked as 'beforefieldinit'.
		static SpellWood()
		{
			Il2CppClassPointerStore<SpellWood>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellWood");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellWood>.NativeClassPtr);
			SpellWood.NativeFieldInfoPtr_extraAttackSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellWood>.NativeClassPtr, "extraAttackSpeedMultiplier");
			SpellWood.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellWood>.NativeClassPtr, 100665565);
			SpellWood.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellWood>.NativeClassPtr, 100665566);
			SpellWood.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellWood>.NativeClassPtr, 100665567);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000CB904 File Offset: 0x000C9B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44196, XrefRangeEnd = 44205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodB(string oldText, int currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellWood.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000CB968 File Offset: 0x000C9B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44205, XrefRangeEnd = 44214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodD(string oldText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellWood.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000CB9BC File Offset: 0x000C9BBC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellWood() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellWood>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellWood.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00009103 File Offset: 0x00007303
		public SpellWood(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000CB9F8 File Offset: 0x000C9BF8
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x0000910C File Offset: 0x0000730C
		public unsafe float extraAttackSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellWood.NativeFieldInfoPtr_extraAttackSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellWood.NativeFieldInfoPtr_extraAttackSpeedMultiplier)) = value;
			}
		}

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_extraAttackSpeedMultiplier;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
