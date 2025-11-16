using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace GameData
{
	// Token: 0x02000216 RID: 534
	public class VersionDisplayer : MonoBehaviour
	{
		// Token: 0x06003DC5 RID: 15813 RVA: 0x0016FD20 File Offset: 0x0016DF20
		// Note: this type is marked as 'beforefieldinit'.
		static VersionDisplayer()
		{
			Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "VersionDisplayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr);
			VersionDisplayer.NativeFieldInfoPtr_versionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr, "versionText");
			VersionDisplayer.NativeFieldInfoPtr_addOnText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr, "addOnText");
			VersionDisplayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr, 100674598);
			VersionDisplayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr, 100674599);
			VersionDisplayer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr, 100674600);
			VersionDisplayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr, 100674601);
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x0016FDC8 File Offset: 0x0016DFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137404, XrefRangeEnd = 137418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionDisplayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x0016FDFC File Offset: 0x0016DFFC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionDisplayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x0016FE30 File Offset: 0x0016E030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionDisplayer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x0016FE6C File Offset: 0x0016E06C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionDisplayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionDisplayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionDisplayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x0002282D File Offset: 0x00020A2D
		public VersionDisplayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06003DCB RID: 15819 RVA: 0x0016FEA8 File Offset: 0x0016E0A8
		// (set) Token: 0x06003DCC RID: 15820 RVA: 0x00022836 File Offset: 0x00020A36
		public unsafe TextMeshProUGUI versionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionDisplayer.NativeFieldInfoPtr_versionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionDisplayer.NativeFieldInfoPtr_versionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x0016FED8 File Offset: 0x0016E0D8
		// (set) Token: 0x06003DCE RID: 15822 RVA: 0x00022855 File Offset: 0x00020A55
		public unsafe MultiLanguageTextMesh.MultiLanguageString addOnText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionDisplayer.NativeFieldInfoPtr_addOnText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionDisplayer.NativeFieldInfoPtr_addOnText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeFieldInfoPtr_versionText;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeFieldInfoPtr_addOnText;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
