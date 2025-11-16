using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.UI.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000275 RID: 629
	public class Spell_Narumi : SpellBase
	{
		// Token: 0x06004EE5 RID: 20197 RVA: 0x001AD0DC File Offset: 0x001AB2DC
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Narumi()
		{
			Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Narumi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr);
			Spell_Narumi.NativeFieldInfoPtr_extraFeeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "extraFeeRate");
			Spell_Narumi.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "positiveDuration");
			Spell_Narumi.NativeFieldInfoPtr_clearBuffNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "clearBuffNum");
			Spell_Narumi.NativeFieldInfoPtr_rewardObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "rewardObject");
			Spell_Narumi.NativeFieldInfoPtr_rewardDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "rewardDuration");
			Spell_Narumi.NativeFieldInfoPtr_effectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "effectDuration");
			Spell_Narumi.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "rewardSFX");
			Spell_Narumi.NativeFieldInfoPtr_fireBulletObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "fireBulletObject");
			Spell_Narumi.NativeFieldInfoPtr_bulletDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "bulletDuration");
			Spell_Narumi.NativeFieldInfoPtr_bulletDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "bulletDelay");
			Spell_Narumi.NativeFieldInfoPtr_bulletFlyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "bulletFlyTime");
			Spell_Narumi.NativeFieldInfoPtr_magicSphereLaunchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "magicSphereLaunchSpeed");
			Spell_Narumi.NativeFieldInfoPtr_magicSphereMaxAnglerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "magicSphereMaxAnglerSpeed");
			Spell_Narumi.NativeFieldInfoPtr_magicSphereMinAnglerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "magicSphereMinAnglerSpeed");
			Spell_Narumi.NativeFieldInfoPtr_finalFireObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "finalFireObject");
			Spell_Narumi.NativeFieldInfoPtr_fireDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "fireDuration");
			Spell_Narumi.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "punishmentSFX");
			Spell_Narumi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, 100679150);
			Spell_Narumi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, 100679151);
			Spell_Narumi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, 100679152);
			Spell_Narumi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, 100679153);
			Spell_Narumi.NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, 100679154);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x001AD2C4 File Offset: 0x001AB4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200666, XrefRangeEnd = 200668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Narumi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x001AD308 File Offset: 0x001AB508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200668, XrefRangeEnd = 200674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Narumi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x001AD364 File Offset: 0x001AB564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200674, XrefRangeEnd = 200679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Narumi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x001AD3C0 File Offset: 0x001AB5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200679, XrefRangeEnd = 200680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Narumi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x001AD3FC File Offset: 0x001AB5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200680, XrefRangeEnd = 200682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__19_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x000296B5 File Offset: 0x000278B5
		public Spell_Narumi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x001AD43C File Offset: 0x001AB63C
		// (set) Token: 0x06004EED RID: 20205 RVA: 0x000296BE File Offset: 0x000278BE
		public unsafe float extraFeeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_extraFeeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_extraFeeRate)) = value;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x001AD464 File Offset: 0x001AB664
		// (set) Token: 0x06004EEF RID: 20207 RVA: 0x000296D9 File Offset: 0x000278D9
		public unsafe float positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x001AD48C File Offset: 0x001AB68C
		// (set) Token: 0x06004EF1 RID: 20209 RVA: 0x000296F4 File Offset: 0x000278F4
		public unsafe int clearBuffNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_clearBuffNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_clearBuffNum)) = value;
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x001AD4B4 File Offset: 0x001AB6B4
		// (set) Token: 0x06004EF3 RID: 20211 RVA: 0x0002970F File Offset: 0x0002790F
		public unsafe GameObject rewardObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_rewardObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_rewardObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x001AD4E4 File Offset: 0x001AB6E4
		// (set) Token: 0x06004EF5 RID: 20213 RVA: 0x0002972E File Offset: 0x0002792E
		public unsafe float rewardDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_rewardDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_rewardDuration)) = value;
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x001AD50C File Offset: 0x001AB70C
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x00029749 File Offset: 0x00027949
		public unsafe float effectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_effectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_effectDuration)) = value;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x001AD534 File Offset: 0x001AB734
		// (set) Token: 0x06004EF9 RID: 20217 RVA: 0x00029764 File Offset: 0x00027964
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x001AD564 File Offset: 0x001AB764
		// (set) Token: 0x06004EFB RID: 20219 RVA: 0x00029783 File Offset: 0x00027983
		public unsafe GameObject fireBulletObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_fireBulletObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_fireBulletObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06004EFC RID: 20220 RVA: 0x001AD594 File Offset: 0x001AB794
		// (set) Token: 0x06004EFD RID: 20221 RVA: 0x000297A2 File Offset: 0x000279A2
		public unsafe float bulletDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_bulletDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_bulletDuration)) = value;
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06004EFE RID: 20222 RVA: 0x001AD5BC File Offset: 0x001AB7BC
		// (set) Token: 0x06004EFF RID: 20223 RVA: 0x000297BD File Offset: 0x000279BD
		public unsafe float bulletDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_bulletDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_bulletDelay)) = value;
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x001AD5E4 File Offset: 0x001AB7E4
		// (set) Token: 0x06004F01 RID: 20225 RVA: 0x000297D8 File Offset: 0x000279D8
		public unsafe float bulletFlyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_bulletFlyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_bulletFlyTime)) = value;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x001AD60C File Offset: 0x001AB80C
		// (set) Token: 0x06004F03 RID: 20227 RVA: 0x000297F3 File Offset: 0x000279F3
		public unsafe float magicSphereLaunchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_magicSphereLaunchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_magicSphereLaunchSpeed)) = value;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x001AD634 File Offset: 0x001AB834
		// (set) Token: 0x06004F05 RID: 20229 RVA: 0x0002980E File Offset: 0x00027A0E
		public unsafe float magicSphereMaxAnglerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_magicSphereMaxAnglerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_magicSphereMaxAnglerSpeed)) = value;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x001AD65C File Offset: 0x001AB85C
		// (set) Token: 0x06004F07 RID: 20231 RVA: 0x00029829 File Offset: 0x00027A29
		public unsafe float magicSphereMinAnglerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_magicSphereMinAnglerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_magicSphereMinAnglerSpeed)) = value;
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x001AD684 File Offset: 0x001AB884
		// (set) Token: 0x06004F09 RID: 20233 RVA: 0x00029844 File Offset: 0x00027A44
		public unsafe GameObject finalFireObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_finalFireObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_finalFireObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x001AD6B4 File Offset: 0x001AB8B4
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x00029863 File Offset: 0x00027A63
		public unsafe float fireDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_fireDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_fireDuration)) = value;
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x001AD6DC File Offset: 0x001AB8DC
		// (set) Token: 0x06004F0D RID: 20237 RVA: 0x0002987E File Offset: 0x00027A7E
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035A3 RID: 13731
		private static readonly IntPtr NativeFieldInfoPtr_extraFeeRate;

		// Token: 0x040035A4 RID: 13732
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040035A5 RID: 13733
		private static readonly IntPtr NativeFieldInfoPtr_clearBuffNum;

		// Token: 0x040035A6 RID: 13734
		private static readonly IntPtr NativeFieldInfoPtr_rewardObject;

		// Token: 0x040035A7 RID: 13735
		private static readonly IntPtr NativeFieldInfoPtr_rewardDuration;

		// Token: 0x040035A8 RID: 13736
		private static readonly IntPtr NativeFieldInfoPtr_effectDuration;

		// Token: 0x040035A9 RID: 13737
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040035AA RID: 13738
		private static readonly IntPtr NativeFieldInfoPtr_fireBulletObject;

		// Token: 0x040035AB RID: 13739
		private static readonly IntPtr NativeFieldInfoPtr_bulletDuration;

		// Token: 0x040035AC RID: 13740
		private static readonly IntPtr NativeFieldInfoPtr_bulletDelay;

		// Token: 0x040035AD RID: 13741
		private static readonly IntPtr NativeFieldInfoPtr_bulletFlyTime;

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereLaunchSpeed;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereMaxAnglerSpeed;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereMinAnglerSpeed;

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeFieldInfoPtr_finalFireObject;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeFieldInfoPtr_fireDuration;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035B8 RID: 13752
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__19_0_Private_Void_Int32_0;

		// Token: 0x02000B70 RID: 2928
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D79B RID: 55195 RVA: 0x003489C4 File Offset: 0x00346BC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr);
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_fireBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "fireBullet");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_buffModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "buffModule");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "canvas");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_getBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "getBuffs");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "effect");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_bulletNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "bulletNum");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "<>9__4");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "<>9__5");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "<>9__6");
				Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, "<>9__7");
				Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, 100679155);
				Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, 100679156);
				Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, 100679157);
				Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, 100679158);
				Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, 100679159);
				Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr, 100679160);
			}

			// Token: 0x0600D79C RID: 55196 RVA: 0x00348B44 File Offset: 0x00346D44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D79D RID: 55197 RVA: 0x00348B80 File Offset: 0x00346D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200527, XrefRangeEnd = 200528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnNegativeBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D79E RID: 55198 RVA: 0x00348BBC File Offset: 0x00346DBC
			[CallerCount(0)]
			public unsafe float _OnNegativeBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D79F RID: 55199 RVA: 0x00348BF8 File Offset: 0x00346DF8
			[CallerCount(0)]
			public unsafe float _OnNegativeBuffExecute_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7A0 RID: 55200 RVA: 0x00348C34 File Offset: 0x00346E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200528, XrefRangeEnd = 200536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7A1 RID: 55201 RVA: 0x00348C78 File Offset: 0x00346E78
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7A2 RID: 55202 RVA: 0x000735A1 File Offset: 0x000717A1
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004622 RID: 17954
			// (get) Token: 0x0600D7A3 RID: 55203 RVA: 0x00348CB4 File Offset: 0x00346EB4
			// (set) Token: 0x0600D7A4 RID: 55204 RVA: 0x000735AA File Offset: 0x000717AA
			public unsafe GameObject fireBullet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_fireBullet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_fireBullet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004623 RID: 17955
			// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x00348CE4 File Offset: 0x00346EE4
			// (set) Token: 0x0600D7A6 RID: 55206 RVA: 0x000735C9 File Offset: 0x000717C9
			public unsafe BuffModule buffModule
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_buffModule);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_buffModule), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004624 RID: 17956
			// (get) Token: 0x0600D7A7 RID: 55207 RVA: 0x00348D14 File Offset: 0x00346F14
			// (set) Token: 0x0600D7A8 RID: 55208 RVA: 0x000735E8 File Offset: 0x000717E8
			public unsafe Canvas canvas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_canvas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004625 RID: 17957
			// (get) Token: 0x0600D7A9 RID: 55209 RVA: 0x00348D44 File Offset: 0x00346F44
			// (set) Token: 0x0600D7AA RID: 55210 RVA: 0x00073607 File Offset: 0x00071807
			public unsafe Il2CppStructArray<Guid> getBuffs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_getBuffs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_getBuffs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004626 RID: 17958
			// (get) Token: 0x0600D7AB RID: 55211 RVA: 0x00348D74 File Offset: 0x00346F74
			// (set) Token: 0x0600D7AC RID: 55212 RVA: 0x00073626 File Offset: 0x00071826
			public unsafe Spell_Narumi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004627 RID: 17959
			// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x00348DA4 File Offset: 0x00346FA4
			// (set) Token: 0x0600D7AE RID: 55214 RVA: 0x00073645 File Offset: 0x00071845
			public unsafe List<ParticleSystem> effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004628 RID: 17960
			// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x00348DD4 File Offset: 0x00346FD4
			// (set) Token: 0x0600D7B0 RID: 55216 RVA: 0x00073664 File Offset: 0x00071864
			public unsafe int bulletNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_bulletNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr_bulletNum)) = value;
				}
			}

			// Token: 0x17004629 RID: 17961
			// (get) Token: 0x0600D7B1 RID: 55217 RVA: 0x00348DFC File Offset: 0x00346FFC
			// (set) Token: 0x0600D7B2 RID: 55218 RVA: 0x0007367F File Offset: 0x0007187F
			public unsafe Func<float> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700462A RID: 17962
			// (get) Token: 0x0600D7B3 RID: 55219 RVA: 0x00348E2C File Offset: 0x0034702C
			// (set) Token: 0x0600D7B4 RID: 55220 RVA: 0x0007369E File Offset: 0x0007189E
			public unsafe Func<float> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700462B RID: 17963
			// (get) Token: 0x0600D7B5 RID: 55221 RVA: 0x00348E5C File Offset: 0x0034705C
			// (set) Token: 0x0600D7B6 RID: 55222 RVA: 0x000736BD File Offset: 0x000718BD
			public unsafe Func<float> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700462C RID: 17964
			// (get) Token: 0x0600D7B7 RID: 55223 RVA: 0x00348E8C File Offset: 0x0034708C
			// (set) Token: 0x0600D7B8 RID: 55224 RVA: 0x000736DC File Offset: 0x000718DC
			public unsafe Action<GameObject> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A3E RID: 35390
			private static readonly IntPtr NativeFieldInfoPtr_fireBullet;

			// Token: 0x04008A3F RID: 35391
			private static readonly IntPtr NativeFieldInfoPtr_buffModule;

			// Token: 0x04008A40 RID: 35392
			private static readonly IntPtr NativeFieldInfoPtr_canvas;

			// Token: 0x04008A41 RID: 35393
			private static readonly IntPtr NativeFieldInfoPtr_getBuffs;

			// Token: 0x04008A42 RID: 35394
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A43 RID: 35395
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04008A44 RID: 35396
			private static readonly IntPtr NativeFieldInfoPtr_bulletNum;

			// Token: 0x04008A45 RID: 35397
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008A46 RID: 35398
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04008A47 RID: 35399
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04008A48 RID: 35400
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x04008A49 RID: 35401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A4A RID: 35402
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Single_0;

			// Token: 0x04008A4B RID: 35403
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Single_0;

			// Token: 0x04008A4C RID: 35404
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Single_0;

			// Token: 0x04008A4D RID: 35405
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0;

			// Token: 0x04008A4E RID: 35406
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000B71 RID: 2929
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<>c__DisplayClass18_1")]
		public sealed class __c__DisplayClass18_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D7B9 RID: 55225 RVA: 0x00348EBC File Offset: 0x003470BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_1()
			{
				Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "<>c__DisplayClass18_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr);
				Spell_Narumi.__c__DisplayClass18_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr, "i");
				Spell_Narumi.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Narumi.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr, 100679161);
				Spell_Narumi.__c__DisplayClass18_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr, 100679162);
			}

			// Token: 0x0600D7BA RID: 55226 RVA: 0x00348F38 File Offset: 0x00347138
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7BB RID: 55227 RVA: 0x00348F74 File Offset: 0x00347174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200593, XrefRangeEnd = 200598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D7BC RID: 55228 RVA: 0x000736FB File Offset: 0x000718FB
			public __c__DisplayClass18_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700462D RID: 17965
			// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x00348FB4 File Offset: 0x003471B4
			// (set) Token: 0x0600D7BE RID: 55230 RVA: 0x00073704 File Offset: 0x00071904
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700462E RID: 17966
			// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x00348FDC File Offset: 0x003471DC
			// (set) Token: 0x0600D7C0 RID: 55232 RVA: 0x0007371F File Offset: 0x0007191F
			public unsafe Spell_Narumi.__c__DisplayClass18_0 field_Public___c__DisplayClass18_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A4F RID: 35407
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008A50 RID: 35408
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0;

			// Token: 0x04008A51 RID: 35409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A52 RID: 35410
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001035 RID: 4149
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<>c__DisplayClass18_1+<<OnNegativeBuffExecute>g__ShootFireBullet|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BFC RID: 72700 RVA: 0x004109F4 File Offset: 0x0040EBF4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique()
				{
					Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1>.NativeClassPtr, "<<OnNegativeBuffExecute>g__ShootFireBullet|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr);
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__bulletTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<bulletTransform>5__2");
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679163);
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679164);
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679165);
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679166);
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679167);
					Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679168);
				}

				// Token: 0x06011BFD RID: 72701 RVA: 0x00410AFC File Offset: 0x0040ECFC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BFE RID: 72702 RVA: 0x00410B44 File Offset: 0x0040ED44
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BFF RID: 72703 RVA: 0x00410B78 File Offset: 0x0040ED78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200536, XrefRangeEnd = 200587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C6D RID: 23661
				// (get) Token: 0x06011C00 RID: 72704 RVA: 0x00410BB4 File Offset: 0x0040EDB4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C01 RID: 72705 RVA: 0x00410BF4 File Offset: 0x0040EDF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200587, XrefRangeEnd = 200593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C6E RID: 23662
				// (get) Token: 0x06011C02 RID: 72706 RVA: 0x00410C28 File Offset: 0x0040EE28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C03 RID: 72707 RVA: 0x0009A43F File Offset: 0x0009863F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C68 RID: 23656
				// (get) Token: 0x06011C04 RID: 72708 RVA: 0x00410C68 File Offset: 0x0040EE68
				// (set) Token: 0x06011C05 RID: 72709 RVA: 0x0009A448 File Offset: 0x00098648
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C69 RID: 23657
				// (get) Token: 0x06011C06 RID: 72710 RVA: 0x00410C90 File Offset: 0x0040EE90
				// (set) Token: 0x06011C07 RID: 72711 RVA: 0x0009A463 File Offset: 0x00098663
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C6A RID: 23658
				// (get) Token: 0x06011C08 RID: 72712 RVA: 0x00410CC0 File Offset: 0x0040EEC0
				// (set) Token: 0x06011C09 RID: 72713 RVA: 0x0009A482 File Offset: 0x00098682
				public unsafe Spell_Narumi.__c__DisplayClass18_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi.__c__DisplayClass18_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C6B RID: 23659
				// (get) Token: 0x06011C0A RID: 72714 RVA: 0x00410CF0 File Offset: 0x0040EEF0
				// (set) Token: 0x06011C0B RID: 72715 RVA: 0x0009A4A1 File Offset: 0x000986A1
				public unsafe Spell_Narumi.__c__DisplayClass18_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi.__c__DisplayClass18_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C6C RID: 23660
				// (get) Token: 0x06011C0C RID: 72716 RVA: 0x00410D20 File Offset: 0x0040EF20
				// (set) Token: 0x06011C0D RID: 72717 RVA: 0x0009A4C0 File Offset: 0x000986C0
				public unsafe Transform _bulletTransform_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__bulletTransform_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__bulletTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B369 RID: 45929
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B36A RID: 45930
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B36B RID: 45931
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B36C RID: 45932
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B36D RID: 45933
				private static readonly IntPtr NativeFieldInfoPtr__bulletTransform_5__2;

				// Token: 0x0400B36E RID: 45934
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B36F RID: 45935
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B370 RID: 45936
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B371 RID: 45937
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B372 RID: 45938
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B373 RID: 45939
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B72 RID: 2930
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<>c__DisplayClass18_2")]
		public sealed class __c__DisplayClass18_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D7C1 RID: 55233 RVA: 0x0034900C File Offset: 0x0034720C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_2()
			{
				Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "<>c__DisplayClass18_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_2>.NativeClassPtr);
				Spell_Narumi.__c__DisplayClass18_2.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_2>.NativeClassPtr, "targetPosition");
				Spell_Narumi.__c__DisplayClass18_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_2>.NativeClassPtr, 100679169);
				Spell_Narumi.__c__DisplayClass18_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_2>.NativeClassPtr, 100679170);
			}

			// Token: 0x0600D7C2 RID: 55234 RVA: 0x00349074 File Offset: 0x00347274
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi.__c__DisplayClass18_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7C3 RID: 55235 RVA: 0x003490B0 File Offset: 0x003472B0
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c__DisplayClass18_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7C4 RID: 55236 RVA: 0x0007373E File Offset: 0x0007193E
			public __c__DisplayClass18_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700462F RID: 17967
			// (get) Token: 0x0600D7C5 RID: 55237 RVA: 0x003490EC File Offset: 0x003472EC
			// (set) Token: 0x0600D7C6 RID: 55238 RVA: 0x00073747 File Offset: 0x00071947
			public unsafe Vector2 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_2.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi.__c__DisplayClass18_2.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x04008A53 RID: 35411
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04008A54 RID: 35412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A55 RID: 35413
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000B73 RID: 2931
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7C7 RID: 55239 RVA: 0x00349114 File Offset: 0x00347314
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr);
				Spell_Narumi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr, "<>9");
				Spell_Narumi.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr, "<>9__18_1");
				Spell_Narumi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr, 100679172);
				Spell_Narumi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_1_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr, 100679173);
			}

			// Token: 0x0600D7C8 RID: 55240 RVA: 0x00349190 File Offset: 0x00347390
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7C9 RID: 55241 RVA: 0x003491CC File Offset: 0x003473CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__18_1(ParticleSystem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_1_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7CA RID: 55242 RVA: 0x00073762 File Offset: 0x00071962
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004630 RID: 17968
			// (get) Token: 0x0600D7CB RID: 55243 RVA: 0x00349210 File Offset: 0x00347410
			// (set) Token: 0x0600D7CC RID: 55244 RVA: 0x0007376B File Offset: 0x0007196B
			public unsafe static Spell_Narumi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Narumi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Narumi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004631 RID: 17969
			// (get) Token: 0x0600D7CD RID: 55245 RVA: 0x00349238 File Offset: 0x00347438
			// (set) Token: 0x0600D7CE RID: 55246 RVA: 0x0007377D File Offset: 0x0007197D
			public unsafe static Action<ParticleSystem> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Narumi.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Narumi.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A56 RID: 35414
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A57 RID: 35415
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04008A58 RID: 35416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A59 RID: 35417
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_1_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000B74 RID: 2932
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<OnNegativeBuffExecute>d__18")]
		public sealed class _OnNegativeBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D7CF RID: 55247 RVA: 0x00349260 File Offset: 0x00347460
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "<OnNegativeBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr);
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, "spellExecutionContext");
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>8__1");
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679174);
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679175);
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679176);
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679177);
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679178);
				Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100679179);
			}

			// Token: 0x0600D7D0 RID: 55248 RVA: 0x00349368 File Offset: 0x00347568
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi._OnNegativeBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D1 RID: 55249 RVA: 0x003493B0 File Offset: 0x003475B0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D2 RID: 55250 RVA: 0x003493E4 File Offset: 0x003475E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200598, XrefRangeEnd = 200637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004637 RID: 17975
			// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x00349420 File Offset: 0x00347620
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7D4 RID: 55252 RVA: 0x00349460 File Offset: 0x00347660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200637, XrefRangeEnd = 200643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004638 RID: 17976
			// (get) Token: 0x0600D7D5 RID: 55253 RVA: 0x00349494 File Offset: 0x00347694
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7D6 RID: 55254 RVA: 0x0007378F File Offset: 0x0007198F
			public _OnNegativeBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004632 RID: 17970
			// (get) Token: 0x0600D7D7 RID: 55255 RVA: 0x003494D4 File Offset: 0x003476D4
			// (set) Token: 0x0600D7D8 RID: 55256 RVA: 0x00073798 File Offset: 0x00071998
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004633 RID: 17971
			// (get) Token: 0x0600D7D9 RID: 55257 RVA: 0x003494FC File Offset: 0x003476FC
			// (set) Token: 0x0600D7DA RID: 55258 RVA: 0x000737B3 File Offset: 0x000719B3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004634 RID: 17972
			// (get) Token: 0x0600D7DB RID: 55259 RVA: 0x0034952C File Offset: 0x0034772C
			// (set) Token: 0x0600D7DC RID: 55260 RVA: 0x000737D2 File Offset: 0x000719D2
			public unsafe Spell_Narumi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004635 RID: 17973
			// (get) Token: 0x0600D7DD RID: 55261 RVA: 0x0034955C File Offset: 0x0034775C
			// (set) Token: 0x0600D7DE RID: 55262 RVA: 0x000737F1 File Offset: 0x000719F1
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004636 RID: 17974
			// (get) Token: 0x0600D7DF RID: 55263 RVA: 0x0034958C File Offset: 0x0034778C
			// (set) Token: 0x0600D7E0 RID: 55264 RVA: 0x00073810 File Offset: 0x00071A10
			public unsafe Spell_Narumi.__c__DisplayClass18_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A5A RID: 35418
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A5B RID: 35419
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A5C RID: 35420
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A5D RID: 35421
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008A5E RID: 35422
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008A5F RID: 35423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A60 RID: 35424
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A61 RID: 35425
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A62 RID: 35426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A63 RID: 35427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A64 RID: 35428
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B75 RID: 2933
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Narumi+<OnPositiveBuffExecute>d__19")]
		public sealed class _OnPositiveBuffExecute_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600D7E1 RID: 55265 RVA: 0x003495BC File Offset: 0x003477BC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__19()
			{
				Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Narumi>.NativeClassPtr, "<OnPositiveBuffExecute>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr);
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>1__state");
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>2__current");
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>4__this");
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr__effect_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<effect>5__2");
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679180);
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679181);
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679182);
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679183);
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679184);
				Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100679185);
			}

			// Token: 0x0600D7E2 RID: 55266 RVA: 0x003496B0 File Offset: 0x003478B0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Narumi._OnPositiveBuffExecute_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7E3 RID: 55267 RVA: 0x003496F8 File Offset: 0x003478F8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7E4 RID: 55268 RVA: 0x0034972C File Offset: 0x0034792C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200643, XrefRangeEnd = 200660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700463D RID: 17981
			// (get) Token: 0x0600D7E5 RID: 55269 RVA: 0x00349768 File Offset: 0x00347968
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7E6 RID: 55270 RVA: 0x003497A8 File Offset: 0x003479A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200660, XrefRangeEnd = 200666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700463E RID: 17982
			// (get) Token: 0x0600D7E7 RID: 55271 RVA: 0x003497DC File Offset: 0x003479DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7E8 RID: 55272 RVA: 0x0007382F File Offset: 0x00071A2F
			public _OnPositiveBuffExecute_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004639 RID: 17977
			// (get) Token: 0x0600D7E9 RID: 55273 RVA: 0x0034981C File Offset: 0x00347A1C
			// (set) Token: 0x0600D7EA RID: 55274 RVA: 0x00073838 File Offset: 0x00071A38
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700463A RID: 17978
			// (get) Token: 0x0600D7EB RID: 55275 RVA: 0x00349844 File Offset: 0x00347A44
			// (set) Token: 0x0600D7EC RID: 55276 RVA: 0x00073853 File Offset: 0x00071A53
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463B RID: 17979
			// (get) Token: 0x0600D7ED RID: 55277 RVA: 0x00349874 File Offset: 0x00347A74
			// (set) Token: 0x0600D7EE RID: 55278 RVA: 0x00073872 File Offset: 0x00071A72
			public unsafe Spell_Narumi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Narumi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463C RID: 17980
			// (get) Token: 0x0600D7EF RID: 55279 RVA: 0x003498A4 File Offset: 0x00347AA4
			// (set) Token: 0x0600D7F0 RID: 55280 RVA: 0x00073891 File Offset: 0x00071A91
			public unsafe GameObject _effect_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr__effect_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Narumi._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr__effect_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A65 RID: 35429
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A66 RID: 35430
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A67 RID: 35431
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A68 RID: 35432
			private static readonly IntPtr NativeFieldInfoPtr__effect_5__2;

			// Token: 0x04008A69 RID: 35433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A6A RID: 35434
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A6B RID: 35435
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A6C RID: 35436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A6D RID: 35437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A6E RID: 35438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
