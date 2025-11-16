using System;
using Common.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000296 RID: 662
	public class Spell_Yuuka : SpellBase
	{
		// Token: 0x060053DD RID: 21469 RVA: 0x001B9E74 File Offset: 0x001B8074
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yuuka()
		{
			Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yuuka");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr);
			Spell_Yuuka.NativeFieldInfoPtr_YUUKA_FLOWER_QUEUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "YUUKA_FLOWER_QUEUE");
			Spell_Yuuka.NativeFieldInfoPtr_YUUKA_COMBO_CHECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "YUUKA_COMBO_CHECK");
			Spell_Yuuka.NativeFieldInfoPtr_WRIGGLE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "WRIGGLE_ID");
			Spell_Yuuka.NativeFieldInfoPtr_YUUKA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "YUUKA_ID");
			Spell_Yuuka.NativeFieldInfoPtr_sunFlowerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "sunFlowerParent");
			Spell_Yuuka.NativeFieldInfoPtr_sunVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "sunVFX");
			Spell_Yuuka.NativeFieldInfoPtr_generateDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "generateDuration");
			Spell_Yuuka.NativeFieldInfoPtr_flowerSpawnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "flowerSpawnDuration");
			Spell_Yuuka.NativeFieldInfoPtr_sunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "sunDuration");
			Spell_Yuuka.NativeFieldInfoPtr_giveTipNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "giveTipNum");
			Spell_Yuuka.NativeFieldInfoPtr_giveTipInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "giveTipInterval");
			Spell_Yuuka.NativeFieldInfoPtr_eachBuffTriggerNeedNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "eachBuffTriggerNeedNum");
			Spell_Yuuka.NativeFieldInfoPtr_extraMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "extraMood");
			Spell_Yuuka.NativeFieldInfoPtr_blossomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "blossomDuration");
			Spell_Yuuka.NativeFieldInfoPtr_specialWrigglePositiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "specialWrigglePositiveDuration");
			Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_PunishmentBlasterFireDelay");
			Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_PunishmentBlaster");
			Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireKickGuestOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_PunishmentBlasterFireKickGuestOffset");
			Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_PunishmentBlasterFireLength");
			Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterChargeCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_PunishmentBlasterChargeCameraShakeAmplitude");
			Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_PunishmentBlasterFireCameraShakeAmplitude");
			Spell_Yuuka.NativeFieldInfoPtr_brokenDesk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "brokenDesk");
			Spell_Yuuka.NativeFieldInfoPtr_smokeVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "smokeVFX");
			Spell_Yuuka.NativeFieldInfoPtr_m_WaitForSparkEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_WaitForSparkEnd");
			Spell_Yuuka.NativeFieldInfoPtr_m_SmokeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "m_SmokeOffset");
			Spell_Yuuka.NativeFieldInfoPtr_flowerSpawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "flowerSpawnSfx");
			Spell_Yuuka.NativeFieldInfoPtr_flowerSunSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "flowerSunSfx");
			Spell_Yuuka.NativeFieldInfoPtr_flowerTipSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "flowerTipSfx");
			Spell_Yuuka.NativeFieldInfoPtr_flowerEnergySfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "flowerEnergySfx");
			Spell_Yuuka.NativeFieldInfoPtr_negativeStartSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "negativeStartSfx");
			Spell_Yuuka.NativeFieldInfoPtr_laserStartSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "laserStartSfx");
			Spell_Yuuka.NativeFieldInfoPtr_laserEndSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "laserEndSfx");
			Spell_Yuuka.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680444);
			Spell_Yuuka.NativeMethodInfoPtr_FindBestFitLine_Private_List_1_Int32_Dictionary_2_Int32_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680445);
			Spell_Yuuka.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680446);
			Spell_Yuuka.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680447);
			Spell_Yuuka.NativeMethodInfoPtr_OnYuukaSpellPowerAbsorbCallback_Private_Void_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680448);
			Spell_Yuuka.NativeMethodInfoPtr_FlowerDisappear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680449);
			Spell_Yuuka.NativeMethodInfoPtr_FlowerBlossom_Private_Void_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680450);
			Spell_Yuuka.NativeMethodInfoPtr_Wither_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680451);
			Spell_Yuuka.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, 100680452);
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x001BA1D8 File Offset: 0x001B83D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210462, XrefRangeEnd = 210464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuuka.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x001BA21C File Offset: 0x001B841C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210659, RefRangeEnd = 210660, XrefRangeStart = 210464, XrefRangeEnd = 210659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> FindBestFitLine(Dictionary<int, Vector2> allDeskPosition, int currentDeskIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(allDeskPosition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentDeskIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.NativeMethodInfoPtr_FindBestFitLine_Private_List_1_Int32_Dictionary_2_Int32_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x001BA27C File Offset: 0x001B847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210660, XrefRangeEnd = 210666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuuka.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x001BA2D8 File Offset: 0x001B84D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210666, XrefRangeEnd = 210672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuuka.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x001BA334 File Offset: 0x001B8534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210672, XrefRangeEnd = 210673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnYuukaSpellPowerAbsorbCallback(SpecialGuestsController specialGuestsController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestsController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.NativeMethodInfoPtr_OnYuukaSpellPowerAbsorbCallback_Private_Void_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x001BA378 File Offset: 0x001B8578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210673, XrefRangeEnd = 210691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlowerDisappear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.NativeMethodInfoPtr_FlowerDisappear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x001BA3AC File Offset: 0x001B85AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210753, RefRangeEnd = 210754, XrefRangeStart = 210691, XrefRangeEnd = 210753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlowerBlossom(SpecialGuestsController specialGuestsController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestsController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.NativeMethodInfoPtr_FlowerBlossom_Private_Void_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x001BA3F0 File Offset: 0x001B85F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210777, RefRangeEnd = 210780, XrefRangeStart = 210754, XrefRangeEnd = 210777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wither(GameObject flower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(flower);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.NativeMethodInfoPtr_Wither_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x001BA434 File Offset: 0x001B8634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210780, XrefRangeEnd = 210781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yuuka() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x0002D1C6 File Offset: 0x0002B3C6
		public Spell_Yuuka(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x001BA470 File Offset: 0x001B8670
		// (set) Token: 0x060053E9 RID: 21481 RVA: 0x0002D1CF File Offset: 0x0002B3CF
		public unsafe static string YUUKA_FLOWER_QUEUE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.NativeFieldInfoPtr_YUUKA_FLOWER_QUEUE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.NativeFieldInfoPtr_YUUKA_FLOWER_QUEUE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x001BA490 File Offset: 0x001B8690
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x0002D1E1 File Offset: 0x0002B3E1
		public unsafe static string YUUKA_COMBO_CHECK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.NativeFieldInfoPtr_YUUKA_COMBO_CHECK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.NativeFieldInfoPtr_YUUKA_COMBO_CHECK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x001BA4B0 File Offset: 0x001B86B0
		// (set) Token: 0x060053ED RID: 21485 RVA: 0x0002D1F3 File Offset: 0x0002B3F3
		public unsafe static int WRIGGLE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.NativeFieldInfoPtr_WRIGGLE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.NativeFieldInfoPtr_WRIGGLE_ID, (void*)(&value));
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x060053EE RID: 21486 RVA: 0x001BA4CC File Offset: 0x001B86CC
		// (set) Token: 0x060053EF RID: 21487 RVA: 0x0002D201 File Offset: 0x0002B401
		public unsafe static int YUUKA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.NativeFieldInfoPtr_YUUKA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.NativeFieldInfoPtr_YUUKA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x001BA4E8 File Offset: 0x001B86E8
		// (set) Token: 0x060053F1 RID: 21489 RVA: 0x0002D20F File Offset: 0x0002B40F
		public unsafe GameObject sunFlowerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_sunFlowerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_sunFlowerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x001BA518 File Offset: 0x001B8718
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x0002D22E File Offset: 0x0002B42E
		public unsafe GameObject sunVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_sunVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_sunVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x060053F4 RID: 21492 RVA: 0x001BA548 File Offset: 0x001B8748
		// (set) Token: 0x060053F5 RID: 21493 RVA: 0x0002D24D File Offset: 0x0002B44D
		public unsafe float generateDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_generateDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_generateDuration)) = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x060053F6 RID: 21494 RVA: 0x001BA570 File Offset: 0x001B8770
		// (set) Token: 0x060053F7 RID: 21495 RVA: 0x0002D268 File Offset: 0x0002B468
		public unsafe float flowerSpawnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerSpawnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerSpawnDuration)) = value;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x001BA598 File Offset: 0x001B8798
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x0002D283 File Offset: 0x0002B483
		public unsafe float sunDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_sunDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_sunDuration)) = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x001BA5C0 File Offset: 0x001B87C0
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x0002D29E File Offset: 0x0002B49E
		public unsafe int giveTipNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_giveTipNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_giveTipNum)) = value;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x001BA5E8 File Offset: 0x001B87E8
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x0002D2B9 File Offset: 0x0002B4B9
		public unsafe float giveTipInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_giveTipInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_giveTipInterval)) = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x001BA610 File Offset: 0x001B8810
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		public unsafe int eachBuffTriggerNeedNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_eachBuffTriggerNeedNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_eachBuffTriggerNeedNum)) = value;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x001BA638 File Offset: 0x001B8838
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x0002D2EF File Offset: 0x0002B4EF
		public unsafe int extraMood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_extraMood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_extraMood)) = value;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x001BA660 File Offset: 0x001B8860
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x0002D30A File Offset: 0x0002B50A
		public unsafe int blossomDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_blossomDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_blossomDuration)) = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x001BA688 File Offset: 0x001B8888
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x0002D325 File Offset: 0x0002B525
		public unsafe int specialWrigglePositiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_specialWrigglePositiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_specialWrigglePositiveDuration)) = value;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x001BA6B0 File Offset: 0x001B88B0
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x0002D340 File Offset: 0x0002B540
		public unsafe float m_PunishmentBlasterFireDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireDelay)) = value;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x001BA6D8 File Offset: 0x001B88D8
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x0002D35B File Offset: 0x0002B55B
		public unsafe GameObject m_PunishmentBlaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x001BA708 File Offset: 0x001B8908
		// (set) Token: 0x0600540B RID: 21515 RVA: 0x0002D37A File Offset: 0x0002B57A
		public unsafe float m_PunishmentBlasterFireKickGuestOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireKickGuestOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireKickGuestOffset)) = value;
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x001BA730 File Offset: 0x001B8930
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x0002D395 File Offset: 0x0002B595
		public unsafe float m_PunishmentBlasterFireLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireLength)) = value;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x001BA758 File Offset: 0x001B8958
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x0002D3B0 File Offset: 0x0002B5B0
		public unsafe float m_PunishmentBlasterChargeCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterChargeCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterChargeCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x001BA780 File Offset: 0x001B8980
		// (set) Token: 0x06005411 RID: 21521 RVA: 0x0002D3CB File Offset: 0x0002B5CB
		public unsafe float m_PunishmentBlasterFireCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_PunishmentBlasterFireCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x001BA7A8 File Offset: 0x001B89A8
		// (set) Token: 0x06005413 RID: 21523 RVA: 0x0002D3E6 File Offset: 0x0002B5E6
		public unsafe GameObject brokenDesk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_brokenDesk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_brokenDesk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06005414 RID: 21524 RVA: 0x001BA7D8 File Offset: 0x001B89D8
		// (set) Token: 0x06005415 RID: 21525 RVA: 0x0002D405 File Offset: 0x0002B605
		public unsafe GameObject smokeVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_smokeVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_smokeVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x001BA808 File Offset: 0x001B8A08
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x0002D424 File Offset: 0x0002B624
		public unsafe float m_WaitForSparkEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_WaitForSparkEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_WaitForSparkEnd)) = value;
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x001BA830 File Offset: 0x001B8A30
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x0002D43F File Offset: 0x0002B63F
		public unsafe float m_SmokeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_SmokeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_m_SmokeOffset)) = value;
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x001BA858 File Offset: 0x001B8A58
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x0002D45A File Offset: 0x0002B65A
		public SpellBase.DelayAudioClip flowerSpawnSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerSpawnSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerSpawnSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x001BA888 File Offset: 0x001B8A88
		// (set) Token: 0x0600541D RID: 21533 RVA: 0x0002D488 File Offset: 0x0002B688
		public SpellBase.DelayAudioClip flowerSunSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerSunSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerSunSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x001BA8B8 File Offset: 0x001B8AB8
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x0002D4B6 File Offset: 0x0002B6B6
		public SpellBase.DelayAudioClip flowerTipSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerTipSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerTipSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x001BA8E8 File Offset: 0x001B8AE8
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
		public SpellBase.DelayAudioClip flowerEnergySfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerEnergySfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_flowerEnergySfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x001BA918 File Offset: 0x001B8B18
		// (set) Token: 0x06005423 RID: 21539 RVA: 0x0002D512 File Offset: 0x0002B712
		public SpellBase.DelayAudioClip negativeStartSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_negativeStartSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_negativeStartSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x001BA948 File Offset: 0x001B8B48
		// (set) Token: 0x06005425 RID: 21541 RVA: 0x0002D540 File Offset: 0x0002B740
		public unsafe LoopedBGMPackage laserStartSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_laserStartSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_laserStartSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x001BA978 File Offset: 0x001B8B78
		// (set) Token: 0x06005427 RID: 21543 RVA: 0x0002D55F File Offset: 0x0002B75F
		public SpellBase.DelayAudioClip laserEndSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_laserEndSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.NativeFieldInfoPtr_laserEndSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeFieldInfoPtr_YUUKA_FLOWER_QUEUE;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeFieldInfoPtr_YUUKA_COMBO_CHECK;

		// Token: 0x04003864 RID: 14436
		private static readonly IntPtr NativeFieldInfoPtr_WRIGGLE_ID;

		// Token: 0x04003865 RID: 14437
		private static readonly IntPtr NativeFieldInfoPtr_YUUKA_ID;

		// Token: 0x04003866 RID: 14438
		private static readonly IntPtr NativeFieldInfoPtr_sunFlowerParent;

		// Token: 0x04003867 RID: 14439
		private static readonly IntPtr NativeFieldInfoPtr_sunVFX;

		// Token: 0x04003868 RID: 14440
		private static readonly IntPtr NativeFieldInfoPtr_generateDuration;

		// Token: 0x04003869 RID: 14441
		private static readonly IntPtr NativeFieldInfoPtr_flowerSpawnDuration;

		// Token: 0x0400386A RID: 14442
		private static readonly IntPtr NativeFieldInfoPtr_sunDuration;

		// Token: 0x0400386B RID: 14443
		private static readonly IntPtr NativeFieldInfoPtr_giveTipNum;

		// Token: 0x0400386C RID: 14444
		private static readonly IntPtr NativeFieldInfoPtr_giveTipInterval;

		// Token: 0x0400386D RID: 14445
		private static readonly IntPtr NativeFieldInfoPtr_eachBuffTriggerNeedNum;

		// Token: 0x0400386E RID: 14446
		private static readonly IntPtr NativeFieldInfoPtr_extraMood;

		// Token: 0x0400386F RID: 14447
		private static readonly IntPtr NativeFieldInfoPtr_blossomDuration;

		// Token: 0x04003870 RID: 14448
		private static readonly IntPtr NativeFieldInfoPtr_specialWrigglePositiveDuration;

		// Token: 0x04003871 RID: 14449
		private static readonly IntPtr NativeFieldInfoPtr_m_PunishmentBlasterFireDelay;

		// Token: 0x04003872 RID: 14450
		private static readonly IntPtr NativeFieldInfoPtr_m_PunishmentBlaster;

		// Token: 0x04003873 RID: 14451
		private static readonly IntPtr NativeFieldInfoPtr_m_PunishmentBlasterFireKickGuestOffset;

		// Token: 0x04003874 RID: 14452
		private static readonly IntPtr NativeFieldInfoPtr_m_PunishmentBlasterFireLength;

		// Token: 0x04003875 RID: 14453
		private static readonly IntPtr NativeFieldInfoPtr_m_PunishmentBlasterChargeCameraShakeAmplitude;

		// Token: 0x04003876 RID: 14454
		private static readonly IntPtr NativeFieldInfoPtr_m_PunishmentBlasterFireCameraShakeAmplitude;

		// Token: 0x04003877 RID: 14455
		private static readonly IntPtr NativeFieldInfoPtr_brokenDesk;

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeFieldInfoPtr_smokeVFX;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForSparkEnd;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeFieldInfoPtr_m_SmokeOffset;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeFieldInfoPtr_flowerSpawnSfx;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeFieldInfoPtr_flowerSunSfx;

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeFieldInfoPtr_flowerTipSfx;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeFieldInfoPtr_flowerEnergySfx;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeFieldInfoPtr_negativeStartSfx;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeFieldInfoPtr_laserStartSfx;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeFieldInfoPtr_laserEndSfx;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeMethodInfoPtr_FindBestFitLine_Private_List_1_Int32_Dictionary_2_Int32_Vector2_Int32_0;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeMethodInfoPtr_OnYuukaSpellPowerAbsorbCallback_Private_Void_SpecialGuestsController_0;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeMethodInfoPtr_FlowerDisappear_Private_Void_0;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr_FlowerBlossom_Private_Void_SpecialGuestsController_0;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeMethodInfoPtr_Wither_Private_Void_GameObject_0;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C31 RID: 3121
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E1E4 RID: 57828 RVA: 0x0036773C File Offset: 0x0036593C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr);
				Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, "max");
				Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_bestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, "bestNum");
				Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_bestVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, "bestVectors");
				Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, 100680453);
				Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__FindBestFitLine_b__0_Internal_Boolean_KeyValuePair_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, 100680454);
				Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__FindBestFitLine_b__3_Internal_Boolean_KeyValuePair_2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, 100680455);
				Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__FindBestFitLine_b__5_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr, 100680456);
			}

			// Token: 0x0600E1E5 RID: 57829 RVA: 0x003677F4 File Offset: 0x003659F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1E6 RID: 57830 RVA: 0x00367830 File Offset: 0x00365A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209940, XrefRangeEnd = 209943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindBestFitLine_b__0(KeyValuePair<int, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__FindBestFitLine_b__0_Internal_Boolean_KeyValuePair_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1E7 RID: 57831 RVA: 0x00367884 File Offset: 0x00365A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209943, XrefRangeEnd = 209944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindBestFitLine_b__3(KeyValuePair<Vector2, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__FindBestFitLine_b__3_Internal_Boolean_KeyValuePair_2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1E8 RID: 57832 RVA: 0x003678D8 File Offset: 0x00365AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209944, XrefRangeEnd = 209945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindBestFitLine_b__5(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass33_0.NativeMethodInfoPtr__FindBestFitLine_b__5_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1E9 RID: 57833 RVA: 0x00078809 File Offset: 0x00076A09
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004957 RID: 18775
			// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x0036792C File Offset: 0x00365B2C
			// (set) Token: 0x0600E1EB RID: 57835 RVA: 0x00078812 File Offset: 0x00076A12
			public unsafe float max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_max)) = value;
				}
			}

			// Token: 0x17004958 RID: 18776
			// (get) Token: 0x0600E1EC RID: 57836 RVA: 0x00367954 File Offset: 0x00365B54
			// (set) Token: 0x0600E1ED RID: 57837 RVA: 0x0007882D File Offset: 0x00076A2D
			public unsafe int bestNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_bestNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_bestNum)) = value;
				}
			}

			// Token: 0x17004959 RID: 18777
			// (get) Token: 0x0600E1EE RID: 57838 RVA: 0x0036797C File Offset: 0x00365B7C
			// (set) Token: 0x0600E1EF RID: 57839 RVA: 0x00078848 File Offset: 0x00076A48
			public unsafe Vector2 bestVectors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_bestVectors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass33_0.NativeFieldInfoPtr_bestVectors)) = value;
				}
			}

			// Token: 0x04009074 RID: 36980
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x04009075 RID: 36981
			private static readonly IntPtr NativeFieldInfoPtr_bestNum;

			// Token: 0x04009076 RID: 36982
			private static readonly IntPtr NativeFieldInfoPtr_bestVectors;

			// Token: 0x04009077 RID: 36983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009078 RID: 36984
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__0_Internal_Boolean_KeyValuePair_2_Int32_Single_0;

			// Token: 0x04009079 RID: 36985
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__3_Internal_Boolean_KeyValuePair_2_Vector2_Int32_0;

			// Token: 0x0400907A RID: 36986
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__5_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0;
		}

		// Token: 0x02000C32 RID: 3122
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E1F0 RID: 57840 RVA: 0x003679A4 File Offset: 0x00365BA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr);
				Spell_Yuuka.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9");
				Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9__33_1");
				Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9__33_2");
				Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9__33_4");
				Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9__33_6");
				Spell_Yuuka.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9__34_0");
				Spell_Yuuka.__c.NativeFieldInfoPtr___9__34_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, "<>9__34_6");
				Spell_Yuuka.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680458);
				Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_1_Internal_Int32_KeyValuePair_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680459);
				Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_2_Internal_Int32_KeyValuePair_2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680460);
				Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_4_Internal_Vector2_KeyValuePair_2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680461);
				Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_6_Internal_Int32_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680462);
				Spell_Yuuka.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__34_0_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680463);
				Spell_Yuuka.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__34_6_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr, 100680464);
			}

			// Token: 0x0600E1F1 RID: 57841 RVA: 0x00367AE8 File Offset: 0x00365CE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1F2 RID: 57842 RVA: 0x00367B24 File Offset: 0x00365D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209945, XrefRangeEnd = 209946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FindBestFitLine_b__33_1(KeyValuePair<int, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_1_Internal_Int32_KeyValuePair_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1F3 RID: 57843 RVA: 0x00367B78 File Offset: 0x00365D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209946, XrefRangeEnd = 209947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FindBestFitLine_b__33_2(KeyValuePair<Vector2, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_2_Internal_Int32_KeyValuePair_2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1F4 RID: 57844 RVA: 0x00367BCC File Offset: 0x00365DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209947, XrefRangeEnd = 209948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _FindBestFitLine_b__33_4(KeyValuePair<Vector2, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_4_Internal_Vector2_KeyValuePair_2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1F5 RID: 57845 RVA: 0x00367C20 File Offset: 0x00365E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209948, XrefRangeEnd = 209949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FindBestFitLine_b__33_6(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__FindBestFitLine_b__33_6_Internal_Int32_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1F6 RID: 57846 RVA: 0x00367C74 File Offset: 0x00365E74
			[CallerCount(0)]
			public unsafe int _OnNegativeBuffExecute_b__34_0(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__34_0_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1F7 RID: 57847 RVA: 0x00367CC0 File Offset: 0x00365EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__34_6(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__34_6_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1F8 RID: 57848 RVA: 0x00078863 File Offset: 0x00076A63
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700495A RID: 18778
			// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x00367D04 File Offset: 0x00365F04
			// (set) Token: 0x0600E1FA RID: 57850 RVA: 0x0007886C File Offset: 0x00076A6C
			public unsafe static Spell_Yuuka.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700495B RID: 18779
			// (get) Token: 0x0600E1FB RID: 57851 RVA: 0x00367D2C File Offset: 0x00365F2C
			// (set) Token: 0x0600E1FC RID: 57852 RVA: 0x0007887E File Offset: 0x00076A7E
			public unsafe static Func<KeyValuePair<int, float>, int> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, float>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700495C RID: 18780
			// (get) Token: 0x0600E1FD RID: 57853 RVA: 0x00367D54 File Offset: 0x00365F54
			// (set) Token: 0x0600E1FE RID: 57854 RVA: 0x00078890 File Offset: 0x00076A90
			public unsafe static Func<KeyValuePair<Vector2, int>, int> __9__33_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Vector2, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700495D RID: 18781
			// (get) Token: 0x0600E1FF RID: 57855 RVA: 0x00367D7C File Offset: 0x00365F7C
			// (set) Token: 0x0600E200 RID: 57856 RVA: 0x000788A2 File Offset: 0x00076AA2
			public unsafe static Func<KeyValuePair<Vector2, int>, Vector2> __9__33_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Vector2, int>, Vector2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700495E RID: 18782
			// (get) Token: 0x0600E201 RID: 57857 RVA: 0x00367DA4 File Offset: 0x00365FA4
			// (set) Token: 0x0600E202 RID: 57858 RVA: 0x000788B4 File Offset: 0x00076AB4
			public unsafe static Func<KeyValuePair<int, Vector2>, int> __9__33_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Vector2>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__33_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700495F RID: 18783
			// (get) Token: 0x0600E203 RID: 57859 RVA: 0x00367DCC File Offset: 0x00365FCC
			// (set) Token: 0x0600E204 RID: 57860 RVA: 0x000788C6 File Offset: 0x00076AC6
			public unsafe static Func<Vector3Int, int> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004960 RID: 18784
			// (get) Token: 0x0600E205 RID: 57861 RVA: 0x00367DF4 File Offset: 0x00365FF4
			// (set) Token: 0x0600E206 RID: 57862 RVA: 0x000788D8 File Offset: 0x00076AD8
			public unsafe static Action<AStarInputGeneratorComponent> __9__34_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__34_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuuka.__c.NativeFieldInfoPtr___9__34_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400907B RID: 36987
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400907C RID: 36988
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x0400907D RID: 36989
			private static readonly IntPtr NativeFieldInfoPtr___9__33_2;

			// Token: 0x0400907E RID: 36990
			private static readonly IntPtr NativeFieldInfoPtr___9__33_4;

			// Token: 0x0400907F RID: 36991
			private static readonly IntPtr NativeFieldInfoPtr___9__33_6;

			// Token: 0x04009080 RID: 36992
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04009081 RID: 36993
			private static readonly IntPtr NativeFieldInfoPtr___9__34_6;

			// Token: 0x04009082 RID: 36994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009083 RID: 36995
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__33_1_Internal_Int32_KeyValuePair_2_Int32_Single_0;

			// Token: 0x04009084 RID: 36996
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__33_2_Internal_Int32_KeyValuePair_2_Vector2_Int32_0;

			// Token: 0x04009085 RID: 36997
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__33_4_Internal_Vector2_KeyValuePair_2_Vector2_Int32_0;

			// Token: 0x04009086 RID: 36998
			private static readonly IntPtr NativeMethodInfoPtr__FindBestFitLine_b__33_6_Internal_Int32_KeyValuePair_2_Int32_Vector2_0;

			// Token: 0x04009087 RID: 36999
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__34_0_Internal_Int32_Vector3Int_0;

			// Token: 0x04009088 RID: 37000
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__34_6_Internal_Void_AStarInputGeneratorComponent_0;
		}

		// Token: 0x02000C33 RID: 3123
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E207 RID: 57863 RVA: 0x00367E1C File Offset: 0x0036601C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr);
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_nearDesk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "nearDesk");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_onArrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "onArrive");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_tileDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "tileDictionary");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_tileManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "tileManager");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_interactableTileMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "interactableTileMap");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_yuukaSmoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "yuukaSmoke");
				Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, 100680465);
				Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Single_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, 100680466);
				Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, 100680467);
				Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, 100680468);
				Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, 100680469);
				Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, 100680470);
			}

			// Token: 0x0600E208 RID: 57864 RVA: 0x00367F60 File Offset: 0x00366160
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E209 RID: 57865 RVA: 0x00367F9C File Offset: 0x0036619C
			[CallerCount(0)]
			public unsafe float _OnNegativeBuffExecute_b__1(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Single_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E20A RID: 57866 RVA: 0x00367FE8 File Offset: 0x003661E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 209966, RefRangeEnd = 209968, XrefRangeStart = 209966, XrefRangeEnd = 209966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(GuestGroupController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E20B RID: 57867 RVA: 0x0036802C File Offset: 0x0036622C
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E20C RID: 57868 RVA: 0x00368068 File Offset: 0x00366268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209968, XrefRangeEnd = 209999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E20D RID: 57869 RVA: 0x0036809C File Offset: 0x0036629C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209999, XrefRangeEnd = 210004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E20E RID: 57870 RVA: 0x000788EA File Offset: 0x00076AEA
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004961 RID: 18785
			// (get) Token: 0x0600E20F RID: 57871 RVA: 0x003680DC File Offset: 0x003662DC
			// (set) Token: 0x0600E210 RID: 57872 RVA: 0x000788F3 File Offset: 0x00076AF3
			public unsafe Vector3Int nearDesk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_nearDesk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_nearDesk)) = value;
				}
			}

			// Token: 0x17004962 RID: 18786
			// (get) Token: 0x0600E211 RID: 57873 RVA: 0x00368104 File Offset: 0x00366304
			// (set) Token: 0x0600E212 RID: 57874 RVA: 0x0007890E File Offset: 0x00076B0E
			public unsafe bool onArrive
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_onArrive);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_onArrive)) = value;
				}
			}

			// Token: 0x17004963 RID: 18787
			// (get) Token: 0x0600E213 RID: 57875 RVA: 0x0036812C File Offset: 0x0036632C
			// (set) Token: 0x0600E214 RID: 57876 RVA: 0x00078929 File Offset: 0x00076B29
			public unsafe Dictionary<int, ValueTuple<GameObject, InteractableTile, Sprite>> tileDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_tileDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<GameObject, InteractableTile, Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_tileDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004964 RID: 18788
			// (get) Token: 0x0600E215 RID: 57877 RVA: 0x0036815C File Offset: 0x0036635C
			// (set) Token: 0x0600E216 RID: 57878 RVA: 0x00078948 File Offset: 0x00076B48
			public unsafe TileManager tileManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_tileManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_tileManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004965 RID: 18789
			// (get) Token: 0x0600E217 RID: 57879 RVA: 0x0036818C File Offset: 0x0036638C
			// (set) Token: 0x0600E218 RID: 57880 RVA: 0x00078967 File Offset: 0x00076B67
			public unsafe Tilemap interactableTileMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_interactableTileMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_interactableTileMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004966 RID: 18790
			// (get) Token: 0x0600E219 RID: 57881 RVA: 0x003681BC File Offset: 0x003663BC
			// (set) Token: 0x0600E21A RID: 57882 RVA: 0x00078986 File Offset: 0x00076B86
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004967 RID: 18791
			// (get) Token: 0x0600E21B RID: 57883 RVA: 0x003681EC File Offset: 0x003663EC
			// (set) Token: 0x0600E21C RID: 57884 RVA: 0x000789A5 File Offset: 0x00076BA5
			public unsafe GameObject yuukaSmoke
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_yuukaSmoke);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr_yuukaSmoke), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004968 RID: 18792
			// (get) Token: 0x0600E21D RID: 57885 RVA: 0x0036821C File Offset: 0x0036641C
			// (set) Token: 0x0600E21E RID: 57886 RVA: 0x000789C4 File Offset: 0x00076BC4
			public unsafe Spell_Yuuka __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009089 RID: 37001
			private static readonly IntPtr NativeFieldInfoPtr_nearDesk;

			// Token: 0x0400908A RID: 37002
			private static readonly IntPtr NativeFieldInfoPtr_onArrive;

			// Token: 0x0400908B RID: 37003
			private static readonly IntPtr NativeFieldInfoPtr_tileDictionary;

			// Token: 0x0400908C RID: 37004
			private static readonly IntPtr NativeFieldInfoPtr_tileManager;

			// Token: 0x0400908D RID: 37005
			private static readonly IntPtr NativeFieldInfoPtr_interactableTileMap;

			// Token: 0x0400908E RID: 37006
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400908F RID: 37007
			private static readonly IntPtr NativeFieldInfoPtr_yuukaSmoke;

			// Token: 0x04009090 RID: 37008
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009091 RID: 37009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009092 RID: 37010
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Single_Vector3Int_0;

			// Token: 0x04009093 RID: 37011
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0;

			// Token: 0x04009094 RID: 37012
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Boolean_0;

			// Token: 0x04009095 RID: 37013
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04009096 RID: 37014
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001055 RID: 4181
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass34_0+<<OnNegativeBuffExecute>g__Follow|5>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011DFC RID: 73212 RVA: 0x00416C7C File Offset: 0x00414E7C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Follow|5>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<time>5__2");
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680471);
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680472);
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680473);
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680474);
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680475);
					Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680476);
				}

				// Token: 0x06011DFD RID: 73213 RVA: 0x00416D70 File Offset: 0x00414F70
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DFE RID: 73214 RVA: 0x00416DB8 File Offset: 0x00414FB8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DFF RID: 73215 RVA: 0x00416DEC File Offset: 0x00414FEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209949, XrefRangeEnd = 209960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D2C RID: 23852
				// (get) Token: 0x06011E00 RID: 73216 RVA: 0x00416E28 File Offset: 0x00415028
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E01 RID: 73217 RVA: 0x00416E68 File Offset: 0x00415068
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209960, XrefRangeEnd = 209966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D2D RID: 23853
				// (get) Token: 0x06011E02 RID: 73218 RVA: 0x00416E9C File Offset: 0x0041509C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E03 RID: 73219 RVA: 0x0009B423 File Offset: 0x00099623
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D28 RID: 23848
				// (get) Token: 0x06011E04 RID: 73220 RVA: 0x00416EDC File Offset: 0x004150DC
				// (set) Token: 0x06011E05 RID: 73221 RVA: 0x0009B42C File Offset: 0x0009962C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D29 RID: 23849
				// (get) Token: 0x06011E06 RID: 73222 RVA: 0x00416F04 File Offset: 0x00415104
				// (set) Token: 0x06011E07 RID: 73223 RVA: 0x0009B447 File Offset: 0x00099647
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D2A RID: 23850
				// (get) Token: 0x06011E08 RID: 73224 RVA: 0x00416F34 File Offset: 0x00415134
				// (set) Token: 0x06011E09 RID: 73225 RVA: 0x0009B466 File Offset: 0x00099666
				public unsafe Spell_Yuuka.__c__DisplayClass34_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D2B RID: 23851
				// (get) Token: 0x06011E0A RID: 73226 RVA: 0x00416F64 File Offset: 0x00415164
				// (set) Token: 0x06011E0B RID: 73227 RVA: 0x0009B485 File Offset: 0x00099685
				public unsafe float _time_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__time_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__time_5__2)) = value;
					}
				}

				// Token: 0x0400B4A9 RID: 46249
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4AA RID: 46250
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B4AB RID: 46251
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4AC RID: 46252
				private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

				// Token: 0x0400B4AD RID: 46253
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B4AE RID: 46254
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4AF RID: 46255
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B4B0 RID: 46256
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B4B1 RID: 46257
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4B2 RID: 46258
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C34 RID: 3124
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<OnNegativeBuffExecute>d__34")]
		public sealed class _OnNegativeBuffExecute_d__34 : Il2CppSystem.Object
		{
			// Token: 0x0600E21F RID: 57887 RVA: 0x0036824C File Offset: 0x0036644C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__34()
			{
				Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<OnNegativeBuffExecute>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr);
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<>1__state");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<>2__current");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "spellExecutionContext");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<>4__this");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<>8__1");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__lockedDeskCode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<lockedDeskCode>5__2");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__characterTargetWorldPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<characterTargetWorldPosition>5__3");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__center_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<center>5__4");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__yukaLaser_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<yukaLaser>5__5");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__punishmentBlasterFireKickGuestOffset_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, "<punishmentBlasterFireKickGuestOffset>5__6");
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, 100680477);
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, 100680478);
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, 100680479);
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, 100680480);
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, 100680481);
				Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr, 100680482);
			}

			// Token: 0x0600E220 RID: 57888 RVA: 0x003683B8 File Offset: 0x003665B8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__34(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka._OnNegativeBuffExecute_d__34>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E221 RID: 57889 RVA: 0x00368400 File Offset: 0x00366600
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E222 RID: 57890 RVA: 0x00368434 File Offset: 0x00366634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210004, XrefRangeEnd = 210274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004973 RID: 18803
			// (get) Token: 0x0600E223 RID: 57891 RVA: 0x00368470 File Offset: 0x00366670
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E224 RID: 57892 RVA: 0x003684B0 File Offset: 0x003666B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210274, XrefRangeEnd = 210280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004974 RID: 18804
			// (get) Token: 0x0600E225 RID: 57893 RVA: 0x003684E4 File Offset: 0x003666E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E226 RID: 57894 RVA: 0x000789E3 File Offset: 0x00076BE3
			public _OnNegativeBuffExecute_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004969 RID: 18793
			// (get) Token: 0x0600E227 RID: 57895 RVA: 0x00368524 File Offset: 0x00366724
			// (set) Token: 0x0600E228 RID: 57896 RVA: 0x000789EC File Offset: 0x00076BEC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700496A RID: 18794
			// (get) Token: 0x0600E229 RID: 57897 RVA: 0x0036854C File Offset: 0x0036674C
			// (set) Token: 0x0600E22A RID: 57898 RVA: 0x00078A07 File Offset: 0x00076C07
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700496B RID: 18795
			// (get) Token: 0x0600E22B RID: 57899 RVA: 0x0036857C File Offset: 0x0036677C
			// (set) Token: 0x0600E22C RID: 57900 RVA: 0x00078A26 File Offset: 0x00076C26
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700496C RID: 18796
			// (get) Token: 0x0600E22D RID: 57901 RVA: 0x003685AC File Offset: 0x003667AC
			// (set) Token: 0x0600E22E RID: 57902 RVA: 0x00078A45 File Offset: 0x00076C45
			public unsafe Spell_Yuuka __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700496D RID: 18797
			// (get) Token: 0x0600E22F RID: 57903 RVA: 0x003685DC File Offset: 0x003667DC
			// (set) Token: 0x0600E230 RID: 57904 RVA: 0x00078A64 File Offset: 0x00076C64
			public unsafe Spell_Yuuka.__c__DisplayClass34_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka.__c__DisplayClass34_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700496E RID: 18798
			// (get) Token: 0x0600E231 RID: 57905 RVA: 0x0036860C File Offset: 0x0036680C
			// (set) Token: 0x0600E232 RID: 57906 RVA: 0x00078A83 File Offset: 0x00076C83
			public unsafe List<int> _lockedDeskCode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__lockedDeskCode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__lockedDeskCode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700496F RID: 18799
			// (get) Token: 0x0600E233 RID: 57907 RVA: 0x0036863C File Offset: 0x0036683C
			// (set) Token: 0x0600E234 RID: 57908 RVA: 0x00078AA2 File Offset: 0x00076CA2
			public unsafe Vector3 _characterTargetWorldPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__characterTargetWorldPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__characterTargetWorldPosition_5__3)) = value;
				}
			}

			// Token: 0x17004970 RID: 18800
			// (get) Token: 0x0600E235 RID: 57909 RVA: 0x00368664 File Offset: 0x00366864
			// (set) Token: 0x0600E236 RID: 57910 RVA: 0x00078ABD File Offset: 0x00076CBD
			public unsafe Vector3 _center_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__center_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__center_5__4)) = value;
				}
			}

			// Token: 0x17004971 RID: 18801
			// (get) Token: 0x0600E237 RID: 57911 RVA: 0x0036868C File Offset: 0x0036688C
			// (set) Token: 0x0600E238 RID: 57912 RVA: 0x00078AD8 File Offset: 0x00076CD8
			public unsafe GameObject _yukaLaser_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__yukaLaser_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__yukaLaser_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004972 RID: 18802
			// (get) Token: 0x0600E239 RID: 57913 RVA: 0x003686BC File Offset: 0x003668BC
			// (set) Token: 0x0600E23A RID: 57914 RVA: 0x00078AF7 File Offset: 0x00076CF7
			public unsafe float _punishmentBlasterFireKickGuestOffset_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__punishmentBlasterFireKickGuestOffset_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnNegativeBuffExecute_d__34.NativeFieldInfoPtr__punishmentBlasterFireKickGuestOffset_5__6)) = value;
				}
			}

			// Token: 0x04009097 RID: 37015
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009098 RID: 37016
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009099 RID: 37017
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400909A RID: 37018
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400909B RID: 37019
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400909C RID: 37020
			private static readonly IntPtr NativeFieldInfoPtr__lockedDeskCode_5__2;

			// Token: 0x0400909D RID: 37021
			private static readonly IntPtr NativeFieldInfoPtr__characterTargetWorldPosition_5__3;

			// Token: 0x0400909E RID: 37022
			private static readonly IntPtr NativeFieldInfoPtr__center_5__4;

			// Token: 0x0400909F RID: 37023
			private static readonly IntPtr NativeFieldInfoPtr__yukaLaser_5__5;

			// Token: 0x040090A0 RID: 37024
			private static readonly IntPtr NativeFieldInfoPtr__punishmentBlasterFireKickGuestOffset_5__6;

			// Token: 0x040090A1 RID: 37025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090A2 RID: 37026
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090A3 RID: 37027
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090A4 RID: 37028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090A5 RID: 37029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090A6 RID: 37030
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C35 RID: 3125
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass35_0")]
		public new sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E23B RID: 57915 RVA: 0x003686E4 File Offset: 0x003668E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr);
				Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr_endNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, "endNum");
				Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr_spawnNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, "spawnNum");
				Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, 100680483);
				Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, 100680484);
				Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, 100680485);
				Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, 100680486);
				Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, 100680487);
				Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, 100680488);
			}

			// Token: 0x0600E23C RID: 57916 RVA: 0x003687C4 File Offset: 0x003669C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E23D RID: 57917 RVA: 0x00368800 File Offset: 0x00366A00
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E23E RID: 57918 RVA: 0x0036883C File Offset: 0x00366A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210378, XrefRangeEnd = 210383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E23F RID: 57919 RVA: 0x0036887C File Offset: 0x00366A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210383, XrefRangeEnd = 210398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E240 RID: 57920 RVA: 0x003688B0 File Offset: 0x00366AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210398, XrefRangeEnd = 210410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPositiveBuffExecute_b__3(int num, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E241 RID: 57921 RVA: 0x00368908 File Offset: 0x00366B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210410, XrefRangeEnd = 210416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_GameObject_PDM_0(GameObject thisFlower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisFlower);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E242 RID: 57922 RVA: 0x00078B12 File Offset: 0x00076D12
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004975 RID: 18805
			// (get) Token: 0x0600E243 RID: 57923 RVA: 0x00368958 File Offset: 0x00366B58
			// (set) Token: 0x0600E244 RID: 57924 RVA: 0x00078B1B File Offset: 0x00076D1B
			public unsafe int endNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr_endNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr_endNum)) = value;
				}
			}

			// Token: 0x17004976 RID: 18806
			// (get) Token: 0x0600E245 RID: 57925 RVA: 0x00368980 File Offset: 0x00366B80
			// (set) Token: 0x0600E246 RID: 57926 RVA: 0x00078B36 File Offset: 0x00076D36
			public unsafe int spawnNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr_spawnNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr_spawnNum)) = value;
				}
			}

			// Token: 0x17004977 RID: 18807
			// (get) Token: 0x0600E247 RID: 57927 RVA: 0x003689A8 File Offset: 0x00366BA8
			// (set) Token: 0x0600E248 RID: 57928 RVA: 0x00078B51 File Offset: 0x00076D51
			public unsafe Spell_Yuuka __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090A7 RID: 37031
			private static readonly IntPtr NativeFieldInfoPtr_endNum;

			// Token: 0x040090A8 RID: 37032
			private static readonly IntPtr NativeFieldInfoPtr_spawnNum;

			// Token: 0x040090A9 RID: 37033
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090AA RID: 37034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090AB RID: 37035
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Boolean_0;

			// Token: 0x040090AC RID: 37036
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040090AD RID: 37037
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_0;

			// Token: 0x040090AE RID: 37038
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_String_Int32_String_0;

			// Token: 0x040090AF RID: 37039
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_PDM_0;

			// Token: 0x02001056 RID: 4182
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass35_0+<<OnPositiveBuffExecute>g__OnGivingTip|4>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011E0C RID: 73228 RVA: 0x00416F8C File Offset: 0x0041518C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__OnGivingTip|4>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr_thisFlower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, "thisFlower");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr__wait1_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, "<wait1>5__2");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr__wait2_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, "<wait2>5__3");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, 100680489);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, 100680490);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, 100680491);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, 100680492);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, 100680493);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr, 100680494);
				}

				// Token: 0x06011E0D RID: 73229 RVA: 0x004170A8 File Offset: 0x004152A8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E0E RID: 73230 RVA: 0x004170F0 File Offset: 0x004152F0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E0F RID: 73231 RVA: 0x00417124 File Offset: 0x00415324
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210280, XrefRangeEnd = 210294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D34 RID: 23860
				// (get) Token: 0x06011E10 RID: 73232 RVA: 0x00417160 File Offset: 0x00415360
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E11 RID: 73233 RVA: 0x004171A0 File Offset: 0x004153A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210294, XrefRangeEnd = 210300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D35 RID: 23861
				// (get) Token: 0x06011E12 RID: 73234 RVA: 0x004171D4 File Offset: 0x004153D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E13 RID: 73235 RVA: 0x0009B4A0 File Offset: 0x000996A0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D2E RID: 23854
				// (get) Token: 0x06011E14 RID: 73236 RVA: 0x00417214 File Offset: 0x00415414
				// (set) Token: 0x06011E15 RID: 73237 RVA: 0x0009B4A9 File Offset: 0x000996A9
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D2F RID: 23855
				// (get) Token: 0x06011E16 RID: 73238 RVA: 0x0041723C File Offset: 0x0041543C
				// (set) Token: 0x06011E17 RID: 73239 RVA: 0x0009B4C4 File Offset: 0x000996C4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D30 RID: 23856
				// (get) Token: 0x06011E18 RID: 73240 RVA: 0x0041726C File Offset: 0x0041546C
				// (set) Token: 0x06011E19 RID: 73241 RVA: 0x0009B4E3 File Offset: 0x000996E3
				public unsafe Spell_Yuuka.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D31 RID: 23857
				// (get) Token: 0x06011E1A RID: 73242 RVA: 0x0041729C File Offset: 0x0041549C
				// (set) Token: 0x06011E1B RID: 73243 RVA: 0x0009B502 File Offset: 0x00099702
				public unsafe GameObject thisFlower
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr_thisFlower);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr_thisFlower), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D32 RID: 23858
				// (get) Token: 0x06011E1C RID: 73244 RVA: 0x004172CC File Offset: 0x004154CC
				// (set) Token: 0x06011E1D RID: 73245 RVA: 0x0009B521 File Offset: 0x00099721
				public unsafe WaitForSeconds _wait1_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr__wait1_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr__wait1_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D33 RID: 23859
				// (get) Token: 0x06011E1E RID: 73246 RVA: 0x004172FC File Offset: 0x004154FC
				// (set) Token: 0x06011E1F RID: 73247 RVA: 0x0009B540 File Offset: 0x00099740
				public unsafe WaitForSeconds _wait2_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr__wait2_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGathWaWaObObUnique.NativeFieldInfoPtr__wait2_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B4B3 RID: 46259
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4B4 RID: 46260
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B4B5 RID: 46261
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4B6 RID: 46262
				private static readonly IntPtr NativeFieldInfoPtr_thisFlower;

				// Token: 0x0400B4B7 RID: 46263
				private static readonly IntPtr NativeFieldInfoPtr__wait1_5__2;

				// Token: 0x0400B4B8 RID: 46264
				private static readonly IntPtr NativeFieldInfoPtr__wait2_5__3;

				// Token: 0x0400B4B9 RID: 46265
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B4BA RID: 46266
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4BB RID: 46267
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B4BC RID: 46268
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B4BD RID: 46269
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4BE RID: 46270
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001057 RID: 4183
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass35_0+<<OnPositiveBuffExecute>g__SpawnSunFlower|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011E20 RID: 73248 RVA: 0x0041732C File Offset: 0x0041552C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__SpawnSunFlower|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__sunFlower_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<sunFlower>5__2");
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680495);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680496);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680497);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680498);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680499);
					Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100680500);
				}

				// Token: 0x06011E21 RID: 73249 RVA: 0x00417420 File Offset: 0x00415620
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E22 RID: 73250 RVA: 0x00417468 File Offset: 0x00415668
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E23 RID: 73251 RVA: 0x0041749C File Offset: 0x0041569C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210300, XrefRangeEnd = 210372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D3A RID: 23866
				// (get) Token: 0x06011E24 RID: 73252 RVA: 0x004174D8 File Offset: 0x004156D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E25 RID: 73253 RVA: 0x00417518 File Offset: 0x00415718
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210372, XrefRangeEnd = 210378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D3B RID: 23867
				// (get) Token: 0x06011E26 RID: 73254 RVA: 0x0041754C File Offset: 0x0041574C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E27 RID: 73255 RVA: 0x0009B55F File Offset: 0x0009975F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D36 RID: 23862
				// (get) Token: 0x06011E28 RID: 73256 RVA: 0x0041758C File Offset: 0x0041578C
				// (set) Token: 0x06011E29 RID: 73257 RVA: 0x0009B568 File Offset: 0x00099768
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D37 RID: 23863
				// (get) Token: 0x06011E2A RID: 73258 RVA: 0x004175B4 File Offset: 0x004157B4
				// (set) Token: 0x06011E2B RID: 73259 RVA: 0x0009B583 File Offset: 0x00099783
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D38 RID: 23864
				// (get) Token: 0x06011E2C RID: 73260 RVA: 0x004175E4 File Offset: 0x004157E4
				// (set) Token: 0x06011E2D RID: 73261 RVA: 0x0009B5A2 File Offset: 0x000997A2
				public unsafe Spell_Yuuka.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D39 RID: 23865
				// (get) Token: 0x06011E2E RID: 73262 RVA: 0x00417614 File Offset: 0x00415814
				// (set) Token: 0x06011E2F RID: 73263 RVA: 0x0009B5C1 File Offset: 0x000997C1
				public unsafe GameObject _sunFlower_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__sunFlower_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__sunFlower_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B4BF RID: 46271
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4C0 RID: 46272
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B4C1 RID: 46273
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4C2 RID: 46274
				private static readonly IntPtr NativeFieldInfoPtr__sunFlower_5__2;

				// Token: 0x0400B4C3 RID: 46275
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B4C4 RID: 46276
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4C5 RID: 46277
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B4C6 RID: 46278
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B4C7 RID: 46279
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4C8 RID: 46280
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C36 RID: 3126
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<OnPositiveBuffExecute>d__35")]
		public sealed class _OnPositiveBuffExecute_d__35 : Il2CppSystem.Object
		{
			// Token: 0x0600E249 RID: 57929 RVA: 0x003689D8 File Offset: 0x00366BD8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__35()
			{
				Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<OnPositiveBuffExecute>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr);
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, "<>1__state");
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, "<>2__current");
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, "<>4__this");
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, "spellExecutionContext");
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, 100680501);
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, 100680502);
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, 100680503);
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, 100680504);
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, 100680505);
				Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr, 100680506);
			}

			// Token: 0x0600E24A RID: 57930 RVA: 0x00368ACC File Offset: 0x00366CCC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__35(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka._OnPositiveBuffExecute_d__35>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E24B RID: 57931 RVA: 0x00368B14 File Offset: 0x00366D14
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E24C RID: 57932 RVA: 0x00368B48 File Offset: 0x00366D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210416, XrefRangeEnd = 210420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700497C RID: 18812
			// (get) Token: 0x0600E24D RID: 57933 RVA: 0x00368B84 File Offset: 0x00366D84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E24E RID: 57934 RVA: 0x00368BC4 File Offset: 0x00366DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210420, XrefRangeEnd = 210426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700497D RID: 18813
			// (get) Token: 0x0600E24F RID: 57935 RVA: 0x00368BF8 File Offset: 0x00366DF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E250 RID: 57936 RVA: 0x00078B70 File Offset: 0x00076D70
			public _OnPositiveBuffExecute_d__35(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004978 RID: 18808
			// (get) Token: 0x0600E251 RID: 57937 RVA: 0x00368C38 File Offset: 0x00366E38
			// (set) Token: 0x0600E252 RID: 57938 RVA: 0x00078B79 File Offset: 0x00076D79
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004979 RID: 18809
			// (get) Token: 0x0600E253 RID: 57939 RVA: 0x00368C60 File Offset: 0x00366E60
			// (set) Token: 0x0600E254 RID: 57940 RVA: 0x00078B94 File Offset: 0x00076D94
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700497A RID: 18810
			// (get) Token: 0x0600E255 RID: 57941 RVA: 0x00368C90 File Offset: 0x00366E90
			// (set) Token: 0x0600E256 RID: 57942 RVA: 0x00078BB3 File Offset: 0x00076DB3
			public unsafe Spell_Yuuka __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700497B RID: 18811
			// (get) Token: 0x0600E257 RID: 57943 RVA: 0x00368CC0 File Offset: 0x00366EC0
			// (set) Token: 0x0600E258 RID: 57944 RVA: 0x00078BD2 File Offset: 0x00076DD2
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka._OnPositiveBuffExecute_d__35.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090B0 RID: 37040
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090B1 RID: 37041
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090B2 RID: 37042
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090B3 RID: 37043
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040090B4 RID: 37044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090B5 RID: 37045
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090B6 RID: 37046
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090B7 RID: 37047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090B8 RID: 37048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090B9 RID: 37049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C37 RID: 3127
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E259 RID: 57945 RVA: 0x00368CF0 File Offset: 0x00366EF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr);
				Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr_targetFlower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, "targetFlower");
				Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, "<>9__2");
				Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, "<>9__3");
				Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, 100680507);
				Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__FlowerBlossom_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, 100680508);
				Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__FlowerBlossom_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, 100680509);
				Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__FlowerBlossom_b__3_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, 100680510);
				Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr, 100680511);
			}

			// Token: 0x0600E25A RID: 57946 RVA: 0x00368DD0 File Offset: 0x00366FD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E25B RID: 57947 RVA: 0x00368E0C File Offset: 0x0036700C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210426, XrefRangeEnd = 210442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FlowerBlossom_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__FlowerBlossom_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E25C RID: 57948 RVA: 0x00368E4C File Offset: 0x0036704C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210442, XrefRangeEnd = 210448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FlowerBlossom_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__FlowerBlossom_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E25D RID: 57949 RVA: 0x00368E80 File Offset: 0x00367080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210448, XrefRangeEnd = 210456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FlowerBlossom_b__3(int num, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr__FlowerBlossom_b__3_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E25E RID: 57950 RVA: 0x00368ED8 File Offset: 0x003670D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210456, XrefRangeEnd = 210458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E25F RID: 57951 RVA: 0x00078BF1 File Offset: 0x00076DF1
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700497E RID: 18814
			// (get) Token: 0x0600E260 RID: 57952 RVA: 0x00368F0C File Offset: 0x0036710C
			// (set) Token: 0x0600E261 RID: 57953 RVA: 0x00078BFA File Offset: 0x00076DFA
			public unsafe Spell_Yuuka __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuuka>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700497F RID: 18815
			// (get) Token: 0x0600E262 RID: 57954 RVA: 0x00368F3C File Offset: 0x0036713C
			// (set) Token: 0x0600E263 RID: 57955 RVA: 0x00078C19 File Offset: 0x00076E19
			public unsafe GameObject targetFlower
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr_targetFlower);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr_targetFlower), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004980 RID: 18816
			// (get) Token: 0x0600E264 RID: 57956 RVA: 0x00368F6C File Offset: 0x0036716C
			// (set) Token: 0x0600E265 RID: 57957 RVA: 0x00078C38 File Offset: 0x00076E38
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004981 RID: 18817
			// (get) Token: 0x0600E266 RID: 57958 RVA: 0x00368F9C File Offset: 0x0036719C
			// (set) Token: 0x0600E267 RID: 57959 RVA: 0x00078C57 File Offset: 0x00076E57
			public unsafe Func<int, string, string> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass38_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090BA RID: 37050
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090BB RID: 37051
			private static readonly IntPtr NativeFieldInfoPtr_targetFlower;

			// Token: 0x040090BC RID: 37052
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040090BD RID: 37053
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040090BE RID: 37054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090BF RID: 37055
			private static readonly IntPtr NativeMethodInfoPtr__FlowerBlossom_b__0_Internal_Void_Int32_0;

			// Token: 0x040090C0 RID: 37056
			private static readonly IntPtr NativeMethodInfoPtr__FlowerBlossom_b__2_Internal_Void_0;

			// Token: 0x040090C1 RID: 37057
			private static readonly IntPtr NativeMethodInfoPtr__FlowerBlossom_b__3_Internal_String_Int32_String_0;

			// Token: 0x040090C2 RID: 37058
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000C38 RID: 3128
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuuka+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E268 RID: 57960 RVA: 0x00368FCC File Offset: 0x003671CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuuka>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass39_0>.NativeClassPtr);
				Spell_Yuuka.__c__DisplayClass39_0.NativeFieldInfoPtr_targetFlower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass39_0>.NativeClassPtr, "targetFlower");
				Spell_Yuuka.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass39_0>.NativeClassPtr, 100680512);
				Spell_Yuuka.__c__DisplayClass39_0.NativeMethodInfoPtr__Wither_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass39_0>.NativeClassPtr, 100680513);
			}

			// Token: 0x0600E269 RID: 57961 RVA: 0x00369034 File Offset: 0x00367234
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuuka.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E26A RID: 57962 RVA: 0x00369070 File Offset: 0x00367270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210458, XrefRangeEnd = 210462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Wither_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuuka.__c__DisplayClass39_0.NativeMethodInfoPtr__Wither_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E26B RID: 57963 RVA: 0x00078C76 File Offset: 0x00076E76
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004982 RID: 18818
			// (get) Token: 0x0600E26C RID: 57964 RVA: 0x003690A4 File Offset: 0x003672A4
			// (set) Token: 0x0600E26D RID: 57965 RVA: 0x00078C7F File Offset: 0x00076E7F
			public unsafe GameObject targetFlower
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass39_0.NativeFieldInfoPtr_targetFlower);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuuka.__c__DisplayClass39_0.NativeFieldInfoPtr_targetFlower), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090C3 RID: 37059
			private static readonly IntPtr NativeFieldInfoPtr_targetFlower;

			// Token: 0x040090C4 RID: 37060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090C5 RID: 37061
			private static readonly IntPtr NativeMethodInfoPtr__Wither_b__0_Internal_Void_0;
		}
	}
}
