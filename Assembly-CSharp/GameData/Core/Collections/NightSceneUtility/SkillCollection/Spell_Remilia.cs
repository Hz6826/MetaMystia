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
	// Token: 0x0200027D RID: 637
	public class Spell_Remilia : SpellBase
	{
		// Token: 0x06005044 RID: 20548 RVA: 0x001B0634 File Offset: 0x001AE834
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Remilia()
		{
			Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Remilia");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr);
			Spell_Remilia.NativeFieldInfoPtr_SAKUYA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "SAKUYA_ID");
			Spell_Remilia.NativeFieldInfoPtr_REMILIA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "REMILIA_ID");
			Spell_Remilia.NativeFieldInfoPtr_YOUSEI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "YOUSEI_ID");
			Spell_Remilia.NativeFieldInfoPtr_REMILIA_POSITIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "REMILIA_POSITIVE");
			Spell_Remilia.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "positiveDuration");
			Spell_Remilia.NativeFieldInfoPtr_extraSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "extraSpawnRate");
			Spell_Remilia.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "negativeDuration");
			Spell_Remilia.NativeFieldInfoPtr_extraPartnerWorkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "extraPartnerWorkSpeed");
			Spell_Remilia.NativeFieldInfoPtr_extraMinNGuestFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "extraMinNGuestFund");
			Spell_Remilia.NativeFieldInfoPtr_extraOrderRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "extraOrderRate");
			Spell_Remilia.NativeFieldInfoPtr_gangnirVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "gangnirVFX");
			Spell_Remilia.NativeFieldInfoPtr_gangnirTrailVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "gangnirTrailVFX");
			Spell_Remilia.NativeFieldInfoPtr_bloodSmokeVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "bloodSmokeVFX");
			Spell_Remilia.NativeFieldInfoPtr_bloodSmokeSpawnWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "bloodSmokeSpawnWait");
			Spell_Remilia.NativeFieldInfoPtr_redNightVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "redNightVFX");
			Spell_Remilia.NativeFieldInfoPtr_redNightVFXDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "redNightVFXDuration");
			Spell_Remilia.NativeFieldInfoPtr_rewardVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "rewardVFX");
			Spell_Remilia.NativeFieldInfoPtr_rewardMagicVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "rewardMagicVFX");
			Spell_Remilia.NativeFieldInfoPtr_rewardVFXDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "rewardVFXDuration");
			Spell_Remilia.NativeFieldInfoPtr_rewardVFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "rewardVFXOffset");
			Spell_Remilia.NativeFieldInfoPtr_rewardMagicOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "rewardMagicOffset");
			Spell_Remilia.NativeFieldInfoPtr_gungnirSpawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "gungnirSpawnSfx");
			Spell_Remilia.NativeFieldInfoPtr_gungnirExplodeSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "gungnirExplodeSfx");
			Spell_Remilia.NativeFieldInfoPtr_magicStoneSpawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "magicStoneSpawnSfx");
			Spell_Remilia.NativeFieldInfoPtr_magicStoneReleaseSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "magicStoneReleaseSfx");
			Spell_Remilia.NativeFieldInfoPtr_redEternalNightSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "redEternalNightSfx");
			Spell_Remilia.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679436);
			Spell_Remilia.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679437);
			Spell_Remilia.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679438);
			Spell_Remilia.NativeMethodInfoPtr_OnNightEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679439);
			Spell_Remilia.NativeMethodInfoPtr_SetGuestFund_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679440);
			Spell_Remilia.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679441);
			Spell_Remilia.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, 100679442);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x001B08F8 File Offset: 0x001AEAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202611, XrefRangeEnd = 202613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Remilia.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x001B093C File Offset: 0x001AEB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202613, XrefRangeEnd = 202618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Remilia.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x001B0998 File Offset: 0x001AEB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202618, XrefRangeEnd = 202624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Remilia.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x001B09F4 File Offset: 0x001AEBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202733, RefRangeEnd = 202734, XrefRangeStart = 202624, XrefRangeEnd = 202733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNightEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.NativeMethodInfoPtr_OnNightEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x001B0A28 File Offset: 0x001AEC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202734, XrefRangeEnd = 202735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGuestFund(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.NativeMethodInfoPtr_SetGuestFund_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x001B0A6C File Offset: 0x001AEC6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Remilia() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x001B0AA8 File Offset: 0x001AECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202735, XrefRangeEnd = 202749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__28_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x0002A7BD File Offset: 0x000289BD
		public Spell_Remilia(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x0600504D RID: 20557 RVA: 0x001B0ADC File Offset: 0x001AECDC
		// (set) Token: 0x0600504E RID: 20558 RVA: 0x0002A7C6 File Offset: 0x000289C6
		public unsafe static int SAKUYA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.NativeFieldInfoPtr_SAKUYA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.NativeFieldInfoPtr_SAKUYA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x001B0AF8 File Offset: 0x001AECF8
		// (set) Token: 0x06005050 RID: 20560 RVA: 0x0002A7D4 File Offset: 0x000289D4
		public unsafe static int REMILIA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.NativeFieldInfoPtr_REMILIA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.NativeFieldInfoPtr_REMILIA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x001B0B14 File Offset: 0x001AED14
		// (set) Token: 0x06005052 RID: 20562 RVA: 0x0002A7E2 File Offset: 0x000289E2
		public unsafe static int YOUSEI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.NativeFieldInfoPtr_YOUSEI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.NativeFieldInfoPtr_YOUSEI_ID, (void*)(&value));
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x001B0B30 File Offset: 0x001AED30
		// (set) Token: 0x06005054 RID: 20564 RVA: 0x0002A7F0 File Offset: 0x000289F0
		public unsafe static string REMILIA_POSITIVE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.NativeFieldInfoPtr_REMILIA_POSITIVE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.NativeFieldInfoPtr_REMILIA_POSITIVE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x001B0B50 File Offset: 0x001AED50
		// (set) Token: 0x06005056 RID: 20566 RVA: 0x0002A802 File Offset: 0x00028A02
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x001B0B78 File Offset: 0x001AED78
		// (set) Token: 0x06005058 RID: 20568 RVA: 0x0002A81D File Offset: 0x00028A1D
		public unsafe float extraSpawnRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraSpawnRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraSpawnRate)) = value;
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x001B0BA0 File Offset: 0x001AEDA0
		// (set) Token: 0x0600505A RID: 20570 RVA: 0x0002A838 File Offset: 0x00028A38
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x0600505B RID: 20571 RVA: 0x001B0BC8 File Offset: 0x001AEDC8
		// (set) Token: 0x0600505C RID: 20572 RVA: 0x0002A853 File Offset: 0x00028A53
		public unsafe float extraPartnerWorkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraPartnerWorkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraPartnerWorkSpeed)) = value;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x0600505D RID: 20573 RVA: 0x001B0BF0 File Offset: 0x001AEDF0
		// (set) Token: 0x0600505E RID: 20574 RVA: 0x0002A86E File Offset: 0x00028A6E
		public unsafe int extraMinNGuestFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraMinNGuestFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraMinNGuestFund)) = value;
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x0600505F RID: 20575 RVA: 0x001B0C18 File Offset: 0x001AEE18
		// (set) Token: 0x06005060 RID: 20576 RVA: 0x0002A889 File Offset: 0x00028A89
		public unsafe float extraOrderRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraOrderRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_extraOrderRate)) = value;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x001B0C40 File Offset: 0x001AEE40
		// (set) Token: 0x06005062 RID: 20578 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		public unsafe GameObject gangnirVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gangnirVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gangnirVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x001B0C70 File Offset: 0x001AEE70
		// (set) Token: 0x06005064 RID: 20580 RVA: 0x0002A8C3 File Offset: 0x00028AC3
		public unsafe GameObject gangnirTrailVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gangnirTrailVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gangnirTrailVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06005065 RID: 20581 RVA: 0x001B0CA0 File Offset: 0x001AEEA0
		// (set) Token: 0x06005066 RID: 20582 RVA: 0x0002A8E2 File Offset: 0x00028AE2
		public unsafe GameObject bloodSmokeVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_bloodSmokeVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_bloodSmokeVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x001B0CD0 File Offset: 0x001AEED0
		// (set) Token: 0x06005068 RID: 20584 RVA: 0x0002A901 File Offset: 0x00028B01
		public unsafe float bloodSmokeSpawnWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_bloodSmokeSpawnWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_bloodSmokeSpawnWait)) = value;
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06005069 RID: 20585 RVA: 0x001B0CF8 File Offset: 0x001AEEF8
		// (set) Token: 0x0600506A RID: 20586 RVA: 0x0002A91C File Offset: 0x00028B1C
		public unsafe GameObject redNightVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_redNightVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_redNightVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x0600506B RID: 20587 RVA: 0x001B0D28 File Offset: 0x001AEF28
		// (set) Token: 0x0600506C RID: 20588 RVA: 0x0002A93B File Offset: 0x00028B3B
		public unsafe float redNightVFXDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_redNightVFXDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_redNightVFXDuration)) = value;
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x0600506D RID: 20589 RVA: 0x001B0D50 File Offset: 0x001AEF50
		// (set) Token: 0x0600506E RID: 20590 RVA: 0x0002A956 File Offset: 0x00028B56
		public unsafe GameObject rewardVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x0600506F RID: 20591 RVA: 0x001B0D80 File Offset: 0x001AEF80
		// (set) Token: 0x06005070 RID: 20592 RVA: 0x0002A975 File Offset: 0x00028B75
		public unsafe GameObject rewardMagicVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardMagicVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardMagicVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06005071 RID: 20593 RVA: 0x001B0DB0 File Offset: 0x001AEFB0
		// (set) Token: 0x06005072 RID: 20594 RVA: 0x0002A994 File Offset: 0x00028B94
		public unsafe float rewardVFXDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardVFXDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardVFXDuration)) = value;
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06005073 RID: 20595 RVA: 0x001B0DD8 File Offset: 0x001AEFD8
		// (set) Token: 0x06005074 RID: 20596 RVA: 0x0002A9AF File Offset: 0x00028BAF
		public unsafe float rewardVFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardVFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardVFXOffset)) = value;
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x001B0E00 File Offset: 0x001AF000
		// (set) Token: 0x06005076 RID: 20598 RVA: 0x0002A9CA File Offset: 0x00028BCA
		public unsafe float rewardMagicOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardMagicOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_rewardMagicOffset)) = value;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x001B0E28 File Offset: 0x001AF028
		// (set) Token: 0x06005078 RID: 20600 RVA: 0x0002A9E5 File Offset: 0x00028BE5
		public SpellBase.DelayAudioClip gungnirSpawnSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gungnirSpawnSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gungnirSpawnSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06005079 RID: 20601 RVA: 0x001B0E58 File Offset: 0x001AF058
		// (set) Token: 0x0600507A RID: 20602 RVA: 0x0002AA13 File Offset: 0x00028C13
		public SpellBase.DelayAudioClip gungnirExplodeSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gungnirExplodeSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_gungnirExplodeSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x0600507B RID: 20603 RVA: 0x001B0E88 File Offset: 0x001AF088
		// (set) Token: 0x0600507C RID: 20604 RVA: 0x0002AA41 File Offset: 0x00028C41
		public SpellBase.DelayAudioClip magicStoneSpawnSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_magicStoneSpawnSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_magicStoneSpawnSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x001B0EB8 File Offset: 0x001AF0B8
		// (set) Token: 0x0600507E RID: 20606 RVA: 0x0002AA6F File Offset: 0x00028C6F
		public SpellBase.DelayAudioClip magicStoneReleaseSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_magicStoneReleaseSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_magicStoneReleaseSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x001B0EE8 File Offset: 0x001AF0E8
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x0002AA9D File Offset: 0x00028C9D
		public SpellBase.DelayAudioClip redEternalNightSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_redEternalNightSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.NativeFieldInfoPtr_redEternalNightSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400365F RID: 13919
		private static readonly IntPtr NativeFieldInfoPtr_SAKUYA_ID;

		// Token: 0x04003660 RID: 13920
		private static readonly IntPtr NativeFieldInfoPtr_REMILIA_ID;

		// Token: 0x04003661 RID: 13921
		private static readonly IntPtr NativeFieldInfoPtr_YOUSEI_ID;

		// Token: 0x04003662 RID: 13922
		private static readonly IntPtr NativeFieldInfoPtr_REMILIA_POSITIVE;

		// Token: 0x04003663 RID: 13923
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003664 RID: 13924
		private static readonly IntPtr NativeFieldInfoPtr_extraSpawnRate;

		// Token: 0x04003665 RID: 13925
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003666 RID: 13926
		private static readonly IntPtr NativeFieldInfoPtr_extraPartnerWorkSpeed;

		// Token: 0x04003667 RID: 13927
		private static readonly IntPtr NativeFieldInfoPtr_extraMinNGuestFund;

		// Token: 0x04003668 RID: 13928
		private static readonly IntPtr NativeFieldInfoPtr_extraOrderRate;

		// Token: 0x04003669 RID: 13929
		private static readonly IntPtr NativeFieldInfoPtr_gangnirVFX;

		// Token: 0x0400366A RID: 13930
		private static readonly IntPtr NativeFieldInfoPtr_gangnirTrailVFX;

		// Token: 0x0400366B RID: 13931
		private static readonly IntPtr NativeFieldInfoPtr_bloodSmokeVFX;

		// Token: 0x0400366C RID: 13932
		private static readonly IntPtr NativeFieldInfoPtr_bloodSmokeSpawnWait;

		// Token: 0x0400366D RID: 13933
		private static readonly IntPtr NativeFieldInfoPtr_redNightVFX;

		// Token: 0x0400366E RID: 13934
		private static readonly IntPtr NativeFieldInfoPtr_redNightVFXDuration;

		// Token: 0x0400366F RID: 13935
		private static readonly IntPtr NativeFieldInfoPtr_rewardVFX;

		// Token: 0x04003670 RID: 13936
		private static readonly IntPtr NativeFieldInfoPtr_rewardMagicVFX;

		// Token: 0x04003671 RID: 13937
		private static readonly IntPtr NativeFieldInfoPtr_rewardVFXDuration;

		// Token: 0x04003672 RID: 13938
		private static readonly IntPtr NativeFieldInfoPtr_rewardVFXOffset;

		// Token: 0x04003673 RID: 13939
		private static readonly IntPtr NativeFieldInfoPtr_rewardMagicOffset;

		// Token: 0x04003674 RID: 13940
		private static readonly IntPtr NativeFieldInfoPtr_gungnirSpawnSfx;

		// Token: 0x04003675 RID: 13941
		private static readonly IntPtr NativeFieldInfoPtr_gungnirExplodeSfx;

		// Token: 0x04003676 RID: 13942
		private static readonly IntPtr NativeFieldInfoPtr_magicStoneSpawnSfx;

		// Token: 0x04003677 RID: 13943
		private static readonly IntPtr NativeFieldInfoPtr_magicStoneReleaseSfx;

		// Token: 0x04003678 RID: 13944
		private static readonly IntPtr NativeFieldInfoPtr_redEternalNightSfx;

		// Token: 0x04003679 RID: 13945
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400367A RID: 13946
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400367B RID: 13947
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400367C RID: 13948
		private static readonly IntPtr NativeMethodInfoPtr_OnNightEnd_Private_Void_0;

		// Token: 0x0400367D RID: 13949
		private static readonly IntPtr NativeMethodInfoPtr_SetGuestFund_Private_Void_GuestGroupController_0;

		// Token: 0x0400367E RID: 13950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400367F RID: 13951
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_1_Private_Void_0;

		// Token: 0x02000B9F RID: 2975
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA0A RID: 55818 RVA: 0x0034FCC8 File Offset: 0x0034DEC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass27_0>.NativeClassPtr);
				Spell_Remilia.__c__DisplayClass27_0.NativeFieldInfoPtr_smoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass27_0>.NativeClassPtr, "smoke");
				Spell_Remilia.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass27_0>.NativeClassPtr, 100679443);
				Spell_Remilia.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass27_0>.NativeClassPtr, 100679444);
			}

			// Token: 0x0600DA0B RID: 55819 RVA: 0x0034FD30 File Offset: 0x0034DF30
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA0C RID: 55820 RVA: 0x0034FD6C File Offset: 0x0034DF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202350, XrefRangeEnd = 202359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA0D RID: 55821 RVA: 0x00074A38 File Offset: 0x00072C38
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046E9 RID: 18153
			// (get) Token: 0x0600DA0E RID: 55822 RVA: 0x0034FDA0 File Offset: 0x0034DFA0
			// (set) Token: 0x0600DA0F RID: 55823 RVA: 0x00074A41 File Offset: 0x00072C41
			public unsafe GameObject smoke
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass27_0.NativeFieldInfoPtr_smoke);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass27_0.NativeFieldInfoPtr_smoke), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BBC RID: 35772
			private static readonly IntPtr NativeFieldInfoPtr_smoke;

			// Token: 0x04008BBD RID: 35773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BBE RID: 35774
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000BA0 RID: 2976
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<OnNegativeBuffExecute>d__27")]
		public sealed class _OnNegativeBuffExecute_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600DA10 RID: 55824 RVA: 0x0034FDD0 File Offset: 0x0034DFD0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__27()
			{
				Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<OnNegativeBuffExecute>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr);
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>1__state");
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>2__current");
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>4__this");
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>8__1");
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100679445);
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100679446);
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100679447);
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100679448);
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100679449);
				Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100679450);
			}

			// Token: 0x0600DA11 RID: 55825 RVA: 0x0034FEC4 File Offset: 0x0034E0C4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia._OnNegativeBuffExecute_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA12 RID: 55826 RVA: 0x0034FF0C File Offset: 0x0034E10C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA13 RID: 55827 RVA: 0x0034FF40 File Offset: 0x0034E140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202359, XrefRangeEnd = 202383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046EE RID: 18158
			// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x0034FF7C File Offset: 0x0034E17C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA15 RID: 55829 RVA: 0x0034FFBC File Offset: 0x0034E1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202383, XrefRangeEnd = 202389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046EF RID: 18159
			// (get) Token: 0x0600DA16 RID: 55830 RVA: 0x0034FFF0 File Offset: 0x0034E1F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA17 RID: 55831 RVA: 0x00074A60 File Offset: 0x00072C60
			public _OnNegativeBuffExecute_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046EA RID: 18154
			// (get) Token: 0x0600DA18 RID: 55832 RVA: 0x00350030 File Offset: 0x0034E230
			// (set) Token: 0x0600DA19 RID: 55833 RVA: 0x00074A69 File Offset: 0x00072C69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046EB RID: 18155
			// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x00350058 File Offset: 0x0034E258
			// (set) Token: 0x0600DA1B RID: 55835 RVA: 0x00074A84 File Offset: 0x00072C84
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046EC RID: 18156
			// (get) Token: 0x0600DA1C RID: 55836 RVA: 0x00350088 File Offset: 0x0034E288
			// (set) Token: 0x0600DA1D RID: 55837 RVA: 0x00074AA3 File Offset: 0x00072CA3
			public unsafe Spell_Remilia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046ED RID: 18157
			// (get) Token: 0x0600DA1E RID: 55838 RVA: 0x003500B8 File Offset: 0x0034E2B8
			// (set) Token: 0x0600DA1F RID: 55839 RVA: 0x00074AC2 File Offset: 0x00072CC2
			public unsafe Spell_Remilia.__c__DisplayClass27_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BBF RID: 35775
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BC0 RID: 35776
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BC1 RID: 35777
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BC2 RID: 35778
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008BC3 RID: 35779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BC4 RID: 35780
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BC5 RID: 35781
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BC6 RID: 35782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BC7 RID: 35783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BC8 RID: 35784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA1 RID: 2977
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA20 RID: 55840 RVA: 0x003500E8 File Offset: 0x0034E2E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr);
				Spell_Remilia.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, "<>9");
				Spell_Remilia.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, "<>9__28_0");
				Spell_Remilia.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, "<>9__29_0");
				Spell_Remilia.__c.NativeFieldInfoPtr___9__29_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, "<>9__29_6");
				Spell_Remilia.__c.NativeFieldInfoPtr___9__29_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, "<>9__29_13");
				Spell_Remilia.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, 100679452);
				Spell_Remilia.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, 100679453);
				Spell_Remilia.__c.NativeMethodInfoPtr__OnNightEnd_b__29_0_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, 100679454);
				Spell_Remilia.__c.NativeMethodInfoPtr__OnNightEnd_b__29_6_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, 100679455);
				Spell_Remilia.__c.NativeMethodInfoPtr__OnNightEnd_b__29_13_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr, 100679456);
			}

			// Token: 0x0600DA21 RID: 55841 RVA: 0x003501DC File Offset: 0x0034E3DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA22 RID: 55842 RVA: 0x00350218 File Offset: 0x0034E418
			[CallerCount(0)]
			public unsafe string _OnPositiveBuffExecute_b__28_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DA23 RID: 55843 RVA: 0x00350260 File Offset: 0x0034E460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202389, XrefRangeEnd = 202392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNightEnd_b__29_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c.NativeMethodInfoPtr__OnNightEnd_b__29_0_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA24 RID: 55844 RVA: 0x003502B0 File Offset: 0x0034E4B0
			[CallerCount(0)]
			public unsafe bool _OnNightEnd_b__29_6(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c.NativeMethodInfoPtr__OnNightEnd_b__29_6_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA25 RID: 55845 RVA: 0x00350300 File Offset: 0x0034E500
			[CallerCount(0)]
			public unsafe bool _OnNightEnd_b__29_13(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c.NativeMethodInfoPtr__OnNightEnd_b__29_13_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA26 RID: 55846 RVA: 0x00074AE1 File Offset: 0x00072CE1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046F0 RID: 18160
			// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x00350350 File Offset: 0x0034E550
			// (set) Token: 0x0600DA28 RID: 55848 RVA: 0x00074AEA File Offset: 0x00072CEA
			public unsafe static Spell_Remilia.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046F1 RID: 18161
			// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x00350378 File Offset: 0x0034E578
			// (set) Token: 0x0600DA2A RID: 55850 RVA: 0x00074AFC File Offset: 0x00072CFC
			public unsafe static Func<string, string> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046F2 RID: 18162
			// (get) Token: 0x0600DA2B RID: 55851 RVA: 0x003503A0 File Offset: 0x0034E5A0
			// (set) Token: 0x0600DA2C RID: 55852 RVA: 0x00074B0E File Offset: 0x00072D0E
			public unsafe static Func<GuestGroupController, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046F3 RID: 18163
			// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x003503C8 File Offset: 0x0034E5C8
			// (set) Token: 0x0600DA2E RID: 55854 RVA: 0x00074B20 File Offset: 0x00072D20
			public unsafe static Func<GuestGroupController, bool> __9__29_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__29_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__29_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046F4 RID: 18164
			// (get) Token: 0x0600DA2F RID: 55855 RVA: 0x003503F0 File Offset: 0x0034E5F0
			// (set) Token: 0x0600DA30 RID: 55856 RVA: 0x00074B32 File Offset: 0x00072D32
			public unsafe static Func<GuestGroupController, bool> __9__29_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__29_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Remilia.__c.NativeFieldInfoPtr___9__29_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BC9 RID: 35785
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BCA RID: 35786
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04008BCB RID: 35787
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04008BCC RID: 35788
			private static readonly IntPtr NativeFieldInfoPtr___9__29_6;

			// Token: 0x04008BCD RID: 35789
			private static readonly IntPtr NativeFieldInfoPtr___9__29_13;

			// Token: 0x04008BCE RID: 35790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BCF RID: 35791
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_0_Internal_String_String_0;

			// Token: 0x04008BD0 RID: 35792
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__29_0_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008BD1 RID: 35793
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__29_6_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04008BD2 RID: 35794
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__29_13_Internal_Boolean_GuestGroupController_0;
		}

		// Token: 0x02000BA2 RID: 2978
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<OnPositiveBuffExecute>d__28")]
		public sealed class _OnPositiveBuffExecute_d__28 : Il2CppSystem.Object
		{
			// Token: 0x0600DA31 RID: 55857 RVA: 0x00350418 File Offset: 0x0034E618
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__28()
			{
				Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<OnPositiveBuffExecute>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr);
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>1__state");
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>2__current");
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>4__this");
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, "spellExecutionContext");
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679457);
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679458);
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679459);
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679460);
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679461);
				Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100679462);
			}

			// Token: 0x0600DA32 RID: 55858 RVA: 0x0035050C File Offset: 0x0034E70C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__28(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia._OnPositiveBuffExecute_d__28>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA33 RID: 55859 RVA: 0x00350554 File Offset: 0x0034E754
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA34 RID: 55860 RVA: 0x00350588 File Offset: 0x0034E788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202392, XrefRangeEnd = 202411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046F9 RID: 18169
			// (get) Token: 0x0600DA35 RID: 55861 RVA: 0x003505C4 File Offset: 0x0034E7C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA36 RID: 55862 RVA: 0x00350604 File Offset: 0x0034E804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202411, XrefRangeEnd = 202417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046FA RID: 18170
			// (get) Token: 0x0600DA37 RID: 55863 RVA: 0x00350638 File Offset: 0x0034E838
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA38 RID: 55864 RVA: 0x00074B44 File Offset: 0x00072D44
			public _OnPositiveBuffExecute_d__28(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046F5 RID: 18165
			// (get) Token: 0x0600DA39 RID: 55865 RVA: 0x00350678 File Offset: 0x0034E878
			// (set) Token: 0x0600DA3A RID: 55866 RVA: 0x00074B4D File Offset: 0x00072D4D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046F6 RID: 18166
			// (get) Token: 0x0600DA3B RID: 55867 RVA: 0x003506A0 File Offset: 0x0034E8A0
			// (set) Token: 0x0600DA3C RID: 55868 RVA: 0x00074B68 File Offset: 0x00072D68
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046F7 RID: 18167
			// (get) Token: 0x0600DA3D RID: 55869 RVA: 0x003506D0 File Offset: 0x0034E8D0
			// (set) Token: 0x0600DA3E RID: 55870 RVA: 0x00074B87 File Offset: 0x00072D87
			public unsafe Spell_Remilia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046F8 RID: 18168
			// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x00350700 File Offset: 0x0034E900
			// (set) Token: 0x0600DA40 RID: 55872 RVA: 0x00074BA6 File Offset: 0x00072DA6
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BD3 RID: 35795
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BD4 RID: 35796
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BD5 RID: 35797
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BD6 RID: 35798
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008BD7 RID: 35799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BD8 RID: 35800
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BD9 RID: 35801
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BDA RID: 35802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BDB RID: 35803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BDC RID: 35804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA3 RID: 2979
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA41 RID: 55873 RVA: 0x00350730 File Offset: 0x0034E930
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr);
				Spell_Remilia.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				Spell_Remilia.__c__DisplayClass29_0.NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, "interrupt");
				Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, 100679463);
				Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, 100679464);
				Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNightEnd_b__3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, 100679465);
				Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, 100679466);
			}

			// Token: 0x0600DA42 RID: 55874 RVA: 0x003507D4 File Offset: 0x0034E9D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA43 RID: 55875 RVA: 0x00350810 File Offset: 0x0034EA10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202442, XrefRangeEnd = 202447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DA44 RID: 55876 RVA: 0x00350850 File Offset: 0x0034EA50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202447, XrefRangeEnd = 202461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNightEnd_b__3(string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr__OnNightEnd_b__3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DA45 RID: 55877 RVA: 0x00350898 File Offset: 0x0034EA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202461, XrefRangeEnd = 202475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA46 RID: 55878 RVA: 0x00074BC5 File Offset: 0x00072DC5
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046FB RID: 18171
			// (get) Token: 0x0600DA47 RID: 55879 RVA: 0x003508CC File Offset: 0x0034EACC
			// (set) Token: 0x0600DA48 RID: 55880 RVA: 0x00074BCE File Offset: 0x00072DCE
			public unsafe Spell_Remilia __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046FC RID: 18172
			// (get) Token: 0x0600DA49 RID: 55881 RVA: 0x003508FC File Offset: 0x0034EAFC
			// (set) Token: 0x0600DA4A RID: 55882 RVA: 0x00074BED File Offset: 0x00072DED
			public unsafe Action interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.NativeFieldInfoPtr_interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.NativeFieldInfoPtr_interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BDD RID: 35805
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BDE RID: 35806
			private static readonly IntPtr NativeFieldInfoPtr_interrupt;

			// Token: 0x04008BDF RID: 35807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BE0 RID: 35808
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008BE1 RID: 35809
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__3_Internal_String_String_0;

			// Token: 0x04008BE2 RID: 35810
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0200103C RID: 4156
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c__DisplayClass29_0+<<OnNightEnd>g__CloseVfx|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011C70 RID: 72816 RVA: 0x0041200C File Offset: 0x0041020C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0>.NativeClassPtr, "<<OnNightEnd>g__CloseVfx|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr);
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__stop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, "<stop>5__2");
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__shouldStopTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, "<shouldStopTime>5__3");
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__redNight_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, "<redNight>5__4");
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, 100679467);
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, 100679468);
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, 100679469);
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, 100679470);
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, 100679471);
					Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr, 100679472);
				}

				// Token: 0x06011C71 RID: 72817 RVA: 0x00412128 File Offset: 0x00410328
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C72 RID: 72818 RVA: 0x00412170 File Offset: 0x00410370
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011C73 RID: 72819 RVA: 0x004121A4 File Offset: 0x004103A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202417, XrefRangeEnd = 202436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C9A RID: 23706
				// (get) Token: 0x06011C74 RID: 72820 RVA: 0x004121E0 File Offset: 0x004103E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C75 RID: 72821 RVA: 0x00412220 File Offset: 0x00410420
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202436, XrefRangeEnd = 202442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C9B RID: 23707
				// (get) Token: 0x06011C76 RID: 72822 RVA: 0x00412254 File Offset: 0x00410454
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011C77 RID: 72823 RVA: 0x0009A7F8 File Offset: 0x000989F8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C94 RID: 23700
				// (get) Token: 0x06011C78 RID: 72824 RVA: 0x00412294 File Offset: 0x00410494
				// (set) Token: 0x06011C79 RID: 72825 RVA: 0x0009A801 File Offset: 0x00098A01
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C95 RID: 23701
				// (get) Token: 0x06011C7A RID: 72826 RVA: 0x004122BC File Offset: 0x004104BC
				// (set) Token: 0x06011C7B RID: 72827 RVA: 0x0009A81C File Offset: 0x00098A1C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C96 RID: 23702
				// (get) Token: 0x06011C7C RID: 72828 RVA: 0x004122EC File Offset: 0x004104EC
				// (set) Token: 0x06011C7D RID: 72829 RVA: 0x0009A83B File Offset: 0x00098A3B
				public unsafe Spell_Remilia.__c__DisplayClass29_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia.__c__DisplayClass29_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C97 RID: 23703
				// (get) Token: 0x06011C7E RID: 72830 RVA: 0x0041231C File Offset: 0x0041051C
				// (set) Token: 0x06011C7F RID: 72831 RVA: 0x0009A85A File Offset: 0x00098A5A
				public unsafe bool _stop_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__stop_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__stop_5__2)) = value;
					}
				}

				// Token: 0x17005C98 RID: 23704
				// (get) Token: 0x06011C80 RID: 72832 RVA: 0x00412344 File Offset: 0x00410544
				// (set) Token: 0x06011C81 RID: 72833 RVA: 0x0009A875 File Offset: 0x00098A75
				public unsafe float _shouldStopTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__shouldStopTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__shouldStopTime_5__3)) = value;
					}
				}

				// Token: 0x17005C99 RID: 23705
				// (get) Token: 0x06011C82 RID: 72834 RVA: 0x0041236C File Offset: 0x0041056C
				// (set) Token: 0x06011C83 RID: 72835 RVA: 0x0009A890 File Offset: 0x00098A90
				public unsafe GameObject _redNight_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__redNight_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiGaObObUnique.NativeFieldInfoPtr__redNight_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B3B1 RID: 46001
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3B2 RID: 46002
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3B3 RID: 46003
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3B4 RID: 46004
				private static readonly IntPtr NativeFieldInfoPtr__stop_5__2;

				// Token: 0x0400B3B5 RID: 46005
				private static readonly IntPtr NativeFieldInfoPtr__shouldStopTime_5__3;

				// Token: 0x0400B3B6 RID: 46006
				private static readonly IntPtr NativeFieldInfoPtr__redNight_5__4;

				// Token: 0x0400B3B7 RID: 46007
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3B8 RID: 46008
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3B9 RID: 46009
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3BA RID: 46010
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3BB RID: 46011
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3BC RID: 46012
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BA4 RID: 2980
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DA4B RID: 55883 RVA: 0x0035092C File Offset: 0x0034EB2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr);
				Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_interruptSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr, "interruptSpawn");
				Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_buffInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr, "buffInterrupt");
				Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Remilia.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr, 100679473);
				Spell_Remilia.__c__DisplayClass29_1.NativeMethodInfoPtr__OnNightEnd_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr, 100679474);
				Spell_Remilia.__c__DisplayClass29_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr, 100679475);
			}

			// Token: 0x0600DA4C RID: 55884 RVA: 0x003509D0 File Offset: 0x0034EBD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4D RID: 55885 RVA: 0x00350A0C File Offset: 0x0034EC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202475, XrefRangeEnd = 202476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNightEnd_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_1.NativeMethodInfoPtr__OnNightEnd_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4E RID: 55886 RVA: 0x00350A40 File Offset: 0x0034EC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202476, XrefRangeEnd = 202480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4F RID: 55887 RVA: 0x00074C0C File Offset: 0x00072E0C
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046FD RID: 18173
			// (get) Token: 0x0600DA50 RID: 55888 RVA: 0x00350A74 File Offset: 0x0034EC74
			// (set) Token: 0x0600DA51 RID: 55889 RVA: 0x00074C15 File Offset: 0x00072E15
			public unsafe Action interruptSpawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_interruptSpawn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_interruptSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046FE RID: 18174
			// (get) Token: 0x0600DA52 RID: 55890 RVA: 0x00350AA4 File Offset: 0x0034ECA4
			// (set) Token: 0x0600DA53 RID: 55891 RVA: 0x00074C34 File Offset: 0x00072E34
			public unsafe Action buffInterrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_buffInterrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_buffInterrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046FF RID: 18175
			// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x00350AD4 File Offset: 0x0034ECD4
			// (set) Token: 0x0600DA55 RID: 55893 RVA: 0x00074C53 File Offset: 0x00072E53
			public unsafe Spell_Remilia.__c__DisplayClass29_0 field_Public___c__DisplayClass29_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia.__c__DisplayClass29_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_1.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BE3 RID: 35811
			private static readonly IntPtr NativeFieldInfoPtr_interruptSpawn;

			// Token: 0x04008BE4 RID: 35812
			private static readonly IntPtr NativeFieldInfoPtr_buffInterrupt;

			// Token: 0x04008BE5 RID: 35813
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0;

			// Token: 0x04008BE6 RID: 35814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BE7 RID: 35815
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__4_Internal_Void_0;

			// Token: 0x04008BE8 RID: 35816
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000BA5 RID: 2981
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c__DisplayClass29_2")]
		public sealed class __c__DisplayClass29_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DA56 RID: 55894 RVA: 0x00350B04 File Offset: 0x0034ED04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_2()
			{
				Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<>c__DisplayClass29_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr);
				Spell_Remilia.__c__DisplayClass29_2.NativeFieldInfoPtr_isEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, "isEnd");
				Spell_Remilia.__c__DisplayClass29_2.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, "CS$<>8__locals2");
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679476);
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr__OnNightEnd_b__7_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679477);
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679478);
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr__OnNightEnd_b__12_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679479);
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679480);
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679481);
				Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr, 100679482);
			}

			// Token: 0x0600DA57 RID: 55895 RVA: 0x00350BE4 File Offset: 0x0034EDE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA58 RID: 55896 RVA: 0x00350C20 File Offset: 0x0034EE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202480, XrefRangeEnd = 202490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNightEnd_b__7(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr__OnNightEnd_b__7_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA59 RID: 55897 RVA: 0x00350C64 File Offset: 0x0034EE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202490, XrefRangeEnd = 202510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5A RID: 55898 RVA: 0x00350C98 File Offset: 0x0034EE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202510, XrefRangeEnd = 202520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNightEnd_b__12(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr__OnNightEnd_b__12_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5B RID: 55899 RVA: 0x00350CDC File Offset: 0x0034EEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202520, XrefRangeEnd = 202530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5C RID: 55900 RVA: 0x00350D20 File Offset: 0x0034EF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202530, XrefRangeEnd = 202580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_1(GuestGroupController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5D RID: 55901 RVA: 0x00350D64 File Offset: 0x0034EF64
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 202604, RefRangeEnd = 202606, XrefRangeStart = 202580, XrefRangeEnd = 202604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_2.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5E RID: 55902 RVA: 0x00074C72 File Offset: 0x00072E72
			public __c__DisplayClass29_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004700 RID: 18176
			// (get) Token: 0x0600DA5F RID: 55903 RVA: 0x00350D98 File Offset: 0x0034EF98
			// (set) Token: 0x0600DA60 RID: 55904 RVA: 0x00074C7B File Offset: 0x00072E7B
			public unsafe bool isEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_2.NativeFieldInfoPtr_isEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_2.NativeFieldInfoPtr_isEnd)) = value;
				}
			}

			// Token: 0x17004701 RID: 18177
			// (get) Token: 0x0600DA61 RID: 55905 RVA: 0x00350DC0 File Offset: 0x0034EFC0
			// (set) Token: 0x0600DA62 RID: 55906 RVA: 0x00074C96 File Offset: 0x00072E96
			public unsafe Spell_Remilia.__c__DisplayClass29_0 field_Public___c__DisplayClass29_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_2.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia.__c__DisplayClass29_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_2.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BE9 RID: 35817
			private static readonly IntPtr NativeFieldInfoPtr_isEnd;

			// Token: 0x04008BEA RID: 35818
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0;

			// Token: 0x04008BEB RID: 35819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BEC RID: 35820
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__7_Internal_Void_GuestGroupController_0;

			// Token: 0x04008BED RID: 35821
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008BEE RID: 35822
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__12_Internal_Void_GuestGroupController_0;

			// Token: 0x04008BEF RID: 35823
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04008BF0 RID: 35824
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1;

			// Token: 0x04008BF1 RID: 35825
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000BA6 RID: 2982
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Remilia+<>c__DisplayClass29_3")]
		public sealed class __c__DisplayClass29_3 : Il2CppSystem.Object
		{
			// Token: 0x0600DA63 RID: 55907 RVA: 0x00350DF0 File Offset: 0x0034EFF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_3()
			{
				Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Remilia>.NativeClassPtr, "<>c__DisplayClass29_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr);
				Spell_Remilia.__c__DisplayClass29_3.NativeFieldInfoPtr_interruptSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr, "interruptSpawn");
				Spell_Remilia.__c__DisplayClass29_3.NativeFieldInfoPtr_field_Public___c__DisplayClass29_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr, "CS$<>8__locals3");
				Spell_Remilia.__c__DisplayClass29_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr, 100679483);
				Spell_Remilia.__c__DisplayClass29_3.NativeMethodInfoPtr__OnNightEnd_b__14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr, 100679484);
			}

			// Token: 0x0600DA64 RID: 55908 RVA: 0x00350E6C File Offset: 0x0034F06C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Remilia.__c__DisplayClass29_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA65 RID: 55909 RVA: 0x00350EA8 File Offset: 0x0034F0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202606, XrefRangeEnd = 202611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNightEnd_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Remilia.__c__DisplayClass29_3.NativeMethodInfoPtr__OnNightEnd_b__14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA66 RID: 55910 RVA: 0x00074CB5 File Offset: 0x00072EB5
			public __c__DisplayClass29_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004702 RID: 18178
			// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x00350EDC File Offset: 0x0034F0DC
			// (set) Token: 0x0600DA68 RID: 55912 RVA: 0x00074CBE File Offset: 0x00072EBE
			public unsafe Action interruptSpawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_3.NativeFieldInfoPtr_interruptSpawn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_3.NativeFieldInfoPtr_interruptSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004703 RID: 18179
			// (get) Token: 0x0600DA69 RID: 55913 RVA: 0x00350F0C File Offset: 0x0034F10C
			// (set) Token: 0x0600DA6A RID: 55914 RVA: 0x00074CDD File Offset: 0x00072EDD
			public unsafe Spell_Remilia.__c__DisplayClass29_2 field_Public___c__DisplayClass29_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_3.NativeFieldInfoPtr_field_Public___c__DisplayClass29_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Remilia.__c__DisplayClass29_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Remilia.__c__DisplayClass29_3.NativeFieldInfoPtr_field_Public___c__DisplayClass29_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BF2 RID: 35826
			private static readonly IntPtr NativeFieldInfoPtr_interruptSpawn;

			// Token: 0x04008BF3 RID: 35827
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_2_0;

			// Token: 0x04008BF4 RID: 35828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BF5 RID: 35829
			private static readonly IntPtr NativeMethodInfoPtr__OnNightEnd_b__14_Internal_Void_0;
		}
	}
}
