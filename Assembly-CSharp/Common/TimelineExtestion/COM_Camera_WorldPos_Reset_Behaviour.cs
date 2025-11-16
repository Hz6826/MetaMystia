using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000423 RID: 1059
	public class COM_Camera_WorldPos_Reset_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007866 RID: 30822 RVA: 0x0022E89C File Offset: 0x0022CA9C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_WorldPos_Reset_Behaviour()
		{
			Il2CppClassPointerStore<COM_Camera_WorldPos_Reset_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_WorldPos_Reset_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset_Behaviour>.NativeClassPtr);
			COM_Camera_WorldPos_Reset_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset_Behaviour>.NativeClassPtr, 100687629);
			COM_Camera_WorldPos_Reset_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset_Behaviour>.NativeClassPtr, 100687630);
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x0022E8F4 File Offset: 0x0022CAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293514, XrefRangeEnd = 293519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_WorldPos_Reset_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x0022E930 File Offset: 0x0022CB30
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_WorldPos_Reset_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_WorldPos_Reset_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_WorldPos_Reset_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x0004122B File Offset: 0x0003F42B
		public COM_Camera_WorldPos_Reset_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004F64 RID: 20324
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F65 RID: 20325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
