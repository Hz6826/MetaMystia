using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001EA RID: 490
	public class NS_MGuest_EvalR_Clear_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C9D RID: 15517 RVA: 0x0016C650 File Offset: 0x0016A850
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_EvalR_Clear_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_EvalR_Clear_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_EvalR_Clear_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear_Behaviour>.NativeClassPtr);
			NS_MGuest_EvalR_Clear_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear_Behaviour>.NativeClassPtr, 100674510);
			NS_MGuest_EvalR_Clear_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear_Behaviour>.NativeClassPtr, 100674511);
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x0016C6A8 File Offset: 0x0016A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136934, XrefRangeEnd = 136942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_EvalR_Clear_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0016C6E4 File Offset: 0x0016A8E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_EvalR_Clear_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_EvalR_Clear_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_EvalR_Clear_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00021FF5 File Offset: 0x000201F5
		public NS_MGuest_EvalR_Clear_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
