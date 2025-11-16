using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000172 RID: 370
	public class SwitchConditionComponent : EntityConditionComponent
	{
		// Token: 0x060028D3 RID: 10451 RVA: 0x001264DC File Offset: 0x001246DC
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchConditionComponent()
		{
			Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "SwitchConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr);
			SwitchConditionComponent.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr, "label");
			SwitchConditionComponent.NativeFieldInfoPtr_onByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr, "onByDefault");
			SwitchConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr, 100670442);
			SwitchConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr, 100670443);
			SwitchConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr, 100670444);
			SwitchConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr, 100670445);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00126584 File Offset: 0x00124784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92549, XrefRangeEnd = 92550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SwitchConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x001265CC File Offset: 0x001247CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92550, XrefRangeEnd = 92556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SwitchConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00126618 File Offset: 0x00124818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SwitchConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00126654 File Offset: 0x00124854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92556, XrefRangeEnd = 92564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00017EC8 File Offset: 0x000160C8
		public SwitchConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x00126690 File Offset: 0x00124890
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x00017ED1 File Offset: 0x000160D1
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchConditionComponent.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchConditionComponent.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x001266B8 File Offset: 0x001248B8
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x00017EF0 File Offset: 0x000160F0
		public unsafe bool onByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchConditionComponent.NativeFieldInfoPtr_onByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchConditionComponent.NativeFieldInfoPtr_onByDefault)) = value;
			}
		}

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr_onByDefault;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
