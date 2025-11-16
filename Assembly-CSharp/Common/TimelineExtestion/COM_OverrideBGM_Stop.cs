using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000402 RID: 1026
	public class COM_OverrideBGM_Stop : PlayableAsset
	{
		// Token: 0x0600773E RID: 30526 RVA: 0x0022B650 File Offset: 0x00229850
		// Note: this type is marked as 'beforefieldinit'.
		static COM_OverrideBGM_Stop()
		{
			Il2CppClassPointerStore<COM_OverrideBGM_Stop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_OverrideBGM_Stop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_OverrideBGM_Stop>.NativeClassPtr);
			COM_OverrideBGM_Stop.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Stop>.NativeClassPtr, 100687559);
			COM_OverrideBGM_Stop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Stop>.NativeClassPtr, 100687560);
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x0022B6A8 File Offset: 0x002298A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293109, XrefRangeEnd = 293118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_OverrideBGM_Stop.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x0022B710 File Offset: 0x00229910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_OverrideBGM_Stop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_OverrideBGM_Stop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_OverrideBGM_Stop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x000407EE File Offset: 0x0003E9EE
		public COM_OverrideBGM_Stop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004ECE RID: 20174
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004ECF RID: 20175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
