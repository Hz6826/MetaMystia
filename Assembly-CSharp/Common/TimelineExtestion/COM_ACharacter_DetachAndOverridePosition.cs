using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003DE RID: 990
	public class COM_ACharacter_DetachAndOverridePosition : PlayableAsset
	{
		// Token: 0x0600760E RID: 30222 RVA: 0x00227FE0 File Offset: 0x002261E0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_DetachAndOverridePosition()
		{
			Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_DetachAndOverridePosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr);
			COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_baseLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr, "baseLabel");
			COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_detachIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr, "detachIndex");
			COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_detachCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr, "detachCharacterLabel");
			COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_overridePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr, "overridePosition");
			COM_ACharacter_DetachAndOverridePosition.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr, 100687487);
			COM_ACharacter_DetachAndOverridePosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr, 100687488);
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00228088 File Offset: 0x00226288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292580, XrefRangeEnd = 292600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_DetachAndOverridePosition.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x002280F0 File Offset: 0x002262F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_DetachAndOverridePosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_DetachAndOverridePosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x0003FDD2 File Offset: 0x0003DFD2
		public COM_ACharacter_DetachAndOverridePosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x06007612 RID: 30226 RVA: 0x0022812C File Offset: 0x0022632C
		// (set) Token: 0x06007613 RID: 30227 RVA: 0x0003FDDB File Offset: 0x0003DFDB
		public unsafe string baseLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_baseLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_baseLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x06007614 RID: 30228 RVA: 0x00228154 File Offset: 0x00226354
		// (set) Token: 0x06007615 RID: 30229 RVA: 0x0003FDFA File Offset: 0x0003DFFA
		public unsafe int detachIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_detachIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_detachIndex)) = value;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x06007616 RID: 30230 RVA: 0x0022817C File Offset: 0x0022637C
		// (set) Token: 0x06007617 RID: 30231 RVA: 0x0003FE15 File Offset: 0x0003E015
		public unsafe string detachCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_detachCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_detachCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x06007618 RID: 30232 RVA: 0x002281A4 File Offset: 0x002263A4
		// (set) Token: 0x06007619 RID: 30233 RVA: 0x0003FE34 File Offset: 0x0003E034
		public unsafe Vector2 overridePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_overridePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition.NativeFieldInfoPtr_overridePosition)) = value;
			}
		}

		// Token: 0x04004E36 RID: 20022
		private static readonly IntPtr NativeFieldInfoPtr_baseLabel;

		// Token: 0x04004E37 RID: 20023
		private static readonly IntPtr NativeFieldInfoPtr_detachIndex;

		// Token: 0x04004E38 RID: 20024
		private static readonly IntPtr NativeFieldInfoPtr_detachCharacterLabel;

		// Token: 0x04004E39 RID: 20025
		private static readonly IntPtr NativeFieldInfoPtr_overridePosition;

		// Token: 0x04004E3A RID: 20026
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E3B RID: 20027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
