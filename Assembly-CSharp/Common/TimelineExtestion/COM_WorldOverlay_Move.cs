using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000410 RID: 1040
	public class COM_WorldOverlay_Move : PlayableAsset
	{
		// Token: 0x06007792 RID: 30610 RVA: 0x0022C778 File Offset: 0x0022A978
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Move()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Move");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr);
			COM_WorldOverlay_Move.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr, "label");
			COM_WorldOverlay_Move.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr, "wayPoints");
			COM_WorldOverlay_Move.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr, "speedMultiplier");
			COM_WorldOverlay_Move.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr, "shouldWaitForFinish");
			COM_WorldOverlay_Move.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr, 100687587);
			COM_WorldOverlay_Move.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr, 100687588);
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x0022C820 File Offset: 0x0022AA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293284, XrefRangeEnd = 293304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Move.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x0022C888 File Offset: 0x0022AA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Move() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Move>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Move.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00040A12 File Offset: 0x0003EC12
		public COM_WorldOverlay_Move(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x0022C8C4 File Offset: 0x0022AAC4
		// (set) Token: 0x06007797 RID: 30615 RVA: 0x00040A1B File Offset: 0x0003EC1B
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x0022C8EC File Offset: 0x0022AAEC
		// (set) Token: 0x06007799 RID: 30617 RVA: 0x00040A3A File Offset: 0x0003EC3A
		public unsafe Il2CppStructArray<Vector2> wayPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_wayPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x0600779A RID: 30618 RVA: 0x0022C91C File Offset: 0x0022AB1C
		// (set) Token: 0x0600779B RID: 30619 RVA: 0x00040A59 File Offset: 0x0003EC59
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x0022C944 File Offset: 0x0022AB44
		// (set) Token: 0x0600779D RID: 30621 RVA: 0x00040A74 File Offset: 0x0003EC74
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Move.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004EF8 RID: 20216
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004EF9 RID: 20217
		private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

		// Token: 0x04004EFA RID: 20218
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004EFB RID: 20219
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004EFC RID: 20220
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EFD RID: 20221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
