using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000276 RID: 630
	public class Spell_Nitori : SpellBase
	{
		// Token: 0x06004F0E RID: 20238 RVA: 0x001AD70C File Offset: 0x001AB90C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Nitori()
		{
			Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Nitori");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr);
			Spell_Nitori.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "positiveDuration");
			Spell_Nitori.NativeFieldInfoPtr_negativeRepellGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "negativeRepellGuestNum");
			Spell_Nitori.NativeFieldInfoPtr_waterShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "waterShakeAmplitude");
			Spell_Nitori.NativeFieldInfoPtr_waterShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "waterShakeDuration");
			Spell_Nitori.NativeFieldInfoPtr_waterShakeEndDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "waterShakeEndDuration");
			Spell_Nitori.NativeFieldInfoPtr_nitoriTechArmObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "nitoriTechArmObject");
			Spell_Nitori.NativeFieldInfoPtr_armAnimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "armAnimDuration");
			Spell_Nitori.NativeFieldInfoPtr_armOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "armOffset");
			Spell_Nitori.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "rewardSFX");
			Spell_Nitori.NativeFieldInfoPtr_nitoriRainObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "nitoriRainObject");
			Spell_Nitori.NativeFieldInfoPtr_stopRainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "stopRainTime");
			Spell_Nitori.NativeFieldInfoPtr_wholeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "wholeDuration");
			Spell_Nitori.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "punishmentSFX");
			Spell_Nitori.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, 100679186);
			Spell_Nitori.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, 100679187);
			Spell_Nitori.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, 100679188);
			Spell_Nitori.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, 100679189);
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x001AD890 File Offset: 0x001ABA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200788, XrefRangeEnd = 200790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Nitori.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x001AD8D4 File Offset: 0x001ABAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200790, XrefRangeEnd = 200796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Nitori.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x001AD930 File Offset: 0x001ABB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200796, XrefRangeEnd = 200801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Nitori.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x001AD98C File Offset: 0x001ABB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200801, XrefRangeEnd = 200802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Nitori() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x0002989D File Offset: 0x00027A9D
		public Spell_Nitori(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06004F14 RID: 20244 RVA: 0x001AD9C8 File Offset: 0x001ABBC8
		// (set) Token: 0x06004F15 RID: 20245 RVA: 0x000298A6 File Offset: 0x00027AA6
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06004F16 RID: 20246 RVA: 0x001AD9F0 File Offset: 0x001ABBF0
		// (set) Token: 0x06004F17 RID: 20247 RVA: 0x000298C1 File Offset: 0x00027AC1
		public unsafe Vector2Int negativeRepellGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_negativeRepellGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_negativeRepellGuestNum)) = value;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06004F18 RID: 20248 RVA: 0x001ADA18 File Offset: 0x001ABC18
		// (set) Token: 0x06004F19 RID: 20249 RVA: 0x000298DC File Offset: 0x00027ADC
		public unsafe float waterShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_waterShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_waterShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06004F1A RID: 20250 RVA: 0x001ADA40 File Offset: 0x001ABC40
		// (set) Token: 0x06004F1B RID: 20251 RVA: 0x000298F7 File Offset: 0x00027AF7
		public unsafe float waterShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_waterShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_waterShakeDuration)) = value;
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06004F1C RID: 20252 RVA: 0x001ADA68 File Offset: 0x001ABC68
		// (set) Token: 0x06004F1D RID: 20253 RVA: 0x00029912 File Offset: 0x00027B12
		public unsafe float waterShakeEndDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_waterShakeEndDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_waterShakeEndDuration)) = value;
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06004F1E RID: 20254 RVA: 0x001ADA90 File Offset: 0x001ABC90
		// (set) Token: 0x06004F1F RID: 20255 RVA: 0x0002992D File Offset: 0x00027B2D
		public unsafe GameObject nitoriTechArmObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_nitoriTechArmObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_nitoriTechArmObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x001ADAC0 File Offset: 0x001ABCC0
		// (set) Token: 0x06004F21 RID: 20257 RVA: 0x0002994C File Offset: 0x00027B4C
		public unsafe float armAnimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_armAnimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_armAnimDuration)) = value;
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x001ADAE8 File Offset: 0x001ABCE8
		// (set) Token: 0x06004F23 RID: 20259 RVA: 0x00029967 File Offset: 0x00027B67
		public unsafe Vector2 armOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_armOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_armOffset)) = value;
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x001ADB10 File Offset: 0x001ABD10
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x00029982 File Offset: 0x00027B82
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x001ADB40 File Offset: 0x001ABD40
		// (set) Token: 0x06004F27 RID: 20263 RVA: 0x000299A1 File Offset: 0x00027BA1
		public unsafe GameObject nitoriRainObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_nitoriRainObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_nitoriRainObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06004F28 RID: 20264 RVA: 0x001ADB70 File Offset: 0x001ABD70
		// (set) Token: 0x06004F29 RID: 20265 RVA: 0x000299C0 File Offset: 0x00027BC0
		public unsafe float stopRainTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_stopRainTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_stopRainTime)) = value;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06004F2A RID: 20266 RVA: 0x001ADB98 File Offset: 0x001ABD98
		// (set) Token: 0x06004F2B RID: 20267 RVA: 0x000299DB File Offset: 0x00027BDB
		public unsafe float wholeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_wholeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_wholeDuration)) = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06004F2C RID: 20268 RVA: 0x001ADBC0 File Offset: 0x001ABDC0
		// (set) Token: 0x06004F2D RID: 20269 RVA: 0x000299F6 File Offset: 0x00027BF6
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035B9 RID: 13753
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040035BA RID: 13754
		private static readonly IntPtr NativeFieldInfoPtr_negativeRepellGuestNum;

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeFieldInfoPtr_waterShakeAmplitude;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeFieldInfoPtr_waterShakeDuration;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeFieldInfoPtr_waterShakeEndDuration;

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeFieldInfoPtr_nitoriTechArmObject;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeFieldInfoPtr_armAnimDuration;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeFieldInfoPtr_armOffset;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeFieldInfoPtr_nitoriRainObject;

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeFieldInfoPtr_stopRainTime;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeFieldInfoPtr_wholeDuration;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B76 RID: 2934
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nitori+<>c__DisplayClass14_0")]
		public new sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7F1 RID: 55281 RVA: 0x003498D4 File Offset: 0x00347AD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass14_0>.NativeClassPtr);
				Spell_Nitori.__c__DisplayClass14_0.NativeFieldInfoPtr_rain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass14_0>.NativeClassPtr, "rain");
				Spell_Nitori.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass14_0>.NativeClassPtr, 100679190);
				Spell_Nitori.__c__DisplayClass14_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass14_0>.NativeClassPtr, 100679191);
			}

			// Token: 0x0600D7F2 RID: 55282 RVA: 0x0034993C File Offset: 0x00347B3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F3 RID: 55283 RVA: 0x00349978 File Offset: 0x00347B78
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass14_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F4 RID: 55284 RVA: 0x000738B0 File Offset: 0x00071AB0
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700463F RID: 17983
			// (get) Token: 0x0600D7F5 RID: 55285 RVA: 0x003499BC File Offset: 0x00347BBC
			// (set) Token: 0x0600D7F6 RID: 55286 RVA: 0x000738B9 File Offset: 0x00071AB9
			public unsafe GameObject rain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass14_0.NativeFieldInfoPtr_rain);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass14_0.NativeFieldInfoPtr_rain), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A6F RID: 35439
			private static readonly IntPtr NativeFieldInfoPtr_rain;

			// Token: 0x04008A70 RID: 35440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A71 RID: 35441
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B77 RID: 2935
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nitori+<OnNegativeBuffExecute>d__14")]
		public sealed class _OnNegativeBuffExecute_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D7F7 RID: 55287 RVA: 0x003499EC File Offset: 0x00347BEC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__14()
			{
				Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "<OnNegativeBuffExecute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr);
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>1__state");
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>2__current");
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>4__this");
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>8__1");
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, "spellExecutionContext");
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679192);
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679193);
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679194);
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679195);
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679196);
				Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679197);
			}

			// Token: 0x0600D7F8 RID: 55288 RVA: 0x00349AF4 File Offset: 0x00347CF4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori._OnNegativeBuffExecute_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F9 RID: 55289 RVA: 0x00349B3C File Offset: 0x00347D3C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7FA RID: 55290 RVA: 0x00349B70 File Offset: 0x00347D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200682, XrefRangeEnd = 200712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004645 RID: 17989
			// (get) Token: 0x0600D7FB RID: 55291 RVA: 0x00349BAC File Offset: 0x00347DAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7FC RID: 55292 RVA: 0x00349BEC File Offset: 0x00347DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200712, XrefRangeEnd = 200718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004646 RID: 17990
			// (get) Token: 0x0600D7FD RID: 55293 RVA: 0x00349C20 File Offset: 0x00347E20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7FE RID: 55294 RVA: 0x000738D8 File Offset: 0x00071AD8
			public _OnNegativeBuffExecute_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004640 RID: 17984
			// (get) Token: 0x0600D7FF RID: 55295 RVA: 0x00349C60 File Offset: 0x00347E60
			// (set) Token: 0x0600D800 RID: 55296 RVA: 0x000738E1 File Offset: 0x00071AE1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004641 RID: 17985
			// (get) Token: 0x0600D801 RID: 55297 RVA: 0x00349C88 File Offset: 0x00347E88
			// (set) Token: 0x0600D802 RID: 55298 RVA: 0x000738FC File Offset: 0x00071AFC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004642 RID: 17986
			// (get) Token: 0x0600D803 RID: 55299 RVA: 0x00349CB8 File Offset: 0x00347EB8
			// (set) Token: 0x0600D804 RID: 55300 RVA: 0x0007391B File Offset: 0x00071B1B
			public unsafe Spell_Nitori __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004643 RID: 17987
			// (get) Token: 0x0600D805 RID: 55301 RVA: 0x00349CE8 File Offset: 0x00347EE8
			// (set) Token: 0x0600D806 RID: 55302 RVA: 0x0007393A File Offset: 0x00071B3A
			public unsafe Spell_Nitori.__c__DisplayClass14_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004644 RID: 17988
			// (get) Token: 0x0600D807 RID: 55303 RVA: 0x00349D18 File Offset: 0x00347F18
			// (set) Token: 0x0600D808 RID: 55304 RVA: 0x00073959 File Offset: 0x00071B59
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A72 RID: 35442
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A73 RID: 35443
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A74 RID: 35444
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A75 RID: 35445
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008A76 RID: 35446
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008A77 RID: 35447
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A78 RID: 35448
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A79 RID: 35449
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A7A RID: 35450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A7B RID: 35451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A7C RID: 35452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B78 RID: 2936
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nitori+<>c__DisplayClass15_0")]
		public new sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D809 RID: 55305 RVA: 0x00349D48 File Offset: 0x00347F48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr);
				Spell_Nitori.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				Spell_Nitori.__c__DisplayClass15_0.NativeFieldInfoPtr_armNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr, "armNum");
				Spell_Nitori.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr, 100679198);
				Spell_Nitori.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr, 100679199);
				Spell_Nitori.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr, 100679200);
			}

			// Token: 0x0600D80A RID: 55306 RVA: 0x00349DD8 File Offset: 0x00347FD8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D80B RID: 55307 RVA: 0x00349E14 File Offset: 0x00348014
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D80C RID: 55308 RVA: 0x00349E50 File Offset: 0x00348050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200718, XrefRangeEnd = 200720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D80D RID: 55309 RVA: 0x00073978 File Offset: 0x00071B78
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004647 RID: 17991
			// (get) Token: 0x0600D80E RID: 55310 RVA: 0x00349E90 File Offset: 0x00348090
			// (set) Token: 0x0600D80F RID: 55311 RVA: 0x00073981 File Offset: 0x00071B81
			public unsafe Spell_Nitori __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004648 RID: 17992
			// (get) Token: 0x0600D810 RID: 55312 RVA: 0x00349EC0 File Offset: 0x003480C0
			// (set) Token: 0x0600D811 RID: 55313 RVA: 0x000739A0 File Offset: 0x00071BA0
			public unsafe int armNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_0.NativeFieldInfoPtr_armNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_0.NativeFieldInfoPtr_armNum)) = value;
				}
			}

			// Token: 0x04008A7D RID: 35453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A7E RID: 35454
			private static readonly IntPtr NativeFieldInfoPtr_armNum;

			// Token: 0x04008A7F RID: 35455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A80 RID: 35456
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Boolean_0;

			// Token: 0x04008A81 RID: 35457
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0;
		}

		// Token: 0x02000B79 RID: 2937
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nitori+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D812 RID: 55314 RVA: 0x00349EE8 File Offset: 0x003480E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr);
				Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_partnerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, "partnerTransform");
				Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_armObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, "armObject");
				Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Nitori.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, 100679201);
				Spell_Nitori.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, 100679202);
				Spell_Nitori.__c__DisplayClass15_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, 100679203);
			}

			// Token: 0x0600D813 RID: 55315 RVA: 0x00349F8C File Offset: 0x0034818C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D814 RID: 55316 RVA: 0x00349FC8 File Offset: 0x003481C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200740, XrefRangeEnd = 200744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D815 RID: 55317 RVA: 0x0034A00C File Offset: 0x0034820C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200744, XrefRangeEnd = 200749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D816 RID: 55318 RVA: 0x000739BB File Offset: 0x00071BBB
			public __c__DisplayClass15_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004649 RID: 17993
			// (get) Token: 0x0600D817 RID: 55319 RVA: 0x0034A04C File Offset: 0x0034824C
			// (set) Token: 0x0600D818 RID: 55320 RVA: 0x000739C4 File Offset: 0x00071BC4
			public unsafe Transform partnerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_partnerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_partnerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464A RID: 17994
			// (get) Token: 0x0600D819 RID: 55321 RVA: 0x0034A07C File Offset: 0x0034827C
			// (set) Token: 0x0600D81A RID: 55322 RVA: 0x000739E3 File Offset: 0x00071BE3
			public unsafe GameObject armObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_armObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_armObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464B RID: 17995
			// (get) Token: 0x0600D81B RID: 55323 RVA: 0x0034A0AC File Offset: 0x003482AC
			// (set) Token: 0x0600D81C RID: 55324 RVA: 0x00073A02 File Offset: 0x00071C02
			public unsafe Spell_Nitori.__c__DisplayClass15_0 field_Public___c__DisplayClass15_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A82 RID: 35458
			private static readonly IntPtr NativeFieldInfoPtr_partnerTransform;

			// Token: 0x04008A83 RID: 35459
			private static readonly IntPtr NativeFieldInfoPtr_armObject;

			// Token: 0x04008A84 RID: 35460
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0;

			// Token: 0x04008A85 RID: 35461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A86 RID: 35462
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0;

			// Token: 0x04008A87 RID: 35463
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001036 RID: 4150
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nitori+<>c__DisplayClass15_1+<<OnPositiveBuffExecute>g__Delay|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C0E RID: 72718 RVA: 0x00410D50 File Offset: 0x0040EF50
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Delay|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr);
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<thisPartner>5__2");
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisArmObject_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<thisArmObject>5__3");
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100679204);
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100679205);
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100679206);
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100679207);
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100679208);
					Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100679209);
				}

				// Token: 0x06011C0F RID: 72719 RVA: 0x00410E58 File Offset: 0x0040F058
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C10 RID: 72720 RVA: 0x00410EA0 File Offset: 0x0040F0A0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C11 RID: 72721 RVA: 0x00410ED4 File Offset: 0x0040F0D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200720, XrefRangeEnd = 200734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C74 RID: 23668
				// (get) Token: 0x06011C12 RID: 72722 RVA: 0x00410F10 File Offset: 0x0040F110
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C13 RID: 72723 RVA: 0x00410F50 File Offset: 0x0040F150
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200734, XrefRangeEnd = 200740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C75 RID: 23669
				// (get) Token: 0x06011C14 RID: 72724 RVA: 0x00410F84 File Offset: 0x0040F184
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C15 RID: 72725 RVA: 0x0009A4DF File Offset: 0x000986DF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C6F RID: 23663
				// (get) Token: 0x06011C16 RID: 72726 RVA: 0x00410FC4 File Offset: 0x0040F1C4
				// (set) Token: 0x06011C17 RID: 72727 RVA: 0x0009A4E8 File Offset: 0x000986E8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C70 RID: 23664
				// (get) Token: 0x06011C18 RID: 72728 RVA: 0x00410FEC File Offset: 0x0040F1EC
				// (set) Token: 0x06011C19 RID: 72729 RVA: 0x0009A503 File Offset: 0x00098703
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C71 RID: 23665
				// (get) Token: 0x06011C1A RID: 72730 RVA: 0x0041101C File Offset: 0x0040F21C
				// (set) Token: 0x06011C1B RID: 72731 RVA: 0x0009A522 File Offset: 0x00098722
				public unsafe Spell_Nitori.__c__DisplayClass15_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori.__c__DisplayClass15_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C72 RID: 23666
				// (get) Token: 0x06011C1C RID: 72732 RVA: 0x0041104C File Offset: 0x0040F24C
				// (set) Token: 0x06011C1D RID: 72733 RVA: 0x0009A541 File Offset: 0x00098741
				public unsafe Transform _thisPartner_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C73 RID: 23667
				// (get) Token: 0x06011C1E RID: 72734 RVA: 0x0041107C File Offset: 0x0040F27C
				// (set) Token: 0x06011C1F RID: 72735 RVA: 0x0009A560 File Offset: 0x00098760
				public unsafe GameObject _thisArmObject_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisArmObject_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori.__c__DisplayClass15_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisArmObject_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B374 RID: 45940
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B375 RID: 45941
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B376 RID: 45942
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B377 RID: 45943
				private static readonly IntPtr NativeFieldInfoPtr__thisPartner_5__2;

				// Token: 0x0400B378 RID: 45944
				private static readonly IntPtr NativeFieldInfoPtr__thisArmObject_5__3;

				// Token: 0x0400B379 RID: 45945
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B37A RID: 45946
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B37B RID: 45947
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B37C RID: 45948
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B37D RID: 45949
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B37E RID: 45950
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B7A RID: 2938
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Nitori+<OnPositiveBuffExecute>d__15")]
		public sealed class _OnPositiveBuffExecute_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600D81D RID: 55325 RVA: 0x0034A0DC File Offset: 0x003482DC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__15()
			{
				Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Nitori>.NativeClassPtr, "<OnPositiveBuffExecute>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr);
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>1__state");
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>2__current");
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>4__this");
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>8__1");
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679210);
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679211);
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679212);
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679213);
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679214);
				Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679215);
			}

			// Token: 0x0600D81E RID: 55326 RVA: 0x0034A1D0 File Offset: 0x003483D0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Nitori._OnPositiveBuffExecute_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D81F RID: 55327 RVA: 0x0034A218 File Offset: 0x00348418
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D820 RID: 55328 RVA: 0x0034A24C File Offset: 0x0034844C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200749, XrefRangeEnd = 200782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004650 RID: 18000
			// (get) Token: 0x0600D821 RID: 55329 RVA: 0x0034A288 File Offset: 0x00348488
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D822 RID: 55330 RVA: 0x0034A2C8 File Offset: 0x003484C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200782, XrefRangeEnd = 200788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004651 RID: 18001
			// (get) Token: 0x0600D823 RID: 55331 RVA: 0x0034A2FC File Offset: 0x003484FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D824 RID: 55332 RVA: 0x00073A21 File Offset: 0x00071C21
			public _OnPositiveBuffExecute_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700464C RID: 17996
			// (get) Token: 0x0600D825 RID: 55333 RVA: 0x0034A33C File Offset: 0x0034853C
			// (set) Token: 0x0600D826 RID: 55334 RVA: 0x00073A2A File Offset: 0x00071C2A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700464D RID: 17997
			// (get) Token: 0x0600D827 RID: 55335 RVA: 0x0034A364 File Offset: 0x00348564
			// (set) Token: 0x0600D828 RID: 55336 RVA: 0x00073A45 File Offset: 0x00071C45
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464E RID: 17998
			// (get) Token: 0x0600D829 RID: 55337 RVA: 0x0034A394 File Offset: 0x00348594
			// (set) Token: 0x0600D82A RID: 55338 RVA: 0x00073A64 File Offset: 0x00071C64
			public unsafe Spell_Nitori __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464F RID: 17999
			// (get) Token: 0x0600D82B RID: 55339 RVA: 0x0034A3C4 File Offset: 0x003485C4
			// (set) Token: 0x0600D82C RID: 55340 RVA: 0x00073A83 File Offset: 0x00071C83
			public unsafe Spell_Nitori.__c__DisplayClass15_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Nitori.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Nitori._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A88 RID: 35464
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A89 RID: 35465
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A8A RID: 35466
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A8B RID: 35467
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008A8C RID: 35468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A8D RID: 35469
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A8E RID: 35470
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A8F RID: 35471
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A90 RID: 35472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A91 RID: 35473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
