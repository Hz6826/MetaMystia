using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000211 RID: 529
	public class NS_SetPlayerToDefaultSpawn : PlayableAsset
	{
		// Token: 0x06003DA9 RID: 15785 RVA: 0x0016F744 File Offset: 0x0016D944
		// Note: this type is marked as 'beforefieldinit'.
		static NS_SetPlayerToDefaultSpawn()
		{
			Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_SetPlayerToDefaultSpawn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn>.NativeClassPtr);
			NS_SetPlayerToDefaultSpawn.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn>.NativeClassPtr, 100674588);
			NS_SetPlayerToDefaultSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn>.NativeClassPtr, 100674589);
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x0016F79C File Offset: 0x0016D99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137347, XrefRangeEnd = 137356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_SetPlayerToDefaultSpawn.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x0016F804 File Offset: 0x0016DA04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_SetPlayerToDefaultSpawn() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_SetPlayerToDefaultSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00022794 File Offset: 0x00020994
		public NS_SetPlayerToDefaultSpawn(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
