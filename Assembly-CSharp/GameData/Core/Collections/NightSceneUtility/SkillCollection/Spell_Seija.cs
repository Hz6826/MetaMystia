using System;
using Common.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using TMPro;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000284 RID: 644
	public class Spell_Seija : SpellBase
	{
		// Token: 0x06005103 RID: 20739 RVA: 0x001B267C File Offset: 0x001B087C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Seija()
		{
			Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Seija");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr);
			Spell_Seija.NativeFieldInfoPtr_SEIJA_SPECIAL_POSITIVE_SPELL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "SEIJA_SPECIAL_POSITIVE_SPELL");
			Spell_Seija.NativeFieldInfoPtr_SEIJA_ADD_ORDERCOUNT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "SEIJA_ADD_ORDERCOUNT_KEY");
			Spell_Seija.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "positiveDuration");
			Spell_Seija.NativeFieldInfoPtr_positiveMaxRewardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "positiveMaxRewardNum");
			Spell_Seija.NativeFieldInfoPtr_positiveAddMoneyPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "positiveAddMoneyPercent");
			Spell_Seija.NativeFieldInfoPtr_positiveCheckNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "positiveCheckNum");
			Spell_Seija.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "negativeDuration");
			Spell_Seija.NativeFieldInfoPtr_reverseObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "reverseObject");
			Spell_Seija.NativeFieldInfoPtr_reverseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "reverseDuration");
			Spell_Seija.NativeFieldInfoPtr_walletObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "walletObject");
			Spell_Seija.NativeFieldInfoPtr_fireBallInEyeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "fireBallInEyeObject");
			Spell_Seija.NativeFieldInfoPtr_walletAnimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "walletAnimDuration");
			Spell_Seija.NativeFieldInfoPtr_fireOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "fireOffset");
			Spell_Seija.NativeFieldInfoPtr_punishmentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "punishmentObject");
			Spell_Seija.NativeFieldInfoPtr_reverseDuration_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "reverseDuration_P");
			Spell_Seija.NativeFieldInfoPtr_reward1Sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "reward1Sfx");
			Spell_Seija.NativeFieldInfoPtr_reward2Sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "reward2Sfx");
			Spell_Seija.NativeFieldInfoPtr_yukuriDropSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "yukuriDropSfx");
			Spell_Seija.NativeFieldInfoPtr_OverturningWorldSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "OverturningWorldSfx");
			Spell_Seija.NativeFieldInfoPtr_yukuriLiftSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "yukuriLiftSfx");
			Spell_Seija.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679670);
			Spell_Seija.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679671);
			Spell_Seija.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679672);
			Spell_Seija.NativeMethodInfoPtr_OnGuestSpawnNegative_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679673);
			Spell_Seija.NativeMethodInfoPtr_OnBuffEndNegative_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679674);
			Spell_Seija.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679675);
			Spell_Seija.NativeMethodInfoPtr_ReversedLikeTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679676);
			Spell_Seija.NativeMethodInfoPtr_ReversedHateTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679677);
			Spell_Seija.NativeMethodInfoPtr_OnGuestSpawnPositive_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679678);
			Spell_Seija.NativeMethodInfoPtr_OnBuffEndPositive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679679);
			Spell_Seija.NativeMethodInfoPtr_GetEffectDisplayer_Private_Boolean_GuestGroupController_byref_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679680);
			Spell_Seija.NativeMethodInfoPtr_RefreshDisplayer_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679681);
			Spell_Seija.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679682);
			Spell_Seija.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679683);
			Spell_Seija.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_4_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679684);
			Spell_Seija.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679685);
			Spell_Seija.NativeMethodInfoPtr__OnBuffEndPositive_b__29_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, 100679686);
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x001B2990 File Offset: 0x001B0B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204250, XrefRangeEnd = 204252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seija.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x001B29D4 File Offset: 0x001B0BD4
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seija.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x001B2A28 File Offset: 0x001B0C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204252, XrefRangeEnd = 204258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seija.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x001B2A84 File Offset: 0x001B0C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204258, XrefRangeEnd = 204286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawnNegative(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_OnGuestSpawnNegative_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x001B2AC8 File Offset: 0x001B0CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204286, XrefRangeEnd = 204297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEndNegative()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_OnBuffEndNegative_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x001B2AFC File Offset: 0x001B0CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204297, XrefRangeEnd = 204303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seija.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x001B2B58 File Offset: 0x001B0D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204303, XrefRangeEnd = 204360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> ReversedLikeTags(Il2CppStructArray<int> originalTags, GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_ReversedLikeTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x001B2BBC File Offset: 0x001B0DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204360, XrefRangeEnd = 204364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> ReversedHateTags(Il2CppStructArray<int> originalTags, GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_ReversedHateTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x001B2C20 File Offset: 0x001B0E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204364, XrefRangeEnd = 204388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawnPositive(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_OnGuestSpawnPositive_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x001B2C64 File Offset: 0x001B0E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204388, XrefRangeEnd = 204408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEndPositive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_OnBuffEndPositive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x001B2C98 File Offset: 0x001B0E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204408, XrefRangeEnd = 204431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetEffectDisplayer(GuestGroupController x, out List<GameObject> myEffects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_GetEffectDisplayer_Private_Boolean_GuestGroupController_byref_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			myEffects = ((intPtr4 == 0) ? null : new List<GameObject>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x001B2D08 File Offset: 0x001B0F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204507, RefRangeEnd = 204508, XrefRangeStart = 204431, XrefRangeEnd = 204507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayer(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_RefreshDisplayer_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x001B2D4C File Offset: 0x001B0F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Seija() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x001B2D88 File Offset: 0x001B0F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204508, XrefRangeEnd = 204516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__25_3(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x001B2DC8 File Offset: 0x001B0FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204516, XrefRangeEnd = 204540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__25_4(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_4_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x001B2E0C File Offset: 0x001B100C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204540, XrefRangeEnd = 204546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_GuestGroupController_PDM_0(GuestGroupController thisGuest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x001B2E50 File Offset: 0x001B1050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204546, XrefRangeEnd = 204570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBuffEndPositive_b__29_0(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.NativeMethodInfoPtr__OnBuffEndPositive_b__29_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x0002AFF9 File Offset: 0x000291F9
		public Spell_Seija(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x001B2E94 File Offset: 0x001B1094
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x0002B002 File Offset: 0x00029202
		public unsafe static int SEIJA_SPECIAL_POSITIVE_SPELL
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Seija.NativeFieldInfoPtr_SEIJA_SPECIAL_POSITIVE_SPELL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Seija.NativeFieldInfoPtr_SEIJA_SPECIAL_POSITIVE_SPELL, (void*)(&value));
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x001B2EB0 File Offset: 0x001B10B0
		// (set) Token: 0x06005119 RID: 20761 RVA: 0x0002B010 File Offset: 0x00029210
		public unsafe static string SEIJA_ADD_ORDERCOUNT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Seija.NativeFieldInfoPtr_SEIJA_ADD_ORDERCOUNT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Seija.NativeFieldInfoPtr_SEIJA_ADD_ORDERCOUNT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x001B2ED0 File Offset: 0x001B10D0
		// (set) Token: 0x0600511B RID: 20763 RVA: 0x0002B022 File Offset: 0x00029222
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x001B2EF8 File Offset: 0x001B10F8
		// (set) Token: 0x0600511D RID: 20765 RVA: 0x0002B03D File Offset: 0x0002923D
		public unsafe int positiveMaxRewardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveMaxRewardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveMaxRewardNum)) = value;
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x001B2F20 File Offset: 0x001B1120
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x0002B058 File Offset: 0x00029258
		public unsafe float positiveAddMoneyPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveAddMoneyPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveAddMoneyPercent)) = value;
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x001B2F48 File Offset: 0x001B1148
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x0002B073 File Offset: 0x00029273
		public unsafe int positiveCheckNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveCheckNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_positiveCheckNum)) = value;
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x001B2F70 File Offset: 0x001B1170
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x0002B08E File Offset: 0x0002928E
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x001B2F98 File Offset: 0x001B1198
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x0002B0A9 File Offset: 0x000292A9
		public unsafe GameObject reverseObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reverseObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reverseObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x001B2FC8 File Offset: 0x001B11C8
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x0002B0C8 File Offset: 0x000292C8
		public unsafe float reverseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reverseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reverseDuration)) = value;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x001B2FF0 File Offset: 0x001B11F0
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x0002B0E3 File Offset: 0x000292E3
		public unsafe GameObject walletObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_walletObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_walletObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x001B3020 File Offset: 0x001B1220
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x0002B102 File Offset: 0x00029302
		public unsafe GameObject fireBallInEyeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_fireBallInEyeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_fireBallInEyeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x001B3050 File Offset: 0x001B1250
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x0002B121 File Offset: 0x00029321
		public unsafe float walletAnimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_walletAnimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_walletAnimDuration)) = value;
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x001B3078 File Offset: 0x001B1278
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x0002B13C File Offset: 0x0002933C
		public unsafe Vector2 fireOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_fireOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_fireOffset)) = value;
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x001B30A0 File Offset: 0x001B12A0
		// (set) Token: 0x06005131 RID: 20785 RVA: 0x0002B157 File Offset: 0x00029357
		public unsafe GameObject punishmentObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_punishmentObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_punishmentObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x001B30D0 File Offset: 0x001B12D0
		// (set) Token: 0x06005133 RID: 20787 RVA: 0x0002B176 File Offset: 0x00029376
		public unsafe float reverseDuration_P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reverseDuration_P);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reverseDuration_P)) = value;
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x001B30F8 File Offset: 0x001B12F8
		// (set) Token: 0x06005135 RID: 20789 RVA: 0x0002B191 File Offset: 0x00029391
		public SpellBase.DelayAudioClip reward1Sfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reward1Sfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reward1Sfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x001B3128 File Offset: 0x001B1328
		// (set) Token: 0x06005137 RID: 20791 RVA: 0x0002B1BF File Offset: 0x000293BF
		public SpellBase.DelayAudioClip reward2Sfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reward2Sfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_reward2Sfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x001B3158 File Offset: 0x001B1358
		// (set) Token: 0x06005139 RID: 20793 RVA: 0x0002B1ED File Offset: 0x000293ED
		public SpellBase.DelayAudioClip yukuriDropSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_yukuriDropSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_yukuriDropSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x001B3188 File Offset: 0x001B1388
		// (set) Token: 0x0600513B RID: 20795 RVA: 0x0002B21B File Offset: 0x0002941B
		public SpellBase.DelayAudioClip OverturningWorldSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_OverturningWorldSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_OverturningWorldSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x001B31B8 File Offset: 0x001B13B8
		// (set) Token: 0x0600513D RID: 20797 RVA: 0x0002B249 File Offset: 0x00029449
		public SpellBase.DelayAudioClip yukuriLiftSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_yukuriLiftSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.NativeFieldInfoPtr_yukuriLiftSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeFieldInfoPtr_SEIJA_SPECIAL_POSITIVE_SPELL;

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeFieldInfoPtr_SEIJA_ADD_ORDERCOUNT_KEY;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeFieldInfoPtr_positiveMaxRewardNum;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeFieldInfoPtr_positiveAddMoneyPercent;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeFieldInfoPtr_positiveCheckNum;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeFieldInfoPtr_reverseObject;

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeFieldInfoPtr_reverseDuration;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeFieldInfoPtr_walletObject;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeFieldInfoPtr_fireBallInEyeObject;

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeFieldInfoPtr_walletAnimDuration;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeFieldInfoPtr_fireOffset;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeFieldInfoPtr_punishmentObject;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeFieldInfoPtr_reverseDuration_P;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeFieldInfoPtr_reward1Sfx;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeFieldInfoPtr_reward2Sfx;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeFieldInfoPtr_yukuriDropSfx;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeFieldInfoPtr_OverturningWorldSfx;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeFieldInfoPtr_yukuriLiftSfx;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawnNegative_Private_Void_GuestGroupController_0;

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEndNegative_Private_Void_0;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeMethodInfoPtr_ReversedLikeTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0;

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeMethodInfoPtr_ReversedHateTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawnPositive_Private_Void_GuestGroupController_0;

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEndPositive_Private_Void_0;

		// Token: 0x040036E8 RID: 14056
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectDisplayer_Private_Boolean_GuestGroupController_byref_List_1_GameObject_0;

		// Token: 0x040036E9 RID: 14057
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayer_Private_Void_GuestGroupController_0;

		// Token: 0x040036EA RID: 14058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036EB RID: 14059
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_3_Private_Void_Int32_0;

		// Token: 0x040036EC RID: 14060
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_4_Private_Void_GuestGroupController_0;

		// Token: 0x040036ED RID: 14061
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0;

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeMethodInfoPtr__OnBuffEndPositive_b__29_0_Private_Void_GuestGroupController_0;

		// Token: 0x02000BC3 RID: 3011
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBE5 RID: 56293 RVA: 0x00355794 File Offset: 0x00353994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass22_0>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass22_0.NativeFieldInfoPtr_minFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass22_0>.NativeClassPtr, "minFund");
				Spell_Seija.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass22_0>.NativeClassPtr, 100679687);
				Spell_Seija.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass22_0>.NativeClassPtr, 100679688);
			}

			// Token: 0x0600DBE6 RID: 56294 RVA: 0x003557FC File Offset: 0x003539FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE7 RID: 56295 RVA: 0x00355838 File Offset: 0x00353A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203936, XrefRangeEnd = 203944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE8 RID: 56296 RVA: 0x000757FF File Offset: 0x000739FF
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700477C RID: 18300
			// (get) Token: 0x0600DBE9 RID: 56297 RVA: 0x0035587C File Offset: 0x00353A7C
			// (set) Token: 0x0600DBEA RID: 56298 RVA: 0x00075808 File Offset: 0x00073A08
			public unsafe int minFund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass22_0.NativeFieldInfoPtr_minFund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass22_0.NativeFieldInfoPtr_minFund)) = value;
				}
			}

			// Token: 0x04008CE3 RID: 36067
			private static readonly IntPtr NativeFieldInfoPtr_minFund;

			// Token: 0x04008CE4 RID: 36068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CE5 RID: 36069
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000BC4 RID: 3012
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DBEB RID: 56299 RVA: 0x003558A4 File Offset: 0x00353AA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr);
				Spell_Seija.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9");
				Spell_Seija.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__22_0");
				Spell_Seija.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__22_1");
				Spell_Seija.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__23_0");
				Spell_Seija.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__25_0");
				Spell_Seija.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__25_1");
				Spell_Seija.__c.NativeFieldInfoPtr___9__25_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__25_2");
				Spell_Seija.__c.NativeFieldInfoPtr___9__25_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__25_5");
				Spell_Seija.__c.NativeFieldInfoPtr___9__25_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__25_6");
				Spell_Seija.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__26_0");
				Spell_Seija.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, "<>9__30_2");
				Spell_Seija.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679690);
				Spell_Seija.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679691);
				Spell_Seija.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_1_Internal_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679692);
				Spell_Seija.__c.NativeMethodInfoPtr__OnGuestSpawnNegative_b__23_0_Internal_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679693);
				Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_0_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679694);
				Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_1_Internal_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679695);
				Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_2_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679696);
				Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_5_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679697);
				Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_6_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679698);
				Spell_Seija.__c.NativeMethodInfoPtr__ReversedLikeTags_b__26_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679699);
				Spell_Seija.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__30_2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr, 100679700);
			}

			// Token: 0x0600DBEC RID: 56300 RVA: 0x00355A88 File Offset: 0x00353C88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBED RID: 56301 RVA: 0x00355AC4 File Offset: 0x00353CC4
			[CallerCount(0)]
			public unsafe int _OnNegativeBuffExecute_b__22_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBEE RID: 56302 RVA: 0x00355B14 File Offset: 0x00353D14
			[CallerCount(0)]
			public unsafe int _OnNegativeBuffExecute_b__22_1(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_1_Internal_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBEF RID: 56303 RVA: 0x00355B64 File Offset: 0x00353D64
			[CallerCount(0)]
			public unsafe int _OnGuestSpawnNegative_b__23_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnGuestSpawnNegative_b__23_0_Internal_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBF0 RID: 56304 RVA: 0x00355BB4 File Offset: 0x00353DB4
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__25_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_0_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBF1 RID: 56305 RVA: 0x00355C04 File Offset: 0x00353E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203944, XrefRangeEnd = 203946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPositiveBuffExecute_b__25_1(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_1_Internal_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBF2 RID: 56306 RVA: 0x00355C54 File Offset: 0x00353E54
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__25_2(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_2_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBF3 RID: 56307 RVA: 0x00355CAC File Offset: 0x00353EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203946, XrefRangeEnd = 203956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__25_5(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_5_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBF4 RID: 56308 RVA: 0x00355CF0 File Offset: 0x00353EF0
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__25_6(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_6_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBF5 RID: 56309 RVA: 0x00355D40 File Offset: 0x00353F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ReversedLikeTags_b__26_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__ReversedLikeTags_b__26_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DBF6 RID: 56310 RVA: 0x00355D84 File Offset: 0x00353F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203956, XrefRangeEnd = 203974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__30_2(GameObject effect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__30_2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBF7 RID: 56311 RVA: 0x00075823 File Offset: 0x00073A23
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700477D RID: 18301
			// (get) Token: 0x0600DBF8 RID: 56312 RVA: 0x00355DC8 File Offset: 0x00353FC8
			// (set) Token: 0x0600DBF9 RID: 56313 RVA: 0x0007582C File Offset: 0x00073A2C
			public unsafe static Spell_Seija.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700477E RID: 18302
			// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x00355DF0 File Offset: 0x00353FF0
			// (set) Token: 0x0600DBFB RID: 56315 RVA: 0x0007583E File Offset: 0x00073A3E
			public unsafe static Func<GuestGroupController, int> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700477F RID: 18303
			// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x00355E18 File Offset: 0x00354018
			// (set) Token: 0x0600DBFD RID: 56317 RVA: 0x00075850 File Offset: 0x00073A50
			public unsafe static Func<GuestGroupController, int> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004780 RID: 18304
			// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x00355E40 File Offset: 0x00354040
			// (set) Token: 0x0600DBFF RID: 56319 RVA: 0x00075862 File Offset: 0x00073A62
			public unsafe static Func<GuestGroupController, int> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004781 RID: 18305
			// (get) Token: 0x0600DC00 RID: 56320 RVA: 0x00355E68 File Offset: 0x00354068
			// (set) Token: 0x0600DC01 RID: 56321 RVA: 0x00075874 File Offset: 0x00073A74
			public unsafe static Func<GuestGroupController, bool> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004782 RID: 18306
			// (get) Token: 0x0600DC02 RID: 56322 RVA: 0x00355E90 File Offset: 0x00354090
			// (set) Token: 0x0600DC03 RID: 56323 RVA: 0x00075886 File Offset: 0x00073A86
			public unsafe static Func<GuestGroupController, int> __9__25_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004783 RID: 18307
			// (get) Token: 0x0600DC04 RID: 56324 RVA: 0x00355EB8 File Offset: 0x003540B8
			// (set) Token: 0x0600DC05 RID: 56325 RVA: 0x00075898 File Offset: 0x00073A98
			public unsafe static Func<int, int, int> __9__25_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004784 RID: 18308
			// (get) Token: 0x0600DC06 RID: 56326 RVA: 0x00355EE0 File Offset: 0x003540E0
			// (set) Token: 0x0600DC07 RID: 56327 RVA: 0x000758AA File Offset: 0x00073AAA
			public unsafe static Action<GameObject> __9__25_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004785 RID: 18309
			// (get) Token: 0x0600DC08 RID: 56328 RVA: 0x00355F08 File Offset: 0x00354108
			// (set) Token: 0x0600DC09 RID: 56329 RVA: 0x000758BC File Offset: 0x00073ABC
			public unsafe static Func<GuestGroupController, bool> __9__25_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__25_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004786 RID: 18310
			// (get) Token: 0x0600DC0A RID: 56330 RVA: 0x00355F30 File Offset: 0x00354130
			// (set) Token: 0x0600DC0B RID: 56331 RVA: 0x000758CE File Offset: 0x00073ACE
			public unsafe static Func<int, string> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004787 RID: 18311
			// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x00355F58 File Offset: 0x00354158
			// (set) Token: 0x0600DC0D RID: 56333 RVA: 0x000758E0 File Offset: 0x00073AE0
			public unsafe static Action<GameObject> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seija.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seija.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CE6 RID: 36070
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008CE7 RID: 36071
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04008CE8 RID: 36072
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x04008CE9 RID: 36073
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04008CEA RID: 36074
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04008CEB RID: 36075
			private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

			// Token: 0x04008CEC RID: 36076
			private static readonly IntPtr NativeFieldInfoPtr___9__25_2;

			// Token: 0x04008CED RID: 36077
			private static readonly IntPtr NativeFieldInfoPtr___9__25_5;

			// Token: 0x04008CEE RID: 36078
			private static readonly IntPtr NativeFieldInfoPtr___9__25_6;

			// Token: 0x04008CEF RID: 36079
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04008CF0 RID: 36080
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x04008CF1 RID: 36081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF2 RID: 36082
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Int32_GuestGroupController_0;

			// Token: 0x04008CF3 RID: 36083
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_1_Internal_Int32_GuestGroupController_0;

			// Token: 0x04008CF4 RID: 36084
			private static readonly IntPtr NativeMethodInfoPtr__OnGuestSpawnNegative_b__23_0_Internal_Int32_GuestGroupController_0;

			// Token: 0x04008CF5 RID: 36085
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_0_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008CF6 RID: 36086
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_1_Internal_Int32_GuestGroupController_0;

			// Token: 0x04008CF7 RID: 36087
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_2_Internal_Int32_Int32_Int32_0;

			// Token: 0x04008CF8 RID: 36088
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_5_Internal_Void_GameObject_0;

			// Token: 0x04008CF9 RID: 36089
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__25_6_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008CFA RID: 36090
			private static readonly IntPtr NativeMethodInfoPtr__ReversedLikeTags_b__26_0_Internal_String_Int32_0;

			// Token: 0x04008CFB RID: 36091
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__30_2_Internal_Void_GameObject_0;
		}

		// Token: 0x02000BC5 RID: 3013
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<OnNegativeBuffExecute>d__22")]
		public sealed class _OnNegativeBuffExecute_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600DC0E RID: 56334 RVA: 0x00355F80 File Offset: 0x00354180
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__22()
			{
				Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<OnNegativeBuffExecute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr);
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>1__state");
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>2__current");
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>4__this");
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, "spellExecutionContext");
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>8__1");
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679701);
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679702);
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679703);
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679704);
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679705);
				Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679706);
			}

			// Token: 0x0600DC0F RID: 56335 RVA: 0x00356088 File Offset: 0x00354288
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija._OnNegativeBuffExecute_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC10 RID: 56336 RVA: 0x003560D0 File Offset: 0x003542D0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC11 RID: 56337 RVA: 0x00356104 File Offset: 0x00354304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203974, XrefRangeEnd = 204045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700478D RID: 18317
			// (get) Token: 0x0600DC12 RID: 56338 RVA: 0x00356140 File Offset: 0x00354340
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC13 RID: 56339 RVA: 0x00356180 File Offset: 0x00354380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204045, XrefRangeEnd = 204051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700478E RID: 18318
			// (get) Token: 0x0600DC14 RID: 56340 RVA: 0x003561B4 File Offset: 0x003543B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC15 RID: 56341 RVA: 0x000758F2 File Offset: 0x00073AF2
			public _OnNegativeBuffExecute_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004788 RID: 18312
			// (get) Token: 0x0600DC16 RID: 56342 RVA: 0x003561F4 File Offset: 0x003543F4
			// (set) Token: 0x0600DC17 RID: 56343 RVA: 0x000758FB File Offset: 0x00073AFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004789 RID: 18313
			// (get) Token: 0x0600DC18 RID: 56344 RVA: 0x0035621C File Offset: 0x0035441C
			// (set) Token: 0x0600DC19 RID: 56345 RVA: 0x00075916 File Offset: 0x00073B16
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700478A RID: 18314
			// (get) Token: 0x0600DC1A RID: 56346 RVA: 0x0035624C File Offset: 0x0035444C
			// (set) Token: 0x0600DC1B RID: 56347 RVA: 0x00075935 File Offset: 0x00073B35
			public unsafe Spell_Seija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700478B RID: 18315
			// (get) Token: 0x0600DC1C RID: 56348 RVA: 0x0035627C File Offset: 0x0035447C
			// (set) Token: 0x0600DC1D RID: 56349 RVA: 0x00075954 File Offset: 0x00073B54
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700478C RID: 18316
			// (get) Token: 0x0600DC1E RID: 56350 RVA: 0x003562AC File Offset: 0x003544AC
			// (set) Token: 0x0600DC1F RID: 56351 RVA: 0x00075973 File Offset: 0x00073B73
			public unsafe Spell_Seija.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CFC RID: 36092
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CFD RID: 36093
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CFE RID: 36094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CFF RID: 36095
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008D00 RID: 36096
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008D01 RID: 36097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D02 RID: 36098
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D03 RID: 36099
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D04 RID: 36100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D05 RID: 36101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D06 RID: 36102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BC6 RID: 3014
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC20 RID: 56352 RVA: 0x003562DC File Offset: 0x003544DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass25_0.NativeFieldInfoPtr_allGuestExtraCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr, "allGuestExtraCollection");
				Spell_Seija.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				Spell_Seija.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr, 100679707);
				Spell_Seija.__c__DisplayClass25_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr, 100679708);
			}

			// Token: 0x0600DC21 RID: 56353 RVA: 0x00356358 File Offset: 0x00354558
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC22 RID: 56354 RVA: 0x00356394 File Offset: 0x00354594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204051, XrefRangeEnd = 204106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__7(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass25_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC23 RID: 56355 RVA: 0x00075992 File Offset: 0x00073B92
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700478F RID: 18319
			// (get) Token: 0x0600DC24 RID: 56356 RVA: 0x003563D8 File Offset: 0x003545D8
			// (set) Token: 0x0600DC25 RID: 56357 RVA: 0x0007599B File Offset: 0x00073B9B
			public unsafe List<ValueTuple<GuestGroupController, int>> allGuestExtraCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_0.NativeFieldInfoPtr_allGuestExtraCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<GuestGroupController, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_0.NativeFieldInfoPtr_allGuestExtraCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004790 RID: 18320
			// (get) Token: 0x0600DC26 RID: 56358 RVA: 0x00356408 File Offset: 0x00354608
			// (set) Token: 0x0600DC27 RID: 56359 RVA: 0x000759BA File Offset: 0x00073BBA
			public unsafe Spell_Seija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D07 RID: 36103
			private static readonly IntPtr NativeFieldInfoPtr_allGuestExtraCollection;

			// Token: 0x04008D08 RID: 36104
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D09 RID: 36105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D0A RID: 36106
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000BC7 RID: 3015
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass25_1")]
		public sealed class __c__DisplayClass25_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DC28 RID: 56360 RVA: 0x00356438 File Offset: 0x00354638
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_1()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass25_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, "x");
				Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_canGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, "canGet");
				Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, 100679709);
				Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Boolean_ValueTuple_2_GuestGroupController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, 100679710);
				Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_ValueTuple_2_GuestGroupController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, 100679711);
				Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr, 100679712);
			}

			// Token: 0x0600DC29 RID: 56361 RVA: 0x003564F0 File Offset: 0x003546F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass25_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC2A RID: 56362 RVA: 0x0035652C File Offset: 0x0035472C
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__8(ValueTuple<GuestGroupController, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Boolean_ValueTuple_2_GuestGroupController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC2B RID: 56363 RVA: 0x00356580 File Offset: 0x00354780
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__9(ValueTuple<GuestGroupController, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_ValueTuple_2_GuestGroupController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC2C RID: 56364 RVA: 0x003565D4 File Offset: 0x003547D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204106, XrefRangeEnd = 204116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController thisGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass25_1.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC2D RID: 56365 RVA: 0x000759D9 File Offset: 0x00073BD9
			public __c__DisplayClass25_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004791 RID: 18321
			// (get) Token: 0x0600DC2E RID: 56366 RVA: 0x00356618 File Offset: 0x00354818
			// (set) Token: 0x0600DC2F RID: 56367 RVA: 0x000759E2 File Offset: 0x00073BE2
			public unsafe GuestGroupController x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004792 RID: 18322
			// (get) Token: 0x0600DC30 RID: 56368 RVA: 0x00356648 File Offset: 0x00354848
			// (set) Token: 0x0600DC31 RID: 56369 RVA: 0x00075A01 File Offset: 0x00073C01
			public unsafe bool canGet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_canGet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_canGet)) = value;
				}
			}

			// Token: 0x17004793 RID: 18323
			// (get) Token: 0x0600DC32 RID: 56370 RVA: 0x00356670 File Offset: 0x00354870
			// (set) Token: 0x0600DC33 RID: 56371 RVA: 0x00075A1C File Offset: 0x00073C1C
			public unsafe Spell_Seija.__c__DisplayClass25_0 field_Public___c__DisplayClass25_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija.__c__DisplayClass25_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass25_1.NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D0B RID: 36107
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008D0C RID: 36108
			private static readonly IntPtr NativeFieldInfoPtr_canGet;

			// Token: 0x04008D0D RID: 36109
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass25_0_0;

			// Token: 0x04008D0E RID: 36110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D0F RID: 36111
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Boolean_ValueTuple_2_GuestGroupController_Int32_0;

			// Token: 0x04008D10 RID: 36112
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_ValueTuple_2_GuestGroupController_Int32_0;

			// Token: 0x04008D11 RID: 36113
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;
		}

		// Token: 0x02000BC8 RID: 3016
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<OnPositiveBuffExecute>d__25")]
		public sealed class _OnPositiveBuffExecute_d__25 : Il2CppSystem.Object
		{
			// Token: 0x0600DC34 RID: 56372 RVA: 0x003566A0 File Offset: 0x003548A0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__25()
			{
				Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<OnPositiveBuffExecute>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr);
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>1__state");
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>2__current");
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>4__this");
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, "spellExecutionContext");
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>8__1");
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__useSecondSpellCardCheck_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<useSecondSpellCardCheck>5__2");
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679713);
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679714);
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679715);
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679716);
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679717);
				Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679718);
			}

			// Token: 0x0600DC35 RID: 56373 RVA: 0x003567BC File Offset: 0x003549BC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija._OnPositiveBuffExecute_d__25>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC36 RID: 56374 RVA: 0x00356804 File Offset: 0x00354A04
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC37 RID: 56375 RVA: 0x00356838 File Offset: 0x00354A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204116, XrefRangeEnd = 204198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700479A RID: 18330
			// (get) Token: 0x0600DC38 RID: 56376 RVA: 0x00356874 File Offset: 0x00354A74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC39 RID: 56377 RVA: 0x003568B4 File Offset: 0x00354AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204198, XrefRangeEnd = 204204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700479B RID: 18331
			// (get) Token: 0x0600DC3A RID: 56378 RVA: 0x003568E8 File Offset: 0x00354AE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC3B RID: 56379 RVA: 0x00075A3B File Offset: 0x00073C3B
			public _OnPositiveBuffExecute_d__25(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004794 RID: 18324
			// (get) Token: 0x0600DC3C RID: 56380 RVA: 0x00356928 File Offset: 0x00354B28
			// (set) Token: 0x0600DC3D RID: 56381 RVA: 0x00075A44 File Offset: 0x00073C44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004795 RID: 18325
			// (get) Token: 0x0600DC3E RID: 56382 RVA: 0x00356950 File Offset: 0x00354B50
			// (set) Token: 0x0600DC3F RID: 56383 RVA: 0x00075A5F File Offset: 0x00073C5F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004796 RID: 18326
			// (get) Token: 0x0600DC40 RID: 56384 RVA: 0x00356980 File Offset: 0x00354B80
			// (set) Token: 0x0600DC41 RID: 56385 RVA: 0x00075A7E File Offset: 0x00073C7E
			public unsafe Spell_Seija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004797 RID: 18327
			// (get) Token: 0x0600DC42 RID: 56386 RVA: 0x003569B0 File Offset: 0x00354BB0
			// (set) Token: 0x0600DC43 RID: 56387 RVA: 0x00075A9D File Offset: 0x00073C9D
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004798 RID: 18328
			// (get) Token: 0x0600DC44 RID: 56388 RVA: 0x003569E0 File Offset: 0x00354BE0
			// (set) Token: 0x0600DC45 RID: 56389 RVA: 0x00075ABC File Offset: 0x00073CBC
			public unsafe Spell_Seija.__c__DisplayClass25_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija.__c__DisplayClass25_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004799 RID: 18329
			// (get) Token: 0x0600DC46 RID: 56390 RVA: 0x00356A10 File Offset: 0x00354C10
			// (set) Token: 0x0600DC47 RID: 56391 RVA: 0x00075ADB File Offset: 0x00073CDB
			public unsafe bool _useSecondSpellCardCheck_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__useSecondSpellCardCheck_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__useSecondSpellCardCheck_5__2)) = value;
				}
			}

			// Token: 0x04008D12 RID: 36114
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D13 RID: 36115
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D14 RID: 36116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D15 RID: 36117
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008D16 RID: 36118
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008D17 RID: 36119
			private static readonly IntPtr NativeFieldInfoPtr__useSecondSpellCardCheck_5__2;

			// Token: 0x04008D18 RID: 36120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D19 RID: 36121
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D1A RID: 36122
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D1B RID: 36123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D1C RID: 36124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D1D RID: 36125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BC9 RID: 3017
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC48 RID: 56392 RVA: 0x00356A38 File Offset: 0x00354C38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, "x");
				Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_effectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, "effectIndex");
				Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_newEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, "newEffects");
				Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_allGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, "allGet");
				Spell_Seija.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, 100679719);
				Spell_Seija.__c__DisplayClass30_0.NativeMethodInfoPtr__GetEffectDisplayer_b__0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr, 100679720);
			}

			// Token: 0x0600DC49 RID: 56393 RVA: 0x00356AF0 File Offset: 0x00354CF0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC4A RID: 56394 RVA: 0x00356B2C File Offset: 0x00354D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204204, XrefRangeEnd = 204233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__0(AStarInputGeneratorComponent character)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass30_0.NativeMethodInfoPtr__GetEffectDisplayer_b__0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC4B RID: 56395 RVA: 0x00075AF6 File Offset: 0x00073CF6
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700479C RID: 18332
			// (get) Token: 0x0600DC4C RID: 56396 RVA: 0x00356B70 File Offset: 0x00354D70
			// (set) Token: 0x0600DC4D RID: 56397 RVA: 0x00075AFF File Offset: 0x00073CFF
			public unsafe Spell_Seija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700479D RID: 18333
			// (get) Token: 0x0600DC4E RID: 56398 RVA: 0x00356BA0 File Offset: 0x00354DA0
			// (set) Token: 0x0600DC4F RID: 56399 RVA: 0x00075B1E File Offset: 0x00073D1E
			public unsafe GuestGroupController x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700479E RID: 18334
			// (get) Token: 0x0600DC50 RID: 56400 RVA: 0x00356BD0 File Offset: 0x00354DD0
			// (set) Token: 0x0600DC51 RID: 56401 RVA: 0x00075B3D File Offset: 0x00073D3D
			public unsafe int effectIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_effectIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_effectIndex)) = value;
				}
			}

			// Token: 0x1700479F RID: 18335
			// (get) Token: 0x0600DC52 RID: 56402 RVA: 0x00356BF8 File Offset: 0x00354DF8
			// (set) Token: 0x0600DC53 RID: 56403 RVA: 0x00075B58 File Offset: 0x00073D58
			public unsafe List<GameObject> newEffects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_newEffects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_newEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A0 RID: 18336
			// (get) Token: 0x0600DC54 RID: 56404 RVA: 0x00356C28 File Offset: 0x00354E28
			// (set) Token: 0x0600DC55 RID: 56405 RVA: 0x00075B77 File Offset: 0x00073D77
			public unsafe bool allGet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_allGet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_0.NativeFieldInfoPtr_allGet)) = value;
				}
			}

			// Token: 0x04008D1E RID: 36126
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D1F RID: 36127
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008D20 RID: 36128
			private static readonly IntPtr NativeFieldInfoPtr_effectIndex;

			// Token: 0x04008D21 RID: 36129
			private static readonly IntPtr NativeFieldInfoPtr_newEffects;

			// Token: 0x04008D22 RID: 36130
			private static readonly IntPtr NativeFieldInfoPtr_allGet;

			// Token: 0x04008D23 RID: 36131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D24 RID: 36132
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__0_Internal_Void_AStarInputGeneratorComponent_0;
		}

		// Token: 0x02000BCA RID: 3018
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass30_1")]
		public sealed class __c__DisplayClass30_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DC56 RID: 56406 RVA: 0x00356C50 File Offset: 0x00354E50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_1()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass30_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass30_1.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr, "character");
				Spell_Seija.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Seija.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr, 100679721);
				Spell_Seija.__c__DisplayClass30_1.NativeMethodInfoPtr__GetEffectDisplayer_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr, 100679722);
			}

			// Token: 0x0600DC57 RID: 56407 RVA: 0x00356CCC File Offset: 0x00354ECC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC58 RID: 56408 RVA: 0x00356D08 File Offset: 0x00354F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204233, XrefRangeEnd = 204246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__1(GameObject effect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass30_1.NativeMethodInfoPtr__GetEffectDisplayer_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC59 RID: 56409 RVA: 0x00075B92 File Offset: 0x00073D92
			public __c__DisplayClass30_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A1 RID: 18337
			// (get) Token: 0x0600DC5A RID: 56410 RVA: 0x00356D4C File Offset: 0x00354F4C
			// (set) Token: 0x0600DC5B RID: 56411 RVA: 0x00075B9B File Offset: 0x00073D9B
			public unsafe AStarInputGeneratorComponent character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_1.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_1.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A2 RID: 18338
			// (get) Token: 0x0600DC5C RID: 56412 RVA: 0x00356D7C File Offset: 0x00354F7C
			// (set) Token: 0x0600DC5D RID: 56413 RVA: 0x00075BBA File Offset: 0x00073DBA
			public unsafe Spell_Seija.__c__DisplayClass30_0 field_Public___c__DisplayClass30_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seija.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D25 RID: 36133
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04008D26 RID: 36134
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0;

			// Token: 0x04008D27 RID: 36135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D28 RID: 36136
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000BCB RID: 3019
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass30_2")]
		public sealed class __c__DisplayClass30_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DC5E RID: 56414 RVA: 0x00356DAC File Offset: 0x00354FAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_2()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass30_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_2>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass30_2.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_2>.NativeClassPtr, "effect");
				Spell_Seija.__c__DisplayClass30_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_2>.NativeClassPtr, 100679723);
				Spell_Seija.__c__DisplayClass30_2.NativeMethodInfoPtr__GetEffectDisplayer_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_2>.NativeClassPtr, 100679724);
			}

			// Token: 0x0600DC5F RID: 56415 RVA: 0x00356E14 File Offset: 0x00355014
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass30_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass30_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC60 RID: 56416 RVA: 0x00356E50 File Offset: 0x00355050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204246, XrefRangeEnd = 204250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass30_2.NativeMethodInfoPtr__GetEffectDisplayer_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC61 RID: 56417 RVA: 0x00075BD9 File Offset: 0x00073DD9
			public __c__DisplayClass30_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A3 RID: 18339
			// (get) Token: 0x0600DC62 RID: 56418 RVA: 0x00356E84 File Offset: 0x00355084
			// (set) Token: 0x0600DC63 RID: 56419 RVA: 0x00075BE2 File Offset: 0x00073DE2
			public unsafe GameObject effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_2.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass30_2.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D29 RID: 36137
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04008D2A RID: 36138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D2B RID: 36139
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__3_Internal_Void_0;
		}

		// Token: 0x02000BCC RID: 3020
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seija+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC64 RID: 56420 RVA: 0x00356EB4 File Offset: 0x003550B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seija>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr);
				Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, "count");
				Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, "<>9__0");
				Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, "<>9__1");
				Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, "<>9__2");
				Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, "<>9__3");
				Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, 100679725);
				Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, 100679726);
				Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, 100679727);
				Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, 100679728);
				Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr, 100679729);
			}

			// Token: 0x0600DC65 RID: 56421 RVA: 0x00356FA8 File Offset: 0x003551A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seija.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC66 RID: 56422 RVA: 0x00356FE4 File Offset: 0x003551E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__0(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC67 RID: 56423 RVA: 0x00357028 File Offset: 0x00355228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__1(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC68 RID: 56424 RVA: 0x0035706C File Offset: 0x0035526C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__2(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC69 RID: 56425 RVA: 0x003570B0 File Offset: 0x003552B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__3(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seija.__c__DisplayClass31_0.NativeMethodInfoPtr__RefreshDisplayer_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC6A RID: 56426 RVA: 0x00075C01 File Offset: 0x00073E01
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A4 RID: 18340
			// (get) Token: 0x0600DC6B RID: 56427 RVA: 0x003570F4 File Offset: 0x003552F4
			// (set) Token: 0x0600DC6C RID: 56428 RVA: 0x00075C0A File Offset: 0x00073E0A
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170047A5 RID: 18341
			// (get) Token: 0x0600DC6D RID: 56429 RVA: 0x0035711C File Offset: 0x0035531C
			// (set) Token: 0x0600DC6E RID: 56430 RVA: 0x00075C25 File Offset: 0x00073E25
			public unsafe Action<TextMeshProUGUI> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A6 RID: 18342
			// (get) Token: 0x0600DC6F RID: 56431 RVA: 0x0035714C File Offset: 0x0035534C
			// (set) Token: 0x0600DC70 RID: 56432 RVA: 0x00075C44 File Offset: 0x00073E44
			public unsafe Action<TextMeshProUGUI> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A7 RID: 18343
			// (get) Token: 0x0600DC71 RID: 56433 RVA: 0x0035717C File Offset: 0x0035537C
			// (set) Token: 0x0600DC72 RID: 56434 RVA: 0x00075C63 File Offset: 0x00073E63
			public unsafe Action<TextMeshProUGUI> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A8 RID: 18344
			// (get) Token: 0x0600DC73 RID: 56435 RVA: 0x003571AC File Offset: 0x003553AC
			// (set) Token: 0x0600DC74 RID: 56436 RVA: 0x00075C82 File Offset: 0x00073E82
			public unsafe Action<TextMeshProUGUI> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seija.__c__DisplayClass31_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D2C RID: 36140
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04008D2D RID: 36141
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008D2E RID: 36142
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04008D2F RID: 36143
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04008D30 RID: 36144
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04008D31 RID: 36145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D32 RID: 36146
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008D33 RID: 36147
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008D34 RID: 36148
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008D35 RID: 36149
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__3_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
