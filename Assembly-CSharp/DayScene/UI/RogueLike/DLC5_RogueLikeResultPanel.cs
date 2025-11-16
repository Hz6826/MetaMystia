using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000120 RID: 288
	public class DLC5_RogueLikeResultPanel : UIPanelParamOpen<RogueLikeRunTimeData>
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x0010BDF8 File Offset: 0x00109FF8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeResultPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeResultPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr);
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngredientGridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_IngredientGridLayoutGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevGridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_BevGridLayoutGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodGridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_FoodGridLayoutGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeGridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_RecipeGridLayoutGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_PassedTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_PassedTip");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_Difficulty");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_Wave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_Wave");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_WholeTime");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCostInKourindou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_WholeCostInKourindou");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ServedGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_ServedGuestNum");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_EliteFinishNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_EliteFinishNum");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_WholeCollectFund");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_MaxEarnedFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_MaxEarnedFund");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectMikeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_WholeCollectMikeCard");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectPersistentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_WholeCollectPersistentCard");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectRateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_WholeCollectRateText");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ItemStackWithNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_ItemStackWithNum");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ItemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_ItemStack");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ContinueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_ContinueButton");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_CoreRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_CoreRect");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC1Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_DLC1Rect");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC2Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_DLC2Rect");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC3Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_DLC3Rect");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC4Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_DLC4Rect");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC5Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_DLC5Rect");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_PoolButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_PoolButton");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngProductsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_IngProductsGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevProductsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_BevProductsGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodProductsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_FoodProductsGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeProductsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_RecipeProductsGroup");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_IngProductsList");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_BevProductsList");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_FoodProductsList");
			DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "m_RecipeProductsList");
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669182);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669183);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_ConvertSecondsToTimeString_Private_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669184);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669185);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669186);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__34_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669187);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__34_9_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669188);
			DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_String_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, 100669189);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0010C170 File Offset: 0x0010A370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80382, XrefRangeEnd = 80587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0010C1AC File Offset: 0x0010A3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80587, XrefRangeEnd = 80847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(RogueLikeRunTimeData openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0010C1FC File Offset: 0x0010A3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80847, XrefRangeEnd = 80864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertSecondsToTimeString(float seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_ConvertSecondsToTimeString_Private_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x0010C240 File Offset: 0x0010A440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80864, XrefRangeEnd = 80906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0010C27C File Offset: 0x0010A47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80906, XrefRangeEnd = 80936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeResultPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0010C2B8 File Offset: 0x0010A4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80936, XrefRangeEnd = 80939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__34_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__34_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0010C2EC File Offset: 0x0010A4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80939, XrefRangeEnd = 80941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__34_9(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__34_9_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0010C334 File Offset: 0x0010A534
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 80976, RefRangeEnd = 80982, XrefRangeStart = 80941, XrefRangeEnd = 80976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_UIElementCluster_String_byref___c__DisplayClass35_0_0(UIElementCluster cluster, string key, ref DLC5_RogueLikeResultPanel.__c__DisplayClass35_0 A_2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_String_byref___c__DisplayClass35_0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x0001404F File Offset: 0x0001224F
		public DLC5_RogueLikeResultPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x0010C390 File Offset: 0x0010A590
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x00014058 File Offset: 0x00012258
		public unsafe GridLayoutGroup m_IngredientGridLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngredientGridLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngredientGridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x0010C3C0 File Offset: 0x0010A5C0
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x00014077 File Offset: 0x00012277
		public unsafe GridLayoutGroup m_BevGridLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevGridLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevGridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x0010C3F0 File Offset: 0x0010A5F0
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x00014096 File Offset: 0x00012296
		public unsafe GridLayoutGroup m_FoodGridLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodGridLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodGridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x0010C420 File Offset: 0x0010A620
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x000140B5 File Offset: 0x000122B5
		public unsafe GridLayoutGroup m_RecipeGridLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeGridLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeGridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x0010C450 File Offset: 0x0010A650
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x000140D4 File Offset: 0x000122D4
		public unsafe GameObject m_PassedTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_PassedTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_PassedTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x0010C480 File Offset: 0x0010A680
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x000140F3 File Offset: 0x000122F3
		public unsafe TextMeshProUGUI m_Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_Difficulty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_Difficulty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0010C4B0 File Offset: 0x0010A6B0
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x00014112 File Offset: 0x00012312
		public unsafe TextMeshProUGUI m_Wave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_Wave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_Wave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x0010C4E0 File Offset: 0x0010A6E0
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x00014131 File Offset: 0x00012331
		public unsafe TextMeshProUGUI m_WholeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0010C510 File Offset: 0x0010A710
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x00014150 File Offset: 0x00012350
		public unsafe TextMeshProUGUI m_WholeCostInKourindou
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCostInKourindou);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCostInKourindou), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x0010C540 File Offset: 0x0010A740
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x0001416F File Offset: 0x0001236F
		public unsafe TextMeshProUGUI m_ServedGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ServedGuestNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ServedGuestNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x0010C570 File Offset: 0x0010A770
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x0001418E File Offset: 0x0001238E
		public unsafe TextMeshProUGUI m_EliteFinishNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_EliteFinishNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_EliteFinishNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0010C5A0 File Offset: 0x0010A7A0
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x000141AD File Offset: 0x000123AD
		public unsafe TextMeshProUGUI m_WholeCollectFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0010C5D0 File Offset: 0x0010A7D0
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x000141CC File Offset: 0x000123CC
		public unsafe TextMeshProUGUI m_MaxEarnedFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_MaxEarnedFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_MaxEarnedFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0010C600 File Offset: 0x0010A800
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x000141EB File Offset: 0x000123EB
		public unsafe TextMeshProUGUI m_WholeCollectMikeCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectMikeCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectMikeCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x0010C630 File Offset: 0x0010A830
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x0001420A File Offset: 0x0001240A
		public unsafe TextMeshProUGUI m_WholeCollectPersistentCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectPersistentCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectPersistentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x0010C660 File Offset: 0x0010A860
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x00014229 File Offset: 0x00012429
		public unsafe TextMeshProUGUI m_WholeCollectRateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectRateText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_WholeCollectRateText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x0010C690 File Offset: 0x0010A890
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x00014248 File Offset: 0x00012448
		public unsafe GameObject m_ItemStackWithNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ItemStackWithNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ItemStackWithNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x0010C6C0 File Offset: 0x0010A8C0
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x00014267 File Offset: 0x00012467
		public unsafe GameObject m_ItemStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ItemStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ItemStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x0010C6F0 File Offset: 0x0010A8F0
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x00014286 File Offset: 0x00012486
		public unsafe UIButtonSimple m_ContinueButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ContinueButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_ContinueButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x0010C720 File Offset: 0x0010A920
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x000142A5 File Offset: 0x000124A5
		public unsafe UIElementCluster m_CoreRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_CoreRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_CoreRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x0010C750 File Offset: 0x0010A950
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x000142C4 File Offset: 0x000124C4
		public unsafe UIElementCluster m_DLC1Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC1Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC1Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x0010C780 File Offset: 0x0010A980
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x000142E3 File Offset: 0x000124E3
		public unsafe UIElementCluster m_DLC2Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC2Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC2Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0010C7B0 File Offset: 0x0010A9B0
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x00014302 File Offset: 0x00012502
		public unsafe UIElementCluster m_DLC3Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC3Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC3Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x0010C7E0 File Offset: 0x0010A9E0
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x00014321 File Offset: 0x00012521
		public unsafe UIElementCluster m_DLC4Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC4Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC4Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x0010C810 File Offset: 0x0010AA10
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x00014340 File Offset: 0x00012540
		public unsafe UIElementCluster m_DLC5Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC5Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_DLC5Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x0010C840 File Offset: 0x0010AA40
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0001435F File Offset: 0x0001255F
		public unsafe UIButtonSimple m_PoolButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_PoolButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_PoolButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0010C870 File Offset: 0x0010AA70
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0001437E File Offset: 0x0001257E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> m_IngProductsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngProductsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngProductsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0010C8A0 File Offset: 0x0010AAA0
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0001439D File Offset: 0x0001259D
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_BevProductsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevProductsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevProductsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0010C8D0 File Offset: 0x0010AAD0
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x000143BC File Offset: 0x000125BC
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_FoodProductsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodProductsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodProductsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x0010C900 File Offset: 0x0010AB00
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x000143DB File Offset: 0x000125DB
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_RecipeProductsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeProductsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeProductsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x0010C930 File Offset: 0x0010AB30
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x000143FA File Offset: 0x000125FA
		public unsafe List<KeyValuePair<Ingredient, int>> m_IngProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_IngProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0010C960 File Offset: 0x0010AB60
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x00014419 File Offset: 0x00012619
		public unsafe List<KeyValuePair<Sellable, int>> m_BevProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Sellable, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_BevProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0010C990 File Offset: 0x0010AB90
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x00014438 File Offset: 0x00012638
		public unsafe List<KeyValuePair<Sellable, int>> m_FoodProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Sellable, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_FoodProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x0010C9C0 File Offset: 0x0010ABC0
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x00014457 File Offset: 0x00012657
		public unsafe List<Recipe> m_RecipeProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.NativeFieldInfoPtr_m_RecipeProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientGridLayoutGroup;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeFieldInfoPtr_m_BevGridLayoutGroup;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodGridLayoutGroup;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeGridLayoutGroup;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeFieldInfoPtr_m_PassedTip;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr_m_Difficulty;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeFieldInfoPtr_m_Wave;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeTime;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCostInKourindou;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_m_ServedGuestNum;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteFinishNum;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectFund;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxEarnedFund;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectMikeCard;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectPersistentCard;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectRateText;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemStackWithNum;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemStack;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeFieldInfoPtr_m_ContinueButton;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeFieldInfoPtr_m_CoreRect;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC1Rect;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC2Rect;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC3Rect;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC4Rect;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5Rect;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeFieldInfoPtr_m_PoolButton;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeFieldInfoPtr_m_IngProductsGroup;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeFieldInfoPtr_m_BevProductsGroup;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodProductsGroup;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeProductsGroup;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeFieldInfoPtr_m_IngProductsList;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeFieldInfoPtr_m_BevProductsList;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodProductsList;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeProductsList;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_ConvertSecondsToTimeString_Private_String_Single_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_8_Private_Void_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_9_Private_Void_CallbackContext_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_String_byref___c__DisplayClass35_0_0;

		// Token: 0x02000724 RID: 1828
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeResultPanel+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x06009D3F RID: 40255 RVA: 0x0029BA80 File Offset: 0x00299C80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr, "amount");
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr, 100669190);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr, 100669191);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr, 100669192);
			}

			// Token: 0x06009D40 RID: 40256 RVA: 0x0029BAFC File Offset: 0x00299CFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D41 RID: 40257 RVA: 0x0029BB38 File Offset: 0x00299D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__10(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D42 RID: 40258 RVA: 0x0029BB7C File Offset: 0x00299D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__11(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D43 RID: 40259 RVA: 0x00054BE1 File Offset: 0x00052DE1
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033FD RID: 13309
			// (get) Token: 0x06009D44 RID: 40260 RVA: 0x0029BBC0 File Offset: 0x00299DC0
			// (set) Token: 0x06009D45 RID: 40261 RVA: 0x00054BEA File Offset: 0x00052DEA
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass34_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x04006636 RID: 26166
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04006637 RID: 26167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006638 RID: 26168
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006639 RID: 26169
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000725 RID: 1829
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeResultPanel+<>c__DisplayClass34_1")]
		public sealed class __c__DisplayClass34_1 : Il2CppSystem.Object
		{
			// Token: 0x06009D46 RID: 40262 RVA: 0x0029BBE8 File Offset: 0x00299DE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "<>c__DisplayClass34_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr, "amount");
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr, 100669193);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr, 100669194);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr, 100669195);
			}

			// Token: 0x06009D47 RID: 40263 RVA: 0x0029BC64 File Offset: 0x00299E64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D48 RID: 40264 RVA: 0x0029BCA0 File Offset: 0x00299EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__12(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D49 RID: 40265 RVA: 0x0029BCE4 File Offset: 0x00299EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D4A RID: 40266 RVA: 0x00054C05 File Offset: 0x00052E05
			public __c__DisplayClass34_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033FE RID: 13310
			// (get) Token: 0x06009D4B RID: 40267 RVA: 0x0029BD28 File Offset: 0x00299F28
			// (set) Token: 0x06009D4C RID: 40268 RVA: 0x00054C0E File Offset: 0x00052E0E
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass34_1.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x0400663A RID: 26170
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400663B RID: 26171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400663C RID: 26172
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400663D RID: 26173
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000726 RID: 1830
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeResultPanel+<>c__DisplayClass34_2")]
		public sealed class __c__DisplayClass34_2 : Il2CppSystem.Object
		{
			// Token: 0x06009D4D RID: 40269 RVA: 0x0029BD50 File Offset: 0x00299F50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "<>c__DisplayClass34_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr, "amount");
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr, 100669196);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr, 100669197);
				DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr, 100669198);
			}

			// Token: 0x06009D4E RID: 40270 RVA: 0x0029BDCC File Offset: 0x00299FCC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass34_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D4F RID: 40271 RVA: 0x0029BE08 File Offset: 0x0029A008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__14(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D50 RID: 40272 RVA: 0x0029BE4C File Offset: 0x0029A04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D51 RID: 40273 RVA: 0x00054C29 File Offset: 0x00052E29
			public __c__DisplayClass34_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033FF RID: 13311
			// (get) Token: 0x06009D52 RID: 40274 RVA: 0x0029BE90 File Offset: 0x0029A090
			// (set) Token: 0x06009D53 RID: 40275 RVA: 0x00054C32 File Offset: 0x00052E32
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass34_2.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x0400663E RID: 26174
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400663F RID: 26175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006640 RID: 26176
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006641 RID: 26177
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000727 RID: 1831
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeResultPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009D54 RID: 40276 RVA: 0x0029BEB8 File Offset: 0x0029A0B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr);
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_0");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_1");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_2");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_3");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_4");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_5");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_6");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__34_7");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_0");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_1");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_2");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_3");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_4");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_5");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_6");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_7");
				DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, "<>9__35_8");
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669200);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_0_Internal_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669201);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_1_Internal_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669202);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_2_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669203);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_3_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669204);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_4_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669205);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_5_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669206);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_6_Internal_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669207);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_7_Internal_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669208);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_0_Internal_String_KeyValuePair_2_String_DLCAreaCollectRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669209);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_1_Internal_Boolean_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669210);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_2_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669211);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_3_Internal_KeyValuePair_2_Ingredient_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669212);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_4_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669213);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_5_Internal_KeyValuePair_2_Sellable_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669214);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_6_Internal_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669215);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_7_Internal_KeyValuePair_2_Sellable_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669216);
				DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_8_Internal_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr, 100669217);
			}

			// Token: 0x06009D55 RID: 40277 RVA: 0x0029C1B4 File Offset: 0x0029A3B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D56 RID: 40278 RVA: 0x0029C1F0 File Offset: 0x0029A3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80266, XrefRangeEnd = 80290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_0(KeyValuePair<Ingredient, int> ing, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ing));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_0_Internal_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D57 RID: 40279 RVA: 0x0029C25C File Offset: 0x0029A45C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_1(KeyValuePair<Ingredient, int> ing, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ing));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_1_Internal_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D58 RID: 40280 RVA: 0x0029C2C8 File Offset: 0x0029A4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80290, XrefRangeEnd = 80314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_2(KeyValuePair<Sellable, int> bev, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bev));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_2_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D59 RID: 40281 RVA: 0x0029C334 File Offset: 0x0029A534
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_3(KeyValuePair<Sellable, int> ing, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ing));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_3_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D5A RID: 40282 RVA: 0x0029C3A0 File Offset: 0x0029A5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80314, XrefRangeEnd = 80338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_4(KeyValuePair<Sellable, int> food, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(food));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_4_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D5B RID: 40283 RVA: 0x0029C40C File Offset: 0x0029A60C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_5(KeyValuePair<Sellable, int> ing, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ing));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_5_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D5C RID: 40284 RVA: 0x0029C478 File Offset: 0x0029A678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80338, XrefRangeEnd = 80344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_6(Recipe recipe, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_6_Internal_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D5D RID: 40285 RVA: 0x0029C4E0 File Offset: 0x0029A6E0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__34_7(Recipe ing, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ing);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__34_7_Internal_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D5E RID: 40286 RVA: 0x0029C548 File Offset: 0x0029A748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80344, XrefRangeEnd = 80356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPanelOpen_b__35_0(KeyValuePair<string, RogueLikeRunTimeData.DLCAreaCollectRate> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_0_Internal_String_KeyValuePair_2_String_DLCAreaCollectRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009D5F RID: 40287 RVA: 0x0029C598 File Offset: 0x0029A798
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__35_1(RogueLikeRunTimeData.EliteChallengeCache x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_1_Internal_Boolean_EliteChallengeCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D60 RID: 40288 RVA: 0x0029C5E8 File Offset: 0x0029A7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80356, XrefRangeEnd = 80357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__35_2(KeyValuePair<RogueLikePersistentCardInstance, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_2_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D61 RID: 40289 RVA: 0x0029C63C File Offset: 0x0029A83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80357, XrefRangeEnd = 80363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Ingredient, int> _OnPanelOpen_b__35_3(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_3_Internal_KeyValuePair_2_Ingredient_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Ingredient, int>(pointer);
			}

			// Token: 0x06009D62 RID: 40290 RVA: 0x0029C68C File Offset: 0x0029A88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80363, XrefRangeEnd = 80364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__35_4(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_4_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D63 RID: 40291 RVA: 0x0029C6E0 File Offset: 0x0029A8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80364, XrefRangeEnd = 80370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Sellable, int> _OnPanelOpen_b__35_5(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_5_Internal_KeyValuePair_2_Sellable_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Sellable, int>(pointer);
			}

			// Token: 0x06009D64 RID: 40292 RVA: 0x0029C730 File Offset: 0x0029A930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80370, XrefRangeEnd = 80371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__35_6(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_6_Internal_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D65 RID: 40293 RVA: 0x0029C784 File Offset: 0x0029A984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80371, XrefRangeEnd = 80377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Sellable, int> _OnPanelOpen_b__35_7(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_7_Internal_KeyValuePair_2_Sellable_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Sellable, int>(pointer);
			}

			// Token: 0x06009D66 RID: 40294 RVA: 0x0029C7D4 File Offset: 0x0029A9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80377, XrefRangeEnd = 80378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__35_8(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__35_8_Internal_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D67 RID: 40295 RVA: 0x00054C4D File Offset: 0x00052E4D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003400 RID: 13312
			// (get) Token: 0x06009D68 RID: 40296 RVA: 0x0029C828 File Offset: 0x0029AA28
			// (set) Token: 0x06009D69 RID: 40297 RVA: 0x00054C56 File Offset: 0x00052E56
			public unsafe static DLC5_RogueLikeResultPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeResultPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003401 RID: 13313
			// (get) Token: 0x06009D6A RID: 40298 RVA: 0x0029C850 File Offset: 0x0029AA50
			// (set) Token: 0x06009D6B RID: 40299 RVA: 0x00054C68 File Offset: 0x00052E68
			public unsafe static Action<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003402 RID: 13314
			// (get) Token: 0x06009D6C RID: 40300 RVA: 0x0029C878 File Offset: 0x0029AA78
			// (set) Token: 0x06009D6D RID: 40301 RVA: 0x00054C7A File Offset: 0x00052E7A
			public unsafe static Action<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003403 RID: 13315
			// (get) Token: 0x06009D6E RID: 40302 RVA: 0x0029C8A0 File Offset: 0x0029AAA0
			// (set) Token: 0x06009D6F RID: 40303 RVA: 0x00054C8C File Offset: 0x00052E8C
			public unsafe static Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> __9__34_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003404 RID: 13316
			// (get) Token: 0x06009D70 RID: 40304 RVA: 0x0029C8C8 File Offset: 0x0029AAC8
			// (set) Token: 0x06009D71 RID: 40305 RVA: 0x00054C9E File Offset: 0x00052E9E
			public unsafe static Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> __9__34_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003405 RID: 13317
			// (get) Token: 0x06009D72 RID: 40306 RVA: 0x0029C8F0 File Offset: 0x0029AAF0
			// (set) Token: 0x06009D73 RID: 40307 RVA: 0x00054CB0 File Offset: 0x00052EB0
			public unsafe static Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> __9__34_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003406 RID: 13318
			// (get) Token: 0x06009D74 RID: 40308 RVA: 0x0029C918 File Offset: 0x0029AB18
			// (set) Token: 0x06009D75 RID: 40309 RVA: 0x00054CC2 File Offset: 0x00052EC2
			public unsafe static Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> __9__34_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003407 RID: 13319
			// (get) Token: 0x06009D76 RID: 40310 RVA: 0x0029C940 File Offset: 0x0029AB40
			// (set) Token: 0x06009D77 RID: 40311 RVA: 0x00054CD4 File Offset: 0x00052ED4
			public unsafe static Action<Recipe, UIElementCluster, UIButtonSimple> __9__34_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003408 RID: 13320
			// (get) Token: 0x06009D78 RID: 40312 RVA: 0x0029C968 File Offset: 0x0029AB68
			// (set) Token: 0x06009D79 RID: 40313 RVA: 0x00054CE6 File Offset: 0x00052EE6
			public unsafe static Action<Recipe, UIElementCluster, UIButtonSimple> __9__34_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__34_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003409 RID: 13321
			// (get) Token: 0x06009D7A RID: 40314 RVA: 0x0029C990 File Offset: 0x0029AB90
			// (set) Token: 0x06009D7B RID: 40315 RVA: 0x00054CF8 File Offset: 0x00052EF8
			public unsafe static Func<KeyValuePair<string, RogueLikeRunTimeData.DLCAreaCollectRate>, string> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, RogueLikeRunTimeData.DLCAreaCollectRate>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340A RID: 13322
			// (get) Token: 0x06009D7C RID: 40316 RVA: 0x0029C9B8 File Offset: 0x0029ABB8
			// (set) Token: 0x06009D7D RID: 40317 RVA: 0x00054D0A File Offset: 0x00052F0A
			public unsafe static Func<RogueLikeRunTimeData.EliteChallengeCache, bool> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeRunTimeData.EliteChallengeCache, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340B RID: 13323
			// (get) Token: 0x06009D7E RID: 40318 RVA: 0x0029C9E0 File Offset: 0x0029ABE0
			// (set) Token: 0x06009D7F RID: 40319 RVA: 0x00054D1C File Offset: 0x00052F1C
			public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int> __9__35_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340C RID: 13324
			// (get) Token: 0x06009D80 RID: 40320 RVA: 0x0029CA08 File Offset: 0x0029AC08
			// (set) Token: 0x06009D81 RID: 40321 RVA: 0x00054D2E File Offset: 0x00052F2E
			public unsafe static Func<KeyValuePair<int, int>, KeyValuePair<Ingredient, int>> __9__35_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, KeyValuePair<Ingredient, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340D RID: 13325
			// (get) Token: 0x06009D82 RID: 40322 RVA: 0x0029CA30 File Offset: 0x0029AC30
			// (set) Token: 0x06009D83 RID: 40323 RVA: 0x00054D40 File Offset: 0x00052F40
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__35_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340E RID: 13326
			// (get) Token: 0x06009D84 RID: 40324 RVA: 0x0029CA58 File Offset: 0x0029AC58
			// (set) Token: 0x06009D85 RID: 40325 RVA: 0x00054D52 File Offset: 0x00052F52
			public unsafe static Func<KeyValuePair<int, int>, KeyValuePair<Sellable, int>> __9__35_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, KeyValuePair<Sellable, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340F RID: 13327
			// (get) Token: 0x06009D86 RID: 40326 RVA: 0x0029CA80 File Offset: 0x0029AC80
			// (set) Token: 0x06009D87 RID: 40327 RVA: 0x00054D64 File Offset: 0x00052F64
			public unsafe static Func<KeyValuePair<Sellable, int>, int> __9__35_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003410 RID: 13328
			// (get) Token: 0x06009D88 RID: 40328 RVA: 0x0029CAA8 File Offset: 0x0029ACA8
			// (set) Token: 0x06009D89 RID: 40329 RVA: 0x00054D76 File Offset: 0x00052F76
			public unsafe static Func<KeyValuePair<int, int>, KeyValuePair<Sellable, int>> __9__35_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, KeyValuePair<Sellable, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003411 RID: 13329
			// (get) Token: 0x06009D8A RID: 40330 RVA: 0x0029CAD0 File Offset: 0x0029ACD0
			// (set) Token: 0x06009D8B RID: 40331 RVA: 0x00054D88 File Offset: 0x00052F88
			public unsafe static Func<KeyValuePair<Sellable, int>, int> __9__35_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeResultPanel.__c.NativeFieldInfoPtr___9__35_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006642 RID: 26178
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006643 RID: 26179
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04006644 RID: 26180
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x04006645 RID: 26181
			private static readonly IntPtr NativeFieldInfoPtr___9__34_2;

			// Token: 0x04006646 RID: 26182
			private static readonly IntPtr NativeFieldInfoPtr___9__34_3;

			// Token: 0x04006647 RID: 26183
			private static readonly IntPtr NativeFieldInfoPtr___9__34_4;

			// Token: 0x04006648 RID: 26184
			private static readonly IntPtr NativeFieldInfoPtr___9__34_5;

			// Token: 0x04006649 RID: 26185
			private static readonly IntPtr NativeFieldInfoPtr___9__34_6;

			// Token: 0x0400664A RID: 26186
			private static readonly IntPtr NativeFieldInfoPtr___9__34_7;

			// Token: 0x0400664B RID: 26187
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x0400664C RID: 26188
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x0400664D RID: 26189
			private static readonly IntPtr NativeFieldInfoPtr___9__35_2;

			// Token: 0x0400664E RID: 26190
			private static readonly IntPtr NativeFieldInfoPtr___9__35_3;

			// Token: 0x0400664F RID: 26191
			private static readonly IntPtr NativeFieldInfoPtr___9__35_4;

			// Token: 0x04006650 RID: 26192
			private static readonly IntPtr NativeFieldInfoPtr___9__35_5;

			// Token: 0x04006651 RID: 26193
			private static readonly IntPtr NativeFieldInfoPtr___9__35_6;

			// Token: 0x04006652 RID: 26194
			private static readonly IntPtr NativeFieldInfoPtr___9__35_7;

			// Token: 0x04006653 RID: 26195
			private static readonly IntPtr NativeFieldInfoPtr___9__35_8;

			// Token: 0x04006654 RID: 26196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006655 RID: 26197
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_0_Internal_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x04006656 RID: 26198
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_1_Internal_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x04006657 RID: 26199
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_2_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x04006658 RID: 26200
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_3_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x04006659 RID: 26201
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_4_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400665A RID: 26202
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_5_Internal_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400665B RID: 26203
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_6_Internal_Void_Recipe_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400665C RID: 26204
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_7_Internal_Void_Recipe_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400665D RID: 26205
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_0_Internal_String_KeyValuePair_2_String_DLCAreaCollectRate_0;

			// Token: 0x0400665E RID: 26206
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_1_Internal_Boolean_EliteChallengeCache_0;

			// Token: 0x0400665F RID: 26207
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_2_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

			// Token: 0x04006660 RID: 26208
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_3_Internal_KeyValuePair_2_Ingredient_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006661 RID: 26209
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_4_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04006662 RID: 26210
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_5_Internal_KeyValuePair_2_Sellable_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006663 RID: 26211
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_6_Internal_Int32_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04006664 RID: 26212
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_7_Internal_KeyValuePair_2_Sellable_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006665 RID: 26213
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__35_8_Internal_Int32_KeyValuePair_2_Sellable_Int32_0;
		}

		// Token: 0x02000728 RID: 1832
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeResultPanel+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : ValueType
		{
			// Token: 0x06009D8C RID: 40332 RVA: 0x0029CAF8 File Offset: 0x0029ACF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_0>.NativeClassPtr);
				DLC5_RogueLikeResultPanel.__c__DisplayClass35_0.NativeFieldInfoPtr_detailedDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_0>.NativeClassPtr, "detailedDic");
				DLC5_RogueLikeResultPanel.__c__DisplayClass35_0.NativeFieldInfoPtr_openParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_0>.NativeClassPtr, "openParam");
			}

			// Token: 0x06009D8D RID: 40333 RVA: 0x00054D9A File Offset: 0x00052F9A
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009D8E RID: 40334 RVA: 0x00054DA3 File Offset: 0x00052FA3
			public __c__DisplayClass35_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_0>.NativeClassPtr))
			{
			}

			// Token: 0x17003412 RID: 13330
			// (get) Token: 0x06009D8F RID: 40335 RVA: 0x0029CB4C File Offset: 0x0029AD4C
			// (set) Token: 0x06009D90 RID: 40336 RVA: 0x00054DB5 File Offset: 0x00052FB5
			public unsafe Dictionary<string, RogueLikeRunTimeData.DLCAreaCollectRate> detailedDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass35_0.NativeFieldInfoPtr_detailedDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, RogueLikeRunTimeData.DLCAreaCollectRate>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass35_0.NativeFieldInfoPtr_detailedDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003413 RID: 13331
			// (get) Token: 0x06009D91 RID: 40337 RVA: 0x0029CB7C File Offset: 0x0029AD7C
			// (set) Token: 0x06009D92 RID: 40338 RVA: 0x00054DD4 File Offset: 0x00052FD4
			public unsafe RogueLikeRunTimeData openParam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass35_0.NativeFieldInfoPtr_openParam);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass35_0.NativeFieldInfoPtr_openParam), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006666 RID: 26214
			private static readonly IntPtr NativeFieldInfoPtr_detailedDic;

			// Token: 0x04006667 RID: 26215
			private static readonly IntPtr NativeFieldInfoPtr_openParam;
		}

		// Token: 0x02000729 RID: 1833
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeResultPanel+<>c__DisplayClass35_1")]
		public sealed class __c__DisplayClass35_1 : Il2CppSystem.Object
		{
			// Token: 0x06009D93 RID: 40339 RVA: 0x0029CBAC File Offset: 0x0029ADAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel>.NativeClassPtr, "<>c__DisplayClass35_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_1>.NativeClassPtr);
				DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeFieldInfoPtr_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_1>.NativeClassPtr, "rate");
				DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_1>.NativeClassPtr, 100669218);
				DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_1>.NativeClassPtr, 100669219);
			}

			// Token: 0x06009D94 RID: 40340 RVA: 0x0029CC14 File Offset: 0x0029AE14
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeResultPanel.__c__DisplayClass35_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D95 RID: 40341 RVA: 0x0029CC50 File Offset: 0x0029AE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80378, XrefRangeEnd = 80382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__10(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D96 RID: 40342 RVA: 0x00054DF3 File Offset: 0x00052FF3
			public __c__DisplayClass35_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003414 RID: 13332
			// (get) Token: 0x06009D97 RID: 40343 RVA: 0x0029CC94 File Offset: 0x0029AE94
			// (set) Token: 0x06009D98 RID: 40344 RVA: 0x00054DFC File Offset: 0x00052FFC
			public RogueLikeRunTimeData.DLCAreaCollectRate rate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeFieldInfoPtr_rate);
					return new RogueLikeRunTimeData.DLCAreaCollectRate(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeRunTimeData.DLCAreaCollectRate>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeResultPanel.__c__DisplayClass35_1.NativeFieldInfoPtr_rate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeRunTimeData.DLCAreaCollectRate>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006668 RID: 26216
			private static readonly IntPtr NativeFieldInfoPtr_rate;

			// Token: 0x04006669 RID: 26217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400666A RID: 26218
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_CanvasGroup_0;
		}
	}
}
