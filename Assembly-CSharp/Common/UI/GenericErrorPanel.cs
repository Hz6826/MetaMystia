using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace Common.UI
{
	// Token: 0x0200037B RID: 891
	public class GenericErrorPanel : UIPanelParamOpen<ValueTuple<string, string>>
	{
		// Token: 0x060069B9 RID: 27065 RVA: 0x001FF6EC File Offset: 0x001FD8EC
		// Note: this type is marked as 'beforefieldinit'.
		static GenericErrorPanel()
		{
			Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "GenericErrorPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr);
			GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, "m_ErrorMessageTitle");
			GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, "m_ErrorMessageField");
			GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageFieldButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, "m_ErrorMessageFieldButton");
			GenericErrorPanel.NativeFieldInfoPtr_m_QuitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, "m_QuitButton");
			GenericErrorPanel.NativeMethodInfoPtr_AppendText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685225);
			GenericErrorPanel.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685226);
			GenericErrorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685227);
			GenericErrorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685228);
			GenericErrorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685229);
			GenericErrorPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685230);
			GenericErrorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685231);
			GenericErrorPanel.NativeMethodInfoPtr__OnPanelOpen_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr, 100685232);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x001FF80C File Offset: 0x001FDA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269657, XrefRangeEnd = 269661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendText(string newText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericErrorPanel.NativeMethodInfoPtr_AppendText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x001FF850 File Offset: 0x001FDA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269662, RefRangeEnd = 269663, XrefRangeStart = 269661, XrefRangeEnd = 269662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericErrorPanel.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x001FF894 File Offset: 0x001FDA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269663, XrefRangeEnd = 269678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericErrorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x001FF8D0 File Offset: 0x001FDAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269678, XrefRangeEnd = 269691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(ValueTuple<string, string> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericErrorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x001FF924 File Offset: 0x001FDB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericErrorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x001FF960 File Offset: 0x001FDB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269691, XrefRangeEnd = 269694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericErrorPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericErrorPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericErrorPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x001FF99C File Offset: 0x001FDB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269694, XrefRangeEnd = 269696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericErrorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x001FF9D0 File Offset: 0x001FDBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269696, XrefRangeEnd = 269698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericErrorPanel.NativeMethodInfoPtr__OnPanelOpen_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x00039263 File Offset: 0x00037463
		public GenericErrorPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x060069C3 RID: 27075 RVA: 0x001FFA04 File Offset: 0x001FDC04
		// (set) Token: 0x060069C4 RID: 27076 RVA: 0x0003926C File Offset: 0x0003746C
		public unsafe TextMeshProUGUI m_ErrorMessageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x060069C5 RID: 27077 RVA: 0x001FFA34 File Offset: 0x001FDC34
		// (set) Token: 0x060069C6 RID: 27078 RVA: 0x0003928B File Offset: 0x0003748B
		public unsafe TextMeshProUGUI m_ErrorMessageField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x060069C7 RID: 27079 RVA: 0x001FFA64 File Offset: 0x001FDC64
		// (set) Token: 0x060069C8 RID: 27080 RVA: 0x000392AA File Offset: 0x000374AA
		public unsafe UIButtonSimple m_ErrorMessageFieldButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageFieldButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_ErrorMessageFieldButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x060069C9 RID: 27081 RVA: 0x001FFA94 File Offset: 0x001FDC94
		// (set) Token: 0x060069CA RID: 27082 RVA: 0x000392C9 File Offset: 0x000374C9
		public unsafe UIButtonSimple m_QuitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_QuitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericErrorPanel.NativeFieldInfoPtr_m_QuitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400461E RID: 17950
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorMessageTitle;

		// Token: 0x0400461F RID: 17951
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorMessageField;

		// Token: 0x04004620 RID: 17952
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorMessageFieldButton;

		// Token: 0x04004621 RID: 17953
		private static readonly IntPtr NativeFieldInfoPtr_m_QuitButton;

		// Token: 0x04004622 RID: 17954
		private static readonly IntPtr NativeMethodInfoPtr_AppendText_Public_Void_String_0;

		// Token: 0x04004623 RID: 17955
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

		// Token: 0x04004624 RID: 17956
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004625 RID: 17957
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_String_String_0;

		// Token: 0x04004626 RID: 17958
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004627 RID: 17959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004628 RID: 17960
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0;

		// Token: 0x04004629 RID: 17961
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_0_Private_Void_0;
	}
}
