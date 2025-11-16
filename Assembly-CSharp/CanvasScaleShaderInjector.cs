using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class CanvasScaleShaderInjector : MonoBehaviour
{
	// Token: 0x0600004D RID: 77 RVA: 0x0009FC6C File Offset: 0x0009DE6C
	// Note: this type is marked as 'beforefieldinit'.
	static CanvasScaleShaderInjector()
	{
		Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CanvasScaleShaderInjector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr);
		CanvasScaleShaderInjector.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr, "m_RectTransform");
		CanvasScaleShaderInjector.NativeFieldInfoPtr_m_ShaderKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr, "m_ShaderKeyword");
		CanvasScaleShaderInjector.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr, 100663330);
		CanvasScaleShaderInjector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr, 100663331);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0009FCEC File Offset: 0x0009DEEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2782, XrefRangeEnd = 2785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRectTransformDimensionsChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaleShaderInjector.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0009FD20 File Offset: 0x0009DF20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2785, XrefRangeEnd = 2790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanvasScaleShaderInjector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaleShaderInjector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaleShaderInjector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000021BE File Offset: 0x000003BE
	public CanvasScaleShaderInjector(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000051 RID: 81 RVA: 0x0009FD5C File Offset: 0x0009DF5C
	// (set) Token: 0x06000052 RID: 82 RVA: 0x000021C7 File Offset: 0x000003C7
	public unsafe RectTransform m_RectTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaleShaderInjector.NativeFieldInfoPtr_m_RectTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaleShaderInjector.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000053 RID: 83 RVA: 0x0009FD8C File Offset: 0x0009DF8C
	// (set) Token: 0x06000054 RID: 84 RVA: 0x000021E6 File Offset: 0x000003E6
	public unsafe string m_ShaderKeyword
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaleShaderInjector.NativeFieldInfoPtr_m_ShaderKeyword);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaleShaderInjector.NativeFieldInfoPtr_m_ShaderKeyword), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeFieldInfoPtr_m_ShaderKeyword;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Private_Void_0;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
