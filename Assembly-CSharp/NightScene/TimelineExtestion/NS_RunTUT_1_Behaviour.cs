using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F2 RID: 498
	public class NS_RunTUT_1_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CD9 RID: 15577 RVA: 0x0016D018 File Offset: 0x0016B218
		// Note: this type is marked as 'beforefieldinit'.
		static NS_RunTUT_1_Behaviour()
		{
			Il2CppClassPointerStore<NS_RunTUT_1_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_RunTUT_1_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_RunTUT_1_Behaviour>.NativeClassPtr);
			NS_RunTUT_1_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_1_Behaviour>.NativeClassPtr, 100674526);
			NS_RunTUT_1_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_1_Behaviour>.NativeClassPtr, 100674527);
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x0016D070 File Offset: 0x0016B270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136991, XrefRangeEnd = 136996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_RunTUT_1_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x0016D0AC File Offset: 0x0016B2AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_RunTUT_1_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_RunTUT_1_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_RunTUT_1_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x000221CF File Offset: 0x000203CF
		public NS_RunTUT_1_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
