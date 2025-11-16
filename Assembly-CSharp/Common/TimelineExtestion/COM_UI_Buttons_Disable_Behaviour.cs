using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000441 RID: 1089
	public class COM_UI_Buttons_Disable_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600795D RID: 31069 RVA: 0x00231200 File Offset: 0x0022F400
		// Note: this type is marked as 'beforefieldinit'.
		static COM_UI_Buttons_Disable_Behaviour()
		{
			Il2CppClassPointerStore<COM_UI_Buttons_Disable_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_UI_Buttons_Disable_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_UI_Buttons_Disable_Behaviour>.NativeClassPtr);
			COM_UI_Buttons_Disable_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_Buttons_Disable_Behaviour>.NativeClassPtr, 100687723);
			COM_UI_Buttons_Disable_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_Buttons_Disable_Behaviour>.NativeClassPtr, 100687724);
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x00231258 File Offset: 0x0022F458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294069, XrefRangeEnd = 294074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_UI_Buttons_Disable_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x00231294 File Offset: 0x0022F494
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_UI_Buttons_Disable_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_UI_Buttons_Disable_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_UI_Buttons_Disable_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x0004197A File Offset: 0x0003FB7A
		public COM_UI_Buttons_Disable_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004FE5 RID: 20453
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FE6 RID: 20454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
