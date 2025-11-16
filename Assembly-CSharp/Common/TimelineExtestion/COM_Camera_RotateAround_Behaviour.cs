using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200041F RID: 1055
	public class COM_Camera_RotateAround_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007840 RID: 30784 RVA: 0x0022E2C8 File Offset: 0x0022C4C8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_RotateAround_Behaviour()
		{
			Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_RotateAround_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr);
			COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, "startPoint");
			COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, "pivot");
			COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, "angle");
			COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, "speedMultiplier");
			COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			COM_Camera_RotateAround_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, 100687621);
			COM_Camera_RotateAround_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr, 100687622);
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x0022E384 File Offset: 0x0022C584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293493, XrefRangeEnd = 293500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_RotateAround_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x0022E3C0 File Offset: 0x0022C5C0
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_RotateAround_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_RotateAround_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_RotateAround_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x000410DA File Offset: 0x0003F2DA
		public COM_Camera_RotateAround_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x0022E3FC File Offset: 0x0022C5FC
		// (set) Token: 0x06007845 RID: 30789 RVA: 0x000410E3 File Offset: 0x0003F2E3
		public unsafe Vector2 startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_startPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_startPoint)) = value;
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x0022E424 File Offset: 0x0022C624
		// (set) Token: 0x06007847 RID: 30791 RVA: 0x000410FE File Offset: 0x0003F2FE
		public unsafe Vector2 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x06007848 RID: 30792 RVA: 0x0022E44C File Offset: 0x0022C64C
		// (set) Token: 0x06007849 RID: 30793 RVA: 0x00041119 File Offset: 0x0003F319
		public unsafe float angle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_angle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_angle)) = value;
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600784A RID: 30794 RVA: 0x0022E474 File Offset: 0x0022C674
		// (set) Token: 0x0600784B RID: 30795 RVA: 0x00041134 File Offset: 0x0003F334
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x0022E49C File Offset: 0x0022C69C
		// (set) Token: 0x0600784D RID: 30797 RVA: 0x0004114F File Offset: 0x0003F34F
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004F51 RID: 20305
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004F52 RID: 20306
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x04004F53 RID: 20307
		private static readonly IntPtr NativeFieldInfoPtr_angle;

		// Token: 0x04004F54 RID: 20308
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004F55 RID: 20309
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004F56 RID: 20310
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F57 RID: 20311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
