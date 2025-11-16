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
	// Token: 0x02000271 RID: 625
	public class Spell_Mima : SpellBase
	{
		// Token: 0x06004E46 RID: 20038 RVA: 0x001AB788 File Offset: 0x001A9988
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Mima()
		{
			Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Mima");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr);
			Spell_Mima.NativeFieldInfoPtr_greatMagicNeedEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "greatMagicNeedEnergy");
			Spell_Mima.NativeFieldInfoPtr_mimaGreatMagicGetEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "mimaGreatMagicGetEnergy");
			Spell_Mima.NativeFieldInfoPtr_otherGuestGreatMagicGetEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "otherGuestGreatMagicGetEnergy");
			Spell_Mima.NativeFieldInfoPtr_greatMagicPlusDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "greatMagicPlusDuration");
			Spell_Mima.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "negativeDuration");
			Spell_Mima.NativeFieldInfoPtr_magicVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "magicVfx");
			Spell_Mima.NativeFieldInfoPtr_shieldEffectEndParrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "shieldEffectEndParrent");
			Spell_Mima.NativeFieldInfoPtr_shieldEffectEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "shieldEffectEndOffset");
			Spell_Mima.NativeFieldInfoPtr_magicShiningTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "magicShiningTime");
			Spell_Mima.NativeFieldInfoPtr_greatMagicVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "greatMagicVfx");
			Spell_Mima.NativeFieldInfoPtr_ghostVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "ghostVfx");
			Spell_Mima.NativeFieldInfoPtr_ghostVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "ghostVfxOffset");
			Spell_Mima.NativeFieldInfoPtr_shadowVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "shadowVfx");
			Spell_Mima.NativeFieldInfoPtr_shadowVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "shadowVfxOffset");
			Spell_Mima.NativeFieldInfoPtr_shadowDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "shadowDelay");
			Spell_Mima.NativeFieldInfoPtr_ghostDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "ghostDelay");
			Spell_Mima.NativeFieldInfoPtr_shadowSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "shadowSfx");
			Spell_Mima.NativeFieldInfoPtr_ghostSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "ghostSfx");
			Spell_Mima.NativeFieldInfoPtr_magicSpawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "magicSpawnSfx");
			Spell_Mima.NativeFieldInfoPtr_magicEnergySfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "magicEnergySfx");
			Spell_Mima.NativeFieldInfoPtr_magicBurstSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "magicBurstSfx");
			Spell_Mima.NativeFieldInfoPtr_MIMA_MAGIC_OBJECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "MIMA_MAGIC_OBJECT");
			Spell_Mima.NativeFieldInfoPtr_MIMA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "MIMA_ID");
			Spell_Mima.NativeFieldInfoPtr_MARISA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "MARISA_ID");
			Spell_Mima.NativeFieldInfoPtr_REIMU_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "REIMU_ID");
			Spell_Mima.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679019);
			Spell_Mima.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679020);
			Spell_Mima.NativeMethodInfoPtr_MimaMagicEnergyGet_Private_Void_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679021);
			Spell_Mima.NativeMethodInfoPtr_AddEnergyForMagic_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679022);
			Spell_Mima.NativeMethodInfoPtr_CheckGreatMagicEnergy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679023);
			Spell_Mima.NativeMethodInfoPtr_MimaGreatMagic_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679024);
			Spell_Mima.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679025);
			Spell_Mima.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, 100679026);
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x001ABA4C File Offset: 0x001A9C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200185, XrefRangeEnd = 200187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mima.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x001ABA90 File Offset: 0x001A9C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200187, XrefRangeEnd = 200192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mima.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x001ABAEC File Offset: 0x001A9CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200192, XrefRangeEnd = 200193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MimaMagicEnergyGet(SpecialGuestsController specialGuestsController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestsController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.NativeMethodInfoPtr_MimaMagicEnergyGet_Private_Void_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x001ABB30 File Offset: 0x001A9D30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200225, RefRangeEnd = 200227, XrefRangeStart = 200193, XrefRangeEnd = 200225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEnergyForMagic(int addEnergy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref addEnergy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.NativeMethodInfoPtr_AddEnergyForMagic_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x001ABB70 File Offset: 0x001A9D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200227, XrefRangeEnd = 200237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckGreatMagicEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.NativeMethodInfoPtr_CheckGreatMagicEnergy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x001ABBA4 File Offset: 0x001A9DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200237, XrefRangeEnd = 200242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MimaGreatMagic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.NativeMethodInfoPtr_MimaGreatMagic_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x001ABBE4 File Offset: 0x001A9DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200242, XrefRangeEnd = 200247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mima.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x001ABC40 File Offset: 0x001A9E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200247, XrefRangeEnd = 200248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Mima() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00028F54 File Offset: 0x00027154
		public Spell_Mima(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x001ABC7C File Offset: 0x001A9E7C
		// (set) Token: 0x06004E51 RID: 20049 RVA: 0x00028F5D File Offset: 0x0002715D
		public unsafe int greatMagicNeedEnergy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_greatMagicNeedEnergy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_greatMagicNeedEnergy)) = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x001ABCA4 File Offset: 0x001A9EA4
		// (set) Token: 0x06004E53 RID: 20051 RVA: 0x00028F78 File Offset: 0x00027178
		public unsafe int mimaGreatMagicGetEnergy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_mimaGreatMagicGetEnergy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_mimaGreatMagicGetEnergy)) = value;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x001ABCCC File Offset: 0x001A9ECC
		// (set) Token: 0x06004E55 RID: 20053 RVA: 0x00028F93 File Offset: 0x00027193
		public unsafe int otherGuestGreatMagicGetEnergy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_otherGuestGreatMagicGetEnergy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_otherGuestGreatMagicGetEnergy)) = value;
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x001ABCF4 File Offset: 0x001A9EF4
		// (set) Token: 0x06004E57 RID: 20055 RVA: 0x00028FAE File Offset: 0x000271AE
		public unsafe int greatMagicPlusDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_greatMagicPlusDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_greatMagicPlusDuration)) = value;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06004E58 RID: 20056 RVA: 0x001ABD1C File Offset: 0x001A9F1C
		// (set) Token: 0x06004E59 RID: 20057 RVA: 0x00028FC9 File Offset: 0x000271C9
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06004E5A RID: 20058 RVA: 0x001ABD44 File Offset: 0x001A9F44
		// (set) Token: 0x06004E5B RID: 20059 RVA: 0x00028FE4 File Offset: 0x000271E4
		public unsafe GameObject magicVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x001ABD74 File Offset: 0x001A9F74
		// (set) Token: 0x06004E5D RID: 20061 RVA: 0x00029003 File Offset: 0x00027203
		public unsafe GameObject shieldEffectEndParrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shieldEffectEndParrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shieldEffectEndParrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06004E5E RID: 20062 RVA: 0x001ABDA4 File Offset: 0x001A9FA4
		// (set) Token: 0x06004E5F RID: 20063 RVA: 0x00029022 File Offset: 0x00027222
		public unsafe float shieldEffectEndOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shieldEffectEndOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shieldEffectEndOffset)) = value;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06004E60 RID: 20064 RVA: 0x001ABDCC File Offset: 0x001A9FCC
		// (set) Token: 0x06004E61 RID: 20065 RVA: 0x0002903D File Offset: 0x0002723D
		public unsafe float magicShiningTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicShiningTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicShiningTime)) = value;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06004E62 RID: 20066 RVA: 0x001ABDF4 File Offset: 0x001A9FF4
		// (set) Token: 0x06004E63 RID: 20067 RVA: 0x00029058 File Offset: 0x00027258
		public unsafe GameObject greatMagicVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_greatMagicVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_greatMagicVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06004E64 RID: 20068 RVA: 0x001ABE24 File Offset: 0x001AA024
		// (set) Token: 0x06004E65 RID: 20069 RVA: 0x00029077 File Offset: 0x00027277
		public unsafe GameObject ghostVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06004E66 RID: 20070 RVA: 0x001ABE54 File Offset: 0x001AA054
		// (set) Token: 0x06004E67 RID: 20071 RVA: 0x00029096 File Offset: 0x00027296
		public unsafe Vector3 ghostVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostVfxOffset)) = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06004E68 RID: 20072 RVA: 0x001ABE7C File Offset: 0x001AA07C
		// (set) Token: 0x06004E69 RID: 20073 RVA: 0x000290B1 File Offset: 0x000272B1
		public unsafe GameObject shadowVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06004E6A RID: 20074 RVA: 0x001ABEAC File Offset: 0x001AA0AC
		// (set) Token: 0x06004E6B RID: 20075 RVA: 0x000290D0 File Offset: 0x000272D0
		public unsafe Vector3 shadowVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowVfxOffset)) = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x001ABED4 File Offset: 0x001AA0D4
		// (set) Token: 0x06004E6D RID: 20077 RVA: 0x000290EB File Offset: 0x000272EB
		public unsafe float shadowDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowDelay)) = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06004E6E RID: 20078 RVA: 0x001ABEFC File Offset: 0x001AA0FC
		// (set) Token: 0x06004E6F RID: 20079 RVA: 0x00029106 File Offset: 0x00027306
		public unsafe float ghostDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostDelay)) = value;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x001ABF24 File Offset: 0x001AA124
		// (set) Token: 0x06004E71 RID: 20081 RVA: 0x00029121 File Offset: 0x00027321
		public SpellBase.DelayAudioClip shadowSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_shadowSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06004E72 RID: 20082 RVA: 0x001ABF54 File Offset: 0x001AA154
		// (set) Token: 0x06004E73 RID: 20083 RVA: 0x0002914F File Offset: 0x0002734F
		public SpellBase.DelayAudioClip ghostSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_ghostSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06004E74 RID: 20084 RVA: 0x001ABF84 File Offset: 0x001AA184
		// (set) Token: 0x06004E75 RID: 20085 RVA: 0x0002917D File Offset: 0x0002737D
		public unsafe AudioClip magicSpawnSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicSpawnSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicSpawnSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06004E76 RID: 20086 RVA: 0x001ABFB4 File Offset: 0x001AA1B4
		// (set) Token: 0x06004E77 RID: 20087 RVA: 0x0002919C File Offset: 0x0002739C
		public SpellBase.DelayAudioClip magicEnergySfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicEnergySfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicEnergySfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x001ABFE4 File Offset: 0x001AA1E4
		// (set) Token: 0x06004E79 RID: 20089 RVA: 0x000291CA File Offset: 0x000273CA
		public SpellBase.DelayAudioClip magicBurstSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicBurstSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.NativeFieldInfoPtr_magicBurstSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x001AC014 File Offset: 0x001AA214
		// (set) Token: 0x06004E7B RID: 20091 RVA: 0x000291F8 File Offset: 0x000273F8
		public unsafe static string MIMA_MAGIC_OBJECT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Mima.NativeFieldInfoPtr_MIMA_MAGIC_OBJECT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Mima.NativeFieldInfoPtr_MIMA_MAGIC_OBJECT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06004E7C RID: 20092 RVA: 0x001AC034 File Offset: 0x001AA234
		// (set) Token: 0x06004E7D RID: 20093 RVA: 0x0002920A File Offset: 0x0002740A
		public unsafe static int MIMA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Mima.NativeFieldInfoPtr_MIMA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Mima.NativeFieldInfoPtr_MIMA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06004E7E RID: 20094 RVA: 0x001AC050 File Offset: 0x001AA250
		// (set) Token: 0x06004E7F RID: 20095 RVA: 0x00029218 File Offset: 0x00027418
		public unsafe static int MARISA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Mima.NativeFieldInfoPtr_MARISA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Mima.NativeFieldInfoPtr_MARISA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x001AC06C File Offset: 0x001AA26C
		// (set) Token: 0x06004E81 RID: 20097 RVA: 0x00029226 File Offset: 0x00027426
		public unsafe static int REIMU_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Mima.NativeFieldInfoPtr_REIMU_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Mima.NativeFieldInfoPtr_REIMU_ID, (void*)(&value));
			}
		}

		// Token: 0x0400354B RID: 13643
		private static readonly IntPtr NativeFieldInfoPtr_greatMagicNeedEnergy;

		// Token: 0x0400354C RID: 13644
		private static readonly IntPtr NativeFieldInfoPtr_mimaGreatMagicGetEnergy;

		// Token: 0x0400354D RID: 13645
		private static readonly IntPtr NativeFieldInfoPtr_otherGuestGreatMagicGetEnergy;

		// Token: 0x0400354E RID: 13646
		private static readonly IntPtr NativeFieldInfoPtr_greatMagicPlusDuration;

		// Token: 0x0400354F RID: 13647
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003550 RID: 13648
		private static readonly IntPtr NativeFieldInfoPtr_magicVfx;

		// Token: 0x04003551 RID: 13649
		private static readonly IntPtr NativeFieldInfoPtr_shieldEffectEndParrent;

		// Token: 0x04003552 RID: 13650
		private static readonly IntPtr NativeFieldInfoPtr_shieldEffectEndOffset;

		// Token: 0x04003553 RID: 13651
		private static readonly IntPtr NativeFieldInfoPtr_magicShiningTime;

		// Token: 0x04003554 RID: 13652
		private static readonly IntPtr NativeFieldInfoPtr_greatMagicVfx;

		// Token: 0x04003555 RID: 13653
		private static readonly IntPtr NativeFieldInfoPtr_ghostVfx;

		// Token: 0x04003556 RID: 13654
		private static readonly IntPtr NativeFieldInfoPtr_ghostVfxOffset;

		// Token: 0x04003557 RID: 13655
		private static readonly IntPtr NativeFieldInfoPtr_shadowVfx;

		// Token: 0x04003558 RID: 13656
		private static readonly IntPtr NativeFieldInfoPtr_shadowVfxOffset;

		// Token: 0x04003559 RID: 13657
		private static readonly IntPtr NativeFieldInfoPtr_shadowDelay;

		// Token: 0x0400355A RID: 13658
		private static readonly IntPtr NativeFieldInfoPtr_ghostDelay;

		// Token: 0x0400355B RID: 13659
		private static readonly IntPtr NativeFieldInfoPtr_shadowSfx;

		// Token: 0x0400355C RID: 13660
		private static readonly IntPtr NativeFieldInfoPtr_ghostSfx;

		// Token: 0x0400355D RID: 13661
		private static readonly IntPtr NativeFieldInfoPtr_magicSpawnSfx;

		// Token: 0x0400355E RID: 13662
		private static readonly IntPtr NativeFieldInfoPtr_magicEnergySfx;

		// Token: 0x0400355F RID: 13663
		private static readonly IntPtr NativeFieldInfoPtr_magicBurstSfx;

		// Token: 0x04003560 RID: 13664
		private static readonly IntPtr NativeFieldInfoPtr_MIMA_MAGIC_OBJECT;

		// Token: 0x04003561 RID: 13665
		private static readonly IntPtr NativeFieldInfoPtr_MIMA_ID;

		// Token: 0x04003562 RID: 13666
		private static readonly IntPtr NativeFieldInfoPtr_MARISA_ID;

		// Token: 0x04003563 RID: 13667
		private static readonly IntPtr NativeFieldInfoPtr_REIMU_ID;

		// Token: 0x04003564 RID: 13668
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003565 RID: 13669
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003566 RID: 13670
		private static readonly IntPtr NativeMethodInfoPtr_MimaMagicEnergyGet_Private_Void_SpecialGuestsController_0;

		// Token: 0x04003567 RID: 13671
		private static readonly IntPtr NativeMethodInfoPtr_AddEnergyForMagic_Private_Void_Int32_0;

		// Token: 0x04003568 RID: 13672
		private static readonly IntPtr NativeMethodInfoPtr_CheckGreatMagicEnergy_Private_Void_0;

		// Token: 0x04003569 RID: 13673
		private static readonly IntPtr NativeMethodInfoPtr_MimaGreatMagic_Private_IEnumerator_0;

		// Token: 0x0400356A RID: 13674
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400356B RID: 13675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5F RID: 2911
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6C8 RID: 54984 RVA: 0x00346170 File Offset: 0x00344370
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr);
				Spell_Mima.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				Spell_Mima.__c__DisplayClass23_0.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, "magic");
				Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, 100679027);
				Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, 100679028);
				Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, 100679029);
				Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, 100679030);
			}

			// Token: 0x0600D6C9 RID: 54985 RVA: 0x00346214 File Offset: 0x00344414
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6CA RID: 54986 RVA: 0x00346250 File Offset: 0x00344450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199929, XrefRangeEnd = 199936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6CB RID: 54987 RVA: 0x00346284 File Offset: 0x00344484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199936, XrefRangeEnd = 199941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6CC RID: 54988 RVA: 0x003462C4 File Offset: 0x003444C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199941, XrefRangeEnd = 199962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6CD RID: 54989 RVA: 0x00072F98 File Offset: 0x00071198
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045DF RID: 17887
			// (get) Token: 0x0600D6CE RID: 54990 RVA: 0x003462F8 File Offset: 0x003444F8
			// (set) Token: 0x0600D6CF RID: 54991 RVA: 0x00072FA1 File Offset: 0x000711A1
			public unsafe Spell_Mima __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E0 RID: 17888
			// (get) Token: 0x0600D6D0 RID: 54992 RVA: 0x00346328 File Offset: 0x00344528
			// (set) Token: 0x0600D6D1 RID: 54993 RVA: 0x00072FC0 File Offset: 0x000711C0
			public unsafe GameObject magic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.NativeFieldInfoPtr_magic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.NativeFieldInfoPtr_magic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089BE RID: 35262
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089BF RID: 35263
			private static readonly IntPtr NativeFieldInfoPtr_magic;

			// Token: 0x040089C0 RID: 35264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089C1 RID: 35265
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040089C2 RID: 35266
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040089C3 RID: 35267
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_0;

			// Token: 0x02001031 RID: 4145
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<>c__DisplayClass23_0+<<OnPositiveBuffExecute>g__Delay|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BC0 RID: 72640 RVA: 0x0040FE2C File Offset: 0x0040E02C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__Delay|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679031);
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679032);
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679033);
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679034);
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679035);
					Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679036);
				}

				// Token: 0x06011BC1 RID: 72641 RVA: 0x0040FF0C File Offset: 0x0040E10C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BC2 RID: 72642 RVA: 0x0040FF54 File Offset: 0x0040E154
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BC3 RID: 72643 RVA: 0x0040FF88 File Offset: 0x0040E188
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199910, XrefRangeEnd = 199923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C55 RID: 23637
				// (get) Token: 0x06011BC4 RID: 72644 RVA: 0x0040FFC4 File Offset: 0x0040E1C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BC5 RID: 72645 RVA: 0x00410004 File Offset: 0x0040E204
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199923, XrefRangeEnd = 199929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C56 RID: 23638
				// (get) Token: 0x06011BC6 RID: 72646 RVA: 0x00410038 File Offset: 0x0040E238
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BC7 RID: 72647 RVA: 0x0009A281 File Offset: 0x00098481
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C52 RID: 23634
				// (get) Token: 0x06011BC8 RID: 72648 RVA: 0x00410078 File Offset: 0x0040E278
				// (set) Token: 0x06011BC9 RID: 72649 RVA: 0x0009A28A File Offset: 0x0009848A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C53 RID: 23635
				// (get) Token: 0x06011BCA RID: 72650 RVA: 0x004100A0 File Offset: 0x0040E2A0
				// (set) Token: 0x06011BCB RID: 72651 RVA: 0x0009A2A5 File Offset: 0x000984A5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C54 RID: 23636
				// (get) Token: 0x06011BCC RID: 72652 RVA: 0x004100D0 File Offset: 0x0040E2D0
				// (set) Token: 0x06011BCD RID: 72653 RVA: 0x0009A2C4 File Offset: 0x000984C4
				public unsafe Spell_Mima.__c__DisplayClass23_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima.__c__DisplayClass23_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B343 RID: 45891
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B344 RID: 45892
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B345 RID: 45893
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B346 RID: 45894
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B347 RID: 45895
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B348 RID: 45896
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B349 RID: 45897
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B34A RID: 45898
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B34B RID: 45899
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B60 RID: 2912
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<OnPositiveBuffExecute>d__23")]
		public sealed class _OnPositiveBuffExecute_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600D6D2 RID: 54994 RVA: 0x00346358 File Offset: 0x00344558
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__23()
			{
				Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<OnPositiveBuffExecute>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr);
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>1__state");
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>2__current");
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>4__this");
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679037);
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679038);
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679039);
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679040);
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679041);
				Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100679042);
			}

			// Token: 0x0600D6D3 RID: 54995 RVA: 0x00346438 File Offset: 0x00344638
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima._OnPositiveBuffExecute_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6D4 RID: 54996 RVA: 0x00346480 File Offset: 0x00344680
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6D5 RID: 54997 RVA: 0x003464B4 File Offset: 0x003446B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199962, XrefRangeEnd = 200009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045E4 RID: 17892
			// (get) Token: 0x0600D6D6 RID: 54998 RVA: 0x003464F0 File Offset: 0x003446F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6D7 RID: 54999 RVA: 0x00346530 File Offset: 0x00344730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200009, XrefRangeEnd = 200015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045E5 RID: 17893
			// (get) Token: 0x0600D6D8 RID: 55000 RVA: 0x00346564 File Offset: 0x00344764
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6D9 RID: 55001 RVA: 0x00072FDF File Offset: 0x000711DF
			public _OnPositiveBuffExecute_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E1 RID: 17889
			// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x003465A4 File Offset: 0x003447A4
			// (set) Token: 0x0600D6DB RID: 55003 RVA: 0x00072FE8 File Offset: 0x000711E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045E2 RID: 17890
			// (get) Token: 0x0600D6DC RID: 55004 RVA: 0x003465CC File Offset: 0x003447CC
			// (set) Token: 0x0600D6DD RID: 55005 RVA: 0x00073003 File Offset: 0x00071203
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E3 RID: 17891
			// (get) Token: 0x0600D6DE RID: 55006 RVA: 0x003465FC File Offset: 0x003447FC
			// (set) Token: 0x0600D6DF RID: 55007 RVA: 0x00073022 File Offset: 0x00071222
			public unsafe Spell_Mima __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089C4 RID: 35268
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089C5 RID: 35269
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089C6 RID: 35270
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089C7 RID: 35271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089C8 RID: 35272
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089C9 RID: 35273
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089CA RID: 35274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089CB RID: 35275
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089CC RID: 35276
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B61 RID: 2913
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6E0 RID: 55008 RVA: 0x0034662C File Offset: 0x0034482C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr);
				Spell_Mima.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				Spell_Mima.__c__DisplayClass30_0.NativeFieldInfoPtr_greatMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, "greatMagic");
				Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, 100679043);
				Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr__MimaGreatMagic_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, 100679044);
				Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, 100679045);
				Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, 100679046);
			}

			// Token: 0x0600D6E1 RID: 55009 RVA: 0x003466D0 File Offset: 0x003448D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E2 RID: 55010 RVA: 0x0034670C File Offset: 0x0034490C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200033, XrefRangeEnd = 200041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MimaGreatMagic_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr__MimaGreatMagic_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E3 RID: 55011 RVA: 0x0034674C File Offset: 0x0034494C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200041, XrefRangeEnd = 200048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E4 RID: 55012 RVA: 0x00346780 File Offset: 0x00344980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200048, XrefRangeEnd = 200053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6E5 RID: 55013 RVA: 0x00073041 File Offset: 0x00071241
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E6 RID: 17894
			// (get) Token: 0x0600D6E6 RID: 55014 RVA: 0x003467C0 File Offset: 0x003449C0
			// (set) Token: 0x0600D6E7 RID: 55015 RVA: 0x0007304A File Offset: 0x0007124A
			public unsafe Spell_Mima __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E7 RID: 17895
			// (get) Token: 0x0600D6E8 RID: 55016 RVA: 0x003467F0 File Offset: 0x003449F0
			// (set) Token: 0x0600D6E9 RID: 55017 RVA: 0x00073069 File Offset: 0x00071269
			public unsafe GameObject greatMagic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.NativeFieldInfoPtr_greatMagic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.NativeFieldInfoPtr_greatMagic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089CD RID: 35277
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089CE RID: 35278
			private static readonly IntPtr NativeFieldInfoPtr_greatMagic;

			// Token: 0x040089CF RID: 35279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089D0 RID: 35280
			private static readonly IntPtr NativeMethodInfoPtr__MimaGreatMagic_b__1_Internal_Void_Int32_0;

			// Token: 0x040089D1 RID: 35281
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040089D2 RID: 35282
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001032 RID: 4146
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<>c__DisplayClass30_0+<<MimaGreatMagic>g__End|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BCE RID: 72654 RVA: 0x00410100 File Offset: 0x0040E300
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0>.NativeClassPtr, "<<MimaGreatMagic>g__End|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679047);
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679048);
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679049);
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679050);
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679051);
					Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679052);
				}

				// Token: 0x06011BCF RID: 72655 RVA: 0x004101E0 File Offset: 0x0040E3E0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BD0 RID: 72656 RVA: 0x00410228 File Offset: 0x0040E428
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BD1 RID: 72657 RVA: 0x0041025C File Offset: 0x0040E45C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200015, XrefRangeEnd = 200027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C5A RID: 23642
				// (get) Token: 0x06011BD2 RID: 72658 RVA: 0x00410298 File Offset: 0x0040E498
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BD3 RID: 72659 RVA: 0x004102D8 File Offset: 0x0040E4D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200027, XrefRangeEnd = 200033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C5B RID: 23643
				// (get) Token: 0x06011BD4 RID: 72660 RVA: 0x0041030C File Offset: 0x0040E50C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BD5 RID: 72661 RVA: 0x0009A2E3 File Offset: 0x000984E3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C57 RID: 23639
				// (get) Token: 0x06011BD6 RID: 72662 RVA: 0x0041034C File Offset: 0x0040E54C
				// (set) Token: 0x06011BD7 RID: 72663 RVA: 0x0009A2EC File Offset: 0x000984EC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C58 RID: 23640
				// (get) Token: 0x06011BD8 RID: 72664 RVA: 0x00410374 File Offset: 0x0040E574
				// (set) Token: 0x06011BD9 RID: 72665 RVA: 0x0009A307 File Offset: 0x00098507
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C59 RID: 23641
				// (get) Token: 0x06011BDA RID: 72666 RVA: 0x004103A4 File Offset: 0x0040E5A4
				// (set) Token: 0x06011BDB RID: 72667 RVA: 0x0009A326 File Offset: 0x00098526
				public unsafe Spell_Mima.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B34C RID: 45900
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B34D RID: 45901
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B34E RID: 45902
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B34F RID: 45903
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B350 RID: 45904
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B351 RID: 45905
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B352 RID: 45906
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B353 RID: 45907
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B354 RID: 45908
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B62 RID: 2914
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D6EA RID: 55018 RVA: 0x00346820 File Offset: 0x00344A20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr);
				Spell_Mima.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr, "<>9");
				Spell_Mima.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr, "<>9__30_0");
				Spell_Mima.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr, 100679054);
				Spell_Mima.__c.NativeMethodInfoPtr__MimaGreatMagic_b__30_0_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr, 100679055);
			}

			// Token: 0x0600D6EB RID: 55019 RVA: 0x0034689C File Offset: 0x00344A9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6EC RID: 55020 RVA: 0x003468D8 File Offset: 0x00344AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200053, XrefRangeEnd = 200054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MimaGreatMagic_b__30_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c.NativeMethodInfoPtr__MimaGreatMagic_b__30_0_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6ED RID: 55021 RVA: 0x00073088 File Offset: 0x00071288
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E8 RID: 17896
			// (get) Token: 0x0600D6EE RID: 55022 RVA: 0x0034691C File Offset: 0x00344B1C
			// (set) Token: 0x0600D6EF RID: 55023 RVA: 0x00073091 File Offset: 0x00071291
			public unsafe static Spell_Mima.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Mima.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Mima.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E9 RID: 17897
			// (get) Token: 0x0600D6F0 RID: 55024 RVA: 0x00346944 File Offset: 0x00344B44
			// (set) Token: 0x0600D6F1 RID: 55025 RVA: 0x000730A3 File Offset: 0x000712A3
			public unsafe static Action<GuestGroupController> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Mima.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Mima.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089D3 RID: 35283
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089D4 RID: 35284
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x040089D5 RID: 35285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089D6 RID: 35286
			private static readonly IntPtr NativeMethodInfoPtr__MimaGreatMagic_b__30_0_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000B63 RID: 2915
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<MimaGreatMagic>d__30")]
		public sealed class _MimaGreatMagic_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600D6F2 RID: 55026 RVA: 0x0034696C File Offset: 0x00344B6C
			// Note: this type is marked as 'beforefieldinit'.
			static _MimaGreatMagic_d__30()
			{
				Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<MimaGreatMagic>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr);
				Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, "<>1__state");
				Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, "<>2__current");
				Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, "<>4__this");
				Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, 100679056);
				Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, 100679057);
				Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, 100679058);
				Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, 100679059);
				Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, 100679060);
				Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr, 100679061);
			}

			// Token: 0x0600D6F3 RID: 55027 RVA: 0x00346A4C File Offset: 0x00344C4C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MimaGreatMagic_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima._MimaGreatMagic_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6F4 RID: 55028 RVA: 0x00346A94 File Offset: 0x00344C94
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6F5 RID: 55029 RVA: 0x00346AC8 File Offset: 0x00344CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200054, XrefRangeEnd = 200139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045ED RID: 17901
			// (get) Token: 0x0600D6F6 RID: 55030 RVA: 0x00346B04 File Offset: 0x00344D04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6F7 RID: 55031 RVA: 0x00346B44 File Offset: 0x00344D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200139, XrefRangeEnd = 200145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045EE RID: 17902
			// (get) Token: 0x0600D6F8 RID: 55032 RVA: 0x00346B78 File Offset: 0x00344D78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._MimaGreatMagic_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6F9 RID: 55033 RVA: 0x000730B5 File Offset: 0x000712B5
			public _MimaGreatMagic_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EA RID: 17898
			// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x00346BB8 File Offset: 0x00344DB8
			// (set) Token: 0x0600D6FB RID: 55035 RVA: 0x000730BE File Offset: 0x000712BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045EB RID: 17899
			// (get) Token: 0x0600D6FC RID: 55036 RVA: 0x00346BE0 File Offset: 0x00344DE0
			// (set) Token: 0x0600D6FD RID: 55037 RVA: 0x000730D9 File Offset: 0x000712D9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045EC RID: 17900
			// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x00346C10 File Offset: 0x00344E10
			// (set) Token: 0x0600D6FF RID: 55039 RVA: 0x000730F8 File Offset: 0x000712F8
			public unsafe Spell_Mima __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._MimaGreatMagic_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089D7 RID: 35287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089D8 RID: 35288
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089D9 RID: 35289
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089DA RID: 35290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089DB RID: 35291
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089DC RID: 35292
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089DD RID: 35293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089DE RID: 35294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089DF RID: 35295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B64 RID: 2916
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D700 RID: 55040 RVA: 0x00346C40 File Offset: 0x00344E40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr);
				Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr_mystia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, "mystia");
				Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr_ghost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, "ghost");
				Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, "<>9__2");
				Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, 100679062);
				Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, 100679063);
				Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, 100679064);
				Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr, 100679065);
			}

			// Token: 0x0600D701 RID: 55041 RVA: 0x00346D0C File Offset: 0x00344F0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D702 RID: 55042 RVA: 0x00346D48 File Offset: 0x00344F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200145, XrefRangeEnd = 200151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D703 RID: 55043 RVA: 0x00346D8C File Offset: 0x00344F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200151, XrefRangeEnd = 200160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D704 RID: 55044 RVA: 0x00346DCC File Offset: 0x00344FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200160, XrefRangeEnd = 200164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima.__c__DisplayClass31_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D705 RID: 55045 RVA: 0x00073117 File Offset: 0x00071317
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EF RID: 17903
			// (get) Token: 0x0600D706 RID: 55046 RVA: 0x00346E00 File Offset: 0x00345000
			// (set) Token: 0x0600D707 RID: 55047 RVA: 0x00073120 File Offset: 0x00071320
			public unsafe Transform mystia
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr_mystia);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr_mystia), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F0 RID: 17904
			// (get) Token: 0x0600D708 RID: 55048 RVA: 0x00346E30 File Offset: 0x00345030
			// (set) Token: 0x0600D709 RID: 55049 RVA: 0x0007313F File Offset: 0x0007133F
			public unsafe Spell_Mima __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F1 RID: 17905
			// (get) Token: 0x0600D70A RID: 55050 RVA: 0x00346E60 File Offset: 0x00345060
			// (set) Token: 0x0600D70B RID: 55051 RVA: 0x0007315E File Offset: 0x0007135E
			public unsafe GameObject ghost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr_ghost);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr_ghost), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F2 RID: 17906
			// (get) Token: 0x0600D70C RID: 55052 RVA: 0x00346E90 File Offset: 0x00345090
			// (set) Token: 0x0600D70D RID: 55053 RVA: 0x0007317D File Offset: 0x0007137D
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089E0 RID: 35296
			private static readonly IntPtr NativeFieldInfoPtr_mystia;

			// Token: 0x040089E1 RID: 35297
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089E2 RID: 35298
			private static readonly IntPtr NativeFieldInfoPtr_ghost;

			// Token: 0x040089E3 RID: 35299
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040089E4 RID: 35300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089E5 RID: 35301
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x040089E6 RID: 35302
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0;

			// Token: 0x040089E7 RID: 35303
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0;
		}

		// Token: 0x02000B65 RID: 2917
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mima+<OnNegativeBuffExecute>d__31")]
		public sealed class _OnNegativeBuffExecute_d__31 : Il2CppSystem.Object
		{
			// Token: 0x0600D70E RID: 55054 RVA: 0x00346EC0 File Offset: 0x003450C0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__31()
			{
				Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mima>.NativeClassPtr, "<OnNegativeBuffExecute>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr);
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, "<>1__state");
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, "<>2__current");
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, "<>4__this");
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, "<>8__1");
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, 100679066);
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, 100679067);
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, 100679068);
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, 100679069);
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, 100679070);
				Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr, 100679071);
			}

			// Token: 0x0600D70F RID: 55055 RVA: 0x00346FB4 File Offset: 0x003451B4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mima._OnNegativeBuffExecute_d__31>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D710 RID: 55056 RVA: 0x00346FFC File Offset: 0x003451FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D711 RID: 55057 RVA: 0x00347030 File Offset: 0x00345230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200164, XrefRangeEnd = 200179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045F7 RID: 17911
			// (get) Token: 0x0600D712 RID: 55058 RVA: 0x0034706C File Offset: 0x0034526C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D713 RID: 55059 RVA: 0x003470AC File Offset: 0x003452AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200179, XrefRangeEnd = 200185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045F8 RID: 17912
			// (get) Token: 0x0600D714 RID: 55060 RVA: 0x003470E0 File Offset: 0x003452E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mima._OnNegativeBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D715 RID: 55061 RVA: 0x0007319C File Offset: 0x0007139C
			public _OnNegativeBuffExecute_d__31(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F3 RID: 17907
			// (get) Token: 0x0600D716 RID: 55062 RVA: 0x00347120 File Offset: 0x00345320
			// (set) Token: 0x0600D717 RID: 55063 RVA: 0x000731A5 File Offset: 0x000713A5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045F4 RID: 17908
			// (get) Token: 0x0600D718 RID: 55064 RVA: 0x00347148 File Offset: 0x00345348
			// (set) Token: 0x0600D719 RID: 55065 RVA: 0x000731C0 File Offset: 0x000713C0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F5 RID: 17909
			// (get) Token: 0x0600D71A RID: 55066 RVA: 0x00347178 File Offset: 0x00345378
			// (set) Token: 0x0600D71B RID: 55067 RVA: 0x000731DF File Offset: 0x000713DF
			public unsafe Spell_Mima __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F6 RID: 17910
			// (get) Token: 0x0600D71C RID: 55068 RVA: 0x003471A8 File Offset: 0x003453A8
			// (set) Token: 0x0600D71D RID: 55069 RVA: 0x000731FE File Offset: 0x000713FE
			public unsafe Spell_Mima.__c__DisplayClass31_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mima.__c__DisplayClass31_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mima._OnNegativeBuffExecute_d__31.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089E8 RID: 35304
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089E9 RID: 35305
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089EA RID: 35306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089EB RID: 35307
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040089EC RID: 35308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089ED RID: 35309
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089EE RID: 35310
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089EF RID: 35311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089F0 RID: 35312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089F1 RID: 35313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
