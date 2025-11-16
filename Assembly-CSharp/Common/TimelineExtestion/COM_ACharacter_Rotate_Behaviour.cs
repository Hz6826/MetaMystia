using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000424 RID: 1060
	public class COM_ACharacter_Rotate_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600786A RID: 30826 RVA: 0x0022E96C File Offset: 0x0022CB6C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Rotate_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Rotate_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr);
			COM_ACharacter_Rotate_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Rotate_Behaviour.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr, "targetRotation");
			COM_ACharacter_Rotate_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr, 100687631);
			COM_ACharacter_Rotate_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr, 100687632);
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x0022E9EC File Offset: 0x0022CBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293519, XrefRangeEnd = 293524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Rotate_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x0022EA28 File Offset: 0x0022CC28
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Rotate_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Rotate_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Rotate_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00041234 File Offset: 0x0003F434
		public COM_ACharacter_Rotate_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x0022EA64 File Offset: 0x0022CC64
		// (set) Token: 0x0600786F RID: 30831 RVA: 0x0004123D File Offset: 0x0003F43D
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x0022EA8C File Offset: 0x0022CC8C
		// (set) Token: 0x06007871 RID: 30833 RVA: 0x0004125C File Offset: 0x0003F45C
		public unsafe DayScenePlayerInputGenerator.CharacterRotation targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate_Behaviour.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate_Behaviour.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x04004F66 RID: 20326
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F67 RID: 20327
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04004F68 RID: 20328
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F69 RID: 20329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
