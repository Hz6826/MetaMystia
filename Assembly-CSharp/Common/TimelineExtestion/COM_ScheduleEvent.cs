using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000405 RID: 1029
	public class COM_ScheduleEvent : PlayableAsset
	{
		// Token: 0x0600774C RID: 30540 RVA: 0x0022B988 File Offset: 0x00229B88
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ScheduleEvent()
		{
			Il2CppClassPointerStore<COM_ScheduleEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ScheduleEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ScheduleEvent>.NativeClassPtr);
			COM_ScheduleEvent.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ScheduleEvent>.NativeClassPtr, "eventName");
			COM_ScheduleEvent.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ScheduleEvent>.NativeClassPtr, 100687565);
			COM_ScheduleEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ScheduleEvent>.NativeClassPtr, 100687566);
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x0022B9F4 File Offset: 0x00229BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293140, XrefRangeEnd = 293153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ScheduleEvent.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x0022BA5C File Offset: 0x00229C5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ScheduleEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ScheduleEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ScheduleEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00040828 File Offset: 0x0003EA28
		public COM_ScheduleEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x06007750 RID: 30544 RVA: 0x0022BA98 File Offset: 0x00229C98
		// (set) Token: 0x06007751 RID: 30545 RVA: 0x00040831 File Offset: 0x0003EA31
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ScheduleEvent.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ScheduleEvent.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004ED5 RID: 20181
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04004ED6 RID: 20182
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004ED7 RID: 20183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
