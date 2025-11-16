using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200011F RID: 287
	public class DLC5_RogueLikePurchaseRecyclePanel : DLC5_RogueLikePurchaseItemPanel
	{
		// Token: 0x060020EC RID: 8428 RVA: 0x0010BB5C File Offset: 0x00109D5C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikePurchaseRecyclePanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikePurchaseRecyclePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669175);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_AfterBuy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669176);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_GetProductPriceAfterDiscount_Protected_Virtual_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669177);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_UpdateBuyButtonInteractable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669178);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669179);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669180);
			DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr, 100669181);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0010BC18 File Offset: 0x00109E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80244, XrefRangeEnd = 80254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0010BC54 File Offset: 0x00109E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80254, XrefRangeEnd = 80260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterBuy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_AfterBuy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x0010BC90 File Offset: 0x00109E90
		[CallerCount(0)]
		public unsafe override int GetProductPriceAfterDiscount(Product product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_GetProductPriceAfterDiscount_Protected_Virtual_Int32_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0010BCF0 File Offset: 0x00109EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80260, XrefRangeEnd = 80264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBuyButtonInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_UpdateBuyButtonInteractable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0010BD2C File Offset: 0x00109F2C
		[CallerCount(0)]
		public unsafe override int GetFinalFund(int currentFund)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentFund;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0010BD80 File Offset: 0x00109F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80264, XrefRangeEnd = 80265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0010BDBC File Offset: 0x00109FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80265, XrefRangeEnd = 80266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePurchaseRecyclePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecyclePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseRecyclePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00014046 File Offset: 0x00012246
		public DLC5_RogueLikePurchaseRecyclePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_AfterBuy_Protected_Virtual_Void_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_GetProductPriceAfterDiscount_Protected_Virtual_Int32_Product_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBuyButtonInteractable_Protected_Virtual_Void_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_Int32_Int32_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
