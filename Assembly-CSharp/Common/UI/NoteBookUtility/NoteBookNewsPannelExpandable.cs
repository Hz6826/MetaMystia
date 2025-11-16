using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000397 RID: 919
	public class NoteBookNewsPannelExpandable : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x06006E03 RID: 28163 RVA: 0x0020D544 File Offset: 0x0020B744
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookNewsPannelExpandable()
		{
			Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookNewsPannelExpandable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr);
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_AllNewsPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_AllNewsPrefabs");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_AllNewsDetailPannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_AllNewsDetailPannels");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_Field1");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_Field2");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_Field3");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_Field4");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_GotoPrevBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_GotoPrevBtn");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_GotoNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_GotoNextBtn");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_PageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_PageIndex");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_Pool");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_LogicalGroupT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_LogicalGroupT");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_CurrentPageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_CurrentPageIndex");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_TotalPageCountCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_TotalPageCountCache");
			NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_ActiveField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "m_ActiveField");
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685836);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_GoToNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685837);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_BackToPrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685838);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_ExitGroupAndUpdateCurrent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685839);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685840);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685841);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_ExitGroupAndPrintPage_Private_Void_ReadOnlySpan_1_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685842);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_CollectInstance_Private_Void_byref_ValueTuple_2_IntractableNewsObject_IntractableNewsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685843);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OpenDetailPanel_Private_Void_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685844);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685845);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685846);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr__OnPanelInitialize_b__14_3_Private_Void_IntractableNewsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685847);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr__OnPanelInitialize_b__14_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685848);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr__OnPanelInitialize_b__14_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685849);
			NoteBookNewsPannelExpandable.NativeMethodInfoPtr_Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, 100685850);
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x0020D7B8 File Offset: 0x0020B9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275840, XrefRangeEnd = 275932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x0020D7F4 File Offset: 0x0020B9F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275936, RefRangeEnd = 275938, XrefRangeStart = 275932, XrefRangeEnd = 275936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_GoToNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x0020D828 File Offset: 0x0020BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275938, XrefRangeEnd = 275942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackToPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_BackToPrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x0020D85C File Offset: 0x0020BA5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275960, RefRangeEnd = 275963, XrefRangeStart = 275942, XrefRangeEnd = 275960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitGroupAndUpdateCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_ExitGroupAndUpdateCurrent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x0020D890 File Offset: 0x0020BA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275963, XrefRangeEnd = 275972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x0020D8CC File Offset: 0x0020BACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275972, XrefRangeEnd = 275977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x0020D908 File Offset: 0x0020BB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276030, RefRangeEnd = 276031, XrefRangeStart = 275977, XrefRangeEnd = 276030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitGroupAndPrintPage(ReadOnlySpan<RunTimeScheduler.HistoryNewsData> pageData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pageData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_ExitGroupAndPrintPage_Private_Void_ReadOnlySpan_1_HistoryNewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x0020D950 File Offset: 0x0020BB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276031, XrefRangeEnd = 276037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectInstance([In] ref ValueTuple<IntractableNewsObject, IntractableNewsObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_CollectInstance_Private_Void_byref_ValueTuple_2_IntractableNewsObject_IntractableNewsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x0020D994 File Offset: 0x0020BB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276037, XrefRangeEnd = 276050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDetailPanel(RunTimeScheduler.HistoryNewsData newsData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newsData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_OpenDetailPanel_Private_Void_HistoryNewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x0020D9DC File Offset: 0x0020BBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276050, XrefRangeEnd = 276064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannelExpandable.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x0020DA18 File Offset: 0x0020BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276064, XrefRangeEnd = 276082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookNewsPannelExpandable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x0020DA54 File Offset: 0x0020BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276082, XrefRangeEnd = 276089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__14_3(IntractableNewsObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr__OnPanelInitialize_b__14_3_Private_Void_IntractableNewsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x0020DA98 File Offset: 0x0020BC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276089, XrefRangeEnd = 276093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__14_0(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr__OnPanelInitialize_b__14_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x0020DAE0 File Offset: 0x0020BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276093, XrefRangeEnd = 276098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__14_1(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr__OnPanelInitialize_b__14_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x0020DB28 File Offset: 0x0020BD28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276133, RefRangeEnd = 276137, XrefRangeStart = 276098, XrefRangeEnd = 276133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0(RectTransform field, ReadOnlySpan<RunTimeScheduler.HistoryNewsData> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(collection));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.NativeMethodInfoPtr_Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x0003B7A8 File Offset: 0x000399A8
		public NoteBookNewsPannelExpandable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x06006E14 RID: 28180 RVA: 0x0020DB84 File Offset: 0x0020BD84
		// (set) Token: 0x06006E15 RID: 28181 RVA: 0x0003B7B1 File Offset: 0x000399B1
		public unsafe Il2CppReferenceArray<IntractableNewsObject> m_AllNewsPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_AllNewsPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IntractableNewsObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_AllNewsPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x0020DBB4 File Offset: 0x0020BDB4
		// (set) Token: 0x06006E17 RID: 28183 RVA: 0x0003B7D0 File Offset: 0x000399D0
		public unsafe Il2CppReferenceArray<NoteBookNewsDetailPannel> m_AllNewsDetailPannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_AllNewsDetailPannels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NoteBookNewsDetailPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_AllNewsDetailPannels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06006E18 RID: 28184 RVA: 0x0020DBE4 File Offset: 0x0020BDE4
		// (set) Token: 0x06006E19 RID: 28185 RVA: 0x0003B7EF File Offset: 0x000399EF
		public unsafe RectTransform m_Field1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x0020DC14 File Offset: 0x0020BE14
		// (set) Token: 0x06006E1B RID: 28187 RVA: 0x0003B80E File Offset: 0x00039A0E
		public unsafe RectTransform m_Field2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x0020DC44 File Offset: 0x0020BE44
		// (set) Token: 0x06006E1D RID: 28189 RVA: 0x0003B82D File Offset: 0x00039A2D
		public unsafe RectTransform m_Field3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x06006E1E RID: 28190 RVA: 0x0020DC74 File Offset: 0x0020BE74
		// (set) Token: 0x06006E1F RID: 28191 RVA: 0x0003B84C File Offset: 0x00039A4C
		public unsafe RectTransform m_Field4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Field4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06006E20 RID: 28192 RVA: 0x0020DCA4 File Offset: 0x0020BEA4
		// (set) Token: 0x06006E21 RID: 28193 RVA: 0x0003B86B File Offset: 0x00039A6B
		public unsafe UIButtonSimple m_GotoPrevBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_GotoPrevBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_GotoPrevBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x0020DCD4 File Offset: 0x0020BED4
		// (set) Token: 0x06006E23 RID: 28195 RVA: 0x0003B88A File Offset: 0x00039A8A
		public unsafe UIButtonSimple m_GotoNextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_GotoNextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_GotoNextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06006E24 RID: 28196 RVA: 0x0020DD04 File Offset: 0x0020BF04
		// (set) Token: 0x06006E25 RID: 28197 RVA: 0x0003B8A9 File Offset: 0x00039AA9
		public unsafe TextMeshProUGUI m_PageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_PageIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_PageIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06006E26 RID: 28198 RVA: 0x0020DD34 File Offset: 0x0020BF34
		// (set) Token: 0x06006E27 RID: 28199 RVA: 0x0003B8C8 File Offset: 0x00039AC8
		public unsafe Dictionary<IntractableNewsObject, ObjectPool<IntractableNewsObject>> m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IntractableNewsObject, ObjectPool<IntractableNewsObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06006E28 RID: 28200 RVA: 0x0020DD64 File Offset: 0x0020BF64
		// (set) Token: 0x06006E29 RID: 28201 RVA: 0x0003B8E7 File Offset: 0x00039AE7
		public unsafe UILogicalGroupT<ValueTuple<IntractableNewsObject, IntractableNewsObject>> m_LogicalGroupT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_LogicalGroupT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<ValueTuple<IntractableNewsObject, IntractableNewsObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_LogicalGroupT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x06006E2A RID: 28202 RVA: 0x0020DD94 File Offset: 0x0020BF94
		// (set) Token: 0x06006E2B RID: 28203 RVA: 0x0003B906 File Offset: 0x00039B06
		public unsafe int m_CurrentPageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_CurrentPageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_CurrentPageIndex)) = value;
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x06006E2C RID: 28204 RVA: 0x0020DDBC File Offset: 0x0020BFBC
		// (set) Token: 0x06006E2D RID: 28205 RVA: 0x0003B921 File Offset: 0x00039B21
		public unsafe int m_TotalPageCountCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_TotalPageCountCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_TotalPageCountCache)) = value;
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x0020DDE4 File Offset: 0x0020BFE4
		// (set) Token: 0x06006E2F RID: 28207 RVA: 0x0003B93C File Offset: 0x00039B3C
		public unsafe RectTransform m_ActiveField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_ActiveField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.NativeFieldInfoPtr_m_ActiveField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048F3 RID: 18675
		private static readonly IntPtr NativeFieldInfoPtr_m_AllNewsPrefabs;

		// Token: 0x040048F4 RID: 18676
		private static readonly IntPtr NativeFieldInfoPtr_m_AllNewsDetailPannels;

		// Token: 0x040048F5 RID: 18677
		private static readonly IntPtr NativeFieldInfoPtr_m_Field1;

		// Token: 0x040048F6 RID: 18678
		private static readonly IntPtr NativeFieldInfoPtr_m_Field2;

		// Token: 0x040048F7 RID: 18679
		private static readonly IntPtr NativeFieldInfoPtr_m_Field3;

		// Token: 0x040048F8 RID: 18680
		private static readonly IntPtr NativeFieldInfoPtr_m_Field4;

		// Token: 0x040048F9 RID: 18681
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoPrevBtn;

		// Token: 0x040048FA RID: 18682
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoNextBtn;

		// Token: 0x040048FB RID: 18683
		private static readonly IntPtr NativeFieldInfoPtr_m_PageIndex;

		// Token: 0x040048FC RID: 18684
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x040048FD RID: 18685
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroupT;

		// Token: 0x040048FE RID: 18686
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPageIndex;

		// Token: 0x040048FF RID: 18687
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalPageCountCache;

		// Token: 0x04004900 RID: 18688
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveField;

		// Token: 0x04004901 RID: 18689
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004902 RID: 18690
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_0;

		// Token: 0x04004903 RID: 18691
		private static readonly IntPtr NativeMethodInfoPtr_BackToPrevious_Private_Void_0;

		// Token: 0x04004904 RID: 18692
		private static readonly IntPtr NativeMethodInfoPtr_ExitGroupAndUpdateCurrent_Private_Void_0;

		// Token: 0x04004905 RID: 18693
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004906 RID: 18694
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004907 RID: 18695
		private static readonly IntPtr NativeMethodInfoPtr_ExitGroupAndPrintPage_Private_Void_ReadOnlySpan_1_HistoryNewsData_0;

		// Token: 0x04004908 RID: 18696
		private static readonly IntPtr NativeMethodInfoPtr_CollectInstance_Private_Void_byref_ValueTuple_2_IntractableNewsObject_IntractableNewsObject_0;

		// Token: 0x04004909 RID: 18697
		private static readonly IntPtr NativeMethodInfoPtr_OpenDetailPanel_Private_Void_HistoryNewsData_0;

		// Token: 0x0400490A RID: 18698
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400490B RID: 18699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400490C RID: 18700
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_3_Private_Void_IntractableNewsObject_0;

		// Token: 0x0400490D RID: 18701
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_0_Private_Void_CallbackContext_0;

		// Token: 0x0400490E RID: 18702
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_1_Private_Void_CallbackContext_0;

		// Token: 0x0400490F RID: 18703
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0;

		// Token: 0x02000EC6 RID: 3782
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookNewsPannelExpandable+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x06010AA8 RID: 68264 RVA: 0x003DB7FC File Offset: 0x003D99FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr);
				NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeFieldInfoPtr_newsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr, "newsPrefab");
				NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr, 100685851);
				NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_IntractableNewsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr, 100685852);
			}

			// Token: 0x06010AA9 RID: 68265 RVA: 0x003DB878 File Offset: 0x003D9A78
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AAA RID: 68266 RVA: 0x003DB8B4 File Offset: 0x003D9AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275810, XrefRangeEnd = 275817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntractableNewsObject _OnPanelInitialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_IntractableNewsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntractableNewsObject>(intPtr3) : null;
			}

			// Token: 0x06010AAB RID: 68267 RVA: 0x0009166A File Offset: 0x0008F86A
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056E7 RID: 22247
			// (get) Token: 0x06010AAC RID: 68268 RVA: 0x003DB8F4 File Offset: 0x003D9AF4
			// (set) Token: 0x06010AAD RID: 68269 RVA: 0x00091673 File Offset: 0x0008F873
			public unsafe IntractableNewsObject newsPrefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeFieldInfoPtr_newsPrefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntractableNewsObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeFieldInfoPtr_newsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056E8 RID: 22248
			// (get) Token: 0x06010AAE RID: 68270 RVA: 0x003DB924 File Offset: 0x003D9B24
			// (set) Token: 0x06010AAF RID: 68271 RVA: 0x00091692 File Offset: 0x0008F892
			public unsafe NoteBookNewsPannelExpandable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookNewsPannelExpandable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A89B RID: 43163
			private static readonly IntPtr NativeFieldInfoPtr_newsPrefab;

			// Token: 0x0400A89C RID: 43164
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A89D RID: 43165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A89E RID: 43166
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_IntractableNewsObject_0;
		}

		// Token: 0x02000EC7 RID: 3783
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookNewsPannelExpandable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010AB0 RID: 68272 RVA: 0x003DB954 File Offset: 0x003D9B54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr);
				NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr, "<>9");
				NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9__14_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr, "<>9__14_4");
				NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9__14_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr, "<>9__14_5");
				NoteBookNewsPannelExpandable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr, 100685854);
				NoteBookNewsPannelExpandable.__c.NativeMethodInfoPtr__OnPanelInitialize_b__14_4_Internal_Void_IntractableNewsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr, 100685855);
				NoteBookNewsPannelExpandable.__c.NativeMethodInfoPtr__OnPanelInitialize_b__14_5_Internal_Void_IntractableNewsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr, 100685856);
			}

			// Token: 0x06010AB1 RID: 68273 RVA: 0x003DB9F8 File Offset: 0x003D9BF8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AB2 RID: 68274 RVA: 0x003DBA34 File Offset: 0x003D9C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275817, XrefRangeEnd = 275821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__14_4(IntractableNewsObject instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c.NativeMethodInfoPtr__OnPanelInitialize_b__14_4_Internal_Void_IntractableNewsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AB3 RID: 68275 RVA: 0x003DBA78 File Offset: 0x003D9C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275821, XrefRangeEnd = 275827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__14_5(IntractableNewsObject instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c.NativeMethodInfoPtr__OnPanelInitialize_b__14_5_Internal_Void_IntractableNewsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AB4 RID: 68276 RVA: 0x000916B1 File Offset: 0x0008F8B1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056E9 RID: 22249
			// (get) Token: 0x06010AB5 RID: 68277 RVA: 0x003DBABC File Offset: 0x003D9CBC
			// (set) Token: 0x06010AB6 RID: 68278 RVA: 0x000916BA File Offset: 0x0008F8BA
			public unsafe static NoteBookNewsPannelExpandable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookNewsPannelExpandable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056EA RID: 22250
			// (get) Token: 0x06010AB7 RID: 68279 RVA: 0x003DBAE4 File Offset: 0x003D9CE4
			// (set) Token: 0x06010AB8 RID: 68280 RVA: 0x000916CC File Offset: 0x0008F8CC
			public unsafe static Action<IntractableNewsObject> __9__14_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9__14_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntractableNewsObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9__14_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056EB RID: 22251
			// (get) Token: 0x06010AB9 RID: 68281 RVA: 0x003DBB0C File Offset: 0x003D9D0C
			// (set) Token: 0x06010ABA RID: 68282 RVA: 0x000916DE File Offset: 0x0008F8DE
			public unsafe static Action<IntractableNewsObject> __9__14_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9__14_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntractableNewsObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookNewsPannelExpandable.__c.NativeFieldInfoPtr___9__14_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A89F RID: 43167
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A8A0 RID: 43168
			private static readonly IntPtr NativeFieldInfoPtr___9__14_4;

			// Token: 0x0400A8A1 RID: 43169
			private static readonly IntPtr NativeFieldInfoPtr___9__14_5;

			// Token: 0x0400A8A2 RID: 43170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8A3 RID: 43171
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_4_Internal_Void_IntractableNewsObject_0;

			// Token: 0x0400A8A4 RID: 43172
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_5_Internal_Void_IntractableNewsObject_0;
		}

		// Token: 0x02000EC8 RID: 3784
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookNewsPannelExpandable+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06010ABB RID: 68283 RVA: 0x003DBB34 File Offset: 0x003D9D34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookNewsPannelExpandable>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr);
				NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeFieldInfoPtr_encapsulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr, "encapsulated");
				NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr, 100685857);
				NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeMethodInfoPtr__ExitGroupAndPrintPage_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr, 100685858);
			}

			// Token: 0x06010ABC RID: 68284 RVA: 0x003DBBB0 File Offset: 0x003D9DB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannelExpandable.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010ABD RID: 68285 RVA: 0x003DBBEC File Offset: 0x003D9DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275827, XrefRangeEnd = 275840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExitGroupAndPrintPage_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeMethodInfoPtr__ExitGroupAndPrintPage_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010ABE RID: 68286 RVA: 0x000916F0 File Offset: 0x0008F8F0
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056EC RID: 22252
			// (get) Token: 0x06010ABF RID: 68287 RVA: 0x003DBC20 File Offset: 0x003D9E20
			// (set) Token: 0x06010AC0 RID: 68288 RVA: 0x000916F9 File Offset: 0x0008F8F9
			public RunTimeScheduler.HistoryNewsData encapsulated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeFieldInfoPtr_encapsulated);
					return new RunTimeScheduler.HistoryNewsData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RunTimeScheduler.HistoryNewsData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeFieldInfoPtr_encapsulated), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RunTimeScheduler.HistoryNewsData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170056ED RID: 22253
			// (get) Token: 0x06010AC1 RID: 68289 RVA: 0x003DBC50 File Offset: 0x003D9E50
			// (set) Token: 0x06010AC2 RID: 68290 RVA: 0x00091727 File Offset: 0x0008F927
			public unsafe NoteBookNewsPannelExpandable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookNewsPannelExpandable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannelExpandable.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8A5 RID: 43173
			private static readonly IntPtr NativeFieldInfoPtr_encapsulated;

			// Token: 0x0400A8A6 RID: 43174
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8A7 RID: 43175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8A8 RID: 43176
			private static readonly IntPtr NativeMethodInfoPtr__ExitGroupAndPrintPage_b__1_Internal_Void_0;
		}
	}
}
