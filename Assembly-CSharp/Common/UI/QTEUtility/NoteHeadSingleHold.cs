using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000390 RID: 912
	public class NoteHeadSingleHold : NoteHeadSingle
	{
		// Token: 0x06006CB1 RID: 27825 RVA: 0x00208FDC File Offset: 0x002071DC
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHeadSingleHold()
		{
			Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteHeadSingleHold");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr);
			NoteHeadSingleHold.NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr, 100685676);
			NoteHeadSingleHold.NativeMethodInfoPtr_GoodFix_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr, 100685677);
			NoteHeadSingleHold.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr, 100685678);
			NoteHeadSingleHold.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr, 100685679);
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x0020905C File Offset: 0x0020725C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273780, XrefRangeEnd = 273781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStatusChangedToPostPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadSingleHold.NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00209098 File Offset: 0x00207298
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GoodFix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadSingleHold.NativeMethodInfoPtr_GoodFix_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x002090E0 File Offset: 0x002072E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadSingleHold.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x0020911C File Offset: 0x0020731C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadSingleHold() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadSingleHold>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadSingleHold.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x0003AC2D File Offset: 0x00038E2D
		public NoteHeadSingleHold(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004811 RID: 18449
		private static readonly IntPtr NativeMethodInfoPtr_OnStatusChangedToPostPerfect_Protected_Virtual_Void_0;

		// Token: 0x04004812 RID: 18450
		private static readonly IntPtr NativeMethodInfoPtr_GoodFix_Protected_Virtual_Boolean_0;

		// Token: 0x04004813 RID: 18451
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004814 RID: 18452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
