using System;
using Common.UI;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001CE RID: 462
	public class WorkSceneThrowDeliverPanel : UISubPanel<BaseSustainedPannel>
	{
		// Token: 0x060039EE RID: 14830 RVA: 0x00164120 File Offset: 0x00162320
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneThrowDeliverPanel()
		{
			Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "WorkSceneThrowDeliverPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr);
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_TargetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_TargetBtn");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_BtnField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_BtnField");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_Preview");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewUIDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_PreviewUIDefaultPosition");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewUIOffsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_PreviewUIOffsetPosition");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_BtnInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_BtnInstances");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_Data");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_Points");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_Group");
			WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "m_PreviewCanvasGroup");
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674085);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674086);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674087);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_DescribeCurrentOrder_Private_Void_OrderBase_Image_Image_UIElementCluster_UIElementCluster_TextMeshProUGUI_TextMeshProUGUI_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674088);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674089);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674090);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674091);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674092);
			WorkSceneThrowDeliverPanel.NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, 100674093);
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001642E0 File Offset: 0x001624E0
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x0016431C File Offset: 0x0016251C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132058, XrefRangeEnd = 132080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00164358 File Offset: 0x00162558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132080, XrefRangeEnd = 132239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00164394 File Offset: 0x00162594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132286, RefRangeEnd = 132287, XrefRangeStart = 132239, XrefRangeEnd = 132286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeCurrentOrder(GuestsManager.OrderBase orderBase, Image servedFood, Image servedBev, UIElementCluster normalRequestUI, UIElementCluster specialRequestUI, TextMeshProUGUI guestName, TextMeshProUGUI deskCode, GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(servedFood);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(servedBev);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalRequestUI);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialRequestUI);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestName);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deskCode);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_DescribeCurrentOrder_Private_Void_OrderBase_Image_Image_UIElementCluster_UIElementCluster_TextMeshProUGUI_TextMeshProUGUI_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x0016445C File Offset: 0x0016265C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132287, XrefRangeEnd = 132297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00164498 File Offset: 0x00162698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132297, XrefRangeEnd = 132310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x001644D4 File Offset: 0x001626D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132310, XrefRangeEnd = 132337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneThrowDeliverPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00164510 File Offset: 0x00162710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132337, XrefRangeEnd = 132340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00164544 File Offset: 0x00162744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132340, XrefRangeEnd = 132343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelInitialize_b__12_0(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00020713 File Offset: 0x0001E913
		public WorkSceneThrowDeliverPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x00164590 File Offset: 0x00162790
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x0002071C File Offset: 0x0001E91C
		public unsafe UIElementCluster m_TargetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_TargetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_TargetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x001645C0 File Offset: 0x001627C0
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x0002073B File Offset: 0x0001E93B
		public unsafe RectTransform m_BtnField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_BtnField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_BtnField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x001645F0 File Offset: 0x001627F0
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x0002075A File Offset: 0x0001E95A
		public unsafe UIElementCluster m_Preview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Preview);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Preview), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x00164620 File Offset: 0x00162820
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x00020779 File Offset: 0x0001E979
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x00164650 File Offset: 0x00162850
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x00020798 File Offset: 0x0001E998
		public unsafe Vector2 m_PreviewUIDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewUIDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewUIDefaultPosition)) = value;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x00164678 File Offset: 0x00162878
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x000207B3 File Offset: 0x0001E9B3
		public unsafe Vector2 m_PreviewUIOffsetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewUIOffsetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewUIOffsetPosition)) = value;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x001646A0 File Offset: 0x001628A0
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x000207CE File Offset: 0x0001E9CE
		public unsafe List<GameObject> m_BtnInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_BtnInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_BtnInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x001646D0 File Offset: 0x001628D0
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x000207ED File Offset: 0x0001E9ED
		public unsafe Dictionary<int, ValueTuple<Vector3, GuestsManager.OrderBase, GuestGroupController>> m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<Vector3, GuestsManager.OrderBase, GuestGroupController>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x00164700 File Offset: 0x00162900
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x0002080C File Offset: 0x0001EA0C
		public unsafe Il2CppStructArray<Vector3> m_Points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x00164730 File Offset: 0x00162930
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x0002082B File Offset: 0x0001EA2B
		public unsafe UILogicalGroupT<int> m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00164760 File Offset: 0x00162960
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x0002084A File Offset: 0x0001EA4A
		public unsafe CanvasGroup m_PreviewCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.NativeFieldInfoPtr_m_PreviewCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026F8 RID: 9976
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetBtn;

		// Token: 0x040026F9 RID: 9977
		private static readonly IntPtr NativeFieldInfoPtr_m_BtnField;

		// Token: 0x040026FA RID: 9978
		private static readonly IntPtr NativeFieldInfoPtr_m_Preview;

		// Token: 0x040026FB RID: 9979
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x040026FC RID: 9980
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewUIDefaultPosition;

		// Token: 0x040026FD RID: 9981
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewUIOffsetPosition;

		// Token: 0x040026FE RID: 9982
		private static readonly IntPtr NativeFieldInfoPtr_m_BtnInstances;

		// Token: 0x040026FF RID: 9983
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04002700 RID: 9984
		private static readonly IntPtr NativeFieldInfoPtr_m_Points;

		// Token: 0x04002701 RID: 9985
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x04002702 RID: 9986
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewCanvasGroup;

		// Token: 0x04002703 RID: 9987
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002704 RID: 9988
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeMethodInfoPtr_DescribeCurrentOrder_Private_Void_OrderBase_Image_Image_UIElementCluster_UIElementCluster_TextMeshProUGUI_TextMeshProUGUI_GuestGroupController_0;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Private_Boolean_Int32_0;

		// Token: 0x0200094C RID: 2380
		[ObfuscatedName("NightScene.UI.HUDUtility.WorkSceneThrowDeliverPanel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA30 RID: 47664 RVA: 0x002EF6FC File Offset: 0x002ED8FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "canvas");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_mainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "mainCam");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_maxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "maxX");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_existRemiliaNegativeSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "existRemiliaNegativeSpell");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_serveFoodPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "serveFoodPreview");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_serveBeveragePreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "serveBeveragePreview");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_normalRequestPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "normalRequestPreview");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_specialRequestPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "specialRequestPreview");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_guestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "guestName");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_deskCodeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "deskCodeText");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_currentDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, "currentDeskCode");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, 100674094);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_UIElementCluster_KeyValuePair_2_Int32_ValueTuple_3_Vector3_OrderBase_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, 100674095);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr, 100674096);
			}

			// Token: 0x0600BA31 RID: 47665 RVA: 0x002EF854 File Offset: 0x002EDA54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA32 RID: 47666 RVA: 0x002EF890 File Offset: 0x002EDA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131865, XrefRangeEnd = 132007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__0(UIElementCluster ui, KeyValuePair<int, ValueTuple<Vector3, GuestsManager.OrderBase, GuestGroupController>> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_UIElementCluster_KeyValuePair_2_Int32_ValueTuple_3_Vector3_OrderBase_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA33 RID: 47667 RVA: 0x002EF8EC File Offset: 0x002EDAEC
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA34 RID: 47668 RVA: 0x00064779 File Offset: 0x00062979
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF9 RID: 15609
			// (get) Token: 0x0600BA35 RID: 47669 RVA: 0x002EF938 File Offset: 0x002EDB38
			// (set) Token: 0x0600BA36 RID: 47670 RVA: 0x00064782 File Offset: 0x00062982
			public unsafe Canvas canvas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_canvas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFA RID: 15610
			// (get) Token: 0x0600BA37 RID: 47671 RVA: 0x002EF968 File Offset: 0x002EDB68
			// (set) Token: 0x0600BA38 RID: 47672 RVA: 0x000647A1 File Offset: 0x000629A1
			public unsafe Camera mainCam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_mainCam);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_mainCam), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFB RID: 15611
			// (get) Token: 0x0600BA39 RID: 47673 RVA: 0x002EF998 File Offset: 0x002EDB98
			// (set) Token: 0x0600BA3A RID: 47674 RVA: 0x000647C0 File Offset: 0x000629C0
			public unsafe WorkSceneThrowDeliverPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneThrowDeliverPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFC RID: 15612
			// (get) Token: 0x0600BA3B RID: 47675 RVA: 0x002EF9C8 File Offset: 0x002EDBC8
			// (set) Token: 0x0600BA3C RID: 47676 RVA: 0x000647DF File Offset: 0x000629DF
			public unsafe float maxX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_maxX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_maxX)) = value;
				}
			}

			// Token: 0x17003CFD RID: 15613
			// (get) Token: 0x0600BA3D RID: 47677 RVA: 0x002EF9F0 File Offset: 0x002EDBF0
			// (set) Token: 0x0600BA3E RID: 47678 RVA: 0x000647FA File Offset: 0x000629FA
			public unsafe bool existRemiliaNegativeSpell
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_existRemiliaNegativeSpell);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_existRemiliaNegativeSpell)) = value;
				}
			}

			// Token: 0x17003CFE RID: 15614
			// (get) Token: 0x0600BA3F RID: 47679 RVA: 0x002EFA18 File Offset: 0x002EDC18
			// (set) Token: 0x0600BA40 RID: 47680 RVA: 0x00064815 File Offset: 0x00062A15
			public unsafe Image serveFoodPreview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_serveFoodPreview);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_serveFoodPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFF RID: 15615
			// (get) Token: 0x0600BA41 RID: 47681 RVA: 0x002EFA48 File Offset: 0x002EDC48
			// (set) Token: 0x0600BA42 RID: 47682 RVA: 0x00064834 File Offset: 0x00062A34
			public unsafe Image serveBeveragePreview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_serveBeveragePreview);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_serveBeveragePreview), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D00 RID: 15616
			// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x002EFA78 File Offset: 0x002EDC78
			// (set) Token: 0x0600BA44 RID: 47684 RVA: 0x00064853 File Offset: 0x00062A53
			public unsafe UIElementCluster normalRequestPreview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_normalRequestPreview);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_normalRequestPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D01 RID: 15617
			// (get) Token: 0x0600BA45 RID: 47685 RVA: 0x002EFAA8 File Offset: 0x002EDCA8
			// (set) Token: 0x0600BA46 RID: 47686 RVA: 0x00064872 File Offset: 0x00062A72
			public unsafe UIElementCluster specialRequestPreview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_specialRequestPreview);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_specialRequestPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D02 RID: 15618
			// (get) Token: 0x0600BA47 RID: 47687 RVA: 0x002EFAD8 File Offset: 0x002EDCD8
			// (set) Token: 0x0600BA48 RID: 47688 RVA: 0x00064891 File Offset: 0x00062A91
			public unsafe TextMeshProUGUI guestName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_guestName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_guestName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D03 RID: 15619
			// (get) Token: 0x0600BA49 RID: 47689 RVA: 0x002EFB08 File Offset: 0x002EDD08
			// (set) Token: 0x0600BA4A RID: 47690 RVA: 0x000648B0 File Offset: 0x00062AB0
			public unsafe TextMeshProUGUI deskCodeText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_deskCodeText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_deskCodeText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D04 RID: 15620
			// (get) Token: 0x0600BA4B RID: 47691 RVA: 0x002EFB38 File Offset: 0x002EDD38
			// (set) Token: 0x0600BA4C RID: 47692 RVA: 0x000648CF File Offset: 0x00062ACF
			public unsafe int currentDeskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_currentDeskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_currentDeskCode)) = value;
				}
			}

			// Token: 0x04007857 RID: 30807
			private static readonly IntPtr NativeFieldInfoPtr_canvas;

			// Token: 0x04007858 RID: 30808
			private static readonly IntPtr NativeFieldInfoPtr_mainCam;

			// Token: 0x04007859 RID: 30809
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400785A RID: 30810
			private static readonly IntPtr NativeFieldInfoPtr_maxX;

			// Token: 0x0400785B RID: 30811
			private static readonly IntPtr NativeFieldInfoPtr_existRemiliaNegativeSpell;

			// Token: 0x0400785C RID: 30812
			private static readonly IntPtr NativeFieldInfoPtr_serveFoodPreview;

			// Token: 0x0400785D RID: 30813
			private static readonly IntPtr NativeFieldInfoPtr_serveBeveragePreview;

			// Token: 0x0400785E RID: 30814
			private static readonly IntPtr NativeFieldInfoPtr_normalRequestPreview;

			// Token: 0x0400785F RID: 30815
			private static readonly IntPtr NativeFieldInfoPtr_specialRequestPreview;

			// Token: 0x04007860 RID: 30816
			private static readonly IntPtr NativeFieldInfoPtr_guestName;

			// Token: 0x04007861 RID: 30817
			private static readonly IntPtr NativeFieldInfoPtr_deskCodeText;

			// Token: 0x04007862 RID: 30818
			private static readonly IntPtr NativeFieldInfoPtr_currentDeskCode;

			// Token: 0x04007863 RID: 30819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007864 RID: 30820
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_UIElementCluster_KeyValuePair_2_Int32_ValueTuple_3_Vector3_OrderBase_GuestGroupController_0;

			// Token: 0x04007865 RID: 30821
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200094D RID: 2381
		[ObfuscatedName("NightScene.UI.HUDUtility.WorkSceneThrowDeliverPanel+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : Il2CppSystem.Object
		{
			// Token: 0x0600BA4D RID: 47693 RVA: 0x002EFB60 File Offset: 0x002EDD60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, "deskCode");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, "order");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_guestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, "guestGroupController");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, "CS$<>8__locals1");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, "<>9__5");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, "<>9__6");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, 100674097);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, 100674098);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, 100674099);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, 100674100);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr, 100674101);
			}

			// Token: 0x0600BA4E RID: 47694 RVA: 0x002EFC68 File Offset: 0x002EDE68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA4F RID: 47695 RVA: 0x002EFCA4 File Offset: 0x002EDEA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132007, XrefRangeEnd = 132027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA50 RID: 47696 RVA: 0x002EFCD8 File Offset: 0x002EDED8
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__5(GuestsManager.OrderBase predicateOrder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicateOrder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA51 RID: 47697 RVA: 0x002EFD28 File Offset: 0x002EDF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132027, XrefRangeEnd = 132028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA52 RID: 47698 RVA: 0x002EFD5C File Offset: 0x002EDF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132028, XrefRangeEnd = 132039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA53 RID: 47699 RVA: 0x000648EA File Offset: 0x00062AEA
			public __c__DisplayClass13_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D05 RID: 15621
			// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x002EFD90 File Offset: 0x002EDF90
			// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x000648F3 File Offset: 0x00062AF3
			public unsafe int deskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_deskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_deskCode)) = value;
				}
			}

			// Token: 0x17003D06 RID: 15622
			// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x002EFDB8 File Offset: 0x002EDFB8
			// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x0006490E File Offset: 0x00062B0E
			public unsafe GuestsManager.OrderBase order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_order);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_order), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D07 RID: 15623
			// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x002EFDE8 File Offset: 0x002EDFE8
			// (set) Token: 0x0600BA59 RID: 47705 RVA: 0x0006492D File Offset: 0x00062B2D
			public unsafe GuestGroupController guestGroupController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_guestGroupController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_guestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D08 RID: 15624
			// (get) Token: 0x0600BA5A RID: 47706 RVA: 0x002EFE18 File Offset: 0x002EE018
			// (set) Token: 0x0600BA5B RID: 47707 RVA: 0x0006494C File Offset: 0x00062B4C
			public unsafe WorkSceneThrowDeliverPanel.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneThrowDeliverPanel.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D09 RID: 15625
			// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x002EFE48 File Offset: 0x002EE048
			// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x0006496B File Offset: 0x00062B6B
			public unsafe Predicate<GuestsManager.OrderBase> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GuestsManager.OrderBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D0A RID: 15626
			// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x002EFE78 File Offset: 0x002EE078
			// (set) Token: 0x0600BA5F RID: 47711 RVA: 0x0006498A File Offset: 0x00062B8A
			public unsafe Action __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_1.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007866 RID: 30822
			private static readonly IntPtr NativeFieldInfoPtr_deskCode;

			// Token: 0x04007867 RID: 30823
			private static readonly IntPtr NativeFieldInfoPtr_order;

			// Token: 0x04007868 RID: 30824
			private static readonly IntPtr NativeFieldInfoPtr_guestGroupController;

			// Token: 0x04007869 RID: 30825
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x0400786A RID: 30826
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x0400786B RID: 30827
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x0400786C RID: 30828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400786D RID: 30829
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0;

			// Token: 0x0400786E RID: 30830
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Boolean_OrderBase_0;

			// Token: 0x0400786F RID: 30831
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_0;

			// Token: 0x04007870 RID: 30832
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0;
		}

		// Token: 0x0200094E RID: 2382
		[ObfuscatedName("NightScene.UI.HUDUtility.WorkSceneThrowDeliverPanel+<>c__DisplayClass13_2")]
		public sealed class __c__DisplayClass13_2 : Il2CppSystem.Object
		{
			// Token: 0x0600BA60 RID: 47712 RVA: 0x002EFEA8 File Offset: 0x002EE0A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_2()
			{
				Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "<>c__DisplayClass13_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr, "visual");
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr, 100674102);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr, 100674103);
				WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr, 100674104);
			}

			// Token: 0x0600BA61 RID: 47713 RVA: 0x002EFF24 File Offset: 0x002EE124
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass13_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA62 RID: 47714 RVA: 0x002EFF60 File Offset: 0x002EE160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132039, XrefRangeEnd = 132048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7(Image image)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA63 RID: 47715 RVA: 0x002EFFA4 File Offset: 0x002EE1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132048, XrefRangeEnd = 132057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__8(Image image)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA64 RID: 47716 RVA: 0x000649A9 File Offset: 0x00062BA9
			public __c__DisplayClass13_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D0B RID: 15627
			// (get) Token: 0x0600BA65 RID: 47717 RVA: 0x002EFFE8 File Offset: 0x002EE1E8
			// (set) Token: 0x0600BA66 RID: 47718 RVA: 0x000649B2 File Offset: 0x00062BB2
			public unsafe CharacterSpriteSetCompact visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass13_2.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007871 RID: 30833
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x04007872 RID: 30834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007873 RID: 30835
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_Image_0;

			// Token: 0x04007874 RID: 30836
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_Image_0;
		}

		// Token: 0x0200094F RID: 2383
		[ObfuscatedName("NightScene.UI.HUDUtility.WorkSceneThrowDeliverPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BA67 RID: 47719 RVA: 0x002F0018 File Offset: 0x002EE218
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr);
				WorkSceneThrowDeliverPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr, "<>9");
				WorkSceneThrowDeliverPanel.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr, "<>9__13_2");
				WorkSceneThrowDeliverPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr, 100674106);
				WorkSceneThrowDeliverPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_2_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr, 100674107);
			}

			// Token: 0x0600BA68 RID: 47720 RVA: 0x002F0094 File Offset: 0x002EE294
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA69 RID: 47721 RVA: 0x002F00D0 File Offset: 0x002EE2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132057, XrefRangeEnd = 132058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__13_2(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_2_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA6A RID: 47722 RVA: 0x000649D1 File Offset: 0x00062BD1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D0C RID: 15628
			// (get) Token: 0x0600BA6B RID: 47723 RVA: 0x002F0124 File Offset: 0x002EE324
			// (set) Token: 0x0600BA6C RID: 47724 RVA: 0x000649DA File Offset: 0x00062BDA
			public unsafe static WorkSceneThrowDeliverPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneThrowDeliverPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneThrowDeliverPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneThrowDeliverPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D0D RID: 15629
			// (get) Token: 0x0600BA6D RID: 47725 RVA: 0x002F014C File Offset: 0x002EE34C
			// (set) Token: 0x0600BA6E RID: 47726 RVA: 0x000649EC File Offset: 0x00062BEC
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, int> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneThrowDeliverPanel.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneThrowDeliverPanel.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007875 RID: 30837
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007876 RID: 30838
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04007877 RID: 30839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007878 RID: 30840
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_2_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0;
		}

		// Token: 0x02000950 RID: 2384
		[ObfuscatedName("NightScene.UI.HUDUtility.WorkSceneThrowDeliverPanel+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA6F RID: 47727 RVA: 0x002F0174 File Offset: 0x002EE374
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr);
				WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr, "pixel");
				WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr, 100674108);
				WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__DescribeCurrentOrder_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr, 100674109);
				WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__DescribeCurrentOrder_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr, 100674110);
			}

			// Token: 0x0600BA70 RID: 47728 RVA: 0x002F01F0 File Offset: 0x002EE3F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneThrowDeliverPanel.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA71 RID: 47729 RVA: 0x002F022C File Offset: 0x002EE42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeCurrentOrder_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__DescribeCurrentOrder_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA72 RID: 47730 RVA: 0x002F0270 File Offset: 0x002EE470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeCurrentOrder_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__DescribeCurrentOrder_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA73 RID: 47731 RVA: 0x000649FE File Offset: 0x00062BFE
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D0E RID: 15630
			// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x002F02B4 File Offset: 0x002EE4B4
			// (set) Token: 0x0600BA75 RID: 47733 RVA: 0x00064A07 File Offset: 0x00062C07
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneThrowDeliverPanel.__c__DisplayClass14_0.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007879 RID: 30841
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400787A RID: 30842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400787B RID: 30843
			private static readonly IntPtr NativeMethodInfoPtr__DescribeCurrentOrder_b__0_Internal_Void_Image_0;

			// Token: 0x0400787C RID: 30844
			private static readonly IntPtr NativeMethodInfoPtr__DescribeCurrentOrder_b__1_Internal_Void_Image_0;
		}
	}
}
