using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001EB RID: 491
	public class NS_BackToMainMenu_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003CA1 RID: 15521 RVA: 0x0016C720 File Offset: 0x0016A920
		// Note: this type is marked as 'beforefieldinit'.
		static NS_BackToMainMenu_Behaviour()
		{
			Il2CppClassPointerStore<NS_BackToMainMenu_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_BackToMainMenu_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_BackToMainMenu_Behaviour>.NativeClassPtr);
			NS_BackToMainMenu_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_BackToMainMenu_Behaviour>.NativeClassPtr, 100674512);
			NS_BackToMainMenu_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_BackToMainMenu_Behaviour>.NativeClassPtr, 100674513);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0016C778 File Offset: 0x0016A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136942, XrefRangeEnd = 136946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_BackToMainMenu_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x0016C7B4 File Offset: 0x0016A9B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_BackToMainMenu_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_BackToMainMenu_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_BackToMainMenu_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x00021FFE File Offset: 0x000201FE
		public NS_BackToMainMenu_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
