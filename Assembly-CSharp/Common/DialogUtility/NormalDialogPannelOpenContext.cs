using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.DialogUtility
{
	// Token: 0x02000340 RID: 832
	public class NormalDialogPannelOpenContext : DialogPannelOpenContextBase
	{
		// Token: 0x06006364 RID: 25444 RVA: 0x001EAC3C File Offset: 0x001E8E3C
		// Note: this type is marked as 'beforefieldinit'.
		static NormalDialogPannelOpenContext()
		{
			Il2CppClassPointerStore<NormalDialogPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "NormalDialogPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalDialogPannelOpenContext>.NativeClassPtr);
			NormalDialogPannelOpenContext.NativeFieldInfoPtr_OverrideReplaceTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalDialogPannelOpenContext>.NativeClassPtr, "OverrideReplaceTextCallback");
			NormalDialogPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_DialogPackage_Action_1_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalDialogPannelOpenContext>.NativeClassPtr, 100684215);
			NormalDialogPannelOpenContext.NativeMethodInfoPtr_get_ManualMode_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalDialogPannelOpenContext>.NativeClassPtr, 100684216);
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x001EACA8 File Offset: 0x001E8EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257091, XrefRangeEnd = 257102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalDialogPannelOpenContext(DialogPackage dialogPackageToPlay, Action<Dictionary<int, string>> overrideReplaceTextCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalDialogPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackageToPlay);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalDialogPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_DialogPackage_Action_1_Dictionary_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06006366 RID: 25446 RVA: 0x001EAD08 File Offset: 0x001E8F08
		public unsafe override bool ManualMode
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalDialogPannelOpenContext.NativeMethodInfoPtr_get_ManualMode_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x00035B47 File Offset: 0x00033D47
		public NormalDialogPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x001EAD50 File Offset: 0x001E8F50
		// (set) Token: 0x06006369 RID: 25449 RVA: 0x00035B50 File Offset: 0x00033D50
		public unsafe Action<Dictionary<int, string>> OverrideReplaceTextCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalDialogPannelOpenContext.NativeFieldInfoPtr_OverrideReplaceTextCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<int, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalDialogPannelOpenContext.NativeFieldInfoPtr_OverrideReplaceTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041E4 RID: 16868
		private static readonly IntPtr NativeFieldInfoPtr_OverrideReplaceTextCallback;

		// Token: 0x040041E5 RID: 16869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DialogPackage_Action_1_Dictionary_2_Int32_String_0;

		// Token: 0x040041E6 RID: 16870
		private static readonly IntPtr NativeMethodInfoPtr_get_ManualMode_Public_Virtual_get_Boolean_0;
	}
}
