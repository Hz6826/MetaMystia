using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000180 RID: 384
	public class EventTriggerBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x001294F4 File Offset: 0x001276F4
		// Note: this type is marked as 'beforefieldinit'.
		static EventTriggerBehaviourComponent()
		{
			Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "EventTriggerBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr);
			EventTriggerBehaviourComponent.NativeFieldInfoPtr_triggerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr, "triggerId");
			EventTriggerBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr, 100670587);
			EventTriggerBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr, 100670588);
			EventTriggerBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr, 100670589);
			EventTriggerBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr, 100670590);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00129588 File Offset: 0x00127788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93829, XrefRangeEnd = 93833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTriggerBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x001295C4 File Offset: 0x001277C4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTriggerMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTriggerBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0012960C File Offset: 0x0012780C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTriggerBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00129648 File Offset: 0x00127848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventTriggerBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTriggerBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTriggerBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0001860C File Offset: 0x0001680C
		public EventTriggerBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x00129684 File Offset: 0x00127884
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x00018615 File Offset: 0x00016815
		public unsafe string triggerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTriggerBehaviourComponent.NativeFieldInfoPtr_triggerId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTriggerBehaviourComponent.NativeFieldInfoPtr_triggerId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeFieldInfoPtr_triggerId;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
