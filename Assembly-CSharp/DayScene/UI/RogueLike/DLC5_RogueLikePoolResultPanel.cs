using System;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000117 RID: 279
	public class DLC5_RogueLikePoolResultPanel : UIPanelParamOpen<DLC5_RogueLikePoolResultPanel.PoolResultType>
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x0010520C File Offset: 0x0010340C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikePoolResultPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikePoolResultPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr);
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_ObjectStackParent");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_RecipeViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_RecipeViewerGridContent");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_BevViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_BevViewerGridContent");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_Describer");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipeScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_GachaRecipeScroller");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_GachaBevScroller");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ResultRecipeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_ResultRecipeText");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ResultBevText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_ResultBevText");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_GachaRecipeGroup");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_GachaBevGroup");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_GachaRecipePool");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "m_GachaBevPool");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr__RecipeGachaResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "<RecipeGachaResult>k__BackingField");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr__BevGachaResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "<BevGachaResult>k__BackingField");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV");
			DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_describerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "describerCanvasGroup");
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_get_RecipeGachaResult_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668737);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_get_BevGachaResult_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668738);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668739);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_PoolResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668740);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668741);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668742);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668743);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_1_Private_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668744);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_2_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668745);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_5_Private_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668746);
			DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_6_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, 100668747);
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x001054A8 File Offset: 0x001036A8
		public unsafe List<int> RecipeGachaResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_get_RecipeGachaResult_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x001054E8 File Offset: 0x001036E8
		public unsafe List<int> BevGachaResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_get_BevGachaResult_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00105528 File Offset: 0x00103728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76041, XrefRangeEnd = 76132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00105564 File Offset: 0x00103764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76132, XrefRangeEnd = 76174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikePoolResultPanel.PoolResultType poolResultType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref poolResultType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_PoolResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x001055B0 File Offset: 0x001037B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76174, XrefRangeEnd = 76176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x001055EC File Offset: 0x001037EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76176, XrefRangeEnd = 76198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00105628 File Offset: 0x00103828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76198, XrefRangeEnd = 76224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePoolResultPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00105664 File Offset: 0x00103864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76224, XrefRangeEnd = 76239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__25_1(int productId, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref productId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_1_Private_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x001056C8 File Offset: 0x001038C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76239, XrefRangeEnd = 76245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__25_2(int column, MoveDirection overrideMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_2_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00105714 File Offset: 0x00103914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76245, XrefRangeEnd = 76260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__25_5(int productId, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref productId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_5_Private_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00105778 File Offset: 0x00103978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76260, XrefRangeEnd = 76266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__25_6(int column, MoveDirection overrideMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__25_6_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000129F1 File Offset: 0x00010BF1
		public DLC5_RogueLikePoolResultPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x001057C4 File Offset: 0x001039C4
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x000129FA File Offset: 0x00010BFA
		public unsafe GameObject m_ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x001057F4 File Offset: 0x001039F4
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00012A19 File Offset: 0x00010C19
		public unsafe GridLayoutGroup m_RecipeViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_RecipeViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_RecipeViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00105824 File Offset: 0x00103A24
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00012A38 File Offset: 0x00010C38
		public unsafe GridLayoutGroup m_BevViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_BevViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_BevViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00105854 File Offset: 0x00103A54
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00012A57 File Offset: 0x00010C57
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00105884 File Offset: 0x00103A84
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00012A76 File Offset: 0x00010C76
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x001058B4 File Offset: 0x00103AB4
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00012A95 File Offset: 0x00010C95
		public unsafe AdpProgressIndicatorComponent m_GachaRecipeScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipeScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipeScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x001058E4 File Offset: 0x00103AE4
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00012AB4 File Offset: 0x00010CB4
		public unsafe AdpProgressIndicatorComponent m_GachaBevScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00105914 File Offset: 0x00103B14
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00012AD3 File Offset: 0x00010CD3
		public unsafe TextMeshProUGUI m_ResultRecipeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ResultRecipeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ResultRecipeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00105944 File Offset: 0x00103B44
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00012AF2 File Offset: 0x00010CF2
		public unsafe TextMeshProUGUI m_ResultBevText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ResultBevText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_ResultBevText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00105974 File Offset: 0x00103B74
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x00012B11 File Offset: 0x00010D11
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_GachaRecipeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x001059A4 File Offset: 0x00103BA4
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x00012B30 File Offset: 0x00010D30
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_GachaBevGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x001059D4 File Offset: 0x00103BD4
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x00012B4F File Offset: 0x00010D4F
		public unsafe List<int> m_GachaRecipePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaRecipePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x00105A04 File Offset: 0x00103C04
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x00012B6E File Offset: 0x00010D6E
		public unsafe List<int> m_GachaBevPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_m_GachaBevPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00105A34 File Offset: 0x00103C34
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00012B8D File Offset: 0x00010D8D
		public unsafe List<int> _RecipeGachaResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr__RecipeGachaResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr__RecipeGachaResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00105A64 File Offset: 0x00103C64
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00012BAC File Offset: 0x00010DAC
		public unsafe List<int> _BevGachaResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr__BevGachaResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr__BevGachaResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00105A94 File Offset: 0x00103C94
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00012BCB File Offset: 0x00010DCB
		public unsafe static string DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00105AB4 File Offset: 0x00103CB4
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00012BDD File Offset: 0x00010DDD
		public unsafe static string DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00105AD4 File Offset: 0x00103CD4
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00012BEF File Offset: 0x00010DEF
		public unsafe static string DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00105AF4 File Offset: 0x00103CF4
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00012C01 File Offset: 0x00010E01
		public unsafe static string DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00105B14 File Offset: 0x00103D14
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00012C13 File Offset: 0x00010E13
		public unsafe CanvasGroup describerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_describerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.NativeFieldInfoPtr_describerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectStackParent;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeViewerGridContent;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_m_BevViewerGridContent;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaRecipeScroller;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaBevScroller;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeFieldInfoPtr_m_ResultRecipeText;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_m_ResultBevText;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaRecipeGroup;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaBevGroup;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaRecipePool;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaBevPool;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeFieldInfoPtr__RecipeGachaResult_k__BackingField;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeFieldInfoPtr__BevGachaResult_k__BackingField;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_describerCanvasGroup;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeGachaResult_Public_get_List_1_Int32_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_get_BevGachaResult_Public_get_List_1_Int32_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_PoolResultType_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_1_Private_Void_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_2_Private_Void_Int32_MoveDirection_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_5_Private_Void_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_6_Private_Void_Int32_MoveDirection_0;

		// Token: 0x020006F4 RID: 1780
		public enum PoolResultType
		{
			// Token: 0x040064ED RID: 25837
			Add,
			// Token: 0x040064EE RID: 25838
			Sold
		}

		// Token: 0x020006F5 RID: 1781
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolResultPanel+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x06009B43 RID: 39747 RVA: 0x00294098 File Offset: 0x00292298
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr);
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr, "productId");
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr, 100668748);
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr, 100668749);
			}

			// Token: 0x06009B44 RID: 39748 RVA: 0x00294114 File Offset: 0x00292314
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B45 RID: 39749 RVA: 0x00294150 File Offset: 0x00292350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76022, XrefRangeEnd = 76025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B46 RID: 39750 RVA: 0x0005405C File Offset: 0x0005225C
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003385 RID: 13189
			// (get) Token: 0x06009B47 RID: 39751 RVA: 0x00294184 File Offset: 0x00292384
			// (set) Token: 0x06009B48 RID: 39752 RVA: 0x00054065 File Offset: 0x00052265
			public unsafe int productId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_productId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeFieldInfoPtr_productId)) = value;
				}
			}

			// Token: 0x17003386 RID: 13190
			// (get) Token: 0x06009B49 RID: 39753 RVA: 0x002941AC File Offset: 0x002923AC
			// (set) Token: 0x06009B4A RID: 39754 RVA: 0x00054080 File Offset: 0x00052280
			public unsafe DLC5_RogueLikePoolResultPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064EF RID: 25839
			private static readonly IntPtr NativeFieldInfoPtr_productId;

			// Token: 0x040064F0 RID: 25840
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040064F1 RID: 25841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064F2 RID: 25842
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0;
		}

		// Token: 0x020006F6 RID: 1782
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolResultPanel+<>c__DisplayClass25_1")]
		public sealed class __c__DisplayClass25_1 : Il2CppSystem.Object
		{
			// Token: 0x06009B4B RID: 39755 RVA: 0x002941DC File Offset: 0x002923DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "<>c__DisplayClass25_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr);
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr, "productId");
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr, 100668750);
				DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr, 100668751);
			}

			// Token: 0x06009B4C RID: 39756 RVA: 0x00294258 File Offset: 0x00292458
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B4D RID: 39757 RVA: 0x00294294 File Offset: 0x00292494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76025, XrefRangeEnd = 76028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B4E RID: 39758 RVA: 0x0005409F File Offset: 0x0005229F
			public __c__DisplayClass25_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003387 RID: 13191
			// (get) Token: 0x06009B4F RID: 39759 RVA: 0x002942C8 File Offset: 0x002924C8
			// (set) Token: 0x06009B50 RID: 39760 RVA: 0x000540A8 File Offset: 0x000522A8
			public unsafe int productId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_productId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeFieldInfoPtr_productId)) = value;
				}
			}

			// Token: 0x17003388 RID: 13192
			// (get) Token: 0x06009B51 RID: 39761 RVA: 0x002942F0 File Offset: 0x002924F0
			// (set) Token: 0x06009B52 RID: 39762 RVA: 0x000540C3 File Offset: 0x000522C3
			public unsafe DLC5_RogueLikePoolResultPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolResultPanel.__c__DisplayClass25_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064F3 RID: 25843
			private static readonly IntPtr NativeFieldInfoPtr_productId;

			// Token: 0x040064F4 RID: 25844
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040064F5 RID: 25845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064F6 RID: 25846
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_0;
		}

		// Token: 0x020006F7 RID: 1783
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolResultPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009B53 RID: 39763 RVA: 0x00294320 File Offset: 0x00292520
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr);
				DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr, "<>9__25_0");
				DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9__25_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr, "<>9__25_4");
				DLC5_RogueLikePoolResultPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr, 100668753);
				DLC5_RogueLikePoolResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_0_Internal_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr, 100668754);
				DLC5_RogueLikePoolResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_4_Internal_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr, 100668755);
			}

			// Token: 0x06009B54 RID: 39764 RVA: 0x002943C4 File Offset: 0x002925C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolResultPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B55 RID: 39765 RVA: 0x00294400 File Offset: 0x00292600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76028, XrefRangeEnd = 76035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__25_0(int productId, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref productId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_0_Internal_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B56 RID: 39766 RVA: 0x00294464 File Offset: 0x00292664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76035, XrefRangeEnd = 76041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__25_4(int productId, UIElementCluster cluster, UIButtonSimple button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref productId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolResultPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_4_Internal_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B57 RID: 39767 RVA: 0x000540E2 File Offset: 0x000522E2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003389 RID: 13193
			// (get) Token: 0x06009B58 RID: 39768 RVA: 0x002944C8 File Offset: 0x002926C8
			// (set) Token: 0x06009B59 RID: 39769 RVA: 0x000540EB File Offset: 0x000522EB
			public unsafe static DLC5_RogueLikePoolResultPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700338A RID: 13194
			// (get) Token: 0x06009B5A RID: 39770 RVA: 0x002944F0 File Offset: 0x002926F0
			// (set) Token: 0x06009B5B RID: 39771 RVA: 0x000540FD File Offset: 0x000522FD
			public unsafe static Action<int, UIElementCluster, UIButtonSimple> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700338B RID: 13195
			// (get) Token: 0x06009B5C RID: 39772 RVA: 0x00294518 File Offset: 0x00292718
			// (set) Token: 0x06009B5D RID: 39773 RVA: 0x0005410F File Offset: 0x0005230F
			public unsafe static Action<int, UIElementCluster, UIButtonSimple> __9__25_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9__25_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolResultPanel.__c.NativeFieldInfoPtr___9__25_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064F7 RID: 25847
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040064F8 RID: 25848
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x040064F9 RID: 25849
			private static readonly IntPtr NativeFieldInfoPtr___9__25_4;

			// Token: 0x040064FA RID: 25850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064FB RID: 25851
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_0_Internal_Void_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040064FC RID: 25852
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_4_Internal_Void_Int32_UIElementCluster_UIButtonSimple_0;
		}
	}
}
