using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000090 RID: 144
	public class PatchouliSpellBase : Il2CppSystem.Object
	{
		// Token: 0x06000DC4 RID: 3524 RVA: 0x000CC1F4 File Offset: 0x000CA3F4
		// Note: this type is marked as 'beforefieldinit'.
		static PatchouliSpellBase()
		{
			Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "PatchouliSpellBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr);
			PatchouliSpellBase.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, "duration");
			PatchouliSpellBase.NativeFieldInfoPtr_endVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, "endVfx");
			PatchouliSpellBase.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, "index");
			PatchouliSpellBase.NativeFieldInfoPtr_vfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, "vfx");
			PatchouliSpellBase.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_New_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, 100665578);
			PatchouliSpellBase.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, 100665579);
			PatchouliSpellBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr, 100665580);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x000CC2B0 File Offset: 0x000CA4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44241, XrefRangeEnd = 44245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string DescriptionMethodB(string oldText, int currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PatchouliSpellBase.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_New_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x000CC314 File Offset: 0x000CA514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44245, XrefRangeEnd = 44250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string DescriptionMethodD(string oldText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PatchouliSpellBase.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000CC368 File Offset: 0x000CA568
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatchouliSpellBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatchouliSpellBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatchouliSpellBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000093A7 File Offset: 0x000075A7
		public PatchouliSpellBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x000CC3A4 File Offset: 0x000CA5A4
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x000093B0 File Offset: 0x000075B0
		public unsafe int duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000CC3CC File Offset: 0x000CA5CC
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000093CB File Offset: 0x000075CB
		public unsafe GameObject endVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_endVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_endVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000CC3FC File Offset: 0x000CA5FC
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000093EA File Offset: 0x000075EA
		public unsafe PatchouliMagicSpellCardIndex index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000CC424 File Offset: 0x000CA624
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00009405 File Offset: 0x00007605
		public unsafe GameObject vfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_vfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatchouliSpellBase.NativeFieldInfoPtr_vfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr_endVfx;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_vfx;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_New_String_String_Int32_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_New_String_String_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
