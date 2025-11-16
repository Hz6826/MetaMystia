using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F4 RID: 500
	public class NS_RunTUT_3_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003CE1 RID: 15585 RVA: 0x0016D1B8 File Offset: 0x0016B3B8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_RunTUT_3_Behaviour()
		{
			Il2CppClassPointerStore<NS_RunTUT_3_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_RunTUT_3_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_RunTUT_3_Behaviour>.NativeClassPtr);
			NS_RunTUT_3_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_3_Behaviour>.NativeClassPtr, 100674530);
			NS_RunTUT_3_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_RunTUT_3_Behaviour>.NativeClassPtr, 100674531);
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x0016D210 File Offset: 0x0016B410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137001, XrefRangeEnd = 137012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_RunTUT_3_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0016D24C File Offset: 0x0016B44C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_RunTUT_3_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_RunTUT_3_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_RunTUT_3_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x000221E1 File Offset: 0x000203E1
		public NS_RunTUT_3_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
