using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000438 RID: 1080
	public class COM_ADialog_Play_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x0600791E RID: 31006 RVA: 0x00230748 File Offset: 0x0022E948
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Play_Behaviour()
		{
			Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Play_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr);
			COM_ADialog_Play_Behaviour.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr, "dialogPackage");
			COM_ADialog_Play_Behaviour.NativeFieldInfoPtr_PreservePreviousPannelVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr, "PreservePreviousPannelVisual");
			COM_ADialog_Play_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr, 100687700);
			COM_ADialog_Play_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr, 100687701);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x002307C8 File Offset: 0x0022E9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293947, XrefRangeEnd = 293957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Play_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00230804 File Offset: 0x0022EA04
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Play_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Play_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Play_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x000417D5 File Offset: 0x0003F9D5
		public COM_ADialog_Play_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x00230840 File Offset: 0x0022EA40
		// (set) Token: 0x06007923 RID: 31011 RVA: 0x000417DE File Offset: 0x0003F9DE
		public unsafe DialogPackage dialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play_Behaviour.NativeFieldInfoPtr_dialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play_Behaviour.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x00230870 File Offset: 0x0022EA70
		// (set) Token: 0x06007925 RID: 31013 RVA: 0x000417FD File Offset: 0x0003F9FD
		public unsafe bool PreservePreviousPannelVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play_Behaviour.NativeFieldInfoPtr_PreservePreviousPannelVisual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play_Behaviour.NativeFieldInfoPtr_PreservePreviousPannelVisual)) = value;
			}
		}

		// Token: 0x04004FC5 RID: 20421
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

		// Token: 0x04004FC6 RID: 20422
		private static readonly IntPtr NativeFieldInfoPtr_PreservePreviousPannelVisual;

		// Token: 0x04004FC7 RID: 20423
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FC8 RID: 20424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
