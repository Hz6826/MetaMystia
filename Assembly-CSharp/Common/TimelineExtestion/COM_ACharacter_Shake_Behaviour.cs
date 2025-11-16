using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200042D RID: 1069
	public class COM_ACharacter_Shake_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x060078C2 RID: 30914 RVA: 0x0022F7BC File Offset: 0x0022D9BC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Shake_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Shake_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr);
			COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr, "amplitude");
			COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr, "duration");
			COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			COM_ACharacter_Shake_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr, 100687665);
			COM_ACharacter_Shake_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr, 100687666);
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x0022F864 File Offset: 0x0022DA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293708, XrefRangeEnd = 293720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Shake_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x0022F8A0 File Offset: 0x0022DAA0
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Shake_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Shake_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Shake_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x00041531 File Offset: 0x0003F731
		public COM_ACharacter_Shake_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x0022F8DC File Offset: 0x0022DADC
		// (set) Token: 0x060078C7 RID: 30919 RVA: 0x0004153A File Offset: 0x0003F73A
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x0022F904 File Offset: 0x0022DB04
		// (set) Token: 0x060078C9 RID: 30921 RVA: 0x00041559 File Offset: 0x0003F759
		public unsafe Vector2 amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x0022F92C File Offset: 0x0022DB2C
		// (set) Token: 0x060078CB RID: 30923 RVA: 0x00041574 File Offset: 0x0003F774
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x0022F954 File Offset: 0x0022DB54
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x0004158F File Offset: 0x0003F78F
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004F94 RID: 20372
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F95 RID: 20373
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04004F96 RID: 20374
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04004F97 RID: 20375
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004F98 RID: 20376
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F99 RID: 20377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
