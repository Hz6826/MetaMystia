using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x020003D1 RID: 977
	public class DLC5_PresetSelectionPanel : UIPanelParam<DLC5_PresetSelectionPanel.OpenContext, Nullable<int>>
	{
		// Token: 0x060074B0 RID: 29872 RVA: 0x00223468 File Offset: 0x00221668
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_PresetSelectionPanel()
		{
			Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.CreatorsBox", "DLC5_PresetSelectionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr);
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_Preset1");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_Preset2");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_Preset3");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_Title");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_AvailableSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_AvailableSprite");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_UnavailableSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_UnavailableSprite");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_AvailableSprite_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_AvailableSprite_Selected");
			DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_UnavailableSprite_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "m_UnavailableSprite_Selected");
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687272);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687273);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr_First_Private_Static_UIButtonHold_UIButtonHold_UIButtonHold_UIButtonHold_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687274);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687275);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687276);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687277);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687278);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687279);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687280);
			DLC5_PresetSelectionPanel.NativeMethodInfoPtr_Method_Private_Void_Selectable_Int32_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, 100687281);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00223600 File Offset: 0x00221800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290435, XrefRangeEnd = 290463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_PresetSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x0022363C File Offset: 0x0022183C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290463, XrefRangeEnd = 290473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_PresetSelectionPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_PresetSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x00223690 File Offset: 0x00221890
		[CallerCount(0)]
		public unsafe static UIButtonHold First(UIButtonHold a, UIButtonHold b, UIButtonHold c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr_First_Private_Static_UIButtonHold_UIButtonHold_UIButtonHold_UIButtonHold_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr3) : null;
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x002236F8 File Offset: 0x002218F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290473, XrefRangeEnd = 290482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_PresetSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x00223734 File Offset: 0x00221934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290482, XrefRangeEnd = 290485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_PresetSelectionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x00223770 File Offset: 0x00221970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290485, XrefRangeEnd = 290491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x002237A4 File Offset: 0x002219A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290491, XrefRangeEnd = 290497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x002237D8 File Offset: 0x002219D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290497, XrefRangeEnd = 290503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x0022380C File Offset: 0x00221A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290503, XrefRangeEnd = 290506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_3(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x00223854 File Offset: 0x00221A54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290516, RefRangeEnd = 290519, XrefRangeStart = 290506, XrefRangeEnd = 290516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Selectable_Int32_byref___c__DisplayClass10_0_0(Selectable button, int index, ref DLC5_PresetSelectionPanel.__c__DisplayClass10_0 A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.NativeMethodInfoPtr_Method_Private_Void_Selectable_Int32_byref___c__DisplayClass10_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0003F29F File Offset: 0x0003D49F
		public DLC5_PresetSelectionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x060074BC RID: 29884 RVA: 0x002238B8 File Offset: 0x00221AB8
		// (set) Token: 0x060074BD RID: 29885 RVA: 0x0003F2A8 File Offset: 0x0003D4A8
		public unsafe UIButtonHold m_Preset1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x060074BE RID: 29886 RVA: 0x002238E8 File Offset: 0x00221AE8
		// (set) Token: 0x060074BF RID: 29887 RVA: 0x0003F2C7 File Offset: 0x0003D4C7
		public unsafe UIButtonHold m_Preset2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x060074C0 RID: 29888 RVA: 0x00223918 File Offset: 0x00221B18
		// (set) Token: 0x060074C1 RID: 29889 RVA: 0x0003F2E6 File Offset: 0x0003D4E6
		public unsafe UIButtonHold m_Preset3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Preset3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x00223948 File Offset: 0x00221B48
		// (set) Token: 0x060074C3 RID: 29891 RVA: 0x0003F305 File Offset: 0x0003D505
		public unsafe TextMeshProUGUI m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x00223978 File Offset: 0x00221B78
		// (set) Token: 0x060074C5 RID: 29893 RVA: 0x0003F324 File Offset: 0x0003D524
		public unsafe Sprite m_AvailableSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_AvailableSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_AvailableSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x002239A8 File Offset: 0x00221BA8
		// (set) Token: 0x060074C7 RID: 29895 RVA: 0x0003F343 File Offset: 0x0003D543
		public unsafe Sprite m_UnavailableSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_UnavailableSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_UnavailableSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x002239D8 File Offset: 0x00221BD8
		// (set) Token: 0x060074C9 RID: 29897 RVA: 0x0003F362 File Offset: 0x0003D562
		public unsafe Sprite m_AvailableSprite_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_AvailableSprite_Selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_AvailableSprite_Selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x00223A08 File Offset: 0x00221C08
		// (set) Token: 0x060074CB RID: 29899 RVA: 0x0003F381 File Offset: 0x0003D581
		public unsafe Sprite m_UnavailableSprite_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_UnavailableSprite_Selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.NativeFieldInfoPtr_m_UnavailableSprite_Selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeFieldInfoPtr_m_Preset1;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeFieldInfoPtr_m_Preset2;

		// Token: 0x04004D51 RID: 19793
		private static readonly IntPtr NativeFieldInfoPtr_m_Preset3;

		// Token: 0x04004D52 RID: 19794
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x04004D53 RID: 19795
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableSprite;

		// Token: 0x04004D54 RID: 19796
		private static readonly IntPtr NativeFieldInfoPtr_m_UnavailableSprite;

		// Token: 0x04004D55 RID: 19797
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableSprite_Selected;

		// Token: 0x04004D56 RID: 19798
		private static readonly IntPtr NativeFieldInfoPtr_m_UnavailableSprite_Selected;

		// Token: 0x04004D57 RID: 19799
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeMethodInfoPtr_First_Private_Static_UIButtonHold_UIButtonHold_UIButtonHold_UIButtonHold_0;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_0;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_0;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_0;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Private_Void_CallbackContext_0;

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Selectable_Int32_byref___c__DisplayClass10_0_0;

		// Token: 0x02000F6C RID: 3948
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06011279 RID: 70265 RVA: 0x003F4E18 File Offset: 0x003F3018
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr);
				DLC5_PresetSelectionPanel.OpenContext.NativeFieldInfoPtr_Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr, "Presets");
				DLC5_PresetSelectionPanel.OpenContext.NativeFieldInfoPtr_OpenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr, "OpenMode");
				DLC5_PresetSelectionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Nullable_1_CreatorBoxData_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr, 100687282);
			}

			// Token: 0x0601127A RID: 70266 RVA: 0x003F4E80 File Offset: 0x003F3080
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 112346, RefRangeEnd = 112438, XrefRangeStart = 112346, XrefRangeEnd = 112438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Il2CppReferenceArray<Nullable<CreatorBoxData>> presets, DLC5_PresetSelectionPanel.OpenContext.Mode openMode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(presets);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_PresetSelectionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Nullable_1_CreatorBoxData_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601127B RID: 70267 RVA: 0x00095281 File Offset: 0x00093481
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601127C RID: 70268 RVA: 0x0009528A File Offset: 0x0009348A
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700592C RID: 22828
			// (get) Token: 0x0601127D RID: 70269 RVA: 0x003F4EE0 File Offset: 0x003F30E0
			// (set) Token: 0x0601127E RID: 70270 RVA: 0x0009529C File Offset: 0x0009349C
			public unsafe Il2CppReferenceArray<Nullable<CreatorBoxData>> Presets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.OpenContext.NativeFieldInfoPtr_Presets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Nullable<CreatorBoxData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.OpenContext.NativeFieldInfoPtr_Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700592D RID: 22829
			// (get) Token: 0x0601127F RID: 70271 RVA: 0x003F4F10 File Offset: 0x003F3110
			// (set) Token: 0x06011280 RID: 70272 RVA: 0x000952BB File Offset: 0x000934BB
			public unsafe DLC5_PresetSelectionPanel.OpenContext.Mode OpenMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.OpenContext.NativeFieldInfoPtr_OpenMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.OpenContext.NativeFieldInfoPtr_OpenMode)) = value;
				}
			}

			// Token: 0x0400AD85 RID: 44421
			private static readonly IntPtr NativeFieldInfoPtr_Presets;

			// Token: 0x0400AD86 RID: 44422
			private static readonly IntPtr NativeFieldInfoPtr_OpenMode;

			// Token: 0x0400AD87 RID: 44423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Nullable_1_CreatorBoxData_Mode_0;

			// Token: 0x020010DC RID: 4316
			public enum Mode
			{
				// Token: 0x0400B913 RID: 47379
				Read,
				// Token: 0x0400B914 RID: 47380
				Write
			}
		}

		// Token: 0x02000F6D RID: 3949
		[ObfuscatedName("Common.UI.CreatorsBox.DLC5_PresetSelectionPanel+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : ValueType
		{
			// Token: 0x06011281 RID: 70273 RVA: 0x003F4F38 File Offset: 0x003F3138
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DLC5_PresetSelectionPanel.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_PresetSelectionPanel>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.__c__DisplayClass10_0>.NativeClassPtr);
				DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr_openParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.__c__DisplayClass10_0>.NativeClassPtr, "openParam");
				DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr_isRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.__c__DisplayClass10_0>.NativeClassPtr, "isRead");
				DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
			}

			// Token: 0x06011282 RID: 70274 RVA: 0x000952D6 File Offset: 0x000934D6
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011283 RID: 70275 RVA: 0x000952DF File Offset: 0x000934DF
			public __c__DisplayClass10_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.__c__DisplayClass10_0>.NativeClassPtr))
			{
			}

			// Token: 0x1700592E RID: 22830
			// (get) Token: 0x06011284 RID: 70276 RVA: 0x003F4FA0 File Offset: 0x003F31A0
			// (set) Token: 0x06011285 RID: 70277 RVA: 0x000952F1 File Offset: 0x000934F1
			public DLC5_PresetSelectionPanel.OpenContext openParam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr_openParam);
					return new DLC5_PresetSelectionPanel.OpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr_openParam), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_PresetSelectionPanel.OpenContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700592F RID: 22831
			// (get) Token: 0x06011286 RID: 70278 RVA: 0x003F4FD0 File Offset: 0x003F31D0
			// (set) Token: 0x06011287 RID: 70279 RVA: 0x0009531F File Offset: 0x0009351F
			public unsafe bool isRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr_isRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr_isRead)) = value;
				}
			}

			// Token: 0x17005930 RID: 22832
			// (get) Token: 0x06011288 RID: 70280 RVA: 0x003F4FF8 File Offset: 0x003F31F8
			// (set) Token: 0x06011289 RID: 70281 RVA: 0x0009533A File Offset: 0x0009353A
			public unsafe DLC5_PresetSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_PresetSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_PresetSelectionPanel.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD88 RID: 44424
			private static readonly IntPtr NativeFieldInfoPtr_openParam;

			// Token: 0x0400AD89 RID: 44425
			private static readonly IntPtr NativeFieldInfoPtr_isRead;

			// Token: 0x0400AD8A RID: 44426
			private static readonly IntPtr NativeFieldInfoPtr___4__this;
		}
	}
}
