using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E1 RID: 993
	public class COM_ACharacter_Move : PlayableAsset
	{
		// Token: 0x06007632 RID: 30258 RVA: 0x002285A4 File Offset: 0x002267A4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Move()
		{
			Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Move");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr);
			COM_ACharacter_Move.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, "label");
			COM_ACharacter_Move.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, "wayPoints");
			COM_ACharacter_Move.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, "speedMultiplier");
			COM_ACharacter_Move.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, "shouldWaitForFinish");
			COM_ACharacter_Move.NativeFieldInfoPtr_noAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, "noAnimation");
			COM_ACharacter_Move.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, 100687493);
			COM_ACharacter_Move.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr, 100687494);
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00228660 File Offset: 0x00226860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292641, XrefRangeEnd = 292663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Move.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x002286C8 File Offset: 0x002268C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292663, XrefRangeEnd = 292664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Move() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Move>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Move.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x0003FF41 File Offset: 0x0003E141
		public COM_ACharacter_Move(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x00228704 File Offset: 0x00226904
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x0003FF4A File Offset: 0x0003E14A
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x0022872C File Offset: 0x0022692C
		// (set) Token: 0x06007639 RID: 30265 RVA: 0x0003FF69 File Offset: 0x0003E169
		public unsafe Il2CppStructArray<Vector2> wayPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_wayPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x0022875C File Offset: 0x0022695C
		// (set) Token: 0x0600763B RID: 30267 RVA: 0x0003FF88 File Offset: 0x0003E188
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x00228784 File Offset: 0x00226984
		// (set) Token: 0x0600763D RID: 30269 RVA: 0x0003FFA3 File Offset: 0x0003E1A3
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600763E RID: 30270 RVA: 0x002287AC File Offset: 0x002269AC
		// (set) Token: 0x0600763F RID: 30271 RVA: 0x0003FFBE File Offset: 0x0003E1BE
		public unsafe bool noAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_noAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move.NativeFieldInfoPtr_noAnimation)) = value;
			}
		}

		// Token: 0x04004E48 RID: 20040
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E49 RID: 20041
		private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

		// Token: 0x04004E4A RID: 20042
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004E4B RID: 20043
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004E4C RID: 20044
		private static readonly IntPtr NativeFieldInfoPtr_noAnimation;

		// Token: 0x04004E4D RID: 20045
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E4E RID: 20046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
