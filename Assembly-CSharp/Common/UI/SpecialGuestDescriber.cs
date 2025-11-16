using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000368 RID: 872
	public class SpecialGuestDescriber : LanguageBaseDescriber
	{
		// Token: 0x06006747 RID: 26439 RVA: 0x001F7508 File Offset: 0x001F5708
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuestDescriber()
		{
			Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "SpecialGuestDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr);
			SpecialGuestDescriber.NativeFieldInfoPtr_bse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "bse");
			SpecialGuestDescriber.NativeFieldInfoPtr_eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "eyes");
			SpecialGuestDescriber.NativeFieldInfoPtr_trimBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "trimBack");
			SpecialGuestDescriber.NativeFieldInfoPtr_trimFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "trimFront");
			SpecialGuestDescriber.NativeFieldInfoPtr_portrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "portrayal");
			SpecialGuestDescriber.NativeFieldInfoPtr_foodTagParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "foodTagParent");
			SpecialGuestDescriber.NativeFieldInfoPtr_banTagParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "banTagParent");
			SpecialGuestDescriber.NativeFieldInfoPtr_bevTagParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "bevTagParent");
			SpecialGuestDescriber.NativeFieldInfoPtr_placeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "placeText");
			SpecialGuestDescriber.NativeFieldInfoPtr_foodTagField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "foodTagField");
			SpecialGuestDescriber.NativeFieldInfoPtr_bevTagField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "bevTagField");
			SpecialGuestDescriber.NativeFieldInfoPtr_funds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "funds");
			SpecialGuestDescriber.NativeFieldInfoPtr_kizunaField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "kizunaField");
			SpecialGuestDescriber.NativeFieldInfoPtr_kizunaExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "kizunaExp");
			SpecialGuestDescriber.NativeFieldInfoPtr_kizunaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "kizunaLevel");
			SpecialGuestDescriber.NativeFieldInfoPtr_InfoField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "InfoField");
			SpecialGuestDescriber.NativeFieldInfoPtr_DescriptionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "DescriptionField");
			SpecialGuestDescriber.NativeFieldInfoPtr_GotoInfoToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "GotoInfoToggle");
			SpecialGuestDescriber.NativeFieldInfoPtr_GotoDescriptionToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "GotoDescriptionToggle");
			SpecialGuestDescriber.NativeFieldInfoPtr_partnerProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "partnerProperties");
			SpecialGuestDescriber.NativeFieldInfoPtr_positiveSC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "positiveSC");
			SpecialGuestDescriber.NativeFieldInfoPtr_negativeSC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "negativeSC");
			SpecialGuestDescriber.NativeFieldInfoPtr_allBanTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "allBanTagInstances");
			SpecialGuestDescriber.NativeFieldInfoPtr_allBevTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "allBevTagInstances");
			SpecialGuestDescriber.NativeFieldInfoPtr_allFoodTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "allFoodTagInstances");
			SpecialGuestDescriber.NativeFieldInfoPtr_currencyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "currencyInfo");
			SpecialGuestDescriber.NativeFieldInfoPtr_m_CurrentSwitcherSwitcherMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "m_CurrentSwitcherSwitcherMode");
			SpecialGuestDescriber.NativeFieldInfoPtr_m_LastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "m_LastMode");
			SpecialGuestDescriber.NativeFieldInfoPtr_trimBackCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "trimBackCoroutine");
			SpecialGuestDescriber.NativeFieldInfoPtr_m_IsSwitchModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "m_IsSwitchModeEnabled");
			SpecialGuestDescriber.NativeFieldInfoPtr_trimFrontCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "trimFrontCoroutine");
			SpecialGuestDescriber.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684897);
			SpecialGuestDescriber.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684898);
			SpecialGuestDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684899);
			SpecialGuestDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684900);
			SpecialGuestDescriber.NativeMethodInfoPtr_SwitchMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684901);
			SpecialGuestDescriber.NativeMethodInfoPtr_ShowDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684902);
			SpecialGuestDescriber.NativeMethodInfoPtr_ShowInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684903);
			SpecialGuestDescriber.NativeMethodInfoPtr_UpdateModeVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684904);
			SpecialGuestDescriber.NativeMethodInfoPtr_StartTrimCoroutine_Private_Void_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684905);
			SpecialGuestDescriber.NativeMethodInfoPtr_SetParticularMode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684906);
			SpecialGuestDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684907);
			SpecialGuestDescriber.NativeMethodInfoPtr_ApplySpriteOffset_Private_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684908);
			SpecialGuestDescriber.NativeMethodInfoPtr_DescribePartner_Public_Void_SpecialGuest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684909);
			SpecialGuestDescriber.NativeMethodInfoPtr_DescribeSpellCard_Public_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684910);
			SpecialGuestDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684911);
			SpecialGuestDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, 100684912);
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x001F78E4 File Offset: 0x001F5AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265999, XrefRangeEnd = 266053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x001F7918 File Offset: 0x001F5B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266053, XrefRangeEnd = 266057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x001F794C File Offset: 0x001F5B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266057, XrefRangeEnd = 266077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x001F7988 File Offset: 0x001F5B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266077, XrefRangeEnd = 266083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x001F79C4 File Offset: 0x001F5BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266083, XrefRangeEnd = 266084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_SwitchMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x001F79F8 File Offset: 0x001F5BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266084, XrefRangeEnd = 266085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_ShowDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x001F7A2C File Offset: 0x001F5C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266085, XrefRangeEnd = 266086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_ShowInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x001F7A60 File Offset: 0x001F5C60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 266097, RefRangeEnd = 266101, XrefRangeStart = 266086, XrefRangeEnd = 266097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModeVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_UpdateModeVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x001F7A94 File Offset: 0x001F5C94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266121, RefRangeEnd = 266123, XrefRangeStart = 266101, XrefRangeEnd = 266121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrimCoroutine(CharacterSpriteSetCompact pixel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pixel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_StartTrimCoroutine_Private_Void_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x001F7AD8 File Offset: 0x001F5CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266125, RefRangeEnd = 266127, XrefRangeStart = 266123, XrefRangeEnd = 266125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticularMode(bool hideKisunaBox)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hideKisunaBox;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_SetParticularMode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x001F7B18 File Offset: 0x001F5D18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 266248, RefRangeEnd = 266251, XrefRangeStart = 266127, XrefRangeEnd = 266248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(SpecialGuest detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x001F7B74 File Offset: 0x001F5D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266262, RefRangeEnd = 266264, XrefRangeStart = 266251, XrefRangeEnd = 266262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySpriteOffset(SpecialGuest detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_ApplySpriteOffset_Private_Void_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x001F7BB8 File Offset: 0x001F5DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266286, RefRangeEnd = 266287, XrefRangeStart = 266264, XrefRangeEnd = 266286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribePartner(SpecialGuest detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_DescribePartner_Public_Void_SpecialGuest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x001F7C14 File Offset: 0x001F5E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266478, RefRangeEnd = 266479, XrefRangeStart = 266287, XrefRangeEnd = 266478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeSpellCard(SpecialGuest detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr_DescribeSpellCard_Public_Void_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x001F7C58 File Offset: 0x001F5E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266479, XrefRangeEnd = 266508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x001F7C94 File Offset: 0x001F5E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266508, XrefRangeEnd = 266527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x00037C2C File Offset: 0x00035E2C
		public SpecialGuestDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x001F7CD0 File Offset: 0x001F5ED0
		// (set) Token: 0x0600675A RID: 26458 RVA: 0x00037C35 File Offset: 0x00035E35
		public unsafe Image bse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_bse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_bse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x0600675B RID: 26459 RVA: 0x001F7D00 File Offset: 0x001F5F00
		// (set) Token: 0x0600675C RID: 26460 RVA: 0x00037C54 File Offset: 0x00035E54
		public unsafe Image eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x0600675D RID: 26461 RVA: 0x001F7D30 File Offset: 0x001F5F30
		// (set) Token: 0x0600675E RID: 26462 RVA: 0x00037C73 File Offset: 0x00035E73
		public unsafe Image trimBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x0600675F RID: 26463 RVA: 0x001F7D60 File Offset: 0x001F5F60
		// (set) Token: 0x06006760 RID: 26464 RVA: 0x00037C92 File Offset: 0x00035E92
		public unsafe Image trimFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06006761 RID: 26465 RVA: 0x001F7D90 File Offset: 0x001F5F90
		// (set) Token: 0x06006762 RID: 26466 RVA: 0x00037CB1 File Offset: 0x00035EB1
		public unsafe Image portrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_portrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_portrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06006763 RID: 26467 RVA: 0x001F7DC0 File Offset: 0x001F5FC0
		// (set) Token: 0x06006764 RID: 26468 RVA: 0x00037CD0 File Offset: 0x00035ED0
		public unsafe GameObject foodTagParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_foodTagParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_foodTagParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x06006765 RID: 26469 RVA: 0x001F7DF0 File Offset: 0x001F5FF0
		// (set) Token: 0x06006766 RID: 26470 RVA: 0x00037CEF File Offset: 0x00035EEF
		public unsafe GameObject banTagParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_banTagParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_banTagParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x06006767 RID: 26471 RVA: 0x001F7E20 File Offset: 0x001F6020
		// (set) Token: 0x06006768 RID: 26472 RVA: 0x00037D0E File Offset: 0x00035F0E
		public unsafe GameObject bevTagParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_bevTagParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_bevTagParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x001F7E50 File Offset: 0x001F6050
		// (set) Token: 0x0600676A RID: 26474 RVA: 0x00037D2D File Offset: 0x00035F2D
		public unsafe TextMeshProUGUI placeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_placeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_placeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x0600676B RID: 26475 RVA: 0x001F7E80 File Offset: 0x001F6080
		// (set) Token: 0x0600676C RID: 26476 RVA: 0x00037D4C File Offset: 0x00035F4C
		public unsafe RectTransform foodTagField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_foodTagField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_foodTagField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x0600676D RID: 26477 RVA: 0x001F7EB0 File Offset: 0x001F60B0
		// (set) Token: 0x0600676E RID: 26478 RVA: 0x00037D6B File Offset: 0x00035F6B
		public unsafe RectTransform bevTagField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_bevTagField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_bevTagField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x001F7EE0 File Offset: 0x001F60E0
		// (set) Token: 0x06006770 RID: 26480 RVA: 0x00037D8A File Offset: 0x00035F8A
		public unsafe TextMeshProUGUI funds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_funds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_funds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x001F7F10 File Offset: 0x001F6110
		// (set) Token: 0x06006772 RID: 26482 RVA: 0x00037DA9 File Offset: 0x00035FA9
		public unsafe GameObject kizunaField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_kizunaField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_kizunaField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06006773 RID: 26483 RVA: 0x001F7F40 File Offset: 0x001F6140
		// (set) Token: 0x06006774 RID: 26484 RVA: 0x00037DC8 File Offset: 0x00035FC8
		public unsafe Image kizunaExp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_kizunaExp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_kizunaExp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06006775 RID: 26485 RVA: 0x001F7F70 File Offset: 0x001F6170
		// (set) Token: 0x06006776 RID: 26486 RVA: 0x00037DE7 File Offset: 0x00035FE7
		public unsafe TextMeshProUGUI kizunaLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_kizunaLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_kizunaLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x001F7FA0 File Offset: 0x001F61A0
		// (set) Token: 0x06006778 RID: 26488 RVA: 0x00037E06 File Offset: 0x00036006
		public unsafe CanvasGroup InfoField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_InfoField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_InfoField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06006779 RID: 26489 RVA: 0x001F7FD0 File Offset: 0x001F61D0
		// (set) Token: 0x0600677A RID: 26490 RVA: 0x00037E25 File Offset: 0x00036025
		public unsafe CanvasGroup DescriptionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_DescriptionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_DescriptionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600677B RID: 26491 RVA: 0x001F8000 File Offset: 0x001F6200
		// (set) Token: 0x0600677C RID: 26492 RVA: 0x00037E44 File Offset: 0x00036044
		public unsafe UIButtonToggle GotoInfoToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_GotoInfoToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_GotoInfoToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600677D RID: 26493 RVA: 0x001F8030 File Offset: 0x001F6230
		// (set) Token: 0x0600677E RID: 26494 RVA: 0x00037E63 File Offset: 0x00036063
		public unsafe UIButtonToggle GotoDescriptionToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_GotoDescriptionToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_GotoDescriptionToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x0600677F RID: 26495 RVA: 0x001F8060 File Offset: 0x001F6260
		// (set) Token: 0x06006780 RID: 26496 RVA: 0x00037E82 File Offset: 0x00036082
		public unsafe TextMeshProUGUI partnerProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_partnerProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_partnerProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x001F8090 File Offset: 0x001F6290
		// (set) Token: 0x06006782 RID: 26498 RVA: 0x00037EA1 File Offset: 0x000360A1
		public unsafe UIElementCluster positiveSC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_positiveSC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_positiveSC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x001F80C0 File Offset: 0x001F62C0
		// (set) Token: 0x06006784 RID: 26500 RVA: 0x00037EC0 File Offset: 0x000360C0
		public unsafe UIElementCluster negativeSC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_negativeSC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_negativeSC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06006785 RID: 26501 RVA: 0x001F80F0 File Offset: 0x001F62F0
		// (set) Token: 0x06006786 RID: 26502 RVA: 0x00037EDF File Offset: 0x000360DF
		public unsafe List<GameObject> allBanTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_allBanTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_allBanTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x001F8120 File Offset: 0x001F6320
		// (set) Token: 0x06006788 RID: 26504 RVA: 0x00037EFE File Offset: 0x000360FE
		public unsafe List<GameObject> allBevTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_allBevTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_allBevTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x001F8150 File Offset: 0x001F6350
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x00037F1D File Offset: 0x0003611D
		public unsafe List<GameObject> allFoodTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_allFoodTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_allFoodTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x001F8180 File Offset: 0x001F6380
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x00037F3C File Offset: 0x0003613C
		public unsafe NumberFormatInfo currencyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_currencyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_currencyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x001F81B0 File Offset: 0x001F63B0
		// (set) Token: 0x0600678E RID: 26510 RVA: 0x00037F5B File Offset: 0x0003615B
		public unsafe SpecialGuestDescriber.SwitcherMode m_CurrentSwitcherSwitcherMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_m_CurrentSwitcherSwitcherMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_m_CurrentSwitcherSwitcherMode)) = value;
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x0600678F RID: 26511 RVA: 0x001F81D8 File Offset: 0x001F63D8
		// (set) Token: 0x06006790 RID: 26512 RVA: 0x00037F76 File Offset: 0x00036176
		public Nullable<bool> m_LastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_m_LastMode);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_m_LastMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x001F8208 File Offset: 0x001F6408
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x00037FA4 File Offset: 0x000361A4
		public unsafe Coroutine trimBackCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimBackCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimBackCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x001F8238 File Offset: 0x001F6438
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x00037FC3 File Offset: 0x000361C3
		public unsafe bool m_IsSwitchModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_m_IsSwitchModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_m_IsSwitchModeEnabled)) = value;
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06006795 RID: 26517 RVA: 0x001F8260 File Offset: 0x001F6460
		// (set) Token: 0x06006796 RID: 26518 RVA: 0x00037FDE File Offset: 0x000361DE
		public unsafe Coroutine trimFrontCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimFrontCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.NativeFieldInfoPtr_trimFrontCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004481 RID: 17537
		private static readonly IntPtr NativeFieldInfoPtr_bse;

		// Token: 0x04004482 RID: 17538
		private static readonly IntPtr NativeFieldInfoPtr_eyes;

		// Token: 0x04004483 RID: 17539
		private static readonly IntPtr NativeFieldInfoPtr_trimBack;

		// Token: 0x04004484 RID: 17540
		private static readonly IntPtr NativeFieldInfoPtr_trimFront;

		// Token: 0x04004485 RID: 17541
		private static readonly IntPtr NativeFieldInfoPtr_portrayal;

		// Token: 0x04004486 RID: 17542
		private static readonly IntPtr NativeFieldInfoPtr_foodTagParent;

		// Token: 0x04004487 RID: 17543
		private static readonly IntPtr NativeFieldInfoPtr_banTagParent;

		// Token: 0x04004488 RID: 17544
		private static readonly IntPtr NativeFieldInfoPtr_bevTagParent;

		// Token: 0x04004489 RID: 17545
		private static readonly IntPtr NativeFieldInfoPtr_placeText;

		// Token: 0x0400448A RID: 17546
		private static readonly IntPtr NativeFieldInfoPtr_foodTagField;

		// Token: 0x0400448B RID: 17547
		private static readonly IntPtr NativeFieldInfoPtr_bevTagField;

		// Token: 0x0400448C RID: 17548
		private static readonly IntPtr NativeFieldInfoPtr_funds;

		// Token: 0x0400448D RID: 17549
		private static readonly IntPtr NativeFieldInfoPtr_kizunaField;

		// Token: 0x0400448E RID: 17550
		private static readonly IntPtr NativeFieldInfoPtr_kizunaExp;

		// Token: 0x0400448F RID: 17551
		private static readonly IntPtr NativeFieldInfoPtr_kizunaLevel;

		// Token: 0x04004490 RID: 17552
		private static readonly IntPtr NativeFieldInfoPtr_InfoField;

		// Token: 0x04004491 RID: 17553
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionField;

		// Token: 0x04004492 RID: 17554
		private static readonly IntPtr NativeFieldInfoPtr_GotoInfoToggle;

		// Token: 0x04004493 RID: 17555
		private static readonly IntPtr NativeFieldInfoPtr_GotoDescriptionToggle;

		// Token: 0x04004494 RID: 17556
		private static readonly IntPtr NativeFieldInfoPtr_partnerProperties;

		// Token: 0x04004495 RID: 17557
		private static readonly IntPtr NativeFieldInfoPtr_positiveSC;

		// Token: 0x04004496 RID: 17558
		private static readonly IntPtr NativeFieldInfoPtr_negativeSC;

		// Token: 0x04004497 RID: 17559
		private static readonly IntPtr NativeFieldInfoPtr_allBanTagInstances;

		// Token: 0x04004498 RID: 17560
		private static readonly IntPtr NativeFieldInfoPtr_allBevTagInstances;

		// Token: 0x04004499 RID: 17561
		private static readonly IntPtr NativeFieldInfoPtr_allFoodTagInstances;

		// Token: 0x0400449A RID: 17562
		private static readonly IntPtr NativeFieldInfoPtr_currencyInfo;

		// Token: 0x0400449B RID: 17563
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSwitcherSwitcherMode;

		// Token: 0x0400449C RID: 17564
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMode;

		// Token: 0x0400449D RID: 17565
		private static readonly IntPtr NativeFieldInfoPtr_trimBackCoroutine;

		// Token: 0x0400449E RID: 17566
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSwitchModeEnabled;

		// Token: 0x0400449F RID: 17567
		private static readonly IntPtr NativeFieldInfoPtr_trimFrontCoroutine;

		// Token: 0x040044A0 RID: 17568
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x040044A1 RID: 17569
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040044A2 RID: 17570
		private static readonly IntPtr NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0;

		// Token: 0x040044A3 RID: 17571
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040044A4 RID: 17572
		private static readonly IntPtr NativeMethodInfoPtr_SwitchMode_Public_Void_0;

		// Token: 0x040044A5 RID: 17573
		private static readonly IntPtr NativeMethodInfoPtr_ShowDescription_Private_Void_0;

		// Token: 0x040044A6 RID: 17574
		private static readonly IntPtr NativeMethodInfoPtr_ShowInfo_Private_Void_0;

		// Token: 0x040044A7 RID: 17575
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModeVisual_Private_Void_0;

		// Token: 0x040044A8 RID: 17576
		private static readonly IntPtr NativeMethodInfoPtr_StartTrimCoroutine_Private_Void_CharacterSpriteSetCompact_0;

		// Token: 0x040044A9 RID: 17577
		private static readonly IntPtr NativeMethodInfoPtr_SetParticularMode_Public_Void_Boolean_0;

		// Token: 0x040044AA RID: 17578
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0;

		// Token: 0x040044AB RID: 17579
		private static readonly IntPtr NativeMethodInfoPtr_ApplySpriteOffset_Private_Void_SpecialGuest_0;

		// Token: 0x040044AC RID: 17580
		private static readonly IntPtr NativeMethodInfoPtr_DescribePartner_Public_Void_SpecialGuest_CancellationToken_0;

		// Token: 0x040044AD RID: 17581
		private static readonly IntPtr NativeMethodInfoPtr_DescribeSpellCard_Public_Void_SpecialGuest_0;

		// Token: 0x040044AE RID: 17582
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040044AF RID: 17583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E67 RID: 3687
		public enum SwitcherMode
		{
			// Token: 0x0400A65E RID: 42590
			Info,
			// Token: 0x0400A65F RID: 42591
			Description
		}

		// Token: 0x02000E68 RID: 3688
		[ObfuscatedName("Common.UI.SpecialGuestDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060106C9 RID: 67273 RVA: 0x003D054C File Offset: 0x003CE74C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr);
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__31_0");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__41_0");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__44_0");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__44_1");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__44_2");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__44_3");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__44_4");
				SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, "<>9__44_5");
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684914);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__Awake_b__31_0_Internal_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684915);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__Describe_b__41_0_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684916);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684917);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684918);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684919);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684920);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684921);
				SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr, 100684922);
			}

			// Token: 0x060106CA RID: 67274 RVA: 0x003D06E0 File Offset: 0x003CE8E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106CB RID: 67275 RVA: 0x003D071C File Offset: 0x003CE91C
			[CallerCount(0)]
			public unsafe void _Awake_b__31_0(UIButtonToggle toggle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__Awake_b__31_0_Internal_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106CC RID: 67276 RVA: 0x003D0760 File Offset: 0x003CE960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265963, XrefRangeEnd = 265975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__41_0(UIElementCluster interactableBase, int tagId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactableBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__Describe_b__41_0_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106CD RID: 67277 RVA: 0x003D07B0 File Offset: 0x003CE9B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeSpellCard_b__44_0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106CE RID: 67278 RVA: 0x003D07F4 File Offset: 0x003CE9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeSpellCard_b__44_1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106CF RID: 67279 RVA: 0x003D0838 File Offset: 0x003CEA38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeSpellCard_b__44_2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106D0 RID: 67280 RVA: 0x003D087C File Offset: 0x003CEA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeSpellCard_b__44_3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106D1 RID: 67281 RVA: 0x003D08C0 File Offset: 0x003CEAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeSpellCard_b__44_4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106D2 RID: 67282 RVA: 0x003D0904 File Offset: 0x003CEB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeSpellCard_b__44_5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c.NativeMethodInfoPtr__DescribeSpellCard_b__44_5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106D3 RID: 67283 RVA: 0x0008F4B9 File Offset: 0x0008D6B9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055CD RID: 21965
			// (get) Token: 0x060106D4 RID: 67284 RVA: 0x003D0948 File Offset: 0x003CEB48
			// (set) Token: 0x060106D5 RID: 67285 RVA: 0x0008F4C2 File Offset: 0x0008D6C2
			public unsafe static SpecialGuestDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055CE RID: 21966
			// (get) Token: 0x060106D6 RID: 67286 RVA: 0x003D0970 File Offset: 0x003CEB70
			// (set) Token: 0x060106D7 RID: 67287 RVA: 0x0008F4D4 File Offset: 0x0008D6D4
			public unsafe static Action<UIButtonToggle> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055CF RID: 21967
			// (get) Token: 0x060106D8 RID: 67288 RVA: 0x003D0998 File Offset: 0x003CEB98
			// (set) Token: 0x060106D9 RID: 67289 RVA: 0x0008F4E6 File Offset: 0x0008D6E6
			public unsafe static Action<UIElementCluster, int> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D0 RID: 21968
			// (get) Token: 0x060106DA RID: 67290 RVA: 0x003D09C0 File Offset: 0x003CEBC0
			// (set) Token: 0x060106DB RID: 67291 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
			public unsafe static Action<TextMeshProUGUI> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D1 RID: 21969
			// (get) Token: 0x060106DC RID: 67292 RVA: 0x003D09E8 File Offset: 0x003CEBE8
			// (set) Token: 0x060106DD RID: 67293 RVA: 0x0008F50A File Offset: 0x0008D70A
			public unsafe static Action<TextMeshProUGUI> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D2 RID: 21970
			// (get) Token: 0x060106DE RID: 67294 RVA: 0x003D0A10 File Offset: 0x003CEC10
			// (set) Token: 0x060106DF RID: 67295 RVA: 0x0008F51C File Offset: 0x0008D71C
			public unsafe static Action<TextMeshProUGUI> __9__44_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D3 RID: 21971
			// (get) Token: 0x060106E0 RID: 67296 RVA: 0x003D0A38 File Offset: 0x003CEC38
			// (set) Token: 0x060106E1 RID: 67297 RVA: 0x0008F52E File Offset: 0x0008D72E
			public unsafe static Action<TextMeshProUGUI> __9__44_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D4 RID: 21972
			// (get) Token: 0x060106E2 RID: 67298 RVA: 0x003D0A60 File Offset: 0x003CEC60
			// (set) Token: 0x060106E3 RID: 67299 RVA: 0x0008F540 File Offset: 0x0008D740
			public unsafe static Action<TextMeshProUGUI> __9__44_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D5 RID: 21973
			// (get) Token: 0x060106E4 RID: 67300 RVA: 0x003D0A88 File Offset: 0x003CEC88
			// (set) Token: 0x060106E5 RID: 67301 RVA: 0x0008F552 File Offset: 0x0008D752
			public unsafe static Action<TextMeshProUGUI> __9__44_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestDescriber.__c.NativeFieldInfoPtr___9__44_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A660 RID: 42592
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A661 RID: 42593
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x0400A662 RID: 42594
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400A663 RID: 42595
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x0400A664 RID: 42596
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x0400A665 RID: 42597
			private static readonly IntPtr NativeFieldInfoPtr___9__44_2;

			// Token: 0x0400A666 RID: 42598
			private static readonly IntPtr NativeFieldInfoPtr___9__44_3;

			// Token: 0x0400A667 RID: 42599
			private static readonly IntPtr NativeFieldInfoPtr___9__44_4;

			// Token: 0x0400A668 RID: 42600
			private static readonly IntPtr NativeFieldInfoPtr___9__44_5;

			// Token: 0x0400A669 RID: 42601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A66A RID: 42602
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__31_0_Internal_Void_UIButtonToggle_0;

			// Token: 0x0400A66B RID: 42603
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__41_0_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A66C RID: 42604
			private static readonly IntPtr NativeMethodInfoPtr__DescribeSpellCard_b__44_0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A66D RID: 42605
			private static readonly IntPtr NativeMethodInfoPtr__DescribeSpellCard_b__44_1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A66E RID: 42606
			private static readonly IntPtr NativeMethodInfoPtr__DescribeSpellCard_b__44_2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A66F RID: 42607
			private static readonly IntPtr NativeMethodInfoPtr__DescribeSpellCard_b__44_3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A670 RID: 42608
			private static readonly IntPtr NativeMethodInfoPtr__DescribeSpellCard_b__44_4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A671 RID: 42609
			private static readonly IntPtr NativeMethodInfoPtr__DescribeSpellCard_b__44_5_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E69 RID: 3689
		[ObfuscatedName("Common.UI.SpecialGuestDescriber+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x060106E6 RID: 67302 RVA: 0x003D0AB0 File Offset: 0x003CECB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr);
				SpecialGuestDescriber.__c__DisplayClass39_0.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr, "pixel");
				SpecialGuestDescriber.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				SpecialGuestDescriber.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr, 100684923);
				SpecialGuestDescriber.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr, 100684924);
			}

			// Token: 0x060106E7 RID: 67303 RVA: 0x003D0B2C File Offset: 0x003CED2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106E8 RID: 67304 RVA: 0x003D0B68 File Offset: 0x003CED68
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 265997, RefRangeEnd = 265999, XrefRangeStart = 265992, XrefRangeEnd = 265997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Single_Int32_Boolean_0(float delay, int arraySize, bool frontOrBack)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref delay;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontOrBack;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060106E9 RID: 67305 RVA: 0x0008F564 File Offset: 0x0008D764
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055D6 RID: 21974
			// (get) Token: 0x060106EA RID: 67306 RVA: 0x003D0BD0 File Offset: 0x003CEDD0
			// (set) Token: 0x060106EB RID: 67307 RVA: 0x0008F56D File Offset: 0x0008D76D
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055D7 RID: 21975
			// (get) Token: 0x060106EC RID: 67308 RVA: 0x003D0C00 File Offset: 0x003CEE00
			// (set) Token: 0x060106ED RID: 67309 RVA: 0x0008F58C File Offset: 0x0008D78C
			public unsafe SpecialGuestDescriber __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A672 RID: 42610
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400A673 RID: 42611
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A674 RID: 42612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A675 RID: 42613
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Single_Int32_Boolean_0;

			// Token: 0x020010B5 RID: 4277
			[ObfuscatedName("Common.UI.SpecialGuestDescriber+<>c__DisplayClass39_0+<<StartTrimCoroutine>g__Display|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique : Il2CppSystem.Object
			{
				// Token: 0x060122F3 RID: 74483 RVA: 0x004258DC File Offset: 0x00423ADC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique()
				{
					Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0>.NativeClassPtr, "<<StartTrimCoroutine>g__Display|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr);
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<>1__state");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<>2__current");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "delay");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_frontOrBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "frontOrBack");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<>4__this");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_arraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "arraySize");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<index>5__2");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<wait>5__3");
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684925);
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684926);
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684927);
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684928);
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684929);
					SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684930);
				}

				// Token: 0x060122F4 RID: 74484 RVA: 0x00425A20 File Offset: 0x00423C20
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122F5 RID: 74485 RVA: 0x00425A68 File Offset: 0x00423C68
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122F6 RID: 74486 RVA: 0x00425A9C File Offset: 0x00423C9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265975, XrefRangeEnd = 265986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F24 RID: 24356
				// (get) Token: 0x060122F7 RID: 74487 RVA: 0x00425AD8 File Offset: 0x00423CD8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122F8 RID: 74488 RVA: 0x00425B18 File Offset: 0x00423D18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265986, XrefRangeEnd = 265992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F25 RID: 24357
				// (get) Token: 0x060122F9 RID: 74489 RVA: 0x00425B4C File Offset: 0x00423D4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122FA RID: 74490 RVA: 0x0009DE55 File Offset: 0x0009C055
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F1C RID: 24348
				// (get) Token: 0x060122FB RID: 74491 RVA: 0x00425B8C File Offset: 0x00423D8C
				// (set) Token: 0x060122FC RID: 74492 RVA: 0x0009DE5E File Offset: 0x0009C05E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F1D RID: 24349
				// (get) Token: 0x060122FD RID: 74493 RVA: 0x00425BB4 File Offset: 0x00423DB4
				// (set) Token: 0x060122FE RID: 74494 RVA: 0x0009DE79 File Offset: 0x0009C079
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F1E RID: 24350
				// (get) Token: 0x060122FF RID: 74495 RVA: 0x00425BE4 File Offset: 0x00423DE4
				// (set) Token: 0x06012300 RID: 74496 RVA: 0x0009DE98 File Offset: 0x0009C098
				public unsafe float delay
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_delay);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_delay)) = value;
					}
				}

				// Token: 0x17005F1F RID: 24351
				// (get) Token: 0x06012301 RID: 74497 RVA: 0x00425C0C File Offset: 0x00423E0C
				// (set) Token: 0x06012302 RID: 74498 RVA: 0x0009DEB3 File Offset: 0x0009C0B3
				public unsafe bool frontOrBack
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_frontOrBack);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_frontOrBack)) = value;
					}
				}

				// Token: 0x17005F20 RID: 24352
				// (get) Token: 0x06012303 RID: 74499 RVA: 0x00425C34 File Offset: 0x00423E34
				// (set) Token: 0x06012304 RID: 74500 RVA: 0x0009DECE File Offset: 0x0009C0CE
				public unsafe SpecialGuestDescriber.__c__DisplayClass39_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber.__c__DisplayClass39_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F21 RID: 24353
				// (get) Token: 0x06012305 RID: 74501 RVA: 0x00425C64 File Offset: 0x00423E64
				// (set) Token: 0x06012306 RID: 74502 RVA: 0x0009DEED File Offset: 0x0009C0ED
				public unsafe int arraySize
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_arraySize);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_arraySize)) = value;
					}
				}

				// Token: 0x17005F22 RID: 24354
				// (get) Token: 0x06012307 RID: 74503 RVA: 0x00425C8C File Offset: 0x00423E8C
				// (set) Token: 0x06012308 RID: 74504 RVA: 0x0009DF08 File Offset: 0x0009C108
				public unsafe int _index_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__index_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__index_5__2)) = value;
					}
				}

				// Token: 0x17005F23 RID: 24355
				// (get) Token: 0x06012309 RID: 74505 RVA: 0x00425CB4 File Offset: 0x00423EB4
				// (set) Token: 0x0601230A RID: 74506 RVA: 0x0009DF23 File Offset: 0x0009C123
				public unsafe WaitForSecondsRealtime _wait_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__wait_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B853 RID: 47187
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B854 RID: 47188
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B855 RID: 47189
				private static readonly IntPtr NativeFieldInfoPtr_delay;

				// Token: 0x0400B856 RID: 47190
				private static readonly IntPtr NativeFieldInfoPtr_frontOrBack;

				// Token: 0x0400B857 RID: 47191
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B858 RID: 47192
				private static readonly IntPtr NativeFieldInfoPtr_arraySize;

				// Token: 0x0400B859 RID: 47193
				private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

				// Token: 0x0400B85A RID: 47194
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

				// Token: 0x0400B85B RID: 47195
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B85C RID: 47196
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B85D RID: 47197
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B85E RID: 47198
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B85F RID: 47199
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B860 RID: 47200
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000E6A RID: 3690
		[ObfuscatedName("Common.UI.SpecialGuestDescriber+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x060106EE RID: 67310 RVA: 0x003D0C30 File Offset: 0x003CEE30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestDescriber>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass41_0>.NativeClassPtr);
				SpecialGuestDescriber.__c__DisplayClass41_0.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass41_0>.NativeClassPtr, "tagId");
				SpecialGuestDescriber.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass41_0>.NativeClassPtr, 100684931);
				SpecialGuestDescriber.__c__DisplayClass41_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass41_0>.NativeClassPtr, 100684932);
			}

			// Token: 0x060106EF RID: 67311 RVA: 0x003D0C98 File Offset: 0x003CEE98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestDescriber.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106F0 RID: 67312 RVA: 0x003D0CD4 File Offset: 0x003CEED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestDescriber.__c__DisplayClass41_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060106F1 RID: 67313 RVA: 0x0008F5AB File Offset: 0x0008D7AB
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055D8 RID: 21976
			// (get) Token: 0x060106F2 RID: 67314 RVA: 0x003D0D18 File Offset: 0x003CEF18
			// (set) Token: 0x060106F3 RID: 67315 RVA: 0x0008F5B4 File Offset: 0x0008D7B4
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass41_0.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestDescriber.__c__DisplayClass41_0.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x0400A676 RID: 42614
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x0400A677 RID: 42615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A678 RID: 42616
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__1_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
