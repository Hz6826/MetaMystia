using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionExtensions
{
	// Token: 0x02000164 RID: 356
	public class SchedulerConditionExtension : EntityConditionExtension
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x001242F8 File Offset: 0x001224F8
		// Note: this type is marked as 'beforefieldinit'.
		static SchedulerConditionExtension()
		{
			Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionExtensions", "SchedulerConditionExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr);
			SchedulerConditionExtension.NativeFieldInfoPtr_conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr, "conditions");
			SchedulerConditionExtension.NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr, 100670363);
			SchedulerConditionExtension.NativeMethodInfoPtr_OnGetExtensionType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr, 100670364);
			SchedulerConditionExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr, 100670365);
			SchedulerConditionExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr, 100670366);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0012438C File Offset: 0x0012258C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92060, XrefRangeEnd = 92070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetExtensionAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionExtension.NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x001243D4 File Offset: 0x001225D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92070, XrefRangeEnd = 92076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type OnGetExtensionType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionExtension.NativeMethodInfoPtr_OnGetExtensionType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00124420 File Offset: 0x00122620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0012445C File Offset: 0x0012265C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchedulerConditionExtension() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerConditionExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerConditionExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00017B3A File Offset: 0x00015D3A
		public SchedulerConditionExtension(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x00124498 File Offset: 0x00122698
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x00017B43 File Offset: 0x00015D43
		public unsafe Il2CppReferenceArray<SchedulerConditionComponent.SchedulerData> conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionExtension.NativeFieldInfoPtr_conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchedulerConditionComponent.SchedulerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionExtension.NativeFieldInfoPtr_conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeFieldInfoPtr_conditions;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Virtual_Boolean_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_OnGetExtensionType_Public_Virtual_Type_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
