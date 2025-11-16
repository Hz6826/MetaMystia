using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.CookingUtility;

namespace GameData.Profile
{
	// Token: 0x02000306 RID: 774
	public class PureHellFryer : CookerAssetBase
	{
		// Token: 0x06005CEE RID: 23790 RVA: 0x001D39A4 File Offset: 0x001D1BA4
		// Note: this type is marked as 'beforefieldinit'.
		static PureHellFryer()
		{
			Il2CppClassPointerStore<PureHellFryer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PureHellFryer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PureHellFryer>.NativeClassPtr);
			PureHellFryer.NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Virtual_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureHellFryer>.NativeClassPtr, 100682469);
			PureHellFryer.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Virtual_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureHellFryer>.NativeClassPtr, 100682470);
			PureHellFryer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureHellFryer>.NativeClassPtr, 100682471);
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x001D3A10 File Offset: 0x001D1C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232749, XrefRangeEnd = 232775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerFinishExtract(CookController targetCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureHellFryer.NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Virtual_Void_CookController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x001D3A60 File Offset: 0x001D1C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232775, XrefRangeEnd = 232776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WhenPlayerTryExtractWithFullTray(CookController targetCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureHellFryer.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Virtual_Void_CookController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x001D3AB0 File Offset: 0x001D1CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PureHellFryer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PureHellFryer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PureHellFryer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x00032BE7 File Offset: 0x00030DE7
		public PureHellFryer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D88 RID: 15752
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Virtual_Void_CookController_0;

		// Token: 0x04003D89 RID: 15753
		private static readonly IntPtr NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Virtual_Void_CookController_0;

		// Token: 0x04003D8A RID: 15754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
