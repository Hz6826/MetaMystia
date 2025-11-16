using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionExtensions
{
	// Token: 0x02000165 RID: 357
	public class StatusTrackerConditionExtension : EntityConditionExtension
	{
		// Token: 0x0600283E RID: 10302 RVA: 0x001244C8 File Offset: 0x001226C8
		// Note: this type is marked as 'beforefieldinit'.
		static StatusTrackerConditionExtension()
		{
			Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionExtensions", "StatusTrackerConditionExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr);
			StatusTrackerConditionExtension.NativeFieldInfoPtr_statusTrackerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr, "statusTrackerLabel");
			StatusTrackerConditionExtension.NativeFieldInfoPtr_maxInteractNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr, "maxInteractNum");
			StatusTrackerConditionExtension.NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr, 100670367);
			StatusTrackerConditionExtension.NativeMethodInfoPtr_OnGetExtensionType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr, 100670368);
			StatusTrackerConditionExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr, 100670369);
			StatusTrackerConditionExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr, 100670370);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00124570 File Offset: 0x00122770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92076, XrefRangeEnd = 92080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetExtensionAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusTrackerConditionExtension.NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x001245B8 File Offset: 0x001227B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92080, XrefRangeEnd = 92086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type OnGetExtensionType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusTrackerConditionExtension.NativeMethodInfoPtr_OnGetExtensionType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00124604 File Offset: 0x00122804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusTrackerConditionExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00124640 File Offset: 0x00122840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92086, XrefRangeEnd = 92087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusTrackerConditionExtension() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusTrackerConditionExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTrackerConditionExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00017B62 File Offset: 0x00015D62
		public StatusTrackerConditionExtension(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x0012467C File Offset: 0x0012287C
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x00017B6B File Offset: 0x00015D6B
		public unsafe string statusTrackerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTrackerConditionExtension.NativeFieldInfoPtr_statusTrackerLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTrackerConditionExtension.NativeFieldInfoPtr_statusTrackerLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x001246A4 File Offset: 0x001228A4
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x00017B8A File Offset: 0x00015D8A
		public unsafe int maxInteractNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTrackerConditionExtension.NativeFieldInfoPtr_maxInteractNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTrackerConditionExtension.NativeFieldInfoPtr_maxInteractNum)) = value;
			}
		}

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr_statusTrackerLabel;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr_maxInteractNum;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Virtual_Boolean_0;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr_OnGetExtensionType_Public_Virtual_Type_0;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
