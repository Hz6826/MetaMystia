using System;
using Common.UI;
using Common.UI.EscapeUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000121 RID: 289
	public class DLC5_RogueLikeSaveLoadPanel : UIPanelParam<DLC5_RogueLikeSaveLoadPanel.OpenContext, Nullable<int>>
	{
		// Token: 0x06002143 RID: 8515 RVA: 0x0010C9F0 File Offset: 0x0010ABF0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeSaveLoadPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeSaveLoadPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr);
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_Grid");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_Element");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_ProgressIndicatorComponent");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ConfirmPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_ConfirmPanel");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ConfirmSubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_ConfirmSubPanel");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_MessagePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_MessagePanel");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncingIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_SyncingIndicator");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncFailedIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_SyncFailedIndicator");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncFailedIndicatorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_SyncFailedIndicatorDuration");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_Group");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_List");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_MaxRounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_MaxRounds");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_MAX_SAVE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "MAX_SAVE_COUNT");
			DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_OnLoadCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "m_OnLoadCallback");
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669220);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669221);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_RefreshSaveList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669222);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_OnEnabledInternal_Private_Void_KeyValuePair_2_Int32_LoadedRogueLikeSaveDataInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669223);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_TryOpenSubConfirmPanel_Private_UniTask_Nullable_1_Int32_String_Nullable_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669224);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_TryClosePanel_Private_UniTask_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669225);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_CannotLoadAsync_Private_UniTask_IReadOnlyList_1_String_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669226);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_SetActiveAsync_Private_UniTask_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669227);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_SetInActiveAsync_Private_UniTask_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669228);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669229);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669230);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr__OnPanelInitialize_b__12_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669231);
			DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr__OnPanelInitialize_b__12_2_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, 100669232);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0010CC3C File Offset: 0x0010AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81456, XrefRangeEnd = 81503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0010CC70 File Offset: 0x0010AE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81503, XrefRangeEnd = 81511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikeSaveLoadPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0010CCB8 File Offset: 0x0010AEB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81573, RefRangeEnd = 81574, XrefRangeStart = 81511, XrefRangeEnd = 81573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSaveList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_RefreshSaveList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0010CCEC File Offset: 0x0010AEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81574, XrefRangeEnd = 81736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnabledInternal(KeyValuePair<int, LoadedRogueLikeSaveDataInfo> valuePair, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(valuePair));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_OnEnabledInternal_Private_Void_KeyValuePair_2_Int32_LoadedRogueLikeSaveDataInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0010CD58 File Offset: 0x0010AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81736, XrefRangeEnd = 81743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask TryOpenSubConfirmPanel(Nullable<int> index, string langKey, Nullable<Vector3> position, bool invalidSaveFile = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(index));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(langKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(position));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invalidSaveFile;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_TryOpenSubConfirmPanel_Private_UniTask_Nullable_1_Int32_String_Nullable_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0010CDDC File Offset: 0x0010AFDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81749, RefRangeEnd = 81751, XrefRangeStart = 81743, XrefRangeEnd = 81749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask TryClosePanel(Nullable<int> index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(index));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_TryClosePanel_Private_UniTask_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x0010CE2C File Offset: 0x0010B02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81751, XrefRangeEnd = 81759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask CannotLoadAsync(IReadOnlyList<string> activeArray, IReadOnlyList<string> inSaveArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeArray);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inSaveArray);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_CannotLoadAsync_Private_UniTask_IReadOnlyList_1_String_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0010CE88 File Offset: 0x0010B088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81771, RefRangeEnd = 81773, XrefRangeStart = 81759, XrefRangeEnd = 81771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SetActiveAsync(CanvasGroup canvasGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_SetActiveAsync_Private_UniTask_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0010CED0 File Offset: 0x0010B0D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81779, RefRangeEnd = 81781, XrefRangeStart = 81773, XrefRangeEnd = 81779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SetInActiveAsync(CanvasGroup canvasGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_SetInActiveAsync_Private_UniTask_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0010CF18 File Offset: 0x0010B118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81781, XrefRangeEnd = 81795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0010CF54 File Offset: 0x0010B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81795, XrefRangeEnd = 81806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeSaveLoadPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0010CF90 File Offset: 0x0010B190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81806, XrefRangeEnd = 81817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__12_1(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr__OnPanelInitialize_b__12_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0010CFD8 File Offset: 0x0010B1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81817, XrefRangeEnd = 81822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid _OnPanelInitialize_b__12_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.NativeMethodInfoPtr__OnPanelInitialize_b__12_2_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00014476 File Offset: 0x00012676
		public DLC5_RogueLikeSaveLoadPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x0010D014 File Offset: 0x0010B214
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x0001447F File Offset: 0x0001267F
		public unsafe GridLayoutGroup m_Grid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Grid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Grid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x0010D044 File Offset: 0x0010B244
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x0001449E File Offset: 0x0001269E
		public unsafe UIElementCluster m_Element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x0010D074 File Offset: 0x0010B274
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x000144BD File Offset: 0x000126BD
		public unsafe AdpProgressIndicatorComponent m_ProgressIndicatorComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ProgressIndicatorComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x0010D0A4 File Offset: 0x0010B2A4
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x000144DC File Offset: 0x000126DC
		public unsafe EscLoadPannelSubPannel m_ConfirmPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ConfirmPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ConfirmPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x0010D0D4 File Offset: 0x0010B2D4
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x000144FB File Offset: 0x000126FB
		public unsafe EscLoadPannelSubSubPannel m_ConfirmSubPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ConfirmSubPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_ConfirmSubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0010D104 File Offset: 0x0010B304
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x0001451A File Offset: 0x0001271A
		public unsafe DialogBoxPannel m_MessagePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_MessagePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_MessagePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0010D134 File Offset: 0x0010B334
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x00014539 File Offset: 0x00012739
		public unsafe CanvasGroup m_SyncingIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncingIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncingIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0010D164 File Offset: 0x0010B364
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00014558 File Offset: 0x00012758
		public unsafe CanvasGroup m_SyncFailedIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncFailedIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncFailedIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x0010D194 File Offset: 0x0010B394
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x00014577 File Offset: 0x00012777
		public unsafe float m_SyncFailedIndicatorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncFailedIndicatorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_SyncFailedIndicatorDuration)) = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x0010D1BC File Offset: 0x0010B3BC
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x00014592 File Offset: 0x00012792
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>, UIElementCluster, UIButtonSimple> m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0010D1EC File Offset: 0x0010B3EC
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x000145B1 File Offset: 0x000127B1
		public unsafe List<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0010D21C File Offset: 0x0010B41C
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x000145D0 File Offset: 0x000127D0
		public unsafe int m_MaxRounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_MaxRounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_MaxRounds)) = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x0010D244 File Offset: 0x0010B444
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x000145EB File Offset: 0x000127EB
		public unsafe static int MAX_SAVE_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_MAX_SAVE_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_MAX_SAVE_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x0010D260 File Offset: 0x0010B460
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x000145F9 File Offset: 0x000127F9
		public unsafe Func<UniTask> m_OnLoadCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_OnLoadCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniTask>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.NativeFieldInfoPtr_m_OnLoadCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_m_Grid;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr_m_Element;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressIndicatorComponent;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmPanel;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmSubPanel;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr_m_MessagePanel;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncingIndicator;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncFailedIndicator;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncFailedIndicatorDuration;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxRounds;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SAVE_COUNT;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr_m_OnLoadCallback;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_OpenContext_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSaveList_Private_Void_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabledInternal_Private_Void_KeyValuePair_2_Int32_LoadedRogueLikeSaveDataInfo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenSubConfirmPanel_Private_UniTask_Nullable_1_Int32_String_Nullable_1_Vector3_Boolean_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_TryClosePanel_Private_UniTask_Nullable_1_Int32_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_CannotLoadAsync_Private_UniTask_IReadOnlyList_1_String_IReadOnlyList_1_String_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveAsync_Private_UniTask_CanvasGroup_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr_SetInActiveAsync_Private_UniTask_CanvasGroup_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_1_Private_Void_CallbackContext_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_2_Private_UniTaskVoid_0;

		// Token: 0x0200072A RID: 1834
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06009D99 RID: 40345 RVA: 0x0029CCC4 File Offset: 0x0029AEC4
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_MaxRounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "MaxRounds");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_CreateNewKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "CreateNewKey");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_GiveUpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "GiveUpKey");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_OverrideKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "OverrideKey");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_AppendNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "AppendNull");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_IgnoreInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "IgnoreInvalid");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_SaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "SaveData");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_ActiveDeleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, "ActiveDeleteButton");
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeMethodInfoPtr_CreateSave_Public_Static_OpenContext_Int32_RogueLikeSaveData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, 100669233);
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeMethodInfoPtr_CreateLoad_Public_Static_OpenContext_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, 100669234);
				DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_String_String_Boolean_Boolean_Nullable_1_RogueLikeSaveData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr, 100669235);
			}

			// Token: 0x06009D9A RID: 40346 RVA: 0x0029CDCC File Offset: 0x0029AFCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80997, RefRangeEnd = 80998, XrefRangeStart = 80982, XrefRangeEnd = 80997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DLC5_RogueLikeSaveLoadPanel.OpenContext CreateSave(int maxRounds, RogueLikeSaveData rogueLikeSaveData, bool activeDeleteButton)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref maxRounds;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rogueLikeSaveData));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeDeleteButton;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeMethodInfoPtr_CreateSave_Public_Static_OpenContext_Int32_RogueLikeSaveData_Boolean_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC5_RogueLikeSaveLoadPanel.OpenContext(pointer);
			}

			// Token: 0x06009D9B RID: 40347 RVA: 0x0029CE2C File Offset: 0x0029B02C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 81006, RefRangeEnd = 81007, XrefRangeStart = 80998, XrefRangeEnd = 81006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DLC5_RogueLikeSaveLoadPanel.OpenContext CreateLoad(int maxRounds, bool activeDeleteButton)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref maxRounds;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeDeleteButton;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeMethodInfoPtr_CreateLoad_Public_Static_OpenContext_Int32_Boolean_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC5_RogueLikeSaveLoadPanel.OpenContext(pointer);
			}

			// Token: 0x06009D9C RID: 40348 RVA: 0x0029CE74 File Offset: 0x0029B074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81007, XrefRangeEnd = 81011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(int maxRounds, string createNewKey, string giveUpKey, string overrideKey, bool appendNull, bool ignoreInvalid, Nullable<RogueLikeSaveData> saveData, bool activeDeleteButton) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref maxRounds;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(createNewKey);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(giveUpKey);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideKey);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendNull;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreInvalid;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(saveData));
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeDeleteButton;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_String_String_Boolean_Boolean_Nullable_1_RogueLikeSaveData_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D9D RID: 40349 RVA: 0x00054E2A File Offset: 0x0005302A
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009D9E RID: 40350 RVA: 0x00054E33 File Offset: 0x00053033
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003415 RID: 13333
			// (get) Token: 0x06009D9F RID: 40351 RVA: 0x0029CF3C File Offset: 0x0029B13C
			// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x00054E45 File Offset: 0x00053045
			public unsafe int MaxRounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_MaxRounds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_MaxRounds)) = value;
				}
			}

			// Token: 0x17003416 RID: 13334
			// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x0029CF64 File Offset: 0x0029B164
			// (set) Token: 0x06009DA2 RID: 40354 RVA: 0x00054E60 File Offset: 0x00053060
			public unsafe string CreateNewKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_CreateNewKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_CreateNewKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003417 RID: 13335
			// (get) Token: 0x06009DA3 RID: 40355 RVA: 0x0029CF8C File Offset: 0x0029B18C
			// (set) Token: 0x06009DA4 RID: 40356 RVA: 0x00054E7F File Offset: 0x0005307F
			public unsafe string GiveUpKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_GiveUpKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_GiveUpKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003418 RID: 13336
			// (get) Token: 0x06009DA5 RID: 40357 RVA: 0x0029CFB4 File Offset: 0x0029B1B4
			// (set) Token: 0x06009DA6 RID: 40358 RVA: 0x00054E9E File Offset: 0x0005309E
			public unsafe string OverrideKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_OverrideKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_OverrideKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003419 RID: 13337
			// (get) Token: 0x06009DA7 RID: 40359 RVA: 0x0029CFDC File Offset: 0x0029B1DC
			// (set) Token: 0x06009DA8 RID: 40360 RVA: 0x00054EBD File Offset: 0x000530BD
			public unsafe bool AppendNull
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_AppendNull);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_AppendNull)) = value;
				}
			}

			// Token: 0x1700341A RID: 13338
			// (get) Token: 0x06009DA9 RID: 40361 RVA: 0x0029D004 File Offset: 0x0029B204
			// (set) Token: 0x06009DAA RID: 40362 RVA: 0x00054ED8 File Offset: 0x000530D8
			public unsafe bool IgnoreInvalid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_IgnoreInvalid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_IgnoreInvalid)) = value;
				}
			}

			// Token: 0x1700341B RID: 13339
			// (get) Token: 0x06009DAB RID: 40363 RVA: 0x0029D02C File Offset: 0x0029B22C
			// (set) Token: 0x06009DAC RID: 40364 RVA: 0x00054EF3 File Offset: 0x000530F3
			public Nullable<RogueLikeSaveData> SaveData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_SaveData);
					return new Nullable<RogueLikeSaveData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RogueLikeSaveData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_SaveData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RogueLikeSaveData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700341C RID: 13340
			// (get) Token: 0x06009DAD RID: 40365 RVA: 0x0029D05C File Offset: 0x0029B25C
			// (set) Token: 0x06009DAE RID: 40366 RVA: 0x00054F21 File Offset: 0x00053121
			public unsafe bool ActiveDeleteButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_ActiveDeleteButton);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.OpenContext.NativeFieldInfoPtr_ActiveDeleteButton)) = value;
				}
			}

			// Token: 0x0400666B RID: 26219
			private static readonly IntPtr NativeFieldInfoPtr_MaxRounds;

			// Token: 0x0400666C RID: 26220
			private static readonly IntPtr NativeFieldInfoPtr_CreateNewKey;

			// Token: 0x0400666D RID: 26221
			private static readonly IntPtr NativeFieldInfoPtr_GiveUpKey;

			// Token: 0x0400666E RID: 26222
			private static readonly IntPtr NativeFieldInfoPtr_OverrideKey;

			// Token: 0x0400666F RID: 26223
			private static readonly IntPtr NativeFieldInfoPtr_AppendNull;

			// Token: 0x04006670 RID: 26224
			private static readonly IntPtr NativeFieldInfoPtr_IgnoreInvalid;

			// Token: 0x04006671 RID: 26225
			private static readonly IntPtr NativeFieldInfoPtr_SaveData;

			// Token: 0x04006672 RID: 26226
			private static readonly IntPtr NativeFieldInfoPtr_ActiveDeleteButton;

			// Token: 0x04006673 RID: 26227
			private static readonly IntPtr NativeMethodInfoPtr_CreateSave_Public_Static_OpenContext_Int32_RogueLikeSaveData_Boolean_0;

			// Token: 0x04006674 RID: 26228
			private static readonly IntPtr NativeMethodInfoPtr_CreateLoad_Public_Static_OpenContext_Int32_Boolean_0;

			// Token: 0x04006675 RID: 26229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_String_String_String_Boolean_Boolean_Nullable_1_RogueLikeSaveData_Boolean_0;
		}

		// Token: 0x0200072B RID: 1835
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009DAF RID: 40367 RVA: 0x0029D084 File Offset: 0x0029B284
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, "<>9__12_0");
				DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, "<>9__17_7");
				DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__17_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, "<>9__17_8");
				DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, 100669237);
				DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Internal_Void_KeyValuePair_2_Int32_LoadedRogueLikeSaveDataInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, 100669238);
				DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__OnEnabledInternal_b__17_7_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, 100669239);
				DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__OnEnabledInternal_b__17_8_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr, 100669240);
			}

			// Token: 0x06009DB0 RID: 40368 RVA: 0x0029D150 File Offset: 0x0029B350
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DB1 RID: 40369 RVA: 0x0029D18C File Offset: 0x0029B38C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__12_0(KeyValuePair<int, LoadedRogueLikeSaveDataInfo> _, UIElementCluster _, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Internal_Void_KeyValuePair_2_Int32_LoadedRogueLikeSaveDataInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DB2 RID: 40370 RVA: 0x0029D1F8 File Offset: 0x0029B3F8
			[CallerCount(0)]
			public unsafe string _OnEnabledInternal_b__17_7(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__OnEnabledInternal_b__17_7_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009DB3 RID: 40371 RVA: 0x0029D240 File Offset: 0x0029B440
			[CallerCount(0)]
			public unsafe string _OnEnabledInternal_b__17_8(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c.NativeMethodInfoPtr__OnEnabledInternal_b__17_8_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009DB4 RID: 40372 RVA: 0x00054F3C File Offset: 0x0005313C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700341D RID: 13341
			// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x0029D288 File Offset: 0x0029B488
			// (set) Token: 0x06009DB6 RID: 40374 RVA: 0x00054F45 File Offset: 0x00053145
			public unsafe static DLC5_RogueLikeSaveLoadPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341E RID: 13342
			// (get) Token: 0x06009DB7 RID: 40375 RVA: 0x0029D2B0 File Offset: 0x0029B4B0
			// (set) Token: 0x06009DB8 RID: 40376 RVA: 0x00054F57 File Offset: 0x00053157
			public unsafe static Action<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>, UIElementCluster, UIButtonSimple> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341F RID: 13343
			// (get) Token: 0x06009DB9 RID: 40377 RVA: 0x0029D2D8 File Offset: 0x0029B4D8
			// (set) Token: 0x06009DBA RID: 40378 RVA: 0x00054F69 File Offset: 0x00053169
			public unsafe static Func<string, string> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003420 RID: 13344
			// (get) Token: 0x06009DBB RID: 40379 RVA: 0x0029D300 File Offset: 0x0029B500
			// (set) Token: 0x06009DBC RID: 40380 RVA: 0x00054F7B File Offset: 0x0005317B
			public unsafe static Func<string, string> __9__17_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__17_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSaveLoadPanel.__c.NativeFieldInfoPtr___9__17_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006676 RID: 26230
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006677 RID: 26231
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04006678 RID: 26232
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x04006679 RID: 26233
			private static readonly IntPtr NativeFieldInfoPtr___9__17_8;

			// Token: 0x0400667A RID: 26234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400667B RID: 26235
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Internal_Void_KeyValuePair_2_Int32_LoadedRogueLikeSaveDataInfo_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400667C RID: 26236
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__17_7_Internal_String_String_0;

			// Token: 0x0400667D RID: 26237
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__17_8_Internal_String_String_0;
		}

		// Token: 0x0200072C RID: 1836
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x06009DBD RID: 40381 RVA: 0x0029D328 File Offset: 0x0029B528
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr, "key");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr, "button");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr, 100669241);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnEnabledInternal_b__0_Internal_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr, 100669242);
			}

			// Token: 0x06009DBE RID: 40382 RVA: 0x0029D3B8 File Offset: 0x0029B5B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DBF RID: 40383 RVA: 0x0029D3F4 File Offset: 0x0029B5F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81018, XrefRangeEnd = 81023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTaskVoid _OnEnabledInternal_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnEnabledInternal_b__0_Internal_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009DC0 RID: 40384 RVA: 0x00054F8D File Offset: 0x0005318D
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003421 RID: 13345
			// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x0029D430 File Offset: 0x0029B630
			// (set) Token: 0x06009DC2 RID: 40386 RVA: 0x00054F96 File Offset: 0x00053196
			public unsafe DLC5_RogueLikeSaveLoadPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003422 RID: 13346
			// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x0029D460 File Offset: 0x0029B660
			// (set) Token: 0x06009DC4 RID: 40388 RVA: 0x00054FB5 File Offset: 0x000531B5
			public unsafe int key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_key);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_key)) = value;
				}
			}

			// Token: 0x17003423 RID: 13347
			// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x0029D488 File Offset: 0x0029B688
			// (set) Token: 0x06009DC6 RID: 40390 RVA: 0x00054FD0 File Offset: 0x000531D0
			public unsafe UIButtonSimple button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400667E RID: 26238
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400667F RID: 26239
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04006680 RID: 26240
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04006681 RID: 26241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006682 RID: 26242
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__0_Internal_UniTaskVoid_0;

			// Token: 0x02000FD6 RID: 4054
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass17_0+<<OnEnabledInternal>b__0>d")]
			public sealed class __OnEnabledInternal_b__0_d : ValueType
			{
				// Token: 0x060116B7 RID: 71351 RVA: 0x00400F34 File Offset: 0x003FF134
				// Note: this type is marked as 'beforefieldinit'.
				static __OnEnabledInternal_b__0_d()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>.NativeClassPtr, "<<OnEnabledInternal>b__0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr);
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr, "<>t__builder");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr, "<>u__1");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr, 100669243);
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr, 100669244);
				}

				// Token: 0x060116B8 RID: 71352 RVA: 0x00400FD8 File Offset: 0x003FF1D8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 81016, RefRangeEnd = 81018, XrefRangeStart = 81011, XrefRangeEnd = 81016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116B9 RID: 71353 RVA: 0x00401010 File Offset: 0x003FF210
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116BA RID: 71354 RVA: 0x0009780A File Offset: 0x00095A0A
				public __OnEnabledInternal_b__0_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060116BB RID: 71355 RVA: 0x00097813 File Offset: 0x00095A13
				public __OnEnabledInternal_b__0_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A8A RID: 23178
				// (get) Token: 0x060116BC RID: 71356 RVA: 0x00401058 File Offset: 0x003FF258
				// (set) Token: 0x060116BD RID: 71357 RVA: 0x00097825 File Offset: 0x00095A25
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A8B RID: 23179
				// (get) Token: 0x060116BE RID: 71358 RVA: 0x00401080 File Offset: 0x003FF280
				// (set) Token: 0x060116BF RID: 71359 RVA: 0x00097840 File Offset: 0x00095A40
				public AsyncUniTaskVoidMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A8C RID: 23180
				// (get) Token: 0x060116C0 RID: 71360 RVA: 0x004010B0 File Offset: 0x003FF2B0
				// (set) Token: 0x060116C1 RID: 71361 RVA: 0x0009786E File Offset: 0x00095A6E
				public unsafe DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A8D RID: 23181
				// (get) Token: 0x060116C2 RID: 71362 RVA: 0x004010E0 File Offset: 0x003FF2E0
				// (set) Token: 0x060116C3 RID: 71363 RVA: 0x0009788D File Offset: 0x00095A8D
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0.__OnEnabledInternal_b__0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B004 RID: 45060
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B005 RID: 45061
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B006 RID: 45062
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B007 RID: 45063
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B008 RID: 45064
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B009 RID: 45065
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x0200072D RID: 1837
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Il2CppSystem.Object
		{
			// Token: 0x06009DC7 RID: 40391 RVA: 0x0029D4B8 File Offset: 0x0029B6B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeFieldInfoPtr_saveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, "saveFile");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669245);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669246);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669247);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669248);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669249);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669250);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__6_Internal_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, 100669251);
			}

			// Token: 0x06009DC8 RID: 40392 RVA: 0x0029D598 File Offset: 0x0029B798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DC9 RID: 40393 RVA: 0x0029D5D4 File Offset: 0x0029B7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81047, XrefRangeEnd = 81057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnabledInternal_b__1(TextMeshProUGUI text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DCA RID: 40394 RVA: 0x0029D618 File Offset: 0x0029B818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81057, XrefRangeEnd = 81067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnabledInternal_b__2(TextMeshProUGUI text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DCB RID: 40395 RVA: 0x0029D65C File Offset: 0x0029B85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81067, XrefRangeEnd = 81077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnabledInternal_b__3(TextMeshProUGUI text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DCC RID: 40396 RVA: 0x0029D6A0 File Offset: 0x0029B8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81077, XrefRangeEnd = 81087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnabledInternal_b__4(TextMeshProUGUI text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DCD RID: 40397 RVA: 0x0029D6E4 File Offset: 0x0029B8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81087, XrefRangeEnd = 81097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnabledInternal_b__5(TextMeshProUGUI text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DCE RID: 40398 RVA: 0x0029D728 File Offset: 0x0029B928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81097, XrefRangeEnd = 81102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTaskVoid _OnEnabledInternal_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnEnabledInternal_b__6_Internal_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009DCF RID: 40399 RVA: 0x00054FEF File Offset: 0x000531EF
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003424 RID: 13348
			// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x0029D764 File Offset: 0x0029B964
			// (set) Token: 0x06009DD1 RID: 40401 RVA: 0x00054FF8 File Offset: 0x000531F8
			public RogueLikeSaveData saveFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeFieldInfoPtr_saveFile);
					return new RogueLikeSaveData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeFieldInfoPtr_saveFile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003425 RID: 13349
			// (get) Token: 0x06009DD2 RID: 40402 RVA: 0x0029D794 File Offset: 0x0029B994
			// (set) Token: 0x06009DD3 RID: 40403 RVA: 0x00055026 File Offset: 0x00053226
			public unsafe DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006683 RID: 26243
			private static readonly IntPtr NativeFieldInfoPtr_saveFile;

			// Token: 0x04006684 RID: 26244
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x04006685 RID: 26245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006686 RID: 26246
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006687 RID: 26247
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006688 RID: 26248
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006689 RID: 26249
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400668A RID: 26250
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400668B RID: 26251
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__6_Internal_UniTaskVoid_0;

			// Token: 0x02000FD7 RID: 4055
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass17_1+<<OnEnabledInternal>b__6>d")]
			public sealed class __OnEnabledInternal_b__6_d : ValueType
			{
				// Token: 0x060116C4 RID: 71364 RVA: 0x00401110 File Offset: 0x003FF310
				// Note: this type is marked as 'beforefieldinit'.
				static __OnEnabledInternal_b__6_d()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>.NativeClassPtr, "<<OnEnabledInternal>b__6>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr);
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr, "<>t__builder");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr, "<>u__1");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr, 100669252);
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr, 100669253);
				}

				// Token: 0x060116C5 RID: 71365 RVA: 0x004011B4 File Offset: 0x003FF3B4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 81045, RefRangeEnd = 81047, XrefRangeStart = 81023, XrefRangeEnd = 81045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116C6 RID: 71366 RVA: 0x004011EC File Offset: 0x003FF3EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116C7 RID: 71367 RVA: 0x000978BB File Offset: 0x00095ABB
				public __OnEnabledInternal_b__6_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060116C8 RID: 71368 RVA: 0x000978C4 File Offset: 0x00095AC4
				public __OnEnabledInternal_b__6_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A8E RID: 23182
				// (get) Token: 0x060116C9 RID: 71369 RVA: 0x00401234 File Offset: 0x003FF434
				// (set) Token: 0x060116CA RID: 71370 RVA: 0x000978D6 File Offset: 0x00095AD6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A8F RID: 23183
				// (get) Token: 0x060116CB RID: 71371 RVA: 0x0040125C File Offset: 0x003FF45C
				// (set) Token: 0x060116CC RID: 71372 RVA: 0x000978F1 File Offset: 0x00095AF1
				public AsyncUniTaskVoidMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A90 RID: 23184
				// (get) Token: 0x060116CD RID: 71373 RVA: 0x0040128C File Offset: 0x003FF48C
				// (set) Token: 0x060116CE RID: 71374 RVA: 0x0009791F File Offset: 0x00095B1F
				public unsafe DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A91 RID: 23185
				// (get) Token: 0x060116CF RID: 71375 RVA: 0x004012BC File Offset: 0x003FF4BC
				// (set) Token: 0x060116D0 RID: 71376 RVA: 0x0009793E File Offset: 0x00095B3E
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1.__OnEnabledInternal_b__6_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B00A RID: 45066
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B00B RID: 45067
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B00C RID: 45068
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B00D RID: 45069
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B00E RID: 45070
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B00F RID: 45071
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x0200072E RID: 1838
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass17_2")]
		public sealed class __c__DisplayClass17_2 : Il2CppSystem.Object
		{
			// Token: 0x06009DD4 RID: 40404 RVA: 0x0029D7C4 File Offset: 0x0029B9C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c__DisplayClass17_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_activeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr, "activeArray");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_inSaveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr, "inSaveArray");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_field_Public___c__DisplayClass17_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr, "CS$<>8__locals2");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr, 100669254);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeMethodInfoPtr__OnEnabledInternal_b__9_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr, 100669255);
			}

			// Token: 0x06009DD5 RID: 40405 RVA: 0x0029D854 File Offset: 0x0029BA54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DD6 RID: 40406 RVA: 0x0029D890 File Offset: 0x0029BA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81102, XrefRangeEnd = 81110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _OnEnabledInternal_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeMethodInfoPtr__OnEnabledInternal_b__9_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06009DD7 RID: 40407 RVA: 0x00055045 File Offset: 0x00053245
			public __c__DisplayClass17_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003426 RID: 13350
			// (get) Token: 0x06009DD8 RID: 40408 RVA: 0x0029D8C8 File Offset: 0x0029BAC8
			// (set) Token: 0x06009DD9 RID: 40409 RVA: 0x0005504E File Offset: 0x0005324E
			public unsafe Il2CppStringArray activeArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_activeArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_activeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003427 RID: 13351
			// (get) Token: 0x06009DDA RID: 40410 RVA: 0x0029D8F8 File Offset: 0x0029BAF8
			// (set) Token: 0x06009DDB RID: 40411 RVA: 0x0005506D File Offset: 0x0005326D
			public unsafe Il2CppStringArray inSaveArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_inSaveArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_inSaveArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003428 RID: 13352
			// (get) Token: 0x06009DDC RID: 40412 RVA: 0x0029D928 File Offset: 0x0029BB28
			// (set) Token: 0x06009DDD RID: 40413 RVA: 0x0005508C File Offset: 0x0005328C
			public unsafe DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1 field_Public___c__DisplayClass17_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_field_Public___c__DisplayClass17_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass17_2.NativeFieldInfoPtr_field_Public___c__DisplayClass17_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400668C RID: 26252
			private static readonly IntPtr NativeFieldInfoPtr_activeArray;

			// Token: 0x0400668D RID: 26253
			private static readonly IntPtr NativeFieldInfoPtr_inSaveArray;

			// Token: 0x0400668E RID: 26254
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_1_0;

			// Token: 0x0400668F RID: 26255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006690 RID: 26256
			private static readonly IntPtr NativeMethodInfoPtr__OnEnabledInternal_b__9_Internal_UniTask_0;
		}

		// Token: 0x0200072F RID: 1839
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<TryOpenSubConfirmPanel>d__19")]
		public sealed class _TryOpenSubConfirmPanel_d__19 : ValueType
		{
			// Token: 0x06009DDE RID: 40414 RVA: 0x0029D958 File Offset: 0x0029BB58
			// Note: this type is marked as 'beforefieldinit'.
			static _TryOpenSubConfirmPanel_d__19()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<TryOpenSubConfirmPanel>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "index");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "position");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_langKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "langKey");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_invalidSaveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "invalidSaveFile");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr__instance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<instance>5__2");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<>u__2");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr__instance_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<instance>5__3");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, "<>u__3");
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, 100669256);
				DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr, 100669257);
			}

			// Token: 0x06009DDF RID: 40415 RVA: 0x0029DA9C File Offset: 0x0029BC9C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 81186, RefRangeEnd = 81189, XrefRangeStart = 81110, XrefRangeEnd = 81186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DE0 RID: 40416 RVA: 0x0029DAD4 File Offset: 0x0029BCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DE1 RID: 40417 RVA: 0x000550AB File Offset: 0x000532AB
			public _TryOpenSubConfirmPanel_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009DE2 RID: 40418 RVA: 0x000550B4 File Offset: 0x000532B4
			public _TryOpenSubConfirmPanel_d__19() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x17003429 RID: 13353
			// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x0029DB1C File Offset: 0x0029BD1C
			// (set) Token: 0x06009DE4 RID: 40420 RVA: 0x000550C6 File Offset: 0x000532C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700342A RID: 13354
			// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x0029DB44 File Offset: 0x0029BD44
			// (set) Token: 0x06009DE6 RID: 40422 RVA: 0x000550E1 File Offset: 0x000532E1
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700342B RID: 13355
			// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x0029DB74 File Offset: 0x0029BD74
			// (set) Token: 0x06009DE8 RID: 40424 RVA: 0x0005510F File Offset: 0x0005330F
			public unsafe DLC5_RogueLikeSaveLoadPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342C RID: 13356
			// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x0029DBA4 File Offset: 0x0029BDA4
			// (set) Token: 0x06009DEA RID: 40426 RVA: 0x0005512E File Offset: 0x0005332E
			public Nullable<int> index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_index);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_index), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700342D RID: 13357
			// (get) Token: 0x06009DEB RID: 40427 RVA: 0x0029DBD4 File Offset: 0x0029BDD4
			// (set) Token: 0x06009DEC RID: 40428 RVA: 0x0005515C File Offset: 0x0005335C
			public Nullable<Vector3> position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_position);
					return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_position), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700342E RID: 13358
			// (get) Token: 0x06009DED RID: 40429 RVA: 0x0029DC04 File Offset: 0x0029BE04
			// (set) Token: 0x06009DEE RID: 40430 RVA: 0x0005518A File Offset: 0x0005338A
			public unsafe string langKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_langKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_langKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700342F RID: 13359
			// (get) Token: 0x06009DEF RID: 40431 RVA: 0x0029DC2C File Offset: 0x0029BE2C
			// (set) Token: 0x06009DF0 RID: 40432 RVA: 0x000551A9 File Offset: 0x000533A9
			public unsafe bool invalidSaveFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_invalidSaveFile);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr_invalidSaveFile)) = value;
				}
			}

			// Token: 0x17003430 RID: 13360
			// (get) Token: 0x06009DF1 RID: 40433 RVA: 0x0029DC54 File Offset: 0x0029BE54
			// (set) Token: 0x06009DF2 RID: 40434 RVA: 0x000551C4 File Offset: 0x000533C4
			public unsafe EscLoadPannelSubPannel _instance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr__instance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr__instance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003431 RID: 13361
			// (get) Token: 0x06009DF3 RID: 40435 RVA: 0x0029DC84 File Offset: 0x0029BE84
			// (set) Token: 0x06009DF4 RID: 40436 RVA: 0x000551E3 File Offset: 0x000533E3
			public UniTask<EscLoadPannelSubPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__1);
					return new UniTask<EscLoadPannelSubPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<EscLoadPannelSubPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<EscLoadPannelSubPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003432 RID: 13362
			// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x0029DCB4 File Offset: 0x0029BEB4
			// (set) Token: 0x06009DF6 RID: 40438 RVA: 0x00055211 File Offset: 0x00053411
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003433 RID: 13363
			// (get) Token: 0x06009DF7 RID: 40439 RVA: 0x0029DCE4 File Offset: 0x0029BEE4
			// (set) Token: 0x06009DF8 RID: 40440 RVA: 0x0005523F File Offset: 0x0005343F
			public unsafe EscLoadPannelSubSubPannel _instance_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr__instance_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr__instance_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003434 RID: 13364
			// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x0029DD14 File Offset: 0x0029BF14
			// (set) Token: 0x06009DFA RID: 40442 RVA: 0x0005525E File Offset: 0x0005345E
			public UniTask<EscLoadPannelSubSubPannel>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__3);
					return new UniTask<EscLoadPannelSubSubPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<EscLoadPannelSubSubPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryOpenSubConfirmPanel_d__19.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<EscLoadPannelSubSubPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006691 RID: 26257
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006692 RID: 26258
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006693 RID: 26259
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006694 RID: 26260
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04006695 RID: 26261
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04006696 RID: 26262
			private static readonly IntPtr NativeFieldInfoPtr_langKey;

			// Token: 0x04006697 RID: 26263
			private static readonly IntPtr NativeFieldInfoPtr_invalidSaveFile;

			// Token: 0x04006698 RID: 26264
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__2;

			// Token: 0x04006699 RID: 26265
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400669A RID: 26266
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400669B RID: 26267
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__3;

			// Token: 0x0400669C RID: 26268
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400669D RID: 26269
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400669E RID: 26270
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000730 RID: 1840
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06009DFB RID: 40443 RVA: 0x0029DD44 File Offset: 0x0029BF44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr, "index");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr, "exception");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr, 100669258);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__TryClosePanel_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr, 100669259);
			}

			// Token: 0x06009DFC RID: 40444 RVA: 0x0029DDD4 File Offset: 0x0029BFD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009DFD RID: 40445 RVA: 0x0029DE10 File Offset: 0x0029C010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81351, XrefRangeEnd = 81357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _TryClosePanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__TryClosePanel_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06009DFE RID: 40446 RVA: 0x0005528C File Offset: 0x0005348C
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003435 RID: 13365
			// (get) Token: 0x06009DFF RID: 40447 RVA: 0x0029DE48 File Offset: 0x0029C048
			// (set) Token: 0x06009E00 RID: 40448 RVA: 0x00055295 File Offset: 0x00053495
			public unsafe DLC5_RogueLikeSaveLoadPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003436 RID: 13366
			// (get) Token: 0x06009E01 RID: 40449 RVA: 0x0029DE78 File Offset: 0x0029C078
			// (set) Token: 0x06009E02 RID: 40450 RVA: 0x000552B4 File Offset: 0x000534B4
			public Nullable<int> index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_index);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_index), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003437 RID: 13367
			// (get) Token: 0x06009E03 RID: 40451 RVA: 0x0029DEA8 File Offset: 0x0029C0A8
			// (set) Token: 0x06009E04 RID: 40452 RVA: 0x000552E2 File Offset: 0x000534E2
			public unsafe Exception exception
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_exception);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400669F RID: 26271
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066A0 RID: 26272
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040066A1 RID: 26273
			private static readonly IntPtr NativeFieldInfoPtr_exception;

			// Token: 0x040066A2 RID: 26274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066A3 RID: 26275
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__0_Internal_UniTask_0;

			// Token: 0x02000FD8 RID: 4056
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass20_0+<<TryClosePanel>b__0>d")]
			public sealed class __TryClosePanel_b__0_d : ValueType
			{
				// Token: 0x060116D1 RID: 71377 RVA: 0x004012EC File Offset: 0x003FF4EC
				// Note: this type is marked as 'beforefieldinit'.
				static __TryClosePanel_b__0_d()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>.NativeClassPtr, "<<TryClosePanel>b__0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr);
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<>t__builder");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__filePath_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<filePath>5__2");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__fileContent_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<fileContent>5__3");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<>u__1");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__syncResult_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<syncResult>5__4");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<>u__2");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, "<>u__3");
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, 100669260);
					DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr, 100669261);
				}

				// Token: 0x060116D2 RID: 71378 RVA: 0x004013F4 File Offset: 0x003FF5F4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 81349, RefRangeEnd = 81351, XrefRangeStart = 81189, XrefRangeEnd = 81349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116D3 RID: 71379 RVA: 0x0040142C File Offset: 0x003FF62C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116D4 RID: 71380 RVA: 0x0009796C File Offset: 0x00095B6C
				public __TryClosePanel_b__0_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060116D5 RID: 71381 RVA: 0x00097975 File Offset: 0x00095B75
				public __TryClosePanel_b__0_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A92 RID: 23186
				// (get) Token: 0x060116D6 RID: 71382 RVA: 0x00401474 File Offset: 0x003FF674
				// (set) Token: 0x060116D7 RID: 71383 RVA: 0x00097987 File Offset: 0x00095B87
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A93 RID: 23187
				// (get) Token: 0x060116D8 RID: 71384 RVA: 0x0040149C File Offset: 0x003FF69C
				// (set) Token: 0x060116D9 RID: 71385 RVA: 0x000979A2 File Offset: 0x00095BA2
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A94 RID: 23188
				// (get) Token: 0x060116DA RID: 71386 RVA: 0x004014CC File Offset: 0x003FF6CC
				// (set) Token: 0x060116DB RID: 71387 RVA: 0x000979D0 File Offset: 0x00095BD0
				public unsafe DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A95 RID: 23189
				// (get) Token: 0x060116DC RID: 71388 RVA: 0x004014FC File Offset: 0x003FF6FC
				// (set) Token: 0x060116DD RID: 71389 RVA: 0x000979EF File Offset: 0x00095BEF
				public unsafe string _filePath_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__filePath_5__2);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__filePath_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17005A96 RID: 23190
				// (get) Token: 0x060116DE RID: 71390 RVA: 0x00401524 File Offset: 0x003FF724
				// (set) Token: 0x060116DF RID: 71391 RVA: 0x00097A0E File Offset: 0x00095C0E
				public unsafe string _fileContent_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__fileContent_5__3);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__fileContent_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17005A97 RID: 23191
				// (get) Token: 0x060116E0 RID: 71392 RVA: 0x0040154C File Offset: 0x003FF74C
				// (set) Token: 0x060116E1 RID: 71393 RVA: 0x00097A2D File Offset: 0x00095C2D
				public UniTask<ValueTuple<string, string, Exception>>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__1);
						return new UniTask<ValueTuple<string, string, Exception>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ValueTuple<string, string, Exception>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ValueTuple<string, string, Exception>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A98 RID: 23192
				// (get) Token: 0x060116E2 RID: 71394 RVA: 0x0040157C File Offset: 0x003FF77C
				// (set) Token: 0x060116E3 RID: 71395 RVA: 0x00097A5B File Offset: 0x00095C5B
				public unsafe bool _syncResult_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__syncResult_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr__syncResult_5__4)) = value;
					}
				}

				// Token: 0x17005A99 RID: 23193
				// (get) Token: 0x060116E4 RID: 71396 RVA: 0x004015A4 File Offset: 0x003FF7A4
				// (set) Token: 0x060116E5 RID: 71397 RVA: 0x00097A76 File Offset: 0x00095C76
				public UniTask.Awaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__2);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A9A RID: 23194
				// (get) Token: 0x060116E6 RID: 71398 RVA: 0x004015D4 File Offset: 0x003FF7D4
				// (set) Token: 0x060116E7 RID: 71399 RVA: 0x00097AA4 File Offset: 0x00095CA4
				public UniTask<bool>.Awaiter __u__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__3);
						return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0.__TryClosePanel_b__0_d.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B010 RID: 45072
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B011 RID: 45073
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B012 RID: 45074
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B013 RID: 45075
				private static readonly IntPtr NativeFieldInfoPtr__filePath_5__2;

				// Token: 0x0400B014 RID: 45076
				private static readonly IntPtr NativeFieldInfoPtr__fileContent_5__3;

				// Token: 0x0400B015 RID: 45077
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B016 RID: 45078
				private static readonly IntPtr NativeFieldInfoPtr__syncResult_5__4;

				// Token: 0x0400B017 RID: 45079
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x0400B018 RID: 45080
				private static readonly IntPtr NativeFieldInfoPtr___u__3;

				// Token: 0x0400B019 RID: 45081
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B01A RID: 45082
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000731 RID: 1841
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<TryClosePanel>d__20")]
		public sealed class _TryClosePanel_d__20 : ValueType
		{
			// Token: 0x06009E05 RID: 40453 RVA: 0x0029DED8 File Offset: 0x0029C0D8
			// Note: this type is marked as 'beforefieldinit'.
			static _TryClosePanel_d__20()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<TryClosePanel>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, "index");
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, 100669262);
				DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr, 100669263);
			}

			// Token: 0x06009E06 RID: 40454 RVA: 0x0029DFA4 File Offset: 0x0029C1A4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 81411, RefRangeEnd = 81414, XrefRangeStart = 81357, XrefRangeEnd = 81411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E07 RID: 40455 RVA: 0x0029DFDC File Offset: 0x0029C1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E08 RID: 40456 RVA: 0x00055301 File Offset: 0x00053501
			public _TryClosePanel_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E09 RID: 40457 RVA: 0x0005530A File Offset: 0x0005350A
			public _TryClosePanel_d__20() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17003438 RID: 13368
			// (get) Token: 0x06009E0A RID: 40458 RVA: 0x0029E024 File Offset: 0x0029C224
			// (set) Token: 0x06009E0B RID: 40459 RVA: 0x0005531C File Offset: 0x0005351C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003439 RID: 13369
			// (get) Token: 0x06009E0C RID: 40460 RVA: 0x0029E04C File Offset: 0x0029C24C
			// (set) Token: 0x06009E0D RID: 40461 RVA: 0x00055337 File Offset: 0x00053537
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700343A RID: 13370
			// (get) Token: 0x06009E0E RID: 40462 RVA: 0x0029E07C File Offset: 0x0029C27C
			// (set) Token: 0x06009E0F RID: 40463 RVA: 0x00055365 File Offset: 0x00053565
			public unsafe DLC5_RogueLikeSaveLoadPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700343B RID: 13371
			// (get) Token: 0x06009E10 RID: 40464 RVA: 0x0029E0AC File Offset: 0x0029C2AC
			// (set) Token: 0x06009E11 RID: 40465 RVA: 0x00055384 File Offset: 0x00053584
			public Nullable<int> index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr_index);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr_index), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700343C RID: 13372
			// (get) Token: 0x06009E12 RID: 40466 RVA: 0x0029E0DC File Offset: 0x0029C2DC
			// (set) Token: 0x06009E13 RID: 40467 RVA: 0x000553B2 File Offset: 0x000535B2
			public unsafe DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass20_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700343D RID: 13373
			// (get) Token: 0x06009E14 RID: 40468 RVA: 0x0029E10C File Offset: 0x0029C30C
			// (set) Token: 0x06009E15 RID: 40469 RVA: 0x000553D1 File Offset: 0x000535D1
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._TryClosePanel_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040066A4 RID: 26276
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040066A5 RID: 26277
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040066A6 RID: 26278
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066A7 RID: 26279
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040066A8 RID: 26280
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040066A9 RID: 26281
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040066AA RID: 26282
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040066AB RID: 26283
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000732 RID: 1842
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<CannotLoadAsync>d__21")]
		public sealed class _CannotLoadAsync_d__21 : ValueType
		{
			// Token: 0x06009E16 RID: 40470 RVA: 0x0029E13C File Offset: 0x0029C33C
			// Note: this type is marked as 'beforefieldinit'.
			static _CannotLoadAsync_d__21()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<CannotLoadAsync>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr_activeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, "activeArray");
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr_inSaveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, "inSaveArray");
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, 100669264);
				DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr, 100669265);
			}

			// Token: 0x06009E17 RID: 40471 RVA: 0x0029E208 File Offset: 0x0029C408
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 81431, RefRangeEnd = 81435, XrefRangeStart = 81414, XrefRangeEnd = 81431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E18 RID: 40472 RVA: 0x0029E240 File Offset: 0x0029C440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E19 RID: 40473 RVA: 0x000553FF File Offset: 0x000535FF
			public _CannotLoadAsync_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E1A RID: 40474 RVA: 0x00055408 File Offset: 0x00053608
			public _CannotLoadAsync_d__21() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x1700343E RID: 13374
			// (get) Token: 0x06009E1B RID: 40475 RVA: 0x0029E288 File Offset: 0x0029C488
			// (set) Token: 0x06009E1C RID: 40476 RVA: 0x0005541A File Offset: 0x0005361A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700343F RID: 13375
			// (get) Token: 0x06009E1D RID: 40477 RVA: 0x0029E2B0 File Offset: 0x0029C4B0
			// (set) Token: 0x06009E1E RID: 40478 RVA: 0x00055435 File Offset: 0x00053635
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003440 RID: 13376
			// (get) Token: 0x06009E1F RID: 40479 RVA: 0x0029E2E0 File Offset: 0x0029C4E0
			// (set) Token: 0x06009E20 RID: 40480 RVA: 0x00055463 File Offset: 0x00053663
			public unsafe DLC5_RogueLikeSaveLoadPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003441 RID: 13377
			// (get) Token: 0x06009E21 RID: 40481 RVA: 0x0029E310 File Offset: 0x0029C510
			// (set) Token: 0x06009E22 RID: 40482 RVA: 0x00055482 File Offset: 0x00053682
			public unsafe IReadOnlyList<string> activeArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr_activeArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr_activeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003442 RID: 13378
			// (get) Token: 0x06009E23 RID: 40483 RVA: 0x0029E340 File Offset: 0x0029C540
			// (set) Token: 0x06009E24 RID: 40484 RVA: 0x000554A1 File Offset: 0x000536A1
			public unsafe IReadOnlyList<string> inSaveArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr_inSaveArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr_inSaveArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003443 RID: 13379
			// (get) Token: 0x06009E25 RID: 40485 RVA: 0x0029E370 File Offset: 0x0029C570
			// (set) Token: 0x06009E26 RID: 40486 RVA: 0x000554C0 File Offset: 0x000536C0
			public UniTask<DialogBoxPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___u__1);
					return new UniTask<DialogBoxPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DialogBoxPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._CannotLoadAsync_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DialogBoxPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040066AC RID: 26284
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040066AD RID: 26285
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040066AE RID: 26286
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066AF RID: 26287
			private static readonly IntPtr NativeFieldInfoPtr_activeArray;

			// Token: 0x040066B0 RID: 26288
			private static readonly IntPtr NativeFieldInfoPtr_inSaveArray;

			// Token: 0x040066B1 RID: 26289
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040066B2 RID: 26290
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040066B3 RID: 26291
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000733 RID: 1843
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x06009E27 RID: 40487 RVA: 0x0029E3A0 File Offset: 0x0029C5A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0>.NativeClassPtr, "canvasGroup");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0>.NativeClassPtr, 100669266);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeMethodInfoPtr__SetActiveAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0>.NativeClassPtr, 100669267);
			}

			// Token: 0x06009E28 RID: 40488 RVA: 0x0029E408 File Offset: 0x0029C608
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E29 RID: 40489 RVA: 0x0029E444 File Offset: 0x0029C644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetActiveAsync_b__0(Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeMethodInfoPtr__SetActiveAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E2A RID: 40490 RVA: 0x000554EE File Offset: 0x000536EE
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003444 RID: 13380
			// (get) Token: 0x06009E2B RID: 40491 RVA: 0x0029E488 File Offset: 0x0029C688
			// (set) Token: 0x06009E2C RID: 40492 RVA: 0x000554F7 File Offset: 0x000536F7
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass22_0.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066B4 RID: 26292
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x040066B5 RID: 26293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066B6 RID: 26294
			private static readonly IntPtr NativeMethodInfoPtr__SetActiveAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x02000734 RID: 1844
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x06009E2D RID: 40493 RVA: 0x0029E4B8 File Offset: 0x0029C6B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0>.NativeClassPtr, "canvasGroup");
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0>.NativeClassPtr, 100669268);
				DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeMethodInfoPtr__SetInActiveAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0>.NativeClassPtr, 100669269);
			}

			// Token: 0x06009E2E RID: 40494 RVA: 0x0029E520 File Offset: 0x0029C720
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E2F RID: 40495 RVA: 0x0029E55C File Offset: 0x0029C75C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetInActiveAsync_b__0(Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeMethodInfoPtr__SetInActiveAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E30 RID: 40496 RVA: 0x00055516 File Offset: 0x00053716
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003445 RID: 13381
			// (get) Token: 0x06009E31 RID: 40497 RVA: 0x0029E5A0 File Offset: 0x0029C7A0
			// (set) Token: 0x06009E32 RID: 40498 RVA: 0x0005551F File Offset: 0x0005371F
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__c__DisplayClass23_0.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066B7 RID: 26295
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x040066B8 RID: 26296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066B9 RID: 26297
			private static readonly IntPtr NativeMethodInfoPtr__SetInActiveAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x02000735 RID: 1845
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<SetInActiveAsync>d__23")]
		public sealed class _SetInActiveAsync_d__23 : ValueType
		{
			// Token: 0x06009E33 RID: 40499 RVA: 0x0029E5D0 File Offset: 0x0029C7D0
			// Note: this type is marked as 'beforefieldinit'.
			static _SetInActiveAsync_d__23()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<SetInActiveAsync>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr, "canvasGroup");
				DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr, 100669270);
				DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr, 100669271);
			}

			// Token: 0x06009E34 RID: 40500 RVA: 0x0029E674 File Offset: 0x0029C874
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 81443, RefRangeEnd = 81446, XrefRangeStart = 81435, XrefRangeEnd = 81443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E35 RID: 40501 RVA: 0x0029E6AC File Offset: 0x0029C8AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E36 RID: 40502 RVA: 0x0005553E File Offset: 0x0005373E
			public _SetInActiveAsync_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E37 RID: 40503 RVA: 0x00055547 File Offset: 0x00053747
			public _SetInActiveAsync_d__23() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x17003446 RID: 13382
			// (get) Token: 0x06009E38 RID: 40504 RVA: 0x0029E6F4 File Offset: 0x0029C8F4
			// (set) Token: 0x06009E39 RID: 40505 RVA: 0x00055559 File Offset: 0x00053759
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003447 RID: 13383
			// (get) Token: 0x06009E3A RID: 40506 RVA: 0x0029E71C File Offset: 0x0029C91C
			// (set) Token: 0x06009E3B RID: 40507 RVA: 0x00055574 File Offset: 0x00053774
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003448 RID: 13384
			// (get) Token: 0x06009E3C RID: 40508 RVA: 0x0029E74C File Offset: 0x0029C94C
			// (set) Token: 0x06009E3D RID: 40509 RVA: 0x000555A2 File Offset: 0x000537A2
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003449 RID: 13385
			// (get) Token: 0x06009E3E RID: 40510 RVA: 0x0029E77C File Offset: 0x0029C97C
			// (set) Token: 0x06009E3F RID: 40511 RVA: 0x000555C1 File Offset: 0x000537C1
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel._SetInActiveAsync_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040066BA RID: 26298
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040066BB RID: 26299
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040066BC RID: 26300
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x040066BD RID: 26301
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040066BE RID: 26302
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040066BF RID: 26303
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000736 RID: 1846
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSaveLoadPanel+<<OnPanelInitialize>b__12_2>d")]
		public sealed class __OnPanelInitialize_b__12_2_d : ValueType
		{
			// Token: 0x06009E40 RID: 40512 RVA: 0x0029E7AC File Offset: 0x0029C9AC
			// Note: this type is marked as 'beforefieldinit'.
			static __OnPanelInitialize_b__12_2_d()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel>.NativeClassPtr, "<<OnPanelInitialize>b__12_2>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr);
				DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr, 100669272);
				DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr, 100669273);
			}

			// Token: 0x06009E41 RID: 40513 RVA: 0x0029E850 File Offset: 0x0029CA50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 81454, RefRangeEnd = 81456, XrefRangeStart = 81446, XrefRangeEnd = 81454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E42 RID: 40514 RVA: 0x0029E888 File Offset: 0x0029CA88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E43 RID: 40515 RVA: 0x000555EF File Offset: 0x000537EF
			public __OnPanelInitialize_b__12_2_d(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E44 RID: 40516 RVA: 0x000555F8 File Offset: 0x000537F8
			public __OnPanelInitialize_b__12_2_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d>.NativeClassPtr))
			{
			}

			// Token: 0x1700344A RID: 13386
			// (get) Token: 0x06009E45 RID: 40517 RVA: 0x0029E8D0 File Offset: 0x0029CAD0
			// (set) Token: 0x06009E46 RID: 40518 RVA: 0x0005560A File Offset: 0x0005380A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700344B RID: 13387
			// (get) Token: 0x06009E47 RID: 40519 RVA: 0x0029E8F8 File Offset: 0x0029CAF8
			// (set) Token: 0x06009E48 RID: 40520 RVA: 0x00055625 File Offset: 0x00053825
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700344C RID: 13388
			// (get) Token: 0x06009E49 RID: 40521 RVA: 0x0029E928 File Offset: 0x0029CB28
			// (set) Token: 0x06009E4A RID: 40522 RVA: 0x00055653 File Offset: 0x00053853
			public unsafe DLC5_RogueLikeSaveLoadPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSaveLoadPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700344D RID: 13389
			// (get) Token: 0x06009E4B RID: 40523 RVA: 0x0029E958 File Offset: 0x0029CB58
			// (set) Token: 0x06009E4C RID: 40524 RVA: 0x00055672 File Offset: 0x00053872
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSaveLoadPanel.__OnPanelInitialize_b__12_2_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040066C0 RID: 26304
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040066C1 RID: 26305
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040066C2 RID: 26306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066C3 RID: 26307
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040066C4 RID: 26308
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040066C5 RID: 26309
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
