using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.TimelineExtestion
{
	// Token: 0x0200043A RID: 1082
	public class COM_ADialog_Manual_Play_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007934 RID: 31028 RVA: 0x00230A9C File Offset: 0x0022EC9C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Manual_Play_Behaviour()
		{
			Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Manual_Play_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr);
			COM_ADialog_Manual_Play_Behaviour.NativeFieldInfoPtr_currentContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr, "currentContinue");
			COM_ADialog_Manual_Play_Behaviour.NativeMethodInfoPtr_ContinueExtern_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr, 100687708);
			COM_ADialog_Manual_Play_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr, 100687709);
			COM_ADialog_Manual_Play_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr, 100687710);
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00230B1C File Offset: 0x0022ED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294008, XrefRangeEnd = 294014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ContinueExtern()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Play_Behaviour.NativeMethodInfoPtr_ContinueExtern_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00230B44 File Offset: 0x0022ED44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294014, XrefRangeEnd = 294030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Manual_Play_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00230B80 File Offset: 0x0022ED80
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Manual_Play_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Manual_Play_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Play_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0004189A File Offset: 0x0003FA9A
		public COM_ADialog_Manual_Play_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x06007939 RID: 31033 RVA: 0x00230BBC File Offset: 0x0022EDBC
		// (set) Token: 0x0600793A RID: 31034 RVA: 0x000418A3 File Offset: 0x0003FAA3
		public unsafe static Action currentContinue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(COM_ADialog_Manual_Play_Behaviour.NativeFieldInfoPtr_currentContinue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(COM_ADialog_Manual_Play_Behaviour.NativeFieldInfoPtr_currentContinue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FD0 RID: 20432
		private static readonly IntPtr NativeFieldInfoPtr_currentContinue;

		// Token: 0x04004FD1 RID: 20433
		private static readonly IntPtr NativeMethodInfoPtr_ContinueExtern_Public_Static_Void_0;

		// Token: 0x04004FD2 RID: 20434
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FD3 RID: 20435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
