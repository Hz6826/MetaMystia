using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000273 RID: 627
	public class Spell_Momizi : SpellBase
	{
		// Token: 0x06004EA6 RID: 20134 RVA: 0x001AC678 File Offset: 0x001AA878
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Momizi()
		{
			Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Momizi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr);
			Spell_Momizi.NativeFieldInfoPtr_TENGU_GUEST_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "TENGU_GUEST_ID");
			Spell_Momizi.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "positiveDuration");
			Spell_Momizi.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "negativeDuration");
			Spell_Momizi.NativeFieldInfoPtr_tenguGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "tenguGuestNum");
			Spell_Momizi.NativeFieldInfoPtr_cardObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "cardObject");
			Spell_Momizi.NativeFieldInfoPtr_cardDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "cardDuration");
			Spell_Momizi.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "rewardSFX");
			Spell_Momizi.NativeFieldInfoPtr_roadClosedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "roadClosedObject");
			Spell_Momizi.NativeFieldInfoPtr_roadClosedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "roadClosedDuration");
			Spell_Momizi.NativeFieldInfoPtr_cameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "cameraShakeAmplitude");
			Spell_Momizi.NativeFieldInfoPtr_cameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "cameraShakeDuration");
			Spell_Momizi.NativeFieldInfoPtr_cameraShakeFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "cameraShakeFade");
			Spell_Momizi.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "punishmentSFX");
			Spell_Momizi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, 100679090);
			Spell_Momizi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, 100679091);
			Spell_Momizi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, 100679092);
			Spell_Momizi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, 100679093);
			Spell_Momizi.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, 100679094);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x001AC810 File Offset: 0x001AAA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200340, XrefRangeEnd = 200342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Momizi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x001AC854 File Offset: 0x001AAA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200342, XrefRangeEnd = 200347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Momizi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x001AC8B0 File Offset: 0x001AAAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200347, XrefRangeEnd = 200352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Momizi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x001AC90C File Offset: 0x001AAB0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Momizi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x001AC948 File Offset: 0x001AAB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200352, XrefRangeEnd = 200355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__15_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x000293CF File Offset: 0x000275CF
		public Spell_Momizi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06004EAD RID: 20141 RVA: 0x001AC988 File Offset: 0x001AAB88
		// (set) Token: 0x06004EAE RID: 20142 RVA: 0x000293D8 File Offset: 0x000275D8
		public unsafe static int TENGU_GUEST_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Momizi.NativeFieldInfoPtr_TENGU_GUEST_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Momizi.NativeFieldInfoPtr_TENGU_GUEST_ID, (void*)(&value));
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x001AC9A4 File Offset: 0x001AABA4
		// (set) Token: 0x06004EB0 RID: 20144 RVA: 0x000293E6 File Offset: 0x000275E6
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06004EB1 RID: 20145 RVA: 0x001AC9CC File Offset: 0x001AABCC
		// (set) Token: 0x06004EB2 RID: 20146 RVA: 0x00029401 File Offset: 0x00027601
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x001AC9F4 File Offset: 0x001AABF4
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x0002941C File Offset: 0x0002761C
		public unsafe int tenguGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_tenguGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_tenguGuestNum)) = value;
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x001ACA1C File Offset: 0x001AAC1C
		// (set) Token: 0x06004EB6 RID: 20150 RVA: 0x00029437 File Offset: 0x00027637
		public unsafe GameObject cardObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cardObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cardObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x001ACA4C File Offset: 0x001AAC4C
		// (set) Token: 0x06004EB8 RID: 20152 RVA: 0x00029456 File Offset: 0x00027656
		public unsafe float cardDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cardDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cardDuration)) = value;
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x001ACA74 File Offset: 0x001AAC74
		// (set) Token: 0x06004EBA RID: 20154 RVA: 0x00029471 File Offset: 0x00027671
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x001ACAA4 File Offset: 0x001AACA4
		// (set) Token: 0x06004EBC RID: 20156 RVA: 0x00029490 File Offset: 0x00027690
		public unsafe GameObject roadClosedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_roadClosedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_roadClosedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x001ACAD4 File Offset: 0x001AACD4
		// (set) Token: 0x06004EBE RID: 20158 RVA: 0x000294AF File Offset: 0x000276AF
		public unsafe float roadClosedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_roadClosedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_roadClosedDuration)) = value;
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x001ACAFC File Offset: 0x001AACFC
		// (set) Token: 0x06004EC0 RID: 20160 RVA: 0x000294CA File Offset: 0x000276CA
		public unsafe float cameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x001ACB24 File Offset: 0x001AAD24
		// (set) Token: 0x06004EC2 RID: 20162 RVA: 0x000294E5 File Offset: 0x000276E5
		public unsafe float cameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cameraShakeDuration)) = value;
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x001ACB4C File Offset: 0x001AAD4C
		// (set) Token: 0x06004EC4 RID: 20164 RVA: 0x00029500 File Offset: 0x00027700
		public unsafe float cameraShakeFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cameraShakeFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_cameraShakeFade)) = value;
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x001ACB74 File Offset: 0x001AAD74
		// (set) Token: 0x06004EC6 RID: 20166 RVA: 0x0002951B File Offset: 0x0002771B
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003580 RID: 13696
		private static readonly IntPtr NativeFieldInfoPtr_TENGU_GUEST_ID;

		// Token: 0x04003581 RID: 13697
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003582 RID: 13698
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003583 RID: 13699
		private static readonly IntPtr NativeFieldInfoPtr_tenguGuestNum;

		// Token: 0x04003584 RID: 13700
		private static readonly IntPtr NativeFieldInfoPtr_cardObject;

		// Token: 0x04003585 RID: 13701
		private static readonly IntPtr NativeFieldInfoPtr_cardDuration;

		// Token: 0x04003586 RID: 13702
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x04003587 RID: 13703
		private static readonly IntPtr NativeFieldInfoPtr_roadClosedObject;

		// Token: 0x04003588 RID: 13704
		private static readonly IntPtr NativeFieldInfoPtr_roadClosedDuration;

		// Token: 0x04003589 RID: 13705
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeAmplitude;

		// Token: 0x0400358A RID: 13706
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeDuration;

		// Token: 0x0400358B RID: 13707
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeFade;

		// Token: 0x0400358C RID: 13708
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x0400358D RID: 13709
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400358E RID: 13710
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400358F RID: 13711
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003590 RID: 13712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003591 RID: 13713
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_1_Private_Void_Int32_0;

		// Token: 0x02000B68 RID: 2920
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Momizi+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D73A RID: 55098 RVA: 0x00347780 File Offset: 0x00345980
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr);
				Spell_Momizi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr, "<>9");
				Spell_Momizi.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr, "<>9__14_0");
				Spell_Momizi.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr, "<>9__15_0");
				Spell_Momizi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr, 100679096);
				Spell_Momizi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr, 100679097);
				Spell_Momizi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr, 100679098);
			}

			// Token: 0x0600D73B RID: 55099 RVA: 0x00347824 File Offset: 0x00345A24
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Momizi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D73C RID: 55100 RVA: 0x00347860 File Offset: 0x00345A60
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__14_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D73D RID: 55101 RVA: 0x003478A4 File Offset: 0x00345AA4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__15_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D73E RID: 55102 RVA: 0x000732E1 File Offset: 0x000714E1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004603 RID: 17923
			// (get) Token: 0x0600D73F RID: 55103 RVA: 0x003478E8 File Offset: 0x00345AE8
			// (set) Token: 0x0600D740 RID: 55104 RVA: 0x000732EA File Offset: 0x000714EA
			public unsafe static Spell_Momizi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Momizi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Momizi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Momizi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004604 RID: 17924
			// (get) Token: 0x0600D741 RID: 55105 RVA: 0x00347910 File Offset: 0x00345B10
			// (set) Token: 0x0600D742 RID: 55106 RVA: 0x000732FC File Offset: 0x000714FC
			public unsafe static Action<GameObject> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Momizi.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Momizi.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004605 RID: 17925
			// (get) Token: 0x0600D743 RID: 55107 RVA: 0x00347938 File Offset: 0x00345B38
			// (set) Token: 0x0600D744 RID: 55108 RVA: 0x0007330E File Offset: 0x0007150E
			public unsafe static Action<GameObject> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Momizi.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Momizi.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A04 RID: 35332
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A05 RID: 35333
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04008A06 RID: 35334
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04008A07 RID: 35335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A08 RID: 35336
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_GameObject_0;

			// Token: 0x04008A09 RID: 35337
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_0_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B69 RID: 2921
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Momizi+<OnNegativeBuffExecute>d__14")]
		public sealed class _OnNegativeBuffExecute_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D745 RID: 55109 RVA: 0x00347960 File Offset: 0x00345B60
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__14()
			{
				Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "<OnNegativeBuffExecute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr);
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>1__state");
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>2__current");
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>4__this");
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679099);
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679100);
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679101);
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679102);
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679103);
				Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679104);
			}

			// Token: 0x0600D746 RID: 55110 RVA: 0x00347A40 File Offset: 0x00345C40
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Momizi._OnNegativeBuffExecute_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D747 RID: 55111 RVA: 0x00347A88 File Offset: 0x00345C88
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D748 RID: 55112 RVA: 0x00347ABC File Offset: 0x00345CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200309, XrefRangeEnd = 200316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004609 RID: 17929
			// (get) Token: 0x0600D749 RID: 55113 RVA: 0x00347AF8 File Offset: 0x00345CF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D74A RID: 55114 RVA: 0x00347B38 File Offset: 0x00345D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200316, XrefRangeEnd = 200322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700460A RID: 17930
			// (get) Token: 0x0600D74B RID: 55115 RVA: 0x00347B6C File Offset: 0x00345D6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D74C RID: 55116 RVA: 0x00073320 File Offset: 0x00071520
			public _OnNegativeBuffExecute_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004606 RID: 17926
			// (get) Token: 0x0600D74D RID: 55117 RVA: 0x00347BAC File Offset: 0x00345DAC
			// (set) Token: 0x0600D74E RID: 55118 RVA: 0x00073329 File Offset: 0x00071529
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004607 RID: 17927
			// (get) Token: 0x0600D74F RID: 55119 RVA: 0x00347BD4 File Offset: 0x00345DD4
			// (set) Token: 0x0600D750 RID: 55120 RVA: 0x00073344 File Offset: 0x00071544
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004608 RID: 17928
			// (get) Token: 0x0600D751 RID: 55121 RVA: 0x00347C04 File Offset: 0x00345E04
			// (set) Token: 0x0600D752 RID: 55122 RVA: 0x00073363 File Offset: 0x00071563
			public unsafe Spell_Momizi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Momizi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A0A RID: 35338
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A0B RID: 35339
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A0C RID: 35340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A0D RID: 35341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A0E RID: 35342
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A0F RID: 35343
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A10 RID: 35344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A11 RID: 35345
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A12 RID: 35346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6A RID: 2922
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Momizi+<OnPositiveBuffExecute>d__15")]
		public sealed class _OnPositiveBuffExecute_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600D753 RID: 55123 RVA: 0x00347C34 File Offset: 0x00345E34
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__15()
			{
				Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Momizi>.NativeClassPtr, "<OnPositiveBuffExecute>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr);
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>1__state");
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>2__current");
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>4__this");
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679105);
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679106);
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679107);
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679108);
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679109);
				Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679110);
			}

			// Token: 0x0600D754 RID: 55124 RVA: 0x00347D14 File Offset: 0x00345F14
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Momizi._OnPositiveBuffExecute_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D755 RID: 55125 RVA: 0x00347D5C File Offset: 0x00345F5C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D756 RID: 55126 RVA: 0x00347D90 File Offset: 0x00345F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200322, XrefRangeEnd = 200334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700460E RID: 17934
			// (get) Token: 0x0600D757 RID: 55127 RVA: 0x00347DCC File Offset: 0x00345FCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D758 RID: 55128 RVA: 0x00347E0C File Offset: 0x0034600C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200334, XrefRangeEnd = 200340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700460F RID: 17935
			// (get) Token: 0x0600D759 RID: 55129 RVA: 0x00347E40 File Offset: 0x00346040
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D75A RID: 55130 RVA: 0x00073382 File Offset: 0x00071582
			public _OnPositiveBuffExecute_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700460B RID: 17931
			// (get) Token: 0x0600D75B RID: 55131 RVA: 0x00347E80 File Offset: 0x00346080
			// (set) Token: 0x0600D75C RID: 55132 RVA: 0x0007338B File Offset: 0x0007158B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700460C RID: 17932
			// (get) Token: 0x0600D75D RID: 55133 RVA: 0x00347EA8 File Offset: 0x003460A8
			// (set) Token: 0x0600D75E RID: 55134 RVA: 0x000733A6 File Offset: 0x000715A6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460D RID: 17933
			// (get) Token: 0x0600D75F RID: 55135 RVA: 0x00347ED8 File Offset: 0x003460D8
			// (set) Token: 0x0600D760 RID: 55136 RVA: 0x000733C5 File Offset: 0x000715C5
			public unsafe Spell_Momizi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Momizi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Momizi._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A13 RID: 35347
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A14 RID: 35348
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A15 RID: 35349
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A16 RID: 35350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A17 RID: 35351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A18 RID: 35352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A19 RID: 35353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A1A RID: 35354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A1B RID: 35355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
