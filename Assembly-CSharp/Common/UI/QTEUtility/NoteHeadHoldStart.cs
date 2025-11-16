using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x0200038E RID: 910
	public class NoteHeadHoldStart : NoteHeadBase
	{
		// Token: 0x06006C94 RID: 27796 RVA: 0x002088F4 File Offset: 0x00206AF4
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHeadHoldStart()
		{
			Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteHeadHoldStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr);
			NoteHeadHoldStart.NativeFieldInfoPtr_NoteHeadHoldLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, "NoteHeadHoldLerp");
			NoteHeadHoldStart.NativeFieldInfoPtr_m_CornerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, "m_CornerBuffer");
			NoteHeadHoldStart.NativeFieldInfoPtr_m_OnClickStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, "m_OnClickStatus");
			NoteHeadHoldStart.NativeFieldInfoPtr__EndNote_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, "<EndNote>k__BackingField");
			NoteHeadHoldStart.NativeMethodInfoPtr_get_EndNote_Public_get_NoteHeadHoldEnd_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685650);
			NoteHeadHoldStart.NativeMethodInfoPtr_set_EndNote_Public_set_Void_NoteHeadHoldEnd_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685651);
			NoteHeadHoldStart.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685652);
			NoteHeadHoldStart.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685653);
			NoteHeadHoldStart.NativeMethodInfoPtr_OnRemove_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685654);
			NoteHeadHoldStart.NativeMethodInfoPtr_OnRelease_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685655);
			NoteHeadHoldStart.NativeMethodInfoPtr_Evaluate_Public_Void_Nullable_1_NoteStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685656);
			NoteHeadHoldStart.NativeMethodInfoPtr_InitForVisualOnlyElements_Public_Virtual_IEnumerable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685657);
			NoteHeadHoldStart.NativeMethodInfoPtr_OnNotePositionUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685658);
			NoteHeadHoldStart.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685659);
			NoteHeadHoldStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685660);
			NoteHeadHoldStart.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, 100685661);
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x06006C95 RID: 27797 RVA: 0x00208A64 File Offset: 0x00206C64
		// (set) Token: 0x06006C96 RID: 27798 RVA: 0x00208AA4 File Offset: 0x00206CA4
		public unsafe NoteHeadHoldEnd EndNote
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart.NativeMethodInfoPtr_get_EndNote_Public_get_NoteHeadHoldEnd_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadHoldEnd>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart.NativeMethodInfoPtr_set_EndNote_Public_set_Void_NoteHeadHoldEnd_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00208AE8 File Offset: 0x00206CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273734, XrefRangeEnd = 273735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00208B24 File Offset: 0x00206D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273581, RefRangeEnd = 273583, XrefRangeStart = 273581, XrefRangeEnd = 273583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDemoModeStatusChangeToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00208B60 File Offset: 0x00206D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273735, XrefRangeEnd = 273737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRemove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_OnRemove_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00208B9C File Offset: 0x00206D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273737, XrefRangeEnd = 273744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRelease()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_OnRelease_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00208BD8 File Offset: 0x00206DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273744, XrefRangeEnd = 273751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(Nullable<NoteHeadBase.NoteStatus> overrideValue = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart.NativeMethodInfoPtr_Evaluate_Public_Void_Nullable_1_NoteStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00208C20 File Offset: 0x00206E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273751, XrefRangeEnd = 273757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Image> InitForVisualOnlyElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_InitForVisualOnlyElements_Public_Virtual_IEnumerable_1_Image_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Image>>(intPtr3) : null;
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00208C6C File Offset: 0x00206E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273757, XrefRangeEnd = 273769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNotePositionUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_OnNotePositionUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x00208CA8 File Offset: 0x00206EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273769, XrefRangeEnd = 273772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldStart.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x00208CE4 File Offset: 0x00206EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273772, XrefRangeEnd = 273777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadHoldStart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x00208D20 File Offset: 0x00206F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Image> __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Image>>(intPtr3) : null;
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x0003ABA3 File Offset: 0x00038DA3
		public NoteHeadHoldStart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x06006CA2 RID: 27810 RVA: 0x00208D60 File Offset: 0x00206F60
		// (set) Token: 0x06006CA3 RID: 27811 RVA: 0x0003ABAC File Offset: 0x00038DAC
		public unsafe RectTransform NoteHeadHoldLerp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr_NoteHeadHoldLerp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr_NoteHeadHoldLerp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x06006CA4 RID: 27812 RVA: 0x00208D90 File Offset: 0x00206F90
		// (set) Token: 0x06006CA5 RID: 27813 RVA: 0x0003ABCB File Offset: 0x00038DCB
		public unsafe Il2CppStructArray<Vector3> m_CornerBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr_m_CornerBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr_m_CornerBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x06006CA6 RID: 27814 RVA: 0x00208DC0 File Offset: 0x00206FC0
		// (set) Token: 0x06006CA7 RID: 27815 RVA: 0x0003ABEA File Offset: 0x00038DEA
		public unsafe NoteHeadBase.NoteStatus m_OnClickStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr_m_OnClickStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr_m_OnClickStatus)) = value;
			}
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x06006CA8 RID: 27816 RVA: 0x00208DE8 File Offset: 0x00206FE8
		// (set) Token: 0x06006CA9 RID: 27817 RVA: 0x0003AC05 File Offset: 0x00038E05
		public unsafe NoteHeadHoldEnd _EndNote_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr__EndNote_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadHoldEnd>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart.NativeFieldInfoPtr__EndNote_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047FC RID: 18428
		private static readonly IntPtr NativeFieldInfoPtr_NoteHeadHoldLerp;

		// Token: 0x040047FD RID: 18429
		private static readonly IntPtr NativeFieldInfoPtr_m_CornerBuffer;

		// Token: 0x040047FE RID: 18430
		private static readonly IntPtr NativeFieldInfoPtr_m_OnClickStatus;

		// Token: 0x040047FF RID: 18431
		private static readonly IntPtr NativeFieldInfoPtr__EndNote_k__BackingField;

		// Token: 0x04004800 RID: 18432
		private static readonly IntPtr NativeMethodInfoPtr_get_EndNote_Public_get_NoteHeadHoldEnd_0;

		// Token: 0x04004801 RID: 18433
		private static readonly IntPtr NativeMethodInfoPtr_set_EndNote_Public_set_Void_NoteHeadHoldEnd_0;

		// Token: 0x04004802 RID: 18434
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0;

		// Token: 0x04004803 RID: 18435
		private static readonly IntPtr NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0;

		// Token: 0x04004804 RID: 18436
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Public_Virtual_Void_0;

		// Token: 0x04004805 RID: 18437
		private static readonly IntPtr NativeMethodInfoPtr_OnRelease_Protected_Virtual_Void_0;

		// Token: 0x04004806 RID: 18438
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Nullable_1_NoteStatus_0;

		// Token: 0x04004807 RID: 18439
		private static readonly IntPtr NativeMethodInfoPtr_InitForVisualOnlyElements_Public_Virtual_IEnumerable_1_Image_0;

		// Token: 0x04004808 RID: 18440
		private static readonly IntPtr NativeMethodInfoPtr_OnNotePositionUpdate_Public_Virtual_Void_0;

		// Token: 0x04004809 RID: 18441
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400480A RID: 18442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400480B RID: 18443
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Image_0;

		// Token: 0x02000EB9 RID: 3769
		[ObfuscatedName("Common.UI.QTEUtility.NoteHeadHoldStart+<InitForVisualOnlyElements>d__12")]
		public sealed class _InitForVisualOnlyElements_d__12 : Il2CppSystem.Object
		{
			// Token: 0x06010A02 RID: 68098 RVA: 0x003D9AA8 File Offset: 0x003D7CA8
			// Note: this type is marked as 'beforefieldinit'.
			static _InitForVisualOnlyElements_d__12()
			{
				Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteHeadHoldStart>.NativeClassPtr, "<InitForVisualOnlyElements>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, "<>1__state");
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, "<>2__current");
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, "<>l__initialThreadId");
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, "<>4__this");
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, "<>7__wrap1");
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685662);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685663);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685664);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685665);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Image__get_Current_Private_Virtual_Final_New_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685666);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685667);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685668);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685669);
				NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr, 100685670);
			}

			// Token: 0x06010A03 RID: 68099 RVA: 0x003D9BEC File Offset: 0x003D7DEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39842, RefRangeEnd = 39844, XrefRangeStart = 39842, XrefRangeEnd = 39844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitForVisualOnlyElements_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadHoldStart._InitForVisualOnlyElements_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A04 RID: 68100 RVA: 0x003D9C34 File Offset: 0x003D7E34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 273691, RefRangeEnd = 273692, XrefRangeStart = 273686, XrefRangeEnd = 273691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A05 RID: 68101 RVA: 0x003D9C68 File Offset: 0x003D7E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273692, XrefRangeEnd = 273723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A06 RID: 68102 RVA: 0x003D9CA4 File Offset: 0x003D7EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273723, XrefRangeEnd = 273726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170056B7 RID: 22199
			// (get) Token: 0x06010A07 RID: 68103 RVA: 0x003D9CD8 File Offset: 0x003D7ED8
			public unsafe Image Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Image__get_Current_Private_Virtual_Final_New_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
				}
			}

			// Token: 0x06010A08 RID: 68104 RVA: 0x003D9D18 File Offset: 0x003D7F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273726, XrefRangeEnd = 273732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170056B8 RID: 22200
			// (get) Token: 0x06010A09 RID: 68105 RVA: 0x003D9D4C File Offset: 0x003D7F4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010A0A RID: 68106 RVA: 0x003D9D8C File Offset: 0x003D7F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273732, XrefRangeEnd = 273734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Image> System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Image>>(intPtr3) : null;
			}

			// Token: 0x06010A0B RID: 68107 RVA: 0x003D9DCC File Offset: 0x003D7FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010A0C RID: 68108 RVA: 0x0009109C File Offset: 0x0008F29C
			public _InitForVisualOnlyElements_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056B2 RID: 22194
			// (get) Token: 0x06010A0D RID: 68109 RVA: 0x003D9E0C File Offset: 0x003D800C
			// (set) Token: 0x06010A0E RID: 68110 RVA: 0x000910A5 File Offset: 0x0008F2A5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170056B3 RID: 22195
			// (get) Token: 0x06010A0F RID: 68111 RVA: 0x003D9E34 File Offset: 0x003D8034
			// (set) Token: 0x06010A10 RID: 68112 RVA: 0x000910C0 File Offset: 0x0008F2C0
			public unsafe Image __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056B4 RID: 22196
			// (get) Token: 0x06010A11 RID: 68113 RVA: 0x003D9E64 File Offset: 0x003D8064
			// (set) Token: 0x06010A12 RID: 68114 RVA: 0x000910DF File Offset: 0x0008F2DF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170056B5 RID: 22197
			// (get) Token: 0x06010A13 RID: 68115 RVA: 0x003D9E8C File Offset: 0x003D808C
			// (set) Token: 0x06010A14 RID: 68116 RVA: 0x000910FA File Offset: 0x0008F2FA
			public unsafe NoteHeadHoldStart __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadHoldStart>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056B6 RID: 22198
			// (get) Token: 0x06010A15 RID: 68117 RVA: 0x003D9EBC File Offset: 0x003D80BC
			// (set) Token: 0x06010A16 RID: 68118 RVA: 0x00091119 File Offset: 0x0008F319
			public unsafe IEnumerator<Image> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldStart._InitForVisualOnlyElements_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A83E RID: 43070
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A83F RID: 43071
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A840 RID: 43072
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400A841 RID: 43073
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A842 RID: 43074
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400A843 RID: 43075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A844 RID: 43076
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A845 RID: 43077
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A846 RID: 43078
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400A847 RID: 43079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Image__get_Current_Private_Virtual_Final_New_get_Image_0;

			// Token: 0x0400A848 RID: 43080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A849 RID: 43081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A84A RID: 43082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Image__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Image_0;

			// Token: 0x0400A84B RID: 43083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
