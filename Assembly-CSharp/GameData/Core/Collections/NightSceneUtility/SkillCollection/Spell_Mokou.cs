using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000272 RID: 626
	public class Spell_Mokou : SpellBase
	{
		// Token: 0x06004E82 RID: 20098 RVA: 0x001AC088 File Offset: 0x001AA288
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Mokou()
		{
			Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Mokou");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr);
			Spell_Mokou.NativeFieldInfoPtr_cookTimeEditMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "cookTimeEditMultiplier");
			Spell_Mokou.NativeFieldInfoPtr_fireDurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "fireDurationSec");
			Spell_Mokou.NativeFieldInfoPtr_maxEvalLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "maxEvalLevel");
			Spell_Mokou.NativeFieldInfoPtr_negativeDurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "negativeDurationSec");
			Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "fireBirdEffectA");
			Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "fireBirdEffectOffset");
			Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "fireBirdEffectB");
			Spell_Mokou.NativeFieldInfoPtr_fireBirdEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "fireBirdEffect");
			Spell_Mokou.NativeFieldInfoPtr_positiveEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "positiveEffectDuration");
			Spell_Mokou.NativeFieldInfoPtr_evalOverrideEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "evalOverrideEffect");
			Spell_Mokou.NativeFieldInfoPtr_negativeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "negativeEffectDuration");
			Spell_Mokou.NativeFieldInfoPtr_negativeEffectAppearSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "negativeEffectAppearSFX");
			Spell_Mokou.NativeFieldInfoPtr_negativeEffectSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "negativeEffectSFX");
			Spell_Mokou.NativeFieldInfoPtr_negativeEffectSFXDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "negativeEffectSFXDelay");
			Spell_Mokou.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, 100679072);
			Spell_Mokou.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, 100679073);
			Spell_Mokou.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, 100679074);
			Spell_Mokou.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, 100679075);
			Spell_Mokou.NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, 100679076);
			Spell_Mokou.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, 100679077);
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x001AC248 File Offset: 0x001AA448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200270, XrefRangeEnd = 200272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mokou.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x001AC28C File Offset: 0x001AA48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200272, XrefRangeEnd = 200277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mokou.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x001AC2E8 File Offset: 0x001AA4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200277, XrefRangeEnd = 200282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mokou.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x001AC344 File Offset: 0x001AA544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Mokou() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x001AC380 File Offset: 0x001AA580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200282, XrefRangeEnd = 200296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Method_Private_String_Int32_String_PDM_0(int currentTime, string buffDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou.NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x001AC3D8 File Offset: 0x001AA5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200296, XrefRangeEnd = 200309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__16_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x00029234 File Offset: 0x00027434
		public Spell_Mokou(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x001AC418 File Offset: 0x001AA618
		// (set) Token: 0x06004E8B RID: 20107 RVA: 0x0002923D File Offset: 0x0002743D
		public unsafe float cookTimeEditMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_cookTimeEditMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_cookTimeEditMultiplier)) = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06004E8C RID: 20108 RVA: 0x001AC440 File Offset: 0x001AA640
		// (set) Token: 0x06004E8D RID: 20109 RVA: 0x00029258 File Offset: 0x00027458
		public unsafe int fireDurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireDurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireDurationSec)) = value;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x001AC468 File Offset: 0x001AA668
		// (set) Token: 0x06004E8F RID: 20111 RVA: 0x00029273 File Offset: 0x00027473
		public unsafe int maxEvalLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_maxEvalLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_maxEvalLevel)) = value;
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06004E90 RID: 20112 RVA: 0x001AC490 File Offset: 0x001AA690
		// (set) Token: 0x06004E91 RID: 20113 RVA: 0x0002928E File Offset: 0x0002748E
		public unsafe int negativeDurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeDurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeDurationSec)) = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06004E92 RID: 20114 RVA: 0x001AC4B8 File Offset: 0x001AA6B8
		// (set) Token: 0x06004E93 RID: 20115 RVA: 0x000292A9 File Offset: 0x000274A9
		public unsafe AudioClip fireBirdEffectA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06004E94 RID: 20116 RVA: 0x001AC4E8 File Offset: 0x001AA6E8
		// (set) Token: 0x06004E95 RID: 20117 RVA: 0x000292C8 File Offset: 0x000274C8
		public unsafe float fireBirdEffectOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectOffset)) = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06004E96 RID: 20118 RVA: 0x001AC510 File Offset: 0x001AA710
		// (set) Token: 0x06004E97 RID: 20119 RVA: 0x000292E3 File Offset: 0x000274E3
		public unsafe AudioClip fireBirdEffectB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffectB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x001AC540 File Offset: 0x001AA740
		// (set) Token: 0x06004E99 RID: 20121 RVA: 0x00029302 File Offset: 0x00027502
		public unsafe GameObject fireBirdEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_fireBirdEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x001AC570 File Offset: 0x001AA770
		// (set) Token: 0x06004E9B RID: 20123 RVA: 0x00029321 File Offset: 0x00027521
		public unsafe float positiveEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_positiveEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_positiveEffectDuration)) = value;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06004E9C RID: 20124 RVA: 0x001AC598 File Offset: 0x001AA798
		// (set) Token: 0x06004E9D RID: 20125 RVA: 0x0002933C File Offset: 0x0002753C
		public unsafe GameObject evalOverrideEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_evalOverrideEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_evalOverrideEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06004E9E RID: 20126 RVA: 0x001AC5C8 File Offset: 0x001AA7C8
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x0002935B File Offset: 0x0002755B
		public unsafe float negativeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectDuration)) = value;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x001AC5F0 File Offset: 0x001AA7F0
		// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x00029376 File Offset: 0x00027576
		public unsafe AudioClip negativeEffectAppearSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectAppearSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectAppearSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x001AC620 File Offset: 0x001AA820
		// (set) Token: 0x06004EA3 RID: 20131 RVA: 0x00029395 File Offset: 0x00027595
		public unsafe AudioClip negativeEffectSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x001AC650 File Offset: 0x001AA850
		// (set) Token: 0x06004EA5 RID: 20133 RVA: 0x000293B4 File Offset: 0x000275B4
		public unsafe float negativeEffectSFXDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectSFXDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou.NativeFieldInfoPtr_negativeEffectSFXDelay)) = value;
			}
		}

		// Token: 0x0400356C RID: 13676
		private static readonly IntPtr NativeFieldInfoPtr_cookTimeEditMultiplier;

		// Token: 0x0400356D RID: 13677
		private static readonly IntPtr NativeFieldInfoPtr_fireDurationSec;

		// Token: 0x0400356E RID: 13678
		private static readonly IntPtr NativeFieldInfoPtr_maxEvalLevel;

		// Token: 0x0400356F RID: 13679
		private static readonly IntPtr NativeFieldInfoPtr_negativeDurationSec;

		// Token: 0x04003570 RID: 13680
		private static readonly IntPtr NativeFieldInfoPtr_fireBirdEffectA;

		// Token: 0x04003571 RID: 13681
		private static readonly IntPtr NativeFieldInfoPtr_fireBirdEffectOffset;

		// Token: 0x04003572 RID: 13682
		private static readonly IntPtr NativeFieldInfoPtr_fireBirdEffectB;

		// Token: 0x04003573 RID: 13683
		private static readonly IntPtr NativeFieldInfoPtr_fireBirdEffect;

		// Token: 0x04003574 RID: 13684
		private static readonly IntPtr NativeFieldInfoPtr_positiveEffectDuration;

		// Token: 0x04003575 RID: 13685
		private static readonly IntPtr NativeFieldInfoPtr_evalOverrideEffect;

		// Token: 0x04003576 RID: 13686
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectDuration;

		// Token: 0x04003577 RID: 13687
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectAppearSFX;

		// Token: 0x04003578 RID: 13688
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectSFX;

		// Token: 0x04003579 RID: 13689
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectSFXDelay;

		// Token: 0x0400357A RID: 13690
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400357B RID: 13691
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400357C RID: 13692
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400357D RID: 13693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400357E RID: 13694
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_0;

		// Token: 0x0400357F RID: 13695
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_1_Private_Void_Int32_0;

		// Token: 0x02000B66 RID: 2918
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mokou+<OnNegativeBuffExecute>d__15")]
		public sealed class _OnNegativeBuffExecute_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600D71E RID: 55070 RVA: 0x003471D8 File Offset: 0x003453D8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__15()
			{
				Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "<OnNegativeBuffExecute>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr);
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>1__state");
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>2__current");
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>4__this");
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100679078);
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100679079);
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100679080);
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100679081);
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100679082);
				Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100679083);
			}

			// Token: 0x0600D71F RID: 55071 RVA: 0x003472B8 File Offset: 0x003454B8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mokou._OnNegativeBuffExecute_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D720 RID: 55072 RVA: 0x00347300 File Offset: 0x00345500
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D721 RID: 55073 RVA: 0x00347334 File Offset: 0x00345534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200248, XrefRangeEnd = 200249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045FC RID: 17916
			// (get) Token: 0x0600D722 RID: 55074 RVA: 0x00347370 File Offset: 0x00345570
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D723 RID: 55075 RVA: 0x003473B0 File Offset: 0x003455B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200249, XrefRangeEnd = 200255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045FD RID: 17917
			// (get) Token: 0x0600D724 RID: 55076 RVA: 0x003473E4 File Offset: 0x003455E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D725 RID: 55077 RVA: 0x0007321D File Offset: 0x0007141D
			public _OnNegativeBuffExecute_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F9 RID: 17913
			// (get) Token: 0x0600D726 RID: 55078 RVA: 0x00347424 File Offset: 0x00345624
			// (set) Token: 0x0600D727 RID: 55079 RVA: 0x00073226 File Offset: 0x00071426
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045FA RID: 17914
			// (get) Token: 0x0600D728 RID: 55080 RVA: 0x0034744C File Offset: 0x0034564C
			// (set) Token: 0x0600D729 RID: 55081 RVA: 0x00073241 File Offset: 0x00071441
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045FB RID: 17915
			// (get) Token: 0x0600D72A RID: 55082 RVA: 0x0034747C File Offset: 0x0034567C
			// (set) Token: 0x0600D72B RID: 55083 RVA: 0x00073260 File Offset: 0x00071460
			public unsafe Spell_Mokou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mokou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089F2 RID: 35314
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089F3 RID: 35315
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089F4 RID: 35316
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089F5 RID: 35317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089F6 RID: 35318
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089F7 RID: 35319
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089F8 RID: 35320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089F9 RID: 35321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089FA RID: 35322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B67 RID: 2919
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mokou+<OnPositiveBuffExecute>d__16")]
		public sealed class _OnPositiveBuffExecute_d__16 : Il2CppSystem.Object
		{
			// Token: 0x0600D72C RID: 55084 RVA: 0x003474AC File Offset: 0x003456AC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__16()
			{
				Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mokou>.NativeClassPtr, "<OnPositiveBuffExecute>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr);
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>1__state");
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>2__current");
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>4__this");
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679084);
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679085);
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679086);
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679087);
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679088);
				Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679089);
			}

			// Token: 0x0600D72D RID: 55085 RVA: 0x0034758C File Offset: 0x0034578C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mokou._OnPositiveBuffExecute_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D72E RID: 55086 RVA: 0x003475D4 File Offset: 0x003457D4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D72F RID: 55087 RVA: 0x00347608 File Offset: 0x00345808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200255, XrefRangeEnd = 200264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004601 RID: 17921
			// (get) Token: 0x0600D730 RID: 55088 RVA: 0x00347644 File Offset: 0x00345844
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D731 RID: 55089 RVA: 0x00347684 File Offset: 0x00345884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200264, XrefRangeEnd = 200270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004602 RID: 17922
			// (get) Token: 0x0600D732 RID: 55090 RVA: 0x003476B8 File Offset: 0x003458B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D733 RID: 55091 RVA: 0x0007327F File Offset: 0x0007147F
			public _OnPositiveBuffExecute_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045FE RID: 17918
			// (get) Token: 0x0600D734 RID: 55092 RVA: 0x003476F8 File Offset: 0x003458F8
			// (set) Token: 0x0600D735 RID: 55093 RVA: 0x00073288 File Offset: 0x00071488
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045FF RID: 17919
			// (get) Token: 0x0600D736 RID: 55094 RVA: 0x00347720 File Offset: 0x00345920
			// (set) Token: 0x0600D737 RID: 55095 RVA: 0x000732A3 File Offset: 0x000714A3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004600 RID: 17920
			// (get) Token: 0x0600D738 RID: 55096 RVA: 0x00347750 File Offset: 0x00345950
			// (set) Token: 0x0600D739 RID: 55097 RVA: 0x000732C2 File Offset: 0x000714C2
			public unsafe Spell_Mokou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mokou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mokou._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089FB RID: 35323
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089FC RID: 35324
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089FD RID: 35325
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089FE RID: 35326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089FF RID: 35327
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A00 RID: 35328
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A01 RID: 35329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A02 RID: 35330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A03 RID: 35331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
