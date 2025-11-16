using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F4 RID: 1012
	public class COM_Camera_RotateAround : PlayableAsset
	{
		// Token: 0x060076D6 RID: 30422 RVA: 0x0022A2C8 File Offset: 0x002284C8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_RotateAround()
		{
			Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_RotateAround");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr);
			COM_Camera_RotateAround.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, "startPoint");
			COM_Camera_RotateAround.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, "pivot");
			COM_Camera_RotateAround.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, "angle");
			COM_Camera_RotateAround.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, "speedMultiplier");
			COM_Camera_RotateAround.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, "shouldWaitForFinish");
			COM_Camera_RotateAround.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, 100687531);
			COM_Camera_RotateAround.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr, 100687532);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x0022A384 File Offset: 0x00228584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292914, XrefRangeEnd = 292934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_RotateAround.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x0022A3EC File Offset: 0x002285EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292934, XrefRangeEnd = 292935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_RotateAround() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_RotateAround>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_RotateAround.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x000404D0 File Offset: 0x0003E6D0
		public COM_Camera_RotateAround(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x060076DA RID: 30426 RVA: 0x0022A428 File Offset: 0x00228628
		// (set) Token: 0x060076DB RID: 30427 RVA: 0x000404D9 File Offset: 0x0003E6D9
		public unsafe Vector2 startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_startPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_startPoint)) = value;
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x060076DC RID: 30428 RVA: 0x0022A450 File Offset: 0x00228650
		// (set) Token: 0x060076DD RID: 30429 RVA: 0x000404F4 File Offset: 0x0003E6F4
		public unsafe Vector2 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x060076DE RID: 30430 RVA: 0x0022A478 File Offset: 0x00228678
		// (set) Token: 0x060076DF RID: 30431 RVA: 0x0004050F File Offset: 0x0003E70F
		public unsafe float angle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_angle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_angle)) = value;
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x060076E0 RID: 30432 RVA: 0x0022A4A0 File Offset: 0x002286A0
		// (set) Token: 0x060076E1 RID: 30433 RVA: 0x0004052A File Offset: 0x0003E72A
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x060076E2 RID: 30434 RVA: 0x0022A4C8 File Offset: 0x002286C8
		// (set) Token: 0x060076E3 RID: 30435 RVA: 0x00040545 File Offset: 0x0003E745
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_RotateAround.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004E9A RID: 20122
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004E9B RID: 20123
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x04004E9C RID: 20124
		private static readonly IntPtr NativeFieldInfoPtr_angle;

		// Token: 0x04004E9D RID: 20125
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004E9E RID: 20126
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004E9F RID: 20127
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EA0 RID: 20128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
