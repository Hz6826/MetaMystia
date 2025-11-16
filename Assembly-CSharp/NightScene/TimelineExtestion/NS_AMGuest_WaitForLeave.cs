using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001FB RID: 507
	public class NS_AMGuest_WaitForLeave : PlayableAsset
	{
		// Token: 0x06003D09 RID: 15625 RVA: 0x0016D90C File Offset: 0x0016BB0C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_AMGuest_WaitForLeave()
		{
			Il2CppClassPointerStore<NS_AMGuest_WaitForLeave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_AMGuest_WaitForLeave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave>.NativeClassPtr);
			NS_AMGuest_WaitForLeave.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave>.NativeClassPtr, 100674544);
			NS_AMGuest_WaitForLeave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave>.NativeClassPtr, 100674545);
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x0016D964 File Offset: 0x0016BB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137046, XrefRangeEnd = 137055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_AMGuest_WaitForLeave.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x0016D9CC File Offset: 0x0016BBCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_AMGuest_WaitForLeave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_AMGuest_WaitForLeave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x000222CA File Offset: 0x000204CA
		public NS_AMGuest_WaitForLeave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
