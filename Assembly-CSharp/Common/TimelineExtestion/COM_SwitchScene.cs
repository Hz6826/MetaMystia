using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000409 RID: 1033
	public class COM_SwitchScene : PlayableAsset
	{
		// Token: 0x06007766 RID: 30566 RVA: 0x0022BEA4 File Offset: 0x0022A0A4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SwitchScene()
		{
			Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SwitchScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr);
			COM_SwitchScene.NativeFieldInfoPtr_sceneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr, "sceneReference");
			COM_SwitchScene.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr, "label");
			COM_SwitchScene.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr, 100687573);
			COM_SwitchScene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr, 100687574);
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x0022BF24 File Offset: 0x0022A124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293193, XrefRangeEnd = 293209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SwitchScene.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x0022BF8C File Offset: 0x0022A18C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SwitchScene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SwitchScene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SwitchScene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x000408DF File Offset: 0x0003EADF
		public COM_SwitchScene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600776A RID: 30570 RVA: 0x0022BFC8 File Offset: 0x0022A1C8
		// (set) Token: 0x0600776B RID: 30571 RVA: 0x000408E8 File Offset: 0x0003EAE8
		public unsafe GameObject sceneReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene.NativeFieldInfoPtr_sceneReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene.NativeFieldInfoPtr_sceneReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600776C RID: 30572 RVA: 0x0022BFF8 File Offset: 0x0022A1F8
		// (set) Token: 0x0600776D RID: 30573 RVA: 0x00040907 File Offset: 0x0003EB07
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004EE2 RID: 20194
		private static readonly IntPtr NativeFieldInfoPtr_sceneReference;

		// Token: 0x04004EE3 RID: 20195
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004EE4 RID: 20196
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EE5 RID: 20197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
