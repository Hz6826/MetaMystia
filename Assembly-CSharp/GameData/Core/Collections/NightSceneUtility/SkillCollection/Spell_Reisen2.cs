using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200027C RID: 636
	public class Spell_Reisen2 : SpellBase
	{
		// Token: 0x06004FF9 RID: 20473 RVA: 0x001AFACC File Offset: 0x001ADCCC
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Reisen2()
		{
			Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Reisen2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr);
			Spell_Reisen2.NativeFieldInfoPtr_ingredientsRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "ingredientsRate");
			Spell_Reisen2.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "positiveDuration");
			Spell_Reisen2.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "negativeDuration");
			Spell_Reisen2.NativeFieldInfoPtr_negativeDurationIfReisenExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "negativeDurationIfReisenExist");
			Spell_Reisen2.NativeFieldInfoPtr_magicianHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "magicianHat");
			Spell_Reisen2.NativeFieldInfoPtr_magicianHatDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "magicianHatDuration");
			Spell_Reisen2.NativeFieldInfoPtr_magicianRabbitSpawnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "magicianRabbitSpawnDuration");
			Spell_Reisen2.NativeFieldInfoPtr_rabbitVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "rabbitVfx");
			Spell_Reisen2.NativeFieldInfoPtr_rabbitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "rabbitDuration");
			Spell_Reisen2.NativeFieldInfoPtr_rabbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "rabbits");
			Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "offsetForRabbitGuest");
			Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitDecoration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "offsetForRabbitDecoration");
			Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "offsetForRabbitEffect");
			Spell_Reisen2.NativeFieldInfoPtr_ammopackVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "ammopackVfx");
			Spell_Reisen2.NativeFieldInfoPtr_ammopackVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "ammopackVfxOffset");
			Spell_Reisen2.NativeFieldInfoPtr_ammopackVfxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "ammopackVfxDelay");
			Spell_Reisen2.NativeFieldInfoPtr_starVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "starVfx");
			Spell_Reisen2.NativeFieldInfoPtr_starVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "starVfxOffset");
			Spell_Reisen2.NativeFieldInfoPtr_starVfxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "starVfxDelay");
			Spell_Reisen2.NativeFieldInfoPtr_bulletVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "bulletVfx");
			Spell_Reisen2.NativeFieldInfoPtr_bulletVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "bulletVfxOffset");
			Spell_Reisen2.NativeFieldInfoPtr_bulletVfxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "bulletVfxDelay");
			Spell_Reisen2.NativeFieldInfoPtr_boomVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "boomVfx");
			Spell_Reisen2.NativeFieldInfoPtr_boomVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "boomVfxOffset");
			Spell_Reisen2.NativeFieldInfoPtr_angleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "angleOffset");
			Spell_Reisen2.NativeFieldInfoPtr_positiveSfxHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "positiveSfxHat");
			Spell_Reisen2.NativeFieldInfoPtr_positiveSfxRabbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "positiveSfxRabbit");
			Spell_Reisen2.NativeFieldInfoPtr_negativeSfxAmmopack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "negativeSfxAmmopack");
			Spell_Reisen2.NativeFieldInfoPtr_negativeSfxShoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "negativeSfxShoot");
			Spell_Reisen2.NativeFieldInfoPtr_negativeSfxBoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "negativeSfxBoom");
			Spell_Reisen2.NativeFieldInfoPtr_REISEN_PARTNER_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "REISEN_PARTNER_ID");
			Spell_Reisen2.NativeFieldInfoPtr_HIGH_ALCOHOL_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "HIGH_ALCOHOL_ID");
			Spell_Reisen2.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679402);
			Spell_Reisen2.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679403);
			Spell_Reisen2.NativeMethodInfoPtr_OnRabbitSpawn_Private_Void_Transform_RabbitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679404);
			Spell_Reisen2.NativeMethodInfoPtr_FindAllRabbits_Private_List_1_ValueTuple_2_Transform_RabbitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679405);
			Spell_Reisen2.NativeMethodInfoPtr_SpawnIngredientsOrBeverage_Private_Void_Transform_RabbitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679406);
			Spell_Reisen2.NativeMethodInfoPtr_SpawnRabbitVfx_Private_Void_Transform_RabbitType_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679407);
			Spell_Reisen2.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679408);
			Spell_Reisen2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679409);
			Spell_Reisen2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, 100679410);
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x001AFE30 File Offset: 0x001AE030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202154, XrefRangeEnd = 202156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Reisen2.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x001AFE74 File Offset: 0x001AE074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202156, XrefRangeEnd = 202161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Reisen2.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x001AFED0 File Offset: 0x001AE0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202161, XrefRangeEnd = 202162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRabbitSpawn(Transform offset, EventManager.RabbitType rabbitType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rabbitType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.NativeMethodInfoPtr_OnRabbitSpawn_Private_Void_Transform_RabbitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x001AFF20 File Offset: 0x001AE120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202267, RefRangeEnd = 202268, XrefRangeStart = 202162, XrefRangeEnd = 202267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<Transform, EventManager.RabbitType>> FindAllRabbits()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.NativeMethodInfoPtr_FindAllRabbits_Private_List_1_ValueTuple_2_Transform_RabbitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Transform, EventManager.RabbitType>>>(intPtr3) : null;
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x001AFF60 File Offset: 0x001AE160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202309, RefRangeEnd = 202312, XrefRangeStart = 202268, XrefRangeEnd = 202309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnIngredientsOrBeverage(Transform offset, EventManager.RabbitType rabbitType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rabbitType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.NativeMethodInfoPtr_SpawnIngredientsOrBeverage_Private_Void_Transform_RabbitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x001AFFB0 File Offset: 0x001AE1B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202336, RefRangeEnd = 202338, XrefRangeStart = 202312, XrefRangeEnd = 202336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnRabbitVfx(Transform offset, EventManager.RabbitType rabbitType, Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rabbitType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.NativeMethodInfoPtr_SpawnRabbitVfx_Private_Void_Transform_RabbitType_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x001B0014 File Offset: 0x001AE214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202338, XrefRangeEnd = 202344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Reisen2.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x001B0070 File Offset: 0x001AE270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202344, XrefRangeEnd = 202345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Reisen2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x001B00AC File Offset: 0x001AE2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202345, XrefRangeEnd = 202350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNegativeBuffExecute_b__38_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x0002A3F3 File Offset: 0x000285F3
		public Spell_Reisen2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x001B00EC File Offset: 0x001AE2EC
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x0002A3FC File Offset: 0x000285FC
		public unsafe float ingredientsRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ingredientsRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ingredientsRate)) = value;
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x001B0114 File Offset: 0x001AE314
		// (set) Token: 0x06005007 RID: 20487 RVA: 0x0002A417 File Offset: 0x00028617
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06005008 RID: 20488 RVA: 0x001B013C File Offset: 0x001AE33C
		// (set) Token: 0x06005009 RID: 20489 RVA: 0x0002A432 File Offset: 0x00028632
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x001B0164 File Offset: 0x001AE364
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x0002A44D File Offset: 0x0002864D
		public unsafe int negativeDurationIfReisenExist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeDurationIfReisenExist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeDurationIfReisenExist)) = value;
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x001B018C File Offset: 0x001AE38C
		// (set) Token: 0x0600500D RID: 20493 RVA: 0x0002A468 File Offset: 0x00028668
		public unsafe GameObject magicianHat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_magicianHat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_magicianHat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x001B01BC File Offset: 0x001AE3BC
		// (set) Token: 0x0600500F RID: 20495 RVA: 0x0002A487 File Offset: 0x00028687
		public unsafe float magicianHatDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_magicianHatDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_magicianHatDuration)) = value;
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x001B01E4 File Offset: 0x001AE3E4
		// (set) Token: 0x06005011 RID: 20497 RVA: 0x0002A4A2 File Offset: 0x000286A2
		public unsafe float magicianRabbitSpawnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_magicianRabbitSpawnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_magicianRabbitSpawnDuration)) = value;
			}
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x001B020C File Offset: 0x001AE40C
		// (set) Token: 0x06005013 RID: 20499 RVA: 0x0002A4BD File Offset: 0x000286BD
		public unsafe GameObject rabbitVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_rabbitVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_rabbitVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x001B023C File Offset: 0x001AE43C
		// (set) Token: 0x06005015 RID: 20501 RVA: 0x0002A4DC File Offset: 0x000286DC
		public unsafe float rabbitDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_rabbitDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_rabbitDuration)) = value;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x001B0264 File Offset: 0x001AE464
		// (set) Token: 0x06005017 RID: 20503 RVA: 0x0002A4F7 File Offset: 0x000286F7
		public unsafe Il2CppReferenceArray<Sprite> rabbits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_rabbits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_rabbits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06005018 RID: 20504 RVA: 0x001B0294 File Offset: 0x001AE494
		// (set) Token: 0x06005019 RID: 20505 RVA: 0x0002A516 File Offset: 0x00028716
		public unsafe Vector3 offsetForRabbitGuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitGuest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitGuest)) = value;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600501A RID: 20506 RVA: 0x001B02BC File Offset: 0x001AE4BC
		// (set) Token: 0x0600501B RID: 20507 RVA: 0x0002A531 File Offset: 0x00028731
		public unsafe Vector3 offsetForRabbitDecoration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitDecoration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitDecoration)) = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x001B02E4 File Offset: 0x001AE4E4
		// (set) Token: 0x0600501D RID: 20509 RVA: 0x0002A54C File Offset: 0x0002874C
		public unsafe Vector3 offsetForRabbitEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_offsetForRabbitEffect)) = value;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x001B030C File Offset: 0x001AE50C
		// (set) Token: 0x0600501F RID: 20511 RVA: 0x0002A567 File Offset: 0x00028767
		public unsafe GameObject ammopackVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ammopackVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ammopackVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005020 RID: 20512 RVA: 0x001B033C File Offset: 0x001AE53C
		// (set) Token: 0x06005021 RID: 20513 RVA: 0x0002A586 File Offset: 0x00028786
		public unsafe Vector3 ammopackVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ammopackVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ammopackVfxOffset)) = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x001B0364 File Offset: 0x001AE564
		// (set) Token: 0x06005023 RID: 20515 RVA: 0x0002A5A1 File Offset: 0x000287A1
		public unsafe float ammopackVfxDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ammopackVfxDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_ammopackVfxDelay)) = value;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x001B038C File Offset: 0x001AE58C
		// (set) Token: 0x06005025 RID: 20517 RVA: 0x0002A5BC File Offset: 0x000287BC
		public unsafe GameObject starVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_starVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_starVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x001B03BC File Offset: 0x001AE5BC
		// (set) Token: 0x06005027 RID: 20519 RVA: 0x0002A5DB File Offset: 0x000287DB
		public unsafe Vector3 starVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_starVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_starVfxOffset)) = value;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x001B03E4 File Offset: 0x001AE5E4
		// (set) Token: 0x06005029 RID: 20521 RVA: 0x0002A5F6 File Offset: 0x000287F6
		public unsafe float starVfxDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_starVfxDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_starVfxDelay)) = value;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x001B040C File Offset: 0x001AE60C
		// (set) Token: 0x0600502B RID: 20523 RVA: 0x0002A611 File Offset: 0x00028811
		public unsafe GameObject bulletVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_bulletVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_bulletVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x001B043C File Offset: 0x001AE63C
		// (set) Token: 0x0600502D RID: 20525 RVA: 0x0002A630 File Offset: 0x00028830
		public unsafe Vector3 bulletVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_bulletVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_bulletVfxOffset)) = value;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x001B0464 File Offset: 0x001AE664
		// (set) Token: 0x0600502F RID: 20527 RVA: 0x0002A64B File Offset: 0x0002884B
		public unsafe float bulletVfxDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_bulletVfxDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_bulletVfxDelay)) = value;
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x001B048C File Offset: 0x001AE68C
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x0002A666 File Offset: 0x00028866
		public unsafe GameObject boomVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_boomVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_boomVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06005032 RID: 20530 RVA: 0x001B04BC File Offset: 0x001AE6BC
		// (set) Token: 0x06005033 RID: 20531 RVA: 0x0002A685 File Offset: 0x00028885
		public unsafe Vector3 boomVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_boomVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_boomVfxOffset)) = value;
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x001B04E4 File Offset: 0x001AE6E4
		// (set) Token: 0x06005035 RID: 20533 RVA: 0x0002A6A0 File Offset: 0x000288A0
		public unsafe int angleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_angleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_angleOffset)) = value;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x001B050C File Offset: 0x001AE70C
		// (set) Token: 0x06005037 RID: 20535 RVA: 0x0002A6BB File Offset: 0x000288BB
		public SpellBase.DelayAudioClip positiveSfxHat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_positiveSfxHat);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_positiveSfxHat), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x001B053C File Offset: 0x001AE73C
		// (set) Token: 0x06005039 RID: 20537 RVA: 0x0002A6E9 File Offset: 0x000288E9
		public SpellBase.DelayAudioClip positiveSfxRabbit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_positiveSfxRabbit);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_positiveSfxRabbit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x001B056C File Offset: 0x001AE76C
		// (set) Token: 0x0600503B RID: 20539 RVA: 0x0002A717 File Offset: 0x00028917
		public SpellBase.DelayAudioClip negativeSfxAmmopack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeSfxAmmopack);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeSfxAmmopack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x001B059C File Offset: 0x001AE79C
		// (set) Token: 0x0600503D RID: 20541 RVA: 0x0002A745 File Offset: 0x00028945
		public SpellBase.DelayAudioClip negativeSfxShoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeSfxShoot);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeSfxShoot), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x001B05CC File Offset: 0x001AE7CC
		// (set) Token: 0x0600503F RID: 20543 RVA: 0x0002A773 File Offset: 0x00028973
		public SpellBase.DelayAudioClip negativeSfxBoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeSfxBoom);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.NativeFieldInfoPtr_negativeSfxBoom), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x001B05FC File Offset: 0x001AE7FC
		// (set) Token: 0x06005041 RID: 20545 RVA: 0x0002A7A1 File Offset: 0x000289A1
		public unsafe static int REISEN_PARTNER_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.NativeFieldInfoPtr_REISEN_PARTNER_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.NativeFieldInfoPtr_REISEN_PARTNER_ID, (void*)(&value));
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x001B0618 File Offset: 0x001AE818
		// (set) Token: 0x06005043 RID: 20547 RVA: 0x0002A7AF File Offset: 0x000289AF
		public unsafe static int HIGH_ALCOHOL_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.NativeFieldInfoPtr_HIGH_ALCOHOL_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.NativeFieldInfoPtr_HIGH_ALCOHOL_ID, (void*)(&value));
			}
		}

		// Token: 0x04003636 RID: 13878
		private static readonly IntPtr NativeFieldInfoPtr_ingredientsRate;

		// Token: 0x04003637 RID: 13879
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003638 RID: 13880
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003639 RID: 13881
		private static readonly IntPtr NativeFieldInfoPtr_negativeDurationIfReisenExist;

		// Token: 0x0400363A RID: 13882
		private static readonly IntPtr NativeFieldInfoPtr_magicianHat;

		// Token: 0x0400363B RID: 13883
		private static readonly IntPtr NativeFieldInfoPtr_magicianHatDuration;

		// Token: 0x0400363C RID: 13884
		private static readonly IntPtr NativeFieldInfoPtr_magicianRabbitSpawnDuration;

		// Token: 0x0400363D RID: 13885
		private static readonly IntPtr NativeFieldInfoPtr_rabbitVfx;

		// Token: 0x0400363E RID: 13886
		private static readonly IntPtr NativeFieldInfoPtr_rabbitDuration;

		// Token: 0x0400363F RID: 13887
		private static readonly IntPtr NativeFieldInfoPtr_rabbits;

		// Token: 0x04003640 RID: 13888
		private static readonly IntPtr NativeFieldInfoPtr_offsetForRabbitGuest;

		// Token: 0x04003641 RID: 13889
		private static readonly IntPtr NativeFieldInfoPtr_offsetForRabbitDecoration;

		// Token: 0x04003642 RID: 13890
		private static readonly IntPtr NativeFieldInfoPtr_offsetForRabbitEffect;

		// Token: 0x04003643 RID: 13891
		private static readonly IntPtr NativeFieldInfoPtr_ammopackVfx;

		// Token: 0x04003644 RID: 13892
		private static readonly IntPtr NativeFieldInfoPtr_ammopackVfxOffset;

		// Token: 0x04003645 RID: 13893
		private static readonly IntPtr NativeFieldInfoPtr_ammopackVfxDelay;

		// Token: 0x04003646 RID: 13894
		private static readonly IntPtr NativeFieldInfoPtr_starVfx;

		// Token: 0x04003647 RID: 13895
		private static readonly IntPtr NativeFieldInfoPtr_starVfxOffset;

		// Token: 0x04003648 RID: 13896
		private static readonly IntPtr NativeFieldInfoPtr_starVfxDelay;

		// Token: 0x04003649 RID: 13897
		private static readonly IntPtr NativeFieldInfoPtr_bulletVfx;

		// Token: 0x0400364A RID: 13898
		private static readonly IntPtr NativeFieldInfoPtr_bulletVfxOffset;

		// Token: 0x0400364B RID: 13899
		private static readonly IntPtr NativeFieldInfoPtr_bulletVfxDelay;

		// Token: 0x0400364C RID: 13900
		private static readonly IntPtr NativeFieldInfoPtr_boomVfx;

		// Token: 0x0400364D RID: 13901
		private static readonly IntPtr NativeFieldInfoPtr_boomVfxOffset;

		// Token: 0x0400364E RID: 13902
		private static readonly IntPtr NativeFieldInfoPtr_angleOffset;

		// Token: 0x0400364F RID: 13903
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfxHat;

		// Token: 0x04003650 RID: 13904
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfxRabbit;

		// Token: 0x04003651 RID: 13905
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfxAmmopack;

		// Token: 0x04003652 RID: 13906
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfxShoot;

		// Token: 0x04003653 RID: 13907
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfxBoom;

		// Token: 0x04003654 RID: 13908
		private static readonly IntPtr NativeFieldInfoPtr_REISEN_PARTNER_ID;

		// Token: 0x04003655 RID: 13909
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_ALCOHOL_ID;

		// Token: 0x04003656 RID: 13910
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003657 RID: 13911
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003658 RID: 13912
		private static readonly IntPtr NativeMethodInfoPtr_OnRabbitSpawn_Private_Void_Transform_RabbitType_0;

		// Token: 0x04003659 RID: 13913
		private static readonly IntPtr NativeMethodInfoPtr_FindAllRabbits_Private_List_1_ValueTuple_2_Transform_RabbitType_0;

		// Token: 0x0400365A RID: 13914
		private static readonly IntPtr NativeMethodInfoPtr_SpawnIngredientsOrBeverage_Private_Void_Transform_RabbitType_0;

		// Token: 0x0400365B RID: 13915
		private static readonly IntPtr NativeMethodInfoPtr_SpawnRabbitVfx_Private_Void_Transform_RabbitType_Sprite_0;

		// Token: 0x0400365C RID: 13916
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400365D RID: 13917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400365E RID: 13918
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_1_Private_Void_Int32_0;

		// Token: 0x02000B9A RID: 2970
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reisen2+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9C0 RID: 55744 RVA: 0x0034EF0C File Offset: 0x0034D10C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr);
				Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr_cosplayRabbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, "cosplayRabbit");
				Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, "<>9__2");
				Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, 100679411);
				Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, 100679412);
				Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, 100679413);
				Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr, 100679414);
			}

			// Token: 0x0600D9C1 RID: 55745 RVA: 0x0034EFC4 File Offset: 0x0034D1C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C2 RID: 55746 RVA: 0x0034F000 File Offset: 0x0034D200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201991, XrefRangeEnd = 202004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C3 RID: 55747 RVA: 0x0034F044 File Offset: 0x0034D244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202004, XrefRangeEnd = 202013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C4 RID: 55748 RVA: 0x0034F084 File Offset: 0x0034D284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202013, XrefRangeEnd = 202026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C5 RID: 55749 RVA: 0x000747F0 File Offset: 0x000729F0
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046D1 RID: 18129
			// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x0034F0B8 File Offset: 0x0034D2B8
			// (set) Token: 0x0600D9C7 RID: 55751 RVA: 0x000747F9 File Offset: 0x000729F9
			public unsafe Transform cosplayRabbit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr_cosplayRabbit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr_cosplayRabbit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D2 RID: 18130
			// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x0034F0E8 File Offset: 0x0034D2E8
			// (set) Token: 0x0600D9C9 RID: 55753 RVA: 0x00074818 File Offset: 0x00072A18
			public unsafe Spell_Reisen2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reisen2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D3 RID: 18131
			// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x0034F118 File Offset: 0x0034D318
			// (set) Token: 0x0600D9CB RID: 55755 RVA: 0x00074837 File Offset: 0x00072A37
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B90 RID: 35728
			private static readonly IntPtr NativeFieldInfoPtr_cosplayRabbit;

			// Token: 0x04008B91 RID: 35729
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B92 RID: 35730
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04008B93 RID: 35731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B94 RID: 35732
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008B95 RID: 35733
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0;

			// Token: 0x04008B96 RID: 35734
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_0;
		}

		// Token: 0x02000B9B RID: 2971
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reisen2+<OnPositiveBuffExecute>d__31")]
		public sealed class _OnPositiveBuffExecute_d__31 : Il2CppSystem.Object
		{
			// Token: 0x0600D9CC RID: 55756 RVA: 0x0034F148 File Offset: 0x0034D348
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__31()
			{
				Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "<OnPositiveBuffExecute>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr);
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>1__state");
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>2__current");
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>4__this");
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>8__1");
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100679415);
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100679416);
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100679417);
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100679418);
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100679419);
				Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100679420);
			}

			// Token: 0x0600D9CD RID: 55757 RVA: 0x0034F23C File Offset: 0x0034D43C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reisen2._OnPositiveBuffExecute_d__31>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9CE RID: 55758 RVA: 0x0034F284 File Offset: 0x0034D484
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9CF RID: 55759 RVA: 0x0034F2B8 File Offset: 0x0034D4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202026, XrefRangeEnd = 202074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046D8 RID: 18136
			// (get) Token: 0x0600D9D0 RID: 55760 RVA: 0x0034F2F4 File Offset: 0x0034D4F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9D1 RID: 55761 RVA: 0x0034F334 File Offset: 0x0034D534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202074, XrefRangeEnd = 202080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046D9 RID: 18137
			// (get) Token: 0x0600D9D2 RID: 55762 RVA: 0x0034F368 File Offset: 0x0034D568
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9D3 RID: 55763 RVA: 0x00074856 File Offset: 0x00072A56
			public _OnPositiveBuffExecute_d__31(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046D4 RID: 18132
			// (get) Token: 0x0600D9D4 RID: 55764 RVA: 0x0034F3A8 File Offset: 0x0034D5A8
			// (set) Token: 0x0600D9D5 RID: 55765 RVA: 0x0007485F File Offset: 0x00072A5F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046D5 RID: 18133
			// (get) Token: 0x0600D9D6 RID: 55766 RVA: 0x0034F3D0 File Offset: 0x0034D5D0
			// (set) Token: 0x0600D9D7 RID: 55767 RVA: 0x0007487A File Offset: 0x00072A7A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D6 RID: 18134
			// (get) Token: 0x0600D9D8 RID: 55768 RVA: 0x0034F400 File Offset: 0x0034D600
			// (set) Token: 0x0600D9D9 RID: 55769 RVA: 0x00074899 File Offset: 0x00072A99
			public unsafe Spell_Reisen2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reisen2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D7 RID: 18135
			// (get) Token: 0x0600D9DA RID: 55770 RVA: 0x0034F430 File Offset: 0x0034D630
			// (set) Token: 0x0600D9DB RID: 55771 RVA: 0x000748B8 File Offset: 0x00072AB8
			public unsafe Spell_Reisen2.__c__DisplayClass31_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reisen2.__c__DisplayClass31_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B97 RID: 35735
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B98 RID: 35736
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B99 RID: 35737
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B9A RID: 35738
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008B9B RID: 35739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B9C RID: 35740
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B9D RID: 35741
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B9E RID: 35742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B9F RID: 35743
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BA0 RID: 35744
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B9C RID: 2972
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reisen2+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D9DC RID: 55772 RVA: 0x0034F460 File Offset: 0x0034D660
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr);
				Spell_Reisen2.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, "<>9");
				Spell_Reisen2.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, "<>9__35_0");
				Spell_Reisen2.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, "<>9__35_1");
				Spell_Reisen2.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, "<>9__36_0");
				Spell_Reisen2.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, "<>9__38_0");
				Spell_Reisen2.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, 100679422);
				Spell_Reisen2.__c.NativeMethodInfoPtr__FindAllRabbits_b__35_0_Internal_ValueTuple_2_Transform_RabbitType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, 100679423);
				Spell_Reisen2.__c.NativeMethodInfoPtr__FindAllRabbits_b__35_1_Internal_ValueTuple_2_Transform_RabbitType_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, 100679424);
				Spell_Reisen2.__c.NativeMethodInfoPtr__SpawnIngredientsOrBeverage_b__36_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, 100679425);
				Spell_Reisen2.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_0_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr, 100679426);
			}

			// Token: 0x0600D9DD RID: 55773 RVA: 0x0034F554 File Offset: 0x0034D754
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reisen2.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9DE RID: 55774 RVA: 0x0034F590 File Offset: 0x0034D790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202080, XrefRangeEnd = 202084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Transform, EventManager.RabbitType> _FindAllRabbits_b__35_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c.NativeMethodInfoPtr__FindAllRabbits_b__35_0_Internal_ValueTuple_2_Transform_RabbitType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Transform, EventManager.RabbitType>(pointer);
			}

			// Token: 0x0600D9DF RID: 55775 RVA: 0x0034F5D8 File Offset: 0x0034D7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202084, XrefRangeEnd = 202087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Transform, EventManager.RabbitType> _FindAllRabbits_b__35_1(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c.NativeMethodInfoPtr__FindAllRabbits_b__35_1_Internal_ValueTuple_2_Transform_RabbitType_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Transform, EventManager.RabbitType>(pointer);
			}

			// Token: 0x0600D9E0 RID: 55776 RVA: 0x0034F620 File Offset: 0x0034D820
			[CallerCount(0)]
			public unsafe bool _SpawnIngredientsOrBeverage_b__36_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c.NativeMethodInfoPtr__SpawnIngredientsOrBeverage_b__36_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9E1 RID: 55777 RVA: 0x0034F66C File Offset: 0x0034D86C
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__38_0(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_0_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9E2 RID: 55778 RVA: 0x000748D7 File Offset: 0x00072AD7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046DA RID: 18138
			// (get) Token: 0x0600D9E3 RID: 55779 RVA: 0x0034F6BC File Offset: 0x0034D8BC
			// (set) Token: 0x0600D9E4 RID: 55780 RVA: 0x000748E0 File Offset: 0x00072AE0
			public unsafe static Spell_Reisen2.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reisen2.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046DB RID: 18139
			// (get) Token: 0x0600D9E5 RID: 55781 RVA: 0x0034F6E4 File Offset: 0x0034D8E4
			// (set) Token: 0x0600D9E6 RID: 55782 RVA: 0x000748F2 File Offset: 0x00072AF2
			public unsafe static Func<GameObject, ValueTuple<Transform, EventManager.RabbitType>> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, ValueTuple<Transform, EventManager.RabbitType>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046DC RID: 18140
			// (get) Token: 0x0600D9E7 RID: 55783 RVA: 0x0034F70C File Offset: 0x0034D90C
			// (set) Token: 0x0600D9E8 RID: 55784 RVA: 0x00074904 File Offset: 0x00072B04
			public unsafe static Func<Transform, ValueTuple<Transform, EventManager.RabbitType>> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, ValueTuple<Transform, EventManager.RabbitType>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046DD RID: 18141
			// (get) Token: 0x0600D9E9 RID: 55785 RVA: 0x0034F734 File Offset: 0x0034D934
			// (set) Token: 0x0600D9EA RID: 55786 RVA: 0x00074916 File Offset: 0x00072B16
			public unsafe static Func<int, bool> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046DE RID: 18142
			// (get) Token: 0x0600D9EB RID: 55787 RVA: 0x0034F75C File Offset: 0x0034D95C
			// (set) Token: 0x0600D9EC RID: 55788 RVA: 0x00074928 File Offset: 0x00072B28
			public unsafe static Func<PartnerBase, bool> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Reisen2.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BA1 RID: 35745
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BA2 RID: 35746
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04008BA3 RID: 35747
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x04008BA4 RID: 35748
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04008BA5 RID: 35749
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x04008BA6 RID: 35750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BA7 RID: 35751
			private static readonly IntPtr NativeMethodInfoPtr__FindAllRabbits_b__35_0_Internal_ValueTuple_2_Transform_RabbitType_GameObject_0;

			// Token: 0x04008BA8 RID: 35752
			private static readonly IntPtr NativeMethodInfoPtr__FindAllRabbits_b__35_1_Internal_ValueTuple_2_Transform_RabbitType_Transform_0;

			// Token: 0x04008BA9 RID: 35753
			private static readonly IntPtr NativeMethodInfoPtr__SpawnIngredientsOrBeverage_b__36_0_Internal_Boolean_Int32_0;

			// Token: 0x04008BAA RID: 35754
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_0_Internal_Boolean_PartnerBase_0;
		}

		// Token: 0x02000B9D RID: 2973
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reisen2+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9ED RID: 55789 RVA: 0x0034F784 File Offset: 0x0034D984
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr);
				Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr_spawnUiPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr, "spawnUiPosition");
				Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr, "sprite");
				Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr, "<>9__1");
				Spell_Reisen2.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr, 100679427);
				Spell_Reisen2.__c__DisplayClass37_0.NativeMethodInfoPtr__SpawnRabbitVfx_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr, 100679428);
				Spell_Reisen2.__c__DisplayClass37_0.NativeMethodInfoPtr__SpawnRabbitVfx_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr, 100679429);
			}

			// Token: 0x0600D9EE RID: 55790 RVA: 0x0034F828 File Offset: 0x0034DA28
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reisen2.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9EF RID: 55791 RVA: 0x0034F864 File Offset: 0x0034DA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202087, XrefRangeEnd = 202101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnRabbitVfx_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass37_0.NativeMethodInfoPtr__SpawnRabbitVfx_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9F0 RID: 55792 RVA: 0x0034F8A8 File Offset: 0x0034DAA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202101, XrefRangeEnd = 202103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnRabbitVfx_b__1(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2.__c__DisplayClass37_0.NativeMethodInfoPtr__SpawnRabbitVfx_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9F1 RID: 55793 RVA: 0x0007493A File Offset: 0x00072B3A
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046DF RID: 18143
			// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x0034F8EC File Offset: 0x0034DAEC
			// (set) Token: 0x0600D9F3 RID: 55795 RVA: 0x00074943 File Offset: 0x00072B43
			public unsafe Vector3 spawnUiPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr_spawnUiPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr_spawnUiPosition)) = value;
				}
			}

			// Token: 0x170046E0 RID: 18144
			// (get) Token: 0x0600D9F4 RID: 55796 RVA: 0x0034F914 File Offset: 0x0034DB14
			// (set) Token: 0x0600D9F5 RID: 55797 RVA: 0x0007495E File Offset: 0x00072B5E
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E1 RID: 18145
			// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x0034F944 File Offset: 0x0034DB44
			// (set) Token: 0x0600D9F7 RID: 55799 RVA: 0x0007497D File Offset: 0x00072B7D
			public unsafe Action<Image> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2.__c__DisplayClass37_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BAB RID: 35755
			private static readonly IntPtr NativeFieldInfoPtr_spawnUiPosition;

			// Token: 0x04008BAC RID: 35756
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04008BAD RID: 35757
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04008BAE RID: 35758
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BAF RID: 35759
			private static readonly IntPtr NativeMethodInfoPtr__SpawnRabbitVfx_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008BB0 RID: 35760
			private static readonly IntPtr NativeMethodInfoPtr__SpawnRabbitVfx_b__1_Internal_Void_Image_0;
		}

		// Token: 0x02000B9E RID: 2974
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Reisen2+<OnNegativeBuffExecute>d__38")]
		public sealed class _OnNegativeBuffExecute_d__38 : Il2CppSystem.Object
		{
			// Token: 0x0600D9F8 RID: 55800 RVA: 0x0034F974 File Offset: 0x0034DB74
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__38()
			{
				Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Reisen2>.NativeClassPtr, "<OnNegativeBuffExecute>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr);
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>1__state");
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>2__current");
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, "spellExecutionContext");
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>4__this");
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__position_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<position>5__2");
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679430);
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679431);
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679432);
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679433);
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679434);
				Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679435);
			}

			// Token: 0x0600D9F9 RID: 55801 RVA: 0x0034FA7C File Offset: 0x0034DC7C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Reisen2._OnNegativeBuffExecute_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9FA RID: 55802 RVA: 0x0034FAC4 File Offset: 0x0034DCC4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9FB RID: 55803 RVA: 0x0034FAF8 File Offset: 0x0034DCF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202103, XrefRangeEnd = 202148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046E7 RID: 18151
			// (get) Token: 0x0600D9FC RID: 55804 RVA: 0x0034FB34 File Offset: 0x0034DD34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9FD RID: 55805 RVA: 0x0034FB74 File Offset: 0x0034DD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202148, XrefRangeEnd = 202154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046E8 RID: 18152
			// (get) Token: 0x0600D9FE RID: 55806 RVA: 0x0034FBA8 File Offset: 0x0034DDA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9FF RID: 55807 RVA: 0x0007499C File Offset: 0x00072B9C
			public _OnNegativeBuffExecute_d__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046E2 RID: 18146
			// (get) Token: 0x0600DA00 RID: 55808 RVA: 0x0034FBE8 File Offset: 0x0034DDE8
			// (set) Token: 0x0600DA01 RID: 55809 RVA: 0x000749A5 File Offset: 0x00072BA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046E3 RID: 18147
			// (get) Token: 0x0600DA02 RID: 55810 RVA: 0x0034FC10 File Offset: 0x0034DE10
			// (set) Token: 0x0600DA03 RID: 55811 RVA: 0x000749C0 File Offset: 0x00072BC0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E4 RID: 18148
			// (get) Token: 0x0600DA04 RID: 55812 RVA: 0x0034FC40 File Offset: 0x0034DE40
			// (set) Token: 0x0600DA05 RID: 55813 RVA: 0x000749DF File Offset: 0x00072BDF
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E5 RID: 18149
			// (get) Token: 0x0600DA06 RID: 55814 RVA: 0x0034FC70 File Offset: 0x0034DE70
			// (set) Token: 0x0600DA07 RID: 55815 RVA: 0x000749FE File Offset: 0x00072BFE
			public unsafe Spell_Reisen2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Reisen2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E6 RID: 18150
			// (get) Token: 0x0600DA08 RID: 55816 RVA: 0x0034FCA0 File Offset: 0x0034DEA0
			// (set) Token: 0x0600DA09 RID: 55817 RVA: 0x00074A1D File Offset: 0x00072C1D
			public unsafe Vector3 _position_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__position_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Reisen2._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__position_5__2)) = value;
				}
			}

			// Token: 0x04008BB1 RID: 35761
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BB2 RID: 35762
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BB3 RID: 35763
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008BB4 RID: 35764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BB5 RID: 35765
			private static readonly IntPtr NativeFieldInfoPtr__position_5__2;

			// Token: 0x04008BB6 RID: 35766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BB7 RID: 35767
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BB8 RID: 35768
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BB9 RID: 35769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BBA RID: 35770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BBB RID: 35771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
