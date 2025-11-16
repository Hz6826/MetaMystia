using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000418 RID: 1048
	public class COM_WorldOverlay_Move_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x060077F1 RID: 30705 RVA: 0x0022D6C4 File Offset: 0x0022B8C4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Move_Behaviour()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Move_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr);
			COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr, "label");
			COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr, "speedMultiplier");
			COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr, "wayPoints");
			COM_WorldOverlay_Move_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr, 100687606);
			COM_WorldOverlay_Move_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr, 100687607);
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x0022D76C File Offset: 0x0022B96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293429, XrefRangeEnd = 293436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Move_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x0022D7A8 File Offset: 0x0022B9A8
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Move_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Move_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Move_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x00040DC8 File Offset: 0x0003EFC8
		public COM_WorldOverlay_Move_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x060077F5 RID: 30709 RVA: 0x0022D7E4 File Offset: 0x0022B9E4
		// (set) Token: 0x060077F6 RID: 30710 RVA: 0x00040DD1 File Offset: 0x0003EFD1
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x060077F7 RID: 30711 RVA: 0x0022D80C File Offset: 0x0022BA0C
		// (set) Token: 0x060077F8 RID: 30712 RVA: 0x00040DF0 File Offset: 0x0003EFF0
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x060077F9 RID: 30713 RVA: 0x0022D834 File Offset: 0x0022BA34
		// (set) Token: 0x060077FA RID: 30714 RVA: 0x00040E0B File Offset: 0x0003F00B
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x060077FB RID: 30715 RVA: 0x0022D85C File Offset: 0x0022BA5C
		// (set) Token: 0x060077FC RID: 30716 RVA: 0x00040E26 File Offset: 0x0003F026
		public unsafe Il2CppStructArray<Vector2> wayPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_wayPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move_Behaviour.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F29 RID: 20265
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F2A RID: 20266
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004F2B RID: 20267
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004F2C RID: 20268
		private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

		// Token: 0x04004F2D RID: 20269
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F2E RID: 20270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
