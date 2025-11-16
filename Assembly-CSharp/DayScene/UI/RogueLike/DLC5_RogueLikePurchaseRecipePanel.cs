using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200011E RID: 286
	public class DLC5_RogueLikePurchaseRecipePanel : DLC5_RogueLikePurchaseItemPanel
	{
		// Token: 0x060020D7 RID: 8407 RVA: 0x0010B708 File Offset: 0x00109908
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikePurchaseRecipePanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikePurchaseRecipePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr);
			DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_StackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, "m_StackObject");
			DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_StackRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, "m_StackRect");
			DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_FreeIngText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, "m_FreeIngText");
			DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_AllStackInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, "m_AllStackInstances");
			DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_RemainingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, "m_RemainingCount");
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669163);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_UpdateRecipeCartBG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669164);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterBuy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669165);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_UpdateCartTitle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669166);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterAddToCart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669167);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterRemoveFromCart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669168);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669169);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669170);
			DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, 100669171);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0010B850 File Offset: 0x00109A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80143, XrefRangeEnd = 80156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0010B88C File Offset: 0x00109A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80183, RefRangeEnd = 80185, XrefRangeStart = 80156, XrefRangeEnd = 80183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRecipeCartBG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_UpdateRecipeCartBG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0010B8C0 File Offset: 0x00109AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80185, XrefRangeEnd = 80201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterBuy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterBuy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0010B8FC File Offset: 0x00109AFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80227, XrefRangeStart = 80201, XrefRangeEnd = 80223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCartTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_UpdateCartTitle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0010B930 File Offset: 0x00109B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80227, XrefRangeEnd = 80228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterAddToCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterAddToCart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0010B96C File Offset: 0x00109B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterRemoveFromCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_AfterRemoveFromCart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0010B9A8 File Offset: 0x00109BA8
		[CallerCount(0)]
		public unsafe override int GetFinalFund(int currentFund)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentFund;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0010B9FC File Offset: 0x00109BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80228, XrefRangeEnd = 80235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0010BA38 File Offset: 0x00109C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80235, XrefRangeEnd = 80244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePurchaseRecipePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseRecipePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00013FA6 File Offset: 0x000121A6
		public DLC5_RogueLikePurchaseRecipePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0010BA74 File Offset: 0x00109C74
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x00013FAF File Offset: 0x000121AF
		public unsafe GameObject m_StackObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_StackObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_StackObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x0010BAA4 File Offset: 0x00109CA4
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x00013FCE File Offset: 0x000121CE
		public unsafe RectTransform m_StackRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_StackRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_StackRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0010BAD4 File Offset: 0x00109CD4
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00013FED File Offset: 0x000121ED
		public unsafe TextMeshProUGUI m_FreeIngText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_FreeIngText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_FreeIngText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0010BB04 File Offset: 0x00109D04
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0001400C File Offset: 0x0001220C
		public unsafe List<GameObject> m_AllStackInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_AllStackInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_AllStackInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0010BB34 File Offset: 0x00109D34
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x0001402B File Offset: 0x0001222B
		public unsafe int m_RemainingCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_RemainingCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseRecipePanel.NativeFieldInfoPtr_m_RemainingCount)) = value;
			}
		}

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeFieldInfoPtr_m_StackObject;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeFieldInfoPtr_m_StackRect;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeIngText;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeFieldInfoPtr_m_AllStackInstances;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingCount;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRecipeCartBG_Private_Void_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_AfterBuy_Protected_Virtual_Void_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCartTitle_Private_Void_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_AfterAddToCart_Protected_Virtual_Void_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_AfterRemoveFromCart_Protected_Virtual_Void_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_Int32_Int32_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000723 RID: 1827
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseRecipePanel+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009D37 RID: 40247 RVA: 0x0029B928 File Offset: 0x00299B28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr);
				DLC5_RogueLikePurchaseRecipePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikePurchaseRecipePanel.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr, "<>9__6_0");
				DLC5_RogueLikePurchaseRecipePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr, 100669173);
				DLC5_RogueLikePurchaseRecipePanel.__c.NativeMethodInfoPtr__UpdateRecipeCartBG_b__6_0_Internal_Void_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr, 100669174);
			}

			// Token: 0x06009D38 RID: 40248 RVA: 0x0029B9A4 File Offset: 0x00299BA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseRecipePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseRecipePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D39 RID: 40249 RVA: 0x0029B9E0 File Offset: 0x00299BE0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateRecipeCartBG_b__6_0(RectTransform a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseRecipePanel.__c.NativeMethodInfoPtr__UpdateRecipeCartBG_b__6_0_Internal_Void_RectTransform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D3A RID: 40250 RVA: 0x00054BB4 File Offset: 0x00052DB4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033FB RID: 13307
			// (get) Token: 0x06009D3B RID: 40251 RVA: 0x0029BA30 File Offset: 0x00299C30
			// (set) Token: 0x06009D3C RID: 40252 RVA: 0x00054BBD File Offset: 0x00052DBD
			public unsafe static DLC5_RogueLikePurchaseRecipePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseRecipePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseRecipePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseRecipePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033FC RID: 13308
			// (get) Token: 0x06009D3D RID: 40253 RVA: 0x0029BA58 File Offset: 0x00299C58
			// (set) Token: 0x06009D3E RID: 40254 RVA: 0x00054BCF File Offset: 0x00052DCF
			public unsafe static Action<RectTransform, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseRecipePanel.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RectTransform, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseRecipePanel.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006632 RID: 26162
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006633 RID: 26163
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04006634 RID: 26164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006635 RID: 26165
			private static readonly IntPtr NativeMethodInfoPtr__UpdateRecipeCartBG_b__6_0_Internal_Void_RectTransform_Int32_0;
		}
	}
}
