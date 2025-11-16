using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x0200016B RID: 363
	public class ConstantConditionComponent : EntityConditionComponent
	{
		// Token: 0x0600288E RID: 10382 RVA: 0x00125618 File Offset: 0x00123818
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantConditionComponent()
		{
			Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "ConstantConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr);
			ConstantConditionComponent.NativeFieldInfoPtr_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr, "available");
			ConstantConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr, 100670405);
			ConstantConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr, 100670406);
			ConstantConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr, 100670407);
			ConstantConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr, 100670408);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x001256AC File Offset: 0x001238AC
		[CallerCount(0)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x001256F4 File Offset: 0x001238F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92360, XrefRangeEnd = 92366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00125740 File Offset: 0x00123940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92366, XrefRangeEnd = 92368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0012577C File Offset: 0x0012397C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92368, XrefRangeEnd = 92376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00017D3F File Offset: 0x00015F3F
		public ConstantConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x001257B8 File Offset: 0x001239B8
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x00017D48 File Offset: 0x00015F48
		public unsafe bool available
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantConditionComponent.NativeFieldInfoPtr_available);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantConditionComponent.NativeFieldInfoPtr_available)) = value;
			}
		}

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr_available;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
