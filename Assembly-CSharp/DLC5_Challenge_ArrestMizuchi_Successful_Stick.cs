using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class DLC5_Challenge_ArrestMizuchi_Successful_Stick : MonoBehaviour
{
	// Token: 0x060001C6 RID: 454 RVA: 0x000A4CC0 File Offset: 0x000A2EC0
	// Note: this type is marked as 'beforefieldinit'.
	static DLC5_Challenge_ArrestMizuchi_Successful_Stick()
	{
		Il2CppClassPointerStore<DLC5_Challenge_ArrestMizuchi_Successful_Stick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC5_Challenge_ArrestMizuchi_Successful_Stick");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_Challenge_ArrestMizuchi_Successful_Stick>.NativeClassPtr);
		DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeFieldInfoPtr_m_BlackScreenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_Challenge_ArrestMizuchi_Successful_Stick>.NativeClassPtr, "m_BlackScreenSFX");
		DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeMethodInfoPtr_OnBlackScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Challenge_ArrestMizuchi_Successful_Stick>.NativeClassPtr, 100663549);
		DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_Challenge_ArrestMizuchi_Successful_Stick>.NativeClassPtr, 100663550);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x000A4D2C File Offset: 0x000A2F2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19075, XrefRangeEnd = 19083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBlackScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeMethodInfoPtr_OnBlackScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x000A4D60 File Offset: 0x000A2F60
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC5_Challenge_ArrestMizuchi_Successful_Stick() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_Challenge_ArrestMizuchi_Successful_Stick>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002E78 File Offset: 0x00001078
	public DLC5_Challenge_ArrestMizuchi_Successful_Stick(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060001CA RID: 458 RVA: 0x000A4D9C File Offset: 0x000A2F9C
	// (set) Token: 0x060001CB RID: 459 RVA: 0x00002E81 File Offset: 0x00001081
	public unsafe AudioClip m_BlackScreenSFX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeFieldInfoPtr_m_BlackScreenSFX);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_Challenge_ArrestMizuchi_Successful_Stick.NativeFieldInfoPtr_m_BlackScreenSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000126 RID: 294
	private static readonly IntPtr NativeFieldInfoPtr_m_BlackScreenSFX;

	// Token: 0x04000127 RID: 295
	private static readonly IntPtr NativeMethodInfoPtr_OnBlackScreen_Public_Void_0;

	// Token: 0x04000128 RID: 296
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
