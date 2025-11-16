using System;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x020000D5 RID: 213
	public class DLC4_FlandreHomeDecorationStorageTabPanel : MultiLayerUISubPanel<DLC4_FlandreHomeDecorationEditorPanel, DLC4_FlandreHomeDecorationStorageTabPanel, DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType>
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x000F4E2C File Offset: 0x000F302C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreHomeDecorationStorageTabPanel()
		{
			Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_FlandreHomeDecorationStorageTabPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_storageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "storageParent");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_shopParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "shopParent");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoAllBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoAllBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoCarpetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoCarpetBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoCabinetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoCabinetBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoTableBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoTableBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoChairBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoChairBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoBedBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoBedBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoObjectBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoObjectBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoPaintBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoPaintBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoShopBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "GotoShopBtn");
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_EditorParentPanel_Public_get_DLC4_FlandreHomeDecorationEditorPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667903);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667904);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667905);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_AlbumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667906);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667907);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667908);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_GoToDefaultPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667909);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667910);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667911);
			DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__22_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, 100667912);
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x000F5000 File Offset: 0x000F3200
		public unsafe DLC4_FlandreHomeDecorationEditorPanel EditorParentPanel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70019, XrefRangeEnd = 70020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_EditorParentPanel_Public_get_DLC4_FlandreHomeDecorationEditorPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr3) : null;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x000F5040 File Offset: 0x000F3240
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x000F5088 File Offset: 0x000F3288
		public unsafe override IEnumerable<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70020, XrefRangeEnd = 70026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000F50D4 File Offset: 0x000F32D4
		public unsafe override DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType DefaultPanelSelection
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_AlbumType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000F511C File Offset: 0x000F331C
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70026, XrefRangeEnd = 70027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000F5160 File Offset: 0x000F3360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70027, XrefRangeEnd = 70041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPostPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000F519C File Offset: 0x000F339C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70041, XrefRangeEnd = 70044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToDefaultPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_GoToDefaultPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000F51D0 File Offset: 0x000F33D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70044, XrefRangeEnd = 70058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000F520C File Offset: 0x000F340C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70058, XrefRangeEnd = 70061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreHomeDecorationStorageTabPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000F5248 File Offset: 0x000F3448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70061, XrefRangeEnd = 70067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__22_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__22_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00010422 File Offset: 0x0000E622
		public DLC4_FlandreHomeDecorationStorageTabPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000F5290 File Offset: 0x000F3490
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x0001042B File Offset: 0x0000E62B
		public unsafe DLC4_FlandreHomeDecorationStoragePanel storageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_storageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationStoragePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_storageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x000F52C0 File Offset: 0x000F34C0
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0001044A File Offset: 0x0000E64A
		public unsafe DLC4_FlandreHomeDecorationShopPanel shopParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_shopParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationShopPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_shopParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x000F52F0 File Offset: 0x000F34F0
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00010469 File Offset: 0x0000E669
		public unsafe UIButtonToggle GotoAllBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoAllBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoAllBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000F5320 File Offset: 0x000F3520
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x00010488 File Offset: 0x0000E688
		public unsafe UIButtonToggle GotoCarpetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoCarpetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoCarpetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000F5350 File Offset: 0x000F3550
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x000104A7 File Offset: 0x0000E6A7
		public unsafe UIButtonToggle GotoCabinetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoCabinetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoCabinetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x000F5380 File Offset: 0x000F3580
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x000104C6 File Offset: 0x0000E6C6
		public unsafe UIButtonToggle GotoTableBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoTableBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoTableBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000F53B0 File Offset: 0x000F35B0
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x000104E5 File Offset: 0x0000E6E5
		public unsafe UIButtonToggle GotoChairBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoChairBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoChairBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x000F53E0 File Offset: 0x000F35E0
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x00010504 File Offset: 0x0000E704
		public unsafe UIButtonToggle GotoBedBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoBedBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoBedBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x000F5410 File Offset: 0x000F3610
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x00010523 File Offset: 0x0000E723
		public unsafe UIButtonToggle GotoObjectBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoObjectBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoObjectBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x000F5440 File Offset: 0x000F3640
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x00010542 File Offset: 0x0000E742
		public unsafe UIButtonToggle GotoPaintBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoPaintBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoPaintBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000F5470 File Offset: 0x000F3670
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x00010561 File Offset: 0x0000E761
		public unsafe UIButtonToggle GotoShopBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoShopBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel.NativeFieldInfoPtr_GotoShopBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_storageParent;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr_shopParent;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr_GotoAllBtn;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_GotoCarpetBtn;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_GotoCabinetBtn;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_GotoTableBtn;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_GotoChairBtn;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_GotoBedBtn;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr_GotoObjectBtn;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr_GotoPaintBtn;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr_GotoShopBtn;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorParentPanel_Public_get_DLC4_FlandreHomeDecorationEditorPanel_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_AlbumType_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_GoToDefaultPanel_Public_Void_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__22_0_Private_Void_CallbackContext_0;

		// Token: 0x0200068D RID: 1677
		public enum AlbumType
		{
			// Token: 0x04006199 RID: 24985
			All,
			// Token: 0x0400619A RID: 24986
			Carpet,
			// Token: 0x0400619B RID: 24987
			Cabinet,
			// Token: 0x0400619C RID: 24988
			Table,
			// Token: 0x0400619D RID: 24989
			Chair,
			// Token: 0x0400619E RID: 24990
			Bed,
			// Token: 0x0400619F RID: 24991
			Object,
			// Token: 0x040061A0 RID: 24992
			Paint,
			// Token: 0x040061A1 RID: 24993
			Shop
		}

		// Token: 0x0200068E RID: 1678
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationStorageTabPanel+<get_GetData>d__17")]
		public sealed class _get_GetData_d__17 : Object
		{
			// Token: 0x06009683 RID: 38531 RVA: 0x00286404 File Offset: 0x00284604
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__17()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel>.NativeClassPtr, "<get_GetData>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, "<>1__state");
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, "<>2__current");
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, "<>l__initialThreadId");
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667913);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667914);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667915);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667916);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667917);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667918);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667919);
				DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr, 100667920);
			}

			// Token: 0x06009684 RID: 38532 RVA: 0x00286520 File Offset: 0x00284720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70002, XrefRangeEnd = 70004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009685 RID: 38533 RVA: 0x00286568 File Offset: 0x00284768
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009686 RID: 38534 RVA: 0x0028659C File Offset: 0x0028479C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70004, XrefRangeEnd = 70008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170031FE RID: 12798
			// (get) Token: 0x06009687 RID: 38535 RVA: 0x002865D8 File Offset: 0x002847D8
			public unsafe ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>> prop_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>(pointer);
				}
			}

			// Token: 0x06009688 RID: 38536 RVA: 0x00286610 File Offset: 0x00284810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70008, XrefRangeEnd = 70014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170031FF RID: 12799
			// (get) Token: 0x06009689 RID: 38537 RVA: 0x00286644 File Offset: 0x00284844
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70014, XrefRangeEnd = 70017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600968A RID: 38538 RVA: 0x00286684 File Offset: 0x00284884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70017, XrefRangeEnd = 70019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>>>(intPtr3) : null;
			}

			// Token: 0x0600968B RID: 38539 RVA: 0x002866C4 File Offset: 0x002848C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600968C RID: 38540 RVA: 0x000515E0 File Offset: 0x0004F7E0
			public _get_GetData_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031FA RID: 12794
			// (get) Token: 0x0600968D RID: 38541 RVA: 0x00286704 File Offset: 0x00284904
			// (set) Token: 0x0600968E RID: 38542 RVA: 0x000515E9 File Offset: 0x0004F7E9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170031FB RID: 12795
			// (get) Token: 0x0600968F RID: 38543 RVA: 0x0028672C File Offset: 0x0028492C
			// (set) Token: 0x06009690 RID: 38544 RVA: 0x00051604 File Offset: 0x0004F804
			public ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___2__current);
					return new ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170031FC RID: 12796
			// (get) Token: 0x06009691 RID: 38545 RVA: 0x0028675C File Offset: 0x0028495C
			// (set) Token: 0x06009692 RID: 38546 RVA: 0x00051632 File Offset: 0x0004F832
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170031FD RID: 12797
			// (get) Token: 0x06009693 RID: 38547 RVA: 0x00286784 File Offset: 0x00284984
			// (set) Token: 0x06009694 RID: 38548 RVA: 0x0005164D File Offset: 0x0004F84D
			public unsafe DLC4_FlandreHomeDecorationStorageTabPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationStorageTabPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStorageTabPanel._get_GetData_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040061A2 RID: 24994
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040061A3 RID: 24995
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040061A4 RID: 24996
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040061A5 RID: 24997
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040061A6 RID: 24998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040061A7 RID: 24999
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040061A8 RID: 25000
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040061A9 RID: 25001
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0;

			// Token: 0x040061AA RID: 25002
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040061AB RID: 25003
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040061AC RID: 25004
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_DLC4_FlandreHomeDecorationStorageTabPanel_0;

			// Token: 0x040061AD RID: 25005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
