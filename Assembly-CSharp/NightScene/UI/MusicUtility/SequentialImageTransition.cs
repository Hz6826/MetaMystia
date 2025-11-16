using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.MusicUtility
{
	// Token: 0x020001CF RID: 463
	public class SequentialImageTransition : MonoBehaviour
	{
		// Token: 0x06003A0F RID: 14863 RVA: 0x00164790 File Offset: 0x00162990
		// Note: this type is marked as 'beforefieldinit'.
		static SequentialImageTransition()
		{
			Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.MusicUtility", "SequentialImageTransition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr);
			SequentialImageTransition.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, "image");
			SequentialImageTransition.NativeFieldInfoPtr_imageSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, "imageSequence");
			SequentialImageTransition.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, 100674111);
			SequentialImageTransition.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, 100674112);
			SequentialImageTransition.NativeMethodInfoPtr_OnProgressUpdate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, 100674113);
			SequentialImageTransition.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, 100674114);
			SequentialImageTransition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr, 100674115);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x0016484C File Offset: 0x00162A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132343, XrefRangeEnd = 132348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialImageTransition.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00164880 File Offset: 0x00162A80
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialImageTransition.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001648B4 File Offset: 0x00162AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132348, XrefRangeEnd = 132351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnProgressUpdate(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialImageTransition.NativeMethodInfoPtr_OnProgressUpdate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x001648F4 File Offset: 0x00162AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialImageTransition.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00164930 File Offset: 0x00162B30
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequentialImageTransition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequentialImageTransition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialImageTransition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00020869 File Offset: 0x0001EA69
		public SequentialImageTransition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x0016496C File Offset: 0x00162B6C
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x00020872 File Offset: 0x0001EA72
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequentialImageTransition.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequentialImageTransition.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x0016499C File Offset: 0x00162B9C
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x00020891 File Offset: 0x0001EA91
		public unsafe Il2CppReferenceArray<Sprite> imageSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequentialImageTransition.NativeFieldInfoPtr_imageSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequentialImageTransition.NativeFieldInfoPtr_imageSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400270C RID: 9996
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400270D RID: 9997
		private static readonly IntPtr NativeFieldInfoPtr_imageSequence;

		// Token: 0x0400270E RID: 9998
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x0400270F RID: 9999
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002710 RID: 10000
		private static readonly IntPtr NativeMethodInfoPtr_OnProgressUpdate_Public_Void_Single_0;

		// Token: 0x04002711 RID: 10001
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002712 RID: 10002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
