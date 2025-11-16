using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200043B RID: 1083
	public class COM_ADialog_Manual_Exit_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600793B RID: 31035 RVA: 0x00230BE4 File Offset: 0x0022EDE4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Manual_Exit_Behaviour()
		{
			Il2CppClassPointerStore<COM_ADialog_Manual_Exit_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Manual_Exit_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Manual_Exit_Behaviour>.NativeClassPtr);
			COM_ADialog_Manual_Exit_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Exit_Behaviour>.NativeClassPtr, 100687711);
			COM_ADialog_Manual_Exit_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Exit_Behaviour>.NativeClassPtr, 100687712);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x00230C3C File Offset: 0x0022EE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294030, XrefRangeEnd = 294036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Manual_Exit_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x00230C78 File Offset: 0x0022EE78
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Manual_Exit_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Manual_Exit_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Exit_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x000418B5 File Offset: 0x0003FAB5
		public COM_ADialog_Manual_Exit_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004FD4 RID: 20436
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FD5 RID: 20437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
