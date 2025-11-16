using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000401 RID: 1025
	public class COM_OverrideBGM_Play : PlayableAsset
	{
		// Token: 0x06007738 RID: 30520 RVA: 0x0022B510 File Offset: 0x00229710
		// Note: this type is marked as 'beforefieldinit'.
		static COM_OverrideBGM_Play()
		{
			Il2CppClassPointerStore<COM_OverrideBGM_Play>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_OverrideBGM_Play");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_OverrideBGM_Play>.NativeClassPtr);
			COM_OverrideBGM_Play.NativeFieldInfoPtr_musicPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_OverrideBGM_Play>.NativeClassPtr, "musicPackage");
			COM_OverrideBGM_Play.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Play>.NativeClassPtr, 100687557);
			COM_OverrideBGM_Play.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Play>.NativeClassPtr, 100687558);
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x0022B57C File Offset: 0x0022977C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293096, XrefRangeEnd = 293109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_OverrideBGM_Play.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x0022B5E4 File Offset: 0x002297E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_OverrideBGM_Play() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_OverrideBGM_Play>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_OverrideBGM_Play.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x000407C6 File Offset: 0x0003E9C6
		public COM_OverrideBGM_Play(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x0600773C RID: 30524 RVA: 0x0022B620 File Offset: 0x00229820
		// (set) Token: 0x0600773D RID: 30525 RVA: 0x000407CF File Offset: 0x0003E9CF
		public unsafe LoopedBGMPackage musicPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_Play.NativeFieldInfoPtr_musicPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_OverrideBGM_Play.NativeFieldInfoPtr_musicPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004ECB RID: 20171
		private static readonly IntPtr NativeFieldInfoPtr_musicPackage;

		// Token: 0x04004ECC RID: 20172
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004ECD RID: 20173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
