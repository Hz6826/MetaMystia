using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI.QTEUtility
{
	// Token: 0x0200038D RID: 909
	public class NoteHeadHoldEnd : NoteHeadBase
	{
		// Token: 0x06006C8A RID: 27786 RVA: 0x00208694 File Offset: 0x00206894
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHeadHoldEnd()
		{
			Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteHeadHoldEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr);
			NoteHeadHoldEnd.NativeFieldInfoPtr__StartNote_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, "<StartNote>k__BackingField");
			NoteHeadHoldEnd.NativeMethodInfoPtr_get_StartNote_Public_get_NoteHeadHoldStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, 100685644);
			NoteHeadHoldEnd.NativeMethodInfoPtr_set_StartNote_Public_set_Void_NoteHeadHoldStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, 100685645);
			NoteHeadHoldEnd.NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, 100685646);
			NoteHeadHoldEnd.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, 100685647);
			NoteHeadHoldEnd.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, 100685648);
			NoteHeadHoldEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr, 100685649);
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x00208750 File Offset: 0x00206950
		// (set) Token: 0x06006C8C RID: 27788 RVA: 0x00208790 File Offset: 0x00206990
		public unsafe NoteHeadHoldStart StartNote
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldEnd.NativeMethodInfoPtr_get_StartNote_Public_get_NoteHeadHoldStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadHoldStart>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldEnd.NativeMethodInfoPtr_set_StartNote_Public_set_Void_NoteHeadHoldStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x002087D4 File Offset: 0x002069D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273646, XrefRangeEnd = 273656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStatusChangedToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldEnd.NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x00208810 File Offset: 0x00206A10
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 273656, RefRangeEnd = 273684, XrefRangeStart = 273656, XrefRangeEnd = 273656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDemoModeStatusChangeToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldEnd.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x0020884C File Offset: 0x00206A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273684, XrefRangeEnd = 273686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadHoldEnd.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x00208888 File Offset: 0x00206A88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadHoldEnd() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadHoldEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadHoldEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x0003AB7B File Offset: 0x00038D7B
		public NoteHeadHoldEnd(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x06006C92 RID: 27794 RVA: 0x002088C4 File Offset: 0x00206AC4
		// (set) Token: 0x06006C93 RID: 27795 RVA: 0x0003AB84 File Offset: 0x00038D84
		public unsafe NoteHeadHoldStart _StartNote_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldEnd.NativeFieldInfoPtr__StartNote_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadHoldStart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadHoldEnd.NativeFieldInfoPtr__StartNote_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047F5 RID: 18421
		private static readonly IntPtr NativeFieldInfoPtr__StartNote_k__BackingField;

		// Token: 0x040047F6 RID: 18422
		private static readonly IntPtr NativeMethodInfoPtr_get_StartNote_Public_get_NoteHeadHoldStart_0;

		// Token: 0x040047F7 RID: 18423
		private static readonly IntPtr NativeMethodInfoPtr_set_StartNote_Public_set_Void_NoteHeadHoldStart_0;

		// Token: 0x040047F8 RID: 18424
		private static readonly IntPtr NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_Void_0;

		// Token: 0x040047F9 RID: 18425
		private static readonly IntPtr NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0;

		// Token: 0x040047FA RID: 18426
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040047FB RID: 18427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
