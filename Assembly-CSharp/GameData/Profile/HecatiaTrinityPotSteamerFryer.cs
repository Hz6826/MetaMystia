using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000301 RID: 769
	public class HecatiaTrinityPotSteamerFryer : CookerAssetBase
	{
		// Token: 0x06005CA4 RID: 23716 RVA: 0x001D2C18 File Offset: 0x001D0E18
		// Note: this type is marked as 'beforefieldinit'.
		static HecatiaTrinityPotSteamerFryer()
		{
			Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "HecatiaTrinityPotSteamerFryer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr);
			HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForPot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, "startCookSFXForPot");
			HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForSteamer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, "startCookSFXForSteamer");
			HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForFryer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, "startCookSFXForFryer");
			HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_extraCookerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, "extraCookerType");
			HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_DLC5_HECATIA_COOK_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, "DLC5_HECATIA_COOK_NAME");
			HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr_OverrideStartSFX_Public_Virtual_AudioClip_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, 100682435);
			HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr_get_ExtraAvailableCookerType_Public_Virtual_get_Il2CppStructArray_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, 100682436);
			HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr_get_OverrideTypeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, 100682437);
			HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr, 100682438);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x001D2CFC File Offset: 0x001D0EFC
		[CallerCount(0)]
		public unsafe override AudioClip OverrideStartSFX(Cooker.CookerType cookerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr_OverrideStartSFX_Public_Virtual_AudioClip_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x001D2D54 File Offset: 0x001D0F54
		public unsafe override Il2CppStructArray<Cooker.CookerType> ExtraAvailableCookerType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr_get_ExtraAvailableCookerType_Public_Virtual_get_Il2CppStructArray_1_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Cooker.CookerType>>(intPtr3) : null;
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06005CA7 RID: 23719 RVA: 0x001D2DA0 File Offset: 0x001D0FA0
		public unsafe override string OverrideTypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232438, XrefRangeEnd = 232441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr_get_OverrideTypeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x001D2DE4 File Offset: 0x001D0FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HecatiaTrinityPotSteamerFryer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HecatiaTrinityPotSteamerFryer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HecatiaTrinityPotSteamerFryer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x00032948 File Offset: 0x00030B48
		public HecatiaTrinityPotSteamerFryer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x001D2E20 File Offset: 0x001D1020
		// (set) Token: 0x06005CAB RID: 23723 RVA: 0x00032951 File Offset: 0x00030B51
		public unsafe AudioClip startCookSFXForPot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForPot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForPot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06005CAC RID: 23724 RVA: 0x001D2E50 File Offset: 0x001D1050
		// (set) Token: 0x06005CAD RID: 23725 RVA: 0x00032970 File Offset: 0x00030B70
		public unsafe AudioClip startCookSFXForSteamer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForSteamer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForSteamer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06005CAE RID: 23726 RVA: 0x001D2E80 File Offset: 0x001D1080
		// (set) Token: 0x06005CAF RID: 23727 RVA: 0x0003298F File Offset: 0x00030B8F
		public unsafe AudioClip startCookSFXForFryer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForFryer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_startCookSFXForFryer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x001D2EB0 File Offset: 0x001D10B0
		// (set) Token: 0x06005CB1 RID: 23729 RVA: 0x000329AE File Offset: 0x00030BAE
		public unsafe Il2CppStructArray<Cooker.CookerType> extraCookerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_extraCookerType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Cooker.CookerType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_extraCookerType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x001D2EE0 File Offset: 0x001D10E0
		// (set) Token: 0x06005CB3 RID: 23731 RVA: 0x000329CD File Offset: 0x00030BCD
		public unsafe static string DLC5_HECATIA_COOK_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_DLC5_HECATIA_COOK_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HecatiaTrinityPotSteamerFryer.NativeFieldInfoPtr_DLC5_HECATIA_COOK_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeFieldInfoPtr_startCookSFXForPot;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeFieldInfoPtr_startCookSFXForSteamer;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeFieldInfoPtr_startCookSFXForFryer;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeFieldInfoPtr_extraCookerType;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_HECATIA_COOK_NAME;

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeMethodInfoPtr_OverrideStartSFX_Public_Virtual_AudioClip_CookerType_0;

		// Token: 0x04003D65 RID: 15717
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraAvailableCookerType_Public_Virtual_get_Il2CppStructArray_1_CookerType_0;

		// Token: 0x04003D66 RID: 15718
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideTypeName_Public_Virtual_get_String_0;

		// Token: 0x04003D67 RID: 15719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
