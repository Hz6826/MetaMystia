using System;
using Common.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000278 RID: 632
	public class Spell_Orin : SpellBase
	{
		// Token: 0x06004F51 RID: 20305 RVA: 0x001AE1A0 File Offset: 0x001AC3A0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Orin()
		{
			Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Orin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr);
			Spell_Orin.NativeFieldInfoPtr_postiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "postiveDuration");
			Spell_Orin.NativeFieldInfoPtr_targetTagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "targetTagId");
			Spell_Orin.NativeFieldInfoPtr_baseEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "baseEval");
			Spell_Orin.NativeFieldInfoPtr_ghostGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "ghostGuestId");
			Spell_Orin.NativeFieldInfoPtr_spiritCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "spiritCharacter");
			Spell_Orin.NativeFieldInfoPtr_spiritCharacterEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "spiritCharacterEyes");
			Spell_Orin.NativeFieldInfoPtr_spiritEyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "spiritEyeColor");
			Spell_Orin.NativeFieldInfoPtr_fogEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "fogEffect");
			Spell_Orin.NativeFieldInfoPtr_catEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "catEffect");
			Spell_Orin.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "rewardSFX");
			Spell_Orin.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "punishmentSFX");
			Spell_Orin.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, 100679263);
			Spell_Orin.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, 100679264);
			Spell_Orin.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, 100679265);
			Spell_Orin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, 100679266);
			Spell_Orin.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, 100679267);
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x001AE310 File Offset: 0x001AC510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201269, XrefRangeEnd = 201271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Orin.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x001AE354 File Offset: 0x001AC554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201271, XrefRangeEnd = 201277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Orin.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x001AE3B0 File Offset: 0x001AC5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201277, XrefRangeEnd = 201283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Orin.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x001AE40C File Offset: 0x001AC60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201283, XrefRangeEnd = 201284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Orin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x001AE448 File Offset: 0x001AC648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201284, XrefRangeEnd = 201289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__13_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00029BB4 File Offset: 0x00027DB4
		public Spell_Orin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06004F58 RID: 20312 RVA: 0x001AE488 File Offset: 0x001AC688
		// (set) Token: 0x06004F59 RID: 20313 RVA: 0x00029BBD File Offset: 0x00027DBD
		public unsafe int postiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_postiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_postiveDuration)) = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06004F5A RID: 20314 RVA: 0x001AE4B0 File Offset: 0x001AC6B0
		// (set) Token: 0x06004F5B RID: 20315 RVA: 0x00029BD8 File Offset: 0x00027DD8
		public unsafe int targetTagId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_targetTagId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_targetTagId)) = value;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06004F5C RID: 20316 RVA: 0x001AE4D8 File Offset: 0x001AC6D8
		// (set) Token: 0x06004F5D RID: 20317 RVA: 0x00029BF3 File Offset: 0x00027DF3
		public unsafe int baseEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_baseEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_baseEval)) = value;
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06004F5E RID: 20318 RVA: 0x001AE500 File Offset: 0x001AC700
		// (set) Token: 0x06004F5F RID: 20319 RVA: 0x00029C0E File Offset: 0x00027E0E
		public unsafe int ghostGuestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_ghostGuestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_ghostGuestId)) = value;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x001AE528 File Offset: 0x001AC728
		// (set) Token: 0x06004F61 RID: 20321 RVA: 0x00029C29 File Offset: 0x00027E29
		public unsafe Material spiritCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_spiritCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_spiritCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06004F62 RID: 20322 RVA: 0x001AE558 File Offset: 0x001AC758
		// (set) Token: 0x06004F63 RID: 20323 RVA: 0x00029C48 File Offset: 0x00027E48
		public unsafe Material spiritCharacterEyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_spiritCharacterEyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_spiritCharacterEyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x001AE588 File Offset: 0x001AC788
		// (set) Token: 0x06004F65 RID: 20325 RVA: 0x00029C67 File Offset: 0x00027E67
		public unsafe Color spiritEyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_spiritEyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_spiritEyeColor)) = value;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06004F66 RID: 20326 RVA: 0x001AE5B0 File Offset: 0x001AC7B0
		// (set) Token: 0x06004F67 RID: 20327 RVA: 0x00029C82 File Offset: 0x00027E82
		public unsafe GameObject fogEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_fogEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_fogEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06004F68 RID: 20328 RVA: 0x001AE5E0 File Offset: 0x001AC7E0
		// (set) Token: 0x06004F69 RID: 20329 RVA: 0x00029CA1 File Offset: 0x00027EA1
		public unsafe GameObject catEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_catEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_catEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06004F6A RID: 20330 RVA: 0x001AE610 File Offset: 0x001AC810
		// (set) Token: 0x06004F6B RID: 20331 RVA: 0x00029CC0 File Offset: 0x00027EC0
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06004F6C RID: 20332 RVA: 0x001AE640 File Offset: 0x001AC840
		// (set) Token: 0x06004F6D RID: 20333 RVA: 0x00029CDF File Offset: 0x00027EDF
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeFieldInfoPtr_postiveDuration;

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeFieldInfoPtr_targetTagId;

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeFieldInfoPtr_baseEval;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeFieldInfoPtr_ghostGuestId;

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeFieldInfoPtr_spiritCharacter;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeFieldInfoPtr_spiritCharacterEyes;

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeFieldInfoPtr_spiritEyeColor;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeFieldInfoPtr_fogEffect;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeFieldInfoPtr_catEffect;

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040035E7 RID: 13799
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040035E8 RID: 13800
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040035E9 RID: 13801
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035EA RID: 13802
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035EB RID: 13803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035EC RID: 13804
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_0_Private_Void_Int32_0;

		// Token: 0x02000B87 RID: 2951
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Orin+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8B3 RID: 55475 RVA: 0x0034BCCC File Offset: 0x00349ECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr);
				Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr_currentDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr, "currentDeskCode");
				Spell_Orin.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr, 100679268);
				Spell_Orin.__c__DisplayClass12_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr, 100679269);
			}

			// Token: 0x0600D8B4 RID: 55476 RVA: 0x0034BD5C File Offset: 0x00349F5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8B5 RID: 55477 RVA: 0x0034BD98 File Offset: 0x00349F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201195, XrefRangeEnd = 201200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin.__c__DisplayClass12_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8B6 RID: 55478 RVA: 0x00073F47 File Offset: 0x00072147
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467A RID: 18042
			// (get) Token: 0x0600D8B7 RID: 55479 RVA: 0x0034BDDC File Offset: 0x00349FDC
			// (set) Token: 0x0600D8B8 RID: 55480 RVA: 0x00073F50 File Offset: 0x00072150
			public unsafe Spell_Orin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Orin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700467B RID: 18043
			// (get) Token: 0x0600D8B9 RID: 55481 RVA: 0x0034BE0C File Offset: 0x0034A00C
			// (set) Token: 0x0600D8BA RID: 55482 RVA: 0x00073F6F File Offset: 0x0007216F
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700467C RID: 18044
			// (get) Token: 0x0600D8BB RID: 55483 RVA: 0x0034BE3C File Offset: 0x0034A03C
			// (set) Token: 0x0600D8BC RID: 55484 RVA: 0x00073F8E File Offset: 0x0007218E
			public unsafe int currentDeskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr_currentDeskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_0.NativeFieldInfoPtr_currentDeskCode)) = value;
				}
			}

			// Token: 0x04008AF0 RID: 35568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AF1 RID: 35569
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008AF2 RID: 35570
			private static readonly IntPtr NativeFieldInfoPtr_currentDeskCode;

			// Token: 0x04008AF3 RID: 35571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AF4 RID: 35572
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_AStarInputGeneratorComponent_0;
		}

		// Token: 0x02000B88 RID: 2952
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Orin+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D8BD RID: 55485 RVA: 0x0034BE64 File Offset: 0x0034A064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr);
				Spell_Orin.__c__DisplayClass12_1.NativeFieldInfoPtr_postprocessCharacterCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr, "postprocessCharacterCallback");
				Spell_Orin.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Orin.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr, 100679270);
				Spell_Orin.__c__DisplayClass12_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr, 100679271);
			}

			// Token: 0x0600D8BE RID: 55486 RVA: 0x0034BEE0 File Offset: 0x0034A0E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Orin.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8BF RID: 55487 RVA: 0x0034BF1C File Offset: 0x0034A11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201200, XrefRangeEnd = 201211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GuestGroupController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin.__c__DisplayClass12_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C0 RID: 55488 RVA: 0x00073FA9 File Offset: 0x000721A9
			public __c__DisplayClass12_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467D RID: 18045
			// (get) Token: 0x0600D8C1 RID: 55489 RVA: 0x0034BF60 File Offset: 0x0034A160
			// (set) Token: 0x0600D8C2 RID: 55490 RVA: 0x00073FB2 File Offset: 0x000721B2
			public unsafe Action<AStarInputGeneratorComponent> postprocessCharacterCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_1.NativeFieldInfoPtr_postprocessCharacterCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_1.NativeFieldInfoPtr_postprocessCharacterCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700467E RID: 18046
			// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x0034BF90 File Offset: 0x0034A190
			// (set) Token: 0x0600D8C4 RID: 55492 RVA: 0x00073FD1 File Offset: 0x000721D1
			public unsafe Spell_Orin.__c__DisplayClass12_0 field_Public___c__DisplayClass12_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Orin.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AF5 RID: 35573
			private static readonly IntPtr NativeFieldInfoPtr_postprocessCharacterCallback;

			// Token: 0x04008AF6 RID: 35574
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0;

			// Token: 0x04008AF7 RID: 35575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AF8 RID: 35576
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000B89 RID: 2953
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Orin+<OnNegativeBuffExecute>d__12")]
		public sealed class _OnNegativeBuffExecute_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600D8C5 RID: 55493 RVA: 0x0034BFC0 File Offset: 0x0034A1C0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__12()
			{
				Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "<OnNegativeBuffExecute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr);
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, "<>1__state");
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, "<>2__current");
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, "<>4__this");
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, "spellExecutionContext");
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100679272);
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100679273);
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100679274);
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100679275);
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100679276);
				Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100679277);
			}

			// Token: 0x0600D8C6 RID: 55494 RVA: 0x0034C0B4 File Offset: 0x0034A2B4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Orin._OnNegativeBuffExecute_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C7 RID: 55495 RVA: 0x0034C0FC File Offset: 0x0034A2FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C8 RID: 55496 RVA: 0x0034C130 File Offset: 0x0034A330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201211, XrefRangeEnd = 201247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004683 RID: 18051
			// (get) Token: 0x0600D8C9 RID: 55497 RVA: 0x0034C16C File Offset: 0x0034A36C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8CA RID: 55498 RVA: 0x0034C1AC File Offset: 0x0034A3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201247, XrefRangeEnd = 201253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004684 RID: 18052
			// (get) Token: 0x0600D8CB RID: 55499 RVA: 0x0034C1E0 File Offset: 0x0034A3E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8CC RID: 55500 RVA: 0x00073FF0 File Offset: 0x000721F0
			public _OnNegativeBuffExecute_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467F RID: 18047
			// (get) Token: 0x0600D8CD RID: 55501 RVA: 0x0034C220 File Offset: 0x0034A420
			// (set) Token: 0x0600D8CE RID: 55502 RVA: 0x00073FF9 File Offset: 0x000721F9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004680 RID: 18048
			// (get) Token: 0x0600D8CF RID: 55503 RVA: 0x0034C248 File Offset: 0x0034A448
			// (set) Token: 0x0600D8D0 RID: 55504 RVA: 0x00074014 File Offset: 0x00072214
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004681 RID: 18049
			// (get) Token: 0x0600D8D1 RID: 55505 RVA: 0x0034C278 File Offset: 0x0034A478
			// (set) Token: 0x0600D8D2 RID: 55506 RVA: 0x00074033 File Offset: 0x00072233
			public unsafe Spell_Orin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Orin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004682 RID: 18050
			// (get) Token: 0x0600D8D3 RID: 55507 RVA: 0x0034C2A8 File Offset: 0x0034A4A8
			// (set) Token: 0x0600D8D4 RID: 55508 RVA: 0x00074052 File Offset: 0x00072252
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AF9 RID: 35577
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AFA RID: 35578
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AFB RID: 35579
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AFC RID: 35580
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008AFD RID: 35581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AFE RID: 35582
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AFF RID: 35583
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B00 RID: 35584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B01 RID: 35585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B02 RID: 35586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B8A RID: 2954
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Orin+<OnPositiveBuffExecute>d__13")]
		public sealed class _OnPositiveBuffExecute_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600D8D5 RID: 55509 RVA: 0x0034C2D8 File Offset: 0x0034A4D8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__13()
			{
				Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Orin>.NativeClassPtr, "<OnPositiveBuffExecute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr);
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>1__state");
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>2__current");
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>4__this");
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, "spellExecutionContext");
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100679278);
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100679279);
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100679280);
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100679281);
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100679282);
				Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100679283);
			}

			// Token: 0x0600D8D6 RID: 55510 RVA: 0x0034C3CC File Offset: 0x0034A5CC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Orin._OnPositiveBuffExecute_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8D7 RID: 55511 RVA: 0x0034C414 File Offset: 0x0034A614
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8D8 RID: 55512 RVA: 0x0034C448 File Offset: 0x0034A648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201253, XrefRangeEnd = 201263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004689 RID: 18057
			// (get) Token: 0x0600D8D9 RID: 55513 RVA: 0x0034C484 File Offset: 0x0034A684
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8DA RID: 55514 RVA: 0x0034C4C4 File Offset: 0x0034A6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201263, XrefRangeEnd = 201269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700468A RID: 18058
			// (get) Token: 0x0600D8DB RID: 55515 RVA: 0x0034C4F8 File Offset: 0x0034A6F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Orin._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8DC RID: 55516 RVA: 0x00074071 File Offset: 0x00072271
			public _OnPositiveBuffExecute_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004685 RID: 18053
			// (get) Token: 0x0600D8DD RID: 55517 RVA: 0x0034C538 File Offset: 0x0034A738
			// (set) Token: 0x0600D8DE RID: 55518 RVA: 0x0007407A File Offset: 0x0007227A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004686 RID: 18054
			// (get) Token: 0x0600D8DF RID: 55519 RVA: 0x0034C560 File Offset: 0x0034A760
			// (set) Token: 0x0600D8E0 RID: 55520 RVA: 0x00074095 File Offset: 0x00072295
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004687 RID: 18055
			// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x0034C590 File Offset: 0x0034A790
			// (set) Token: 0x0600D8E2 RID: 55522 RVA: 0x000740B4 File Offset: 0x000722B4
			public unsafe Spell_Orin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Orin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004688 RID: 18056
			// (get) Token: 0x0600D8E3 RID: 55523 RVA: 0x0034C5C0 File Offset: 0x0034A7C0
			// (set) Token: 0x0600D8E4 RID: 55524 RVA: 0x000740D3 File Offset: 0x000722D3
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Orin._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B03 RID: 35587
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B04 RID: 35588
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B05 RID: 35589
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B06 RID: 35590
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008B07 RID: 35591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B08 RID: 35592
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B09 RID: 35593
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B0A RID: 35594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B0B RID: 35595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B0C RID: 35596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
