using System;
using DEYU.UniversalUISystem;
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
	// Token: 0x02000277 RID: 631
	public class Spell_Nue : SpellBase
	{
		// Token: 0x06004F2E RID: 20270 RVA: 0x001ADBF0 File Offset: 0x001ABDF0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Nue()
		{
			Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Nue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr);
			Spell_Nue.NativeFieldInfoPtr_UFOEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "UFOEffect");
			Spell_Nue.NativeFieldInfoPtr_UFODurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "UFODurationSec");
			Spell_Nue.NativeFieldInfoPtr_waitForUFOEffective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "waitForUFOEffective");
			Spell_Nue.NativeFieldInfoPtr_targetPostiveIdInUnityEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "targetPostiveIdInUnityEditor");
			Spell_Nue.NativeFieldInfoPtr_targetNegativeIdInUnityEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "targetNegativeIdInUnityEditor");
			Spell_Nue.NativeFieldInfoPtr_ufoSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "ufoSprites");
			Spell_Nue.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "reward");
			Spell_Nue.NativeFieldInfoPtr_threeBlueUFOExtraFundRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "threeBlueUFOExtraFundRate");
			Spell_Nue.NativeFieldInfoPtr_punish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "punish");
			Spell_Nue.NativeFieldInfoPtr_ggbUFOExtraCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "ggbUFOExtraCost");
			Spell_Nue.NativeFieldInfoPtr_bbrUFOExtraFundRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "bbrUFOExtraFundRate");
			Spell_Nue.NativeFieldInfoPtr_ufoSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "ufoSFX");
			Spell_Nue.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "rewardSFX");
			Spell_Nue.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "punishmentSFX");
			Spell_Nue.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, 100679216);
			Spell_Nue.NativeMethodInfoPtr_SetSprites_Private_Void_ColorType_ParticleSystem_TrailRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, 100679217);
			Spell_Nue.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, 100679218);
			Spell_Nue.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, 100679219);
			Spell_Nue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, 100679220);
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x001ADD9C File Offset: 0x001ABF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201128, XrefRangeEnd = 201130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Nue.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x001ADDE0 File Offset: 0x001ABFE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 201146, RefRangeEnd = 201150, XrefRangeStart = 201130, XrefRangeEnd = 201146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSprites(Spell_Nue.ColorType color, ParticleSystem particle, TrailRenderer trailRenderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trailRenderer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.NativeMethodInfoPtr_SetSprites_Private_Void_ColorType_ParticleSystem_TrailRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x001ADE44 File Offset: 0x001AC044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201150, XrefRangeEnd = 201156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Nue.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x001ADEA0 File Offset: 0x001AC0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201156, XrefRangeEnd = 201162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Nue.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x001ADEFC File Offset: 0x001AC0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201162, XrefRangeEnd = 201195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Nue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00029A15 File Offset: 0x00027C15
		public Spell_Nue(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x001ADF38 File Offset: 0x001AC138
		// (set) Token: 0x06004F36 RID: 20278 RVA: 0x00029A1E File Offset: 0x00027C1E
		public unsafe GameObject UFOEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_UFOEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_UFOEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x001ADF68 File Offset: 0x001AC168
		// (set) Token: 0x06004F38 RID: 20280 RVA: 0x00029A3D File Offset: 0x00027C3D
		public unsafe float UFODurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_UFODurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_UFODurationSec)) = value;
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06004F39 RID: 20281 RVA: 0x001ADF90 File Offset: 0x001AC190
		// (set) Token: 0x06004F3A RID: 20282 RVA: 0x00029A58 File Offset: 0x00027C58
		public unsafe float waitForUFOEffective
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_waitForUFOEffective);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_waitForUFOEffective)) = value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x001ADFB8 File Offset: 0x001AC1B8
		// (set) Token: 0x06004F3C RID: 20284 RVA: 0x00029A73 File Offset: 0x00027C73
		public unsafe Spell_Nue.PositiveRewardType targetPostiveIdInUnityEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_targetPostiveIdInUnityEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_targetPostiveIdInUnityEditor)) = value;
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x001ADFE0 File Offset: 0x001AC1E0
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x00029A8E File Offset: 0x00027C8E
		public unsafe Spell_Nue.PunishmentRewardType targetNegativeIdInUnityEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_targetNegativeIdInUnityEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_targetNegativeIdInUnityEditor)) = value;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x001AE008 File Offset: 0x001AC208
		// (set) Token: 0x06004F40 RID: 20288 RVA: 0x00029AA9 File Offset: 0x00027CA9
		public unsafe Il2CppReferenceArray<Spell_Nue.ColorUFO> ufoSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_ufoSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Spell_Nue.ColorUFO>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_ufoSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06004F41 RID: 20289 RVA: 0x001AE038 File Offset: 0x001AC238
		// (set) Token: 0x06004F42 RID: 20290 RVA: 0x00029AC8 File Offset: 0x00027CC8
		public unsafe Il2CppReferenceArray<Spell_Nue.NueRewardPair> reward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_reward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Spell_Nue.NueRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06004F43 RID: 20291 RVA: 0x001AE068 File Offset: 0x001AC268
		// (set) Token: 0x06004F44 RID: 20292 RVA: 0x00029AE7 File Offset: 0x00027CE7
		public unsafe float threeBlueUFOExtraFundRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_threeBlueUFOExtraFundRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_threeBlueUFOExtraFundRate)) = value;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x001AE090 File Offset: 0x001AC290
		// (set) Token: 0x06004F46 RID: 20294 RVA: 0x00029B02 File Offset: 0x00027D02
		public unsafe Il2CppReferenceArray<Spell_Nue.NuePunishmentPair> punish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_punish);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Spell_Nue.NuePunishmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_punish), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06004F47 RID: 20295 RVA: 0x001AE0C0 File Offset: 0x001AC2C0
		// (set) Token: 0x06004F48 RID: 20296 RVA: 0x00029B21 File Offset: 0x00027D21
		public unsafe int ggbUFOExtraCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_ggbUFOExtraCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_ggbUFOExtraCost)) = value;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06004F49 RID: 20297 RVA: 0x001AE0E8 File Offset: 0x001AC2E8
		// (set) Token: 0x06004F4A RID: 20298 RVA: 0x00029B3C File Offset: 0x00027D3C
		public unsafe float bbrUFOExtraFundRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_bbrUFOExtraFundRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_bbrUFOExtraFundRate)) = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06004F4B RID: 20299 RVA: 0x001AE110 File Offset: 0x001AC310
		// (set) Token: 0x06004F4C RID: 20300 RVA: 0x00029B57 File Offset: 0x00027D57
		public unsafe AudioClip ufoSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_ufoSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_ufoSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x001AE140 File Offset: 0x001AC340
		// (set) Token: 0x06004F4E RID: 20302 RVA: 0x00029B76 File Offset: 0x00027D76
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x001AE170 File Offset: 0x001AC370
		// (set) Token: 0x06004F50 RID: 20304 RVA: 0x00029B95 File Offset: 0x00027D95
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeFieldInfoPtr_UFOEffect;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeFieldInfoPtr_UFODurationSec;

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeFieldInfoPtr_waitForUFOEffective;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeFieldInfoPtr_targetPostiveIdInUnityEditor;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeFieldInfoPtr_targetNegativeIdInUnityEditor;

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeFieldInfoPtr_ufoSprites;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeFieldInfoPtr_reward;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeFieldInfoPtr_threeBlueUFOExtraFundRate;

		// Token: 0x040035D2 RID: 13778
		private static readonly IntPtr NativeFieldInfoPtr_punish;

		// Token: 0x040035D3 RID: 13779
		private static readonly IntPtr NativeFieldInfoPtr_ggbUFOExtraCost;

		// Token: 0x040035D4 RID: 13780
		private static readonly IntPtr NativeFieldInfoPtr_bbrUFOExtraFundRate;

		// Token: 0x040035D5 RID: 13781
		private static readonly IntPtr NativeFieldInfoPtr_ufoSFX;

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040035D8 RID: 13784
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040035D9 RID: 13785
		private static readonly IntPtr NativeMethodInfoPtr_SetSprites_Private_Void_ColorType_ParticleSystem_TrailRenderer_0;

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7B RID: 2939
		public enum ColorType
		{
			// Token: 0x04008A93 RID: 35475
			R,
			// Token: 0x04008A94 RID: 35476
			G,
			// Token: 0x04008A95 RID: 35477
			B,
			// Token: 0x04008A96 RID: 35478
			E
		}

		// Token: 0x02000B7C RID: 2940
		public enum PositiveRewardType
		{
			// Token: 0x04008A98 RID: 35480
			RRR,
			// Token: 0x04008A99 RID: 35481
			GGG,
			// Token: 0x04008A9A RID: 35482
			BBB,
			// Token: 0x04008A9B RID: 35483
			RGB,
			// Token: 0x04008A9C RID: 35484
			None
		}

		// Token: 0x02000B7D RID: 2941
		public enum PunishmentRewardType
		{
			// Token: 0x04008A9E RID: 35486
			R2,
			// Token: 0x04008A9F RID: 35487
			G2,
			// Token: 0x04008AA0 RID: 35488
			B2,
			// Token: 0x04008AA1 RID: 35489
			RRB,
			// Token: 0x04008AA2 RID: 35490
			None
		}

		// Token: 0x02000B7E RID: 2942
		[Serializable]
		public sealed class ColorUFO : ValueType
		{
			// Token: 0x0600D82D RID: 55341 RVA: 0x0034A3F4 File Offset: 0x003485F4
			// Note: this type is marked as 'beforefieldinit'.
			static ColorUFO()
			{
				Il2CppClassPointerStore<Spell_Nue.ColorUFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "ColorUFO");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.ColorUFO>.NativeClassPtr);
				Spell_Nue.ColorUFO.NativeFieldInfoPtr_colorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.ColorUFO>.NativeClassPtr, "colorType");
				Spell_Nue.ColorUFO.NativeFieldInfoPtr_ufoSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.ColorUFO>.NativeClassPtr, "ufoSprites");
				Spell_Nue.ColorUFO.NativeFieldInfoPtr_trailGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.ColorUFO>.NativeClassPtr, "trailGradient");
			}

			// Token: 0x0600D82E RID: 55342 RVA: 0x00073AA2 File Offset: 0x00071CA2
			public ColorUFO(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D82F RID: 55343 RVA: 0x00073AAB File Offset: 0x00071CAB
			public ColorUFO() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.ColorUFO>.NativeClassPtr))
			{
			}

			// Token: 0x17004652 RID: 18002
			// (get) Token: 0x0600D830 RID: 55344 RVA: 0x0034A45C File Offset: 0x0034865C
			// (set) Token: 0x0600D831 RID: 55345 RVA: 0x00073ABD File Offset: 0x00071CBD
			public unsafe Spell_Nue.ColorType colorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.ColorUFO.NativeFieldInfoPtr_colorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.ColorUFO.NativeFieldInfoPtr_colorType)) = value;
				}
			}

			// Token: 0x17004653 RID: 18003
			// (get) Token: 0x0600D832 RID: 55346 RVA: 0x0034A484 File Offset: 0x00348684
			// (set) Token: 0x0600D833 RID: 55347 RVA: 0x00073AD8 File Offset: 0x00071CD8
			public unsafe Il2CppReferenceArray<Sprite> ufoSprites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.ColorUFO.NativeFieldInfoPtr_ufoSprites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.ColorUFO.NativeFieldInfoPtr_ufoSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004654 RID: 18004
			// (get) Token: 0x0600D834 RID: 55348 RVA: 0x0034A4B4 File Offset: 0x003486B4
			// (set) Token: 0x0600D835 RID: 55349 RVA: 0x00073AF7 File Offset: 0x00071CF7
			public unsafe Gradient trailGradient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.ColorUFO.NativeFieldInfoPtr_trailGradient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.ColorUFO.NativeFieldInfoPtr_trailGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AA3 RID: 35491
			private static readonly IntPtr NativeFieldInfoPtr_colorType;

			// Token: 0x04008AA4 RID: 35492
			private static readonly IntPtr NativeFieldInfoPtr_ufoSprites;

			// Token: 0x04008AA5 RID: 35493
			private static readonly IntPtr NativeFieldInfoPtr_trailGradient;
		}

		// Token: 0x02000B7F RID: 2943
		[Serializable]
		public sealed class NueRewardPair : ValueType
		{
			// Token: 0x0600D836 RID: 55350 RVA: 0x0034A4E4 File Offset: 0x003486E4
			// Note: this type is marked as 'beforefieldinit'.
			static NueRewardPair()
			{
				Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "NueRewardPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr);
				Spell_Nue.NueRewardPair.NativeFieldInfoPtr_RewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, "RewardType");
				Spell_Nue.NueRewardPair.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, "Probability");
				Spell_Nue.NueRewardPair.NativeFieldInfoPtr_DurationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, "DurationTime");
				Spell_Nue.NueRewardPair.NativeFieldInfoPtr_blinkEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, "blinkEffect");
				Spell_Nue.NueRewardPair.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, "colors");
				Spell_Nue.NueRewardPair.NativeMethodInfoPtr__ctor_Public_Void_PositiveRewardType_Single_Single_GameObject_Il2CppStructArray_1_ColorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, 100679221);
			}

			// Token: 0x0600D837 RID: 55351 RVA: 0x0034A588 File Offset: 0x00348788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200802, XrefRangeEnd = 200804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NueRewardPair(Spell_Nue.PositiveRewardType rewardType, float probability, float durationTime, GameObject blinkEffect = null, Il2CppStructArray<Spell_Nue.ColorType> colors = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rewardType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationTime;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blinkEffect);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.NueRewardPair.NativeMethodInfoPtr__ctor_Public_Void_PositiveRewardType_Single_Single_GameObject_Il2CppStructArray_1_ColorType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D838 RID: 55352 RVA: 0x00073B16 File Offset: 0x00071D16
			public NueRewardPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D839 RID: 55353 RVA: 0x00073B1F File Offset: 0x00071D1F
			public NueRewardPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr))
			{
			}

			// Token: 0x17004655 RID: 18005
			// (get) Token: 0x0600D83A RID: 55354 RVA: 0x0034A618 File Offset: 0x00348818
			// (set) Token: 0x0600D83B RID: 55355 RVA: 0x00073B31 File Offset: 0x00071D31
			public unsafe Spell_Nue.PositiveRewardType RewardType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_RewardType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_RewardType)) = value;
				}
			}

			// Token: 0x17004656 RID: 18006
			// (get) Token: 0x0600D83C RID: 55356 RVA: 0x0034A640 File Offset: 0x00348840
			// (set) Token: 0x0600D83D RID: 55357 RVA: 0x00073B4C File Offset: 0x00071D4C
			public unsafe float Probability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_Probability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_Probability)) = value;
				}
			}

			// Token: 0x17004657 RID: 18007
			// (get) Token: 0x0600D83E RID: 55358 RVA: 0x0034A668 File Offset: 0x00348868
			// (set) Token: 0x0600D83F RID: 55359 RVA: 0x00073B67 File Offset: 0x00071D67
			public unsafe float DurationTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_DurationTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_DurationTime)) = value;
				}
			}

			// Token: 0x17004658 RID: 18008
			// (get) Token: 0x0600D840 RID: 55360 RVA: 0x0034A690 File Offset: 0x00348890
			// (set) Token: 0x0600D841 RID: 55361 RVA: 0x00073B82 File Offset: 0x00071D82
			public unsafe GameObject blinkEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_blinkEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_blinkEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004659 RID: 18009
			// (get) Token: 0x0600D842 RID: 55362 RVA: 0x0034A6C0 File Offset: 0x003488C0
			// (set) Token: 0x0600D843 RID: 55363 RVA: 0x00073BA1 File Offset: 0x00071DA1
			public unsafe Il2CppStructArray<Spell_Nue.ColorType> colors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_colors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Spell_Nue.ColorType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NueRewardPair.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AA6 RID: 35494
			private static readonly IntPtr NativeFieldInfoPtr_RewardType;

			// Token: 0x04008AA7 RID: 35495
			private static readonly IntPtr NativeFieldInfoPtr_Probability;

			// Token: 0x04008AA8 RID: 35496
			private static readonly IntPtr NativeFieldInfoPtr_DurationTime;

			// Token: 0x04008AA9 RID: 35497
			private static readonly IntPtr NativeFieldInfoPtr_blinkEffect;

			// Token: 0x04008AAA RID: 35498
			private static readonly IntPtr NativeFieldInfoPtr_colors;

			// Token: 0x04008AAB RID: 35499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PositiveRewardType_Single_Single_GameObject_Il2CppStructArray_1_ColorType_0;
		}

		// Token: 0x02000B80 RID: 2944
		[Serializable]
		public sealed class NuePunishmentPair : ValueType
		{
			// Token: 0x0600D844 RID: 55364 RVA: 0x0034A6F0 File Offset: 0x003488F0
			// Note: this type is marked as 'beforefieldinit'.
			static NuePunishmentPair()
			{
				Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "NuePunishmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr);
				Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_PunishmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, "PunishmentType");
				Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, "Probability");
				Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_DurationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, "DurationTime");
				Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_smokeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, "smokeEffect");
				Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, "colors");
				Spell_Nue.NuePunishmentPair.NativeMethodInfoPtr__ctor_Public_Void_PunishmentRewardType_Single_Single_GameObject_Il2CppStructArray_1_ColorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, 100679222);
			}

			// Token: 0x0600D845 RID: 55365 RVA: 0x0034A794 File Offset: 0x00348994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NuePunishmentPair(Spell_Nue.PunishmentRewardType type, float probability, float durationTime, GameObject smokeEffect = null, Il2CppStructArray<Spell_Nue.ColorType> colors = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref type;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationTime;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(smokeEffect);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.NuePunishmentPair.NativeMethodInfoPtr__ctor_Public_Void_PunishmentRewardType_Single_Single_GameObject_Il2CppStructArray_1_ColorType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D846 RID: 55366 RVA: 0x00073BC0 File Offset: 0x00071DC0
			public NuePunishmentPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D847 RID: 55367 RVA: 0x00073BC9 File Offset: 0x00071DC9
			public NuePunishmentPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr))
			{
			}

			// Token: 0x1700465A RID: 18010
			// (get) Token: 0x0600D848 RID: 55368 RVA: 0x0034A824 File Offset: 0x00348A24
			// (set) Token: 0x0600D849 RID: 55369 RVA: 0x00073BDB File Offset: 0x00071DDB
			public unsafe Spell_Nue.PunishmentRewardType PunishmentType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_PunishmentType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_PunishmentType)) = value;
				}
			}

			// Token: 0x1700465B RID: 18011
			// (get) Token: 0x0600D84A RID: 55370 RVA: 0x0034A84C File Offset: 0x00348A4C
			// (set) Token: 0x0600D84B RID: 55371 RVA: 0x00073BF6 File Offset: 0x00071DF6
			public unsafe float Probability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_Probability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_Probability)) = value;
				}
			}

			// Token: 0x1700465C RID: 18012
			// (get) Token: 0x0600D84C RID: 55372 RVA: 0x0034A874 File Offset: 0x00348A74
			// (set) Token: 0x0600D84D RID: 55373 RVA: 0x00073C11 File Offset: 0x00071E11
			public unsafe float DurationTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_DurationTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_DurationTime)) = value;
				}
			}

			// Token: 0x1700465D RID: 18013
			// (get) Token: 0x0600D84E RID: 55374 RVA: 0x0034A89C File Offset: 0x00348A9C
			// (set) Token: 0x0600D84F RID: 55375 RVA: 0x00073C2C File Offset: 0x00071E2C
			public unsafe GameObject smokeEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_smokeEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_smokeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700465E RID: 18014
			// (get) Token: 0x0600D850 RID: 55376 RVA: 0x0034A8CC File Offset: 0x00348ACC
			// (set) Token: 0x0600D851 RID: 55377 RVA: 0x00073C4B File Offset: 0x00071E4B
			public unsafe Il2CppStructArray<Spell_Nue.ColorType> colors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_colors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Spell_Nue.ColorType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.NuePunishmentPair.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AAC RID: 35500
			private static readonly IntPtr NativeFieldInfoPtr_PunishmentType;

			// Token: 0x04008AAD RID: 35501
			private static readonly IntPtr NativeFieldInfoPtr_Probability;

			// Token: 0x04008AAE RID: 35502
			private static readonly IntPtr NativeFieldInfoPtr_DurationTime;

			// Token: 0x04008AAF RID: 35503
			private static readonly IntPtr NativeFieldInfoPtr_smokeEffect;

			// Token: 0x04008AB0 RID: 35504
			private static readonly IntPtr NativeFieldInfoPtr_colors;

			// Token: 0x04008AB1 RID: 35505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PunishmentRewardType_Single_Single_GameObject_Il2CppStructArray_1_ColorType_0;
		}

		// Token: 0x02000B81 RID: 2945
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nue+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D852 RID: 55378 RVA: 0x0034A8FC File Offset: 0x00348AFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass18_0>.NativeClassPtr);
				Spell_Nue.__c__DisplayClass18_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass18_0>.NativeClassPtr, "color");
				Spell_Nue.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass18_0>.NativeClassPtr, 100679223);
				Spell_Nue.__c__DisplayClass18_0.NativeMethodInfoPtr__SetSprites_b__0_Internal_Boolean_ColorUFO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass18_0>.NativeClassPtr, 100679224);
			}

			// Token: 0x0600D853 RID: 55379 RVA: 0x0034A964 File Offset: 0x00348B64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x0034A9A0 File Offset: 0x00348BA0
			[CallerCount(0)]
			public unsafe bool _SetSprites_b__0(Spell_Nue.ColorUFO x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass18_0.NativeMethodInfoPtr__SetSprites_b__0_Internal_Boolean_ColorUFO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x00073C6A File Offset: 0x00071E6A
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465F RID: 18015
			// (get) Token: 0x0600D856 RID: 55382 RVA: 0x0034A9F4 File Offset: 0x00348BF4
			// (set) Token: 0x0600D857 RID: 55383 RVA: 0x00073C73 File Offset: 0x00071E73
			public unsafe Spell_Nue.ColorType color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass18_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass18_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008AB2 RID: 35506
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008AB3 RID: 35507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AB4 RID: 35508
			private static readonly IntPtr NativeMethodInfoPtr__SetSprites_b__0_Internal_Boolean_ColorUFO_0;
		}

		// Token: 0x02000B82 RID: 2946
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nue+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D858 RID: 55384 RVA: 0x0034AA1C File Offset: 0x00348C1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr);
				Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, "cluster");
				Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_finalResultPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, "finalResultPair");
				Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_allColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, "allColor");
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679225);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Boolean_NuePunishmentPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679226);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679227);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679228);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679229);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679230);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679231);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679232);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679233);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679234);
				Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr, 100679235);
			}

			// Token: 0x0600D859 RID: 55385 RVA: 0x0034AB74 File Offset: 0x00348D74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D85A RID: 55386 RVA: 0x0034ABB0 File Offset: 0x00348DB0
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__1(Spell_Nue.NuePunishmentPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Boolean_NuePunishmentPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D85B RID: 55387 RVA: 0x0034AC04 File Offset: 0x00348E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200804, XrefRangeEnd = 200809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D85C RID: 55388 RVA: 0x0034AC48 File Offset: 0x00348E48
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200822, RefRangeEnd = 200823, XrefRangeStart = 200809, XrefRangeEnd = 200822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D85D RID: 55389 RVA: 0x0034AC7C File Offset: 0x00348E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200823, XrefRangeEnd = 200825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D85E RID: 55390 RVA: 0x0034ACBC File Offset: 0x00348EBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200838, RefRangeEnd = 200839, XrefRangeStart = 200825, XrefRangeEnd = 200838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D85F RID: 55391 RVA: 0x0034ACF0 File Offset: 0x00348EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200839, XrefRangeEnd = 200847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D860 RID: 55392 RVA: 0x0034AD30 File Offset: 0x00348F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200847, XrefRangeEnd = 200855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_String_PDM_0(int currentTime, string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D861 RID: 55393 RVA: 0x0034AD88 File Offset: 0x00348F88
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200868, RefRangeEnd = 200869, XrefRangeStart = 200855, XrefRangeEnd = 200868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D862 RID: 55394 RVA: 0x0034ADBC File Offset: 0x00348FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200869, XrefRangeEnd = 200871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__11(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D863 RID: 55395 RVA: 0x0034ADFC File Offset: 0x00348FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200871, XrefRangeEnd = 200885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GameObject_PDM_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D864 RID: 55396 RVA: 0x00073C8E File Offset: 0x00071E8E
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004660 RID: 18016
			// (get) Token: 0x0600D865 RID: 55397 RVA: 0x0034AE40 File Offset: 0x00349040
			// (set) Token: 0x0600D866 RID: 55398 RVA: 0x00073C97 File Offset: 0x00071E97
			public unsafe Spell_Nue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004661 RID: 18017
			// (get) Token: 0x0600D867 RID: 55399 RVA: 0x0034AE70 File Offset: 0x00349070
			// (set) Token: 0x0600D868 RID: 55400 RVA: 0x00073CB6 File Offset: 0x00071EB6
			public unsafe UIElementCluster cluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_cluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004662 RID: 18018
			// (get) Token: 0x0600D869 RID: 55401 RVA: 0x0034AEA0 File Offset: 0x003490A0
			// (set) Token: 0x0600D86A RID: 55402 RVA: 0x00073CD5 File Offset: 0x00071ED5
			public Spell_Nue.NuePunishmentPair finalResultPair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_finalResultPair);
					return new Spell_Nue.NuePunishmentPair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_finalResultPair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Spell_Nue.NuePunishmentPair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004663 RID: 18019
			// (get) Token: 0x0600D86B RID: 55403 RVA: 0x0034AED0 File Offset: 0x003490D0
			// (set) Token: 0x0600D86C RID: 55404 RVA: 0x00073D03 File Offset: 0x00071F03
			public unsafe List<Spell_Nue.ColorType> allColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_allColor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Spell_Nue.ColorType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass19_0.NativeFieldInfoPtr_allColor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AB5 RID: 35509
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AB6 RID: 35510
			private static readonly IntPtr NativeFieldInfoPtr_cluster;

			// Token: 0x04008AB7 RID: 35511
			private static readonly IntPtr NativeFieldInfoPtr_finalResultPair;

			// Token: 0x04008AB8 RID: 35512
			private static readonly IntPtr NativeFieldInfoPtr_allColor;

			// Token: 0x04008AB9 RID: 35513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ABA RID: 35514
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Boolean_NuePunishmentPair_0;

			// Token: 0x04008ABB RID: 35515
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_GameObject_0;

			// Token: 0x04008ABC RID: 35516
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04008ABD RID: 35517
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_Int32_0;

			// Token: 0x04008ABE RID: 35518
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x04008ABF RID: 35519
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_Int32_0;

			// Token: 0x04008AC0 RID: 35520
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0;

			// Token: 0x04008AC1 RID: 35521
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_2;

			// Token: 0x04008AC2 RID: 35522
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_Int32_0;

			// Token: 0x04008AC3 RID: 35523
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0;
		}

		// Token: 0x02000B83 RID: 2947
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nue+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D86D RID: 55405 RVA: 0x0034AF00 File Offset: 0x00349100
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr);
				Spell_Nue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, "<>9");
				Spell_Nue.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, "<>9__19_0");
				Spell_Nue.__c.NativeFieldInfoPtr___9__19_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, "<>9__19_2");
				Spell_Nue.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, "<>9__20_0");
				Spell_Nue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, 100679237);
				Spell_Nue.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_0_Internal_Single_NuePunishmentPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, 100679238);
				Spell_Nue.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_2_Internal_Boolean_ColorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, 100679239);
				Spell_Nue.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Internal_Single_NueRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr, 100679240);
			}

			// Token: 0x0600D86E RID: 55406 RVA: 0x0034AFCC File Offset: 0x003491CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D86F RID: 55407 RVA: 0x0034B008 File Offset: 0x00349208
			[CallerCount(0)]
			public unsafe float _OnNegativeBuffExecute_b__19_0(Spell_Nue.NuePunishmentPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_0_Internal_Single_NuePunishmentPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D870 RID: 55408 RVA: 0x0034B05C File Offset: 0x0034925C
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__19_2(Spell_Nue.ColorType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_2_Internal_Boolean_ColorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D871 RID: 55409 RVA: 0x0034B0A8 File Offset: 0x003492A8
			[CallerCount(0)]
			public unsafe float _OnPositiveBuffExecute_b__20_0(Spell_Nue.NueRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Internal_Single_NueRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D872 RID: 55410 RVA: 0x00073D22 File Offset: 0x00071F22
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004664 RID: 18020
			// (get) Token: 0x0600D873 RID: 55411 RVA: 0x0034B0FC File Offset: 0x003492FC
			// (set) Token: 0x0600D874 RID: 55412 RVA: 0x00073D2B File Offset: 0x00071F2B
			public unsafe static Spell_Nue.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Nue.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Nue.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004665 RID: 18021
			// (get) Token: 0x0600D875 RID: 55413 RVA: 0x0034B124 File Offset: 0x00349324
			// (set) Token: 0x0600D876 RID: 55414 RVA: 0x00073D3D File Offset: 0x00071F3D
			public unsafe static Func<Spell_Nue.NuePunishmentPair, float> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Nue.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Nue.NuePunishmentPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Nue.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004666 RID: 18022
			// (get) Token: 0x0600D877 RID: 55415 RVA: 0x0034B14C File Offset: 0x0034934C
			// (set) Token: 0x0600D878 RID: 55416 RVA: 0x00073D4F File Offset: 0x00071F4F
			public unsafe static Func<Spell_Nue.ColorType, bool> __9__19_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Nue.__c.NativeFieldInfoPtr___9__19_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Nue.ColorType, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Nue.__c.NativeFieldInfoPtr___9__19_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004667 RID: 18023
			// (get) Token: 0x0600D879 RID: 55417 RVA: 0x0034B174 File Offset: 0x00349374
			// (set) Token: 0x0600D87A RID: 55418 RVA: 0x00073D61 File Offset: 0x00071F61
			public unsafe static Func<Spell_Nue.NueRewardPair, float> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Nue.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Nue.NueRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Nue.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AC4 RID: 35524
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008AC5 RID: 35525
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04008AC6 RID: 35526
			private static readonly IntPtr NativeFieldInfoPtr___9__19_2;

			// Token: 0x04008AC7 RID: 35527
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04008AC8 RID: 35528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AC9 RID: 35529
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_0_Internal_Single_NuePunishmentPair_0;

			// Token: 0x04008ACA RID: 35530
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_2_Internal_Boolean_ColorType_0;

			// Token: 0x04008ACB RID: 35531
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Internal_Single_NueRewardPair_0;
		}

		// Token: 0x02000B84 RID: 2948
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nue+<OnNegativeBuffExecute>d__19")]
		public sealed class _OnNegativeBuffExecute_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600D87B RID: 55419 RVA: 0x0034B19C File Offset: 0x0034939C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__19()
			{
				Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "<OnNegativeBuffExecute>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr);
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, "<>1__state");
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, "<>2__current");
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, "<>4__this");
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, "spellExecutionContext");
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, "<>8__1");
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, 100679241);
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, 100679242);
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, 100679243);
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, 100679244);
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, 100679245);
				Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr, 100679246);
			}

			// Token: 0x0600D87C RID: 55420 RVA: 0x0034B2A4 File Offset: 0x003494A4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue._OnNegativeBuffExecute_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D87D RID: 55421 RVA: 0x0034B2EC File Offset: 0x003494EC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D87E RID: 55422 RVA: 0x0034B320 File Offset: 0x00349520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200885, XrefRangeEnd = 200987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700466D RID: 18029
			// (get) Token: 0x0600D87F RID: 55423 RVA: 0x0034B35C File Offset: 0x0034955C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D880 RID: 55424 RVA: 0x0034B39C File Offset: 0x0034959C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200987, XrefRangeEnd = 200993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700466E RID: 18030
			// (get) Token: 0x0600D881 RID: 55425 RVA: 0x0034B3D0 File Offset: 0x003495D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnNegativeBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D882 RID: 55426 RVA: 0x00073D73 File Offset: 0x00071F73
			public _OnNegativeBuffExecute_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004668 RID: 18024
			// (get) Token: 0x0600D883 RID: 55427 RVA: 0x0034B410 File Offset: 0x00349610
			// (set) Token: 0x0600D884 RID: 55428 RVA: 0x00073D7C File Offset: 0x00071F7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004669 RID: 18025
			// (get) Token: 0x0600D885 RID: 55429 RVA: 0x0034B438 File Offset: 0x00349638
			// (set) Token: 0x0600D886 RID: 55430 RVA: 0x00073D97 File Offset: 0x00071F97
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700466A RID: 18026
			// (get) Token: 0x0600D887 RID: 55431 RVA: 0x0034B468 File Offset: 0x00349668
			// (set) Token: 0x0600D888 RID: 55432 RVA: 0x00073DB6 File Offset: 0x00071FB6
			public unsafe Spell_Nue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700466B RID: 18027
			// (get) Token: 0x0600D889 RID: 55433 RVA: 0x0034B498 File Offset: 0x00349698
			// (set) Token: 0x0600D88A RID: 55434 RVA: 0x00073DD5 File Offset: 0x00071FD5
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700466C RID: 18028
			// (get) Token: 0x0600D88B RID: 55435 RVA: 0x0034B4C8 File Offset: 0x003496C8
			// (set) Token: 0x0600D88C RID: 55436 RVA: 0x00073DF4 File Offset: 0x00071FF4
			public unsafe Spell_Nue.__c__DisplayClass19_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnNegativeBuffExecute_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ACC RID: 35532
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008ACD RID: 35533
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008ACE RID: 35534
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008ACF RID: 35535
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008AD0 RID: 35536
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008AD1 RID: 35537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AD2 RID: 35538
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AD3 RID: 35539
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AD4 RID: 35540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AD5 RID: 35541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AD6 RID: 35542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B85 RID: 2949
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nue+<>c__DisplayClass20_0")]
		public new sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D88D RID: 55437 RVA: 0x0034B4F8 File Offset: 0x003496F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr);
				Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, "cluster");
				Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_finalResultPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, "finalResultPair");
				Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_allColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, "allColor");
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679247);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Boolean_NueRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679248);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679249);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679250);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679251);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679252);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679253);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679254);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679255);
				Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr, 100679256);
			}

			// Token: 0x0600D88E RID: 55438 RVA: 0x0034B63C File Offset: 0x0034983C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D88F RID: 55439 RVA: 0x0034B678 File Offset: 0x00349878
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__1(Spell_Nue.NueRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Boolean_NueRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D890 RID: 55440 RVA: 0x0034B6CC File Offset: 0x003498CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200993, XrefRangeEnd = 200998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D891 RID: 55441 RVA: 0x0034B710 File Offset: 0x00349910
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 201005, RefRangeEnd = 201006, XrefRangeStart = 200998, XrefRangeEnd = 201005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D892 RID: 55442 RVA: 0x0034B744 File Offset: 0x00349944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201006, XrefRangeEnd = 201008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D893 RID: 55443 RVA: 0x0034B784 File Offset: 0x00349984
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 201015, RefRangeEnd = 201016, XrefRangeStart = 201008, XrefRangeEnd = 201015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D894 RID: 55444 RVA: 0x0034B7B8 File Offset: 0x003499B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201016, XrefRangeEnd = 201018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D895 RID: 55445 RVA: 0x0034B7F8 File Offset: 0x003499F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 201025, RefRangeEnd = 201026, XrefRangeStart = 201018, XrefRangeEnd = 201025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D896 RID: 55446 RVA: 0x0034B82C File Offset: 0x00349A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201026, XrefRangeEnd = 201028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D897 RID: 55447 RVA: 0x0034B86C File Offset: 0x00349A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201028, XrefRangeEnd = 201042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GameObject_PDM_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D898 RID: 55448 RVA: 0x00073E13 File Offset: 0x00072013
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700466F RID: 18031
			// (get) Token: 0x0600D899 RID: 55449 RVA: 0x0034B8B0 File Offset: 0x00349AB0
			// (set) Token: 0x0600D89A RID: 55450 RVA: 0x00073E1C File Offset: 0x0007201C
			public unsafe Spell_Nue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004670 RID: 18032
			// (get) Token: 0x0600D89B RID: 55451 RVA: 0x0034B8E0 File Offset: 0x00349AE0
			// (set) Token: 0x0600D89C RID: 55452 RVA: 0x00073E3B File Offset: 0x0007203B
			public unsafe UIElementCluster cluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_cluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004671 RID: 18033
			// (get) Token: 0x0600D89D RID: 55453 RVA: 0x0034B910 File Offset: 0x00349B10
			// (set) Token: 0x0600D89E RID: 55454 RVA: 0x00073E5A File Offset: 0x0007205A
			public Spell_Nue.NueRewardPair finalResultPair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_finalResultPair);
					return new Spell_Nue.NueRewardPair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_finalResultPair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Spell_Nue.NueRewardPair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004672 RID: 18034
			// (get) Token: 0x0600D89F RID: 55455 RVA: 0x0034B940 File Offset: 0x00349B40
			// (set) Token: 0x0600D8A0 RID: 55456 RVA: 0x00073E88 File Offset: 0x00072088
			public unsafe List<Spell_Nue.ColorType> allColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_allColor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Spell_Nue.ColorType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue.__c__DisplayClass20_0.NativeFieldInfoPtr_allColor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AD7 RID: 35543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AD8 RID: 35544
			private static readonly IntPtr NativeFieldInfoPtr_cluster;

			// Token: 0x04008AD9 RID: 35545
			private static readonly IntPtr NativeFieldInfoPtr_finalResultPair;

			// Token: 0x04008ADA RID: 35546
			private static readonly IntPtr NativeFieldInfoPtr_allColor;

			// Token: 0x04008ADB RID: 35547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ADC RID: 35548
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Boolean_NueRewardPair_0;

			// Token: 0x04008ADD RID: 35549
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0;

			// Token: 0x04008ADE RID: 35550
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04008ADF RID: 35551
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_Int32_0;

			// Token: 0x04008AE0 RID: 35552
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x04008AE1 RID: 35553
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Void_Int32_0;

			// Token: 0x04008AE2 RID: 35554
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_2;

			// Token: 0x04008AE3 RID: 35555
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Void_Int32_0;

			// Token: 0x04008AE4 RID: 35556
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0;
		}

		// Token: 0x02000B86 RID: 2950
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nue+<OnPositiveBuffExecute>d__20")]
		public sealed class _OnPositiveBuffExecute_d__20 : Il2CppSystem.Object
		{
			// Token: 0x0600D8A1 RID: 55457 RVA: 0x0034B970 File Offset: 0x00349B70
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__20()
			{
				Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nue>.NativeClassPtr, "<OnPositiveBuffExecute>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr);
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>1__state");
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>2__current");
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>4__this");
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, "spellExecutionContext");
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>8__1");
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100679257);
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100679258);
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100679259);
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100679260);
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100679261);
				Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100679262);
			}

			// Token: 0x0600D8A2 RID: 55458 RVA: 0x0034BA78 File Offset: 0x00349C78
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nue._OnPositiveBuffExecute_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8A3 RID: 55459 RVA: 0x0034BAC0 File Offset: 0x00349CC0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8A4 RID: 55460 RVA: 0x0034BAF4 File Offset: 0x00349CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201042, XrefRangeEnd = 201122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004678 RID: 18040
			// (get) Token: 0x0600D8A5 RID: 55461 RVA: 0x0034BB30 File Offset: 0x00349D30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8A6 RID: 55462 RVA: 0x0034BB70 File Offset: 0x00349D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201122, XrefRangeEnd = 201128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004679 RID: 18041
			// (get) Token: 0x0600D8A7 RID: 55463 RVA: 0x0034BBA4 File Offset: 0x00349DA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nue._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8A8 RID: 55464 RVA: 0x00073EA7 File Offset: 0x000720A7
			public _OnPositiveBuffExecute_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004673 RID: 18035
			// (get) Token: 0x0600D8A9 RID: 55465 RVA: 0x0034BBE4 File Offset: 0x00349DE4
			// (set) Token: 0x0600D8AA RID: 55466 RVA: 0x00073EB0 File Offset: 0x000720B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004674 RID: 18036
			// (get) Token: 0x0600D8AB RID: 55467 RVA: 0x0034BC0C File Offset: 0x00349E0C
			// (set) Token: 0x0600D8AC RID: 55468 RVA: 0x00073ECB File Offset: 0x000720CB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004675 RID: 18037
			// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x0034BC3C File Offset: 0x00349E3C
			// (set) Token: 0x0600D8AE RID: 55470 RVA: 0x00073EEA File Offset: 0x000720EA
			public unsafe Spell_Nue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004676 RID: 18038
			// (get) Token: 0x0600D8AF RID: 55471 RVA: 0x0034BC6C File Offset: 0x00349E6C
			// (set) Token: 0x0600D8B0 RID: 55472 RVA: 0x00073F09 File Offset: 0x00072109
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004677 RID: 18039
			// (get) Token: 0x0600D8B1 RID: 55473 RVA: 0x0034BC9C File Offset: 0x00349E9C
			// (set) Token: 0x0600D8B2 RID: 55474 RVA: 0x00073F28 File Offset: 0x00072128
			public unsafe Spell_Nue.__c__DisplayClass20_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nue.__c__DisplayClass20_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nue._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AE5 RID: 35557
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AE6 RID: 35558
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AE7 RID: 35559
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AE8 RID: 35560
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008AE9 RID: 35561
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008AEA RID: 35562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AEB RID: 35563
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AEC RID: 35564
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AED RID: 35565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AEE RID: 35566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AEF RID: 35567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
