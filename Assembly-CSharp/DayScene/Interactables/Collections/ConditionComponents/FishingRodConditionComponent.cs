using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x0200016E RID: 366
	public class FishingRodConditionComponent : EntityConditionComponent
	{
		// Token: 0x060028A9 RID: 10409 RVA: 0x00125C04 File Offset: 0x00123E04
		// Note: this type is marked as 'beforefieldinit'.
		static FishingRodConditionComponent()
		{
			Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "FishingRodConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr);
			FishingRodConditionComponent.NativeFieldInfoPtr_m_FishingRodIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr, "m_FishingRodIds");
			FishingRodConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr, 100670418);
			FishingRodConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr, 100670419);
			FishingRodConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr, 100670420);
			FishingRodConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr, 100670421);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00125C98 File Offset: 0x00123E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92434, XrefRangeEnd = 92444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingRodConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00125CE0 File Offset: 0x00123EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92444, XrefRangeEnd = 92450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingRodConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00125D2C File Offset: 0x00123F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishingRodConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00125D68 File Offset: 0x00123F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92450, XrefRangeEnd = 92458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishingRodConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishingRodConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishingRodConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00017DCE File Offset: 0x00015FCE
		public FishingRodConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x00125DA4 File Offset: 0x00123FA4
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00017DD7 File Offset: 0x00015FD7
		public unsafe Il2CppStructArray<int> m_FishingRodIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingRodConditionComponent.NativeFieldInfoPtr_m_FishingRodIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishingRodConditionComponent.NativeFieldInfoPtr_m_FishingRodIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_m_FishingRodIds;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
