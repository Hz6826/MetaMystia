using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000287 RID: 647
	public class Spell_Tenshi : SpellBase
	{
		// Token: 0x060051C8 RID: 20936 RVA: 0x001B460C File Offset: 0x001B280C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Tenshi()
		{
			Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Tenshi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr);
			Spell_Tenshi.NativeFieldInfoPtr_overrideGuestMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "overrideGuestMood");
			Spell_Tenshi.NativeFieldInfoPtr_smashTableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "smashTableCount");
			Spell_Tenshi.NativeFieldInfoPtr_lockTableDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "lockTableDuration");
			Spell_Tenshi.NativeFieldInfoPtr_rockEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockEffect");
			Spell_Tenshi.NativeFieldInfoPtr_rockFallSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockFallSFX");
			Spell_Tenshi.NativeFieldInfoPtr_fadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "fadeDuration");
			Spell_Tenshi.NativeFieldInfoPtr_rockImpactOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockImpactOffset");
			Spell_Tenshi.NativeFieldInfoPtr_rockImpactSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockImpactSFX");
			Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockCameraShakeOffset");
			Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockCameraShakeAmplitude");
			Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockCameraShakeDuration");
			Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "rockCameraShakeFadeDuration");
			Spell_Tenshi.NativeFieldInfoPtr_passionEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionEffect");
			Spell_Tenshi.NativeFieldInfoPtr_passionSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionSFX");
			Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionCameraShakeAmplitude");
			Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionCameraShakeDuration");
			Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionCameraShakeFadeDuration");
			Spell_Tenshi.NativeFieldInfoPtr_passionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionDuration");
			Spell_Tenshi.NativeFieldInfoPtr_passionHappySFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionHappySFX");
			Spell_Tenshi.NativeFieldInfoPtr_passionHappyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionHappyEffect");
			Spell_Tenshi.NativeFieldInfoPtr_passionHappyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "passionHappyDuration");
			Spell_Tenshi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, 100679846);
			Spell_Tenshi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, 100679847);
			Spell_Tenshi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, 100679848);
			Spell_Tenshi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, 100679849);
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x001B4830 File Offset: 0x001B2A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205508, XrefRangeEnd = 205510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tenshi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x001B4874 File Offset: 0x001B2A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205510, XrefRangeEnd = 205516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tenshi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x001B48D0 File Offset: 0x001B2AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205516, XrefRangeEnd = 205522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tenshi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x001B492C File Offset: 0x001B2B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Tenshi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0002B988 File Offset: 0x00029B88
		public Spell_Tenshi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x001B4968 File Offset: 0x001B2B68
		// (set) Token: 0x060051CF RID: 20943 RVA: 0x0002B991 File Offset: 0x00029B91
		public unsafe float overrideGuestMood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_overrideGuestMood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_overrideGuestMood)) = value;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x001B4990 File Offset: 0x001B2B90
		// (set) Token: 0x060051D1 RID: 20945 RVA: 0x0002B9AC File Offset: 0x00029BAC
		public unsafe int smashTableCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_smashTableCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_smashTableCount)) = value;
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x001B49B8 File Offset: 0x001B2BB8
		// (set) Token: 0x060051D3 RID: 20947 RVA: 0x0002B9C7 File Offset: 0x00029BC7
		public unsafe int lockTableDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_lockTableDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_lockTableDuration)) = value;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x001B49E0 File Offset: 0x001B2BE0
		// (set) Token: 0x060051D5 RID: 20949 RVA: 0x0002B9E2 File Offset: 0x00029BE2
		public unsafe GameObject rockEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x001B4A10 File Offset: 0x001B2C10
		// (set) Token: 0x060051D7 RID: 20951 RVA: 0x0002BA01 File Offset: 0x00029C01
		public unsafe AudioClip rockFallSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockFallSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockFallSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x001B4A40 File Offset: 0x001B2C40
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x0002BA20 File Offset: 0x00029C20
		public unsafe float fadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_fadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_fadeDuration)) = value;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x001B4A68 File Offset: 0x001B2C68
		// (set) Token: 0x060051DB RID: 20955 RVA: 0x0002BA3B File Offset: 0x00029C3B
		public unsafe float rockImpactOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockImpactOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockImpactOffset)) = value;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x001B4A90 File Offset: 0x001B2C90
		// (set) Token: 0x060051DD RID: 20957 RVA: 0x0002BA56 File Offset: 0x00029C56
		public unsafe AudioClip rockImpactSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockImpactSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockImpactSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x001B4AC0 File Offset: 0x001B2CC0
		// (set) Token: 0x060051DF RID: 20959 RVA: 0x0002BA75 File Offset: 0x00029C75
		public unsafe float rockCameraShakeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeOffset)) = value;
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x001B4AE8 File Offset: 0x001B2CE8
		// (set) Token: 0x060051E1 RID: 20961 RVA: 0x0002BA90 File Offset: 0x00029C90
		public unsafe float rockCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x001B4B10 File Offset: 0x001B2D10
		// (set) Token: 0x060051E3 RID: 20963 RVA: 0x0002BAAB File Offset: 0x00029CAB
		public unsafe float rockCameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeDuration)) = value;
			}
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x001B4B38 File Offset: 0x001B2D38
		// (set) Token: 0x060051E5 RID: 20965 RVA: 0x0002BAC6 File Offset: 0x00029CC6
		public unsafe float rockCameraShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_rockCameraShakeFadeDuration)) = value;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x001B4B60 File Offset: 0x001B2D60
		// (set) Token: 0x060051E7 RID: 20967 RVA: 0x0002BAE1 File Offset: 0x00029CE1
		public unsafe GameObject passionEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x001B4B90 File Offset: 0x001B2D90
		// (set) Token: 0x060051E9 RID: 20969 RVA: 0x0002BB00 File Offset: 0x00029D00
		public unsafe AudioClip passionSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x001B4BC0 File Offset: 0x001B2DC0
		// (set) Token: 0x060051EB RID: 20971 RVA: 0x0002BB1F File Offset: 0x00029D1F
		public unsafe float passionCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x001B4BE8 File Offset: 0x001B2DE8
		// (set) Token: 0x060051ED RID: 20973 RVA: 0x0002BB3A File Offset: 0x00029D3A
		public unsafe float passionCameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeDuration)) = value;
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x001B4C10 File Offset: 0x001B2E10
		// (set) Token: 0x060051EF RID: 20975 RVA: 0x0002BB55 File Offset: 0x00029D55
		public unsafe float passionCameraShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionCameraShakeFadeDuration)) = value;
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x001B4C38 File Offset: 0x001B2E38
		// (set) Token: 0x060051F1 RID: 20977 RVA: 0x0002BB70 File Offset: 0x00029D70
		public unsafe float passionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionDuration)) = value;
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x001B4C60 File Offset: 0x001B2E60
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x0002BB8B File Offset: 0x00029D8B
		public unsafe AudioClip passionHappySFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionHappySFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionHappySFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x001B4C90 File Offset: 0x001B2E90
		// (set) Token: 0x060051F5 RID: 20981 RVA: 0x0002BBAA File Offset: 0x00029DAA
		public unsafe GameObject passionHappyEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionHappyEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionHappyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x001B4CC0 File Offset: 0x001B2EC0
		// (set) Token: 0x060051F7 RID: 20983 RVA: 0x0002BBC9 File Offset: 0x00029DC9
		public unsafe float passionHappyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionHappyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.NativeFieldInfoPtr_passionHappyDuration)) = value;
			}
		}

		// Token: 0x04003739 RID: 14137
		private static readonly IntPtr NativeFieldInfoPtr_overrideGuestMood;

		// Token: 0x0400373A RID: 14138
		private static readonly IntPtr NativeFieldInfoPtr_smashTableCount;

		// Token: 0x0400373B RID: 14139
		private static readonly IntPtr NativeFieldInfoPtr_lockTableDuration;

		// Token: 0x0400373C RID: 14140
		private static readonly IntPtr NativeFieldInfoPtr_rockEffect;

		// Token: 0x0400373D RID: 14141
		private static readonly IntPtr NativeFieldInfoPtr_rockFallSFX;

		// Token: 0x0400373E RID: 14142
		private static readonly IntPtr NativeFieldInfoPtr_fadeDuration;

		// Token: 0x0400373F RID: 14143
		private static readonly IntPtr NativeFieldInfoPtr_rockImpactOffset;

		// Token: 0x04003740 RID: 14144
		private static readonly IntPtr NativeFieldInfoPtr_rockImpactSFX;

		// Token: 0x04003741 RID: 14145
		private static readonly IntPtr NativeFieldInfoPtr_rockCameraShakeOffset;

		// Token: 0x04003742 RID: 14146
		private static readonly IntPtr NativeFieldInfoPtr_rockCameraShakeAmplitude;

		// Token: 0x04003743 RID: 14147
		private static readonly IntPtr NativeFieldInfoPtr_rockCameraShakeDuration;

		// Token: 0x04003744 RID: 14148
		private static readonly IntPtr NativeFieldInfoPtr_rockCameraShakeFadeDuration;

		// Token: 0x04003745 RID: 14149
		private static readonly IntPtr NativeFieldInfoPtr_passionEffect;

		// Token: 0x04003746 RID: 14150
		private static readonly IntPtr NativeFieldInfoPtr_passionSFX;

		// Token: 0x04003747 RID: 14151
		private static readonly IntPtr NativeFieldInfoPtr_passionCameraShakeAmplitude;

		// Token: 0x04003748 RID: 14152
		private static readonly IntPtr NativeFieldInfoPtr_passionCameraShakeDuration;

		// Token: 0x04003749 RID: 14153
		private static readonly IntPtr NativeFieldInfoPtr_passionCameraShakeFadeDuration;

		// Token: 0x0400374A RID: 14154
		private static readonly IntPtr NativeFieldInfoPtr_passionDuration;

		// Token: 0x0400374B RID: 14155
		private static readonly IntPtr NativeFieldInfoPtr_passionHappySFX;

		// Token: 0x0400374C RID: 14156
		private static readonly IntPtr NativeFieldInfoPtr_passionHappyEffect;

		// Token: 0x0400374D RID: 14157
		private static readonly IntPtr NativeFieldInfoPtr_passionHappyDuration;

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BD5 RID: 3029
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tenshi+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD1A RID: 56602 RVA: 0x00359210 File Offset: 0x00357410
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr);
				Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr, "queue");
				Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr, "<>9__1");
				Spell_Tenshi.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr, 100679850);
				Spell_Tenshi.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr, 100679851);
				Spell_Tenshi.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr, 100679852);
			}

			// Token: 0x0600DD1B RID: 56603 RVA: 0x003592B4 File Offset: 0x003574B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1C RID: 56604 RVA: 0x003592F0 File Offset: 0x003574F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205314, XrefRangeEnd = 205327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1D RID: 56605 RVA: 0x00359324 File Offset: 0x00357524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205327, XrefRangeEnd = 205342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1E RID: 56606 RVA: 0x0007620D File Offset: 0x0007440D
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047DE RID: 18398
			// (get) Token: 0x0600DD1F RID: 56607 RVA: 0x00359368 File Offset: 0x00357568
			// (set) Token: 0x0600DD20 RID: 56608 RVA: 0x00076216 File Offset: 0x00074416
			public unsafe Queue<UIElementCluster> queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr_queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047DF RID: 18399
			// (get) Token: 0x0600DD21 RID: 56609 RVA: 0x00359398 File Offset: 0x00357598
			// (set) Token: 0x0600DD22 RID: 56610 RVA: 0x00076235 File Offset: 0x00074435
			public unsafe Spell_Tenshi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tenshi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E0 RID: 18400
			// (get) Token: 0x0600DD23 RID: 56611 RVA: 0x003593C8 File Offset: 0x003575C8
			// (set) Token: 0x0600DD24 RID: 56612 RVA: 0x00076254 File Offset: 0x00074454
			public unsafe Action<SpriteRenderer> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D9E RID: 36254
			private static readonly IntPtr NativeFieldInfoPtr_queue;

			// Token: 0x04008D9F RID: 36255
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DA0 RID: 36256
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04008DA1 RID: 36257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DA2 RID: 36258
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008DA3 RID: 36259
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_SpriteRenderer_0;
		}

		// Token: 0x02000BD6 RID: 3030
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tenshi+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DD25 RID: 56613 RVA: 0x003593F8 File Offset: 0x003575F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_1>.NativeClassPtr);
				Spell_Tenshi.__c__DisplayClass22_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_1>.NativeClassPtr, "x");
				Spell_Tenshi.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_1>.NativeClassPtr, 100679853);
				Spell_Tenshi.__c__DisplayClass22_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_1>.NativeClassPtr, 100679854);
			}

			// Token: 0x0600DD26 RID: 56614 RVA: 0x00359460 File Offset: 0x00357660
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD27 RID: 56615 RVA: 0x0035949C File Offset: 0x0035769C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205342, XrefRangeEnd = 205348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass22_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD28 RID: 56616 RVA: 0x00076273 File Offset: 0x00074473
			public __c__DisplayClass22_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047E1 RID: 18401
			// (get) Token: 0x0600DD29 RID: 56617 RVA: 0x003594D0 File Offset: 0x003576D0
			// (set) Token: 0x0600DD2A RID: 56618 RVA: 0x0007627C File Offset: 0x0007447C
			public unsafe SpriteRenderer x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass22_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DA4 RID: 36260
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008DA5 RID: 36261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DA6 RID: 36262
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0;
		}

		// Token: 0x02000BD7 RID: 3031
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tenshi+<OnNegativeBuffExecute>d__22")]
		public sealed class _OnNegativeBuffExecute_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600DD2B RID: 56619 RVA: 0x00359500 File Offset: 0x00357700
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__22()
			{
				Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "<OnNegativeBuffExecute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr);
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>1__state");
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>2__current");
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>4__this");
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, "spellExecutionContext");
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>8__1");
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__targets_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<targets>5__2");
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679855);
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679856);
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679857);
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679858);
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679859);
				Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100679860);
			}

			// Token: 0x0600DD2C RID: 56620 RVA: 0x0035961C File Offset: 0x0035781C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi._OnNegativeBuffExecute_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD2D RID: 56621 RVA: 0x00359664 File Offset: 0x00357864
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD2E RID: 56622 RVA: 0x00359698 File Offset: 0x00357898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205348, XrefRangeEnd = 205423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047E8 RID: 18408
			// (get) Token: 0x0600DD2F RID: 56623 RVA: 0x003596D4 File Offset: 0x003578D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD30 RID: 56624 RVA: 0x00359714 File Offset: 0x00357914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205423, XrefRangeEnd = 205429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047E9 RID: 18409
			// (get) Token: 0x0600DD31 RID: 56625 RVA: 0x00359748 File Offset: 0x00357948
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD32 RID: 56626 RVA: 0x0007629B File Offset: 0x0007449B
			public _OnNegativeBuffExecute_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047E2 RID: 18402
			// (get) Token: 0x0600DD33 RID: 56627 RVA: 0x00359788 File Offset: 0x00357988
			// (set) Token: 0x0600DD34 RID: 56628 RVA: 0x000762A4 File Offset: 0x000744A4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047E3 RID: 18403
			// (get) Token: 0x0600DD35 RID: 56629 RVA: 0x003597B0 File Offset: 0x003579B0
			// (set) Token: 0x0600DD36 RID: 56630 RVA: 0x000762BF File Offset: 0x000744BF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E4 RID: 18404
			// (get) Token: 0x0600DD37 RID: 56631 RVA: 0x003597E0 File Offset: 0x003579E0
			// (set) Token: 0x0600DD38 RID: 56632 RVA: 0x000762DE File Offset: 0x000744DE
			public unsafe Spell_Tenshi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tenshi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E5 RID: 18405
			// (get) Token: 0x0600DD39 RID: 56633 RVA: 0x00359810 File Offset: 0x00357A10
			// (set) Token: 0x0600DD3A RID: 56634 RVA: 0x000762FD File Offset: 0x000744FD
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E6 RID: 18406
			// (get) Token: 0x0600DD3B RID: 56635 RVA: 0x00359840 File Offset: 0x00357A40
			// (set) Token: 0x0600DD3C RID: 56636 RVA: 0x0007631C File Offset: 0x0007451C
			public unsafe Spell_Tenshi.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tenshi.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E7 RID: 18407
			// (get) Token: 0x0600DD3D RID: 56637 RVA: 0x00359870 File Offset: 0x00357A70
			// (set) Token: 0x0600DD3E RID: 56638 RVA: 0x0007633B File Offset: 0x0007453B
			public unsafe IEnumerable<int> _targets_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__targets_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr__targets_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DA7 RID: 36263
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DA8 RID: 36264
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DA9 RID: 36265
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DAA RID: 36266
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008DAB RID: 36267
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008DAC RID: 36268
			private static readonly IntPtr NativeFieldInfoPtr__targets_5__2;

			// Token: 0x04008DAD RID: 36269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DAE RID: 36270
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DAF RID: 36271
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DB0 RID: 36272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DB1 RID: 36273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DB2 RID: 36274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD8 RID: 3032
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tenshi+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD3F RID: 56639 RVA: 0x003598A0 File Offset: 0x00357AA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_0>.NativeClassPtr);
				Spell_Tenshi.__c__DisplayClass23_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Tenshi.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_0>.NativeClassPtr, 100679861);
				Spell_Tenshi.__c__DisplayClass23_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_0>.NativeClassPtr, 100679862);
			}

			// Token: 0x0600DD40 RID: 56640 RVA: 0x00359908 File Offset: 0x00357B08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD41 RID: 56641 RVA: 0x00359944 File Offset: 0x00357B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205429, XrefRangeEnd = 205435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass23_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD42 RID: 56642 RVA: 0x0007635A File Offset: 0x0007455A
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047EA RID: 18410
			// (get) Token: 0x0600DD43 RID: 56643 RVA: 0x00359988 File Offset: 0x00357B88
			// (set) Token: 0x0600DD44 RID: 56644 RVA: 0x00076363 File Offset: 0x00074563
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass23_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass23_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DB3 RID: 36275
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008DB4 RID: 36276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DB5 RID: 36277
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;
		}

		// Token: 0x02000BD9 RID: 3033
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tenshi+<>c__DisplayClass23_1")]
		public sealed class __c__DisplayClass23_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DD45 RID: 56645 RVA: 0x003599B8 File Offset: 0x00357BB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_1()
			{
				Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "<>c__DisplayClass23_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_1>.NativeClassPtr);
				Spell_Tenshi.__c__DisplayClass23_1.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_1>.NativeClassPtr, "item");
				Spell_Tenshi.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_1>.NativeClassPtr, 100679863);
				Spell_Tenshi.__c__DisplayClass23_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_1>.NativeClassPtr, 100679864);
			}

			// Token: 0x0600DD46 RID: 56646 RVA: 0x00359A20 File Offset: 0x00357C20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi.__c__DisplayClass23_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD47 RID: 56647 RVA: 0x00359A5C File Offset: 0x00357C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi.__c__DisplayClass23_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD48 RID: 56648 RVA: 0x00076382 File Offset: 0x00074582
			public __c__DisplayClass23_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047EB RID: 18411
			// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x00359AA0 File Offset: 0x00357CA0
			// (set) Token: 0x0600DD4A RID: 56650 RVA: 0x0007638B File Offset: 0x0007458B
			public unsafe Vector3 item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass23_1.NativeFieldInfoPtr_item);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi.__c__DisplayClass23_1.NativeFieldInfoPtr_item)) = value;
				}
			}

			// Token: 0x04008DB6 RID: 36278
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008DB7 RID: 36279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DB8 RID: 36280
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000BDA RID: 3034
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tenshi+<OnPositiveBuffExecute>d__23")]
		public sealed class _OnPositiveBuffExecute_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600DD4B RID: 56651 RVA: 0x00359AC8 File Offset: 0x00357CC8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__23()
			{
				Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tenshi>.NativeClassPtr, "<OnPositiveBuffExecute>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr);
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>1__state");
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>2__current");
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, "spellExecutionContext");
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>4__this");
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679865);
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679866);
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679867);
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679868);
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679869);
				Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679870);
			}

			// Token: 0x0600DD4C RID: 56652 RVA: 0x00359BBC File Offset: 0x00357DBC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tenshi._OnPositiveBuffExecute_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD4D RID: 56653 RVA: 0x00359C04 File Offset: 0x00357E04
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD4E RID: 56654 RVA: 0x00359C38 File Offset: 0x00357E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205435, XrefRangeEnd = 205502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047F0 RID: 18416
			// (get) Token: 0x0600DD4F RID: 56655 RVA: 0x00359C74 File Offset: 0x00357E74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD50 RID: 56656 RVA: 0x00359CB4 File Offset: 0x00357EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205502, XrefRangeEnd = 205508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047F1 RID: 18417
			// (get) Token: 0x0600DD51 RID: 56657 RVA: 0x00359CE8 File Offset: 0x00357EE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD52 RID: 56658 RVA: 0x000763A6 File Offset: 0x000745A6
			public _OnPositiveBuffExecute_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047EC RID: 18412
			// (get) Token: 0x0600DD53 RID: 56659 RVA: 0x00359D28 File Offset: 0x00357F28
			// (set) Token: 0x0600DD54 RID: 56660 RVA: 0x000763AF File Offset: 0x000745AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047ED RID: 18413
			// (get) Token: 0x0600DD55 RID: 56661 RVA: 0x00359D50 File Offset: 0x00357F50
			// (set) Token: 0x0600DD56 RID: 56662 RVA: 0x000763CA File Offset: 0x000745CA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047EE RID: 18414
			// (get) Token: 0x0600DD57 RID: 56663 RVA: 0x00359D80 File Offset: 0x00357F80
			// (set) Token: 0x0600DD58 RID: 56664 RVA: 0x000763E9 File Offset: 0x000745E9
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047EF RID: 18415
			// (get) Token: 0x0600DD59 RID: 56665 RVA: 0x00359DB0 File Offset: 0x00357FB0
			// (set) Token: 0x0600DD5A RID: 56666 RVA: 0x00076408 File Offset: 0x00074608
			public unsafe Spell_Tenshi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tenshi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tenshi._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DB9 RID: 36281
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DBA RID: 36282
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DBB RID: 36283
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008DBC RID: 36284
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DBD RID: 36285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DBE RID: 36286
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DBF RID: 36287
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DC0 RID: 36288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DC1 RID: 36289
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DC2 RID: 36290
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
