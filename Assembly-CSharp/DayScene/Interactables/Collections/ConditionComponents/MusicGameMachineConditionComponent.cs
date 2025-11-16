using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x0200016F RID: 367
	public class MusicGameMachineConditionComponent : EntityConditionComponent
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x00125DD4 File Offset: 0x00123FD4
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMachineConditionComponent()
		{
			Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "MusicGameMachineConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr);
			MusicGameMachineConditionComponent.NativeFieldInfoPtr_INTERACTABLE_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr, "INTERACTABLE_KEY");
			MusicGameMachineConditionComponent.NativeFieldInfoPtr_MAIN_MAP_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr, "MAIN_MAP_LABEL");
			MusicGameMachineConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr, 100670422);
			MusicGameMachineConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr, 100670423);
			MusicGameMachineConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr, 100670424);
			MusicGameMachineConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr, 100670425);
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00125E7C File Offset: 0x0012407C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92458, XrefRangeEnd = 92467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMachineConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00125EC4 File Offset: 0x001240C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92467, XrefRangeEnd = 92473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMachineConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x00125F10 File Offset: 0x00124110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMachineConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00125F4C File Offset: 0x0012414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92473, XrefRangeEnd = 92481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMachineConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMachineConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMachineConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x00017DF6 File Offset: 0x00015FF6
		public MusicGameMachineConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x00125F88 File Offset: 0x00124188
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x00017DFF File Offset: 0x00015FFF
		public unsafe static string INTERACTABLE_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMachineConditionComponent.NativeFieldInfoPtr_INTERACTABLE_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMachineConditionComponent.NativeFieldInfoPtr_INTERACTABLE_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00125FA8 File Offset: 0x001241A8
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x00017E11 File Offset: 0x00016011
		public unsafe static string MAIN_MAP_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMachineConditionComponent.NativeFieldInfoPtr_MAIN_MAP_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMachineConditionComponent.NativeFieldInfoPtr_MAIN_MAP_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_INTERACTABLE_KEY;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeFieldInfoPtr_MAIN_MAP_LABEL;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
