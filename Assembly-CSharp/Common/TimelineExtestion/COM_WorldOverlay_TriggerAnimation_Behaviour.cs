using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000417 RID: 1047
	public class COM_WorldOverlay_TriggerAnimation_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x060077E9 RID: 30697 RVA: 0x0022D57C File Offset: 0x0022B77C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_TriggerAnimation_Behaviour()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_TriggerAnimation_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr);
			COM_WorldOverlay_TriggerAnimation_Behaviour.NativeFieldInfoPtr_animationTriggerlabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr, "animationTriggerlabel");
			COM_WorldOverlay_TriggerAnimation_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr, "label");
			COM_WorldOverlay_TriggerAnimation_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr, 100687604);
			COM_WorldOverlay_TriggerAnimation_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr, 100687605);
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x0022D5FC File Offset: 0x0022B7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293424, XrefRangeEnd = 293429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_TriggerAnimation_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x0022D638 File Offset: 0x0022B838
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_TriggerAnimation_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_TriggerAnimation_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_TriggerAnimation_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00040D81 File Offset: 0x0003EF81
		public COM_WorldOverlay_TriggerAnimation_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x0022D674 File Offset: 0x0022B874
		// (set) Token: 0x060077EE RID: 30702 RVA: 0x00040D8A File Offset: 0x0003EF8A
		public unsafe string animationTriggerlabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation_Behaviour.NativeFieldInfoPtr_animationTriggerlabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation_Behaviour.NativeFieldInfoPtr_animationTriggerlabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x060077EF RID: 30703 RVA: 0x0022D69C File Offset: 0x0022B89C
		// (set) Token: 0x060077F0 RID: 30704 RVA: 0x00040DA9 File Offset: 0x0003EFA9
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_TriggerAnimation_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F25 RID: 20261
		private static readonly IntPtr NativeFieldInfoPtr_animationTriggerlabel;

		// Token: 0x04004F26 RID: 20262
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F27 RID: 20263
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F28 RID: 20264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
