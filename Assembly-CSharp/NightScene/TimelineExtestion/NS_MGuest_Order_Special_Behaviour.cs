using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E4 RID: 484
	public class NS_MGuest_Order_Special_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003C63 RID: 15459 RVA: 0x0016BC9C File Offset: 0x00169E9C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_Order_Special_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_Order_Special_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr);
			NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_bevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr, "bevTag");
			NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_foodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr, "foodTag");
			NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr, "label");
			NS_MGuest_Order_Special_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr, 100674491);
			NS_MGuest_Order_Special_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr, 100674492);
			NS_MGuest_Order_Special_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr, 100674493);
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x0016BD44 File Offset: 0x00169F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136792, XrefRangeEnd = 136802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_Order_Special_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x0016BD80 File Offset: 0x00169F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_Order_Special_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_Order_Special_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_Order_Special_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x0016BDBC File Offset: 0x00169FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136802, XrefRangeEnd = 136815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBehaviourEnter_b__3_0(GuestGroupController.EvaluationResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_Order_Special_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00021E23 File Offset: 0x00020023
		public NS_MGuest_Order_Special_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06003C68 RID: 15464 RVA: 0x0016BDFC File Offset: 0x00169FFC
		// (set) Token: 0x06003C69 RID: 15465 RVA: 0x00021E2C File Offset: 0x0002002C
		public unsafe int bevTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_bevTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_bevTag)) = value;
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x0016BE24 File Offset: 0x0016A024
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x00021E47 File Offset: 0x00020047
		public unsafe int foodTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_foodTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_foodTag)) = value;
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x0016BE4C File Offset: 0x0016A04C
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x00021E62 File Offset: 0x00020062
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeFieldInfoPtr_bevTag;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeFieldInfoPtr_foodTag;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_EvaluationResult_0;
	}
}
