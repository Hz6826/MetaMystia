using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003FA RID: 1018
	public class COM_FinishEvent : PlayableAsset
	{
		// Token: 0x06007706 RID: 30470 RVA: 0x0022AB80 File Offset: 0x00228D80
		// Note: this type is marked as 'beforefieldinit'.
		static COM_FinishEvent()
		{
			Il2CppClassPointerStore<COM_FinishEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_FinishEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_FinishEvent>.NativeClassPtr);
			COM_FinishEvent.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_FinishEvent>.NativeClassPtr, "eventName");
			COM_FinishEvent.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_FinishEvent>.NativeClassPtr, 100687543);
			COM_FinishEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_FinishEvent>.NativeClassPtr, 100687544);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x0022ABEC File Offset: 0x00228DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293000, XrefRangeEnd = 293013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_FinishEvent.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x0022AC54 File Offset: 0x00228E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_FinishEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_FinishEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_FinishEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x0004064E File Offset: 0x0003E84E
		public COM_FinishEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x0022AC90 File Offset: 0x00228E90
		// (set) Token: 0x0600770B RID: 30475 RVA: 0x00040657 File Offset: 0x0003E857
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_FinishEvent.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_FinishEvent.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004EB2 RID: 20146
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04004EB3 RID: 20147
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EB4 RID: 20148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
