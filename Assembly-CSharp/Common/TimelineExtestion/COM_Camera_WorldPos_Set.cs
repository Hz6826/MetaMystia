using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F8 RID: 1016
	public class COM_Camera_WorldPos_Set : PlayableAsset
	{
		// Token: 0x060076F8 RID: 30456 RVA: 0x0022A8D4 File Offset: 0x00228AD4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_WorldPos_Set()
		{
			Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_WorldPos_Set");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr);
			COM_Camera_WorldPos_Set.NativeFieldInfoPtr_targetCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr, "targetCoordinate");
			COM_Camera_WorldPos_Set.NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr, "damping");
			COM_Camera_WorldPos_Set.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr, 100687539);
			COM_Camera_WorldPos_Set.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr, 100687540);
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x0022A954 File Offset: 0x00228B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292974, XrefRangeEnd = 292988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_WorldPos_Set.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x0022A9BC File Offset: 0x00228BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_WorldPos_Set() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_WorldPos_Set>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_WorldPos_Set.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x000405EB File Offset: 0x0003E7EB
		public COM_Camera_WorldPos_Set(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x060076FC RID: 30460 RVA: 0x0022A9F8 File Offset: 0x00228BF8
		// (set) Token: 0x060076FD RID: 30461 RVA: 0x000405F4 File Offset: 0x0003E7F4
		public unsafe Vector2 targetCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set.NativeFieldInfoPtr_targetCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set.NativeFieldInfoPtr_targetCoordinate)) = value;
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x060076FE RID: 30462 RVA: 0x0022AA20 File Offset: 0x00228C20
		// (set) Token: 0x060076FF RID: 30463 RVA: 0x0004060F File Offset: 0x0003E80F
		public unsafe float damping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set.NativeFieldInfoPtr_damping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set.NativeFieldInfoPtr_damping)) = value;
			}
		}

		// Token: 0x04004EAB RID: 20139
		private static readonly IntPtr NativeFieldInfoPtr_targetCoordinate;

		// Token: 0x04004EAC RID: 20140
		private static readonly IntPtr NativeFieldInfoPtr_damping;

		// Token: 0x04004EAD RID: 20141
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EAE RID: 20142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
