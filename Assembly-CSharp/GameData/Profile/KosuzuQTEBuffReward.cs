using System;
using Common.VFX;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000314 RID: 788
	public class KosuzuQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06005D70 RID: 23920 RVA: 0x001D52A8 File Offset: 0x001D34A8
		// Note: this type is marked as 'beforefieldinit'.
		static KosuzuQTEBuffReward()
		{
			Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "KosuzuQTEBuffReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr);
			KosuzuQTEBuffReward.NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_MAX_COMBO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "MAX_COMBO");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_s_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "s_On");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_dialoguesBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "dialoguesBuffDuration");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_lunaticCookBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "lunaticCookBuffDuration");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "throwDeliverBuffDuration");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuFeverDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "kosuzuFeverDuration");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_extraMoodGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "extraMoodGet");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_eachComboAddSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "eachComboAddSpeed");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "throwDeliverParent");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuDialoguesEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "kosuzuDialoguesEndCallback");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuFeverEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "kosuzuFeverEndCallback");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuLunaticCookEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "kosuzuLunaticCookEndCallback");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuThrowDeliverEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "kosuzuThrowDeliverEndCallback");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_m_CurrentFocusedDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "m_CurrentFocusedDeskCode");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_m_InternalThrowDeliverStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "m_InternalThrowDeliverStatus");
			KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "throwDeliverIndicator");
			KosuzuQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682544);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682545);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682546);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_UpdateLegacyThrowDeliverVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682547);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682548);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682549);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_Dialogues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682550);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_LunaticCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682551);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682552);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_ThrowDeliver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682553);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_Fever_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682554);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682555);
			KosuzuQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682556);
			KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_Dialogues_b__23_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682558);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Method_Private_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682559);
			KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_LunaticCook_b__24_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682560);
			KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_LunaticCook_b__24_2_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682561);
			KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_ThrowDeliver_b__26_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682562);
			KosuzuQTEBuffReward.NativeMethodInfoPtr_Method_Private_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682563);
			KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_Fever_b__27_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, 100682564);
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x001D55BC File Offset: 0x001D37BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233314, XrefRangeEnd = 233316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string QTEBuffOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x001D5600 File Offset: 0x001D3800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233316, XrefRangeEnd = 233366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x001D5658 File Offset: 0x001D3858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233366, XrefRangeEnd = 233382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Transform playerCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x001D56A8 File Offset: 0x001D38A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233382, XrefRangeEnd = 233398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLegacyThrowDeliverVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_UpdateLegacyThrowDeliverVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x001D56DC File Offset: 0x001D38DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233398, XrefRangeEnd = 233404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryExecuteThrowDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x001D5718 File Offset: 0x001D3918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233404, XrefRangeEnd = 233422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFocusingDeskChanged(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x001D5764 File Offset: 0x001D3964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233422, XrefRangeEnd = 233430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kosuzu_Dialogues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_Dialogues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x001D5798 File Offset: 0x001D3998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233430, XrefRangeEnd = 233450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kosuzu_LunaticCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_LunaticCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x001D57CC File Offset: 0x001D39CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233450, XrefRangeEnd = 233461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ToggleThrowDeliverIndicator(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x001D5818 File Offset: 0x001D3A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233461, XrefRangeEnd = 233477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kosuzu_ThrowDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_ThrowDeliver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x001D584C File Offset: 0x001D3A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233477, XrefRangeEnd = 233493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kosuzu_Fever()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_Kosuzu_Fever_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x001D5880 File Offset: 0x001D3A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233493, XrefRangeEnd = 233497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearAllBuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KosuzuQTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x001D58BC File Offset: 0x001D3ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KosuzuQTEBuffReward() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x001D58F8 File Offset: 0x001D3AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kosuzu_Dialogues_b__23_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_Dialogues_b__23_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x001D592C File Offset: 0x001D3B2C
		[CallerCount(0)]
		public unsafe float Method_Private_Single_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_Method_Private_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x001D5968 File Offset: 0x001D3B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kosuzu_LunaticCook_b__24_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_LunaticCook_b__24_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x001D599C File Offset: 0x001D3B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233497, XrefRangeEnd = 233506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _Kosuzu_LunaticCook_b__24_2(int currentTime, string buffDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_LunaticCook_b__24_2_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x001D59F4 File Offset: 0x001D3BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233506, XrefRangeEnd = 233507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kosuzu_ThrowDeliver_b__26_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_ThrowDeliver_b__26_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x001D5A28 File Offset: 0x001D3C28
		[CallerCount(0)]
		public unsafe float Method_Private_Single_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr_Method_Private_Single_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x001D5A64 File Offset: 0x001D3C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233507, XrefRangeEnd = 233508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Kosuzu_Fever_b__27_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.NativeMethodInfoPtr__Kosuzu_Fever_b__27_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x00032FAB File Offset: 0x000311AB
		public KosuzuQTEBuffReward(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x001D5A98 File Offset: 0x001D3C98
		// (set) Token: 0x06005D87 RID: 23943 RVA: 0x00032FB4 File Offset: 0x000311B4
		public unsafe static float THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(KosuzuQTEBuffReward.NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KosuzuQTEBuffReward.NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION, (void*)(&value));
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06005D88 RID: 23944 RVA: 0x001D5AB4 File Offset: 0x001D3CB4
		// (set) Token: 0x06005D89 RID: 23945 RVA: 0x00032FC2 File Offset: 0x000311C2
		public unsafe static int MAX_COMBO
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(KosuzuQTEBuffReward.NativeFieldInfoPtr_MAX_COMBO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KosuzuQTEBuffReward.NativeFieldInfoPtr_MAX_COMBO, (void*)(&value));
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06005D8A RID: 23946 RVA: 0x001D5AD0 File Offset: 0x001D3CD0
		// (set) Token: 0x06005D8B RID: 23947 RVA: 0x00032FD0 File Offset: 0x000311D0
		public unsafe static int s_On
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(KosuzuQTEBuffReward.NativeFieldInfoPtr_s_On, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KosuzuQTEBuffReward.NativeFieldInfoPtr_s_On, (void*)(&value));
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x06005D8C RID: 23948 RVA: 0x001D5AEC File Offset: 0x001D3CEC
		// (set) Token: 0x06005D8D RID: 23949 RVA: 0x00032FDE File Offset: 0x000311DE
		public unsafe int dialoguesBuffDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_dialoguesBuffDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_dialoguesBuffDuration)) = value;
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x001D5B14 File Offset: 0x001D3D14
		// (set) Token: 0x06005D8F RID: 23951 RVA: 0x00032FF9 File Offset: 0x000311F9
		public unsafe int lunaticCookBuffDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_lunaticCookBuffDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_lunaticCookBuffDuration)) = value;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06005D90 RID: 23952 RVA: 0x001D5B3C File Offset: 0x001D3D3C
		// (set) Token: 0x06005D91 RID: 23953 RVA: 0x00033014 File Offset: 0x00031214
		public unsafe int throwDeliverBuffDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverBuffDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverBuffDuration)) = value;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06005D92 RID: 23954 RVA: 0x001D5B64 File Offset: 0x001D3D64
		// (set) Token: 0x06005D93 RID: 23955 RVA: 0x0003302F File Offset: 0x0003122F
		public unsafe int kosuzuFeverDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuFeverDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuFeverDuration)) = value;
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06005D94 RID: 23956 RVA: 0x001D5B8C File Offset: 0x001D3D8C
		// (set) Token: 0x06005D95 RID: 23957 RVA: 0x0003304A File Offset: 0x0003124A
		public unsafe int extraMoodGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_extraMoodGet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_extraMoodGet)) = value;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06005D96 RID: 23958 RVA: 0x001D5BB4 File Offset: 0x001D3DB4
		// (set) Token: 0x06005D97 RID: 23959 RVA: 0x00033065 File Offset: 0x00031265
		public unsafe float eachComboAddSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_eachComboAddSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_eachComboAddSpeed)) = value;
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06005D98 RID: 23960 RVA: 0x001D5BDC File Offset: 0x001D3DDC
		// (set) Token: 0x06005D99 RID: 23961 RVA: 0x00033080 File Offset: 0x00031280
		public unsafe GameObject throwDeliverParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x001D5C0C File Offset: 0x001D3E0C
		// (set) Token: 0x06005D9B RID: 23963 RVA: 0x0003309F File Offset: 0x0003129F
		public unsafe Action kosuzuDialoguesEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuDialoguesEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuDialoguesEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06005D9C RID: 23964 RVA: 0x001D5C3C File Offset: 0x001D3E3C
		// (set) Token: 0x06005D9D RID: 23965 RVA: 0x000330BE File Offset: 0x000312BE
		public unsafe Action kosuzuFeverEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuFeverEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuFeverEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06005D9E RID: 23966 RVA: 0x001D5C6C File Offset: 0x001D3E6C
		// (set) Token: 0x06005D9F RID: 23967 RVA: 0x000330DD File Offset: 0x000312DD
		public unsafe Action kosuzuLunaticCookEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuLunaticCookEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuLunaticCookEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06005DA0 RID: 23968 RVA: 0x001D5C9C File Offset: 0x001D3E9C
		// (set) Token: 0x06005DA1 RID: 23969 RVA: 0x000330FC File Offset: 0x000312FC
		public unsafe Action kosuzuThrowDeliverEndCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuThrowDeliverEndCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_kosuzuThrowDeliverEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x001D5CCC File Offset: 0x001D3ECC
		// (set) Token: 0x06005DA3 RID: 23971 RVA: 0x0003311B File Offset: 0x0003131B
		public unsafe int m_CurrentFocusedDeskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_m_CurrentFocusedDeskCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_m_CurrentFocusedDeskCode)) = value;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x001D5CF4 File Offset: 0x001D3EF4
		// (set) Token: 0x06005DA5 RID: 23973 RVA: 0x00033136 File Offset: 0x00031336
		public unsafe bool m_InternalThrowDeliverStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_m_InternalThrowDeliverStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_m_InternalThrowDeliverStatus)) = value;
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06005DA6 RID: 23974 RVA: 0x001D5D1C File Offset: 0x001D3F1C
		// (set) Token: 0x06005DA7 RID: 23975 RVA: 0x00033151 File Offset: 0x00031351
		public unsafe DisplayBeizer throwDeliverIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayBeizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.NativeFieldInfoPtr_throwDeliverIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DD1 RID: 15825
		private static readonly IntPtr NativeFieldInfoPtr_THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION;

		// Token: 0x04003DD2 RID: 15826
		private static readonly IntPtr NativeFieldInfoPtr_MAX_COMBO;

		// Token: 0x04003DD3 RID: 15827
		private static readonly IntPtr NativeFieldInfoPtr_s_On;

		// Token: 0x04003DD4 RID: 15828
		private static readonly IntPtr NativeFieldInfoPtr_dialoguesBuffDuration;

		// Token: 0x04003DD5 RID: 15829
		private static readonly IntPtr NativeFieldInfoPtr_lunaticCookBuffDuration;

		// Token: 0x04003DD6 RID: 15830
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverBuffDuration;

		// Token: 0x04003DD7 RID: 15831
		private static readonly IntPtr NativeFieldInfoPtr_kosuzuFeverDuration;

		// Token: 0x04003DD8 RID: 15832
		private static readonly IntPtr NativeFieldInfoPtr_extraMoodGet;

		// Token: 0x04003DD9 RID: 15833
		private static readonly IntPtr NativeFieldInfoPtr_eachComboAddSpeed;

		// Token: 0x04003DDA RID: 15834
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverParent;

		// Token: 0x04003DDB RID: 15835
		private static readonly IntPtr NativeFieldInfoPtr_kosuzuDialoguesEndCallback;

		// Token: 0x04003DDC RID: 15836
		private static readonly IntPtr NativeFieldInfoPtr_kosuzuFeverEndCallback;

		// Token: 0x04003DDD RID: 15837
		private static readonly IntPtr NativeFieldInfoPtr_kosuzuLunaticCookEndCallback;

		// Token: 0x04003DDE RID: 15838
		private static readonly IntPtr NativeFieldInfoPtr_kosuzuThrowDeliverEndCallback;

		// Token: 0x04003DDF RID: 15839
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFocusedDeskCode;

		// Token: 0x04003DE0 RID: 15840
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalThrowDeliverStatus;

		// Token: 0x04003DE1 RID: 15841
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverIndicator;

		// Token: 0x04003DE2 RID: 15842
		private static readonly IntPtr NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Virtual_String_0;

		// Token: 0x04003DE3 RID: 15843
		private static readonly IntPtr NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_Void_Int32_Boolean_0;

		// Token: 0x04003DE4 RID: 15844
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

		// Token: 0x04003DE5 RID: 15845
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLegacyThrowDeliverVisual_Private_Void_0;

		// Token: 0x04003DE6 RID: 15846
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_Void_0;

		// Token: 0x04003DE7 RID: 15847
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_Void_Int32_0;

		// Token: 0x04003DE8 RID: 15848
		private static readonly IntPtr NativeMethodInfoPtr_Kosuzu_Dialogues_Private_Void_0;

		// Token: 0x04003DE9 RID: 15849
		private static readonly IntPtr NativeMethodInfoPtr_Kosuzu_LunaticCook_Private_Void_0;

		// Token: 0x04003DEA RID: 15850
		private static readonly IntPtr NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003DEB RID: 15851
		private static readonly IntPtr NativeMethodInfoPtr_Kosuzu_ThrowDeliver_Private_Void_0;

		// Token: 0x04003DEC RID: 15852
		private static readonly IntPtr NativeMethodInfoPtr_Kosuzu_Fever_Private_Void_0;

		// Token: 0x04003DED RID: 15853
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBuff_Public_Virtual_Void_0;

		// Token: 0x04003DEE RID: 15854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003DEF RID: 15855
		private static readonly IntPtr NativeMethodInfoPtr__Kosuzu_Dialogues_b__23_0_Private_Void_0;

		// Token: 0x04003DF0 RID: 15856
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Single_PDM_0;

		// Token: 0x04003DF1 RID: 15857
		private static readonly IntPtr NativeMethodInfoPtr__Kosuzu_LunaticCook_b__24_1_Private_Void_0;

		// Token: 0x04003DF2 RID: 15858
		private static readonly IntPtr NativeMethodInfoPtr__Kosuzu_LunaticCook_b__24_2_Private_String_Int32_String_0;

		// Token: 0x04003DF3 RID: 15859
		private static readonly IntPtr NativeMethodInfoPtr__Kosuzu_ThrowDeliver_b__26_0_Private_Void_0;

		// Token: 0x04003DF4 RID: 15860
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Single_PDM_1;

		// Token: 0x04003DF5 RID: 15861
		private static readonly IntPtr NativeMethodInfoPtr__Kosuzu_Fever_b__27_1_Private_Void_0;

		// Token: 0x02000D37 RID: 3383
		[ObfuscatedName("GameData.Profile.KosuzuQTEBuffReward+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F354 RID: 62292 RVA: 0x00399C68 File Offset: 0x00397E68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KosuzuQTEBuffReward>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr);
				KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr, "startPosition");
				KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr, "targetPosition");
				KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr, 100682565);
				KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr, 100682566);
			}

			// Token: 0x0600F355 RID: 62293 RVA: 0x00399CF8 File Offset: 0x00397EF8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KosuzuQTEBuffReward.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F356 RID: 62294 RVA: 0x00399D34 File Offset: 0x00397F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233311, XrefRangeEnd = 233314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F357 RID: 62295 RVA: 0x000829BB File Offset: 0x00080BBB
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F1A RID: 20250
			// (get) Token: 0x0600F358 RID: 62296 RVA: 0x00399D74 File Offset: 0x00397F74
			// (set) Token: 0x0600F359 RID: 62297 RVA: 0x000829C4 File Offset: 0x00080BC4
			public unsafe KosuzuQTEBuffReward __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KosuzuQTEBuffReward>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F1B RID: 20251
			// (get) Token: 0x0600F35A RID: 62298 RVA: 0x00399DA4 File Offset: 0x00397FA4
			// (set) Token: 0x0600F35B RID: 62299 RVA: 0x000829E3 File Offset: 0x00080BE3
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17004F1C RID: 20252
			// (get) Token: 0x0600F35C RID: 62300 RVA: 0x00399DCC File Offset: 0x00397FCC
			// (set) Token: 0x0600F35D RID: 62301 RVA: 0x000829FE File Offset: 0x00080BFE
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KosuzuQTEBuffReward.__c__DisplayClass22_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x04009AFE RID: 39678
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009AFF RID: 39679
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x04009B00 RID: 39680
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04009B01 RID: 39681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B02 RID: 39682
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;
		}
	}
}
