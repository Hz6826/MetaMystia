using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x0200034C RID: 844
	public class DisplayProgress : MonoBehaviour
	{
		// Token: 0x06006427 RID: 25639 RVA: 0x001ECFF8 File Offset: 0x001EB1F8
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayProgress()
		{
			Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.VFX", "DisplayProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr);
			DisplayProgress.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr, "spriteRenderer");
			DisplayProgress.NativeFieldInfoPtr_sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr, "sequences");
			DisplayProgress.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr, 100684282);
			DisplayProgress.NativeMethodInfoPtr_SetProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr, 100684283);
			DisplayProgress.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr, 100684284);
			DisplayProgress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr, 100684285);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x001ED0A0 File Offset: 0x001EB2A0
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayProgress.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x001ED0D4 File Offset: 0x001EB2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257702, XrefRangeEnd = 257718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayProgress.NativeMethodInfoPtr_SetProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x001ED114 File Offset: 0x001EB314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayProgress.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x001ED150 File Offset: 0x001EB350
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayProgress() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayProgress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayProgress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x000362F7 File Offset: 0x000344F7
		public DisplayProgress(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x001ED18C File Offset: 0x001EB38C
		// (set) Token: 0x0600642E RID: 25646 RVA: 0x00036300 File Offset: 0x00034500
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayProgress.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayProgress.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x001ED1BC File Offset: 0x001EB3BC
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x0003631F File Offset: 0x0003451F
		public unsafe Il2CppReferenceArray<Sprite> sequences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayProgress.NativeFieldInfoPtr_sequences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayProgress.NativeFieldInfoPtr_sequences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400426A RID: 17002
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeFieldInfoPtr_sequences;

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeMethodInfoPtr_SetProgress_Public_Void_Single_0;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
