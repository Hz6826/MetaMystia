using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000281 RID: 641
	public class Spell_Sanae : SpellBase
	{
		// Token: 0x060050BC RID: 20668 RVA: 0x001B1A6C File Offset: 0x001AFC6C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Sanae()
		{
			Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Sanae");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr);
			Spell_Sanae.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "negativeDuration");
			Spell_Sanae.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "reward");
			Spell_Sanae.NativeFieldInfoPtr_positiveBevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "positiveBevNum");
			Spell_Sanae.NativeFieldInfoPtr_positiveIngredientNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "positiveIngredientNum");
			Spell_Sanae.NativeFieldInfoPtr_sanaeSealPaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "sanaeSealPaper");
			Spell_Sanae.NativeFieldInfoPtr_sanaeMagicObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "sanaeMagicObject");
			Spell_Sanae.NativeFieldInfoPtr_punishmentDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "punishmentDuration");
			Spell_Sanae.NativeFieldInfoPtr_delayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "delayTime");
			Spell_Sanae.NativeFieldInfoPtr_paperOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "paperOffset");
			Spell_Sanae.NativeFieldInfoPtr_magicOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "magicOffset");
			Spell_Sanae.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "punishmentSFX");
			Spell_Sanae.NativeFieldInfoPtr_sanaeRewardObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "sanaeRewardObject");
			Spell_Sanae.NativeFieldInfoPtr_rewardDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "rewardDuration");
			Spell_Sanae.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "rewardSFX");
			Spell_Sanae.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, 100679564);
			Spell_Sanae.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, 100679565);
			Spell_Sanae.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, 100679566);
			Spell_Sanae.NativeMethodInfoPtr_SelectReward_Private_Int32_SanaeRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, 100679567);
			Spell_Sanae.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, 100679568);
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x001B1C18 File Offset: 0x001AFE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203413, XrefRangeEnd = 203415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Sanae.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x001B1C5C File Offset: 0x001AFE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203415, XrefRangeEnd = 203420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Sanae.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x001B1CB8 File Offset: 0x001AFEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203420, XrefRangeEnd = 203426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Sanae.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x001B1D14 File Offset: 0x001AFF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203426, XrefRangeEnd = 203572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SelectReward(Spell_Sanae.SanaeRewardPair rewardPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rewardPair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.NativeMethodInfoPtr_SelectReward_Private_Int32_SanaeRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x001B1D60 File Offset: 0x001AFF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203572, XrefRangeEnd = 203579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Sanae() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x0002ACCA File Offset: 0x00028ECA
		public Spell_Sanae(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x060050C3 RID: 20675 RVA: 0x001B1D9C File Offset: 0x001AFF9C
		// (set) Token: 0x060050C4 RID: 20676 RVA: 0x0002ACD3 File Offset: 0x00028ED3
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x060050C5 RID: 20677 RVA: 0x001B1DC4 File Offset: 0x001AFFC4
		// (set) Token: 0x060050C6 RID: 20678 RVA: 0x0002ACEE File Offset: 0x00028EEE
		public unsafe Il2CppStructArray<Spell_Sanae.SanaeRewardPair> reward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_reward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Spell_Sanae.SanaeRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x001B1DF4 File Offset: 0x001AFFF4
		// (set) Token: 0x060050C8 RID: 20680 RVA: 0x0002AD0D File Offset: 0x00028F0D
		public unsafe int positiveBevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_positiveBevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_positiveBevNum)) = value;
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x060050C9 RID: 20681 RVA: 0x001B1E1C File Offset: 0x001B001C
		// (set) Token: 0x060050CA RID: 20682 RVA: 0x0002AD28 File Offset: 0x00028F28
		public unsafe int positiveIngredientNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_positiveIngredientNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_positiveIngredientNum)) = value;
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x001B1E44 File Offset: 0x001B0044
		// (set) Token: 0x060050CC RID: 20684 RVA: 0x0002AD43 File Offset: 0x00028F43
		public unsafe GameObject sanaeSealPaper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_sanaeSealPaper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_sanaeSealPaper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x060050CD RID: 20685 RVA: 0x001B1E74 File Offset: 0x001B0074
		// (set) Token: 0x060050CE RID: 20686 RVA: 0x0002AD62 File Offset: 0x00028F62
		public unsafe GameObject sanaeMagicObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_sanaeMagicObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_sanaeMagicObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x060050CF RID: 20687 RVA: 0x001B1EA4 File Offset: 0x001B00A4
		// (set) Token: 0x060050D0 RID: 20688 RVA: 0x0002AD81 File Offset: 0x00028F81
		public unsafe float punishmentDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_punishmentDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_punishmentDuration)) = value;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x060050D1 RID: 20689 RVA: 0x001B1ECC File Offset: 0x001B00CC
		// (set) Token: 0x060050D2 RID: 20690 RVA: 0x0002AD9C File Offset: 0x00028F9C
		public unsafe float delayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_delayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_delayTime)) = value;
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x001B1EF4 File Offset: 0x001B00F4
		// (set) Token: 0x060050D4 RID: 20692 RVA: 0x0002ADB7 File Offset: 0x00028FB7
		public unsafe Vector2 paperOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_paperOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_paperOffset)) = value;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x060050D5 RID: 20693 RVA: 0x001B1F1C File Offset: 0x001B011C
		// (set) Token: 0x060050D6 RID: 20694 RVA: 0x0002ADD2 File Offset: 0x00028FD2
		public unsafe Vector2 magicOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_magicOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_magicOffset)) = value;
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x060050D7 RID: 20695 RVA: 0x001B1F44 File Offset: 0x001B0144
		// (set) Token: 0x060050D8 RID: 20696 RVA: 0x0002ADED File Offset: 0x00028FED
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x060050D9 RID: 20697 RVA: 0x001B1F74 File Offset: 0x001B0174
		// (set) Token: 0x060050DA RID: 20698 RVA: 0x0002AE0C File Offset: 0x0002900C
		public unsafe GameObject sanaeRewardObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_sanaeRewardObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_sanaeRewardObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x060050DB RID: 20699 RVA: 0x001B1FA4 File Offset: 0x001B01A4
		// (set) Token: 0x060050DC RID: 20700 RVA: 0x0002AE2B File Offset: 0x0002902B
		public unsafe float rewardDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_rewardDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_rewardDuration)) = value;
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x060050DD RID: 20701 RVA: 0x001B1FCC File Offset: 0x001B01CC
		// (set) Token: 0x060050DE RID: 20702 RVA: 0x0002AE46 File Offset: 0x00029046
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036A3 RID: 13987
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040036A4 RID: 13988
		private static readonly IntPtr NativeFieldInfoPtr_reward;

		// Token: 0x040036A5 RID: 13989
		private static readonly IntPtr NativeFieldInfoPtr_positiveBevNum;

		// Token: 0x040036A6 RID: 13990
		private static readonly IntPtr NativeFieldInfoPtr_positiveIngredientNum;

		// Token: 0x040036A7 RID: 13991
		private static readonly IntPtr NativeFieldInfoPtr_sanaeSealPaper;

		// Token: 0x040036A8 RID: 13992
		private static readonly IntPtr NativeFieldInfoPtr_sanaeMagicObject;

		// Token: 0x040036A9 RID: 13993
		private static readonly IntPtr NativeFieldInfoPtr_punishmentDuration;

		// Token: 0x040036AA RID: 13994
		private static readonly IntPtr NativeFieldInfoPtr_delayTime;

		// Token: 0x040036AB RID: 13995
		private static readonly IntPtr NativeFieldInfoPtr_paperOffset;

		// Token: 0x040036AC RID: 13996
		private static readonly IntPtr NativeFieldInfoPtr_magicOffset;

		// Token: 0x040036AD RID: 13997
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040036AE RID: 13998
		private static readonly IntPtr NativeFieldInfoPtr_sanaeRewardObject;

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeFieldInfoPtr_rewardDuration;

		// Token: 0x040036B0 RID: 14000
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040036B1 RID: 14001
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040036B2 RID: 14002
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036B3 RID: 14003
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeMethodInfoPtr_SelectReward_Private_Int32_SanaeRewardPair_0;

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB3 RID: 2995
		public enum SanaeRewardType : byte
		{
			// Token: 0x04008C4E RID: 35918
			Ingredient,
			// Token: 0x04008C4F RID: 35919
			Bev
		}

		// Token: 0x02000BB4 RID: 2996
		[Serializable]
		[StructLayout(2)]
		public struct SanaeRewardPair
		{
			// Token: 0x0600DAFB RID: 56059 RVA: 0x00352AD4 File Offset: 0x00350CD4
			// Note: this type is marked as 'beforefieldinit'.
			static SanaeRewardPair()
			{
				Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "SanaeRewardPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr);
				Spell_Sanae.SanaeRewardPair.NativeFieldInfoPtr_RewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr, "RewardType");
				Spell_Sanae.SanaeRewardPair.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr, "Level");
				Spell_Sanae.SanaeRewardPair.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr, "Probability");
				Spell_Sanae.SanaeRewardPair.NativeMethodInfoPtr__ctor_Public_Void_SanaeRewardType_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr, 100679569);
			}

			// Token: 0x0600DAFC RID: 56060 RVA: 0x00352B50 File Offset: 0x00350D50
			[CallerCount(0)]
			public unsafe SanaeRewardPair(Spell_Sanae.SanaeRewardType type, int level, float probability)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref type;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.SanaeRewardPair.NativeMethodInfoPtr__ctor_Public_Void_SanaeRewardType_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAFD RID: 56061 RVA: 0x00075115 File Offset: 0x00073315
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spell_Sanae.SanaeRewardPair>.NativeClassPtr, ref this));
			}

			// Token: 0x04008C50 RID: 35920
			private static readonly IntPtr NativeFieldInfoPtr_RewardType;

			// Token: 0x04008C51 RID: 35921
			private static readonly IntPtr NativeFieldInfoPtr_Level;

			// Token: 0x04008C52 RID: 35922
			private static readonly IntPtr NativeFieldInfoPtr_Probability;

			// Token: 0x04008C53 RID: 35923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SanaeRewardType_Int32_Single_0;

			// Token: 0x04008C54 RID: 35924
			[FieldOffset(0)]
			public Spell_Sanae.SanaeRewardType RewardType;

			// Token: 0x04008C55 RID: 35925
			[FieldOffset(4)]
			public int Level;

			// Token: 0x04008C56 RID: 35926
			[FieldOffset(8)]
			public float Probability;
		}

		// Token: 0x02000BB5 RID: 2997
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAFE RID: 56062 RVA: 0x00352BA0 File Offset: 0x00350DA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr);
				Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_paper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, "paper");
				Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, "effect");
				Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_bingo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, "bingo");
				Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, 100679570);
				Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, 100679571);
				Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, 100679572);
				Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, 100679573);
				Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, 100679574);
			}

			// Token: 0x0600DAFF RID: 56063 RVA: 0x00352C80 File Offset: 0x00350E80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB00 RID: 56064 RVA: 0x00352CBC File Offset: 0x00350EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203302, XrefRangeEnd = 203307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB01 RID: 56065 RVA: 0x00352CFC File Offset: 0x00350EFC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB02 RID: 56066 RVA: 0x00352D40 File Offset: 0x00350F40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB03 RID: 56067 RVA: 0x00352D84 File Offset: 0x00350F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203307, XrefRangeEnd = 203312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB04 RID: 56068 RVA: 0x00075127 File Offset: 0x00073327
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004731 RID: 18225
			// (get) Token: 0x0600DB05 RID: 56069 RVA: 0x00352DC4 File Offset: 0x00350FC4
			// (set) Token: 0x0600DB06 RID: 56070 RVA: 0x00075130 File Offset: 0x00073330
			public unsafe Spell_Sanae __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004732 RID: 18226
			// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x00352DF4 File Offset: 0x00350FF4
			// (set) Token: 0x0600DB08 RID: 56072 RVA: 0x0007514F File Offset: 0x0007334F
			public unsafe GameObject paper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_paper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_paper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004733 RID: 18227
			// (get) Token: 0x0600DB09 RID: 56073 RVA: 0x00352E24 File Offset: 0x00351024
			// (set) Token: 0x0600DB0A RID: 56074 RVA: 0x0007516E File Offset: 0x0007336E
			public unsafe GameObject effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004734 RID: 18228
			// (get) Token: 0x0600DB0B RID: 56075 RVA: 0x00352E54 File Offset: 0x00351054
			// (set) Token: 0x0600DB0C RID: 56076 RVA: 0x0007518D File Offset: 0x0007338D
			public unsafe bool bingo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_bingo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.NativeFieldInfoPtr_bingo)) = value;
				}
			}

			// Token: 0x04008C57 RID: 35927
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C58 RID: 35928
			private static readonly IntPtr NativeFieldInfoPtr_paper;

			// Token: 0x04008C59 RID: 35929
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04008C5A RID: 35930
			private static readonly IntPtr NativeFieldInfoPtr_bingo;

			// Token: 0x04008C5B RID: 35931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C5C RID: 35932
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008C5D RID: 35933
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GameObject_0;

			// Token: 0x04008C5E RID: 35934
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_GameObject_0;

			// Token: 0x04008C5F RID: 35935
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x0200103E RID: 4158
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<>c__DisplayClass16_0+<<OnNegativeBuffExecute>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011C92 RID: 72850 RVA: 0x00412670 File Offset: 0x00410870
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679575);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679576);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679577);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679578);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679579);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679580);
				}

				// Token: 0x06011C93 RID: 72851 RVA: 0x00412750 File Offset: 0x00410950
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C94 RID: 72852 RVA: 0x00412798 File Offset: 0x00410998
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C95 RID: 72853 RVA: 0x004127CC File Offset: 0x004109CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203264, XrefRangeEnd = 203280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CA4 RID: 23716
				// (get) Token: 0x06011C96 RID: 72854 RVA: 0x00412808 File Offset: 0x00410A08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C97 RID: 72855 RVA: 0x00412848 File Offset: 0x00410A48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203280, XrefRangeEnd = 203286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CA5 RID: 23717
				// (get) Token: 0x06011C98 RID: 72856 RVA: 0x0041287C File Offset: 0x00410A7C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C99 RID: 72857 RVA: 0x0009A911 File Offset: 0x00098B11
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CA1 RID: 23713
				// (get) Token: 0x06011C9A RID: 72858 RVA: 0x004128BC File Offset: 0x00410ABC
				// (set) Token: 0x06011C9B RID: 72859 RVA: 0x0009A91A File Offset: 0x00098B1A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CA2 RID: 23714
				// (get) Token: 0x06011C9C RID: 72860 RVA: 0x004128E4 File Offset: 0x00410AE4
				// (set) Token: 0x06011C9D RID: 72861 RVA: 0x0009A935 File Offset: 0x00098B35
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CA3 RID: 23715
				// (get) Token: 0x06011C9E RID: 72862 RVA: 0x00412914 File Offset: 0x00410B14
				// (set) Token: 0x06011C9F RID: 72863 RVA: 0x0009A954 File Offset: 0x00098B54
				public unsafe Spell_Sanae.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B3C6 RID: 46022
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3C7 RID: 46023
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3C8 RID: 46024
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3C9 RID: 46025
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3CA RID: 46026
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3CB RID: 46027
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3CC RID: 46028
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3CD RID: 46029
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3CE RID: 46030
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200103F RID: 4159
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<>c__DisplayClass16_0+<<OnNegativeBuffExecute>g__BuffSet|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011CA0 RID: 72864 RVA: 0x00412944 File Offset: 0x00410B44
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__BuffSet|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679581);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679582);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679583);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679584);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679585);
					Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679586);
				}

				// Token: 0x06011CA1 RID: 72865 RVA: 0x00412A24 File Offset: 0x00410C24
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CA2 RID: 72866 RVA: 0x00412A6C File Offset: 0x00410C6C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CA3 RID: 72867 RVA: 0x00412AA0 File Offset: 0x00410CA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203286, XrefRangeEnd = 203296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CA9 RID: 23721
				// (get) Token: 0x06011CA4 RID: 72868 RVA: 0x00412ADC File Offset: 0x00410CDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CA5 RID: 72869 RVA: 0x00412B1C File Offset: 0x00410D1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203296, XrefRangeEnd = 203302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CAA RID: 23722
				// (get) Token: 0x06011CA6 RID: 72870 RVA: 0x00412B50 File Offset: 0x00410D50
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CA7 RID: 72871 RVA: 0x0009A973 File Offset: 0x00098B73
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CA6 RID: 23718
				// (get) Token: 0x06011CA8 RID: 72872 RVA: 0x00412B90 File Offset: 0x00410D90
				// (set) Token: 0x06011CA9 RID: 72873 RVA: 0x0009A97C File Offset: 0x00098B7C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CA7 RID: 23719
				// (get) Token: 0x06011CAA RID: 72874 RVA: 0x00412BB8 File Offset: 0x00410DB8
				// (set) Token: 0x06011CAB RID: 72875 RVA: 0x0009A997 File Offset: 0x00098B97
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CA8 RID: 23720
				// (get) Token: 0x06011CAC RID: 72876 RVA: 0x00412BE8 File Offset: 0x00410DE8
				// (set) Token: 0x06011CAD RID: 72877 RVA: 0x0009A9B6 File Offset: 0x00098BB6
				public unsafe Spell_Sanae.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B3CF RID: 46031
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3D0 RID: 46032
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3D1 RID: 46033
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3D2 RID: 46034
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3D3 RID: 46035
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3D4 RID: 46036
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3D5 RID: 46037
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3D6 RID: 46038
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3D7 RID: 46039
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BB6 RID: 2998
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<OnNegativeBuffExecute>d__16")]
		public sealed class _OnNegativeBuffExecute_d__16 : Il2CppSystem.Object
		{
			// Token: 0x0600DB0D RID: 56077 RVA: 0x00352E7C File Offset: 0x0035107C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__16()
			{
				Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "<OnNegativeBuffExecute>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr);
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, "<>1__state");
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, "<>2__current");
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, "<>4__this");
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, "<>8__1");
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, 100679587);
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, 100679588);
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, 100679589);
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, 100679590);
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, 100679591);
				Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr, 100679592);
			}

			// Token: 0x0600DB0E RID: 56078 RVA: 0x00352F70 File Offset: 0x00351170
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae._OnNegativeBuffExecute_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB0F RID: 56079 RVA: 0x00352FB8 File Offset: 0x003511B8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB10 RID: 56080 RVA: 0x00352FEC File Offset: 0x003511EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203312, XrefRangeEnd = 203349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004739 RID: 18233
			// (get) Token: 0x0600DB11 RID: 56081 RVA: 0x00353028 File Offset: 0x00351228
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB12 RID: 56082 RVA: 0x00353068 File Offset: 0x00351268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203349, XrefRangeEnd = 203355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700473A RID: 18234
			// (get) Token: 0x0600DB13 RID: 56083 RVA: 0x0035309C File Offset: 0x0035129C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB14 RID: 56084 RVA: 0x000751A8 File Offset: 0x000733A8
			public _OnNegativeBuffExecute_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004735 RID: 18229
			// (get) Token: 0x0600DB15 RID: 56085 RVA: 0x003530DC File Offset: 0x003512DC
			// (set) Token: 0x0600DB16 RID: 56086 RVA: 0x000751B1 File Offset: 0x000733B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004736 RID: 18230
			// (get) Token: 0x0600DB17 RID: 56087 RVA: 0x00353104 File Offset: 0x00351304
			// (set) Token: 0x0600DB18 RID: 56088 RVA: 0x000751CC File Offset: 0x000733CC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004737 RID: 18231
			// (get) Token: 0x0600DB19 RID: 56089 RVA: 0x00353134 File Offset: 0x00351334
			// (set) Token: 0x0600DB1A RID: 56090 RVA: 0x000751EB File Offset: 0x000733EB
			public unsafe Spell_Sanae __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004738 RID: 18232
			// (get) Token: 0x0600DB1B RID: 56091 RVA: 0x00353164 File Offset: 0x00351364
			// (set) Token: 0x0600DB1C RID: 56092 RVA: 0x0007520A File Offset: 0x0007340A
			public unsafe Spell_Sanae.__c__DisplayClass16_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnNegativeBuffExecute_d__16.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C60 RID: 35936
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C61 RID: 35937
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C62 RID: 35938
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C63 RID: 35939
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008C64 RID: 35940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C65 RID: 35941
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C66 RID: 35942
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C67 RID: 35943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C68 RID: 35944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C69 RID: 35945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BB7 RID: 2999
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB1D RID: 56093 RVA: 0x00353194 File Offset: 0x00351394
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr);
				Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr, "ingredient");
				Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_bev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr, "bev");
				Spell_Sanae.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr, 100679593);
				Spell_Sanae.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr, 100679594);
			}

			// Token: 0x0600DB1E RID: 56094 RVA: 0x00353224 File Offset: 0x00351424
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB1F RID: 56095 RVA: 0x00353260 File Offset: 0x00351460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203355, XrefRangeEnd = 203385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GameObject_PDM_0(GameObject gameObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB20 RID: 56096 RVA: 0x00075229 File Offset: 0x00073429
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700473B RID: 18235
			// (get) Token: 0x0600DB21 RID: 56097 RVA: 0x003532A4 File Offset: 0x003514A4
			// (set) Token: 0x0600DB22 RID: 56098 RVA: 0x00075232 File Offset: 0x00073432
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700473C RID: 18236
			// (get) Token: 0x0600DB23 RID: 56099 RVA: 0x003532D4 File Offset: 0x003514D4
			// (set) Token: 0x0600DB24 RID: 56100 RVA: 0x00075251 File Offset: 0x00073451
			public unsafe List<int> ingredient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700473D RID: 18237
			// (get) Token: 0x0600DB25 RID: 56101 RVA: 0x00353304 File Offset: 0x00351504
			// (set) Token: 0x0600DB26 RID: 56102 RVA: 0x00075270 File Offset: 0x00073470
			public unsafe List<int> bev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_bev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae.__c__DisplayClass17_0.NativeFieldInfoPtr_bev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C6A RID: 35946
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008C6B RID: 35947
			private static readonly IntPtr NativeFieldInfoPtr_ingredient;

			// Token: 0x04008C6C RID: 35948
			private static readonly IntPtr NativeFieldInfoPtr_bev;

			// Token: 0x04008C6D RID: 35949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C6E RID: 35950
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0;
		}

		// Token: 0x02000BB8 RID: 3000
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB27 RID: 56103 RVA: 0x00353334 File Offset: 0x00351534
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr);
				Spell_Sanae.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__17_0");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__17_1");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__17_2");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__17_3");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_0");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_1");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_2");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_3");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_4");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_5");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_6");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_7");
				Spell_Sanae.__c.NativeFieldInfoPtr___9__18_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, "<>9__18_8");
				Spell_Sanae.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679596);
				Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_0_Internal_Boolean_SanaeRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679597);
				Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_1_Internal_Single_SanaeRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679598);
				Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_2_Internal_Boolean_SanaeRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679599);
				Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_3_Internal_Single_SanaeRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679600);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679601);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_1_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679602);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_2_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679603);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_3_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679604);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_4_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679605);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_5_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679606);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679607);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_7_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679608);
				Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_8_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr, 100679609);
			}

			// Token: 0x0600DB28 RID: 56104 RVA: 0x00353590 File Offset: 0x00351790
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB29 RID: 56105 RVA: 0x003535CC File Offset: 0x003517CC
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__17_0(Spell_Sanae.SanaeRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_0_Internal_Boolean_SanaeRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2A RID: 56106 RVA: 0x00353618 File Offset: 0x00351818
			[CallerCount(0)]
			public unsafe float _OnPositiveBuffExecute_b__17_1(Spell_Sanae.SanaeRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_1_Internal_Single_SanaeRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2B RID: 56107 RVA: 0x00353664 File Offset: 0x00351864
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__17_2(Spell_Sanae.SanaeRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_2_Internal_Boolean_SanaeRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2C RID: 56108 RVA: 0x003536B0 File Offset: 0x003518B0
			[CallerCount(0)]
			public unsafe float _OnPositiveBuffExecute_b__17_3(Spell_Sanae.SanaeRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_3_Internal_Single_SanaeRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x003536FC File Offset: 0x003518FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__18_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x00353748 File Offset: 0x00351948
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__18_1(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_1_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2F RID: 56111 RVA: 0x00353798 File Offset: 0x00351998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__18_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_2_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600DB30 RID: 56112 RVA: 0x003537E4 File Offset: 0x003519E4
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__18_3(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_3_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB31 RID: 56113 RVA: 0x00353834 File Offset: 0x00351A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__18_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_4_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600DB32 RID: 56114 RVA: 0x00353880 File Offset: 0x00351A80
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__18_5(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_5_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB33 RID: 56115 RVA: 0x003538D0 File Offset: 0x00351AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__18_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB34 RID: 56116 RVA: 0x0035391C File Offset: 0x00351B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__18_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_7_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB35 RID: 56117 RVA: 0x00353968 File Offset: 0x00351B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__18_8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae.__c.NativeMethodInfoPtr__SelectReward_b__18_8_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB36 RID: 56118 RVA: 0x0007528F File Offset: 0x0007348F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700473E RID: 18238
			// (get) Token: 0x0600DB37 RID: 56119 RVA: 0x003539B4 File Offset: 0x00351BB4
			// (set) Token: 0x0600DB38 RID: 56120 RVA: 0x00075298 File Offset: 0x00073498
			public unsafe static Spell_Sanae.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700473F RID: 18239
			// (get) Token: 0x0600DB39 RID: 56121 RVA: 0x003539DC File Offset: 0x00351BDC
			// (set) Token: 0x0600DB3A RID: 56122 RVA: 0x000752AA File Offset: 0x000734AA
			public unsafe static Func<Spell_Sanae.SanaeRewardPair, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Sanae.SanaeRewardPair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004740 RID: 18240
			// (get) Token: 0x0600DB3B RID: 56123 RVA: 0x00353A04 File Offset: 0x00351C04
			// (set) Token: 0x0600DB3C RID: 56124 RVA: 0x000752BC File Offset: 0x000734BC
			public unsafe static Func<Spell_Sanae.SanaeRewardPair, float> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Sanae.SanaeRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004741 RID: 18241
			// (get) Token: 0x0600DB3D RID: 56125 RVA: 0x00353A2C File Offset: 0x00351C2C
			// (set) Token: 0x0600DB3E RID: 56126 RVA: 0x000752CE File Offset: 0x000734CE
			public unsafe static Func<Spell_Sanae.SanaeRewardPair, bool> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Sanae.SanaeRewardPair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004742 RID: 18242
			// (get) Token: 0x0600DB3F RID: 56127 RVA: 0x00353A54 File Offset: 0x00351C54
			// (set) Token: 0x0600DB40 RID: 56128 RVA: 0x000752E0 File Offset: 0x000734E0
			public unsafe static Func<Spell_Sanae.SanaeRewardPair, float> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Sanae.SanaeRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004743 RID: 18243
			// (get) Token: 0x0600DB41 RID: 56129 RVA: 0x00353A7C File Offset: 0x00351C7C
			// (set) Token: 0x0600DB42 RID: 56130 RVA: 0x000752F2 File Offset: 0x000734F2
			public unsafe static Func<int, Ingredient> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004744 RID: 18244
			// (get) Token: 0x0600DB43 RID: 56131 RVA: 0x00353AA4 File Offset: 0x00351CA4
			// (set) Token: 0x0600DB44 RID: 56132 RVA: 0x00075304 File Offset: 0x00073504
			public unsafe static Func<Ingredient, bool> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004745 RID: 18245
			// (get) Token: 0x0600DB45 RID: 56133 RVA: 0x00353ACC File Offset: 0x00351CCC
			// (set) Token: 0x0600DB46 RID: 56134 RVA: 0x00075316 File Offset: 0x00073516
			public unsafe static Func<int, Ingredient> __9__18_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004746 RID: 18246
			// (get) Token: 0x0600DB47 RID: 56135 RVA: 0x00353AF4 File Offset: 0x00351CF4
			// (set) Token: 0x0600DB48 RID: 56136 RVA: 0x00075328 File Offset: 0x00073528
			public unsafe static Func<Ingredient, bool> __9__18_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004747 RID: 18247
			// (get) Token: 0x0600DB49 RID: 56137 RVA: 0x00353B1C File Offset: 0x00351D1C
			// (set) Token: 0x0600DB4A RID: 56138 RVA: 0x0007533A File Offset: 0x0007353A
			public unsafe static Func<int, Ingredient> __9__18_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004748 RID: 18248
			// (get) Token: 0x0600DB4B RID: 56139 RVA: 0x00353B44 File Offset: 0x00351D44
			// (set) Token: 0x0600DB4C RID: 56140 RVA: 0x0007534C File Offset: 0x0007354C
			public unsafe static Func<Ingredient, bool> __9__18_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004749 RID: 18249
			// (get) Token: 0x0600DB4D RID: 56141 RVA: 0x00353B6C File Offset: 0x00351D6C
			// (set) Token: 0x0600DB4E RID: 56142 RVA: 0x0007535E File Offset: 0x0007355E
			public unsafe static Func<int, bool> __9__18_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700474A RID: 18250
			// (get) Token: 0x0600DB4F RID: 56143 RVA: 0x00353B94 File Offset: 0x00351D94
			// (set) Token: 0x0600DB50 RID: 56144 RVA: 0x00075370 File Offset: 0x00073570
			public unsafe static Func<int, bool> __9__18_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700474B RID: 18251
			// (get) Token: 0x0600DB51 RID: 56145 RVA: 0x00353BBC File Offset: 0x00351DBC
			// (set) Token: 0x0600DB52 RID: 56146 RVA: 0x00075382 File Offset: 0x00073582
			public unsafe static Func<int, bool> __9__18_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Sanae.__c.NativeFieldInfoPtr___9__18_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C6F RID: 35951
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C70 RID: 35952
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008C71 RID: 35953
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04008C72 RID: 35954
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04008C73 RID: 35955
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x04008C74 RID: 35956
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04008C75 RID: 35957
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04008C76 RID: 35958
			private static readonly IntPtr NativeFieldInfoPtr___9__18_2;

			// Token: 0x04008C77 RID: 35959
			private static readonly IntPtr NativeFieldInfoPtr___9__18_3;

			// Token: 0x04008C78 RID: 35960
			private static readonly IntPtr NativeFieldInfoPtr___9__18_4;

			// Token: 0x04008C79 RID: 35961
			private static readonly IntPtr NativeFieldInfoPtr___9__18_5;

			// Token: 0x04008C7A RID: 35962
			private static readonly IntPtr NativeFieldInfoPtr___9__18_6;

			// Token: 0x04008C7B RID: 35963
			private static readonly IntPtr NativeFieldInfoPtr___9__18_7;

			// Token: 0x04008C7C RID: 35964
			private static readonly IntPtr NativeFieldInfoPtr___9__18_8;

			// Token: 0x04008C7D RID: 35965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C7E RID: 35966
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_0_Internal_Boolean_SanaeRewardPair_0;

			// Token: 0x04008C7F RID: 35967
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_1_Internal_Single_SanaeRewardPair_0;

			// Token: 0x04008C80 RID: 35968
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_2_Internal_Boolean_SanaeRewardPair_0;

			// Token: 0x04008C81 RID: 35969
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__17_3_Internal_Single_SanaeRewardPair_0;

			// Token: 0x04008C82 RID: 35970
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_0_Internal_Ingredient_Int32_0;

			// Token: 0x04008C83 RID: 35971
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_1_Internal_Boolean_Ingredient_0;

			// Token: 0x04008C84 RID: 35972
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_2_Internal_Ingredient_Int32_0;

			// Token: 0x04008C85 RID: 35973
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_3_Internal_Boolean_Ingredient_0;

			// Token: 0x04008C86 RID: 35974
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_4_Internal_Ingredient_Int32_0;

			// Token: 0x04008C87 RID: 35975
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_5_Internal_Boolean_Ingredient_0;

			// Token: 0x04008C88 RID: 35976
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_6_Internal_Boolean_Int32_0;

			// Token: 0x04008C89 RID: 35977
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_7_Internal_Boolean_Int32_0;

			// Token: 0x04008C8A RID: 35978
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__18_8_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000BB9 RID: 3001
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Sanae+<OnPositiveBuffExecute>d__17")]
		public sealed class _OnPositiveBuffExecute_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600DB53 RID: 56147 RVA: 0x00353BE4 File Offset: 0x00351DE4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__17()
			{
				Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Sanae>.NativeClassPtr, "<OnPositiveBuffExecute>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr);
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, "<>1__state");
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, "<>2__current");
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, "spellExecutionContext");
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, "<>4__this");
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, "<>8__1");
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, 100679610);
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, 100679611);
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, 100679612);
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, 100679613);
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, 100679614);
				Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr, 100679615);
			}

			// Token: 0x0600DB54 RID: 56148 RVA: 0x00353CEC File Offset: 0x00351EEC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Sanae._OnPositiveBuffExecute_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB55 RID: 56149 RVA: 0x00353D34 File Offset: 0x00351F34
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB56 RID: 56150 RVA: 0x00353D68 File Offset: 0x00351F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203385, XrefRangeEnd = 203407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004751 RID: 18257
			// (get) Token: 0x0600DB57 RID: 56151 RVA: 0x00353DA4 File Offset: 0x00351FA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB58 RID: 56152 RVA: 0x00353DE4 File Offset: 0x00351FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203407, XrefRangeEnd = 203413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004752 RID: 18258
			// (get) Token: 0x0600DB59 RID: 56153 RVA: 0x00353E18 File Offset: 0x00352018
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB5A RID: 56154 RVA: 0x00075394 File Offset: 0x00073594
			public _OnPositiveBuffExecute_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700474C RID: 18252
			// (get) Token: 0x0600DB5B RID: 56155 RVA: 0x00353E58 File Offset: 0x00352058
			// (set) Token: 0x0600DB5C RID: 56156 RVA: 0x0007539D File Offset: 0x0007359D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700474D RID: 18253
			// (get) Token: 0x0600DB5D RID: 56157 RVA: 0x00353E80 File Offset: 0x00352080
			// (set) Token: 0x0600DB5E RID: 56158 RVA: 0x000753B8 File Offset: 0x000735B8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700474E RID: 18254
			// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x00353EB0 File Offset: 0x003520B0
			// (set) Token: 0x0600DB60 RID: 56160 RVA: 0x000753D7 File Offset: 0x000735D7
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700474F RID: 18255
			// (get) Token: 0x0600DB61 RID: 56161 RVA: 0x00353EE0 File Offset: 0x003520E0
			// (set) Token: 0x0600DB62 RID: 56162 RVA: 0x000753F6 File Offset: 0x000735F6
			public unsafe Spell_Sanae __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004750 RID: 18256
			// (get) Token: 0x0600DB63 RID: 56163 RVA: 0x00353F10 File Offset: 0x00352110
			// (set) Token: 0x0600DB64 RID: 56164 RVA: 0x00075415 File Offset: 0x00073615
			public unsafe Spell_Sanae.__c__DisplayClass17_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Sanae.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Sanae._OnPositiveBuffExecute_d__17.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C8B RID: 35979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C8C RID: 35980
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C8D RID: 35981
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008C8E RID: 35982
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C8F RID: 35983
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008C90 RID: 35984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C91 RID: 35985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C92 RID: 35986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C93 RID: 35987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C94 RID: 35988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C95 RID: 35989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
