using System;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.UI.QTEUtility
{
	// Token: 0x0200038A RID: 906
	public class NoteAnimationControllerBase : MonoBehaviour
	{
		// Token: 0x06006C31 RID: 27697 RVA: 0x00207210 File Offset: 0x00205410
		// Note: this type is marked as 'beforefieldinit'.
		static NoteAnimationControllerBase()
		{
			Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteAnimationControllerBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr);
			NoteAnimationControllerBase.NativeFieldInfoPtr__NoteData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, "<NoteData>k__BackingField");
			NoteAnimationControllerBase.NativeFieldInfoPtr__IsEasyMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, "<IsEasyMode>k__BackingField");
			NoteAnimationControllerBase.NativeMethodInfoPtr_get_NoteData_Protected_get_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685584);
			NoteAnimationControllerBase.NativeMethodInfoPtr_set_NoteData_Public_set_Void_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685585);
			NoteAnimationControllerBase.NativeMethodInfoPtr_get_IsEasyMode_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685586);
			NoteAnimationControllerBase.NativeMethodInfoPtr_set_IsEasyMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685587);
			NoteAnimationControllerBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685588);
			NoteAnimationControllerBase.NativeMethodInfoPtr_OnNoteChangeToMiss_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685589);
			NoteAnimationControllerBase.NativeMethodInfoPtr_OnNoteChangeToGood_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685590);
			NoteAnimationControllerBase.NativeMethodInfoPtr_OnNoteChangeToPerfect_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685591);
			NoteAnimationControllerBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685592);
			NoteAnimationControllerBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr, 100685593);
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x06006C32 RID: 27698 RVA: 0x00207330 File Offset: 0x00205530
		// (set) Token: 0x06006C33 RID: 27699 RVA: 0x0020736C File Offset: 0x0020556C
		public unsafe IzakayaMusic.SingleNote NoteData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerBase.NativeMethodInfoPtr_get_NoteData_Protected_get_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerBase.NativeMethodInfoPtr_set_NoteData_Public_set_Void_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x06006C34 RID: 27700 RVA: 0x002073AC File Offset: 0x002055AC
		// (set) Token: 0x06006C35 RID: 27701 RVA: 0x002073E8 File Offset: 0x002055E8
		public unsafe bool IsEasyMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerBase.NativeMethodInfoPtr_get_IsEasyMode_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerBase.NativeMethodInfoPtr_set_IsEasyMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x00207428 File Offset: 0x00205628
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0020745C File Offset: 0x0020565C
		[CallerCount(0)]
		public unsafe virtual void OnNoteChangeToMiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerBase.NativeMethodInfoPtr_OnNoteChangeToMiss_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00207498 File Offset: 0x00205698
		[CallerCount(0)]
		public unsafe virtual void OnNoteChangeToGood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerBase.NativeMethodInfoPtr_OnNoteChangeToGood_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x002074D4 File Offset: 0x002056D4
		[CallerCount(0)]
		public unsafe virtual void OnNoteChangeToPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerBase.NativeMethodInfoPtr_OnNoteChangeToPerfect_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x00207510 File Offset: 0x00205710
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x0020754C File Offset: 0x0020574C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteAnimationControllerBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteAnimationControllerBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x0003A962 File Offset: 0x00038B62
		public NoteAnimationControllerBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x00207588 File Offset: 0x00205788
		// (set) Token: 0x06006C3E RID: 27710 RVA: 0x0003A96B File Offset: 0x00038B6B
		public unsafe IzakayaMusic.SingleNote _NoteData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerBase.NativeFieldInfoPtr__NoteData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerBase.NativeFieldInfoPtr__NoteData_k__BackingField)) = value;
			}
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x06006C3F RID: 27711 RVA: 0x002075B0 File Offset: 0x002057B0
		// (set) Token: 0x06006C40 RID: 27712 RVA: 0x0003A986 File Offset: 0x00038B86
		public unsafe bool _IsEasyMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerBase.NativeFieldInfoPtr__IsEasyMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerBase.NativeFieldInfoPtr__IsEasyMode_k__BackingField)) = value;
			}
		}

		// Token: 0x040047B3 RID: 18355
		private static readonly IntPtr NativeFieldInfoPtr__NoteData_k__BackingField;

		// Token: 0x040047B4 RID: 18356
		private static readonly IntPtr NativeFieldInfoPtr__IsEasyMode_k__BackingField;

		// Token: 0x040047B5 RID: 18357
		private static readonly IntPtr NativeMethodInfoPtr_get_NoteData_Protected_get_SingleNote_0;

		// Token: 0x040047B6 RID: 18358
		private static readonly IntPtr NativeMethodInfoPtr_set_NoteData_Public_set_Void_SingleNote_0;

		// Token: 0x040047B7 RID: 18359
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEasyMode_Protected_get_Boolean_0;

		// Token: 0x040047B8 RID: 18360
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEasyMode_Public_set_Void_Boolean_0;

		// Token: 0x040047B9 RID: 18361
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040047BA RID: 18362
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteChangeToMiss_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040047BB RID: 18363
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteChangeToGood_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040047BC RID: 18364
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteChangeToPerfect_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040047BD RID: 18365
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040047BE RID: 18366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
