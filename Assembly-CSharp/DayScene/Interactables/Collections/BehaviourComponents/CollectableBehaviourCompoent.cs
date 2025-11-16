using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000178 RID: 376
	public class CollectableBehaviourCompoent : EntityBehaviourComponent
	{
		// Token: 0x06002961 RID: 10593 RVA: 0x001280CC File Offset: 0x001262CC
		// Note: this type is marked as 'beforefieldinit'.
		static CollectableBehaviourCompoent()
		{
			Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "CollectableBehaviourCompoent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr);
			CollectableBehaviourCompoent.NativeFieldInfoPtr_onCollectAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr, "onCollectAudio");
			CollectableBehaviourCompoent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr, 100670522);
			CollectableBehaviourCompoent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr, 100670523);
			CollectableBehaviourCompoent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr, 100670524);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x0012814C File Offset: 0x0012634C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93352, XrefRangeEnd = 93361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectableBehaviourCompoent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00128188 File Offset: 0x00126388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93361, XrefRangeEnd = 93363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectableBehaviourCompoent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x001281C4 File Offset: 0x001263C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectableBehaviourCompoent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectableBehaviourCompoent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectableBehaviourCompoent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0001837F File Offset: 0x0001657F
		public CollectableBehaviourCompoent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x00128200 File Offset: 0x00126400
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x00018388 File Offset: 0x00016588
		public unsafe AudioClip onCollectAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectableBehaviourCompoent.NativeFieldInfoPtr_onCollectAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectableBehaviourCompoent.NativeFieldInfoPtr_onCollectAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeFieldInfoPtr_onCollectAudio;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
