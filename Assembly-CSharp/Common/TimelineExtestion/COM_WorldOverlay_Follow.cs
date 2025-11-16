using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x0200040E RID: 1038
	public class COM_WorldOverlay_Follow : PlayableAsset
	{
		// Token: 0x06007784 RID: 30596 RVA: 0x0022C4CC File Offset: 0x0022A6CC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Follow()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Follow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr);
			COM_WorldOverlay_Follow.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr, "label");
			COM_WorldOverlay_Follow.NativeFieldInfoPtr_targetLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr, "targetLabel");
			COM_WorldOverlay_Follow.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr, 100687583);
			COM_WorldOverlay_Follow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr, 100687584);
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x0022C54C File Offset: 0x0022A74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293255, XrefRangeEnd = 293271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Follow.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x0022C5B4 File Offset: 0x0022A7B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Follow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Follow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Follow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x000409A3 File Offset: 0x0003EBA3
		public COM_WorldOverlay_Follow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x06007788 RID: 30600 RVA: 0x0022C5F0 File Offset: 0x0022A7F0
		// (set) Token: 0x06007789 RID: 30601 RVA: 0x000409AC File Offset: 0x0003EBAC
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600778A RID: 30602 RVA: 0x0022C618 File Offset: 0x0022A818
		// (set) Token: 0x0600778B RID: 30603 RVA: 0x000409CB File Offset: 0x0003EBCB
		public unsafe string targetLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow.NativeFieldInfoPtr_targetLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow.NativeFieldInfoPtr_targetLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004EF1 RID: 20209
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004EF2 RID: 20210
		private static readonly IntPtr NativeFieldInfoPtr_targetLabel;

		// Token: 0x04004EF3 RID: 20211
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EF4 RID: 20212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
