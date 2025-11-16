using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200026A RID: 618
	public class Spell_Kogasa : SpellBase
	{
		// Token: 0x06004CF5 RID: 19701 RVA: 0x001A83E4 File Offset: 0x001A65E4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Kogasa()
		{
			Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Kogasa");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr);
			Spell_Kogasa.NativeFieldInfoPtr_weirdoTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "weirdoTag");
			Spell_Kogasa.NativeFieldInfoPtr_weirdoFoodCookSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "weirdoFoodCookSpeedModifier");
			Spell_Kogasa.NativeFieldInfoPtr_weirdoFoodExtraOrderRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "weirdoFoodExtraOrderRate");
			Spell_Kogasa.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "positiveDuration");
			Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "umbrellaShakeAmplitude");
			Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "umbrellaShakeDuration");
			Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeEndDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "umbrellaShakeEndDuration");
			Spell_Kogasa.NativeFieldInfoPtr_rainEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "rainEffect");
			Spell_Kogasa.NativeFieldInfoPtr_itemEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "itemEffect");
			Spell_Kogasa.NativeFieldInfoPtr_fogEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "fogEffect");
			Spell_Kogasa.NativeFieldInfoPtr_cloudEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "cloudEffect");
			Spell_Kogasa.NativeFieldInfoPtr_gengarEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "gengarEffect");
			Spell_Kogasa.NativeFieldInfoPtr_rainSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "rainSFX");
			Spell_Kogasa.NativeFieldInfoPtr_itemSpawnSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "itemSpawnSFX");
			Spell_Kogasa.NativeFieldInfoPtr_throwBallSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "throwBallSFX");
			Spell_Kogasa.NativeFieldInfoPtr_gengarSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "gengarSFX");
			Spell_Kogasa.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, 100678757);
			Spell_Kogasa.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, 100678758);
			Spell_Kogasa.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, 100678759);
			Spell_Kogasa.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, 100678760);
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x001A85A4 File Offset: 0x001A67A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197855, XrefRangeEnd = 197857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kogasa.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x001A85E8 File Offset: 0x001A67E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197857, XrefRangeEnd = 197863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kogasa.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x001A8644 File Offset: 0x001A6844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197863, XrefRangeEnd = 197869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kogasa.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x001A86A0 File Offset: 0x001A68A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197869, XrefRangeEnd = 197870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Kogasa() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x00027EF4 File Offset: 0x000260F4
		public Spell_Kogasa(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x001A86DC File Offset: 0x001A68DC
		// (set) Token: 0x06004CFC RID: 19708 RVA: 0x00027EFD File Offset: 0x000260FD
		public unsafe int weirdoTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_weirdoTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_weirdoTag)) = value;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x001A8704 File Offset: 0x001A6904
		// (set) Token: 0x06004CFE RID: 19710 RVA: 0x00027F18 File Offset: 0x00026118
		public unsafe float weirdoFoodCookSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_weirdoFoodCookSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_weirdoFoodCookSpeedModifier)) = value;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x001A872C File Offset: 0x001A692C
		// (set) Token: 0x06004D00 RID: 19712 RVA: 0x00027F33 File Offset: 0x00026133
		public unsafe float weirdoFoodExtraOrderRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_weirdoFoodExtraOrderRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_weirdoFoodExtraOrderRate)) = value;
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x001A8754 File Offset: 0x001A6954
		// (set) Token: 0x06004D02 RID: 19714 RVA: 0x00027F4E File Offset: 0x0002614E
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x001A877C File Offset: 0x001A697C
		// (set) Token: 0x06004D04 RID: 19716 RVA: 0x00027F69 File Offset: 0x00026169
		public unsafe float umbrellaShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeAmplitude)) = value;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x001A87A4 File Offset: 0x001A69A4
		// (set) Token: 0x06004D06 RID: 19718 RVA: 0x00027F84 File Offset: 0x00026184
		public unsafe float umbrellaShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeDuration)) = value;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x001A87CC File Offset: 0x001A69CC
		// (set) Token: 0x06004D08 RID: 19720 RVA: 0x00027F9F File Offset: 0x0002619F
		public unsafe float umbrellaShakeEndDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeEndDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_umbrellaShakeEndDuration)) = value;
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x001A87F4 File Offset: 0x001A69F4
		// (set) Token: 0x06004D0A RID: 19722 RVA: 0x00027FBA File Offset: 0x000261BA
		public unsafe GameObject rainEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_rainEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_rainEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x001A8824 File Offset: 0x001A6A24
		// (set) Token: 0x06004D0C RID: 19724 RVA: 0x00027FD9 File Offset: 0x000261D9
		public unsafe GameObject itemEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_itemEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_itemEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06004D0D RID: 19725 RVA: 0x001A8854 File Offset: 0x001A6A54
		// (set) Token: 0x06004D0E RID: 19726 RVA: 0x00027FF8 File Offset: 0x000261F8
		public unsafe GameObject fogEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_fogEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_fogEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x001A8884 File Offset: 0x001A6A84
		// (set) Token: 0x06004D10 RID: 19728 RVA: 0x00028017 File Offset: 0x00026217
		public unsafe GameObject cloudEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_cloudEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_cloudEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x001A88B4 File Offset: 0x001A6AB4
		// (set) Token: 0x06004D12 RID: 19730 RVA: 0x00028036 File Offset: 0x00026236
		public unsafe GameObject gengarEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_gengarEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_gengarEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06004D13 RID: 19731 RVA: 0x001A88E4 File Offset: 0x001A6AE4
		// (set) Token: 0x06004D14 RID: 19732 RVA: 0x00028055 File Offset: 0x00026255
		public unsafe AudioClip rainSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_rainSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_rainSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x001A8914 File Offset: 0x001A6B14
		// (set) Token: 0x06004D16 RID: 19734 RVA: 0x00028074 File Offset: 0x00026274
		public SpellBase.DelayAudioClip itemSpawnSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_itemSpawnSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_itemSpawnSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x001A8944 File Offset: 0x001A6B44
		// (set) Token: 0x06004D18 RID: 19736 RVA: 0x000280A2 File Offset: 0x000262A2
		public unsafe AudioClip throwBallSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_throwBallSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_throwBallSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x001A8974 File Offset: 0x001A6B74
		// (set) Token: 0x06004D1A RID: 19738 RVA: 0x000280C1 File Offset: 0x000262C1
		public SpellBase.DelayAudioClip gengarSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_gengarSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.NativeFieldInfoPtr_gengarSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003494 RID: 13460
		private static readonly IntPtr NativeFieldInfoPtr_weirdoTag;

		// Token: 0x04003495 RID: 13461
		private static readonly IntPtr NativeFieldInfoPtr_weirdoFoodCookSpeedModifier;

		// Token: 0x04003496 RID: 13462
		private static readonly IntPtr NativeFieldInfoPtr_weirdoFoodExtraOrderRate;

		// Token: 0x04003497 RID: 13463
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003498 RID: 13464
		private static readonly IntPtr NativeFieldInfoPtr_umbrellaShakeAmplitude;

		// Token: 0x04003499 RID: 13465
		private static readonly IntPtr NativeFieldInfoPtr_umbrellaShakeDuration;

		// Token: 0x0400349A RID: 13466
		private static readonly IntPtr NativeFieldInfoPtr_umbrellaShakeEndDuration;

		// Token: 0x0400349B RID: 13467
		private static readonly IntPtr NativeFieldInfoPtr_rainEffect;

		// Token: 0x0400349C RID: 13468
		private static readonly IntPtr NativeFieldInfoPtr_itemEffect;

		// Token: 0x0400349D RID: 13469
		private static readonly IntPtr NativeFieldInfoPtr_fogEffect;

		// Token: 0x0400349E RID: 13470
		private static readonly IntPtr NativeFieldInfoPtr_cloudEffect;

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeFieldInfoPtr_gengarEffect;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeFieldInfoPtr_rainSFX;

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeFieldInfoPtr_itemSpawnSFX;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeFieldInfoPtr_throwBallSFX;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeFieldInfoPtr_gengarSFX;

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B37 RID: 2871
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kogasa+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D485 RID: 54405 RVA: 0x0033F600 File Offset: 0x0033D800
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr);
				Spell_Kogasa.__c__DisplayClass17_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr, "effect");
				Spell_Kogasa.__c__DisplayClass17_0.NativeFieldInfoPtr_gengar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr, "gengar");
				Spell_Kogasa.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr, 100678761);
				Spell_Kogasa.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr, 100678762);
				Spell_Kogasa.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr, 100678763);
			}

			// Token: 0x0600D486 RID: 54406 RVA: 0x0033F690 File Offset: 0x0033D890
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D487 RID: 54407 RVA: 0x0033F6CC File Offset: 0x0033D8CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197721, XrefRangeEnd = 197726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D488 RID: 54408 RVA: 0x0033F710 File Offset: 0x0033D910
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D489 RID: 54409 RVA: 0x00071CA6 File Offset: 0x0006FEA6
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004526 RID: 17702
			// (get) Token: 0x0600D48A RID: 54410 RVA: 0x0033F754 File Offset: 0x0033D954
			// (set) Token: 0x0600D48B RID: 54411 RVA: 0x00071CAF File Offset: 0x0006FEAF
			public unsafe ParticleSystem effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass17_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass17_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004527 RID: 17703
			// (get) Token: 0x0600D48C RID: 54412 RVA: 0x0033F784 File Offset: 0x0033D984
			// (set) Token: 0x0600D48D RID: 54413 RVA: 0x00071CCE File Offset: 0x0006FECE
			public unsafe GameObject gengar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass17_0.NativeFieldInfoPtr_gengar);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass17_0.NativeFieldInfoPtr_gengar), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008868 RID: 34920
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04008869 RID: 34921
			private static readonly IntPtr NativeFieldInfoPtr_gengar;

			// Token: 0x0400886A RID: 34922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400886B RID: 34923
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x0400886C RID: 34924
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B38 RID: 2872
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kogasa+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D48E RID: 54414 RVA: 0x0033F7B4 File Offset: 0x0033D9B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr);
				Spell_Kogasa.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, "<>9");
				Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, "<>9__17_2");
				Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, "<>9__17_3");
				Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, "<>9__17_4");
				Spell_Kogasa.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, 100678765);
				Spell_Kogasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, 100678766);
				Spell_Kogasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_3_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, 100678767);
				Spell_Kogasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_4_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr, 100678768);
			}

			// Token: 0x0600D48F RID: 54415 RVA: 0x0033F880 File Offset: 0x0033DA80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kogasa.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D490 RID: 54416 RVA: 0x0033F8BC File Offset: 0x0033DABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197726, XrefRangeEnd = 197732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__17_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D491 RID: 54417 RVA: 0x0033F8F8 File Offset: 0x0033DAF8
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__17_3(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_3_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D492 RID: 54418 RVA: 0x0033F948 File Offset: 0x0033DB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197732, XrefRangeEnd = 197735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__17_4(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_4_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D493 RID: 54419 RVA: 0x00071CED File Offset: 0x0006FEED
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004528 RID: 17704
			// (get) Token: 0x0600D494 RID: 54420 RVA: 0x0033F98C File Offset: 0x0033DB8C
			// (set) Token: 0x0600D495 RID: 54421 RVA: 0x00071CF6 File Offset: 0x0006FEF6
			public unsafe static Spell_Kogasa.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kogasa.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004529 RID: 17705
			// (get) Token: 0x0600D496 RID: 54422 RVA: 0x0033F9B4 File Offset: 0x0033DBB4
			// (set) Token: 0x0600D497 RID: 54423 RVA: 0x00071D08 File Offset: 0x0006FF08
			public unsafe static Func<Vector3> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452A RID: 17706
			// (get) Token: 0x0600D498 RID: 54424 RVA: 0x0033F9DC File Offset: 0x0033DBDC
			// (set) Token: 0x0600D499 RID: 54425 RVA: 0x00071D1A File Offset: 0x0006FF1A
			public unsafe static Func<GuestGroupController, bool> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452B RID: 17707
			// (get) Token: 0x0600D49A RID: 54426 RVA: 0x0033FA04 File Offset: 0x0033DC04
			// (set) Token: 0x0600D49B RID: 54427 RVA: 0x00071D2C File Offset: 0x0006FF2C
			public unsafe static Action<GuestGroupController> __9__17_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kogasa.__c.NativeFieldInfoPtr___9__17_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400886D RID: 34925
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400886E RID: 34926
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x0400886F RID: 34927
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x04008870 RID: 34928
			private static readonly IntPtr NativeFieldInfoPtr___9__17_4;

			// Token: 0x04008871 RID: 34929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008872 RID: 34930
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_2_Internal_Vector3_0;

			// Token: 0x04008873 RID: 34931
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_3_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008874 RID: 34932
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_4_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000B39 RID: 2873
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kogasa+<OnNegativeBuffExecute>d__17")]
		public sealed class _OnNegativeBuffExecute_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600D49C RID: 54428 RVA: 0x0033FA2C File Offset: 0x0033DC2C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__17()
			{
				Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "<OnNegativeBuffExecute>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr);
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>1__state");
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>2__current");
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>4__this");
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, "spellExecutionContext");
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>8__1");
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100678769);
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100678770);
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100678771);
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100678772);
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100678773);
				Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100678774);
			}

			// Token: 0x0600D49D RID: 54429 RVA: 0x0033FB34 File Offset: 0x0033DD34
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kogasa._OnNegativeBuffExecute_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D49E RID: 54430 RVA: 0x0033FB7C File Offset: 0x0033DD7C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D49F RID: 54431 RVA: 0x0033FBB0 File Offset: 0x0033DDB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197735, XrefRangeEnd = 197788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004531 RID: 17713
			// (get) Token: 0x0600D4A0 RID: 54432 RVA: 0x0033FBEC File Offset: 0x0033DDEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4A1 RID: 54433 RVA: 0x0033FC2C File Offset: 0x0033DE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197788, XrefRangeEnd = 197794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004532 RID: 17714
			// (get) Token: 0x0600D4A2 RID: 54434 RVA: 0x0033FC60 File Offset: 0x0033DE60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4A3 RID: 54435 RVA: 0x00071D3E File Offset: 0x0006FF3E
			public _OnNegativeBuffExecute_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700452C RID: 17708
			// (get) Token: 0x0600D4A4 RID: 54436 RVA: 0x0033FCA0 File Offset: 0x0033DEA0
			// (set) Token: 0x0600D4A5 RID: 54437 RVA: 0x00071D47 File Offset: 0x0006FF47
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700452D RID: 17709
			// (get) Token: 0x0600D4A6 RID: 54438 RVA: 0x0033FCC8 File Offset: 0x0033DEC8
			// (set) Token: 0x0600D4A7 RID: 54439 RVA: 0x00071D62 File Offset: 0x0006FF62
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452E RID: 17710
			// (get) Token: 0x0600D4A8 RID: 54440 RVA: 0x0033FCF8 File Offset: 0x0033DEF8
			// (set) Token: 0x0600D4A9 RID: 54441 RVA: 0x00071D81 File Offset: 0x0006FF81
			public unsafe Spell_Kogasa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kogasa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452F RID: 17711
			// (get) Token: 0x0600D4AA RID: 54442 RVA: 0x0033FD28 File Offset: 0x0033DF28
			// (set) Token: 0x0600D4AB RID: 54443 RVA: 0x00071DA0 File Offset: 0x0006FFA0
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004530 RID: 17712
			// (get) Token: 0x0600D4AC RID: 54444 RVA: 0x0033FD58 File Offset: 0x0033DF58
			// (set) Token: 0x0600D4AD RID: 54445 RVA: 0x00071DBF File Offset: 0x0006FFBF
			public unsafe Spell_Kogasa.__c__DisplayClass17_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kogasa.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008875 RID: 34933
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008876 RID: 34934
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008877 RID: 34935
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008878 RID: 34936
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008879 RID: 34937
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400887A RID: 34938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400887B RID: 34939
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400887C RID: 34940
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400887D RID: 34941
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400887E RID: 34942
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400887F RID: 34943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B3A RID: 2874
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kogasa+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4AE RID: 54446 RVA: 0x0033FD88 File Offset: 0x0033DF88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr);
				Spell_Kogasa.__c__DisplayClass18_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr, "effect");
				Spell_Kogasa.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr, 100678775);
				Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr, 100678776);
				Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr, 100678777);
				Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr, 100678778);
			}

			// Token: 0x0600D4AF RID: 54447 RVA: 0x0033FE2C File Offset: 0x0033E02C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kogasa.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4B0 RID: 54448 RVA: 0x0033FE68 File Offset: 0x0033E068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197794, XrefRangeEnd = 197799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4B1 RID: 54449 RVA: 0x0033FEAC File Offset: 0x0033E0AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197799, XrefRangeEnd = 197825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_String_PDM_0(int currentTime, string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D4B2 RID: 54450 RVA: 0x0033FF04 File Offset: 0x0033E104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197825, XrefRangeEnd = 197833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4B3 RID: 54451 RVA: 0x00071DDE File Offset: 0x0006FFDE
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004533 RID: 17715
			// (get) Token: 0x0600D4B4 RID: 54452 RVA: 0x0033FF44 File Offset: 0x0033E144
			// (set) Token: 0x0600D4B5 RID: 54453 RVA: 0x00071DE7 File Offset: 0x0006FFE7
			public unsafe ParticleSystem effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass18_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass18_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004534 RID: 17716
			// (get) Token: 0x0600D4B6 RID: 54454 RVA: 0x0033FF74 File Offset: 0x0033E174
			// (set) Token: 0x0600D4B7 RID: 54455 RVA: 0x00071E06 File Offset: 0x00070006
			public unsafe Spell_Kogasa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kogasa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008880 RID: 34944
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04008881 RID: 34945
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008882 RID: 34946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008883 RID: 34947
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008884 RID: 34948
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_String_PDM_0;

			// Token: 0x04008885 RID: 34949
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0;
		}

		// Token: 0x02000B3B RID: 2875
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kogasa+<OnPositiveBuffExecute>d__18")]
		public sealed class _OnPositiveBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D4B8 RID: 54456 RVA: 0x0033FFA4 File Offset: 0x0033E1A4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kogasa>.NativeClassPtr, "<OnPositiveBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr);
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, "spellExecutionContext");
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>8__1");
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678779);
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678780);
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678781);
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678782);
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678783);
				Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678784);
			}

			// Token: 0x0600D4B9 RID: 54457 RVA: 0x003400AC File Offset: 0x0033E2AC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kogasa._OnPositiveBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4BA RID: 54458 RVA: 0x003400F4 File Offset: 0x0033E2F4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4BB RID: 54459 RVA: 0x00340128 File Offset: 0x0033E328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197833, XrefRangeEnd = 197849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700453A RID: 17722
			// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x00340164 File Offset: 0x0033E364
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4BD RID: 54461 RVA: 0x003401A4 File Offset: 0x0033E3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197849, XrefRangeEnd = 197855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700453B RID: 17723
			// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x003401D8 File Offset: 0x0033E3D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4BF RID: 54463 RVA: 0x00071E25 File Offset: 0x00070025
			public _OnPositiveBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004535 RID: 17717
			// (get) Token: 0x0600D4C0 RID: 54464 RVA: 0x00340218 File Offset: 0x0033E418
			// (set) Token: 0x0600D4C1 RID: 54465 RVA: 0x00071E2E File Offset: 0x0007002E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004536 RID: 17718
			// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x00340240 File Offset: 0x0033E440
			// (set) Token: 0x0600D4C3 RID: 54467 RVA: 0x00071E49 File Offset: 0x00070049
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004537 RID: 17719
			// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x00340270 File Offset: 0x0033E470
			// (set) Token: 0x0600D4C5 RID: 54469 RVA: 0x00071E68 File Offset: 0x00070068
			public unsafe Spell_Kogasa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kogasa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004538 RID: 17720
			// (get) Token: 0x0600D4C6 RID: 54470 RVA: 0x003402A0 File Offset: 0x0033E4A0
			// (set) Token: 0x0600D4C7 RID: 54471 RVA: 0x00071E87 File Offset: 0x00070087
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004539 RID: 17721
			// (get) Token: 0x0600D4C8 RID: 54472 RVA: 0x003402D0 File Offset: 0x0033E4D0
			// (set) Token: 0x0600D4C9 RID: 54473 RVA: 0x00071EA6 File Offset: 0x000700A6
			public unsafe Spell_Kogasa.__c__DisplayClass18_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kogasa.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kogasa._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008886 RID: 34950
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008887 RID: 34951
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008888 RID: 34952
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008889 RID: 34953
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400888A RID: 34954
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400888B RID: 34955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400888C RID: 34956
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400888D RID: 34957
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400888E RID: 34958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400888F RID: 34959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008890 RID: 34960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
