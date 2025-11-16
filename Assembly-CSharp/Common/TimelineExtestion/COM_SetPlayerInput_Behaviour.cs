using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200043D RID: 1085
	public class COM_SetPlayerInput_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007945 RID: 31045 RVA: 0x00230DC0 File Offset: 0x0022EFC0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SetPlayerInput_Behaviour()
		{
			Il2CppClassPointerStore<COM_SetPlayerInput_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SetPlayerInput_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SetPlayerInput_Behaviour>.NativeClassPtr);
			COM_SetPlayerInput_Behaviour.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SetPlayerInput_Behaviour>.NativeClassPtr, "enabled");
			COM_SetPlayerInput_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerInput_Behaviour>.NativeClassPtr, 100687715);
			COM_SetPlayerInput_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerInput_Behaviour>.NativeClassPtr, 100687716);
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x00230E2C File Offset: 0x0022F02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294047, XrefRangeEnd = 294054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SetPlayerInput_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00230E68 File Offset: 0x0022F068
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SetPlayerInput_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SetPlayerInput_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SetPlayerInput_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x000418E2 File Offset: 0x0003FAE2
		public COM_SetPlayerInput_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x06007949 RID: 31049 RVA: 0x00230EA4 File Offset: 0x0022F0A4
		// (set) Token: 0x0600794A RID: 31050 RVA: 0x000418EB File Offset: 0x0003FAEB
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerInput_Behaviour.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerInput_Behaviour.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x04004FD9 RID: 20441
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04004FDA RID: 20442
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FDB RID: 20443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
