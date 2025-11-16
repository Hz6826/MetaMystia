using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace GameData.Profile
{
	// Token: 0x02000322 RID: 802
	public sealed class PartnerInfoIchirin : PartnerInfo
	{
		// Token: 0x06005F1B RID: 24347 RVA: 0x001DAF8C File Offset: 0x001D918C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoIchirin()
		{
			Il2CppClassPointerStore<PartnerInfoIchirin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoIchirin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoIchirin>.NativeClassPtr);
			PartnerInfoIchirin.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoIchirin>.NativeClassPtr, 100682830);
			PartnerInfoIchirin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoIchirin>.NativeClassPtr, 100682831);
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x001DAFE4 File Offset: 0x001D91E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235162, XrefRangeEnd = 235165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoIchirin.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x001DB028 File Offset: 0x001D9228
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoIchirin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoIchirin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoIchirin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x00033D09 File Offset: 0x00031F09
		public PartnerInfoIchirin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003EEB RID: 16107
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003EEC RID: 16108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
