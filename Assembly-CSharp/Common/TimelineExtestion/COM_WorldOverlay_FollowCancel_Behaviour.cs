using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200041A RID: 1050
	public class COM_WorldOverlay_FollowCancel_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007805 RID: 30725 RVA: 0x0022D9D4 File Offset: 0x0022BBD4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_FollowCancel_Behaviour()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_FollowCancel_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel_Behaviour>.NativeClassPtr);
			COM_WorldOverlay_FollowCancel_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel_Behaviour>.NativeClassPtr, "label");
			COM_WorldOverlay_FollowCancel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel_Behaviour>.NativeClassPtr, 100687610);
			COM_WorldOverlay_FollowCancel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel_Behaviour>.NativeClassPtr, 100687611);
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x0022DA40 File Offset: 0x0022BC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293441, XrefRangeEnd = 293446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_FollowCancel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0022DA7C File Offset: 0x0022BC7C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_FollowCancel_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_FollowCancel_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_FollowCancel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00040E8C File Offset: 0x0003F08C
		public COM_WorldOverlay_FollowCancel_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x0022DAB8 File Offset: 0x0022BCB8
		// (set) Token: 0x0600780A RID: 30730 RVA: 0x00040E95 File Offset: 0x0003F095
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_FollowCancel_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_FollowCancel_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F33 RID: 20275
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F34 RID: 20276
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F35 RID: 20277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
