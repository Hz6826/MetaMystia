using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000446 RID: 1094
	public class COM_OverrideBGM_Stop_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007977 RID: 31095 RVA: 0x002316D4 File Offset: 0x0022F8D4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_OverrideBGM_Stop_Behaviour()
		{
			Il2CppClassPointerStore<COM_OverrideBGM_Stop_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_OverrideBGM_Stop_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_OverrideBGM_Stop_Behaviour>.NativeClassPtr);
			COM_OverrideBGM_Stop_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Stop_Behaviour>.NativeClassPtr, 100687733);
			COM_OverrideBGM_Stop_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_OverrideBGM_Stop_Behaviour>.NativeClassPtr, 100687734);
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x0023172C File Offset: 0x0022F92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294093, XrefRangeEnd = 294098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_OverrideBGM_Stop_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x00231768 File Offset: 0x0022F968
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_OverrideBGM_Stop_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_OverrideBGM_Stop_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_OverrideBGM_Stop_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x00041A00 File Offset: 0x0003FC00
		public COM_OverrideBGM_Stop_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004FF2 RID: 20466
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FF3 RID: 20467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
