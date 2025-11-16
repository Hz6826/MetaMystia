using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.UI.QTEUtility
{
	// Token: 0x0200038F RID: 911
	public class NoteHeadSingle : NoteHeadBase
	{
		// Token: 0x06006CAA RID: 27818 RVA: 0x00208E18 File Offset: 0x00207018
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHeadSingle()
		{
			Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteHeadSingle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr);
			NoteHeadSingle.NativeMethodInfoPtr_OnClick_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr, 100685671);
			NoteHeadSingle.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr, 100685672);
			NoteHeadSingle.NativeMethodInfoPtr_GoodFix_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr, 100685673);
			NoteHeadSingle.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr, 100685674);
			NoteHeadSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr, 100685675);
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x00208EAC File Offset: 0x002070AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273777, XrefRangeEnd = 273779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadSingle.NativeMethodInfoPtr_OnClick_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00208EE0 File Offset: 0x002070E0
		[CallerCount(0)]
		public unsafe override void OnDemoModeStatusChangeToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadSingle.NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00208F1C File Offset: 0x0020711C
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GoodFix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadSingle.NativeMethodInfoPtr_GoodFix_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x00208F64 File Offset: 0x00207164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273779, XrefRangeEnd = 273780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadSingle.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00208FA0 File Offset: 0x002071A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadSingle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadSingle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x0003AC24 File Offset: 0x00038E24
		public NoteHeadSingle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400480C RID: 18444
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_Final_Void_0;

		// Token: 0x0400480D RID: 18445
		private static readonly IntPtr NativeMethodInfoPtr_OnDemoModeStatusChangeToPostPerfect_Protected_Virtual_Void_0;

		// Token: 0x0400480E RID: 18446
		private static readonly IntPtr NativeMethodInfoPtr_GoodFix_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400480F RID: 18447
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004810 RID: 18448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
