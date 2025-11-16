using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E1 RID: 481
	public class NS_AMGuest_WaitForLeave_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003C45 RID: 15429 RVA: 0x0016B7BC File Offset: 0x001699BC
		// Note: this type is marked as 'beforefieldinit'.
		static NS_AMGuest_WaitForLeave_Behaviour()
		{
			Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_AMGuest_WaitForLeave_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr);
			NS_AMGuest_WaitForLeave_Behaviour.NativeFieldInfoPtr_continueHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr, "continueHandle");
			NS_AMGuest_WaitForLeave_Behaviour.NativeMethodInfoPtr_TryContinue_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr, 100674479);
			NS_AMGuest_WaitForLeave_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr, 100674480);
			NS_AMGuest_WaitForLeave_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr, 100674481);
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x0016B83C File Offset: 0x00169A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136716, XrefRangeEnd = 136718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryContinue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_AMGuest_WaitForLeave_Behaviour.NativeMethodInfoPtr_TryContinue_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x0016B864 File Offset: 0x00169A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136718, XrefRangeEnd = 136729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_AMGuest_WaitForLeave_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x0016B8A0 File Offset: 0x00169AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_AMGuest_WaitForLeave_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_AMGuest_WaitForLeave_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_AMGuest_WaitForLeave_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00021D31 File Offset: 0x0001FF31
		public NS_AMGuest_WaitForLeave_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x0016B8DC File Offset: 0x00169ADC
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x00021D3A File Offset: 0x0001FF3A
		public unsafe static Action continueHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NS_AMGuest_WaitForLeave_Behaviour.NativeFieldInfoPtr_continueHandle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NS_AMGuest_WaitForLeave_Behaviour.NativeFieldInfoPtr_continueHandle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeFieldInfoPtr_continueHandle;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeMethodInfoPtr_TryContinue_Public_Static_Void_0;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
