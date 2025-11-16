using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI
{
	// Token: 0x02000373 RID: 883
	public class IzakayaDetailPanel : UIPanelParamOpen<Izakaya>
	{
		// Token: 0x060068D5 RID: 26837 RVA: 0x001FC480 File Offset: 0x001FA680
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaDetailPanel()
		{
			Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "IzakayaDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr);
			IzakayaDetailPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr, "m_Describer");
			IzakayaDetailPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr, 100685090);
			IzakayaDetailPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr, 100685091);
			IzakayaDetailPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr, 100685092);
			IzakayaDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr, 100685093);
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x001FC514 File Offset: 0x001FA714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268064, XrefRangeEnd = 268078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaDetailPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x001FC550 File Offset: 0x001FA750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268078, XrefRangeEnd = 268080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(Izakaya openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaDetailPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Izakaya_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x001FC5A0 File Offset: 0x001FA7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaDetailPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x001FC5DC File Offset: 0x001FA7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268080, XrefRangeEnd = 268083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00038B09 File Offset: 0x00036D09
		public IzakayaDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x060068DB RID: 26843 RVA: 0x001FC618 File Offset: 0x001FA818
		// (set) Token: 0x060068DC RID: 26844 RVA: 0x00038B12 File Offset: 0x00036D12
		public unsafe DetailedIzakayaDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaDetailPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DetailedIzakayaDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaDetailPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400457F RID: 17791
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x04004580 RID: 17792
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004581 RID: 17793
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Izakaya_0;

		// Token: 0x04004582 RID: 17794
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004583 RID: 17795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
