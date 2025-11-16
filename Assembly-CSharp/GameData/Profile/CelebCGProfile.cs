using System;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002C4 RID: 708
	public class CelebCGProfile : ScriptableObject
	{
		// Token: 0x0600583B RID: 22587 RVA: 0x001C7F54 File Offset: 0x001C6154
		// Note: this type is marked as 'beforefieldinit'.
		static CelebCGProfile()
		{
			Il2CppClassPointerStore<CelebCGProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CelebCGProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CelebCGProfile>.NativeClassPtr);
			CelebCGProfile.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelebCGProfile>.NativeClassPtr, "label");
			CelebCGProfile.NativeFieldInfoPtr_cgPictures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelebCGProfile>.NativeClassPtr, "cgPictures");
			CelebCGProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CelebCGProfile>.NativeClassPtr, 100681243);
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x001C7FC0 File Offset: 0x001C61C0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CelebCGProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CelebCGProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CelebCGProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0002F493 File Offset: 0x0002D693
		public CelebCGProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x0600583E RID: 22590 RVA: 0x001C7FFC File Offset: 0x001C61FC
		// (set) Token: 0x0600583F RID: 22591 RVA: 0x0002F49C File Offset: 0x0002D69C
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CelebCGProfile.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CelebCGProfile.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x001C8024 File Offset: 0x001C6224
		// (set) Token: 0x06005841 RID: 22593 RVA: 0x0002F4BB File Offset: 0x0002D6BB
		public unsafe Il2CppReferenceArray<RunTimeScheduler.CGPicture> cgPictures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CelebCGProfile.NativeFieldInfoPtr_cgPictures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RunTimeScheduler.CGPicture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CelebCGProfile.NativeFieldInfoPtr_cgPictures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B1F RID: 15135
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04003B20 RID: 15136
		private static readonly IntPtr NativeFieldInfoPtr_cgPictures;

		// Token: 0x04003B21 RID: 15137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
