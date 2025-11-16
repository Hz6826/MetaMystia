using System;
using Common.UI;
using Common.UI.EscapeUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace ResultScene.UI
{
	// Token: 0x02000039 RID: 57
	public class ResultSceneSavePannel : AsyncUIPanel
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x000B1900 File Offset: 0x000AFB00
		// Note: this type is marked as 'beforefieldinit'.
		static ResultSceneSavePannel()
		{
			Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ResultScene.UI", "ResultSceneSavePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr);
			ResultSceneSavePannel.NativeFieldInfoPtr_m_BlockSubPanelCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_BlockSubPanelCommand");
			ResultSceneSavePannel.NativeFieldInfoPtr_MAX_SAVE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "MAX_SAVE_COUNT");
			ResultSceneSavePannel.NativeFieldInfoPtr_SaveParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "SaveParent");
			ResultSceneSavePannel.NativeFieldInfoPtr_ElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "ElementField");
			ResultSceneSavePannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "Scroller");
			ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncingIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_SyncingIndicator");
			ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncFailedIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_SyncFailedIndicator");
			ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncFailedIndicatorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_SyncFailedIndicatorDuration");
			ResultSceneSavePannel.NativeFieldInfoPtr_m_GenericErrorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_GenericErrorPanel");
			ResultSceneSavePannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "SubPannel");
			ResultSceneSavePannel.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_Data");
			ResultSceneSavePannel.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "m_Group");
			ResultSceneSavePannel.NativeMethodInfoPtr_OpenConfirmPanel_Private_Void_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664167);
			ResultSceneSavePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664168);
			ResultSceneSavePannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664169);
			ResultSceneSavePannel.NativeMethodInfoPtr_CreateNewSave_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664170);
			ResultSceneSavePannel.NativeMethodInfoPtr_OverrideSave_Private_UniTaskVoid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664171);
			ResultSceneSavePannel.NativeMethodInfoPtr_SavePlayerDataCoreAsync_Private_UniTask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664172);
			ResultSceneSavePannel.NativeMethodInfoPtr_SavePlayerDataImpl_Private_UniTask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664173);
			ResultSceneSavePannel.NativeMethodInfoPtr_SetActiveAsync_Private_UniTask_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664174);
			ResultSceneSavePannel.NativeMethodInfoPtr_SetInActiveAsync_Private_UniTask_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664175);
			ResultSceneSavePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664176);
			ResultSceneSavePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664177);
			ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664178);
			ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664179);
			ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664180);
			ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664181);
			ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, 100664182);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000B1B60 File Offset: 0x000AFD60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26720, RefRangeEnd = 26723, XrefRangeStart = 26697, XrefRangeEnd = 26720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenConfirmPanel(string panelTitle, Action onYes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(panelTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onYes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_OpenConfirmPanel_Private_Void_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000B1BB4 File Offset: 0x000AFDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26723, XrefRangeEnd = 26769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResultSceneSavePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000B1BF0 File Offset: 0x000AFDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26769, XrefRangeEnd = 26774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResultSceneSavePannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000B1C38 File Offset: 0x000AFE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26774, XrefRangeEnd = 26779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid CreateNewSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_CreateNewSave_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000B1C74 File Offset: 0x000AFE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26779, XrefRangeEnd = 26784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OverrideSave(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_OverrideSave_Private_UniTaskVoid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000B1CC0 File Offset: 0x000AFEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26784, XrefRangeEnd = 26799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SavePlayerDataCoreAsync(int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref writeIndex;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_SavePlayerDataCoreAsync_Private_UniTask_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000B1D04 File Offset: 0x000AFF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26806, RefRangeEnd = 26807, XrefRangeStart = 26799, XrefRangeEnd = 26806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SavePlayerDataImpl(int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref writeIndex;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_SavePlayerDataImpl_Private_UniTask_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000B1D48 File Offset: 0x000AFF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26807, XrefRangeEnd = 26819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SetActiveAsync(CanvasGroup canvasGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_SetActiveAsync_Private_UniTask_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000B1D90 File Offset: 0x000AFF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26819, XrefRangeEnd = 26825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SetInActiveAsync(CanvasGroup canvasGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr_SetInActiveAsync_Private_UniTask_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000B1DD8 File Offset: 0x000AFFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26825, XrefRangeEnd = 26837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResultSceneSavePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000B1E14 File Offset: 0x000B0014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26837, XrefRangeEnd = 26846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResultSceneSavePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000B1E50 File Offset: 0x000B0050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26846, XrefRangeEnd = 26863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_1(KeyValuePair<int, LoadedSaveDataInfo> value, UIElementCluster _, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000B1EBC File Offset: 0x000B00BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26863, XrefRangeEnd = 26873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000B1EF0 File Offset: 0x000B00F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26873, XrefRangeEnd = 26879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000B1F24 File Offset: 0x000B0124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26879, XrefRangeEnd = 26889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_2(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000B1F6C File Offset: 0x000B016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000057AD File Offset: 0x000039AD
		public ResultSceneSavePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x000B1FA0 File Offset: 0x000B01A0
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x000057B6 File Offset: 0x000039B6
		public unsafe bool m_BlockSubPanelCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_BlockSubPanelCommand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_BlockSubPanelCommand)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x000B1FC8 File Offset: 0x000B01C8
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x000057D1 File Offset: 0x000039D1
		public unsafe static int MAX_SAVE_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ResultSceneSavePannel.NativeFieldInfoPtr_MAX_SAVE_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResultSceneSavePannel.NativeFieldInfoPtr_MAX_SAVE_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x000B1FE4 File Offset: 0x000B01E4
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x000057DF File Offset: 0x000039DF
		public unsafe GameObject SaveParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_SaveParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_SaveParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000B2014 File Offset: 0x000B0214
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x000057FE File Offset: 0x000039FE
		public unsafe GridLayoutGroup ElementField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_ElementField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_ElementField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x000B2044 File Offset: 0x000B0244
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0000581D File Offset: 0x00003A1D
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x000B2074 File Offset: 0x000B0274
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0000583C File Offset: 0x00003A3C
		public unsafe CanvasGroup m_SyncingIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncingIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncingIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000B20A4 File Offset: 0x000B02A4
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0000585B File Offset: 0x00003A5B
		public unsafe CanvasGroup m_SyncFailedIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncFailedIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncFailedIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000B20D4 File Offset: 0x000B02D4
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0000587A File Offset: 0x00003A7A
		public unsafe float m_SyncFailedIndicatorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncFailedIndicatorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_SyncFailedIndicatorDuration)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000B20FC File Offset: 0x000B02FC
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00005895 File Offset: 0x00003A95
		public unsafe GenericErrorPanel m_GenericErrorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_GenericErrorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericErrorPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_GenericErrorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000B212C File Offset: 0x000B032C
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x000058B4 File Offset: 0x00003AB4
		public unsafe EscLoadPannelSubSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000B215C File Offset: 0x000B035C
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x000058D3 File Offset: 0x00003AD3
		public unsafe List<KeyValuePair<int, LoadedSaveDataInfo>> m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, LoadedSaveDataInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x000B218C File Offset: 0x000B038C
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x000058F2 File Offset: 0x00003AF2
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple> m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockSubPanelCommand;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SAVE_COUNT;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_SaveParent;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_ElementField;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncingIndicator;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncFailedIndicator;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncFailedIndicatorDuration;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_m_GenericErrorPanel;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_OpenConfirmPanel_Private_Void_String_Action_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewSave_Private_UniTaskVoid_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSave_Private_UniTaskVoid_Int32_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayerDataCoreAsync_Private_UniTask_Int32_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayerDataImpl_Private_UniTask_Int32_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveAsync_Private_UniTask_CanvasGroup_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_SetInActiveAsync_Private_UniTask_CanvasGroup_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_3_Private_Void_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_5_Private_Void_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Private_Void_CallbackContext_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_7_Private_Void_0;

		// Token: 0x020004C7 RID: 1223
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x06008057 RID: 32855 RVA: 0x00245ACC File Offset: 0x00243CCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass12_0.NativeFieldInfoPtr_panelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr, "panelInstance");
				ResultSceneSavePannel.__c__DisplayClass12_0.NativeFieldInfoPtr_onYes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr, "onYes");
				ResultSceneSavePannel.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr, 100664183);
				ResultSceneSavePannel.__c__DisplayClass12_0.NativeMethodInfoPtr__OpenConfirmPanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr, 100664184);
			}

			// Token: 0x06008058 RID: 32856 RVA: 0x00245B48 File Offset: 0x00243D48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008059 RID: 32857 RVA: 0x00245B84 File Offset: 0x00243D84
			[CallerCount(0)]
			public unsafe void _OpenConfirmPanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass12_0.NativeMethodInfoPtr__OpenConfirmPanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600805A RID: 32858 RVA: 0x0004548B File Offset: 0x0004368B
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B51 RID: 11089
			// (get) Token: 0x0600805B RID: 32859 RVA: 0x00245BB8 File Offset: 0x00243DB8
			// (set) Token: 0x0600805C RID: 32860 RVA: 0x00045494 File Offset: 0x00043694
			public unsafe EscLoadPannelSubSubPannel panelInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass12_0.NativeFieldInfoPtr_panelInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass12_0.NativeFieldInfoPtr_panelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B52 RID: 11090
			// (get) Token: 0x0600805D RID: 32861 RVA: 0x00245BE8 File Offset: 0x00243DE8
			// (set) Token: 0x0600805E RID: 32862 RVA: 0x000454B3 File Offset: 0x000436B3
			public unsafe Action onYes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass12_0.NativeFieldInfoPtr_onYes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass12_0.NativeFieldInfoPtr_onYes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005436 RID: 21558
			private static readonly IntPtr NativeFieldInfoPtr_panelInstance;

			// Token: 0x04005437 RID: 21559
			private static readonly IntPtr NativeFieldInfoPtr_onYes;

			// Token: 0x04005438 RID: 21560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005439 RID: 21561
			private static readonly IntPtr NativeMethodInfoPtr__OpenConfirmPanel_b__0_Internal_Void_0;
		}

		// Token: 0x020004C8 RID: 1224
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600805F RID: 32863 RVA: 0x00245C18 File Offset: 0x00243E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr, "value");
				ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr, "<>9__6");
				ResultSceneSavePannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr, 100664185);
				ResultSceneSavePannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr, 100664186);
				ResultSceneSavePannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr, 100664187);
			}

			// Token: 0x06008060 RID: 32864 RVA: 0x00245CBC File Offset: 0x00243EBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008061 RID: 32865 RVA: 0x00245CF8 File Offset: 0x00243EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26438, XrefRangeEnd = 26449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008062 RID: 32866 RVA: 0x00245D2C File Offset: 0x00243F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26449, XrefRangeEnd = 26456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008063 RID: 32867 RVA: 0x000454D2 File Offset: 0x000436D2
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B53 RID: 11091
			// (get) Token: 0x06008064 RID: 32868 RVA: 0x00245D60 File Offset: 0x00243F60
			// (set) Token: 0x06008065 RID: 32869 RVA: 0x000454DB File Offset: 0x000436DB
			public KeyValuePair<int, LoadedSaveDataInfo> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr_value);
					return new KeyValuePair<int, LoadedSaveDataInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, LoadedSaveDataInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, LoadedSaveDataInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B54 RID: 11092
			// (get) Token: 0x06008066 RID: 32870 RVA: 0x00245D90 File Offset: 0x00243F90
			// (set) Token: 0x06008067 RID: 32871 RVA: 0x00045509 File Offset: 0x00043709
			public unsafe ResultSceneSavePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B55 RID: 11093
			// (get) Token: 0x06008068 RID: 32872 RVA: 0x00245DC0 File Offset: 0x00243FC0
			// (set) Token: 0x06008069 RID: 32873 RVA: 0x00045528 File Offset: 0x00043728
			public unsafe Action __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400543A RID: 21562
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400543B RID: 21563
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400543C RID: 21564
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x0400543D RID: 21565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400543E RID: 21566
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_0;

			// Token: 0x0400543F RID: 21567
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_0;
		}

		// Token: 0x020004C9 RID: 1225
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600806A RID: 32874 RVA: 0x00245DF0 File Offset: 0x00243FF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr);
				ResultSceneSavePannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr, "<>9");
				ResultSceneSavePannel.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr, "<>9__13_0");
				ResultSceneSavePannel.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr, "<>9__14_1");
				ResultSceneSavePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr, 100664189);
				ResultSceneSavePannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Internal_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr, 100664190);
				ResultSceneSavePannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__14_1_Internal_Boolean_KeyValuePair_2_Int32_LoadedSaveDataInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr, 100664191);
			}

			// Token: 0x0600806B RID: 32875 RVA: 0x00245E94 File Offset: 0x00244094
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600806C RID: 32876 RVA: 0x00245ED0 File Offset: 0x002440D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26456, XrefRangeEnd = 26511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13_0(KeyValuePair<int, LoadedSaveDataInfo> value, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Internal_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600806D RID: 32877 RVA: 0x00245F3C File Offset: 0x0024413C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26511, XrefRangeEnd = 26512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpenAsync_b__14_1(KeyValuePair<int, LoadedSaveDataInfo> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__14_1_Internal_Boolean_KeyValuePair_2_Int32_LoadedSaveDataInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600806E RID: 32878 RVA: 0x00045547 File Offset: 0x00043747
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B56 RID: 11094
			// (get) Token: 0x0600806F RID: 32879 RVA: 0x00245F90 File Offset: 0x00244190
			// (set) Token: 0x06008070 RID: 32880 RVA: 0x00045550 File Offset: 0x00043750
			public unsafe static ResultSceneSavePannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneSavePannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneSavePannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B57 RID: 11095
			// (get) Token: 0x06008071 RID: 32881 RVA: 0x00245FB8 File Offset: 0x002441B8
			// (set) Token: 0x06008072 RID: 32882 RVA: 0x00045562 File Offset: 0x00043762
			public unsafe static Action<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneSavePannel.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneSavePannel.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B58 RID: 11096
			// (get) Token: 0x06008073 RID: 32883 RVA: 0x00245FE0 File Offset: 0x002441E0
			// (set) Token: 0x06008074 RID: 32884 RVA: 0x00045574 File Offset: 0x00043774
			public unsafe static Predicate<KeyValuePair<int, LoadedSaveDataInfo>> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneSavePannel.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<KeyValuePair<int, LoadedSaveDataInfo>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneSavePannel.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005440 RID: 21568
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005441 RID: 21569
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04005442 RID: 21570
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04005443 RID: 21571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005444 RID: 21572
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Internal_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0;

			// Token: 0x04005445 RID: 21573
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__14_1_Internal_Boolean_KeyValuePair_2_Int32_LoadedSaveDataInfo_0;
		}

		// Token: 0x020004CA RID: 1226
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x06008075 RID: 32885 RVA: 0x00246008 File Offset: 0x00244208
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_0>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass14_0.NativeFieldInfoPtr_lastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_0>.NativeClassPtr, "lastIndex");
				ResultSceneSavePannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_0>.NativeClassPtr, 100664192);
				ResultSceneSavePannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_0>.NativeClassPtr, 100664193);
			}

			// Token: 0x06008076 RID: 32886 RVA: 0x00246070 File Offset: 0x00244270
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008077 RID: 32887 RVA: 0x002460AC File Offset: 0x002442AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26512, XrefRangeEnd = 26518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, LoadedSaveDataInfo> _OnPanelOpenAsync_b__0(KeyValuePair<LoadedSaveDataInfo, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, LoadedSaveDataInfo>(pointer);
			}

			// Token: 0x06008078 RID: 32888 RVA: 0x00045586 File Offset: 0x00043786
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B59 RID: 11097
			// (get) Token: 0x06008079 RID: 32889 RVA: 0x002460FC File Offset: 0x002442FC
			// (set) Token: 0x0600807A RID: 32890 RVA: 0x0004558F File Offset: 0x0004378F
			public unsafe int lastIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass14_0.NativeFieldInfoPtr_lastIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass14_0.NativeFieldInfoPtr_lastIndex)) = value;
				}
			}

			// Token: 0x04005446 RID: 21574
			private static readonly IntPtr NativeFieldInfoPtr_lastIndex;

			// Token: 0x04005447 RID: 21575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005448 RID: 21576
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0;
		}

		// Token: 0x020004CB RID: 1227
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass14_1")]
		public sealed class __c__DisplayClass14_1 : Il2CppSystem.Object
		{
			// Token: 0x0600807B RID: 32891 RVA: 0x00246124 File Offset: 0x00244324
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_1()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass14_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_1>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass14_1.NativeFieldInfoPtr_saveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_1>.NativeClassPtr, "saveIndex");
				ResultSceneSavePannel.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_1>.NativeClassPtr, 100664194);
				ResultSceneSavePannel.__c__DisplayClass14_1.NativeMethodInfoPtr__OnPanelOpenAsync_b__2_Internal_Boolean_KeyValuePair_2_Int32_LoadedSaveDataInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_1>.NativeClassPtr, 100664195);
			}

			// Token: 0x0600807C RID: 32892 RVA: 0x0024618C File Offset: 0x0024438C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass14_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600807D RID: 32893 RVA: 0x002461C8 File Offset: 0x002443C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26518, XrefRangeEnd = 26519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpenAsync_b__2(KeyValuePair<int, LoadedSaveDataInfo> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass14_1.NativeMethodInfoPtr__OnPanelOpenAsync_b__2_Internal_Boolean_KeyValuePair_2_Int32_LoadedSaveDataInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600807E RID: 32894 RVA: 0x000455AA File Offset: 0x000437AA
			public __c__DisplayClass14_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B5A RID: 11098
			// (get) Token: 0x0600807F RID: 32895 RVA: 0x0024621C File Offset: 0x0024441C
			// (set) Token: 0x06008080 RID: 32896 RVA: 0x000455B3 File Offset: 0x000437B3
			public unsafe int saveIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass14_1.NativeFieldInfoPtr_saveIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass14_1.NativeFieldInfoPtr_saveIndex)) = value;
				}
			}

			// Token: 0x04005449 RID: 21577
			private static readonly IntPtr NativeFieldInfoPtr_saveIndex;

			// Token: 0x0400544A RID: 21578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400544B RID: 21579
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__2_Internal_Boolean_KeyValuePair_2_Int32_LoadedSaveDataInfo_0;
		}

		// Token: 0x020004CC RID: 1228
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<OnPanelOpenAsync>d__14")]
		public sealed class _OnPanelOpenAsync_d__14 : ValueType
		{
			// Token: 0x06008081 RID: 32897 RVA: 0x00246244 File Offset: 0x00244444
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__14()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<OnPanelOpenAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr);
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, "<>1__state");
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, "<>t__builder");
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, "<>4__this");
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, "<>8__1");
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, "<>u__1");
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, 100664196);
				ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr, 100664197);
			}

			// Token: 0x06008082 RID: 32898 RVA: 0x002462FC File Offset: 0x002444FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 26626, RefRangeEnd = 26628, XrefRangeStart = 26519, XrefRangeEnd = 26626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008083 RID: 32899 RVA: 0x00246334 File Offset: 0x00244534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008084 RID: 32900 RVA: 0x000455CE File Offset: 0x000437CE
			public _OnPanelOpenAsync_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008085 RID: 32901 RVA: 0x000455D7 File Offset: 0x000437D7
			public _OnPanelOpenAsync_d__14() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel._OnPanelOpenAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x17002B5B RID: 11099
			// (get) Token: 0x06008086 RID: 32902 RVA: 0x0024637C File Offset: 0x0024457C
			// (set) Token: 0x06008087 RID: 32903 RVA: 0x000455E9 File Offset: 0x000437E9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B5C RID: 11100
			// (get) Token: 0x06008088 RID: 32904 RVA: 0x002463A4 File Offset: 0x002445A4
			// (set) Token: 0x06008089 RID: 32905 RVA: 0x00045604 File Offset: 0x00043804
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B5D RID: 11101
			// (get) Token: 0x0600808A RID: 32906 RVA: 0x002463D4 File Offset: 0x002445D4
			// (set) Token: 0x0600808B RID: 32907 RVA: 0x00045632 File Offset: 0x00043832
			public unsafe ResultSceneSavePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B5E RID: 11102
			// (get) Token: 0x0600808C RID: 32908 RVA: 0x00246404 File Offset: 0x00244604
			// (set) Token: 0x0600808D RID: 32909 RVA: 0x00045651 File Offset: 0x00043851
			public unsafe ResultSceneSavePannel.__c__DisplayClass14_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B5F RID: 11103
			// (get) Token: 0x0600808E RID: 32910 RVA: 0x00246434 File Offset: 0x00244634
			// (set) Token: 0x0600808F RID: 32911 RVA: 0x00045670 File Offset: 0x00043870
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OnPanelOpenAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400544C RID: 21580
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400544D RID: 21581
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400544E RID: 21582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400544F RID: 21583
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005450 RID: 21584
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005451 RID: 21585
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005452 RID: 21586
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004CD RID: 1229
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<CreateNewSave>d__15")]
		public sealed class _CreateNewSave_d__15 : ValueType
		{
			// Token: 0x06008090 RID: 32912 RVA: 0x00246464 File Offset: 0x00244664
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateNewSave_d__15()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<CreateNewSave>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr);
				ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr, "<>1__state");
				ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr, "<>t__builder");
				ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr, "<>4__this");
				ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr, "<>u__1");
				ResultSceneSavePannel._CreateNewSave_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr, 100664198);
				ResultSceneSavePannel._CreateNewSave_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr, 100664199);
			}

			// Token: 0x06008091 RID: 32913 RVA: 0x00246508 File Offset: 0x00244708
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 26641, RefRangeEnd = 26643, XrefRangeStart = 26628, XrefRangeEnd = 26641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._CreateNewSave_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008092 RID: 32914 RVA: 0x00246540 File Offset: 0x00244740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._CreateNewSave_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008093 RID: 32915 RVA: 0x0004569E File Offset: 0x0004389E
			public _CreateNewSave_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008094 RID: 32916 RVA: 0x000456A7 File Offset: 0x000438A7
			public _CreateNewSave_d__15() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel._CreateNewSave_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17002B60 RID: 11104
			// (get) Token: 0x06008095 RID: 32917 RVA: 0x00246588 File Offset: 0x00244788
			// (set) Token: 0x06008096 RID: 32918 RVA: 0x000456B9 File Offset: 0x000438B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B61 RID: 11105
			// (get) Token: 0x06008097 RID: 32919 RVA: 0x002465B0 File Offset: 0x002447B0
			// (set) Token: 0x06008098 RID: 32920 RVA: 0x000456D4 File Offset: 0x000438D4
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B62 RID: 11106
			// (get) Token: 0x06008099 RID: 32921 RVA: 0x002465E0 File Offset: 0x002447E0
			// (set) Token: 0x0600809A RID: 32922 RVA: 0x00045702 File Offset: 0x00043902
			public unsafe ResultSceneSavePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B63 RID: 11107
			// (get) Token: 0x0600809B RID: 32923 RVA: 0x00246610 File Offset: 0x00244810
			// (set) Token: 0x0600809C RID: 32924 RVA: 0x00045721 File Offset: 0x00043921
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._CreateNewSave_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005453 RID: 21587
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005454 RID: 21588
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005455 RID: 21589
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005456 RID: 21590
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005457 RID: 21591
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005458 RID: 21592
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004CE RID: 1230
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<OverrideSave>d__16")]
		public sealed class _OverrideSave_d__16 : ValueType
		{
			// Token: 0x0600809D RID: 32925 RVA: 0x00246640 File Offset: 0x00244840
			// Note: this type is marked as 'beforefieldinit'.
			static _OverrideSave_d__16()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<OverrideSave>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr);
				ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, "<>1__state");
				ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, "<>t__builder");
				ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, "<>4__this");
				ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, "index");
				ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, "<>u__1");
				ResultSceneSavePannel._OverrideSave_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, 100664200);
				ResultSceneSavePannel._OverrideSave_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr, 100664201);
			}

			// Token: 0x0600809E RID: 32926 RVA: 0x002466F8 File Offset: 0x002448F8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 26647, RefRangeEnd = 26649, XrefRangeStart = 26643, XrefRangeEnd = 26647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._OverrideSave_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600809F RID: 32927 RVA: 0x00246730 File Offset: 0x00244930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._OverrideSave_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080A0 RID: 32928 RVA: 0x0004574F File Offset: 0x0004394F
			public _OverrideSave_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060080A1 RID: 32929 RVA: 0x00045758 File Offset: 0x00043958
			public _OverrideSave_d__16() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel._OverrideSave_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17002B64 RID: 11108
			// (get) Token: 0x060080A2 RID: 32930 RVA: 0x00246778 File Offset: 0x00244978
			// (set) Token: 0x060080A3 RID: 32931 RVA: 0x0004576A File Offset: 0x0004396A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B65 RID: 11109
			// (get) Token: 0x060080A4 RID: 32932 RVA: 0x002467A0 File Offset: 0x002449A0
			// (set) Token: 0x060080A5 RID: 32933 RVA: 0x00045785 File Offset: 0x00043985
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B66 RID: 11110
			// (get) Token: 0x060080A6 RID: 32934 RVA: 0x002467D0 File Offset: 0x002449D0
			// (set) Token: 0x060080A7 RID: 32935 RVA: 0x000457B3 File Offset: 0x000439B3
			public unsafe ResultSceneSavePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B67 RID: 11111
			// (get) Token: 0x060080A8 RID: 32936 RVA: 0x00246800 File Offset: 0x00244A00
			// (set) Token: 0x060080A9 RID: 32937 RVA: 0x000457D2 File Offset: 0x000439D2
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17002B68 RID: 11112
			// (get) Token: 0x060080AA RID: 32938 RVA: 0x00246828 File Offset: 0x00244A28
			// (set) Token: 0x060080AB RID: 32939 RVA: 0x000457ED File Offset: 0x000439ED
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._OverrideSave_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005459 RID: 21593
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400545A RID: 21594
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400545B RID: 21595
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400545C RID: 21596
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400545D RID: 21597
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400545E RID: 21598
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400545F RID: 21599
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004CF RID: 1231
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x060080AC RID: 32940 RVA: 0x00246858 File Offset: 0x00244A58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				ResultSceneSavePannel.__c__DisplayClass17_0.NativeFieldInfoPtr_writeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr, "writeIndex");
				ResultSceneSavePannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr, 100664202);
				ResultSceneSavePannel.__c__DisplayClass17_0.NativeMethodInfoPtr__SavePlayerDataCoreAsync_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr, 100664203);
			}

			// Token: 0x060080AD RID: 32941 RVA: 0x002468D4 File Offset: 0x00244AD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080AE RID: 32942 RVA: 0x00246910 File Offset: 0x00244B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26649, XrefRangeEnd = 26650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _SavePlayerDataCoreAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass17_0.NativeMethodInfoPtr__SavePlayerDataCoreAsync_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x060080AF RID: 32943 RVA: 0x0004581B File Offset: 0x00043A1B
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B69 RID: 11113
			// (get) Token: 0x060080B0 RID: 32944 RVA: 0x00246948 File Offset: 0x00244B48
			// (set) Token: 0x060080B1 RID: 32945 RVA: 0x00045824 File Offset: 0x00043A24
			public unsafe ResultSceneSavePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B6A RID: 11114
			// (get) Token: 0x060080B2 RID: 32946 RVA: 0x00246978 File Offset: 0x00244B78
			// (set) Token: 0x060080B3 RID: 32947 RVA: 0x00045843 File Offset: 0x00043A43
			public unsafe int writeIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass17_0.NativeFieldInfoPtr_writeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass17_0.NativeFieldInfoPtr_writeIndex)) = value;
				}
			}

			// Token: 0x04005460 RID: 21600
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005461 RID: 21601
			private static readonly IntPtr NativeFieldInfoPtr_writeIndex;

			// Token: 0x04005462 RID: 21602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005463 RID: 21603
			private static readonly IntPtr NativeMethodInfoPtr__SavePlayerDataCoreAsync_b__0_Internal_UniTask_0;
		}

		// Token: 0x020004D0 RID: 1232
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<SavePlayerDataImpl>d__18")]
		public sealed class _SavePlayerDataImpl_d__18 : ValueType
		{
			// Token: 0x060080B4 RID: 32948 RVA: 0x002469A0 File Offset: 0x00244BA0
			// Note: this type is marked as 'beforefieldinit'.
			static _SavePlayerDataImpl_d__18()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<SavePlayerDataImpl>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr);
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>1__state");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>t__builder");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr_writeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "writeIndex");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>4__this");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__filePath_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<filePath>5__2");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__fileContent_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<fileContent>5__3");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__syncResult_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<syncResult>5__4");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>7__wrap4");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>7__wrap5");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>u__1");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>u__2");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>u__3");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, "<>u__4");
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, 100664204);
				ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr, 100664205);
			}

			// Token: 0x060080B5 RID: 32949 RVA: 0x00246AF8 File Offset: 0x00244CF8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 26683, RefRangeEnd = 26685, XrefRangeStart = 26650, XrefRangeEnd = 26683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080B6 RID: 32950 RVA: 0x00246B30 File Offset: 0x00244D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080B7 RID: 32951 RVA: 0x0004585E File Offset: 0x00043A5E
			public _SavePlayerDataImpl_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060080B8 RID: 32952 RVA: 0x00045867 File Offset: 0x00043A67
			public _SavePlayerDataImpl_d__18() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel._SavePlayerDataImpl_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17002B6B RID: 11115
			// (get) Token: 0x060080B9 RID: 32953 RVA: 0x00246B78 File Offset: 0x00244D78
			// (set) Token: 0x060080BA RID: 32954 RVA: 0x00045879 File Offset: 0x00043A79
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B6C RID: 11116
			// (get) Token: 0x060080BB RID: 32955 RVA: 0x00246BA0 File Offset: 0x00244DA0
			// (set) Token: 0x060080BC RID: 32956 RVA: 0x00045894 File Offset: 0x00043A94
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B6D RID: 11117
			// (get) Token: 0x060080BD RID: 32957 RVA: 0x00246BD0 File Offset: 0x00244DD0
			// (set) Token: 0x060080BE RID: 32958 RVA: 0x000458C2 File Offset: 0x00043AC2
			public unsafe int writeIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr_writeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr_writeIndex)) = value;
				}
			}

			// Token: 0x17002B6E RID: 11118
			// (get) Token: 0x060080BF RID: 32959 RVA: 0x00246BF8 File Offset: 0x00244DF8
			// (set) Token: 0x060080C0 RID: 32960 RVA: 0x000458DD File Offset: 0x00043ADD
			public unsafe ResultSceneSavePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B6F RID: 11119
			// (get) Token: 0x060080C1 RID: 32961 RVA: 0x00246C28 File Offset: 0x00244E28
			// (set) Token: 0x060080C2 RID: 32962 RVA: 0x000458FC File Offset: 0x00043AFC
			public unsafe string _filePath_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__filePath_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__filePath_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002B70 RID: 11120
			// (get) Token: 0x060080C3 RID: 32963 RVA: 0x00246C50 File Offset: 0x00244E50
			// (set) Token: 0x060080C4 RID: 32964 RVA: 0x0004591B File Offset: 0x00043B1B
			public unsafe string _fileContent_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__fileContent_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__fileContent_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002B71 RID: 11121
			// (get) Token: 0x060080C5 RID: 32965 RVA: 0x00246C78 File Offset: 0x00244E78
			// (set) Token: 0x060080C6 RID: 32966 RVA: 0x0004593A File Offset: 0x00043B3A
			public unsafe bool _syncResult_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__syncResult_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr__syncResult_5__4)) = value;
				}
			}

			// Token: 0x17002B72 RID: 11122
			// (get) Token: 0x060080C7 RID: 32967 RVA: 0x00246CA0 File Offset: 0x00244EA0
			// (set) Token: 0x060080C8 RID: 32968 RVA: 0x00045955 File Offset: 0x00043B55
			public unsafe Il2CppSystem.Object __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B73 RID: 11123
			// (get) Token: 0x060080C9 RID: 32969 RVA: 0x00246CD0 File Offset: 0x00244ED0
			// (set) Token: 0x060080CA RID: 32970 RVA: 0x00045974 File Offset: 0x00043B74
			public unsafe int __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___7__wrap5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___7__wrap5)) = value;
				}
			}

			// Token: 0x17002B74 RID: 11124
			// (get) Token: 0x060080CB RID: 32971 RVA: 0x00246CF8 File Offset: 0x00244EF8
			// (set) Token: 0x060080CC RID: 32972 RVA: 0x0004598F File Offset: 0x00043B8F
			public UniTask<ValueTuple<string, string>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__1);
					return new UniTask<ValueTuple<string, string>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ValueTuple<string, string>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ValueTuple<string, string>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B75 RID: 11125
			// (get) Token: 0x060080CD RID: 32973 RVA: 0x00246D28 File Offset: 0x00244F28
			// (set) Token: 0x060080CE RID: 32974 RVA: 0x000459BD File Offset: 0x00043BBD
			public UniTask<GenericErrorPanel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__2);
					return new UniTask<GenericErrorPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<GenericErrorPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<GenericErrorPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B76 RID: 11126
			// (get) Token: 0x060080CF RID: 32975 RVA: 0x00246D58 File Offset: 0x00244F58
			// (set) Token: 0x060080D0 RID: 32976 RVA: 0x000459EB File Offset: 0x00043BEB
			public UniTask.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__3);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B77 RID: 11127
			// (get) Token: 0x060080D1 RID: 32977 RVA: 0x00246D88 File Offset: 0x00244F88
			// (set) Token: 0x060080D2 RID: 32978 RVA: 0x00045A19 File Offset: 0x00043C19
			public UniTask<bool>.Awaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__4);
					return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SavePlayerDataImpl_d__18.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005464 RID: 21604
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005465 RID: 21605
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005466 RID: 21606
			private static readonly IntPtr NativeFieldInfoPtr_writeIndex;

			// Token: 0x04005467 RID: 21607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005468 RID: 21608
			private static readonly IntPtr NativeFieldInfoPtr__filePath_5__2;

			// Token: 0x04005469 RID: 21609
			private static readonly IntPtr NativeFieldInfoPtr__fileContent_5__3;

			// Token: 0x0400546A RID: 21610
			private static readonly IntPtr NativeFieldInfoPtr__syncResult_5__4;

			// Token: 0x0400546B RID: 21611
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x0400546C RID: 21612
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x0400546D RID: 21613
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400546E RID: 21614
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400546F RID: 21615
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04005470 RID: 21616
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x04005471 RID: 21617
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005472 RID: 21618
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004D1 RID: 1233
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x060080D3 RID: 32979 RVA: 0x00246DB8 File Offset: 0x00244FB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass19_0>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass19_0.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass19_0>.NativeClassPtr, "canvasGroup");
				ResultSceneSavePannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass19_0>.NativeClassPtr, 100664206);
				ResultSceneSavePannel.__c__DisplayClass19_0.NativeMethodInfoPtr__SetActiveAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass19_0>.NativeClassPtr, 100664207);
			}

			// Token: 0x060080D4 RID: 32980 RVA: 0x00246E20 File Offset: 0x00245020
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080D5 RID: 32981 RVA: 0x00246E5C File Offset: 0x0024505C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26685, XrefRangeEnd = 26686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetActiveAsync_b__0(Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass19_0.NativeMethodInfoPtr__SetActiveAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080D6 RID: 32982 RVA: 0x00045A47 File Offset: 0x00043C47
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B78 RID: 11128
			// (get) Token: 0x060080D7 RID: 32983 RVA: 0x00246EA0 File Offset: 0x002450A0
			// (set) Token: 0x060080D8 RID: 32984 RVA: 0x00045A50 File Offset: 0x00043C50
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass19_0.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass19_0.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005473 RID: 21619
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x04005474 RID: 21620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005475 RID: 21621
			private static readonly IntPtr NativeMethodInfoPtr__SetActiveAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x020004D2 RID: 1234
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x060080D9 RID: 32985 RVA: 0x00246ED0 File Offset: 0x002450D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass20_0>.NativeClassPtr);
				ResultSceneSavePannel.__c__DisplayClass20_0.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass20_0>.NativeClassPtr, "canvasGroup");
				ResultSceneSavePannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass20_0>.NativeClassPtr, 100664208);
				ResultSceneSavePannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetInActiveAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass20_0>.NativeClassPtr, 100664209);
			}

			// Token: 0x060080DA RID: 32986 RVA: 0x00246F38 File Offset: 0x00245138
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080DB RID: 32987 RVA: 0x00246F74 File Offset: 0x00245174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26686, XrefRangeEnd = 26687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetInActiveAsync_b__0(Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetInActiveAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080DC RID: 32988 RVA: 0x00045A6F File Offset: 0x00043C6F
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B79 RID: 11129
			// (get) Token: 0x060080DD RID: 32989 RVA: 0x00246FB8 File Offset: 0x002451B8
			// (set) Token: 0x060080DE RID: 32990 RVA: 0x00045A78 File Offset: 0x00043C78
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass20_0.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel.__c__DisplayClass20_0.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005476 RID: 21622
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x04005477 RID: 21623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005478 RID: 21624
			private static readonly IntPtr NativeMethodInfoPtr__SetInActiveAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x020004D3 RID: 1235
		[ObfuscatedName("ResultScene.UI.ResultSceneSavePannel+<SetInActiveAsync>d__20")]
		public sealed class _SetInActiveAsync_d__20 : ValueType
		{
			// Token: 0x060080DF RID: 32991 RVA: 0x00246FE8 File Offset: 0x002451E8
			// Note: this type is marked as 'beforefieldinit'.
			static _SetInActiveAsync_d__20()
			{
				Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneSavePannel>.NativeClassPtr, "<SetInActiveAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr);
				ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr, "<>1__state");
				ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr, "<>t__builder");
				ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr, "canvasGroup");
				ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr, "<>u__1");
				ResultSceneSavePannel._SetInActiveAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr, 100664210);
				ResultSceneSavePannel._SetInActiveAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr, 100664211);
			}

			// Token: 0x060080E0 RID: 32992 RVA: 0x0024708C File Offset: 0x0024528C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 26695, RefRangeEnd = 26697, XrefRangeStart = 26687, XrefRangeEnd = 26695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080E1 RID: 32993 RVA: 0x002470C4 File Offset: 0x002452C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080E2 RID: 32994 RVA: 0x00045A97 File Offset: 0x00043C97
			public _SetInActiveAsync_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060080E3 RID: 32995 RVA: 0x00045AA0 File Offset: 0x00043CA0
			public _SetInActiveAsync_d__20() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneSavePannel._SetInActiveAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17002B7A RID: 11130
			// (get) Token: 0x060080E4 RID: 32996 RVA: 0x0024710C File Offset: 0x0024530C
			// (set) Token: 0x060080E5 RID: 32997 RVA: 0x00045AB2 File Offset: 0x00043CB2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B7B RID: 11131
			// (get) Token: 0x060080E6 RID: 32998 RVA: 0x00247134 File Offset: 0x00245334
			// (set) Token: 0x060080E7 RID: 32999 RVA: 0x00045ACD File Offset: 0x00043CCD
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B7C RID: 11132
			// (get) Token: 0x060080E8 RID: 33000 RVA: 0x00247164 File Offset: 0x00245364
			// (set) Token: 0x060080E9 RID: 33001 RVA: 0x00045AFB File Offset: 0x00043CFB
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B7D RID: 11133
			// (get) Token: 0x060080EA RID: 33002 RVA: 0x00247194 File Offset: 0x00245394
			// (set) Token: 0x060080EB RID: 33003 RVA: 0x00045B1A File Offset: 0x00043D1A
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneSavePannel._SetInActiveAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005479 RID: 21625
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400547A RID: 21626
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400547B RID: 21627
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x0400547C RID: 21628
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400547D RID: 21629
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400547E RID: 21630
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
