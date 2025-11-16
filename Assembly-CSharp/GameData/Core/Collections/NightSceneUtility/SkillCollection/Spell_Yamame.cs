using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000290 RID: 656
	public class Spell_Yamame : SpellBase
	{
		// Token: 0x06005318 RID: 21272 RVA: 0x001B7DE0 File Offset: 0x001B5FE0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yamame()
		{
			Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yamame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr);
			Spell_Yamame.NativeFieldInfoPtr_postiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "postiveDuration");
			Spell_Yamame.NativeFieldInfoPtr_slowDownMultiper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "slowDownMultiper");
			Spell_Yamame.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "negativeDuration");
			Spell_Yamame.NativeFieldInfoPtr_lightVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "lightVFX");
			Spell_Yamame.NativeFieldInfoPtr_positiveVFXDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "positiveVFXDuration");
			Spell_Yamame.NativeFieldInfoPtr_webVFX1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "webVFX1");
			Spell_Yamame.NativeFieldInfoPtr_webVFX2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "webVFX2");
			Spell_Yamame.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "rewardSFX");
			Spell_Yamame.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "punishmentSFX");
			Spell_Yamame.NativeFieldInfoPtr_punishmentHitSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "punishmentHitSFX");
			Spell_Yamame.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, 100680200);
			Spell_Yamame.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, 100680201);
			Spell_Yamame.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, 100680202);
			Spell_Yamame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, 100680203);
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x001B7F28 File Offset: 0x001B6128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208150, XrefRangeEnd = 208152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yamame.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x001B7F6C File Offset: 0x001B616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208152, XrefRangeEnd = 208158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yamame.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x001B7FC8 File Offset: 0x001B61C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208158, XrefRangeEnd = 208163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yamame.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x001B8024 File Offset: 0x001B6224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yamame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x0002C90D File Offset: 0x0002AB0D
		public Spell_Yamame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x001B8060 File Offset: 0x001B6260
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x0002C916 File Offset: 0x0002AB16
		public unsafe int postiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_postiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_postiveDuration)) = value;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x001B8088 File Offset: 0x001B6288
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x0002C931 File Offset: 0x0002AB31
		public unsafe float slowDownMultiper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_slowDownMultiper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_slowDownMultiper)) = value;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x001B80B0 File Offset: 0x001B62B0
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x0002C94C File Offset: 0x0002AB4C
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x001B80D8 File Offset: 0x001B62D8
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x0002C967 File Offset: 0x0002AB67
		public unsafe GameObject lightVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_lightVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_lightVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x001B8108 File Offset: 0x001B6308
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x0002C986 File Offset: 0x0002AB86
		public unsafe float positiveVFXDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_positiveVFXDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_positiveVFXDuration)) = value;
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x001B8130 File Offset: 0x001B6330
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x0002C9A1 File Offset: 0x0002ABA1
		public unsafe GameObject webVFX1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_webVFX1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_webVFX1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x001B8160 File Offset: 0x001B6360
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x0002C9C0 File Offset: 0x0002ABC0
		public unsafe GameObject webVFX2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_webVFX2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_webVFX2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600532C RID: 21292 RVA: 0x001B8190 File Offset: 0x001B6390
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x0002C9DF File Offset: 0x0002ABDF
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x001B81C0 File Offset: 0x001B63C0
		// (set) Token: 0x0600532F RID: 21295 RVA: 0x0002C9FE File Offset: 0x0002ABFE
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x001B81F0 File Offset: 0x001B63F0
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x0002CA1D File Offset: 0x0002AC1D
		public unsafe AudioClip punishmentHitSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_punishmentHitSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.NativeFieldInfoPtr_punishmentHitSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040037F5 RID: 14325
		private static readonly IntPtr NativeFieldInfoPtr_postiveDuration;

		// Token: 0x040037F6 RID: 14326
		private static readonly IntPtr NativeFieldInfoPtr_slowDownMultiper;

		// Token: 0x040037F7 RID: 14327
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040037F8 RID: 14328
		private static readonly IntPtr NativeFieldInfoPtr_lightVFX;

		// Token: 0x040037F9 RID: 14329
		private static readonly IntPtr NativeFieldInfoPtr_positiveVFXDuration;

		// Token: 0x040037FA RID: 14330
		private static readonly IntPtr NativeFieldInfoPtr_webVFX1;

		// Token: 0x040037FB RID: 14331
		private static readonly IntPtr NativeFieldInfoPtr_webVFX2;

		// Token: 0x040037FC RID: 14332
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040037FD RID: 14333
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040037FE RID: 14334
		private static readonly IntPtr NativeFieldInfoPtr_punishmentHitSFX;

		// Token: 0x040037FF RID: 14335
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003800 RID: 14336
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003801 RID: 14337
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003802 RID: 14338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C0A RID: 3082
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yamame+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFE6 RID: 57318 RVA: 0x0036180C File Offset: 0x0035FA0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr);
				Spell_Yamame.__c__DisplayClass11_0.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, "angle");
				Spell_Yamame.__c__DisplayClass11_0.NativeFieldInfoPtr_web2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, "web2");
				Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, 100680204);
				Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, 100680205);
				Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, 100680206);
				Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, 100680207);
			}

			// Token: 0x0600DFE7 RID: 57319 RVA: 0x003618B0 File Offset: 0x0035FAB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE8 RID: 57320 RVA: 0x003618EC File Offset: 0x0035FAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207993, XrefRangeEnd = 207996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(ParticleSystem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE9 RID: 57321 RVA: 0x00361930 File Offset: 0x0035FB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207996, XrefRangeEnd = 208000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFEA RID: 57322 RVA: 0x00361964 File Offset: 0x0035FB64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208000, XrefRangeEnd = 208005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFEB RID: 57323 RVA: 0x00077867 File Offset: 0x00075A67
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048BA RID: 18618
			// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x003619A4 File Offset: 0x0035FBA4
			// (set) Token: 0x0600DFED RID: 57325 RVA: 0x00077870 File Offset: 0x00075A70
			public unsafe float angle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.NativeFieldInfoPtr_angle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.NativeFieldInfoPtr_angle)) = value;
				}
			}

			// Token: 0x170048BB RID: 18619
			// (get) Token: 0x0600DFEE RID: 57326 RVA: 0x003619CC File Offset: 0x0035FBCC
			// (set) Token: 0x0600DFEF RID: 57327 RVA: 0x0007788B File Offset: 0x00075A8B
			public unsafe GameObject web2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.NativeFieldInfoPtr_web2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.NativeFieldInfoPtr_web2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F47 RID: 36679
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x04008F48 RID: 36680
			private static readonly IntPtr NativeFieldInfoPtr_web2;

			// Token: 0x04008F49 RID: 36681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F4A RID: 36682
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_ParticleSystem_0;

			// Token: 0x04008F4B RID: 36683
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_0;

			// Token: 0x04008F4C RID: 36684
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200104F RID: 4175
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yamame+<>c__DisplayClass11_0+<<OnNegativeBuffExecute>g__Follow|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011D96 RID: 73110 RVA: 0x00415950 File Offset: 0x00413B50
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Follow|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680208);
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680209);
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680210);
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680211);
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680212);
					Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680213);
				}

				// Token: 0x06011D97 RID: 73111 RVA: 0x00415A30 File Offset: 0x00413C30
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D98 RID: 73112 RVA: 0x00415A78 File Offset: 0x00413C78
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D99 RID: 73113 RVA: 0x00415AAC File Offset: 0x00413CAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207979, XrefRangeEnd = 207987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D04 RID: 23812
				// (get) Token: 0x06011D9A RID: 73114 RVA: 0x00415AE8 File Offset: 0x00413CE8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D9B RID: 73115 RVA: 0x00415B28 File Offset: 0x00413D28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207987, XrefRangeEnd = 207993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D05 RID: 23813
				// (get) Token: 0x06011D9C RID: 73116 RVA: 0x00415B5C File Offset: 0x00413D5C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D9D RID: 73117 RVA: 0x0009B0D8 File Offset: 0x000992D8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D01 RID: 23809
				// (get) Token: 0x06011D9E RID: 73118 RVA: 0x00415B9C File Offset: 0x00413D9C
				// (set) Token: 0x06011D9F RID: 73119 RVA: 0x0009B0E1 File Offset: 0x000992E1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D02 RID: 23810
				// (get) Token: 0x06011DA0 RID: 73120 RVA: 0x00415BC4 File Offset: 0x00413DC4
				// (set) Token: 0x06011DA1 RID: 73121 RVA: 0x0009B0FC File Offset: 0x000992FC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D03 RID: 23811
				// (get) Token: 0x06011DA2 RID: 73122 RVA: 0x00415BF4 File Offset: 0x00413DF4
				// (set) Token: 0x06011DA3 RID: 73123 RVA: 0x0009B11B File Offset: 0x0009931B
				public unsafe Spell_Yamame.__c__DisplayClass11_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B46A RID: 46186
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B46B RID: 46187
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B46C RID: 46188
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B46D RID: 46189
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B46E RID: 46190
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B46F RID: 46191
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B470 RID: 46192
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B471 RID: 46193
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B472 RID: 46194
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C0B RID: 3083
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yamame+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DFF0 RID: 57328 RVA: 0x003619FC File Offset: 0x0035FBFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr);
				Spell_Yamame.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, "<>9");
				Spell_Yamame.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, "<>9__11_1");
				Spell_Yamame.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, "<>9__12_2");
				Spell_Yamame.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, "<>9__12_3");
				Spell_Yamame.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, 100680215);
				Spell_Yamame.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, 100680216);
				Spell_Yamame.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_2_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, 100680217);
				Spell_Yamame.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_3_Internal_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr, 100680218);
			}

			// Token: 0x0600DFF1 RID: 57329 RVA: 0x00361AC8 File Offset: 0x0035FCC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF2 RID: 57330 RVA: 0x00361B04 File Offset: 0x0035FD04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__11_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFF3 RID: 57331 RVA: 0x00361B40 File Offset: 0x0035FD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__12_2(ParticleSystem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_2_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF4 RID: 57332 RVA: 0x00361B84 File Offset: 0x0035FD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208005, XrefRangeEnd = 208009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__12_3(Animator x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_3_Internal_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF5 RID: 57333 RVA: 0x000778AA File Offset: 0x00075AAA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048BC RID: 18620
			// (get) Token: 0x0600DFF6 RID: 57334 RVA: 0x00361BC8 File Offset: 0x0035FDC8
			// (set) Token: 0x0600DFF7 RID: 57335 RVA: 0x000778B3 File Offset: 0x00075AB3
			public unsafe static Spell_Yamame.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yamame.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yamame.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048BD RID: 18621
			// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x00361BF0 File Offset: 0x0035FDF0
			// (set) Token: 0x0600DFF9 RID: 57337 RVA: 0x000778C5 File Offset: 0x00075AC5
			public unsafe static Func<Vector3> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yamame.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yamame.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048BE RID: 18622
			// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x00361C18 File Offset: 0x0035FE18
			// (set) Token: 0x0600DFFB RID: 57339 RVA: 0x000778D7 File Offset: 0x00075AD7
			public unsafe static Action<ParticleSystem> __9__12_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yamame.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yamame.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048BF RID: 18623
			// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x00361C40 File Offset: 0x0035FE40
			// (set) Token: 0x0600DFFD RID: 57341 RVA: 0x000778E9 File Offset: 0x00075AE9
			public unsafe static Action<Animator> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yamame.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Animator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yamame.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F4D RID: 36685
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F4E RID: 36686
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04008F4F RID: 36687
			private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

			// Token: 0x04008F50 RID: 36688
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x04008F51 RID: 36689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F52 RID: 36690
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_1_Internal_Vector3_0;

			// Token: 0x04008F53 RID: 36691
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_2_Internal_Void_ParticleSystem_0;

			// Token: 0x04008F54 RID: 36692
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_3_Internal_Void_Animator_0;
		}

		// Token: 0x02000C0C RID: 3084
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yamame+<OnNegativeBuffExecute>d__11")]
		public sealed class _OnNegativeBuffExecute_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600DFFE RID: 57342 RVA: 0x00361C68 File Offset: 0x0035FE68
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__11()
			{
				Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "<OnNegativeBuffExecute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr);
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>1__state");
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>2__current");
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>4__this");
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, "spellExecutionContext");
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>8__1");
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680219);
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680220);
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680221);
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680222);
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680223);
				Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680224);
			}

			// Token: 0x0600DFFF RID: 57343 RVA: 0x00361D70 File Offset: 0x0035FF70
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame._OnNegativeBuffExecute_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E000 RID: 57344 RVA: 0x00361DB8 File Offset: 0x0035FFB8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E001 RID: 57345 RVA: 0x00361DEC File Offset: 0x0035FFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208009, XrefRangeEnd = 208087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048C5 RID: 18629
			// (get) Token: 0x0600E002 RID: 57346 RVA: 0x00361E28 File Offset: 0x00360028
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E003 RID: 57347 RVA: 0x00361E68 File Offset: 0x00360068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208087, XrefRangeEnd = 208093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048C6 RID: 18630
			// (get) Token: 0x0600E004 RID: 57348 RVA: 0x00361E9C File Offset: 0x0036009C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E005 RID: 57349 RVA: 0x000778FB File Offset: 0x00075AFB
			public _OnNegativeBuffExecute_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048C0 RID: 18624
			// (get) Token: 0x0600E006 RID: 57350 RVA: 0x00361EDC File Offset: 0x003600DC
			// (set) Token: 0x0600E007 RID: 57351 RVA: 0x00077904 File Offset: 0x00075B04
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048C1 RID: 18625
			// (get) Token: 0x0600E008 RID: 57352 RVA: 0x00361F04 File Offset: 0x00360104
			// (set) Token: 0x0600E009 RID: 57353 RVA: 0x0007791F File Offset: 0x00075B1F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048C2 RID: 18626
			// (get) Token: 0x0600E00A RID: 57354 RVA: 0x00361F34 File Offset: 0x00360134
			// (set) Token: 0x0600E00B RID: 57355 RVA: 0x0007793E File Offset: 0x00075B3E
			public unsafe Spell_Yamame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048C3 RID: 18627
			// (get) Token: 0x0600E00C RID: 57356 RVA: 0x00361F64 File Offset: 0x00360164
			// (set) Token: 0x0600E00D RID: 57357 RVA: 0x0007795D File Offset: 0x00075B5D
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048C4 RID: 18628
			// (get) Token: 0x0600E00E RID: 57358 RVA: 0x00361F94 File Offset: 0x00360194
			// (set) Token: 0x0600E00F RID: 57359 RVA: 0x0007797C File Offset: 0x00075B7C
			public unsafe Spell_Yamame.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F55 RID: 36693
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F56 RID: 36694
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F57 RID: 36695
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F58 RID: 36696
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008F59 RID: 36697
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008F5A RID: 36698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F5B RID: 36699
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F5C RID: 36700
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F5D RID: 36701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F5E RID: 36702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F5F RID: 36703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C0D RID: 3085
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yamame+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E010 RID: 57360 RVA: 0x00361FC4 File Offset: 0x003601C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr);
				Spell_Yamame.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				Spell_Yamame.__c__DisplayClass12_0.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr, "light");
				Spell_Yamame.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr, 100680225);
				Spell_Yamame.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr, 100680226);
				Spell_Yamame.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr, 100680227);
			}

			// Token: 0x0600E011 RID: 57361 RVA: 0x00362054 File Offset: 0x00360254
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E012 RID: 57362 RVA: 0x00362090 File Offset: 0x00360290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208093, XrefRangeEnd = 208095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E013 RID: 57363 RVA: 0x003620D0 File Offset: 0x003602D0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame.__c__DisplayClass12_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E014 RID: 57364 RVA: 0x0007799B File Offset: 0x00075B9B
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048C7 RID: 18631
			// (get) Token: 0x0600E015 RID: 57365 RVA: 0x00362114 File Offset: 0x00360314
			// (set) Token: 0x0600E016 RID: 57366 RVA: 0x000779A4 File Offset: 0x00075BA4
			public unsafe Spell_Yamame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048C8 RID: 18632
			// (get) Token: 0x0600E017 RID: 57367 RVA: 0x00362144 File Offset: 0x00360344
			// (set) Token: 0x0600E018 RID: 57368 RVA: 0x000779C3 File Offset: 0x00075BC3
			public unsafe GameObject light
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass12_0.NativeFieldInfoPtr_light);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame.__c__DisplayClass12_0.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F60 RID: 36704
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F61 RID: 36705
			private static readonly IntPtr NativeFieldInfoPtr_light;

			// Token: 0x04008F62 RID: 36706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F63 RID: 36707
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0;

			// Token: 0x04008F64 RID: 36708
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000C0E RID: 3086
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yamame+<OnPositiveBuffExecute>d__12")]
		public sealed class _OnPositiveBuffExecute_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600E019 RID: 57369 RVA: 0x00362174 File Offset: 0x00360374
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__12()
			{
				Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yamame>.NativeClassPtr, "<OnPositiveBuffExecute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr);
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>1__state");
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>2__current");
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>4__this");
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, "<>8__1");
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100680228);
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100680229);
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100680230);
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100680231);
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100680232);
				Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr, 100680233);
			}

			// Token: 0x0600E01A RID: 57370 RVA: 0x00362268 File Offset: 0x00360468
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yamame._OnPositiveBuffExecute_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E01B RID: 57371 RVA: 0x003622B0 File Offset: 0x003604B0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E01C RID: 57372 RVA: 0x003622E4 File Offset: 0x003604E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208095, XrefRangeEnd = 208144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048CD RID: 18637
			// (get) Token: 0x0600E01D RID: 57373 RVA: 0x00362320 File Offset: 0x00360520
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E01E RID: 57374 RVA: 0x00362360 File Offset: 0x00360560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208144, XrefRangeEnd = 208150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048CE RID: 18638
			// (get) Token: 0x0600E01F RID: 57375 RVA: 0x00362394 File Offset: 0x00360594
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E020 RID: 57376 RVA: 0x000779E2 File Offset: 0x00075BE2
			public _OnPositiveBuffExecute_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048C9 RID: 18633
			// (get) Token: 0x0600E021 RID: 57377 RVA: 0x003623D4 File Offset: 0x003605D4
			// (set) Token: 0x0600E022 RID: 57378 RVA: 0x000779EB File Offset: 0x00075BEB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048CA RID: 18634
			// (get) Token: 0x0600E023 RID: 57379 RVA: 0x003623FC File Offset: 0x003605FC
			// (set) Token: 0x0600E024 RID: 57380 RVA: 0x00077A06 File Offset: 0x00075C06
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048CB RID: 18635
			// (get) Token: 0x0600E025 RID: 57381 RVA: 0x0036242C File Offset: 0x0036062C
			// (set) Token: 0x0600E026 RID: 57382 RVA: 0x00077A25 File Offset: 0x00075C25
			public unsafe Spell_Yamame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048CC RID: 18636
			// (get) Token: 0x0600E027 RID: 57383 RVA: 0x0036245C File Offset: 0x0036065C
			// (set) Token: 0x0600E028 RID: 57384 RVA: 0x00077A44 File Offset: 0x00075C44
			public unsafe Spell_Yamame.__c__DisplayClass12_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yamame.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yamame._OnPositiveBuffExecute_d__12.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F65 RID: 36709
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F66 RID: 36710
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F67 RID: 36711
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F68 RID: 36712
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008F69 RID: 36713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F6A RID: 36714
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F6B RID: 36715
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F6C RID: 36716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F6D RID: 36717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F6E RID: 36718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
