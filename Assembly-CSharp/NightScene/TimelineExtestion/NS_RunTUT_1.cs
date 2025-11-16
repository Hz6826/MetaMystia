using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200020E RID: 526
	public class NS_RunTUT_1 : PlayableAsset
	{
		// Token: 0x06003D9D RID: 15773 RVA: 0x0016F450 File Offset: 0x0016D650
		// Note: this type is marked as 'beforefieldinit'.
		static NS_RunTUT_1()
		{
			Il2CppClassPointerStore<NS_RunTUT_1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_RunTUT_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_RunTUT_1>.NativeClassPtr);
			NS_RunTUT_1.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_1>.NativeClassPtr, 100674582);
			NS_RunTUT_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_1>.NativeClassPtr, 100674583);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x0016F4A8 File Offset: 0x0016D6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137320, XrefRangeEnd = 137329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_RunTUT_1.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x0016F510 File Offset: 0x0016D710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_RunTUT_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_RunTUT_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_RunTUT_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00022779 File Offset: 0x00020979
		public NS_RunTUT_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
