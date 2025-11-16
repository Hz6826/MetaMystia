using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000179 RID: 377
	public class MapTransitionBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x00128230 File Offset: 0x00126430
		// Note: this type is marked as 'beforefieldinit'.
		static MapTransitionBehaviourComponent()
		{
			Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MapTransitionBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr);
			MapTransitionBehaviourComponent.NativeFieldInfoPtr_isInteractTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, "isInteractTransition");
			MapTransitionBehaviourComponent.NativeFieldInfoPtr_canBeInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, "canBeInteract");
			MapTransitionBehaviourComponent.NativeFieldInfoPtr_conditionComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, "conditionComponent");
			MapTransitionBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670525);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670526);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr_ExecuteMapTransition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670527);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670528);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670529);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670530);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670531);
			MapTransitionBehaviourComponent.NativeMethodInfoPtr__ExecuteMapTransition_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr, 100670532);
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0012833C File Offset: 0x0012653C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93363, XrefRangeEnd = 93367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00128370 File Offset: 0x00126570
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 93367, RefRangeEnd = 93375, XrefRangeStart = 93367, XrefRangeEnd = 93367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTriggerMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x001283B8 File Offset: 0x001265B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93390, RefRangeEnd = 93392, XrefRangeStart = 93375, XrefRangeEnd = 93390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteMapTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionBehaviourComponent.NativeMethodInfoPtr_ExecuteMapTransition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x001283EC File Offset: 0x001265EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93392, XrefRangeEnd = 93393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00128428 File Offset: 0x00126628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93393, XrefRangeEnd = 93394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00128464 File Offset: 0x00126664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93394, XrefRangeEnd = 93396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x001284A0 File Offset: 0x001266A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93396, XrefRangeEnd = 93397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTransitionBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTransitionBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x001284DC File Offset: 0x001266DC
		[CallerCount(0)]
		public unsafe void _ExecuteMapTransition_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionBehaviourComponent.NativeMethodInfoPtr__ExecuteMapTransition_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000183A7 File Offset: 0x000165A7
		public MapTransitionBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x00128510 File Offset: 0x00126710
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x000183B0 File Offset: 0x000165B0
		public unsafe bool isInteractTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionBehaviourComponent.NativeFieldInfoPtr_isInteractTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionBehaviourComponent.NativeFieldInfoPtr_isInteractTransition)) = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x00128538 File Offset: 0x00126738
		// (set) Token: 0x06002975 RID: 10613 RVA: 0x000183CB File Offset: 0x000165CB
		public unsafe bool canBeInteract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionBehaviourComponent.NativeFieldInfoPtr_canBeInteract);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionBehaviourComponent.NativeFieldInfoPtr_canBeInteract)) = value;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x00128560 File Offset: 0x00126760
		// (set) Token: 0x06002977 RID: 10615 RVA: 0x000183E6 File Offset: 0x000165E6
		public unsafe MapTransitionConditionComponent conditionComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionBehaviourComponent.NativeFieldInfoPtr_conditionComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapTransitionConditionComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionBehaviourComponent.NativeFieldInfoPtr_conditionComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeFieldInfoPtr_isInteractTransition;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeFieldInfoPtr_canBeInteract;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeFieldInfoPtr_conditionComponent;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteMapTransition_Private_Void_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr__ExecuteMapTransition_b__5_0_Private_Void_0;
	}
}
