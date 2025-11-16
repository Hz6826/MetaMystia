using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001FF RID: 511
	public class NS_MGuest_EvalR_Clear : PlayableAsset
	{
		// Token: 0x06003D1F RID: 15647 RVA: 0x0016DDB8 File Offset: 0x0016BFB8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_EvalR_Clear()
		{
			Il2CppClassPointerStore<NS_MGuest_EvalR_Clear>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_EvalR_Clear");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear>.NativeClassPtr);
			NS_MGuest_EvalR_Clear.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear>.NativeClassPtr, 100674552);
			NS_MGuest_EvalR_Clear.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear>.NativeClassPtr, 100674553);
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x0016DE10 File Offset: 0x0016C010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137091, XrefRangeEnd = 137100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_EvalR_Clear.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x0016DE78 File Offset: 0x0016C078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_EvalR_Clear() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_EvalR_Clear.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00022343 File Offset: 0x00020543
		public NS_MGuest_EvalR_Clear(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
