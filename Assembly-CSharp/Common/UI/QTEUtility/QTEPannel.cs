using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using UnityEngine;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000391 RID: 913
	public class QTEPannel : QTEPannelBase
	{
		// Token: 0x06006CB7 RID: 27831 RVA: 0x00209158 File Offset: 0x00207358
		// Note: this type is marked as 'beforefieldinit'.
		static QTEPannel()
		{
			Il2CppClassPointerStore<QTEPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "QTEPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr);
			QTEPannel.NativeFieldInfoPtr_NOTE_VERTICAL_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "NOTE_VERTICAL_OFFSET");
			QTEPannel.NativeFieldInfoPtr_m_NoteFieldUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_NoteFieldUp");
			QTEPannel.NativeFieldInfoPtr_m_NoteFieldDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_NoteFieldDown");
			QTEPannel.NativeFieldInfoPtr_m_AutoIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_AutoIndicator");
			QTEPannel.NativeFieldInfoPtr_m_Beats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_Beats");
			QTEPannel.NativeFieldInfoPtr_m_SleepingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_SleepingNotes");
			QTEPannel.NativeFieldInfoPtr_m_ActiveNoteTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_ActiveNoteTransform");
			QTEPannel.NativeFieldInfoPtr_m_NoteBeatCalledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_NoteBeatCalledThisFrame");
			QTEPannel.NativeFieldInfoPtr_m_NoteFieldWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_NoteFieldWidth");
			QTEPannel.NativeFieldInfoPtr_m_OnNoteBeatCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "m_OnNoteBeatCallback");
			QTEPannel.NativeFieldInfoPtr__tokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "_tokenSource");
			QTEPannel.NativeFieldInfoPtr__IsBreak_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "<IsBreak>k__BackingField");
			QTEPannel.NativeFieldInfoPtr__shouldRunExtraUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "_shouldRunExtraUpdate");
			QTEPannel.NativeFieldInfoPtr_OnAllNotesFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "OnAllNotesFinishCallback");
			QTEPannel.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "_collection");
			QTEPannel.NativeMethodInfoPtr_set_IsBreak_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685680);
			QTEPannel.NativeMethodInfoPtr_get_IsBreak_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685681);
			QTEPannel.NativeMethodInfoPtr_get_ActiveNoteField_Protected_Virtual_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685682);
			QTEPannel.NativeMethodInfoPtr_add_OnAllNotesFinishCallback_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685683);
			QTEPannel.NativeMethodInfoPtr_remove_OnAllNotesFinishCallback_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685684);
			QTEPannel.NativeMethodInfoPtr_BreakAndClose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685685);
			QTEPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685686);
			QTEPannel.NativeMethodInfoPtr_ResetProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685687);
			QTEPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685688);
			QTEPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685689);
			QTEPannel.NativeMethodInfoPtr_GetAllVisualNotesQueue_Private_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685690);
			QTEPannel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685691);
			QTEPannel.NativeMethodInfoPtr_RunNoteUpdate_Private_UniTaskVoid_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685692);
			QTEPannel.NativeMethodInfoPtr_MoveSleepingNotesToUpdatingNotes_Private_Void_Int64_Queue_1_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685693);
			QTEPannel.NativeMethodInfoPtr_GetNoteCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685694);
			QTEPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685695);
			QTEPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, 100685696);
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x00209448 File Offset: 0x00207648
		// (set) Token: 0x06006CB8 RID: 27832 RVA: 0x00209408 File Offset: 0x00207608
		public unsafe bool IsBreak
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_get_IsBreak_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_set_IsBreak_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x06006CBA RID: 27834 RVA: 0x00209484 File Offset: 0x00207684
		public unsafe override RectTransform ActiveNoteField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannel.NativeMethodInfoPtr_get_ActiveNoteField_Protected_Virtual_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x002094D0 File Offset: 0x002076D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273965, RefRangeEnd = 273967, XrefRangeStart = 273961, XrefRangeEnd = 273965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAllNotesFinishCallback(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_add_OnAllNotesFinishCallback_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00209514 File Offset: 0x00207714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273967, XrefRangeEnd = 273971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAllNotesFinishCallback(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_remove_OnAllNotesFinishCallback_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00209558 File Offset: 0x00207758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273979, RefRangeEnd = 273981, XrefRangeStart = 273971, XrefRangeEnd = 273979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreakAndClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_BreakAndClose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x0020958C File Offset: 0x0020778C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273981, XrefRangeEnd = 273983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x002095C8 File Offset: 0x002077C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273983, XrefRangeEnd = 273987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_ResetProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x002095FC File Offset: 0x002077FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273987, XrefRangeEnd = 274114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x00209638 File Offset: 0x00207838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274114, XrefRangeEnd = 274123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x00209674 File Offset: 0x00207874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274224, RefRangeEnd = 274225, XrefRangeStart = 274123, XrefRangeEnd = 274224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue<NoteHeadBase> GetAllVisualNotesQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_GetAllVisualNotesQueue_Private_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<NoteHeadBase>>(intPtr3) : null;
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x002096B4 File Offset: 0x002078B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274225, XrefRangeEnd = 274234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x002096E8 File Offset: 0x002078E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274234, XrefRangeEnd = 274240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid RunNoteUpdate(CancellationToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_RunNoteUpdate_Private_UniTaskVoid_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x0020973C File Offset: 0x0020793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274296, RefRangeEnd = 274297, XrefRangeStart = 274240, XrefRangeEnd = 274296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveSleepingNotesToUpdatingNotes(long noteStartUpdateTime, Queue<IzakayaMusic.SingleNote> willSpawnNotes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref noteStartUpdateTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willSpawnNotes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr_MoveSleepingNotesToUpdatingNotes_Private_Void_Int64_Queue_1_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x0020978C File Offset: 0x0020798C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274297, XrefRangeEnd = 274349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNoteCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannel.NativeMethodInfoPtr_GetNoteCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x002097D4 File Offset: 0x002079D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274349, XrefRangeEnd = 274366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00209810 File Offset: 0x00207A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274366, XrefRangeEnd = 274392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QTEPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x0003AC36 File Offset: 0x00038E36
		public QTEPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x0020984C File Offset: 0x00207A4C
		// (set) Token: 0x06006CCB RID: 27851 RVA: 0x0003AC3F File Offset: 0x00038E3F
		public unsafe static float NOTE_VERTICAL_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(QTEPannel.NativeFieldInfoPtr_NOTE_VERTICAL_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QTEPannel.NativeFieldInfoPtr_NOTE_VERTICAL_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x00209868 File Offset: 0x00207A68
		// (set) Token: 0x06006CCD RID: 27853 RVA: 0x0003AC4D File Offset: 0x00038E4D
		public unsafe RectTransform m_NoteFieldUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteFieldUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteFieldUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06006CCE RID: 27854 RVA: 0x00209898 File Offset: 0x00207A98
		// (set) Token: 0x06006CCF RID: 27855 RVA: 0x0003AC6C File Offset: 0x00038E6C
		public unsafe RectTransform m_NoteFieldDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteFieldDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteFieldDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x06006CD0 RID: 27856 RVA: 0x002098C8 File Offset: 0x00207AC8
		// (set) Token: 0x06006CD1 RID: 27857 RVA: 0x0003AC8B File Offset: 0x00038E8B
		public unsafe GameObject m_AutoIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_AutoIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_AutoIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x06006CD2 RID: 27858 RVA: 0x002098F8 File Offset: 0x00207AF8
		// (set) Token: 0x06006CD3 RID: 27859 RVA: 0x0003ACAA File Offset: 0x00038EAA
		public unsafe Queue<long> m_Beats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_Beats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_Beats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x06006CD4 RID: 27860 RVA: 0x00209928 File Offset: 0x00207B28
		// (set) Token: 0x06006CD5 RID: 27861 RVA: 0x0003ACC9 File Offset: 0x00038EC9
		public unsafe Queue<IzakayaMusic.SingleNote> m_SleepingNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_SleepingNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<IzakayaMusic.SingleNote>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_SleepingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x06006CD6 RID: 27862 RVA: 0x00209958 File Offset: 0x00207B58
		// (set) Token: 0x06006CD7 RID: 27863 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		public unsafe RectTransform m_ActiveNoteTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_ActiveNoteTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_ActiveNoteTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x06006CD8 RID: 27864 RVA: 0x00209988 File Offset: 0x00207B88
		// (set) Token: 0x06006CD9 RID: 27865 RVA: 0x0003AD07 File Offset: 0x00038F07
		public unsafe bool m_NoteBeatCalledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteBeatCalledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteBeatCalledThisFrame)) = value;
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x06006CDA RID: 27866 RVA: 0x002099B0 File Offset: 0x00207BB0
		// (set) Token: 0x06006CDB RID: 27867 RVA: 0x0003AD22 File Offset: 0x00038F22
		public unsafe float m_NoteFieldWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteFieldWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_NoteFieldWidth)) = value;
			}
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x06006CDC RID: 27868 RVA: 0x002099D8 File Offset: 0x00207BD8
		// (set) Token: 0x06006CDD RID: 27869 RVA: 0x0003AD3D File Offset: 0x00038F3D
		public unsafe Action m_OnNoteBeatCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_OnNoteBeatCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_m_OnNoteBeatCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x06006CDE RID: 27870 RVA: 0x00209A08 File Offset: 0x00207C08
		// (set) Token: 0x06006CDF RID: 27871 RVA: 0x0003AD5C File Offset: 0x00038F5C
		public unsafe CancellationTokenSource _tokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__tokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__tokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x06006CE0 RID: 27872 RVA: 0x00209A38 File Offset: 0x00207C38
		// (set) Token: 0x06006CE1 RID: 27873 RVA: 0x0003AD7B File Offset: 0x00038F7B
		public unsafe bool _IsBreak_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__IsBreak_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__IsBreak_k__BackingField)) = value;
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x00209A60 File Offset: 0x00207C60
		// (set) Token: 0x06006CE3 RID: 27875 RVA: 0x0003AD96 File Offset: 0x00038F96
		public unsafe bool _shouldRunExtraUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__shouldRunExtraUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__shouldRunExtraUpdate)) = value;
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x06006CE4 RID: 27876 RVA: 0x00209A88 File Offset: 0x00207C88
		// (set) Token: 0x06006CE5 RID: 27877 RVA: 0x0003ADB1 File Offset: 0x00038FB1
		public unsafe Action OnAllNotesFinishCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_OnAllNotesFinishCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr_OnAllNotesFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x00209AB8 File Offset: 0x00207CB8
		// (set) Token: 0x06006CE7 RID: 27879 RVA: 0x0003ADD0 File Offset: 0x00038FD0
		public unsafe Queue<NoteHeadBase> _collection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__collection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.NativeFieldInfoPtr__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004815 RID: 18453
		private static readonly IntPtr NativeFieldInfoPtr_NOTE_VERTICAL_OFFSET;

		// Token: 0x04004816 RID: 18454
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteFieldUp;

		// Token: 0x04004817 RID: 18455
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteFieldDown;

		// Token: 0x04004818 RID: 18456
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoIndicator;

		// Token: 0x04004819 RID: 18457
		private static readonly IntPtr NativeFieldInfoPtr_m_Beats;

		// Token: 0x0400481A RID: 18458
		private static readonly IntPtr NativeFieldInfoPtr_m_SleepingNotes;

		// Token: 0x0400481B RID: 18459
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveNoteTransform;

		// Token: 0x0400481C RID: 18460
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteBeatCalledThisFrame;

		// Token: 0x0400481D RID: 18461
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteFieldWidth;

		// Token: 0x0400481E RID: 18462
		private static readonly IntPtr NativeFieldInfoPtr_m_OnNoteBeatCallback;

		// Token: 0x0400481F RID: 18463
		private static readonly IntPtr NativeFieldInfoPtr__tokenSource;

		// Token: 0x04004820 RID: 18464
		private static readonly IntPtr NativeFieldInfoPtr__IsBreak_k__BackingField;

		// Token: 0x04004821 RID: 18465
		private static readonly IntPtr NativeFieldInfoPtr__shouldRunExtraUpdate;

		// Token: 0x04004822 RID: 18466
		private static readonly IntPtr NativeFieldInfoPtr_OnAllNotesFinishCallback;

		// Token: 0x04004823 RID: 18467
		private static readonly IntPtr NativeFieldInfoPtr__collection;

		// Token: 0x04004824 RID: 18468
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBreak_Private_set_Void_Boolean_0;

		// Token: 0x04004825 RID: 18469
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBreak_Public_get_Boolean_0;

		// Token: 0x04004826 RID: 18470
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveNoteField_Protected_Virtual_get_RectTransform_0;

		// Token: 0x04004827 RID: 18471
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAllNotesFinishCallback_Public_add_Void_Action_0;

		// Token: 0x04004828 RID: 18472
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAllNotesFinishCallback_Public_rem_Void_Action_0;

		// Token: 0x04004829 RID: 18473
		private static readonly IntPtr NativeMethodInfoPtr_BreakAndClose_Public_Void_0;

		// Token: 0x0400482A RID: 18474
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400482B RID: 18475
		private static readonly IntPtr NativeMethodInfoPtr_ResetProgress_Private_Void_0;

		// Token: 0x0400482C RID: 18476
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400482D RID: 18477
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400482E RID: 18478
		private static readonly IntPtr NativeMethodInfoPtr_GetAllVisualNotesQueue_Private_Queue_1_NoteHeadBase_0;

		// Token: 0x0400482F RID: 18479
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004830 RID: 18480
		private static readonly IntPtr NativeMethodInfoPtr_RunNoteUpdate_Private_UniTaskVoid_CancellationToken_0;

		// Token: 0x04004831 RID: 18481
		private static readonly IntPtr NativeMethodInfoPtr_MoveSleepingNotesToUpdatingNotes_Private_Void_Int64_Queue_1_SingleNote_0;

		// Token: 0x04004832 RID: 18482
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteCount_Protected_Virtual_Int32_0;

		// Token: 0x04004833 RID: 18483
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004834 RID: 18484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EBA RID: 3770
		public sealed class PannelOpenContext : ValueType
		{
			// Token: 0x06010A17 RID: 68119 RVA: 0x003D9EEC File Offset: 0x003D80EC
			// Note: this type is marked as 'beforefieldinit'.
			static PannelOpenContext()
			{
				Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "PannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr);
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_NoteToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "NoteToProcess");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_GetCurrentTimeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "GetCurrentTimeCallback");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_WorkMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "WorkMode");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_NoteBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "NoteBeat");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnNoteBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "OnNoteBeat");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnComboUpdateInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "OnComboUpdateInParent");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnScoreUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "OnScoreUpdate");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "MusicalNoteSpeed");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_AutoPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "AutoPlayMode");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MidiBarLengthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "MidiBarLengthMultiplier");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_StartQTEMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "StartQTEMilliseconds");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_EndQTEMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "EndQTEMilliseconds");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MusicSwitchLengthMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "MusicSwitchLengthMilliseconds");
				QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnSingleNoteProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, "OnSingleNoteProcess");
				QTEPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SingleNote_Func_1_Int64_Boolean_Il2CppStructArray_1_Int64_Action_Action_1_Int32_Action_1_Single_Single_Boolean_Single_Int64_Int64_Int64_Action_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, 100685697);
				QTEPannel.PannelOpenContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr, 100685698);
			}

			// Token: 0x06010A18 RID: 68120 RVA: 0x003DA058 File Offset: 0x003D8258
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 273798, RefRangeEnd = 273800, XrefRangeStart = 273781, XrefRangeEnd = 273798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PannelOpenContext(Il2CppStructArray<IzakayaMusic.SingleNote> noteToProcess, Func<long> getCurrentTimeCallback, bool workMode, Il2CppStructArray<long> noteBeat, Action onNoteBeat, Action<int> onComboUpdateInParent, Action<float> onScoreUpdate, float musicalNoteSpeed, bool autoPlayMode, float midiBarLengthMultiplier, long startQTEMilliseconds, long endQTEMilliseconds, long musicSwitchLengthMilliseconds, Action<long> onSingleNoteProcess) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteToProcess);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getCurrentTimeCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workMode;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(noteBeat);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onNoteBeat);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComboUpdateInParent);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onScoreUpdate);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicalNoteSpeed;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoPlayMode;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiBarLengthMultiplier;
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startQTEMilliseconds;
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endQTEMilliseconds;
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicSwitchLengthMilliseconds;
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSingleNoteProcess);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SingleNote_Func_1_Int64_Boolean_Il2CppStructArray_1_Int64_Action_Action_1_Int32_Action_1_Single_Single_Boolean_Single_Int64_Int64_Int64_Action_1_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A19 RID: 68121 RVA: 0x003DA184 File Offset: 0x003D8384
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 273831, RefRangeEnd = 273832, XrefRangeStart = 273800, XrefRangeEnd = 273831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.PannelOpenContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010A1A RID: 68122 RVA: 0x00091138 File Offset: 0x0008F338
			public PannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010A1B RID: 68123 RVA: 0x00091141 File Offset: 0x0008F341
			public PannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannel.PannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170056B9 RID: 22201
			// (get) Token: 0x06010A1C RID: 68124 RVA: 0x003DA1C0 File Offset: 0x003D83C0
			// (set) Token: 0x06010A1D RID: 68125 RVA: 0x00091153 File Offset: 0x0008F353
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> NoteToProcess
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_NoteToProcess);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_NoteToProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056BA RID: 22202
			// (get) Token: 0x06010A1E RID: 68126 RVA: 0x003DA1F0 File Offset: 0x003D83F0
			// (set) Token: 0x06010A1F RID: 68127 RVA: 0x00091172 File Offset: 0x0008F372
			public unsafe Func<long> GetCurrentTimeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_GetCurrentTimeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_GetCurrentTimeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056BB RID: 22203
			// (get) Token: 0x06010A20 RID: 68128 RVA: 0x003DA220 File Offset: 0x003D8420
			// (set) Token: 0x06010A21 RID: 68129 RVA: 0x00091191 File Offset: 0x0008F391
			public unsafe bool WorkMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_WorkMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_WorkMode)) = value;
				}
			}

			// Token: 0x170056BC RID: 22204
			// (get) Token: 0x06010A22 RID: 68130 RVA: 0x003DA248 File Offset: 0x003D8448
			// (set) Token: 0x06010A23 RID: 68131 RVA: 0x000911AC File Offset: 0x0008F3AC
			public unsafe Il2CppStructArray<long> NoteBeat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_NoteBeat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_NoteBeat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056BD RID: 22205
			// (get) Token: 0x06010A24 RID: 68132 RVA: 0x003DA278 File Offset: 0x003D8478
			// (set) Token: 0x06010A25 RID: 68133 RVA: 0x000911CB File Offset: 0x0008F3CB
			public unsafe Action OnNoteBeat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnNoteBeat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnNoteBeat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056BE RID: 22206
			// (get) Token: 0x06010A26 RID: 68134 RVA: 0x003DA2A8 File Offset: 0x003D84A8
			// (set) Token: 0x06010A27 RID: 68135 RVA: 0x000911EA File Offset: 0x0008F3EA
			public unsafe Action<int> OnComboUpdateInParent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnComboUpdateInParent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnComboUpdateInParent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056BF RID: 22207
			// (get) Token: 0x06010A28 RID: 68136 RVA: 0x003DA2D8 File Offset: 0x003D84D8
			// (set) Token: 0x06010A29 RID: 68137 RVA: 0x00091209 File Offset: 0x0008F409
			public unsafe Action<float> OnScoreUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnScoreUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnScoreUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056C0 RID: 22208
			// (get) Token: 0x06010A2A RID: 68138 RVA: 0x003DA308 File Offset: 0x003D8508
			// (set) Token: 0x06010A2B RID: 68139 RVA: 0x00091228 File Offset: 0x0008F428
			public unsafe float MusicalNoteSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MusicalNoteSpeed)) = value;
				}
			}

			// Token: 0x170056C1 RID: 22209
			// (get) Token: 0x06010A2C RID: 68140 RVA: 0x003DA330 File Offset: 0x003D8530
			// (set) Token: 0x06010A2D RID: 68141 RVA: 0x00091243 File Offset: 0x0008F443
			public unsafe bool AutoPlayMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_AutoPlayMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_AutoPlayMode)) = value;
				}
			}

			// Token: 0x170056C2 RID: 22210
			// (get) Token: 0x06010A2E RID: 68142 RVA: 0x003DA358 File Offset: 0x003D8558
			// (set) Token: 0x06010A2F RID: 68143 RVA: 0x0009125E File Offset: 0x0008F45E
			public unsafe float MidiBarLengthMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MidiBarLengthMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MidiBarLengthMultiplier)) = value;
				}
			}

			// Token: 0x170056C3 RID: 22211
			// (get) Token: 0x06010A30 RID: 68144 RVA: 0x003DA380 File Offset: 0x003D8580
			// (set) Token: 0x06010A31 RID: 68145 RVA: 0x00091279 File Offset: 0x0008F479
			public unsafe long StartQTEMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_StartQTEMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_StartQTEMilliseconds)) = value;
				}
			}

			// Token: 0x170056C4 RID: 22212
			// (get) Token: 0x06010A32 RID: 68146 RVA: 0x003DA3A8 File Offset: 0x003D85A8
			// (set) Token: 0x06010A33 RID: 68147 RVA: 0x00091294 File Offset: 0x0008F494
			public unsafe long EndQTEMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_EndQTEMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_EndQTEMilliseconds)) = value;
				}
			}

			// Token: 0x170056C5 RID: 22213
			// (get) Token: 0x06010A34 RID: 68148 RVA: 0x003DA3D0 File Offset: 0x003D85D0
			// (set) Token: 0x06010A35 RID: 68149 RVA: 0x000912AF File Offset: 0x0008F4AF
			public unsafe long MusicSwitchLengthMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MusicSwitchLengthMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_MusicSwitchLengthMilliseconds)) = value;
				}
			}

			// Token: 0x170056C6 RID: 22214
			// (get) Token: 0x06010A36 RID: 68150 RVA: 0x003DA3F8 File Offset: 0x003D85F8
			// (set) Token: 0x06010A37 RID: 68151 RVA: 0x000912CA File Offset: 0x0008F4CA
			public unsafe Action<long> OnSingleNoteProcess
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnSingleNoteProcess);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<long>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel.PannelOpenContext.NativeFieldInfoPtr_OnSingleNoteProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A84C RID: 43084
			private static readonly IntPtr NativeFieldInfoPtr_NoteToProcess;

			// Token: 0x0400A84D RID: 43085
			private static readonly IntPtr NativeFieldInfoPtr_GetCurrentTimeCallback;

			// Token: 0x0400A84E RID: 43086
			private static readonly IntPtr NativeFieldInfoPtr_WorkMode;

			// Token: 0x0400A84F RID: 43087
			private static readonly IntPtr NativeFieldInfoPtr_NoteBeat;

			// Token: 0x0400A850 RID: 43088
			private static readonly IntPtr NativeFieldInfoPtr_OnNoteBeat;

			// Token: 0x0400A851 RID: 43089
			private static readonly IntPtr NativeFieldInfoPtr_OnComboUpdateInParent;

			// Token: 0x0400A852 RID: 43090
			private static readonly IntPtr NativeFieldInfoPtr_OnScoreUpdate;

			// Token: 0x0400A853 RID: 43091
			private static readonly IntPtr NativeFieldInfoPtr_MusicalNoteSpeed;

			// Token: 0x0400A854 RID: 43092
			private static readonly IntPtr NativeFieldInfoPtr_AutoPlayMode;

			// Token: 0x0400A855 RID: 43093
			private static readonly IntPtr NativeFieldInfoPtr_MidiBarLengthMultiplier;

			// Token: 0x0400A856 RID: 43094
			private static readonly IntPtr NativeFieldInfoPtr_StartQTEMilliseconds;

			// Token: 0x0400A857 RID: 43095
			private static readonly IntPtr NativeFieldInfoPtr_EndQTEMilliseconds;

			// Token: 0x0400A858 RID: 43096
			private static readonly IntPtr NativeFieldInfoPtr_MusicSwitchLengthMilliseconds;

			// Token: 0x0400A859 RID: 43097
			private static readonly IntPtr NativeFieldInfoPtr_OnSingleNoteProcess;

			// Token: 0x0400A85A RID: 43098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SingleNote_Func_1_Int64_Boolean_Il2CppStructArray_1_Int64_Action_Action_1_Int32_Action_1_Single_Single_Boolean_Single_Int64_Int64_Int64_Action_1_Int64_0;

			// Token: 0x0400A85B RID: 43099
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x02000EBB RID: 3771
		[ObfuscatedName("Common.UI.QTEUtility.QTEPannel+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010A38 RID: 68152 RVA: 0x003DA428 File Offset: 0x003D8628
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr);
				QTEPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9");
				QTEPannel.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__24_0");
				QTEPannel.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__24_1");
				QTEPannel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__29_0");
				QTEPannel.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__29_1");
				QTEPannel.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__31_0");
				QTEPannel.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__31_1");
				QTEPannel.__c.NativeFieldInfoPtr___9__31_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, "<>9__31_2");
				QTEPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685700);
				QTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__24_0_Internal_Int64_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685701);
				QTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__24_1_Internal_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685702);
				QTEPannel.__c.NativeMethodInfoPtr__RunNoteUpdate_b__29_0_Internal_Boolean_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685703);
				QTEPannel.__c.NativeMethodInfoPtr__RunNoteUpdate_b__29_1_Internal_Boolean_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685704);
				QTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__31_0_Internal_Int32_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685705);
				QTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__31_1_Internal_Int32_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685706);
				QTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__31_2_Internal_Int32_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr, 100685707);
			}

			// Token: 0x06010A39 RID: 68153 RVA: 0x003DA594 File Offset: 0x003D8794
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A3A RID: 68154 RVA: 0x003DA5D0 File Offset: 0x003D87D0
			[CallerCount(0)]
			public unsafe long _OnPanelOpen_b__24_0(IzakayaMusic.SingleNote x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__24_0_Internal_Int64_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A3B RID: 68155 RVA: 0x003DA61C File Offset: 0x003D881C
			[CallerCount(0)]
			public unsafe long _OnPanelOpen_b__24_1(long x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__24_1_Internal_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A3C RID: 68156 RVA: 0x003DA668 File Offset: 0x003D8868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273832, XrefRangeEnd = 273834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunNoteUpdate_b__29_0(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__RunNoteUpdate_b__29_0_Internal_Boolean_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A3D RID: 68157 RVA: 0x003DA6BC File Offset: 0x003D88BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273834, XrefRangeEnd = 273836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunNoteUpdate_b__29_1(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__RunNoteUpdate_b__29_1_Internal_Boolean_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A3E RID: 68158 RVA: 0x003DA710 File Offset: 0x003D8910
			[CallerCount(0)]
			public unsafe int _GetNoteCount_b__31_0(IzakayaMusic.SingleNote x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__31_0_Internal_Int32_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A3F RID: 68159 RVA: 0x003DA75C File Offset: 0x003D895C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273836, XrefRangeEnd = 273838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetNoteCount_b__31_1(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__31_1_Internal_Int32_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A40 RID: 68160 RVA: 0x003DA7B0 File Offset: 0x003D89B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273838, XrefRangeEnd = 273840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetNoteCount_b__31_2(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__31_2_Internal_Int32_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A41 RID: 68161 RVA: 0x000912E9 File Offset: 0x0008F4E9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056C7 RID: 22215
			// (get) Token: 0x06010A42 RID: 68162 RVA: 0x003DA804 File Offset: 0x003D8A04
			// (set) Token: 0x06010A43 RID: 68163 RVA: 0x000912F2 File Offset: 0x0008F4F2
			public unsafe static QTEPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056C8 RID: 22216
			// (get) Token: 0x06010A44 RID: 68164 RVA: 0x003DA82C File Offset: 0x003D8A2C
			// (set) Token: 0x06010A45 RID: 68165 RVA: 0x00091304 File Offset: 0x0008F504
			public unsafe static Func<IzakayaMusic.SingleNote, long> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IzakayaMusic.SingleNote, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056C9 RID: 22217
			// (get) Token: 0x06010A46 RID: 68166 RVA: 0x003DA854 File Offset: 0x003D8A54
			// (set) Token: 0x06010A47 RID: 68167 RVA: 0x00091316 File Offset: 0x0008F516
			public unsafe static Func<long, long> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056CA RID: 22218
			// (get) Token: 0x06010A48 RID: 68168 RVA: 0x003DA87C File Offset: 0x003D8A7C
			// (set) Token: 0x06010A49 RID: 68169 RVA: 0x00091328 File Offset: 0x0008F528
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056CB RID: 22219
			// (get) Token: 0x06010A4A RID: 68170 RVA: 0x003DA8A4 File Offset: 0x003D8AA4
			// (set) Token: 0x06010A4B RID: 68171 RVA: 0x0009133A File Offset: 0x0008F53A
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, bool> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056CC RID: 22220
			// (get) Token: 0x06010A4C RID: 68172 RVA: 0x003DA8CC File Offset: 0x003D8ACC
			// (set) Token: 0x06010A4D RID: 68173 RVA: 0x0009134C File Offset: 0x0008F54C
			public unsafe static Func<IzakayaMusic.SingleNote, int> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IzakayaMusic.SingleNote, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056CD RID: 22221
			// (get) Token: 0x06010A4E RID: 68174 RVA: 0x003DA8F4 File Offset: 0x003D8AF4
			// (set) Token: 0x06010A4F RID: 68175 RVA: 0x0009135E File Offset: 0x0008F55E
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, int> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056CE RID: 22222
			// (get) Token: 0x06010A50 RID: 68176 RVA: 0x003DA91C File Offset: 0x003D8B1C
			// (set) Token: 0x06010A51 RID: 68177 RVA: 0x00091370 File Offset: 0x0008F570
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, int> __9__31_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannel.__c.NativeFieldInfoPtr___9__31_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannel.__c.NativeFieldInfoPtr___9__31_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A85C RID: 43100
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A85D RID: 43101
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400A85E RID: 43102
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x0400A85F RID: 43103
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400A860 RID: 43104
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x0400A861 RID: 43105
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x0400A862 RID: 43106
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x0400A863 RID: 43107
			private static readonly IntPtr NativeFieldInfoPtr___9__31_2;

			// Token: 0x0400A864 RID: 43108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A865 RID: 43109
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__24_0_Internal_Int64_SingleNote_0;

			// Token: 0x0400A866 RID: 43110
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__24_1_Internal_Int64_Int64_0;

			// Token: 0x0400A867 RID: 43111
			private static readonly IntPtr NativeMethodInfoPtr__RunNoteUpdate_b__29_0_Internal_Boolean_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0;

			// Token: 0x0400A868 RID: 43112
			private static readonly IntPtr NativeMethodInfoPtr__RunNoteUpdate_b__29_1_Internal_Boolean_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0;

			// Token: 0x0400A869 RID: 43113
			private static readonly IntPtr NativeMethodInfoPtr__GetNoteCount_b__31_0_Internal_Int32_SingleNote_0;

			// Token: 0x0400A86A RID: 43114
			private static readonly IntPtr NativeMethodInfoPtr__GetNoteCount_b__31_1_Internal_Int32_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0;

			// Token: 0x0400A86B RID: 43115
			private static readonly IntPtr NativeMethodInfoPtr__GetNoteCount_b__31_2_Internal_Int32_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0;
		}

		// Token: 0x02000EBC RID: 3772
		[ObfuscatedName("Common.UI.QTEUtility.QTEPannel+<RunNoteUpdate>d__29")]
		public sealed class _RunNoteUpdate_d__29 : ValueType
		{
			// Token: 0x06010A52 RID: 68178 RVA: 0x003DA944 File Offset: 0x003D8B44
			// Note: this type is marked as 'beforefieldinit'.
			static _RunNoteUpdate_d__29()
			{
				Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEPannel>.NativeClassPtr, "<RunNoteUpdate>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr);
				QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, "<>1__state");
				QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, "<>t__builder");
				QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, "<>4__this");
				QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, "token");
				QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr__willSpawnNotes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, "<willSpawnNotes>5__2");
				QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, "<>u__1");
				QTEPannel._RunNoteUpdate_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, 100685708);
				QTEPannel._RunNoteUpdate_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr, 100685709);
			}

			// Token: 0x06010A53 RID: 68179 RVA: 0x003DAA10 File Offset: 0x003D8C10
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 273959, RefRangeEnd = 273961, XrefRangeStart = 273840, XrefRangeEnd = 273959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel._RunNoteUpdate_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A54 RID: 68180 RVA: 0x003DAA48 File Offset: 0x003D8C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannel._RunNoteUpdate_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A55 RID: 68181 RVA: 0x00091382 File Offset: 0x0008F582
			public _RunNoteUpdate_d__29(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010A56 RID: 68182 RVA: 0x0009138B File Offset: 0x0008F58B
			public _RunNoteUpdate_d__29() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannel._RunNoteUpdate_d__29>.NativeClassPtr))
			{
			}

			// Token: 0x170056CF RID: 22223
			// (get) Token: 0x06010A57 RID: 68183 RVA: 0x003DAA90 File Offset: 0x003D8C90
			// (set) Token: 0x06010A58 RID: 68184 RVA: 0x0009139D File Offset: 0x0008F59D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170056D0 RID: 22224
			// (get) Token: 0x06010A59 RID: 68185 RVA: 0x003DAAB8 File Offset: 0x003D8CB8
			// (set) Token: 0x06010A5A RID: 68186 RVA: 0x000913B8 File Offset: 0x0008F5B8
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170056D1 RID: 22225
			// (get) Token: 0x06010A5B RID: 68187 RVA: 0x003DAAE8 File Offset: 0x003D8CE8
			// (set) Token: 0x06010A5C RID: 68188 RVA: 0x000913E6 File Offset: 0x0008F5E6
			public unsafe QTEPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056D2 RID: 22226
			// (get) Token: 0x06010A5D RID: 68189 RVA: 0x003DAB18 File Offset: 0x003D8D18
			// (set) Token: 0x06010A5E RID: 68190 RVA: 0x00091405 File Offset: 0x0008F605
			public CancellationToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr_token);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr_token), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170056D3 RID: 22227
			// (get) Token: 0x06010A5F RID: 68191 RVA: 0x003DAB48 File Offset: 0x003D8D48
			// (set) Token: 0x06010A60 RID: 68192 RVA: 0x00091433 File Offset: 0x0008F633
			public unsafe Queue<IzakayaMusic.SingleNote> _willSpawnNotes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr__willSpawnNotes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<IzakayaMusic.SingleNote>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr__willSpawnNotes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056D4 RID: 22228
			// (get) Token: 0x06010A61 RID: 68193 RVA: 0x003DAB78 File Offset: 0x003D8D78
			// (set) Token: 0x06010A62 RID: 68194 RVA: 0x00091452 File Offset: 0x0008F652
			public UniTask<bool>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___u__1);
					return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannel._RunNoteUpdate_d__29.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A86C RID: 43116
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A86D RID: 43117
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A86E RID: 43118
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A86F RID: 43119
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x0400A870 RID: 43120
			private static readonly IntPtr NativeFieldInfoPtr__willSpawnNotes_5__2;

			// Token: 0x0400A871 RID: 43121
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A872 RID: 43122
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A873 RID: 43123
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
