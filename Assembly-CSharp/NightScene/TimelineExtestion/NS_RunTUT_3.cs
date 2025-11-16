using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000210 RID: 528
	public class NS_RunTUT_3 : PlayableAsset
	{
		// Token: 0x06003DA5 RID: 15781 RVA: 0x0016F648 File Offset: 0x0016D848
		// Note: this type is marked as 'beforefieldinit'.
		static NS_RunTUT_3()
		{
			Il2CppClassPointerStore<NS_RunTUT_3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_RunTUT_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_RunTUT_3>.NativeClassPtr);
			NS_RunTUT_3.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_3>.NativeClassPtr, 100674586);
			NS_RunTUT_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_3>.NativeClassPtr, 100674587);
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x0016F6A0 File Offset: 0x0016D8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137338, XrefRangeEnd = 137347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_RunTUT_3.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x0016F708 File Offset: 0x0016D908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_RunTUT_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_RunTUT_3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_RunTUT_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x0002278B File Offset: 0x0002098B
		public NS_RunTUT_3(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
