using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F6 RID: 1014
	public class COM_Camera_WorldPos_Follow : PlayableAsset
	{
		// Token: 0x060076EC RID: 30444 RVA: 0x0022A664 File Offset: 0x00228864
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_WorldPos_Follow()
		{
			Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_WorldPos_Follow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr);
			COM_Camera_WorldPos_Follow.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr, "label");
			COM_Camera_WorldPos_Follow.NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr, "damping");
			COM_Camera_WorldPos_Follow.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr, 100687535);
			COM_Camera_WorldPos_Follow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr, 100687536);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x0022A6E4 File Offset: 0x002288E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292949, XrefRangeEnd = 292964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_WorldPos_Follow.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x0022A74C File Offset: 0x0022894C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292964, XrefRangeEnd = 292965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_WorldPos_Follow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_WorldPos_Follow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x0004059F File Offset: 0x0003E79F
		public COM_Camera_WorldPos_Follow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x060076F0 RID: 30448 RVA: 0x0022A788 File Offset: 0x00228988
		// (set) Token: 0x060076F1 RID: 30449 RVA: 0x000405A8 File Offset: 0x0003E7A8
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x060076F2 RID: 30450 RVA: 0x0022A7B0 File Offset: 0x002289B0
		// (set) Token: 0x060076F3 RID: 30451 RVA: 0x000405C7 File Offset: 0x0003E7C7
		public unsafe float damping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow.NativeFieldInfoPtr_damping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow.NativeFieldInfoPtr_damping)) = value;
			}
		}

		// Token: 0x04004EA5 RID: 20133
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004EA6 RID: 20134
		private static readonly IntPtr NativeFieldInfoPtr_damping;

		// Token: 0x04004EA7 RID: 20135
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EA8 RID: 20136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
