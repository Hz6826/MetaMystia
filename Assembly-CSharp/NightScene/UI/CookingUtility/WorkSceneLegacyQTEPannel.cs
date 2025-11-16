using System;
using Common.UI.QTEUtility;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D8 RID: 472
	public class WorkSceneLegacyQTEPannel : QTEPannelBase
	{
		// Token: 0x06003B9A RID: 15258 RVA: 0x001697E0 File Offset: 0x001679E0
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneLegacyQTEPannel()
		{
			Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "WorkSceneLegacyQTEPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr);
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_NoteField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_NoteField");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_FinishedNoteField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_FinishedNoteField");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_Module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_Module");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_Scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_Scanner");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_FinishedNoteInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_FinishedNoteInstances");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_InitialModuleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_InitialModuleWidth");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_UpdateNoteCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_UpdateNoteCoroutine");
			WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_UpdateScannerCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "m_UpdateScannerCoroutine");
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_get_ActiveNoteField_Protected_Virtual_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674361);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_get_WorkMode_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674362);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674363);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674364);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnNoteEvaluated_Protected_Virtual_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674365);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674366);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_GetNoteCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674367);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674368);
			WorkSceneLegacyQTEPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, 100674369);
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x00169964 File Offset: 0x00167B64
		public unsafe override RectTransform ActiveNoteField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_get_ActiveNoteField_Protected_Virtual_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x001699B0 File Offset: 0x00167BB0
		public unsafe override bool WorkMode
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_get_WorkMode_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x001699F8 File Offset: 0x00167BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135499, XrefRangeEnd = 135501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00169A34 File Offset: 0x00167C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135501, XrefRangeEnd = 135609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00169A70 File Offset: 0x00167C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135609, XrefRangeEnd = 135612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNoteEvaluated(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnNoteEvaluated_Protected_Virtual_Void_NoteHeadBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00169AC0 File Offset: 0x00167CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135612, XrefRangeEnd = 135617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00169AFC File Offset: 0x00167CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135617, XrefRangeEnd = 135652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNoteCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_GetNoteCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x00169B44 File Offset: 0x00167D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135652, XrefRangeEnd = 135662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneLegacyQTEPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00169B80 File Offset: 0x00167D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135662, XrefRangeEnd = 135674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneLegacyQTEPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000216D8 File Offset: 0x0001F8D8
		public WorkSceneLegacyQTEPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x00169BBC File Offset: 0x00167DBC
		// (set) Token: 0x06003BA6 RID: 15270 RVA: 0x000216E1 File Offset: 0x0001F8E1
		public unsafe RectTransform m_NoteField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_NoteField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_NoteField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x00169BEC File Offset: 0x00167DEC
		// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x00021700 File Offset: 0x0001F900
		public unsafe RectTransform m_FinishedNoteField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_FinishedNoteField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_FinishedNoteField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x00169C1C File Offset: 0x00167E1C
		// (set) Token: 0x06003BAA RID: 15274 RVA: 0x0002171F File Offset: 0x0001F91F
		public unsafe RectTransform m_Module
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_Module);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_Module), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x00169C4C File Offset: 0x00167E4C
		// (set) Token: 0x06003BAC RID: 15276 RVA: 0x0002173E File Offset: 0x0001F93E
		public unsafe RectTransform m_Scanner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_Scanner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_Scanner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x00169C7C File Offset: 0x00167E7C
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x0002175D File Offset: 0x0001F95D
		public unsafe Dictionary<NoteHeadBase, GameObject> m_FinishedNoteInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_FinishedNoteInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NoteHeadBase, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_FinishedNoteInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x00169CAC File Offset: 0x00167EAC
		// (set) Token: 0x06003BB0 RID: 15280 RVA: 0x0002177C File Offset: 0x0001F97C
		public unsafe float m_InitialModuleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_InitialModuleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_InitialModuleWidth)) = value;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x00169CD4 File Offset: 0x00167ED4
		// (set) Token: 0x06003BB2 RID: 15282 RVA: 0x00021797 File Offset: 0x0001F997
		public unsafe Coroutine m_UpdateNoteCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_UpdateNoteCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_UpdateNoteCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x00169D04 File Offset: 0x00167F04
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x000217B6 File Offset: 0x0001F9B6
		public unsafe Coroutine m_UpdateScannerCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_UpdateScannerCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.NativeFieldInfoPtr_m_UpdateScannerCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteField;

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishedNoteField;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeFieldInfoPtr_m_Module;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeFieldInfoPtr_m_Scanner;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishedNoteInstances;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialModuleWidth;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateNoteCoroutine;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateScannerCoroutine;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveNoteField_Protected_Virtual_get_RectTransform_0;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkMode_Protected_Virtual_get_Boolean_0;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteEvaluated_Protected_Virtual_Void_NoteHeadBase_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteCount_Protected_Virtual_Int32_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000972 RID: 2418
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneLegacyQTEPannel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BBC9 RID: 48073 RVA: 0x002F4164 File Offset: 0x002F2364
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_startQTEMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "startQTEMilliseconds");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_endQTEMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "endQTEMilliseconds");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_qteNoteFieldWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "qteNoteFieldWidth");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_setPositionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "setPositionHandle");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_updatePositionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "updatePositionHandle");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_generateFinishVisualHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "generateFinishVisualHandle");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674370);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674371);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674372);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Vector2_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674373);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674374);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674375);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674376);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674377);
			}

			// Token: 0x0600BBCA RID: 48074 RVA: 0x002F42BC File Offset: 0x002F24BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCB RID: 48075 RVA: 0x002F42F8 File Offset: 0x002F24F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135371, XrefRangeEnd = 135373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NoteHeadBase_PDM_0(NoteHeadBase noteHeadBase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCC RID: 48076 RVA: 0x002F433C File Offset: 0x002F253C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 135412, RefRangeEnd = 135413, XrefRangeStart = 135373, XrefRangeEnd = 135412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NoteHeadBase_0(NoteHeadBase noteHeadBase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCD RID: 48077 RVA: 0x002F4380 File Offset: 0x002F2580
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 135417, RefRangeEnd = 135420, XrefRangeStart = 135413, XrefRangeEnd = 135417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 Method_Internal_Vector2_Int64_0(long noteStartTime)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref noteStartTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Vector2_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBCE RID: 48078 RVA: 0x002F43CC File Offset: 0x002F25CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135420, XrefRangeEnd = 135462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NoteHeadBase_PDM_1(NoteHeadBase noteHeadBase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCF RID: 48079 RVA: 0x002F4410 File Offset: 0x002F2610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135462, XrefRangeEnd = 135472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__5(Queue<NoteHeadBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBD0 RID: 48080 RVA: 0x002F4454 File Offset: 0x002F2654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135472, XrefRangeEnd = 135477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BBD1 RID: 48081 RVA: 0x002F4494 File Offset: 0x002F2694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135477, XrefRangeEnd = 135482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BBD2 RID: 48082 RVA: 0x00065459 File Offset: 0x00063659
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D68 RID: 15720
			// (get) Token: 0x0600BBD3 RID: 48083 RVA: 0x002F44D4 File Offset: 0x002F26D4
			// (set) Token: 0x0600BBD4 RID: 48084 RVA: 0x00065462 File Offset: 0x00063662
			public unsafe WorkSceneLegacyQTEPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneLegacyQTEPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D69 RID: 15721
			// (get) Token: 0x0600BBD5 RID: 48085 RVA: 0x002F4504 File Offset: 0x002F2704
			// (set) Token: 0x0600BBD6 RID: 48086 RVA: 0x00065481 File Offset: 0x00063681
			public unsafe long startQTEMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_startQTEMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_startQTEMilliseconds)) = value;
				}
			}

			// Token: 0x17003D6A RID: 15722
			// (get) Token: 0x0600BBD7 RID: 48087 RVA: 0x002F452C File Offset: 0x002F272C
			// (set) Token: 0x0600BBD8 RID: 48088 RVA: 0x0006549C File Offset: 0x0006369C
			public unsafe long endQTEMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_endQTEMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_endQTEMilliseconds)) = value;
				}
			}

			// Token: 0x17003D6B RID: 15723
			// (get) Token: 0x0600BBD9 RID: 48089 RVA: 0x002F4554 File Offset: 0x002F2754
			// (set) Token: 0x0600BBDA RID: 48090 RVA: 0x000654B7 File Offset: 0x000636B7
			public unsafe float qteNoteFieldWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_qteNoteFieldWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_qteNoteFieldWidth)) = value;
				}
			}

			// Token: 0x17003D6C RID: 15724
			// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x002F457C File Offset: 0x002F277C
			// (set) Token: 0x0600BBDC RID: 48092 RVA: 0x000654D2 File Offset: 0x000636D2
			public unsafe Action setPositionHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_setPositionHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_setPositionHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D6D RID: 15725
			// (get) Token: 0x0600BBDD RID: 48093 RVA: 0x002F45AC File Offset: 0x002F27AC
			// (set) Token: 0x0600BBDE RID: 48094 RVA: 0x000654F1 File Offset: 0x000636F1
			public unsafe Action updatePositionHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_updatePositionHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_updatePositionHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D6E RID: 15726
			// (get) Token: 0x0600BBDF RID: 48095 RVA: 0x002F45DC File Offset: 0x002F27DC
			// (set) Token: 0x0600BBE0 RID: 48096 RVA: 0x00065510 File Offset: 0x00063710
			public unsafe Action generateFinishVisualHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_generateFinishVisualHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_generateFinishVisualHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007948 RID: 31048
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007949 RID: 31049
			private static readonly IntPtr NativeFieldInfoPtr_startQTEMilliseconds;

			// Token: 0x0400794A RID: 31050
			private static readonly IntPtr NativeFieldInfoPtr_endQTEMilliseconds;

			// Token: 0x0400794B RID: 31051
			private static readonly IntPtr NativeFieldInfoPtr_qteNoteFieldWidth;

			// Token: 0x0400794C RID: 31052
			private static readonly IntPtr NativeFieldInfoPtr_setPositionHandle;

			// Token: 0x0400794D RID: 31053
			private static readonly IntPtr NativeFieldInfoPtr_updatePositionHandle;

			// Token: 0x0400794E RID: 31054
			private static readonly IntPtr NativeFieldInfoPtr_generateFinishVisualHandle;

			// Token: 0x0400794F RID: 31055
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007950 RID: 31056
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_PDM_0;

			// Token: 0x04007951 RID: 31057
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_0;

			// Token: 0x04007952 RID: 31058
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Vector2_Int64_0;

			// Token: 0x04007953 RID: 31059
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NoteHeadBase_PDM_1;

			// Token: 0x04007954 RID: 31060
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_Queue_1_NoteHeadBase_0;

			// Token: 0x04007955 RID: 31061
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04007956 RID: 31062
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000FFE RID: 4094
			[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneLegacyQTEPannel+<>c__DisplayClass13_0+<<OnPanelOpen>g__UpdateNote|6>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011889 RID: 71817 RVA: 0x0040662C File Offset: 0x0040482C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "<<OnPanelOpen>g__UpdateNote|6>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100674378);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100674379);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100674380);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100674381);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100674382);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100674383);
				}

				// Token: 0x0601188A RID: 71818 RVA: 0x0040670C File Offset: 0x0040490C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601188B RID: 71819 RVA: 0x00406754 File Offset: 0x00404954
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601188C RID: 71820 RVA: 0x00406788 File Offset: 0x00404988
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135313, XrefRangeEnd = 135355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005B31 RID: 23345
				// (get) Token: 0x0601188D RID: 71821 RVA: 0x004067C4 File Offset: 0x004049C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601188E RID: 71822 RVA: 0x00406804 File Offset: 0x00404A04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135355, XrefRangeEnd = 135361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005B32 RID: 23346
				// (get) Token: 0x0601188F RID: 71823 RVA: 0x00406838 File Offset: 0x00404A38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011890 RID: 71824 RVA: 0x000987FB File Offset: 0x000969FB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B2E RID: 23342
				// (get) Token: 0x06011891 RID: 71825 RVA: 0x00406878 File Offset: 0x00404A78
				// (set) Token: 0x06011892 RID: 71826 RVA: 0x00098804 File Offset: 0x00096A04
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005B2F RID: 23343
				// (get) Token: 0x06011893 RID: 71827 RVA: 0x004068A0 File Offset: 0x00404AA0
				// (set) Token: 0x06011894 RID: 71828 RVA: 0x0009881F File Offset: 0x00096A1F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B30 RID: 23344
				// (get) Token: 0x06011895 RID: 71829 RVA: 0x004068D0 File Offset: 0x00404AD0
				// (set) Token: 0x06011896 RID: 71830 RVA: 0x0009883E File Offset: 0x00096A3E
				public unsafe WorkSceneLegacyQTEPannel.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B13C RID: 45372
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B13D RID: 45373
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B13E RID: 45374
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B13F RID: 45375
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B140 RID: 45376
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B141 RID: 45377
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B142 RID: 45378
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B143 RID: 45379
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B144 RID: 45380
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000FFF RID: 4095
			[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneLegacyQTEPannel+<>c__DisplayClass13_0+<<OnPanelOpen>g__UpdateScanner|7>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011897 RID: 71831 RVA: 0x00406900 File Offset: 0x00404B00
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>.NativeClassPtr, "<<OnPanelOpen>g__UpdateScanner|7>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100674384);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100674385);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100674386);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100674387);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100674388);
					WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100674389);
				}

				// Token: 0x06011898 RID: 71832 RVA: 0x004069E0 File Offset: 0x00404BE0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011899 RID: 71833 RVA: 0x00406A28 File Offset: 0x00404C28
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601189A RID: 71834 RVA: 0x00406A5C File Offset: 0x00404C5C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135361, XrefRangeEnd = 135365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005B36 RID: 23350
				// (get) Token: 0x0601189B RID: 71835 RVA: 0x00406A98 File Offset: 0x00404C98
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601189C RID: 71836 RVA: 0x00406AD8 File Offset: 0x00404CD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135365, XrefRangeEnd = 135371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005B37 RID: 23351
				// (get) Token: 0x0601189D RID: 71837 RVA: 0x00406B0C File Offset: 0x00404D0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601189E RID: 71838 RVA: 0x0009885D File Offset: 0x00096A5D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B33 RID: 23347
				// (get) Token: 0x0601189F RID: 71839 RVA: 0x00406B4C File Offset: 0x00404D4C
				// (set) Token: 0x060118A0 RID: 71840 RVA: 0x00098866 File Offset: 0x00096A66
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005B34 RID: 23348
				// (get) Token: 0x060118A1 RID: 71841 RVA: 0x00406B74 File Offset: 0x00404D74
				// (set) Token: 0x060118A2 RID: 71842 RVA: 0x00098881 File Offset: 0x00096A81
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B35 RID: 23349
				// (get) Token: 0x060118A3 RID: 71843 RVA: 0x00406BA4 File Offset: 0x00404DA4
				// (set) Token: 0x060118A4 RID: 71844 RVA: 0x000988A0 File Offset: 0x00096AA0
				public unsafe WorkSceneLegacyQTEPannel.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B145 RID: 45381
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B146 RID: 45382
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B147 RID: 45383
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B148 RID: 45384
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B149 RID: 45385
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B14A RID: 45386
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B14B RID: 45387
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B14C RID: 45388
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B14D RID: 45389
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000973 RID: 2419
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneLegacyQTEPannel+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : Il2CppSystem.Object
		{
			// Token: 0x0600BBE1 RID: 48097 RVA: 0x002F460C File Offset: 0x002F280C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeFieldInfoPtr_thisNoteHeadBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr, "thisNoteHeadBase");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr, "CS$<>8__locals1");
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr, 100674390);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr, 100674391);
				WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr, 100674392);
			}

			// Token: 0x0600BBE2 RID: 48098 RVA: 0x002F469C File Offset: 0x002F289C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE3 RID: 48099 RVA: 0x002F46D8 File Offset: 0x002F28D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135482, XrefRangeEnd = 135484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE4 RID: 48100 RVA: 0x002F470C File Offset: 0x002F290C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135484, XrefRangeEnd = 135486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE5 RID: 48101 RVA: 0x0006552F File Offset: 0x0006372F
			public __c__DisplayClass13_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D6F RID: 15727
			// (get) Token: 0x0600BBE6 RID: 48102 RVA: 0x002F4740 File Offset: 0x002F2940
			// (set) Token: 0x0600BBE7 RID: 48103 RVA: 0x00065538 File Offset: 0x00063738
			public unsafe NoteHeadBase thisNoteHeadBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeFieldInfoPtr_thisNoteHeadBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeFieldInfoPtr_thisNoteHeadBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D70 RID: 15728
			// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x002F4770 File Offset: 0x002F2970
			// (set) Token: 0x0600BBE9 RID: 48105 RVA: 0x00065557 File Offset: 0x00063757
			public unsafe WorkSceneLegacyQTEPannel.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneLegacyQTEPannel.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneLegacyQTEPannel.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007957 RID: 31063
			private static readonly IntPtr NativeFieldInfoPtr_thisNoteHeadBase;

			// Token: 0x04007958 RID: 31064
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x04007959 RID: 31065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400795A RID: 31066
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_0;

			// Token: 0x0400795B RID: 31067
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_0;
		}

		// Token: 0x02000974 RID: 2420
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneLegacyQTEPannel+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BBEA RID: 48106 RVA: 0x002F47A0 File Offset: 0x002F29A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr);
				WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, "<>9");
				WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, "<>9__13_0");
				WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, "<>9__13_10");
				WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, "<>9__13_11");
				WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, "<>9__16_0");
				WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, "<>9__16_1");
				WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, 100674394);
				WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_0_Internal_Void_KeyValuePair_2_NoteHeadBase_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, 100674395);
				WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_10_Internal_Boolean_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, 100674396);
				WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_11_Internal_Boolean_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, 100674397);
				WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__16_0_Internal_Int32_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, 100674398);
				WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__16_1_Internal_Int32_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr, 100674399);
			}

			// Token: 0x0600BBEB RID: 48107 RVA: 0x002F48BC File Offset: 0x002F2ABC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneLegacyQTEPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBEC RID: 48108 RVA: 0x002F48F8 File Offset: 0x002F2AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135486, XrefRangeEnd = 135491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__13_0(KeyValuePair<NoteHeadBase, GameObject> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_0_Internal_Void_KeyValuePair_2_NoteHeadBase_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBED RID: 48109 RVA: 0x002F4940 File Offset: 0x002F2B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135491, XrefRangeEnd = 135493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__13_10(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_10_Internal_Boolean_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBEE RID: 48110 RVA: 0x002F4994 File Offset: 0x002F2B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135493, XrefRangeEnd = 135495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__13_11(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__13_11_Internal_Boolean_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBEF RID: 48111 RVA: 0x002F49E8 File Offset: 0x002F2BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135495, XrefRangeEnd = 135497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetNoteCount_b__16_0(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__16_0_Internal_Int32_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBF0 RID: 48112 RVA: 0x002F4A3C File Offset: 0x002F2C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135497, XrefRangeEnd = 135499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetNoteCount_b__16_1(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneLegacyQTEPannel.__c.NativeMethodInfoPtr__GetNoteCount_b__16_1_Internal_Int32_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBF1 RID: 48113 RVA: 0x00065576 File Offset: 0x00063776
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D71 RID: 15729
			// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x002F4A90 File Offset: 0x002F2C90
			// (set) Token: 0x0600BBF3 RID: 48115 RVA: 0x0006557F File Offset: 0x0006377F
			public unsafe static WorkSceneLegacyQTEPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneLegacyQTEPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D72 RID: 15730
			// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x002F4AB8 File Offset: 0x002F2CB8
			// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x00065591 File Offset: 0x00063791
			public unsafe static Action<KeyValuePair<NoteHeadBase, GameObject>> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<NoteHeadBase, GameObject>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D73 RID: 15731
			// (get) Token: 0x0600BBF6 RID: 48118 RVA: 0x002F4AE0 File Offset: 0x002F2CE0
			// (set) Token: 0x0600BBF7 RID: 48119 RVA: 0x000655A3 File Offset: 0x000637A3
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, bool> __9__13_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D74 RID: 15732
			// (get) Token: 0x0600BBF8 RID: 48120 RVA: 0x002F4B08 File Offset: 0x002F2D08
			// (set) Token: 0x0600BBF9 RID: 48121 RVA: 0x000655B5 File Offset: 0x000637B5
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, bool> __9__13_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__13_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D75 RID: 15733
			// (get) Token: 0x0600BBFA RID: 48122 RVA: 0x002F4B30 File Offset: 0x002F2D30
			// (set) Token: 0x0600BBFB RID: 48123 RVA: 0x000655C7 File Offset: 0x000637C7
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, int> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D76 RID: 15734
			// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x002F4B58 File Offset: 0x002F2D58
			// (set) Token: 0x0600BBFD RID: 48125 RVA: 0x000655D9 File Offset: 0x000637D9
			public unsafe static Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, int> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneLegacyQTEPannel.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400795C RID: 31068
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400795D RID: 31069
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400795E RID: 31070
			private static readonly IntPtr NativeFieldInfoPtr___9__13_10;

			// Token: 0x0400795F RID: 31071
			private static readonly IntPtr NativeFieldInfoPtr___9__13_11;

			// Token: 0x04007960 RID: 31072
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04007961 RID: 31073
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x04007962 RID: 31074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007963 RID: 31075
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_0_Internal_Void_KeyValuePair_2_NoteHeadBase_GameObject_0;

			// Token: 0x04007964 RID: 31076
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_10_Internal_Boolean_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0;

			// Token: 0x04007965 RID: 31077
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_11_Internal_Boolean_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0;

			// Token: 0x04007966 RID: 31078
			private static readonly IntPtr NativeMethodInfoPtr__GetNoteCount_b__16_0_Internal_Int32_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0;

			// Token: 0x04007967 RID: 31079
			private static readonly IntPtr NativeMethodInfoPtr__GetNoteCount_b__16_1_Internal_Int32_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0;
		}
	}
}
