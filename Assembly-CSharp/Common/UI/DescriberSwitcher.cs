using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x0200035B RID: 859
	public class DescriberSwitcher : MonoBehaviour
	{
		// Token: 0x060065A3 RID: 26019 RVA: 0x001F1F28 File Offset: 0x001F0128
		// Note: this type is marked as 'beforefieldinit'.
		static DescriberSwitcher()
		{
			Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DescriberSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr);
			DescriberSwitcher.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_Describer");
			DescriberSwitcher.NativeFieldInfoPtr_m_DescriptionParentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_DescriptionParentField");
			DescriberSwitcher.NativeFieldInfoPtr_m_TagParentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_TagParentField");
			DescriberSwitcher.NativeFieldInfoPtr_m_SwitchButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_SwitchButton");
			DescriberSwitcher.NativeFieldInfoPtr_m_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_ButtonText");
			DescriberSwitcher.NativeFieldInfoPtr_m_DefaultMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_DefaultMode");
			DescriberSwitcher.NativeFieldInfoPtr_m_CurrentDescriberMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_CurrentDescriberMode");
			DescriberSwitcher.NativeFieldInfoPtr_m_CurrentSwitcherMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_CurrentSwitcherMode");
			DescriberSwitcher.NativeFieldInfoPtr_m_LastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, "m_LastMode");
			DescriberSwitcher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684615);
			DescriberSwitcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684616);
			DescriberSwitcher.NativeMethodInfoPtr_SwitchMode_Public_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684617);
			DescriberSwitcher.NativeMethodInfoPtr_UpdateDescriberMode_Private_Void_DescriberMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684618);
			DescriberSwitcher.NativeMethodInfoPtr_AllowTags_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684619);
			DescriberSwitcher.NativeMethodInfoPtr_UpdateModeVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684620);
			DescriberSwitcher.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684621);
			DescriberSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684622);
			DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684623);
			DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684624);
			DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684625);
			DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684626);
			DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684627);
			DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr, 100684628);
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x001F2124 File Offset: 0x001F0324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262552, XrefRangeEnd = 262595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x001F2158 File Offset: 0x001F0358
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x001F218C File Offset: 0x001F038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262595, XrefRangeEnd = 262597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchMode(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr_SwitchMode_Public_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x001F21D4 File Offset: 0x001F03D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262597, XrefRangeEnd = 262598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDescriberMode(DescriberSwitcher.DescriberMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr_UpdateDescriberMode_Private_Void_DescriberMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x001F2214 File Offset: 0x001F0414
		[CallerCount(0)]
		public unsafe bool AllowTags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr_AllowTags_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x001F2250 File Offset: 0x001F0450
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 262617, RefRangeEnd = 262625, XrefRangeStart = 262598, XrefRangeEnd = 262617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModeVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr_UpdateModeVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x001F2284 File Offset: 0x001F0484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262625, XrefRangeEnd = 262630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescriberSwitcher.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x001F22C0 File Offset: 0x001F04C0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DescriberSwitcher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberSwitcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x001F22FC File Offset: 0x001F04FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262630, XrefRangeEnd = 262631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x001F2330 File Offset: 0x001F0530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262631, XrefRangeEnd = 262632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x001F2364 File Offset: 0x001F0564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262632, XrefRangeEnd = 262633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x001F2398 File Offset: 0x001F0598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262633, XrefRangeEnd = 262634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x001F23CC File Offset: 0x001F05CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262634, XrefRangeEnd = 262635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x001F2400 File Offset: 0x001F0600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262635, XrefRangeEnd = 262636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberSwitcher.NativeMethodInfoPtr__Awake_b__9_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00036E5D File Offset: 0x0003505D
		public DescriberSwitcher(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x060065B3 RID: 26035 RVA: 0x001F2434 File Offset: 0x001F0634
		// (set) Token: 0x060065B4 RID: 26036 RVA: 0x00036E66 File Offset: 0x00035066
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x001F2464 File Offset: 0x001F0664
		// (set) Token: 0x060065B6 RID: 26038 RVA: 0x00036E85 File Offset: 0x00035085
		public unsafe RectTransform m_DescriptionParentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_DescriptionParentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_DescriptionParentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x060065B7 RID: 26039 RVA: 0x001F2494 File Offset: 0x001F0694
		// (set) Token: 0x060065B8 RID: 26040 RVA: 0x00036EA4 File Offset: 0x000350A4
		public unsafe RectTransform m_TagParentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_TagParentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_TagParentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x001F24C4 File Offset: 0x001F06C4
		// (set) Token: 0x060065BA RID: 26042 RVA: 0x00036EC3 File Offset: 0x000350C3
		public unsafe UIButtonSimple m_SwitchButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_SwitchButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_SwitchButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x060065BB RID: 26043 RVA: 0x001F24F4 File Offset: 0x001F06F4
		// (set) Token: 0x060065BC RID: 26044 RVA: 0x00036EE2 File Offset: 0x000350E2
		public unsafe TextMeshProUGUI m_ButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_ButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_ButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x001F2524 File Offset: 0x001F0724
		// (set) Token: 0x060065BE RID: 26046 RVA: 0x00036F01 File Offset: 0x00035101
		public unsafe DescriberSwitcher.SwitcherMode m_DefaultMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_DefaultMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_DefaultMode)) = value;
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x060065BF RID: 26047 RVA: 0x001F254C File Offset: 0x001F074C
		// (set) Token: 0x060065C0 RID: 26048 RVA: 0x00036F1C File Offset: 0x0003511C
		public unsafe DescriberSwitcher.DescriberMode m_CurrentDescriberMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_CurrentDescriberMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_CurrentDescriberMode)) = value;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x060065C1 RID: 26049 RVA: 0x001F2574 File Offset: 0x001F0774
		// (set) Token: 0x060065C2 RID: 26050 RVA: 0x00036F37 File Offset: 0x00035137
		public unsafe DescriberSwitcher.SwitcherMode m_CurrentSwitcherMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_CurrentSwitcherMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_CurrentSwitcherMode)) = value;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x001F259C File Offset: 0x001F079C
		// (set) Token: 0x060065C4 RID: 26052 RVA: 0x00036F52 File Offset: 0x00035152
		public Nullable<bool> m_LastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_LastMode);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberSwitcher.NativeFieldInfoPtr_m_LastMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400436F RID: 17263
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x04004370 RID: 17264
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriptionParentField;

		// Token: 0x04004371 RID: 17265
		private static readonly IntPtr NativeFieldInfoPtr_m_TagParentField;

		// Token: 0x04004372 RID: 17266
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchButton;

		// Token: 0x04004373 RID: 17267
		private static readonly IntPtr NativeFieldInfoPtr_m_ButtonText;

		// Token: 0x04004374 RID: 17268
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultMode;

		// Token: 0x04004375 RID: 17269
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDescriberMode;

		// Token: 0x04004376 RID: 17270
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSwitcherMode;

		// Token: 0x04004377 RID: 17271
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMode;

		// Token: 0x04004378 RID: 17272
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004379 RID: 17273
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400437A RID: 17274
		private static readonly IntPtr NativeMethodInfoPtr_SwitchMode_Public_Void_CallbackContext_0;

		// Token: 0x0400437B RID: 17275
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDescriberMode_Private_Void_DescriberMode_0;

		// Token: 0x0400437C RID: 17276
		private static readonly IntPtr NativeMethodInfoPtr_AllowTags_Private_Boolean_0;

		// Token: 0x0400437D RID: 17277
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModeVisual_Private_Void_0;

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004380 RID: 17280
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0;

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_1_Private_Void_0;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_2_Private_Void_0;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_3_Private_Void_0;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_4_Private_Void_0;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_5_Private_Void_0;

		// Token: 0x02000E3E RID: 3646
		public enum SwitcherMode
		{
			// Token: 0x0400A574 RID: 42356
			Description,
			// Token: 0x0400A575 RID: 42357
			Tag
		}

		// Token: 0x02000E3F RID: 3647
		public enum DescriberMode
		{
			// Token: 0x0400A577 RID: 42359
			ObjectLanguageBase,
			// Token: 0x0400A578 RID: 42360
			LanguageBase,
			// Token: 0x0400A579 RID: 42361
			Null,
			// Token: 0x0400A57A RID: 42362
			Sellable,
			// Token: 0x0400A57B RID: 42363
			Ingredient
		}
	}
}
