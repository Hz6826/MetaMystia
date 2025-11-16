using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000412 RID: 1042
	public class COM_WorldOverlay_TriggerAnimation : PlayableAsset
	{
		// Token: 0x060077BA RID: 30650 RVA: 0x0022CD60 File Offset: 0x0022AF60
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_TriggerAnimation()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_TriggerAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr);
			COM_WorldOverlay_TriggerAnimation.NativeFieldInfoPtr_animationTriggerlabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr, "animationTriggerlabel");
			COM_WorldOverlay_TriggerAnimation.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr, "label");
			COM_WorldOverlay_TriggerAnimation.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr, 100687591);
			COM_WorldOverlay_TriggerAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr, 100687592);
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x0022CDE0 File Offset: 0x0022AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293351, XrefRangeEnd = 293367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_TriggerAnimation.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x0022CE48 File Offset: 0x0022B048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_TriggerAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_TriggerAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00040BF8 File Offset: 0x0003EDF8
		public COM_WorldOverlay_TriggerAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x0022CE84 File Offset: 0x0022B084
		// (set) Token: 0x060077BF RID: 30655 RVA: 0x00040C01 File Offset: 0x0003EE01
		public unsafe string animationTriggerlabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation.NativeFieldInfoPtr_animationTriggerlabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation.NativeFieldInfoPtr_animationTriggerlabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x0022CEAC File Offset: 0x0022B0AC
		// (set) Token: 0x060077C1 RID: 30657 RVA: 0x00040C20 File Offset: 0x0003EE20
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F0C RID: 20236
		private static readonly IntPtr NativeFieldInfoPtr_animationTriggerlabel;

		// Token: 0x04004F0D RID: 20237
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F0E RID: 20238
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004F0F RID: 20239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
