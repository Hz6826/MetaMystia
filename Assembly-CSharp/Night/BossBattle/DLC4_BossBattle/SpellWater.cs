using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200008B RID: 139
	[Serializable]
	public class SpellWater : PatchouliSpellBase
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x000CBA20 File Offset: 0x000C9C20
		// Note: this type is marked as 'beforefieldinit'.
		static SpellWater()
		{
			Il2CppClassPointerStore<SpellWater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellWater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellWater>.NativeClassPtr);
			SpellWater.NativeFieldInfoPtr_extraCoolDownMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellWater>.NativeClassPtr, "extraCoolDownMultiplier");
			SpellWater.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellWater>.NativeClassPtr, 100665568);
			SpellWater.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellWater>.NativeClassPtr, 100665569);
			SpellWater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellWater>.NativeClassPtr, 100665570);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000CBAA0 File Offset: 0x000C9CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44214, XrefRangeEnd = 44223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodB(string oldText, int currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellWater.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000CBB04 File Offset: 0x000C9D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44223, XrefRangeEnd = 44232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodD(string oldText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellWater.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000CBB58 File Offset: 0x000C9D58
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellWater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellWater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellWater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00009127 File Offset: 0x00007327
		public SpellWater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x000CBB94 File Offset: 0x000C9D94
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00009130 File Offset: 0x00007330
		public unsafe float extraCoolDownMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellWater.NativeFieldInfoPtr_extraCoolDownMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellWater.NativeFieldInfoPtr_extraCoolDownMultiplier)) = value;
			}
		}

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_extraCoolDownMultiplier;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
