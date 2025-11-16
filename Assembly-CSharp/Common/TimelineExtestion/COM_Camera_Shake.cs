using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F5 RID: 1013
	public class COM_Camera_Shake : PlayableAsset
	{
		// Token: 0x060076E4 RID: 30436 RVA: 0x0022A4F0 File Offset: 0x002286F0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_Shake()
		{
			Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_Shake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr);
			COM_Camera_Shake.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr, "amplitude");
			COM_Camera_Shake.NativeFieldInfoPtr__duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr, "_duration");
			COM_Camera_Shake.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr, 100687533);
			COM_Camera_Shake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr, 100687534);
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x0022A570 File Offset: 0x00228770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292935, XrefRangeEnd = 292949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_Shake.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x0022A5D8 File Offset: 0x002287D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_Shake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_Shake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_Shake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00040560 File Offset: 0x0003E760
		public COM_Camera_Shake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x0022A614 File Offset: 0x00228814
		// (set) Token: 0x060076E9 RID: 30441 RVA: 0x00040569 File Offset: 0x0003E769
		public unsafe float amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x060076EA RID: 30442 RVA: 0x0022A63C File Offset: 0x0022883C
		// (set) Token: 0x060076EB RID: 30443 RVA: 0x00040584 File Offset: 0x0003E784
		public unsafe float _duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake.NativeFieldInfoPtr__duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake.NativeFieldInfoPtr__duration)) = value;
			}
		}

		// Token: 0x04004EA1 RID: 20129
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04004EA2 RID: 20130
		private static readonly IntPtr NativeFieldInfoPtr__duration;

		// Token: 0x04004EA3 RID: 20131
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EA4 RID: 20132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
