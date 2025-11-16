using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000444 RID: 1092
	public class COM_PlayAudioSFXBehaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600796B RID: 31083 RVA: 0x002314B4 File Offset: 0x0022F6B4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_PlayAudioSFXBehaviour()
		{
			Il2CppClassPointerStore<COM_PlayAudioSFXBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_PlayAudioSFXBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_PlayAudioSFXBehaviour>.NativeClassPtr);
			COM_PlayAudioSFXBehaviour.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_PlayAudioSFXBehaviour>.NativeClassPtr, "audioClip");
			COM_PlayAudioSFXBehaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_PlayAudioSFXBehaviour>.NativeClassPtr, 100687729);
			COM_PlayAudioSFXBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_PlayAudioSFXBehaviour>.NativeClassPtr, 100687730);
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x00231520 File Offset: 0x0022F720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294081, XrefRangeEnd = 294086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_PlayAudioSFXBehaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x0023155C File Offset: 0x0022F75C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_PlayAudioSFXBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_PlayAudioSFXBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_PlayAudioSFXBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x000419B4 File Offset: 0x0003FBB4
		public COM_PlayAudioSFXBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x00231598 File Offset: 0x0022F798
		// (set) Token: 0x06007970 RID: 31088 RVA: 0x000419BD File Offset: 0x0003FBBD
		public unsafe AudioClip audioClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_PlayAudioSFXBehaviour.NativeFieldInfoPtr_audioClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_PlayAudioSFXBehaviour.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FEC RID: 20460
		private static readonly IntPtr NativeFieldInfoPtr_audioClip;

		// Token: 0x04004FED RID: 20461
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FEE RID: 20462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
