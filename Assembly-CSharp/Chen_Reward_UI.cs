using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000006 RID: 6
public class Chen_Reward_UI : MonoBehaviour
{
	// Token: 0x06000033 RID: 51 RVA: 0x0009F800 File Offset: 0x0009DA00
	// Note: this type is marked as 'beforefieldinit'.
	static Chen_Reward_UI()
	{
		Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Chen_Reward_UI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr);
		Chen_Reward_UI.NativeFieldInfoPtr_m_Image0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, "m_Image0");
		Chen_Reward_UI.NativeFieldInfoPtr_m_Image1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, "m_Image1");
		Chen_Reward_UI.NativeFieldInfoPtr_m_Image2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, "m_Image2");
		Chen_Reward_UI.NativeFieldInfoPtr_m_Image0MaterialFloat0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, "m_Image0MaterialFloat0");
		Chen_Reward_UI.NativeFieldInfoPtr_m_Image1MaterialFloat0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, "m_Image1MaterialFloat0");
		Chen_Reward_UI.NativeFieldInfoPtr_m_Image2MaterialFloat0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, "m_Image2MaterialFloat0");
		Chen_Reward_UI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, 100663319);
		Chen_Reward_UI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr, 100663320);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387, XrefRangeEnd = 395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chen_Reward_UI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0009F904 File Offset: 0x0009DB04
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chen_Reward_UI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chen_Reward_UI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chen_Reward_UI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000020CD File Offset: 0x000002CD
	public Chen_Reward_UI(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000037 RID: 55 RVA: 0x0009F940 File Offset: 0x0009DB40
	// (set) Token: 0x06000038 RID: 56 RVA: 0x000020D6 File Offset: 0x000002D6
	public unsafe Image m_Image0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000039 RID: 57 RVA: 0x0009F970 File Offset: 0x0009DB70
	// (set) Token: 0x0600003A RID: 58 RVA: 0x000020F5 File Offset: 0x000002F5
	public unsafe Image m_Image1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image1);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image1), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600003B RID: 59 RVA: 0x0009F9A0 File Offset: 0x0009DBA0
	// (set) Token: 0x0600003C RID: 60 RVA: 0x00002114 File Offset: 0x00000314
	public unsafe Image m_Image2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600003D RID: 61 RVA: 0x0009F9D0 File Offset: 0x0009DBD0
	// (set) Token: 0x0600003E RID: 62 RVA: 0x00002133 File Offset: 0x00000333
	public unsafe float m_Image0MaterialFloat0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image0MaterialFloat0);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image0MaterialFloat0)) = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600003F RID: 63 RVA: 0x0009F9F8 File Offset: 0x0009DBF8
	// (set) Token: 0x06000040 RID: 64 RVA: 0x0000214E File Offset: 0x0000034E
	public unsafe float m_Image1MaterialFloat0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image1MaterialFloat0);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image1MaterialFloat0)) = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000041 RID: 65 RVA: 0x0009FA20 File Offset: 0x0009DC20
	// (set) Token: 0x06000042 RID: 66 RVA: 0x00002169 File Offset: 0x00000369
	public unsafe float m_Image2MaterialFloat0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image2MaterialFloat0);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chen_Reward_UI.NativeFieldInfoPtr_m_Image2MaterialFloat0)) = value;
		}
	}

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeFieldInfoPtr_m_Image0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeFieldInfoPtr_m_Image1;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeFieldInfoPtr_m_Image2;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeFieldInfoPtr_m_Image0MaterialFloat0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeFieldInfoPtr_m_Image1MaterialFloat0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr_m_Image2MaterialFloat0;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
