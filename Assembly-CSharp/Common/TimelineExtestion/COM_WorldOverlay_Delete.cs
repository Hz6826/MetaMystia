using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x0200040D RID: 1037
	public class COM_WorldOverlay_Delete : PlayableAsset
	{
		// Token: 0x0600777C RID: 30588 RVA: 0x0022C358 File Offset: 0x0022A558
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Delete()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Delete");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr);
			COM_WorldOverlay_Delete.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr, "label");
			COM_WorldOverlay_Delete.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr, "transitionDuration");
			COM_WorldOverlay_Delete.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr, 100687581);
			COM_WorldOverlay_Delete.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr, 100687582);
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x0022C3D8 File Offset: 0x0022A5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293240, XrefRangeEnd = 293255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Delete.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x0022C440 File Offset: 0x0022A640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Delete() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Delete>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Delete.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00040960 File Offset: 0x0003EB60
		public COM_WorldOverlay_Delete(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x06007780 RID: 30592 RVA: 0x0022C47C File Offset: 0x0022A67C
		// (set) Token: 0x06007781 RID: 30593 RVA: 0x00040969 File Offset: 0x0003EB69
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x06007782 RID: 30594 RVA: 0x0022C4A4 File Offset: 0x0022A6A4
		// (set) Token: 0x06007783 RID: 30595 RVA: 0x00040988 File Offset: 0x0003EB88
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x04004EED RID: 20205
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004EEE RID: 20206
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x04004EEF RID: 20207
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EF0 RID: 20208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
