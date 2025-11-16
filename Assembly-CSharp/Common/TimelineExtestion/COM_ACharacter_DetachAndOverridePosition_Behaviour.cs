using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000431 RID: 1073
	public class COM_ACharacter_DetachAndOverridePosition_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078E4 RID: 30948 RVA: 0x0022FD18 File Offset: 0x0022DF18
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_DetachAndOverridePosition_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_DetachAndOverridePosition_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr);
			COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_baseLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr, "baseLabel");
			COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_detachCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr, "detachCharacterLabel");
			COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_detachIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr, "detachIndex");
			COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_overridePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr, "overridePosition");
			COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr, 100687673);
			COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr, 100687674);
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x0022FDC0 File Offset: 0x0022DFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293738, XrefRangeEnd = 293756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x0022FDFC File Offset: 0x0022DFFC
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_DetachAndOverridePosition_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_DetachAndOverridePosition_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00041658 File Offset: 0x0003F858
		public COM_ACharacter_DetachAndOverridePosition_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x060078E8 RID: 30952 RVA: 0x0022FE38 File Offset: 0x0022E038
		// (set) Token: 0x060078E9 RID: 30953 RVA: 0x00041661 File Offset: 0x0003F861
		public unsafe string baseLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_baseLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_baseLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x0022FE60 File Offset: 0x0022E060
		// (set) Token: 0x060078EB RID: 30955 RVA: 0x00041680 File Offset: 0x0003F880
		public unsafe string detachCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_detachCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_detachCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x060078EC RID: 30956 RVA: 0x0022FE88 File Offset: 0x0022E088
		// (set) Token: 0x060078ED RID: 30957 RVA: 0x0004169F File Offset: 0x0003F89F
		public unsafe int detachIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_detachIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_detachIndex)) = value;
			}
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x060078EE RID: 30958 RVA: 0x0022FEB0 File Offset: 0x0022E0B0
		// (set) Token: 0x060078EF RID: 30959 RVA: 0x000416BA File Offset: 0x0003F8BA
		public unsafe Vector2 overridePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_overridePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_DetachAndOverridePosition_Behaviour.NativeFieldInfoPtr_overridePosition)) = value;
			}
		}

		// Token: 0x04004FA5 RID: 20389
		private static readonly IntPtr NativeFieldInfoPtr_baseLabel;

		// Token: 0x04004FA6 RID: 20390
		private static readonly IntPtr NativeFieldInfoPtr_detachCharacterLabel;

		// Token: 0x04004FA7 RID: 20391
		private static readonly IntPtr NativeFieldInfoPtr_detachIndex;

		// Token: 0x04004FA8 RID: 20392
		private static readonly IntPtr NativeFieldInfoPtr_overridePosition;

		// Token: 0x04004FA9 RID: 20393
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FAA RID: 20394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
