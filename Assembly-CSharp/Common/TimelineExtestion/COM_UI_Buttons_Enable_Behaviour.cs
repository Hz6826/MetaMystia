using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000440 RID: 1088
	public class COM_UI_Buttons_Enable_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007959 RID: 31065 RVA: 0x00231130 File Offset: 0x0022F330
		// Note: this type is marked as 'beforefieldinit'.
		static COM_UI_Buttons_Enable_Behaviour()
		{
			Il2CppClassPointerStore<COM_UI_Buttons_Enable_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_UI_Buttons_Enable_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_UI_Buttons_Enable_Behaviour>.NativeClassPtr);
			COM_UI_Buttons_Enable_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_Buttons_Enable_Behaviour>.NativeClassPtr, 100687721);
			COM_UI_Buttons_Enable_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_Buttons_Enable_Behaviour>.NativeClassPtr, 100687722);
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x00231188 File Offset: 0x0022F388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294064, XrefRangeEnd = 294069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_UI_Buttons_Enable_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x002311C4 File Offset: 0x0022F3C4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_UI_Buttons_Enable_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_UI_Buttons_Enable_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_UI_Buttons_Enable_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x00041971 File Offset: 0x0003FB71
		public COM_UI_Buttons_Enable_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004FE3 RID: 20451
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FE4 RID: 20452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
