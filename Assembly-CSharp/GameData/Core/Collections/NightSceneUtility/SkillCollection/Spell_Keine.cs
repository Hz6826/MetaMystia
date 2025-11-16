using System;
using Common.CharacterUtility;
using Common.VFX;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000268 RID: 616
	public class Spell_Keine : SpellBase
	{
		// Token: 0x06004C56 RID: 19542 RVA: 0x001A6DBC File Offset: 0x001A4FBC
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Keine()
		{
			Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Keine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr);
			Spell_Keine.NativeFieldInfoPtr_stunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "stunDuration");
			Spell_Keine.NativeFieldInfoPtr_unlockInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "unlockInfoCount");
			Spell_Keine.NativeFieldInfoPtr_giveVeggiesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "giveVeggiesCount");
			Spell_Keine.NativeFieldInfoPtr_freeCookDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "freeCookDuration");
			Spell_Keine.NativeFieldInfoPtr_spawnNormalGuestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "spawnNormalGuestCount");
			Spell_Keine.NativeFieldInfoPtr_spawnNormalGuestDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "spawnNormalGuestDuration");
			Spell_Keine.NativeFieldInfoPtr_testUsetoControlSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "testUsetoControlSelection");
			Spell_Keine.NativeFieldInfoPtr_selectionEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "selectionEffect");
			Spell_Keine.NativeFieldInfoPtr_selectionObjectStartActivateDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "selectionObjectStartActivateDelay");
			Spell_Keine.NativeFieldInfoPtr_selectionObjectActivateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "selectionObjectActivateOffset");
			Spell_Keine.NativeFieldInfoPtr_selectionObjectStartSelectionDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "selectionObjectStartSelectionDelay");
			Spell_Keine.NativeFieldInfoPtr_objectSelectedEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectSelectedEffect");
			Spell_Keine.NativeFieldInfoPtr_objectSelectedTextEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectSelectedTextEffect");
			Spell_Keine.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "text");
			Spell_Keine.NativeFieldInfoPtr_objectSelectedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectSelectedDuration");
			Spell_Keine.NativeFieldInfoPtr_objectSelectedTextDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectSelectedTextDuration");
			Spell_Keine.NativeFieldInfoPtr_objectRemovedEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectRemovedEffect");
			Spell_Keine.NativeFieldInfoPtr_objectRemovedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectRemovedDuration");
			Spell_Keine.NativeFieldInfoPtr_selectionObjectEndDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "selectionObjectEndDelay");
			Spell_Keine.NativeFieldInfoPtr_magicFieldExpansionSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "magicFieldExpansionSFX");
			Spell_Keine.NativeFieldInfoPtr_objectSelectedSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectSelectedSFX");
			Spell_Keine.NativeFieldInfoPtr_removedSFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "removedSFXOffset");
			Spell_Keine.NativeFieldInfoPtr_objectRemovedSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "objectRemovedSFX");
			Spell_Keine.NativeFieldInfoPtr_magatamaEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "magatamaEffect");
			Spell_Keine.NativeFieldInfoPtr_specialGuestInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "specialGuestInfo");
			Spell_Keine.NativeFieldInfoPtr_magatamaEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "magatamaEffectDuration");
			Spell_Keine.NativeFieldInfoPtr_timeForInformationToDisappear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "timeForInformationToDisappear");
			Spell_Keine.NativeFieldInfoPtr_chainSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "chainSFX");
			Spell_Keine.NativeFieldInfoPtr_chainBreakSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "chainBreakSFX");
			Spell_Keine.NativeFieldInfoPtr_aquireSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "aquireSFX");
			Spell_Keine.NativeFieldInfoPtr_swordEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "swordEffect");
			Spell_Keine.NativeFieldInfoPtr_swordEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "swordEffectDuration");
			Spell_Keine.NativeFieldInfoPtr_swordEffectSpriteSwapOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "swordEffectSpriteSwapOffset");
			Spell_Keine.NativeFieldInfoPtr_swordSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "swordSFX");
			Spell_Keine.NativeFieldInfoPtr_swordTransformSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "swordTransformSFX");
			Spell_Keine.NativeFieldInfoPtr_itemGainSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "itemGainSFX");
			Spell_Keine.NativeFieldInfoPtr_mirrorEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "mirrorEffect");
			Spell_Keine.NativeFieldInfoPtr_mirrorStartWarmDownOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "mirrorStartWarmDownOffset");
			Spell_Keine.NativeFieldInfoPtr_mirrorWarmDownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "mirrorWarmDownDuration");
			Spell_Keine.NativeFieldInfoPtr_mirrorSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "mirrorSFX");
			Spell_Keine.NativeFieldInfoPtr_villageEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "villageEffect");
			Spell_Keine.NativeFieldInfoPtr_villageDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "villageDuration");
			Spell_Keine.NativeFieldInfoPtr_villageCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "villageCameraShakeAmplitude");
			Spell_Keine.NativeFieldInfoPtr_villageCameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "villageCameraShakeDuration");
			Spell_Keine.NativeFieldInfoPtr_villageCameraShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "villageCameraShakeFadeDuration");
			Spell_Keine.NativeFieldInfoPtr_bookSFXDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "bookSFXDelay");
			Spell_Keine.NativeFieldInfoPtr_bookSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "bookSFX");
			Spell_Keine.NativeFieldInfoPtr_itemGetSFXDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "itemGetSFXDelay");
			Spell_Keine.NativeFieldInfoPtr_itemGetSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "itemGetSFX");
			Spell_Keine.NativeFieldInfoPtr_eyeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "eyeEffect");
			Spell_Keine.NativeFieldInfoPtr_eyeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "eyeEffectDuration");
			Spell_Keine.NativeFieldInfoPtr_jumpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "jumpEffect");
			Spell_Keine.NativeFieldInfoPtr_jumpEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "jumpEffectDuration");
			Spell_Keine.NativeFieldInfoPtr_jumpEffectShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "jumpEffectShakeAmplitude");
			Spell_Keine.NativeFieldInfoPtr_jumpEffectShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "jumpEffectShakeFadeDuration");
			Spell_Keine.NativeFieldInfoPtr_characterJumpToWorldHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "characterJumpToWorldHeight");
			Spell_Keine.NativeFieldInfoPtr_characterJumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "characterJumpDuration");
			Spell_Keine.NativeFieldInfoPtr_characterTurnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "characterTurnDuration");
			Spell_Keine.NativeFieldInfoPtr_nuclearEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "nuclearEffect");
			Spell_Keine.NativeFieldInfoPtr_nuclearEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "nuclearEffectDuration");
			Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "nuclearEffectShakeAmplitude");
			Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "nuclearEffectShakeDuration");
			Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "nuclearEffectShakeFadeDuration");
			Spell_Keine.NativeFieldInfoPtr_stunEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "stunEffect");
			Spell_Keine.NativeFieldInfoPtr_afterJumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "afterJumpHeight");
			Spell_Keine.NativeFieldInfoPtr_afterJumpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "afterJumpSpeed");
			Spell_Keine.NativeFieldInfoPtr_afterJumpRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "afterJumpRotationSpeed");
			Spell_Keine.NativeFieldInfoPtr_specialFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "specialFace");
			Spell_Keine.NativeFieldInfoPtr_warningSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "warningSFX");
			Spell_Keine.NativeFieldInfoPtr_launchSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "launchSFX");
			Spell_Keine.NativeFieldInfoPtr_inAirSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "inAirSFX");
			Spell_Keine.NativeFieldInfoPtr_impactSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "impactSFX");
			Spell_Keine.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678661);
			Spell_Keine.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678662);
			Spell_Keine.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678663);
			Spell_Keine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678664);
			Spell_Keine.NativeMethodInfoPtr_Method_Internal_Static_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678665);
			Spell_Keine.NativeMethodInfoPtr_Method_Internal_Static_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678666);
			Spell_Keine.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, 100678667);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x001A7418 File Offset: 0x001A5618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197649, XrefRangeEnd = 197651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Keine.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x001A745C File Offset: 0x001A565C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197651, XrefRangeEnd = 197657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Keine.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x001A74B8 File Offset: 0x001A56B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197657, XrefRangeEnd = 197663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Keine.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x001A7514 File Offset: 0x001A5714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Keine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x001A7550 File Offset: 0x001A5750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197663, XrefRangeEnd = 197664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.NativeMethodInfoPtr_Method_Internal_Static_Vector3_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x001A7580 File Offset: 0x001A5780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197664, XrefRangeEnd = 197667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject Method_Internal_Static_GameObject_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.NativeMethodInfoPtr_Method_Internal_Static_GameObject_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x001A75B4 File Offset: 0x001A57B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197667, XrefRangeEnd = 197699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Int32_PDM_0(int specGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x000276CE File Offset: 0x000258CE
		public Spell_Keine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06004C5F RID: 19551 RVA: 0x001A75F4 File Offset: 0x001A57F4
		// (set) Token: 0x06004C60 RID: 19552 RVA: 0x000276D7 File Offset: 0x000258D7
		public unsafe int stunDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_stunDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_stunDuration)) = value;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x001A761C File Offset: 0x001A581C
		// (set) Token: 0x06004C62 RID: 19554 RVA: 0x000276F2 File Offset: 0x000258F2
		public unsafe int unlockInfoCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_unlockInfoCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_unlockInfoCount)) = value;
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x001A7644 File Offset: 0x001A5844
		// (set) Token: 0x06004C64 RID: 19556 RVA: 0x0002770D File Offset: 0x0002590D
		public unsafe int giveVeggiesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_giveVeggiesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_giveVeggiesCount)) = value;
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x001A766C File Offset: 0x001A586C
		// (set) Token: 0x06004C66 RID: 19558 RVA: 0x00027728 File Offset: 0x00025928
		public unsafe int freeCookDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_freeCookDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_freeCookDuration)) = value;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x001A7694 File Offset: 0x001A5894
		// (set) Token: 0x06004C68 RID: 19560 RVA: 0x00027743 File Offset: 0x00025943
		public unsafe int spawnNormalGuestCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_spawnNormalGuestCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_spawnNormalGuestCount)) = value;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06004C69 RID: 19561 RVA: 0x001A76BC File Offset: 0x001A58BC
		// (set) Token: 0x06004C6A RID: 19562 RVA: 0x0002775E File Offset: 0x0002595E
		public unsafe int spawnNormalGuestDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_spawnNormalGuestDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_spawnNormalGuestDuration)) = value;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06004C6B RID: 19563 RVA: 0x001A76E4 File Offset: 0x001A58E4
		// (set) Token: 0x06004C6C RID: 19564 RVA: 0x00027779 File Offset: 0x00025979
		public unsafe int testUsetoControlSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_testUsetoControlSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_testUsetoControlSelection)) = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x001A770C File Offset: 0x001A590C
		// (set) Token: 0x06004C6E RID: 19566 RVA: 0x00027794 File Offset: 0x00025994
		public unsafe GameObject selectionEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x001A773C File Offset: 0x001A593C
		// (set) Token: 0x06004C70 RID: 19568 RVA: 0x000277B3 File Offset: 0x000259B3
		public unsafe float selectionObjectStartActivateDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectStartActivateDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectStartActivateDelay)) = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x001A7764 File Offset: 0x001A5964
		// (set) Token: 0x06004C72 RID: 19570 RVA: 0x000277CE File Offset: 0x000259CE
		public unsafe float selectionObjectActivateOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectActivateOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectActivateOffset)) = value;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x001A778C File Offset: 0x001A598C
		// (set) Token: 0x06004C74 RID: 19572 RVA: 0x000277E9 File Offset: 0x000259E9
		public unsafe float selectionObjectStartSelectionDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectStartSelectionDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectStartSelectionDelay)) = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x001A77B4 File Offset: 0x001A59B4
		// (set) Token: 0x06004C76 RID: 19574 RVA: 0x00027804 File Offset: 0x00025A04
		public unsafe GameObject objectSelectedEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x001A77E4 File Offset: 0x001A59E4
		// (set) Token: 0x06004C78 RID: 19576 RVA: 0x00027823 File Offset: 0x00025A23
		public unsafe GameObject objectSelectedTextEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedTextEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedTextEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x001A7814 File Offset: 0x001A5A14
		// (set) Token: 0x06004C7A RID: 19578 RVA: 0x00027842 File Offset: 0x00025A42
		public unsafe Il2CppReferenceArray<Sprite> text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x001A7844 File Offset: 0x001A5A44
		// (set) Token: 0x06004C7C RID: 19580 RVA: 0x00027861 File Offset: 0x00025A61
		public unsafe float objectSelectedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedDuration)) = value;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x001A786C File Offset: 0x001A5A6C
		// (set) Token: 0x06004C7E RID: 19582 RVA: 0x0002787C File Offset: 0x00025A7C
		public unsafe float objectSelectedTextDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedTextDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedTextDuration)) = value;
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x001A7894 File Offset: 0x001A5A94
		// (set) Token: 0x06004C80 RID: 19584 RVA: 0x00027897 File Offset: 0x00025A97
		public unsafe GameObject objectRemovedEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectRemovedEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectRemovedEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x001A78C4 File Offset: 0x001A5AC4
		// (set) Token: 0x06004C82 RID: 19586 RVA: 0x000278B6 File Offset: 0x00025AB6
		public unsafe float objectRemovedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectRemovedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectRemovedDuration)) = value;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x001A78EC File Offset: 0x001A5AEC
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x000278D1 File Offset: 0x00025AD1
		public unsafe float selectionObjectEndDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectEndDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_selectionObjectEndDelay)) = value;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x001A7914 File Offset: 0x001A5B14
		// (set) Token: 0x06004C86 RID: 19590 RVA: 0x000278EC File Offset: 0x00025AEC
		public unsafe AudioClip magicFieldExpansionSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_magicFieldExpansionSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_magicFieldExpansionSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x001A7944 File Offset: 0x001A5B44
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x0002790B File Offset: 0x00025B0B
		public unsafe AudioClip objectSelectedSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectSelectedSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x001A7974 File Offset: 0x001A5B74
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x0002792A File Offset: 0x00025B2A
		public unsafe float removedSFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_removedSFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_removedSFXOffset)) = value;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06004C8B RID: 19595 RVA: 0x001A799C File Offset: 0x001A5B9C
		// (set) Token: 0x06004C8C RID: 19596 RVA: 0x00027945 File Offset: 0x00025B45
		public unsafe AudioClip objectRemovedSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectRemovedSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_objectRemovedSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06004C8D RID: 19597 RVA: 0x001A79CC File Offset: 0x001A5BCC
		// (set) Token: 0x06004C8E RID: 19598 RVA: 0x00027964 File Offset: 0x00025B64
		public unsafe GameObject magatamaEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_magatamaEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_magatamaEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x001A79FC File Offset: 0x001A5BFC
		// (set) Token: 0x06004C90 RID: 19600 RVA: 0x00027983 File Offset: 0x00025B83
		public unsafe GameObject specialGuestInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_specialGuestInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_specialGuestInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x001A7A2C File Offset: 0x001A5C2C
		// (set) Token: 0x06004C92 RID: 19602 RVA: 0x000279A2 File Offset: 0x00025BA2
		public unsafe float magatamaEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_magatamaEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_magatamaEffectDuration)) = value;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x001A7A54 File Offset: 0x001A5C54
		// (set) Token: 0x06004C94 RID: 19604 RVA: 0x000279BD File Offset: 0x00025BBD
		public unsafe float timeForInformationToDisappear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_timeForInformationToDisappear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_timeForInformationToDisappear)) = value;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x001A7A7C File Offset: 0x001A5C7C
		// (set) Token: 0x06004C96 RID: 19606 RVA: 0x000279D8 File Offset: 0x00025BD8
		public unsafe AudioClip chainSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_chainSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_chainSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06004C97 RID: 19607 RVA: 0x001A7AAC File Offset: 0x001A5CAC
		// (set) Token: 0x06004C98 RID: 19608 RVA: 0x000279F7 File Offset: 0x00025BF7
		public unsafe AudioClip chainBreakSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_chainBreakSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_chainBreakSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x001A7ADC File Offset: 0x001A5CDC
		// (set) Token: 0x06004C9A RID: 19610 RVA: 0x00027A16 File Offset: 0x00025C16
		public unsafe AudioClip aquireSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_aquireSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_aquireSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06004C9B RID: 19611 RVA: 0x001A7B0C File Offset: 0x001A5D0C
		// (set) Token: 0x06004C9C RID: 19612 RVA: 0x00027A35 File Offset: 0x00025C35
		public unsafe GameObject swordEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06004C9D RID: 19613 RVA: 0x001A7B3C File Offset: 0x001A5D3C
		// (set) Token: 0x06004C9E RID: 19614 RVA: 0x00027A54 File Offset: 0x00025C54
		public unsafe float swordEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordEffectDuration)) = value;
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x001A7B64 File Offset: 0x001A5D64
		// (set) Token: 0x06004CA0 RID: 19616 RVA: 0x00027A6F File Offset: 0x00025C6F
		public unsafe float swordEffectSpriteSwapOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordEffectSpriteSwapOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordEffectSpriteSwapOffset)) = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x001A7B8C File Offset: 0x001A5D8C
		// (set) Token: 0x06004CA2 RID: 19618 RVA: 0x00027A8A File Offset: 0x00025C8A
		public unsafe AudioClip swordSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x001A7BBC File Offset: 0x001A5DBC
		// (set) Token: 0x06004CA4 RID: 19620 RVA: 0x00027AA9 File Offset: 0x00025CA9
		public unsafe AudioClip swordTransformSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordTransformSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_swordTransformSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x001A7BEC File Offset: 0x001A5DEC
		// (set) Token: 0x06004CA6 RID: 19622 RVA: 0x00027AC8 File Offset: 0x00025CC8
		public unsafe AudioClip itemGainSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_itemGainSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_itemGainSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06004CA7 RID: 19623 RVA: 0x001A7C1C File Offset: 0x001A5E1C
		// (set) Token: 0x06004CA8 RID: 19624 RVA: 0x00027AE7 File Offset: 0x00025CE7
		public unsafe GameObject mirrorEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x001A7C4C File Offset: 0x001A5E4C
		// (set) Token: 0x06004CAA RID: 19626 RVA: 0x00027B06 File Offset: 0x00025D06
		public unsafe float mirrorStartWarmDownOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorStartWarmDownOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorStartWarmDownOffset)) = value;
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x001A7C74 File Offset: 0x001A5E74
		// (set) Token: 0x06004CAC RID: 19628 RVA: 0x00027B21 File Offset: 0x00025D21
		public unsafe float mirrorWarmDownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorWarmDownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorWarmDownDuration)) = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x001A7C9C File Offset: 0x001A5E9C
		// (set) Token: 0x06004CAE RID: 19630 RVA: 0x00027B3C File Offset: 0x00025D3C
		public unsafe AudioClip mirrorSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_mirrorSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06004CAF RID: 19631 RVA: 0x001A7CCC File Offset: 0x001A5ECC
		// (set) Token: 0x06004CB0 RID: 19632 RVA: 0x00027B5B File Offset: 0x00025D5B
		public unsafe GameObject villageEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x001A7CFC File Offset: 0x001A5EFC
		// (set) Token: 0x06004CB2 RID: 19634 RVA: 0x00027B7A File Offset: 0x00025D7A
		public unsafe float villageDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageDuration)) = value;
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x001A7D24 File Offset: 0x001A5F24
		// (set) Token: 0x06004CB4 RID: 19636 RVA: 0x00027B95 File Offset: 0x00025D95
		public unsafe float villageCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x001A7D4C File Offset: 0x001A5F4C
		// (set) Token: 0x06004CB6 RID: 19638 RVA: 0x00027BB0 File Offset: 0x00025DB0
		public unsafe float villageCameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageCameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageCameraShakeDuration)) = value;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x001A7D74 File Offset: 0x001A5F74
		// (set) Token: 0x06004CB8 RID: 19640 RVA: 0x00027BCB File Offset: 0x00025DCB
		public unsafe float villageCameraShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageCameraShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_villageCameraShakeFadeDuration)) = value;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06004CB9 RID: 19641 RVA: 0x001A7D9C File Offset: 0x001A5F9C
		// (set) Token: 0x06004CBA RID: 19642 RVA: 0x00027BE6 File Offset: 0x00025DE6
		public unsafe float bookSFXDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_bookSFXDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_bookSFXDelay)) = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x001A7DC4 File Offset: 0x001A5FC4
		// (set) Token: 0x06004CBC RID: 19644 RVA: 0x00027C01 File Offset: 0x00025E01
		public unsafe AudioClip bookSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_bookSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_bookSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06004CBD RID: 19645 RVA: 0x001A7DF4 File Offset: 0x001A5FF4
		// (set) Token: 0x06004CBE RID: 19646 RVA: 0x00027C20 File Offset: 0x00025E20
		public unsafe float itemGetSFXDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_itemGetSFXDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_itemGetSFXDelay)) = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x001A7E1C File Offset: 0x001A601C
		// (set) Token: 0x06004CC0 RID: 19648 RVA: 0x00027C3B File Offset: 0x00025E3B
		public unsafe AudioClip itemGetSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_itemGetSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_itemGetSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x001A7E4C File Offset: 0x001A604C
		// (set) Token: 0x06004CC2 RID: 19650 RVA: 0x00027C5A File Offset: 0x00025E5A
		public unsafe GameObject eyeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_eyeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_eyeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x001A7E7C File Offset: 0x001A607C
		// (set) Token: 0x06004CC4 RID: 19652 RVA: 0x00027C79 File Offset: 0x00025E79
		public unsafe float eyeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_eyeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_eyeEffectDuration)) = value;
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x001A7EA4 File Offset: 0x001A60A4
		// (set) Token: 0x06004CC6 RID: 19654 RVA: 0x00027C94 File Offset: 0x00025E94
		public unsafe GameObject jumpEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06004CC7 RID: 19655 RVA: 0x001A7ED4 File Offset: 0x001A60D4
		// (set) Token: 0x06004CC8 RID: 19656 RVA: 0x00027CB3 File Offset: 0x00025EB3
		public unsafe float jumpEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffectDuration)) = value;
			}
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06004CC9 RID: 19657 RVA: 0x001A7EFC File Offset: 0x001A60FC
		// (set) Token: 0x06004CCA RID: 19658 RVA: 0x00027CCE File Offset: 0x00025ECE
		public unsafe float jumpEffectShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffectShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffectShakeAmplitude)) = value;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06004CCB RID: 19659 RVA: 0x001A7F24 File Offset: 0x001A6124
		// (set) Token: 0x06004CCC RID: 19660 RVA: 0x00027CE9 File Offset: 0x00025EE9
		public unsafe float jumpEffectShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffectShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_jumpEffectShakeFadeDuration)) = value;
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x001A7F4C File Offset: 0x001A614C
		// (set) Token: 0x06004CCE RID: 19662 RVA: 0x00027D04 File Offset: 0x00025F04
		public unsafe float characterJumpToWorldHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_characterJumpToWorldHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_characterJumpToWorldHeight)) = value;
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06004CCF RID: 19663 RVA: 0x001A7F74 File Offset: 0x001A6174
		// (set) Token: 0x06004CD0 RID: 19664 RVA: 0x00027D1F File Offset: 0x00025F1F
		public unsafe float characterJumpDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_characterJumpDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_characterJumpDuration)) = value;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x001A7F9C File Offset: 0x001A619C
		// (set) Token: 0x06004CD2 RID: 19666 RVA: 0x00027D3A File Offset: 0x00025F3A
		public unsafe float characterTurnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_characterTurnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_characterTurnDuration)) = value;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06004CD3 RID: 19667 RVA: 0x001A7FC4 File Offset: 0x001A61C4
		// (set) Token: 0x06004CD4 RID: 19668 RVA: 0x00027D55 File Offset: 0x00025F55
		public unsafe GameObject nuclearEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x001A7FF4 File Offset: 0x001A61F4
		// (set) Token: 0x06004CD6 RID: 19670 RVA: 0x00027D74 File Offset: 0x00025F74
		public unsafe float nuclearEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectDuration)) = value;
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x001A801C File Offset: 0x001A621C
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00027D8F File Offset: 0x00025F8F
		public unsafe float nuclearEffectShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeAmplitude)) = value;
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x001A8044 File Offset: 0x001A6244
		// (set) Token: 0x06004CDA RID: 19674 RVA: 0x00027DAA File Offset: 0x00025FAA
		public unsafe float nuclearEffectShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeDuration)) = value;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x001A806C File Offset: 0x001A626C
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x00027DC5 File Offset: 0x00025FC5
		public unsafe float nuclearEffectShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_nuclearEffectShakeFadeDuration)) = value;
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x001A8094 File Offset: 0x001A6294
		// (set) Token: 0x06004CDE RID: 19678 RVA: 0x00027DE0 File Offset: 0x00025FE0
		public unsafe GameObject stunEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_stunEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_stunEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x001A80C4 File Offset: 0x001A62C4
		// (set) Token: 0x06004CE0 RID: 19680 RVA: 0x00027DFF File Offset: 0x00025FFF
		public unsafe float afterJumpHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_afterJumpHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_afterJumpHeight)) = value;
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x001A80EC File Offset: 0x001A62EC
		// (set) Token: 0x06004CE2 RID: 19682 RVA: 0x00027E1A File Offset: 0x0002601A
		public unsafe float afterJumpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_afterJumpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_afterJumpSpeed)) = value;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x001A8114 File Offset: 0x001A6314
		// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x00027E35 File Offset: 0x00026035
		public unsafe float afterJumpRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_afterJumpRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_afterJumpRotationSpeed)) = value;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x001A813C File Offset: 0x001A633C
		// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x00027E50 File Offset: 0x00026050
		public unsafe Sprite specialFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_specialFace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_specialFace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x001A816C File Offset: 0x001A636C
		// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x00027E6F File Offset: 0x0002606F
		public unsafe LoopedBGMPackage warningSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_warningSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_warningSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x001A819C File Offset: 0x001A639C
		// (set) Token: 0x06004CEA RID: 19690 RVA: 0x00027E8E File Offset: 0x0002608E
		public unsafe AudioClip launchSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_launchSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_launchSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x001A81CC File Offset: 0x001A63CC
		// (set) Token: 0x06004CEC RID: 19692 RVA: 0x00027EAD File Offset: 0x000260AD
		public unsafe LoopedBGMPackage inAirSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_inAirSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_inAirSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x001A81FC File Offset: 0x001A63FC
		// (set) Token: 0x06004CEE RID: 19694 RVA: 0x00027ECC File Offset: 0x000260CC
		public unsafe AudioClip impactSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_impactSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.NativeFieldInfoPtr_impactSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003441 RID: 13377
		private static readonly IntPtr NativeFieldInfoPtr_stunDuration;

		// Token: 0x04003442 RID: 13378
		private static readonly IntPtr NativeFieldInfoPtr_unlockInfoCount;

		// Token: 0x04003443 RID: 13379
		private static readonly IntPtr NativeFieldInfoPtr_giveVeggiesCount;

		// Token: 0x04003444 RID: 13380
		private static readonly IntPtr NativeFieldInfoPtr_freeCookDuration;

		// Token: 0x04003445 RID: 13381
		private static readonly IntPtr NativeFieldInfoPtr_spawnNormalGuestCount;

		// Token: 0x04003446 RID: 13382
		private static readonly IntPtr NativeFieldInfoPtr_spawnNormalGuestDuration;

		// Token: 0x04003447 RID: 13383
		private static readonly IntPtr NativeFieldInfoPtr_testUsetoControlSelection;

		// Token: 0x04003448 RID: 13384
		private static readonly IntPtr NativeFieldInfoPtr_selectionEffect;

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeFieldInfoPtr_selectionObjectStartActivateDelay;

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeFieldInfoPtr_selectionObjectActivateOffset;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeFieldInfoPtr_selectionObjectStartSelectionDelay;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeFieldInfoPtr_objectSelectedEffect;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeFieldInfoPtr_objectSelectedTextEffect;

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeFieldInfoPtr_objectSelectedDuration;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeFieldInfoPtr_objectSelectedTextDuration;

		// Token: 0x04003451 RID: 13393
		private static readonly IntPtr NativeFieldInfoPtr_objectRemovedEffect;

		// Token: 0x04003452 RID: 13394
		private static readonly IntPtr NativeFieldInfoPtr_objectRemovedDuration;

		// Token: 0x04003453 RID: 13395
		private static readonly IntPtr NativeFieldInfoPtr_selectionObjectEndDelay;

		// Token: 0x04003454 RID: 13396
		private static readonly IntPtr NativeFieldInfoPtr_magicFieldExpansionSFX;

		// Token: 0x04003455 RID: 13397
		private static readonly IntPtr NativeFieldInfoPtr_objectSelectedSFX;

		// Token: 0x04003456 RID: 13398
		private static readonly IntPtr NativeFieldInfoPtr_removedSFXOffset;

		// Token: 0x04003457 RID: 13399
		private static readonly IntPtr NativeFieldInfoPtr_objectRemovedSFX;

		// Token: 0x04003458 RID: 13400
		private static readonly IntPtr NativeFieldInfoPtr_magatamaEffect;

		// Token: 0x04003459 RID: 13401
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestInfo;

		// Token: 0x0400345A RID: 13402
		private static readonly IntPtr NativeFieldInfoPtr_magatamaEffectDuration;

		// Token: 0x0400345B RID: 13403
		private static readonly IntPtr NativeFieldInfoPtr_timeForInformationToDisappear;

		// Token: 0x0400345C RID: 13404
		private static readonly IntPtr NativeFieldInfoPtr_chainSFX;

		// Token: 0x0400345D RID: 13405
		private static readonly IntPtr NativeFieldInfoPtr_chainBreakSFX;

		// Token: 0x0400345E RID: 13406
		private static readonly IntPtr NativeFieldInfoPtr_aquireSFX;

		// Token: 0x0400345F RID: 13407
		private static readonly IntPtr NativeFieldInfoPtr_swordEffect;

		// Token: 0x04003460 RID: 13408
		private static readonly IntPtr NativeFieldInfoPtr_swordEffectDuration;

		// Token: 0x04003461 RID: 13409
		private static readonly IntPtr NativeFieldInfoPtr_swordEffectSpriteSwapOffset;

		// Token: 0x04003462 RID: 13410
		private static readonly IntPtr NativeFieldInfoPtr_swordSFX;

		// Token: 0x04003463 RID: 13411
		private static readonly IntPtr NativeFieldInfoPtr_swordTransformSFX;

		// Token: 0x04003464 RID: 13412
		private static readonly IntPtr NativeFieldInfoPtr_itemGainSFX;

		// Token: 0x04003465 RID: 13413
		private static readonly IntPtr NativeFieldInfoPtr_mirrorEffect;

		// Token: 0x04003466 RID: 13414
		private static readonly IntPtr NativeFieldInfoPtr_mirrorStartWarmDownOffset;

		// Token: 0x04003467 RID: 13415
		private static readonly IntPtr NativeFieldInfoPtr_mirrorWarmDownDuration;

		// Token: 0x04003468 RID: 13416
		private static readonly IntPtr NativeFieldInfoPtr_mirrorSFX;

		// Token: 0x04003469 RID: 13417
		private static readonly IntPtr NativeFieldInfoPtr_villageEffect;

		// Token: 0x0400346A RID: 13418
		private static readonly IntPtr NativeFieldInfoPtr_villageDuration;

		// Token: 0x0400346B RID: 13419
		private static readonly IntPtr NativeFieldInfoPtr_villageCameraShakeAmplitude;

		// Token: 0x0400346C RID: 13420
		private static readonly IntPtr NativeFieldInfoPtr_villageCameraShakeDuration;

		// Token: 0x0400346D RID: 13421
		private static readonly IntPtr NativeFieldInfoPtr_villageCameraShakeFadeDuration;

		// Token: 0x0400346E RID: 13422
		private static readonly IntPtr NativeFieldInfoPtr_bookSFXDelay;

		// Token: 0x0400346F RID: 13423
		private static readonly IntPtr NativeFieldInfoPtr_bookSFX;

		// Token: 0x04003470 RID: 13424
		private static readonly IntPtr NativeFieldInfoPtr_itemGetSFXDelay;

		// Token: 0x04003471 RID: 13425
		private static readonly IntPtr NativeFieldInfoPtr_itemGetSFX;

		// Token: 0x04003472 RID: 13426
		private static readonly IntPtr NativeFieldInfoPtr_eyeEffect;

		// Token: 0x04003473 RID: 13427
		private static readonly IntPtr NativeFieldInfoPtr_eyeEffectDuration;

		// Token: 0x04003474 RID: 13428
		private static readonly IntPtr NativeFieldInfoPtr_jumpEffect;

		// Token: 0x04003475 RID: 13429
		private static readonly IntPtr NativeFieldInfoPtr_jumpEffectDuration;

		// Token: 0x04003476 RID: 13430
		private static readonly IntPtr NativeFieldInfoPtr_jumpEffectShakeAmplitude;

		// Token: 0x04003477 RID: 13431
		private static readonly IntPtr NativeFieldInfoPtr_jumpEffectShakeFadeDuration;

		// Token: 0x04003478 RID: 13432
		private static readonly IntPtr NativeFieldInfoPtr_characterJumpToWorldHeight;

		// Token: 0x04003479 RID: 13433
		private static readonly IntPtr NativeFieldInfoPtr_characterJumpDuration;

		// Token: 0x0400347A RID: 13434
		private static readonly IntPtr NativeFieldInfoPtr_characterTurnDuration;

		// Token: 0x0400347B RID: 13435
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffect;

		// Token: 0x0400347C RID: 13436
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffectDuration;

		// Token: 0x0400347D RID: 13437
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffectShakeAmplitude;

		// Token: 0x0400347E RID: 13438
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffectShakeDuration;

		// Token: 0x0400347F RID: 13439
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffectShakeFadeDuration;

		// Token: 0x04003480 RID: 13440
		private static readonly IntPtr NativeFieldInfoPtr_stunEffect;

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeFieldInfoPtr_afterJumpHeight;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeFieldInfoPtr_afterJumpSpeed;

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeFieldInfoPtr_afterJumpRotationSpeed;

		// Token: 0x04003484 RID: 13444
		private static readonly IntPtr NativeFieldInfoPtr_specialFace;

		// Token: 0x04003485 RID: 13445
		private static readonly IntPtr NativeFieldInfoPtr_warningSFX;

		// Token: 0x04003486 RID: 13446
		private static readonly IntPtr NativeFieldInfoPtr_launchSFX;

		// Token: 0x04003487 RID: 13447
		private static readonly IntPtr NativeFieldInfoPtr_inAirSFX;

		// Token: 0x04003488 RID: 13448
		private static readonly IntPtr NativeFieldInfoPtr_impactSFX;

		// Token: 0x04003489 RID: 13449
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400348A RID: 13450
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400348B RID: 13451
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400348C RID: 13452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400348D RID: 13453
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_PDM_0;

		// Token: 0x0400348E RID: 13454
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_GameObject_PDM_0;

		// Token: 0x0400348F RID: 13455
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_PDM_0;

		// Token: 0x02000B2C RID: 2860
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3C3 RID: 54211 RVA: 0x0033D0EC File Offset: 0x0033B2EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr);
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "<>4__this");
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "character");
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterJumpTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "characterJumpTargetPosition");
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_stunEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "stunEffect");
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterControllerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "characterControllerUnit");
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_oldFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "oldFace");
				Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, "characterStartPosition");
				Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, 100678668);
				Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, 100678669);
				Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, 100678670);
				Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, 100678671);
				Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, 100678672);
				Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr, 100678673);
			}

			// Token: 0x0600D3C4 RID: 54212 RVA: 0x0033D21C File Offset: 0x0033B41C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C5 RID: 54213 RVA: 0x0033D258 File Offset: 0x0033B458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196761, XrefRangeEnd = 196766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C6 RID: 54214 RVA: 0x0033D29C File Offset: 0x0033B49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196766, XrefRangeEnd = 196771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C7 RID: 54215 RVA: 0x0033D2E0 File Offset: 0x0033B4E0
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3C8 RID: 54216 RVA: 0x0033D31C File Offset: 0x0033B51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196771, XrefRangeEnd = 196782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C9 RID: 54217 RVA: 0x0033D350 File Offset: 0x0033B550
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass73_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3CA RID: 54218 RVA: 0x00071659 File Offset: 0x0006F859
			public __c__DisplayClass73_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E9 RID: 17641
			// (get) Token: 0x0600D3CB RID: 54219 RVA: 0x0033D38C File Offset: 0x0033B58C
			// (set) Token: 0x0600D3CC RID: 54220 RVA: 0x00071662 File Offset: 0x0006F862
			public unsafe Spell_Keine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EA RID: 17642
			// (get) Token: 0x0600D3CD RID: 54221 RVA: 0x0033D3BC File Offset: 0x0033B5BC
			// (set) Token: 0x0600D3CE RID: 54222 RVA: 0x00071681 File Offset: 0x0006F881
			public unsafe AStarInputGeneratorComponent character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EB RID: 17643
			// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x0033D3EC File Offset: 0x0033B5EC
			// (set) Token: 0x0600D3D0 RID: 54224 RVA: 0x000716A0 File Offset: 0x0006F8A0
			public unsafe Vector3 characterJumpTargetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterJumpTargetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterJumpTargetPosition)) = value;
				}
			}

			// Token: 0x170044EC RID: 17644
			// (get) Token: 0x0600D3D1 RID: 54225 RVA: 0x0033D414 File Offset: 0x0033B614
			// (set) Token: 0x0600D3D2 RID: 54226 RVA: 0x000716BB File Offset: 0x0006F8BB
			public unsafe DisplayProgress stunEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_stunEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayProgress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_stunEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044ED RID: 17645
			// (get) Token: 0x0600D3D3 RID: 54227 RVA: 0x0033D444 File Offset: 0x0033B644
			// (set) Token: 0x0600D3D4 RID: 54228 RVA: 0x000716DA File Offset: 0x0006F8DA
			public unsafe CharacterControllerUnit characterControllerUnit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterControllerUnit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterControllerUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EE RID: 17646
			// (get) Token: 0x0600D3D5 RID: 54229 RVA: 0x0033D474 File Offset: 0x0033B674
			// (set) Token: 0x0600D3D6 RID: 54230 RVA: 0x000716F9 File Offset: 0x0006F8F9
			public unsafe Sprite oldFace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_oldFace);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_oldFace), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EF RID: 17647
			// (get) Token: 0x0600D3D7 RID: 54231 RVA: 0x0033D4A4 File Offset: 0x0033B6A4
			// (set) Token: 0x0600D3D8 RID: 54232 RVA: 0x00071718 File Offset: 0x0006F918
			public unsafe Vector3 characterStartPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterStartPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass73_0.NativeFieldInfoPtr_characterStartPosition)) = value;
				}
			}

			// Token: 0x040087F1 RID: 34801
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087F2 RID: 34802
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x040087F3 RID: 34803
			private static readonly IntPtr NativeFieldInfoPtr_characterJumpTargetPosition;

			// Token: 0x040087F4 RID: 34804
			private static readonly IntPtr NativeFieldInfoPtr_stunEffect;

			// Token: 0x040087F5 RID: 34805
			private static readonly IntPtr NativeFieldInfoPtr_characterControllerUnit;

			// Token: 0x040087F6 RID: 34806
			private static readonly IntPtr NativeFieldInfoPtr_oldFace;

			// Token: 0x040087F7 RID: 34807
			private static readonly IntPtr NativeFieldInfoPtr_characterStartPosition;

			// Token: 0x040087F8 RID: 34808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087F9 RID: 34809
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x040087FA RID: 34810
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0;

			// Token: 0x040087FB RID: 34811
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Vector3_0;

			// Token: 0x040087FC RID: 34812
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0;

			// Token: 0x040087FD RID: 34813
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0;
		}

		// Token: 0x02000B2D RID: 2861
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D3D9 RID: 54233 RVA: 0x0033D4CC File Offset: 0x0033B6CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr);
				Spell_Keine.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9");
				Spell_Keine.__c.NativeFieldInfoPtr___9__73_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__73_4");
				Spell_Keine.__c.NativeFieldInfoPtr___9__74_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__74_0");
				Spell_Keine.__c.NativeFieldInfoPtr___9__74_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__74_16");
				Spell_Keine.__c.NativeFieldInfoPtr___9__74_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__74_24");
				Spell_Keine.__c.NativeFieldInfoPtr___9__74_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__74_25");
				Spell_Keine.__c.NativeFieldInfoPtr___9__74_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__74_11");
				Spell_Keine.__c.NativeFieldInfoPtr___9__74_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, "<>9__74_12");
				Spell_Keine.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678675);
				Spell_Keine.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__73_4_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678676);
				Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_0_Internal_Animator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678677);
				Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_16_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678678);
				Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_24_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678679);
				Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_25_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678680);
				Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_11_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678681);
				Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_12_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr, 100678682);
			}

			// Token: 0x0600D3DA RID: 54234 RVA: 0x0033D638 File Offset: 0x0033B838
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3DB RID: 54235 RVA: 0x0033D674 File Offset: 0x0033B874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196782, XrefRangeEnd = 196785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__73_4(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__73_4_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3DC RID: 54236 RVA: 0x0033D6B8 File Offset: 0x0033B8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196785, XrefRangeEnd = 196789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Animator _OnPositiveBuffExecute_b__74_0(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_0_Internal_Animator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}

			// Token: 0x0600D3DD RID: 54237 RVA: 0x0033D708 File Offset: 0x0033B908
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__74_16(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_16_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3DE RID: 54238 RVA: 0x0033D74C File Offset: 0x0033B94C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196789, XrefRangeEnd = 196794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__74_24(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_24_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3DF RID: 54239 RVA: 0x0033D798 File Offset: 0x0033B998
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__74_25(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_25_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3E0 RID: 54240 RVA: 0x0033D7E4 File Offset: 0x0033B9E4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__74_11(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_11_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E1 RID: 54241 RVA: 0x0033D828 File Offset: 0x0033BA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196794, XrefRangeEnd = 196801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__74_12(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_12_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E2 RID: 54242 RVA: 0x00071733 File Offset: 0x0006F933
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F0 RID: 17648
			// (get) Token: 0x0600D3E3 RID: 54243 RVA: 0x0033D86C File Offset: 0x0033BA6C
			// (set) Token: 0x0600D3E4 RID: 54244 RVA: 0x0007173C File Offset: 0x0006F93C
			public unsafe static Spell_Keine.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F1 RID: 17649
			// (get) Token: 0x0600D3E5 RID: 54245 RVA: 0x0033D894 File Offset: 0x0033BA94
			// (set) Token: 0x0600D3E6 RID: 54246 RVA: 0x0007174E File Offset: 0x0006F94E
			public unsafe static Action<GameObject> __9__73_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__73_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__73_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F2 RID: 17650
			// (get) Token: 0x0600D3E7 RID: 54247 RVA: 0x0033D8BC File Offset: 0x0033BABC
			// (set) Token: 0x0600D3E8 RID: 54248 RVA: 0x00071760 File Offset: 0x0006F960
			public unsafe static Func<Transform, Animator> __9__74_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, Animator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F3 RID: 17651
			// (get) Token: 0x0600D3E9 RID: 54249 RVA: 0x0033D8E4 File Offset: 0x0033BAE4
			// (set) Token: 0x0600D3EA RID: 54250 RVA: 0x00071772 File Offset: 0x0006F972
			public unsafe static Action<GameObject> __9__74_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F4 RID: 17652
			// (get) Token: 0x0600D3EB RID: 54251 RVA: 0x0033D90C File Offset: 0x0033BB0C
			// (set) Token: 0x0600D3EC RID: 54252 RVA: 0x00071784 File Offset: 0x0006F984
			public unsafe static Func<int, bool> __9__74_24
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_24, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_24, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F5 RID: 17653
			// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x0033D934 File Offset: 0x0033BB34
			// (set) Token: 0x0600D3EE RID: 54254 RVA: 0x00071796 File Offset: 0x0006F996
			public unsafe static Func<int, int> __9__74_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F6 RID: 17654
			// (get) Token: 0x0600D3EF RID: 54255 RVA: 0x0033D95C File Offset: 0x0033BB5C
			// (set) Token: 0x0600D3F0 RID: 54256 RVA: 0x000717A8 File Offset: 0x0006F9A8
			public unsafe static Action<GameObject> __9__74_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F7 RID: 17655
			// (get) Token: 0x0600D3F1 RID: 54257 RVA: 0x0033D984 File Offset: 0x0033BB84
			// (set) Token: 0x0600D3F2 RID: 54258 RVA: 0x000717BA File Offset: 0x0006F9BA
			public unsafe static Action<AchievementNotifyResult> __9__74_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Keine.__c.NativeFieldInfoPtr___9__74_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087FE RID: 34814
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087FF RID: 34815
			private static readonly IntPtr NativeFieldInfoPtr___9__73_4;

			// Token: 0x04008800 RID: 34816
			private static readonly IntPtr NativeFieldInfoPtr___9__74_0;

			// Token: 0x04008801 RID: 34817
			private static readonly IntPtr NativeFieldInfoPtr___9__74_16;

			// Token: 0x04008802 RID: 34818
			private static readonly IntPtr NativeFieldInfoPtr___9__74_24;

			// Token: 0x04008803 RID: 34819
			private static readonly IntPtr NativeFieldInfoPtr___9__74_25;

			// Token: 0x04008804 RID: 34820
			private static readonly IntPtr NativeFieldInfoPtr___9__74_11;

			// Token: 0x04008805 RID: 34821
			private static readonly IntPtr NativeFieldInfoPtr___9__74_12;

			// Token: 0x04008806 RID: 34822
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008807 RID: 34823
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__73_4_Internal_Void_GameObject_0;

			// Token: 0x04008808 RID: 34824
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_0_Internal_Animator_Transform_0;

			// Token: 0x04008809 RID: 34825
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_16_Internal_Void_GameObject_0;

			// Token: 0x0400880A RID: 34826
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_24_Internal_Boolean_Int32_0;

			// Token: 0x0400880B RID: 34827
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_25_Internal_Int32_Int32_0;

			// Token: 0x0400880C RID: 34828
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_11_Internal_Void_GameObject_0;

			// Token: 0x0400880D RID: 34829
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__74_12_Internal_Void_AchievementNotifyResult_0;
		}

		// Token: 0x02000B2E RID: 2862
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<OnNegativeBuffExecute>d__73")]
		public sealed class _OnNegativeBuffExecute_d__73 : Il2CppSystem.Object
		{
			// Token: 0x0600D3F3 RID: 54259 RVA: 0x0033D9AC File Offset: 0x0033BBAC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__73()
			{
				Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<OnNegativeBuffExecute>d__73");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr);
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, "<>1__state");
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, "<>2__current");
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, "<>4__this");
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, "spellExecutionContext");
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, "<>8__1");
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr__isInPlayerLeft_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, "<isInPlayerLeft>5__2");
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, 100678683);
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, 100678684);
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, 100678685);
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, 100678686);
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, 100678687);
				Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr, 100678688);
			}

			// Token: 0x0600D3F4 RID: 54260 RVA: 0x0033DAC8 File Offset: 0x0033BCC8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__73(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine._OnNegativeBuffExecute_d__73>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3F5 RID: 54261 RVA: 0x0033DB10 File Offset: 0x0033BD10
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3F6 RID: 54262 RVA: 0x0033DB44 File Offset: 0x0033BD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196801, XrefRangeEnd = 196983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044FE RID: 17662
			// (get) Token: 0x0600D3F7 RID: 54263 RVA: 0x0033DB80 File Offset: 0x0033BD80
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3F8 RID: 54264 RVA: 0x0033DBC0 File Offset: 0x0033BDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196983, XrefRangeEnd = 196989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044FF RID: 17663
			// (get) Token: 0x0600D3F9 RID: 54265 RVA: 0x0033DBF4 File Offset: 0x0033BDF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnNegativeBuffExecute_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3FA RID: 54266 RVA: 0x000717CC File Offset: 0x0006F9CC
			public _OnNegativeBuffExecute_d__73(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F8 RID: 17656
			// (get) Token: 0x0600D3FB RID: 54267 RVA: 0x0033DC34 File Offset: 0x0033BE34
			// (set) Token: 0x0600D3FC RID: 54268 RVA: 0x000717D5 File Offset: 0x0006F9D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044F9 RID: 17657
			// (get) Token: 0x0600D3FD RID: 54269 RVA: 0x0033DC5C File Offset: 0x0033BE5C
			// (set) Token: 0x0600D3FE RID: 54270 RVA: 0x000717F0 File Offset: 0x0006F9F0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FA RID: 17658
			// (get) Token: 0x0600D3FF RID: 54271 RVA: 0x0033DC8C File Offset: 0x0033BE8C
			// (set) Token: 0x0600D400 RID: 54272 RVA: 0x0007180F File Offset: 0x0006FA0F
			public unsafe Spell_Keine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FB RID: 17659
			// (get) Token: 0x0600D401 RID: 54273 RVA: 0x0033DCBC File Offset: 0x0033BEBC
			// (set) Token: 0x0600D402 RID: 54274 RVA: 0x0007182E File Offset: 0x0006FA2E
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FC RID: 17660
			// (get) Token: 0x0600D403 RID: 54275 RVA: 0x0033DCEC File Offset: 0x0033BEEC
			// (set) Token: 0x0600D404 RID: 54276 RVA: 0x0007184D File Offset: 0x0006FA4D
			public unsafe Spell_Keine.__c__DisplayClass73_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass73_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FD RID: 17661
			// (get) Token: 0x0600D405 RID: 54277 RVA: 0x0033DD1C File Offset: 0x0033BF1C
			// (set) Token: 0x0600D406 RID: 54278 RVA: 0x0007186C File Offset: 0x0006FA6C
			public unsafe int _isInPlayerLeft_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr__isInPlayerLeft_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnNegativeBuffExecute_d__73.NativeFieldInfoPtr__isInPlayerLeft_5__2)) = value;
				}
			}

			// Token: 0x0400880E RID: 34830
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400880F RID: 34831
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008810 RID: 34832
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008811 RID: 34833
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008812 RID: 34834
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008813 RID: 34835
			private static readonly IntPtr NativeFieldInfoPtr__isInPlayerLeft_5__2;

			// Token: 0x04008814 RID: 34836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008815 RID: 34837
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008816 RID: 34838
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008817 RID: 34839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008818 RID: 34840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008819 RID: 34841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B2F RID: 2863
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D407 RID: 54279 RVA: 0x0033DD44 File Offset: 0x0033BF44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr);
				Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "<>4__this");
				Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr_selectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "selectedIndex");
				Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "<>9__4");
				Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "<>9__5");
				Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "<>9__6");
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678689);
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678690);
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678691);
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678692);
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678693);
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678694);
				Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr_Method_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, 100678695);
			}

			// Token: 0x0600D408 RID: 54280 RVA: 0x0033DE74 File Offset: 0x0033C074
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D409 RID: 54281 RVA: 0x0033DEB0 File Offset: 0x0033C0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197012, XrefRangeEnd = 197038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D40A RID: 54282 RVA: 0x0033DEF4 File Offset: 0x0033C0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197038, XrefRangeEnd = 197041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__4(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D40B RID: 54283 RVA: 0x0033DF38 File Offset: 0x0033C138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__5(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D40C RID: 54284 RVA: 0x0033DF7C File Offset: 0x0033C17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__6(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D40D RID: 54285 RVA: 0x0033DFC0 File Offset: 0x0033C1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197041, XrefRangeEnd = 197046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D40E RID: 54286 RVA: 0x0033E000 File Offset: 0x0033C200
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 197133, RefRangeEnd = 197134, XrefRangeStart = 197046, XrefRangeEnd = 197133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.NativeMethodInfoPtr_Method_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D40F RID: 54287 RVA: 0x00071887 File Offset: 0x0006FA87
			public __c__DisplayClass74_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004500 RID: 17664
			// (get) Token: 0x0600D410 RID: 54288 RVA: 0x0033E03C File Offset: 0x0033C23C
			// (set) Token: 0x0600D411 RID: 54289 RVA: 0x00071890 File Offset: 0x0006FA90
			public unsafe Spell_Keine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004501 RID: 17665
			// (get) Token: 0x0600D412 RID: 54290 RVA: 0x0033E06C File Offset: 0x0033C26C
			// (set) Token: 0x0600D413 RID: 54291 RVA: 0x000718AF File Offset: 0x0006FAAF
			public unsafe int selectedIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr_selectedIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr_selectedIndex)) = value;
				}
			}

			// Token: 0x17004502 RID: 17666
			// (get) Token: 0x0600D414 RID: 54292 RVA: 0x0033E094 File Offset: 0x0033C294
			// (set) Token: 0x0600D415 RID: 54293 RVA: 0x000718CA File Offset: 0x0006FACA
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004503 RID: 17667
			// (get) Token: 0x0600D416 RID: 54294 RVA: 0x0033E0C4 File Offset: 0x0033C2C4
			// (set) Token: 0x0600D417 RID: 54295 RVA: 0x000718E9 File Offset: 0x0006FAE9
			public unsafe Action<SpriteRenderer> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004504 RID: 17668
			// (get) Token: 0x0600D418 RID: 54296 RVA: 0x0033E0F4 File Offset: 0x0033C2F4
			// (set) Token: 0x0600D419 RID: 54297 RVA: 0x00071908 File Offset: 0x0006FB08
			public unsafe Action<SpriteRenderer> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004505 RID: 17669
			// (get) Token: 0x0600D41A RID: 54298 RVA: 0x0033E124 File Offset: 0x0033C324
			// (set) Token: 0x0600D41B RID: 54299 RVA: 0x00071927 File Offset: 0x0006FB27
			public unsafe Action<SpriteRenderer> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400881A RID: 34842
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400881B RID: 34843
			private static readonly IntPtr NativeFieldInfoPtr_selectedIndex;

			// Token: 0x0400881C RID: 34844
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400881D RID: 34845
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x0400881E RID: 34846
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x0400881F RID: 34847
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04008820 RID: 34848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008821 RID: 34849
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0;

			// Token: 0x04008822 RID: 34850
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008823 RID: 34851
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008824 RID: 34852
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008825 RID: 34853
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008826 RID: 34854
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_0;

			// Token: 0x02001029 RID: 4137
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_0+<<OnPositiveBuffExecute>g__Effect_1|9>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011B3C RID: 72508 RVA: 0x0040E504 File Offset: 0x0040C704
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Effect_1|9>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678696);
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678697);
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678698);
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678699);
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678700);
					Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678701);
				}

				// Token: 0x06011B3D RID: 72509 RVA: 0x0040E5E4 File Offset: 0x0040C7E4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B3E RID: 72510 RVA: 0x0040E62C File Offset: 0x0040C82C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B3F RID: 72511 RVA: 0x0040E660 File Offset: 0x0040C860
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196989, XrefRangeEnd = 197006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C23 RID: 23587
				// (get) Token: 0x06011B40 RID: 72512 RVA: 0x0040E69C File Offset: 0x0040C89C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B41 RID: 72513 RVA: 0x0040E6DC File Offset: 0x0040C8DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197006, XrefRangeEnd = 197012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C24 RID: 23588
				// (get) Token: 0x06011B42 RID: 72514 RVA: 0x0040E710 File Offset: 0x0040C910
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B43 RID: 72515 RVA: 0x00099E4B File Offset: 0x0009804B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C20 RID: 23584
				// (get) Token: 0x06011B44 RID: 72516 RVA: 0x0040E750 File Offset: 0x0040C950
				// (set) Token: 0x06011B45 RID: 72517 RVA: 0x00099E54 File Offset: 0x00098054
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C21 RID: 23585
				// (get) Token: 0x06011B46 RID: 72518 RVA: 0x0040E778 File Offset: 0x0040C978
				// (set) Token: 0x06011B47 RID: 72519 RVA: 0x00099E6F File Offset: 0x0009806F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C22 RID: 23586
				// (get) Token: 0x06011B48 RID: 72520 RVA: 0x0040E7A8 File Offset: 0x0040C9A8
				// (set) Token: 0x06011B49 RID: 72521 RVA: 0x00099E8E File Offset: 0x0009808E
				public unsafe Spell_Keine.__c__DisplayClass74_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass74_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2F1 RID: 45809
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2F2 RID: 45810
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2F3 RID: 45811
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2F4 RID: 45812
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2F5 RID: 45813
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2F6 RID: 45814
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2F7 RID: 45815
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2F8 RID: 45816
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2F9 RID: 45817
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B30 RID: 2864
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_1")]
		public sealed class __c__DisplayClass74_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D41C RID: 54300 RVA: 0x0033E154 File Offset: 0x0033C354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_1()
			{
				Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c__DisplayClass74_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr);
				Spell_Keine.__c__DisplayClass74_1.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr, "animator");
				Spell_Keine.__c__DisplayClass74_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr, 100678702);
				Spell_Keine.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr, 100678703);
				Spell_Keine.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr, 100678704);
			}

			// Token: 0x0600D41D RID: 54301 RVA: 0x0033E1D0 File Offset: 0x0033C3D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41E RID: 54302 RVA: 0x0033E20C File Offset: 0x0033C40C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197134, XrefRangeEnd = 197138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41F RID: 54303 RVA: 0x0033E250 File Offset: 0x0033C450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D420 RID: 54304 RVA: 0x00071946 File Offset: 0x0006FB46
			public __c__DisplayClass74_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004506 RID: 17670
			// (get) Token: 0x0600D421 RID: 54305 RVA: 0x0033E294 File Offset: 0x0033C494
			// (set) Token: 0x0600D422 RID: 54306 RVA: 0x0007194F File Offset: 0x0006FB4F
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_1.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_1.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008827 RID: 34855
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x04008828 RID: 34856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008829 RID: 34857
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0;

			// Token: 0x0400882A RID: 34858
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B31 RID: 2865
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_2")]
		public sealed class __c__DisplayClass74_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D423 RID: 54307 RVA: 0x0033E2C4 File Offset: 0x0033C4C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_2()
			{
				Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c__DisplayClass74_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr);
				Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_effectQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, "effectQueue");
				Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, "effect");
				Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, "visual");
				Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_field_Public___c__DisplayClass74_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678705);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678706);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678707);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678708);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678709);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678710);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__29_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678711);
				Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, 100678712);
			}

			// Token: 0x0600D424 RID: 54308 RVA: 0x0033E3E0 File Offset: 0x0033C5E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D425 RID: 54309 RVA: 0x0033E41C File Offset: 0x0033C61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197216, XrefRangeEnd = 197224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D426 RID: 54310 RVA: 0x0033E45C File Offset: 0x0033C65C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197224, XrefRangeEnd = 197231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D427 RID: 54311 RVA: 0x0033E490 File Offset: 0x0033C690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197231, XrefRangeEnd = 197236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D428 RID: 54312 RVA: 0x0033E4D0 File Offset: 0x0033C6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197236, XrefRangeEnd = 197241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D429 RID: 54313 RVA: 0x0033E510 File Offset: 0x0033C710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197241, XrefRangeEnd = 197244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__28(SpriteRenderer ax)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D42A RID: 54314 RVA: 0x0033E554 File Offset: 0x0033C754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197244, XrefRangeEnd = 197247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__29(SpriteRenderer yx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(yx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__29_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D42B RID: 54315 RVA: 0x0033E598 File Offset: 0x0033C798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197247, XrefRangeEnd = 197254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__14(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D42C RID: 54316 RVA: 0x0007196E File Offset: 0x0006FB6E
			public __c__DisplayClass74_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004507 RID: 17671
			// (get) Token: 0x0600D42D RID: 54317 RVA: 0x0033E5DC File Offset: 0x0033C7DC
			// (set) Token: 0x0600D42E RID: 54318 RVA: 0x00071977 File Offset: 0x0006FB77
			public unsafe Queue<ParticleSystem> effectQueue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_effectQueue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_effectQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004508 RID: 17672
			// (get) Token: 0x0600D42F RID: 54319 RVA: 0x0033E60C File Offset: 0x0033C80C
			// (set) Token: 0x0600D430 RID: 54320 RVA: 0x00071996 File Offset: 0x0006FB96
			public unsafe UIElementCluster effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004509 RID: 17673
			// (get) Token: 0x0600D431 RID: 54321 RVA: 0x0033E63C File Offset: 0x0033C83C
			// (set) Token: 0x0600D432 RID: 54322 RVA: 0x000719B5 File Offset: 0x0006FBB5
			public unsafe Il2CppReferenceArray<ObjectLanguageBase> visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectLanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450A RID: 17674
			// (get) Token: 0x0600D433 RID: 54323 RVA: 0x0033E66C File Offset: 0x0033C86C
			// (set) Token: 0x0600D434 RID: 54324 RVA: 0x000719D4 File Offset: 0x0006FBD4
			public unsafe Spell_Keine.__c__DisplayClass74_0 field_Public___c__DisplayClass74_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_field_Public___c__DisplayClass74_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass74_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.NativeFieldInfoPtr_field_Public___c__DisplayClass74_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400882B RID: 34859
			private static readonly IntPtr NativeFieldInfoPtr_effectQueue;

			// Token: 0x0400882C RID: 34860
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x0400882D RID: 34861
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x0400882E RID: 34862
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass74_0_0;

			// Token: 0x0400882F RID: 34863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008830 RID: 34864
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_Int32_0;

			// Token: 0x04008831 RID: 34865
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008832 RID: 34866
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008833 RID: 34867
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04008834 RID: 34868
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008835 RID: 34869
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__29_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008836 RID: 34870
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_GameObject_0;

			// Token: 0x0200102A RID: 4138
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_2+<<OnPositiveBuffExecute>g__Del|15>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011B4A RID: 72522 RVA: 0x0040E7D8 File Offset: 0x0040C9D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Del|15>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100678713);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100678714);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100678715);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100678716);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100678717);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100678718);
				}

				// Token: 0x06011B4B RID: 72523 RVA: 0x0040E8B8 File Offset: 0x0040CAB8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B4C RID: 72524 RVA: 0x0040E900 File Offset: 0x0040CB00
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B4D RID: 72525 RVA: 0x0040E934 File Offset: 0x0040CB34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197138, XrefRangeEnd = 197181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C28 RID: 23592
				// (get) Token: 0x06011B4E RID: 72526 RVA: 0x0040E970 File Offset: 0x0040CB70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B4F RID: 72527 RVA: 0x0040E9B0 File Offset: 0x0040CBB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197181, XrefRangeEnd = 197187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C29 RID: 23593
				// (get) Token: 0x06011B50 RID: 72528 RVA: 0x0040E9E4 File Offset: 0x0040CBE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B51 RID: 72529 RVA: 0x00099EAD File Offset: 0x000980AD
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C25 RID: 23589
				// (get) Token: 0x06011B52 RID: 72530 RVA: 0x0040EA24 File Offset: 0x0040CC24
				// (set) Token: 0x06011B53 RID: 72531 RVA: 0x00099EB6 File Offset: 0x000980B6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C26 RID: 23590
				// (get) Token: 0x06011B54 RID: 72532 RVA: 0x0040EA4C File Offset: 0x0040CC4C
				// (set) Token: 0x06011B55 RID: 72533 RVA: 0x00099ED1 File Offset: 0x000980D1
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C27 RID: 23591
				// (get) Token: 0x06011B56 RID: 72534 RVA: 0x0040EA7C File Offset: 0x0040CC7C
				// (set) Token: 0x06011B57 RID: 72535 RVA: 0x00099EF0 File Offset: 0x000980F0
				public unsafe Spell_Keine.__c__DisplayClass74_2 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass74_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2FA RID: 45818
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2FB RID: 45819
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2FC RID: 45820
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2FD RID: 45821
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2FE RID: 45822
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2FF RID: 45823
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B300 RID: 45824
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B301 RID: 45825
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B302 RID: 45826
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200102B RID: 4139
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_2+<<OnPositiveBuffExecute>g__Delay|13>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011B58 RID: 72536 RVA: 0x0040EAAC File Offset: 0x0040CCAC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Delay|13>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100678719);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100678720);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100678721);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100678722);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100678723);
					Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100678724);
				}

				// Token: 0x06011B59 RID: 72537 RVA: 0x0040EB8C File Offset: 0x0040CD8C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B5A RID: 72538 RVA: 0x0040EBD4 File Offset: 0x0040CDD4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B5B RID: 72539 RVA: 0x0040EC08 File Offset: 0x0040CE08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197187, XrefRangeEnd = 197210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C2D RID: 23597
				// (get) Token: 0x06011B5C RID: 72540 RVA: 0x0040EC44 File Offset: 0x0040CE44
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B5D RID: 72541 RVA: 0x0040EC84 File Offset: 0x0040CE84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197210, XrefRangeEnd = 197216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C2E RID: 23598
				// (get) Token: 0x06011B5E RID: 72542 RVA: 0x0040ECB8 File Offset: 0x0040CEB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B5F RID: 72543 RVA: 0x00099F0F File Offset: 0x0009810F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C2A RID: 23594
				// (get) Token: 0x06011B60 RID: 72544 RVA: 0x0040ECF8 File Offset: 0x0040CEF8
				// (set) Token: 0x06011B61 RID: 72545 RVA: 0x00099F18 File Offset: 0x00098118
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C2B RID: 23595
				// (get) Token: 0x06011B62 RID: 72546 RVA: 0x0040ED20 File Offset: 0x0040CF20
				// (set) Token: 0x06011B63 RID: 72547 RVA: 0x00099F33 File Offset: 0x00098133
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C2C RID: 23596
				// (get) Token: 0x06011B64 RID: 72548 RVA: 0x0040ED50 File Offset: 0x0040CF50
				// (set) Token: 0x06011B65 RID: 72549 RVA: 0x00099F52 File Offset: 0x00098152
				public unsafe Spell_Keine.__c__DisplayClass74_2 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass74_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B303 RID: 45827
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B304 RID: 45828
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B305 RID: 45829
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B306 RID: 45830
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B307 RID: 45831
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B308 RID: 45832
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B309 RID: 45833
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B30A RID: 45834
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B30B RID: 45835
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B32 RID: 2866
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_3")]
		public sealed class __c__DisplayClass74_3 : Il2CppSystem.Object
		{
			// Token: 0x0600D435 RID: 54325 RVA: 0x0033E69C File Offset: 0x0033C89C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_3()
			{
				Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c__DisplayClass74_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr);
				Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_specialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, "specialGuest");
				Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, "colorScheme");
				Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, "pixel");
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678725);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678726);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__18_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678727);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678728);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678729);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678730);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__22_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678731);
				Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr, 100678732);
			}

			// Token: 0x0600D436 RID: 54326 RVA: 0x0033E7A4 File Offset: 0x0033C9A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D437 RID: 54327 RVA: 0x0033E7E0 File Offset: 0x0033C9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__17(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D438 RID: 54328 RVA: 0x0033E824 File Offset: 0x0033CA24
			[CallerCount(0)]
			public unsafe void _OnPositiveBuffExecute_b__18(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__18_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D439 RID: 54329 RVA: 0x0033E868 File Offset: 0x0033CA68
			[CallerCount(0)]
			public unsafe void _OnPositiveBuffExecute_b__19(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D43A RID: 54330 RVA: 0x0033E8AC File Offset: 0x0033CAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__20(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D43B RID: 54331 RVA: 0x0033E8F0 File Offset: 0x0033CAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__21(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D43C RID: 54332 RVA: 0x0033E934 File Offset: 0x0033CB34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__22(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__22_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D43D RID: 54333 RVA: 0x0033E978 File Offset: 0x0033CB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__23(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D43E RID: 54334 RVA: 0x000719F3 File Offset: 0x0006FBF3
			public __c__DisplayClass74_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450B RID: 17675
			// (get) Token: 0x0600D43F RID: 54335 RVA: 0x0033E9BC File Offset: 0x0033CBBC
			// (set) Token: 0x0600D440 RID: 54336 RVA: 0x000719FC File Offset: 0x0006FBFC
			public unsafe SpecialGuest specialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_specialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_specialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450C RID: 17676
			// (get) Token: 0x0600D441 RID: 54337 RVA: 0x0033E9EC File Offset: 0x0033CBEC
			// (set) Token: 0x0600D442 RID: 54338 RVA: 0x00071A1B File Offset: 0x0006FC1B
			public unsafe Il2CppStructArray<Color> colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_colorScheme);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_colorScheme), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450D RID: 17677
			// (get) Token: 0x0600D443 RID: 54339 RVA: 0x0033EA1C File Offset: 0x0033CC1C
			// (set) Token: 0x0600D444 RID: 54340 RVA: 0x00071A3A File Offset: 0x0006FC3A
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_3.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008837 RID: 34871
			private static readonly IntPtr NativeFieldInfoPtr_specialGuest;

			// Token: 0x04008838 RID: 34872
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x04008839 RID: 34873
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400883A RID: 34874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400883B RID: 34875
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400883C RID: 34876
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__18_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400883D RID: 34877
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_Internal_Void_Image_0;

			// Token: 0x0400883E RID: 34878
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_Internal_Void_Image_0;

			// Token: 0x0400883F RID: 34879
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_Internal_Void_Image_0;

			// Token: 0x04008840 RID: 34880
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__22_Internal_Void_Image_0;

			// Token: 0x04008841 RID: 34881
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_Internal_Void_Image_0;
		}

		// Token: 0x02000B33 RID: 2867
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<>c__DisplayClass74_4")]
		public sealed class __c__DisplayClass74_4 : Il2CppSystem.Object
		{
			// Token: 0x0600D445 RID: 54341 RVA: 0x0033EA4C File Offset: 0x0033CC4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_4()
			{
				Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<>c__DisplayClass74_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr);
				Spell_Keine.__c__DisplayClass74_4.NativeFieldInfoPtr_maxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr, "maxAmount");
				Spell_Keine.__c__DisplayClass74_4.NativeFieldInfoPtr___9__27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr, "<>9__27");
				Spell_Keine.__c__DisplayClass74_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr, 100678733);
				Spell_Keine.__c__DisplayClass74_4.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr, 100678734);
			}

			// Token: 0x0600D446 RID: 54342 RVA: 0x0033EAC8 File Offset: 0x0033CCC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine.__c__DisplayClass74_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D447 RID: 54343 RVA: 0x0033EB04 File Offset: 0x0033CD04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197254, XrefRangeEnd = 197255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__27(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine.__c__DisplayClass74_4.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D448 RID: 54344 RVA: 0x00071A59 File Offset: 0x0006FC59
			public __c__DisplayClass74_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450E RID: 17678
			// (get) Token: 0x0600D449 RID: 54345 RVA: 0x0033EB58 File Offset: 0x0033CD58
			// (set) Token: 0x0600D44A RID: 54346 RVA: 0x00071A62 File Offset: 0x0006FC62
			public unsafe int maxAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_4.NativeFieldInfoPtr_maxAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_4.NativeFieldInfoPtr_maxAmount)) = value;
				}
			}

			// Token: 0x1700450F RID: 17679
			// (get) Token: 0x0600D44B RID: 54347 RVA: 0x0033EB80 File Offset: 0x0033CD80
			// (set) Token: 0x0600D44C RID: 54348 RVA: 0x00071A7D File Offset: 0x0006FC7D
			public unsafe Func<KeyValuePair<int, int>, bool> __9__27
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_4.NativeFieldInfoPtr___9__27);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine.__c__DisplayClass74_4.NativeFieldInfoPtr___9__27), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008842 RID: 34882
			private static readonly IntPtr NativeFieldInfoPtr_maxAmount;

			// Token: 0x04008843 RID: 34883
			private static readonly IntPtr NativeFieldInfoPtr___9__27;

			// Token: 0x04008844 RID: 34884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008845 RID: 34885
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000B34 RID: 2868
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Keine+<OnPositiveBuffExecute>d__74")]
		public sealed class _OnPositiveBuffExecute_d__74 : Il2CppSystem.Object
		{
			// Token: 0x0600D44D RID: 54349 RVA: 0x0033EBB0 File Offset: 0x0033CDB0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__74()
			{
				Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Keine>.NativeClassPtr, "<OnPositiveBuffExecute>d__74");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr);
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>1__state");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>2__current");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>4__this");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "spellExecutionContext");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>8__1");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>8__2");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__selectionInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<selectionInstance>5__2");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__allInstances_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<allInstances>5__3");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>7__wrap3");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<>7__wrap4");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__selection_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<selection>5__6");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__infoPrefab_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, "<infoPrefab>5__7");
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, 100678735);
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, 100678736);
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, 100678737);
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, 100678738);
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, 100678739);
				Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr, 100678740);
			}

			// Token: 0x0600D44E RID: 54350 RVA: 0x0033ED44 File Offset: 0x0033CF44
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__74(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Keine._OnPositiveBuffExecute_d__74>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D44F RID: 54351 RVA: 0x0033ED8C File Offset: 0x0033CF8C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D450 RID: 54352 RVA: 0x0033EDC0 File Offset: 0x0033CFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197255, XrefRangeEnd = 197643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700451C RID: 17692
			// (get) Token: 0x0600D451 RID: 54353 RVA: 0x0033EDFC File Offset: 0x0033CFFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D452 RID: 54354 RVA: 0x0033EE3C File Offset: 0x0033D03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197643, XrefRangeEnd = 197649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700451D RID: 17693
			// (get) Token: 0x0600D453 RID: 54355 RVA: 0x0033EE70 File Offset: 0x0033D070
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Keine._OnPositiveBuffExecute_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D454 RID: 54356 RVA: 0x00071A9C File Offset: 0x0006FC9C
			public _OnPositiveBuffExecute_d__74(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004510 RID: 17680
			// (get) Token: 0x0600D455 RID: 54357 RVA: 0x0033EEB0 File Offset: 0x0033D0B0
			// (set) Token: 0x0600D456 RID: 54358 RVA: 0x00071AA5 File Offset: 0x0006FCA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004511 RID: 17681
			// (get) Token: 0x0600D457 RID: 54359 RVA: 0x0033EED8 File Offset: 0x0033D0D8
			// (set) Token: 0x0600D458 RID: 54360 RVA: 0x00071AC0 File Offset: 0x0006FCC0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004512 RID: 17682
			// (get) Token: 0x0600D459 RID: 54361 RVA: 0x0033EF08 File Offset: 0x0033D108
			// (set) Token: 0x0600D45A RID: 54362 RVA: 0x00071ADF File Offset: 0x0006FCDF
			public unsafe Spell_Keine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004513 RID: 17683
			// (get) Token: 0x0600D45B RID: 54363 RVA: 0x0033EF38 File Offset: 0x0033D138
			// (set) Token: 0x0600D45C RID: 54364 RVA: 0x00071AFE File Offset: 0x0006FCFE
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004514 RID: 17684
			// (get) Token: 0x0600D45D RID: 54365 RVA: 0x0033EF68 File Offset: 0x0033D168
			// (set) Token: 0x0600D45E RID: 54366 RVA: 0x00071B1D File Offset: 0x0006FD1D
			public unsafe Spell_Keine.__c__DisplayClass74_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass74_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004515 RID: 17685
			// (get) Token: 0x0600D45F RID: 54367 RVA: 0x0033EF98 File Offset: 0x0033D198
			// (set) Token: 0x0600D460 RID: 54368 RVA: 0x00071B3C File Offset: 0x0006FD3C
			public unsafe Spell_Keine.__c__DisplayClass74_2 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Keine.__c__DisplayClass74_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004516 RID: 17686
			// (get) Token: 0x0600D461 RID: 54369 RVA: 0x0033EFC8 File Offset: 0x0033D1C8
			// (set) Token: 0x0600D462 RID: 54370 RVA: 0x00071B5B File Offset: 0x0006FD5B
			public unsafe UIElementCluster _selectionInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__selectionInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__selectionInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004517 RID: 17687
			// (get) Token: 0x0600D463 RID: 54371 RVA: 0x0033EFF8 File Offset: 0x0033D1F8
			// (set) Token: 0x0600D464 RID: 54372 RVA: 0x00071B7A File Offset: 0x0006FD7A
			public unsafe Il2CppReferenceArray<Animator> _allInstances_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__allInstances_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__allInstances_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004518 RID: 17688
			// (get) Token: 0x0600D465 RID: 54373 RVA: 0x0033F028 File Offset: 0x0033D228
			// (set) Token: 0x0600D466 RID: 54374 RVA: 0x00071B99 File Offset: 0x0006FD99
			public unsafe Il2CppReferenceArray<Animator> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004519 RID: 17689
			// (get) Token: 0x0600D467 RID: 54375 RVA: 0x0033F058 File Offset: 0x0033D258
			// (set) Token: 0x0600D468 RID: 54376 RVA: 0x00071BB8 File Offset: 0x0006FDB8
			public unsafe int __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___7__wrap4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr___7__wrap4)) = value;
				}
			}

			// Token: 0x1700451A RID: 17690
			// (get) Token: 0x0600D469 RID: 54377 RVA: 0x0033F080 File Offset: 0x0033D280
			// (set) Token: 0x0600D46A RID: 54378 RVA: 0x00071BD3 File Offset: 0x0006FDD3
			public EventManager.SelectedValue _selection_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__selection_5__6);
					return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__selection_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700451B RID: 17691
			// (get) Token: 0x0600D46B RID: 54379 RVA: 0x0033F0B0 File Offset: 0x0033D2B0
			// (set) Token: 0x0600D46C RID: 54380 RVA: 0x00071C01 File Offset: 0x0006FE01
			public unsafe GameObject _infoPrefab_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__infoPrefab_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Keine._OnPositiveBuffExecute_d__74.NativeFieldInfoPtr__infoPrefab_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008846 RID: 34886
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008847 RID: 34887
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008848 RID: 34888
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008849 RID: 34889
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400884A RID: 34890
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400884B RID: 34891
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x0400884C RID: 34892
			private static readonly IntPtr NativeFieldInfoPtr__selectionInstance_5__2;

			// Token: 0x0400884D RID: 34893
			private static readonly IntPtr NativeFieldInfoPtr__allInstances_5__3;

			// Token: 0x0400884E RID: 34894
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400884F RID: 34895
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04008850 RID: 34896
			private static readonly IntPtr NativeFieldInfoPtr__selection_5__6;

			// Token: 0x04008851 RID: 34897
			private static readonly IntPtr NativeFieldInfoPtr__infoPrefab_5__7;

			// Token: 0x04008852 RID: 34898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008853 RID: 34899
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008854 RID: 34900
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008855 RID: 34901
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008856 RID: 34902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008857 RID: 34903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
