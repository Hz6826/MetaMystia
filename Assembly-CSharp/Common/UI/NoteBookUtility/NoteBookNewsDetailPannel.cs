using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.CoreLanguage;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000394 RID: 916
	public class NoteBookNewsDetailPannel : UIPanelParamOpen<ValueTuple<LanguageBase, GameDate>>
	{
		// Token: 0x06006DC8 RID: 28104 RVA: 0x0020C99C File Offset: 0x0020AB9C
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookNewsDetailPannel()
		{
			Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookNewsDetailPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr);
			NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, "m_Title");
			NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, "m_Content");
			NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, "m_Date");
			NoteBookNewsDetailPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, 100685810);
			NoteBookNewsDetailPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_LanguageBase_GameDate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, 100685811);
			NoteBookNewsDetailPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, 100685812);
			NoteBookNewsDetailPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr, 100685813);
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x0020CA58 File Offset: 0x0020AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275565, XrefRangeEnd = 275569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsDetailPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x0020CA94 File Offset: 0x0020AC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275569, XrefRangeEnd = 275572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(ValueTuple<LanguageBase, GameDate> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsDetailPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_LanguageBase_GameDate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x0020CAE8 File Offset: 0x0020ACE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsDetailPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x0020CB24 File Offset: 0x0020AD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275572, XrefRangeEnd = 275575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookNewsDetailPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsDetailPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsDetailPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x0003B5A1 File Offset: 0x000397A1
		public NoteBookNewsDetailPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x06006DCE RID: 28110 RVA: 0x0020CB60 File Offset: 0x0020AD60
		// (set) Token: 0x06006DCF RID: 28111 RVA: 0x0003B5AA File Offset: 0x000397AA
		public unsafe TextMeshProUGUI m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x06006DD0 RID: 28112 RVA: 0x0020CB90 File Offset: 0x0020AD90
		// (set) Token: 0x06006DD1 RID: 28113 RVA: 0x0003B5C9 File Offset: 0x000397C9
		public unsafe TextMeshProUGUI m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x0020CBC0 File Offset: 0x0020ADC0
		// (set) Token: 0x06006DD3 RID: 28115 RVA: 0x0003B5E8 File Offset: 0x000397E8
		public unsafe TextMeshProUGUI m_Date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Date);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsDetailPannel.NativeFieldInfoPtr_m_Date), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048CE RID: 18638
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x040048CF RID: 18639
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x040048D0 RID: 18640
		private static readonly IntPtr NativeFieldInfoPtr_m_Date;

		// Token: 0x040048D1 RID: 18641
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040048D2 RID: 18642
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_LanguageBase_GameDate_0;

		// Token: 0x040048D3 RID: 18643
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040048D4 RID: 18644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
