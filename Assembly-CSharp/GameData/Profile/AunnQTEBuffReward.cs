using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000313 RID: 787
	public class AunnQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06005D4B RID: 23883 RVA: 0x001D4BBC File Offset: 0x001D2DBC
		// Note: this type is marked as 'beforefieldinit'.
		static AunnQTEBuffReward()
		{
			Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "AunnQTEBuffReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr);
			AunnQTEBuffReward.NativeFieldInfoPtr_extraTipDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "extraTipDuration");
			AunnQTEBuffReward.NativeFieldInfoPtr_payTipDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "payTipDuration");
			AunnQTEBuffReward.NativeFieldInfoPtr_patientFreezeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "patientFreezeDuration");
			AunnQTEBuffReward.NativeFieldInfoPtr_aunnFeverDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "aunnFeverDuration");
			AunnQTEBuffReward.NativeFieldInfoPtr_extraTipRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "extraTipRate");
			AunnQTEBuffReward.NativeFieldInfoPtr_payTipInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "payTipInterval");
			AunnQTEBuffReward.NativeFieldInfoPtr_tipRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "tipRange");
			AunnQTEBuffReward.NativeFieldInfoPtr_aunnExtraTipEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "aunnExtraTipEndCallback");
			AunnQTEBuffReward.NativeFieldInfoPtr_aunnFeverEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "aunnFeverEndCallback");
			AunnQTEBuffReward.NativeFieldInfoPtr_aunnPatientFreezeEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "aunnPatientFreezeEndCallback");
			AunnQTEBuffReward.NativeFieldInfoPtr_aunnPayTipCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "aunnPayTipCallback");
			AunnQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682528);
			AunnQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682529);
			AunnQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682530);
			AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_MoreTip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682531);
			AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_GiveTip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682532);
			AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_PatientFreeze_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682533);
			AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_Fever_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682534);
			AunnQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682535);
			AunnQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682536);
			AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_MoreTip_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682537);
			AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_GiveTip_b__15_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682538);
			AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_PatientFreeze_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682539);
			AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_Fever_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, 100682540);
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x001D4DCC File Offset: 0x001D2FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233200, XrefRangeEnd = 233202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string QTEBuffOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AunnQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x001D4E10 File Offset: 0x001D3010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233202, XrefRangeEnd = 233252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AunnQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x001D4E68 File Offset: 0x001D3068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233252, XrefRangeEnd = 233256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Transform playerCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AunnQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x001D4EB8 File Offset: 0x001D30B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233256, XrefRangeEnd = 233264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Aunn_MoreTip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_MoreTip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x001D4EEC File Offset: 0x001D30EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233264, XrefRangeEnd = 233287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Aunn_GiveTip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_GiveTip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x001D4F20 File Offset: 0x001D3120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233287, XrefRangeEnd = 233295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Aunn_PatientFreeze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_PatientFreeze_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x001D4F54 File Offset: 0x001D3154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233295, XrefRangeEnd = 233303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Aunn_Fever()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr_Aunn_Fever_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x001D4F88 File Offset: 0x001D3188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233303, XrefRangeEnd = 233307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearAllBuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AunnQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x001D4FC4 File Offset: 0x001D31C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AunnQTEBuffReward() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x001D5000 File Offset: 0x001D3200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233307, XrefRangeEnd = 233308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Aunn_MoreTip_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_MoreTip_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x001D5034 File Offset: 0x001D3234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233308, XrefRangeEnd = 233309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Aunn_GiveTip_b__15_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_GiveTip_b__15_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x001D5068 File Offset: 0x001D3268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233309, XrefRangeEnd = 233310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Aunn_PatientFreeze_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_PatientFreeze_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x001D509C File Offset: 0x001D329C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233310, XrefRangeEnd = 233311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Aunn_Fever_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.NativeMethodInfoPtr__Aunn_Fever_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x00032E69 File Offset: 0x00031069
		public AunnQTEBuffReward(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x001D50D0 File Offset: 0x001D32D0
		// (set) Token: 0x06005D5B RID: 23899 RVA: 0x00032E72 File Offset: 0x00031072
		public unsafe int extraTipDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_extraTipDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_extraTipDuration)) = value;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x001D50F8 File Offset: 0x001D32F8
		// (set) Token: 0x06005D5D RID: 23901 RVA: 0x00032E8D File Offset: 0x0003108D
		public unsafe int payTipDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_payTipDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_payTipDuration)) = value;
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x001D5120 File Offset: 0x001D3320
		// (set) Token: 0x06005D5F RID: 23903 RVA: 0x00032EA8 File Offset: 0x000310A8
		public unsafe int patientFreezeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_patientFreezeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_patientFreezeDuration)) = value;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x001D5148 File Offset: 0x001D3348
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x00032EC3 File Offset: 0x000310C3
		public unsafe int aunnFeverDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnFeverDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnFeverDuration)) = value;
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x001D5170 File Offset: 0x001D3370
		// (set) Token: 0x06005D63 RID: 23907 RVA: 0x00032EDE File Offset: 0x000310DE
		public unsafe float extraTipRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_extraTipRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_extraTipRate)) = value;
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x001D5198 File Offset: 0x001D3398
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x00032EF9 File Offset: 0x000310F9
		public unsafe int payTipInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_payTipInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_payTipInterval)) = value;
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06005D66 RID: 23910 RVA: 0x001D51C0 File Offset: 0x001D33C0
		// (set) Token: 0x06005D67 RID: 23911 RVA: 0x00032F14 File Offset: 0x00031114
		public unsafe Vector2Int tipRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_tipRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_tipRange)) = value;
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06005D68 RID: 23912 RVA: 0x001D51E8 File Offset: 0x001D33E8
		// (set) Token: 0x06005D69 RID: 23913 RVA: 0x00032F2F File Offset: 0x0003112F
		public unsafe Action aunnExtraTipEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnExtraTipEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnExtraTipEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x001D5218 File Offset: 0x001D3418
		// (set) Token: 0x06005D6B RID: 23915 RVA: 0x00032F4E File Offset: 0x0003114E
		public unsafe Action aunnFeverEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnFeverEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnFeverEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06005D6C RID: 23916 RVA: 0x001D5248 File Offset: 0x001D3448
		// (set) Token: 0x06005D6D RID: 23917 RVA: 0x00032F6D File Offset: 0x0003116D
		public unsafe Action aunnPatientFreezeEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnPatientFreezeEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnPatientFreezeEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x001D5278 File Offset: 0x001D3478
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x00032F8C File Offset: 0x0003118C
		public unsafe Action aunnPayTipCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnPayTipCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AunnQTEBuffReward.NativeFieldInfoPtr_aunnPayTipCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DB9 RID: 15801
		private static readonly IntPtr NativeFieldInfoPtr_extraTipDuration;

		// Token: 0x04003DBA RID: 15802
		private static readonly IntPtr NativeFieldInfoPtr_payTipDuration;

		// Token: 0x04003DBB RID: 15803
		private static readonly IntPtr NativeFieldInfoPtr_patientFreezeDuration;

		// Token: 0x04003DBC RID: 15804
		private static readonly IntPtr NativeFieldInfoPtr_aunnFeverDuration;

		// Token: 0x04003DBD RID: 15805
		private static readonly IntPtr NativeFieldInfoPtr_extraTipRate;

		// Token: 0x04003DBE RID: 15806
		private static readonly IntPtr NativeFieldInfoPtr_payTipInterval;

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeFieldInfoPtr_tipRange;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeFieldInfoPtr_aunnExtraTipEndCallback;

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeFieldInfoPtr_aunnFeverEndCallback;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeFieldInfoPtr_aunnPatientFreezeEndCallback;

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeFieldInfoPtr_aunnPayTipCallback;

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeMethodInfoPtr_Aunn_MoreTip_Private_Void_0;

		// Token: 0x04003DC8 RID: 15816
		private static readonly IntPtr NativeMethodInfoPtr_Aunn_GiveTip_Private_Void_0;

		// Token: 0x04003DC9 RID: 15817
		private static readonly IntPtr NativeMethodInfoPtr_Aunn_PatientFreeze_Private_Void_0;

		// Token: 0x04003DCA RID: 15818
		private static readonly IntPtr NativeMethodInfoPtr_Aunn_Fever_Private_Void_0;

		// Token: 0x04003DCB RID: 15819
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0;

		// Token: 0x04003DCC RID: 15820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003DCD RID: 15821
		private static readonly IntPtr NativeMethodInfoPtr__Aunn_MoreTip_b__14_0_Private_Void_0;

		// Token: 0x04003DCE RID: 15822
		private static readonly IntPtr NativeMethodInfoPtr__Aunn_GiveTip_b__15_0_Private_Void_0;

		// Token: 0x04003DCF RID: 15823
		private static readonly IntPtr NativeMethodInfoPtr__Aunn_PatientFreeze_b__16_0_Private_Void_0;

		// Token: 0x04003DD0 RID: 15824
		private static readonly IntPtr NativeMethodInfoPtr__Aunn_Fever_b__17_0_Private_Void_0;

		// Token: 0x02000D36 RID: 3382
		[ObfuscatedName("GameData.Profile.AunnQTEBuffReward+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F34C RID: 62284 RVA: 0x00399B10 File Offset: 0x00397D10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AunnQTEBuffReward>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr);
				AunnQTEBuffReward.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr, "<>9");
				AunnQTEBuffReward.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr, "<>9__15_1");
				AunnQTEBuffReward.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr, 100682542);
				AunnQTEBuffReward.__c.NativeMethodInfoPtr__Aunn_GiveTip_b__15_1_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr, 100682543);
			}

			// Token: 0x0600F34D RID: 62285 RVA: 0x00399B8C File Offset: 0x00397D8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AunnQTEBuffReward.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F34E RID: 62286 RVA: 0x00399BC8 File Offset: 0x00397DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233195, XrefRangeEnd = 233200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Aunn_GiveTip_b__15_1(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AunnQTEBuffReward.__c.NativeMethodInfoPtr__Aunn_GiveTip_b__15_1_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F34F RID: 62287 RVA: 0x0008298E File Offset: 0x00080B8E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F18 RID: 20248
			// (get) Token: 0x0600F350 RID: 62288 RVA: 0x00399C18 File Offset: 0x00397E18
			// (set) Token: 0x0600F351 RID: 62289 RVA: 0x00082997 File Offset: 0x00080B97
			public unsafe static AunnQTEBuffReward.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AunnQTEBuffReward.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AunnQTEBuffReward.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AunnQTEBuffReward.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F19 RID: 20249
			// (get) Token: 0x0600F352 RID: 62290 RVA: 0x00399C40 File Offset: 0x00397E40
			// (set) Token: 0x0600F353 RID: 62291 RVA: 0x000829A9 File Offset: 0x00080BA9
			public unsafe static Func<GuestGroupController, bool> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AunnQTEBuffReward.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AunnQTEBuffReward.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AFA RID: 39674
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009AFB RID: 39675
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04009AFC RID: 39676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AFD RID: 39677
			private static readonly IntPtr NativeMethodInfoPtr__Aunn_GiveTip_b__15_1_Internal_Boolean_GuestGroupController_0;
		}
	}
}
