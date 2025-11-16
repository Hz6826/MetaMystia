using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000395 RID: 917
	public class NoteBookNewsPanelSelector : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x06006DD4 RID: 28116 RVA: 0x0020CBF0 File Offset: 0x0020ADF0
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookNewsPanelSelector()
		{
			Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookNewsPanelSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr);
			NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_CompactNewsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, "m_CompactNewsPanel");
			NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_ExpandableNewsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, "m_ExpandableNewsPanel");
			NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_CurrentSubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, "m_CurrentSubPanel");
			NoteBookNewsPanelSelector.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, 100685814);
			NoteBookNewsPanelSelector.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, 100685815);
			NoteBookNewsPanelSelector.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, 100685816);
			NoteBookNewsPanelSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr, 100685817);
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x0020CCAC File Offset: 0x0020AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275575, XrefRangeEnd = 275600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPanelSelector.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x0020CCE8 File Offset: 0x0020AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275600, XrefRangeEnd = 275607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPanelSelector.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x0020CD24 File Offset: 0x0020AF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPanelSelector.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x0020CD60 File Offset: 0x0020AF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275607, XrefRangeEnd = 275610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookNewsPanelSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPanelSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPanelSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x0003B607 File Offset: 0x00039807
		public NoteBookNewsPanelSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x06006DDA RID: 28122 RVA: 0x0020CD9C File Offset: 0x0020AF9C
		// (set) Token: 0x06006DDB RID: 28123 RVA: 0x0003B610 File Offset: 0x00039810
		public unsafe NoteBookNewsPannel m_CompactNewsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_CompactNewsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookNewsPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_CompactNewsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x0020CDCC File Offset: 0x0020AFCC
		// (set) Token: 0x06006DDD RID: 28125 RVA: 0x0003B62F File Offset: 0x0003982F
		public unsafe NoteBookNewsPannelExpandable m_ExpandableNewsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_ExpandableNewsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookNewsPannelExpandable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_ExpandableNewsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x0020CDFC File Offset: 0x0020AFFC
		// (set) Token: 0x06006DDF RID: 28127 RVA: 0x0003B64E File Offset: 0x0003984E
		public unsafe UISubPanel<NoteBookMainPannel> m_CurrentSubPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_CurrentSubPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISubPanel<NoteBookMainPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPanelSelector.NativeFieldInfoPtr_m_CurrentSubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048D5 RID: 18645
		private static readonly IntPtr NativeFieldInfoPtr_m_CompactNewsPanel;

		// Token: 0x040048D6 RID: 18646
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandableNewsPanel;

		// Token: 0x040048D7 RID: 18647
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSubPanel;

		// Token: 0x040048D8 RID: 18648
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040048D9 RID: 18649
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x040048DA RID: 18650
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040048DB RID: 18651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
