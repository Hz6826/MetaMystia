using System;
using Common.UI;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace NightScene.UI
{
	// Token: 0x020001B7 RID: 439
	public class WorkSceneDailyDisplayerPannel : UISubPanel<BaseSustainedPannel>
	{
		// Token: 0x06003611 RID: 13841 RVA: 0x00158550 File Offset: 0x00156750
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneDailyDisplayerPannel()
		{
			Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI", "WorkSceneDailyDisplayerPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr);
			WorkSceneDailyDisplayerPannel.NativeFieldInfoPtr_m_Printer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, "m_Printer");
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673569);
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673570);
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673571);
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673572);
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673573);
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673574);
			WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr, 100673575);
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00158620 File Offset: 0x00156820
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0015865C File Offset: 0x0015685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127114, XrefRangeEnd = 127133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00158698 File Offset: 0x00156898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127133, XrefRangeEnd = 127138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x001586D4 File Offset: 0x001568D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00158710 File Offset: 0x00156910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127138, XrefRangeEnd = 127141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneDailyDisplayerPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneDailyDisplayerPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0015874C File Offset: 0x0015694C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127141, XrefRangeEnd = 127144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00158780 File Offset: 0x00156980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127144, XrefRangeEnd = 127145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationToken _OnPanelInitialize_b__2_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneDailyDisplayerPannel.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CancellationToken(pointer);
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x0001E0B7 File Offset: 0x0001C2B7
		public WorkSceneDailyDisplayerPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x001587B8 File Offset: 0x001569B8
		// (set) Token: 0x0600361B RID: 13851 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		public unsafe DailyRecipePrinterNew m_Printer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneDailyDisplayerPannel.NativeFieldInfoPtr_m_Printer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneDailyDisplayerPannel.NativeFieldInfoPtr_m_Printer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeFieldInfoPtr_m_Printer;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_CancellationToken_0;
	}
}
