using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200017B RID: 379
	public class MissionInteractBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002982 RID: 10626 RVA: 0x001287E8 File Offset: 0x001269E8
		// Note: this type is marked as 'beforefieldinit'.
		static MissionInteractBehaviourComponent()
		{
			Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MissionInteractBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr);
			MissionInteractBehaviourComponent.NativeFieldInfoPtr_onInteractAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr, "onInteractAudio");
			MissionInteractBehaviourComponent.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr, "rewards");
			MissionInteractBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr, 100670539);
			MissionInteractBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr, 100670540);
			MissionInteractBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr, 100670541);
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0012887C File Offset: 0x00126A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93414, XrefRangeEnd = 93427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionInteractBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x001288B8 File Offset: 0x00126AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93427, XrefRangeEnd = 93430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionInteractBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x001288F4 File Offset: 0x00126AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissionInteractBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionInteractBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionInteractBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0001842D File Offset: 0x0001662D
		public MissionInteractBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x00128930 File Offset: 0x00126B30
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x00018436 File Offset: 0x00016636
		public unsafe AudioClip onInteractAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionInteractBehaviourComponent.NativeFieldInfoPtr_onInteractAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionInteractBehaviourComponent.NativeFieldInfoPtr_onInteractAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x00128960 File Offset: 0x00126B60
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x00018455 File Offset: 0x00016655
		public unsafe Il2CppReferenceArray<SchedulerNode.Reward> rewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionInteractBehaviourComponent.NativeFieldInfoPtr_rewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchedulerNode.Reward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionInteractBehaviourComponent.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeFieldInfoPtr_onInteractAudio;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeFieldInfoPtr_rewards;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
