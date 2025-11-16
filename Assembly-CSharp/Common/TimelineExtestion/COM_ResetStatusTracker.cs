using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000404 RID: 1028
	public class COM_ResetStatusTracker : PlayableAsset
	{
		// Token: 0x06007748 RID: 30536 RVA: 0x0022B88C File Offset: 0x00229A8C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ResetStatusTracker()
		{
			Il2CppClassPointerStore<COM_ResetStatusTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ResetStatusTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ResetStatusTracker>.NativeClassPtr);
			COM_ResetStatusTracker.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ResetStatusTracker>.NativeClassPtr, 100687563);
			COM_ResetStatusTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ResetStatusTracker>.NativeClassPtr, 100687564);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x0022B8E4 File Offset: 0x00229AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293131, XrefRangeEnd = 293140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ResetStatusTracker.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x0022B94C File Offset: 0x00229B4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ResetStatusTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ResetStatusTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ResetStatusTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x0004081F File Offset: 0x0003EA1F
		public COM_ResetStatusTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004ED3 RID: 20179
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004ED4 RID: 20180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
