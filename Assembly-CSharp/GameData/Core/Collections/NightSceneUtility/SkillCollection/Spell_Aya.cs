using System;
using Common.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using TMPro;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200025F RID: 607
	public class Spell_Aya : SpellBase
	{
		// Token: 0x06004AA8 RID: 19112 RVA: 0x001A2A10 File Offset: 0x001A0C10
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Aya()
		{
			Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Aya");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr);
			Spell_Aya.NativeFieldInfoPtr_AYA_NEWS_CHECK_SHOULD_SPAWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "AYA_NEWS_CHECK_SHOULD_SPAWN");
			Spell_Aya.NativeFieldInfoPtr_AYA_SPECIAL_POSITIVE_SPELL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "AYA_SPECIAL_POSITIVE_SPELL");
			Spell_Aya.NativeFieldInfoPtr_POPULAR_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "POPULAR_ID");
			Spell_Aya.NativeFieldInfoPtr_AYA_ADD_ORDERCOUNT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "AYA_ADD_ORDERCOUNT_KEY");
			Spell_Aya.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "positiveDuration");
			Spell_Aya.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "negativeDuration");
			Spell_Aya.NativeFieldInfoPtr_negativeSpellCardScheduledEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "negativeSpellCardScheduledEventId");
			Spell_Aya.NativeFieldInfoPtr_positiveSpellCardScheduledEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "positiveSpellCardScheduledEventId");
			Spell_Aya.NativeFieldInfoPtr_negativeSpellCardNewsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "negativeSpellCardNewsLabel");
			Spell_Aya.NativeFieldInfoPtr_positiveSpellCardNewsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "positiveSpellCardNewsLabel");
			Spell_Aya.NativeFieldInfoPtr_signatureTagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "signatureTagId");
			Spell_Aya.NativeFieldInfoPtr_signatureExtraOrderRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "signatureExtraOrderRate");
			Spell_Aya.NativeFieldInfoPtr_minCookTimeSatisfyCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "minCookTimeSatisfyCondition");
			Spell_Aya.NativeFieldInfoPtr_addOrderCountRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "addOrderCountRate");
			Spell_Aya.NativeFieldInfoPtr_newspaperVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperVFX");
			Spell_Aya.NativeFieldInfoPtr_newspaperVFXEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperVFXEN");
			Spell_Aya.NativeFieldInfoPtr_newspaperVFXJP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperVFXJP");
			Spell_Aya.NativeFieldInfoPtr_newspaperVFXKR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperVFXKR");
			Spell_Aya.NativeFieldInfoPtr_newspaperVFXCNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperVFXCNT");
			Spell_Aya.NativeFieldInfoPtr_peerlessWindGodTrail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "peerlessWindGodTrail");
			Spell_Aya.NativeFieldInfoPtr_jumpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "jumpEffect");
			Spell_Aya.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "offset");
			Spell_Aya.NativeFieldInfoPtr_newsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newsOffset");
			Spell_Aya.NativeFieldInfoPtr_flashOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "flashOffset");
			Spell_Aya.NativeFieldInfoPtr_startDashCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "startDashCost");
			Spell_Aya.NativeFieldInfoPtr_finalDashCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "finalDashCost");
			Spell_Aya.NativeFieldInfoPtr_dashCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "dashCoolDown");
			Spell_Aya.NativeFieldInfoPtr_dashCoolDown2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "dashCoolDown2");
			Spell_Aya.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "angle");
			Spell_Aya.NativeFieldInfoPtr_xRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "xRange");
			Spell_Aya.NativeFieldInfoPtr_yRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "yRange");
			Spell_Aya.NativeFieldInfoPtr_tagObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "tagObject");
			Spell_Aya.NativeFieldInfoPtr_newsObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newsObject");
			Spell_Aya.NativeFieldInfoPtr_spawnTagEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "spawnTagEffect");
			Spell_Aya.NativeFieldInfoPtr_tornadoVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "tornadoVFX");
			Spell_Aya.NativeFieldInfoPtr_fogVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "fogVFX");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentVFX");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentVFXEN");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXJP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentVFXJP");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXKR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentVFXKR");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXCNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentVFXCNT");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentFinalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentFinalPosition");
			Spell_Aya.NativeFieldInfoPtr_tornadoDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "tornadoDuration");
			Spell_Aya.NativeFieldInfoPtr_tornadoOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "tornadoOffset");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentDuration");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentSpawnWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentSpawnWait");
			Spell_Aya.NativeFieldInfoPtr_itemMinDashDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "itemMinDashDistance");
			Spell_Aya.NativeFieldInfoPtr_itemMaxDashDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "itemMaxDashDistance");
			Spell_Aya.NativeFieldInfoPtr_itemMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "itemMinRange");
			Spell_Aya.NativeFieldInfoPtr_itemMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "itemMaxRange");
			Spell_Aya.NativeFieldInfoPtr_itemControlPoint1AngularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "itemControlPoint1AngularOffset");
			Spell_Aya.NativeFieldInfoPtr_itemControlPoint2AngularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "itemControlPoint2AngularOffset");
			Spell_Aya.NativeFieldInfoPtr_newspaperRewardSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperRewardSfx");
			Spell_Aya.NativeFieldInfoPtr_ayaJumpSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "ayaJumpSfx");
			Spell_Aya.NativeFieldInfoPtr_ayaDash1Sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "ayaDash1Sfx");
			Spell_Aya.NativeFieldInfoPtr_ayaDash2Sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "ayaDash2Sfx");
			Spell_Aya.NativeFieldInfoPtr_tornadoSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "tornadoSfx");
			Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "newspaperPunishmentSfx");
			Spell_Aya.NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "AYA_FAMOUS_IZAKAYA");
			Spell_Aya.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678358);
			Spell_Aya.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678359);
			Spell_Aya.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678360);
			Spell_Aya.NativeMethodInfoPtr_MergeConflict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678361);
			Spell_Aya.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678362);
			Spell_Aya.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678363);
			Spell_Aya.NativeMethodInfoPtr_AyaSignatureBuff_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678364);
			Spell_Aya.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678365);
			Spell_Aya.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678366);
			Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678367);
			Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_14_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678368);
			Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_15_Private_Boolean_Sellable_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678369);
			Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_2_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678370);
			Spell_Aya.NativeMethodInfoPtr__OnBuffEnd_b__66_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, 100678371);
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x001A2FF4 File Offset: 0x001A11F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194904, XrefRangeEnd = 194906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Aya.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x001A3038 File Offset: 0x001A1238
		[CallerCount(0)]
		public unsafe override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Aya.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x001A308C File Offset: 0x001A128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194906, XrefRangeEnd = 194912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Aya.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x001A30E8 File Offset: 0x001A12E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194912, XrefRangeEnd = 194947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeConflict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr_MergeConflict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x001A311C File Offset: 0x001A131C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194947, XrefRangeEnd = 194953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Aya.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x001A3178 File Offset: 0x001A1378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194953, XrefRangeEnd = 194965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawn(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x001A31BC File Offset: 0x001A13BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194965, XrefRangeEnd = 194994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AyaSignatureBuff(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr_AyaSignatureBuff_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x001A3200 File Offset: 0x001A1400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194994, XrefRangeEnd = 195014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x001A3234 File Offset: 0x001A1434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195014, XrefRangeEnd = 195019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Aya() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x001A3270 File Offset: 0x001A1470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195019, XrefRangeEnd = 195054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__63_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x001A32B0 File Offset: 0x001A14B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195054, XrefRangeEnd = 195076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _OnPositiveBuffExecute_b__63_14(int currentTime, string description)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_14_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x001A3308 File Offset: 0x001A1508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195076, XrefRangeEnd = 195077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPositiveBuffExecute_b__63_15(Sellable sellable, float baseTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_15_Private_Boolean_Sellable_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x001A3364 File Offset: 0x001A1564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195077, XrefRangeEnd = 195089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__63_2(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_2_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x001A33A8 File Offset: 0x001A15A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195089, XrefRangeEnd = 195101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBuffEnd_b__66_0(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.NativeMethodInfoPtr__OnBuffEnd_b__66_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00026252 File Offset: 0x00024452
		public Spell_Aya(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x001A33EC File Offset: 0x001A15EC
		// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x0002625B File Offset: 0x0002445B
		public unsafe static string AYA_NEWS_CHECK_SHOULD_SPAWN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Aya.NativeFieldInfoPtr_AYA_NEWS_CHECK_SHOULD_SPAWN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Aya.NativeFieldInfoPtr_AYA_NEWS_CHECK_SHOULD_SPAWN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x001A340C File Offset: 0x001A160C
		// (set) Token: 0x06004ABB RID: 19131 RVA: 0x0002626D File Offset: 0x0002446D
		public unsafe static int AYA_SPECIAL_POSITIVE_SPELL
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Aya.NativeFieldInfoPtr_AYA_SPECIAL_POSITIVE_SPELL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Aya.NativeFieldInfoPtr_AYA_SPECIAL_POSITIVE_SPELL, (void*)(&value));
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x001A3428 File Offset: 0x001A1628
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x0002627B File Offset: 0x0002447B
		public unsafe static int POPULAR_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Aya.NativeFieldInfoPtr_POPULAR_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Aya.NativeFieldInfoPtr_POPULAR_ID, (void*)(&value));
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x001A3444 File Offset: 0x001A1644
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x00026289 File Offset: 0x00024489
		public unsafe static string AYA_ADD_ORDERCOUNT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Aya.NativeFieldInfoPtr_AYA_ADD_ORDERCOUNT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Aya.NativeFieldInfoPtr_AYA_ADD_ORDERCOUNT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x001A3464 File Offset: 0x001A1664
		// (set) Token: 0x06004AC1 RID: 19137 RVA: 0x0002629B File Offset: 0x0002449B
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x001A348C File Offset: 0x001A168C
		// (set) Token: 0x06004AC3 RID: 19139 RVA: 0x000262B6 File Offset: 0x000244B6
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x001A34B4 File Offset: 0x001A16B4
		// (set) Token: 0x06004AC5 RID: 19141 RVA: 0x000262D1 File Offset: 0x000244D1
		public unsafe string negativeSpellCardScheduledEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_negativeSpellCardScheduledEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_negativeSpellCardScheduledEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x001A34DC File Offset: 0x001A16DC
		// (set) Token: 0x06004AC7 RID: 19143 RVA: 0x000262F0 File Offset: 0x000244F0
		public unsafe string positiveSpellCardScheduledEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_positiveSpellCardScheduledEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_positiveSpellCardScheduledEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06004AC8 RID: 19144 RVA: 0x001A3504 File Offset: 0x001A1704
		// (set) Token: 0x06004AC9 RID: 19145 RVA: 0x0002630F File Offset: 0x0002450F
		public unsafe string negativeSpellCardNewsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_negativeSpellCardNewsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_negativeSpellCardNewsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x001A352C File Offset: 0x001A172C
		// (set) Token: 0x06004ACB RID: 19147 RVA: 0x0002632E File Offset: 0x0002452E
		public unsafe string positiveSpellCardNewsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_positiveSpellCardNewsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_positiveSpellCardNewsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x001A3554 File Offset: 0x001A1754
		// (set) Token: 0x06004ACD RID: 19149 RVA: 0x0002634D File Offset: 0x0002454D
		public unsafe int signatureTagId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_signatureTagId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_signatureTagId)) = value;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x001A357C File Offset: 0x001A177C
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x00026368 File Offset: 0x00024568
		public unsafe float signatureExtraOrderRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_signatureExtraOrderRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_signatureExtraOrderRate)) = value;
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x001A35A4 File Offset: 0x001A17A4
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x00026383 File Offset: 0x00024583
		public unsafe float minCookTimeSatisfyCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_minCookTimeSatisfyCondition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_minCookTimeSatisfyCondition)) = value;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x001A35CC File Offset: 0x001A17CC
		// (set) Token: 0x06004AD3 RID: 19155 RVA: 0x0002639E File Offset: 0x0002459E
		public unsafe float addOrderCountRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_addOrderCountRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_addOrderCountRate)) = value;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x001A35F4 File Offset: 0x001A17F4
		// (set) Token: 0x06004AD5 RID: 19157 RVA: 0x000263B9 File Offset: 0x000245B9
		public unsafe GameObject newspaperVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x001A3624 File Offset: 0x001A1824
		// (set) Token: 0x06004AD7 RID: 19159 RVA: 0x000263D8 File Offset: 0x000245D8
		public unsafe GameObject newspaperVFXEN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXEN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXEN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06004AD8 RID: 19160 RVA: 0x001A3654 File Offset: 0x001A1854
		// (set) Token: 0x06004AD9 RID: 19161 RVA: 0x000263F7 File Offset: 0x000245F7
		public unsafe GameObject newspaperVFXJP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXJP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXJP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06004ADA RID: 19162 RVA: 0x001A3684 File Offset: 0x001A1884
		// (set) Token: 0x06004ADB RID: 19163 RVA: 0x00026416 File Offset: 0x00024616
		public unsafe GameObject newspaperVFXKR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXKR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXKR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06004ADC RID: 19164 RVA: 0x001A36B4 File Offset: 0x001A18B4
		// (set) Token: 0x06004ADD RID: 19165 RVA: 0x00026435 File Offset: 0x00024635
		public unsafe GameObject newspaperVFXCNT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXCNT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperVFXCNT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x001A36E4 File Offset: 0x001A18E4
		// (set) Token: 0x06004ADF RID: 19167 RVA: 0x00026454 File Offset: 0x00024654
		public unsafe GameObject peerlessWindGodTrail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_peerlessWindGodTrail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_peerlessWindGodTrail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x001A3714 File Offset: 0x001A1914
		// (set) Token: 0x06004AE1 RID: 19169 RVA: 0x00026473 File Offset: 0x00024673
		public unsafe GameObject jumpEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_jumpEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_jumpEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x001A3744 File Offset: 0x001A1944
		// (set) Token: 0x06004AE3 RID: 19171 RVA: 0x00026492 File Offset: 0x00024692
		public unsafe float offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x001A376C File Offset: 0x001A196C
		// (set) Token: 0x06004AE5 RID: 19173 RVA: 0x000264AD File Offset: 0x000246AD
		public unsafe float newsOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newsOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newsOffset)) = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x001A3794 File Offset: 0x001A1994
		// (set) Token: 0x06004AE7 RID: 19175 RVA: 0x000264C8 File Offset: 0x000246C8
		public unsafe float flashOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_flashOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_flashOffset)) = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x001A37BC File Offset: 0x001A19BC
		// (set) Token: 0x06004AE9 RID: 19177 RVA: 0x000264E3 File Offset: 0x000246E3
		public unsafe float startDashCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_startDashCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_startDashCost)) = value;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x001A37E4 File Offset: 0x001A19E4
		// (set) Token: 0x06004AEB RID: 19179 RVA: 0x000264FE File Offset: 0x000246FE
		public unsafe float finalDashCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_finalDashCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_finalDashCost)) = value;
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06004AEC RID: 19180 RVA: 0x001A380C File Offset: 0x001A1A0C
		// (set) Token: 0x06004AED RID: 19181 RVA: 0x00026519 File Offset: 0x00024719
		public unsafe float dashCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_dashCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_dashCoolDown)) = value;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06004AEE RID: 19182 RVA: 0x001A3834 File Offset: 0x001A1A34
		// (set) Token: 0x06004AEF RID: 19183 RVA: 0x00026534 File Offset: 0x00024734
		public unsafe float dashCoolDown2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_dashCoolDown2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_dashCoolDown2)) = value;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x001A385C File Offset: 0x001A1A5C
		// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x0002654F File Offset: 0x0002474F
		public unsafe float angle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_angle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_angle)) = value;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x001A3884 File Offset: 0x001A1A84
		// (set) Token: 0x06004AF3 RID: 19187 RVA: 0x0002656A File Offset: 0x0002476A
		public unsafe Vector2 xRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_xRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_xRange)) = value;
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x001A38AC File Offset: 0x001A1AAC
		// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x00026585 File Offset: 0x00024785
		public unsafe Vector2 yRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_yRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_yRange)) = value;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x001A38D4 File Offset: 0x001A1AD4
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x000265A0 File Offset: 0x000247A0
		public unsafe GameObject tagObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tagObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tagObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x001A3904 File Offset: 0x001A1B04
		// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x000265BF File Offset: 0x000247BF
		public unsafe GameObject newsObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newsObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newsObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x001A3934 File Offset: 0x001A1B34
		// (set) Token: 0x06004AFB RID: 19195 RVA: 0x000265DE File Offset: 0x000247DE
		public unsafe GameObject spawnTagEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_spawnTagEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_spawnTagEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x001A3964 File Offset: 0x001A1B64
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x000265FD File Offset: 0x000247FD
		public unsafe GameObject tornadoVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x001A3994 File Offset: 0x001A1B94
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x0002661C File Offset: 0x0002481C
		public unsafe GameObject fogVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_fogVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_fogVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x001A39C4 File Offset: 0x001A1BC4
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x0002663B File Offset: 0x0002483B
		public unsafe GameObject newspaperPunishmentVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x001A39F4 File Offset: 0x001A1BF4
		// (set) Token: 0x06004B03 RID: 19203 RVA: 0x0002665A File Offset: 0x0002485A
		public unsafe GameObject newspaperPunishmentVFXEN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXEN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXEN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x001A3A24 File Offset: 0x001A1C24
		// (set) Token: 0x06004B05 RID: 19205 RVA: 0x00026679 File Offset: 0x00024879
		public unsafe GameObject newspaperPunishmentVFXJP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXJP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXJP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06004B06 RID: 19206 RVA: 0x001A3A54 File Offset: 0x001A1C54
		// (set) Token: 0x06004B07 RID: 19207 RVA: 0x00026698 File Offset: 0x00024898
		public unsafe GameObject newspaperPunishmentVFXKR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXKR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXKR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x001A3A84 File Offset: 0x001A1C84
		// (set) Token: 0x06004B09 RID: 19209 RVA: 0x000266B7 File Offset: 0x000248B7
		public unsafe GameObject newspaperPunishmentVFXCNT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXCNT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentVFXCNT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06004B0A RID: 19210 RVA: 0x001A3AB4 File Offset: 0x001A1CB4
		// (set) Token: 0x06004B0B RID: 19211 RVA: 0x000266D6 File Offset: 0x000248D6
		public unsafe Vector2 newspaperPunishmentFinalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentFinalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentFinalPosition)) = value;
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x001A3ADC File Offset: 0x001A1CDC
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x000266F1 File Offset: 0x000248F1
		public unsafe float tornadoDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoDuration)) = value;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x001A3B04 File Offset: 0x001A1D04
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x0002670C File Offset: 0x0002490C
		public unsafe float tornadoOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoOffset)) = value;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x001A3B2C File Offset: 0x001A1D2C
		// (set) Token: 0x06004B11 RID: 19217 RVA: 0x00026727 File Offset: 0x00024927
		public unsafe float newspaperPunishmentDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentDuration)) = value;
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x001A3B54 File Offset: 0x001A1D54
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x00026742 File Offset: 0x00024942
		public unsafe float newspaperPunishmentSpawnWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentSpawnWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentSpawnWait)) = value;
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x001A3B7C File Offset: 0x001A1D7C
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x0002675D File Offset: 0x0002495D
		public unsafe float itemMinDashDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMinDashDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMinDashDistance)) = value;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x001A3BA4 File Offset: 0x001A1DA4
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x00026778 File Offset: 0x00024978
		public unsafe float itemMaxDashDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMaxDashDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMaxDashDistance)) = value;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x001A3BCC File Offset: 0x001A1DCC
		// (set) Token: 0x06004B19 RID: 19225 RVA: 0x00026793 File Offset: 0x00024993
		public unsafe float itemMinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMinRange)) = value;
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x001A3BF4 File Offset: 0x001A1DF4
		// (set) Token: 0x06004B1B RID: 19227 RVA: 0x000267AE File Offset: 0x000249AE
		public unsafe float itemMaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemMaxRange)) = value;
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x001A3C1C File Offset: 0x001A1E1C
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x000267C9 File Offset: 0x000249C9
		public unsafe float itemControlPoint1AngularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemControlPoint1AngularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemControlPoint1AngularOffset)) = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x001A3C44 File Offset: 0x001A1E44
		// (set) Token: 0x06004B1F RID: 19231 RVA: 0x000267E4 File Offset: 0x000249E4
		public unsafe float itemControlPoint2AngularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemControlPoint2AngularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_itemControlPoint2AngularOffset)) = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x001A3C6C File Offset: 0x001A1E6C
		// (set) Token: 0x06004B21 RID: 19233 RVA: 0x000267FF File Offset: 0x000249FF
		public SpellBase.DelayAudioClip newspaperRewardSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperRewardSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperRewardSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06004B22 RID: 19234 RVA: 0x001A3C9C File Offset: 0x001A1E9C
		// (set) Token: 0x06004B23 RID: 19235 RVA: 0x0002682D File Offset: 0x00024A2D
		public SpellBase.DelayAudioClip ayaJumpSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_ayaJumpSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_ayaJumpSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x001A3CCC File Offset: 0x001A1ECC
		// (set) Token: 0x06004B25 RID: 19237 RVA: 0x0002685B File Offset: 0x00024A5B
		public SpellBase.DelayAudioClip ayaDash1Sfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_ayaDash1Sfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_ayaDash1Sfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x001A3CFC File Offset: 0x001A1EFC
		// (set) Token: 0x06004B27 RID: 19239 RVA: 0x00026889 File Offset: 0x00024A89
		public SpellBase.DelayAudioClip ayaDash2Sfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_ayaDash2Sfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_ayaDash2Sfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x001A3D2C File Offset: 0x001A1F2C
		// (set) Token: 0x06004B29 RID: 19241 RVA: 0x000268B7 File Offset: 0x00024AB7
		public SpellBase.DelayAudioClip tornadoSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_tornadoSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x001A3D5C File Offset: 0x001A1F5C
		// (set) Token: 0x06004B2B RID: 19243 RVA: 0x000268E5 File Offset: 0x00024AE5
		public SpellBase.DelayAudioClip newspaperPunishmentSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_newspaperPunishmentSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06004B2C RID: 19244 RVA: 0x001A3D8C File Offset: 0x001A1F8C
		// (set) Token: 0x06004B2D RID: 19245 RVA: 0x00026913 File Offset: 0x00024B13
		public unsafe string AYA_FAMOUS_IZAKAYA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeFieldInfoPtr_AYA_NEWS_CHECK_SHOULD_SPAWN;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeFieldInfoPtr_AYA_SPECIAL_POSITIVE_SPELL;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeFieldInfoPtr_POPULAR_ID;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeFieldInfoPtr_AYA_ADD_ORDERCOUNT_KEY;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeFieldInfoPtr_negativeSpellCardScheduledEventId;

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeFieldInfoPtr_positiveSpellCardScheduledEventId;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeFieldInfoPtr_negativeSpellCardNewsLabel;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeFieldInfoPtr_positiveSpellCardNewsLabel;

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeFieldInfoPtr_signatureTagId;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeFieldInfoPtr_signatureExtraOrderRate;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeFieldInfoPtr_minCookTimeSatisfyCondition;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeFieldInfoPtr_addOrderCountRate;

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeFieldInfoPtr_newspaperVFX;

		// Token: 0x04003363 RID: 13155
		private static readonly IntPtr NativeFieldInfoPtr_newspaperVFXEN;

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeFieldInfoPtr_newspaperVFXJP;

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeFieldInfoPtr_newspaperVFXKR;

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeFieldInfoPtr_newspaperVFXCNT;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeFieldInfoPtr_peerlessWindGodTrail;

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeFieldInfoPtr_jumpEffect;

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeFieldInfoPtr_newsOffset;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeFieldInfoPtr_flashOffset;

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeFieldInfoPtr_startDashCost;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeFieldInfoPtr_finalDashCost;

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeFieldInfoPtr_dashCoolDown;

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeFieldInfoPtr_dashCoolDown2;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeFieldInfoPtr_angle;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeFieldInfoPtr_xRange;

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeFieldInfoPtr_yRange;

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeFieldInfoPtr_tagObject;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeFieldInfoPtr_newsObject;

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeFieldInfoPtr_spawnTagEffect;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeFieldInfoPtr_tornadoVFX;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeFieldInfoPtr_fogVFX;

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentVFX;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentVFXEN;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentVFXJP;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentVFXKR;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentVFXCNT;

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentFinalPosition;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeFieldInfoPtr_tornadoDuration;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeFieldInfoPtr_tornadoOffset;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentDuration;

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentSpawnWait;

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeFieldInfoPtr_itemMinDashDistance;

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeFieldInfoPtr_itemMaxDashDistance;

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeFieldInfoPtr_itemMinRange;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeFieldInfoPtr_itemMaxRange;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeFieldInfoPtr_itemControlPoint1AngularOffset;

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeFieldInfoPtr_itemControlPoint2AngularOffset;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeFieldInfoPtr_newspaperRewardSfx;

		// Token: 0x04003389 RID: 13193
		private static readonly IntPtr NativeFieldInfoPtr_ayaJumpSfx;

		// Token: 0x0400338A RID: 13194
		private static readonly IntPtr NativeFieldInfoPtr_ayaDash1Sfx;

		// Token: 0x0400338B RID: 13195
		private static readonly IntPtr NativeFieldInfoPtr_ayaDash2Sfx;

		// Token: 0x0400338C RID: 13196
		private static readonly IntPtr NativeFieldInfoPtr_tornadoSfx;

		// Token: 0x0400338D RID: 13197
		private static readonly IntPtr NativeFieldInfoPtr_newspaperPunishmentSfx;

		// Token: 0x0400338E RID: 13198
		private static readonly IntPtr NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA;

		// Token: 0x0400338F RID: 13199
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003390 RID: 13200
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0;

		// Token: 0x04003391 RID: 13201
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003392 RID: 13202
		private static readonly IntPtr NativeMethodInfoPtr_MergeConflict_Private_Void_0;

		// Token: 0x04003393 RID: 13203
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeMethodInfoPtr_AyaSignatureBuff_Private_Void_GuestGroupController_0;

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Private_Void_0;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_1_Private_Void_Int32_0;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_14_Private_String_Int32_String_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_15_Private_Boolean_Sellable_Single_0;

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_2_Private_Void_GuestGroupController_0;

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeMethodInfoPtr__OnBuffEnd_b__66_0_Private_Void_GuestGroupController_0;

		// Token: 0x02000B02 RID: 2818
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D148 RID: 53576 RVA: 0x00335CE0 File Offset: 0x00333EE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr);
				Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr_punishmentSpawnWaitSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, "punishmentSpawnWaitSeconds");
				Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, "<>4__this");
				Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, "position");
				Spell_Aya.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, 100678372);
				Spell_Aya.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, 100678373);
				Spell_Aya.__c__DisplayClass61_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, 100678374);
			}

			// Token: 0x0600D149 RID: 53577 RVA: 0x00335D84 File Offset: 0x00333F84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D14A RID: 53578 RVA: 0x00335DC0 File Offset: 0x00333FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194570, XrefRangeEnd = 194575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D14B RID: 53579 RVA: 0x00335E00 File Offset: 0x00334000
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D14C RID: 53580 RVA: 0x0007009D File Offset: 0x0006E29D
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004414 RID: 17428
			// (get) Token: 0x0600D14D RID: 53581 RVA: 0x00335E3C File Offset: 0x0033403C
			// (set) Token: 0x0600D14E RID: 53582 RVA: 0x000700A6 File Offset: 0x0006E2A6
			public unsafe WaitForSeconds punishmentSpawnWaitSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr_punishmentSpawnWaitSeconds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr_punishmentSpawnWaitSeconds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004415 RID: 17429
			// (get) Token: 0x0600D14F RID: 53583 RVA: 0x00335E6C File Offset: 0x0033406C
			// (set) Token: 0x0600D150 RID: 53584 RVA: 0x000700C5 File Offset: 0x0006E2C5
			public unsafe Spell_Aya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004416 RID: 17430
			// (get) Token: 0x0600D151 RID: 53585 RVA: 0x00335E9C File Offset: 0x0033409C
			// (set) Token: 0x0600D152 RID: 53586 RVA: 0x000700E4 File Offset: 0x0006E2E4
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x0400867B RID: 34427
			private static readonly IntPtr NativeFieldInfoPtr_punishmentSpawnWaitSeconds;

			// Token: 0x0400867C RID: 34428
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400867D RID: 34429
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x0400867E RID: 34430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400867F RID: 34431
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008680 RID: 34432
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0;

			// Token: 0x02001022 RID: 4130
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass61_0+<<OnNegativeBuffExecute>g__Newspaper|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011ABA RID: 72378 RVA: 0x0040CD30 File Offset: 0x0040AF30
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Newspaper|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678375);
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678376);
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678377);
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678378);
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678379);
					Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678380);
				}

				// Token: 0x06011ABB RID: 72379 RVA: 0x0040CE24 File Offset: 0x0040B024
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ABC RID: 72380 RVA: 0x0040CE6C File Offset: 0x0040B06C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ABD RID: 72381 RVA: 0x0040CEA0 File Offset: 0x0040B0A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194523, XrefRangeEnd = 194564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BF1 RID: 23537
				// (get) Token: 0x06011ABE RID: 72382 RVA: 0x0040CEDC File Offset: 0x0040B0DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011ABF RID: 72383 RVA: 0x0040CF1C File Offset: 0x0040B11C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194564, XrefRangeEnd = 194570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BF2 RID: 23538
				// (get) Token: 0x06011AC0 RID: 72384 RVA: 0x0040CF50 File Offset: 0x0040B150
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AC1 RID: 72385 RVA: 0x000999BA File Offset: 0x00097BBA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BED RID: 23533
				// (get) Token: 0x06011AC2 RID: 72386 RVA: 0x0040CF90 File Offset: 0x0040B190
				// (set) Token: 0x06011AC3 RID: 72387 RVA: 0x000999C3 File Offset: 0x00097BC3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BEE RID: 23534
				// (get) Token: 0x06011AC4 RID: 72388 RVA: 0x0040CFB8 File Offset: 0x0040B1B8
				// (set) Token: 0x06011AC5 RID: 72389 RVA: 0x000999DE File Offset: 0x00097BDE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BEF RID: 23535
				// (get) Token: 0x06011AC6 RID: 72390 RVA: 0x0040CFE8 File Offset: 0x0040B1E8
				// (set) Token: 0x06011AC7 RID: 72391 RVA: 0x000999FD File Offset: 0x00097BFD
				public unsafe Spell_Aya.__c__DisplayClass61_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass61_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BF0 RID: 23536
				// (get) Token: 0x06011AC8 RID: 72392 RVA: 0x0040D018 File Offset: 0x0040B218
				// (set) Token: 0x06011AC9 RID: 72393 RVA: 0x00099A1C File Offset: 0x00097C1C
				public unsafe Spell_Aya.__c__DisplayClass61_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass61_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2A2 RID: 45730
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2A3 RID: 45731
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2A4 RID: 45732
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2A5 RID: 45733
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B2A6 RID: 45734
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2A7 RID: 45735
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2A8 RID: 45736
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2A9 RID: 45737
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2AA RID: 45738
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2AB RID: 45739
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B03 RID: 2819
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass61_1")]
		public sealed class __c__DisplayClass61_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D153 RID: 53587 RVA: 0x00335EC4 File Offset: 0x003340C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_1()
			{
				Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c__DisplayClass61_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr);
				Spell_Aya.__c__DisplayClass61_1.NativeFieldInfoPtr_targetPos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr, "targetPos1");
				Spell_Aya.__c__DisplayClass61_1.NativeFieldInfoPtr_targetPos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr, "targetPos2");
				Spell_Aya.__c__DisplayClass61_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr, 100678381);
				Spell_Aya.__c__DisplayClass61_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr, 100678382);
				Spell_Aya.__c__DisplayClass61_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr, 100678383);
			}

			// Token: 0x0600D154 RID: 53588 RVA: 0x00335F54 File Offset: 0x00334154
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass61_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D155 RID: 53589 RVA: 0x00335F90 File Offset: 0x00334190
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D156 RID: 53590 RVA: 0x00335FCC File Offset: 0x003341CC
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass61_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D157 RID: 53591 RVA: 0x000700FF File Offset: 0x0006E2FF
			public __c__DisplayClass61_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004417 RID: 17431
			// (get) Token: 0x0600D158 RID: 53592 RVA: 0x00336008 File Offset: 0x00334208
			// (set) Token: 0x0600D159 RID: 53593 RVA: 0x00070108 File Offset: 0x0006E308
			public unsafe Vector3 targetPos1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_1.NativeFieldInfoPtr_targetPos1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_1.NativeFieldInfoPtr_targetPos1)) = value;
				}
			}

			// Token: 0x17004418 RID: 17432
			// (get) Token: 0x0600D15A RID: 53594 RVA: 0x00336030 File Offset: 0x00334230
			// (set) Token: 0x0600D15B RID: 53595 RVA: 0x00070123 File Offset: 0x0006E323
			public unsafe Vector3 targetPos2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_1.NativeFieldInfoPtr_targetPos2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass61_1.NativeFieldInfoPtr_targetPos2)) = value;
				}
			}

			// Token: 0x04008681 RID: 34433
			private static readonly IntPtr NativeFieldInfoPtr_targetPos1;

			// Token: 0x04008682 RID: 34434
			private static readonly IntPtr NativeFieldInfoPtr_targetPos2;

			// Token: 0x04008683 RID: 34435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008684 RID: 34436
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0;

			// Token: 0x04008685 RID: 34437
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Vector3_0;
		}

		// Token: 0x02000B04 RID: 2820
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D15C RID: 53596 RVA: 0x00336058 File Offset: 0x00334258
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr);
				Spell_Aya.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, "<>9");
				Spell_Aya.__c.NativeFieldInfoPtr___9__61_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, "<>9__61_2");
				Spell_Aya.__c.NativeFieldInfoPtr___9__61_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, "<>9__61_1");
				Spell_Aya.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, "<>9__62_0");
				Spell_Aya.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, "<>9__63_0");
				Spell_Aya.__c.NativeFieldInfoPtr___9__63_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, "<>9__63_16");
				Spell_Aya.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, 100678385);
				Spell_Aya.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__61_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, 100678386);
				Spell_Aya.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__61_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, 100678387);
				Spell_Aya.__c.NativeMethodInfoPtr__MergeConflict_b__62_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, 100678388);
				Spell_Aya.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, 100678389);
				Spell_Aya.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_16_Internal_Boolean_Sellable_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr, 100678390);
			}

			// Token: 0x0600D15D RID: 53597 RVA: 0x00336174 File Offset: 0x00334374
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15E RID: 53598 RVA: 0x003361B0 File Offset: 0x003343B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194575, XrefRangeEnd = 194592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__61_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__61_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15F RID: 53599 RVA: 0x003361E4 File Offset: 0x003343E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194592, XrefRangeEnd = 194597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__61_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__61_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D160 RID: 53600 RVA: 0x00336218 File Offset: 0x00334418
			[CallerCount(0)]
			public unsafe bool _MergeConflict_b__62_0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c.NativeMethodInfoPtr__MergeConflict_b__62_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D161 RID: 53601 RVA: 0x00336264 File Offset: 0x00334464
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__63_0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D162 RID: 53602 RVA: 0x003362B0 File Offset: 0x003344B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194597, XrefRangeEnd = 194602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__63_16(Sellable sellable, GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_16_Internal_Boolean_Sellable_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D163 RID: 53603 RVA: 0x0007013E File Offset: 0x0006E33E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004419 RID: 17433
			// (get) Token: 0x0600D164 RID: 53604 RVA: 0x00336310 File Offset: 0x00334510
			// (set) Token: 0x0600D165 RID: 53605 RVA: 0x00070147 File Offset: 0x0006E347
			public unsafe static Spell_Aya.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Aya.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Aya.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441A RID: 17434
			// (get) Token: 0x0600D166 RID: 53606 RVA: 0x00336338 File Offset: 0x00334538
			// (set) Token: 0x0600D167 RID: 53607 RVA: 0x00070159 File Offset: 0x0006E359
			public unsafe static Action __9__61_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Aya.__c.NativeFieldInfoPtr___9__61_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Aya.__c.NativeFieldInfoPtr___9__61_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441B RID: 17435
			// (get) Token: 0x0600D168 RID: 53608 RVA: 0x00336360 File Offset: 0x00334560
			// (set) Token: 0x0600D169 RID: 53609 RVA: 0x0007016B File Offset: 0x0006E36B
			public unsafe static Action __9__61_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Aya.__c.NativeFieldInfoPtr___9__61_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Aya.__c.NativeFieldInfoPtr___9__61_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441C RID: 17436
			// (get) Token: 0x0600D16A RID: 53610 RVA: 0x00336388 File Offset: 0x00334588
			// (set) Token: 0x0600D16B RID: 53611 RVA: 0x0007017D File Offset: 0x0006E37D
			public unsafe static Func<bool, bool> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Aya.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Aya.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441D RID: 17437
			// (get) Token: 0x0600D16C RID: 53612 RVA: 0x003363B0 File Offset: 0x003345B0
			// (set) Token: 0x0600D16D RID: 53613 RVA: 0x0007018F File Offset: 0x0006E38F
			public unsafe static Func<bool, bool> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Aya.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Aya.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441E RID: 17438
			// (get) Token: 0x0600D16E RID: 53614 RVA: 0x003363D8 File Offset: 0x003345D8
			// (set) Token: 0x0600D16F RID: 53615 RVA: 0x000701A1 File Offset: 0x0006E3A1
			public unsafe static Func<Sellable, GuestGroupController, bool> __9__63_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Aya.__c.NativeFieldInfoPtr___9__63_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Aya.__c.NativeFieldInfoPtr___9__63_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008686 RID: 34438
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008687 RID: 34439
			private static readonly IntPtr NativeFieldInfoPtr___9__61_2;

			// Token: 0x04008688 RID: 34440
			private static readonly IntPtr NativeFieldInfoPtr___9__61_1;

			// Token: 0x04008689 RID: 34441
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x0400868A RID: 34442
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x0400868B RID: 34443
			private static readonly IntPtr NativeFieldInfoPtr___9__63_16;

			// Token: 0x0400868C RID: 34444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400868D RID: 34445
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__61_1_Internal_Void_0;

			// Token: 0x0400868E RID: 34446
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__61_2_Internal_Void_0;

			// Token: 0x0400868F RID: 34447
			private static readonly IntPtr NativeMethodInfoPtr__MergeConflict_b__62_0_Internal_Boolean_Boolean_0;

			// Token: 0x04008690 RID: 34448
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_0_Internal_Boolean_Boolean_0;

			// Token: 0x04008691 RID: 34449
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__63_16_Internal_Boolean_Sellable_GuestGroupController_0;
		}

		// Token: 0x02000B05 RID: 2821
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<OnNegativeBuffExecute>d__61")]
		public sealed class _OnNegativeBuffExecute_d__61 : Il2CppSystem.Object
		{
			// Token: 0x0600D170 RID: 53616 RVA: 0x00336400 File Offset: 0x00334600
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__61()
			{
				Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<OnNegativeBuffExecute>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr);
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, "<>1__state");
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, "<>2__current");
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, "<>4__this");
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, "spellExecutionContext");
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr__tornado_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, "<tornado>5__2");
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr__fog_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, "<fog>5__3");
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, 100678391);
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, 100678392);
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, 100678393);
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, 100678394);
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, 100678395);
				Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr, 100678396);
			}

			// Token: 0x0600D171 RID: 53617 RVA: 0x0033651C File Offset: 0x0033471C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__61(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya._OnNegativeBuffExecute_d__61>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D172 RID: 53618 RVA: 0x00336564 File Offset: 0x00334764
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D173 RID: 53619 RVA: 0x00336598 File Offset: 0x00334798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194602, XrefRangeEnd = 194719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004425 RID: 17445
			// (get) Token: 0x0600D174 RID: 53620 RVA: 0x003365D4 File Offset: 0x003347D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D175 RID: 53621 RVA: 0x00336614 File Offset: 0x00334814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194719, XrefRangeEnd = 194725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004426 RID: 17446
			// (get) Token: 0x0600D176 RID: 53622 RVA: 0x00336648 File Offset: 0x00334848
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnNegativeBuffExecute_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D177 RID: 53623 RVA: 0x000701B3 File Offset: 0x0006E3B3
			public _OnNegativeBuffExecute_d__61(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441F RID: 17439
			// (get) Token: 0x0600D178 RID: 53624 RVA: 0x00336688 File Offset: 0x00334888
			// (set) Token: 0x0600D179 RID: 53625 RVA: 0x000701BC File Offset: 0x0006E3BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004420 RID: 17440
			// (get) Token: 0x0600D17A RID: 53626 RVA: 0x003366B0 File Offset: 0x003348B0
			// (set) Token: 0x0600D17B RID: 53627 RVA: 0x000701D7 File Offset: 0x0006E3D7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004421 RID: 17441
			// (get) Token: 0x0600D17C RID: 53628 RVA: 0x003366E0 File Offset: 0x003348E0
			// (set) Token: 0x0600D17D RID: 53629 RVA: 0x000701F6 File Offset: 0x0006E3F6
			public unsafe Spell_Aya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004422 RID: 17442
			// (get) Token: 0x0600D17E RID: 53630 RVA: 0x00336710 File Offset: 0x00334910
			// (set) Token: 0x0600D17F RID: 53631 RVA: 0x00070215 File Offset: 0x0006E415
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004423 RID: 17443
			// (get) Token: 0x0600D180 RID: 53632 RVA: 0x00336740 File Offset: 0x00334940
			// (set) Token: 0x0600D181 RID: 53633 RVA: 0x00070234 File Offset: 0x0006E434
			public unsafe GameObject _tornado_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr__tornado_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr__tornado_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004424 RID: 17444
			// (get) Token: 0x0600D182 RID: 53634 RVA: 0x00336770 File Offset: 0x00334970
			// (set) Token: 0x0600D183 RID: 53635 RVA: 0x00070253 File Offset: 0x0006E453
			public unsafe GameObject _fog_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr__fog_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnNegativeBuffExecute_d__61.NativeFieldInfoPtr__fog_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008692 RID: 34450
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008693 RID: 34451
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008694 RID: 34452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008695 RID: 34453
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008696 RID: 34454
			private static readonly IntPtr NativeFieldInfoPtr__tornado_5__2;

			// Token: 0x04008697 RID: 34455
			private static readonly IntPtr NativeFieldInfoPtr__fog_5__3;

			// Token: 0x04008698 RID: 34456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008699 RID: 34457
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400869A RID: 34458
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400869B RID: 34459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400869C RID: 34460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400869D RID: 34461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B06 RID: 2822
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass63_0")]
		public new sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D184 RID: 53636 RVA: 0x003367A0 File Offset: 0x003349A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr);
				Spell_Aya.__c__DisplayClass63_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr, "startPosition");
				Spell_Aya.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				Spell_Aya.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr, 100678397);
				Spell_Aya.__c__DisplayClass63_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr, 100678398);
				Spell_Aya.__c__DisplayClass63_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr, 100678399);
			}

			// Token: 0x0600D185 RID: 53637 RVA: 0x00336830 File Offset: 0x00334A30
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D186 RID: 53638 RVA: 0x0033686C File Offset: 0x00334A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194725, XrefRangeEnd = 194728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D187 RID: 53639 RVA: 0x003368A8 File Offset: 0x00334AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194728, XrefRangeEnd = 194731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D188 RID: 53640 RVA: 0x00070272 File Offset: 0x0006E472
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004427 RID: 17447
			// (get) Token: 0x0600D189 RID: 53641 RVA: 0x003368E4 File Offset: 0x00334AE4
			// (set) Token: 0x0600D18A RID: 53642 RVA: 0x0007027B File Offset: 0x0006E47B
			public Nullable<Vector3> startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_0.NativeFieldInfoPtr_startPosition);
					return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_0.NativeFieldInfoPtr_startPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004428 RID: 17448
			// (get) Token: 0x0600D18B RID: 53643 RVA: 0x00336914 File Offset: 0x00334B14
			// (set) Token: 0x0600D18C RID: 53644 RVA: 0x000702A9 File Offset: 0x0006E4A9
			public unsafe Spell_Aya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400869E RID: 34462
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x0400869F RID: 34463
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086A0 RID: 34464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086A1 RID: 34465
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0;

			// Token: 0x040086A2 RID: 34466
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0;
		}

		// Token: 0x02000B07 RID: 2823
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass63_1")]
		public sealed class __c__DisplayClass63_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D18D RID: 53645 RVA: 0x00336944 File Offset: 0x00334B44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_1()
			{
				Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c__DisplayClass63_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr);
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_aya = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "aya");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_hasOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "hasOpen");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "targetPosition");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_tagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "tagName");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_field_Public___c__DisplayClass63_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "<>9__11");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "<>9__7");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "<>9__8");
				Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, "<>9__13");
				Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, 100678400);
				Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, 100678401);
				Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, 100678402);
				Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, 100678403);
				Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, 100678404);
				Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr, 100678405);
			}

			// Token: 0x0600D18E RID: 53646 RVA: 0x00336A9C File Offset: 0x00334C9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D18F RID: 53647 RVA: 0x00336AD8 File Offset: 0x00334CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194731, XrefRangeEnd = 194734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D190 RID: 53648 RVA: 0x00336B1C File Offset: 0x00334D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194734, XrefRangeEnd = 194737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__11(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D191 RID: 53649 RVA: 0x00336B60 File Offset: 0x00334D60
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D192 RID: 53650 RVA: 0x00336B9C File Offset: 0x00334D9C
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D193 RID: 53651 RVA: 0x00336BD8 File Offset: 0x00334DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194737, XrefRangeEnd = 194738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__13(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D194 RID: 53652 RVA: 0x000702C8 File Offset: 0x0006E4C8
			public __c__DisplayClass63_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004429 RID: 17449
			// (get) Token: 0x0600D195 RID: 53653 RVA: 0x00336C1C File Offset: 0x00334E1C
			// (set) Token: 0x0600D196 RID: 53654 RVA: 0x000702D1 File Offset: 0x0006E4D1
			public unsafe Transform aya
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_aya);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_aya), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700442A RID: 17450
			// (get) Token: 0x0600D197 RID: 53655 RVA: 0x00336C4C File Offset: 0x00334E4C
			// (set) Token: 0x0600D198 RID: 53656 RVA: 0x000702F0 File Offset: 0x0006E4F0
			public unsafe bool hasOpen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_hasOpen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_hasOpen)) = value;
				}
			}

			// Token: 0x1700442B RID: 17451
			// (get) Token: 0x0600D199 RID: 53657 RVA: 0x00336C74 File Offset: 0x00334E74
			// (set) Token: 0x0600D19A RID: 53658 RVA: 0x0007030B File Offset: 0x0006E50B
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x1700442C RID: 17452
			// (get) Token: 0x0600D19B RID: 53659 RVA: 0x00336C9C File Offset: 0x00334E9C
			// (set) Token: 0x0600D19C RID: 53660 RVA: 0x00070326 File Offset: 0x0006E526
			public unsafe string tagName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_tagName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_tagName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700442D RID: 17453
			// (get) Token: 0x0600D19D RID: 53661 RVA: 0x00336CC4 File Offset: 0x00334EC4
			// (set) Token: 0x0600D19E RID: 53662 RVA: 0x00070345 File Offset: 0x0006E545
			public unsafe Spell_Aya.__c__DisplayClass63_0 field_Public___c__DisplayClass63_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_field_Public___c__DisplayClass63_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass63_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr_field_Public___c__DisplayClass63_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700442E RID: 17454
			// (get) Token: 0x0600D19F RID: 53663 RVA: 0x00336CF4 File Offset: 0x00334EF4
			// (set) Token: 0x0600D1A0 RID: 53664 RVA: 0x00070364 File Offset: 0x0006E564
			public unsafe Action<Transform> __9__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700442F RID: 17455
			// (get) Token: 0x0600D1A1 RID: 53665 RVA: 0x00336D24 File Offset: 0x00334F24
			// (set) Token: 0x0600D1A2 RID: 53666 RVA: 0x00070383 File Offset: 0x0006E583
			public unsafe Func<Vector3> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004430 RID: 17456
			// (get) Token: 0x0600D1A3 RID: 53667 RVA: 0x00336D54 File Offset: 0x00334F54
			// (set) Token: 0x0600D1A4 RID: 53668 RVA: 0x000703A2 File Offset: 0x0006E5A2
			public unsafe Func<Vector3> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004431 RID: 17457
			// (get) Token: 0x0600D1A5 RID: 53669 RVA: 0x00336D84 File Offset: 0x00334F84
			// (set) Token: 0x0600D1A6 RID: 53670 RVA: 0x000703C1 File Offset: 0x0006E5C1
			public unsafe Action<TextMeshProUGUI> __9__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_1.NativeFieldInfoPtr___9__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086A3 RID: 34467
			private static readonly IntPtr NativeFieldInfoPtr_aya;

			// Token: 0x040086A4 RID: 34468
			private static readonly IntPtr NativeFieldInfoPtr_hasOpen;

			// Token: 0x040086A5 RID: 34469
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040086A6 RID: 34470
			private static readonly IntPtr NativeFieldInfoPtr_tagName;

			// Token: 0x040086A7 RID: 34471
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass63_0_0;

			// Token: 0x040086A8 RID: 34472
			private static readonly IntPtr NativeFieldInfoPtr___9__11;

			// Token: 0x040086A9 RID: 34473
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x040086AA RID: 34474
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x040086AB RID: 34475
			private static readonly IntPtr NativeFieldInfoPtr___9__13;

			// Token: 0x040086AC RID: 34476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086AD RID: 34477
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0;

			// Token: 0x040086AE RID: 34478
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Void_Transform_0;

			// Token: 0x040086AF RID: 34479
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0;

			// Token: 0x040086B0 RID: 34480
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Vector3_0;

			// Token: 0x040086B1 RID: 34481
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000B08 RID: 2824
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass63_2")]
		public sealed class __c__DisplayClass63_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D1A7 RID: 53671 RVA: 0x00336DB4 File Offset: 0x00334FB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_2()
			{
				Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c__DisplayClass63_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr);
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "trail");
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_tableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "tableIndex");
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "table");
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_field_Public___c__DisplayClass63_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "CS$<>8__locals2");
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "<>9__6");
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "<>9__9");
				Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, "<>9__10");
				Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, 100678406);
				Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, 100678407);
				Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, 100678408);
				Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr, 100678409);
			}

			// Token: 0x0600D1A8 RID: 53672 RVA: 0x00336EBC File Offset: 0x003350BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1A9 RID: 53673 RVA: 0x00336EF8 File Offset: 0x003350F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194738, XrefRangeEnd = 194756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__6(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1AA RID: 53674 RVA: 0x00336F3C File Offset: 0x0033513C
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__9(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1AB RID: 53675 RVA: 0x00336F8C File Offset: 0x0033518C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194756, XrefRangeEnd = 194759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__10(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1AC RID: 53676 RVA: 0x000703E0 File Offset: 0x0006E5E0
			public __c__DisplayClass63_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004432 RID: 17458
			// (get) Token: 0x0600D1AD RID: 53677 RVA: 0x00336FD0 File Offset: 0x003351D0
			// (set) Token: 0x0600D1AE RID: 53678 RVA: 0x000703E9 File Offset: 0x0006E5E9
			public unsafe GameObject trail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_trail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_trail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004433 RID: 17459
			// (get) Token: 0x0600D1AF RID: 53679 RVA: 0x00337000 File Offset: 0x00335200
			// (set) Token: 0x0600D1B0 RID: 53680 RVA: 0x00070408 File Offset: 0x0006E608
			public unsafe int tableIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_tableIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_tableIndex)) = value;
				}
			}

			// Token: 0x17004434 RID: 17460
			// (get) Token: 0x0600D1B1 RID: 53681 RVA: 0x00337028 File Offset: 0x00335228
			// (set) Token: 0x0600D1B2 RID: 53682 RVA: 0x00070423 File Offset: 0x0006E623
			public unsafe Vector3 table
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_table);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_table)) = value;
				}
			}

			// Token: 0x17004435 RID: 17461
			// (get) Token: 0x0600D1B3 RID: 53683 RVA: 0x00337050 File Offset: 0x00335250
			// (set) Token: 0x0600D1B4 RID: 53684 RVA: 0x0007043E File Offset: 0x0006E63E
			public unsafe Spell_Aya.__c__DisplayClass63_1 field_Public___c__DisplayClass63_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_field_Public___c__DisplayClass63_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass63_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr_field_Public___c__DisplayClass63_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004436 RID: 17462
			// (get) Token: 0x0600D1B5 RID: 53685 RVA: 0x00337080 File Offset: 0x00335280
			// (set) Token: 0x0600D1B6 RID: 53686 RVA: 0x0007045D File Offset: 0x0006E65D
			public unsafe Action<GameObject> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004437 RID: 17463
			// (get) Token: 0x0600D1B7 RID: 53687 RVA: 0x003370B0 File Offset: 0x003352B0
			// (set) Token: 0x0600D1B8 RID: 53688 RVA: 0x0007047C File Offset: 0x0006E67C
			public unsafe Func<GuestGroupController, bool> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004438 RID: 17464
			// (get) Token: 0x0600D1B9 RID: 53689 RVA: 0x003370E0 File Offset: 0x003352E0
			// (set) Token: 0x0600D1BA RID: 53690 RVA: 0x0007049B File Offset: 0x0006E69B
			public unsafe Action<GameObject> __9__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_2.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086B2 RID: 34482
			private static readonly IntPtr NativeFieldInfoPtr_trail;

			// Token: 0x040086B3 RID: 34483
			private static readonly IntPtr NativeFieldInfoPtr_tableIndex;

			// Token: 0x040086B4 RID: 34484
			private static readonly IntPtr NativeFieldInfoPtr_table;

			// Token: 0x040086B5 RID: 34485
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass63_1_0;

			// Token: 0x040086B6 RID: 34486
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040086B7 RID: 34487
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x040086B8 RID: 34488
			private static readonly IntPtr NativeFieldInfoPtr___9__10;

			// Token: 0x040086B9 RID: 34489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086BA RID: 34490
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_GameObject_0;

			// Token: 0x040086BB RID: 34491
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_GuestGroupController_0;

			// Token: 0x040086BC RID: 34492
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B09 RID: 2825
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<>c__DisplayClass63_3")]
		public sealed class __c__DisplayClass63_3 : Il2CppSystem.Object
		{
			// Token: 0x0600D1BB RID: 53691 RVA: 0x00337110 File Offset: 0x00335310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_3()
			{
				Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<>c__DisplayClass63_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr);
				Spell_Aya.__c__DisplayClass63_3.NativeFieldInfoPtr_guest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr, "guest");
				Spell_Aya.__c__DisplayClass63_3.NativeFieldInfoPtr_field_Public___c__DisplayClass63_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr, "CS$<>8__locals3");
				Spell_Aya.__c__DisplayClass63_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr, 100678410);
				Spell_Aya.__c__DisplayClass63_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr, 100678411);
			}

			// Token: 0x0600D1BC RID: 53692 RVA: 0x0033718C File Offset: 0x0033538C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya.__c__DisplayClass63_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1BD RID: 53693 RVA: 0x003371C8 File Offset: 0x003353C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194759, XrefRangeEnd = 194776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__12(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya.__c__DisplayClass63_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1BE RID: 53694 RVA: 0x000704BA File Offset: 0x0006E6BA
			public __c__DisplayClass63_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004439 RID: 17465
			// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x0033720C File Offset: 0x0033540C
			// (set) Token: 0x0600D1C0 RID: 53696 RVA: 0x000704C3 File Offset: 0x0006E6C3
			public unsafe AStarInputGeneratorComponent guest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_3.NativeFieldInfoPtr_guest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_3.NativeFieldInfoPtr_guest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443A RID: 17466
			// (get) Token: 0x0600D1C1 RID: 53697 RVA: 0x0033723C File Offset: 0x0033543C
			// (set) Token: 0x0600D1C2 RID: 53698 RVA: 0x000704E2 File Offset: 0x0006E6E2
			public unsafe Spell_Aya.__c__DisplayClass63_2 field_Public___c__DisplayClass63_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_3.NativeFieldInfoPtr_field_Public___c__DisplayClass63_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass63_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya.__c__DisplayClass63_3.NativeFieldInfoPtr_field_Public___c__DisplayClass63_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086BD RID: 34493
			private static readonly IntPtr NativeFieldInfoPtr_guest;

			// Token: 0x040086BE RID: 34494
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass63_2_0;

			// Token: 0x040086BF RID: 34495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086C0 RID: 34496
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B0A RID: 2826
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Aya+<OnPositiveBuffExecute>d__63")]
		public sealed class _OnPositiveBuffExecute_d__63 : Il2CppSystem.Object
		{
			// Token: 0x0600D1C3 RID: 53699 RVA: 0x0033726C File Offset: 0x0033546C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__63()
			{
				Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Aya>.NativeClassPtr, "<OnPositiveBuffExecute>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr);
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<>1__state");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<>2__current");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<>4__this");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "spellExecutionContext");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<>8__1");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<>8__2");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<>8__3");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__leftRotate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<leftRotate>5__2");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rightRotate_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<rightRotate>5__3");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__waitSeconds_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<waitSeconds>5__4");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__wait_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<wait>5__5");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__wait2_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<wait2>5__6");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__maxX_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<maxX>5__7");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__minX_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<minX>5__8");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__minY_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<minY>5__9");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__maxY_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<maxY>5__10");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__allTables_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<allTables>5__11");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__allTables2_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<allTables2>5__12");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isHorizontal_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<isHorizontal>5__13");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isRight_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<isRight>5__14");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isUp_5__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<isUp>5__15");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__ayaCharacter_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<ayaCharacter>5__16");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rotate_5__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<rotate>5__17");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rotateStart_5__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<rotateStart>5__18");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__i_5__19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<i>5__19");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__j_5__20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, "<j>5__20");
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, 100678412);
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, 100678413);
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, 100678414);
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, 100678415);
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, 100678416);
				Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr, 100678417);
			}

			// Token: 0x0600D1C4 RID: 53700 RVA: 0x00337518 File Offset: 0x00335718
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__63(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Aya._OnPositiveBuffExecute_d__63>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C5 RID: 53701 RVA: 0x00337560 File Offset: 0x00335760
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C6 RID: 53702 RVA: 0x00337594 File Offset: 0x00335794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194776, XrefRangeEnd = 194898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004455 RID: 17493
			// (get) Token: 0x0600D1C7 RID: 53703 RVA: 0x003375D0 File Offset: 0x003357D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1C8 RID: 53704 RVA: 0x00337610 File Offset: 0x00335810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194898, XrefRangeEnd = 194904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004456 RID: 17494
			// (get) Token: 0x0600D1C9 RID: 53705 RVA: 0x00337644 File Offset: 0x00335844
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Aya._OnPositiveBuffExecute_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1CA RID: 53706 RVA: 0x00070501 File Offset: 0x0006E701
			public _OnPositiveBuffExecute_d__63(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443B RID: 17467
			// (get) Token: 0x0600D1CB RID: 53707 RVA: 0x00337684 File Offset: 0x00335884
			// (set) Token: 0x0600D1CC RID: 53708 RVA: 0x0007050A File Offset: 0x0006E70A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700443C RID: 17468
			// (get) Token: 0x0600D1CD RID: 53709 RVA: 0x003376AC File Offset: 0x003358AC
			// (set) Token: 0x0600D1CE RID: 53710 RVA: 0x00070525 File Offset: 0x0006E725
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443D RID: 17469
			// (get) Token: 0x0600D1CF RID: 53711 RVA: 0x003376DC File Offset: 0x003358DC
			// (set) Token: 0x0600D1D0 RID: 53712 RVA: 0x00070544 File Offset: 0x0006E744
			public unsafe Spell_Aya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443E RID: 17470
			// (get) Token: 0x0600D1D1 RID: 53713 RVA: 0x0033770C File Offset: 0x0033590C
			// (set) Token: 0x0600D1D2 RID: 53714 RVA: 0x00070563 File Offset: 0x0006E763
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443F RID: 17471
			// (get) Token: 0x0600D1D3 RID: 53715 RVA: 0x0033773C File Offset: 0x0033593C
			// (set) Token: 0x0600D1D4 RID: 53716 RVA: 0x00070582 File Offset: 0x0006E782
			public unsafe Spell_Aya.__c__DisplayClass63_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass63_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004440 RID: 17472
			// (get) Token: 0x0600D1D5 RID: 53717 RVA: 0x0033776C File Offset: 0x0033596C
			// (set) Token: 0x0600D1D6 RID: 53718 RVA: 0x000705A1 File Offset: 0x0006E7A1
			public unsafe Spell_Aya.__c__DisplayClass63_1 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass63_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004441 RID: 17473
			// (get) Token: 0x0600D1D7 RID: 53719 RVA: 0x0033779C File Offset: 0x0033599C
			// (set) Token: 0x0600D1D8 RID: 53720 RVA: 0x000705C0 File Offset: 0x0006E7C0
			public unsafe Spell_Aya.__c__DisplayClass63_2 __8__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Aya.__c__DisplayClass63_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr___8__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004442 RID: 17474
			// (get) Token: 0x0600D1D9 RID: 53721 RVA: 0x003377CC File Offset: 0x003359CC
			// (set) Token: 0x0600D1DA RID: 53722 RVA: 0x000705DF File Offset: 0x0006E7DF
			public unsafe Quaternion _leftRotate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__leftRotate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__leftRotate_5__2)) = value;
				}
			}

			// Token: 0x17004443 RID: 17475
			// (get) Token: 0x0600D1DB RID: 53723 RVA: 0x003377F4 File Offset: 0x003359F4
			// (set) Token: 0x0600D1DC RID: 53724 RVA: 0x000705FA File Offset: 0x0006E7FA
			public unsafe Quaternion _rightRotate_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rightRotate_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rightRotate_5__3)) = value;
				}
			}

			// Token: 0x17004444 RID: 17476
			// (get) Token: 0x0600D1DD RID: 53725 RVA: 0x0033781C File Offset: 0x00335A1C
			// (set) Token: 0x0600D1DE RID: 53726 RVA: 0x00070615 File Offset: 0x0006E815
			public unsafe float _waitSeconds_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__waitSeconds_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__waitSeconds_5__4)) = value;
				}
			}

			// Token: 0x17004445 RID: 17477
			// (get) Token: 0x0600D1DF RID: 53727 RVA: 0x00337844 File Offset: 0x00335A44
			// (set) Token: 0x0600D1E0 RID: 53728 RVA: 0x00070630 File Offset: 0x0006E830
			public unsafe WaitForSeconds _wait_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__wait_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__wait_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004446 RID: 17478
			// (get) Token: 0x0600D1E1 RID: 53729 RVA: 0x00337874 File Offset: 0x00335A74
			// (set) Token: 0x0600D1E2 RID: 53730 RVA: 0x0007064F File Offset: 0x0006E84F
			public unsafe WaitForSeconds _wait2_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__wait2_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__wait2_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004447 RID: 17479
			// (get) Token: 0x0600D1E3 RID: 53731 RVA: 0x003378A4 File Offset: 0x00335AA4
			// (set) Token: 0x0600D1E4 RID: 53732 RVA: 0x0007066E File Offset: 0x0006E86E
			public unsafe int _maxX_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__maxX_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__maxX_5__7)) = value;
				}
			}

			// Token: 0x17004448 RID: 17480
			// (get) Token: 0x0600D1E5 RID: 53733 RVA: 0x003378CC File Offset: 0x00335ACC
			// (set) Token: 0x0600D1E6 RID: 53734 RVA: 0x00070689 File Offset: 0x0006E889
			public unsafe int _minX_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__minX_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__minX_5__8)) = value;
				}
			}

			// Token: 0x17004449 RID: 17481
			// (get) Token: 0x0600D1E7 RID: 53735 RVA: 0x003378F4 File Offset: 0x00335AF4
			// (set) Token: 0x0600D1E8 RID: 53736 RVA: 0x000706A4 File Offset: 0x0006E8A4
			public unsafe int _minY_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__minY_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__minY_5__9)) = value;
				}
			}

			// Token: 0x1700444A RID: 17482
			// (get) Token: 0x0600D1E9 RID: 53737 RVA: 0x0033791C File Offset: 0x00335B1C
			// (set) Token: 0x0600D1EA RID: 53738 RVA: 0x000706BF File Offset: 0x0006E8BF
			public unsafe int _maxY_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__maxY_5__10);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__maxY_5__10)) = value;
				}
			}

			// Token: 0x1700444B RID: 17483
			// (get) Token: 0x0600D1EB RID: 53739 RVA: 0x00337944 File Offset: 0x00335B44
			// (set) Token: 0x0600D1EC RID: 53740 RVA: 0x000706DA File Offset: 0x0006E8DA
			public unsafe Dictionary<int, Vector3> _allTables_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__allTables_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__allTables_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444C RID: 17484
			// (get) Token: 0x0600D1ED RID: 53741 RVA: 0x00337974 File Offset: 0x00335B74
			// (set) Token: 0x0600D1EE RID: 53742 RVA: 0x000706F9 File Offset: 0x0006E8F9
			public unsafe List<int> _allTables2_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__allTables2_5__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__allTables2_5__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444D RID: 17485
			// (get) Token: 0x0600D1EF RID: 53743 RVA: 0x003379A4 File Offset: 0x00335BA4
			// (set) Token: 0x0600D1F0 RID: 53744 RVA: 0x00070718 File Offset: 0x0006E918
			public unsafe bool _isHorizontal_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isHorizontal_5__13);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isHorizontal_5__13)) = value;
				}
			}

			// Token: 0x1700444E RID: 17486
			// (get) Token: 0x0600D1F1 RID: 53745 RVA: 0x003379CC File Offset: 0x00335BCC
			// (set) Token: 0x0600D1F2 RID: 53746 RVA: 0x00070733 File Offset: 0x0006E933
			public unsafe bool _isRight_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isRight_5__14);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isRight_5__14)) = value;
				}
			}

			// Token: 0x1700444F RID: 17487
			// (get) Token: 0x0600D1F3 RID: 53747 RVA: 0x003379F4 File Offset: 0x00335BF4
			// (set) Token: 0x0600D1F4 RID: 53748 RVA: 0x0007074E File Offset: 0x0006E94E
			public unsafe bool _isUp_5__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isUp_5__15);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__isUp_5__15)) = value;
				}
			}

			// Token: 0x17004450 RID: 17488
			// (get) Token: 0x0600D1F5 RID: 53749 RVA: 0x00337A1C File Offset: 0x00335C1C
			// (set) Token: 0x0600D1F6 RID: 53750 RVA: 0x00070769 File Offset: 0x0006E969
			public unsafe CharacterControllerUnit _ayaCharacter_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__ayaCharacter_5__16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__ayaCharacter_5__16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004451 RID: 17489
			// (get) Token: 0x0600D1F7 RID: 53751 RVA: 0x00337A4C File Offset: 0x00335C4C
			// (set) Token: 0x0600D1F8 RID: 53752 RVA: 0x00070788 File Offset: 0x0006E988
			public unsafe int _rotate_5__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rotate_5__17);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rotate_5__17)) = value;
				}
			}

			// Token: 0x17004452 RID: 17490
			// (get) Token: 0x0600D1F9 RID: 53753 RVA: 0x00337A74 File Offset: 0x00335C74
			// (set) Token: 0x0600D1FA RID: 53754 RVA: 0x000707A3 File Offset: 0x0006E9A3
			public unsafe Quaternion _rotateStart_5__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rotateStart_5__18);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__rotateStart_5__18)) = value;
				}
			}

			// Token: 0x17004453 RID: 17491
			// (get) Token: 0x0600D1FB RID: 53755 RVA: 0x00337A9C File Offset: 0x00335C9C
			// (set) Token: 0x0600D1FC RID: 53756 RVA: 0x000707BE File Offset: 0x0006E9BE
			public unsafe int _i_5__19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__i_5__19);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__i_5__19)) = value;
				}
			}

			// Token: 0x17004454 RID: 17492
			// (get) Token: 0x0600D1FD RID: 53757 RVA: 0x00337AC4 File Offset: 0x00335CC4
			// (set) Token: 0x0600D1FE RID: 53758 RVA: 0x000707D9 File Offset: 0x0006E9D9
			public unsafe int _j_5__20
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__j_5__20);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Aya._OnPositiveBuffExecute_d__63.NativeFieldInfoPtr__j_5__20)) = value;
				}
			}

			// Token: 0x040086C1 RID: 34497
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040086C2 RID: 34498
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040086C3 RID: 34499
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086C4 RID: 34500
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040086C5 RID: 34501
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040086C6 RID: 34502
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x040086C7 RID: 34503
			private static readonly IntPtr NativeFieldInfoPtr___8__3;

			// Token: 0x040086C8 RID: 34504
			private static readonly IntPtr NativeFieldInfoPtr__leftRotate_5__2;

			// Token: 0x040086C9 RID: 34505
			private static readonly IntPtr NativeFieldInfoPtr__rightRotate_5__3;

			// Token: 0x040086CA RID: 34506
			private static readonly IntPtr NativeFieldInfoPtr__waitSeconds_5__4;

			// Token: 0x040086CB RID: 34507
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__5;

			// Token: 0x040086CC RID: 34508
			private static readonly IntPtr NativeFieldInfoPtr__wait2_5__6;

			// Token: 0x040086CD RID: 34509
			private static readonly IntPtr NativeFieldInfoPtr__maxX_5__7;

			// Token: 0x040086CE RID: 34510
			private static readonly IntPtr NativeFieldInfoPtr__minX_5__8;

			// Token: 0x040086CF RID: 34511
			private static readonly IntPtr NativeFieldInfoPtr__minY_5__9;

			// Token: 0x040086D0 RID: 34512
			private static readonly IntPtr NativeFieldInfoPtr__maxY_5__10;

			// Token: 0x040086D1 RID: 34513
			private static readonly IntPtr NativeFieldInfoPtr__allTables_5__11;

			// Token: 0x040086D2 RID: 34514
			private static readonly IntPtr NativeFieldInfoPtr__allTables2_5__12;

			// Token: 0x040086D3 RID: 34515
			private static readonly IntPtr NativeFieldInfoPtr__isHorizontal_5__13;

			// Token: 0x040086D4 RID: 34516
			private static readonly IntPtr NativeFieldInfoPtr__isRight_5__14;

			// Token: 0x040086D5 RID: 34517
			private static readonly IntPtr NativeFieldInfoPtr__isUp_5__15;

			// Token: 0x040086D6 RID: 34518
			private static readonly IntPtr NativeFieldInfoPtr__ayaCharacter_5__16;

			// Token: 0x040086D7 RID: 34519
			private static readonly IntPtr NativeFieldInfoPtr__rotate_5__17;

			// Token: 0x040086D8 RID: 34520
			private static readonly IntPtr NativeFieldInfoPtr__rotateStart_5__18;

			// Token: 0x040086D9 RID: 34521
			private static readonly IntPtr NativeFieldInfoPtr__i_5__19;

			// Token: 0x040086DA RID: 34522
			private static readonly IntPtr NativeFieldInfoPtr__j_5__20;

			// Token: 0x040086DB RID: 34523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040086DC RID: 34524
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086DD RID: 34525
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040086DE RID: 34526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040086DF RID: 34527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086E0 RID: 34528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
