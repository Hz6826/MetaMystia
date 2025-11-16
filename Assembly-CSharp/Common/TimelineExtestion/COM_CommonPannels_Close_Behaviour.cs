using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200044C RID: 1100
	public class COM_CommonPannels_Close_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060079A1 RID: 31137 RVA: 0x00231DD0 File Offset: 0x0022FFD0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_CommonPannels_Close_Behaviour()
		{
			Il2CppClassPointerStore<COM_CommonPannels_Close_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_CommonPannels_Close_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_CommonPannels_Close_Behaviour>.NativeClassPtr);
			COM_CommonPannels_Close_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Close_Behaviour>.NativeClassPtr, 100687748);
			COM_CommonPannels_Close_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Close_Behaviour>.NativeClassPtr, 100687749);
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00231E28 File Offset: 0x00230028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294140, XrefRangeEnd = 294143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_CommonPannels_Close_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x00231E64 File Offset: 0x00230064
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_CommonPannels_Close_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_CommonPannels_Close_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_CommonPannels_Close_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00041B35 File Offset: 0x0003FD35
		public COM_CommonPannels_Close_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005007 RID: 20487
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04005008 RID: 20488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
