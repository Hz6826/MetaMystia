using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F1 RID: 497
	public class NS_MWorkSession_Leave_Behaviuor : ExtendedPlayableBehaviour
	{
		// Token: 0x06003CD5 RID: 15573 RVA: 0x0016CF48 File Offset: 0x0016B148
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MWorkSession_Leave_Behaviuor()
		{
			Il2CppClassPointerStore<NS_MWorkSession_Leave_Behaviuor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MWorkSession_Leave_Behaviuor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MWorkSession_Leave_Behaviuor>.NativeClassPtr);
			NS_MWorkSession_Leave_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MWorkSession_Leave_Behaviuor>.NativeClassPtr, 100674524);
			NS_MWorkSession_Leave_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MWorkSession_Leave_Behaviuor>.NativeClassPtr, 100674525);
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x0016CFA0 File Offset: 0x0016B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136980, XrefRangeEnd = 136991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MWorkSession_Leave_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x0016CFDC File Offset: 0x0016B1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MWorkSession_Leave_Behaviuor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MWorkSession_Leave_Behaviuor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MWorkSession_Leave_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000221C6 File Offset: 0x000203C6
		public NS_MWorkSession_Leave_Behaviuor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
