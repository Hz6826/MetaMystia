using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E7 RID: 743
	public class PublicExtraDialogProfile : ScriptableObject
	{
		// Token: 0x06005A0A RID: 23050 RVA: 0x001CC594 File Offset: 0x001CA794
		// Note: this type is marked as 'beforefieldinit'.
		static PublicExtraDialogProfile()
		{
			Il2CppClassPointerStore<PublicExtraDialogProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PublicExtraDialogProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublicExtraDialogProfile>.NativeClassPtr);
			PublicExtraDialogProfile.NativeFieldInfoPtr_specialGuestPublicExtraDialogDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicExtraDialogProfile>.NativeClassPtr, "specialGuestPublicExtraDialogDatas");
			PublicExtraDialogProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicExtraDialogProfile>.NativeClassPtr, 100681402);
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x001CC5EC File Offset: 0x001CA7EC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PublicExtraDialogProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PublicExtraDialogProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicExtraDialogProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x00030A0D File Offset: 0x0002EC0D
		public PublicExtraDialogProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06005A0D RID: 23053 RVA: 0x001CC628 File Offset: 0x001CA828
		// (set) Token: 0x06005A0E RID: 23054 RVA: 0x00030A16 File Offset: 0x0002EC16
		public unsafe Il2CppReferenceArray<SpecialGuestPublicExtraDialogData> specialGuestPublicExtraDialogDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicExtraDialogProfile.NativeFieldInfoPtr_specialGuestPublicExtraDialogDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuestPublicExtraDialogData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicExtraDialogProfile.NativeFieldInfoPtr_specialGuestPublicExtraDialogDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C00 RID: 15360
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestPublicExtraDialogDatas;

		// Token: 0x04003C01 RID: 15361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
