using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200044A RID: 1098
	public class COM_FinishEvent_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007991 RID: 31121 RVA: 0x00231B40 File Offset: 0x0022FD40
		// Note: this type is marked as 'beforefieldinit'.
		static COM_FinishEvent_Behaviour()
		{
			Il2CppClassPointerStore<COM_FinishEvent_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_FinishEvent_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_FinishEvent_Behaviour>.NativeClassPtr);
			COM_FinishEvent_Behaviour.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_FinishEvent_Behaviour>.NativeClassPtr, "eventName");
			COM_FinishEvent_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_FinishEvent_Behaviour>.NativeClassPtr, 100687741);
			COM_FinishEvent_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_FinishEvent_Behaviour>.NativeClassPtr, 100687742);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00231BAC File Offset: 0x0022FDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294112, XrefRangeEnd = 294116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_FinishEvent_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00231BE8 File Offset: 0x0022FDE8
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_FinishEvent_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_FinishEvent_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_FinishEvent_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x00041AB3 File Offset: 0x0003FCB3
		public COM_FinishEvent_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x06007995 RID: 31125 RVA: 0x00231C24 File Offset: 0x0022FE24
		// (set) Token: 0x06007996 RID: 31126 RVA: 0x00041ABC File Offset: 0x0003FCBC
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_FinishEvent_Behaviour.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_FinishEvent_Behaviour.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004FFF RID: 20479
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04005000 RID: 20480
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04005001 RID: 20481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
