using System;
using System.Runtime.InteropServices;
using Common.UI.EscapeUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Common.UI
{
	// Token: 0x0200036B RID: 875
	public class BaseSustainedPannel : UIPanelExtern
	{
		// Token: 0x060067C9 RID: 26569 RVA: 0x001F8A38 File Offset: 0x001F6C38
		// Note: this type is marked as 'beforefieldinit'.
		static BaseSustainedPannel()
		{
			Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "BaseSustainedPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr);
			BaseSustainedPannel.NativeFieldInfoPtr_EscapePannelBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "EscapePannelBtn");
			BaseSustainedPannel.NativeFieldInfoPtr_m_CurrentPanelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "m_CurrentPanelParent");
			BaseSustainedPannel.NativeFieldInfoPtr_m_LastPannelCloseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "m_LastPannelCloseHandle");
			BaseSustainedPannel.NativeFieldInfoPtr_m_EnablePlayerOpenAnyPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "m_EnablePlayerOpenAnyPannel");
			BaseSustainedPannel.NativeFieldInfoPtr_OnBasePannelOnTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "OnBasePannelOnTop");
			BaseSustainedPannel.NativeFieldInfoPtr__OnBasePanelProcessedCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "<OnBasePanelProcessedCallback>k__BackingField");
			BaseSustainedPannel.NativeMethodInfoPtr_get_PanelOpenMode_Protected_Virtual_New_get_PanelOpenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684941);
			BaseSustainedPannel.NativeMethodInfoPtr_get_MutePanelOpenAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684942);
			BaseSustainedPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684943);
			BaseSustainedPannel.NativeMethodInfoPtr_add_OnBasePannelOnTop_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684944);
			BaseSustainedPannel.NativeMethodInfoPtr_remove_OnBasePannelOnTop_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684945);
			BaseSustainedPannel.NativeMethodInfoPtr_get_OnBasePanelProcessedCallback_Public_get_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684946);
			BaseSustainedPannel.NativeMethodInfoPtr_set_OnBasePanelProcessedCallback_Public_set_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684947);
			BaseSustainedPannel.NativeMethodInfoPtr_get_EnablePlayerOpenAnyPannel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684948);
			BaseSustainedPannel.NativeMethodInfoPtr_set_EnablePlayerOpenAnyPannel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684949);
			BaseSustainedPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Final_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684950);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684951);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684952);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684953);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684954);
			BaseSustainedPannel.NativeMethodInfoPtr_OnCurrentPanelLayerChanged_Protected_Virtual_Void_IEnumerable_1_UIPanelBaseImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684955);
			BaseSustainedPannel.NativeMethodInfoPtr_CallAndCleanOnTopCallback_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684956);
			BaseSustainedPannel.NativeMethodInfoPtr_TryCloseActivePannel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684957);
			BaseSustainedPannel.NativeMethodInfoPtr_CloseActivePannel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684958);
			BaseSustainedPannel.NativeMethodInfoPtr_PreProcessOpen_Protected_Boolean_T_byref_T_byref_Action_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684959);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684960);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684961);
			BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanelParameterless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684962);
			BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684963);
			BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanelAsync_Public_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684964);
			BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684965);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684966);
			BaseSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684967);
			BaseSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684968);
			BaseSustainedPannel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684969);
			BaseSustainedPannel.NativeMethodInfoPtr__OnPanelInitialize_b__21_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, 100684970);
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x001F8D38 File Offset: 0x001F6F38
		public unsafe virtual AdpUIPanelManager.PanelOpenMode PanelOpenMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_get_PanelOpenMode_Protected_Virtual_New_get_PanelOpenMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x001F8D80 File Offset: 0x001F6F80
		public unsafe override bool MutePanelOpenAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_get_MutePanelOpenAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x001F8DC8 File Offset: 0x001F6FC8
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x001F8E10 File Offset: 0x001F7010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266651, RefRangeEnd = 266652, XrefRangeStart = 266644, XrefRangeEnd = 266651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnBasePannelOnTop(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_add_OnBasePannelOnTop_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x001F8E48 File Offset: 0x001F7048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266652, XrefRangeEnd = 266659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnBasePannelOnTop(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_remove_OnBasePannelOnTop_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x060067CF RID: 26575 RVA: 0x001F8E80 File Offset: 0x001F7080
		// (set) Token: 0x060067D0 RID: 26576 RVA: 0x001F8EC0 File Offset: 0x001F70C0
		public unsafe Action<bool> OnBasePanelProcessedCallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_get_OnBasePanelProcessedCallback_Public_get_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_set_OnBasePanelProcessedCallback_Public_set_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x060067D1 RID: 26577 RVA: 0x001F8F04 File Offset: 0x001F7104
		// (set) Token: 0x060067D2 RID: 26578 RVA: 0x001F8F40 File Offset: 0x001F7140
		public unsafe bool EnablePlayerOpenAnyPannel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157691, RefRangeEnd = 157692, XrefRangeStart = 157691, XrefRangeEnd = 157692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_get_EnablePlayerOpenAnyPannel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 266670, RefRangeEnd = 266691, XrefRangeStart = 266659, XrefRangeEnd = 266670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_set_EnablePlayerOpenAnyPannel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x001F8F80 File Offset: 0x001F7180
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Final_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x001F8FBC File Offset: 0x001F71BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266691, XrefRangeEnd = 266709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x001F8FF0 File Offset: 0x001F71F0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPannelPostInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x001F902C File Offset: 0x001F722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266709, XrefRangeEnd = 266710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x001F9060 File Offset: 0x001F7260
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPrePanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x001F909C File Offset: 0x001F729C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266710, XrefRangeEnd = 266718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCurrentPanelLayerChanged(IEnumerable<UIPanelBaseImpl> currentLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentLayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_OnCurrentPanelLayerChanged_Protected_Virtual_Void_IEnumerable_1_UIPanelBaseImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x001F90EC File Offset: 0x001F72EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266723, RefRangeEnd = 266724, XrefRangeStart = 266718, XrefRangeEnd = 266723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallAndCleanOnTopCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_CallAndCleanOnTopCallback_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x001F9120 File Offset: 0x001F7320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266725, RefRangeEnd = 266727, XrefRangeStart = 266724, XrefRangeEnd = 266725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCloseActivePannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_TryCloseActivePannel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x001F9154 File Offset: 0x001F7354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266735, RefRangeEnd = 266736, XrefRangeStart = 266727, XrefRangeEnd = 266735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseActivePannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_CloseActivePannel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x001F9188 File Offset: 0x001F7388
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 266778, RefRangeEnd = 266791, XrefRangeStart = 266736, XrefRangeEnd = 266778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PreProcessOpen<T>(T parent, out T pannelInstance, ref Action OnPanelCloseCallback, bool alwaysPersistent = false, bool needFreezeTime = true) where T : UIPanelBaseImpl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = parent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref parent;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(T).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref pannelInstance;
			}
			ptr3 = intPtr3;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(OnPanelCloseCallback);
			ptr4 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysPersistent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFreezeTime;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.MethodInfoStoreGeneric_PreProcessOpen_Protected_Boolean_T_byref_T_byref_Action_Boolean_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr7 = intPtr2;
				pannelInstance = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr7, false, false));
			}
			IntPtr intPtr8 = intPtr4;
			OnPanelCloseCallback = ((intPtr8 == 0) ? null : new Action(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x001F92A0 File Offset: 0x001F74A0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPanelWillOpen<T>(T panelParent) where T : UIPanelBaseImpl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.MethodInfoStoreGeneric_OnPanelWillOpen_Protected_Virtual_New_Void_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x001F9324 File Offset: 0x001F7524
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPanelClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x001F9360 File Offset: 0x001F7560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266793, RefRangeEnd = 266795, XrefRangeStart = 266791, XrefRangeEnd = 266793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEscPanelParameterless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanelParameterless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x001F9394 File Offset: 0x001F7594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266797, RefRangeEnd = 266798, XrefRangeStart = 266795, XrefRangeEnd = 266797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEscPanel([Optional] Nullable<EscMainPannel.GoToSpecificType> overrideOpenType, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action onPanelCloseCallback = null, Action afterEscPanelCloseByLoadOrExitCallback = null, bool needFreezeTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterEscPanelCloseByLoadOrExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFreezeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x001F9428 File Offset: 0x001F7628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266799, RefRangeEnd = 266800, XrefRangeStart = 266798, XrefRangeEnd = 266799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenEscPanelAsync([Optional] Nullable<EscMainPannel.GoToSpecificType> overrideOpenType, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action onPanelCloseCallback = null, Action afterEscPanelCloseByLoadOrExitCallback = null, bool needFreezeTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterEscPanelCloseByLoadOrExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFreezeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanelAsync_Public_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x001F94C4 File Offset: 0x001F76C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 266807, RefRangeEnd = 266810, XrefRangeStart = 266800, XrefRangeEnd = 266807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenEscPanelAsyncInternal([Optional] Nullable<EscMainPannel.GoToSpecificType> overrideOpenType, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action onPanelCloseCallback = null, Action afterEscPanelCloseByLoadOrExitCallback = null, bool needFreezeTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterEscPanelCloseByLoadOrExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFreezeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OpenEscPanelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x001F9560 File Offset: 0x001F7760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266810, XrefRangeEnd = 266821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x001F9594 File Offset: 0x001F7794
		[CallerCount(0)]
		public unsafe virtual void OnPannelPostOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x001F95D0 File Offset: 0x001F77D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 266826, RefRangeEnd = 266829, XrefRangeStart = 266821, XrefRangeEnd = 266826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x001F960C File Offset: 0x001F780C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSustainedPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x001F9648 File Offset: 0x001F7848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266829, XrefRangeEnd = 266834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__21_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.NativeMethodInfoPtr__OnPanelInitialize_b__21_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x0003827F File Offset: 0x0003647F
		public BaseSustainedPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x001F967C File Offset: 0x001F787C
		// (set) Token: 0x060067EA RID: 26602 RVA: 0x00038288 File Offset: 0x00036488
		public unsafe UIButtonSimple EscapePannelBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_EscapePannelBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_EscapePannelBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x001F96AC File Offset: 0x001F78AC
		// (set) Token: 0x060067EC RID: 26604 RVA: 0x000382A7 File Offset: 0x000364A7
		public unsafe UIPanelBaseImpl m_CurrentPanelParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_m_CurrentPanelParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanelBaseImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_m_CurrentPanelParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x001F96DC File Offset: 0x001F78DC
		// (set) Token: 0x060067EE RID: 26606 RVA: 0x000382C6 File Offset: 0x000364C6
		public unsafe Action m_LastPannelCloseHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_m_LastPannelCloseHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_m_LastPannelCloseHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x001F970C File Offset: 0x001F790C
		// (set) Token: 0x060067F0 RID: 26608 RVA: 0x000382E5 File Offset: 0x000364E5
		public unsafe bool m_EnablePlayerOpenAnyPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_m_EnablePlayerOpenAnyPannel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr_m_EnablePlayerOpenAnyPannel)) = value;
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x001F9734 File Offset: 0x001F7934
		// (set) Token: 0x060067F2 RID: 26610 RVA: 0x00038300 File Offset: 0x00036500
		public unsafe static Action OnBasePannelOnTop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSustainedPannel.NativeFieldInfoPtr_OnBasePannelOnTop, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSustainedPannel.NativeFieldInfoPtr_OnBasePannelOnTop, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x060067F3 RID: 26611 RVA: 0x001F975C File Offset: 0x001F795C
		// (set) Token: 0x060067F4 RID: 26612 RVA: 0x00038312 File Offset: 0x00036512
		public unsafe Action<bool> _OnBasePanelProcessedCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr__OnBasePanelProcessedCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.NativeFieldInfoPtr__OnBasePanelProcessedCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044CB RID: 17611
		private static readonly IntPtr NativeFieldInfoPtr_EscapePannelBtn;

		// Token: 0x040044CC RID: 17612
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPanelParent;

		// Token: 0x040044CD RID: 17613
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPannelCloseHandle;

		// Token: 0x040044CE RID: 17614
		private static readonly IntPtr NativeFieldInfoPtr_m_EnablePlayerOpenAnyPannel;

		// Token: 0x040044CF RID: 17615
		private static readonly IntPtr NativeFieldInfoPtr_OnBasePannelOnTop;

		// Token: 0x040044D0 RID: 17616
		private static readonly IntPtr NativeFieldInfoPtr__OnBasePanelProcessedCallback_k__BackingField;

		// Token: 0x040044D1 RID: 17617
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelOpenMode_Protected_Virtual_New_get_PanelOpenMode_0;

		// Token: 0x040044D2 RID: 17618
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelOpenAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040044D3 RID: 17619
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040044D4 RID: 17620
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBasePannelOnTop_Public_Static_add_Void_Action_0;

		// Token: 0x040044D5 RID: 17621
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBasePannelOnTop_Public_Static_rem_Void_Action_0;

		// Token: 0x040044D6 RID: 17622
		private static readonly IntPtr NativeMethodInfoPtr_get_OnBasePanelProcessedCallback_Public_get_Action_1_Boolean_0;

		// Token: 0x040044D7 RID: 17623
		private static readonly IntPtr NativeMethodInfoPtr_set_OnBasePanelProcessedCallback_Public_set_Void_Action_1_Boolean_0;

		// Token: 0x040044D8 RID: 17624
		private static readonly IntPtr NativeMethodInfoPtr_get_EnablePlayerOpenAnyPannel_Public_get_Boolean_0;

		// Token: 0x040044D9 RID: 17625
		private static readonly IntPtr NativeMethodInfoPtr_set_EnablePlayerOpenAnyPannel_Public_set_Void_Boolean_0;

		// Token: 0x040044DA RID: 17626
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Final_Single_0;

		// Token: 0x040044DB RID: 17627
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0;

		// Token: 0x040044DC RID: 17628
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_New_Void_0;

		// Token: 0x040044DD RID: 17629
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Final_Void_0;

		// Token: 0x040044DE RID: 17630
		private static readonly IntPtr NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_New_Void_0;

		// Token: 0x040044DF RID: 17631
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentPanelLayerChanged_Protected_Virtual_Void_IEnumerable_1_UIPanelBaseImpl_0;

		// Token: 0x040044E0 RID: 17632
		private static readonly IntPtr NativeMethodInfoPtr_CallAndCleanOnTopCallback_Protected_Void_0;

		// Token: 0x040044E1 RID: 17633
		private static readonly IntPtr NativeMethodInfoPtr_TryCloseActivePannel_Public_Void_0;

		// Token: 0x040044E2 RID: 17634
		private static readonly IntPtr NativeMethodInfoPtr_CloseActivePannel_Public_Void_0;

		// Token: 0x040044E3 RID: 17635
		private static readonly IntPtr NativeMethodInfoPtr_PreProcessOpen_Protected_Boolean_T_byref_T_byref_Action_Boolean_Boolean_0;

		// Token: 0x040044E4 RID: 17636
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_New_Void_T_0;

		// Token: 0x040044E5 RID: 17637
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_New_Void_0;

		// Token: 0x040044E6 RID: 17638
		private static readonly IntPtr NativeMethodInfoPtr_OpenEscPanelParameterless_Public_Void_0;

		// Token: 0x040044E7 RID: 17639
		private static readonly IntPtr NativeMethodInfoPtr_OpenEscPanel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0;

		// Token: 0x040044E8 RID: 17640
		private static readonly IntPtr NativeMethodInfoPtr_OpenEscPanelAsync_Public_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0;

		// Token: 0x040044E9 RID: 17641
		private static readonly IntPtr NativeMethodInfoPtr_OpenEscPanelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_Action_Boolean_0;

		// Token: 0x040044EA RID: 17642
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_0;

		// Token: 0x040044EB RID: 17643
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostOpen_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040044EC RID: 17644
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040044ED RID: 17645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040044EE RID: 17646
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_0_Private_Void_0;

		// Token: 0x02000E6B RID: 3691
		[ObfuscatedName("Common.UI.BaseSustainedPannel+<>c__DisplayClass29_0`1")]
		public sealed class __c__DisplayClass29_0<T> : Object where T : UIPanelBaseImpl
		{
			// Token: 0x060106F4 RID: 67316 RVA: 0x003D0D40 File Offset: 0x003CEF40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "<>c__DisplayClass29_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr);
				BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr, "<>4__this");
				BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_needFreezeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr, "needFreezeTime");
				BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr, 100684971);
				BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr, 100684972);
			}

			// Token: 0x060106F5 RID: 67317 RVA: 0x003D0DF8 File Offset: 0x003CEFF8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSustainedPannel.__c__DisplayClass29_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106F6 RID: 67318 RVA: 0x003D0E34 File Offset: 0x003CF034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266587, XrefRangeEnd = 266593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106F7 RID: 67319 RVA: 0x0008F5CF File Offset: 0x0008D7CF
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055D9 RID: 21977
			// (get) Token: 0x060106F8 RID: 67320 RVA: 0x003D0E68 File Offset: 0x003CF068
			// (set) Token: 0x060106F9 RID: 67321 RVA: 0x0008F5D8 File Offset: 0x0008D7D8
			public unsafe BaseSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055DA RID: 21978
			// (get) Token: 0x060106FA RID: 67322 RVA: 0x003D0E98 File Offset: 0x003CF098
			// (set) Token: 0x060106FB RID: 67323 RVA: 0x0008F5F7 File Offset: 0x0008D7F7
			public unsafe bool needFreezeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_needFreezeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_needFreezeTime)) = value;
				}
			}

			// Token: 0x0400A679 RID: 42617
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A67A RID: 42618
			private static readonly IntPtr NativeFieldInfoPtr_needFreezeTime;

			// Token: 0x0400A67B RID: 42619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A67C RID: 42620
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000E6C RID: 3692
		[ObfuscatedName("Common.UI.BaseSustainedPannel+<OpenEscPanelAsyncInternal>d__35")]
		public sealed class _OpenEscPanelAsyncInternal_d__35 : ValueType
		{
			// Token: 0x060106FC RID: 67324 RVA: 0x003D0EC0 File Offset: 0x003CF0C0
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenEscPanelAsyncInternal_d__35()
			{
				Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr, "<OpenEscPanelAsyncInternal>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr);
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "<>1__state");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "<>t__builder");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "<>4__this");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_onPanelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "onPanelCloseCallback");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_needFreezeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "needFreezeTime");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_overrideOpenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "overrideOpenType");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_afterEscPanelCloseByLoadOrExitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "afterEscPanelCloseByLoadOrExitCallback");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_overrideOpenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "overrideOpenMode");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, "<>u__1");
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, 100684973);
				BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr, 100684974);
			}

			// Token: 0x060106FD RID: 67325 RVA: 0x003D0FC8 File Offset: 0x003CF1C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 266642, RefRangeEnd = 266644, XrefRangeStart = 266593, XrefRangeEnd = 266642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106FE RID: 67326 RVA: 0x003D1000 File Offset: 0x003CF200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106FF RID: 67327 RVA: 0x0008F612 File Offset: 0x0008D812
			public _OpenEscPanelAsyncInternal_d__35(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010700 RID: 67328 RVA: 0x0008F61B File Offset: 0x0008D81B
			public _OpenEscPanelAsyncInternal_d__35() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x170055DB RID: 21979
			// (get) Token: 0x06010701 RID: 67329 RVA: 0x003D1048 File Offset: 0x003CF248
			// (set) Token: 0x06010702 RID: 67330 RVA: 0x0008F62D File Offset: 0x0008D82D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170055DC RID: 21980
			// (get) Token: 0x06010703 RID: 67331 RVA: 0x003D1070 File Offset: 0x003CF270
			// (set) Token: 0x06010704 RID: 67332 RVA: 0x0008F648 File Offset: 0x0008D848
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170055DD RID: 21981
			// (get) Token: 0x06010705 RID: 67333 RVA: 0x003D10A0 File Offset: 0x003CF2A0
			// (set) Token: 0x06010706 RID: 67334 RVA: 0x0008F676 File Offset: 0x0008D876
			public unsafe BaseSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055DE RID: 21982
			// (get) Token: 0x06010707 RID: 67335 RVA: 0x003D10D0 File Offset: 0x003CF2D0
			// (set) Token: 0x06010708 RID: 67336 RVA: 0x0008F695 File Offset: 0x0008D895
			public unsafe Action onPanelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_onPanelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_onPanelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055DF RID: 21983
			// (get) Token: 0x06010709 RID: 67337 RVA: 0x003D1100 File Offset: 0x003CF300
			// (set) Token: 0x0601070A RID: 67338 RVA: 0x0008F6B4 File Offset: 0x0008D8B4
			public unsafe bool needFreezeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_needFreezeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_needFreezeTime)) = value;
				}
			}

			// Token: 0x170055E0 RID: 21984
			// (get) Token: 0x0601070B RID: 67339 RVA: 0x003D1128 File Offset: 0x003CF328
			// (set) Token: 0x0601070C RID: 67340 RVA: 0x0008F6CF File Offset: 0x0008D8CF
			public Nullable<EscMainPannel.GoToSpecificType> overrideOpenType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_overrideOpenType);
					return new Nullable<EscMainPannel.GoToSpecificType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<EscMainPannel.GoToSpecificType>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_overrideOpenType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<EscMainPannel.GoToSpecificType>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170055E1 RID: 21985
			// (get) Token: 0x0601070D RID: 67341 RVA: 0x003D1158 File Offset: 0x003CF358
			// (set) Token: 0x0601070E RID: 67342 RVA: 0x0008F6FD File Offset: 0x0008D8FD
			public unsafe Action afterEscPanelCloseByLoadOrExitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_afterEscPanelCloseByLoadOrExitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_afterEscPanelCloseByLoadOrExitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055E2 RID: 21986
			// (get) Token: 0x0601070F RID: 67343 RVA: 0x003D1188 File Offset: 0x003CF388
			// (set) Token: 0x06010710 RID: 67344 RVA: 0x0008F71C File Offset: 0x0008D91C
			public Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_overrideOpenMode);
					return new Nullable<AdpUIPanelManager.PanelOpenMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AdpUIPanelManager.PanelOpenMode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr_overrideOpenMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AdpUIPanelManager.PanelOpenMode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170055E3 RID: 21987
			// (get) Token: 0x06010711 RID: 67345 RVA: 0x003D11B8 File Offset: 0x003CF3B8
			// (set) Token: 0x06010712 RID: 67346 RVA: 0x0008F74A File Offset: 0x0008D94A
			public UniTask<EscMainPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___u__1);
					return new UniTask<EscMainPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<EscMainPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSustainedPannel._OpenEscPanelAsyncInternal_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<EscMainPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A67D RID: 42621
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A67E RID: 42622
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A67F RID: 42623
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A680 RID: 42624
			private static readonly IntPtr NativeFieldInfoPtr_onPanelCloseCallback;

			// Token: 0x0400A681 RID: 42625
			private static readonly IntPtr NativeFieldInfoPtr_needFreezeTime;

			// Token: 0x0400A682 RID: 42626
			private static readonly IntPtr NativeFieldInfoPtr_overrideOpenType;

			// Token: 0x0400A683 RID: 42627
			private static readonly IntPtr NativeFieldInfoPtr_afterEscPanelCloseByLoadOrExitCallback;

			// Token: 0x0400A684 RID: 42628
			private static readonly IntPtr NativeFieldInfoPtr_overrideOpenMode;

			// Token: 0x0400A685 RID: 42629
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A686 RID: 42630
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A687 RID: 42631
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E6D RID: 3693
		private sealed class MethodInfoStoreGeneric_PreProcessOpen_Protected_Boolean_T_byref_T_byref_Action_Boolean_Boolean_0<T>
		{
			// Token: 0x0400A688 RID: 42632
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseSustainedPannel.NativeMethodInfoPtr_PreProcessOpen_Protected_Boolean_T_byref_T_byref_Action_Boolean_Boolean_0, Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E6E RID: 3694
		private sealed class MethodInfoStoreGeneric_OnPanelWillOpen_Protected_Virtual_New_Void_T_0<T>
		{
			// Token: 0x0400A689 RID: 42633
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseSustainedPannel.NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_New_Void_T_0, Il2CppClassPointerStore<BaseSustainedPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
