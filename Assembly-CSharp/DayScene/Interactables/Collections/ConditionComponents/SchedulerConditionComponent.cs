using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000170 RID: 368
	public class SchedulerConditionComponent : EntityConditionComponent
	{
		// Token: 0x060028BB RID: 10427 RVA: 0x00125FC8 File Offset: 0x001241C8
		// Note: this type is marked as 'beforefieldinit'.
		static SchedulerConditionComponent()
		{
			Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "SchedulerConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr);
			SchedulerConditionComponent.NativeFieldInfoPtr_conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, "conditions");
			SchedulerConditionComponent.NativeFieldInfoPtr_inverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, "inverse");
			SchedulerConditionComponent.NativeFieldInfoPtr_shouldFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, "shouldFadeOut");
			SchedulerConditionComponent.NativeMethodInfoPtr_ShouldFadeOut_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, 100670426);
			SchedulerConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, 100670427);
			SchedulerConditionComponent.NativeMethodInfoPtr_Finished_Public_Static_Boolean_SchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, 100670428);
			SchedulerConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, 100670429);
			SchedulerConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, 100670430);
			SchedulerConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, 100670431);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x001260AC File Offset: 0x001242AC
		[CallerCount(0)]
		public unsafe override bool ShouldFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionComponent.NativeMethodInfoPtr_ShouldFadeOut_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x001260F4 File Offset: 0x001242F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92481, XrefRangeEnd = 92490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0012613C File Offset: 0x0012433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92490, XrefRangeEnd = 92494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Finished(SchedulerConditionComponent.SchedulerData schedulerData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(schedulerData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerConditionComponent.NativeMethodInfoPtr_Finished_Public_Static_Boolean_SchedulerData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00126184 File Offset: 0x00124384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92494, XrefRangeEnd = 92500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x001261D0 File Offset: 0x001243D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0012620C File Offset: 0x0012440C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92500, XrefRangeEnd = 92508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchedulerConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00017E23 File Offset: 0x00016023
		public SchedulerConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x00126248 File Offset: 0x00124448
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x00017E2C File Offset: 0x0001602C
		public unsafe Il2CppReferenceArray<SchedulerConditionComponent.SchedulerData> conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.NativeFieldInfoPtr_conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchedulerConditionComponent.SchedulerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.NativeFieldInfoPtr_conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x00126278 File Offset: 0x00124478
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x00017E4B File Offset: 0x0001604B
		public unsafe bool inverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.NativeFieldInfoPtr_inverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.NativeFieldInfoPtr_inverse)) = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x001262A0 File Offset: 0x001244A0
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x00017E66 File Offset: 0x00016066
		public unsafe bool shouldFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.NativeFieldInfoPtr_shouldFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.NativeFieldInfoPtr_shouldFadeOut)) = value;
			}
		}

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeFieldInfoPtr_conditions;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeFieldInfoPtr_inverse;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr_shouldFadeOut;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_ShouldFadeOut_Protected_Virtual_Boolean_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_Finished_Public_Static_Boolean_SchedulerData_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000790 RID: 1936
		[Serializable]
		public sealed class SchedulerData : ValueType
		{
			// Token: 0x0600A37C RID: 41852 RVA: 0x002ADDB0 File Offset: 0x002ABFB0
			// Note: this type is marked as 'beforefieldinit'.
			static SchedulerData()
			{
				Il2CppClassPointerStore<SchedulerConditionComponent.SchedulerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerConditionComponent>.NativeClassPtr, "SchedulerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerConditionComponent.SchedulerData>.NativeClassPtr);
				SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionComponent.SchedulerData>.NativeClassPtr, "nodeType");
				SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_nodeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionComponent.SchedulerData>.NativeClassPtr, "nodeKey");
				SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerConditionComponent.SchedulerData>.NativeClassPtr, "status");
			}

			// Token: 0x0600A37D RID: 41853 RVA: 0x00058482 File Offset: 0x00056682
			public SchedulerData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A37E RID: 41854 RVA: 0x0005848B File Offset: 0x0005668B
			public SchedulerData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerConditionComponent.SchedulerData>.NativeClassPtr))
			{
			}

			// Token: 0x170035EB RID: 13803
			// (get) Token: 0x0600A37F RID: 41855 RVA: 0x002ADE18 File Offset: 0x002AC018
			// (set) Token: 0x0600A380 RID: 41856 RVA: 0x0005849D File Offset: 0x0005669D
			public unsafe SchedulerNode.NodeType nodeType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_nodeType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_nodeType)) = value;
				}
			}

			// Token: 0x170035EC RID: 13804
			// (get) Token: 0x0600A381 RID: 41857 RVA: 0x002ADE40 File Offset: 0x002AC040
			// (set) Token: 0x0600A382 RID: 41858 RVA: 0x000584B8 File Offset: 0x000566B8
			public unsafe string nodeKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_nodeKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_nodeKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170035ED RID: 13805
			// (get) Token: 0x0600A383 RID: 41859 RVA: 0x002ADE68 File Offset: 0x002AC068
			// (set) Token: 0x0600A384 RID: 41860 RVA: 0x000584D7 File Offset: 0x000566D7
			public unsafe SchedulerConditionComponent.SchedulerData.Condition status
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_status);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerConditionComponent.SchedulerData.NativeFieldInfoPtr_status)) = value;
				}
			}

			// Token: 0x040069D6 RID: 27094
			private static readonly IntPtr NativeFieldInfoPtr_nodeType;

			// Token: 0x040069D7 RID: 27095
			private static readonly IntPtr NativeFieldInfoPtr_nodeKey;

			// Token: 0x040069D8 RID: 27096
			private static readonly IntPtr NativeFieldInfoPtr_status;

			// Token: 0x02000FDF RID: 4063
			public enum Condition
			{
				// Token: 0x0400B049 RID: 45129
				Finished,
				// Token: 0x0400B04A RID: 45130
				InProgress,
				// Token: 0x0400B04B RID: 45131
				Unfinshed
			}
		}
	}
}
