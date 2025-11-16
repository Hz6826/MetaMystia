using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class UnscaledTimeShaderInjector : MonoBehaviour
{
	// Token: 0x06000097 RID: 151 RVA: 0x000A0E40 File Offset: 0x0009F040
	// Note: this type is marked as 'beforefieldinit'.
	static UnscaledTimeShaderInjector()
	{
		Il2CppClassPointerStore<UnscaledTimeShaderInjector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnscaledTimeShaderInjector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnscaledTimeShaderInjector>.NativeClassPtr);
		UnscaledTimeShaderInjector.NativeFieldInfoPtr_m_ShaderKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnscaledTimeShaderInjector>.NativeClassPtr, "m_ShaderKeyword");
		UnscaledTimeShaderInjector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnscaledTimeShaderInjector>.NativeClassPtr, 100663370);
		UnscaledTimeShaderInjector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnscaledTimeShaderInjector>.NativeClassPtr, 100663371);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000A0EAC File Offset: 0x0009F0AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3467, XrefRangeEnd = 3469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnscaledTimeShaderInjector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000A0EE0 File Offset: 0x0009F0E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3469, XrefRangeEnd = 3486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnscaledTimeShaderInjector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnscaledTimeShaderInjector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnscaledTimeShaderInjector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000023FA File Offset: 0x000005FA
	public UnscaledTimeShaderInjector(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600009B RID: 155 RVA: 0x000A0F1C File Offset: 0x0009F11C
	// (set) Token: 0x0600009C RID: 156 RVA: 0x00002403 File Offset: 0x00000603
	public unsafe string m_ShaderKeyword
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnscaledTimeShaderInjector.NativeFieldInfoPtr_m_ShaderKeyword);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnscaledTimeShaderInjector.NativeFieldInfoPtr_m_ShaderKeyword), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeFieldInfoPtr_m_ShaderKeyword;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
