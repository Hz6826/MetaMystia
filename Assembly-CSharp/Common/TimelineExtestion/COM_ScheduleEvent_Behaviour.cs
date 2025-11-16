using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000449 RID: 1097
	public class COM_ScheduleEvent_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600798B RID: 31115 RVA: 0x00231A34 File Offset: 0x0022FC34
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ScheduleEvent_Behaviour()
		{
			Il2CppClassPointerStore<COM_ScheduleEvent_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ScheduleEvent_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ScheduleEvent_Behaviour>.NativeClassPtr);
			COM_ScheduleEvent_Behaviour.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ScheduleEvent_Behaviour>.NativeClassPtr, "eventName");
			COM_ScheduleEvent_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ScheduleEvent_Behaviour>.NativeClassPtr, 100687739);
			COM_ScheduleEvent_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ScheduleEvent_Behaviour>.NativeClassPtr, 100687740);
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x00231AA0 File Offset: 0x0022FCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294108, XrefRangeEnd = 294112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ScheduleEvent_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x00231ADC File Offset: 0x0022FCDC
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ScheduleEvent_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ScheduleEvent_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ScheduleEvent_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x00041A8B File Offset: 0x0003FC8B
		public COM_ScheduleEvent_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600798F RID: 31119 RVA: 0x00231B18 File Offset: 0x0022FD18
		// (set) Token: 0x06007990 RID: 31120 RVA: 0x00041A94 File Offset: 0x0003FC94
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ScheduleEvent_Behaviour.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ScheduleEvent_Behaviour.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004FFC RID: 20476
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04004FFD RID: 20477
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FFE RID: 20478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
