using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003ED RID: 1005
	public class COM_ADialog_Manual_Exit : PlayableAsset
	{
		// Token: 0x060076A4 RID: 30372 RVA: 0x00229938 File Offset: 0x00227B38
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Manual_Exit()
		{
			Il2CppClassPointerStore<COM_ADialog_Manual_Exit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Manual_Exit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Manual_Exit>.NativeClassPtr);
			COM_ADialog_Manual_Exit.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Exit>.NativeClassPtr, 100687517);
			COM_ADialog_Manual_Exit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Exit>.NativeClassPtr, 100687518);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x00229990 File Offset: 0x00227B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292822, XrefRangeEnd = 292831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Manual_Exit.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x002299F8 File Offset: 0x00227BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Manual_Exit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Manual_Exit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Exit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x0004035C File Offset: 0x0003E55C
		public COM_ADialog_Manual_Exit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E81 RID: 20097
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E82 RID: 20098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
