using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003EA RID: 1002
	public class COM_ACharacter_Shake_Unmanaged : PlayableAsset
	{
		// Token: 0x0600767C RID: 30332 RVA: 0x002292FC File Offset: 0x002274FC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Shake_Unmanaged()
		{
			Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Shake_Unmanaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr);
			COM_ACharacter_Shake_Unmanaged.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr, "label");
			COM_ACharacter_Shake_Unmanaged.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr, "amplitude");
			COM_ACharacter_Shake_Unmanaged.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr, 100687511);
			COM_ACharacter_Shake_Unmanaged.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr, 100687512);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x0022937C File Offset: 0x0022757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292778, XrefRangeEnd = 292793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Shake_Unmanaged.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x002293E4 File Offset: 0x002275E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Shake_Unmanaged() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Shake_Unmanaged.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x000401B3 File Offset: 0x0003E3B3
		public COM_ACharacter_Shake_Unmanaged(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06007680 RID: 30336 RVA: 0x00229420 File Offset: 0x00227620
		// (set) Token: 0x06007681 RID: 30337 RVA: 0x000401BC File Offset: 0x0003E3BC
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x06007682 RID: 30338 RVA: 0x00229448 File Offset: 0x00227648
		// (set) Token: 0x06007683 RID: 30339 RVA: 0x000401DB File Offset: 0x0003E3DB
		public unsafe Vector2 amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x04004E6D RID: 20077
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E6E RID: 20078
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04004E6F RID: 20079
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E70 RID: 20080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
