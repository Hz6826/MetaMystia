using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200042F RID: 1071
	public class COM_ACharacter_ShakeStop_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078D6 RID: 30934 RVA: 0x0022FAC4 File Offset: 0x0022DCC4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_ShakeStop_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_ShakeStop_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_ShakeStop_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_ShakeStop_Behaviour>.NativeClassPtr);
			COM_ACharacter_ShakeStop_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ShakeStop_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_ShakeStop_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ShakeStop_Behaviour>.NativeClassPtr, 100687669);
			COM_ACharacter_ShakeStop_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ShakeStop_Behaviour>.NativeClassPtr, 100687670);
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x0022FB30 File Offset: 0x0022DD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293725, XrefRangeEnd = 293733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_ShakeStop_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x0022FB6C File Offset: 0x0022DD6C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_ShakeStop_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_ShakeStop_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ShakeStop_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x000415ED File Offset: 0x0003F7ED
		public COM_ACharacter_ShakeStop_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x060078DA RID: 30938 RVA: 0x0022FBA8 File Offset: 0x0022DDA8
		// (set) Token: 0x060078DB RID: 30939 RVA: 0x000415F6 File Offset: 0x0003F7F6
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ShakeStop_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ShakeStop_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F9E RID: 20382
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F9F RID: 20383
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FA0 RID: 20384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
