using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.TimelineExtestion
{
	// Token: 0x02000437 RID: 1079
	public class COM_AFadeInFadeOut_OnFinish_Behvaiour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007917 RID: 30999 RVA: 0x00230600 File Offset: 0x0022E800
		// Note: this type is marked as 'beforefieldinit'.
		static COM_AFadeInFadeOut_OnFinish_Behvaiour()
		{
			Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_AFadeInFadeOut_OnFinish_Behvaiour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr);
			COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr, "onFinished");
			COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeMethodInfoPtr_NotifyFinish_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr, 100687697);
			COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr, 100687698);
			COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr, 100687699);
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x00230680 File Offset: 0x0022E880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293934, RefRangeEnd = 293936, XrefRangeStart = 293929, XrefRangeEnd = 293934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyFinish()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeMethodInfoPtr_NotifyFinish_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x002306A8 File Offset: 0x0022E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293936, XrefRangeEnd = 293947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x002306E4 File Offset: 0x0022E8E4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_AFadeInFadeOut_OnFinish_Behvaiour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_AFadeInFadeOut_OnFinish_Behvaiour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x000417BA File Offset: 0x0003F9BA
		public COM_AFadeInFadeOut_OnFinish_Behvaiour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600791C RID: 31004 RVA: 0x00230720 File Offset: 0x0022E920
		// (set) Token: 0x0600791D RID: 31005 RVA: 0x000417C3 File Offset: 0x0003F9C3
		public unsafe static Action onFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeFieldInfoPtr_onFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(COM_AFadeInFadeOut_OnFinish_Behvaiour.NativeFieldInfoPtr_onFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FC1 RID: 20417
		private static readonly IntPtr NativeFieldInfoPtr_onFinished;

		// Token: 0x04004FC2 RID: 20418
		private static readonly IntPtr NativeMethodInfoPtr_NotifyFinish_Public_Static_Void_0;

		// Token: 0x04004FC3 RID: 20419
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FC4 RID: 20420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
