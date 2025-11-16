using System;
using Common.VFX;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000316 RID: 790
	public class MystiaQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06005DD2 RID: 24018 RVA: 0x001D65A4 File Offset: 0x001D47A4
		// Note: this type is marked as 'beforefieldinit'.
		static MystiaQTEBuffReward()
		{
			Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "MystiaQTEBuffReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr);
			MystiaQTEBuffReward.NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION");
			MystiaQTEBuffReward.NativeFieldInfoPtr_s_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "s_On");
			MystiaQTEBuffReward.NativeFieldInfoPtr_GuestInstantEvaluateDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "GuestInstantEvaluateDuration");
			MystiaQTEBuffReward.NativeFieldInfoPtr_GuestPatientFreezeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "GuestPatientFreezeDuration");
			MystiaQTEBuffReward.NativeFieldInfoPtr_PlayerThrowDeliverDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "PlayerThrowDeliverDuration");
			MystiaQTEBuffReward.NativeFieldInfoPtr_PlayerFeverDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "PlayerFeverDuration");
			MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "throwDeliverParent");
			MystiaQTEBuffReward.NativeFieldInfoPtr_feverEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "feverEndCallback");
			MystiaQTEBuffReward.NativeFieldInfoPtr_instantEvaluateEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "instantEvaluateEndCallback");
			MystiaQTEBuffReward.NativeFieldInfoPtr_m_CurrentFocusedDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "m_CurrentFocusedDeskCode");
			MystiaQTEBuffReward.NativeFieldInfoPtr_m_InternalThrowDeliverStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "m_InternalThrowDeliverStatus");
			MystiaQTEBuffReward.NativeFieldInfoPtr_patientFreezeEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "patientFreezeEndCallback");
			MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "throwDeliverEndCallback");
			MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "throwDeliverIndicator");
			MystiaQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682583);
			MystiaQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682584);
			MystiaQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682585);
			MystiaQTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682586);
			MystiaQTEBuffReward.NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682587);
			MystiaQTEBuffReward.NativeMethodInfoPtr_Player_InstantEvaluation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682588);
			MystiaQTEBuffReward.NativeMethodInfoPtr_Player_PatientFreeze_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682589);
			MystiaQTEBuffReward.NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682590);
			MystiaQTEBuffReward.NativeMethodInfoPtr_UpdateLegacyThrowDeliverVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682591);
			MystiaQTEBuffReward.NativeMethodInfoPtr_Player_ThrowDeliver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682592);
			MystiaQTEBuffReward.NativeMethodInfoPtr_Player_Fever_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682593);
			MystiaQTEBuffReward.NativeMethodInfoPtr_Player_Fever_Infinite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682594);
			MystiaQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682595);
			MystiaQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682596);
			MystiaQTEBuffReward.NativeMethodInfoPtr__Player_InstantEvaluation_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682598);
			MystiaQTEBuffReward.NativeMethodInfoPtr__Player_PatientFreeze_b__20_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682599);
			MystiaQTEBuffReward.NativeMethodInfoPtr__Player_ThrowDeliver_b__23_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682600);
			MystiaQTEBuffReward.NativeMethodInfoPtr__Player_Fever_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682601);
			MystiaQTEBuffReward.NativeMethodInfoPtr__Player_Fever_Infinite_b__25_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, 100682602);
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x001D6868 File Offset: 0x001D4A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233639, XrefRangeEnd = 233641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string QTEBuffOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x001D68AC File Offset: 0x001D4AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233641, XrefRangeEnd = 233692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x001D6904 File Offset: 0x001D4B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233692, XrefRangeEnd = 233707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Transform playerCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x001D6954 File Offset: 0x001D4B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryExecuteThrowDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x001D6990 File Offset: 0x001D4B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233707, XrefRangeEnd = 233725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFocusingDeskChanged(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x001D69DC File Offset: 0x001D4BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233725, XrefRangeEnd = 233739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Player_InstantEvaluation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr_Player_InstantEvaluation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x001D6A10 File Offset: 0x001D4C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233739, XrefRangeEnd = 233753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Player_PatientFreeze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr_Player_PatientFreeze_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x001D6A44 File Offset: 0x001D4C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233753, XrefRangeEnd = 233764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ToggleThrowDeliverIndicator(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x001D6A90 File Offset: 0x001D4C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233764, XrefRangeEnd = 233780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLegacyThrowDeliverVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr_UpdateLegacyThrowDeliverVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x001D6AC4 File Offset: 0x001D4CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233780, XrefRangeEnd = 233796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Player_ThrowDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr_Player_ThrowDeliver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x001D6AF8 File Offset: 0x001D4CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233796, XrefRangeEnd = 233812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Player_Fever()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr_Player_Fever_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x001D6B2C File Offset: 0x001D4D2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233827, RefRangeEnd = 233830, XrefRangeStart = 233812, XrefRangeEnd = 233827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Player_Fever_Infinite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr_Player_Fever_Infinite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x001D6B60 File Offset: 0x001D4D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233830, XrefRangeEnd = 233834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearAllBuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MystiaQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x001D6B9C File Offset: 0x001D4D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MystiaQTEBuffReward() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x001D6BD8 File Offset: 0x001D4DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Player_InstantEvaluation_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr__Player_InstantEvaluation_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x001D6C0C File Offset: 0x001D4E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Player_PatientFreeze_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr__Player_PatientFreeze_b__20_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x001D6C40 File Offset: 0x001D4E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Player_ThrowDeliver_b__23_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr__Player_ThrowDeliver_b__23_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x001D6C74 File Offset: 0x001D4E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233834, XrefRangeEnd = 233835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Player_Fever_b__24_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr__Player_Fever_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x001D6CA8 File Offset: 0x001D4EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Player_Fever_Infinite_b__25_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.NativeMethodInfoPtr__Player_Fever_Infinite_b__25_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x000332D1 File Offset: 0x000314D1
		public MystiaQTEBuffReward(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x001D6CDC File Offset: 0x001D4EDC
		// (set) Token: 0x06005DE8 RID: 24040 RVA: 0x000332DA File Offset: 0x000314DA
		public unsafe static float THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MystiaQTEBuffReward.NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MystiaQTEBuffReward.NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION, (void*)(&value));
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x001D6CF8 File Offset: 0x001D4EF8
		// (set) Token: 0x06005DEA RID: 24042 RVA: 0x000332E8 File Offset: 0x000314E8
		public unsafe static int s_On
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MystiaQTEBuffReward.NativeFieldInfoPtr_s_On, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MystiaQTEBuffReward.NativeFieldInfoPtr_s_On, (void*)(&value));
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x001D6D14 File Offset: 0x001D4F14
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x000332F6 File Offset: 0x000314F6
		public unsafe int GuestInstantEvaluateDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_GuestInstantEvaluateDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_GuestInstantEvaluateDuration)) = value;
			}
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06005DED RID: 24045 RVA: 0x001D6D3C File Offset: 0x001D4F3C
		// (set) Token: 0x06005DEE RID: 24046 RVA: 0x00033311 File Offset: 0x00031511
		public unsafe int GuestPatientFreezeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_GuestPatientFreezeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_GuestPatientFreezeDuration)) = value;
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x001D6D64 File Offset: 0x001D4F64
		// (set) Token: 0x06005DF0 RID: 24048 RVA: 0x0003332C File Offset: 0x0003152C
		public unsafe int PlayerThrowDeliverDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_PlayerThrowDeliverDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_PlayerThrowDeliverDuration)) = value;
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x001D6D8C File Offset: 0x001D4F8C
		// (set) Token: 0x06005DF2 RID: 24050 RVA: 0x00033347 File Offset: 0x00031547
		public unsafe int PlayerFeverDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_PlayerFeverDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_PlayerFeverDuration)) = value;
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06005DF3 RID: 24051 RVA: 0x001D6DB4 File Offset: 0x001D4FB4
		// (set) Token: 0x06005DF4 RID: 24052 RVA: 0x00033362 File Offset: 0x00031562
		public unsafe GameObject throwDeliverParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06005DF5 RID: 24053 RVA: 0x001D6DE4 File Offset: 0x001D4FE4
		// (set) Token: 0x06005DF6 RID: 24054 RVA: 0x00033381 File Offset: 0x00031581
		public unsafe Action feverEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_feverEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_feverEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x001D6E14 File Offset: 0x001D5014
		// (set) Token: 0x06005DF8 RID: 24056 RVA: 0x000333A0 File Offset: 0x000315A0
		public unsafe Action instantEvaluateEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_instantEvaluateEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_instantEvaluateEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06005DF9 RID: 24057 RVA: 0x001D6E44 File Offset: 0x001D5044
		// (set) Token: 0x06005DFA RID: 24058 RVA: 0x000333BF File Offset: 0x000315BF
		public unsafe int m_CurrentFocusedDeskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_m_CurrentFocusedDeskCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_m_CurrentFocusedDeskCode)) = value;
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06005DFB RID: 24059 RVA: 0x001D6E6C File Offset: 0x001D506C
		// (set) Token: 0x06005DFC RID: 24060 RVA: 0x000333DA File Offset: 0x000315DA
		public unsafe bool m_InternalThrowDeliverStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_m_InternalThrowDeliverStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_m_InternalThrowDeliverStatus)) = value;
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x001D6E94 File Offset: 0x001D5094
		// (set) Token: 0x06005DFE RID: 24062 RVA: 0x000333F5 File Offset: 0x000315F5
		public unsafe Action patientFreezeEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_patientFreezeEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_patientFreezeEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x001D6EC4 File Offset: 0x001D50C4
		// (set) Token: 0x06005E00 RID: 24064 RVA: 0x00033414 File Offset: 0x00031614
		public unsafe Action throwDeliverEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06005E01 RID: 24065 RVA: 0x001D6EF4 File Offset: 0x001D50F4
		// (set) Token: 0x06005E02 RID: 24066 RVA: 0x00033433 File Offset: 0x00031633
		public unsafe DisplayBeizer throwDeliverIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayBeizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.NativeFieldInfoPtr_throwDeliverIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E12 RID: 15890
		private static readonly IntPtr NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION;

		// Token: 0x04003E13 RID: 15891
		private static readonly IntPtr NativeFieldInfoPtr_s_On;

		// Token: 0x04003E14 RID: 15892
		private static readonly IntPtr NativeFieldInfoPtr_GuestInstantEvaluateDuration;

		// Token: 0x04003E15 RID: 15893
		private static readonly IntPtr NativeFieldInfoPtr_GuestPatientFreezeDuration;

		// Token: 0x04003E16 RID: 15894
		private static readonly IntPtr NativeFieldInfoPtr_PlayerThrowDeliverDuration;

		// Token: 0x04003E17 RID: 15895
		private static readonly IntPtr NativeFieldInfoPtr_PlayerFeverDuration;

		// Token: 0x04003E18 RID: 15896
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverParent;

		// Token: 0x04003E19 RID: 15897
		private static readonly IntPtr NativeFieldInfoPtr_feverEndCallback;

		// Token: 0x04003E1A RID: 15898
		private static readonly IntPtr NativeFieldInfoPtr_instantEvaluateEndCallback;

		// Token: 0x04003E1B RID: 15899
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFocusedDeskCode;

		// Token: 0x04003E1C RID: 15900
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalThrowDeliverStatus;

		// Token: 0x04003E1D RID: 15901
		private static readonly IntPtr NativeFieldInfoPtr_patientFreezeEndCallback;

		// Token: 0x04003E1E RID: 15902
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverEndCallback;

		// Token: 0x04003E1F RID: 15903
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverIndicator;

		// Token: 0x04003E20 RID: 15904
		private static readonly IntPtr NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0;

		// Token: 0x04003E21 RID: 15905
		private static readonly IntPtr NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

		// Token: 0x04003E23 RID: 15907
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_Void_0;

		// Token: 0x04003E24 RID: 15908
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_Void_Int32_0;

		// Token: 0x04003E25 RID: 15909
		private static readonly IntPtr NativeMethodInfoPtr_Player_InstantEvaluation_Private_Void_0;

		// Token: 0x04003E26 RID: 15910
		private static readonly IntPtr NativeMethodInfoPtr_Player_PatientFreeze_Private_Void_0;

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLegacyThrowDeliverVisual_Private_Void_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeMethodInfoPtr_Player_ThrowDeliver_Private_Void_0;

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeMethodInfoPtr_Player_Fever_Private_Void_0;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeMethodInfoPtr_Player_Fever_Infinite_Public_Void_0;

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0;

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeMethodInfoPtr__Player_InstantEvaluation_b__19_0_Private_Void_0;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeMethodInfoPtr__Player_PatientFreeze_b__20_0_Private_Void_0;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeMethodInfoPtr__Player_ThrowDeliver_b__23_0_Private_Void_0;

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeMethodInfoPtr__Player_Fever_b__24_0_Private_Void_0;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr__Player_Fever_Infinite_b__25_0_Private_Void_0;

		// Token: 0x02000D38 RID: 3384
		[ObfuscatedName("GameData.Profile.MystiaQTEBuffReward+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F35E RID: 62302 RVA: 0x00399DF4 File Offset: 0x00397FF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MystiaQTEBuffReward>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr);
				MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr, "startPosition");
				MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr, "targetPosition");
				MystiaQTEBuffReward.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr, 100682603);
				MystiaQTEBuffReward.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr, 100682604);
			}

			// Token: 0x0600F35F RID: 62303 RVA: 0x00399E84 File Offset: 0x00398084
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MystiaQTEBuffReward.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F360 RID: 62304 RVA: 0x00399EC0 File Offset: 0x003980C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233636, XrefRangeEnd = 233639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F361 RID: 62305 RVA: 0x00082A19 File Offset: 0x00080C19
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F1D RID: 20253
			// (get) Token: 0x0600F362 RID: 62306 RVA: 0x00399F00 File Offset: 0x00398100
			// (set) Token: 0x0600F363 RID: 62307 RVA: 0x00082A22 File Offset: 0x00080C22
			public unsafe MystiaQTEBuffReward __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MystiaQTEBuffReward>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F1E RID: 20254
			// (get) Token: 0x0600F364 RID: 62308 RVA: 0x00399F30 File Offset: 0x00398130
			// (set) Token: 0x0600F365 RID: 62309 RVA: 0x00082A41 File Offset: 0x00080C41
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17004F1F RID: 20255
			// (get) Token: 0x0600F366 RID: 62310 RVA: 0x00399F58 File Offset: 0x00398158
			// (set) Token: 0x0600F367 RID: 62311 RVA: 0x00082A5C File Offset: 0x00080C5C
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MystiaQTEBuffReward.__c__DisplayClass18_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x04009B03 RID: 39683
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B04 RID: 39684
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x04009B05 RID: 39685
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04009B06 RID: 39686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B07 RID: 39687
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;
		}
	}
}
