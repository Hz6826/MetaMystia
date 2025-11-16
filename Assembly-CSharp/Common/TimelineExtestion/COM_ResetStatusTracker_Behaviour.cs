using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000442 RID: 1090
	public class COM_ResetStatusTracker_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007961 RID: 31073 RVA: 0x002312D0 File Offset: 0x0022F4D0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ResetStatusTracker_Behaviour()
		{
			Il2CppClassPointerStore<COM_ResetStatusTracker_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ResetStatusTracker_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ResetStatusTracker_Behaviour>.NativeClassPtr);
			COM_ResetStatusTracker_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ResetStatusTracker_Behaviour>.NativeClassPtr, 100687725);
			COM_ResetStatusTracker_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ResetStatusTracker_Behaviour>.NativeClassPtr, 100687726);
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x00231328 File Offset: 0x0022F528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294074, XrefRangeEnd = 294077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ResetStatusTracker_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x00231364 File Offset: 0x0022F564
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ResetStatusTracker_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ResetStatusTracker_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ResetStatusTracker_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x00041983 File Offset: 0x0003FB83
		public COM_ResetStatusTracker_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004FE7 RID: 20455
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FE8 RID: 20456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
