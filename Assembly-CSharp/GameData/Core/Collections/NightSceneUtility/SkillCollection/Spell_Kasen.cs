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
	// Token: 0x02000267 RID: 615
	public class Spell_Kasen : SpellBase
	{
		// Token: 0x06004C32 RID: 19506 RVA: 0x001A6768 File Offset: 0x001A4968
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Kasen()
		{
			Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Kasen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr);
			Spell_Kasen.NativeFieldInfoPtr_tipAmountMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "tipAmountMin");
			Spell_Kasen.NativeFieldInfoPtr_tipAmountMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "tipAmountMax");
			Spell_Kasen.NativeFieldInfoPtr_payIntervalMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "payIntervalMin");
			Spell_Kasen.NativeFieldInfoPtr_payIntervalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "payIntervalMax");
			Spell_Kasen.NativeFieldInfoPtr_increaseNumIfBuffExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "increaseNumIfBuffExist");
			Spell_Kasen.NativeFieldInfoPtr_durationNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "durationNum");
			Spell_Kasen.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "negativeDuration");
			Spell_Kasen.NativeFieldInfoPtr_rewardEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "rewardEffectDuration");
			Spell_Kasen.NativeFieldInfoPtr_punishmentEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "punishmentEffectDuration");
			Spell_Kasen.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "launchHeight");
			Spell_Kasen.NativeFieldInfoPtr_rewardTigerEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "rewardTigerEffect");
			Spell_Kasen.NativeFieldInfoPtr_punishmentEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "punishmentEffect");
			Spell_Kasen.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "punishmentSFX");
			Spell_Kasen.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678635);
			Spell_Kasen.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678636);
			Spell_Kasen.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678637);
			Spell_Kasen.NativeMethodInfoPtr_KasenOverrideOrderGeneration_Private_OrderBase_GuestGroupController_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678638);
			Spell_Kasen.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678639);
			Spell_Kasen.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678640);
			Spell_Kasen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678641);
			Spell_Kasen.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, 100678642);
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x001A693C File Offset: 0x001A4B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196658, XrefRangeEnd = 196660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kasen.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x001A6980 File Offset: 0x001A4B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196660, XrefRangeEnd = 196665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kasen.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x001A69DC File Offset: 0x001A4BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196665, XrefRangeEnd = 196676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawn(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x001A6A20 File Offset: 0x001A4C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196676, XrefRangeEnd = 196707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestsManager.OrderBase KasenOverrideOrderGeneration(GuestGroupController guestGroup, out string orderGenerationMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.NativeMethodInfoPtr_KasenOverrideOrderGeneration_Private_OrderBase_GuestGroupController_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x001A6A8C File Offset: 0x001A4C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196707, XrefRangeEnd = 196744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x001A6AC0 File Offset: 0x001A4CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196744, XrefRangeEnd = 196750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kasen.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x001A6B1C File Offset: 0x001A4D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Kasen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x001A6B58 File Offset: 0x001A4D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196750, XrefRangeEnd = 196761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNegativeBuffExecute_b__14_0(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x0002755A File Offset: 0x0002575A
		public Spell_Kasen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x001A6B9C File Offset: 0x001A4D9C
		// (set) Token: 0x06004C3D RID: 19517 RVA: 0x00027563 File Offset: 0x00025763
		public unsafe int tipAmountMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_tipAmountMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_tipAmountMin)) = value;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x001A6BC4 File Offset: 0x001A4DC4
		// (set) Token: 0x06004C3F RID: 19519 RVA: 0x0002757E File Offset: 0x0002577E
		public unsafe int tipAmountMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_tipAmountMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_tipAmountMax)) = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x001A6BEC File Offset: 0x001A4DEC
		// (set) Token: 0x06004C41 RID: 19521 RVA: 0x00027599 File Offset: 0x00025799
		public unsafe int payIntervalMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_payIntervalMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_payIntervalMin)) = value;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x001A6C14 File Offset: 0x001A4E14
		// (set) Token: 0x06004C43 RID: 19523 RVA: 0x000275B4 File Offset: 0x000257B4
		public unsafe int payIntervalMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_payIntervalMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_payIntervalMax)) = value;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x001A6C3C File Offset: 0x001A4E3C
		// (set) Token: 0x06004C45 RID: 19525 RVA: 0x000275CF File Offset: 0x000257CF
		public unsafe int increaseNumIfBuffExist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_increaseNumIfBuffExist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_increaseNumIfBuffExist)) = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x001A6C64 File Offset: 0x001A4E64
		// (set) Token: 0x06004C47 RID: 19527 RVA: 0x000275EA File Offset: 0x000257EA
		public unsafe int durationNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_durationNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_durationNum)) = value;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x001A6C8C File Offset: 0x001A4E8C
		// (set) Token: 0x06004C49 RID: 19529 RVA: 0x00027605 File Offset: 0x00025805
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x001A6CB4 File Offset: 0x001A4EB4
		// (set) Token: 0x06004C4B RID: 19531 RVA: 0x00027620 File Offset: 0x00025820
		public unsafe int rewardEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_rewardEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_rewardEffectDuration)) = value;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x001A6CDC File Offset: 0x001A4EDC
		// (set) Token: 0x06004C4D RID: 19533 RVA: 0x0002763B File Offset: 0x0002583B
		public unsafe float punishmentEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_punishmentEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_punishmentEffectDuration)) = value;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x001A6D04 File Offset: 0x001A4F04
		// (set) Token: 0x06004C4F RID: 19535 RVA: 0x00027656 File Offset: 0x00025856
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x001A6D2C File Offset: 0x001A4F2C
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x00027671 File Offset: 0x00025871
		public unsafe GameObject rewardTigerEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_rewardTigerEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_rewardTigerEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x001A6D5C File Offset: 0x001A4F5C
		// (set) Token: 0x06004C53 RID: 19539 RVA: 0x00027690 File Offset: 0x00025890
		public unsafe GameObject punishmentEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_punishmentEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_punishmentEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x001A6D8C File Offset: 0x001A4F8C
		// (set) Token: 0x06004C55 RID: 19541 RVA: 0x000276AF File Offset: 0x000258AF
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeFieldInfoPtr_tipAmountMin;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeFieldInfoPtr_tipAmountMax;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeFieldInfoPtr_payIntervalMin;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeFieldInfoPtr_payIntervalMax;

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeFieldInfoPtr_increaseNumIfBuffExist;

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeFieldInfoPtr_durationNum;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeFieldInfoPtr_rewardEffectDuration;

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeFieldInfoPtr_punishmentEffectDuration;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeFieldInfoPtr_rewardTigerEffect;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeFieldInfoPtr_punishmentEffect;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400343A RID: 13370
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400343B RID: 13371
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x0400343C RID: 13372
		private static readonly IntPtr NativeMethodInfoPtr_KasenOverrideOrderGeneration_Private_OrderBase_GuestGroupController_byref_String_0;

		// Token: 0x0400343D RID: 13373
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Private_Void_0;

		// Token: 0x0400343E RID: 13374
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400343F RID: 13375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003440 RID: 13376
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Private_Void_GuestGroupController_0;

		// Token: 0x02000B29 RID: 2857
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kasen+<OnNegativeBuffExecute>d__14")]
		public sealed class _OnNegativeBuffExecute_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D395 RID: 54165 RVA: 0x0033C7F4 File Offset: 0x0033A9F4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__14()
			{
				Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "<OnNegativeBuffExecute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr);
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>1__state");
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>2__current");
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>4__this");
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678643);
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678644);
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678645);
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678646);
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678647);
				Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678648);
			}

			// Token: 0x0600D396 RID: 54166 RVA: 0x0033C8D4 File Offset: 0x0033AAD4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kasen._OnNegativeBuffExecute_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D397 RID: 54167 RVA: 0x0033C91C File Offset: 0x0033AB1C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D398 RID: 54168 RVA: 0x0033C950 File Offset: 0x0033AB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196524, XrefRangeEnd = 196557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044DD RID: 17629
			// (get) Token: 0x0600D399 RID: 54169 RVA: 0x0033C98C File Offset: 0x0033AB8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D39A RID: 54170 RVA: 0x0033C9CC File Offset: 0x0033ABCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196557, XrefRangeEnd = 196563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044DE RID: 17630
			// (get) Token: 0x0600D39B RID: 54171 RVA: 0x0033CA00 File Offset: 0x0033AC00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D39C RID: 54172 RVA: 0x000714F5 File Offset: 0x0006F6F5
			public _OnNegativeBuffExecute_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044DA RID: 17626
			// (get) Token: 0x0600D39D RID: 54173 RVA: 0x0033CA40 File Offset: 0x0033AC40
			// (set) Token: 0x0600D39E RID: 54174 RVA: 0x000714FE File Offset: 0x0006F6FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044DB RID: 17627
			// (get) Token: 0x0600D39F RID: 54175 RVA: 0x0033CA68 File Offset: 0x0033AC68
			// (set) Token: 0x0600D3A0 RID: 54176 RVA: 0x00071519 File Offset: 0x0006F719
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044DC RID: 17628
			// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x0033CA98 File Offset: 0x0033AC98
			// (set) Token: 0x0600D3A2 RID: 54178 RVA: 0x00071538 File Offset: 0x0006F738
			public unsafe Spell_Kasen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kasen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087D4 RID: 34772
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087D5 RID: 34773
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087D6 RID: 34774
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087D7 RID: 34775
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087D8 RID: 34776
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087D9 RID: 34777
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087DA RID: 34778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087DB RID: 34779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087DC RID: 34780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B2A RID: 2858
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kasen+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3A3 RID: 54179 RVA: 0x0033CAC8 File Offset: 0x0033ACC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr);
				Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_tiger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, "tiger");
				Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, "targetPosition");
				Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, 100678649);
				Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, 100678650);
				Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, 100678651);
				Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, 100678652);
				Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, 100678653);
				Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr, 100678654);
			}

			// Token: 0x0600D3A4 RID: 54180 RVA: 0x0033CBBC File Offset: 0x0033ADBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kasen.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A5 RID: 54181 RVA: 0x0033CBF8 File Offset: 0x0033ADF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196563, XrefRangeEnd = 196584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A6 RID: 54182 RVA: 0x0033CC2C File Offset: 0x0033AE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196584, XrefRangeEnd = 196588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A7 RID: 54183 RVA: 0x0033CC60 File Offset: 0x0033AE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196588, XrefRangeEnd = 196604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A8 RID: 54184 RVA: 0x0033CCA0 File Offset: 0x0033AEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196604, XrefRangeEnd = 196616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A9 RID: 54185 RVA: 0x0033CCE0 File Offset: 0x0033AEE0
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen.__c__DisplayClass18_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3AA RID: 54186 RVA: 0x00071557 File Offset: 0x0006F757
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044DF RID: 17631
			// (get) Token: 0x0600D3AB RID: 54187 RVA: 0x0033CD1C File Offset: 0x0033AF1C
			// (set) Token: 0x0600D3AC RID: 54188 RVA: 0x00071560 File Offset: 0x0006F760
			public unsafe GameObject tiger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_tiger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_tiger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E0 RID: 17632
			// (get) Token: 0x0600D3AD RID: 54189 RVA: 0x0033CD4C File Offset: 0x0033AF4C
			// (set) Token: 0x0600D3AE RID: 54190 RVA: 0x0007157F File Offset: 0x0006F77F
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E1 RID: 17633
			// (get) Token: 0x0600D3AF RID: 54191 RVA: 0x0033CD7C File Offset: 0x0033AF7C
			// (set) Token: 0x0600D3B0 RID: 54192 RVA: 0x0007159E File Offset: 0x0006F79E
			public unsafe Spell_Kasen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kasen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E2 RID: 17634
			// (get) Token: 0x0600D3B1 RID: 54193 RVA: 0x0033CDAC File Offset: 0x0033AFAC
			// (set) Token: 0x0600D3B2 RID: 54194 RVA: 0x000715BD File Offset: 0x0006F7BD
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen.__c__DisplayClass18_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x040087DD RID: 34781
			private static readonly IntPtr NativeFieldInfoPtr_tiger;

			// Token: 0x040087DE RID: 34782
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040087DF RID: 34783
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087E0 RID: 34784
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040087E1 RID: 34785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087E2 RID: 34786
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040087E3 RID: 34787
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_0;

			// Token: 0x040087E4 RID: 34788
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0;

			// Token: 0x040087E5 RID: 34789
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0;

			// Token: 0x040087E6 RID: 34790
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000B2B RID: 2859
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kasen+<OnPositiveBuffExecute>d__18")]
		public sealed class _OnPositiveBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D3B3 RID: 54195 RVA: 0x0033CDD4 File Offset: 0x0033AFD4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kasen>.NativeClassPtr, "<OnPositiveBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr);
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, "spellExecutionContext");
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678655);
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678656);
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678657);
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678658);
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678659);
				Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr, 100678660);
			}

			// Token: 0x0600D3B4 RID: 54196 RVA: 0x0033CEC8 File Offset: 0x0033B0C8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kasen._OnPositiveBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3B5 RID: 54197 RVA: 0x0033CF10 File Offset: 0x0033B110
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3B6 RID: 54198 RVA: 0x0033CF44 File Offset: 0x0033B144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196616, XrefRangeEnd = 196652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044E7 RID: 17639
			// (get) Token: 0x0600D3B7 RID: 54199 RVA: 0x0033CF80 File Offset: 0x0033B180
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3B8 RID: 54200 RVA: 0x0033CFC0 File Offset: 0x0033B1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196652, XrefRangeEnd = 196658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044E8 RID: 17640
			// (get) Token: 0x0600D3B9 RID: 54201 RVA: 0x0033CFF4 File Offset: 0x0033B1F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3BA RID: 54202 RVA: 0x000715D8 File Offset: 0x0006F7D8
			public _OnPositiveBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E3 RID: 17635
			// (get) Token: 0x0600D3BB RID: 54203 RVA: 0x0033D034 File Offset: 0x0033B234
			// (set) Token: 0x0600D3BC RID: 54204 RVA: 0x000715E1 File Offset: 0x0006F7E1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044E4 RID: 17636
			// (get) Token: 0x0600D3BD RID: 54205 RVA: 0x0033D05C File Offset: 0x0033B25C
			// (set) Token: 0x0600D3BE RID: 54206 RVA: 0x000715FC File Offset: 0x0006F7FC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E5 RID: 17637
			// (get) Token: 0x0600D3BF RID: 54207 RVA: 0x0033D08C File Offset: 0x0033B28C
			// (set) Token: 0x0600D3C0 RID: 54208 RVA: 0x0007161B File Offset: 0x0006F81B
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E6 RID: 17638
			// (get) Token: 0x0600D3C1 RID: 54209 RVA: 0x0033D0BC File Offset: 0x0033B2BC
			// (set) Token: 0x0600D3C2 RID: 54210 RVA: 0x0007163A File Offset: 0x0006F83A
			public unsafe Spell_Kasen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kasen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kasen._OnPositiveBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087E7 RID: 34791
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087E8 RID: 34792
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087E9 RID: 34793
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040087EA RID: 34794
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087EB RID: 34795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087EC RID: 34796
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087ED RID: 34797
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087EE RID: 34798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087EF RID: 34799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087F0 RID: 34800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
