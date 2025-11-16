using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200028E RID: 654
	public class Spell_Utsuho : SpellBase
	{
		// Token: 0x060052BC RID: 21180 RVA: 0x001B6F70 File Offset: 0x001B5170
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Utsuho()
		{
			Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Utsuho");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr);
			Spell_Utsuho.NativeFieldInfoPtr_postiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "postiveDuration");
			Spell_Utsuho.NativeFieldInfoPtr_cookerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "cookerTypes");
			Spell_Utsuho.NativeFieldInfoPtr_multiper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "multiper");
			Spell_Utsuho.NativeFieldInfoPtr_scaredGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "scaredGuestNum");
			Spell_Utsuho.NativeFieldInfoPtr_tokamakEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "tokamakEffect");
			Spell_Utsuho.NativeFieldInfoPtr_flareEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "flareEffect");
			Spell_Utsuho.NativeFieldInfoPtr_controlRodEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "controlRodEffect");
			Spell_Utsuho.NativeFieldInfoPtr_nuclearFireEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "nuclearFireEffect");
			Spell_Utsuho.NativeFieldInfoPtr_scaredGuestsTXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "scaredGuestsTXT");
			Spell_Utsuho.NativeFieldInfoPtr_nuclearEffectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "nuclearEffectParent");
			Spell_Utsuho.NativeFieldInfoPtr_brokenCookParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "brokenCookParent");
			Spell_Utsuho.NativeFieldInfoPtr_bomb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "bomb");
			Spell_Utsuho.NativeFieldInfoPtr_warningSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "warningSFX");
			Spell_Utsuho.NativeFieldInfoPtr_nuclearEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "nuclearEffectDuration");
			Spell_Utsuho.NativeFieldInfoPtr_warningDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "warningDuration");
			Spell_Utsuho.NativeFieldInfoPtr_dropSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "dropSFX");
			Spell_Utsuho.NativeFieldInfoPtr_chargeSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "chargeSFX");
			Spell_Utsuho.NativeFieldInfoPtr_boomSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "boomSFX");
			Spell_Utsuho.NativeFieldInfoPtr_energySFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "energySFX");
			Spell_Utsuho.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "punishmentSFX");
			Spell_Utsuho.NativeFieldInfoPtr_punishmentFireSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "punishmentFireSFX");
			Spell_Utsuho.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680100);
			Spell_Utsuho.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680101);
			Spell_Utsuho.NativeMethodInfoPtr_NuclearBombWhenQteFail_Private_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680102);
			Spell_Utsuho.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680103);
			Spell_Utsuho.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680104);
			Spell_Utsuho.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680105);
			Spell_Utsuho.NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_1_Private_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680106);
			Spell_Utsuho.NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, 100680107);
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x001B71E4 File Offset: 0x001B53E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207761, XrefRangeEnd = 207763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Utsuho.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x001B7228 File Offset: 0x001B5428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207763, XrefRangeEnd = 207769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Utsuho.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x001B7284 File Offset: 0x001B5484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207769, XrefRangeEnd = 207781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NuclearBombWhenQteFail(CookController cookController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.NativeMethodInfoPtr_NuclearBombWhenQteFail_Private_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x001B72C8 File Offset: 0x001B54C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207781, XrefRangeEnd = 207786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Utsuho.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x001B7324 File Offset: 0x001B5524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Utsuho() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x001B7360 File Offset: 0x001B5560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207786, XrefRangeEnd = 207790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Int32_String_PDM_0(int currentTime, string buffDescription)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x001B73AC File Offset: 0x001B55AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207790, XrefRangeEnd = 207801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPositiveBuffExecute_b__24_1(CookController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_1_Private_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x001B73FC File Offset: 0x001B55FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207801, XrefRangeEnd = 207809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__24_3(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0002C469 File Offset: 0x0002A669
		public Spell_Utsuho(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x001B743C File Offset: 0x001B563C
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x0002C472 File Offset: 0x0002A672
		public unsafe int postiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_postiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_postiveDuration)) = value;
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x001B7464 File Offset: 0x001B5664
		// (set) Token: 0x060052C9 RID: 21193 RVA: 0x0002C48D File Offset: 0x0002A68D
		public unsafe Il2CppStructArray<Cooker.CookerType> cookerTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_cookerTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Cooker.CookerType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_cookerTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x001B7494 File Offset: 0x001B5694
		// (set) Token: 0x060052CB RID: 21195 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		public unsafe float multiper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_multiper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_multiper)) = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x001B74BC File Offset: 0x001B56BC
		// (set) Token: 0x060052CD RID: 21197 RVA: 0x0002C4C7 File Offset: 0x0002A6C7
		public unsafe Vector2Int scaredGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_scaredGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_scaredGuestNum)) = value;
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x001B74E4 File Offset: 0x001B56E4
		// (set) Token: 0x060052CF RID: 21199 RVA: 0x0002C4E2 File Offset: 0x0002A6E2
		public unsafe GameObject tokamakEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_tokamakEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_tokamakEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x060052D0 RID: 21200 RVA: 0x001B7514 File Offset: 0x001B5714
		// (set) Token: 0x060052D1 RID: 21201 RVA: 0x0002C501 File Offset: 0x0002A701
		public unsafe GameObject flareEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_flareEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_flareEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x060052D2 RID: 21202 RVA: 0x001B7544 File Offset: 0x001B5744
		// (set) Token: 0x060052D3 RID: 21203 RVA: 0x0002C520 File Offset: 0x0002A720
		public unsafe GameObject controlRodEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_controlRodEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_controlRodEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x001B7574 File Offset: 0x001B5774
		// (set) Token: 0x060052D5 RID: 21205 RVA: 0x0002C53F File Offset: 0x0002A73F
		public unsafe GameObject nuclearFireEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_nuclearFireEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_nuclearFireEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x001B75A4 File Offset: 0x001B57A4
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x0002C55E File Offset: 0x0002A75E
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset scaredGuestsTXT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_scaredGuestsTXT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_scaredGuestsTXT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x001B75D4 File Offset: 0x001B57D4
		// (set) Token: 0x060052D9 RID: 21209 RVA: 0x0002C57D File Offset: 0x0002A77D
		public unsafe GameObject nuclearEffectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_nuclearEffectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_nuclearEffectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x001B7604 File Offset: 0x001B5804
		// (set) Token: 0x060052DB RID: 21211 RVA: 0x0002C59C File Offset: 0x0002A79C
		public unsafe GameObject brokenCookParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_brokenCookParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_brokenCookParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x001B7634 File Offset: 0x001B5834
		// (set) Token: 0x060052DD RID: 21213 RVA: 0x0002C5BB File Offset: 0x0002A7BB
		public unsafe AudioClip bomb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_bomb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_bomb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x060052DE RID: 21214 RVA: 0x001B7664 File Offset: 0x001B5864
		// (set) Token: 0x060052DF RID: 21215 RVA: 0x0002C5DA File Offset: 0x0002A7DA
		public unsafe LoopedBGMPackage warningSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_warningSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_warningSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x060052E0 RID: 21216 RVA: 0x001B7694 File Offset: 0x001B5894
		// (set) Token: 0x060052E1 RID: 21217 RVA: 0x0002C5F9 File Offset: 0x0002A7F9
		public unsafe float nuclearEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_nuclearEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_nuclearEffectDuration)) = value;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x060052E2 RID: 21218 RVA: 0x001B76BC File Offset: 0x001B58BC
		// (set) Token: 0x060052E3 RID: 21219 RVA: 0x0002C614 File Offset: 0x0002A814
		public unsafe float warningDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_warningDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_warningDuration)) = value;
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x060052E4 RID: 21220 RVA: 0x001B76E4 File Offset: 0x001B58E4
		// (set) Token: 0x060052E5 RID: 21221 RVA: 0x0002C62F File Offset: 0x0002A82F
		public SpellBase.DelayAudioClip dropSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_dropSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_dropSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x060052E6 RID: 21222 RVA: 0x001B7714 File Offset: 0x001B5914
		// (set) Token: 0x060052E7 RID: 21223 RVA: 0x0002C65D File Offset: 0x0002A85D
		public SpellBase.DelayAudioClip chargeSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_chargeSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_chargeSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x060052E8 RID: 21224 RVA: 0x001B7744 File Offset: 0x001B5944
		// (set) Token: 0x060052E9 RID: 21225 RVA: 0x0002C68B File Offset: 0x0002A88B
		public SpellBase.DelayAudioClip boomSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_boomSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_boomSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x001B7774 File Offset: 0x001B5974
		// (set) Token: 0x060052EB RID: 21227 RVA: 0x0002C6B9 File Offset: 0x0002A8B9
		public unsafe AudioClip energySFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_energySFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_energySFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x060052EC RID: 21228 RVA: 0x001B77A4 File Offset: 0x001B59A4
		// (set) Token: 0x060052ED RID: 21229 RVA: 0x0002C6D8 File Offset: 0x0002A8D8
		public SpellBase.DelayAudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_punishmentSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_punishmentSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x001B77D4 File Offset: 0x001B59D4
		// (set) Token: 0x060052EF RID: 21231 RVA: 0x0002C706 File Offset: 0x0002A906
		public unsafe AudioClip punishmentFireSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_punishmentFireSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.NativeFieldInfoPtr_punishmentFireSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeFieldInfoPtr_postiveDuration;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeFieldInfoPtr_cookerTypes;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeFieldInfoPtr_multiper;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeFieldInfoPtr_scaredGuestNum;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeFieldInfoPtr_tokamakEffect;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeFieldInfoPtr_flareEffect;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeFieldInfoPtr_controlRodEffect;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeFieldInfoPtr_nuclearFireEffect;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeFieldInfoPtr_scaredGuestsTXT;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffectParent;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeFieldInfoPtr_brokenCookParent;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeFieldInfoPtr_bomb;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeFieldInfoPtr_warningSFX;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeFieldInfoPtr_nuclearEffectDuration;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeFieldInfoPtr_warningDuration;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeFieldInfoPtr_dropSFX;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeFieldInfoPtr_chargeSFX;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeFieldInfoPtr_boomSFX;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeFieldInfoPtr_energySFX;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeFieldInfoPtr_punishmentFireSFX;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_NuclearBombWhenQteFail_Private_Void_CookController_0;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_1_Private_Boolean_CookController_0;

		// Token: 0x040037DF RID: 14303
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_3_Private_Void_Int32_0;

		// Token: 0x02000BFF RID: 3071
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF3E RID: 57150 RVA: 0x0035F8A4 File Offset: 0x0035DAA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr);
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_rod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "rod");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "line");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "endPoint");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "startPoint");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_targetsLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "targetsLast");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_fires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "fires");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "<>9__8");
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680108);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680109);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_LineRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680110);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680111);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680112);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680113);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680114);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680115);
				Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, 100680116);
			}

			// Token: 0x0600DF3F RID: 57151 RVA: 0x0035FA24 File Offset: 0x0035DC24
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF40 RID: 57152 RVA: 0x0035FA60 File Offset: 0x0035DC60
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF41 RID: 57153 RVA: 0x0035FAA4 File Offset: 0x0035DCA4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(LineRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_LineRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF42 RID: 57154 RVA: 0x0035FAE8 File Offset: 0x0035DCE8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__3(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF43 RID: 57155 RVA: 0x0035FB2C File Offset: 0x0035DD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__4(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF44 RID: 57156 RVA: 0x0035FB70 File Offset: 0x0035DD70
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF45 RID: 57157 RVA: 0x0035FBAC File Offset: 0x0035DDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207420, XrefRangeEnd = 207427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__8(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF46 RID: 57158 RVA: 0x0035FBF0 File Offset: 0x0035DDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207427, XrefRangeEnd = 207432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF47 RID: 57159 RVA: 0x0035FC30 File Offset: 0x0035DE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207432, XrefRangeEnd = 207443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF48 RID: 57160 RVA: 0x0007731D File Offset: 0x0007551D
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004885 RID: 18565
			// (get) Token: 0x0600DF49 RID: 57161 RVA: 0x0035FC64 File Offset: 0x0035DE64
			// (set) Token: 0x0600DF4A RID: 57162 RVA: 0x00077326 File Offset: 0x00075526
			public unsafe GameObject rod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_rod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_rod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004886 RID: 18566
			// (get) Token: 0x0600DF4B RID: 57163 RVA: 0x0035FC94 File Offset: 0x0035DE94
			// (set) Token: 0x0600DF4C RID: 57164 RVA: 0x00077345 File Offset: 0x00075545
			public unsafe LineRenderer line
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_line);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004887 RID: 18567
			// (get) Token: 0x0600DF4D RID: 57165 RVA: 0x0035FCC4 File Offset: 0x0035DEC4
			// (set) Token: 0x0600DF4E RID: 57166 RVA: 0x00077364 File Offset: 0x00075564
			public unsafe Transform endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_endPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004888 RID: 18568
			// (get) Token: 0x0600DF4F RID: 57167 RVA: 0x0035FCF4 File Offset: 0x0035DEF4
			// (set) Token: 0x0600DF50 RID: 57168 RVA: 0x00077383 File Offset: 0x00075583
			public unsafe Transform startPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_startPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004889 RID: 18569
			// (get) Token: 0x0600DF51 RID: 57169 RVA: 0x0035FD24 File Offset: 0x0035DF24
			// (set) Token: 0x0600DF52 RID: 57170 RVA: 0x000773A2 File Offset: 0x000755A2
			public unsafe Vector3 targetsLast
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_targetsLast);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_targetsLast)) = value;
				}
			}

			// Token: 0x1700488A RID: 18570
			// (get) Token: 0x0600DF53 RID: 57171 RVA: 0x0035FD4C File Offset: 0x0035DF4C
			// (set) Token: 0x0600DF54 RID: 57172 RVA: 0x000773BD File Offset: 0x000755BD
			public unsafe List<ParticleSystem> fires
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_fires);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr_fires), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700488B RID: 18571
			// (get) Token: 0x0600DF55 RID: 57173 RVA: 0x0035FD7C File Offset: 0x0035DF7C
			// (set) Token: 0x0600DF56 RID: 57174 RVA: 0x000773DC File Offset: 0x000755DC
			public unsafe Spell_Utsuho __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700488C RID: 18572
			// (get) Token: 0x0600DF57 RID: 57175 RVA: 0x0035FDAC File Offset: 0x0035DFAC
			// (set) Token: 0x0600DF58 RID: 57176 RVA: 0x000773FB File Offset: 0x000755FB
			public unsafe Action<GameObject> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EE2 RID: 36578
			private static readonly IntPtr NativeFieldInfoPtr_rod;

			// Token: 0x04008EE3 RID: 36579
			private static readonly IntPtr NativeFieldInfoPtr_line;

			// Token: 0x04008EE4 RID: 36580
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04008EE5 RID: 36581
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x04008EE6 RID: 36582
			private static readonly IntPtr NativeFieldInfoPtr_targetsLast;

			// Token: 0x04008EE7 RID: 36583
			private static readonly IntPtr NativeFieldInfoPtr_fires;

			// Token: 0x04008EE8 RID: 36584
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EE9 RID: 36585
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x04008EEA RID: 36586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EEB RID: 36587
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0;

			// Token: 0x04008EEC RID: 36588
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_LineRenderer_0;

			// Token: 0x04008EED RID: 36589
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_Transform_0;

			// Token: 0x04008EEE RID: 36590
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_Transform_0;

			// Token: 0x04008EEF RID: 36591
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Vector3_0;

			// Token: 0x04008EF0 RID: 36592
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_GameObject_0;

			// Token: 0x04008EF1 RID: 36593
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008EF2 RID: 36594
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0;

			// Token: 0x0200104A RID: 4170
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<>c__DisplayClass22_0+<<OnNegativeBuffExecute>g__StopFire|6>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D4A RID: 73034 RVA: 0x00414A60 File Offset: 0x00412C60
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__StopFire|6>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680117);
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680118);
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680119);
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680120);
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680121);
					Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680122);
				}

				// Token: 0x06011D4B RID: 73035 RVA: 0x00414B40 File Offset: 0x00412D40
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D4C RID: 73036 RVA: 0x00414B88 File Offset: 0x00412D88
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D4D RID: 73037 RVA: 0x00414BBC File Offset: 0x00412DBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207405, XrefRangeEnd = 207414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CE8 RID: 23784
				// (get) Token: 0x06011D4E RID: 73038 RVA: 0x00414BF8 File Offset: 0x00412DF8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D4F RID: 73039 RVA: 0x00414C38 File Offset: 0x00412E38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207414, XrefRangeEnd = 207420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CE9 RID: 23785
				// (get) Token: 0x06011D50 RID: 73040 RVA: 0x00414C6C File Offset: 0x00412E6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D51 RID: 73041 RVA: 0x0009AE91 File Offset: 0x00099091
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CE5 RID: 23781
				// (get) Token: 0x06011D52 RID: 73042 RVA: 0x00414CAC File Offset: 0x00412EAC
				// (set) Token: 0x06011D53 RID: 73043 RVA: 0x0009AE9A File Offset: 0x0009909A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CE6 RID: 23782
				// (get) Token: 0x06011D54 RID: 73044 RVA: 0x00414CD4 File Offset: 0x00412ED4
				// (set) Token: 0x06011D55 RID: 73045 RVA: 0x0009AEB5 File Offset: 0x000990B5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CE7 RID: 23783
				// (get) Token: 0x06011D56 RID: 73046 RVA: 0x00414D04 File Offset: 0x00412F04
				// (set) Token: 0x06011D57 RID: 73047 RVA: 0x0009AED4 File Offset: 0x000990D4
				public unsafe Spell_Utsuho.__c__DisplayClass22_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho.__c__DisplayClass22_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B43A RID: 46138
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B43B RID: 46139
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B43C RID: 46140
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B43D RID: 46141
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B43E RID: 46142
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B43F RID: 46143
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B440 RID: 46144
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B441 RID: 46145
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B442 RID: 46146
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C00 RID: 3072
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DF59 RID: 57177 RVA: 0x0035FDDC File Offset: 0x0035DFDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr);
				Spell_Utsuho.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, "<>9");
				Spell_Utsuho.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, "<>9__22_0");
				Spell_Utsuho.__c.NativeFieldInfoPtr___9__22_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, "<>9__22_9");
				Spell_Utsuho.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, "<>9__23_1");
				Spell_Utsuho.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, "<>9__23_2");
				Spell_Utsuho.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, "<>9__24_2");
				Spell_Utsuho.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, 100680124);
				Spell_Utsuho.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Vector3_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, 100680125);
				Spell_Utsuho.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_9_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, 100680126);
				Spell_Utsuho.__c.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__23_1_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, 100680127);
				Spell_Utsuho.__c.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__23_2_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, 100680128);
				Spell_Utsuho.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_2_Internal_Vector3Int_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr, 100680129);
			}

			// Token: 0x0600DF5A RID: 57178 RVA: 0x0035FEF8 File Offset: 0x0035E0F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF5B RID: 57179 RVA: 0x0035FF34 File Offset: 0x0035E134
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__22_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Vector3_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF5C RID: 57180 RVA: 0x0035FF84 File Offset: 0x0035E184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__22_9(ParticleSystem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_9_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF5D RID: 57181 RVA: 0x0035FFC8 File Offset: 0x0035E1C8
			[CallerCount(0)]
			public unsafe string _NuclearBombWhenQteFail_b__23_1(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__23_1_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DF5E RID: 57182 RVA: 0x00360010 File Offset: 0x0035E210
			[CallerCount(0)]
			public unsafe bool _NuclearBombWhenQteFail_b__23_2(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__23_2_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF5F RID: 57183 RVA: 0x00360060 File Offset: 0x0035E260
			[CallerCount(0)]
			public unsafe Vector3Int _OnPositiveBuffExecute_b__24_2(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_2_Internal_Vector3Int_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF60 RID: 57184 RVA: 0x0007741A File Offset: 0x0007561A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700488D RID: 18573
			// (get) Token: 0x0600DF61 RID: 57185 RVA: 0x003600B0 File Offset: 0x0035E2B0
			// (set) Token: 0x0600DF62 RID: 57186 RVA: 0x00077423 File Offset: 0x00075623
			public unsafe static Spell_Utsuho.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700488E RID: 18574
			// (get) Token: 0x0600DF63 RID: 57187 RVA: 0x003600D8 File Offset: 0x0035E2D8
			// (set) Token: 0x0600DF64 RID: 57188 RVA: 0x00077435 File Offset: 0x00075635
			public unsafe static Func<CookController, Vector3> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700488F RID: 18575
			// (get) Token: 0x0600DF65 RID: 57189 RVA: 0x00360100 File Offset: 0x0035E300
			// (set) Token: 0x0600DF66 RID: 57190 RVA: 0x00077447 File Offset: 0x00075647
			public unsafe static Action<ParticleSystem> __9__22_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__22_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__22_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004890 RID: 18576
			// (get) Token: 0x0600DF67 RID: 57191 RVA: 0x00360128 File Offset: 0x0035E328
			// (set) Token: 0x0600DF68 RID: 57192 RVA: 0x00077459 File Offset: 0x00075659
			public unsafe static Func<Il2CppStringArray, string> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004891 RID: 18577
			// (get) Token: 0x0600DF69 RID: 57193 RVA: 0x00360150 File Offset: 0x0035E350
			// (set) Token: 0x0600DF6A RID: 57194 RVA: 0x0007746B File Offset: 0x0007566B
			public unsafe static Func<GuestGroupController, bool> __9__23_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__23_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__23_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004892 RID: 18578
			// (get) Token: 0x0600DF6B RID: 57195 RVA: 0x00360178 File Offset: 0x0035E378
			// (set) Token: 0x0600DF6C RID: 57196 RVA: 0x0007747D File Offset: 0x0007567D
			public unsafe static Func<CookController, Vector3Int> __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Utsuho.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EF3 RID: 36595
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EF4 RID: 36596
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04008EF5 RID: 36597
			private static readonly IntPtr NativeFieldInfoPtr___9__22_9;

			// Token: 0x04008EF6 RID: 36598
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04008EF7 RID: 36599
			private static readonly IntPtr NativeFieldInfoPtr___9__23_2;

			// Token: 0x04008EF8 RID: 36600
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x04008EF9 RID: 36601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EFA RID: 36602
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Vector3_CookController_0;

			// Token: 0x04008EFB RID: 36603
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_9_Internal_Void_ParticleSystem_0;

			// Token: 0x04008EFC RID: 36604
			private static readonly IntPtr NativeMethodInfoPtr__NuclearBombWhenQteFail_b__23_1_Internal_String_Il2CppStringArray_0;

			// Token: 0x04008EFD RID: 36605
			private static readonly IntPtr NativeMethodInfoPtr__NuclearBombWhenQteFail_b__23_2_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008EFE RID: 36606
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__24_2_Internal_Vector3Int_CookController_0;
		}

		// Token: 0x02000C01 RID: 3073
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<OnNegativeBuffExecute>d__22")]
		public sealed class _OnNegativeBuffExecute_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600DF6D RID: 57197 RVA: 0x003601A0 File Offset: 0x0035E3A0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__22()
			{
				Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "<OnNegativeBuffExecute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr);
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>1__state");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>2__current");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>4__this");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "spellExecutionContext");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>8__1");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__allControllers_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<allControllers>5__2");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__cookerCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<cookerCount>5__3");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__currentTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<currentTime>5__4");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__currentCooker_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<currentCooker>5__5");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__maxCount_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<maxCount>5__6");
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680130);
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680131);
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680132);
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680133);
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680134);
				Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680135);
			}

			// Token: 0x0600DF6E RID: 57198 RVA: 0x0036030C File Offset: 0x0035E50C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho._OnNegativeBuffExecute_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF6F RID: 57199 RVA: 0x00360354 File Offset: 0x0035E554
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF70 RID: 57200 RVA: 0x00360388 File Offset: 0x0035E588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207443, XrefRangeEnd = 207512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700489D RID: 18589
			// (get) Token: 0x0600DF71 RID: 57201 RVA: 0x003603C4 File Offset: 0x0035E5C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF72 RID: 57202 RVA: 0x00360404 File Offset: 0x0035E604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207512, XrefRangeEnd = 207518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700489E RID: 18590
			// (get) Token: 0x0600DF73 RID: 57203 RVA: 0x00360438 File Offset: 0x0035E638
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF74 RID: 57204 RVA: 0x0007748F File Offset: 0x0007568F
			public _OnNegativeBuffExecute_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004893 RID: 18579
			// (get) Token: 0x0600DF75 RID: 57205 RVA: 0x00360478 File Offset: 0x0035E678
			// (set) Token: 0x0600DF76 RID: 57206 RVA: 0x00077498 File Offset: 0x00075698
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004894 RID: 18580
			// (get) Token: 0x0600DF77 RID: 57207 RVA: 0x003604A0 File Offset: 0x0035E6A0
			// (set) Token: 0x0600DF78 RID: 57208 RVA: 0x000774B3 File Offset: 0x000756B3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004895 RID: 18581
			// (get) Token: 0x0600DF79 RID: 57209 RVA: 0x003604D0 File Offset: 0x0035E6D0
			// (set) Token: 0x0600DF7A RID: 57210 RVA: 0x000774D2 File Offset: 0x000756D2
			public unsafe Spell_Utsuho __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004896 RID: 18582
			// (get) Token: 0x0600DF7B RID: 57211 RVA: 0x00360500 File Offset: 0x0035E700
			// (set) Token: 0x0600DF7C RID: 57212 RVA: 0x000774F1 File Offset: 0x000756F1
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004897 RID: 18583
			// (get) Token: 0x0600DF7D RID: 57213 RVA: 0x00360530 File Offset: 0x0035E730
			// (set) Token: 0x0600DF7E RID: 57214 RVA: 0x00077510 File Offset: 0x00075710
			public unsafe Spell_Utsuho.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004898 RID: 18584
			// (get) Token: 0x0600DF7F RID: 57215 RVA: 0x00360560 File Offset: 0x0035E760
			// (set) Token: 0x0600DF80 RID: 57216 RVA: 0x0007752F File Offset: 0x0007572F
			public unsafe Il2CppStructArray<Vector3> _allControllers_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__allControllers_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__allControllers_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004899 RID: 18585
			// (get) Token: 0x0600DF81 RID: 57217 RVA: 0x00360590 File Offset: 0x0035E790
			// (set) Token: 0x0600DF82 RID: 57218 RVA: 0x0007754E File Offset: 0x0007574E
			public unsafe int _cookerCount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__cookerCount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__cookerCount_5__3)) = value;
				}
			}

			// Token: 0x1700489A RID: 18586
			// (get) Token: 0x0600DF83 RID: 57219 RVA: 0x003605B8 File Offset: 0x0035E7B8
			// (set) Token: 0x0600DF84 RID: 57220 RVA: 0x00077569 File Offset: 0x00075769
			public unsafe float _currentTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__currentTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__currentTime_5__4)) = value;
				}
			}

			// Token: 0x1700489B RID: 18587
			// (get) Token: 0x0600DF85 RID: 57221 RVA: 0x003605E0 File Offset: 0x0035E7E0
			// (set) Token: 0x0600DF86 RID: 57222 RVA: 0x00077584 File Offset: 0x00075784
			public unsafe int _currentCooker_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__currentCooker_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__currentCooker_5__5)) = value;
				}
			}

			// Token: 0x1700489C RID: 18588
			// (get) Token: 0x0600DF87 RID: 57223 RVA: 0x00360608 File Offset: 0x0035E808
			// (set) Token: 0x0600DF88 RID: 57224 RVA: 0x0007759F File Offset: 0x0007579F
			public unsafe int _maxCount_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__maxCount_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__maxCount_5__6)) = value;
				}
			}

			// Token: 0x04008EFF RID: 36607
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F00 RID: 36608
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F01 RID: 36609
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F02 RID: 36610
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008F03 RID: 36611
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008F04 RID: 36612
			private static readonly IntPtr NativeFieldInfoPtr__allControllers_5__2;

			// Token: 0x04008F05 RID: 36613
			private static readonly IntPtr NativeFieldInfoPtr__cookerCount_5__3;

			// Token: 0x04008F06 RID: 36614
			private static readonly IntPtr NativeFieldInfoPtr__currentTime_5__4;

			// Token: 0x04008F07 RID: 36615
			private static readonly IntPtr NativeFieldInfoPtr__currentCooker_5__5;

			// Token: 0x04008F08 RID: 36616
			private static readonly IntPtr NativeFieldInfoPtr__maxCount_5__6;

			// Token: 0x04008F09 RID: 36617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F0A RID: 36618
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F0B RID: 36619
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F0C RID: 36620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F0D RID: 36621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F0E RID: 36622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C02 RID: 3074
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF89 RID: 57225 RVA: 0x00360630 File Offset: 0x0035E830
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr);
				Spell_Utsuho.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				Spell_Utsuho.__c__DisplayClass23_0.NativeFieldInfoPtr_cookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr, "cookController");
				Spell_Utsuho.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr, 100680136);
				Spell_Utsuho.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr, 100680137);
				Spell_Utsuho.__c__DisplayClass23_0.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr, 100680138);
			}

			// Token: 0x0600DF8A RID: 57226 RVA: 0x003606C0 File Offset: 0x0035E8C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF8B RID: 57227 RVA: 0x003606FC File Offset: 0x0035E8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207652, XrefRangeEnd = 207657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF8C RID: 57228 RVA: 0x0036073C File Offset: 0x0035E93C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207657, XrefRangeEnd = 207659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NuclearBombWhenQteFail_b__3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF8D RID: 57229 RVA: 0x000775BA File Offset: 0x000757BA
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700489F RID: 18591
			// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x00360780 File Offset: 0x0035E980
			// (set) Token: 0x0600DF8F RID: 57231 RVA: 0x000775C3 File Offset: 0x000757C3
			public unsafe Spell_Utsuho __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048A0 RID: 18592
			// (get) Token: 0x0600DF90 RID: 57232 RVA: 0x003607B0 File Offset: 0x0035E9B0
			// (set) Token: 0x0600DF91 RID: 57233 RVA: 0x000775E2 File Offset: 0x000757E2
			public unsafe CookController cookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.NativeFieldInfoPtr_cookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.NativeFieldInfoPtr_cookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F0F RID: 36623
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F10 RID: 36624
			private static readonly IntPtr NativeFieldInfoPtr_cookController;

			// Token: 0x04008F11 RID: 36625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F12 RID: 36626
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008F13 RID: 36627
			private static readonly IntPtr NativeMethodInfoPtr__NuclearBombWhenQteFail_b__3_Internal_Void_GameObject_0;

			// Token: 0x0200104B RID: 4171
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<>c__DisplayClass23_0+<<NuclearBombWhenQteFail>g__startNuclearBomb|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D58 RID: 73048 RVA: 0x00414D34 File Offset: 0x00412F34
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0>.NativeClassPtr, "<<NuclearBombWhenQteFail>g__startNuclearBomb|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr);
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__obj_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<obj>5__2");
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680139);
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680140);
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680141);
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680142);
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680143);
					Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680144);
				}

				// Token: 0x06011D59 RID: 73049 RVA: 0x00414E3C File Offset: 0x0041303C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D5A RID: 73050 RVA: 0x00414E84 File Offset: 0x00413084
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D5B RID: 73051 RVA: 0x00414EB8 File Offset: 0x004130B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207518, XrefRangeEnd = 207646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CEF RID: 23791
				// (get) Token: 0x06011D5C RID: 73052 RVA: 0x00414EF4 File Offset: 0x004130F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D5D RID: 73053 RVA: 0x00414F34 File Offset: 0x00413134
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207646, XrefRangeEnd = 207652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CF0 RID: 23792
				// (get) Token: 0x06011D5E RID: 73054 RVA: 0x00414F68 File Offset: 0x00413168
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D5F RID: 73055 RVA: 0x0009AEF3 File Offset: 0x000990F3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CEA RID: 23786
				// (get) Token: 0x06011D60 RID: 73056 RVA: 0x00414FA8 File Offset: 0x004131A8
				// (set) Token: 0x06011D61 RID: 73057 RVA: 0x0009AEFC File Offset: 0x000990FC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CEB RID: 23787
				// (get) Token: 0x06011D62 RID: 73058 RVA: 0x00414FD0 File Offset: 0x004131D0
				// (set) Token: 0x06011D63 RID: 73059 RVA: 0x0009AF17 File Offset: 0x00099117
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CEC RID: 23788
				// (get) Token: 0x06011D64 RID: 73060 RVA: 0x00415000 File Offset: 0x00413200
				// (set) Token: 0x06011D65 RID: 73061 RVA: 0x0009AF36 File Offset: 0x00099136
				public unsafe Spell_Utsuho.__c__DisplayClass23_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho.__c__DisplayClass23_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CED RID: 23789
				// (get) Token: 0x06011D66 RID: 73062 RVA: 0x00415030 File Offset: 0x00413230
				// (set) Token: 0x06011D67 RID: 73063 RVA: 0x0009AF55 File Offset: 0x00099155
				public unsafe Spell_Utsuho.__c__DisplayClass23_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho.__c__DisplayClass23_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CEE RID: 23790
				// (get) Token: 0x06011D68 RID: 73064 RVA: 0x00415060 File Offset: 0x00413260
				// (set) Token: 0x06011D69 RID: 73065 RVA: 0x0009AF74 File Offset: 0x00099174
				public unsafe GameObject _obj_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__obj_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__obj_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B443 RID: 46147
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B444 RID: 46148
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B445 RID: 46149
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B446 RID: 46150
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B447 RID: 46151
				private static readonly IntPtr NativeFieldInfoPtr__obj_5__2;

				// Token: 0x0400B448 RID: 46152
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B449 RID: 46153
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B44A RID: 46154
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B44B RID: 46155
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B44C RID: 46156
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B44D RID: 46157
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C03 RID: 3075
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<>c__DisplayClass23_1")]
		public sealed class __c__DisplayClass23_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DF92 RID: 57234 RVA: 0x003607E0 File Offset: 0x0035E9E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_1()
			{
				Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "<>c__DisplayClass23_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr);
				Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, "text");
				Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_brokenTableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, "brokenTableObject");
				Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, 100680145);
				Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__5_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, 100680146);
				Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, 100680147);
				Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr, 100680148);
			}

			// Token: 0x0600DF93 RID: 57235 RVA: 0x00360898 File Offset: 0x0035EA98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho.__c__DisplayClass23_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF94 RID: 57236 RVA: 0x003608D4 File Offset: 0x0035EAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207659, XrefRangeEnd = 207669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NuclearBombWhenQteFail_b__5(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__5_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF95 RID: 57237 RVA: 0x00360918 File Offset: 0x0035EB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207669, XrefRangeEnd = 207684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF96 RID: 57238 RVA: 0x0036094C File Offset: 0x0035EB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207684, XrefRangeEnd = 207688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NuclearBombWhenQteFail_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho.__c__DisplayClass23_1.NativeMethodInfoPtr__NuclearBombWhenQteFail_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF97 RID: 57239 RVA: 0x00077601 File Offset: 0x00075801
			public __c__DisplayClass23_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048A1 RID: 18593
			// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x00360980 File Offset: 0x0035EB80
			// (set) Token: 0x0600DF99 RID: 57241 RVA: 0x0007760A File Offset: 0x0007580A
			public unsafe Il2CppStringArray text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048A2 RID: 18594
			// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x003609B0 File Offset: 0x0035EBB0
			// (set) Token: 0x0600DF9B RID: 57243 RVA: 0x00077629 File Offset: 0x00075829
			public unsafe GameObject brokenTableObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_brokenTableObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_brokenTableObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048A3 RID: 18595
			// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x003609E0 File Offset: 0x0035EBE0
			// (set) Token: 0x0600DF9D RID: 57245 RVA: 0x00077648 File Offset: 0x00075848
			public unsafe Spell_Utsuho.__c__DisplayClass23_0 field_Public___c__DisplayClass23_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho.__c__DisplayClass23_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho.__c__DisplayClass23_1.NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F14 RID: 36628
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04008F15 RID: 36629
			private static readonly IntPtr NativeFieldInfoPtr_brokenTableObject;

			// Token: 0x04008F16 RID: 36630
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass23_0_0;

			// Token: 0x04008F17 RID: 36631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F18 RID: 36632
			private static readonly IntPtr NativeMethodInfoPtr__NuclearBombWhenQteFail_b__5_Internal_Void_GuestGroupController_0;

			// Token: 0x04008F19 RID: 36633
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008F1A RID: 36634
			private static readonly IntPtr NativeMethodInfoPtr__NuclearBombWhenQteFail_b__6_Internal_Void_0;
		}

		// Token: 0x02000C04 RID: 3076
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Utsuho+<OnPositiveBuffExecute>d__24")]
		public sealed class _OnPositiveBuffExecute_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600DF9E RID: 57246 RVA: 0x00360A10 File Offset: 0x0035EC10
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__24()
			{
				Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Utsuho>.NativeClassPtr, "<OnPositiveBuffExecute>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr);
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, "<>1__state");
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, "<>2__current");
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, "<>4__this");
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, 100680149);
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, 100680150);
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, 100680151);
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, 100680152);
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, 100680153);
				Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr, 100680154);
			}

			// Token: 0x0600DF9F RID: 57247 RVA: 0x00360AF0 File Offset: 0x0035ECF0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Utsuho._OnPositiveBuffExecute_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFA0 RID: 57248 RVA: 0x00360B38 File Offset: 0x0035ED38
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFA1 RID: 57249 RVA: 0x00360B6C File Offset: 0x0035ED6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207688, XrefRangeEnd = 207755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048A7 RID: 18599
			// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x00360BA8 File Offset: 0x0035EDA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFA3 RID: 57251 RVA: 0x00360BE8 File Offset: 0x0035EDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207755, XrefRangeEnd = 207761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048A8 RID: 18600
			// (get) Token: 0x0600DFA4 RID: 57252 RVA: 0x00360C1C File Offset: 0x0035EE1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFA5 RID: 57253 RVA: 0x00077667 File Offset: 0x00075867
			public _OnPositiveBuffExecute_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048A4 RID: 18596
			// (get) Token: 0x0600DFA6 RID: 57254 RVA: 0x00360C5C File Offset: 0x0035EE5C
			// (set) Token: 0x0600DFA7 RID: 57255 RVA: 0x00077670 File Offset: 0x00075870
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048A5 RID: 18597
			// (get) Token: 0x0600DFA8 RID: 57256 RVA: 0x00360C84 File Offset: 0x0035EE84
			// (set) Token: 0x0600DFA9 RID: 57257 RVA: 0x0007768B File Offset: 0x0007588B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048A6 RID: 18598
			// (get) Token: 0x0600DFAA RID: 57258 RVA: 0x00360CB4 File Offset: 0x0035EEB4
			// (set) Token: 0x0600DFAB RID: 57259 RVA: 0x000776AA File Offset: 0x000758AA
			public unsafe Spell_Utsuho __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Utsuho>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Utsuho._OnPositiveBuffExecute_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F1B RID: 36635
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F1C RID: 36636
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F1D RID: 36637
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F1E RID: 36638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F1F RID: 36639
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F20 RID: 36640
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F21 RID: 36641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F22 RID: 36642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F23 RID: 36643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
