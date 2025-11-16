using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000280 RID: 640
	public class Spell_Rumia : SpellBase
	{
		// Token: 0x060050A6 RID: 20646 RVA: 0x001B16B4 File Offset: 0x001AF8B4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Rumia()
		{
			Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Rumia");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr);
			Spell_Rumia.NativeFieldInfoPtr_getMeatTypeIngredientAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "getMeatTypeIngredientAmount");
			Spell_Rumia.NativeFieldInfoPtr_curtainDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "curtainDuration");
			Spell_Rumia.NativeFieldInfoPtr_effectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "effectParent");
			Spell_Rumia.NativeFieldInfoPtr_effectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "effectDuration");
			Spell_Rumia.NativeFieldInfoPtr_effectSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "effectSFX");
			Spell_Rumia.NativeFieldInfoPtr_curtainParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "curtainParent");
			Spell_Rumia.NativeFieldInfoPtr_curtainFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "curtainFadeDuration");
			Spell_Rumia.NativeFieldInfoPtr_curtainSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "curtainSFX");
			Spell_Rumia.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, 100679535);
			Spell_Rumia.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, 100679536);
			Spell_Rumia.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, 100679537);
			Spell_Rumia.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, 100679538);
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x001B17D4 File Offset: 0x001AF9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203252, XrefRangeEnd = 203254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rumia.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x001B1818 File Offset: 0x001AFA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203254, XrefRangeEnd = 203259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rumia.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x001B1874 File Offset: 0x001AFA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203259, XrefRangeEnd = 203264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rumia.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x001B18D0 File Offset: 0x001AFAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Rumia() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x0002ABD9 File Offset: 0x00028DD9
		public Spell_Rumia(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x001B190C File Offset: 0x001AFB0C
		// (set) Token: 0x060050AD RID: 20653 RVA: 0x0002ABE2 File Offset: 0x00028DE2
		public unsafe int getMeatTypeIngredientAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_getMeatTypeIngredientAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_getMeatTypeIngredientAmount)) = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x001B1934 File Offset: 0x001AFB34
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x0002ABFD File Offset: 0x00028DFD
		public unsafe int curtainDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainDuration)) = value;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x001B195C File Offset: 0x001AFB5C
		// (set) Token: 0x060050B1 RID: 20657 RVA: 0x0002AC18 File Offset: 0x00028E18
		public unsafe GameObject effectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_effectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_effectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x001B198C File Offset: 0x001AFB8C
		// (set) Token: 0x060050B3 RID: 20659 RVA: 0x0002AC37 File Offset: 0x00028E37
		public unsafe float effectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_effectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_effectDuration)) = value;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x001B19B4 File Offset: 0x001AFBB4
		// (set) Token: 0x060050B5 RID: 20661 RVA: 0x0002AC52 File Offset: 0x00028E52
		public unsafe AudioClip effectSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_effectSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_effectSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x001B19E4 File Offset: 0x001AFBE4
		// (set) Token: 0x060050B7 RID: 20663 RVA: 0x0002AC71 File Offset: 0x00028E71
		public unsafe GameObject curtainParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x060050B8 RID: 20664 RVA: 0x001B1A14 File Offset: 0x001AFC14
		// (set) Token: 0x060050B9 RID: 20665 RVA: 0x0002AC90 File Offset: 0x00028E90
		public unsafe float curtainFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainFadeDuration)) = value;
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x060050BA RID: 20666 RVA: 0x001B1A3C File Offset: 0x001AFC3C
		// (set) Token: 0x060050BB RID: 20667 RVA: 0x0002ACAB File Offset: 0x00028EAB
		public unsafe AudioClip curtainSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.NativeFieldInfoPtr_curtainSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeFieldInfoPtr_getMeatTypeIngredientAmount;

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeFieldInfoPtr_curtainDuration;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeFieldInfoPtr_effectParent;

		// Token: 0x0400369A RID: 13978
		private static readonly IntPtr NativeFieldInfoPtr_effectDuration;

		// Token: 0x0400369B RID: 13979
		private static readonly IntPtr NativeFieldInfoPtr_effectSFX;

		// Token: 0x0400369C RID: 13980
		private static readonly IntPtr NativeFieldInfoPtr_curtainParent;

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeFieldInfoPtr_curtainFadeDuration;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeFieldInfoPtr_curtainSFX;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040036A0 RID: 13984
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036A1 RID: 13985
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036A2 RID: 13986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAF RID: 2991
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rumia+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAC6 RID: 56006 RVA: 0x003520C4 File Offset: 0x003502C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr);
				Spell_Rumia.__c__DisplayClass9_0.NativeFieldInfoPtr_curtain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr, "curtain");
				Spell_Rumia.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				Spell_Rumia.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr, 100679539);
				Spell_Rumia.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr, 100679540);
				Spell_Rumia.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr, 100679541);
			}

			// Token: 0x0600DAC7 RID: 56007 RVA: 0x00352154 File Offset: 0x00350354
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAC8 RID: 56008 RVA: 0x00352190 File Offset: 0x00350390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203010, XrefRangeEnd = 203128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAC9 RID: 56009 RVA: 0x003521C4 File Offset: 0x003503C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203128, XrefRangeEnd = 203133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DACA RID: 56010 RVA: 0x00074F57 File Offset: 0x00073157
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004720 RID: 18208
			// (get) Token: 0x0600DACB RID: 56011 RVA: 0x00352204 File Offset: 0x00350404
			// (set) Token: 0x0600DACC RID: 56012 RVA: 0x00074F60 File Offset: 0x00073160
			public unsafe GameObject curtain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.NativeFieldInfoPtr_curtain);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.NativeFieldInfoPtr_curtain), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004721 RID: 18209
			// (get) Token: 0x0600DACD RID: 56013 RVA: 0x00352234 File Offset: 0x00350434
			// (set) Token: 0x0600DACE RID: 56014 RVA: 0x00074F7F File Offset: 0x0007317F
			public unsafe Spell_Rumia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rumia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C2D RID: 35885
			private static readonly IntPtr NativeFieldInfoPtr_curtain;

			// Token: 0x04008C2E RID: 35886
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C2F RID: 35887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C30 RID: 35888
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008C31 RID: 35889
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200103D RID: 4157
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rumia+<>c__DisplayClass9_0+<<OnNegativeBuffExecute>g__DestroyDelayed|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C84 RID: 72836 RVA: 0x0041239C File Offset: 0x0041059C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__DestroyDelayed|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679542);
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679543);
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679544);
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679545);
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679546);
					Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679547);
				}

				// Token: 0x06011C85 RID: 72837 RVA: 0x0041247C File Offset: 0x0041067C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C86 RID: 72838 RVA: 0x004124C4 File Offset: 0x004106C4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C87 RID: 72839 RVA: 0x004124F8 File Offset: 0x004106F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202998, XrefRangeEnd = 203004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C9F RID: 23711
				// (get) Token: 0x06011C88 RID: 72840 RVA: 0x00412534 File Offset: 0x00410734
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C89 RID: 72841 RVA: 0x00412574 File Offset: 0x00410774
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203004, XrefRangeEnd = 203010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CA0 RID: 23712
				// (get) Token: 0x06011C8A RID: 72842 RVA: 0x004125A8 File Offset: 0x004107A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C8B RID: 72843 RVA: 0x0009A8AF File Offset: 0x00098AAF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C9C RID: 23708
				// (get) Token: 0x06011C8C RID: 72844 RVA: 0x004125E8 File Offset: 0x004107E8
				// (set) Token: 0x06011C8D RID: 72845 RVA: 0x0009A8B8 File Offset: 0x00098AB8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C9D RID: 23709
				// (get) Token: 0x06011C8E RID: 72846 RVA: 0x00412610 File Offset: 0x00410810
				// (set) Token: 0x06011C8F RID: 72847 RVA: 0x0009A8D3 File Offset: 0x00098AD3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C9E RID: 23710
				// (get) Token: 0x06011C90 RID: 72848 RVA: 0x00412640 File Offset: 0x00410840
				// (set) Token: 0x06011C91 RID: 72849 RVA: 0x0009A8F2 File Offset: 0x00098AF2
				public unsafe Spell_Rumia.__c__DisplayClass9_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rumia.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B3BD RID: 46013
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3BE RID: 46014
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3BF RID: 46015
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3C0 RID: 46016
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3C1 RID: 46017
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3C2 RID: 46018
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3C3 RID: 46019
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3C4 RID: 46020
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3C5 RID: 46021
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BB0 RID: 2992
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rumia+<OnNegativeBuffExecute>d__9")]
		public sealed class _OnNegativeBuffExecute_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600DACF RID: 56015 RVA: 0x00352264 File Offset: 0x00350464
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__9()
			{
				Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "<OnNegativeBuffExecute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr);
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>1__state");
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>2__current");
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>4__this");
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679548);
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679549);
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679550);
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679551);
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679552);
				Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679553);
			}

			// Token: 0x0600DAD0 RID: 56016 RVA: 0x00352344 File Offset: 0x00350544
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rumia._OnNegativeBuffExecute_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAD1 RID: 56017 RVA: 0x0035238C File Offset: 0x0035058C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAD2 RID: 56018 RVA: 0x003523C0 File Offset: 0x003505C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203133, XrefRangeEnd = 203160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004725 RID: 18213
			// (get) Token: 0x0600DAD3 RID: 56019 RVA: 0x003523FC File Offset: 0x003505FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAD4 RID: 56020 RVA: 0x0035243C File Offset: 0x0035063C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203160, XrefRangeEnd = 203166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004726 RID: 18214
			// (get) Token: 0x0600DAD5 RID: 56021 RVA: 0x00352470 File Offset: 0x00350670
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAD6 RID: 56022 RVA: 0x00074F9E File Offset: 0x0007319E
			public _OnNegativeBuffExecute_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004722 RID: 18210
			// (get) Token: 0x0600DAD7 RID: 56023 RVA: 0x003524B0 File Offset: 0x003506B0
			// (set) Token: 0x0600DAD8 RID: 56024 RVA: 0x00074FA7 File Offset: 0x000731A7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004723 RID: 18211
			// (get) Token: 0x0600DAD9 RID: 56025 RVA: 0x003524D8 File Offset: 0x003506D8
			// (set) Token: 0x0600DADA RID: 56026 RVA: 0x00074FC2 File Offset: 0x000731C2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004724 RID: 18212
			// (get) Token: 0x0600DADB RID: 56027 RVA: 0x00352508 File Offset: 0x00350708
			// (set) Token: 0x0600DADC RID: 56028 RVA: 0x00074FE1 File Offset: 0x000731E1
			public unsafe Spell_Rumia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rumia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C32 RID: 35890
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C33 RID: 35891
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C34 RID: 35892
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C35 RID: 35893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C36 RID: 35894
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C37 RID: 35895
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C38 RID: 35896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C39 RID: 35897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C3A RID: 35898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BB1 RID: 2993
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rumia+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DADD RID: 56029 RVA: 0x00352538 File Offset: 0x00350738
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr);
				Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr, "item");
				Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
				Spell_Rumia.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr, 100679554);
				Spell_Rumia.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr, 100679555);
				Spell_Rumia.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr, 100679556);
			}

			// Token: 0x0600DADE RID: 56030 RVA: 0x003525DC File Offset: 0x003507DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rumia.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DADF RID: 56031 RVA: 0x00352618 File Offset: 0x00350818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203166, XrefRangeEnd = 203188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAE0 RID: 56032 RVA: 0x0035265C File Offset: 0x0035085C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(Image xy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAE1 RID: 56033 RVA: 0x00075000 File Offset: 0x00073200
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004727 RID: 18215
			// (get) Token: 0x0600DAE2 RID: 56034 RVA: 0x003526A0 File Offset: 0x003508A0
			// (set) Token: 0x0600DAE3 RID: 56035 RVA: 0x00075009 File Offset: 0x00073209
			public unsafe ObjectLanguageBase item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004728 RID: 18216
			// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x003526D0 File Offset: 0x003508D0
			// (set) Token: 0x0600DAE5 RID: 56037 RVA: 0x00075028 File Offset: 0x00073228
			public unsafe Spell_Rumia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rumia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004729 RID: 18217
			// (get) Token: 0x0600DAE6 RID: 56038 RVA: 0x00352700 File Offset: 0x00350900
			// (set) Token: 0x0600DAE7 RID: 56039 RVA: 0x00075047 File Offset: 0x00073247
			public unsafe Action<Image> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C3B RID: 35899
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008C3C RID: 35900
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C3D RID: 35901
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04008C3E RID: 35902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C3F RID: 35903
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008C40 RID: 35904
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Image_0;
		}

		// Token: 0x02000BB2 RID: 2994
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rumia+<OnPositiveBuffExecute>d__10")]
		public sealed class _OnPositiveBuffExecute_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DAE8 RID: 56040 RVA: 0x00352730 File Offset: 0x00350930
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__10()
			{
				Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rumia>.NativeClassPtr, "<OnPositiveBuffExecute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>1__state");
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>2__current");
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>4__this");
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr__selected_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<selected>5__2");
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>7__wrap2");
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679557);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679558);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679559);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679560);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679561);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679562);
				Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679563);
			}

			// Token: 0x0600DAE9 RID: 56041 RVA: 0x0035284C File Offset: 0x00350A4C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rumia._OnPositiveBuffExecute_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAEA RID: 56042 RVA: 0x00352894 File Offset: 0x00350A94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 203193, RefRangeEnd = 203194, XrefRangeStart = 203188, XrefRangeEnd = 203193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAEB RID: 56043 RVA: 0x003528C8 File Offset: 0x00350AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203194, XrefRangeEnd = 203243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAEC RID: 56044 RVA: 0x00352904 File Offset: 0x00350B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203243, XrefRangeEnd = 203246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700472F RID: 18223
			// (get) Token: 0x0600DAED RID: 56045 RVA: 0x00352938 File Offset: 0x00350B38
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAEE RID: 56046 RVA: 0x00352978 File Offset: 0x00350B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203246, XrefRangeEnd = 203252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004730 RID: 18224
			// (get) Token: 0x0600DAEF RID: 56047 RVA: 0x003529AC File Offset: 0x00350BAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAF0 RID: 56048 RVA: 0x00075066 File Offset: 0x00073266
			public _OnPositiveBuffExecute_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700472A RID: 18218
			// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x003529EC File Offset: 0x00350BEC
			// (set) Token: 0x0600DAF2 RID: 56050 RVA: 0x0007506F File Offset: 0x0007326F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700472B RID: 18219
			// (get) Token: 0x0600DAF3 RID: 56051 RVA: 0x00352A14 File Offset: 0x00350C14
			// (set) Token: 0x0600DAF4 RID: 56052 RVA: 0x0007508A File Offset: 0x0007328A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700472C RID: 18220
			// (get) Token: 0x0600DAF5 RID: 56053 RVA: 0x00352A44 File Offset: 0x00350C44
			// (set) Token: 0x0600DAF6 RID: 56054 RVA: 0x000750A9 File Offset: 0x000732A9
			public unsafe Spell_Rumia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rumia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700472D RID: 18221
			// (get) Token: 0x0600DAF7 RID: 56055 RVA: 0x00352A74 File Offset: 0x00350C74
			// (set) Token: 0x0600DAF8 RID: 56056 RVA: 0x000750C8 File Offset: 0x000732C8
			public EventManager.SelectedValue _selected_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr__selected_5__2);
					return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr__selected_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700472E RID: 18222
			// (get) Token: 0x0600DAF9 RID: 56057 RVA: 0x00352AA4 File Offset: 0x00350CA4
			// (set) Token: 0x0600DAFA RID: 56058 RVA: 0x000750F6 File Offset: 0x000732F6
			public unsafe IEnumerator<ObjectLanguageBase> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ObjectLanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rumia._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C41 RID: 35905
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C42 RID: 35906
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C43 RID: 35907
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C44 RID: 35908
			private static readonly IntPtr NativeFieldInfoPtr__selected_5__2;

			// Token: 0x04008C45 RID: 35909
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04008C46 RID: 35910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C47 RID: 35911
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C48 RID: 35912
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C49 RID: 35913
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04008C4A RID: 35914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C4B RID: 35915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C4C RID: 35916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
