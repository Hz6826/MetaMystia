using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000419 RID: 1049
	public class COM_WorldOverlay_Follow_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060077FD RID: 30717 RVA: 0x0022D88C File Offset: 0x0022BA8C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Follow_Behaviour()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Follow_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr);
			COM_WorldOverlay_Follow_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr, "label");
			COM_WorldOverlay_Follow_Behaviour.NativeFieldInfoPtr_targetLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr, "targetLabel");
			COM_WorldOverlay_Follow_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr, 100687608);
			COM_WorldOverlay_Follow_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr, 100687609);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x0022D90C File Offset: 0x0022BB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293436, XrefRangeEnd = 293441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Follow_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x0022D948 File Offset: 0x0022BB48
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Follow_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Follow_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Follow_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00040E45 File Offset: 0x0003F045
		public COM_WorldOverlay_Follow_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x06007801 RID: 30721 RVA: 0x0022D984 File Offset: 0x0022BB84
		// (set) Token: 0x06007802 RID: 30722 RVA: 0x00040E4E File Offset: 0x0003F04E
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06007803 RID: 30723 RVA: 0x0022D9AC File Offset: 0x0022BBAC
		// (set) Token: 0x06007804 RID: 30724 RVA: 0x00040E6D File Offset: 0x0003F06D
		public unsafe string targetLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow_Behaviour.NativeFieldInfoPtr_targetLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Follow_Behaviour.NativeFieldInfoPtr_targetLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F2F RID: 20271
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F30 RID: 20272
		private static readonly IntPtr NativeFieldInfoPtr_targetLabel;

		// Token: 0x04004F31 RID: 20273
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F32 RID: 20274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
