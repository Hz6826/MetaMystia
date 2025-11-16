using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using TMPro;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000279 RID: 633
	public class Spell_Parsee : SpellBase
	{
		// Token: 0x06004F6E RID: 20334 RVA: 0x001AE670 File Offset: 0x001AC870
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Parsee()
		{
			Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Parsee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr);
			Spell_Parsee.NativeFieldInfoPtr_postiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "postiveDuration");
			Spell_Parsee.NativeFieldInfoPtr_partnerExtraWageMultiper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "partnerExtraWageMultiper");
			Spell_Parsee.NativeFieldInfoPtr_rewardObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "rewardObject");
			Spell_Parsee.NativeFieldInfoPtr_rewardParseeEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "rewardParseeEye");
			Spell_Parsee.NativeFieldInfoPtr_rewardFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "rewardFire");
			Spell_Parsee.NativeFieldInfoPtr_rewardUIMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "rewardUIMoney");
			Spell_Parsee.NativeFieldInfoPtr_flashDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "flashDuration");
			Spell_Parsee.NativeFieldInfoPtr_fireDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "fireDuration");
			Spell_Parsee.NativeFieldInfoPtr_uiDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "uiDuration");
			Spell_Parsee.NativeFieldInfoPtr_uiAnimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "uiAnimDuration");
			Spell_Parsee.NativeFieldInfoPtr_uiOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "uiOffset");
			Spell_Parsee.NativeFieldInfoPtr_flashOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "flashOffset");
			Spell_Parsee.NativeFieldInfoPtr_fireOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "fireOffset");
			Spell_Parsee.NativeFieldInfoPtr_punishmentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "punishmentObject");
			Spell_Parsee.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "rewardSFX");
			Spell_Parsee.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "punishmentSFX");
			Spell_Parsee.NativeFieldInfoPtr_punishmentSFX2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "punishmentSFX2");
			Spell_Parsee.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, 100679284);
			Spell_Parsee.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, 100679285);
			Spell_Parsee.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, 100679286);
			Spell_Parsee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, 100679287);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x001AE844 File Offset: 0x001ACA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201433, XrefRangeEnd = 201435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Parsee.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x001AE888 File Offset: 0x001ACA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201435, XrefRangeEnd = 201440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Parsee.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x001AE8E4 File Offset: 0x001ACAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201440, XrefRangeEnd = 201446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Parsee.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x001AE940 File Offset: 0x001ACB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Parsee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x00029CFE File Offset: 0x00027EFE
		public Spell_Parsee(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06004F74 RID: 20340 RVA: 0x001AE97C File Offset: 0x001ACB7C
		// (set) Token: 0x06004F75 RID: 20341 RVA: 0x00029D07 File Offset: 0x00027F07
		public unsafe int postiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_postiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_postiveDuration)) = value;
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x001AE9A4 File Offset: 0x001ACBA4
		// (set) Token: 0x06004F77 RID: 20343 RVA: 0x00029D22 File Offset: 0x00027F22
		public unsafe float partnerExtraWageMultiper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_partnerExtraWageMultiper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_partnerExtraWageMultiper)) = value;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x001AE9CC File Offset: 0x001ACBCC
		// (set) Token: 0x06004F79 RID: 20345 RVA: 0x00029D3D File Offset: 0x00027F3D
		public unsafe GameObject rewardObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x001AE9FC File Offset: 0x001ACBFC
		// (set) Token: 0x06004F7B RID: 20347 RVA: 0x00029D5C File Offset: 0x00027F5C
		public unsafe GameObject rewardParseeEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardParseeEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardParseeEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06004F7C RID: 20348 RVA: 0x001AEA2C File Offset: 0x001ACC2C
		// (set) Token: 0x06004F7D RID: 20349 RVA: 0x00029D7B File Offset: 0x00027F7B
		public unsafe GameObject rewardFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x001AEA5C File Offset: 0x001ACC5C
		// (set) Token: 0x06004F7F RID: 20351 RVA: 0x00029D9A File Offset: 0x00027F9A
		public unsafe GameObject rewardUIMoney
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardUIMoney);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardUIMoney), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x001AEA8C File Offset: 0x001ACC8C
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x00029DB9 File Offset: 0x00027FB9
		public unsafe float flashDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_flashDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_flashDuration)) = value;
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x001AEAB4 File Offset: 0x001ACCB4
		// (set) Token: 0x06004F83 RID: 20355 RVA: 0x00029DD4 File Offset: 0x00027FD4
		public unsafe float fireDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_fireDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_fireDuration)) = value;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x001AEADC File Offset: 0x001ACCDC
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x00029DEF File Offset: 0x00027FEF
		public unsafe float uiDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_uiDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_uiDuration)) = value;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x001AEB04 File Offset: 0x001ACD04
		// (set) Token: 0x06004F87 RID: 20359 RVA: 0x00029E0A File Offset: 0x0002800A
		public unsafe float uiAnimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_uiAnimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_uiAnimDuration)) = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x001AEB2C File Offset: 0x001ACD2C
		// (set) Token: 0x06004F89 RID: 20361 RVA: 0x00029E25 File Offset: 0x00028025
		public unsafe Vector2 uiOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_uiOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_uiOffset)) = value;
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x001AEB54 File Offset: 0x001ACD54
		// (set) Token: 0x06004F8B RID: 20363 RVA: 0x00029E40 File Offset: 0x00028040
		public unsafe Vector2 flashOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_flashOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_flashOffset)) = value;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x001AEB7C File Offset: 0x001ACD7C
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x00029E5B File Offset: 0x0002805B
		public unsafe Vector2 fireOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_fireOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_fireOffset)) = value;
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x001AEBA4 File Offset: 0x001ACDA4
		// (set) Token: 0x06004F8F RID: 20367 RVA: 0x00029E76 File Offset: 0x00028076
		public unsafe GameObject punishmentObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_punishmentObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_punishmentObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x001AEBD4 File Offset: 0x001ACDD4
		// (set) Token: 0x06004F91 RID: 20369 RVA: 0x00029E95 File Offset: 0x00028095
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x001AEC04 File Offset: 0x001ACE04
		// (set) Token: 0x06004F93 RID: 20371 RVA: 0x00029EB4 File Offset: 0x000280B4
		public SpellBase.DelayAudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_punishmentSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_punishmentSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x001AEC34 File Offset: 0x001ACE34
		// (set) Token: 0x06004F95 RID: 20373 RVA: 0x00029EE2 File Offset: 0x000280E2
		public SpellBase.DelayAudioClip punishmentSFX2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_punishmentSFX2);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.NativeFieldInfoPtr_punishmentSFX2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040035ED RID: 13805
		private static readonly IntPtr NativeFieldInfoPtr_postiveDuration;

		// Token: 0x040035EE RID: 13806
		private static readonly IntPtr NativeFieldInfoPtr_partnerExtraWageMultiper;

		// Token: 0x040035EF RID: 13807
		private static readonly IntPtr NativeFieldInfoPtr_rewardObject;

		// Token: 0x040035F0 RID: 13808
		private static readonly IntPtr NativeFieldInfoPtr_rewardParseeEye;

		// Token: 0x040035F1 RID: 13809
		private static readonly IntPtr NativeFieldInfoPtr_rewardFire;

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeFieldInfoPtr_rewardUIMoney;

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeFieldInfoPtr_flashDuration;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeFieldInfoPtr_fireDuration;

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeFieldInfoPtr_uiDuration;

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeFieldInfoPtr_uiAnimDuration;

		// Token: 0x040035F7 RID: 13815
		private static readonly IntPtr NativeFieldInfoPtr_uiOffset;

		// Token: 0x040035F8 RID: 13816
		private static readonly IntPtr NativeFieldInfoPtr_flashOffset;

		// Token: 0x040035F9 RID: 13817
		private static readonly IntPtr NativeFieldInfoPtr_fireOffset;

		// Token: 0x040035FA RID: 13818
		private static readonly IntPtr NativeFieldInfoPtr_punishmentObject;

		// Token: 0x040035FB RID: 13819
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040035FC RID: 13820
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040035FD RID: 13821
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX2;

		// Token: 0x040035FE RID: 13822
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040035FF RID: 13823
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003600 RID: 13824
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003601 RID: 13825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8B RID: 2955
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<OnNegativeBuffExecute>d__18")]
		public sealed class _OnNegativeBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D8E5 RID: 55525 RVA: 0x0034C5F0 File Offset: 0x0034A7F0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "<OnNegativeBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr);
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679288);
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679289);
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679290);
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679291);
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679292);
				Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679293);
			}

			// Token: 0x0600D8E6 RID: 55526 RVA: 0x0034C6D0 File Offset: 0x0034A8D0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee._OnNegativeBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8E7 RID: 55527 RVA: 0x0034C718 File Offset: 0x0034A918
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8E8 RID: 55528 RVA: 0x0034C74C File Offset: 0x0034A94C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201289, XrefRangeEnd = 201296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700468E RID: 18062
			// (get) Token: 0x0600D8E9 RID: 55529 RVA: 0x0034C788 File Offset: 0x0034A988
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8EA RID: 55530 RVA: 0x0034C7C8 File Offset: 0x0034A9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201296, XrefRangeEnd = 201302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700468F RID: 18063
			// (get) Token: 0x0600D8EB RID: 55531 RVA: 0x0034C7FC File Offset: 0x0034A9FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8EC RID: 55532 RVA: 0x000740F2 File Offset: 0x000722F2
			public _OnNegativeBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700468B RID: 18059
			// (get) Token: 0x0600D8ED RID: 55533 RVA: 0x0034C83C File Offset: 0x0034AA3C
			// (set) Token: 0x0600D8EE RID: 55534 RVA: 0x000740FB File Offset: 0x000722FB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700468C RID: 18060
			// (get) Token: 0x0600D8EF RID: 55535 RVA: 0x0034C864 File Offset: 0x0034AA64
			// (set) Token: 0x0600D8F0 RID: 55536 RVA: 0x00074116 File Offset: 0x00072316
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700468D RID: 18061
			// (get) Token: 0x0600D8F1 RID: 55537 RVA: 0x0034C894 File Offset: 0x0034AA94
			// (set) Token: 0x0600D8F2 RID: 55538 RVA: 0x00074135 File Offset: 0x00072335
			public unsafe Spell_Parsee __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B0D RID: 35597
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B0E RID: 35598
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B0F RID: 35599
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B10 RID: 35600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B11 RID: 35601
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B12 RID: 35602
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B13 RID: 35603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B14 RID: 35604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B15 RID: 35605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B8C RID: 2956
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8F3 RID: 55539 RVA: 0x0034C8C4 File Offset: 0x0034AAC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr);
				Spell_Parsee.__c__DisplayClass19_0.NativeFieldInfoPtr_largestFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr, "largestFund");
				Spell_Parsee.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				Spell_Parsee.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr, 100679294);
				Spell_Parsee.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr, 100679295);
				Spell_Parsee.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_TextMeshProUGUI_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr, 100679296);
			}

			// Token: 0x0600D8F4 RID: 55540 RVA: 0x0034C954 File Offset: 0x0034AB54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8F5 RID: 55541 RVA: 0x0034C990 File Offset: 0x0034AB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201313, XrefRangeEnd = 201340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8F6 RID: 55542 RVA: 0x0034C9D4 File Offset: 0x0034ABD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201340, XrefRangeEnd = 201346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_TextMeshProUGUI_Int32_Int32_PDM_0(TextMeshProUGUI moneyText, int targetMoney, int currentMoney)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moneyText);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetMoney;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMoney;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_TextMeshProUGUI_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D8F7 RID: 55543 RVA: 0x00074154 File Offset: 0x00072354
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004690 RID: 18064
			// (get) Token: 0x0600D8F8 RID: 55544 RVA: 0x0034CA40 File Offset: 0x0034AC40
			// (set) Token: 0x0600D8F9 RID: 55545 RVA: 0x0007415D File Offset: 0x0007235D
			public unsafe int largestFund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.NativeFieldInfoPtr_largestFund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.NativeFieldInfoPtr_largestFund)) = value;
				}
			}

			// Token: 0x17004691 RID: 18065
			// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x0034CA68 File Offset: 0x0034AC68
			// (set) Token: 0x0600D8FB RID: 55547 RVA: 0x00074178 File Offset: 0x00072378
			public unsafe Spell_Parsee __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B16 RID: 35606
			private static readonly IntPtr NativeFieldInfoPtr_largestFund;

			// Token: 0x04008B17 RID: 35607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B18 RID: 35608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B19 RID: 35609
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GuestGroupController_0;

			// Token: 0x04008B1A RID: 35610
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_TextMeshProUGUI_Int32_Int32_PDM_0;

			// Token: 0x02001037 RID: 4151
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<>c__DisplayClass19_0+<<OnPositiveBuffExecute>g__UpdateMoney|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C20 RID: 72736 RVA: 0x004110AC File Offset: 0x0040F2AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique()
				{
					Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__UpdateMoney|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr);
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "<>1__state");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "<>2__current");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "<>4__this");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_currentMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "currentMoney");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_targetMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "targetMoney");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_moneyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "moneyText");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, "<elapsedTime>5__2");
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, 100679297);
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, 100679298);
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, 100679299);
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, 100679300);
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, 100679301);
					Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr, 100679302);
				}

				// Token: 0x06011C21 RID: 72737 RVA: 0x004111DC File Offset: 0x0040F3DC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C22 RID: 72738 RVA: 0x00411224 File Offset: 0x0040F424
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C23 RID: 72739 RVA: 0x00411258 File Offset: 0x0040F458
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201302, XrefRangeEnd = 201307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C7D RID: 23677
				// (get) Token: 0x06011C24 RID: 72740 RVA: 0x00411294 File Offset: 0x0040F494
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C25 RID: 72741 RVA: 0x004112D4 File Offset: 0x0040F4D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201307, XrefRangeEnd = 201313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C7E RID: 23678
				// (get) Token: 0x06011C26 RID: 72742 RVA: 0x00411308 File Offset: 0x0040F508
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C27 RID: 72743 RVA: 0x0009A57F File Offset: 0x0009877F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C76 RID: 23670
				// (get) Token: 0x06011C28 RID: 72744 RVA: 0x00411348 File Offset: 0x0040F548
				// (set) Token: 0x06011C29 RID: 72745 RVA: 0x0009A588 File Offset: 0x00098788
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C77 RID: 23671
				// (get) Token: 0x06011C2A RID: 72746 RVA: 0x00411370 File Offset: 0x0040F570
				// (set) Token: 0x06011C2B RID: 72747 RVA: 0x0009A5A3 File Offset: 0x000987A3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C78 RID: 23672
				// (get) Token: 0x06011C2C RID: 72748 RVA: 0x004113A0 File Offset: 0x0040F5A0
				// (set) Token: 0x06011C2D RID: 72749 RVA: 0x0009A5C2 File Offset: 0x000987C2
				public unsafe Spell_Parsee.__c__DisplayClass19_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee.__c__DisplayClass19_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C79 RID: 23673
				// (get) Token: 0x06011C2E RID: 72750 RVA: 0x004113D0 File Offset: 0x0040F5D0
				// (set) Token: 0x06011C2F RID: 72751 RVA: 0x0009A5E1 File Offset: 0x000987E1
				public unsafe int currentMoney
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_currentMoney);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_currentMoney)) = value;
					}
				}

				// Token: 0x17005C7A RID: 23674
				// (get) Token: 0x06011C30 RID: 72752 RVA: 0x004113F8 File Offset: 0x0040F5F8
				// (set) Token: 0x06011C31 RID: 72753 RVA: 0x0009A5FC File Offset: 0x000987FC
				public unsafe int targetMoney
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_targetMoney);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_targetMoney)) = value;
					}
				}

				// Token: 0x17005C7B RID: 23675
				// (get) Token: 0x06011C32 RID: 72754 RVA: 0x00411420 File Offset: 0x0040F620
				// (set) Token: 0x06011C33 RID: 72755 RVA: 0x0009A617 File Offset: 0x00098817
				public unsafe TextMeshProUGUI moneyText
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_moneyText);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr_moneyText), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C7C RID: 23676
				// (get) Token: 0x06011C34 RID: 72756 RVA: 0x00411450 File Offset: 0x0040F650
				// (set) Token: 0x06011C35 RID: 72757 RVA: 0x0009A636 File Offset: 0x00098836
				public unsafe float _elapsedTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr__elapsedTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObcuIntaTemoInSiObUnique.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
					}
				}

				// Token: 0x0400B37F RID: 45951
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B380 RID: 45952
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B381 RID: 45953
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B382 RID: 45954
				private static readonly IntPtr NativeFieldInfoPtr_currentMoney;

				// Token: 0x0400B383 RID: 45955
				private static readonly IntPtr NativeFieldInfoPtr_targetMoney;

				// Token: 0x0400B384 RID: 45956
				private static readonly IntPtr NativeFieldInfoPtr_moneyText;

				// Token: 0x0400B385 RID: 45957
				private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

				// Token: 0x0400B386 RID: 45958
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B387 RID: 45959
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B388 RID: 45960
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B389 RID: 45961
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B38A RID: 45962
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B38B RID: 45963
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B8D RID: 2957
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D8FC RID: 55548 RVA: 0x0034CA98 File Offset: 0x0034AC98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr);
				Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_moneyUiPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr, "moneyUiPosition");
				Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_currentMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr, "currentMoney");
				Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Parsee.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr, 100679303);
				Spell_Parsee.__c__DisplayClass19_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr, 100679304);
			}

			// Token: 0x0600D8FD RID: 55549 RVA: 0x0034CB28 File Offset: 0x0034AD28
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8FE RID: 55550 RVA: 0x0034CB64 File Offset: 0x0034AD64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201346, XrefRangeEnd = 201372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8FF RID: 55551 RVA: 0x00074197 File Offset: 0x00072397
			public __c__DisplayClass19_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004692 RID: 18066
			// (get) Token: 0x0600D900 RID: 55552 RVA: 0x0034CBA8 File Offset: 0x0034ADA8
			// (set) Token: 0x0600D901 RID: 55553 RVA: 0x000741A0 File Offset: 0x000723A0
			public unsafe Vector3 moneyUiPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_moneyUiPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_moneyUiPosition)) = value;
				}
			}

			// Token: 0x17004693 RID: 18067
			// (get) Token: 0x0600D902 RID: 55554 RVA: 0x0034CBD0 File Offset: 0x0034ADD0
			// (set) Token: 0x0600D903 RID: 55555 RVA: 0x000741BB File Offset: 0x000723BB
			public unsafe int currentMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_currentMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_currentMoney)) = value;
				}
			}

			// Token: 0x17004694 RID: 18068
			// (get) Token: 0x0600D904 RID: 55556 RVA: 0x0034CBF8 File Offset: 0x0034ADF8
			// (set) Token: 0x0600D905 RID: 55557 RVA: 0x000741D6 File Offset: 0x000723D6
			public unsafe Spell_Parsee.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B1B RID: 35611
			private static readonly IntPtr NativeFieldInfoPtr_moneyUiPosition;

			// Token: 0x04008B1C RID: 35612
			private static readonly IntPtr NativeFieldInfoPtr_currentMoney;

			// Token: 0x04008B1D RID: 35613
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;

			// Token: 0x04008B1E RID: 35614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B1F RID: 35615
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B8E RID: 2958
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<>c__DisplayClass19_2")]
		public sealed class __c__DisplayClass19_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D906 RID: 55558 RVA: 0x0034CC28 File Offset: 0x0034AE28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_2()
			{
				Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "<>c__DisplayClass19_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_2>.NativeClassPtr);
				Spell_Parsee.__c__DisplayClass19_2.NativeFieldInfoPtr_moneyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_2>.NativeClassPtr, "moneyText");
				Spell_Parsee.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_2>.NativeClassPtr, 100679305);
				Spell_Parsee.__c__DisplayClass19_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_2>.NativeClassPtr, 100679306);
			}

			// Token: 0x0600D907 RID: 55559 RVA: 0x0034CC90 File Offset: 0x0034AE90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee.__c__DisplayClass19_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D908 RID: 55560 RVA: 0x0034CCCC File Offset: 0x0034AECC
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__4(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c__DisplayClass19_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D909 RID: 55561 RVA: 0x000741F5 File Offset: 0x000723F5
			public __c__DisplayClass19_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004695 RID: 18069
			// (get) Token: 0x0600D90A RID: 55562 RVA: 0x0034CD10 File Offset: 0x0034AF10
			// (set) Token: 0x0600D90B RID: 55563 RVA: 0x000741FE File Offset: 0x000723FE
			public unsafe TextMeshProUGUI moneyText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_2.NativeFieldInfoPtr_moneyText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee.__c__DisplayClass19_2.NativeFieldInfoPtr_moneyText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B20 RID: 35616
			private static readonly IntPtr NativeFieldInfoPtr_moneyText;

			// Token: 0x04008B21 RID: 35617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B22 RID: 35618
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000B8F RID: 2959
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D90C RID: 55564 RVA: 0x0034CD40 File Offset: 0x0034AF40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr);
				Spell_Parsee.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr, "<>9");
				Spell_Parsee.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr, "<>9__19_0");
				Spell_Parsee.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr, 100679308);
				Spell_Parsee.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_0_Internal_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr, 100679309);
			}

			// Token: 0x0600D90D RID: 55565 RVA: 0x0034CDBC File Offset: 0x0034AFBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D90E RID: 55566 RVA: 0x0034CDF8 File Offset: 0x0034AFF8
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__19_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_0_Internal_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D90F RID: 55567 RVA: 0x0007421D File Offset: 0x0007241D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004696 RID: 18070
			// (get) Token: 0x0600D910 RID: 55568 RVA: 0x0034CE48 File Offset: 0x0034B048
			// (set) Token: 0x0600D911 RID: 55569 RVA: 0x00074226 File Offset: 0x00072426
			public unsafe static Spell_Parsee.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Parsee.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Parsee.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004697 RID: 18071
			// (get) Token: 0x0600D912 RID: 55570 RVA: 0x0034CE70 File Offset: 0x0034B070
			// (set) Token: 0x0600D913 RID: 55571 RVA: 0x00074238 File Offset: 0x00072438
			public unsafe static Func<GuestGroupController, int> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Parsee.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Parsee.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B23 RID: 35619
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B24 RID: 35620
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04008B25 RID: 35621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B26 RID: 35622
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_0_Internal_Int32_GuestGroupController_0;
		}

		// Token: 0x02000B90 RID: 2960
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Parsee+<OnPositiveBuffExecute>d__19")]
		public sealed class _OnPositiveBuffExecute_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600D914 RID: 55572 RVA: 0x0034CE98 File Offset: 0x0034B098
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__19()
			{
				Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Parsee>.NativeClassPtr, "<OnPositiveBuffExecute>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr);
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>1__state");
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>2__current");
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>4__this");
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, "spellExecutionContext");
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>8__1");
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679310);
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679311);
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679312);
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679313);
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679314);
				Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679315);
			}

			// Token: 0x0600D915 RID: 55573 RVA: 0x0034CFA0 File Offset: 0x0034B1A0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Parsee._OnPositiveBuffExecute_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D916 RID: 55574 RVA: 0x0034CFE8 File Offset: 0x0034B1E8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D917 RID: 55575 RVA: 0x0034D01C File Offset: 0x0034B21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201372, XrefRangeEnd = 201427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700469D RID: 18077
			// (get) Token: 0x0600D918 RID: 55576 RVA: 0x0034D058 File Offset: 0x0034B258
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D919 RID: 55577 RVA: 0x0034D098 File Offset: 0x0034B298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201427, XrefRangeEnd = 201433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700469E RID: 18078
			// (get) Token: 0x0600D91A RID: 55578 RVA: 0x0034D0CC File Offset: 0x0034B2CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D91B RID: 55579 RVA: 0x0007424A File Offset: 0x0007244A
			public _OnPositiveBuffExecute_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004698 RID: 18072
			// (get) Token: 0x0600D91C RID: 55580 RVA: 0x0034D10C File Offset: 0x0034B30C
			// (set) Token: 0x0600D91D RID: 55581 RVA: 0x00074253 File Offset: 0x00072453
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004699 RID: 18073
			// (get) Token: 0x0600D91E RID: 55582 RVA: 0x0034D134 File Offset: 0x0034B334
			// (set) Token: 0x0600D91F RID: 55583 RVA: 0x0007426E File Offset: 0x0007246E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700469A RID: 18074
			// (get) Token: 0x0600D920 RID: 55584 RVA: 0x0034D164 File Offset: 0x0034B364
			// (set) Token: 0x0600D921 RID: 55585 RVA: 0x0007428D File Offset: 0x0007248D
			public unsafe Spell_Parsee __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700469B RID: 18075
			// (get) Token: 0x0600D922 RID: 55586 RVA: 0x0034D194 File Offset: 0x0034B394
			// (set) Token: 0x0600D923 RID: 55587 RVA: 0x000742AC File Offset: 0x000724AC
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700469C RID: 18076
			// (get) Token: 0x0600D924 RID: 55588 RVA: 0x0034D1C4 File Offset: 0x0034B3C4
			// (set) Token: 0x0600D925 RID: 55589 RVA: 0x000742CB File Offset: 0x000724CB
			public unsafe Spell_Parsee.__c__DisplayClass19_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Parsee.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Parsee._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B27 RID: 35623
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B28 RID: 35624
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B29 RID: 35625
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B2A RID: 35626
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008B2B RID: 35627
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008B2C RID: 35628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B2D RID: 35629
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B2E RID: 35630
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B2F RID: 35631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B30 RID: 35632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B31 RID: 35633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
