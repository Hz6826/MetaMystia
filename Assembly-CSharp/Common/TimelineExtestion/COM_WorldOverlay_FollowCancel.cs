using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x0200040F RID: 1039
	public class COM_WorldOverlay_FollowCancel : PlayableAsset
	{
		// Token: 0x0600778C RID: 30604 RVA: 0x0022C640 File Offset: 0x0022A840
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_FollowCancel()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_FollowCancel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel>.NativeClassPtr);
			COM_WorldOverlay_FollowCancel.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel>.NativeClassPtr, "label");
			COM_WorldOverlay_FollowCancel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel>.NativeClassPtr, 100687585);
			COM_WorldOverlay_FollowCancel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel>.NativeClassPtr, 100687586);
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x0022C6AC File Offset: 0x0022A8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293271, XrefRangeEnd = 293284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_FollowCancel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x0022C714 File Offset: 0x0022A914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_FollowCancel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_FollowCancel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x000409EA File Offset: 0x0003EBEA
		public COM_WorldOverlay_FollowCancel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x0022C750 File Offset: 0x0022A950
		// (set) Token: 0x06007791 RID: 30609 RVA: 0x000409F3 File Offset: 0x0003EBF3
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_FollowCancel.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_FollowCancel.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004EF5 RID: 20213
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004EF6 RID: 20214
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EF7 RID: 20215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
