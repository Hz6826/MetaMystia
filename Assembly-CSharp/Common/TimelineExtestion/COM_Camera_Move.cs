using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F3 RID: 1011
	public class COM_Camera_Move : PlayableAsset
	{
		// Token: 0x060076CA RID: 30410 RVA: 0x0022A0D4 File Offset: 0x002282D4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_Move()
		{
			Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_Move");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr);
			COM_Camera_Move.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr, "startPoint");
			COM_Camera_Move.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr, "wayPoints");
			COM_Camera_Move.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr, "speedMultiplier");
			COM_Camera_Move.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr, "shouldWaitForFinish");
			COM_Camera_Move.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr, 100687529);
			COM_Camera_Move.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr, 100687530);
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x0022A17C File Offset: 0x0022837C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292895, XrefRangeEnd = 292914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_Move.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x0022A1E4 File Offset: 0x002283E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_Move() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_Move>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_Move.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00040457 File Offset: 0x0003E657
		public COM_Camera_Move(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x060076CE RID: 30414 RVA: 0x0022A220 File Offset: 0x00228420
		// (set) Token: 0x060076CF RID: 30415 RVA: 0x00040460 File Offset: 0x0003E660
		public unsafe Vector2 startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_startPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_startPoint)) = value;
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x060076D0 RID: 30416 RVA: 0x0022A248 File Offset: 0x00228448
		// (set) Token: 0x060076D1 RID: 30417 RVA: 0x0004047B File Offset: 0x0003E67B
		public unsafe Il2CppStructArray<Vector2> wayPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_wayPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x060076D2 RID: 30418 RVA: 0x0022A278 File Offset: 0x00228478
		// (set) Token: 0x060076D3 RID: 30419 RVA: 0x0004049A File Offset: 0x0003E69A
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x060076D4 RID: 30420 RVA: 0x0022A2A0 File Offset: 0x002284A0
		// (set) Token: 0x060076D5 RID: 30421 RVA: 0x000404B5 File Offset: 0x0003E6B5
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Move.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004E94 RID: 20116
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004E95 RID: 20117
		private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

		// Token: 0x04004E96 RID: 20118
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004E97 RID: 20119
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004E98 RID: 20120
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E99 RID: 20121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
