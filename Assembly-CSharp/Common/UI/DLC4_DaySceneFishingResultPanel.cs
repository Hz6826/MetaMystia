using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.PanelCollection.Async;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000370 RID: 880
	public class DLC4_DaySceneFishingResultPanel : AsyncUIPanel
	{
		// Token: 0x06006881 RID: 26753 RVA: 0x001FB474 File Offset: 0x001F9674
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_DaySceneFishingResultPanel()
		{
			Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DLC4_DaySceneFishingResultPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr);
			DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, "m_Animator");
			DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, "m_Describer");
			DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_canClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, "canClose");
			DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr__TrophyResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, "<TrophyResult>k__BackingField");
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_get_TrophyResult_Private_get_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685056);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_set_TrophyResult_Public_set_Void_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685057);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685058);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685059);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_TryClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685060);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685061);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685062);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685063);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685064);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685065);
			DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, 100685066);
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x06006882 RID: 26754 RVA: 0x001FB5D0 File Offset: 0x001F97D0
		// (set) Token: 0x06006883 RID: 26755 RVA: 0x001FB610 File Offset: 0x001F9810
		public unsafe ObjectLanguageBase TrophyResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_get_TrophyResult_Private_get_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_set_TrophyResult_Public_set_Void_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x001FB654 File Offset: 0x001F9854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267815, XrefRangeEnd = 267840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x001FB690 File Offset: 0x001F9890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267840, XrefRangeEnd = 267845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x001FB6D8 File Offset: 0x001F98D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267845, XrefRangeEnd = 267846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_TryClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x001FB70C File Offset: 0x001F990C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267846, XrefRangeEnd = 267849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x001FB748 File Offset: 0x001F9948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267849, XrefRangeEnd = 267853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001FB784 File Offset: 0x001F9984
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_DaySceneFishingResultPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x001FB7C0 File Offset: 0x001F99C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x001FB808 File Offset: 0x001F9A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_1(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x001FB850 File Offset: 0x001F9A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_2(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x000387DD File Offset: 0x000369DD
		public DLC4_DaySceneFishingResultPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x0600688E RID: 26766 RVA: 0x001FB898 File Offset: 0x001F9A98
		// (set) Token: 0x0600688F RID: 26767 RVA: 0x000387E6 File Offset: 0x000369E6
		public unsafe Animator m_Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_m_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x06006890 RID: 26768 RVA: 0x001FB8C8 File Offset: 0x001F9AC8
		// (set) Token: 0x06006891 RID: 26769 RVA: 0x00038805 File Offset: 0x00036A05
		public unsafe ObjectLanguageBaseDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBaseDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x06006892 RID: 26770 RVA: 0x001FB8F8 File Offset: 0x001F9AF8
		// (set) Token: 0x06006893 RID: 26771 RVA: 0x00038824 File Offset: 0x00036A24
		public unsafe bool canClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_canClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr_canClose)) = value;
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x06006894 RID: 26772 RVA: 0x001FB920 File Offset: 0x001F9B20
		// (set) Token: 0x06006895 RID: 26773 RVA: 0x0003883F File Offset: 0x00036A3F
		public unsafe ObjectLanguageBase _TrophyResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr__TrophyResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel.NativeFieldInfoPtr__TrophyResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400454B RID: 17739
		private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

		// Token: 0x0400454C RID: 17740
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x0400454D RID: 17741
		private static readonly IntPtr NativeFieldInfoPtr_canClose;

		// Token: 0x0400454E RID: 17742
		private static readonly IntPtr NativeFieldInfoPtr__TrophyResult_k__BackingField;

		// Token: 0x0400454F RID: 17743
		private static readonly IntPtr NativeMethodInfoPtr_get_TrophyResult_Private_get_ObjectLanguageBase_0;

		// Token: 0x04004550 RID: 17744
		private static readonly IntPtr NativeMethodInfoPtr_set_TrophyResult_Public_set_Void_ObjectLanguageBase_0;

		// Token: 0x04004551 RID: 17745
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004552 RID: 17746
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0;

		// Token: 0x04004553 RID: 17747
		private static readonly IntPtr NativeMethodInfoPtr_TryClose_Private_Void_0;

		// Token: 0x04004554 RID: 17748
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004555 RID: 17749
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004556 RID: 17750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004557 RID: 17751
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_CallbackContext_0;

		// Token: 0x04004558 RID: 17752
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_CallbackContext_0;

		// Token: 0x04004559 RID: 17753
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Private_Void_CallbackContext_0;

		// Token: 0x02000E7C RID: 3708
		[ObfuscatedName("Common.UI.DLC4_DaySceneFishingResultPanel+<OnPanelOpenAsync>d__8")]
		public sealed class _OnPanelOpenAsync_d__8 : ValueType
		{
			// Token: 0x0601077A RID: 67450 RVA: 0x003D23E8 File Offset: 0x003D05E8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__8()
			{
				Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel>.NativeClassPtr, "<OnPanelOpenAsync>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr);
				DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr, "<>1__state");
				DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr, "<>t__builder");
				DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr, "<>4__this");
				DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr, "<>u__1");
				DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr, 100685067);
				DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr, 100685068);
			}

			// Token: 0x0601077B RID: 67451 RVA: 0x003D248C File Offset: 0x003D068C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 267813, RefRangeEnd = 267815, XrefRangeStart = 267805, XrefRangeEnd = 267813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601077C RID: 67452 RVA: 0x003D24C4 File Offset: 0x003D06C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601077D RID: 67453 RVA: 0x0008FAD0 File Offset: 0x0008DCD0
			public _OnPanelOpenAsync_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601077E RID: 67454 RVA: 0x0008FAD9 File Offset: 0x0008DCD9
			public _OnPanelOpenAsync_d__8() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170055FD RID: 22013
			// (get) Token: 0x0601077F RID: 67455 RVA: 0x003D250C File Offset: 0x003D070C
			// (set) Token: 0x06010780 RID: 67456 RVA: 0x0008FAEB File Offset: 0x0008DCEB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170055FE RID: 22014
			// (get) Token: 0x06010781 RID: 67457 RVA: 0x003D2534 File Offset: 0x003D0734
			// (set) Token: 0x06010782 RID: 67458 RVA: 0x0008FB06 File Offset: 0x0008DD06
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170055FF RID: 22015
			// (get) Token: 0x06010783 RID: 67459 RVA: 0x003D2564 File Offset: 0x003D0764
			// (set) Token: 0x06010784 RID: 67460 RVA: 0x0008FB34 File Offset: 0x0008DD34
			public unsafe DLC4_DaySceneFishingResultPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_DaySceneFishingResultPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005600 RID: 22016
			// (get) Token: 0x06010785 RID: 67461 RVA: 0x003D2594 File Offset: 0x003D0794
			// (set) Token: 0x06010786 RID: 67462 RVA: 0x0008FB53 File Offset: 0x0008DD53
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_DaySceneFishingResultPanel._OnPanelOpenAsync_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6C1 RID: 42689
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A6C2 RID: 42690
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A6C3 RID: 42691
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6C4 RID: 42692
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A6C5 RID: 42693
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A6C6 RID: 42694
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
