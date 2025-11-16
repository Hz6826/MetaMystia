using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020000C0 RID: 192
	public class DaySceneEventSelectionPannel : UIPanelParamOpen<DaySceneEventSelectionPannelOpenContext>
	{
		// Token: 0x0600157C RID: 5500 RVA: 0x000E6BD8 File Offset: 0x000E4DD8
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneEventSelectionPannel()
		{
			Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneEventSelectionPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr);
			DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_SelectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, "m_SelectionPrefab");
			DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, "m_Container");
			DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_Scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, "m_Scroll");
			DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_SelectionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, "m_SelectionInstances");
			DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_UseCustomTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, "m_UseCustomTitle");
			DaySceneEventSelectionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, 100667145);
			DaySceneEventSelectionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DaySceneEventSelectionPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, 100667146);
			DaySceneEventSelectionPannel.NativeMethodInfoPtr_UIButtonSimpleHandler_Private_Void_UIButtonSimple_KeyValuePair_2_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, 100667147);
			DaySceneEventSelectionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, 100667148);
			DaySceneEventSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, 100667149);
			DaySceneEventSelectionPannel.NativeMethodInfoPtr__OnPanelOpen_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, 100667150);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000E6CE4 File Offset: 0x000E4EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60851, XrefRangeEnd = 60853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneEventSelectionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x000E6D20 File Offset: 0x000E4F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60853, XrefRangeEnd = 60875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DaySceneEventSelectionPannelOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneEventSelectionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DaySceneEventSelectionPannelOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000E6D74 File Offset: 0x000E4F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60875, XrefRangeEnd = 60906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIButtonSimpleHandler(UIButtonSimple button, KeyValuePair<string, Action> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.NativeMethodInfoPtr_UIButtonSimpleHandler_Private_Void_UIButtonSimple_KeyValuePair_2_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000E6DD0 File Offset: 0x000E4FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60906, XrefRangeEnd = 60911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneEventSelectionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000E6E0C File Offset: 0x000E500C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60911, XrefRangeEnd = 60922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneEventSelectionPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000E6E48 File Offset: 0x000E5048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60922, XrefRangeEnd = 60929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.NativeMethodInfoPtr__OnPanelOpen_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0000D62D File Offset: 0x0000B82D
		public DaySceneEventSelectionPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000E6E7C File Offset: 0x000E507C
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000D636 File Offset: 0x0000B836
		public unsafe GameObject m_SelectionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_SelectionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_SelectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000E6EAC File Offset: 0x000E50AC
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000D655 File Offset: 0x0000B855
		public unsafe RectTransform m_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x000E6EDC File Offset: 0x000E50DC
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000D674 File Offset: 0x0000B874
		public unsafe AdpScrollListFixedComponent m_Scroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_Scroll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListFixedComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_Scroll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x000E6F0C File Offset: 0x000E510C
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000D693 File Offset: 0x0000B893
		public unsafe List<GameObject> m_SelectionInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_SelectionInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_SelectionInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000E6F3C File Offset: 0x000E513C
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000D6B2 File Offset: 0x0000B8B2
		public unsafe bool m_UseCustomTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_UseCustomTitle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.NativeFieldInfoPtr_m_UseCustomTitle)) = value;
			}
		}

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionPrefab;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_m_Container;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr_m_Scroll;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionInstances;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr_m_UseCustomTitle;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DaySceneEventSelectionPannelOpenContext_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_UIButtonSimpleHandler_Private_Void_UIButtonSimple_KeyValuePair_2_String_Action_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_0_Private_Void_0;

		// Token: 0x0200062D RID: 1581
		[ObfuscatedName("DayScene.UI.DaySceneEventSelectionPannel+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x06009207 RID: 37383 RVA: 0x00278E64 File Offset: 0x00277064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneEventSelectionPannel>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr);
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, "data");
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, "button");
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, 100667151);
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__UIButtonSimpleHandler_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, 100667152);
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__UIButtonSimpleHandler_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, 100667153);
				DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__UIButtonSimpleHandler_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr, 100667154);
			}

			// Token: 0x06009208 RID: 37384 RVA: 0x00278F1C File Offset: 0x0027711C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneEventSelectionPannel.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009209 RID: 37385 RVA: 0x00278F58 File Offset: 0x00277158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60840, XrefRangeEnd = 60845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UIButtonSimpleHandler_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__UIButtonSimpleHandler_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600920A RID: 37386 RVA: 0x00278F8C File Offset: 0x0027718C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60845, XrefRangeEnd = 60848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UIButtonSimpleHandler_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__UIButtonSimpleHandler_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600920B RID: 37387 RVA: 0x00278FD0 File Offset: 0x002771D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60848, XrefRangeEnd = 60851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UIButtonSimpleHandler_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeMethodInfoPtr__UIButtonSimpleHandler_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600920C RID: 37388 RVA: 0x0004F16B File Offset: 0x0004D36B
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030B0 RID: 12464
			// (get) Token: 0x0600920D RID: 37389 RVA: 0x00279004 File Offset: 0x00277204
			// (set) Token: 0x0600920E RID: 37390 RVA: 0x0004F174 File Offset: 0x0004D374
			public KeyValuePair<string, Action> data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_data);
					return new KeyValuePair<string, Action>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, Action>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, Action>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170030B1 RID: 12465
			// (get) Token: 0x0600920F RID: 37391 RVA: 0x00279034 File Offset: 0x00277234
			// (set) Token: 0x06009210 RID: 37392 RVA: 0x0004F1A2 File Offset: 0x0004D3A2
			public unsafe DaySceneEventSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneEventSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030B2 RID: 12466
			// (get) Token: 0x06009211 RID: 37393 RVA: 0x00279064 File Offset: 0x00277264
			// (set) Token: 0x06009212 RID: 37394 RVA: 0x0004F1C1 File Offset: 0x0004D3C1
			public unsafe UIButtonSimple button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005ED9 RID: 24281
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005EDA RID: 24282
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005EDB RID: 24283
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04005EDC RID: 24284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005EDD RID: 24285
			private static readonly IntPtr NativeMethodInfoPtr__UIButtonSimpleHandler_b__0_Internal_Void_0;

			// Token: 0x04005EDE RID: 24286
			private static readonly IntPtr NativeMethodInfoPtr__UIButtonSimpleHandler_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005EDF RID: 24287
			private static readonly IntPtr NativeMethodInfoPtr__UIButtonSimpleHandler_b__2_Internal_Void_0;
		}
	}
}
