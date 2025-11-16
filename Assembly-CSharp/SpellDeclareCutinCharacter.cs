using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class SpellDeclareCutinCharacter : MonoBehaviour
{
	// Token: 0x06000028 RID: 40 RVA: 0x0009F62C File Offset: 0x0009D82C
	// Note: this type is marked as 'beforefieldinit'.
	static SpellDeclareCutinCharacter()
	{
		Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpellDeclareCutinCharacter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr);
		SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_OutlineImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr, "m_OutlineImage");
		SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_OutlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr, "m_OutlineWidth");
		SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_ImagesPivotFixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr, "m_ImagesPivotFixed");
		SpellDeclareCutinCharacter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr, 100663316);
		SpellDeclareCutinCharacter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr, 100663317);
		SpellDeclareCutinCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr, 100663318);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0009F6D4 File Offset: 0x0009D8D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169, XrefRangeEnd = 173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellDeclareCutinCharacter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0009F708 File Offset: 0x0009D908
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173, XrefRangeEnd = 189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellDeclareCutinCharacter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0009F73C File Offset: 0x0009D93C
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 189, XrefRangeEnd = 190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpellDeclareCutinCharacter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellDeclareCutinCharacter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellDeclareCutinCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000206B File Offset: 0x0000026B
	public SpellDeclareCutinCharacter(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600002D RID: 45 RVA: 0x0009F778 File Offset: 0x0009D978
	// (set) Token: 0x0600002E RID: 46 RVA: 0x00002074 File Offset: 0x00000274
	public unsafe Image m_OutlineImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_OutlineImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_OutlineImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600002F RID: 47 RVA: 0x0009F7A8 File Offset: 0x0009D9A8
	// (set) Token: 0x06000030 RID: 48 RVA: 0x00002093 File Offset: 0x00000293
	public unsafe float m_OutlineWidth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_OutlineWidth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_OutlineWidth)) = value;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000031 RID: 49 RVA: 0x0009F7D0 File Offset: 0x0009D9D0
	// (set) Token: 0x06000032 RID: 50 RVA: 0x000020AE File Offset: 0x000002AE
	public unsafe Il2CppReferenceArray<Image> m_ImagesPivotFixed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_ImagesPivotFixed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellDeclareCutinCharacter.NativeFieldInfoPtr_m_ImagesPivotFixed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeFieldInfoPtr_m_OutlineImage;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeFieldInfoPtr_m_OutlineWidth;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeFieldInfoPtr_m_ImagesPivotFixed;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
