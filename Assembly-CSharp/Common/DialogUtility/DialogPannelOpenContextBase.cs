using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.DialogUtility
{
	// Token: 0x0200033F RID: 831
	public class DialogPannelOpenContextBase : Object
	{
		// Token: 0x0600635E RID: 25438 RVA: 0x001EAB0C File Offset: 0x001E8D0C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogPannelOpenContextBase()
		{
			Il2CppClassPointerStore<DialogPannelOpenContextBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "DialogPannelOpenContextBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannelOpenContextBase>.NativeClassPtr);
			DialogPannelOpenContextBase.NativeFieldInfoPtr_DialogPackageToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannelOpenContextBase>.NativeClassPtr, "DialogPackageToPlay");
			DialogPannelOpenContextBase.NativeMethodInfoPtr__ctor_Protected_Void_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannelOpenContextBase>.NativeClassPtr, 100684213);
			DialogPannelOpenContextBase.NativeMethodInfoPtr_get_ManualMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannelOpenContextBase>.NativeClassPtr, 100684214);
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x001EAB78 File Offset: 0x001E8D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257081, XrefRangeEnd = 257091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPannelOpenContextBase(DialogPackage dialogPackageToPlay) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannelOpenContextBase>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackageToPlay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannelOpenContextBase.NativeMethodInfoPtr__ctor_Protected_Void_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x06006360 RID: 25440 RVA: 0x001EABC4 File Offset: 0x001E8DC4
		public unsafe virtual bool ManualMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogPannelOpenContextBase.NativeMethodInfoPtr_get_ManualMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x00035B1F File Offset: 0x00033D1F
		public DialogPannelOpenContextBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06006362 RID: 25442 RVA: 0x001EAC0C File Offset: 0x001E8E0C
		// (set) Token: 0x06006363 RID: 25443 RVA: 0x00035B28 File Offset: 0x00033D28
		public unsafe DialogPackage DialogPackageToPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannelOpenContextBase.NativeFieldInfoPtr_DialogPackageToPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannelOpenContextBase.NativeFieldInfoPtr_DialogPackageToPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041E1 RID: 16865
		private static readonly IntPtr NativeFieldInfoPtr_DialogPackageToPlay;

		// Token: 0x040041E2 RID: 16866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DialogPackage_0;

		// Token: 0x040041E3 RID: 16867
		private static readonly IntPtr NativeMethodInfoPtr_get_ManualMode_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
