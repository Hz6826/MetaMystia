using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200027B RID: 635
	public class Spell_Reimu : SpellBase
	{
		// Token: 0x06004FBD RID: 20413 RVA: 0x001AF268 File Offset: 0x001AD468
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Reimu()
		{
			Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Reimu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr);
			Spell_Reimu.NativeFieldInfoPtr_shieldGivenCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "shieldGivenCount");
			Spell_Reimu.NativeFieldInfoPtr_lockDailyRecipesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "lockDailyRecipesCount");
			Spell_Reimu.NativeFieldInfoPtr_lockDailyRecipesDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "lockDailyRecipesDuration");
			Spell_Reimu.NativeFieldInfoPtr_shieldSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "shieldSFX");
			Spell_Reimu.NativeFieldInfoPtr_shieldEffectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "shieldEffectParent");
			Spell_Reimu.NativeFieldInfoPtr_shieldEffectEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "shieldEffectEndOffset");
			Spell_Reimu.NativeFieldInfoPtr_sphereGenerateSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sphereGenerateSFX");
			Spell_Reimu.NativeFieldInfoPtr_shieldEffectEndParrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "shieldEffectEndParrent");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereEffectStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereEffectStart");
			Spell_Reimu.NativeFieldInfoPtr_magicStartDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicStartDuration");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereEffect");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereEffectDetonate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereEffectDetonate");
			Spell_Reimu.NativeFieldInfoPtr_sphereLaunchSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sphereLaunchSFX");
			Spell_Reimu.NativeFieldInfoPtr_sphereDetonateSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sphereDetonateSFX");
			Spell_Reimu.NativeFieldInfoPtr_magicDetonateDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicDetonateDuration");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereLaunchOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereLaunchOffset");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereLaunchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereLaunchSpeed");
			Spell_Reimu.NativeFieldInfoPtr_sealSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sealSFX");
			Spell_Reimu.NativeFieldInfoPtr_sealSFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sealSFXOffset");
			Spell_Reimu.NativeFieldInfoPtr_sealEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sealEffect");
			Spell_Reimu.NativeFieldInfoPtr_sealEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "sealEffectDuration");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereMaxAnglerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereMaxAnglerSpeed");
			Spell_Reimu.NativeFieldInfoPtr_magicSphereMinAnglerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicSphereMinAnglerSpeed");
			Spell_Reimu.NativeFieldInfoPtr_magicHitCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicHitCameraShakeAmplitude");
			Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicEndCameraShakeAmplitude");
			Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicEndCameraShakeDuration");
			Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "magicEndCameraShakeFadeDuration");
			Spell_Reimu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, 100679343);
			Spell_Reimu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, 100679344);
			Spell_Reimu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, 100679345);
			Spell_Reimu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, 100679346);
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x001AF504 File Offset: 0x001AD704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201978, XrefRangeEnd = 201980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Reimu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x001AF548 File Offset: 0x001AD748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201980, XrefRangeEnd = 201985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Reimu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x001AF5A4 File Offset: 0x001AD7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201985, XrefRangeEnd = 201991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Reimu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x001AF600 File Offset: 0x001AD800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Reimu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x0002A0E5 File Offset: 0x000282E5
		public Spell_Reimu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x001AF63C File Offset: 0x001AD83C
		// (set) Token: 0x06004FC4 RID: 20420 RVA: 0x0002A0EE File Offset: 0x000282EE
		public unsafe int shieldGivenCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldGivenCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldGivenCount)) = value;
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x001AF664 File Offset: 0x001AD864
		// (set) Token: 0x06004FC6 RID: 20422 RVA: 0x0002A109 File Offset: 0x00028309
		public unsafe int lockDailyRecipesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_lockDailyRecipesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_lockDailyRecipesCount)) = value;
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x001AF68C File Offset: 0x001AD88C
		// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x0002A124 File Offset: 0x00028324
		public unsafe int lockDailyRecipesDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_lockDailyRecipesDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_lockDailyRecipesDuration)) = value;
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x001AF6B4 File Offset: 0x001AD8B4
		// (set) Token: 0x06004FCA RID: 20426 RVA: 0x0002A13F File Offset: 0x0002833F
		public unsafe AudioClip shieldSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x001AF6E4 File Offset: 0x001AD8E4
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x0002A15E File Offset: 0x0002835E
		public unsafe GameObject shieldEffectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldEffectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldEffectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x001AF714 File Offset: 0x001AD914
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x0002A17D File Offset: 0x0002837D
		public unsafe float shieldEffectEndOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldEffectEndOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldEffectEndOffset)) = value;
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x001AF73C File Offset: 0x001AD93C
		// (set) Token: 0x06004FD0 RID: 20432 RVA: 0x0002A198 File Offset: 0x00028398
		public unsafe AudioClip sphereGenerateSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sphereGenerateSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sphereGenerateSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x001AF76C File Offset: 0x001AD96C
		// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x0002A1B7 File Offset: 0x000283B7
		public unsafe GameObject shieldEffectEndParrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldEffectEndParrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_shieldEffectEndParrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x001AF79C File Offset: 0x001AD99C
		// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x0002A1D6 File Offset: 0x000283D6
		public unsafe GameObject magicSphereEffectStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereEffectStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereEffectStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x001AF7CC File Offset: 0x001AD9CC
		// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x0002A1F5 File Offset: 0x000283F5
		public unsafe float magicStartDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicStartDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicStartDuration)) = value;
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x001AF7F4 File Offset: 0x001AD9F4
		// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x0002A210 File Offset: 0x00028410
		public unsafe GameObject magicSphereEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x001AF824 File Offset: 0x001ADA24
		// (set) Token: 0x06004FDA RID: 20442 RVA: 0x0002A22F File Offset: 0x0002842F
		public unsafe GameObject magicSphereEffectDetonate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereEffectDetonate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereEffectDetonate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x001AF854 File Offset: 0x001ADA54
		// (set) Token: 0x06004FDC RID: 20444 RVA: 0x0002A24E File Offset: 0x0002844E
		public unsafe AudioClip sphereLaunchSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sphereLaunchSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sphereLaunchSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x001AF884 File Offset: 0x001ADA84
		// (set) Token: 0x06004FDE RID: 20446 RVA: 0x0002A26D File Offset: 0x0002846D
		public unsafe AudioClip sphereDetonateSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sphereDetonateSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sphereDetonateSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x001AF8B4 File Offset: 0x001ADAB4
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x0002A28C File Offset: 0x0002848C
		public unsafe float magicDetonateDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicDetonateDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicDetonateDuration)) = value;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x001AF8DC File Offset: 0x001ADADC
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x0002A2A7 File Offset: 0x000284A7
		public unsafe float magicSphereLaunchOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereLaunchOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereLaunchOffset)) = value;
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x001AF904 File Offset: 0x001ADB04
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x0002A2C2 File Offset: 0x000284C2
		public unsafe float magicSphereLaunchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereLaunchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereLaunchSpeed)) = value;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x001AF92C File Offset: 0x001ADB2C
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x0002A2DD File Offset: 0x000284DD
		public unsafe AudioClip sealSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x001AF95C File Offset: 0x001ADB5C
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x0002A2FC File Offset: 0x000284FC
		public unsafe float sealSFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealSFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealSFXOffset)) = value;
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x001AF984 File Offset: 0x001ADB84
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x0002A317 File Offset: 0x00028517
		public unsafe GameObject sealEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x001AF9B4 File Offset: 0x001ADBB4
		// (set) Token: 0x06004FEC RID: 20460 RVA: 0x0002A336 File Offset: 0x00028536
		public unsafe float sealEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_sealEffectDuration)) = value;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x001AF9DC File Offset: 0x001ADBDC
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x0002A351 File Offset: 0x00028551
		public unsafe float magicSphereMaxAnglerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereMaxAnglerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereMaxAnglerSpeed)) = value;
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x001AFA04 File Offset: 0x001ADC04
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x0002A36C File Offset: 0x0002856C
		public unsafe float magicSphereMinAnglerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereMinAnglerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicSphereMinAnglerSpeed)) = value;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x001AFA2C File Offset: 0x001ADC2C
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x0002A387 File Offset: 0x00028587
		public unsafe float magicHitCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicHitCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicHitCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x001AFA54 File Offset: 0x001ADC54
		// (set) Token: 0x06004FF4 RID: 20468 RVA: 0x0002A3A2 File Offset: 0x000285A2
		public unsafe float magicEndCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x001AFA7C File Offset: 0x001ADC7C
		// (set) Token: 0x06004FF6 RID: 20470 RVA: 0x0002A3BD File Offset: 0x000285BD
		public unsafe float magicEndCameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeDuration)) = value;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x001AFAA4 File Offset: 0x001ADCA4
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x0002A3D8 File Offset: 0x000285D8
		public unsafe float magicEndCameraShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.NativeFieldInfoPtr_magicEndCameraShakeFadeDuration)) = value;
			}
		}

		// Token: 0x04003617 RID: 13847
		private static readonly IntPtr NativeFieldInfoPtr_shieldGivenCount;

		// Token: 0x04003618 RID: 13848
		private static readonly IntPtr NativeFieldInfoPtr_lockDailyRecipesCount;

		// Token: 0x04003619 RID: 13849
		private static readonly IntPtr NativeFieldInfoPtr_lockDailyRecipesDuration;

		// Token: 0x0400361A RID: 13850
		private static readonly IntPtr NativeFieldInfoPtr_shieldSFX;

		// Token: 0x0400361B RID: 13851
		private static readonly IntPtr NativeFieldInfoPtr_shieldEffectParent;

		// Token: 0x0400361C RID: 13852
		private static readonly IntPtr NativeFieldInfoPtr_shieldEffectEndOffset;

		// Token: 0x0400361D RID: 13853
		private static readonly IntPtr NativeFieldInfoPtr_sphereGenerateSFX;

		// Token: 0x0400361E RID: 13854
		private static readonly IntPtr NativeFieldInfoPtr_shieldEffectEndParrent;

		// Token: 0x0400361F RID: 13855
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereEffectStart;

		// Token: 0x04003620 RID: 13856
		private static readonly IntPtr NativeFieldInfoPtr_magicStartDuration;

		// Token: 0x04003621 RID: 13857
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereEffect;

		// Token: 0x04003622 RID: 13858
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereEffectDetonate;

		// Token: 0x04003623 RID: 13859
		private static readonly IntPtr NativeFieldInfoPtr_sphereLaunchSFX;

		// Token: 0x04003624 RID: 13860
		private static readonly IntPtr NativeFieldInfoPtr_sphereDetonateSFX;

		// Token: 0x04003625 RID: 13861
		private static readonly IntPtr NativeFieldInfoPtr_magicDetonateDuration;

		// Token: 0x04003626 RID: 13862
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereLaunchOffset;

		// Token: 0x04003627 RID: 13863
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereLaunchSpeed;

		// Token: 0x04003628 RID: 13864
		private static readonly IntPtr NativeFieldInfoPtr_sealSFX;

		// Token: 0x04003629 RID: 13865
		private static readonly IntPtr NativeFieldInfoPtr_sealSFXOffset;

		// Token: 0x0400362A RID: 13866
		private static readonly IntPtr NativeFieldInfoPtr_sealEffect;

		// Token: 0x0400362B RID: 13867
		private static readonly IntPtr NativeFieldInfoPtr_sealEffectDuration;

		// Token: 0x0400362C RID: 13868
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereMaxAnglerSpeed;

		// Token: 0x0400362D RID: 13869
		private static readonly IntPtr NativeFieldInfoPtr_magicSphereMinAnglerSpeed;

		// Token: 0x0400362E RID: 13870
		private static readonly IntPtr NativeFieldInfoPtr_magicHitCameraShakeAmplitude;

		// Token: 0x0400362F RID: 13871
		private static readonly IntPtr NativeFieldInfoPtr_magicEndCameraShakeAmplitude;

		// Token: 0x04003630 RID: 13872
		private static readonly IntPtr NativeFieldInfoPtr_magicEndCameraShakeDuration;

		// Token: 0x04003631 RID: 13873
		private static readonly IntPtr NativeFieldInfoPtr_magicEndCameraShakeFadeDuration;

		// Token: 0x04003632 RID: 13874
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003633 RID: 13875
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003634 RID: 13876
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003635 RID: 13877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B94 RID: 2964
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D94C RID: 55628 RVA: 0x0034D9A8 File Offset: 0x0034BBA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr);
				Spell_Reimu.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				Spell_Reimu.__c__DisplayClass28_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, "instance");
				Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, 100679347);
				Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, 100679348);
				Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, 100679349);
				Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, 100679350);
			}

			// Token: 0x0600D94D RID: 55629 RVA: 0x0034DA4C File Offset: 0x0034BC4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D94E RID: 55630 RVA: 0x0034DA88 File Offset: 0x0034BC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201640, XrefRangeEnd = 201647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D94F RID: 55631 RVA: 0x0034DABC File Offset: 0x0034BCBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201647, XrefRangeEnd = 201652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D950 RID: 55632 RVA: 0x0034DAFC File Offset: 0x0034BCFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201652, XrefRangeEnd = 201659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D951 RID: 55633 RVA: 0x000743F5 File Offset: 0x000725F5
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046AB RID: 18091
			// (get) Token: 0x0600D952 RID: 55634 RVA: 0x0034DB30 File Offset: 0x0034BD30
			// (set) Token: 0x0600D953 RID: 55635 RVA: 0x000743FE File Offset: 0x000725FE
			public unsafe Spell_Reimu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046AC RID: 18092
			// (get) Token: 0x0600D954 RID: 55636 RVA: 0x0034DB60 File Offset: 0x0034BD60
			// (set) Token: 0x0600D955 RID: 55637 RVA: 0x0007441D File Offset: 0x0007261D
			public unsafe GameObject instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B4A RID: 35658
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B4B RID: 35659
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04008B4C RID: 35660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B4D RID: 35661
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008B4E RID: 35662
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008B4F RID: 35663
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x02001039 RID: 4153
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c__DisplayClass28_0+<<OnPositiveBuffExecute>g__Delay|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C44 RID: 72772 RVA: 0x0041174C File Offset: 0x0040F94C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Delay|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679351);
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679352);
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679353);
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679354);
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679355);
					Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679356);
				}

				// Token: 0x06011C45 RID: 72773 RVA: 0x0041182C File Offset: 0x0040FA2C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C46 RID: 72774 RVA: 0x00411874 File Offset: 0x0040FA74
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C47 RID: 72775 RVA: 0x004118A8 File Offset: 0x0040FAA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201628, XrefRangeEnd = 201634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C87 RID: 23687
				// (get) Token: 0x06011C48 RID: 72776 RVA: 0x004118E4 File Offset: 0x0040FAE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C49 RID: 72777 RVA: 0x00411924 File Offset: 0x0040FB24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201634, XrefRangeEnd = 201640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C88 RID: 23688
				// (get) Token: 0x06011C4A RID: 72778 RVA: 0x00411958 File Offset: 0x0040FB58
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C4B RID: 72779 RVA: 0x0009A6B3 File Offset: 0x000988B3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C84 RID: 23684
				// (get) Token: 0x06011C4C RID: 72780 RVA: 0x00411998 File Offset: 0x0040FB98
				// (set) Token: 0x06011C4D RID: 72781 RVA: 0x0009A6BC File Offset: 0x000988BC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C85 RID: 23685
				// (get) Token: 0x06011C4E RID: 72782 RVA: 0x004119C0 File Offset: 0x0040FBC0
				// (set) Token: 0x06011C4F RID: 72783 RVA: 0x0009A6D7 File Offset: 0x000988D7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C86 RID: 23686
				// (get) Token: 0x06011C50 RID: 72784 RVA: 0x004119F0 File Offset: 0x0040FBF0
				// (set) Token: 0x06011C51 RID: 72785 RVA: 0x0009A6F6 File Offset: 0x000988F6
				public unsafe Spell_Reimu.__c__DisplayClass28_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu.__c__DisplayClass28_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B395 RID: 45973
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B396 RID: 45974
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B397 RID: 45975
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B398 RID: 45976
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B399 RID: 45977
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B39A RID: 45978
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B39B RID: 45979
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B39C RID: 45980
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B39D RID: 45981
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B95 RID: 2965
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<OnPositiveBuffExecute>d__28")]
		public sealed class _OnPositiveBuffExecute_d__28 : Il2CppSystem.Object
		{
			// Token: 0x0600D956 RID: 55638 RVA: 0x0034DB90 File Offset: 0x0034BD90
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__28()
			{
				Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "<OnPositiveBuffExecute>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr);
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>1__state");
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>2__current");
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>4__this");
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679357);
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679358);
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679359);
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679360);
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679361);
				Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679362);
			}

			// Token: 0x0600D957 RID: 55639 RVA: 0x0034DC70 File Offset: 0x0034BE70
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__28(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu._OnPositiveBuffExecute_d__28>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D958 RID: 55640 RVA: 0x0034DCB8 File Offset: 0x0034BEB8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D959 RID: 55641 RVA: 0x0034DCEC File Offset: 0x0034BEEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201659, XrefRangeEnd = 201690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046B0 RID: 18096
			// (get) Token: 0x0600D95A RID: 55642 RVA: 0x0034DD28 File Offset: 0x0034BF28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D95B RID: 55643 RVA: 0x0034DD68 File Offset: 0x0034BF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201690, XrefRangeEnd = 201696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046B1 RID: 18097
			// (get) Token: 0x0600D95C RID: 55644 RVA: 0x0034DD9C File Offset: 0x0034BF9C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D95D RID: 55645 RVA: 0x0007443C File Offset: 0x0007263C
			public _OnPositiveBuffExecute_d__28(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046AD RID: 18093
			// (get) Token: 0x0600D95E RID: 55646 RVA: 0x0034DDDC File Offset: 0x0034BFDC
			// (set) Token: 0x0600D95F RID: 55647 RVA: 0x00074445 File Offset: 0x00072645
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046AE RID: 18094
			// (get) Token: 0x0600D960 RID: 55648 RVA: 0x0034DE04 File Offset: 0x0034C004
			// (set) Token: 0x0600D961 RID: 55649 RVA: 0x00074460 File Offset: 0x00072660
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046AF RID: 18095
			// (get) Token: 0x0600D962 RID: 55650 RVA: 0x0034DE34 File Offset: 0x0034C034
			// (set) Token: 0x0600D963 RID: 55651 RVA: 0x0007447F File Offset: 0x0007267F
			public unsafe Spell_Reimu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B50 RID: 35664
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B51 RID: 35665
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B52 RID: 35666
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B53 RID: 35667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B54 RID: 35668
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B55 RID: 35669
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B56 RID: 35670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B57 RID: 35671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B58 RID: 35672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B96 RID: 2966
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D964 RID: 55652 RVA: 0x0034DE64 File Offset: 0x0034C064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr);
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_characterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "characterPosition");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_hasStartCameraShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "hasStartCameraShake");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_processCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "processCount");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "reference");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "recipe");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_initialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "initialization");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_canExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "canExit");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>9__9");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>9__11");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>9__12");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>9__14");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>9__15");
				Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<>9__16");
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679363);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679364);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679365);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679366);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679367);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679368);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679369);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679370);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679371);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679372);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__15_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679373);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__16_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679374);
				Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, 100679375);
			}

			// Token: 0x0600D965 RID: 55653 RVA: 0x0034E0AC File Offset: 0x0034C2AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D966 RID: 55654 RVA: 0x0034E0E8 File Offset: 0x0034C2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201705, XrefRangeEnd = 201707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D967 RID: 55655 RVA: 0x0034E12C File Offset: 0x0034C32C
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D968 RID: 55656 RVA: 0x0034E168 File Offset: 0x0034C368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201707, XrefRangeEnd = 201728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__6(GameObject d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D969 RID: 55657 RVA: 0x0034E1AC File Offset: 0x0034C3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201728, XrefRangeEnd = 201733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__9(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96A RID: 55658 RVA: 0x0034E1F0 File Offset: 0x0034C3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201733, XrefRangeEnd = 201783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7(GameObject b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96B RID: 55659 RVA: 0x0034E234 File Offset: 0x0034C434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__11(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96C RID: 55660 RVA: 0x0034E278 File Offset: 0x0034C478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201783, XrefRangeEnd = 201788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__12(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96D RID: 55661 RVA: 0x0034E2BC File Offset: 0x0034C4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201788, XrefRangeEnd = 201841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__8(GameObject c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96E RID: 55662 RVA: 0x0034E300 File Offset: 0x0034C500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__14(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96F RID: 55663 RVA: 0x0034E344 File Offset: 0x0034C544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__15(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__15_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D970 RID: 55664 RVA: 0x0034E388 File Offset: 0x0034C588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201841, XrefRangeEnd = 201846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__16(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__16_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D971 RID: 55665 RVA: 0x0034E3CC File Offset: 0x0034C5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201846, XrefRangeEnd = 201851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D972 RID: 55666 RVA: 0x0007449E File Offset: 0x0007269E
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046B2 RID: 18098
			// (get) Token: 0x0600D973 RID: 55667 RVA: 0x0034E40C File Offset: 0x0034C60C
			// (set) Token: 0x0600D974 RID: 55668 RVA: 0x000744A7 File Offset: 0x000726A7
			public unsafe Vector3 characterPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_characterPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_characterPosition)) = value;
				}
			}

			// Token: 0x170046B3 RID: 18099
			// (get) Token: 0x0600D975 RID: 55669 RVA: 0x0034E434 File Offset: 0x0034C634
			// (set) Token: 0x0600D976 RID: 55670 RVA: 0x000744C2 File Offset: 0x000726C2
			public unsafe Spell_Reimu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B4 RID: 18100
			// (get) Token: 0x0600D977 RID: 55671 RVA: 0x0034E464 File Offset: 0x0034C664
			// (set) Token: 0x0600D978 RID: 55672 RVA: 0x000744E1 File Offset: 0x000726E1
			public unsafe bool hasStartCameraShake
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_hasStartCameraShake);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_hasStartCameraShake)) = value;
				}
			}

			// Token: 0x170046B5 RID: 18101
			// (get) Token: 0x0600D979 RID: 55673 RVA: 0x0034E48C File Offset: 0x0034C68C
			// (set) Token: 0x0600D97A RID: 55674 RVA: 0x000744FC File Offset: 0x000726FC
			public unsafe int processCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_processCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_processCount)) = value;
				}
			}

			// Token: 0x170046B6 RID: 18102
			// (get) Token: 0x0600D97B RID: 55675 RVA: 0x0034E4B4 File Offset: 0x0034C6B4
			// (set) Token: 0x0600D97C RID: 55676 RVA: 0x00074517 File Offset: 0x00072717
			public unsafe GameObject reference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_reference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_reference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B7 RID: 18103
			// (get) Token: 0x0600D97D RID: 55677 RVA: 0x0034E4E4 File Offset: 0x0034C6E4
			// (set) Token: 0x0600D97E RID: 55678 RVA: 0x00074536 File Offset: 0x00072736
			public unsafe Il2CppReferenceArray<Recipe> recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B8 RID: 18104
			// (get) Token: 0x0600D97F RID: 55679 RVA: 0x0034E514 File Offset: 0x0034C714
			// (set) Token: 0x0600D980 RID: 55680 RVA: 0x00074555 File Offset: 0x00072755
			public unsafe Action<GameObject> initialization
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_initialization);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_initialization), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B9 RID: 18105
			// (get) Token: 0x0600D981 RID: 55681 RVA: 0x0034E544 File Offset: 0x0034C744
			// (set) Token: 0x0600D982 RID: 55682 RVA: 0x00074574 File Offset: 0x00072774
			public unsafe bool canExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_canExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr_canExit)) = value;
				}
			}

			// Token: 0x170046BA RID: 18106
			// (get) Token: 0x0600D983 RID: 55683 RVA: 0x0034E56C File Offset: 0x0034C76C
			// (set) Token: 0x0600D984 RID: 55684 RVA: 0x0007458F File Offset: 0x0007278F
			public unsafe Action<SpriteRenderer> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BB RID: 18107
			// (get) Token: 0x0600D985 RID: 55685 RVA: 0x0034E59C File Offset: 0x0034C79C
			// (set) Token: 0x0600D986 RID: 55686 RVA: 0x000745AE File Offset: 0x000727AE
			public unsafe Action<SpriteRenderer> __9__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BC RID: 18108
			// (get) Token: 0x0600D987 RID: 55687 RVA: 0x0034E5CC File Offset: 0x0034C7CC
			// (set) Token: 0x0600D988 RID: 55688 RVA: 0x000745CD File Offset: 0x000727CD
			public unsafe Action<SpriteRenderer> __9__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BD RID: 18109
			// (get) Token: 0x0600D989 RID: 55689 RVA: 0x0034E5FC File Offset: 0x0034C7FC
			// (set) Token: 0x0600D98A RID: 55690 RVA: 0x000745EC File Offset: 0x000727EC
			public unsafe Action<SpriteRenderer> __9__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BE RID: 18110
			// (get) Token: 0x0600D98B RID: 55691 RVA: 0x0034E62C File Offset: 0x0034C82C
			// (set) Token: 0x0600D98C RID: 55692 RVA: 0x0007460B File Offset: 0x0007280B
			public unsafe Action<SpriteRenderer> __9__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__15);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__15), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BF RID: 18111
			// (get) Token: 0x0600D98D RID: 55693 RVA: 0x0034E65C File Offset: 0x0034C85C
			// (set) Token: 0x0600D98E RID: 55694 RVA: 0x0007462A File Offset: 0x0007282A
			public unsafe Action<SpriteRenderer> __9__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.NativeFieldInfoPtr___9__16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B59 RID: 35673
			private static readonly IntPtr NativeFieldInfoPtr_characterPosition;

			// Token: 0x04008B5A RID: 35674
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B5B RID: 35675
			private static readonly IntPtr NativeFieldInfoPtr_hasStartCameraShake;

			// Token: 0x04008B5C RID: 35676
			private static readonly IntPtr NativeFieldInfoPtr_processCount;

			// Token: 0x04008B5D RID: 35677
			private static readonly IntPtr NativeFieldInfoPtr_reference;

			// Token: 0x04008B5E RID: 35678
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x04008B5F RID: 35679
			private static readonly IntPtr NativeFieldInfoPtr_initialization;

			// Token: 0x04008B60 RID: 35680
			private static readonly IntPtr NativeFieldInfoPtr_canExit;

			// Token: 0x04008B61 RID: 35681
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x04008B62 RID: 35682
			private static readonly IntPtr NativeFieldInfoPtr___9__11;

			// Token: 0x04008B63 RID: 35683
			private static readonly IntPtr NativeFieldInfoPtr___9__12;

			// Token: 0x04008B64 RID: 35684
			private static readonly IntPtr NativeFieldInfoPtr___9__14;

			// Token: 0x04008B65 RID: 35685
			private static readonly IntPtr NativeFieldInfoPtr___9__15;

			// Token: 0x04008B66 RID: 35686
			private static readonly IntPtr NativeFieldInfoPtr___9__16;

			// Token: 0x04008B67 RID: 35687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B68 RID: 35688
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008B69 RID: 35689
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Boolean_0;

			// Token: 0x04008B6A RID: 35690
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_GameObject_0;

			// Token: 0x04008B6B RID: 35691
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008B6C RID: 35692
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0;

			// Token: 0x04008B6D RID: 35693
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008B6E RID: 35694
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008B6F RID: 35695
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_GameObject_0;

			// Token: 0x04008B70 RID: 35696
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008B71 RID: 35697
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__15_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008B72 RID: 35698
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__16_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008B73 RID: 35699
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200103A RID: 4154
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c__DisplayClass29_0+<<OnNegativeBuffExecute>g__Delay|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C52 RID: 72786 RVA: 0x00411A20 File Offset: 0x0040FC20
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Delay|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679376);
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679377);
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679378);
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679379);
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679380);
					Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679381);
				}

				// Token: 0x06011C53 RID: 72787 RVA: 0x00411B00 File Offset: 0x0040FD00
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C54 RID: 72788 RVA: 0x00411B48 File Offset: 0x0040FD48
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C55 RID: 72789 RVA: 0x00411B7C File Offset: 0x0040FD7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201696, XrefRangeEnd = 201699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C8C RID: 23692
				// (get) Token: 0x06011C56 RID: 72790 RVA: 0x00411BB8 File Offset: 0x0040FDB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C57 RID: 72791 RVA: 0x00411BF8 File Offset: 0x0040FDF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201699, XrefRangeEnd = 201705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C8D RID: 23693
				// (get) Token: 0x06011C58 RID: 72792 RVA: 0x00411C2C File Offset: 0x0040FE2C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C59 RID: 72793 RVA: 0x0009A715 File Offset: 0x00098915
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C89 RID: 23689
				// (get) Token: 0x06011C5A RID: 72794 RVA: 0x00411C6C File Offset: 0x0040FE6C
				// (set) Token: 0x06011C5B RID: 72795 RVA: 0x0009A71E File Offset: 0x0009891E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C8A RID: 23690
				// (get) Token: 0x06011C5C RID: 72796 RVA: 0x00411C94 File Offset: 0x0040FE94
				// (set) Token: 0x06011C5D RID: 72797 RVA: 0x0009A739 File Offset: 0x00098939
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C8B RID: 23691
				// (get) Token: 0x06011C5E RID: 72798 RVA: 0x00411CC4 File Offset: 0x0040FEC4
				// (set) Token: 0x06011C5F RID: 72799 RVA: 0x0009A758 File Offset: 0x00098958
				public unsafe Spell_Reimu.__c__DisplayClass29_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu.__c__DisplayClass29_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B39E RID: 45982
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B39F RID: 45983
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3A0 RID: 45984
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3A1 RID: 45985
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3A2 RID: 45986
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3A3 RID: 45987
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3A4 RID: 45988
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3A5 RID: 45989
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3A6 RID: 45990
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B97 RID: 2967
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D98F RID: 55695 RVA: 0x0034E68C File Offset: 0x0034C88C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr);
				Spell_Reimu.__c__DisplayClass29_1.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr, "item");
				Spell_Reimu.__c__DisplayClass29_1.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Reimu.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr, 100679382);
				Spell_Reimu.__c__DisplayClass29_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr, 100679383);
			}

			// Token: 0x0600D990 RID: 55696 RVA: 0x0034E708 File Offset: 0x0034C908
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D991 RID: 55697 RVA: 0x0034E744 File Offset: 0x0034C944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201898, XrefRangeEnd = 201903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D992 RID: 55698 RVA: 0x00074649 File Offset: 0x00072849
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C0 RID: 18112
			// (get) Token: 0x0600D993 RID: 55699 RVA: 0x0034E784 File Offset: 0x0034C984
			// (set) Token: 0x0600D994 RID: 55700 RVA: 0x00074652 File Offset: 0x00072852
			public unsafe Transform item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C1 RID: 18113
			// (get) Token: 0x0600D995 RID: 55701 RVA: 0x0034E7B4 File Offset: 0x0034C9B4
			// (set) Token: 0x0600D996 RID: 55702 RVA: 0x00074671 File Offset: 0x00072871
			public unsafe Spell_Reimu.__c__DisplayClass29_0 field_Public___c__DisplayClass29_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu.__c__DisplayClass29_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B74 RID: 35700
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008B75 RID: 35701
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0;

			// Token: 0x04008B76 RID: 35702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B77 RID: 35703
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200103B RID: 4155
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c__DisplayClass29_1+<<OnNegativeBuffExecute>g__Do|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C60 RID: 72800 RVA: 0x00411CF4 File Offset: 0x0040FEF4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique()
				{
					Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Do|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr);
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__obj_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<obj>5__2");
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679384);
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679385);
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679386);
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679387);
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679388);
					Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100679389);
				}

				// Token: 0x06011C61 RID: 72801 RVA: 0x00411DE8 File Offset: 0x0040FFE8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C62 RID: 72802 RVA: 0x00411E30 File Offset: 0x00410030
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C63 RID: 72803 RVA: 0x00411E64 File Offset: 0x00410064
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201851, XrefRangeEnd = 201892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C92 RID: 23698
				// (get) Token: 0x06011C64 RID: 72804 RVA: 0x00411EA0 File Offset: 0x004100A0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C65 RID: 72805 RVA: 0x00411EE0 File Offset: 0x004100E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201892, XrefRangeEnd = 201898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C93 RID: 23699
				// (get) Token: 0x06011C66 RID: 72806 RVA: 0x00411F14 File Offset: 0x00410114
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C67 RID: 72807 RVA: 0x0009A777 File Offset: 0x00098977
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C8E RID: 23694
				// (get) Token: 0x06011C68 RID: 72808 RVA: 0x00411F54 File Offset: 0x00410154
				// (set) Token: 0x06011C69 RID: 72809 RVA: 0x0009A780 File Offset: 0x00098980
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C8F RID: 23695
				// (get) Token: 0x06011C6A RID: 72810 RVA: 0x00411F7C File Offset: 0x0041017C
				// (set) Token: 0x06011C6B RID: 72811 RVA: 0x0009A79B File Offset: 0x0009899B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C90 RID: 23696
				// (get) Token: 0x06011C6C RID: 72812 RVA: 0x00411FAC File Offset: 0x004101AC
				// (set) Token: 0x06011C6D RID: 72813 RVA: 0x0009A7BA File Offset: 0x000989BA
				public unsafe Spell_Reimu.__c__DisplayClass29_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu.__c__DisplayClass29_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C91 RID: 23697
				// (get) Token: 0x06011C6E RID: 72814 RVA: 0x00411FDC File Offset: 0x004101DC
				// (set) Token: 0x06011C6F RID: 72815 RVA: 0x0009A7D9 File Offset: 0x000989D9
				public unsafe Transform _obj_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__obj_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu.__c__DisplayClass29_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__obj_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B3A7 RID: 45991
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3A8 RID: 45992
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3A9 RID: 45993
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3AA RID: 45994
				private static readonly IntPtr NativeFieldInfoPtr__obj_5__2;

				// Token: 0x0400B3AB RID: 45995
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3AC RID: 45996
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3AD RID: 45997
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3AE RID: 45998
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3AF RID: 45999
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3B0 RID: 46000
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B98 RID: 2968
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D997 RID: 55703 RVA: 0x0034E7E4 File Offset: 0x0034C9E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr);
				Spell_Reimu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, "<>9");
				Spell_Reimu.__c.NativeFieldInfoPtr___9__29_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, "<>9__29_4");
				Spell_Reimu.__c.NativeFieldInfoPtr___9__29_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, "<>9__29_5");
				Spell_Reimu.__c.NativeFieldInfoPtr___9__29_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, "<>9__29_10");
				Spell_Reimu.__c.NativeFieldInfoPtr___9__29_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, "<>9__29_13");
				Spell_Reimu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, 100679391);
				Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, 100679392);
				Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_5_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, 100679393);
				Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_10_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, 100679394);
				Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_13_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr, 100679395);
			}

			// Token: 0x0600D998 RID: 55704 RVA: 0x0034E8D8 File Offset: 0x0034CAD8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D999 RID: 55705 RVA: 0x0034E914 File Offset: 0x0034CB14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201903, XrefRangeEnd = 201904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__29_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D99A RID: 55706 RVA: 0x0034E950 File Offset: 0x0034CB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201904, XrefRangeEnd = 201907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__29_5(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_5_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D99B RID: 55707 RVA: 0x0034E994 File Offset: 0x0034CB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201907, XrefRangeEnd = 201911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__29_10(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_10_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D99C RID: 55708 RVA: 0x0034E9D8 File Offset: 0x0034CBD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201911, XrefRangeEnd = 201915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__29_13(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_13_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D99D RID: 55709 RVA: 0x00074690 File Offset: 0x00072890
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C2 RID: 18114
			// (get) Token: 0x0600D99E RID: 55710 RVA: 0x0034EA1C File Offset: 0x0034CC1C
			// (set) Token: 0x0600D99F RID: 55711 RVA: 0x00074699 File Offset: 0x00072899
			public unsafe static Spell_Reimu.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reimu.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reimu.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C3 RID: 18115
			// (get) Token: 0x0600D9A0 RID: 55712 RVA: 0x0034EA44 File Offset: 0x0034CC44
			// (set) Token: 0x0600D9A1 RID: 55713 RVA: 0x000746AB File Offset: 0x000728AB
			public unsafe static Func<Vector3> __9__29_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C4 RID: 18116
			// (get) Token: 0x0600D9A2 RID: 55714 RVA: 0x0034EA6C File Offset: 0x0034CC6C
			// (set) Token: 0x0600D9A3 RID: 55715 RVA: 0x000746BD File Offset: 0x000728BD
			public unsafe static Action<GameObject> __9__29_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C5 RID: 18117
			// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x0034EA94 File Offset: 0x0034CC94
			// (set) Token: 0x0600D9A5 RID: 55717 RVA: 0x000746CF File Offset: 0x000728CF
			public unsafe static Action<Transform> __9__29_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C6 RID: 18118
			// (get) Token: 0x0600D9A6 RID: 55718 RVA: 0x0034EABC File Offset: 0x0034CCBC
			// (set) Token: 0x0600D9A7 RID: 55719 RVA: 0x000746E1 File Offset: 0x000728E1
			public unsafe static Action<Transform> __9__29_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reimu.__c.NativeFieldInfoPtr___9__29_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B78 RID: 35704
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B79 RID: 35705
			private static readonly IntPtr NativeFieldInfoPtr___9__29_4;

			// Token: 0x04008B7A RID: 35706
			private static readonly IntPtr NativeFieldInfoPtr___9__29_5;

			// Token: 0x04008B7B RID: 35707
			private static readonly IntPtr NativeFieldInfoPtr___9__29_10;

			// Token: 0x04008B7C RID: 35708
			private static readonly IntPtr NativeFieldInfoPtr___9__29_13;

			// Token: 0x04008B7D RID: 35709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B7E RID: 35710
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_4_Internal_Vector3_0;

			// Token: 0x04008B7F RID: 35711
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_5_Internal_Void_GameObject_0;

			// Token: 0x04008B80 RID: 35712
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_10_Internal_Void_Transform_0;

			// Token: 0x04008B81 RID: 35713
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__29_13_Internal_Void_Transform_0;
		}

		// Token: 0x02000B99 RID: 2969
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reimu+<OnNegativeBuffExecute>d__29")]
		public sealed class _OnNegativeBuffExecute_d__29 : Il2CppSystem.Object
		{
			// Token: 0x0600D9A8 RID: 55720 RVA: 0x0034EAE4 File Offset: 0x0034CCE4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__29()
			{
				Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reimu>.NativeClassPtr, "<OnNegativeBuffExecute>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr);
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<>1__state");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<>2__current");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<>4__this");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "spellExecutionContext");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<>8__1");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__instance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<instance>5__2");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__a_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<a>5__3");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__controlledUIElements_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, "<controlledUIElements>5__4");
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, 100679396);
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, 100679397);
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, 100679398);
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, 100679399);
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, 100679400);
				Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr, 100679401);
			}

			// Token: 0x0600D9A9 RID: 55721 RVA: 0x0034EC28 File Offset: 0x0034CE28
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__29(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reimu._OnNegativeBuffExecute_d__29>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9AA RID: 55722 RVA: 0x0034EC70 File Offset: 0x0034CE70
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9AB RID: 55723 RVA: 0x0034ECA4 File Offset: 0x0034CEA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201915, XrefRangeEnd = 201972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046CF RID: 18127
			// (get) Token: 0x0600D9AC RID: 55724 RVA: 0x0034ECE0 File Offset: 0x0034CEE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9AD RID: 55725 RVA: 0x0034ED20 File Offset: 0x0034CF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201972, XrefRangeEnd = 201978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046D0 RID: 18128
			// (get) Token: 0x0600D9AE RID: 55726 RVA: 0x0034ED54 File Offset: 0x0034CF54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9AF RID: 55727 RVA: 0x000746F3 File Offset: 0x000728F3
			public _OnNegativeBuffExecute_d__29(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C7 RID: 18119
			// (get) Token: 0x0600D9B0 RID: 55728 RVA: 0x0034ED94 File Offset: 0x0034CF94
			// (set) Token: 0x0600D9B1 RID: 55729 RVA: 0x000746FC File Offset: 0x000728FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046C8 RID: 18120
			// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x0034EDBC File Offset: 0x0034CFBC
			// (set) Token: 0x0600D9B3 RID: 55731 RVA: 0x00074717 File Offset: 0x00072917
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C9 RID: 18121
			// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x0034EDEC File Offset: 0x0034CFEC
			// (set) Token: 0x0600D9B5 RID: 55733 RVA: 0x00074736 File Offset: 0x00072936
			public unsafe Spell_Reimu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CA RID: 18122
			// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x0034EE1C File Offset: 0x0034D01C
			// (set) Token: 0x0600D9B7 RID: 55735 RVA: 0x00074755 File Offset: 0x00072955
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CB RID: 18123
			// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x0034EE4C File Offset: 0x0034D04C
			// (set) Token: 0x0600D9B9 RID: 55737 RVA: 0x00074774 File Offset: 0x00072974
			public unsafe Spell_Reimu.__c__DisplayClass29_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reimu.__c__DisplayClass29_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CC RID: 18124
			// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x0034EE7C File Offset: 0x0034D07C
			// (set) Token: 0x0600D9BB RID: 55739 RVA: 0x00074793 File Offset: 0x00072993
			public unsafe GameObject _instance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__instance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__instance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CD RID: 18125
			// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x0034EEAC File Offset: 0x0034D0AC
			// (set) Token: 0x0600D9BD RID: 55741 RVA: 0x000747B2 File Offset: 0x000729B2
			public unsafe Animator _a_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__a_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__a_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CE RID: 18126
			// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x0034EEDC File Offset: 0x0034D0DC
			// (set) Token: 0x0600D9BF RID: 55743 RVA: 0x000747D1 File Offset: 0x000729D1
			public unsafe Il2CppReferenceArray<Transform> _controlledUIElements_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__controlledUIElements_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reimu._OnNegativeBuffExecute_d__29.NativeFieldInfoPtr__controlledUIElements_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B82 RID: 35714
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B83 RID: 35715
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B84 RID: 35716
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B85 RID: 35717
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008B86 RID: 35718
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008B87 RID: 35719
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__2;

			// Token: 0x04008B88 RID: 35720
			private static readonly IntPtr NativeFieldInfoPtr__a_5__3;

			// Token: 0x04008B89 RID: 35721
			private static readonly IntPtr NativeFieldInfoPtr__controlledUIElements_5__4;

			// Token: 0x04008B8A RID: 35722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B8B RID: 35723
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B8C RID: 35724
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B8D RID: 35725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B8E RID: 35726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B8F RID: 35727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
