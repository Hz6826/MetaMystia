using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E7 RID: 999
	public class COM_ACharacter_SetVisualActive : PlayableAsset
	{
		// Token: 0x06007662 RID: 30306 RVA: 0x00228E64 File Offset: 0x00227064
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SetVisualActive()
		{
			Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SetVisualActive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr);
			COM_ACharacter_SetVisualActive.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr, "label");
			COM_ACharacter_SetVisualActive.NativeFieldInfoPtr_visualActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr, "visualActive");
			COM_ACharacter_SetVisualActive.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr, 100687505);
			COM_ACharacter_SetVisualActive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr, 100687506);
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00228EE4 File Offset: 0x002270E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292730, XrefRangeEnd = 292745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SetVisualActive.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00228F4C File Offset: 0x0022714C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SetVisualActive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetVisualActive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x000400CF File Offset: 0x0003E2CF
		public COM_ACharacter_SetVisualActive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x00228F88 File Offset: 0x00227188
		// (set) Token: 0x06007667 RID: 30311 RVA: 0x000400D8 File Offset: 0x0003E2D8
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x00228FB0 File Offset: 0x002271B0
		// (set) Token: 0x06007669 RID: 30313 RVA: 0x000400F7 File Offset: 0x0003E2F7
		public unsafe bool visualActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive.NativeFieldInfoPtr_visualActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive.NativeFieldInfoPtr_visualActive)) = value;
			}
		}

		// Token: 0x04004E60 RID: 20064
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E61 RID: 20065
		private static readonly IntPtr NativeFieldInfoPtr_visualActive;

		// Token: 0x04004E62 RID: 20066
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E63 RID: 20067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
