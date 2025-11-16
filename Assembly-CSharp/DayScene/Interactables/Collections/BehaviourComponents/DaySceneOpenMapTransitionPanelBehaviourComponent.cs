using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200017E RID: 382
	public class DaySceneOpenMapTransitionPanelBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x060029AE RID: 10670 RVA: 0x0012914C File Offset: 0x0012734C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneOpenMapTransitionPanelBehaviourComponent()
		{
			Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "DaySceneOpenMapTransitionPanelBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr);
			DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr, 100670579);
			DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr, 100670580);
			DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr, 100670581);
			DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr, 100670582);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x001291CC File Offset: 0x001273CC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTriggerMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00129214 File Offset: 0x00127414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93794, XrefRangeEnd = 93800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00129250 File Offset: 0x00127450
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x0012928C File Offset: 0x0012748C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneOpenMapTransitionPanelBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneOpenMapTransitionPanelBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneOpenMapTransitionPanelBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0001859D File Offset: 0x0001679D
		public DaySceneOpenMapTransitionPanelBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_IsTriggerMode_Protected_Virtual_Boolean_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerEnter_Public_Virtual_Void_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
