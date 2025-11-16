using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000403 RID: 1027
	public class COM_PlayAudioSFX : PlayableAsset
	{
		// Token: 0x06007742 RID: 30530 RVA: 0x0022B74C File Offset: 0x0022994C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_PlayAudioSFX()
		{
			Il2CppClassPointerStore<COM_PlayAudioSFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_PlayAudioSFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_PlayAudioSFX>.NativeClassPtr);
			COM_PlayAudioSFX.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_PlayAudioSFX>.NativeClassPtr, "audioClip");
			COM_PlayAudioSFX.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_PlayAudioSFX>.NativeClassPtr, 100687561);
			COM_PlayAudioSFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_PlayAudioSFX>.NativeClassPtr, 100687562);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x0022B7B8 File Offset: 0x002299B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293118, XrefRangeEnd = 293131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_PlayAudioSFX.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x0022B820 File Offset: 0x00229A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_PlayAudioSFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_PlayAudioSFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_PlayAudioSFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x000407F7 File Offset: 0x0003E9F7
		public COM_PlayAudioSFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x06007746 RID: 30534 RVA: 0x0022B85C File Offset: 0x00229A5C
		// (set) Token: 0x06007747 RID: 30535 RVA: 0x00040800 File Offset: 0x0003EA00
		public unsafe AudioClip audioClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_PlayAudioSFX.NativeFieldInfoPtr_audioClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_PlayAudioSFX.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004ED0 RID: 20176
		private static readonly IntPtr NativeFieldInfoPtr_audioClip;

		// Token: 0x04004ED1 RID: 20177
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004ED2 RID: 20178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
