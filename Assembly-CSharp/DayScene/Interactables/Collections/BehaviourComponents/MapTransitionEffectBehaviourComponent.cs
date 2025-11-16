using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200017A RID: 378
	public class MapTransitionEffectBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002978 RID: 10616 RVA: 0x00128590 File Offset: 0x00126790
		// Note: this type is marked as 'beforefieldinit'.
		static MapTransitionEffectBehaviourComponent()
		{
			Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MapTransitionEffectBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr);
			MapTransitionEffectBehaviourComponent.NativeFieldInfoPtr_conditionComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, "conditionComponent");
			MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, 100670533);
			MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, 100670534);
			MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, 100670535);
			MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_OnPlayerExit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, 100670536);
			MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, 100670537);
			MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr, 100670538);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0012864C File Offset: 0x0012684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93397, XrefRangeEnd = 93401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00128680 File Offset: 0x00126880
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTriggerMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x001286C8 File Offset: 0x001268C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93401, XrefRangeEnd = 93409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00128704 File Offset: 0x00126904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93409, XrefRangeEnd = 93414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_OnPlayerExit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00128740 File Offset: 0x00126940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x0012877C File Offset: 0x0012697C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTransitionEffectBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTransitionEffectBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionEffectBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00018405 File Offset: 0x00016605
		public MapTransitionEffectBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x001287B8 File Offset: 0x001269B8
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x0001840E File Offset: 0x0001660E
		public unsafe MapTransitionConditionComponent conditionComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionEffectBehaviourComponent.NativeFieldInfoPtr_conditionComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapTransitionConditionComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionEffectBehaviourComponent.NativeFieldInfoPtr_conditionComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeFieldInfoPtr_conditionComponent;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerExit_Public_Virtual_Void_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
