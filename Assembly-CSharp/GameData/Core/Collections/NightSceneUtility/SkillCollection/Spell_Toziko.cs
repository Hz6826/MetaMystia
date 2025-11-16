using System;
using Common.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200028C RID: 652
	public class Spell_Toziko : SpellBase
	{
		// Token: 0x0600527B RID: 21115 RVA: 0x001B632C File Offset: 0x001B452C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Toziko()
		{
			Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Toziko");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr);
			Spell_Toziko.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "positiveDuration");
			Spell_Toziko.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "negativeDuration");
			Spell_Toziko.NativeFieldInfoPtr_extraMoveSpeedMultipier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "extraMoveSpeedMultipier");
			Spell_Toziko.NativeFieldInfoPtr_rewardThunderSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "rewardThunderSelf");
			Spell_Toziko.NativeFieldInfoPtr_rewardThunderPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "rewardThunderPartner");
			Spell_Toziko.NativeFieldInfoPtr_negativeThunderEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "negativeThunderEffect");
			Spell_Toziko.NativeFieldInfoPtr_immunityEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "immunityEffect");
			Spell_Toziko.NativeFieldInfoPtr_blackSmokeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "blackSmokeEffect");
			Spell_Toziko.NativeFieldInfoPtr_notEffectiveEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "notEffectiveEffect");
			Spell_Toziko.NativeFieldInfoPtr_stunFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "stunFace");
			Spell_Toziko.NativeFieldInfoPtr_stunEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "stunEffect");
			Spell_Toziko.NativeFieldInfoPtr_glowSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "glowSFX");
			Spell_Toziko.NativeFieldInfoPtr_electircSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "electircSFX");
			Spell_Toziko.NativeFieldInfoPtr_buffSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "buffSFX");
			Spell_Toziko.NativeFieldInfoPtr_thunderSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "thunderSFX");
			Spell_Toziko.NativeFieldInfoPtr_hitAunnSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "hitAunnSFX");
			Spell_Toziko.NativeFieldInfoPtr_hitHinaSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "hitHinaSFX");
			Spell_Toziko.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, 100680018);
			Spell_Toziko.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, 100680019);
			Spell_Toziko.NativeMethodInfoPtr_LightningWhenQteFail_Private_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, 100680020);
			Spell_Toziko.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, 100680021);
			Spell_Toziko.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, 100680022);
			Spell_Toziko.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, 100680023);
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x001B6528 File Offset: 0x001B4728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207162, XrefRangeEnd = 207164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Toziko.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x001B656C File Offset: 0x001B476C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207164, XrefRangeEnd = 207169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Toziko.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x001B65C8 File Offset: 0x001B47C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207169, XrefRangeEnd = 207185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightningWhenQteFail(CookController cookController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.NativeMethodInfoPtr_LightningWhenQteFail_Private_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x001B660C File Offset: 0x001B480C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207185, XrefRangeEnd = 207191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Toziko.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x001B6668 File Offset: 0x001B4868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Toziko() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x001B66A4 File Offset: 0x001B48A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207191, XrefRangeEnd = 207202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNegativeBuffExecute_b__18_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0002C16F File Offset: 0x0002A36F
		public Spell_Toziko(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06005283 RID: 21123 RVA: 0x001B66D8 File Offset: 0x001B48D8
		// (set) Token: 0x06005284 RID: 21124 RVA: 0x0002C178 File Offset: 0x0002A378
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x001B6700 File Offset: 0x001B4900
		// (set) Token: 0x06005286 RID: 21126 RVA: 0x0002C193 File Offset: 0x0002A393
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x001B6728 File Offset: 0x001B4928
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x0002C1AE File Offset: 0x0002A3AE
		public unsafe float extraMoveSpeedMultipier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_extraMoveSpeedMultipier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_extraMoveSpeedMultipier)) = value;
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x001B6750 File Offset: 0x001B4950
		// (set) Token: 0x0600528A RID: 21130 RVA: 0x0002C1C9 File Offset: 0x0002A3C9
		public unsafe GameObject rewardThunderSelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_rewardThunderSelf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_rewardThunderSelf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x001B6780 File Offset: 0x001B4980
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x0002C1E8 File Offset: 0x0002A3E8
		public unsafe GameObject rewardThunderPartner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_rewardThunderPartner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_rewardThunderPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x001B67B0 File Offset: 0x001B49B0
		// (set) Token: 0x0600528E RID: 21134 RVA: 0x0002C207 File Offset: 0x0002A407
		public unsafe GameObject negativeThunderEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_negativeThunderEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_negativeThunderEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x001B67E0 File Offset: 0x001B49E0
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x0002C226 File Offset: 0x0002A426
		public unsafe GameObject immunityEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_immunityEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_immunityEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x001B6810 File Offset: 0x001B4A10
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x0002C245 File Offset: 0x0002A445
		public unsafe GameObject blackSmokeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_blackSmokeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_blackSmokeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x001B6840 File Offset: 0x001B4A40
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x0002C264 File Offset: 0x0002A464
		public unsafe GameObject notEffectiveEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_notEffectiveEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_notEffectiveEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x001B6870 File Offset: 0x001B4A70
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x0002C283 File Offset: 0x0002A483
		public unsafe Sprite stunFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_stunFace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_stunFace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x001B68A0 File Offset: 0x001B4AA0
		// (set) Token: 0x06005298 RID: 21144 RVA: 0x0002C2A2 File Offset: 0x0002A4A2
		public unsafe GameObject stunEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_stunEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_stunEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x001B68D0 File Offset: 0x001B4AD0
		// (set) Token: 0x0600529A RID: 21146 RVA: 0x0002C2C1 File Offset: 0x0002A4C1
		public SpellBase.DelayAudioClip glowSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_glowSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_glowSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x001B6900 File Offset: 0x001B4B00
		// (set) Token: 0x0600529C RID: 21148 RVA: 0x0002C2EF File Offset: 0x0002A4EF
		public SpellBase.DelayAudioClip electircSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_electircSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_electircSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x001B6930 File Offset: 0x001B4B30
		// (set) Token: 0x0600529E RID: 21150 RVA: 0x0002C31D File Offset: 0x0002A51D
		public SpellBase.DelayAudioClip buffSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_buffSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_buffSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x001B6960 File Offset: 0x001B4B60
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x0002C34B File Offset: 0x0002A54B
		public SpellBase.DelayAudioClip thunderSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_thunderSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_thunderSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x001B6990 File Offset: 0x001B4B90
		// (set) Token: 0x060052A2 RID: 21154 RVA: 0x0002C379 File Offset: 0x0002A579
		public SpellBase.DelayAudioClip hitAunnSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_hitAunnSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_hitAunnSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x001B69C0 File Offset: 0x001B4BC0
		// (set) Token: 0x060052A4 RID: 21156 RVA: 0x0002C3A7 File Offset: 0x0002A5A7
		public SpellBase.DelayAudioClip hitHinaSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_hitHinaSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.NativeFieldInfoPtr_hitHinaSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeFieldInfoPtr_extraMoveSpeedMultipier;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeFieldInfoPtr_rewardThunderSelf;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeFieldInfoPtr_rewardThunderPartner;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeFieldInfoPtr_negativeThunderEffect;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeFieldInfoPtr_immunityEffect;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeFieldInfoPtr_blackSmokeEffect;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeFieldInfoPtr_notEffectiveEffect;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeFieldInfoPtr_stunFace;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeFieldInfoPtr_stunEffect;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeFieldInfoPtr_glowSFX;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeFieldInfoPtr_electircSFX;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeFieldInfoPtr_buffSFX;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeFieldInfoPtr_thunderSFX;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeFieldInfoPtr_hitAunnSFX;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeFieldInfoPtr_hitHinaSFX;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_LightningWhenQteFail_Private_Void_CookController_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_0_Private_Void_0;

		// Token: 0x02000BF5 RID: 3061
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<OnNegativeBuffExecute>d__18")]
		public sealed class _OnNegativeBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600DEB5 RID: 57013 RVA: 0x0035DF10 File Offset: 0x0035C110
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<OnNegativeBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr);
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680024);
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680025);
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680026);
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680027);
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680028);
				Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680029);
			}

			// Token: 0x0600DEB6 RID: 57014 RVA: 0x0035DFF0 File Offset: 0x0035C1F0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko._OnNegativeBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEB7 RID: 57015 RVA: 0x0035E038 File Offset: 0x0035C238
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEB8 RID: 57016 RVA: 0x0035E06C File Offset: 0x0035C26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206853, XrefRangeEnd = 206874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700485C RID: 18524
			// (get) Token: 0x0600DEB9 RID: 57017 RVA: 0x0035E0A8 File Offset: 0x0035C2A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEBA RID: 57018 RVA: 0x0035E0E8 File Offset: 0x0035C2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206874, XrefRangeEnd = 206880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700485D RID: 18525
			// (get) Token: 0x0600DEBB RID: 57019 RVA: 0x0035E11C File Offset: 0x0035C31C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEBC RID: 57020 RVA: 0x00076ECD File Offset: 0x000750CD
			public _OnNegativeBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004859 RID: 18521
			// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x0035E15C File Offset: 0x0035C35C
			// (set) Token: 0x0600DEBE RID: 57022 RVA: 0x00076ED6 File Offset: 0x000750D6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700485A RID: 18522
			// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x0035E184 File Offset: 0x0035C384
			// (set) Token: 0x0600DEC0 RID: 57024 RVA: 0x00076EF1 File Offset: 0x000750F1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700485B RID: 18523
			// (get) Token: 0x0600DEC1 RID: 57025 RVA: 0x0035E1B4 File Offset: 0x0035C3B4
			// (set) Token: 0x0600DEC2 RID: 57026 RVA: 0x00076F10 File Offset: 0x00075110
			public unsafe Spell_Toziko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E91 RID: 36497
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E92 RID: 36498
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E93 RID: 36499
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E94 RID: 36500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E95 RID: 36501
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E96 RID: 36502
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E97 RID: 36503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E98 RID: 36504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E99 RID: 36505
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BF6 RID: 3062
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEC3 RID: 57027 RVA: 0x0035E1E4 File Offset: 0x0035C3E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr);
				Spell_Toziko.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				Spell_Toziko.__c__DisplayClass19_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr, "partnerManager");
				Spell_Toziko.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr, 100680030);
				Spell_Toziko.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr, 100680031);
				Spell_Toziko.__c__DisplayClass19_0.NativeMethodInfoPtr__LightningWhenQteFail_b__1_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr, 100680032);
			}

			// Token: 0x0600DEC4 RID: 57028 RVA: 0x0035E274 File Offset: 0x0035C474
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEC5 RID: 57029 RVA: 0x0035E2B0 File Offset: 0x0035C4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207002, XrefRangeEnd = 207007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DEC6 RID: 57030 RVA: 0x0035E2F0 File Offset: 0x0035C4F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207007, XrefRangeEnd = 207008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LightningWhenQteFail_b__1(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.NativeMethodInfoPtr__LightningWhenQteFail_b__1_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEC7 RID: 57031 RVA: 0x00076F2F File Offset: 0x0007512F
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700485E RID: 18526
			// (get) Token: 0x0600DEC8 RID: 57032 RVA: 0x0035E340 File Offset: 0x0035C540
			// (set) Token: 0x0600DEC9 RID: 57033 RVA: 0x00076F38 File Offset: 0x00075138
			public unsafe Spell_Toziko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700485F RID: 18527
			// (get) Token: 0x0600DECA RID: 57034 RVA: 0x0035E370 File Offset: 0x0035C570
			// (set) Token: 0x0600DECB RID: 57035 RVA: 0x00076F57 File Offset: 0x00075157
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E9A RID: 36506
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E9B RID: 36507
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04008E9C RID: 36508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E9D RID: 36509
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008E9E RID: 36510
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__1_Internal_Boolean_PartnerBase_0;

			// Token: 0x02001047 RID: 4167
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass19_0+<<LightningWhenQteFail>g__SpawnLighting|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D18 RID: 72984 RVA: 0x004140D4 File Offset: 0x004122D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0>.NativeClassPtr, "<<LightningWhenQteFail>g__SpawnLighting|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr);
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr__allPartner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, "<allPartner>5__2");
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, 100680033);
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, 100680034);
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, 100680035);
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, 100680036);
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, 100680037);
					Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr, 100680038);
				}

				// Token: 0x06011D19 RID: 72985 RVA: 0x004141DC File Offset: 0x004123DC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D1A RID: 72986 RVA: 0x00414224 File Offset: 0x00412424
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D1B RID: 72987 RVA: 0x00414258 File Offset: 0x00412458
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206880, XrefRangeEnd = 206996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CD7 RID: 23767
				// (get) Token: 0x06011D1C RID: 72988 RVA: 0x00414294 File Offset: 0x00412494
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D1D RID: 72989 RVA: 0x004142D4 File Offset: 0x004124D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206996, XrefRangeEnd = 207002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CD8 RID: 23768
				// (get) Token: 0x06011D1E RID: 72990 RVA: 0x00414308 File Offset: 0x00412508
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D1F RID: 72991 RVA: 0x0009ACEF File Offset: 0x00098EEF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CD2 RID: 23762
				// (get) Token: 0x06011D20 RID: 72992 RVA: 0x00414348 File Offset: 0x00412548
				// (set) Token: 0x06011D21 RID: 72993 RVA: 0x0009ACF8 File Offset: 0x00098EF8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CD3 RID: 23763
				// (get) Token: 0x06011D22 RID: 72994 RVA: 0x00414370 File Offset: 0x00412570
				// (set) Token: 0x06011D23 RID: 72995 RVA: 0x0009AD13 File Offset: 0x00098F13
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CD4 RID: 23764
				// (get) Token: 0x06011D24 RID: 72996 RVA: 0x004143A0 File Offset: 0x004125A0
				// (set) Token: 0x06011D25 RID: 72997 RVA: 0x0009AD32 File Offset: 0x00098F32
				public unsafe Spell_Toziko.__c__DisplayClass19_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass19_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CD5 RID: 23765
				// (get) Token: 0x06011D26 RID: 72998 RVA: 0x004143D0 File Offset: 0x004125D0
				// (set) Token: 0x06011D27 RID: 72999 RVA: 0x0009AD51 File Offset: 0x00098F51
				public unsafe Spell_Toziko.__c__DisplayClass19_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass19_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CD6 RID: 23766
				// (get) Token: 0x06011D28 RID: 73000 RVA: 0x00414400 File Offset: 0x00412600
				// (set) Token: 0x06011D29 RID: 73001 RVA: 0x0009AD70 File Offset: 0x00098F70
				public unsafe IEnumerable<PartnerBase> _allPartner_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr__allPartner_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<PartnerBase>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1PaObObUnique.NativeFieldInfoPtr__allPartner_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B41B RID: 46107
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B41C RID: 46108
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B41D RID: 46109
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B41E RID: 46110
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B41F RID: 46111
				private static readonly IntPtr NativeFieldInfoPtr__allPartner_5__2;

				// Token: 0x0400B420 RID: 46112
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B421 RID: 46113
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B422 RID: 46114
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B423 RID: 46115
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B424 RID: 46116
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B425 RID: 46117
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BF7 RID: 3063
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DECC RID: 57036 RVA: 0x0035E3A0 File Offset: 0x0035C5A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr);
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_thunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "thunder");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_targetPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "targetPartner");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_shouldFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "shouldFollow");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_partnerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "partnerTransform");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_stunEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "stunEffect");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_characterControllerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "characterControllerUnit");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_oldFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "oldFace");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_partnerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "partnerList");
				Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680039);
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680040);
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__8_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680041);
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__10_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680042);
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__5_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680043);
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__6_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680044);
				Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, 100680045);
			}

			// Token: 0x0600DECD RID: 57037 RVA: 0x0035E50C File Offset: 0x0035C70C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DECE RID: 57038 RVA: 0x0035E548 File Offset: 0x0035C748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207019, XrefRangeEnd = 207024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DECF RID: 57039 RVA: 0x0035E588 File Offset: 0x0035C788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207024, XrefRangeEnd = 207028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LightningWhenQteFail_b__8(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__8_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED0 RID: 57040 RVA: 0x0035E5CC File Offset: 0x0035C7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207028, XrefRangeEnd = 207032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LightningWhenQteFail_b__10(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__10_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED1 RID: 57041 RVA: 0x0035E610 File Offset: 0x0035C810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207032, XrefRangeEnd = 207036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LightningWhenQteFail_b__5(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__5_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED2 RID: 57042 RVA: 0x0035E654 File Offset: 0x0035C854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207036, XrefRangeEnd = 207048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _LightningWhenQteFail_b__6(int a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr__LightningWhenQteFail_b__6_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DED3 RID: 57043 RVA: 0x0035E6AC File Offset: 0x0035C8AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207048, XrefRangeEnd = 207059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED4 RID: 57044 RVA: 0x00076F76 File Offset: 0x00075176
			public __c__DisplayClass19_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004860 RID: 18528
			// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x0035E6E0 File Offset: 0x0035C8E0
			// (set) Token: 0x0600DED6 RID: 57046 RVA: 0x00076F7F File Offset: 0x0007517F
			public unsafe GameObject thunder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_thunder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_thunder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004861 RID: 18529
			// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x0035E710 File Offset: 0x0035C910
			// (set) Token: 0x0600DED8 RID: 57048 RVA: 0x00076F9E File Offset: 0x0007519E
			public unsafe PartnerBase targetPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_targetPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_targetPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004862 RID: 18530
			// (get) Token: 0x0600DED9 RID: 57049 RVA: 0x0035E740 File Offset: 0x0035C940
			// (set) Token: 0x0600DEDA RID: 57050 RVA: 0x00076FBD File Offset: 0x000751BD
			public unsafe bool shouldFollow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_shouldFollow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_shouldFollow)) = value;
				}
			}

			// Token: 0x17004863 RID: 18531
			// (get) Token: 0x0600DEDB RID: 57051 RVA: 0x0035E768 File Offset: 0x0035C968
			// (set) Token: 0x0600DEDC RID: 57052 RVA: 0x00076FD8 File Offset: 0x000751D8
			public unsafe Transform partnerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_partnerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_partnerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004864 RID: 18532
			// (get) Token: 0x0600DEDD RID: 57053 RVA: 0x0035E798 File Offset: 0x0035C998
			// (set) Token: 0x0600DEDE RID: 57054 RVA: 0x00076FF7 File Offset: 0x000751F7
			public unsafe GameObject stunEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_stunEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_stunEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004865 RID: 18533
			// (get) Token: 0x0600DEDF RID: 57055 RVA: 0x0035E7C8 File Offset: 0x0035C9C8
			// (set) Token: 0x0600DEE0 RID: 57056 RVA: 0x00077016 File Offset: 0x00075216
			public unsafe CharacterControllerUnit characterControllerUnit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_characterControllerUnit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_characterControllerUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004866 RID: 18534
			// (get) Token: 0x0600DEE1 RID: 57057 RVA: 0x0035E7F8 File Offset: 0x0035C9F8
			// (set) Token: 0x0600DEE2 RID: 57058 RVA: 0x00077035 File Offset: 0x00075235
			public unsafe Sprite oldFace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_oldFace);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_oldFace), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004867 RID: 18535
			// (get) Token: 0x0600DEE3 RID: 57059 RVA: 0x0035E828 File Offset: 0x0035CA28
			// (set) Token: 0x0600DEE4 RID: 57060 RVA: 0x00077054 File Offset: 0x00075254
			public unsafe List<int> partnerList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_partnerList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_partnerList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004868 RID: 18536
			// (get) Token: 0x0600DEE5 RID: 57061 RVA: 0x0035E858 File Offset: 0x0035CA58
			// (set) Token: 0x0600DEE6 RID: 57062 RVA: 0x00077073 File Offset: 0x00075273
			public unsafe Spell_Toziko.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E9F RID: 36511
			private static readonly IntPtr NativeFieldInfoPtr_thunder;

			// Token: 0x04008EA0 RID: 36512
			private static readonly IntPtr NativeFieldInfoPtr_targetPartner;

			// Token: 0x04008EA1 RID: 36513
			private static readonly IntPtr NativeFieldInfoPtr_shouldFollow;

			// Token: 0x04008EA2 RID: 36514
			private static readonly IntPtr NativeFieldInfoPtr_partnerTransform;

			// Token: 0x04008EA3 RID: 36515
			private static readonly IntPtr NativeFieldInfoPtr_stunEffect;

			// Token: 0x04008EA4 RID: 36516
			private static readonly IntPtr NativeFieldInfoPtr_characterControllerUnit;

			// Token: 0x04008EA5 RID: 36517
			private static readonly IntPtr NativeFieldInfoPtr_oldFace;

			// Token: 0x04008EA6 RID: 36518
			private static readonly IntPtr NativeFieldInfoPtr_partnerList;

			// Token: 0x04008EA7 RID: 36519
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;

			// Token: 0x04008EA8 RID: 36520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EA9 RID: 36521
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008EAA RID: 36522
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__8_Internal_Void_GameObject_0;

			// Token: 0x04008EAB RID: 36523
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__10_Internal_Void_GameObject_0;

			// Token: 0x04008EAC RID: 36524
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__5_Internal_Void_GameObject_0;

			// Token: 0x04008EAD RID: 36525
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__6_Internal_String_Int32_String_0;

			// Token: 0x04008EAE RID: 36526
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02001048 RID: 4168
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass19_1+<<LightningWhenQteFail>g__Follow|4>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D2A RID: 73002 RVA: 0x00414430 File Offset: 0x00412630
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1>.NativeClassPtr, "<<LightningWhenQteFail>g__Follow|4>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680046);
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680047);
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680048);
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680049);
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680050);
					Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680051);
				}

				// Token: 0x06011D2B RID: 73003 RVA: 0x00414510 File Offset: 0x00412710
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D2C RID: 73004 RVA: 0x00414558 File Offset: 0x00412758
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D2D RID: 73005 RVA: 0x0041458C File Offset: 0x0041278C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207008, XrefRangeEnd = 207013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CDC RID: 23772
				// (get) Token: 0x06011D2E RID: 73006 RVA: 0x004145C8 File Offset: 0x004127C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D2F RID: 73007 RVA: 0x00414608 File Offset: 0x00412808
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207013, XrefRangeEnd = 207019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CDD RID: 23773
				// (get) Token: 0x06011D30 RID: 73008 RVA: 0x0041463C File Offset: 0x0041283C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D31 RID: 73009 RVA: 0x0009AD8F File Offset: 0x00098F8F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CD9 RID: 23769
				// (get) Token: 0x06011D32 RID: 73010 RVA: 0x0041467C File Offset: 0x0041287C
				// (set) Token: 0x06011D33 RID: 73011 RVA: 0x0009AD98 File Offset: 0x00098F98
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CDA RID: 23770
				// (get) Token: 0x06011D34 RID: 73012 RVA: 0x004146A4 File Offset: 0x004128A4
				// (set) Token: 0x06011D35 RID: 73013 RVA: 0x0009ADB3 File Offset: 0x00098FB3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CDB RID: 23771
				// (get) Token: 0x06011D36 RID: 73014 RVA: 0x004146D4 File Offset: 0x004128D4
				// (set) Token: 0x06011D37 RID: 73015 RVA: 0x0009ADD2 File Offset: 0x00098FD2
				public unsafe Spell_Toziko.__c__DisplayClass19_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass19_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass19_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B426 RID: 46118
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B427 RID: 46119
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B428 RID: 46120
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B429 RID: 46121
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B42A RID: 46122
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B42B RID: 46123
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B42C RID: 46124
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B42D RID: 46125
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B42E RID: 46126
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BF8 RID: 3064
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DEE7 RID: 57063 RVA: 0x0035E888 File Offset: 0x0035CA88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr);
				Spell_Toziko.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, "<>9");
				Spell_Toziko.__c.NativeFieldInfoPtr___9__19_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, "<>9__19_2");
				Spell_Toziko.__c.NativeFieldInfoPtr___9__19_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, "<>9__19_3");
				Spell_Toziko.__c.NativeFieldInfoPtr___9__19_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, "<>9__19_9");
				Spell_Toziko.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, 100680053);
				Spell_Toziko.__c.NativeMethodInfoPtr__LightningWhenQteFail_b__19_2_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, 100680054);
				Spell_Toziko.__c.NativeMethodInfoPtr__LightningWhenQteFail_b__19_3_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, 100680055);
				Spell_Toziko.__c.NativeMethodInfoPtr__LightningWhenQteFail_b__19_9_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr, 100680056);
			}

			// Token: 0x0600DEE8 RID: 57064 RVA: 0x0035E954 File Offset: 0x0035CB54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEE9 RID: 57065 RVA: 0x0035E990 File Offset: 0x0035CB90
			[CallerCount(0)]
			public unsafe bool _LightningWhenQteFail_b__19_2(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c.NativeMethodInfoPtr__LightningWhenQteFail_b__19_2_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEEA RID: 57066 RVA: 0x0035E9E0 File Offset: 0x0035CBE0
			[CallerCount(0)]
			public unsafe bool _LightningWhenQteFail_b__19_3(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c.NativeMethodInfoPtr__LightningWhenQteFail_b__19_3_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEEB RID: 57067 RVA: 0x0035EA30 File Offset: 0x0035CC30
			[CallerCount(0)]
			public unsafe bool _LightningWhenQteFail_b__19_9(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c.NativeMethodInfoPtr__LightningWhenQteFail_b__19_9_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEEC RID: 57068 RVA: 0x00077092 File Offset: 0x00075292
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004869 RID: 18537
			// (get) Token: 0x0600DEED RID: 57069 RVA: 0x0035EA80 File Offset: 0x0035CC80
			// (set) Token: 0x0600DEEE RID: 57070 RVA: 0x0007709B File Offset: 0x0007529B
			public unsafe static Spell_Toziko.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toziko.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toziko.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700486A RID: 18538
			// (get) Token: 0x0600DEEF RID: 57071 RVA: 0x0035EAA8 File Offset: 0x0035CCA8
			// (set) Token: 0x0600DEF0 RID: 57072 RVA: 0x000770AD File Offset: 0x000752AD
			public unsafe static Func<PartnerBase, bool> __9__19_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toziko.__c.NativeFieldInfoPtr___9__19_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toziko.__c.NativeFieldInfoPtr___9__19_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700486B RID: 18539
			// (get) Token: 0x0600DEF1 RID: 57073 RVA: 0x0035EAD0 File Offset: 0x0035CCD0
			// (set) Token: 0x0600DEF2 RID: 57074 RVA: 0x000770BF File Offset: 0x000752BF
			public unsafe static Func<PartnerBase, bool> __9__19_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toziko.__c.NativeFieldInfoPtr___9__19_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toziko.__c.NativeFieldInfoPtr___9__19_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700486C RID: 18540
			// (get) Token: 0x0600DEF3 RID: 57075 RVA: 0x0035EAF8 File Offset: 0x0035CCF8
			// (set) Token: 0x0600DEF4 RID: 57076 RVA: 0x000770D1 File Offset: 0x000752D1
			public unsafe static Func<PartnerBase, bool> __9__19_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toziko.__c.NativeFieldInfoPtr___9__19_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toziko.__c.NativeFieldInfoPtr___9__19_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EAF RID: 36527
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EB0 RID: 36528
			private static readonly IntPtr NativeFieldInfoPtr___9__19_2;

			// Token: 0x04008EB1 RID: 36529
			private static readonly IntPtr NativeFieldInfoPtr___9__19_3;

			// Token: 0x04008EB2 RID: 36530
			private static readonly IntPtr NativeFieldInfoPtr___9__19_9;

			// Token: 0x04008EB3 RID: 36531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB4 RID: 36532
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__19_2_Internal_Boolean_PartnerBase_0;

			// Token: 0x04008EB5 RID: 36533
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__19_3_Internal_Boolean_PartnerBase_0;

			// Token: 0x04008EB6 RID: 36534
			private static readonly IntPtr NativeMethodInfoPtr__LightningWhenQteFail_b__19_9_Internal_Boolean_PartnerBase_0;
		}

		// Token: 0x02000BF9 RID: 3065
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass20_0")]
		public new sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEF5 RID: 57077 RVA: 0x0035EB20 File Offset: 0x0035CD20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr);
				Spell_Toziko.__c__DisplayClass20_0.NativeFieldInfoPtr_thunderNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr, "thunderNum");
				Spell_Toziko.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				Spell_Toziko.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr, 100680057);
				Spell_Toziko.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr, 100680058);
				Spell_Toziko.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr, 100680059);
			}

			// Token: 0x0600DEF6 RID: 57078 RVA: 0x0035EBB0 File Offset: 0x0035CDB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEF7 RID: 57079 RVA: 0x0035EBEC File Offset: 0x0035CDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207059, XrefRangeEnd = 207069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEF8 RID: 57080 RVA: 0x0035EC2C File Offset: 0x0035CE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207069, XrefRangeEnd = 207071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEF9 RID: 57081 RVA: 0x000770E3 File Offset: 0x000752E3
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700486D RID: 18541
			// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x0035EC60 File Offset: 0x0035CE60
			// (set) Token: 0x0600DEFB RID: 57083 RVA: 0x000770EC File Offset: 0x000752EC
			public unsafe int thunderNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_0.NativeFieldInfoPtr_thunderNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_0.NativeFieldInfoPtr_thunderNum)) = value;
				}
			}

			// Token: 0x1700486E RID: 18542
			// (get) Token: 0x0600DEFC RID: 57084 RVA: 0x0035EC88 File Offset: 0x0035CE88
			// (set) Token: 0x0600DEFD RID: 57085 RVA: 0x00077107 File Offset: 0x00075307
			public unsafe Spell_Toziko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EB7 RID: 36535
			private static readonly IntPtr NativeFieldInfoPtr_thunderNum;

			// Token: 0x04008EB8 RID: 36536
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EB9 RID: 36537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EBA RID: 36538
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0;

			// Token: 0x04008EBB RID: 36539
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000BFA RID: 3066
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DEFE RID: 57086 RVA: 0x0035ECB8 File Offset: 0x0035CEB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr);
				Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_partnerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr, "partnerTransform");
				Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_thunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr, "thunder");
				Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Toziko.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr, 100680060);
				Spell_Toziko.__c__DisplayClass20_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr, 100680061);
			}

			// Token: 0x0600DEFF RID: 57087 RVA: 0x0035ED48 File Offset: 0x0035CF48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF00 RID: 57088 RVA: 0x0035ED84 File Offset: 0x0035CF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207091, XrefRangeEnd = 207096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF01 RID: 57089 RVA: 0x00077126 File Offset: 0x00075326
			public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700486F RID: 18543
			// (get) Token: 0x0600DF02 RID: 57090 RVA: 0x0035EDC4 File Offset: 0x0035CFC4
			// (set) Token: 0x0600DF03 RID: 57091 RVA: 0x0007712F File Offset: 0x0007532F
			public unsafe Transform partnerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_partnerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_partnerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004870 RID: 18544
			// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x0035EDF4 File Offset: 0x0035CFF4
			// (set) Token: 0x0600DF05 RID: 57093 RVA: 0x0007714E File Offset: 0x0007534E
			public unsafe GameObject thunder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_thunder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_thunder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004871 RID: 18545
			// (get) Token: 0x0600DF06 RID: 57094 RVA: 0x0035EE24 File Offset: 0x0035D024
			// (set) Token: 0x0600DF07 RID: 57095 RVA: 0x0007716D File Offset: 0x0007536D
			public unsafe Spell_Toziko.__c__DisplayClass20_0 field_Public___c__DisplayClass20_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass20_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EBC RID: 36540
			private static readonly IntPtr NativeFieldInfoPtr_partnerTransform;

			// Token: 0x04008EBD RID: 36541
			private static readonly IntPtr NativeFieldInfoPtr_thunder;

			// Token: 0x04008EBE RID: 36542
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0;

			// Token: 0x04008EBF RID: 36543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EC0 RID: 36544
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001049 RID: 4169
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<>c__DisplayClass20_1+<<OnPositiveBuffExecute>g__Delay|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D38 RID: 73016 RVA: 0x00414704 File Offset: 0x00412904
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Delay|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr);
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<thisPartner>5__2");
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisThunderObject_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<thisThunderObject>5__3");
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100680062);
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100680063);
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100680064);
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100680065);
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100680066);
					Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100680067);
				}

				// Token: 0x06011D39 RID: 73017 RVA: 0x0041480C File Offset: 0x00412A0C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D3A RID: 73018 RVA: 0x00414854 File Offset: 0x00412A54
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D3B RID: 73019 RVA: 0x00414888 File Offset: 0x00412A88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207071, XrefRangeEnd = 207085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CE3 RID: 23779
				// (get) Token: 0x06011D3C RID: 73020 RVA: 0x004148C4 File Offset: 0x00412AC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D3D RID: 73021 RVA: 0x00414904 File Offset: 0x00412B04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207085, XrefRangeEnd = 207091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CE4 RID: 23780
				// (get) Token: 0x06011D3E RID: 73022 RVA: 0x00414938 File Offset: 0x00412B38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D3F RID: 73023 RVA: 0x0009ADF1 File Offset: 0x00098FF1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CDE RID: 23774
				// (get) Token: 0x06011D40 RID: 73024 RVA: 0x00414978 File Offset: 0x00412B78
				// (set) Token: 0x06011D41 RID: 73025 RVA: 0x0009ADFA File Offset: 0x00098FFA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CDF RID: 23775
				// (get) Token: 0x06011D42 RID: 73026 RVA: 0x004149A0 File Offset: 0x00412BA0
				// (set) Token: 0x06011D43 RID: 73027 RVA: 0x0009AE15 File Offset: 0x00099015
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CE0 RID: 23776
				// (get) Token: 0x06011D44 RID: 73028 RVA: 0x004149D0 File Offset: 0x00412BD0
				// (set) Token: 0x06011D45 RID: 73029 RVA: 0x0009AE34 File Offset: 0x00099034
				public unsafe Spell_Toziko.__c__DisplayClass20_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass20_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CE1 RID: 23777
				// (get) Token: 0x06011D46 RID: 73030 RVA: 0x00414A00 File Offset: 0x00412C00
				// (set) Token: 0x06011D47 RID: 73031 RVA: 0x0009AE53 File Offset: 0x00099053
				public unsafe Transform _thisPartner_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CE2 RID: 23778
				// (get) Token: 0x06011D48 RID: 73032 RVA: 0x00414A30 File Offset: 0x00412C30
				// (set) Token: 0x06011D49 RID: 73033 RVA: 0x0009AE72 File Offset: 0x00099072
				public unsafe GameObject _thisThunderObject_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisThunderObject_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko.__c__DisplayClass20_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisThunderObject_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B42F RID: 46127
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B430 RID: 46128
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B431 RID: 46129
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B432 RID: 46130
				private static readonly IntPtr NativeFieldInfoPtr__thisPartner_5__2;

				// Token: 0x0400B433 RID: 46131
				private static readonly IntPtr NativeFieldInfoPtr__thisThunderObject_5__3;

				// Token: 0x0400B434 RID: 46132
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B435 RID: 46133
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B436 RID: 46134
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B437 RID: 46135
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B438 RID: 46136
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B439 RID: 46137
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BFB RID: 3067
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toziko+<OnPositiveBuffExecute>d__20")]
		public sealed class _OnPositiveBuffExecute_d__20 : Il2CppSystem.Object
		{
			// Token: 0x0600DF08 RID: 57096 RVA: 0x0035EE54 File Offset: 0x0035D054
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__20()
			{
				Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toziko>.NativeClassPtr, "<OnPositiveBuffExecute>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr);
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>1__state");
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>2__current");
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>4__this");
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, "spellExecutionContext");
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>8__1");
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680068);
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680069);
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680070);
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680071);
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680072);
				Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680073);
			}

			// Token: 0x0600DF09 RID: 57097 RVA: 0x0035EF5C File Offset: 0x0035D15C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toziko._OnPositiveBuffExecute_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF0A RID: 57098 RVA: 0x0035EFA4 File Offset: 0x0035D1A4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF0B RID: 57099 RVA: 0x0035EFD8 File Offset: 0x0035D1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207096, XrefRangeEnd = 207156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004877 RID: 18551
			// (get) Token: 0x0600DF0C RID: 57100 RVA: 0x0035F014 File Offset: 0x0035D214
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF0D RID: 57101 RVA: 0x0035F054 File Offset: 0x0035D254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207156, XrefRangeEnd = 207162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004878 RID: 18552
			// (get) Token: 0x0600DF0E RID: 57102 RVA: 0x0035F088 File Offset: 0x0035D288
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF0F RID: 57103 RVA: 0x0007718C File Offset: 0x0007538C
			public _OnPositiveBuffExecute_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004872 RID: 18546
			// (get) Token: 0x0600DF10 RID: 57104 RVA: 0x0035F0C8 File Offset: 0x0035D2C8
			// (set) Token: 0x0600DF11 RID: 57105 RVA: 0x00077195 File Offset: 0x00075395
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004873 RID: 18547
			// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x0035F0F0 File Offset: 0x0035D2F0
			// (set) Token: 0x0600DF13 RID: 57107 RVA: 0x000771B0 File Offset: 0x000753B0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004874 RID: 18548
			// (get) Token: 0x0600DF14 RID: 57108 RVA: 0x0035F120 File Offset: 0x0035D320
			// (set) Token: 0x0600DF15 RID: 57109 RVA: 0x000771CF File Offset: 0x000753CF
			public unsafe Spell_Toziko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004875 RID: 18549
			// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x0035F150 File Offset: 0x0035D350
			// (set) Token: 0x0600DF17 RID: 57111 RVA: 0x000771EE File Offset: 0x000753EE
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004876 RID: 18550
			// (get) Token: 0x0600DF18 RID: 57112 RVA: 0x0035F180 File Offset: 0x0035D380
			// (set) Token: 0x0600DF19 RID: 57113 RVA: 0x0007720D File Offset: 0x0007540D
			public unsafe Spell_Toziko.__c__DisplayClass20_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toziko.__c__DisplayClass20_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toziko._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EC1 RID: 36545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EC2 RID: 36546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EC3 RID: 36547
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EC4 RID: 36548
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008EC5 RID: 36549
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008EC6 RID: 36550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EC7 RID: 36551
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EC8 RID: 36552
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EC9 RID: 36553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008ECA RID: 36554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ECB RID: 36555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
