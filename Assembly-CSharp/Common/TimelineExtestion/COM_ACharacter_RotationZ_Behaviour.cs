using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200042C RID: 1068
	public class COM_ACharacter_RotationZ_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078B8 RID: 30904 RVA: 0x0022F638 File Offset: 0x0022D838
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_RotationZ_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_RotationZ_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr);
			COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr, "targetValue");
			COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_continuousRotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr, "continuousRotationZ");
			COM_ACharacter_RotationZ_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr, 100687663);
			COM_ACharacter_RotationZ_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr, 100687664);
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x0022F6CC File Offset: 0x0022D8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293704, XrefRangeEnd = 293708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_RotationZ_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x0022F708 File Offset: 0x0022D908
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_RotationZ_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_RotationZ_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_RotationZ_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x000414D3 File Offset: 0x0003F6D3
		public COM_ACharacter_RotationZ_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x060078BC RID: 30908 RVA: 0x0022F744 File Offset: 0x0022D944
		// (set) Token: 0x060078BD RID: 30909 RVA: 0x000414DC File Offset: 0x0003F6DC
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x0022F76C File Offset: 0x0022D96C
		// (set) Token: 0x060078BF RID: 30911 RVA: 0x000414FB File Offset: 0x0003F6FB
		public unsafe float targetValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_targetValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_targetValue)) = value;
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x060078C0 RID: 30912 RVA: 0x0022F794 File Offset: 0x0022D994
		// (set) Token: 0x060078C1 RID: 30913 RVA: 0x00041516 File Offset: 0x0003F716
		public unsafe bool continuousRotationZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_continuousRotationZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotationZ_Behaviour.NativeFieldInfoPtr_continuousRotationZ)) = value;
			}
		}

		// Token: 0x04004F8F RID: 20367
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F90 RID: 20368
		private static readonly IntPtr NativeFieldInfoPtr_targetValue;

		// Token: 0x04004F91 RID: 20369
		private static readonly IntPtr NativeFieldInfoPtr_continuousRotationZ;

		// Token: 0x04004F92 RID: 20370
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F93 RID: 20371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
