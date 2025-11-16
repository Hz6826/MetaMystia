using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000432 RID: 1074
	public class COM_ACharacter_ResetDetachedCharacter_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078F0 RID: 30960 RVA: 0x0022FED8 File Offset: 0x0022E0D8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_ResetDetachedCharacter_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_ResetDetachedCharacter_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter_Behaviour>.NativeClassPtr);
			COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeFieldInfoPtr_detachedCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter_Behaviour>.NativeClassPtr, "detachedCharacterLabel");
			COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter_Behaviour>.NativeClassPtr, 100687675);
			COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter_Behaviour>.NativeClassPtr, 100687676);
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x0022FF44 File Offset: 0x0022E144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293756, XrefRangeEnd = 293768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x0022FF80 File Offset: 0x0022E180
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_ResetDetachedCharacter_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x000416D5 File Offset: 0x0003F8D5
		public COM_ACharacter_ResetDetachedCharacter_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x060078F4 RID: 30964 RVA: 0x0022FFBC File Offset: 0x0022E1BC
		// (set) Token: 0x060078F5 RID: 30965 RVA: 0x000416DE File Offset: 0x0003F8DE
		public unsafe string detachedCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeFieldInfoPtr_detachedCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetDetachedCharacter_Behaviour.NativeFieldInfoPtr_detachedCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004FAB RID: 20395
		private static readonly IntPtr NativeFieldInfoPtr_detachedCharacterLabel;

		// Token: 0x04004FAC RID: 20396
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FAD RID: 20397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
