using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x0200016A RID: 362
	public class MissionInteractConditionComponent : EntityConditionComponent
	{
		// Token: 0x06002886 RID: 10374 RVA: 0x00125450 File Offset: 0x00123650
		// Note: this type is marked as 'beforefieldinit'.
		static MissionInteractConditionComponent()
		{
			Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "MissionInteractConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr);
			MissionInteractConditionComponent.NativeFieldInfoPtr_interactableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr, "interactableKey");
			MissionInteractConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr, 100670401);
			MissionInteractConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr, 100670402);
			MissionInteractConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr, 100670403);
			MissionInteractConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr, 100670404);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x001254E4 File Offset: 0x001236E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92345, XrefRangeEnd = 92346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionInteractConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0012552C File Offset: 0x0012372C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92346, XrefRangeEnd = 92352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionInteractConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00125578 File Offset: 0x00123778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionInteractConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x001255B4 File Offset: 0x001237B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92352, XrefRangeEnd = 92360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissionInteractConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionInteractConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionInteractConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x00017D17 File Offset: 0x00015F17
		public MissionInteractConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x001255F0 File Offset: 0x001237F0
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x00017D20 File Offset: 0x00015F20
		public unsafe string interactableKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionInteractConditionComponent.NativeFieldInfoPtr_interactableKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionInteractConditionComponent.NativeFieldInfoPtr_interactableKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeFieldInfoPtr_interactableKey;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
