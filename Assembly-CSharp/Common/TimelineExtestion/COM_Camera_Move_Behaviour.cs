using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200041E RID: 1054
	public class COM_Camera_Move_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007834 RID: 30772 RVA: 0x0022E100 File Offset: 0x0022C300
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_Move_Behaviour()
		{
			Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_Move_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr);
			COM_Camera_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			COM_Camera_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr, "speedMultiplier");
			COM_Camera_Move_Behaviour.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr, "startPoint");
			COM_Camera_Move_Behaviour.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr, "wayPoints");
			COM_Camera_Move_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr, 100687619);
			COM_Camera_Move_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr, 100687620);
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x0022E1A8 File Offset: 0x0022C3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293486, XrefRangeEnd = 293493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_Move_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x0022E1E4 File Offset: 0x0022C3E4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_Move_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_Move_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_Move_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00041061 File Offset: 0x0003F261
		public COM_Camera_Move_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x0022E220 File Offset: 0x0022C420
		// (set) Token: 0x06007839 RID: 30777 RVA: 0x0004106A File Offset: 0x0003F26A
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x0022E248 File Offset: 0x0022C448
		// (set) Token: 0x0600783B RID: 30779 RVA: 0x00041085 File Offset: 0x0003F285
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x0022E270 File Offset: 0x0022C470
		// (set) Token: 0x0600783D RID: 30781 RVA: 0x000410A0 File Offset: 0x0003F2A0
		public unsafe Vector2 startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_startPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_startPoint)) = value;
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x0600783E RID: 30782 RVA: 0x0022E298 File Offset: 0x0022C498
		// (set) Token: 0x0600783F RID: 30783 RVA: 0x000410BB File Offset: 0x0003F2BB
		public unsafe Il2CppStructArray<Vector2> wayPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_wayPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move_Behaviour.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F4B RID: 20299
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004F4C RID: 20300
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004F4D RID: 20301
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004F4E RID: 20302
		private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

		// Token: 0x04004F4F RID: 20303
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F50 RID: 20304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
