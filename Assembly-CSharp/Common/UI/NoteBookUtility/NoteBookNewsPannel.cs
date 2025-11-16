using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.CoreLanguage;
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

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000396 RID: 918
	public class NoteBookNewsPannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x06006DE0 RID: 28128 RVA: 0x0020CE2C File Offset: 0x0020B02C
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookNewsPannel()
		{
			Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookNewsPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr);
			NoteBookNewsPannel.NativeFieldInfoPtr_allNewPannelInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "allNewPannelInstances");
			NoteBookNewsPannel.NativeFieldInfoPtr_leftPannelA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "leftPannelA");
			NoteBookNewsPannel.NativeFieldInfoPtr_rightPannelA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "rightPannelA");
			NoteBookNewsPannel.NativeFieldInfoPtr_leftPannelB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "leftPannelB");
			NoteBookNewsPannel.NativeFieldInfoPtr_rightPannelB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "rightPannelB");
			NoteBookNewsPannel.NativeFieldInfoPtr_gotoPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "gotoPrevious");
			NoteBookNewsPannel.NativeFieldInfoPtr_gotoNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "gotoNext");
			NoteBookNewsPannel.NativeFieldInfoPtr_PageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "PageIndex");
			NoteBookNewsPannel.NativeFieldInfoPtr_m_AllInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "m_AllInstances");
			NoteBookNewsPannel.NativeFieldInfoPtr_m_CurrentPageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "m_CurrentPageIndex");
			NoteBookNewsPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685818);
			NoteBookNewsPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685819);
			NoteBookNewsPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685820);
			NoteBookNewsPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685821);
			NoteBookNewsPannel.NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685822);
			NoteBookNewsPannel.NativeMethodInfoPtr_OnScrollInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685823);
			NoteBookNewsPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685824);
			NoteBookNewsPannel.NativeMethodInfoPtr_BackToPrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685825);
			NoteBookNewsPannel.NativeMethodInfoPtr_UpdateCurrent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685826);
			NoteBookNewsPannel.NativeMethodInfoPtr_PrintPage_Private_Void_ReadOnlySpan_1_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685827);
			NoteBookNewsPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685828);
			NoteBookNewsPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685829);
			NoteBookNewsPannel.NativeMethodInfoPtr_Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, 100685830);
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06006DE1 RID: 28129 RVA: 0x0020D028 File Offset: 0x0020B228
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x0020D070 File Offset: 0x0020B270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275613, XrefRangeEnd = 275649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x0020D0AC File Offset: 0x0020B2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275649, XrefRangeEnd = 275654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0020D0E8 File Offset: 0x0020B2E8
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x0020D124 File Offset: 0x0020B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275654, XrefRangeEnd = 275658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryInput(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x0020D16C File Offset: 0x0020B36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275658, XrefRangeEnd = 275668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollInput(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_OnScrollInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x0020D1B4 File Offset: 0x0020B3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275668, XrefRangeEnd = 275673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x0020D1E8 File Offset: 0x0020B3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275673, XrefRangeEnd = 275674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackToPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_BackToPrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x0020D21C File Offset: 0x0020B41C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 275694, RefRangeEnd = 275699, XrefRangeStart = 275674, XrefRangeEnd = 275694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_UpdateCurrent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x0020D250 File Offset: 0x0020B450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275731, RefRangeEnd = 275732, XrefRangeStart = 275699, XrefRangeEnd = 275731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintPage(ReadOnlySpan<RunTimeScheduler.HistoryNewsData> pageData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pageData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_PrintPage_Private_Void_ReadOnlySpan_1_HistoryNewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x0020D298 File Offset: 0x0020B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275732, XrefRangeEnd = 275744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookNewsPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x0020D2D4 File Offset: 0x0020B4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275744, XrefRangeEnd = 275755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookNewsPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x0020D310 File Offset: 0x0020B510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 275806, RefRangeEnd = 275810, XrefRangeStart = 275755, XrefRangeEnd = 275806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0(RectTransform field, ReadOnlySpan<RunTimeScheduler.HistoryNewsData> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(collection));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.NativeMethodInfoPtr_Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0003B66D File Offset: 0x0003986D
		public NoteBookNewsPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x0020D36C File Offset: 0x0020B56C
		// (set) Token: 0x06006DF0 RID: 28144 RVA: 0x0003B676 File Offset: 0x00039876
		public unsafe Il2CppReferenceArray<GameObject> allNewPannelInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_allNewPannelInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_allNewPannelInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06006DF1 RID: 28145 RVA: 0x0020D39C File Offset: 0x0020B59C
		// (set) Token: 0x06006DF2 RID: 28146 RVA: 0x0003B695 File Offset: 0x00039895
		public unsafe RectTransform leftPannelA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_leftPannelA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_leftPannelA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06006DF3 RID: 28147 RVA: 0x0020D3CC File Offset: 0x0020B5CC
		// (set) Token: 0x06006DF4 RID: 28148 RVA: 0x0003B6B4 File Offset: 0x000398B4
		public unsafe RectTransform rightPannelA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_rightPannelA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_rightPannelA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x0020D3FC File Offset: 0x0020B5FC
		// (set) Token: 0x06006DF6 RID: 28150 RVA: 0x0003B6D3 File Offset: 0x000398D3
		public unsafe RectTransform leftPannelB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_leftPannelB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_leftPannelB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06006DF7 RID: 28151 RVA: 0x0020D42C File Offset: 0x0020B62C
		// (set) Token: 0x06006DF8 RID: 28152 RVA: 0x0003B6F2 File Offset: 0x000398F2
		public unsafe RectTransform rightPannelB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_rightPannelB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_rightPannelB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x0020D45C File Offset: 0x0020B65C
		// (set) Token: 0x06006DFA RID: 28154 RVA: 0x0003B711 File Offset: 0x00039911
		public unsafe UIButtonSimple gotoPrevious
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_gotoPrevious);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_gotoPrevious), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06006DFB RID: 28155 RVA: 0x0020D48C File Offset: 0x0020B68C
		// (set) Token: 0x06006DFC RID: 28156 RVA: 0x0003B730 File Offset: 0x00039930
		public unsafe UIButtonSimple gotoNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_gotoNext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_gotoNext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06006DFD RID: 28157 RVA: 0x0020D4BC File Offset: 0x0020B6BC
		// (set) Token: 0x06006DFE RID: 28158 RVA: 0x0003B74F File Offset: 0x0003994F
		public unsafe TextMeshProUGUI PageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_PageIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_PageIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x0020D4EC File Offset: 0x0020B6EC
		// (set) Token: 0x06006E00 RID: 28160 RVA: 0x0003B76E File Offset: 0x0003996E
		public unsafe HashSet<GameObject> m_AllInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_m_AllInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_m_AllInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06006E01 RID: 28161 RVA: 0x0020D51C File Offset: 0x0020B71C
		// (set) Token: 0x06006E02 RID: 28162 RVA: 0x0003B78D File Offset: 0x0003998D
		public unsafe int m_CurrentPageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_m_CurrentPageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.NativeFieldInfoPtr_m_CurrentPageIndex)) = value;
			}
		}

		// Token: 0x040048DC RID: 18652
		private static readonly IntPtr NativeFieldInfoPtr_allNewPannelInstances;

		// Token: 0x040048DD RID: 18653
		private static readonly IntPtr NativeFieldInfoPtr_leftPannelA;

		// Token: 0x040048DE RID: 18654
		private static readonly IntPtr NativeFieldInfoPtr_rightPannelA;

		// Token: 0x040048DF RID: 18655
		private static readonly IntPtr NativeFieldInfoPtr_leftPannelB;

		// Token: 0x040048E0 RID: 18656
		private static readonly IntPtr NativeFieldInfoPtr_rightPannelB;

		// Token: 0x040048E1 RID: 18657
		private static readonly IntPtr NativeFieldInfoPtr_gotoPrevious;

		// Token: 0x040048E2 RID: 18658
		private static readonly IntPtr NativeFieldInfoPtr_gotoNext;

		// Token: 0x040048E3 RID: 18659
		private static readonly IntPtr NativeFieldInfoPtr_PageIndex;

		// Token: 0x040048E4 RID: 18660
		private static readonly IntPtr NativeFieldInfoPtr_m_AllInstances;

		// Token: 0x040048E5 RID: 18661
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPageIndex;

		// Token: 0x040048E6 RID: 18662
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040048E7 RID: 18663
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040048E8 RID: 18664
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040048E9 RID: 18665
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040048EA RID: 18666
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0;

		// Token: 0x040048EB RID: 18667
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollInput_Private_Void_CallbackContext_0;

		// Token: 0x040048EC RID: 18668
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_0;

		// Token: 0x040048ED RID: 18669
		private static readonly IntPtr NativeMethodInfoPtr_BackToPrevious_Private_Void_0;

		// Token: 0x040048EE RID: 18670
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrent_Private_Void_0;

		// Token: 0x040048EF RID: 18671
		private static readonly IntPtr NativeMethodInfoPtr_PrintPage_Private_Void_ReadOnlySpan_1_HistoryNewsData_0;

		// Token: 0x040048F0 RID: 18672
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040048F1 RID: 18673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040048F2 RID: 18674
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_RectTransform_ReadOnlySpan_1_HistoryNewsData_0;

		// Token: 0x02000EC4 RID: 3780
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookNewsPannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06010A9B RID: 68251 RVA: 0x003DB574 File Offset: 0x003D9774
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_0>.NativeClassPtr);
				NoteBookNewsPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_0>.NativeClassPtr, "data");
				NoteBookNewsPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_0>.NativeClassPtr, 100685831);
				NoteBookNewsPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__PrintPage_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_0>.NativeClassPtr, 100685832);
			}

			// Token: 0x06010A9C RID: 68252 RVA: 0x003DB5DC File Offset: 0x003D97DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A9D RID: 68253 RVA: 0x003DB618 File Offset: 0x003D9818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275610, XrefRangeEnd = 275611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PrintPage_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__PrintPage_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A9E RID: 68254 RVA: 0x0009160B File Offset: 0x0008F80B
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056E5 RID: 22245
			// (get) Token: 0x06010A9F RID: 68255 RVA: 0x003DB65C File Offset: 0x003D985C
			// (set) Token: 0x06010AA0 RID: 68256 RVA: 0x00091614 File Offset: 0x0008F814
			public RunTimeScheduler.HistoryNewsData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_data);
					return new RunTimeScheduler.HistoryNewsData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RunTimeScheduler.HistoryNewsData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RunTimeScheduler.HistoryNewsData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A894 RID: 43156
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400A895 RID: 43157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A896 RID: 43158
			private static readonly IntPtr NativeMethodInfoPtr__PrintPage_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EC5 RID: 3781
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookNewsPannel+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
		{
			// Token: 0x06010AA1 RID: 68257 RVA: 0x003DB68C File Offset: 0x003D988C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookNewsPannel>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr);
				NoteBookNewsPannel.__c__DisplayClass20_1.NativeFieldInfoPtr_newsReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr, "newsReference");
				NoteBookNewsPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr, 100685833);
				NoteBookNewsPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__PrintPage_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr, 100685834);
				NoteBookNewsPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__PrintPage_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr, 100685835);
			}

			// Token: 0x06010AA2 RID: 68258 RVA: 0x003DB708 File Offset: 0x003D9908
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookNewsPannel.__c__DisplayClass20_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AA3 RID: 68259 RVA: 0x003DB744 File Offset: 0x003D9944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PrintPage_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__PrintPage_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AA4 RID: 68260 RVA: 0x003DB788 File Offset: 0x003D9988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275611, XrefRangeEnd = 275613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PrintPage_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookNewsPannel.__c__DisplayClass20_1.NativeMethodInfoPtr__PrintPage_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AA5 RID: 68261 RVA: 0x00091642 File Offset: 0x0008F842
			public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056E6 RID: 22246
			// (get) Token: 0x06010AA6 RID: 68262 RVA: 0x003DB7CC File Offset: 0x003D99CC
			// (set) Token: 0x06010AA7 RID: 68263 RVA: 0x0009164B File Offset: 0x0008F84B
			public unsafe LanguageBase newsReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.__c__DisplayClass20_1.NativeFieldInfoPtr_newsReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookNewsPannel.__c__DisplayClass20_1.NativeFieldInfoPtr_newsReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A897 RID: 43159
			private static readonly IntPtr NativeFieldInfoPtr_newsReference;

			// Token: 0x0400A898 RID: 43160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A899 RID: 43161
			private static readonly IntPtr NativeMethodInfoPtr__PrintPage_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A89A RID: 43162
			private static readonly IntPtr NativeMethodInfoPtr__PrintPage_b__3_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
