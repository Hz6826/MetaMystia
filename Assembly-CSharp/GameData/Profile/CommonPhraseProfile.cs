using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002CA RID: 714
	public class CommonPhraseProfile : ScriptableObject
	{
		// Token: 0x0600586E RID: 22638 RVA: 0x001C887C File Offset: 0x001C6A7C
		// Note: this type is marked as 'beforefieldinit'.
		static CommonPhraseProfile()
		{
			Il2CppClassPointerStore<CommonPhraseProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CommonPhraseProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonPhraseProfile>.NativeClassPtr);
			CommonPhraseProfile.NativeFieldInfoPtr_commonPhraseEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonPhraseProfile>.NativeClassPtr, "commonPhraseEnum");
			CommonPhraseProfile.NativeFieldInfoPtr_tsvBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonPhraseProfile>.NativeClassPtr, "tsvBackup");
			CommonPhraseProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPhraseProfile>.NativeClassPtr, 100681263);
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x001C88E8 File Offset: 0x001C6AE8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonPhraseProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonPhraseProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonPhraseProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0002F650 File Offset: 0x0002D850
		public CommonPhraseProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06005871 RID: 22641 RVA: 0x001C8924 File Offset: 0x001C6B24
		// (set) Token: 0x06005872 RID: 22642 RVA: 0x0002F659 File Offset: 0x0002D859
		public unsafe Il2CppStringArray commonPhraseEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonPhraseProfile.NativeFieldInfoPtr_commonPhraseEnum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonPhraseProfile.NativeFieldInfoPtr_commonPhraseEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06005873 RID: 22643 RVA: 0x001C8954 File Offset: 0x001C6B54
		// (set) Token: 0x06005874 RID: 22644 RVA: 0x0002F678 File Offset: 0x0002D878
		public unsafe TextAsset tsvBackup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonPhraseProfile.NativeFieldInfoPtr_tsvBackup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonPhraseProfile.NativeFieldInfoPtr_tsvBackup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B39 RID: 15161
		private static readonly IntPtr NativeFieldInfoPtr_commonPhraseEnum;

		// Token: 0x04003B3A RID: 15162
		private static readonly IntPtr NativeFieldInfoPtr_tsvBackup;

		// Token: 0x04003B3B RID: 15163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
