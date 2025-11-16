using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003DA RID: 986
	public class COM_CommonPannels_Close : PlayableAsset
	{
		// Token: 0x060075E0 RID: 30176 RVA: 0x00227694 File Offset: 0x00225894
		// Note: this type is marked as 'beforefieldinit'.
		static COM_CommonPannels_Close()
		{
			Il2CppClassPointerStore<COM_CommonPannels_Close>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_CommonPannels_Close");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_CommonPannels_Close>.NativeClassPtr);
			COM_CommonPannels_Close.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Close>.NativeClassPtr, 100687469);
			COM_CommonPannels_Close.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Close>.NativeClassPtr, 100687470);
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x002276EC File Offset: 0x002258EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292465, XrefRangeEnd = 292477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_CommonPannels_Close.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x00227754 File Offset: 0x00225954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_CommonPannels_Close() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_CommonPannels_Close>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_CommonPannels_Close.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x0003FCA5 File Offset: 0x0003DEA5
		public COM_CommonPannels_Close(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E1A RID: 19994
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E1B RID: 19995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
