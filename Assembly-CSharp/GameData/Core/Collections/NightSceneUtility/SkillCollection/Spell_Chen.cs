using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.EventUtility;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000260 RID: 608
	public class Spell_Chen : SpellBase
	{
		// Token: 0x06004B2E RID: 19246 RVA: 0x001A3DB4 File Offset: 0x001A1FB4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Chen()
		{
			Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Chen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr);
			Spell_Chen.NativeFieldInfoPtr_normalGuestSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "normalGuestSpawnRate");
			Spell_Chen.NativeFieldInfoPtr_fishGiveAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "fishGiveAmount");
			Spell_Chen.NativeFieldInfoPtr_getItemEffectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "getItemEffectParent");
			Spell_Chen.NativeFieldInfoPtr_trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "trail");
			Spell_Chen.NativeFieldInfoPtr_lazyEffectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "lazyEffectParent");
			Spell_Chen.NativeFieldInfoPtr_bubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "bubble");
			Spell_Chen.NativeFieldInfoPtr_getItemEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "getItemEffectDuration");
			Spell_Chen.NativeFieldInfoPtr_getItemOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "getItemOffset");
			Spell_Chen.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, 100678418);
			Spell_Chen.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, 100678419);
			Spell_Chen.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, 100678420);
			Spell_Chen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, 100678421);
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x001A3ED4 File Offset: 0x001A20D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195255, XrefRangeEnd = 195257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Chen.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x001A3F18 File Offset: 0x001A2118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195257, XrefRangeEnd = 195262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Chen.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x001A3F74 File Offset: 0x001A2174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195262, XrefRangeEnd = 195267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Chen.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x001A3FD0 File Offset: 0x001A21D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Chen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00026932 File Offset: 0x00024B32
		public Spell_Chen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x001A400C File Offset: 0x001A220C
		// (set) Token: 0x06004B35 RID: 19253 RVA: 0x0002693B File Offset: 0x00024B3B
		public unsafe float normalGuestSpawnRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_normalGuestSpawnRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_normalGuestSpawnRate)) = value;
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x001A4034 File Offset: 0x001A2234
		// (set) Token: 0x06004B37 RID: 19255 RVA: 0x00026956 File Offset: 0x00024B56
		public unsafe int fishGiveAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_fishGiveAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_fishGiveAmount)) = value;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x001A405C File Offset: 0x001A225C
		// (set) Token: 0x06004B39 RID: 19257 RVA: 0x00026971 File Offset: 0x00024B71
		public unsafe GameObject getItemEffectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_getItemEffectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_getItemEffectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x001A408C File Offset: 0x001A228C
		// (set) Token: 0x06004B3B RID: 19259 RVA: 0x00026990 File Offset: 0x00024B90
		public unsafe AudioClip trail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_trail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_trail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x001A40BC File Offset: 0x001A22BC
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x000269AF File Offset: 0x00024BAF
		public unsafe GameObject lazyEffectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_lazyEffectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_lazyEffectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x001A40EC File Offset: 0x001A22EC
		// (set) Token: 0x06004B3F RID: 19263 RVA: 0x000269CE File Offset: 0x00024BCE
		public unsafe AudioClip bubble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_bubble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_bubble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x001A411C File Offset: 0x001A231C
		// (set) Token: 0x06004B41 RID: 19265 RVA: 0x000269ED File Offset: 0x00024BED
		public unsafe float getItemEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_getItemEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_getItemEffectDuration)) = value;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06004B42 RID: 19266 RVA: 0x001A4144 File Offset: 0x001A2344
		// (set) Token: 0x06004B43 RID: 19267 RVA: 0x00026A08 File Offset: 0x00024C08
		public unsafe float getItemOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_getItemOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.NativeFieldInfoPtr_getItemOffset)) = value;
			}
		}

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestSpawnRate;

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeFieldInfoPtr_fishGiveAmount;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeFieldInfoPtr_getItemEffectParent;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeFieldInfoPtr_trail;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeFieldInfoPtr_lazyEffectParent;

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeFieldInfoPtr_bubble;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeFieldInfoPtr_getItemEffectDuration;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeFieldInfoPtr_getItemOffset;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B0B RID: 2827
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Chen+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1FF RID: 53759 RVA: 0x00337AEC File Offset: 0x00335CEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass9_0>.NativeClassPtr);
				Spell_Chen.__c__DisplayClass9_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass9_0>.NativeClassPtr, "effect");
				Spell_Chen.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass9_0>.NativeClassPtr, 100678422);
				Spell_Chen.__c__DisplayClass9_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass9_0>.NativeClassPtr, 100678423);
			}

			// Token: 0x0600D200 RID: 53760 RVA: 0x00337B54 File Offset: 0x00335D54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D201 RID: 53761 RVA: 0x00337B90 File Offset: 0x00335D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195101, XrefRangeEnd = 195145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass9_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D202 RID: 53762 RVA: 0x000707F4 File Offset: 0x0006E9F4
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004457 RID: 17495
			// (get) Token: 0x0600D203 RID: 53763 RVA: 0x00337BC4 File Offset: 0x00335DC4
			// (set) Token: 0x0600D204 RID: 53764 RVA: 0x000707FD File Offset: 0x0006E9FD
			public unsafe GameObject effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass9_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass9_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086E1 RID: 34529
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x040086E2 RID: 34530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086E3 RID: 34531
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_0;
		}

		// Token: 0x02000B0C RID: 2828
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Chen+<OnNegativeBuffExecute>d__9")]
		public sealed class _OnNegativeBuffExecute_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D205 RID: 53765 RVA: 0x00337BF4 File Offset: 0x00335DF4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__9()
			{
				Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "<OnNegativeBuffExecute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr);
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>1__state");
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>2__current");
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>4__this");
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100678424);
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100678425);
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100678426);
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100678427);
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100678428);
				Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100678429);
			}

			// Token: 0x0600D206 RID: 53766 RVA: 0x00337CD4 File Offset: 0x00335ED4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Chen._OnNegativeBuffExecute_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D207 RID: 53767 RVA: 0x00337D1C File Offset: 0x00335F1C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D208 RID: 53768 RVA: 0x00337D50 File Offset: 0x00335F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195145, XrefRangeEnd = 195168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700445B RID: 17499
			// (get) Token: 0x0600D209 RID: 53769 RVA: 0x00337D8C File Offset: 0x00335F8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D20A RID: 53770 RVA: 0x00337DCC File Offset: 0x00335FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195168, XrefRangeEnd = 195174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700445C RID: 17500
			// (get) Token: 0x0600D20B RID: 53771 RVA: 0x00337E00 File Offset: 0x00336000
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D20C RID: 53772 RVA: 0x0007081C File Offset: 0x0006EA1C
			public _OnNegativeBuffExecute_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004458 RID: 17496
			// (get) Token: 0x0600D20D RID: 53773 RVA: 0x00337E40 File Offset: 0x00336040
			// (set) Token: 0x0600D20E RID: 53774 RVA: 0x00070825 File Offset: 0x0006EA25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004459 RID: 17497
			// (get) Token: 0x0600D20F RID: 53775 RVA: 0x00337E68 File Offset: 0x00336068
			// (set) Token: 0x0600D210 RID: 53776 RVA: 0x00070840 File Offset: 0x0006EA40
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445A RID: 17498
			// (get) Token: 0x0600D211 RID: 53777 RVA: 0x00337E98 File Offset: 0x00336098
			// (set) Token: 0x0600D212 RID: 53778 RVA: 0x0007085F File Offset: 0x0006EA5F
			public unsafe Spell_Chen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Chen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086E4 RID: 34532
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040086E5 RID: 34533
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040086E6 RID: 34534
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086E7 RID: 34535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040086E8 RID: 34536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086E9 RID: 34537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040086EA RID: 34538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040086EB RID: 34539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086EC RID: 34540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B0D RID: 2829
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Chen+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D213 RID: 53779 RVA: 0x00337EC8 File Offset: 0x003360C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr);
				Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr_texts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, "texts");
				Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
				Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, "<>9__2");
				Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, "<>9__3");
				Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, 100678430);
				Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, 100678431);
				Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, 100678432);
				Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, 100678433);
				Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr, 100678434);
			}

			// Token: 0x0600D214 RID: 53780 RVA: 0x00337FBC File Offset: 0x003361BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Chen.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D215 RID: 53781 RVA: 0x00337FF8 File Offset: 0x003361F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195174, XrefRangeEnd = 195208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D216 RID: 53782 RVA: 0x0033803C File Offset: 0x0033623C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195208, XrefRangeEnd = 195211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D217 RID: 53783 RVA: 0x00338080 File Offset: 0x00336280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195211, XrefRangeEnd = 195214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D218 RID: 53784 RVA: 0x003380C4 File Offset: 0x003362C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195214, XrefRangeEnd = 195217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D219 RID: 53785 RVA: 0x0007087E File Offset: 0x0006EA7E
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700445D RID: 17501
			// (get) Token: 0x0600D21A RID: 53786 RVA: 0x00338108 File Offset: 0x00336308
			// (set) Token: 0x0600D21B RID: 53787 RVA: 0x00070887 File Offset: 0x0006EA87
			public unsafe Spell_Chen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Chen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445E RID: 17502
			// (get) Token: 0x0600D21C RID: 53788 RVA: 0x00338138 File Offset: 0x00336338
			// (set) Token: 0x0600D21D RID: 53789 RVA: 0x000708A6 File Offset: 0x0006EAA6
			public unsafe Il2CppReferenceArray<ObjectLanguageBase> texts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr_texts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectLanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr_texts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445F RID: 17503
			// (get) Token: 0x0600D21E RID: 53790 RVA: 0x00338168 File Offset: 0x00336368
			// (set) Token: 0x0600D21F RID: 53791 RVA: 0x000708C5 File Offset: 0x0006EAC5
			public unsafe Action<Image> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004460 RID: 17504
			// (get) Token: 0x0600D220 RID: 53792 RVA: 0x00338198 File Offset: 0x00336398
			// (set) Token: 0x0600D221 RID: 53793 RVA: 0x000708E4 File Offset: 0x0006EAE4
			public unsafe Action<Image> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004461 RID: 17505
			// (get) Token: 0x0600D222 RID: 53794 RVA: 0x003381C8 File Offset: 0x003363C8
			// (set) Token: 0x0600D223 RID: 53795 RVA: 0x00070903 File Offset: 0x0006EB03
			public unsafe Action<Image> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen.__c__DisplayClass10_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086ED RID: 34541
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086EE RID: 34542
			private static readonly IntPtr NativeFieldInfoPtr_texts;

			// Token: 0x040086EF RID: 34543
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040086F0 RID: 34544
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040086F1 RID: 34545
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040086F2 RID: 34546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086F3 RID: 34547
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x040086F4 RID: 34548
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Image_0;

			// Token: 0x040086F5 RID: 34549
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Image_0;

			// Token: 0x040086F6 RID: 34550
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_Image_0;
		}

		// Token: 0x02000B0E RID: 2830
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Chen+<OnPositiveBuffExecute>d__10")]
		public sealed class _OnPositiveBuffExecute_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600D224 RID: 53796 RVA: 0x003381F8 File Offset: 0x003363F8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__10()
			{
				Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Chen>.NativeClassPtr, "<OnPositiveBuffExecute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr);
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>1__state");
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>2__current");
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>4__this");
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr__selected_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<selected>5__2");
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100678435);
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100678436);
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100678437);
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100678438);
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100678439);
				Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100678440);
			}

			// Token: 0x0600D225 RID: 53797 RVA: 0x003382EC File Offset: 0x003364EC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Chen._OnPositiveBuffExecute_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D226 RID: 53798 RVA: 0x00338334 File Offset: 0x00336534
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D227 RID: 53799 RVA: 0x00338368 File Offset: 0x00336568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195217, XrefRangeEnd = 195249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004466 RID: 17510
			// (get) Token: 0x0600D228 RID: 53800 RVA: 0x003383A4 File Offset: 0x003365A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D229 RID: 53801 RVA: 0x003383E4 File Offset: 0x003365E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195249, XrefRangeEnd = 195255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004467 RID: 17511
			// (get) Token: 0x0600D22A RID: 53802 RVA: 0x00338418 File Offset: 0x00336618
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Chen._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D22B RID: 53803 RVA: 0x00070922 File Offset: 0x0006EB22
			public _OnPositiveBuffExecute_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004462 RID: 17506
			// (get) Token: 0x0600D22C RID: 53804 RVA: 0x00338458 File Offset: 0x00336658
			// (set) Token: 0x0600D22D RID: 53805 RVA: 0x0007092B File Offset: 0x0006EB2B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004463 RID: 17507
			// (get) Token: 0x0600D22E RID: 53806 RVA: 0x00338480 File Offset: 0x00336680
			// (set) Token: 0x0600D22F RID: 53807 RVA: 0x00070946 File Offset: 0x0006EB46
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004464 RID: 17508
			// (get) Token: 0x0600D230 RID: 53808 RVA: 0x003384B0 File Offset: 0x003366B0
			// (set) Token: 0x0600D231 RID: 53809 RVA: 0x00070965 File Offset: 0x0006EB65
			public unsafe Spell_Chen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Chen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004465 RID: 17509
			// (get) Token: 0x0600D232 RID: 53810 RVA: 0x003384E0 File Offset: 0x003366E0
			// (set) Token: 0x0600D233 RID: 53811 RVA: 0x00070984 File Offset: 0x0006EB84
			public EventManager.SelectedValue _selected_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr__selected_5__2);
					return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Chen._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr__selected_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040086F7 RID: 34551
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040086F8 RID: 34552
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040086F9 RID: 34553
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086FA RID: 34554
			private static readonly IntPtr NativeFieldInfoPtr__selected_5__2;

			// Token: 0x040086FB RID: 34555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040086FC RID: 34556
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086FD RID: 34557
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040086FE RID: 34558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040086FF RID: 34559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008700 RID: 34560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
