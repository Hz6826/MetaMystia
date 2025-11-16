using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000315 RID: 789
	public class KyoukoQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06005DA8 RID: 23976 RVA: 0x001D5D4C File Offset: 0x001D3F4C
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoQTEBuffReward()
		{
			Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "KyoukoQTEBuffReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr);
			KyoukoQTEBuffReward.NativeFieldInfoPtr_extraGuestSpawnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "extraGuestSpawnDuration");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_instantFinishEatDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "instantFinishEatDuration");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_fasterCookDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "fasterCookDuration");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFeverDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "kyoukoFeverDuration");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_extraGuestSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "extraGuestSpawnRate");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_fasterCookRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "fasterCookRate");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_lockCookerNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "lockCookerNum");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_lockCookerEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "lockCookerEffect");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoExtraGuestSpawnEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "kyoukoExtraGuestSpawnEndCallback");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFasterCookEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "kyoukoFasterCookEndCallback");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFeverEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "kyoukoFeverEndCallback");
			KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoInstantFinishEatCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, "kyoukoInstantFinishEatCallback");
			KyoukoQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682567);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682568);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682569);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_MoreGuest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682570);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_InstantFinishEat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682571);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_FasterCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682572);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_Fever_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682573);
			KyoukoQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682574);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682575);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_MoreGuest_b__15_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682576);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_MoreGuest_b__15_1_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682577);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_InstantFinishEat_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682578);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_FasterCook_b__17_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682579);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_FasterCook_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682580);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_FasterCook_b__17_2_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682581);
			KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_Fever_b__18_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr, 100682582);
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x001D5FAC File Offset: 0x001D41AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233508, XrefRangeEnd = 233510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string QTEBuffOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x001D5FF0 File Offset: 0x001D41F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233510, XrefRangeEnd = 233560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x001D6048 File Offset: 0x001D4248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233560, XrefRangeEnd = 233564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Transform playerCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x001D6098 File Offset: 0x001D4298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233564, XrefRangeEnd = 233578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kyouko_MoreGuest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_MoreGuest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x001D60CC File Offset: 0x001D42CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233578, XrefRangeEnd = 233586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kyouko_InstantFinishEat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_InstantFinishEat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x001D6100 File Offset: 0x001D4300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233586, XrefRangeEnd = 233606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kyouko_FasterCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_FasterCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x001D6134 File Offset: 0x001D4334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233606, XrefRangeEnd = 233614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kyouko_Fever()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr_Kyouko_Fever_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x001D6168 File Offset: 0x001D4368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233614, XrefRangeEnd = 233618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearAllBuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x001D61A4 File Offset: 0x001D43A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoQTEBuffReward() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoQTEBuffReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x001D61E0 File Offset: 0x001D43E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kyouko_MoreGuest_b__15_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_MoreGuest_b__15_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x001D6214 File Offset: 0x001D4414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233618, XrefRangeEnd = 233626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _Kyouko_MoreGuest_b__15_1(int currentTime, string buffDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_MoreGuest_b__15_1_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x001D626C File Offset: 0x001D446C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233626, XrefRangeEnd = 233627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kyouko_InstantFinishEat_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_InstantFinishEat_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x001D62A0 File Offset: 0x001D44A0
		[CallerCount(0)]
		public unsafe float _Kyouko_FasterCook_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_FasterCook_b__17_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x001D62DC File Offset: 0x001D44DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kyouko_FasterCook_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_FasterCook_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x001D6310 File Offset: 0x001D4510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233627, XrefRangeEnd = 233636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _Kyouko_FasterCook_b__17_2(int currentTime, string buffDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_FasterCook_b__17_2_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x001D6368 File Offset: 0x001D4568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kyouko_Fever_b__18_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoQTEBuffReward.NativeMethodInfoPtr__Kyouko_Fever_b__18_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x00033170 File Offset: 0x00031370
		public KyoukoQTEBuffReward(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06005DBA RID: 23994 RVA: 0x001D639C File Offset: 0x001D459C
		// (set) Token: 0x06005DBB RID: 23995 RVA: 0x00033179 File Offset: 0x00031379
		public unsafe int extraGuestSpawnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_extraGuestSpawnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_extraGuestSpawnDuration)) = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x001D63C4 File Offset: 0x001D45C4
		// (set) Token: 0x06005DBD RID: 23997 RVA: 0x00033194 File Offset: 0x00031394
		public unsafe int instantFinishEatDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_instantFinishEatDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_instantFinishEatDuration)) = value;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x001D63EC File Offset: 0x001D45EC
		// (set) Token: 0x06005DBF RID: 23999 RVA: 0x000331AF File Offset: 0x000313AF
		public unsafe int fasterCookDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_fasterCookDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_fasterCookDuration)) = value;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06005DC0 RID: 24000 RVA: 0x001D6414 File Offset: 0x001D4614
		// (set) Token: 0x06005DC1 RID: 24001 RVA: 0x000331CA File Offset: 0x000313CA
		public unsafe int kyoukoFeverDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFeverDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFeverDuration)) = value;
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x001D643C File Offset: 0x001D463C
		// (set) Token: 0x06005DC3 RID: 24003 RVA: 0x000331E5 File Offset: 0x000313E5
		public unsafe float extraGuestSpawnRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_extraGuestSpawnRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_extraGuestSpawnRate)) = value;
			}
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x001D6464 File Offset: 0x001D4664
		// (set) Token: 0x06005DC5 RID: 24005 RVA: 0x00033200 File Offset: 0x00031400
		public unsafe float fasterCookRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_fasterCookRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_fasterCookRate)) = value;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x001D648C File Offset: 0x001D468C
		// (set) Token: 0x06005DC7 RID: 24007 RVA: 0x0003321B File Offset: 0x0003141B
		public unsafe int lockCookerNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_lockCookerNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_lockCookerNum)) = value;
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x001D64B4 File Offset: 0x001D46B4
		// (set) Token: 0x06005DC9 RID: 24009 RVA: 0x00033236 File Offset: 0x00031436
		public unsafe GameObject lockCookerEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_lockCookerEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_lockCookerEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06005DCA RID: 24010 RVA: 0x001D64E4 File Offset: 0x001D46E4
		// (set) Token: 0x06005DCB RID: 24011 RVA: 0x00033255 File Offset: 0x00031455
		public unsafe Action kyoukoExtraGuestSpawnEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoExtraGuestSpawnEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoExtraGuestSpawnEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x001D6514 File Offset: 0x001D4714
		// (set) Token: 0x06005DCD RID: 24013 RVA: 0x00033274 File Offset: 0x00031474
		public unsafe Action kyoukoFasterCookEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFasterCookEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFasterCookEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06005DCE RID: 24014 RVA: 0x001D6544 File Offset: 0x001D4744
		// (set) Token: 0x06005DCF RID: 24015 RVA: 0x00033293 File Offset: 0x00031493
		public unsafe Action kyoukoFeverEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFeverEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoFeverEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x001D6574 File Offset: 0x001D4774
		// (set) Token: 0x06005DD1 RID: 24017 RVA: 0x000332B2 File Offset: 0x000314B2
		public unsafe Action kyoukoInstantFinishEatCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoInstantFinishEatCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoQTEBuffReward.NativeFieldInfoPtr_kyoukoInstantFinishEatCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DF6 RID: 15862
		private static readonly IntPtr NativeFieldInfoPtr_extraGuestSpawnDuration;

		// Token: 0x04003DF7 RID: 15863
		private static readonly IntPtr NativeFieldInfoPtr_instantFinishEatDuration;

		// Token: 0x04003DF8 RID: 15864
		private static readonly IntPtr NativeFieldInfoPtr_fasterCookDuration;

		// Token: 0x04003DF9 RID: 15865
		private static readonly IntPtr NativeFieldInfoPtr_kyoukoFeverDuration;

		// Token: 0x04003DFA RID: 15866
		private static readonly IntPtr NativeFieldInfoPtr_extraGuestSpawnRate;

		// Token: 0x04003DFB RID: 15867
		private static readonly IntPtr NativeFieldInfoPtr_fasterCookRate;

		// Token: 0x04003DFC RID: 15868
		private static readonly IntPtr NativeFieldInfoPtr_lockCookerNum;

		// Token: 0x04003DFD RID: 15869
		private static readonly IntPtr NativeFieldInfoPtr_lockCookerEffect;

		// Token: 0x04003DFE RID: 15870
		private static readonly IntPtr NativeFieldInfoPtr_kyoukoExtraGuestSpawnEndCallback;

		// Token: 0x04003DFF RID: 15871
		private static readonly IntPtr NativeFieldInfoPtr_kyoukoFasterCookEndCallback;

		// Token: 0x04003E00 RID: 15872
		private static readonly IntPtr NativeFieldInfoPtr_kyoukoFeverEndCallback;

		// Token: 0x04003E01 RID: 15873
		private static readonly IntPtr NativeFieldInfoPtr_kyoukoInstantFinishEatCallback;

		// Token: 0x04003E02 RID: 15874
		private static readonly IntPtr NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0;

		// Token: 0x04003E03 RID: 15875
		private static readonly IntPtr NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0;

		// Token: 0x04003E04 RID: 15876
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

		// Token: 0x04003E05 RID: 15877
		private static readonly IntPtr NativeMethodInfoPtr_Kyouko_MoreGuest_Private_Void_0;

		// Token: 0x04003E06 RID: 15878
		private static readonly IntPtr NativeMethodInfoPtr_Kyouko_InstantFinishEat_Private_Void_0;

		// Token: 0x04003E07 RID: 15879
		private static readonly IntPtr NativeMethodInfoPtr_Kyouko_FasterCook_Private_Void_0;

		// Token: 0x04003E08 RID: 15880
		private static readonly IntPtr NativeMethodInfoPtr_Kyouko_Fever_Private_Void_0;

		// Token: 0x04003E09 RID: 15881
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0;

		// Token: 0x04003E0A RID: 15882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E0B RID: 15883
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_MoreGuest_b__15_0_Private_Void_0;

		// Token: 0x04003E0C RID: 15884
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_MoreGuest_b__15_1_Private_String_Int32_String_0;

		// Token: 0x04003E0D RID: 15885
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_InstantFinishEat_b__16_0_Private_Void_0;

		// Token: 0x04003E0E RID: 15886
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_FasterCook_b__17_0_Private_Single_0;

		// Token: 0x04003E0F RID: 15887
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_FasterCook_b__17_1_Private_Void_0;

		// Token: 0x04003E10 RID: 15888
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_FasterCook_b__17_2_Private_String_Int32_String_0;

		// Token: 0x04003E11 RID: 15889
		private static readonly IntPtr NativeMethodInfoPtr__Kyouko_Fever_b__18_0_Private_Void_0;
	}
}
