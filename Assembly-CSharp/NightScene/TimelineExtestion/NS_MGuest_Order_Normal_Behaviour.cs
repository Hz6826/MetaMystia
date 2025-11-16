using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E3 RID: 483
	public class NS_MGuest_Order_Normal_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003C58 RID: 15448 RVA: 0x0016BAC4 File Offset: 0x00169CC4
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_Order_Normal_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_Order_Normal_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr);
			NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_bevId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr, "bevId");
			NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_foodId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr, "foodId");
			NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr, "label");
			NS_MGuest_Order_Normal_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr, 100674488);
			NS_MGuest_Order_Normal_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr, 100674489);
			NS_MGuest_Order_Normal_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr, 100674490);
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x0016BB6C File Offset: 0x00169D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136769, XrefRangeEnd = 136779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_Order_Normal_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x0016BBA8 File Offset: 0x00169DA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_Order_Normal_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_Order_Normal_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_Order_Normal_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x0016BBE4 File Offset: 0x00169DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136779, XrefRangeEnd = 136792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBehaviourEnter_b__3_0(GuestGroupController.EvaluationResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_Order_Normal_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x00021DC5 File Offset: 0x0001FFC5
		public NS_MGuest_Order_Normal_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0016BC24 File Offset: 0x00169E24
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x00021DCE File Offset: 0x0001FFCE
		public unsafe int bevId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_bevId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_bevId)) = value;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0016BC4C File Offset: 0x00169E4C
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x00021DE9 File Offset: 0x0001FFE9
		public unsafe int foodId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_foodId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_foodId)) = value;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x0016BC74 File Offset: 0x00169E74
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x00021E04 File Offset: 0x00020004
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeFieldInfoPtr_bevId;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeFieldInfoPtr_foodId;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_EvaluationResult_0;
	}
}
