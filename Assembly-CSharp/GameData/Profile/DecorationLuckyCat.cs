using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.EventUtility;

namespace GameData.Profile
{
	// Token: 0x0200030C RID: 780
	public class DecorationLuckyCat : DecorationBase
	{
		// Token: 0x06005D12 RID: 23826 RVA: 0x001D41CC File Offset: 0x001D23CC
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationLuckyCat()
		{
			Il2CppClassPointerStore<DecorationLuckyCat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationLuckyCat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationLuckyCat>.NativeClassPtr);
			DecorationLuckyCat.NativeFieldInfoPtr_extraFeeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationLuckyCat>.NativeClassPtr, "extraFeeRate");
			DecorationLuckyCat.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationLuckyCat>.NativeClassPtr, 100682489);
			DecorationLuckyCat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationLuckyCat>.NativeClassPtr, 100682490);
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x001D4238 File Offset: 0x001D2438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232858, XrefRangeEnd = 232859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationLuckyCat.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x001D4288 File Offset: 0x001D2488
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationLuckyCat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationLuckyCat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationLuckyCat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x00032CB5 File Offset: 0x00030EB5
		public DecorationLuckyCat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x001D42C4 File Offset: 0x001D24C4
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x00032CBE File Offset: 0x00030EBE
		public unsafe float extraFeeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationLuckyCat.NativeFieldInfoPtr_extraFeeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationLuckyCat.NativeFieldInfoPtr_extraFeeRate)) = value;
			}
		}

		// Token: 0x04003D9C RID: 15772
		private static readonly IntPtr NativeFieldInfoPtr_extraFeeRate;

		// Token: 0x04003D9D RID: 15773
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003D9E RID: 15774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
