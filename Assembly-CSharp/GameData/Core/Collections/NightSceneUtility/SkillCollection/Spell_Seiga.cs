using System;
using Common.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000283 RID: 643
	public class Spell_Seiga : SpellBase
	{
		// Token: 0x060050E9 RID: 20713 RVA: 0x001B2234 File Offset: 0x001B0434
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Seiga()
		{
			Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Seiga");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr);
			Spell_Seiga.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "positiveDuration");
			Spell_Seiga.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "negativeDuration");
			Spell_Seiga.NativeFieldInfoPtr_extraNegativeSpellcardRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "extraNegativeSpellcardRate");
			Spell_Seiga.NativeFieldInfoPtr_DoorEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "DoorEffect");
			Spell_Seiga.NativeFieldInfoPtr_magicEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "magicEffect");
			Spell_Seiga.NativeFieldInfoPtr_demonFaceEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "demonFaceEffect");
			Spell_Seiga.NativeFieldInfoPtr_doorOpenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "doorOpenSFX");
			Spell_Seiga.NativeFieldInfoPtr_magicSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "magicSFX");
			Spell_Seiga.NativeFieldInfoPtr_blackMagicSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "blackMagicSFX");
			Spell_Seiga.NativeFieldInfoPtr_demonSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "demonSFX");
			Spell_Seiga.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, 100679636);
			Spell_Seiga.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, 100679637);
			Spell_Seiga.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, 100679638);
			Spell_Seiga.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, 100679639);
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x001B237C File Offset: 0x001B057C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203922, XrefRangeEnd = 203924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seiga.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x001B23C0 File Offset: 0x001B05C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203924, XrefRangeEnd = 203930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seiga.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x001B241C File Offset: 0x001B061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203930, XrefRangeEnd = 203936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Seiga.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x001B2478 File Offset: 0x001B0678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Seiga() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x0002AEA8 File Offset: 0x000290A8
		public Spell_Seiga(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x001B24B4 File Offset: 0x001B06B4
		// (set) Token: 0x060050F0 RID: 20720 RVA: 0x0002AEB1 File Offset: 0x000290B1
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x001B24DC File Offset: 0x001B06DC
		// (set) Token: 0x060050F2 RID: 20722 RVA: 0x0002AECC File Offset: 0x000290CC
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x060050F3 RID: 20723 RVA: 0x001B2504 File Offset: 0x001B0704
		// (set) Token: 0x060050F4 RID: 20724 RVA: 0x0002AEE7 File Offset: 0x000290E7
		public unsafe float extraNegativeSpellcardRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_extraNegativeSpellcardRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_extraNegativeSpellcardRate)) = value;
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x001B252C File Offset: 0x001B072C
		// (set) Token: 0x060050F6 RID: 20726 RVA: 0x0002AF02 File Offset: 0x00029102
		public unsafe GameObject DoorEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_DoorEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_DoorEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x001B255C File Offset: 0x001B075C
		// (set) Token: 0x060050F8 RID: 20728 RVA: 0x0002AF21 File Offset: 0x00029121
		public unsafe GameObject magicEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_magicEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_magicEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x001B258C File Offset: 0x001B078C
		// (set) Token: 0x060050FA RID: 20730 RVA: 0x0002AF40 File Offset: 0x00029140
		public unsafe GameObject demonFaceEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_demonFaceEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_demonFaceEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x001B25BC File Offset: 0x001B07BC
		// (set) Token: 0x060050FC RID: 20732 RVA: 0x0002AF5F File Offset: 0x0002915F
		public SpellBase.DelayAudioClip doorOpenSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_doorOpenSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_doorOpenSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x001B25EC File Offset: 0x001B07EC
		// (set) Token: 0x060050FE RID: 20734 RVA: 0x0002AF8D File Offset: 0x0002918D
		public SpellBase.DelayAudioClip magicSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_magicSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_magicSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x001B261C File Offset: 0x001B081C
		// (set) Token: 0x06005100 RID: 20736 RVA: 0x0002AFBB File Offset: 0x000291BB
		public unsafe AudioClip blackMagicSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_blackMagicSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_blackMagicSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x001B264C File Offset: 0x001B084C
		// (set) Token: 0x06005102 RID: 20738 RVA: 0x0002AFDA File Offset: 0x000291DA
		public unsafe AudioClip demonSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_demonSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.NativeFieldInfoPtr_demonSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeFieldInfoPtr_extraNegativeSpellcardRate;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeFieldInfoPtr_DoorEffect;

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeFieldInfoPtr_magicEffect;

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeFieldInfoPtr_demonFaceEffect;

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeFieldInfoPtr_doorOpenSFX;

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeFieldInfoPtr_magicSFX;

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeFieldInfoPtr_blackMagicSFX;

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeFieldInfoPtr_demonSFX;

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBD RID: 3005
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seiga+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB8E RID: 56206 RVA: 0x0035471C File Offset: 0x0035291C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr);
				Spell_Seiga.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				Spell_Seiga.__c__DisplayClass11_0.NativeFieldInfoPtr_onBuffEndAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, "onBuffEndAction");
				Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, 100679640);
				Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, 100679641);
				Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, 100679642);
				Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, 100679643);
				Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr, 100679644);
			}

			// Token: 0x0600DB8F RID: 56207 RVA: 0x003547D4 File Offset: 0x003529D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB90 RID: 56208 RVA: 0x00354810 File Offset: 0x00352A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203696, XrefRangeEnd = 203707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_String_PDM_0(int currentTime, string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DB91 RID: 56209 RVA: 0x00354868 File Offset: 0x00352A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203707, XrefRangeEnd = 203741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB92 RID: 56210 RVA: 0x003548AC File Offset: 0x00352AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203741, XrefRangeEnd = 203742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialGuestsController_Action_PDM_0(SpecialGuestsController specialGuestsController, Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestsController);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB93 RID: 56211 RVA: 0x00354900 File Offset: 0x00352B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203742, XrefRangeEnd = 203752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB94 RID: 56212 RVA: 0x00075556 File Offset: 0x00073756
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004761 RID: 18273
			// (get) Token: 0x0600DB95 RID: 56213 RVA: 0x00354934 File Offset: 0x00352B34
			// (set) Token: 0x0600DB96 RID: 56214 RVA: 0x0007555F File Offset: 0x0007375F
			public unsafe Spell_Seiga __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004762 RID: 18274
			// (get) Token: 0x0600DB97 RID: 56215 RVA: 0x00354964 File Offset: 0x00352B64
			// (set) Token: 0x0600DB98 RID: 56216 RVA: 0x0007557E File Offset: 0x0007377E
			public unsafe Action onBuffEndAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_0.NativeFieldInfoPtr_onBuffEndAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_0.NativeFieldInfoPtr_onBuffEndAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CAF RID: 36015
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CB0 RID: 36016
			private static readonly IntPtr NativeFieldInfoPtr_onBuffEndAction;

			// Token: 0x04008CB1 RID: 36017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CB2 RID: 36018
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0;

			// Token: 0x04008CB3 RID: 36019
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04008CB4 RID: 36020
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_Action_PDM_0;

			// Token: 0x04008CB5 RID: 36021
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000BBE RID: 3006
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seiga+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DB99 RID: 56217 RVA: 0x00354994 File Offset: 0x00352B94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr);
				Spell_Seiga.__c__DisplayClass11_1.NativeFieldInfoPtr_specguest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr, "specguest");
				Spell_Seiga.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Seiga.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr, 100679645);
				Spell_Seiga.__c__DisplayClass11_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr, 100679646);
			}

			// Token: 0x0600DB9A RID: 56218 RVA: 0x00354A10 File Offset: 0x00352C10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB9B RID: 56219 RVA: 0x00354A4C File Offset: 0x00352C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203752, XrefRangeEnd = 203764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass11_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB9C RID: 56220 RVA: 0x0007559D File Offset: 0x0007379D
			public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004763 RID: 18275
			// (get) Token: 0x0600DB9D RID: 56221 RVA: 0x00354A80 File Offset: 0x00352C80
			// (set) Token: 0x0600DB9E RID: 56222 RVA: 0x000755A6 File Offset: 0x000737A6
			public unsafe SpecialGuestsController specguest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_1.NativeFieldInfoPtr_specguest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_1.NativeFieldInfoPtr_specguest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004764 RID: 18276
			// (get) Token: 0x0600DB9F RID: 56223 RVA: 0x00354AB0 File Offset: 0x00352CB0
			// (set) Token: 0x0600DBA0 RID: 56224 RVA: 0x000755C5 File Offset: 0x000737C5
			public unsafe Spell_Seiga.__c__DisplayClass11_0 field_Public___c__DisplayClass11_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CB6 RID: 36022
			private static readonly IntPtr NativeFieldInfoPtr_specguest;

			// Token: 0x04008CB7 RID: 36023
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0;

			// Token: 0x04008CB8 RID: 36024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CB9 RID: 36025
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_0;
		}

		// Token: 0x02000BBF RID: 3007
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seiga+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DBA1 RID: 56225 RVA: 0x00354AE0 File Offset: 0x00352CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr);
				Spell_Seiga.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, "<>9");
				Spell_Seiga.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, "<>9__11_0");
				Spell_Seiga.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, "<>9__11_5");
				Spell_Seiga.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, "<>9__12_1");
				Spell_Seiga.__c.NativeFieldInfoPtr___9__12_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, "<>9__12_4");
				Spell_Seiga.__c.NativeFieldInfoPtr___9__12_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, "<>9__12_5");
				Spell_Seiga.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, 100679648);
				Spell_Seiga.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_0_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, 100679649);
				Spell_Seiga.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_5_Internal_IEnumerable_1_AStarInputGeneratorComponent_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, 100679650);
				Spell_Seiga.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_1_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, 100679651);
				Spell_Seiga.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_4_Internal_Void_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, 100679652);
				Spell_Seiga.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_5_Internal_Void_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr, 100679653);
			}

			// Token: 0x0600DBA2 RID: 56226 RVA: 0x00354BFC File Offset: 0x00352DFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA3 RID: 56227 RVA: 0x00354C38 File Offset: 0x00352E38
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__11_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_0_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBA4 RID: 56228 RVA: 0x00354C88 File Offset: 0x00352E88
			[CallerCount(0)]
			public unsafe IEnumerable<AStarInputGeneratorComponent> _OnNegativeBuffExecute_b__11_5(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_5_Internal_IEnumerable_1_AStarInputGeneratorComponent_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AStarInputGeneratorComponent>>(intPtr3) : null;
			}

			// Token: 0x0600DBA5 RID: 56229 RVA: 0x00354CD8 File Offset: 0x00352ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203764, XrefRangeEnd = 203765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__12_1(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_1_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBA6 RID: 56230 RVA: 0x00354D28 File Offset: 0x00352F28
			[CallerCount(0)]
			public unsafe void _OnPositiveBuffExecute_b__12_4(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_4_Internal_Void_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA7 RID: 56231 RVA: 0x00354D6C File Offset: 0x00352F6C
			[CallerCount(0)]
			public unsafe void _OnPositiveBuffExecute_b__12_5(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_5_Internal_Void_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA8 RID: 56232 RVA: 0x000755E4 File Offset: 0x000737E4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004765 RID: 18277
			// (get) Token: 0x0600DBA9 RID: 56233 RVA: 0x00354DB0 File Offset: 0x00352FB0
			// (set) Token: 0x0600DBAA RID: 56234 RVA: 0x000755ED File Offset: 0x000737ED
			public unsafe static Spell_Seiga.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seiga.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seiga.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004766 RID: 18278
			// (get) Token: 0x0600DBAB RID: 56235 RVA: 0x00354DD8 File Offset: 0x00352FD8
			// (set) Token: 0x0600DBAC RID: 56236 RVA: 0x000755FF File Offset: 0x000737FF
			public unsafe static Func<GuestGroupController, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004767 RID: 18279
			// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x00354E00 File Offset: 0x00353000
			// (set) Token: 0x0600DBAE RID: 56238 RVA: 0x00075611 File Offset: 0x00073811
			public unsafe static Func<GuestGroupController, IEnumerable<AStarInputGeneratorComponent>> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, IEnumerable<AStarInputGeneratorComponent>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004768 RID: 18280
			// (get) Token: 0x0600DBAF RID: 56239 RVA: 0x00354E28 File Offset: 0x00353028
			// (set) Token: 0x0600DBB0 RID: 56240 RVA: 0x00075623 File Offset: 0x00073823
			public unsafe static Func<PartnerBase, bool> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004769 RID: 18281
			// (get) Token: 0x0600DBB1 RID: 56241 RVA: 0x00354E50 File Offset: 0x00353050
			// (set) Token: 0x0600DBB2 RID: 56242 RVA: 0x00075635 File Offset: 0x00073835
			public unsafe static Action<PartnerBase> __9__12_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__12_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartnerBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__12_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700476A RID: 18282
			// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x00354E78 File Offset: 0x00353078
			// (set) Token: 0x0600DBB4 RID: 56244 RVA: 0x00075647 File Offset: 0x00073847
			public unsafe static Action<PartnerBase> __9__12_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__12_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartnerBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Seiga.__c.NativeFieldInfoPtr___9__12_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CBA RID: 36026
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008CBB RID: 36027
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008CBC RID: 36028
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x04008CBD RID: 36029
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04008CBE RID: 36030
			private static readonly IntPtr NativeFieldInfoPtr___9__12_4;

			// Token: 0x04008CBF RID: 36031
			private static readonly IntPtr NativeFieldInfoPtr___9__12_5;

			// Token: 0x04008CC0 RID: 36032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CC1 RID: 36033
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_0_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008CC2 RID: 36034
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_5_Internal_IEnumerable_1_AStarInputGeneratorComponent_GuestGroupController_0;

			// Token: 0x04008CC3 RID: 36035
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_1_Internal_Boolean_PartnerBase_0;

			// Token: 0x04008CC4 RID: 36036
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_4_Internal_Void_PartnerBase_0;

			// Token: 0x04008CC5 RID: 36037
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_5_Internal_Void_PartnerBase_0;
		}

		// Token: 0x02000BC0 RID: 3008
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seiga+<OnNegativeBuffExecute>d__11")]
		public sealed class _OnNegativeBuffExecute_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600DBB5 RID: 56245 RVA: 0x00354EA0 File Offset: 0x003530A0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__11()
			{
				Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "<OnNegativeBuffExecute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr);
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>1__state");
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>2__current");
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>4__this");
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, "spellExecutionContext");
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>8__1");
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679654);
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679655);
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679656);
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679657);
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679658);
				Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679659);
			}

			// Token: 0x0600DBB6 RID: 56246 RVA: 0x00354FA8 File Offset: 0x003531A8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga._OnNegativeBuffExecute_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB7 RID: 56247 RVA: 0x00354FF0 File Offset: 0x003531F0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB8 RID: 56248 RVA: 0x00355024 File Offset: 0x00353224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203765, XrefRangeEnd = 203818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004770 RID: 18288
			// (get) Token: 0x0600DBB9 RID: 56249 RVA: 0x00355060 File Offset: 0x00353260
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DBBA RID: 56250 RVA: 0x003550A0 File Offset: 0x003532A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203818, XrefRangeEnd = 203824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004771 RID: 18289
			// (get) Token: 0x0600DBBB RID: 56251 RVA: 0x003550D4 File Offset: 0x003532D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DBBC RID: 56252 RVA: 0x00075659 File Offset: 0x00073859
			public _OnNegativeBuffExecute_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700476B RID: 18283
			// (get) Token: 0x0600DBBD RID: 56253 RVA: 0x00355114 File Offset: 0x00353314
			// (set) Token: 0x0600DBBE RID: 56254 RVA: 0x00075662 File Offset: 0x00073862
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700476C RID: 18284
			// (get) Token: 0x0600DBBF RID: 56255 RVA: 0x0035513C File Offset: 0x0035333C
			// (set) Token: 0x0600DBC0 RID: 56256 RVA: 0x0007567D File Offset: 0x0007387D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700476D RID: 18285
			// (get) Token: 0x0600DBC1 RID: 56257 RVA: 0x0035516C File Offset: 0x0035336C
			// (set) Token: 0x0600DBC2 RID: 56258 RVA: 0x0007569C File Offset: 0x0007389C
			public unsafe Spell_Seiga __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700476E RID: 18286
			// (get) Token: 0x0600DBC3 RID: 56259 RVA: 0x0035519C File Offset: 0x0035339C
			// (set) Token: 0x0600DBC4 RID: 56260 RVA: 0x000756BB File Offset: 0x000738BB
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700476F RID: 18287
			// (get) Token: 0x0600DBC5 RID: 56261 RVA: 0x003551CC File Offset: 0x003533CC
			// (set) Token: 0x0600DBC6 RID: 56262 RVA: 0x000756DA File Offset: 0x000738DA
			public unsafe Spell_Seiga.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CC6 RID: 36038
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CC7 RID: 36039
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CC8 RID: 36040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CC9 RID: 36041
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008CCA RID: 36042
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008CCB RID: 36043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CCC RID: 36044
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CCD RID: 36045
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CCE RID: 36046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CCF RID: 36047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CD0 RID: 36048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BC1 RID: 3009
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seiga+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBC7 RID: 56263 RVA: 0x003551FC File Offset: 0x003533FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr);
				Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr_allPartnerToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, "allPartnerToCheck");
				Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, 100679660);
				Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, 100679661);
				Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, 100679662);
				Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr, 100679663);
			}

			// Token: 0x0600DBC8 RID: 56264 RVA: 0x003552B4 File Offset: 0x003534B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC9 RID: 56265 RVA: 0x003552F0 File Offset: 0x003534F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203824, XrefRangeEnd = 203830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBCA RID: 56266 RVA: 0x00355334 File Offset: 0x00353534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203830, XrefRangeEnd = 203856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBCB RID: 56267 RVA: 0x00355374 File Offset: 0x00353574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203856, XrefRangeEnd = 203875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBCC RID: 56268 RVA: 0x000756F9 File Offset: 0x000738F9
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004772 RID: 18290
			// (get) Token: 0x0600DBCD RID: 56269 RVA: 0x003553A8 File Offset: 0x003535A8
			// (set) Token: 0x0600DBCE RID: 56270 RVA: 0x00075702 File Offset: 0x00073902
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004773 RID: 18291
			// (get) Token: 0x0600DBCF RID: 56271 RVA: 0x003553D8 File Offset: 0x003535D8
			// (set) Token: 0x0600DBD0 RID: 56272 RVA: 0x00075721 File Offset: 0x00073921
			public unsafe Il2CppReferenceArray<PartnerBase> allPartnerToCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr_allPartnerToCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PartnerBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr_allPartnerToCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004774 RID: 18292
			// (get) Token: 0x0600DBD1 RID: 56273 RVA: 0x00355408 File Offset: 0x00353608
			// (set) Token: 0x0600DBD2 RID: 56274 RVA: 0x00075740 File Offset: 0x00073940
			public unsafe Spell_Seiga __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CD1 RID: 36049
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008CD2 RID: 36050
			private static readonly IntPtr NativeFieldInfoPtr_allPartnerToCheck;

			// Token: 0x04008CD3 RID: 36051
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CD4 RID: 36052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CD5 RID: 36053
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008CD6 RID: 36054
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0;

			// Token: 0x04008CD7 RID: 36055
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000BC2 RID: 3010
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Seiga+<OnPositiveBuffExecute>d__12")]
		public sealed class _OnPositiveBuffExecute_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600DBD3 RID: 56275 RVA: 0x00355438 File Offset: 0x00353638
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__12()
			{
				Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Seiga>.NativeClassPtr, "<OnPositiveBuffExecute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr);
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>1__state");
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>2__current");
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, "spellExecutionContext");
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>4__this");
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>8__1");
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100679664);
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100679665);
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100679666);
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100679667);
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100679668);
				Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100679669);
			}

			// Token: 0x0600DBD4 RID: 56276 RVA: 0x00355540 File Offset: 0x00353740
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Seiga._OnPositiveBuffExecute_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBD5 RID: 56277 RVA: 0x00355588 File Offset: 0x00353788
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBD6 RID: 56278 RVA: 0x003555BC File Offset: 0x003537BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203875, XrefRangeEnd = 203916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700477A RID: 18298
			// (get) Token: 0x0600DBD7 RID: 56279 RVA: 0x003555F8 File Offset: 0x003537F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DBD8 RID: 56280 RVA: 0x00355638 File Offset: 0x00353838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203916, XrefRangeEnd = 203922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700477B RID: 18299
			// (get) Token: 0x0600DBD9 RID: 56281 RVA: 0x0035566C File Offset: 0x0035386C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DBDA RID: 56282 RVA: 0x0007575F File Offset: 0x0007395F
			public _OnPositiveBuffExecute_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004775 RID: 18293
			// (get) Token: 0x0600DBDB RID: 56283 RVA: 0x003556AC File Offset: 0x003538AC
			// (set) Token: 0x0600DBDC RID: 56284 RVA: 0x00075768 File Offset: 0x00073968
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004776 RID: 18294
			// (get) Token: 0x0600DBDD RID: 56285 RVA: 0x003556D4 File Offset: 0x003538D4
			// (set) Token: 0x0600DBDE RID: 56286 RVA: 0x00075783 File Offset: 0x00073983
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004777 RID: 18295
			// (get) Token: 0x0600DBDF RID: 56287 RVA: 0x00355704 File Offset: 0x00353904
			// (set) Token: 0x0600DBE0 RID: 56288 RVA: 0x000757A2 File Offset: 0x000739A2
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004778 RID: 18296
			// (get) Token: 0x0600DBE1 RID: 56289 RVA: 0x00355734 File Offset: 0x00353934
			// (set) Token: 0x0600DBE2 RID: 56290 RVA: 0x000757C1 File Offset: 0x000739C1
			public unsafe Spell_Seiga __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004779 RID: 18297
			// (get) Token: 0x0600DBE3 RID: 56291 RVA: 0x00355764 File Offset: 0x00353964
			// (set) Token: 0x0600DBE4 RID: 56292 RVA: 0x000757E0 File Offset: 0x000739E0
			public unsafe Spell_Seiga.__c__DisplayClass12_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Seiga.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Seiga._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CD8 RID: 36056
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CD9 RID: 36057
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CDA RID: 36058
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008CDB RID: 36059
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CDC RID: 36060
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008CDD RID: 36061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CDE RID: 36062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CDF RID: 36063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CE0 RID: 36064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CE1 RID: 36065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CE2 RID: 36066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
