using System;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x0200038B RID: 907
	public class NoteHeadBase : UIBehaviour
	{
		// Token: 0x06006C41 RID: 27713 RVA: 0x002075D8 File Offset: 0x002057D8
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHeadBase()
		{
			Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteHeadBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr);
			NoteHeadBase.NativeFieldInfoPtr_m_Visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_Visual");
			NoteHeadBase.NativeFieldInfoPtr_m_OverrideAnimationSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_OverrideAnimationSprite");
			NoteHeadBase.NativeFieldInfoPtr_m_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_Animation");
			NoteHeadBase.NativeFieldInfoPtr_m_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_Controller");
			NoteHeadBase.NativeFieldInfoPtr_m_HasPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_HasPressed");
			NoteHeadBase.NativeFieldInfoPtr_m_HasRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_HasRemoved");
			NoteHeadBase.NativeFieldInfoPtr_m_RemoveObjectHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_RemoveObjectHandle");
			NoteHeadBase.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "m_Status");
			NoteHeadBase.NativeFieldInfoPtr__RectTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "<RectTransform>k__BackingField");
			NoteHeadBase.NativeFieldInfoPtr__NoteInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "<NoteInfo>k__BackingField");
			NoteHeadBase.NativeFieldInfoPtr__IsUpdatingPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "<IsUpdatingPosition>k__BackingField");
			NoteHeadBase.NativeFieldInfoPtr__UnderEvaluation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "<UnderEvaluation>k__BackingField");
			NoteHeadBase.NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685594);
			NoteHeadBase.NativeMethodInfoPtr_set_RectTransform_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685595);
			NoteHeadBase.NativeMethodInfoPtr_get_NoteInfo_Public_get_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685596);
			NoteHeadBase.NativeMethodInfoPtr_set_NoteInfo_Private_set_Void_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685597);
			NoteHeadBase.NativeMethodInfoPtr_get_Status_Public_get_NoteStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685598);
			NoteHeadBase.NativeMethodInfoPtr_set_Status_Public_set_Void_NoteStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685599);
			NoteHeadBase.NativeMethodInfoPtr_get_Type_Public_get_NoteType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685600);
			NoteHeadBase.NativeMethodInfoPtr_get_IsUpdatingPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685601);
			NoteHeadBase.NativeMethodInfoPtr_set_IsUpdatingPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685602);
			NoteHeadBase.NativeMethodInfoPtr_get_UnderEvaluation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685603);
			NoteHeadBase.NativeMethodInfoPtr_set_UnderEvaluation_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685604);
			NoteHeadBase.NativeMethodInfoPtr_get_Visual_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685605);
			NoteHeadBase.NativeMethodInfoPtr_get_IsFocusingInputEnabled_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685606);
			NoteHeadBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685607);
			NoteHeadBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685608);
			NoteHeadBase.NativeMethodInfoPtr_InitForVisualOnlyElements_Public_Virtual_New_IEnumerable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685609);
			NoteHeadBase.NativeMethodInfoPtr_PlayCorrectAudio_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685610);
			NoteHeadBase.NativeMethodInfoPtr_WorldToLocalPoint_Protected_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685611);
			NoteHeadBase.NativeMethodInfoPtr_EvaluateNote_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685612);
			NoteHeadBase.NativeMethodInfoPtr_ReleaseNote_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685613);
			NoteHeadBase.NativeMethodInfoPtr_RemoveNote_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685614);
			NoteHeadBase.NativeMethodInfoPtr_OnNotePositionUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685615);
			NoteHeadBase.NativeMethodInfoPtr_Initialize_Public_Void_SingleNote_QTEPannelBase_ObjectPool_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685616);
			NoteHeadBase.NativeMethodInfoPtr_Click_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685617);
			NoteHeadBase.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685618);
			NoteHeadBase.NativeMethodInfoPtr_EnableUnderEvaluation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685619);
			NoteHeadBase.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685620);
			NoteHeadBase.NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685621);
			NoteHeadBase.NativeMethodInfoPtr_OnRemove_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685622);
			NoteHeadBase.NativeMethodInfoPtr_OnClick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685623);
			NoteHeadBase.NativeMethodInfoPtr_OnRelease_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685624);
			NoteHeadBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685625);
			NoteHeadBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, 100685626);
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x0020798C File Offset: 0x00205B8C
		// (set) Token: 0x06006C43 RID: 27715 RVA: 0x002079CC File Offset: 0x00205BCC
		public unsafe RectTransform RectTransform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_set_RectTransform_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x06006C44 RID: 27716 RVA: 0x00207A10 File Offset: 0x00205C10
		// (set) Token: 0x06006C45 RID: 27717 RVA: 0x00207A4C File Offset: 0x00205C4C
		public unsafe IzakayaMusic.SingleNote NoteInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_NoteInfo_Public_get_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_set_NoteInfo_Private_set_Void_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06006C46 RID: 27718 RVA: 0x00207A8C File Offset: 0x00205C8C
		// (set) Token: 0x06006C47 RID: 27719 RVA: 0x00207AC8 File Offset: 0x00205CC8
		public unsafe NoteHeadBase.NoteStatus Status
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 105723, RefRangeEnd = 105726, XrefRangeStart = 105723, XrefRangeEnd = 105726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_Status_Public_get_NoteStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 273528, RefRangeEnd = 273539, XrefRangeStart = 273527, XrefRangeEnd = 273528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_set_Status_Public_set_Void_NoteStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x06006C48 RID: 27720 RVA: 0x00207B08 File Offset: 0x00205D08
		public unsafe IzakayaMusic.SingleNote.NoteType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_Type_Public_get_NoteType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x06006C49 RID: 27721 RVA: 0x00207B44 File Offset: 0x00205D44
		// (set) Token: 0x06006C4A RID: 27722 RVA: 0x00207B80 File Offset: 0x00205D80
		public unsafe bool IsUpdatingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_IsUpdatingPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_set_IsUpdatingPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x06006C4B RID: 27723 RVA: 0x00207BC0 File Offset: 0x00205DC0
		// (set) Token: 0x06006C4C RID: 27724 RVA: 0x00207BFC File Offset: 0x00205DFC
		public unsafe bool UnderEvaluation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_UnderEvaluation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_set_UnderEvaluation_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x06006C4D RID: 27725 RVA: 0x00207C3C File Offset: 0x00205E3C
		public unsafe Sprite Visual
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 273543, RefRangeEnd = 273546, XrefRangeStart = 273539, XrefRangeEnd = 273543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_Visual_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x00207C7C File Offset: 0x00205E7C
		public unsafe bool IsFocusingInputEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273546, XrefRangeEnd = 273547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_get_IsFocusingInputEnabled_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x00207CB8 File Offset: 0x00205EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273547, XrefRangeEnd = 273556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x00207CF4 File Offset: 0x00205EF4
		[CallerCount(0)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x00207D28 File Offset: 0x00205F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273556, XrefRangeEnd = 273562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Image> InitForVisualOnlyElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_InitForVisualOnlyElements_Public_Virtual_New_IEnumerable_1_Image_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Image>>(intPtr3) : null;
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x00207D74 File Offset: 0x00205F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273562, XrefRangeEnd = 273564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCorrectAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_PlayCorrectAudio_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x00207DA8 File Offset: 0x00205FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273564, XrefRangeEnd = 273565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToLocalPoint(Vector3 worldPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_WorldToLocalPoint_Protected_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00207DF4 File Offset: 0x00205FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273565, XrefRangeEnd = 273567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateNote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_EvaluateNote_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x00207E28 File Offset: 0x00206028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273567, XrefRangeEnd = 273569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseNote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_ReleaseNote_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00207E5C File Offset: 0x0020605C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273572, RefRangeEnd = 273575, XrefRangeStart = 273569, XrefRangeEnd = 273572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_RemoveNote_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x00207E90 File Offset: 0x00206090
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnNotePositionUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnNotePositionUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x00207ECC File Offset: 0x002060CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273578, RefRangeEnd = 273581, XrefRangeStart = 273575, XrefRangeEnd = 273578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IzakayaMusic.SingleNote noteInfo, QTEPannelBase controller, ObjectPool<NoteHeadBase> removeObjectHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref noteInfo;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(removeObjectHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_Initialize_Public_Void_SingleNote_QTEPannelBase_ObjectPool_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00207F30 File Offset: 0x00206130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273581, RefRangeEnd = 273583, XrefRangeStart = 273581, XrefRangeEnd = 273581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Click()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_Click_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00207F64 File Offset: 0x00206164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273583, RefRangeEnd = 273585, XrefRangeStart = 273583, XrefRangeEnd = 273583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x00207F98 File Offset: 0x00206198
		[CallerCount(0)]
		public unsafe void EnableUnderEvaluation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr_EnableUnderEvaluation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00207FCC File Offset: 0x002061CC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDemoModeStatusChangeToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00208008 File Offset: 0x00206208
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStatusChangedToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x00208044 File Offset: 0x00206244
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnRemove_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x00208080 File Offset: 0x00206280
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnClick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x002080BC File Offset: 0x002062BC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRelease()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_OnRelease_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x002080F8 File Offset: 0x002062F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273591, RefRangeEnd = 273595, XrefRangeStart = 273585, XrefRangeEnd = 273591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00208134 File Offset: 0x00206334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x0003A9A1 File Offset: 0x00038BA1
		public NoteHeadBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06006C64 RID: 27748 RVA: 0x00208170 File Offset: 0x00206370
		// (set) Token: 0x06006C65 RID: 27749 RVA: 0x0003A9AA File Offset: 0x00038BAA
		public unsafe Image m_Visual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Visual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Visual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06006C66 RID: 27750 RVA: 0x002081A0 File Offset: 0x002063A0
		// (set) Token: 0x06006C67 RID: 27751 RVA: 0x0003A9C9 File Offset: 0x00038BC9
		public unsafe Sprite m_OverrideAnimationSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_OverrideAnimationSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_OverrideAnimationSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06006C68 RID: 27752 RVA: 0x002081D0 File Offset: 0x002063D0
		// (set) Token: 0x06006C69 RID: 27753 RVA: 0x0003A9E8 File Offset: 0x00038BE8
		public unsafe NoteAnimationControllerBase m_Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteAnimationControllerBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06006C6A RID: 27754 RVA: 0x00208200 File Offset: 0x00206400
		// (set) Token: 0x06006C6B RID: 27755 RVA: 0x0003AA07 File Offset: 0x00038C07
		public unsafe QTEPannelBase m_Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannelBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06006C6C RID: 27756 RVA: 0x00208230 File Offset: 0x00206430
		// (set) Token: 0x06006C6D RID: 27757 RVA: 0x0003AA26 File Offset: 0x00038C26
		public unsafe bool m_HasPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_HasPressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_HasPressed)) = value;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06006C6E RID: 27758 RVA: 0x00208258 File Offset: 0x00206458
		// (set) Token: 0x06006C6F RID: 27759 RVA: 0x0003AA41 File Offset: 0x00038C41
		public unsafe bool m_HasRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_HasRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_HasRemoved)) = value;
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06006C70 RID: 27760 RVA: 0x00208280 File Offset: 0x00206480
		// (set) Token: 0x06006C71 RID: 27761 RVA: 0x0003AA5C File Offset: 0x00038C5C
		public unsafe ObjectPool<NoteHeadBase> m_RemoveObjectHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_RemoveObjectHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_RemoveObjectHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06006C72 RID: 27762 RVA: 0x002082B0 File Offset: 0x002064B0
		// (set) Token: 0x06006C73 RID: 27763 RVA: 0x0003AA7B File Offset: 0x00038C7B
		public unsafe NoteHeadBase.NoteStatus m_Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr_m_Status)) = value;
			}
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x06006C74 RID: 27764 RVA: 0x002082D8 File Offset: 0x002064D8
		// (set) Token: 0x06006C75 RID: 27765 RVA: 0x0003AA96 File Offset: 0x00038C96
		public unsafe RectTransform _RectTransform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__RectTransform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__RectTransform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06006C76 RID: 27766 RVA: 0x00208308 File Offset: 0x00206508
		// (set) Token: 0x06006C77 RID: 27767 RVA: 0x0003AAB5 File Offset: 0x00038CB5
		public unsafe IzakayaMusic.SingleNote _NoteInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__NoteInfo_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__NoteInfo_k__BackingField)) = value;
			}
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06006C78 RID: 27768 RVA: 0x00208330 File Offset: 0x00206530
		// (set) Token: 0x06006C79 RID: 27769 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		public unsafe bool _IsUpdatingPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__IsUpdatingPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__IsUpdatingPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06006C7A RID: 27770 RVA: 0x00208358 File Offset: 0x00206558
		// (set) Token: 0x06006C7B RID: 27771 RVA: 0x0003AAEB File Offset: 0x00038CEB
		public unsafe bool _UnderEvaluation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__UnderEvaluation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase.NativeFieldInfoPtr__UnderEvaluation_k__BackingField)) = value;
			}
		}

		// Token: 0x040047BF RID: 18367
		private static readonly IntPtr NativeFieldInfoPtr_m_Visual;

		// Token: 0x040047C0 RID: 18368
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideAnimationSprite;

		// Token: 0x040047C1 RID: 18369
		private static readonly IntPtr NativeFieldInfoPtr_m_Animation;

		// Token: 0x040047C2 RID: 18370
		private static readonly IntPtr NativeFieldInfoPtr_m_Controller;

		// Token: 0x040047C3 RID: 18371
		private static readonly IntPtr NativeFieldInfoPtr_m_HasPressed;

		// Token: 0x040047C4 RID: 18372
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRemoved;

		// Token: 0x040047C5 RID: 18373
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveObjectHandle;

		// Token: 0x040047C6 RID: 18374
		private static readonly IntPtr NativeFieldInfoPtr_m_Status;

		// Token: 0x040047C7 RID: 18375
		private static readonly IntPtr NativeFieldInfoPtr__RectTransform_k__BackingField;

		// Token: 0x040047C8 RID: 18376
		private static readonly IntPtr NativeFieldInfoPtr__NoteInfo_k__BackingField;

		// Token: 0x040047C9 RID: 18377
		private static readonly IntPtr NativeFieldInfoPtr__IsUpdatingPosition_k__BackingField;

		// Token: 0x040047CA RID: 18378
		private static readonly IntPtr NativeFieldInfoPtr__UnderEvaluation_k__BackingField;

		// Token: 0x040047CB RID: 18379
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0;

		// Token: 0x040047CC RID: 18380
		private static readonly IntPtr NativeMethodInfoPtr_set_RectTransform_Private_set_Void_RectTransform_0;

		// Token: 0x040047CD RID: 18381
		private static readonly IntPtr NativeMethodInfoPtr_get_NoteInfo_Public_get_SingleNote_0;

		// Token: 0x040047CE RID: 18382
		private static readonly IntPtr NativeMethodInfoPtr_set_NoteInfo_Private_set_Void_SingleNote_0;

		// Token: 0x040047CF RID: 18383
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_NoteStatus_0;

		// Token: 0x040047D0 RID: 18384
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_NoteStatus_0;

		// Token: 0x040047D1 RID: 18385
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_NoteType_0;

		// Token: 0x040047D2 RID: 18386
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpdatingPosition_Public_get_Boolean_0;

		// Token: 0x040047D3 RID: 18387
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUpdatingPosition_Public_set_Void_Boolean_0;

		// Token: 0x040047D4 RID: 18388
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderEvaluation_Public_get_Boolean_0;

		// Token: 0x040047D5 RID: 18389
		private static readonly IntPtr NativeMethodInfoPtr_set_UnderEvaluation_Private_set_Void_Boolean_0;

		// Token: 0x040047D6 RID: 18390
		private static readonly IntPtr NativeMethodInfoPtr_get_Visual_Public_get_Sprite_0;

		// Token: 0x040047D7 RID: 18391
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFocusingInputEnabled_Protected_get_Boolean_0;

		// Token: 0x040047D8 RID: 18392
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040047D9 RID: 18393
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0;

		// Token: 0x040047DA RID: 18394
		private static readonly IntPtr NativeMethodInfoPtr_InitForVisualOnlyElements_Public_Virtual_New_IEnumerable_1_Image_0;

		// Token: 0x040047DB RID: 18395
		private static readonly IntPtr NativeMethodInfoPtr_PlayCorrectAudio_Protected_Void_0;

		// Token: 0x040047DC RID: 18396
		private static readonly IntPtr NativeMethodInfoPtr_WorldToLocalPoint_Protected_Vector3_Vector3_0;

		// Token: 0x040047DD RID: 18397
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateNote_Public_Void_0;

		// Token: 0x040047DE RID: 18398
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseNote_Public_Void_0;

		// Token: 0x040047DF RID: 18399
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNote_Public_Void_0;

		// Token: 0x040047E0 RID: 18400
		private static readonly IntPtr NativeMethodInfoPtr_OnNotePositionUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040047E1 RID: 18401
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_SingleNote_QTEPannelBase_ObjectPool_1_NoteHeadBase_0;

		// Token: 0x040047E2 RID: 18402
		private static readonly IntPtr NativeMethodInfoPtr_Click_Public_Void_0;

		// Token: 0x040047E3 RID: 18403
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x040047E4 RID: 18404
		private static readonly IntPtr NativeMethodInfoPtr_EnableUnderEvaluation_Protected_Void_0;

		// Token: 0x040047E5 RID: 18405
		private static readonly IntPtr NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_New_Void_0;

		// Token: 0x040047E6 RID: 18406
		private static readonly IntPtr NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_New_Void_0;

		// Token: 0x040047E7 RID: 18407
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Public_Virtual_New_Void_0;

		// Token: 0x040047E8 RID: 18408
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_New_Void_0;

		// Token: 0x040047E9 RID: 18409
		private static readonly IntPtr NativeMethodInfoPtr_OnRelease_Protected_Virtual_New_Void_0;

		// Token: 0x040047EA RID: 18410
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040047EB RID: 18411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000EB6 RID: 3766
		public enum NoteStatus
		{
			// Token: 0x0400A828 RID: 43048
			Good,
			// Token: 0x0400A829 RID: 43049
			Perfect,
			// Token: 0x0400A82A RID: 43050
			Miss,
			// Token: 0x0400A82B RID: 43051
			PostPerfect
		}

		// Token: 0x02000EB7 RID: 3767
		[ObfuscatedName("Common.UI.QTEUtility.NoteHeadBase+<InitForVisualOnlyElements>d__36")]
		public sealed class _InitForVisualOnlyElements_d__36 : Il2CppSystem.Object
		{
			// Token: 0x060109E4 RID: 68068 RVA: 0x003D94CC File Offset: 0x003D76CC
			// Note: this type is marked as 'beforefieldinit'.
			static _InitForVisualOnlyElements_d__36()
			{
				Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteHeadBase>.NativeClassPtr, "<InitForVisualOnlyElements>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, "<>1__state");
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, "<>2__current");
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, "<>l__initialThreadId");
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, "<>4__this");
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685627);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685628);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685629);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Image__get_Current_Private_Virtual_Final_New_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685630);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685631);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685632);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685633);
				NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr, 100685634);
			}

			// Token: 0x060109E5 RID: 68069 RVA: 0x003D95E8 File Offset: 0x003D77E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39842, RefRangeEnd = 39844, XrefRangeStart = 39842, XrefRangeEnd = 39844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitForVisualOnlyElements_d__36(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadBase._InitForVisualOnlyElements_d__36>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109E6 RID: 68070 RVA: 0x003D9630 File Offset: 0x003D7830
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109E7 RID: 68071 RVA: 0x003D9664 File Offset: 0x003D7864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273513, XrefRangeEnd = 273519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170056AD RID: 22189
			// (get) Token: 0x060109E8 RID: 68072 RVA: 0x003D96A0 File Offset: 0x003D78A0
			public unsafe Image Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Image__get_Current_Private_Virtual_Final_New_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
				}
			}

			// Token: 0x060109E9 RID: 68073 RVA: 0x003D96E0 File Offset: 0x003D78E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273519, XrefRangeEnd = 273525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170056AE RID: 22190
			// (get) Token: 0x060109EA RID: 68074 RVA: 0x003D9714 File Offset: 0x003D7914
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060109EB RID: 68075 RVA: 0x003D9754 File Offset: 0x003D7954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273525, XrefRangeEnd = 273527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Image> System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Image>>(intPtr3) : null;
			}

			// Token: 0x060109EC RID: 68076 RVA: 0x003D9794 File Offset: 0x003D7994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060109ED RID: 68077 RVA: 0x00090FAB File Offset: 0x0008F1AB
			public _InitForVisualOnlyElements_d__36(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056A9 RID: 22185
			// (get) Token: 0x060109EE RID: 68078 RVA: 0x003D97D4 File Offset: 0x003D79D4
			// (set) Token: 0x060109EF RID: 68079 RVA: 0x00090FB4 File Offset: 0x0008F1B4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170056AA RID: 22186
			// (get) Token: 0x060109F0 RID: 68080 RVA: 0x003D97FC File Offset: 0x003D79FC
			// (set) Token: 0x060109F1 RID: 68081 RVA: 0x00090FCF File Offset: 0x0008F1CF
			public unsafe Image __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056AB RID: 22187
			// (get) Token: 0x060109F2 RID: 68082 RVA: 0x003D982C File Offset: 0x003D7A2C
			// (set) Token: 0x060109F3 RID: 68083 RVA: 0x00090FEE File Offset: 0x0008F1EE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170056AC RID: 22188
			// (get) Token: 0x060109F4 RID: 68084 RVA: 0x003D9854 File Offset: 0x003D7A54
			// (set) Token: 0x060109F5 RID: 68085 RVA: 0x00091009 File Offset: 0x0008F209
			public unsafe NoteHeadBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadBase._InitForVisualOnlyElements_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A82C RID: 43052
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A82D RID: 43053
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A82E RID: 43054
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400A82F RID: 43055
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A830 RID: 43056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A831 RID: 43057
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A832 RID: 43058
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A833 RID: 43059
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Image__get_Current_Private_Virtual_Final_New_get_Image_0;

			// Token: 0x0400A834 RID: 43060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A835 RID: 43061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A836 RID: 43062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Image_0;

			// Token: 0x0400A837 RID: 43063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
