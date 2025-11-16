using System;
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
	// Token: 0x0200027A RID: 634
	public class Spell_Patchouli : SpellBase
	{
		// Token: 0x06004F96 RID: 20374 RVA: 0x001AEC64 File Offset: 0x001ACE64
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Patchouli()
		{
			Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Patchouli");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr);
			Spell_Patchouli.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "positiveDuration");
			Spell_Patchouli.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "negativeDuration");
			Spell_Patchouli.NativeFieldInfoPtr_philosopherStoneInfluencedTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "philosopherStoneInfluencedTags");
			Spell_Patchouli.NativeFieldInfoPtr_baseEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "baseEval");
			Spell_Patchouli.NativeFieldInfoPtr_failedFoodRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "failedFoodRate");
			Spell_Patchouli.NativeFieldInfoPtr_philosopherStoneEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "philosopherStoneEffect");
			Spell_Patchouli.NativeFieldInfoPtr_bookAppearsSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "bookAppearsSFX");
			Spell_Patchouli.NativeFieldInfoPtr_bookFlipSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "bookFlipSFX");
			Spell_Patchouli.NativeFieldInfoPtr_bookFlipOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "bookFlipOffset");
			Spell_Patchouli.NativeFieldInfoPtr_effectSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "effectSFX");
			Spell_Patchouli.NativeFieldInfoPtr_effectOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "effectOffset");
			Spell_Patchouli.NativeFieldInfoPtr_positiveEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "positiveEffectDuration");
			Spell_Patchouli.NativeFieldInfoPtr_mercuryPoisonEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "mercuryPoisonEffect");
			Spell_Patchouli.NativeFieldInfoPtr_negativeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "negativeEffectDuration");
			Spell_Patchouli.NativeFieldInfoPtr_negativeEffectSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "negativeEffectSFX");
			Spell_Patchouli.NativeFieldInfoPtr_negativeEffectWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "negativeEffectWait");
			Spell_Patchouli.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, 100679316);
			Spell_Patchouli.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, 100679317);
			Spell_Patchouli.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, 100679318);
			Spell_Patchouli.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, 100679319);
			Spell_Patchouli.NativeMethodInfoPtr__OnPositiveBuffExecute_b__18_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, 100679320);
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x001AEE38 File Offset: 0x001AD038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201613, XrefRangeEnd = 201615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Patchouli.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x001AEE7C File Offset: 0x001AD07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201615, XrefRangeEnd = 201620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Patchouli.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x001AEED8 File Offset: 0x001AD0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201620, XrefRangeEnd = 201625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Patchouli.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x001AEF34 File Offset: 0x001AD134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201625, XrefRangeEnd = 201626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Patchouli() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x001AEF70 File Offset: 0x001AD170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201626, XrefRangeEnd = 201628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__18_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.NativeMethodInfoPtr__OnPositiveBuffExecute_b__18_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00029F10 File Offset: 0x00028110
		public Spell_Patchouli(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x001AEFB0 File Offset: 0x001AD1B0
		// (set) Token: 0x06004F9E RID: 20382 RVA: 0x00029F19 File Offset: 0x00028119
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06004F9F RID: 20383 RVA: 0x001AEFD8 File Offset: 0x001AD1D8
		// (set) Token: 0x06004FA0 RID: 20384 RVA: 0x00029F34 File Offset: 0x00028134
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x001AF000 File Offset: 0x001AD200
		// (set) Token: 0x06004FA2 RID: 20386 RVA: 0x00029F4F File Offset: 0x0002814F
		public unsafe Il2CppStructArray<int> philosopherStoneInfluencedTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_philosopherStoneInfluencedTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_philosopherStoneInfluencedTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x001AF030 File Offset: 0x001AD230
		// (set) Token: 0x06004FA4 RID: 20388 RVA: 0x00029F6E File Offset: 0x0002816E
		public unsafe int baseEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_baseEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_baseEval)) = value;
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x001AF058 File Offset: 0x001AD258
		// (set) Token: 0x06004FA6 RID: 20390 RVA: 0x00029F89 File Offset: 0x00028189
		public unsafe float failedFoodRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_failedFoodRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_failedFoodRate)) = value;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x001AF080 File Offset: 0x001AD280
		// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x00029FA4 File Offset: 0x000281A4
		public unsafe GameObject philosopherStoneEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_philosopherStoneEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_philosopherStoneEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x001AF0B0 File Offset: 0x001AD2B0
		// (set) Token: 0x06004FAA RID: 20394 RVA: 0x00029FC3 File Offset: 0x000281C3
		public unsafe AudioClip bookAppearsSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_bookAppearsSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_bookAppearsSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x001AF0E0 File Offset: 0x001AD2E0
		// (set) Token: 0x06004FAC RID: 20396 RVA: 0x00029FE2 File Offset: 0x000281E2
		public unsafe AudioClip bookFlipSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_bookFlipSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_bookFlipSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x001AF110 File Offset: 0x001AD310
		// (set) Token: 0x06004FAE RID: 20398 RVA: 0x0002A001 File Offset: 0x00028201
		public unsafe float bookFlipOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_bookFlipOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_bookFlipOffset)) = value;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x001AF138 File Offset: 0x001AD338
		// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x0002A01C File Offset: 0x0002821C
		public unsafe AudioClip effectSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_effectSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_effectSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x001AF168 File Offset: 0x001AD368
		// (set) Token: 0x06004FB2 RID: 20402 RVA: 0x0002A03B File Offset: 0x0002823B
		public unsafe float effectOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_effectOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_effectOffset)) = value;
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x001AF190 File Offset: 0x001AD390
		// (set) Token: 0x06004FB4 RID: 20404 RVA: 0x0002A056 File Offset: 0x00028256
		public unsafe float positiveEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_positiveEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_positiveEffectDuration)) = value;
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x001AF1B8 File Offset: 0x001AD3B8
		// (set) Token: 0x06004FB6 RID: 20406 RVA: 0x0002A071 File Offset: 0x00028271
		public unsafe GameObject mercuryPoisonEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_mercuryPoisonEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_mercuryPoisonEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x001AF1E8 File Offset: 0x001AD3E8
		// (set) Token: 0x06004FB8 RID: 20408 RVA: 0x0002A090 File Offset: 0x00028290
		public unsafe float negativeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeEffectDuration)) = value;
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x001AF210 File Offset: 0x001AD410
		// (set) Token: 0x06004FBA RID: 20410 RVA: 0x0002A0AB File Offset: 0x000282AB
		public unsafe AudioClip negativeEffectSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeEffectSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeEffectSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x001AF240 File Offset: 0x001AD440
		// (set) Token: 0x06004FBC RID: 20412 RVA: 0x0002A0CA File Offset: 0x000282CA
		public unsafe float negativeEffectWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeEffectWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.NativeFieldInfoPtr_negativeEffectWait)) = value;
			}
		}

		// Token: 0x04003602 RID: 13826
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003603 RID: 13827
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003604 RID: 13828
		private static readonly IntPtr NativeFieldInfoPtr_philosopherStoneInfluencedTags;

		// Token: 0x04003605 RID: 13829
		private static readonly IntPtr NativeFieldInfoPtr_baseEval;

		// Token: 0x04003606 RID: 13830
		private static readonly IntPtr NativeFieldInfoPtr_failedFoodRate;

		// Token: 0x04003607 RID: 13831
		private static readonly IntPtr NativeFieldInfoPtr_philosopherStoneEffect;

		// Token: 0x04003608 RID: 13832
		private static readonly IntPtr NativeFieldInfoPtr_bookAppearsSFX;

		// Token: 0x04003609 RID: 13833
		private static readonly IntPtr NativeFieldInfoPtr_bookFlipSFX;

		// Token: 0x0400360A RID: 13834
		private static readonly IntPtr NativeFieldInfoPtr_bookFlipOffset;

		// Token: 0x0400360B RID: 13835
		private static readonly IntPtr NativeFieldInfoPtr_effectSFX;

		// Token: 0x0400360C RID: 13836
		private static readonly IntPtr NativeFieldInfoPtr_effectOffset;

		// Token: 0x0400360D RID: 13837
		private static readonly IntPtr NativeFieldInfoPtr_positiveEffectDuration;

		// Token: 0x0400360E RID: 13838
		private static readonly IntPtr NativeFieldInfoPtr_mercuryPoisonEffect;

		// Token: 0x0400360F RID: 13839
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectDuration;

		// Token: 0x04003610 RID: 13840
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectSFX;

		// Token: 0x04003611 RID: 13841
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectWait;

		// Token: 0x04003612 RID: 13842
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003613 RID: 13843
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003614 RID: 13844
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003615 RID: 13845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003616 RID: 13846
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__18_0_Private_Void_Int32_0;

		// Token: 0x02000B91 RID: 2961
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Patchouli+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D926 RID: 55590 RVA: 0x0034D1F4 File Offset: 0x0034B3F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr);
				Spell_Patchouli.__c__DisplayClass17_0.NativeFieldInfoPtr_effectQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, "effectQueue");
				Spell_Patchouli.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, 100679321);
				Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, 100679322);
				Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, 100679323);
				Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, 100679324);
			}

			// Token: 0x0600D927 RID: 55591 RVA: 0x0034D298 File Offset: 0x0034B498
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D928 RID: 55592 RVA: 0x0034D2D4 File Offset: 0x0034B4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201495, XrefRangeEnd = 201502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D929 RID: 55593 RVA: 0x0034D308 File Offset: 0x0034B508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201502, XrefRangeEnd = 201507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D92A RID: 55594 RVA: 0x0034D348 File Offset: 0x0034B548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201507, XrefRangeEnd = 201521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_String_PDM_0(int currentTime, string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D92B RID: 55595 RVA: 0x000742EA File Offset: 0x000724EA
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700469F RID: 18079
			// (get) Token: 0x0600D92C RID: 55596 RVA: 0x0034D3A0 File Offset: 0x0034B5A0
			// (set) Token: 0x0600D92D RID: 55597 RVA: 0x000742F3 File Offset: 0x000724F3
			public unsafe Queue<ParticleSystem> effectQueue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.NativeFieldInfoPtr_effectQueue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.NativeFieldInfoPtr_effectQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A0 RID: 18080
			// (get) Token: 0x0600D92E RID: 55598 RVA: 0x0034D3D0 File Offset: 0x0034B5D0
			// (set) Token: 0x0600D92F RID: 55599 RVA: 0x00074312 File Offset: 0x00072512
			public unsafe Spell_Patchouli __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Patchouli>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B32 RID: 35634
			private static readonly IntPtr NativeFieldInfoPtr_effectQueue;

			// Token: 0x04008B33 RID: 35635
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B34 RID: 35636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B35 RID: 35637
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008B36 RID: 35638
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008B37 RID: 35639
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0;

			// Token: 0x02001038 RID: 4152
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Patchouli+<>c__DisplayClass17_0+<<OnNegativeBuffExecute>g__Del|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C36 RID: 72758 RVA: 0x00411478 File Offset: 0x0040F678
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Del|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679325);
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679326);
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679327);
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679328);
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679329);
					Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679330);
				}

				// Token: 0x06011C37 RID: 72759 RVA: 0x00411558 File Offset: 0x0040F758
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C38 RID: 72760 RVA: 0x004115A0 File Offset: 0x0040F7A0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C39 RID: 72761 RVA: 0x004115D4 File Offset: 0x0040F7D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201446, XrefRangeEnd = 201489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C82 RID: 23682
				// (get) Token: 0x06011C3A RID: 72762 RVA: 0x00411610 File Offset: 0x0040F810
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C3B RID: 72763 RVA: 0x00411650 File Offset: 0x0040F850
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201489, XrefRangeEnd = 201495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C83 RID: 23683
				// (get) Token: 0x06011C3C RID: 72764 RVA: 0x00411684 File Offset: 0x0040F884
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C3D RID: 72765 RVA: 0x0009A651 File Offset: 0x00098851
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C7F RID: 23679
				// (get) Token: 0x06011C3E RID: 72766 RVA: 0x004116C4 File Offset: 0x0040F8C4
				// (set) Token: 0x06011C3F RID: 72767 RVA: 0x0009A65A File Offset: 0x0009885A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C80 RID: 23680
				// (get) Token: 0x06011C40 RID: 72768 RVA: 0x004116EC File Offset: 0x0040F8EC
				// (set) Token: 0x06011C41 RID: 72769 RVA: 0x0009A675 File Offset: 0x00098875
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C81 RID: 23681
				// (get) Token: 0x06011C42 RID: 72770 RVA: 0x0041171C File Offset: 0x0040F91C
				// (set) Token: 0x06011C43 RID: 72771 RVA: 0x0009A694 File Offset: 0x00098894
				public unsafe Spell_Patchouli.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Patchouli.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B38C RID: 45964
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B38D RID: 45965
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B38E RID: 45966
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B38F RID: 45967
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B390 RID: 45968
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B391 RID: 45969
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B392 RID: 45970
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B393 RID: 45971
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B394 RID: 45972
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B92 RID: 2962
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Patchouli+<OnNegativeBuffExecute>d__17")]
		public sealed class _OnNegativeBuffExecute_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600D930 RID: 55600 RVA: 0x0034D400 File Offset: 0x0034B600
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__17()
			{
				Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "<OnNegativeBuffExecute>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr);
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>1__state");
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>2__current");
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>4__this");
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100679331);
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100679332);
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100679333);
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100679334);
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100679335);
				Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100679336);
			}

			// Token: 0x0600D931 RID: 55601 RVA: 0x0034D4E0 File Offset: 0x0034B6E0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Patchouli._OnNegativeBuffExecute_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D932 RID: 55602 RVA: 0x0034D528 File Offset: 0x0034B728
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D933 RID: 55603 RVA: 0x0034D55C File Offset: 0x0034B75C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201521, XrefRangeEnd = 201592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046A4 RID: 18084
			// (get) Token: 0x0600D934 RID: 55604 RVA: 0x0034D598 File Offset: 0x0034B798
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D935 RID: 55605 RVA: 0x0034D5D8 File Offset: 0x0034B7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201592, XrefRangeEnd = 201598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046A5 RID: 18085
			// (get) Token: 0x0600D936 RID: 55606 RVA: 0x0034D60C File Offset: 0x0034B80C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D937 RID: 55607 RVA: 0x00074331 File Offset: 0x00072531
			public _OnNegativeBuffExecute_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046A1 RID: 18081
			// (get) Token: 0x0600D938 RID: 55608 RVA: 0x0034D64C File Offset: 0x0034B84C
			// (set) Token: 0x0600D939 RID: 55609 RVA: 0x0007433A File Offset: 0x0007253A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046A2 RID: 18082
			// (get) Token: 0x0600D93A RID: 55610 RVA: 0x0034D674 File Offset: 0x0034B874
			// (set) Token: 0x0600D93B RID: 55611 RVA: 0x00074355 File Offset: 0x00072555
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A3 RID: 18083
			// (get) Token: 0x0600D93C RID: 55612 RVA: 0x0034D6A4 File Offset: 0x0034B8A4
			// (set) Token: 0x0600D93D RID: 55613 RVA: 0x00074374 File Offset: 0x00072574
			public unsafe Spell_Patchouli __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Patchouli>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B38 RID: 35640
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B39 RID: 35641
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B3A RID: 35642
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B3B RID: 35643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B3C RID: 35644
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B3D RID: 35645
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B3E RID: 35646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B3F RID: 35647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B40 RID: 35648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B93 RID: 2963
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Patchouli+<OnPositiveBuffExecute>d__18")]
		public sealed class _OnPositiveBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D93E RID: 55614 RVA: 0x0034D6D4 File Offset: 0x0034B8D4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Patchouli>.NativeClassPtr, "<OnPositiveBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr);
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100679337);
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100679338);
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100679339);
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100679340);
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100679341);
				Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100679342);
			}

			// Token: 0x0600D93F RID: 55615 RVA: 0x0034D7B4 File Offset: 0x0034B9B4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Patchouli._OnPositiveBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D940 RID: 55616 RVA: 0x0034D7FC File Offset: 0x0034B9FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D941 RID: 55617 RVA: 0x0034D830 File Offset: 0x0034BA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201598, XrefRangeEnd = 201607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046A9 RID: 18089
			// (get) Token: 0x0600D942 RID: 55618 RVA: 0x0034D86C File Offset: 0x0034BA6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D943 RID: 55619 RVA: 0x0034D8AC File Offset: 0x0034BAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201607, XrefRangeEnd = 201613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046AA RID: 18090
			// (get) Token: 0x0600D944 RID: 55620 RVA: 0x0034D8E0 File Offset: 0x0034BAE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D945 RID: 55621 RVA: 0x00074393 File Offset: 0x00072593
			public _OnPositiveBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046A6 RID: 18086
			// (get) Token: 0x0600D946 RID: 55622 RVA: 0x0034D920 File Offset: 0x0034BB20
			// (set) Token: 0x0600D947 RID: 55623 RVA: 0x0007439C File Offset: 0x0007259C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046A7 RID: 18087
			// (get) Token: 0x0600D948 RID: 55624 RVA: 0x0034D948 File Offset: 0x0034BB48
			// (set) Token: 0x0600D949 RID: 55625 RVA: 0x000743B7 File Offset: 0x000725B7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A8 RID: 18088
			// (get) Token: 0x0600D94A RID: 55626 RVA: 0x0034D978 File Offset: 0x0034BB78
			// (set) Token: 0x0600D94B RID: 55627 RVA: 0x000743D6 File Offset: 0x000725D6
			public unsafe Spell_Patchouli __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Patchouli>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Patchouli._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B41 RID: 35649
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B42 RID: 35650
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B43 RID: 35651
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B44 RID: 35652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B45 RID: 35653
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B46 RID: 35654
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B47 RID: 35655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B48 RID: 35656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B49 RID: 35657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
