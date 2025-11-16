using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.UGUIExtensions;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000382 RID: 898
	public class MultipleGetProductsPanel : UIPanelParamOpen<MultipleGetProductsPanel.MultipleGetProductsOpenContext>
	{
		// Token: 0x06006A83 RID: 27267 RVA: 0x00201D3C File Offset: 0x001FFF3C
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleGetProductsPanel()
		{
			Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "MultipleGetProductsPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr);
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_LeftLabelGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_LeftLabelGridContent");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_Element");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_TitleText");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_RightViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_RightViewerGridContent");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_GetProductScroller");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_Describer");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_ObjectStackParent");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_DescriberCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_DescriberCanvasGroup");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_Normal");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_Selected");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_UILogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_UILogicalGroup");
			MultipleGetProductsPanel.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "currentIndex");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_ProductDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_ProductDictionary");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_ProductSourceLabelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_ProductSourceLabelList");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_AllRecordedProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_AllRecordedProductsList");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_GetProductsList");
			MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "m_GetProductsGroup");
			MultipleGetProductsPanel.NativeFieldInfoPtr_MAX_SHOW_TAB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "MAX_SHOW_TAB");
			MultipleGetProductsPanel.NativeFieldInfoPtr_ALL_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "ALL_TAG");
			MultipleGetProductsPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685340);
			MultipleGetProductsPanel.NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685341);
			MultipleGetProductsPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_MultipleGetProductsOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685342);
			MultipleGetProductsPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685343);
			MultipleGetProductsPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685344);
			MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_0_Private_Void_String_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685345);
			MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_1_Private_Void_String_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685346);
			MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_6_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685347);
			MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_3_Private_Void_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, 100685348);
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x00201FB0 File Offset: 0x002001B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270845, XrefRangeEnd = 270919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleGetProductsPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x00201FEC File Offset: 0x002001EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270919, XrefRangeEnd = 270929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitchMove(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x00202034 File Offset: 0x00200234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270929, XrefRangeEnd = 271026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(MultipleGetProductsPanel.MultipleGetProductsOpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleGetProductsPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_MultipleGetProductsOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x00202088 File Offset: 0x00200288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271048, RefRangeEnd = 271051, XrefRangeStart = 271026, XrefRangeEnd = 271048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x002020CC File Offset: 0x002002CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271051, XrefRangeEnd = 271081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleGetProductsPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x00202108 File Offset: 0x00200308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271081, XrefRangeEnd = 271107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__21_0(string title, UIButtonSimple uiButtonToggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonToggle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_0_Private_Void_String_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0020215C File Offset: 0x0020035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271107, XrefRangeEnd = 271118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__21_1(string title, UIButtonSimple uiButtonToggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonToggle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_1_Private_Void_String_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x002021B0 File Offset: 0x002003B0
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__21_6(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_6_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x002021F4 File Offset: 0x002003F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271118, XrefRangeEnd = 271160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__21_3(Product product, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.NativeMethodInfoPtr__OnPanelInitialize_b__21_3_Private_Void_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x000399E7 File Offset: 0x00037BE7
		public MultipleGetProductsPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x00202260 File Offset: 0x00200460
		// (set) Token: 0x06006A8F RID: 27279 RVA: 0x000399F0 File Offset: 0x00037BF0
		public unsafe AdpVerticalLayoutGroup m_LeftLabelGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_LeftLabelGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpVerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_LeftLabelGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x00202290 File Offset: 0x00200490
		// (set) Token: 0x06006A91 RID: 27281 RVA: 0x00039A0F File Offset: 0x00037C0F
		public unsafe GameObject m_Element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x002022C0 File Offset: 0x002004C0
		// (set) Token: 0x06006A93 RID: 27283 RVA: 0x00039A2E File Offset: 0x00037C2E
		public unsafe TextMeshProUGUI m_TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x002022F0 File Offset: 0x002004F0
		// (set) Token: 0x06006A95 RID: 27285 RVA: 0x00039A4D File Offset: 0x00037C4D
		public unsafe GridLayoutGroup m_RightViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_RightViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_RightViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x06006A96 RID: 27286 RVA: 0x00202320 File Offset: 0x00200520
		// (set) Token: 0x06006A97 RID: 27287 RVA: 0x00039A6C File Offset: 0x00037C6C
		public unsafe AdpProgressIndicatorComponent m_GetProductScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x00202350 File Offset: 0x00200550
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x00039A8B File Offset: 0x00037C8B
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x00202380 File Offset: 0x00200580
		// (set) Token: 0x06006A9B RID: 27291 RVA: 0x00039AAA File Offset: 0x00037CAA
		public unsafe GameObject m_ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x002023B0 File Offset: 0x002005B0
		// (set) Token: 0x06006A9D RID: 27293 RVA: 0x00039AC9 File Offset: 0x00037CC9
		public unsafe CanvasGroup m_DescriberCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_DescriberCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_DescriberCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x06006A9E RID: 27294 RVA: 0x002023E0 File Offset: 0x002005E0
		// (set) Token: 0x06006A9F RID: 27295 RVA: 0x00039AE8 File Offset: 0x00037CE8
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x06006AA0 RID: 27296 RVA: 0x00202410 File Offset: 0x00200610
		// (set) Token: 0x06006AA1 RID: 27297 RVA: 0x00039B07 File Offset: 0x00037D07
		public unsafe Color m_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Normal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Normal)) = value;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x00202438 File Offset: 0x00200638
		// (set) Token: 0x06006AA3 RID: 27299 RVA: 0x00039B22 File Offset: 0x00037D22
		public unsafe Color m_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_Selected)) = value;
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x00202460 File Offset: 0x00200660
		// (set) Token: 0x06006AA5 RID: 27301 RVA: 0x00039B3D File Offset: 0x00037D3D
		public unsafe AdpVirtualScrollListComponent<string, UIButtonSimple> m_UILogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_UILogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpVirtualScrollListComponent<string, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_UILogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x00202490 File Offset: 0x00200690
		// (set) Token: 0x06006AA7 RID: 27303 RVA: 0x00039B5C File Offset: 0x00037D5C
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x06006AA8 RID: 27304 RVA: 0x002024B8 File Offset: 0x002006B8
		// (set) Token: 0x06006AA9 RID: 27305 RVA: 0x00039B77 File Offset: 0x00037D77
		public unsafe Dictionary<string, List<Product>> m_ProductDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ProductDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Product>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ProductDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x002024E8 File Offset: 0x002006E8
		// (set) Token: 0x06006AAB RID: 27307 RVA: 0x00039B96 File Offset: 0x00037D96
		public unsafe List<string> m_ProductSourceLabelList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ProductSourceLabelList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_ProductSourceLabelList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x00202518 File Offset: 0x00200718
		// (set) Token: 0x06006AAD RID: 27309 RVA: 0x00039BB5 File Offset: 0x00037DB5
		public unsafe List<Product> m_AllRecordedProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_AllRecordedProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_AllRecordedProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x00202548 File Offset: 0x00200748
		// (set) Token: 0x06006AAF RID: 27311 RVA: 0x00039BD4 File Offset: 0x00037DD4
		public unsafe List<Product> m_GetProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x00202578 File Offset: 0x00200778
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x00039BF3 File Offset: 0x00037DF3
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple> m_GetProductsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.NativeFieldInfoPtr_m_GetProductsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x002025A8 File Offset: 0x002007A8
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x00039C12 File Offset: 0x00037E12
		public unsafe static int MAX_SHOW_TAB
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MultipleGetProductsPanel.NativeFieldInfoPtr_MAX_SHOW_TAB, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultipleGetProductsPanel.NativeFieldInfoPtr_MAX_SHOW_TAB, (void*)(&value));
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x002025C4 File Offset: 0x002007C4
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x00039C20 File Offset: 0x00037E20
		public unsafe static string ALL_TAG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultipleGetProductsPanel.NativeFieldInfoPtr_ALL_TAG, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultipleGetProductsPanel.NativeFieldInfoPtr_ALL_TAG, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400469D RID: 18077
		private static readonly IntPtr NativeFieldInfoPtr_m_LeftLabelGridContent;

		// Token: 0x0400469E RID: 18078
		private static readonly IntPtr NativeFieldInfoPtr_m_Element;

		// Token: 0x0400469F RID: 18079
		private static readonly IntPtr NativeFieldInfoPtr_m_TitleText;

		// Token: 0x040046A0 RID: 18080
		private static readonly IntPtr NativeFieldInfoPtr_m_RightViewerGridContent;

		// Token: 0x040046A1 RID: 18081
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProductScroller;

		// Token: 0x040046A2 RID: 18082
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x040046A3 RID: 18083
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectStackParent;

		// Token: 0x040046A4 RID: 18084
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberCanvasGroup;

		// Token: 0x040046A5 RID: 18085
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x040046A6 RID: 18086
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040046A7 RID: 18087
		private static readonly IntPtr NativeFieldInfoPtr_m_Selected;

		// Token: 0x040046A8 RID: 18088
		private static readonly IntPtr NativeFieldInfoPtr_m_UILogicalGroup;

		// Token: 0x040046A9 RID: 18089
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x040046AA RID: 18090
		private static readonly IntPtr NativeFieldInfoPtr_m_ProductDictionary;

		// Token: 0x040046AB RID: 18091
		private static readonly IntPtr NativeFieldInfoPtr_m_ProductSourceLabelList;

		// Token: 0x040046AC RID: 18092
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRecordedProductsList;

		// Token: 0x040046AD RID: 18093
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProductsList;

		// Token: 0x040046AE RID: 18094
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProductsGroup;

		// Token: 0x040046AF RID: 18095
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SHOW_TAB;

		// Token: 0x040046B0 RID: 18096
		private static readonly IntPtr NativeFieldInfoPtr_ALL_TAG;

		// Token: 0x040046B1 RID: 18097
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040046B2 RID: 18098
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0;

		// Token: 0x040046B3 RID: 18099
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_MultipleGetProductsOpenContext_0;

		// Token: 0x040046B4 RID: 18100
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_String_0;

		// Token: 0x040046B5 RID: 18101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046B6 RID: 18102
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_0_Private_Void_String_UIButtonSimple_0;

		// Token: 0x040046B7 RID: 18103
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_1_Private_Void_String_UIButtonSimple_0;

		// Token: 0x040046B8 RID: 18104
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_6_Private_Void_TextMeshProUGUI_0;

		// Token: 0x040046B9 RID: 18105
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_3_Private_Void_Product_UIElementCluster_UIButtonSimple_0;

		// Token: 0x02000E97 RID: 3735
		public sealed class MultipleGetProductsOpenContext : ValueType
		{
			// Token: 0x060108BA RID: 67770 RVA: 0x003D5C74 File Offset: 0x003D3E74
			// Note: this type is marked as 'beforefieldinit'.
			static MultipleGetProductsOpenContext()
			{
				Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "MultipleGetProductsOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr);
				MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr, "Title");
				MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeFieldInfoPtr_GetProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr, "GetProducts");
				MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr, 100685349);
			}

			// Token: 0x060108BB RID: 67771 RVA: 0x003D5CDC File Offset: 0x003D3EDC
			[CallerCount(272)]
			[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MultipleGetProductsOpenContext(string title, Dictionary<string, List<Product>> getProducts) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getProducts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_List_1_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108BC RID: 67772 RVA: 0x0009075F File Offset: 0x0008E95F
			public MultipleGetProductsOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060108BD RID: 67773 RVA: 0x00090768 File Offset: 0x0008E968
			public MultipleGetProductsOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel.MultipleGetProductsOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700565D RID: 22109
			// (get) Token: 0x060108BE RID: 67774 RVA: 0x003D5D40 File Offset: 0x003D3F40
			// (set) Token: 0x060108BF RID: 67775 RVA: 0x0009077A File Offset: 0x0008E97A
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700565E RID: 22110
			// (get) Token: 0x060108C0 RID: 67776 RVA: 0x003D5D68 File Offset: 0x003D3F68
			// (set) Token: 0x060108C1 RID: 67777 RVA: 0x00090799 File Offset: 0x0008E999
			public unsafe Dictionary<string, List<Product>> GetProducts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeFieldInfoPtr_GetProducts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Product>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.MultipleGetProductsOpenContext.NativeFieldInfoPtr_GetProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A775 RID: 42869
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x0400A776 RID: 42870
			private static readonly IntPtr NativeFieldInfoPtr_GetProducts;

			// Token: 0x0400A777 RID: 42871
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_List_1_Product_0;
		}

		// Token: 0x02000E98 RID: 3736
		[ObfuscatedName("Common.UI.MultipleGetProductsPanel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x060108C2 RID: 67778 RVA: 0x003D5D98 File Offset: 0x003D3F98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr);
				MultipleGetProductsPanel.__c__DisplayClass21_0.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr, "title");
				MultipleGetProductsPanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				MultipleGetProductsPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr, 100685350);
				MultipleGetProductsPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr, 100685351);
				MultipleGetProductsPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr, 100685352);
			}

			// Token: 0x060108C3 RID: 67779 RVA: 0x003D5E28 File Offset: 0x003D4028
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108C4 RID: 67780 RVA: 0x003D5E64 File Offset: 0x003D4064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270801, XrefRangeEnd = 270808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108C5 RID: 67781 RVA: 0x003D5EA8 File Offset: 0x003D40A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270808, XrefRangeEnd = 270810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108C6 RID: 67782 RVA: 0x000907B8 File Offset: 0x0008E9B8
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700565F RID: 22111
			// (get) Token: 0x060108C7 RID: 67783 RVA: 0x003D5EDC File Offset: 0x003D40DC
			// (set) Token: 0x060108C8 RID: 67784 RVA: 0x000907C1 File Offset: 0x0008E9C1
			public unsafe string title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeFieldInfoPtr_title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005660 RID: 22112
			// (get) Token: 0x060108C9 RID: 67785 RVA: 0x003D5F04 File Offset: 0x003D4104
			// (set) Token: 0x060108CA RID: 67786 RVA: 0x000907E0 File Offset: 0x0008E9E0
			public unsafe MultipleGetProductsPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleGetProductsPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A778 RID: 42872
			private static readonly IntPtr NativeFieldInfoPtr_title;

			// Token: 0x0400A779 RID: 42873
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A77A RID: 42874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A77B RID: 42875
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A77C RID: 42876
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_0;
		}

		// Token: 0x02000E99 RID: 3737
		[ObfuscatedName("Common.UI.MultipleGetProductsPanel+<>c__DisplayClass21_1")]
		public sealed class __c__DisplayClass21_1 : Il2CppSystem.Object
		{
			// Token: 0x060108CB RID: 67787 RVA: 0x003D5F34 File Offset: 0x003D4134
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_1()
			{
				Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "<>c__DisplayClass21_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr);
				MultipleGetProductsPanel.__c__DisplayClass21_1.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr, "amount");
				MultipleGetProductsPanel.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr, 100685353);
				MultipleGetProductsPanel.__c__DisplayClass21_1.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr, 100685354);
				MultipleGetProductsPanel.__c__DisplayClass21_1.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr, 100685355);
			}

			// Token: 0x060108CC RID: 67788 RVA: 0x003D5FB0 File Offset: 0x003D41B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108CD RID: 67789 RVA: 0x003D5FEC File Offset: 0x003D41EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_1.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108CE RID: 67790 RVA: 0x003D6030 File Offset: 0x003D4230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_1.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108CF RID: 67791 RVA: 0x000907FF File Offset: 0x0008E9FF
			public __c__DisplayClass21_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005661 RID: 22113
			// (get) Token: 0x060108D0 RID: 67792 RVA: 0x003D6074 File Offset: 0x003D4274
			// (set) Token: 0x060108D1 RID: 67793 RVA: 0x00090808 File Offset: 0x0008EA08
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_1.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_1.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x0400A77D RID: 42877
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400A77E RID: 42878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A77F RID: 42879
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A780 RID: 42880
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E9A RID: 3738
		[ObfuscatedName("Common.UI.MultipleGetProductsPanel+<>c__DisplayClass21_2")]
		public sealed class __c__DisplayClass21_2 : Il2CppSystem.Object
		{
			// Token: 0x060108D2 RID: 67794 RVA: 0x003D609C File Offset: 0x003D429C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_2()
			{
				Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "<>c__DisplayClass21_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr);
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, "product");
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, "<>4__this");
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, 100685356);
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, 100685357);
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, 100685358);
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, 100685359);
				MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr, 100685360);
			}

			// Token: 0x060108D3 RID: 67795 RVA: 0x003D6154 File Offset: 0x003D4354
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel.__c__DisplayClass21_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108D4 RID: 67796 RVA: 0x003D6190 File Offset: 0x003D4390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270810, XrefRangeEnd = 270813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108D5 RID: 67797 RVA: 0x003D61C4 File Offset: 0x003D43C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270813, XrefRangeEnd = 270816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108D6 RID: 67798 RVA: 0x003D61F8 File Offset: 0x003D43F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270816, XrefRangeEnd = 270819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108D7 RID: 67799 RVA: 0x003D622C File Offset: 0x003D442C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270819, XrefRangeEnd = 270823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108D8 RID: 67800 RVA: 0x00090823 File Offset: 0x0008EA23
			public __c__DisplayClass21_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005662 RID: 22114
			// (get) Token: 0x060108D9 RID: 67801 RVA: 0x003D6260 File Offset: 0x003D4460
			// (set) Token: 0x060108DA RID: 67802 RVA: 0x0009082C File Offset: 0x0008EA2C
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005663 RID: 22115
			// (get) Token: 0x060108DB RID: 67803 RVA: 0x003D6290 File Offset: 0x003D4490
			// (set) Token: 0x060108DC RID: 67804 RVA: 0x0009085A File Offset: 0x0008EA5A
			public unsafe MultipleGetProductsPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleGetProductsPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleGetProductsPanel.__c__DisplayClass21_2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A781 RID: 42881
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400A782 RID: 42882
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A783 RID: 42883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A784 RID: 42884
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_0;

			// Token: 0x0400A785 RID: 42885
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_0;

			// Token: 0x0400A786 RID: 42886
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_0;

			// Token: 0x0400A787 RID: 42887
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_0;
		}

		// Token: 0x02000E9B RID: 3739
		[ObfuscatedName("Common.UI.MultipleGetProductsPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060108DD RID: 67805 RVA: 0x003D62C0 File Offset: 0x003D44C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleGetProductsPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr);
				MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr, "<>9");
				MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9__21_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr, "<>9__21_2");
				MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr, "<>9__23_0");
				MultipleGetProductsPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr, 100685362);
				MultipleGetProductsPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__21_2_Internal_Void_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr, 100685363);
				MultipleGetProductsPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__23_0_Internal_IEnumerable_1_Product_KeyValuePair_2_String_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr, 100685364);
			}

			// Token: 0x060108DE RID: 67806 RVA: 0x003D6364 File Offset: 0x003D4564
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleGetProductsPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108DF RID: 67807 RVA: 0x003D63A0 File Offset: 0x003D45A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270823, XrefRangeEnd = 270844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__21_2(Product product, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__21_2_Internal_Void_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108E0 RID: 67808 RVA: 0x003D640C File Offset: 0x003D460C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270844, XrefRangeEnd = 270845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Product> _OnPanelOpen_b__23_0(KeyValuePair<string, List<Product>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleGetProductsPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__23_0_Internal_IEnumerable_1_Product_KeyValuePair_2_String_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Product>>(intPtr3) : null;
			}

			// Token: 0x060108E1 RID: 67809 RVA: 0x00090879 File Offset: 0x0008EA79
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005664 RID: 22116
			// (get) Token: 0x060108E2 RID: 67810 RVA: 0x003D6464 File Offset: 0x003D4664
			// (set) Token: 0x060108E3 RID: 67811 RVA: 0x00090882 File Offset: 0x0008EA82
			public unsafe static MultipleGetProductsPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleGetProductsPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005665 RID: 22117
			// (get) Token: 0x060108E4 RID: 67812 RVA: 0x003D648C File Offset: 0x003D468C
			// (set) Token: 0x060108E5 RID: 67813 RVA: 0x00090894 File Offset: 0x0008EA94
			public unsafe static Action<Product, UIElementCluster, UIButtonSimple> __9__21_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9__21_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9__21_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005666 RID: 22118
			// (get) Token: 0x060108E6 RID: 67814 RVA: 0x003D64B4 File Offset: 0x003D46B4
			// (set) Token: 0x060108E7 RID: 67815 RVA: 0x000908A6 File Offset: 0x0008EAA6
			public unsafe static Func<KeyValuePair<string, List<Product>>, IEnumerable<Product>> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<Product>>, IEnumerable<Product>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleGetProductsPanel.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A788 RID: 42888
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A789 RID: 42889
			private static readonly IntPtr NativeFieldInfoPtr___9__21_2;

			// Token: 0x0400A78A RID: 42890
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x0400A78B RID: 42891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A78C RID: 42892
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_2_Internal_Void_Product_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400A78D RID: 42893
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__23_0_Internal_IEnumerable_1_Product_KeyValuePair_2_String_List_1_Product_0;
		}
	}
}
