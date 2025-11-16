using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F3 RID: 499
	public class NS_RunTUT_2_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CDD RID: 15581 RVA: 0x0016D0E8 File Offset: 0x0016B2E8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_RunTUT_2_Behaviour()
		{
			Il2CppClassPointerStore<NS_RunTUT_2_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_RunTUT_2_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_RunTUT_2_Behaviour>.NativeClassPtr);
			NS_RunTUT_2_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_2_Behaviour>.NativeClassPtr, 100674528);
			NS_RunTUT_2_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_2_Behaviour>.NativeClassPtr, 100674529);
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x0016D140 File Offset: 0x0016B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136996, XrefRangeEnd = 137001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_RunTUT_2_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x0016D17C File Offset: 0x0016B37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_RunTUT_2_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_RunTUT_2_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_RunTUT_2_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x000221D8 File Offset: 0x000203D8
		public NS_RunTUT_2_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
