using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000380 RID: 896
	public class TextMeshProUGUIColorController : MonoBehaviour
	{
		// Token: 0x06006A54 RID: 27220 RVA: 0x0020152C File Offset: 0x001FF72C
		// Note: this type is marked as 'beforefieldinit'.
		static TextMeshProUGUIColorController()
		{
			Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "TextMeshProUGUIColorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr);
			TextMeshProUGUIColorController.NativeFieldInfoPtr_m_EnableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr, "m_EnableColor");
			TextMeshProUGUIColorController.NativeFieldInfoPtr_m_DisableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr, "m_DisableColor");
			TextMeshProUGUIColorController.NativeFieldInfoPtr_m_TextMeshProUGUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr, "m_TextMeshProUGUI");
			TextMeshProUGUIColorController.NativeMethodInfoPtr_Do_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr, 100685321);
			TextMeshProUGUIColorController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr, 100685322);
			TextMeshProUGUIColorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr, 100685323);
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x002015D4 File Offset: 0x001FF7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270699, XrefRangeEnd = 270700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Do(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUIColorController.NativeMethodInfoPtr_Do_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x00201614 File Offset: 0x001FF814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270701, RefRangeEnd = 270703, XrefRangeStart = 270700, XrefRangeEnd = 270701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUIColorController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x00201650 File Offset: 0x001FF850
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMeshProUGUIColorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProUGUIColorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUIColorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x0003984A File Offset: 0x00037A4A
		public TextMeshProUGUIColorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x0020168C File Offset: 0x001FF88C
		// (set) Token: 0x06006A5A RID: 27226 RVA: 0x00039853 File Offset: 0x00037A53
		public unsafe Color32 m_EnableColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUIColorController.NativeFieldInfoPtr_m_EnableColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUIColorController.NativeFieldInfoPtr_m_EnableColor)) = value;
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x002016B4 File Offset: 0x001FF8B4
		// (set) Token: 0x06006A5C RID: 27228 RVA: 0x0003986E File Offset: 0x00037A6E
		public unsafe Color32 m_DisableColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUIColorController.NativeFieldInfoPtr_m_DisableColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUIColorController.NativeFieldInfoPtr_m_DisableColor)) = value;
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x002016DC File Offset: 0x001FF8DC
		// (set) Token: 0x06006A5E RID: 27230 RVA: 0x00039889 File Offset: 0x00037A89
		public unsafe TextMeshProUGUI m_TextMeshProUGUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUIColorController.NativeFieldInfoPtr_m_TextMeshProUGUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUIColorController.NativeFieldInfoPtr_m_TextMeshProUGUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004681 RID: 18049
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableColor;

		// Token: 0x04004682 RID: 18050
		private static readonly IntPtr NativeFieldInfoPtr_m_DisableColor;

		// Token: 0x04004683 RID: 18051
		private static readonly IntPtr NativeFieldInfoPtr_m_TextMeshProUGUI;

		// Token: 0x04004684 RID: 18052
		private static readonly IntPtr NativeMethodInfoPtr_Do_Public_Void_Boolean_0;

		// Token: 0x04004685 RID: 18053
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004686 RID: 18054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
