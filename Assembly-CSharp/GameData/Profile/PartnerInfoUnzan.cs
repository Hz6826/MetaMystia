using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace GameData.Profile
{
	// Token: 0x0200032B RID: 811
	public sealed class PartnerInfoUnzan : PartnerInfo
	{
		// Token: 0x06005F7E RID: 24446 RVA: 0x001DC5DC File Offset: 0x001DA7DC
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoUnzan()
		{
			Il2CppClassPointerStore<PartnerInfoUnzan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoUnzan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoUnzan>.NativeClassPtr);
			PartnerInfoUnzan.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoUnzan>.NativeClassPtr, 100682917);
			PartnerInfoUnzan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoUnzan>.NativeClassPtr, 100682918);
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x001DC634 File Offset: 0x001DA834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235726, XrefRangeEnd = 235729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoUnzan.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x001DC678 File Offset: 0x001DA878
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoUnzan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoUnzan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoUnzan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x00033FAA File Offset: 0x000321AA
		public PartnerInfoUnzan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003F27 RID: 16167
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F28 RID: 16168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
