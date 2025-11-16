using System;
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
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.DialogUtility.History
{
	// Token: 0x02000349 RID: 841
	public class DialogHistoryPanel : UIPanelParamOpen<IReadOnlyList<DialogHistory>>
	{
		// Token: 0x060063D6 RID: 25558 RVA: 0x001EC0EC File Offset: 0x001EA2EC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogHistoryPanel()
		{
			Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility.History", "DialogHistoryPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr);
			DialogHistoryPanel.NativeFieldInfoPtr_m_UIButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_UIButton");
			DialogHistoryPanel.NativeFieldInfoPtr_m_UpArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_UpArrow");
			DialogHistoryPanel.NativeFieldInfoPtr_m_DownArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_DownArrow");
			DialogHistoryPanel.NativeFieldInfoPtr_m_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_LayoutGroup");
			DialogHistoryPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_ProgressIndicatorComponent");
			DialogHistoryPanel.NativeFieldInfoPtr_m_TypeABackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_TypeABackgroundColor");
			DialogHistoryPanel.NativeFieldInfoPtr_m_TypeAForegroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_TypeAForegroundColor");
			DialogHistoryPanel.NativeFieldInfoPtr_m_TypeBBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_TypeBBackgroundColor");
			DialogHistoryPanel.NativeFieldInfoPtr_m_TypeBForegroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_TypeBForegroundColor");
			DialogHistoryPanel.NativeFieldInfoPtr_m_Histories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_Histories");
			DialogHistoryPanel.NativeFieldInfoPtr_m_CurrentMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_CurrentMoveDirection");
			DialogHistoryPanel.NativeFieldInfoPtr_m_LogicalGroupT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "m_LogicalGroupT");
			DialogHistoryPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684243);
			DialogHistoryPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684244);
			DialogHistoryPanel.NativeMethodInfoPtr_SnapToUI_Private_UILogicalUnit_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684245);
			DialogHistoryPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IReadOnlyList_1_DialogHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684246);
			DialogHistoryPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684247);
			DialogHistoryPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684248);
			DialogHistoryPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684249);
			DialogHistoryPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, 100684250);
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x001EC2AC File Offset: 0x001EA4AC
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogHistoryPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x001EC2F4 File Offset: 0x001EA4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257450, XrefRangeEnd = 257510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogHistoryPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x001EC330 File Offset: 0x001EA530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257527, RefRangeEnd = 257529, XrefRangeStart = 257510, XrefRangeEnd = 257527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UILogicalUnit SnapToUI(MoveDirection dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.NativeMethodInfoPtr_SnapToUI_Private_UILogicalUnit_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UILogicalUnit>(intPtr3) : null;
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x001EC37C File Offset: 0x001EA57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257529, XrefRangeEnd = 257546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(IReadOnlyList<DialogHistory> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogHistoryPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IReadOnlyList_1_DialogHistory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x001EC3CC File Offset: 0x001EA5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257546, XrefRangeEnd = 257551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogHistoryPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x001EC408 File Offset: 0x001EA608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257551, XrefRangeEnd = 257555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x001EC43C File Offset: 0x001EA63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257555, XrefRangeEnd = 257565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogHistoryPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x001EC478 File Offset: 0x001EA678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257565, XrefRangeEnd = 257576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogHistoryPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00035FDF File Offset: 0x000341DF
		public DialogHistoryPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x060063E0 RID: 25568 RVA: 0x001EC4B4 File Offset: 0x001EA6B4
		// (set) Token: 0x060063E1 RID: 25569 RVA: 0x00035FE8 File Offset: 0x000341E8
		public unsafe UIElementCluster m_UIButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_UIButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_UIButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x001EC4E4 File Offset: 0x001EA6E4
		// (set) Token: 0x060063E3 RID: 25571 RVA: 0x00036007 File Offset: 0x00034207
		public unsafe CanvasGroup m_UpArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_UpArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_UpArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x001EC514 File Offset: 0x001EA714
		// (set) Token: 0x060063E5 RID: 25573 RVA: 0x00036026 File Offset: 0x00034226
		public unsafe CanvasGroup m_DownArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_DownArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_DownArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x060063E6 RID: 25574 RVA: 0x001EC544 File Offset: 0x001EA744
		// (set) Token: 0x060063E7 RID: 25575 RVA: 0x00036045 File Offset: 0x00034245
		public unsafe GridLayoutGroup m_LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x001EC574 File Offset: 0x001EA774
		// (set) Token: 0x060063E9 RID: 25577 RVA: 0x00036064 File Offset: 0x00034264
		public unsafe AdpProgressIndicatorComponent m_ProgressIndicatorComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x001EC5A4 File Offset: 0x001EA7A4
		// (set) Token: 0x060063EB RID: 25579 RVA: 0x00036083 File Offset: 0x00034283
		public unsafe Color32 m_TypeABackgroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeABackgroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeABackgroundColor)) = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x001EC5CC File Offset: 0x001EA7CC
		// (set) Token: 0x060063ED RID: 25581 RVA: 0x0003609E File Offset: 0x0003429E
		public unsafe Color32 m_TypeAForegroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeAForegroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeAForegroundColor)) = value;
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x060063EE RID: 25582 RVA: 0x001EC5F4 File Offset: 0x001EA7F4
		// (set) Token: 0x060063EF RID: 25583 RVA: 0x000360B9 File Offset: 0x000342B9
		public unsafe Color32 m_TypeBBackgroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeBBackgroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeBBackgroundColor)) = value;
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x060063F0 RID: 25584 RVA: 0x001EC61C File Offset: 0x001EA81C
		// (set) Token: 0x060063F1 RID: 25585 RVA: 0x000360D4 File Offset: 0x000342D4
		public unsafe Color32 m_TypeBForegroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeBForegroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_TypeBForegroundColor)) = value;
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x001EC644 File Offset: 0x001EA844
		// (set) Token: 0x060063F3 RID: 25587 RVA: 0x000360EF File Offset: 0x000342EF
		public unsafe List<DialogHistory> m_Histories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_Histories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogHistory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_Histories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x060063F4 RID: 25588 RVA: 0x001EC674 File Offset: 0x001EA874
		// (set) Token: 0x060063F5 RID: 25589 RVA: 0x0003610E File Offset: 0x0003430E
		public Nullable<MoveDirection> m_CurrentMoveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_CurrentMoveDirection);
				return new Nullable<MoveDirection>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MoveDirection>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_CurrentMoveDirection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MoveDirection>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x001EC6A4 File Offset: 0x001EA8A4
		// (set) Token: 0x060063F7 RID: 25591 RVA: 0x0003613C File Offset: 0x0003433C
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DialogHistory, UIElementCluster, UIButtonSimple> m_LogicalGroupT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_LogicalGroupT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DialogHistory, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.NativeFieldInfoPtr_m_LogicalGroupT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004239 RID: 16953
		private static readonly IntPtr NativeFieldInfoPtr_m_UIButton;

		// Token: 0x0400423A RID: 16954
		private static readonly IntPtr NativeFieldInfoPtr_m_UpArrow;

		// Token: 0x0400423B RID: 16955
		private static readonly IntPtr NativeFieldInfoPtr_m_DownArrow;

		// Token: 0x0400423C RID: 16956
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutGroup;

		// Token: 0x0400423D RID: 16957
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressIndicatorComponent;

		// Token: 0x0400423E RID: 16958
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeABackgroundColor;

		// Token: 0x0400423F RID: 16959
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeAForegroundColor;

		// Token: 0x04004240 RID: 16960
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeBBackgroundColor;

		// Token: 0x04004241 RID: 16961
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeBForegroundColor;

		// Token: 0x04004242 RID: 16962
		private static readonly IntPtr NativeFieldInfoPtr_m_Histories;

		// Token: 0x04004243 RID: 16963
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMoveDirection;

		// Token: 0x04004244 RID: 16964
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroupT;

		// Token: 0x04004245 RID: 16965
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004246 RID: 16966
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004247 RID: 16967
		private static readonly IntPtr NativeMethodInfoPtr_SnapToUI_Private_UILogicalUnit_MoveDirection_0;

		// Token: 0x04004248 RID: 16968
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IReadOnlyList_1_DialogHistory_0;

		// Token: 0x04004249 RID: 16969
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400424A RID: 16970
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400424B RID: 16971
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400424C RID: 16972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E02 RID: 3586
		[ObfuscatedName("Common.DialogUtility.History.DialogHistoryPanel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x060102B8 RID: 66232 RVA: 0x003C5288 File Offset: 0x003C3488
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogHistoryPanel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr);
				DialogHistoryPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				DialogHistoryPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr, "axis");
				DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr, 100684251);
				DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr, 100684252);
				DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr, 100684253);
				DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_DialogHistory_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr, 100684254);
			}

			// Token: 0x060102B9 RID: 66233 RVA: 0x003C532C File Offset: 0x003C352C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogHistoryPanel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102BA RID: 66234 RVA: 0x003C5368 File Offset: 0x003C3568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257420, XrefRangeEnd = 257428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__0(InputAction.CallbackContext call)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(call));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102BB RID: 66235 RVA: 0x003C53B0 File Offset: 0x003C35B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257428, XrefRangeEnd = 257436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__1(InputAction.CallbackContext call)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(call));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102BC RID: 66236 RVA: 0x003C53F8 File Offset: 0x003C35F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257436, XrefRangeEnd = 257450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2(DialogHistory history, UIElementCluster ui, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(history));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistoryPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_DialogHistory_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102BD RID: 66237 RVA: 0x0008CBCD File Offset: 0x0008ADCD
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700548C RID: 21644
			// (get) Token: 0x060102BE RID: 66238 RVA: 0x003C5464 File Offset: 0x003C3664
			// (set) Token: 0x060102BF RID: 66239 RVA: 0x0008CBD6 File Offset: 0x0008ADD6
			public unsafe DialogHistoryPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogHistoryPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700548D RID: 21645
			// (get) Token: 0x060102C0 RID: 66240 RVA: 0x003C5494 File Offset: 0x003C3694
			// (set) Token: 0x060102C1 RID: 66241 RVA: 0x0008CBF5 File Offset: 0x0008ADF5
			public unsafe AxisEventData axis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_axis);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistoryPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_axis), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A41B RID: 42011
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A41C RID: 42012
			private static readonly IntPtr NativeFieldInfoPtr_axis;

			// Token: 0x0400A41D RID: 42013
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A41E RID: 42014
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_CallbackContext_0;

			// Token: 0x0400A41F RID: 42015
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_CallbackContext_0;

			// Token: 0x0400A420 RID: 42016
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_DialogHistory_UIElementCluster_UIButtonSimple_0;
		}
	}
}
