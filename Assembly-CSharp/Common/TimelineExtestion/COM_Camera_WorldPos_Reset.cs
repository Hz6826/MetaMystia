using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F7 RID: 1015
	public class COM_Camera_WorldPos_Reset : PlayableAsset
	{
		// Token: 0x060076F4 RID: 30452 RVA: 0x0022A7D8 File Offset: 0x002289D8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_WorldPos_Reset()
		{
			Il2CppClassPointerStore<COM_Camera_WorldPos_Reset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_WorldPos_Reset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset>.NativeClassPtr);
			COM_Camera_WorldPos_Reset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset>.NativeClassPtr, 100687537);
			COM_Camera_WorldPos_Reset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset>.NativeClassPtr, 100687538);
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x0022A830 File Offset: 0x00228A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292965, XrefRangeEnd = 292974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_WorldPos_Reset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x0022A898 File Offset: 0x00228A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_WorldPos_Reset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_WorldPos_Reset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x000405E2 File Offset: 0x0003E7E2
		public COM_Camera_WorldPos_Reset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004EA9 RID: 20137
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EAA RID: 20138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
