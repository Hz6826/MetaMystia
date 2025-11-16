using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200028F RID: 655
	public class Spell_Wriggle : SpellBase
	{
		// Token: 0x060052F0 RID: 21232 RVA: 0x001B7804 File Offset: 0x001B5A04
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Wriggle()
		{
			Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Wriggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr);
			Spell_Wriggle.NativeFieldInfoPtr_spawnGuestModifyFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "spawnGuestModifyFactor");
			Spell_Wriggle.NativeFieldInfoPtr_spawnGuestModifyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "spawnGuestModifyDuration");
			Spell_Wriggle.NativeFieldInfoPtr_extraSpawnGuestModifyDurationInYuukaSpellBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "extraSpawnGuestModifyDurationInYuukaSpellBuff");
			Spell_Wriggle.NativeFieldInfoPtr_firefliesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "firefliesParent");
			Spell_Wriggle.NativeFieldInfoPtr_fireFliesWarmDownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fireFliesWarmDownDuration");
			Spell_Wriggle.NativeFieldInfoPtr_firefliesSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "firefliesSFX");
			Spell_Wriggle.NativeFieldInfoPtr_fliesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fliesParent");
			Spell_Wriggle.NativeFieldInfoPtr_fliesSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fliesSFX");
			Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "deskDarkEffectParent");
			Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "deskDarkEffectDuration");
			Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectWarmDownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "deskDarkEffectWarmDownDuration");
			Spell_Wriggle.NativeFieldInfoPtr_fliesDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fliesDuration");
			Spell_Wriggle.NativeFieldInfoPtr_onGuestStartToRunOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "onGuestStartToRunOffset");
			Spell_Wriggle.NativeFieldInfoPtr_onDeskEffectStartToRunOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "onDeskEffectStartToRunOffset");
			Spell_Wriggle.NativeFieldInfoPtr_fliesShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fliesShakeAmplitude");
			Spell_Wriggle.NativeFieldInfoPtr_fliesShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fliesShakeDuration");
			Spell_Wriggle.NativeFieldInfoPtr_fliesShakeEndDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "fliesShakeEndDuration");
			Spell_Wriggle.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, 100680155);
			Spell_Wriggle.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, 100680156);
			Spell_Wriggle.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, 100680157);
			Spell_Wriggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, 100680158);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x001B79D8 File Offset: 0x001B5BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207966, XrefRangeEnd = 207968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Wriggle.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x001B7A1C File Offset: 0x001B5C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207968, XrefRangeEnd = 207974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Wriggle.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x001B7A78 File Offset: 0x001B5C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207974, XrefRangeEnd = 207979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Wriggle.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x001B7AD4 File Offset: 0x001B5CD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Wriggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0002C725 File Offset: 0x0002A925
		public Spell_Wriggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x001B7B10 File Offset: 0x001B5D10
		// (set) Token: 0x060052F7 RID: 21239 RVA: 0x0002C72E File Offset: 0x0002A92E
		public unsafe float spawnGuestModifyFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_spawnGuestModifyFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_spawnGuestModifyFactor)) = value;
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x001B7B38 File Offset: 0x001B5D38
		// (set) Token: 0x060052F9 RID: 21241 RVA: 0x0002C749 File Offset: 0x0002A949
		public unsafe int spawnGuestModifyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_spawnGuestModifyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_spawnGuestModifyDuration)) = value;
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x060052FA RID: 21242 RVA: 0x001B7B60 File Offset: 0x001B5D60
		// (set) Token: 0x060052FB RID: 21243 RVA: 0x0002C764 File Offset: 0x0002A964
		public unsafe int extraSpawnGuestModifyDurationInYuukaSpellBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_extraSpawnGuestModifyDurationInYuukaSpellBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_extraSpawnGuestModifyDurationInYuukaSpellBuff)) = value;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x060052FC RID: 21244 RVA: 0x001B7B88 File Offset: 0x001B5D88
		// (set) Token: 0x060052FD RID: 21245 RVA: 0x0002C77F File Offset: 0x0002A97F
		public unsafe GameObject firefliesParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_firefliesParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_firefliesParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x001B7BB8 File Offset: 0x001B5DB8
		// (set) Token: 0x060052FF RID: 21247 RVA: 0x0002C79E File Offset: 0x0002A99E
		public unsafe float fireFliesWarmDownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fireFliesWarmDownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fireFliesWarmDownDuration)) = value;
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x001B7BE0 File Offset: 0x001B5DE0
		// (set) Token: 0x06005301 RID: 21249 RVA: 0x0002C7B9 File Offset: 0x0002A9B9
		public unsafe AudioClip firefliesSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_firefliesSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_firefliesSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005302 RID: 21250 RVA: 0x001B7C10 File Offset: 0x001B5E10
		// (set) Token: 0x06005303 RID: 21251 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		public unsafe GameObject fliesParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005304 RID: 21252 RVA: 0x001B7C40 File Offset: 0x001B5E40
		// (set) Token: 0x06005305 RID: 21253 RVA: 0x0002C7F7 File Offset: 0x0002A9F7
		public unsafe AudioClip fliesSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005306 RID: 21254 RVA: 0x001B7C70 File Offset: 0x001B5E70
		// (set) Token: 0x06005307 RID: 21255 RVA: 0x0002C816 File Offset: 0x0002AA16
		public unsafe GameObject deskDarkEffectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06005308 RID: 21256 RVA: 0x001B7CA0 File Offset: 0x001B5EA0
		// (set) Token: 0x06005309 RID: 21257 RVA: 0x0002C835 File Offset: 0x0002AA35
		public unsafe float deskDarkEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectDuration)) = value;
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x0600530A RID: 21258 RVA: 0x001B7CC8 File Offset: 0x001B5EC8
		// (set) Token: 0x0600530B RID: 21259 RVA: 0x0002C850 File Offset: 0x0002AA50
		public unsafe float deskDarkEffectWarmDownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectWarmDownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_deskDarkEffectWarmDownDuration)) = value;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x0600530C RID: 21260 RVA: 0x001B7CF0 File Offset: 0x001B5EF0
		// (set) Token: 0x0600530D RID: 21261 RVA: 0x0002C86B File Offset: 0x0002AA6B
		public unsafe float fliesDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesDuration)) = value;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x0600530E RID: 21262 RVA: 0x001B7D18 File Offset: 0x001B5F18
		// (set) Token: 0x0600530F RID: 21263 RVA: 0x0002C886 File Offset: 0x0002AA86
		public unsafe float onGuestStartToRunOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_onGuestStartToRunOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_onGuestStartToRunOffset)) = value;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06005310 RID: 21264 RVA: 0x001B7D40 File Offset: 0x001B5F40
		// (set) Token: 0x06005311 RID: 21265 RVA: 0x0002C8A1 File Offset: 0x0002AAA1
		public unsafe float onDeskEffectStartToRunOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_onDeskEffectStartToRunOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_onDeskEffectStartToRunOffset)) = value;
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x001B7D68 File Offset: 0x001B5F68
		// (set) Token: 0x06005313 RID: 21267 RVA: 0x0002C8BC File Offset: 0x0002AABC
		public unsafe float fliesShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06005314 RID: 21268 RVA: 0x001B7D90 File Offset: 0x001B5F90
		// (set) Token: 0x06005315 RID: 21269 RVA: 0x0002C8D7 File Offset: 0x0002AAD7
		public unsafe float fliesShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesShakeDuration)) = value;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x001B7DB8 File Offset: 0x001B5FB8
		// (set) Token: 0x06005317 RID: 21271 RVA: 0x0002C8F2 File Offset: 0x0002AAF2
		public unsafe float fliesShakeEndDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesShakeEndDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.NativeFieldInfoPtr_fliesShakeEndDuration)) = value;
			}
		}

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeFieldInfoPtr_spawnGuestModifyFactor;

		// Token: 0x040037E1 RID: 14305
		private static readonly IntPtr NativeFieldInfoPtr_spawnGuestModifyDuration;

		// Token: 0x040037E2 RID: 14306
		private static readonly IntPtr NativeFieldInfoPtr_extraSpawnGuestModifyDurationInYuukaSpellBuff;

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeFieldInfoPtr_firefliesParent;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeFieldInfoPtr_fireFliesWarmDownDuration;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeFieldInfoPtr_firefliesSFX;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeFieldInfoPtr_fliesParent;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeFieldInfoPtr_fliesSFX;

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeFieldInfoPtr_deskDarkEffectParent;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeFieldInfoPtr_deskDarkEffectDuration;

		// Token: 0x040037EA RID: 14314
		private static readonly IntPtr NativeFieldInfoPtr_deskDarkEffectWarmDownDuration;

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeFieldInfoPtr_fliesDuration;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeFieldInfoPtr_onGuestStartToRunOffset;

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeFieldInfoPtr_onDeskEffectStartToRunOffset;

		// Token: 0x040037EE RID: 14318
		private static readonly IntPtr NativeFieldInfoPtr_fliesShakeAmplitude;

		// Token: 0x040037EF RID: 14319
		private static readonly IntPtr NativeFieldInfoPtr_fliesShakeDuration;

		// Token: 0x040037F0 RID: 14320
		private static readonly IntPtr NativeFieldInfoPtr_fliesShakeEndDuration;

		// Token: 0x040037F1 RID: 14321
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040037F2 RID: 14322
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037F3 RID: 14323
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037F4 RID: 14324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C05 RID: 3077
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFAC RID: 57260 RVA: 0x00360CE4 File Offset: 0x0035EEE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr);
				Spell_Wriggle.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				Spell_Wriggle.__c__DisplayClass18_0.NativeFieldInfoPtr_selectedTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, "selectedTables");
				Spell_Wriggle.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, 100680159);
				Spell_Wriggle.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, 100680160);
				Spell_Wriggle.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, 100680161);
			}

			// Token: 0x0600DFAD RID: 57261 RVA: 0x00360D74 File Offset: 0x0035EF74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFAE RID: 57262 RVA: 0x00360DB0 File Offset: 0x0035EFB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207844, XrefRangeEnd = 207849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFAF RID: 57263 RVA: 0x00360DF0 File Offset: 0x0035EFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207849, XrefRangeEnd = 207854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFB0 RID: 57264 RVA: 0x000776C9 File Offset: 0x000758C9
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048A9 RID: 18601
			// (get) Token: 0x0600DFB1 RID: 57265 RVA: 0x00360E30 File Offset: 0x0035F030
			// (set) Token: 0x0600DFB2 RID: 57266 RVA: 0x000776D2 File Offset: 0x000758D2
			public unsafe Spell_Wriggle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048AA RID: 18602
			// (get) Token: 0x0600DFB3 RID: 57267 RVA: 0x00360E60 File Offset: 0x0035F060
			// (set) Token: 0x0600DFB4 RID: 57268 RVA: 0x000776F1 File Offset: 0x000758F1
			public unsafe IEnumerable<int> selectedTables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.NativeFieldInfoPtr_selectedTables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.NativeFieldInfoPtr_selectedTables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F24 RID: 36644
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F25 RID: 36645
			private static readonly IntPtr NativeFieldInfoPtr_selectedTables;

			// Token: 0x04008F26 RID: 36646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F27 RID: 36647
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008F28 RID: 36648
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x0200104C RID: 4172
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<>c__DisplayClass18_0+<<OnNegativeBuffExecute>g__OnDisperse|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D6A RID: 73066 RVA: 0x00415090 File Offset: 0x00413290
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__OnDisperse|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680162);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680163);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680164);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680165);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680166);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680167);
				}

				// Token: 0x06011D6B RID: 73067 RVA: 0x00415170 File Offset: 0x00413370
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D6C RID: 73068 RVA: 0x004151B8 File Offset: 0x004133B8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D6D RID: 73069 RVA: 0x004151EC File Offset: 0x004133EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207809, XrefRangeEnd = 207815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CF4 RID: 23796
				// (get) Token: 0x06011D6E RID: 73070 RVA: 0x00415228 File Offset: 0x00413428
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D6F RID: 73071 RVA: 0x00415268 File Offset: 0x00413468
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207815, XrefRangeEnd = 207821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CF5 RID: 23797
				// (get) Token: 0x06011D70 RID: 73072 RVA: 0x0041529C File Offset: 0x0041349C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D71 RID: 73073 RVA: 0x0009AF93 File Offset: 0x00099193
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CF1 RID: 23793
				// (get) Token: 0x06011D72 RID: 73074 RVA: 0x004152DC File Offset: 0x004134DC
				// (set) Token: 0x06011D73 RID: 73075 RVA: 0x0009AF9C File Offset: 0x0009919C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CF2 RID: 23794
				// (get) Token: 0x06011D74 RID: 73076 RVA: 0x00415304 File Offset: 0x00413504
				// (set) Token: 0x06011D75 RID: 73077 RVA: 0x0009AFB7 File Offset: 0x000991B7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CF3 RID: 23795
				// (get) Token: 0x06011D76 RID: 73078 RVA: 0x00415334 File Offset: 0x00413534
				// (set) Token: 0x06011D77 RID: 73079 RVA: 0x0009AFD6 File Offset: 0x000991D6
				public unsafe Spell_Wriggle.__c__DisplayClass18_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle.__c__DisplayClass18_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B44E RID: 46158
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B44F RID: 46159
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B450 RID: 46160
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B451 RID: 46161
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B452 RID: 46162
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B453 RID: 46163
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B454 RID: 46164
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B455 RID: 46165
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B456 RID: 46166
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200104D RID: 4173
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<>c__DisplayClass18_0+<<OnNegativeBuffExecute>g__OnDeskEffect|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D78 RID: 73080 RVA: 0x00415364 File Offset: 0x00413564
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__OnDeskEffect|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr__queue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, "<queue>5__2");
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, 100680168);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, 100680169);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, 100680170);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, 100680171);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, 100680172);
					Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr, 100680173);
				}

				// Token: 0x06011D79 RID: 73081 RVA: 0x00415458 File Offset: 0x00413658
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D7A RID: 73082 RVA: 0x004154A0 File Offset: 0x004136A0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D7B RID: 73083 RVA: 0x004154D4 File Offset: 0x004136D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207821, XrefRangeEnd = 207838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CFA RID: 23802
				// (get) Token: 0x06011D7C RID: 73084 RVA: 0x00415510 File Offset: 0x00413710
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D7D RID: 73085 RVA: 0x00415550 File Offset: 0x00413750
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207838, XrefRangeEnd = 207844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CFB RID: 23803
				// (get) Token: 0x06011D7E RID: 73086 RVA: 0x00415584 File Offset: 0x00413784
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D7F RID: 73087 RVA: 0x0009AFF5 File Offset: 0x000991F5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CF6 RID: 23798
				// (get) Token: 0x06011D80 RID: 73088 RVA: 0x004155C4 File Offset: 0x004137C4
				// (set) Token: 0x06011D81 RID: 73089 RVA: 0x0009AFFE File Offset: 0x000991FE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CF7 RID: 23799
				// (get) Token: 0x06011D82 RID: 73090 RVA: 0x004155EC File Offset: 0x004137EC
				// (set) Token: 0x06011D83 RID: 73091 RVA: 0x0009B019 File Offset: 0x00099219
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CF8 RID: 23800
				// (get) Token: 0x06011D84 RID: 73092 RVA: 0x0041561C File Offset: 0x0041381C
				// (set) Token: 0x06011D85 RID: 73093 RVA: 0x0009B038 File Offset: 0x00099238
				public unsafe Spell_Wriggle.__c__DisplayClass18_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle.__c__DisplayClass18_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CF9 RID: 23801
				// (get) Token: 0x06011D86 RID: 73094 RVA: 0x0041564C File Offset: 0x0041384C
				// (set) Token: 0x06011D87 RID: 73095 RVA: 0x0009B057 File Offset: 0x00099257
				public unsafe Queue<ParticleSystem> _queue_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr__queue_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ParticleSystem>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQu1PaObObUnique.NativeFieldInfoPtr__queue_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B457 RID: 46167
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B458 RID: 46168
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B459 RID: 46169
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B45A RID: 46170
				private static readonly IntPtr NativeFieldInfoPtr__queue_5__2;

				// Token: 0x0400B45B RID: 46171
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B45C RID: 46172
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B45D RID: 46173
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B45E RID: 46174
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B45F RID: 46175
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B460 RID: 46176
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C06 RID: 3078
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DFB5 RID: 57269 RVA: 0x00360E90 File Offset: 0x0035F090
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr);
				Spell_Wriggle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr, "<>9");
				Spell_Wriggle.__c.NativeFieldInfoPtr___9__18_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr, "<>9__18_2");
				Spell_Wriggle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr, 100680175);
				Spell_Wriggle.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_2_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr, 100680176);
			}

			// Token: 0x0600DFB6 RID: 57270 RVA: 0x00360F0C File Offset: 0x0035F10C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFB7 RID: 57271 RVA: 0x00360F48 File Offset: 0x0035F148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__18_2(ParticleSystem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_2_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFB8 RID: 57272 RVA: 0x00077710 File Offset: 0x00075910
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048AB RID: 18603
			// (get) Token: 0x0600DFB9 RID: 57273 RVA: 0x00360F8C File Offset: 0x0035F18C
			// (set) Token: 0x0600DFBA RID: 57274 RVA: 0x00077719 File Offset: 0x00075919
			public unsafe static Spell_Wriggle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Wriggle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Wriggle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048AC RID: 18604
			// (get) Token: 0x0600DFBB RID: 57275 RVA: 0x00360FB4 File Offset: 0x0035F1B4
			// (set) Token: 0x0600DFBC RID: 57276 RVA: 0x0007772B File Offset: 0x0007592B
			public unsafe static Action<ParticleSystem> __9__18_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Wriggle.__c.NativeFieldInfoPtr___9__18_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Wriggle.__c.NativeFieldInfoPtr___9__18_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F29 RID: 36649
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F2A RID: 36650
			private static readonly IntPtr NativeFieldInfoPtr___9__18_2;

			// Token: 0x04008F2B RID: 36651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F2C RID: 36652
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_2_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000C07 RID: 3079
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<OnNegativeBuffExecute>d__18")]
		public sealed class _OnNegativeBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600DFBD RID: 57277 RVA: 0x00360FDC File Offset: 0x0035F1DC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "<OnNegativeBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr);
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, "spellExecutionContext");
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680177);
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680178);
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680179);
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680180);
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680181);
				Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100680182);
			}

			// Token: 0x0600DFBE RID: 57278 RVA: 0x003610D0 File Offset: 0x0035F2D0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle._OnNegativeBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFBF RID: 57279 RVA: 0x00361118 File Offset: 0x0035F318
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFC0 RID: 57280 RVA: 0x0036114C File Offset: 0x0035F34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207854, XrefRangeEnd = 207884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048B1 RID: 18609
			// (get) Token: 0x0600DFC1 RID: 57281 RVA: 0x00361188 File Offset: 0x0035F388
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFC2 RID: 57282 RVA: 0x003611C8 File Offset: 0x0035F3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207884, XrefRangeEnd = 207890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048B2 RID: 18610
			// (get) Token: 0x0600DFC3 RID: 57283 RVA: 0x003611FC File Offset: 0x0035F3FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFC4 RID: 57284 RVA: 0x0007773D File Offset: 0x0007593D
			public _OnNegativeBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048AD RID: 18605
			// (get) Token: 0x0600DFC5 RID: 57285 RVA: 0x0036123C File Offset: 0x0035F43C
			// (set) Token: 0x0600DFC6 RID: 57286 RVA: 0x00077746 File Offset: 0x00075946
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048AE RID: 18606
			// (get) Token: 0x0600DFC7 RID: 57287 RVA: 0x00361264 File Offset: 0x0035F464
			// (set) Token: 0x0600DFC8 RID: 57288 RVA: 0x00077761 File Offset: 0x00075961
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048AF RID: 18607
			// (get) Token: 0x0600DFC9 RID: 57289 RVA: 0x00361294 File Offset: 0x0035F494
			// (set) Token: 0x0600DFCA RID: 57290 RVA: 0x00077780 File Offset: 0x00075980
			public unsafe Spell_Wriggle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048B0 RID: 18608
			// (get) Token: 0x0600DFCB RID: 57291 RVA: 0x003612C4 File Offset: 0x0035F4C4
			// (set) Token: 0x0600DFCC RID: 57292 RVA: 0x0007779F File Offset: 0x0007599F
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F2D RID: 36653
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F2E RID: 36654
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F2F RID: 36655
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F30 RID: 36656
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008F31 RID: 36657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F32 RID: 36658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F33 RID: 36659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F34 RID: 36660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F35 RID: 36661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F36 RID: 36662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C08 RID: 3080
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFCD RID: 57293 RVA: 0x003612F4 File Offset: 0x0035F4F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr);
				Spell_Wriggle.__c__DisplayClass19_0.NativeFieldInfoPtr_particleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, "particleSystem");
				Spell_Wriggle.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, 100680183);
				Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, 100680184);
				Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, 100680185);
				Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, 100680186);
				Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, 100680187);
			}

			// Token: 0x0600DFCE RID: 57294 RVA: 0x003613AC File Offset: 0x0035F5AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFCF RID: 57295 RVA: 0x003613E8 File Offset: 0x0035F5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207902, XrefRangeEnd = 207910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFD0 RID: 57296 RVA: 0x0036141C File Offset: 0x0035F61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207910, XrefRangeEnd = 207915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFD1 RID: 57297 RVA: 0x0036145C File Offset: 0x0035F65C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207915, XrefRangeEnd = 207925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFD2 RID: 57298 RVA: 0x0036149C File Offset: 0x0035F69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207925, XrefRangeEnd = 207930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFD3 RID: 57299 RVA: 0x000777BE File Offset: 0x000759BE
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048B3 RID: 18611
			// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x003614D8 File Offset: 0x0035F6D8
			// (set) Token: 0x0600DFD5 RID: 57301 RVA: 0x000777C7 File Offset: 0x000759C7
			public unsafe ParticleSystem particleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.NativeFieldInfoPtr_particleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.NativeFieldInfoPtr_particleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048B4 RID: 18612
			// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x00361508 File Offset: 0x0035F708
			// (set) Token: 0x0600DFD7 RID: 57303 RVA: 0x000777E6 File Offset: 0x000759E6
			public unsafe Spell_Wriggle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F37 RID: 36663
			private static readonly IntPtr NativeFieldInfoPtr_particleSystem;

			// Token: 0x04008F38 RID: 36664
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F39 RID: 36665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F3A RID: 36666
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008F3B RID: 36667
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008F3C RID: 36668
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0;

			// Token: 0x04008F3D RID: 36669
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_PDM_0;

			// Token: 0x0200104E RID: 4174
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<>c__DisplayClass19_0+<<OnPositiveBuffExecute>g__StopDelayed|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D88 RID: 73096 RVA: 0x0041567C File Offset: 0x0041387C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__StopDelayed|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680188);
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680189);
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680190);
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680191);
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680192);
					Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680193);
				}

				// Token: 0x06011D89 RID: 73097 RVA: 0x0041575C File Offset: 0x0041395C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D8A RID: 73098 RVA: 0x004157A4 File Offset: 0x004139A4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D8B RID: 73099 RVA: 0x004157D8 File Offset: 0x004139D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207890, XrefRangeEnd = 207896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CFF RID: 23807
				// (get) Token: 0x06011D8C RID: 73100 RVA: 0x00415814 File Offset: 0x00413A14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D8D RID: 73101 RVA: 0x00415854 File Offset: 0x00413A54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207896, XrefRangeEnd = 207902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D00 RID: 23808
				// (get) Token: 0x06011D8E RID: 73102 RVA: 0x00415888 File Offset: 0x00413A88
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D8F RID: 73103 RVA: 0x0009B076 File Offset: 0x00099276
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CFC RID: 23804
				// (get) Token: 0x06011D90 RID: 73104 RVA: 0x004158C8 File Offset: 0x00413AC8
				// (set) Token: 0x06011D91 RID: 73105 RVA: 0x0009B07F File Offset: 0x0009927F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CFD RID: 23805
				// (get) Token: 0x06011D92 RID: 73106 RVA: 0x004158F0 File Offset: 0x00413AF0
				// (set) Token: 0x06011D93 RID: 73107 RVA: 0x0009B09A File Offset: 0x0009929A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CFE RID: 23806
				// (get) Token: 0x06011D94 RID: 73108 RVA: 0x00415920 File Offset: 0x00413B20
				// (set) Token: 0x06011D95 RID: 73109 RVA: 0x0009B0B9 File Offset: 0x000992B9
				public unsafe Spell_Wriggle.__c__DisplayClass19_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle.__c__DisplayClass19_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B461 RID: 46177
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B462 RID: 46178
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B463 RID: 46179
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B464 RID: 46180
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B465 RID: 46181
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B466 RID: 46182
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B467 RID: 46183
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B468 RID: 46184
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B469 RID: 46185
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C09 RID: 3081
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Wriggle+<OnPositiveBuffExecute>d__19")]
		public sealed class _OnPositiveBuffExecute_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600DFD8 RID: 57304 RVA: 0x00361538 File Offset: 0x0035F738
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__19()
			{
				Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Wriggle>.NativeClassPtr, "<OnPositiveBuffExecute>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr);
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>1__state");
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>2__current");
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>4__this");
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100680194);
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100680195);
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100680196);
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100680197);
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100680198);
				Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100680199);
			}

			// Token: 0x0600DFD9 RID: 57305 RVA: 0x00361618 File Offset: 0x0035F818
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Wriggle._OnPositiveBuffExecute_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFDA RID: 57306 RVA: 0x00361660 File Offset: 0x0035F860
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFDB RID: 57307 RVA: 0x00361694 File Offset: 0x0035F894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207930, XrefRangeEnd = 207960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048B8 RID: 18616
			// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x003616D0 File Offset: 0x0035F8D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFDD RID: 57309 RVA: 0x00361710 File Offset: 0x0035F910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207960, XrefRangeEnd = 207966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048B9 RID: 18617
			// (get) Token: 0x0600DFDE RID: 57310 RVA: 0x00361744 File Offset: 0x0035F944
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFDF RID: 57311 RVA: 0x00077805 File Offset: 0x00075A05
			public _OnPositiveBuffExecute_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048B5 RID: 18613
			// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x00361784 File Offset: 0x0035F984
			// (set) Token: 0x0600DFE1 RID: 57313 RVA: 0x0007780E File Offset: 0x00075A0E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048B6 RID: 18614
			// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x003617AC File Offset: 0x0035F9AC
			// (set) Token: 0x0600DFE3 RID: 57315 RVA: 0x00077829 File Offset: 0x00075A29
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048B7 RID: 18615
			// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x003617DC File Offset: 0x0035F9DC
			// (set) Token: 0x0600DFE5 RID: 57317 RVA: 0x00077848 File Offset: 0x00075A48
			public unsafe Spell_Wriggle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Wriggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Wriggle._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F3E RID: 36670
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F3F RID: 36671
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F40 RID: 36672
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F41 RID: 36673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F42 RID: 36674
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F43 RID: 36675
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F44 RID: 36676
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F45 RID: 36677
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F46 RID: 36678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
