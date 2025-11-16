using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200042E RID: 1070
	public class COM_ACharacter_Shake_Unmanaged_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078CE RID: 30926 RVA: 0x0022F97C File Offset: 0x0022DB7C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Shake_Unmanaged_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Shake_Unmanaged_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr);
			COM_ACharacter_Shake_Unmanaged_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Shake_Unmanaged_Behaviour.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr, "amplitude");
			COM_ACharacter_Shake_Unmanaged_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr, 100687667);
			COM_ACharacter_Shake_Unmanaged_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr, 100687668);
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x0022F9FC File Offset: 0x0022DBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293720, XrefRangeEnd = 293725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Shake_Unmanaged_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x0022FA38 File Offset: 0x0022DC38
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Shake_Unmanaged_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Shake_Unmanaged_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Shake_Unmanaged_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x000415AA File Offset: 0x0003F7AA
		public COM_ACharacter_Shake_Unmanaged_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x060078D2 RID: 30930 RVA: 0x0022FA74 File Offset: 0x0022DC74
		// (set) Token: 0x060078D3 RID: 30931 RVA: 0x000415B3 File Offset: 0x0003F7B3
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x0022FA9C File Offset: 0x0022DC9C
		// (set) Token: 0x060078D5 RID: 30933 RVA: 0x000415D2 File Offset: 0x0003F7D2
		public unsafe Vector2 amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged_Behaviour.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake_Unmanaged_Behaviour.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x04004F9A RID: 20378
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F9B RID: 20379
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04004F9C RID: 20380
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F9D RID: 20381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
