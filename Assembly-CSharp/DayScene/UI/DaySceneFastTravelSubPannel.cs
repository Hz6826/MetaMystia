using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x020000C2 RID: 194
	public class DaySceneFastTravelSubPannel : UIPanelParam<DaySceneFastTravelSubPannel.OpenContext, DaySceneFastTravelSubPannel.PannelCloseData>
	{
		// Token: 0x06001592 RID: 5522 RVA: 0x000E7034 File Offset: 0x000E5234
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneFastTravelSubPannel()
		{
			Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneFastTravelSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr);
			DaySceneFastTravelSubPannel.NativeFieldInfoPtr_ConfirmMoveBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, "ConfirmMoveBtn");
			DaySceneFastTravelSubPannel.NativeFieldInfoPtr_ConfirmTeleportBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, "ConfirmTeleportBtn");
			DaySceneFastTravelSubPannel.NativeFieldInfoPtr_YukariTeleportText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, "YukariTeleportText");
			DaySceneFastTravelSubPannel.NativeFieldInfoPtr_TravelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, "TravelText");
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667157);
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667158);
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667159);
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667160);
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667161);
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667162);
			DaySceneFastTravelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, 100667163);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000E7140 File Offset: 0x000E5340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60930, XrefRangeEnd = 60952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneFastTravelSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000E717C File Offset: 0x000E537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60952, XrefRangeEnd = 60992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DaySceneFastTravelSubPannel.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneFastTravelSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x000E71D0 File Offset: 0x000E53D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60992, XrefRangeEnd = 60997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneFastTravelSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x000E720C File Offset: 0x000E540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60997, XrefRangeEnd = 61000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneFastTravelSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneFastTravelSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000E7248 File Offset: 0x000E5448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61000, XrefRangeEnd = 61003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneFastTravelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000E7290 File Offset: 0x000E5490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61003, XrefRangeEnd = 61006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneFastTravelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000E72C4 File Offset: 0x000E54C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61006, XrefRangeEnd = 61009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneFastTravelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000D6D6 File Offset: 0x0000B8D6
		public DaySceneFastTravelSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000E72F8 File Offset: 0x000E54F8
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000D6DF File Offset: 0x0000B8DF
		public unsafe UIButtonSimple ConfirmMoveBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_ConfirmMoveBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_ConfirmMoveBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x000E7328 File Offset: 0x000E5528
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000D6FE File Offset: 0x0000B8FE
		public unsafe UIButtonSimple ConfirmTeleportBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_ConfirmTeleportBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_ConfirmTeleportBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x000E7358 File Offset: 0x000E5558
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0000D71D File Offset: 0x0000B91D
		public unsafe TextMeshProUGUI YukariTeleportText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_YukariTeleportText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_YukariTeleportText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000E7388 File Offset: 0x000E5588
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0000D73C File Offset: 0x0000B93C
		public unsafe TextMeshProUGUI TravelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_TravelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.NativeFieldInfoPtr_TravelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmMoveBtn;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmTeleportBtn;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_YukariTeleportText;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr_TravelText;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_CallbackContext_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_2_Private_Void_0;

		// Token: 0x0200062E RID: 1582
		public enum PannelCloseData
		{
			// Token: 0x04005EE1 RID: 24289
			ConfirmMove,
			// Token: 0x04005EE2 RID: 24290
			ConfirmTeleport,
			// Token: 0x04005EE3 RID: 24291
			None
		}

		// Token: 0x0200062F RID: 1583
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06009213 RID: 37395 RVA: 0x00279094 File Offset: 0x00277294
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneFastTravelSubPannel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr);
				DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_YukariTeleportCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr, "YukariTeleportCost");
				DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_TravelCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr, "TravelCost");
				DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_PrioritizeYukariButtonSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr, "PrioritizeYukariButtonSelection");
				DaySceneFastTravelSubPannel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr, 100667164);
			}

			// Token: 0x06009214 RID: 37396 RVA: 0x00279110 File Offset: 0x00277310
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 60929, RefRangeEnd = 60930, XrefRangeStart = 60929, XrefRangeEnd = 60929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Nullable<int> yukariTeleportCost, int travelCost, bool prioritizeYukariButtonSelection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(yukariTeleportCost));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref travelCost;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prioritizeYukariButtonSelection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneFastTravelSubPannel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009215 RID: 37397 RVA: 0x0004F1E0 File Offset: 0x0004D3E0
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009216 RID: 37398 RVA: 0x0004F1E9 File Offset: 0x0004D3E9
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170030B3 RID: 12467
			// (get) Token: 0x06009217 RID: 37399 RVA: 0x00279184 File Offset: 0x00277384
			// (set) Token: 0x06009218 RID: 37400 RVA: 0x0004F1FB File Offset: 0x0004D3FB
			public Nullable<int> YukariTeleportCost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_YukariTeleportCost);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_YukariTeleportCost), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170030B4 RID: 12468
			// (get) Token: 0x06009219 RID: 37401 RVA: 0x002791B4 File Offset: 0x002773B4
			// (set) Token: 0x0600921A RID: 37402 RVA: 0x0004F229 File Offset: 0x0004D429
			public unsafe int TravelCost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_TravelCost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_TravelCost)) = value;
				}
			}

			// Token: 0x170030B5 RID: 12469
			// (get) Token: 0x0600921B RID: 37403 RVA: 0x002791DC File Offset: 0x002773DC
			// (set) Token: 0x0600921C RID: 37404 RVA: 0x0004F244 File Offset: 0x0004D444
			public unsafe bool PrioritizeYukariButtonSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_PrioritizeYukariButtonSelection);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneFastTravelSubPannel.OpenContext.NativeFieldInfoPtr_PrioritizeYukariButtonSelection)) = value;
				}
			}

			// Token: 0x04005EE4 RID: 24292
			private static readonly IntPtr NativeFieldInfoPtr_YukariTeleportCost;

			// Token: 0x04005EE5 RID: 24293
			private static readonly IntPtr NativeFieldInfoPtr_TravelCost;

			// Token: 0x04005EE6 RID: 24294
			private static readonly IntPtr NativeFieldInfoPtr_PrioritizeYukariButtonSelection;

			// Token: 0x04005EE7 RID: 24295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_Int32_Boolean_0;
		}
	}
}
