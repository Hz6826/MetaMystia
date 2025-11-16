using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001EC RID: 492
	public class NS_MGuest_MVT_Leave_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CA5 RID: 15525 RVA: 0x0016C7F0 File Offset: 0x0016A9F0
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_MVT_Leave_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_MVT_Leave_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr);
			NS_MGuest_MVT_Leave_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr, "label");
			NS_MGuest_MVT_Leave_Behaviour.NativeFieldInfoPtr_shouldLeaveInstantly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr, "shouldLeaveInstantly");
			NS_MGuest_MVT_Leave_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr, 100674514);
			NS_MGuest_MVT_Leave_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr, 100674515);
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x0016C870 File Offset: 0x0016AA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136946, XrefRangeEnd = 136951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_MVT_Leave_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0016C8AC File Offset: 0x0016AAAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_MVT_Leave_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_Leave_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_Leave_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00022007 File Offset: 0x00020207
		public NS_MGuest_MVT_Leave_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x0016C8E8 File Offset: 0x0016AAE8
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x00022010 File Offset: 0x00020210
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x0016C910 File Offset: 0x0016AB10
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x0002202F File Offset: 0x0002022F
		public unsafe bool shouldLeaveInstantly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave_Behaviour.NativeFieldInfoPtr_shouldLeaveInstantly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave_Behaviour.NativeFieldInfoPtr_shouldLeaveInstantly)) = value;
			}
		}

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeFieldInfoPtr_shouldLeaveInstantly;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
