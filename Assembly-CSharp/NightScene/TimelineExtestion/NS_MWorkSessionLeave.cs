using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200020A RID: 522
	public class NS_MWorkSessionLeave : PlayableAsset
	{
		// Token: 0x06003D87 RID: 15751 RVA: 0x0016EF9C File Offset: 0x0016D19C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MWorkSessionLeave()
		{
			Il2CppClassPointerStore<NS_MWorkSessionLeave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MWorkSessionLeave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MWorkSessionLeave>.NativeClassPtr);
			NS_MWorkSessionLeave.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MWorkSessionLeave>.NativeClassPtr, 100674574);
			NS_MWorkSessionLeave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MWorkSessionLeave>.NativeClassPtr, 100674575);
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x0016EFF4 File Offset: 0x0016D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137273, XrefRangeEnd = 137282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MWorkSessionLeave.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x0016F05C File Offset: 0x0016D25C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MWorkSessionLeave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MWorkSessionLeave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MWorkSessionLeave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x000226FC File Offset: 0x000208FC
		public NS_MWorkSessionLeave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
