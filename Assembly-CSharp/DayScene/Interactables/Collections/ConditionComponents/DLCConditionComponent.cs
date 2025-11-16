using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x0200016D RID: 365
	public class DLCConditionComponent : EntityConditionComponent
	{
		// Token: 0x060028A1 RID: 10401 RVA: 0x00125A3C File Offset: 0x00123C3C
		// Note: this type is marked as 'beforefieldinit'.
		static DLCConditionComponent()
		{
			Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "DLCConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr);
			DLCConditionComponent.NativeFieldInfoPtr_dlcKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr, "dlcKey");
			DLCConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr, 100670414);
			DLCConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr, 100670415);
			DLCConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr, 100670416);
			DLCConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr, 100670417);
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00125AD0 File Offset: 0x00123CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92408, XrefRangeEnd = 92420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLCConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00125B18 File Offset: 0x00123D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92420, XrefRangeEnd = 92426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLCConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00125B64 File Offset: 0x00123D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLCConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00125BA0 File Offset: 0x00123DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92426, XrefRangeEnd = 92434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLCConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLCConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLCConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00017DA6 File Offset: 0x00015FA6
		public DLCConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x00125BDC File Offset: 0x00123DDC
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00017DAF File Offset: 0x00015FAF
		public unsafe string dlcKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLCConditionComponent.NativeFieldInfoPtr_dlcKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLCConditionComponent.NativeFieldInfoPtr_dlcKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeFieldInfoPtr_dlcKey;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
