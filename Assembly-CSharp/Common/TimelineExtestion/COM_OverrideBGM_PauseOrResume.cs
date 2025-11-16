using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000400 RID: 1024
	public class COM_OverrideBGM_PauseOrResume : PlayableAsset
	{
		// Token: 0x06007732 RID: 30514 RVA: 0x0022B3D8 File Offset: 0x002295D8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_OverrideBGM_PauseOrResume()
		{
			Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_OverrideBGM_PauseOrResume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume>.NativeClassPtr);
			COM_OverrideBGM_PauseOrResume.NativeFieldInfoPtr_shouldResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume>.NativeClassPtr, "shouldResume");
			COM_OverrideBGM_PauseOrResume.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume>.NativeClassPtr, 100687555);
			COM_OverrideBGM_PauseOrResume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume>.NativeClassPtr, 100687556);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x0022B444 File Offset: 0x00229644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293084, XrefRangeEnd = 293096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_OverrideBGM_PauseOrResume.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x0022B4AC File Offset: 0x002296AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_OverrideBGM_PauseOrResume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_OverrideBGM_PauseOrResume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_OverrideBGM_PauseOrResume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x000407A2 File Offset: 0x0003E9A2
		public COM_OverrideBGM_PauseOrResume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x0022B4E8 File Offset: 0x002296E8
		// (set) Token: 0x06007737 RID: 30519 RVA: 0x000407AB File Offset: 0x0003E9AB
		public unsafe bool shouldResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_PauseOrResume.NativeFieldInfoPtr_shouldResume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_PauseOrResume.NativeFieldInfoPtr_shouldResume)) = value;
			}
		}

		// Token: 0x04004EC8 RID: 20168
		private static readonly IntPtr NativeFieldInfoPtr_shouldResume;

		// Token: 0x04004EC9 RID: 20169
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004ECA RID: 20170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
